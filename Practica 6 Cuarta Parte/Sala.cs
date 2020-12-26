using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    public class Sala
    {

        private String nombrevento;
        private String fecha;
        private String hora;
        private List<Asientos> listaasientos;

        public string Nombrevento { get => nombrevento; set => nombrevento = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public List<Asientos> Listaasientos { get => listaasientos; set => listaasientos = value; }

        public Sala(string nombrevento, string fecha, string hora, List<Asientos> listaasientos)
        {
            this.Nombrevento = nombrevento;
            this.Fecha = fecha;
            this.Hora = hora;
            this.Listaasientos = listaasientos;
        }

        public void versala()
        {

        }

        public void reservarasiento()
        {

        }

        public void comprarasiento()
        {

        }



    }
}
