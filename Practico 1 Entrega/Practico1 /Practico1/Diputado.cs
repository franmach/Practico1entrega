using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    internal class Diputado : Legislador
    {
        private int numAsientoCamaraBaja;

        public Diputado(string partidoPolitico, string departamentoQueRepresenta, int numDespacho, string nombre, string apellido, int edad, bool casado, int numAsientoCamaraBaja):base(partidoPolitico, departamentoQueRepresenta,numDespacho, nombre, apellido, edad, casado)
        {
            this.numAsientoCamaraBaja = numAsientoCamaraBaja;
        }
        public Diputado()
        {

        }
        public void setNumAsiento(int numAsiento)
        {
            this.numAsientoCamaraBaja = numAsiento;
        }
        public int getNumAsiento()
        {
            return numAsientoCamaraBaja;
        }
        public override string getCamara()
        {
            return "Diputados";
        }

        public override void presentarPropuestaLegislativa()
        {
            Console.WriteLine($"El Diputado {getNombre()} {getApellido()} presentó una propuesta");
        }
        public override void votar()
        {
            Console.WriteLine($"El Diputado {getNombre()} {getApellido()} votó");
        }
        public override void participarDebate()
        {
            Console.WriteLine($"El Diputado {getNombre()} {getApellido()} participó en un debate");
        }
    }

}
