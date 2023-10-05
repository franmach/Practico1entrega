using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    internal class Parlamento
    {
        //La lista y dos atributos solo de lectura para contar
        public List<Legislador> listaLegisladores;
        public int CantidadSenadores => listaLegisladores.Count(legislador => legislador.getCamara() == "Senadores");
        public int CantidadDiputados => listaLegisladores.Count(legislador => legislador.getCamara() == "Diputados");
        //----------------------------------------------------

        // Constructor que inicializa la lista de legisladores
        public Parlamento()
        {
            listaLegisladores = new List<Legislador>();
        }
        //----------------------------------------------------
        public List<Legislador> getListaLegisladores()
        {
            return listaLegisladores;
        }

        public void setListaLegisladores(List<Legislador> nuevaLista)
        {
            listaLegisladores = nuevaLista;
        }

        // Metodo para recorrer la lista e imprimir los valores
        public void listarCamaras()
        {
            foreach (var legislador in listaLegisladores)
            {
                Console.WriteLine($"Nombre: {legislador.getNombre()}");
                Console.WriteLine($"Apellido: {legislador.getApellido()}");
                Console.WriteLine($"Número de Despacho: {legislador.getNumDespacho()}");
                Console.WriteLine($"Cámara: {legislador.getCamara()}");
                Console.WriteLine();
            }
        }
        //----------------------------------------------------

        //Metodo para agregar el nuevo legislador a la lista
        public void registrarLegislador(Legislador nuevoLegislador)
        {
           
            listaLegisladores.Add(nuevoLegislador);
        }
        //----------------------------------------------------

        //Metodo para imprimir las cantidades de cada tipo de legislador
        public void cantidadLegisladores(int CantidadSenadores, int CantidadDiputados)
        {
            Console.WriteLine($"Cantidad de Senadores: {CantidadSenadores}");
            Console.WriteLine($"Cantidad de Diputados: {CantidadDiputados}");
        }
        //----------------------------------------------------
    }
}
