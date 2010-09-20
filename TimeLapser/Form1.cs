using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System.Threading;
namespace TimeLapser
{
    public partial class Form1 : Form
    {
        int id = 0;
        int indiceCamara=0;
        string nombre = "Imagen";
        string rutaAlmacenamiento = "";
        int ancho = 800;
        int alto = 600;
        Capture capturador;
        int milisegundos = 1500;
        Emgu.CV.Image<Bgr, byte> imagenCapturada=null;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            temporizador.Interval = milisegundos;
            cmbResolucion.SelectedItem = cmbResolucion.Items[0];
            temporizador.Stop();
            
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            string sufijo = "";
            string cadAux = "";
            sufijo = id.ToString();
            cadAux=sufijo.PadLeft(10, '0');
            imagenCapturada = capturador.QueryFrame();
            imagenCapturada.Save(rutaAlmacenamiento+"\\"+ nombre+cadAux + ".jpg");
            id++; 
            controlImagen.Image = imagenCapturada;
            
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            DialogResult resultado = selectorCarpeta.ShowDialog();
            if (resultado != DialogResult.Yes)
            {
                textoPath.Text=selectorCarpeta.SelectedPath;
            }
        }

        private void cmbResolucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string res = (string)cmbResolucion.SelectedItem;
            int posX = res.IndexOf('x');
            string cad_ancho = res.Substring(0, posX);
            string cad_alto = res.Substring(posX + 1);
            //MessageBox.Show("Ancho:" + ancho + ", alto:" + alto);
            this.ancho = System.Convert.ToInt16(cad_ancho);
            this.alto = System.Convert.ToInt16(cad_alto);
        }
        private void conmutar(bool modo)
        {
            btnChooseFolder.Enabled = modo;
            cmbResolucion.Enabled = modo;
            btnEmpezar.Enabled = modo;
            btnParar.Enabled = !modo;
            textoPath.Enabled = modo;
            spnMilisegundos.Enabled = modo;
        }
        private void funcionando()
        {
            conmutar(false);
            rutaAlmacenamiento = textoPath.Text;
            id = 0;
            temporizador.Interval = (int)spnMilisegundos.Value;
            temporizador.Start();
            capturador = new Capture(indiceCamara);
            capturador.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, alto);
            capturador.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, ancho);
            Thread.Sleep(3000);
        }
        private void detenido()
        {
            conmutar(true);
            temporizador.Stop();
            controlImagen.Image = null;
            imagenCapturada = null;
            capturador.Dispose();
        }
        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            funcionando();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            detenido();
            generarVideo();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About formularioAcerca = new About();
            
            DialogResult resultado = formularioAcerca.ShowDialog();
            if (resultado == DialogResult.OK) formularioAcerca.Dispose();
        }
        private void generarVideo()
        {
            
            Emgu.CV.VideoWriter escritor = new Emgu.CV.VideoWriter(rutaAlmacenamiento+"\\Out.avi", 30,
                ancho, alto, true);
            //Recuperamos los nombres de los archivos JPG
            string[] listaImagenes = Directory.GetFiles(rutaAlmacenamiento, "*.jpg");
            barraProgresoGeneracion.Maximum = listaImagenes.Length;
            int posFrame = 0;
            int total=listaImagenes.Length;
            
            foreach (string imagen in listaImagenes)
            {
                
                barraProgresoGeneracion.Value = posFrame;
                
                Image<Bgr, Byte> imagenCargada = new Image<Bgr, byte>(imagen);
                escritor.WriteFrame<Bgr, byte>(imagenCargada);
                //imagenCargada.Dispose();
                posFrame=posFrame+1;
            }
            
            
            Thread.Sleep(5000);
            escritor.Dispose();
            GC.Collect();
            
            MessageBox.Show("Video generado");
            
        }
        private void btnGenerarVideo_Click(object sender, EventArgs e)
        {
            
        }

        private void idCamara_ValueChanged(object sender, EventArgs e)
        {
            indiceCamara = (int)idCamara.Value;
        }
    }
}
