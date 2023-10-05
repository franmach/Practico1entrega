using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    internal class Senador:Legislador
    {
        private int numAsientoCamaraAlta;

        public Senador(string partidoPolitico, string departamentoQueRepresenta, int numDespacho, string nombre, string apellido, int edad, bool casado, int numAsientoCamaraAlta) : base(partidoPolitico, departamentoQueRepresenta, numDespacho, nombre, apellido, edad, casado)
        {
            this.numAsientoCamaraAlta = numAsientoCamaraAlta;
        }
        public Senador()
        {

        }
        public void setNumAsiento(int numAsiento)
        {
            this.numAsientoCamaraAlta = numAsiento;
        }
        public int getNumAsiento()
        {
            return numAsientoCamaraAlta;
        }
        public override string getCamara()
        {
            return "Senadores";
        }

        public override void presentarPropuestaLegislativa()
        {
            Console.WriteLine($"El Senador {getNombre()} {getApellido()} presentó una propuesta");
        }
        public override void votar()
        {
            Console.WriteLine($"El Senador {getNombre()} {getApellido()} votó");
        }
        public override void participarDebate()
        {
            Console.WriteLine($"El Senador {getNombre()} {getApellido()} participó en un debate");
        }
    }

}

