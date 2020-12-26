using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using Microsoft.Reporting.WinForms;
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

namespace Practica5
{
    public partial class Form1 : Form
    {
        MainWindow mw;
        List<Asientos> DatosAsientos;
        Sala sala;
        
        public Form1(MainWindow mw, List<Asientos> DatosAsientos, Sala sala)
        {
            InitializeComponent();
            this.DatosAsientos = DatosAsientos;
            this.mw = mw;
            this.sala = sala;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            int precio = 0;

            var qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            var qrCode = qrEncoder.Encode("texto a codificar");
            var renderer = new GraphicsRenderer(new FixedModuleSize(5,
            QuietZoneModules.Two), Brushes.Black, Brushes.White);
            using (var stream = new FileStream(Application.StartupPath +
            @"\imagenes\qrcode.png", FileMode.Create))
                renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, stream);
            /*Para cargar la imagen de manera dinámica, primero hemos de
            agregar un parámetro para la ruta. Luego insertamos en el informe
            una imagen, el origen de la imagen ha de ser “externo2 y en valor
            establecemos el parámetro.
            Luego insertamos la ruta de la imagen en el parámetro string
            "rutaImagen" siendo qrcode.png el código generado en el paso
            anterior (como se muestra continuación)*/

            reportViewer1.LocalReport.EnableExternalImages = true;

            string rutaQR = Application.StartupPath + @"\imagenes\qrcode.png";

            ReportParameter paramImagenQR = new ReportParameter("RutaImagenQR", @"file:\" + rutaQR, true);
            reportViewer1.LocalReport.SetParameters(paramImagenQR);
            reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
            reportViewer1.LocalReport.EnableExternalImages = true;

            string ruta = "";

            if (sala.Nombrevento.Equals("Una Visita Inesperada"))
            {
                ruta = Application.StartupPath + @"\imagenes\unavisitainesperada.jpg";
            }else if(sala.Nombrevento.Equals("La Soga"))
            {
                ruta = Application.StartupPath + @"\imagenes\Lasoga.jpg";

            }
            else if(sala.Nombrevento.Equals("El Cuarto de Veronica"))
            {
                ruta = Application.StartupPath + @"\imagenes\cuartovero.jpg";

            }


            ReportParameter paramImagen = new ReportParameter("RutaImagenObra", @"file:\" + ruta, true);
            reportViewer1.LocalReport.SetParameters(paramImagen);

            ReportParameter Titulo = new ReportParameter("RP_Titulo", sala.Nombrevento, true);
            reportViewer1.LocalReport.SetParameters(Titulo);

            ReportParameter fecha = new ReportParameter("Fecha", sala.Fecha, true);
            reportViewer1.LocalReport.SetParameters(fecha);

            ReportParameter hora = new ReportParameter("Hora", sala.Hora, true);
            reportViewer1.LocalReport.SetParameters(hora);

            for (int i = 0; i<DatosAsientos.Count; i++)
            {
                precio = 40 + precio;
            }

            String Sprecio = precio.ToString();
            ReportParameter precios = new ReportParameter("Precio", Sprecio, true);
            reportViewer1.LocalReport.SetParameters(precios);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1" , DatosAsientos));


            reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mw.Show();
        }
    }
}
