using Capa.Entidades;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using PdfSharp.Charting;
using System;
using System.Collections;
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
            get { return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Comprobantes\\Prestamos"; }
        }
        public string RutaHtml
        {
            get { return "D:\\2018\\Proyecto C# 2018\\slnBiblioteca\\Capa.UI\\bin\\Debug\\Prestamos_de_Libros.html"; }
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
            DateTime t = new DateTime();
            try
            {
                var myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");
                var response = myHttpWebRequest.GetResponse();

                string[] dt = response.Headers.GetValues("Date");
                 t = Convert.ToDateTime(dt[0]);

            }
            catch (Exception)
            {
                t = DateTime.Now;
                //throw;
            }

            return t;
        }


        public void GuardarXML(Prestamo prestamo, string ruta)
        {
            List<Libros> lista = new Prestamo_Libros_Logica().SeleccionarTodos(prestamo.id);

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

            XmlElement NodoLibros = doc.CreateElement("Libros");
            foreach (Libros Libro in lista)
            {
                //--INICIO NODO LIBRO
                XmlElement NodoLibro = doc.CreateElement("Libro");
                //--
                XmlElement NodoCodigo_L = doc.CreateElement("Codigo");
                NodoCodigo_L.InnerText = Libro.Id.ToString();
                NodoLibro.AppendChild(NodoCodigo_L);
                //--
                //--
                XmlElement NodoTitulo = doc.CreateElement("Titulo");
                NodoTitulo.InnerText = Libro.Titulo.ToString();
                NodoLibro.AppendChild(NodoTitulo);
                //--
                //--
                XmlElement NodoAnno = doc.CreateElement("Año");
                NodoAnno.InnerText = Libro.anno.ToString();
                NodoLibro.AppendChild(NodoAnno);
                //--
                //--
                XmlElement NodoEditoial = doc.CreateElement("Editorial");
                NodoEditoial.InnerText = Libro.Editorial.Nombre.ToString();
                NodoLibro.AppendChild(NodoEditoial);
                //--
                //--FIN NODO LIBRO

                NodoLibros.AppendChild(NodoLibro);
            }

            //--CAT
            XmlElement NodoTipo_solicitud = doc.CreateElement("Tipo_Solicitud");
            NodoTipo_solicitud.InnerText = prestamo.Categoria.Descripcion.ToString();
            NodoLibros.AppendChild(NodoTipo_solicitud);
            //--

            //--FIN NODO PRESTAMO
            root.AppendChild(NodoPrestamo);
            root.AppendChild(NodoEstudiante);
            root.AppendChild(NodoLibros);


            // Guardamos el Archivo XML
            doc.Save(ruta);

        }

        public void CrearCarpeta()
        {
            string folderName = @"C:\Users\Pablo\Desktop\Comprobantes";
            string pathString = System.IO.Path.Combine(folderName);


            if (System.IO.Directory.Exists(pathString) != true)
            {
                System.IO.Directory.CreateDirectory(pathString);

            }
        }

        public string TransformXMLToHTML(string rutaXML,string html)
        {
            // Transformación del XMl utilizando XSLT
            XslCompiledTransform myXslTrans = new XslCompiledTransform();
            // Carga en memoria la lectura xslt
            myXslTrans.Load("Xslt\\Prestamos.xslt");
            // Transforma el archivo xml aun archivo HTML
            myXslTrans.Transform(rutaXML, RutaHtml);
            myXslTrans.Transform(rutaXML, html);

            return "Prestamos_de_Libros.html";
        }

        public void pdf(Prestamo prestamo)
        {
            var p = prestamo;
            // Creamos el documento con el tamaño de página tradicional
            Document doc = new Document(PageSize.LETTER);
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc,
                                        new FileStream(@"D:\prueba.pdf", FileMode.Create));

            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("Mi primer PDF");
            doc.AddCreator("Escuela Platanares");

            // Abrimos el archivo
            doc.Open();

            // Escribimos el encabezamiento en el documento
            doc.Add(new Paragraph("Comprobante"));
            doc.Add(Chunk.NEWLINE);

            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            // Creamos una tabla que contendrá el nombre, apellido y país 
            // de nuestros visitante.
            PdfPTable tblPrueba = new PdfPTable(1);
            tblPrueba.WidthPercentage = 100;

            //// Configuramos el título de las columnas de la tabla
            PdfPCell clNombre = new PdfPCell(new Phrase("Prestamo", _standardFont));
            clNombre.BorderWidth = 0;
            clNombre.BorderWidthBottom = 0.75f;

            //PdfPCell clApellido = new PdfPCell(new Phrase("Apellido", _standardFont));
            //clApellido.BorderWidth = 0;
            //clApellido.BorderWidthBottom = 0.75f;

            //PdfPCell clPais = new PdfPCell(new Phrase("País", _standardFont));
            //clPais.BorderWidth = 0;
            //clPais.BorderWidthBottom = 0.75f;

            //// Añadimos las celdas a la tabla
            //tblPrueba.AddCell(clNombre);
            //tblPrueba.AddCell(clApellido);
            //tblPrueba.AddCell(clPais);

            //// Llenamos la tabla con información
            clNombre = new PdfPCell(new Phrase(prestamo.ToString(), _standardFont));
            clNombre.BorderWidth = 0;

            //clApellido = new PdfPCell(new Phrase("Torres", _standardFont));
            //clApellido.BorderWidth = 0;

            //clPais = new PdfPCell(new Phrase("Puerto Rico", _standardFont));
            //clPais.BorderWidth = 0;

            //// Añadimos las celdas a la tabla
            tblPrueba.AddCell(clNombre);
            //tblPrueba.AddCell(clApellido);
            //tblPrueba.AddCell(clPais);

            //clNombre = new PdfPCell(new Phrase("Juan", _standardFont));
            //clNombre.BorderWidth = 0;

            //clApellido = new PdfPCell(new Phrase("Rodríguez", _standardFont));
            //clApellido.BorderWidth = 0;

            //clPais = new PdfPCell(new Phrase("México", _standardFont));
            //clPais.BorderWidth = 0;

            //tblPrueba.AddCell(clNombre);
            //tblPrueba.AddCell(clApellido);
            //tblPrueba.AddCell(clPais);
            tblPrueba.AddCell(prestamo.ToString());
            
            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblPrueba);

            doc.Close();
            writer.Close();

           // MessageBox.Show("¡PDF creado!");
        }


    }

}
