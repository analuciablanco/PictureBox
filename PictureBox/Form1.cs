using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> InputColor;
        Image<Gray, byte> InputGray;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string rutaImagen = "E:\\tomlinson.jpg";
           InputColor = new Image<Bgr, byte>(rutaImagen);

            if (InputColor == null)
            {
                MessageBox.Show("No cargó la imagen correctamente.");
                return;
            }

            imageBox1.Image = InputColor;

            // Desactiva la existencia de TODAS las opciones cuando le damos clic derecho,
            // Pero con esta línea podemos definit qué opciones poner o quitar todas.
            imageBox1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Convertir a grises.
            InputGray = InputColor.Convert<Gray, byte>();

            imageBox2.Image = InputGray;
            imageBox1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom;
        }
    }
}
