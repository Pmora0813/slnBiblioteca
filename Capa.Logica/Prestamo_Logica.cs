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
using System.Net.Mail;
using System.Xml;
using System.Xml.Xsl;


namespace Capa.Logica
{
    /// <summary>
    /// Clase encargada de hacer el 
    /// CRUD en la BD del Objeto PRESTAMO
    /// </summary>
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

        /// <summary>
        /// Metodo utilizado para optener la fecha
        /// de una pagina Web
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Metodo par aguardar un XML
        /// en una ruta determinada
        /// </summary>
        /// <param name="prestamo"></param>
        /// <param name="ruta"></param>
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
        /// <summary>
        /// Creamos una carpeta en el escritorio
        /// para guardar archivos definidos
        /// </summary>
        public void CrearCarpeta()
        {
            string folderName = @"C:\Users\Pablo\Desktop\Comprobantes";
            string pathString = System.IO.Path.Combine(folderName);


            if (System.IO.Directory.Exists(pathString) != true)
            {
                System.IO.Directory.CreateDirectory(pathString);

            }
        }
        /// <summary>
        /// transformar el xml en html 
        /// para mostrarlo 
        /// </summary>
        /// <param name="rutaXML"></param>
        /// <param name="html"></param>
        /// <returns></returns>
        public string TransformXMLToHTML(string rutaXML, string html)
        {
            // Transformación del XMl utilizando XSLT
            XslCompiledTransform myXslTrans = new XslCompiledTransform();
            // Carga en memoria la lectura xslt
            myXslTrans.Load("Xslt\\Prestamos.xslt");
            // Transforma el archivo xml aun archivo HTML
            myXslTrans.Transform(rutaXML, RutaHtml);
            //myXslTrans.Transform(rutaXML, html);

            return "Prestamos_de_Libros.html";
        }
        /// <summary>
        /// Guardar en Prestamos en pdf
        /// para tener en comprobante del
        /// prestamo
        /// </summary>
        /// <param name="prestamo"></param>
        public void pdf(Prestamo prestamo)
        {
            List<Libros> lista = new Prestamo_Libros_Logica().SeleccionarTodos(prestamo.id);
            //var p = prestamo;
            // Creamos el documento con el tamaño de página tradicional
            Document doc = new Document(PageSize.LETTER);

            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc,
                                        new FileStream(@"C:\Users\Pablo\Desktop\Comprobantes\Prestamo_" + prestamo.id + ".pdf", FileMode.Create));


            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("Prestamos de Libros");
            doc.AddCreator("Escuela Platanares");

            // Abrimos el archivo
            doc.Open();

            // Escribimos el encabezamiento en el documento
            doc.Add(new Paragraph("Prestamos de Libros"));
            doc.Add(Chunk.NEWLINE);


            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            // Creamos una tabla que contendrá el nombre, apellido y país 
            // de nuestros visitante.
            PdfPTable tblPrueba = new PdfPTable(1);
            tblPrueba.WidthPercentage = 25;

            //// Configuramos el título de las columnas de la tabla
            //--Inicio Prestamo
            PdfPCell clPrestamo = new PdfPCell(new Phrase("Informacion del Prestamo", _standardFont));
            clPrestamo.BorderWidth = 2;
            clPrestamo.HorizontalAlignment = 1;
            clPrestamo.BorderWidthBottom = 0.75f;
            tblPrueba.AddCell(clPrestamo);

            clPrestamo = new PdfPCell(new Phrase("Codido: " + prestamo.id.ToString(), _standardFont));
            clPrestamo.BorderWidth = 0;
            tblPrueba.AddCell(clPrestamo);

            clPrestamo = new PdfPCell(new Phrase("Fecha de Solicitud: " + prestamo.Fecha_Act.ToString("dd/mm/yyyy"), _standardFont));
            clPrestamo.BorderWidth = 0;
            tblPrueba.AddCell(clPrestamo);

            clPrestamo = new PdfPCell(new Phrase("Fecha de Devolución: " + prestamo.Fecha_Dev.ToString("dd/mm/yyyy"), _standardFont));
            clPrestamo.BorderWidth = 0;
            tblPrueba.AddCell(clPrestamo);

            clPrestamo = new PdfPCell(new Phrase("Días de Prestamo: " + prestamo.dias.ToString(), _standardFont));
            clPrestamo.BorderWidth = 0;
            tblPrueba.AddCell(clPrestamo);
            //--Fin Prestamo

            //--Inicio Usuario
            PdfPCell clUsuario = new PdfPCell(new Phrase("Usuario Autorizado", _standardFont));
            clUsuario.BorderWidth = 2;
            clUsuario.HorizontalAlignment = 1;
            clUsuario.BorderWidthBottom = 0.75f;

            tblPrueba.AddCell(clUsuario);

            clUsuario = new PdfPCell(new Phrase("Usuario: " + prestamo.Usuario.id.ToString(), _standardFont));
            clUsuario.BorderWidth = 0;
            tblPrueba.AddCell(clUsuario);

            clUsuario = new PdfPCell(new Phrase("Tipo: " + prestamo.Usuario.Rol.descripcion.ToString(), _standardFont));
            clUsuario.BorderWidth = 0;
            tblPrueba.AddCell(clUsuario);
            //--Fin Usuario

            //--Inicio Estudiante
            PdfPCell clEstudiante = new PdfPCell(new Phrase("Informacion del Estudiante", _standardFont));
            clEstudiante.BorderWidth = 2;
            clEstudiante.HorizontalAlignment = 1;
            clEstudiante.BorderWidthBottom = 0.75f;
            tblPrueba.AddCell(clEstudiante);

            clEstudiante = new PdfPCell(new Phrase("Cédula: " + prestamo.estudiant.IdCedula.ToString(), _standardFont));
            clEstudiante.BorderWidth = 0;
            tblPrueba.AddCell(clEstudiante);

            clEstudiante = new PdfPCell(new Phrase("Nombre: " + prestamo.estudiant.Nombre.ToString(), _standardFont));
            clEstudiante.BorderWidth = 0;
            tblPrueba.AddCell(clEstudiante);

            clEstudiante = new PdfPCell(new Phrase("Sección: " + prestamo.estudiant.Seccion.ToString(), _standardFont));
            clEstudiante.BorderWidth = 0;
            tblPrueba.AddCell(clEstudiante);

            clEstudiante = new PdfPCell(new Phrase("Teléfono: " + prestamo.estudiant.Telefono.ToString(), _standardFont));
            clEstudiante.BorderWidth = 0;
            tblPrueba.AddCell(clEstudiante);

            clEstudiante = new PdfPCell(new Phrase("Email: " + prestamo.estudiant.Email.ToString(), _standardFont));
            clEstudiante.BorderWidth = 0;
            tblPrueba.AddCell(clEstudiante);
            //--Fin Estudiante

            foreach (Libros libro in lista)
            {
                //--Inicio Libro
                PdfPCell clLibro = new PdfPCell(new Phrase("Libro", _standardFont));
                clLibro.BorderWidth = 2;
                clLibro.HorizontalAlignment = 1;
                clLibro.BorderWidthBottom = 0.75f;
                tblPrueba.AddCell(clLibro);

                clLibro = new PdfPCell(new Phrase("Código: " + libro.Id.ToString(), _standardFont));
                clLibro.BorderWidth = 0;
                tblPrueba.AddCell(clLibro);

                clLibro = new PdfPCell(new Phrase("Título: " + libro.Titulo.ToString(), _standardFont));
                clLibro.BorderWidth = 0;
                tblPrueba.AddCell(clLibro);

                clLibro = new PdfPCell(new Phrase("Año: " + libro.anno.ToString(), _standardFont));
                clLibro.BorderWidth = 0;
                tblPrueba.AddCell(clLibro);

                clLibro = new PdfPCell(new Phrase("Editorial: " + libro.Editorial.Nombre.ToString(), _standardFont));
                clLibro.BorderWidth = 0;
                tblPrueba.AddCell(clLibro);
                //--Fin Libro            

            }
            //--Inicio Tipo Solicitud
            PdfPCell clTipo = new PdfPCell(new Phrase("Tipo de Solicitud", _standardFont));
            clTipo.BorderWidth = 2;
            clTipo.HorizontalAlignment = 1;
            clTipo.BorderWidthBottom = 0.75f;
            tblPrueba.AddCell(clTipo);

            clTipo = new PdfPCell(new Phrase("Clasificasión: " + prestamo.Categoria.Descripcion.ToString(), _standardFont));
            clTipo.BorderWidth = 0;
            tblPrueba.AddCell(clTipo);
            //--Fin Tipo Solicitud

            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblPrueba);

            doc.Close();
            writer.Close();

        }
        public List<Prestamo> Solicitudes_Devol()
        {
            Datos.Prestamo_Datos datos = new Datos.Prestamo_Datos();
            return datos.Solicitudes_Devolucion();
        }

        public List<Prestamo> Solicitudes_Prestamo()
        {
            Datos.Prestamo_Datos datos = new Datos.Prestamo_Datos();
            return datos.Solicitudes_Prestamo();
        }

      
    }

}
