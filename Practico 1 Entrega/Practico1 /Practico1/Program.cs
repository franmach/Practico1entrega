using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Creo Parlamento, la entidad que contiene la lista y las funciones
            Parlamento parlamento = new Parlamento();


            int opcion, edad, nDespacho,nAsiento;
            string apellido, nombre, partidoPolitico, departamento, input;
            do
            {
                
                Console.WriteLine("----MENU----");
                Console.WriteLine("1 - Ingresar diputados");
                Console.WriteLine("2 - Ingresar senadores");
                Console.WriteLine("3 - Ver camaras");
                Console.WriteLine("4 - Cantidad de legisladores");
                Console.WriteLine("0 - Continuar");
                input = Console.ReadLine();

                if (Int32.TryParse(input, out opcion))
                {
                    // Verificar si el número está en el rango 
                    if (opcion >= 0 && opcion <= 4)
                    {
                        switch (opcion)
                        {
                            case 1:
                                Diputado D = new Diputado();

                                //INGRESO NOMBRE-----------------------------------------------------------------------------------------
                                do
                                {
                                    Console.WriteLine("Ingrese el nombre:");
                                    nombre = Console.ReadLine();
                                    D.setNombre(nombre);
                                    if (string.IsNullOrWhiteSpace(nombre) || Int32.TryParse(nombre, out _))
                                    {
                                        Console.WriteLine("Nombre no válido. Ingrese un nombre válido.");
                                    }
                                } while (string.IsNullOrWhiteSpace(nombre) || Int32.TryParse(nombre, out _));


                                //INGRESO APELLIDO-----------------------------------------------------------------------------------------
                                do
                                {
                                    Console.WriteLine("Ingrese el apellido:");
                                    apellido = Console.ReadLine();
                                    D.setApellido(apellido);
                                    if (string.IsNullOrWhiteSpace(apellido) || Int32.TryParse(apellido, out _))
                                    {
                                        Console.WriteLine("Apellido no válido. Ingrese un apellido válido.");
                                    }
                                } while (string.IsNullOrWhiteSpace(apellido) || Int32.TryParse(apellido, out _));


                                //INGRESO EDAD---------------------------------------------------------------------------------------------
                                do
                                {
                                    Console.WriteLine("Ingrese la edad:");
                                    input = Console.ReadLine();

                                    if (string.IsNullOrWhiteSpace(input))
                                    {
                                        Console.WriteLine("Edad no válida. Ingrese una edad válida.");
                                    }
                                    else if (!Int32.TryParse(input, out edad))
                                    {
                                        Console.WriteLine("Edad no válida. Ingrese una edad válida.");
                                    }
                                    else
                                    {
                                        // Asignar la edad a D solo cuando la entrada sea un número válido
                                        D.setEdad(edad);
                                    }
                                } while (!Int32.TryParse(input, out _));// Guion bajo indica que no queremos guardar ese parseo


                                //INGRESO pPOLITICO-----------------------------------------------------------------------------------------
                                do
                                {
                                    Console.WriteLine("Ingrese el partido politico:");
                                    partidoPolitico = Console.ReadLine();
                                    D.setPartidoPolitico(partidoPolitico);
                                    if (string.IsNullOrWhiteSpace(partidoPolitico) || Int32.TryParse(partidoPolitico, out _))
                                    {
                                        Console.WriteLine("Partido politico no válido. Ingrese uno válido.");
                                    }
                                } while (string.IsNullOrWhiteSpace(partidoPolitico) || Int32.TryParse(partidoPolitico, out _));


                                //INGRESO nDESPACHO----------------------------------------------------------------------------------------
                                do
                                {
                                    Console.WriteLine("Ingrese el numero de despacho:");
                                    input = Console.ReadLine();
                                   
                                        foreach (var legislador in parlamento.listaLegisladores)
                                        {
                                            while (legislador.getNumDespacho() == Int32.Parse(input))
                                            {
                                                Console.WriteLine("Numero de despacho ya existe. Ingrese un numero de despacho válido.");
                                                input = Console.ReadLine();
                                            }
                                            
                                        }
                                    
                                    if (string.IsNullOrWhiteSpace(input))
                                    {
                                        Console.WriteLine("Numero de despacho no válido. Ingrese un numero de despacho válido.");
                                    }
                                    else if (!Int32.TryParse(input, out nDespacho))
                                    {
                                        Console.WriteLine("Numero de despacho no válido. Ingrese un numero de despacho válido.");
                                    }
                                    else
                                    {
                                        D.setNumDespacho(nDespacho);
                                    }
                                } while (!Int32.TryParse(input, out _));


                                //INGRESO DEPARTAMENTO------------------------------------------------------------------------------------
                                do
                                {
                                    Console.WriteLine("Ingrese el departamento que representa:");
                                    departamento = Console.ReadLine();
                                    D.setPartidoPolitico(departamento);
                                    if (string.IsNullOrWhiteSpace(departamento) || Int32.TryParse(departamento, out _))
                                    {
                                        Console.WriteLine("Departamento no válido. Ingrese uno válido.");
                                    }
                                } while (string.IsNullOrWhiteSpace(departamento) || Int32.TryParse(departamento, out _));


                                //INGRESO CASADO-----------------------------------------------------------------------------------------
                                Console.WriteLine("Esta casado?(S/N)");
                                string casado= Console.ReadLine();
                                do {
                                    if (casado.ToLower() == "s")
                                    {
                                        D.setCasado(true);
                                    }
                                    else if(casado.ToLower() == "n")
                                    {
                                        D.setCasado(false);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Opcion no válida. Ingrese una válida.");
                                        casado = Console.ReadLine();
                                    }
                                } while (casado.ToLower()!= "s" && casado.ToLower() != "n");


                                //INGRESO ASIENTO----------------------------------------------------------------------------------------
                                do
                                {
                                    Console.WriteLine("Ingrese el numero de asiento:");
                                    input = Console.ReadLine();

                                    if (string.IsNullOrWhiteSpace(input))
                                    {
                                        Console.WriteLine("Numero de asiento no válido. Ingrese un numero de asiento válido.");
                                    }
                                    else if (!Int32.TryParse(input, out nAsiento))
                                    {
                                        Console.WriteLine("Numero de asiento no válido. Ingrese un numero de asiento válido.");
                                    }
                                    else
                                    {
                                        D.setNumAsiento(nAsiento);
                                    }
                                } while (!Int32.TryParse(input, out _));
                                //-------------------------------------------------------------------------------------------------------
                                parlamento.registrarLegislador(D);
                                break;

                            case 2:
                                Senador S = new Senador();
                                //INGRESO NOMBRE-----------------------------------------------------------------------------------------
                                do
                                {
                                    Console.WriteLine("Ingrese el nombre:");
                                    nombre = Console.ReadLine();
                                    S.setNombre(nombre);
                                    if (string.IsNullOrWhiteSpace(nombre) || Int32.TryParse(nombre, out _))
                                    {
                                        Console.WriteLine("Nombre no válido. Ingrese un nombre válido.");
                                    }
                                } while (string.IsNullOrWhiteSpace(nombre) || Int32.TryParse(nombre, out _));


                                //INGRESO APELLIDO-----------------------------------------------------------------------------------------
                                do
                                {
                                    Console.WriteLine("Ingrese el apellido:");
                                    apellido = Console.ReadLine();
                                    S.setApellido(apellido);
                                    if (string.IsNullOrWhiteSpace(apellido) || Int32.TryParse(apellido, out _))
                                    {
                                        Console.WriteLine("Apellido no válido. Ingrese un apellido válido.");
                                    }
                                } while (string.IsNullOrWhiteSpace(apellido) || Int32.TryParse(apellido, out _));


                                //INGRESO EDAD---------------------------------------------------------------------------------------------
                                do
                                {
                                    Console.WriteLine("Ingrese la edad:");
                                    input = Console.ReadLine();

                                    if (string.IsNullOrWhiteSpace(input))
                                    {
                                        Console.WriteLine("Edad no válida. Ingrese una edad válida.");
                                    }
                                    else if (!Int32.TryParse(input, out edad))
                                    {
                                        Console.WriteLine("Edad no válida. Ingrese una edad válida.");
                                    }
                                    else
                                    {
                                        // Asignar la edad a D solo cuando la entrada sea un número válido
                                        S.setEdad(edad);
                                    }
                                } while (!Int32.TryParse(input, out _));// Guion bajo indica que no queremos guardar ese parseo


                                //INGRESO pPOLITICO-----------------------------------------------------------------------------------------
                                do
                                {
                                    Console.WriteLine("Ingrese el partido politico:");
                                    partidoPolitico = Console.ReadLine();
                                    S.setPartidoPolitico(partidoPolitico);
                                    if (string.IsNullOrWhiteSpace(partidoPolitico) || Int32.TryParse(partidoPolitico, out _))
                                    {
                                        Console.WriteLine("Partido politico no válido. Ingrese uno válido.");
                                    }
                                } while (string.IsNullOrWhiteSpace(partidoPolitico) || Int32.TryParse(partidoPolitico, out _));


                                //INGRESO nDESPACHO----------------------------------------------------------------------------------------
                                do
                                {
                                    Console.WriteLine("Ingrese el numero de despacho:");
                                    input = Console.ReadLine();
                                    

                                    foreach (var legislador in parlamento.listaLegisladores)
                                    {
                                        while (legislador.getNumDespacho() == Int32.Parse(input))
                                        {
                                            Console.WriteLine("Numero de despacho ya existe. Ingrese un numero de despacho válido.");
                                            input = Console.ReadLine();

                                        }
                                    }
                                        if (string.IsNullOrWhiteSpace(input))
                                    {
                                        Console.WriteLine("Numero de despacho no válido. Ingrese un numero de despacho válido.");
                                    }
                                    else if (!Int32.TryParse(input, out nDespacho))
                                    {
                                        Console.WriteLine("Numero de despacho no válido. Ingrese un numero de despacho válido.");
                                    }
                                    else
                                    {
                                        S.setNumDespacho(nDespacho);
                                    }
                                } while (!Int32.TryParse(input, out _));


                                //INGRESO DEPARTAMENTO------------------------------------------------------------------------------------
                                do
                                {
                                    Console.WriteLine("Ingrese el departamento que representa:");
                                    departamento = Console.ReadLine();
                                    S.setPartidoPolitico(departamento);
                                    if (string.IsNullOrWhiteSpace(departamento) || Int32.TryParse(departamento, out _))
                                    {
                                        Console.WriteLine("Departamento no válido. Ingrese uno válido.");
                                    }
                                } while (string.IsNullOrWhiteSpace(departamento) || Int32.TryParse(departamento, out _));


                                //INGRESO CASADO-----------------------------------------------------------------------------------------
                                Console.WriteLine("Esta casado?(S/N)");
                                casado = Console.ReadLine();
                                do
                                {
                                    if (casado.ToLower() == "s")
                                    {
                                        S.setCasado(true);
                                    }
                                    else if (casado.ToLower() == "n")
                                    {
                                        S.setCasado(false);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Opcion no válida. Ingrese una válida.");
                                        casado = Console.ReadLine();
                                    }
                                } while (casado.ToLower() != "s" && casado.ToLower() != "n");


                                //INGRESO ASIENTO----------------------------------------------------------------------------------------
                                do
                                {
                                    Console.WriteLine("Ingrese el numero de asiento:");
                                    input = Console.ReadLine();

                                    if (string.IsNullOrWhiteSpace(input))
                                    {
                                        Console.WriteLine("Numero de asiento no válido. Ingrese un numero de asiento válido.");
                                    }
                                    else if (!Int32.TryParse(input, out nAsiento))
                                    {
                                        Console.WriteLine("Numero de asiento no válido. Ingrese un numero de asiento válido.");
                                    }
                                    else
                                    {
                                        S.setNumAsiento(nAsiento);
                                    }
                                } while (!Int32.TryParse(input, out _));
                                //-------------------------------------------------------------------------------------------------------
                                parlamento.registrarLegislador(S);
                                break;
                            case 3:
                                parlamento.listarCamaras();
                                break;
                            case 4:
                                parlamento.cantidadLegisladores(parlamento.CantidadSenadores, parlamento.CantidadDiputados);
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opción fuera de rango. Por favor, elija una opción válida.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.");
                }
            
        } while (opcion != 0);

            do
            {
                parlamento.listarCamaras();
                do
                {
                    Console.WriteLine("Ingrese el numero de despacho del legislador (0 para salir)");
                    input = Console.ReadLine();
             
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Numero de despacho no válido. Ingrese un numero de despacho válido.");
                    }
                    else if (!Int32.TryParse(input, out nDespacho))
                    {
                        Console.WriteLine("Numero de despacho no válido. Ingrese un numero de despacho válido.");
                    }
                    else if (Int32.Parse(input) == 0)
                    {
                        break;
                    }
                } while (!Int32.TryParse(input, out _));
                nDespacho = Int32.Parse(input);


                Legislador legisladorActual = null;
                while (legisladorActual == null)
                {
                    foreach (var legislador in parlamento.listaLegisladores)
                    {
                        if (legislador.getNumDespacho() == nDespacho)
                        {
                            legisladorActual = legislador;
                            break;
                        }
                        if (legislador.getNumDespacho() != nDespacho)
                        {
                            Console.WriteLine("El numero ingresado no corresponde a ningun Legislador, Ingrese un numero de despacho válido.");
                            nDespacho = Int32.Parse(Console.ReadLine());
                        }
                    }
                }
                do { 
                Console.WriteLine("1 - Presentar una propuesta legislativa");
                Console.WriteLine("2 - Votar");
                Console.WriteLine("3 - Participar en debate");
                Console.WriteLine("0 - Salir");
                input = Console.ReadLine();
                if (Int32.TryParse(input, out opcion))
                {
                    // Verificar si el número está en el rango 
                    if (opcion >= 0 && opcion <= 3)
                    {
                        switch (opcion)
                        {
                            case 1:
                                legisladorActual.presentarPropuestaLegislativa();
                                break;
                            case 2:
                                legisladorActual.votar();
                                break;
                            case 3:
                                legisladorActual.participarDebate();
                                break;
                        }
                            break;
                    }
                    else
                    {
                        Console.WriteLine("Opción fuera de rango. Por favor, elija una opción válida.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.");
                }
                }while(true);   
            } while (opcion != 0);


            parlamento.listarCamaras();

        }

    }
}