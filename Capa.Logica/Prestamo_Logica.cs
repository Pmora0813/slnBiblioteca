using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml;
using System.Xml.Xsl;


namespace Capa.Logica
{
    
    public class Prestamo_Logica
    {
        public string Ruta
        {
            get { return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Prestamos.xml"; }
        }
       
        public void guardar(Prestamo prestamo)
        {
            if (String.IsNullOrWhiteSpace(prestamo.id.ToString()))
            {
                throw new ApplicationException("El Codigo es requerido");
            }
            Datos.Prestamo_Datos datos = new Datos.Prestamo_Datos();
            if (datos.SeleccionarPorID(prestamo.id) == null)
                datos.Insertar(prestamo);
            else
                datos.Actualizar(prestamo);
        }

        public List<Prestamo> SeleccionarTodos()
        {
            Datos.Prestamo_Datos datos = new Datos.Prestamo_Datos();
            return datos.SeleccionarTodos();
        }
        public Prestamo SeleccionarPrestamoPorId(int Id)
        {
            Datos.Prestamo_Datos datos = new Datos.Prestamo_Datos();
            return datos.SeleccionarPorID(Id);
        }

        public void Eliminar(int Id)
        {
            Datos.Prestamo_Datos datos = new Datos.Prestamo_Datos();
            datos.Eliminar(Id);
        }
        public DateTime ObtenerFecha()
        {
            try
            {
                var myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");
                var response = myHttpWebRequest.GetResponse();

                string[] dt = response.Headers.GetValues("Date");
                DateTime t = Convert.ToDateTime(dt[0]);

                if (t == null)
                {
                    t = DateTime.Now;
                }
                return t;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void GuardarXML(Prestamo prestamo, string Ruta)
        {

            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<Prestamos></Prestamos>");

            XmlElement root = doc.DocumentElement;

            //--INICIO NODO PRESTAMO
            XmlElement NodoPrestamo = doc.CreateElement("Prestamo");
            //--          
            XmlElement NodoCodigo = doc.CreateElement("Codigo");
            NodoCodigo.InnerText = prestamo.id.ToString();
            NodoPrestamo.AppendChild(NodoCodigo);
            //--
            //--
            XmlElement NodoFecha_Emision = doc.CreateElement("Fecha_Emision");
            NodoFecha_Emision.InnerText = prestamo.Fecha_Act.ToString();
            NodoPrestamo.AppendChild(NodoFecha_Emision);
            //--
            //--
            XmlElement NodoFecha_Devolucion = doc.CreateElement("Fecha_Devolucion");
            NodoFecha_Devolucion.InnerText = prestamo.Fecha_Dev.ToString();
            NodoPrestamo.AppendChild(NodoFecha_Devolucion);
            //--
            //--
            XmlElement NodoDias_Prestamo = doc.CreateElement("Dias_Prestamo");
            NodoDias_Prestamo.InnerText = prestamo.dias.ToString();
            NodoPrestamo.AppendChild(NodoDias_Prestamo);
            //-- 

            //--INICIO NODO USUARIO AUTORIZADO
            XmlElement NodoUsuario = doc.CreateElement("Usuario_Autorizado");
            NodoUsuario.InnerText = prestamo.Usuario.id.ToString();
            NodoPrestamo.AppendChild(NodoUsuario);
            //--
            //--
            XmlElement NodoRoll = doc.CreateElement("Roll_Usuario");
            NodoRoll.InnerText = prestamo.Usuario.Rol.descripcion.ToString();
            NodoPrestamo.AppendChild(NodoRoll);
            //--FIN NODO USUARIO AUTORIZADO


            //--INICIO NODO ESTUDIANTE
            XmlElement NodoEstudiante = doc.CreateElement("Estudiante");
            //--
            XmlElement NodoCedula = doc.CreateElement("Cedula");
            NodoCedula.InnerText = prestamo.estudiant.IdCedula.ToString();
            NodoEstudiante.AppendChild(NodoCedula);
            //--
            //--
            XmlElement NodoNombre = doc.CreateElement("Nombre");
            NodoNombre.InnerText = prestamo.estudiant.Nombre.ToString();
            NodoEstudiante.AppendChild(NodoNombre);
            //--
            //--
            XmlElement NodoSeccion = doc.CreateElement("Seccion");
            NodoSeccion.InnerText = prestamo.estudiant.Seccion.ToString();
            NodoEstudiante.AppendChild(NodoSeccion);
            //--
            //--
            XmlElement NodoTelefono = doc.CreateElement("Telefono");
            NodoTelefono.InnerText = prestamo.estudiant.Telefono.ToString();
            NodoEstudiante.AppendChild(NodoTelefono);
            //--
            //--
            XmlElement NodoEmail = doc.CreateElement("Email");
            NodoEmail.InnerText = prestamo.estudiant.Email.ToString();
            NodoEstudiante.AppendChild(NodoEmail);
            //--FIN NODO ESTUDIANTE

            //--INICIO NODO LIBRO
            XmlElement NodoLibro = doc.CreateElement("Libro");
            //--
            XmlElement NodoCodigo_L = doc.CreateElement("Codigo");
           // NodoCodigo_L.InnerText = prestamo.Libro.Id.ToString();
            NodoLibro.AppendChild(NodoCodigo_L);
            //--
            //--
            XmlElement NodoTitulo = doc.CreateElement("Titulo");
            //NodoTitulo.InnerText = prestamo.Libro.Titulo.ToString();
            NodoLibro.AppendChild(NodoTitulo);
            //--
            //--
            XmlElement NodoAnno = doc.CreateElement("Año");
            //NodoAnno.InnerText = prestamo.Libro.anno.ToString();
            NodoLibro.AppendChild(NodoAnno);
            //--
            //--
            XmlElement NodoEditoial = doc.CreateElement("Editorial");
           // NodoEditoial.InnerText = prestamo.Libro.Editorial.Nombre.ToString();
            NodoLibro.AppendChild(NodoEditoial);
            //--CAT
            XmlElement NodoTipo_solicitud = doc.CreateElement("Tipo_Solicitud");
            NodoTipo_solicitud.InnerText = prestamo.Categoria.Descripcion.ToString();
            NodoLibro.AppendChild(NodoTipo_solicitud);
            //--
            //--FIN NODO LIBRO



            //--FIN NODO PRESTAMO

            root.AppendChild(NodoPrestamo);
            root.AppendChild(NodoEstudiante);
            root.AppendChild(NodoLibro);


            // Guardamos el Archivo XML
            doc.Save(Ruta);
        }

        public string TransformXMLToHTML(string rutaXML)
        {
            // Transformación del XMl utilizando XSLT
            XslCompiledTransform myXslTrans = new XslCompiledTransform();
            // Carga en memoria la lectura xslt
            myXslTrans.Load("Xslt\\Prestamos.xslt");
            // Transforma el archivo xml aun archivo HTML
            myXslTrans.Transform(rutaXML, "Prestamos_de_Libros.html");

            return "Prestamos_de_Libros.html";
        }

        public string PDF(string ruta)
        {
            return "";
        }

    }
}