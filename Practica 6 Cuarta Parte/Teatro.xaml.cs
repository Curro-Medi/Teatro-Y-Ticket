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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Practica5
{
    /// <summary>
    /// Lógica de interacción para Teatro.xaml
    /// </summary>
    public partial class Teatro : Window
    {
        MainWindow mw;
        Sala sala;
        List<Asientos> asientos;
        int filas;
        int columnas;
        List<int> fila = new List<int>();
        List<int> columna = new List<int>();
        Boolean compradooreservado;

        public Teatro()
        {
            InitializeComponent();

        }

        public Teatro(MainWindow mainWindow, Sala sala, List<Asientos> asientos, int filas, int columnas)
        {
            InitializeComponent();
            this.mw = mainWindow;
            this.sala = sala;
            this.asientos = asientos;
            this.filas = filas;
            this.columnas = columnas;

            for (int f = 0; f < filas; f++)
                GridSala.RowDefinitions.Add(new RowDefinition());
            for (int c = 0; c < columnas; c++)
                GridSala.ColumnDefinitions.Add(new ColumnDefinition());


            for (int fila = 0; fila < filas; fila++)
            {
                for (int columna = 0; columna < columnas; columna++)
                {
                    Button b = new Button();
                    Grid g = new Grid();
                    b.Name = "boton" + fila + columna;
                    b.Click += boton_Click;
                    b.Loaded += boton_Load;
                    b.Content=g;
                    Image image = new Image();
                    image.Source = new BitmapImage(new Uri("asiento.png",UriKind.Relative));
                    GridSala.Children.Add(b);
                    Grid.SetRow(b, fila);
                    Grid.SetColumn(b, columna);
                    g.Children.Add(image);

                    
                }

            }
        }

        public Teatro(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mw = mainWindow;

        }

        private void boton_Load(object sender, RoutedEventArgs e)
        {
            foreach (Asientos a in asientos)
            {
                if (a.Estado.Equals("comprado") && a.Columna == Grid.GetColumn(((Button)sender)) && a.Fila == Grid.GetRow(((Button)sender)))
                {
                    ((Button)sender).Background = Brushes.DarkOliveGreen;
                }
                else if (a.Estado.Equals("reservado") && a.Columna == Grid.GetColumn(((Button)sender)) && a.Fila == Grid.GetRow(((Button)sender)))
                {
                    ((Button)sender).Background = Brushes.Yellow;
                }
            }
        }



        private void boton_Click(object sender, RoutedEventArgs e)
        {
            var elemento = (UIElement)e.Source;

            if (((Button)sender).Background != Brushes.LightBlue || ((Button)sender).Background != Brushes.DarkOliveGreen || ((Button)sender).Background != Brushes.Yellow)
            {
                columna.Add(Grid.GetColumn(elemento));
                fila.Add(Grid.GetRow(elemento));
            }
            

            ((Button)sender).Background = Brushes.LightBlue;
        }

        private void Comprar_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < fila.Count; i++)
            {
                asientos.Add(new Asientos(columna[i], fila[i], "comprado"));
                for (int t = 0; t < asientos.Count; t++)
                {
                    if (asientos[t].Columna == columna[i] && asientos[i].Fila == fila[i] && asientos[i].Estado.Equals("reservado"))
                    {
                        asientos.RemoveAt(i);
                    }
                    else
                    {
                        break;
                    }
                }


            }

            if (columna.Count == 0 && fila.Count == 0)
            {
                MessageBox.Show("No has seleccionado ningun asiento");
            }
            else
            {
                this.Hide();
                Form1 f1 = new Form1(mw,asientos, sala);
                f1.Show();
            }
        }

        private void Anularcompra_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < asientos.Count; i++)
            {
                for (int t = 0; t < columna.Count; t++)
                {
                    if (asientos[i].Columna == columna[t] && asientos[i].Fila == fila[t] && asientos[i].Estado.Equals("comprado"))
                    {
                        asientos.RemoveAt(i);
                    }
                }

            }
            if (columna.Count == 0 && fila.Count == 0)
            {
                MessageBox.Show("No has seleccionado ningun asiento");
            }
            else
            {
                this.Hide();
                mw.Show();
            }
        }

        private void Reservar_Click(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < columna.Count; i++)
            {
                asientos.Add(new Asientos(columna[i], fila[i], "reservado"));
                for (int t = 0; t < asientos.Count; t++)
                {
                    if (asientos[t].Columna == columna[i] && asientos[i].Fila == fila[t] && asientos[i].Estado.Equals("comprado"))
                    {
                        asientos.RemoveAt(i);
                    }
                    else
                    {
                        break;
                    }
                }


            }
            if (columna.Count == 0 && fila.Count == 0)
            {
                MessageBox.Show("No has seleccionado ningun asiento");
            }
            else
            {

                this.Hide();
                Form1 f1 = new Form1(mw,asientos, sala);
                f1.Show();
            }
        }

        private void Anularreserva_Click(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < asientos.Count; i++)
            {
                for (int t = 0; t < columna.Count; t++)
                {
                    if (asientos[i].Columna == columna[t] && asientos[i].Fila == fila[t] && asientos[i].Estado.Equals("reservado"))
                    {
                        asientos.RemoveAt(i);
                    }
                }

            }

            if (columna.Count == 0 && fila.Count == 0)
            {
                MessageBox.Show("No has seleccionado ningun asiento");
            }
            else
            {
                this.Hide();
                mw.Show();
            }
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            mw.Show();
            this.Hide();
        }
    }
}
