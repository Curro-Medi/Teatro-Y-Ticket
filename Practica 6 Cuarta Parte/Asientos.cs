using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    public class Asientos
    {
        private int fila;
        private int columna;
        private String estado;

        public Asientos()
        {
        }

        public Asientos(int columna, int fila, String estado)
        {
            this.columna = columna;
            this.fila = fila;
            this.estado = estado;
        }

        public int Fila { get => fila; set => fila = value; }
        public int Columna { get => columna; set => columna = value; }
        public String Estado { get => estado; set => estado = value; }

        public static implicit operator List<object>(Asientos v)
        {
            throw new NotImplementedException();
        }
    }
}
