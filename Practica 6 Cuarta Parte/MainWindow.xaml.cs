using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practica5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Sala> salas = new List<Sala>();
        List<Asientos> asientos = new List<Asientos>();

        public MainWindow()
        {
            InitializeComponent();

        }


        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            visitainesperada.Effect = new BlurEffect();
            fotoroja.Visibility = Visibility.Visible;
            gridfoto1.Visibility = Visibility.Visible;

        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            visitainesperada.Effect = null;
            fotoroja.Visibility = Visibility.Hidden;
            gridfoto1.Visibility = Visibility.Visible;

        }

        private void Button_MouseEnter2(object sender, MouseEventArgs e)
        {

            rope.Effect = new BlurEffect();
            fotorope.Visibility = Visibility.Visible;
            gridfoto2.Visibility = Visibility.Visible;

        }

        private void Button_MouseLeave2(object sender, MouseEventArgs e)
        {

            rope.Effect = null;
            fotorope.Visibility = Visibility.Hidden;
            gridfoto2.Visibility = Visibility.Hidden;

        }

        private void Button_MouseEnter3(object sender, MouseEventArgs e)
        {

            vero.Effect = new BlurEffect();
            fotovero.Visibility = Visibility.Visible;
            gridfoto3.Visibility = Visibility.Visible;

        }

        private void Button_MouseLeave3(object sender, MouseEventArgs e)
        {

            vero.Effect = null;
            fotovero.Visibility = Visibility.Hidden;
            gridfoto3.Visibility = Visibility.Hidden;

        }

        private void fotoroja_Click(object sender, RoutedEventArgs e)
        {

            Horas horas = new Horas(salas, "Una Visita Inesperada", this, asientos);
            this.Hide();
            horas.Show();

        }

        private void fotorope_Click(object sender, RoutedEventArgs e)
        {
            Horas horas = new Horas(salas, "La Soga", this, asientos);
            this.Hide();
            horas.Show();
        }

        private void fotovero_Click(object sender, RoutedEventArgs e)
        {
            Horas horas = new Horas(salas, "El Cuarto de Veronica", this, asientos);
            this.Hide();
            horas.Show();
        }
    }
}

