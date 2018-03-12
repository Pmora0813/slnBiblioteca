﻿using Capa.Entidades;
using Capa.Logica;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.UI.Mantenimientos
{
    public partial class frmMant_Libros : Form
    {
        public frmMant_Libros()
        {
            InitializeComponent();
        }

        private void frmMant_Libros_Load(object sender, EventArgs e)
        {
            llenarComboEditoriales();
            llenarComboAutores();
        }

        private void llenarComboAutores()
        {
            Autor_Logica Logica = new Autor_Logica();
            cbmAutores.DataSource = Logica.SeleccionarTodos();
        }

        private void llenarComboEditoriales()
        {
            Editorial_Logica logica = new Editorial_Logica();
            cbmEditoriales.DataSource = logica.SeleccionarTodos();
            cbmEditoriales.DisplayMember = "Nombre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode(txtCodigo.Text, out qrCode);

            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);

            MemoryStream ms = new MemoryStream();

            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imageTemporal = new Bitmap(ms);
            var imagen = new Bitmap(imageTemporal, new Size(new Point(145, 125)));
            panel1.BackgroundImage = imagen;

            // Guardar en el disco duro la imagen (Carpeta del proyecto)
            imagen.Save("imagen.png", ImageFormat.Png);
            btnEliminar.Enabled = true;
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            Libro_Autor_Logica Logica = new Libro_Autor_Logica();

            Autor aut = (Autor)cbmAutores.SelectedItem;

            Logica.guardar(Convert.ToInt32(txtCodigo.Text), aut.Id);

        }
    }
}