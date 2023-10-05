using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    internal class Legislador
    {
        //atributos
        protected string partidoPolitico;
        protected string departamentoQueRepresenta;
        protected int numDespacho;
        protected string nombre;
        protected string apellido;
        protected int edad;
        protected bool casado;

        //constructor
       

        public Legislador(string partidoPolitico, string departamentoQueRepresenta, int numDespacho, string nombre, string apellido, int edad, bool casado)
        {
            this.partidoPolitico = partidoPolitico;
            this.departamentoQueRepresenta = departamentoQueRepresenta;
            this.numDespacho = numDespacho;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.casado = casado;
        }

        public Legislador()
        {

        }

       
        public string getPartidoPolitico()
        {
            return partidoPolitico;
        }
        public string getDepartamentoQueRepresenta()
        {
            return departamentoQueRepresenta;
        }
        public int getNumDespacho()
        {
            return numDespacho;
        }
        public string getNombre()
        {
            return nombre;
        }
        public string getApellido()
        {
            return apellido;
        }
        public int getEdad()
        {
            return edad;
        }
        public bool getCasado()
        {
            return casado;
        }

        //setters
        public void setPartidoPolitico(string partidoPolitico)
        {
            this.partidoPolitico = partidoPolitico;
        }
        public void setDepartamentoQueRepresenta(string departamentoQueRepresenta)
        {
            this.departamentoQueRepresenta = departamentoQueRepresenta;
        }
        public void setNumDespacho(int numDespacho)
        {
            this.numDespacho = numDespacho;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public void setEdad(int edad)
        {
            this.edad = edad;
        }
        public void setCasado(bool casado)
        {
            this.casado = casado;
        }

        //Metodos polimorficos
        public virtual string getCamara()
        {
            
            return "vacio";
        }

        
        public virtual void presentarPropuestaLegislativa()
        {
        }

        public virtual void votar()
        {
        }
        public virtual void participarDebate()
        {
        }
        
    }
}
