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
    /// Lógica de interacción para Horas.xaml
    /// </summary>
    public partial class Horas : Window
    {
        MainWindow mw;
        List<Sala> salas;
        String evento;
        String hora;
        String fecha;
        List<Asientos> asientos;

        public Horas()
        {
            InitializeComponent();

        }

        public Horas(List<Sala> salas, String evento, MainWindow mw, List<Asientos> asientos)
        {
            InitializeComponent();
            this.evento = evento;
            this.salas = salas;
            this.mw = mw;
            this.asientos = asientos;
        }

        private void fecha29_Click(object sender, RoutedEventArgs e)
        {

            fecha29.Background = Brushes.LightBlue;
            fecha30.Background = Brushes.White;
            fecha31.Background = Brushes.White;
            fecha = "29/10/2020";

        }

        private void fecha30_Click(object sender, RoutedEventArgs e)
        {

            fecha29.Background = Brushes.White;
            fecha30.Background = Brushes.LightBlue;
            fecha31.Background = Brushes.White;
            fecha = "30/10/2020";

        }

        private void fecha31_Click(object sender, RoutedEventArgs e)
        {

            fecha29.Background = Brushes.White;
            fecha30.Background = Brushes.White;
            fecha31.Background = Brushes.LightBlue;
            fecha = "31/10/2020";

        }

        private void hora16_00_Click(object sender, RoutedEventArgs e)
        {

            hora16_00.Background = Brushes.LightBlue;
            hora17_30.Background = Brushes.White;
            hora18_00.Background = Brushes.White;
            hora19_00.Background = Brushes.White;
            hora20_30.Background = Brushes.White;
            hora21_00.Background = Brushes.White;
            hora22_00.Background = Brushes.White;
            hora23_00.Background = Brushes.White;
            hora23_30.Background = Brushes.White;
            hora00_00.Background = Brushes.White;

            hora = "16:00";

        }

        private void hora17_30_Click(object sender, RoutedEventArgs e)
        {

            hora16_00.Background = Brushes.White;
            hora17_30.Background = Brushes.LightBlue;
            hora18_00.Background = Brushes.White;
            hora19_00.Background = Brushes.White;
            hora20_30.Background = Brushes.White;
            hora21_00.Background = Brushes.White;
            hora22_00.Background = Brushes.White;
            hora23_00.Background = Brushes.White;
            hora23_30.Background = Brushes.White;
            hora00_00.Background = Brushes.White;

            hora = "17:30";
        }

        private void hora18_00_Click(object sender, RoutedEventArgs e)
        {

            hora16_00.Background = Brushes.White;
            hora17_30.Background = Brushes.White;
            hora18_00.Background = Brushes.LightBlue;
            hora19_00.Background = Brushes.White;
            hora20_30.Background = Brushes.White;
            hora21_00.Background = Brushes.White;
            hora22_00.Background = Brushes.White;
            hora23_00.Background = Brushes.White;
            hora23_30.Background = Brushes.White;
            hora00_00.Background = Brushes.White;

            hora = "18:00";
        }

        private void hora19_00_Click(object sender, RoutedEventArgs e)
        {

            hora16_00.Background = Brushes.White;
            hora17_30.Background = Brushes.White;
            hora18_00.Background = Brushes.White;
            hora19_00.Background = Brushes.LightBlue;
            hora20_30.Background = Brushes.White;
            hora21_00.Background = Brushes.White;
            hora22_00.Background = Brushes.White;
            hora23_00.Background = Brushes.White;
            hora23_30.Background = Brushes.White;
            hora00_00.Background = Brushes.White;

            hora = "19:00";
        }

        private void hora20_30_Click(object sender, RoutedEventArgs e)
        {

            hora16_00.Background = Brushes.White;
            hora17_30.Background = Brushes.White;
            hora18_00.Background = Brushes.White;
            hora19_00.Background = Brushes.White;
            hora20_30.Background = Brushes.LightBlue;
            hora21_00.Background = Brushes.White;
            hora22_00.Background = Brushes.White;
            hora23_00.Background = Brushes.White;
            hora23_30.Background = Brushes.White;
            hora00_00.Background = Brushes.White;

            hora = "20:30";
        }

        private void hora21_00_Click(object sender, RoutedEventArgs e)
        {

            hora16_00.Background = Brushes.White;
            hora17_30.Background = Brushes.White;
            hora18_00.Background = Brushes.White;
            hora19_00.Background = Brushes.White;
            hora20_30.Background = Brushes.White;
            hora21_00.Background = Brushes.LightBlue;
            hora22_00.Background = Brushes.White;
            hora23_00.Background = Brushes.White;
            hora23_30.Background = Brushes.White;
            hora00_00.Background = Brushes.White;

            hora = "21:00";
        }

        private void hora22_00_Click(object sender, RoutedEventArgs e)
        {

            hora16_00.Background = Brushes.White;
            hora17_30.Background = Brushes.White;
            hora18_00.Background = Brushes.White;
            hora19_00.Background = Brushes.White;
            hora20_30.Background = Brushes.White;
            hora21_00.Background = Brushes.White;
            hora22_00.Background = Brushes.LightBlue;
            hora23_00.Background = Brushes.White;
            hora23_30.Background = Brushes.White;
            hora00_00.Background = Brushes.White;

            hora = "22:00";
        }

        private void hora23_00_Click(object sender, RoutedEventArgs e)
        {

            hora16_00.Background = Brushes.White;
            hora17_30.Background = Brushes.White;
            hora18_00.Background = Brushes.White;
            hora19_00.Background = Brushes.White;
            hora20_30.Background = Brushes.White;
            hora21_00.Background = Brushes.White;
            hora22_00.Background = Brushes.White;
            hora23_00.Background = Brushes.LightBlue;
            hora23_30.Background = Brushes.White;
            hora00_00.Background = Brushes.White;

            hora = "23:00";
        }

        private void hora23_30_Click(object sender, RoutedEventArgs e)
        {

            hora16_00.Background = Brushes.White;
            hora17_30.Background = Brushes.White;
            hora18_00.Background = Brushes.White;
            hora19_00.Background = Brushes.White;
            hora20_30.Background = Brushes.White;
            hora21_00.Background = Brushes.White;
            hora22_00.Background = Brushes.White;
            hora23_00.Background = Brushes.White;
            hora23_30.Background = Brushes.LightBlue;
            hora00_00.Background = Brushes.White;

            hora = "23:30";
        }

        private void hora00_00_Click(object sender, RoutedEventArgs e)
        {

            hora16_00.Background = Brushes.White;
            hora17_30.Background = Brushes.White;
            hora18_00.Background = Brushes.White;
            hora19_00.Background = Brushes.White;
            hora20_30.Background = Brushes.White;
            hora21_00.Background = Brushes.White;
            hora22_00.Background = Brushes.White;
            hora23_00.Background = Brushes.White;
            hora23_30.Background = Brushes.White;
            hora00_00.Background = Brushes.LightBlue;

            hora = "00:00";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Buscar con un for each si ya existe la sala con la hora y fecha que entre en esa list de asientos y sino que la cree

            Boolean existe = false;
            foreach (Sala s in salas)
            {
                if (s.Nombrevento.Equals(evento) && s.Fecha.Equals(fecha) && s.Hora.Equals(hora))
                {
                    existe = true;
                    if (s.Nombrevento.Equals(evento) && s.Fecha.Equals(fecha) && s.Hora.Equals(hora))
                    {
                        if (s.Hora.Equals("16:00") || s.Hora.Equals("21:00") || s.Hora.Equals("23:00") || s.Hora.Equals("00:00"))
                        {
                            Teatro teatro = new Teatro(mw, s, s.Listaasientos, 4, 3);
                            teatro.Show();
                            this.Hide();
                        }
                        else if (s.Hora.Equals("17:30") || s.Hora.Equals("20:30"))
                        {
                            Teatro teatro = new Teatro(mw, s, s.Listaasientos, 7, 3);
                            teatro.Show();
                            this.Hide();
                        }
                        else
                        {
                            Teatro teatro = new Teatro(mw, s, s.Listaasientos, 3, 5);
                            teatro.Show();
                            this.Hide();
                        }
                    }
                }

            }

            if (existe == false)
            {
                if (fecha == null || hora == null)
                {
                    MessageBox.Show("HORA O FECHA NO SELECCIONADAS");
                }
                else
                {
                    salas.Add(new Sala(evento, fecha, hora, new List<Asientos>()));
                    foreach (Sala s in salas)
                    {
                        if (s.Nombrevento.Equals(evento) && s.Fecha.Equals(fecha) && s.Hora.Equals(hora))
                        {

                            if (s.Hora.Equals("16:00") || s.Hora.Equals("21:00") || s.Hora.Equals("23:00") || s.Hora.Equals("00:00"))
                            {
                                Teatro teatro = new Teatro(mw, new Sala(evento, fecha, hora, s.Listaasientos), s.Listaasientos, 4, 3);
                                teatro.Show();
                                this.Hide();
                            }
                            else if (s.Hora.Equals("17:30") || s.Hora.Equals("20:30"))
                            {
                                Teatro teatro = new Teatro(mw, new Sala(evento, fecha, hora, s.Listaasientos), s.Listaasientos, 7,3);
                                teatro.Show();
                                this.Hide();
                            }
                            else
                            {
                                Teatro teatro = new Teatro(mw, new Sala(evento, fecha, hora, s.Listaasientos), s.Listaasientos, 3,5);
                                teatro.Show();
                                this.Hide();
                            }
                           
                            
                        }
                    }
                }
            }

        }
    }
}
