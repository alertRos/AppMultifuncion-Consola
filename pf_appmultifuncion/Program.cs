using System;
using System.Threading;
using System.IO;

namespace pf_appmultifuncion
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program call = new Program();
            call.inicio_programa();
        }
        public void inicio_programa()
        {
            //instancia de agenda
            agenda call_agenda = new agenda();
            //instancia de conversor de unidades
            moduloutilitario call_mu = new moduloutilitario();

            Console.WriteLine(@"
▄▀█ █▀█ █▀█   █▀▄▀█ █░█ █░░ ▀█▀ █ █▀▀ █░█ █▄░█ █▀▀ █ █▀█ █▄░█ ▄▀█ █░░
█▀█ █▀▀ █▀▀   █░▀░█ █▄█ █▄▄ ░█░ █ █▀░ █▄█ █░▀█ █▄▄ █ █▄█ █░▀█ █▀█ █▄▄");
            Console.WriteLine("\n\n1. Agenda\n2. Modulo utilitario\n3. Salir");
            string opcion;
            string entrada = Console.ReadLine();

            bool esValido = false;
            while (!esValido)
            {
                if (entrada != "1" && entrada != "2" && entrada != "3")
                {
                    esValido = false;
                }
                else
                {
                    esValido = true;
                }

                if (!esValido)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("OPCION INVALIDA, por favor ingrese una de las opciones disponibles");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(@"
▄▀█ █▀█ █▀█   █▀▄▀█ █░█ █░░ ▀█▀ █ █▀▀ █░█ █▄░█ █▀▀ █ █▀█ █▄░█ ▄▀█ █░░
█▀█ █▀▀ █▀▀   █░▀░█ █▄█ █▄▄ ░█░ █ █▀░ █▄█ █░▀█ █▄▄ █ █▄█ █░▀█ █▀█ █▄▄");

                    Console.WriteLine("\n\n1. Agenda\n2. Modulo utilitario\n3. Salir");

                    entrada = Console.ReadLine();
                }
            }

            opcion = entrada;

            switch (opcion)
            {
                case "1":
                    Console.Clear();
                    agenda.agenda_inicio();
                    break;
                case "2":
                    Console.Clear();
                    call_mu.inicioMU();
                    break;
                case "3":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Hasta luego! :)");
                    Environment.Exit(0);
                    break;
            }
        }
    }

    class agenda
    {
        public static void agenda_inicio()
        {

            Program volver_inicio = new Program();
            evento call_eventos = new evento();
            contactos call_contactos = new contactos();
            Console.WriteLine("Bienvenido/a a tu agenda personal. \nQué desea hacer?\n");
            Console.WriteLine("1. Contactos\n2. Eventos\n3. Atrás");

            string opcion;
            string entrada = Console.ReadLine();

            bool esValido = false;
            while (!esValido)
            {
                if (entrada != "1" && entrada != "2" && entrada != "3")
                {
                    esValido = false;
                }
                else
                {
                    esValido = true;
                }

                if (!esValido)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("OPCION INVALIDA, por favor ingrese una de las opciones disponibles");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Bienvenido/a a tu agenda personal. \nQué desea hacer?");
                    Console.WriteLine("1. Contactos\n2. Eventos\n3. Atrás");

                    entrada = Console.ReadLine();
                }
            }

            opcion = entrada;

            switch (opcion)
            {
                case "1":
                    Console.Clear();
                    call_contactos.contactos_inicio();
                    break;

                case "2":
                    Console.Clear();
                    call_eventos.eventos_inicio();

                    break;
                case "3":
                    Console.Clear();
                    volver_inicio.inicio_programa();
                    break;
            }
        }

    }

    class evento
    {
        public void eventos_inicio()
        {
            Console.WriteLine(@"           
                █▀▀ █░█ █▀▀ █▄░█ ▀█▀ █▀█ █▀
                ██▄ ▀▄▀ ██▄ █░▀█ ░█░ █▄█ ▄█");
            Console.WriteLine("1.Buscar eventos\n2.Agregar eventos\n3.Editar evento\n4.Eliminar eventos\n5.Ver eventos\n6.Atras\n7.Salir");

            string opcion;
            string entrada = Console.ReadLine();

            bool esValido = false;
            while (!esValido)
            {
                if (entrada != "1" && entrada != "2" && entrada != "3" && entrada != "4" && entrada != "5" && entrada != "6" && entrada != "7")
                {
                    esValido = false;
                }
                else
                {
                    esValido = true;
                }

                if (!esValido)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("OPCION INVALIDA, por favor ingrese una de las opciones disponibles");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(@"           
                █▀▀ █░█ █▀▀ █▄░█ ▀█▀ █▀█ █▀
                ██▄ ▀▄▀ ██▄ █░▀█ ░█░ █▄█ ▄█");

                    Console.WriteLine("1.Buscar eventos\n2.Agregar eventos\n3.Editar evento\n4.Eliminar eventos\n5.Ver eventos\n6.Atras\n7.Salir");

                    entrada = Console.ReadLine();
                }
            }

            opcion = entrada;

            switch (opcion)
            {
                case "1":
                    buscarEvento();
                    break;
                case "2":
                    agregarEvento();
                    break;
                case "3":
                    editarEvento();
                    break;
                case "4":
                    eliminarEvento();
                    break;
                case "5":
                    verEvento();
                    break;
                case "6":
                    Console.Clear();
                    agenda.agenda_inicio();
                    break;
                case "7":
                    Console.Clear();
                    Console.WriteLine("Hasta luego! :)");
                    Environment.Exit(0);
                    break;

            }

        }

        public void agregarEvento()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Para cancelar escriba /cancel\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                //CREANDO UN ARRAY PARA QUE VAYA PIDIENDO ESOS CAMPOS
                string[] informacion_contacto = { "NOMBRE", "FECHA", "HORA", "LUGAR" };
                string[] informacion = new string[informacion_contacto.Length];

                //DECLARANDO VARIABLES A UTILIZAR
                string respuesta;

                // CREANDO BUCLE QUE REPITA EL CODIGO DE AGREGAR CONTACTO
                do
                {
                    //CREANDO ESTANCIA DEL DOCUMENTO DE TEXTO(CONTACTOS) QUE GUARDARA LA INFORMACION
                    StreamWriter contactos = File.AppendText("inf_eventos.txt");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    //********     ESTRUCTURA DE LA SECCION DE AGREGAR CONTACTO    ******
                    Console.WriteLine("\nInformación del evento\n");
                    Console.ForegroundColor = ConsoleColor.White;

                    //CREANDO UN FOR QUE RECORRA EL ARRAY DE LOS CAMPOS REQUERIDOS
                    for (int i = 0; i < informacion_contacto.Length; i++)
                    {

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(informacion_contacto[i]);
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        //EL ARREGLO informacion LEERA LA INFORMACION QUE EL USUARIO VA INGRESANDO Y EL contactos.write LO QUE HARA 
                        // ES TOMAR ESA INFORMACION QUE HA SIDO GUARDADA EN LA VARIABLE CONTACTOS Y LO AÑADIRA AL DOCUMENTO DE TEXTO
                        // inf_eventos.txt DE IGUAL MANERA SE LE COLOCA UN SEPARADOR PARA PODER DISTINGUIR EL RECORRIDO DEL BUCLE FOR.
                        //NOTA IMPORTANTE: PARA QUE LA PROPIEDAD .write SE PUEDA USAR EN LA ESTANCIA DEL DOCUMENTO DE TEXTO FUE NECESARIO 
                        // El USAR StreamWriter QUE ESCRIBE SOBRE UN DOCUMENTO DE TEXTO ESPECIFICADO.

                        here3:
                        informacion[i] = Console.ReadLine().ToUpper();

                        if (informacion[i] == " ")
                        {
                            Console.WriteLine("Por favor ingrese texto, cadena vacia");
                            goto here3;
                        }
                        else if (informacion[i] == "")
                        {
                            Console.WriteLine("Por favor ingrese texto, cadena vacia");
                            goto here3;
                        }


                        if (informacion[i] == "/CANCEL")
                        {
                            Console.Clear();
                            contactos.Close();
                            Console.ForegroundColor = ConsoleColor.White;
                            eventos_inicio();

                        }
                    }
                    contactos.WriteLine(informacion[0] + " ║ " + informacion[1] + " ║ " + informacion[2] + " ║ " + informacion[3] + " ║ ");
                    //TERMINA EL RECORRIDO DEL BUCLE FOR POR LO QUE, TODOS LOS DATOS DEL CONTACTOHAN SIDO PEDIDOS Y GUARDADOS
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("EVENTO GUARDADO");
                    //SE CIERRA LA EJERCICION DE StreamWrite PARA QUE LOS DATOS ESCRITOS SE GUARDEN CORRECTAMENTE Y NO SIGA EN 
                    //EJECUCION.
                    contactos.Close();
                    //SE LE PIDE AL USUARIO SI DESEA AGREGAR UN NUEVO CONTACTO, EN CASO DE QUE LA RESPUESTA SEA SI EL BUCLE SE REPETIRA
                    //EN CASO DE SER NO SE TERMINA EL BUCLE Y SE VUELVE AL MENU INICIAL
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Desea crear un evento nuevo (SI/NO)?");
                    //ESTA LINEA DE CODIGO LEE LA RESPUESTA DEL USUARIO Y TOMA ESA RESPUESTA CONVIRTIENDOLA EN MAYUSCULA PARA EVITAR 
                    //ERRORES
                    respuesta = (Console.ReadLine()).ToUpper();
                    // ESTA LINEA DE CODIGO BASICAMENTE DICE: SI LA RESPUESTA ES "SI" ESTE CODIGO SEGUIRA EJECUTANDOSE, DE SER "NO"
                    //DETEN ESTE BUCLE.
                } while (respuesta.Equals("SI"));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\nPresione una tecla para volver al menú principal");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
                eventos_inicio();

            }//EN CASO DE QUE NO SE ENCUENTRE EL ARCHIVO 
            catch (FileNotFoundException)
            {
                Console.WriteLine("No se encontró el archivo");
            }
            Console.ReadLine();

        }

        public void buscarEvento()
        {
            //DECLARANDO VARIABLES
            string lector, buscador;
            bool busqueda = false;
            string[] campos = new string[4];

            try
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Para cancelar escriba /cancel\n\n");
                Console.ForegroundColor = ConsoleColor.White;

                StreamReader lectura = File.OpenText("inf_eventos.txt");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("BUSCADOR: ");
                Console.ForegroundColor = ConsoleColor.White;

                string entrada = Console.ReadLine().ToUpper();
                bool esValido = false;
                while (!esValido)
                {
                    if (entrada == " ")
                    {
                        esValido = false;
                    }
                    else if (entrada == "")
                    {
                        esValido = false;
                    }
                    else
                    {
                        esValido = true;
                    }

                    if (!esValido)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("La entrada es invalida, por favor ingrese un texto");
                        Thread.Sleep(3000);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(@"           
                █▀▀ █░█ █▀▀ █▄░█ ▀█▀ █▀█ █▀
                ██▄ ▀▄▀ ██▄ █░▀█ ░█░ █▄█ ▄█

");

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("\nBUSCADOR: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        entrada = Console.ReadLine().ToUpper();
                    }
                }
                buscador = entrada;
                //CONTENEMOS LA LECTURA DEL DOCUMENTO DE TEXTO EN UNA VARIABLE
                lector = lectura.ReadLine();
                //CREAMOS UN BUCLE QUE SE REPITA MIENTRAS LA VARIABLE LECTOR NO SEA NULA Y EL BOOLEANO busqueda SEA FALSO
                //O SEA, SI EXISTE TEXTO EN EL DOCUMENTO SEGUIRA BUSCANDO HASTA ENCONTRAR LO QUE SE LE PIDE.
                while (lector != null)
                {
                    //CREAMOS UN ARRAY CAMPO QUE SEPARA LOS DATOS DEL DOCUMENTO EN POSICIONES DE ARRAY DIVIDIDOS POR UN SEPARADOR.
                    campos = lector.Split('║');


                    //COLOCAMOS UNA CONDICION QUE DICE: SI LA POSICION 0 DEL ARRAY campos COINCIDE CON EL BUSCADOR CAPTURA LOS VALORES E IMPRIME LO QUE ESTA
                    //DENTRO DEL IF, el ".Trim" SE UTILIZO PARA OBVIAR LOS ESPACIOS VACIOS Y ESQUIVAR ERRORES 
                    if (buscador == "/CANCEL")
                    {
                        Console.Clear();
                        lectura.Close();
                        eventos_inicio();
                    }

                    if ((campos[0].Trim().Equals(buscador)))
                    {

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nInformación del evento\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t" + campos[0].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Fecha: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[1].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Hora: ");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[2].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Lugar: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[3].Trim() + "\n");
                        //SALIMOS DE LA BUSQUEDA ASIGNANDOLE AL BOOLEANO busqueda UN VALOR true POR LO QUE EL while NO SE CUMPLIRA
                        //Y EL BUCLE SE ROMPERA
                        busqueda = true;

                    }
                    else if ((campos[1].Trim().Equals(buscador)))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nInformación del evento\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t" + campos[0].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Fecha: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[1].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Hora: ");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[2].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Lugar: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[3].Trim() + "\n");
                        //SALIMOS DE LA BUSQUEDA ASIGNANDOLE AL BOOLEANO busqueda UN VALOR true POR LO QUE EL while NO SE CUMPLIRA
                        //Y EL BUCLE SE ROMPERA
                        busqueda = true;

                    }
                    else if (((campos[0].Trim() + " " + campos[1].Trim()).Equals(buscador)))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nInformación del evento\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t" + campos[0].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Fecha: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[1].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Hora: ");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[2].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Lugar: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[3].Trim() + "\n");
                        //SALIMOS DE LA BUSQUEDA ASIGNANDOLE AL BOOLEANO busqueda UN VALOR true POR LO QUE EL while NO SE CUMPLIRA
                        //Y EL BUCLE SE ROMPERA
                        busqueda = true;

                    }
                    else if ((campos[2].Trim().Equals(buscador)))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nInformación del evento\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t" + campos[0].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Fecha: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[1].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Hora: ");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[2].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Lugar: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[3].Trim() + "\n");
                        //SALIMOS DE LA BUSQUEDA ASIGNANDOLE AL BOOLEANO busqueda UN VALOR true POR LO QUE EL while NO SE CUMPLIRA
                        //Y EL BUCLE SE ROMPERA
                        busqueda = true;

                    }
                    else if ((campos[3].Trim().Equals(buscador)))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nInformación del evento\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t" + campos[0].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Fecha: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[1].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Hora: ");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[2].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Lugar: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[3].Trim() + "\n");
                        //SALIMOS DE LA BUSQUEDA ASIGNANDOLE AL BOOLEANO busqueda UN VALOR true POR LO QUE EL while NO SE CUMPLIRA
                        //Y EL BUCLE SE ROMPERA
                        busqueda = true;

                    }

                    //EN CASO DE NO ENCOTRAR LE DECIMOS A LA VARIABLE LECTOR, SIGUE LEYENDO             
                    lector = lectura.ReadLine();

                    //SI busqueda ES FALSO, O SEA, SI NO SE ENCONTRO NADA PARECIDO EJECUTA QUE NO SE ENCONTRO EL CONTACTO
                }

                if (busqueda == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se encontró el evento");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                lectura.Close();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\nPresione una tecla para volver al menú principal");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
                eventos_inicio();
                //CERRAMOS LA LECTURA

            }
            catch (FileNotFoundException fe)
            {
                Console.WriteLine("ERROR" + fe.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR" + e.Message);
            }

            Console.ReadKey();


        }

        public void eliminarEvento()
        {
            //DECLARANDO VARIABLES
            string lector, buscador, respuesta;
            bool busqueda = false;
            string[] campos = new string[4];

            try
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Para cancelar escriba /cancel\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Para borrar todos los eventos escriba /todos\n\n");

                Console.ForegroundColor = ConsoleColor.White;

                StreamReader lectura = File.OpenText("inf_eventos.txt");
                //DECLARAMOS UNA ESTANCIA StreamWriter PARA PODER EDITAR EL TEXTO Y USAMOS File.CreatText PARA CREAR UN ARCHIVO TEMPORAL 
                // QUE UTILIZAREMOS COMO REMPLAZO
                StreamWriter escribir = File.CreateText("temporal.txt");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("EVENTO QUE DESEA ELIMINAR: ");
                Console.ForegroundColor = ConsoleColor.White;
                //GUARDAMOS EL DATO A BUSCAR EN UNA VARIABLE buscador

                string entrada = Console.ReadLine().ToUpper();

                buscador = entrada;

                if (buscador == "/CANCEL")
                {
                    Console.Clear();
                    lectura.Close();
                    escribir.Close();
                    eventos_inicio();
                }

                //CONTENEMOS LA LECTURA DEL DOCUMENTO DE TEXTO EN UNA VARIABLE
                lector = lectura.ReadLine();
                //CREAMOS UN BUCLE QUE SE REPITA MIENTRAS LA VARIABLE LECTOR NO SEA NULA 
                //O SEA, SI EXISTE TEXTO EN EL DOCUMENTO SEGUIRA BUSCANDO HASTA ENCONTRAR LO QUE SE LE PIDE.
                while (lector != null)
                {
                    //CREAMOS UN ARRAY CAMPO QUE SEPARA LOS DATOS DEL DOCUMENTO EN POSICIONES DE ARRAY DIVIDIDOS POR UN SEPARADOR.
                    campos = lector.Split('║');

                    //COLOCAMOS UNA CONDICION QUE DICE: SI LA POSICION 0 DEL ARRAY campos COINCIDE CON EL BUSCADOR CAPTURA LOS VALORES E IMPRIME LO QUE ESTA
                    //DENTRO DEL IF, el ".Trim" SE UTILIZO PARA OBVIAR LOS ESPACIOS VACIOS Y ESQUIVAR ERRORES 
                    if ((campos[0].Trim().Equals(buscador)))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nInformación del evento\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t" + campos[0].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Fecha: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[1].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Hora: ");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[2].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Lugar: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[3].Trim() + "\n");
                        //SALIMOS DE LA BUSQUEDA ASIGNANDOLE AL BOOLEANO busqueda UN VALOR true POR LO QUE EL while NO SE CUMPLIRA
                        //Y EL BUCLE SE ROMPERA
                        busqueda = true;

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nDesea eliminar este evento? (SI/NO)");
                        Console.ForegroundColor = ConsoleColor.White;
                        respuesta = Console.ReadLine().ToUpper();


                        if (respuesta.Equals("SI"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Se ha eliminado el evento con exito");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            escribir.WriteLine(lector);
                        }

                    }
                    else if ((campos[1].Trim().Equals(buscador)))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nInformación del evento\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t" + campos[0].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Fecha: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[1].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Hora: ");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[2].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Lugar: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[3].Trim() + "\n");

                        busqueda = true;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nDesea eliminar este contacto? (SI/NO)");
                        Console.ForegroundColor = ConsoleColor.White;
                        respuesta = Console.ReadLine().ToUpper();


                        if (respuesta.Equals("SI"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Se ha eliminado el evento con exito");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            escribir.WriteLine(lector);
                        }

                    }
                    else if (((campos[0].Trim() + " " + campos[1].Trim()).Equals(buscador)))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nInformación del evento\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t" + campos[0].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Fecha: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[1].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Hora: ");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[2].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Lugar: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[3].Trim() + "\n");

                        busqueda = true;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nDesea eliminar este contacto? (SI/NO)");
                        Console.ForegroundColor = ConsoleColor.White;
                        respuesta = Console.ReadLine().ToUpper();


                        if (respuesta.Equals("SI"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Se ha eliminado el evento con exito");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            escribir.WriteLine(lector);
                        }

                    }
                    else if ((campos[2].Trim().Equals(buscador)))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nInformación del evento\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t" + campos[0].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Fecha: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[1].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Hora: ");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[2].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Lugar: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[3].Trim() + "\n");

                        busqueda = true;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nDesea eliminar este contacto? (SI/NO)");
                        Console.ForegroundColor = ConsoleColor.White;
                        respuesta = Console.ReadLine().ToUpper();


                        if (respuesta.Equals("SI"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Se ha eliminado el evento con exito");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            escribir.WriteLine(lector);
                        }

                    }
                    else if ((campos[3].Trim().Equals(buscador)))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nInformación del evento\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t" + campos[0].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Fecha: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[1].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Hora: ");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[2].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Lugar: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[3].Trim() + "\n");

                        busqueda = true;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nDesea eliminar este contacto? (SI/NO)");
                        Console.ForegroundColor = ConsoleColor.White;
                        respuesta = Console.ReadLine().ToUpper();


                        if (respuesta.Equals("SI"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Se ha eliminado el evento con exito");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            escribir.WriteLine(lector);
                        }

                    }

                    else if (buscador == "/TODOS")
                    {
                        busqueda = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nEstá seguro de eliminar todos los eventos? (SI/NO)");
                        Console.ForegroundColor = ConsoleColor.White;
                        respuesta = Console.ReadLine().ToUpper();


                        if (respuesta.Equals("SI"))
                        {
                            busqueda = true;
                            while (lector == null)
                            {

                                File.Delete("inf_eventos.txt");
                                File.Move("temporal.txt", "inf_eventos.txt");

                                lector = lectura.ReadLine();
                                escribir.WriteLine(lector);

                            }
                            //CERRAMOS LA LECTURA
                            lectura.Close();
                            //CERRAMOS LA ESCRITURA
                            escribir.Close();
                            //ELIMINAMOS EL DOCUMENTO DE TEXTO inf_contactos YA QUE AL PASAR TODO LO QUE HABIA EN EL ARCHIVO temporal.txt Y DEJAR 
                            //UNICAMENTE EL ARCHIVO QUE QUEREMOS ELIMINAR PUES SE ELIMINA. 
                            File.Delete("inf_eventos.txt");
                            //UTILIZAMOS .Move Y MOVEMOS A UN NUEVO DOCUMENTO DE TEXTO LLAMADO inf_contactos LOS CONTACTOS QUE NO HAN SIDO ELIMINADOS
                            File.Move("temporal.txt", "inf_eventos.txt");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Se han eliminado los eventos con exito");
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\n\nPresione una tecla para volver al menú principal");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey();
                            Console.Clear();
                            eventos_inicio();

                        }
                        else
                        {
                            escribir.WriteLine(lector);
                            lectura.Close();
                            escribir.Close();

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\n\nPresione una tecla para volver al menú principal");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey();
                            Console.Clear();
                            eventos_inicio();

                        }
                    }

                    else
                    {
                        //UTILIZAMOS LA ESTANCIA escribir Y ESCRIBIMOS SOBRE ELLA LOS DATOS QUE EXISTEN EN LA VARIABLE lector EXTRAIDA DEL
                        //DOCUMENTO DE TEXTO inf_eventos.txt a temporal.txt
                        escribir.WriteLine(lector);
                    }
                    //ESTA LINEA DE CODIGO SE UTILIZA PARA SEGUIR LEYENDO EL DOCUMENTO DE TEXTO inf_eventos.txt
                    lector = lectura.ReadLine();

                }//SI busqueda ES FALSO, O SEA, SI NO SE ENCONTRO NADA PARECIDO EJECUTA QUE NO SE ENCONTRO EL CONTACTO
                if (busqueda == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se encontró el evento");
                    Console.ForegroundColor = ConsoleColor.White;
                }// SI busqueda ES VERDADERO, O SEA, SI SE ENCONTRO EL CONTACTO ENVIA UN MENSAJE DE QUE HA SIDO ELIMINADO CON EXITO

                //CERRAMOS LA LECTURA
                lectura.Close();
                //CERRAMOS LA ESCRITURA
                escribir.Close();
                //ELIMINAMOS EL DOCUMENTO DE TEXTO inf_contactos YA QUE AL PASAR TODO LO QUE HABIA EN EL ARCHIVO temporal.txt Y DEJAR 
                //UNICAMENTE EL ARCHIVO QUE QUEREMOS ELIMINAR PUES SE ELIMINA. 
                File.Delete("inf_eventos.txt");
                //UTILIZAMOS .Move Y MOVEMOS A UN NUEVO DOCUMENTO DE TEXTO LLAMADO inf_contactos LOS CONTACTOS QUE NO HAN SIDO ELIMINADOS
                File.Move("temporal.txt", "inf_eventos.txt");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\nPresione una tecla para volver al menú principal");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
                eventos_inicio();
            }
            catch (FileNotFoundException fe)
            {
                Console.WriteLine("ERROR" + fe.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR" + e.Message);
            }

            Console.ReadKey();

        }

        public void editarEvento()
        {
            Console.Clear();
            string lector, buscador, edicion, respuesta;
            bool busqueda = false;
            string[] campos = new string[4];
            try
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Para cancelar escriba /cancel\n\n");
                Console.ForegroundColor = ConsoleColor.White;

                StreamReader lectura = File.OpenText("inf_eventos.txt");
                //DECLARAMOS UNA ESTANCIA StreamWriter PARA PODER EDITAR EL TEXTO Y USAMOS File.CreatText PARA CREAR UN ARCHIVO TEMPORAL 
                // QUE UTILIZAREMOS COMO REMPLAZO
                StreamWriter escribir = File.CreateText("temporal.txt");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("EVENTO QUE DESEA EDITAR: ");
                Console.ForegroundColor = ConsoleColor.White;
                //GUARDAMOS EL DATO A BUSCAR EN UNA VARIABLE buscador

                string entrada = Console.ReadLine().ToUpper();

                buscador = entrada;

                if (buscador == "/CANCEL")
                {
                    Console.Clear();
                    escribir.Close();
                    lectura.Close();
                    eventos_inicio();
                }

                //CONTENEMOS LA LECTURA DEL DOCUMENTO DE TEXTO EN UNA VARIABLE
                lector = lectura.ReadLine();
                //CREAMOS UN BUCLE QUE SE REPITA MIENTRAS LA VARIABLE LECTOR NO SEA NULA 
                //O SEA, SI EXISTE TEXTO EN EL DOCUMENTO SEGUIRA BUSCANDO HASTA ENCONTRAR LO QUE SE LE PIDE.
                while (lector != null)
                {
                    //CREAMOS UN ARRAY CAMPO QUE SEPARA LOS DATOS DEL DOCUMENTO EN POSICIONES DE ARRAY DIVIDIDOS POR UN SEPARADOR.
                    campos = lector.Split('║');

                    //COLOCAMOS UNA CONDICION QUE DICE: SI LA POSICION 0 DEL ARRAY campos COINCIDE CON EL BUSCADOR CAPTURA LOS VALORES E IMPRIME LO QUE ESTA
                    //DENTRO DEL IF, el ".Trim" SE UTILIZO PARA OBVIAR LOS ESPACIOS VACIOS Y ESQUIVAR ERRORES 

                    if ((campos[0].Trim().Equals(buscador)))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nInformación del evento\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t" + campos[0].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Fecha: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[1].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Hora: ");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[2].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Lugar: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[3].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nDesea editar este contacto? (SI/NO)");
                        Console.ForegroundColor = ConsoleColor.White;
                        respuesta = Console.ReadLine().ToUpper();


                        if (respuesta.Equals("SI"))
                        {
                            busqueda = true;

                            Console.Clear();
                            Console.WriteLine("Editar:\n\n1.Nombre\n2.Fecha\n3.Hora\n4.Lugar\n5.Atrás\n6.Salir");
                            string opcion_1;
                            string entrada_1 = Console.ReadLine();

                            bool esValido = false;
                            while (!esValido)
                            {
                                if (entrada_1 != "1" && entrada_1 != "2" && entrada_1 != "3" && entrada_1 != "4" && entrada_1 != "5" && entrada_1 != "6")
                                {
                                    esValido = false;
                                }
                                else
                                {
                                    esValido = true;
                                }

                                if (!esValido)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("OPCION INVALIDA, por favor ingrese una de las opciones disponibles");
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine(@"           
                █▀▀ █░█ █▀▀ █▄░█ ▀█▀ █▀█ █▀
                ██▄ ▀▄▀ ██▄ █░▀█ ░█░ █▄█ ▄█");

                                    Console.WriteLine("Editar:\n\n1.Nombre\n2.Fecha\n3.Hora\n4.Lugar\n5.Atrás\n6.Salir");

                                    entrada_1 = Console.ReadLine();

                                }
                            }

                            opcion_1 = entrada_1;

                            switch (opcion_1)
                            {
                                case "1":
                                    //nombre
                                    Console.Write("Ingresa el nuevo nombre: ");
                                    edicion = Console.ReadLine().ToUpper();
                                    escribir.WriteLine(edicion + "║" + campos[1] + "║" + campos[2] + "║" + campos[3]);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nEl evento se modificó con exito");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    busqueda = true;
                                    break;

                                case "2":
                                    //apellido
                                    Console.Write("Ingresa la nueva fecha: ");
                                    edicion = Console.ReadLine().ToUpper();
                                    escribir.WriteLine(campos[0] + "║" + edicion + "║" + campos[2] + "║" + campos[3]);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nEl evento se modificó con exito");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    busqueda = true;
                                    break;

                                case "3":
                                    //telefono
                                    Console.Write("Ingresa la nueva hora: ");
                                    edicion = Console.ReadLine().ToUpper();
                                    escribir.WriteLine(campos[0] + "║" + campos[1] + "║" + edicion + "║" + campos[3]);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nEl evento se modificó con exito");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    busqueda = true;

                                    break;
                                case "4":
                                    //direccion
                                    Console.Write("Ingresa el nuevo lugar: ");
                                    edicion = Console.ReadLine().ToUpper();
                                    escribir.WriteLine(campos[0] + "║" + campos[1] + "║" + campos[2] + "║" + edicion);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nEl evento se modificó con exito");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    busqueda = true;

                                    break;


                                /* case "5":
                                     //correo
                                     Console.Write("Ingresa el nuevo correo electrónico: ");
                                     edicion = Console.ReadLine().ToUpper();
                                     escribir.WriteLine(campos[0] + "║" + campos[1] + "║" + campos[2] + "║" + campos[3] + "║" + edicion);
                                     Console.ForegroundColor = ConsoleColor.Green;
                                     Console.WriteLine("\nEl evento se modificó con exito");
                                     Console.ForegroundColor = ConsoleColor.White;
                                     busqueda = true;
                                     break;*/

                                case "6":
                                    string[] informacion_contacto = { "NOMBRE", "FECHA", "HORA", "LUGAR" };
                                    string[] nueva_info = new string[informacion_contacto.Length];

                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("\nEditar información del evento\n");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    for (int i = 0; i < informacion_contacto.Length; i++)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine(informacion_contacto[i]);
                                        Console.ForegroundColor = ConsoleColor.Yellow;

                                        nueva_info[i] = Console.ReadLine().ToUpper();

                                        Console.ForegroundColor = ConsoleColor.Green;

                                    }
                                    escribir.WriteLine(nueva_info[0] + " ║ " + nueva_info[1] + " ║ " + nueva_info[2] + " ║ " + nueva_info[3]);
                                    Console.WriteLine("\nEl evento se modificó con exito");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    busqueda = true;

                                    break;
                                case "7":
                                    Console.Clear();
                                    eventos_inicio();
                                    break;
                                case "8":
                                    Environment.Exit(0);
                                    break;
                            }
                        }
                        else
                        {
                            escribir.WriteLine(lector);
                        }

                    }
                    else
                    {
                        //UTILIZAMOS LA ESTANCIA escribir Y ESCRIBIMOS SOBRE ELLA LOS DATOS QUE EXISTEN EN LA VARIABLE lector EXTRAIDA DEL
                        //DOCUMENTO DE TEXTO inf_eventos.txt a temporal.txt
                        escribir.WriteLine(lector);
                    }
                    //ESTA LINEA DE CODIGO SE UTILIZA PARA SEGUIR LEYENDO EL DOCUMENTO DE TEXTO inf_eventos.txt
                    lector = lectura.ReadLine();

                }
                if (busqueda == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se encontró el evento");
                    Console.ForegroundColor = ConsoleColor.White;
                }//SI busqueda ES FALSO, O SEA, SI NO SE ENCONTRO NADA PARECIDO EJECUTA QUE NO SE ENCONTRO EL CONTACTO
                 // SI busqueda ES VERDADERO, O SEA, SI SE ENCONTRO EL CONTACTO ENVIA UN MENSAJE DE QUE HA SIDO ELIMINADO CON EXITO

                //CERRAMOS LA LECTURA
                lectura.Close();
                //CERRAMOS LA ESCRITURA
                escribir.Close();
                //ELIMINAMOS EL DOCUMENTO DE TEXTO inf_contactos YA QUE AL PASAR TODO LO QUE HABIA EN EL ARCHIVO temporal.txt Y DEJAR 
                //UNICAMENTE EL ARCHIVO QUE QUEREMOS ELIMINAR PUES SE ELIMINA. 
                File.Delete("inf_eventos.txt");
                //UTILIZAMOS .Move Y MOVEMOS A UN NUEVO DOCUMENTO DE TEXTO LLAMADO inf_contactos LOS CONTACTOS QUE NO HAN SIDO ELIMINADOS
                File.Move("temporal.txt", "inf_eventos.txt");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\nPresione una tecla para volver al menú principal");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
                eventos_inicio();
            }
            catch (FileNotFoundException fe)
            {
                Console.WriteLine("ERROR" + fe.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR" + e.Message);
            }

        }

        public void verEvento()
        {
            Console.Clear();
            //DECLARANDO VARIABLES
            string lector;
            bool busqueda = false;
            string[] campos = new string[4];

            try
            {
                StreamReader lectura = File.OpenText("inf_eventos.txt");
                Console.ForegroundColor = ConsoleColor.Blue;

                lector = lectura.ReadLine();

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(@"           
                █▀▀ █░█ █▀▀ █▄░█ ▀█▀ █▀█ █▀
                ██▄ ▀▄▀ ██▄ █░▀█ ░█░ █▄█ ▄█");
                Console.WriteLine("\n");
                while (lector != null)
                {
                    campos = lector.Split('║');

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nInformación del evento\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\t" + campos[0].Trim() + "\n");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Fecha: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(campos[1].Trim() + "\n");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Hora: ");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(campos[2].Trim() + "\n");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Lugar: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(campos[3].Trim() + "\n");

                    busqueda = true;
                    lector = lectura.ReadLine();

                }
                if (busqueda == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se encontraron eventos");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                lectura.Close();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\nPresione una tecla para volver al menú principal");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
                eventos_inicio();
            }
            catch (FileNotFoundException fe)
            {
                Console.WriteLine("ERROR" + fe.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR" + e.Message);
            }

            Console.ReadKey();
        }
    }

    class contactos
    {
        public void contactos_inicio()
        {
            Console.WriteLine(@"           
            █▀▀ █▀█ █▄░█ ▀█▀ ▄▀█ █▀▀ ▀█▀ █▀█ █▀
            █▄▄ █▄█ █░▀█ ░█░ █▀█ █▄▄ ░█░ █▄█ ▄█");

            Console.WriteLine("1.Buscar contacto\n2.Agregar contacto\n3.Editar contacto\n4.Eliminar contacto\n5.Ver contactos\n6.Atras\n7.Salir");

            string opcion;
            string entrada = Console.ReadLine();

            bool esValido = false;
            while (!esValido)
            {
                if (entrada != "1" && entrada != "2" && entrada != "3" && entrada != "4" && entrada != "5" && entrada != "6" && entrada != "7")
                {
                    esValido = false;
                }
                else
                {
                    esValido = true;
                }

                if (!esValido)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("OPCION INVALIDA, por favor ingrese una de las opciones disponibles");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(@"           
                █▀▀ █░█ █▀▀ █▄░█ ▀█▀ █▀█ █▀
                ██▄ ▀▄▀ ██▄ █░▀█ ░█░ █▄█ ▄█");

                    Console.WriteLine("1.Buscar contacto\n2.Agregar contacto\n3.Editar contacto\n4.Eliminar contacto\n5.Ver contactos\n6.Atras\n7.Salir");

                    entrada = Console.ReadLine();
                }
            }

            opcion = entrada;

            switch (opcion)
            {
                case "1":
                    buscarContactos();
                    break;
                case "2":
                    agregarContactos();
                    break;
                case "3":
                    editarContacto();
                    break;
                case "4":
                    eliminarContacto();
                    break;
                case "5":
                    verContactos();
                    break;
                case "6":
                    Console.Clear();
                    agenda.agenda_inicio();
                    break;
                case "7":
                    Console.Clear();
                    Console.WriteLine("Hasta luego! :)");
                    Environment.Exit(0);
                    break;

            }

        }

        public void agregarContactos()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Para cancelar escriba /cancel\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                //CREANDO UN ARRAY PARA QUE VAYA PIDIENDO ESOS CAMPOS
                string[] informacion_contacto = { "NOMBRE", "APELLIDO", "TELEFONO", "DIRECCION", "EMAIL" };
                string[] informacion = new string[informacion_contacto.Length];

                //DECLARANDO VARIABLES A UTILIZAR
                string respuesta;

                // CREANDO BUCLE QUE REPITA EL CODIGO DE AGREGAR CONTACTO
                do
                {
                    //CREANDO ESTANCIA DEL DOCUMENTO DE TEXTO(CONTACTOS) QUE GUARDARA LA INFORMACION
                    StreamWriter contactos = File.AppendText("inf_contactos.txt");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    //********     ESTRUCTURA DE LA SECCION DE AGREGAR CONTACTO    ******
                    Console.WriteLine("\nInformación de contacto\n");
                    Console.ForegroundColor = ConsoleColor.White;

                    //CREANDO UN FOR QUE RECORRA EL ARRAY DE LOS CAMPOS REQUERIDOS
                    for (int i = 0; i < informacion_contacto.Length; i++)
                    {

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(informacion_contacto[i]);
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        //EL ARREGLO informacion LEERA LA INFORMACION QUE EL USUARIO VA INGRESANDO Y EL contactos.write LO QUE HARA 
                        // ES TOMAR ESA INFORMACION QUE HA SIDO GUARDADA EN LA VARIABLE CONTACTOS Y LO AÑADIRA AL DOCUMENTO DE TEXTO
                        // inf_contactos.txt DE IGUAL MANERA SE LE COLOCA UN SEPARADOR PARA PODER DISTINGUIR EL RECORRIDO DEL BUCLE FOR.
                        //NOTA IMPORTANTE: PARA QUE LA PROPIEDAD .write SE PUEDA USAR EN LA ESTANCIA DEL DOCUMENTO DE TEXTO FUE NECESARIO 
                        // El USAR StreamWriter QUE ESCRIBE SOBRE UN DOCUMENTO DE TEXTO ESPECIFICADO.

                        here3:
                        informacion[i] = Console.ReadLine().ToUpper();

                        if (informacion[i] == " ")
                        {
                            Console.WriteLine("Por favor ingrese texto, cadena vacia");
                            goto here3;
                        }
                        else if (informacion[i] == "")
                        {
                            Console.WriteLine("Por favor ingrese texto, cadena vacia");
                            goto here3;
                        }


                        if (informacion[i] == "/CANCEL")
                        {
                            Console.Clear();
                            contactos.Close();
                            Console.ForegroundColor = ConsoleColor.White;
                            contactos_inicio();

                        }
                    }
                    contactos.WriteLine(informacion[0] + " ║ " + informacion[1] + " ║ " + informacion[2] + " ║ " + informacion[3] + " ║ " + informacion[4]);
                    //TERMINA EL RECORRIDO DEL BUCLE FOR POR LO QUE, TODOS LOS DATOS DEL CONTACTOHAN SIDO PEDIDOS Y GUARDADOS
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("CONTACTO GUARDADO");
                    //SE CIERRA LA EJERCICION DE StreamWrite PARA QUE LOS DATOS ESCRITOS SE GUARDEN CORRECTAMENTE Y NO SIGA EN 
                    //EJECUCION.
                    contactos.Close();
                    //SE LE PIDE AL USUARIO SI DESEA AGREGAR UN NUEVO CONTACTO, EN CASO DE QUE LA RESPUESTA SEA SI EL BUCLE SE REPETIRA
                    //EN CASO DE SER NO SE TERMINA EL BUCLE Y SE VUELVE AL MENU INICIAL
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Desea crear un contacto nuevo (SI/NO)?");
                    //ESTA LINEA DE CODIGO LEE LA RESPUESTA DEL USUARIO Y TOMA ESA RESPUESTA CONVIRTIENDOLA EN MAYUSCULA PARA EVITAR 
                    //ERRORES
                    respuesta = (Console.ReadLine()).ToUpper();
                    // ESTA LINEA DE CODIGO BASICAMENTE DICE: SI LA RESPUESTA ES "SI" ESTE CODIGO SEGUIRA EJECUTANDOSE, DE SER "NO"
                    //DETEN ESTE BUCLE.
                } while (respuesta.Equals("SI"));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\nPresione una tecla para volver al menú principal");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
                contactos_inicio();

            }//EN CASO DE QUE NO SE ENCUENTRE EL ARCHIVO 
            catch (FileNotFoundException)
            {
                Console.WriteLine("No se encontró el archivo");
            }
            Console.ReadLine();

        }

        public void buscarContactos()
        {
            //DECLARANDO VARIABLES
            string lector, buscador;
            bool busqueda = false;
            string[] campos = new string[5];

            try
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Para cancelar escriba /cancel\n\n");
                Console.ForegroundColor = ConsoleColor.White;

                StreamReader lectura = File.OpenText("inf_contactos.txt");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("BUSCADOR: ");
                Console.ForegroundColor = ConsoleColor.White;

                string entrada = Console.ReadLine().ToUpper();
                bool esValido = false;
                while (!esValido)
                {
                    if (entrada == " ")
                    {
                        esValido = false;
                    }
                    else if (entrada == "")
                    {
                        esValido = false;
                    }
                    else
                    {
                        esValido = true;
                    }

                    if (!esValido)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("La entrada es invalida, por favor ingrese un texto");
                        Thread.Sleep(3000);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(@"           
                █▀▀ █░█ █▀▀ █▄░█ ▀█▀ █▀█ █▀
                ██▄ ▀▄▀ ██▄ █░▀█ ░█░ █▄█ ▄█");

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("\nBUSCADOR: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        entrada = Console.ReadLine().ToUpper();
                    }
                }
                buscador = entrada;
                //CONTENEMOS LA LECTURA DEL DOCUMENTO DE TEXTO EN UNA VARIABLE
                lector = lectura.ReadLine();
                //CREAMOS UN BUCLE QUE SE REPITA MIENTRAS LA VARIABLE LECTOR NO SEA NULA Y EL BOOLEANO busqueda SEA FALSO
                //O SEA, SI EXISTE TEXTO EN EL DOCUMENTO SEGUIRA BUSCANDO HASTA ENCONTRAR LO QUE SE LE PIDE.
                while (lector != null)
                {
                    //CREAMOS UN ARRAY CAMPO QUE SEPARA LOS DATOS DEL DOCUMENTO EN POSICIONES DE ARRAY DIVIDIDOS POR UN SEPARADOR.
                    campos = lector.Split('║');


                    //COLOCAMOS UNA CONDICION QUE DICE: SI LA POSICION 0 DEL ARRAY campos COINCIDE CON EL BUSCADOR CAPTURA LOS VALORES E IMPRIME LO QUE ESTA
                    //DENTRO DEL IF, el ".Trim" SE UTILIZO PARA OBVIAR LOS ESPACIOS VACIOS Y ESQUIVAR ERRORES 
                    if (buscador == "/CANCEL")
                    {
                        Console.Clear();
                        lectura.Close();
                        contactos_inicio();
                    }

                    if ((campos[0].Trim().Equals(buscador)))
                    {

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nInformación de contacto\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t" + campos[0].Trim() + " " + campos[1].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Teléfono: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[2].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Dirección: ");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[3].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Email: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[4].Trim() + "\n");
                        //SALIMOS DE LA BUSQUEDA ASIGNANDOLE AL BOOLEANO busqueda UN VALOR true POR LO QUE EL while NO SE CUMPLIRA
                        //Y EL BUCLE SE ROMPERA
                        busqueda = true;

                    }
                    else if ((campos[1].Trim().Equals(buscador)))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nInformación de contacto\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t" + campos[0].Trim() + " " + campos[1].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Teléfono: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[2].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Dirección: ");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[3].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Email: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[4].Trim() + "\n");

                        busqueda = true;

                    }
                    else if (((campos[0].Trim() + " " + campos[1].Trim()).Equals(buscador)))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nInformación de contacto\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t" + campos[0].Trim() + " " + campos[1].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Teléfono: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[2].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Dirección: ");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[3].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Email: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[4].Trim() + "\n");
                        busqueda = true;

                    }
                    else if ((campos[2].Trim().Equals(buscador)))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nInformación de contacto\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t" + campos[0].Trim() + " " + campos[1].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Teléfono: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[2].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Dirección: ");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[3].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Email: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[4].Trim() + "\n");
                        busqueda = true;

                    }
                    else if ((campos[3].Trim().Equals(buscador)))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nInformación de contacto\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t" + campos[0].Trim() + " " + campos[1].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Teléfono: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[2].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Dirección: ");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[3].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Email: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[4].Trim() + "\n");
                        busqueda = true;

                    }
                    else if ((campos[4].Trim().Equals(buscador)))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nInformación de contacto\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t" + campos[0].Trim() + " " + campos[1].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Teléfono: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[2].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Dirección: ");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[3].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Email: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[4].Trim() + "\n");
                        busqueda = true;

                    }

                    //EN CASO DE NO ENCOTRAR LE DECIMOS A LA VARIABLE LECTOR, SIGUE LEYENDO             
                    lector = lectura.ReadLine();

                    //SI busqueda ES FALSO, O SEA, SI NO SE ENCONTRO NADA PARECIDO EJECUTA QUE NO SE ENCONTRO EL CONTACTO
                }

                if (busqueda == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se encontró el contacto");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                lectura.Close();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\nPresione una tecla para volver al menú principal");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
                contactos_inicio();
                //CERRAMOS LA LECTURA

            }
            catch (FileNotFoundException fe)
            {
                Console.WriteLine("ERROR" + fe.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR" + e.Message);
            }

            Console.ReadKey();


        }

        public void eliminarContacto()
        {
            //DECLARANDO VARIABLES
            string lector, buscador, respuesta;
            bool busqueda = false;
            string[] campos = new string[5];

            try
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Para cancelar escriba /cancel\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Para borrar todos los contactos escriba /todos\n\n");

                Console.ForegroundColor = ConsoleColor.White;

                StreamReader lectura = File.OpenText("inf_contactos.txt");
                //DECLARAMOS UNA ESTANCIA StreamWriter PARA PODER EDITAR EL TEXTO Y USAMOS File.CreatText PARA CREAR UN ARCHIVO TEMPORAL 
                // QUE UTILIZAREMOS COMO REMPLAZO
                StreamWriter escribir = File.CreateText("temporal.txt");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("CONTACTO QUE DESEA ELIMINAR: ");
                Console.ForegroundColor = ConsoleColor.White;
                //GUARDAMOS EL DATO A BUSCAR EN UNA VARIABLE buscador

                string entrada = Console.ReadLine().ToUpper();

                buscador = entrada;

                if (buscador == "/CANCEL")
                {
                    Console.Clear();
                    lectura.Close();
                    escribir.Close();
                    contactos_inicio();
                }

                //CONTENEMOS LA LECTURA DEL DOCUMENTO DE TEXTO EN UNA VARIABLE
                lector = lectura.ReadLine();
                //CREAMOS UN BUCLE QUE SE REPITA MIENTRAS LA VARIABLE LECTOR NO SEA NULA 
                //O SEA, SI EXISTE TEXTO EN EL DOCUMENTO SEGUIRA BUSCANDO HASTA ENCONTRAR LO QUE SE LE PIDE.
                while (lector != null)
                {
                    //CREAMOS UN ARRAY CAMPO QUE SEPARA LOS DATOS DEL DOCUMENTO EN POSICIONES DE ARRAY DIVIDIDOS POR UN SEPARADOR.
                    campos = lector.Split('║');

                    //COLOCAMOS UNA CONDICION QUE DICE: SI LA POSICION 0 DEL ARRAY campos COINCIDE CON EL BUSCADOR CAPTURA LOS VALORES E IMPRIME LO QUE ESTA
                    //DENTRO DEL IF, el ".Trim" SE UTILIZO PARA OBVIAR LOS ESPACIOS VACIOS Y ESQUIVAR ERRORES 
                    if ((campos[0].Trim().Equals(buscador)))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nInformación de contacto\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t" + campos[0].Trim() + " " + campos[1].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Teléfono: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[2].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Dirección: ");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[3].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Email: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[4].Trim() + "\n");

                        busqueda = true;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nDesea eliminar este contacto? (SI/NO)");
                        Console.ForegroundColor = ConsoleColor.White;
                        respuesta = Console.ReadLine().ToUpper();


                        if (respuesta.Equals("SI"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Se ha eliminado el contacto con exito");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            escribir.WriteLine(lector);
                        }

                    }
                    else if ((campos[1].Trim().Equals(buscador)))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nInformación de contacto\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t" + campos[0].Trim() + " " + campos[1].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Teléfono: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[2].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Dirección: ");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[3].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Email: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[4].Trim() + "\n");

                        busqueda = true;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nDesea eliminar este contacto? (SI/NO)");
                        Console.ForegroundColor = ConsoleColor.White;
                        respuesta = Console.ReadLine().ToUpper();


                        if (respuesta.Equals("SI"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Se ha eliminado el contacto con exito");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            escribir.WriteLine(lector);
                        }

                    }
                    else if (((campos[0].Trim() + " " + campos[1].Trim()).Equals(buscador)))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nInformación de contacto\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t" + campos[0].Trim() + " " + campos[1].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Teléfono: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[2].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Dirección: ");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[3].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Email: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[4].Trim() + "\n");

                        busqueda = true;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nDesea eliminar este contacto? (SI/NO)");
                        Console.ForegroundColor = ConsoleColor.White;
                        respuesta = Console.ReadLine().ToUpper();


                        if (respuesta.Equals("SI"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Se ha eliminado el contacto con exito");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            escribir.WriteLine(lector);
                        }

                    }
                    else if ((campos[2].Trim().Equals(buscador)))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nInformación de contacto\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t" + campos[0].Trim() + " " + campos[1].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Teléfono: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[2].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Dirección: ");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[3].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Email: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[4].Trim() + "\n");

                        busqueda = true;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nDesea eliminar este contacto? (SI/NO)");
                        Console.ForegroundColor = ConsoleColor.White;
                        respuesta = Console.ReadLine().ToUpper();


                        if (respuesta.Equals("SI"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Se ha eliminado el contacto con exito");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            escribir.WriteLine(lector);
                        }

                    }
                    else if ((campos[3].Trim().Equals(buscador)))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nInformación de contacto\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t" + campos[0].Trim() + " " + campos[1].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Teléfono: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[2].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Dirección: ");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[3].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Email: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[4].Trim() + "\n");

                        busqueda = true;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nDesea eliminar este contacto? (SI/NO)");
                        Console.ForegroundColor = ConsoleColor.White;
                        respuesta = Console.ReadLine().ToUpper();


                        if (respuesta.Equals("SI"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Se ha eliminado el contacto con exito");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            escribir.WriteLine(lector);
                        }

                    }
                    else if ((campos[4].Trim().Equals(buscador)))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nInformación de contacto\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t" + campos[0].Trim() + " " + campos[1].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Teléfono: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[2].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Dirección: ");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[3].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Email: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[4].Trim() + "\n");

                        busqueda = true;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nDesea eliminar este contacto? (SI/NO)");
                        Console.ForegroundColor = ConsoleColor.White;
                        respuesta = Console.ReadLine().ToUpper();


                        if (respuesta.Equals("SI"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Se ha eliminado el contacto con exito");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            escribir.WriteLine(lector);
                        }
                    }
                    else if (buscador == "/TODOS")
                    {
                        busqueda = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nEstá seguro de eliminar todos los contactos? (SI/NO)");
                        Console.ForegroundColor = ConsoleColor.White;
                        respuesta = Console.ReadLine().ToUpper();


                        if (respuesta.Equals("SI"))
                        {
                            busqueda = true;
                            while (lector == null)
                            {

                                File.Delete("inf_contactos.txt");
                                File.Move("temporal.txt", "inf_contactos.txt");

                                lector = lectura.ReadLine();
                                escribir.WriteLine(lector);

                            }
                            //CERRAMOS LA LECTURA
                            lectura.Close();
                            //CERRAMOS LA ESCRITURA
                            escribir.Close();
                            //ELIMINAMOS EL DOCUMENTO DE TEXTO inf_contactos YA QUE AL PASAR TODO LO QUE HABIA EN EL ARCHIVO temporal.txt Y DEJAR 
                            //UNICAMENTE EL ARCHIVO QUE QUEREMOS ELIMINAR PUES SE ELIMINA. 
                            File.Delete("inf_contactos.txt");
                            //UTILIZAMOS .Move Y MOVEMOS A UN NUEVO DOCUMENTO DE TEXTO LLAMADO inf_contactos LOS CONTACTOS QUE NO HAN SIDO ELIMINADOS
                            File.Move("temporal.txt", "inf_contactos.txt");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Se han eliminado los contactos con exito");
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\n\nPresione una tecla para volver al menú principal");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey();
                            Console.Clear();
                            contactos_inicio();

                        }
                        else
                        {
                            escribir.WriteLine(lector);
                            lectura.Close();
                            escribir.Close();

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\n\nPresione una tecla para volver al menú principal");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey();
                            Console.Clear();
                            contactos_inicio();

                        }
                    }

                    else
                    {
                        //UTILIZAMOS LA ESTANCIA escribir Y ESCRIBIMOS SOBRE ELLA LOS DATOS QUE EXISTEN EN LA VARIABLE lector EXTRAIDA DEL
                        //DOCUMENTO DE TEXTO inf_contactos.txt a temporal.txt
                        escribir.WriteLine(lector);
                    }
                    //ESTA LINEA DE CODIGO SE UTILIZA PARA SEGUIR LEYENDO EL DOCUMENTO DE TEXTO inf_contactos.txt
                    lector = lectura.ReadLine();

                }//SI busqueda ES FALSO, O SEA, SI NO SE ENCONTRO NADA PARECIDO EJECUTA QUE NO SE ENCONTRO EL CONTACTO
                if (busqueda == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se encontró el contacto");
                    Console.ForegroundColor = ConsoleColor.White;
                }// SI busqueda ES VERDADERO, O SEA, SI SE ENCONTRO EL CONTACTO ENVIA UN MENSAJE DE QUE HA SIDO ELIMINADO CON EXITO

                //CERRAMOS LA LECTURA
                lectura.Close();
                //CERRAMOS LA ESCRITURA
                escribir.Close();
                //ELIMINAMOS EL DOCUMENTO DE TEXTO inf_contactos YA QUE AL PASAR TODO LO QUE HABIA EN EL ARCHIVO temporal.txt Y DEJAR 
                //UNICAMENTE EL ARCHIVO QUE QUEREMOS ELIMINAR PUES SE ELIMINA. 
                File.Delete("inf_contactos.txt");
                //UTILIZAMOS .Move Y MOVEMOS A UN NUEVO DOCUMENTO DE TEXTO LLAMADO inf_contactos LOS CONTACTOS QUE NO HAN SIDO ELIMINADOS
                File.Move("temporal.txt", "inf_contactos.txt");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\nPresione una tecla para volver al menú principal");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
                contactos_inicio();
            }
            catch (FileNotFoundException fe)
            {
                Console.WriteLine("ERROR" + fe.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR" + e.Message);
            }

            Console.ReadKey();

        }

        public void editarContacto()
        {
            Console.Clear();
            string lector, buscador, edicion, respuesta;
            bool busqueda = false;
            string[] campos = new string[4];
            try
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Para cancelar escriba /cancel\n\n");
                Console.ForegroundColor = ConsoleColor.White;

                StreamReader lectura = File.OpenText("inf_contactos.txt");
                //DECLARAMOS UNA ESTANCIA StreamWriter PARA PODER EDITAR EL TEXTO Y USAMOS File.CreatText PARA CREAR UN ARCHIVO TEMPORAL 
                // QUE UTILIZAREMOS COMO REMPLAZO
                StreamWriter escribir = File.CreateText("temporal.txt");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("CONTACTO QUE DESEA EDITAR: ");
                Console.ForegroundColor = ConsoleColor.White;
                //GUARDAMOS EL DATO A BUSCAR EN UNA VARIABLE buscador

                string entrada = Console.ReadLine().ToUpper();

                buscador = entrada;

                if (buscador == "/CANCEL")
                {
                    Console.Clear();
                    escribir.Close();
                    lectura.Close();
                    contactos_inicio();
                }

                //CONTENEMOS LA LECTURA DEL DOCUMENTO DE TEXTO EN UNA VARIABLE
                lector = lectura.ReadLine();
                //CREAMOS UN BUCLE QUE SE REPITA MIENTRAS LA VARIABLE LECTOR NO SEA NULA 
                //O SEA, SI EXISTE TEXTO EN EL DOCUMENTO SEGUIRA BUSCANDO HASTA ENCONTRAR LO QUE SE LE PIDE.
                while (lector != null)
                {
                    //CREAMOS UN ARRAY CAMPO QUE SEPARA LOS DATOS DEL DOCUMENTO EN POSICIONES DE ARRAY DIVIDIDOS POR UN SEPARADOR.
                    campos = lector.Split('║');

                    //COLOCAMOS UNA CONDICION QUE DICE: SI LA POSICION 0 DEL ARRAY campos COINCIDE CON EL BUSCADOR CAPTURA LOS VALORES E IMPRIME LO QUE ESTA
                    //DENTRO DEL IF, el ".Trim" SE UTILIZO PARA OBVIAR LOS ESPACIOS VACIOS Y ESQUIVAR ERRORES 

                    if ((campos[0].Trim().Equals(buscador)))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nInformación de contacto\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Nombre: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[0].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Apellido: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[1].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Teléfono: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[2].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Dirección: ");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[3].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Email: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(campos[4].Trim() + "\n");

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nDesea editar este contacto? (SI/NO)");
                        Console.ForegroundColor = ConsoleColor.White;
                        respuesta = Console.ReadLine().ToUpper();


                        if (respuesta.Equals("SI"))
                        {
                            busqueda = true;

                            Console.Clear();
                            Console.WriteLine("Editar:\n\n1.Nombre\n2.Apellido\n3.Teléfono\n4.Dirección\n5.Correo electronicon\n6.Editar todo\n7.Atrás\n8.Salir ");
                            string opcion_1;
                            string entrada_1 = Console.ReadLine();

                            bool esValido = false;
                            while (!esValido)
                            {
                                if (entrada_1 != "1" && entrada_1 != "2" && entrada_1 != "3" && entrada_1 != "4" && entrada_1 != "5" && entrada_1 != "6" && entrada_1 != "7" && entrada_1 != "8")
                                {
                                    esValido = false;
                                }
                                else
                                {
                                    esValido = true;
                                }

                                if (!esValido)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("OPCION INVALIDA, por favor ingrese una de las opciones disponibles");
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine(@"           
                █▀▀ █░█ █▀▀ █▄░█ ▀█▀ █▀█ █▀
                ██▄ ▀▄▀ ██▄ █░▀█ ░█░ █▄█ ▄█");

                                    Console.WriteLine("Editar:\n\n1.Nombre\n2.Apellido\n3.Teléfono\n4.Dirección\n5.Correo electronicon\n6.Editar todo\n7.Atrás\n8.Salir ");

                                    entrada_1 = Console.ReadLine();

                                }
                            }


                            opcion_1 = entrada_1;

                            switch (opcion_1)
                            {
                                case "1":
                                    //nombre
                                    Console.Write("Ingresa el nuevo nombre: ");
                                    edicion = Console.ReadLine().ToUpper();
                                    escribir.WriteLine(edicion + "║" + campos[1] + "║" + campos[2] + "║" + campos[3] + "║" + campos[4]);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nEl contacto se modificó con exito");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    busqueda = true;
                                    break;

                                case "2":
                                    //apellido
                                    Console.Write("Ingresa el nuevo apellido: ");
                                    edicion = Console.ReadLine().ToUpper();
                                    escribir.WriteLine(campos[0] + "║" + edicion + "║" + campos[2] + "║" + campos[3] + "║" + campos[4]);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nEl contacto se modificó con exito");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    busqueda = true;
                                    break;

                                case "3":
                                    //telefono
                                    Console.Write("Ingresa el nuevo teléfono: ");
                                    edicion = Console.ReadLine().ToUpper();
                                    escribir.WriteLine(campos[0] + "║" + campos[1] + "║" + edicion + "║" + campos[3] + "║" + campos[4]);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nEl contacto se modificó con exito");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    busqueda = true;

                                    break;
                                case "4":
                                    //direccion
                                    Console.Write("Ingresa la nueva dirección: ");
                                    edicion = Console.ReadLine().ToUpper();
                                    escribir.WriteLine(campos[0] + "║" + campos[1] + "║" + campos[2] + "║" + edicion + "║" + campos[4]);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nEl contacto se modificó con exito");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    busqueda = true;

                                    break;


                                case "5":
                                    //correo
                                    Console.Write("Ingresa el nuevo correo electrónico: ");
                                    edicion = Console.ReadLine().ToUpper();
                                    escribir.WriteLine(campos[0] + "║" + campos[1] + "║" + campos[2] + "║" + campos[3] + "║" + edicion);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nEl contacto se modificó con exito");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    busqueda = true;
                                    break;

                                case "6":
                                    string[] informacion_contacto = { "NOMBRE ", "APELLIDO", "TELEFONO", "DIRECCION", "EMAIL" };
                                    string[] nueva_info = new string[informacion_contacto.Length];

                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("\nEditar información de contacto\n");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    for (int i = 0; i < informacion_contacto.Length; i++)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine(informacion_contacto[i]);
                                        Console.ForegroundColor = ConsoleColor.Yellow;

                                        nueva_info[i] = Console.ReadLine().ToUpper();

                                        Console.ForegroundColor = ConsoleColor.Green;

                                    }
                                    escribir.WriteLine(nueva_info[0] + " ║ " + nueva_info[1] + " ║ " + nueva_info[2] + " ║ " + nueva_info[3] + " ║ " + nueva_info[4]);
                                    Console.WriteLine("\nEl contacto se modificó con exito");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    busqueda = true;

                                    break;
                                case "7":
                                    Console.Clear();
                                    contactos_inicio();
                                    break;
                                case "8":
                                    Environment.Exit(0);
                                    break;
                            }
                        }
                        else
                        {
                            escribir.WriteLine(lector);
                        }

                    }
                    else
                    {
                        //UTILIZAMOS LA ESTANCIA escribir Y ESCRIBIMOS SOBRE ELLA LOS DATOS QUE EXISTEN EN LA VARIABLE lector EXTRAIDA DEL
                        //DOCUMENTO DE TEXTO inf_contactos.txt a temporal.txt
                        escribir.WriteLine(lector);
                    }
                    //ESTA LINEA DE CODIGO SE UTILIZA PARA SEGUIR LEYENDO EL DOCUMENTO DE TEXTO inf_contactos.txt
                    lector = lectura.ReadLine();

                }
                if (busqueda == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se encontró el contacto");
                    Console.ForegroundColor = ConsoleColor.White;
                }//SI busqueda ES FALSO, O SEA, SI NO SE ENCONTRO NADA PARECIDO EJECUTA QUE NO SE ENCONTRO EL CONTACTO
                 // SI busqueda ES VERDADERO, O SEA, SI SE ENCONTRO EL CONTACTO ENVIA UN MENSAJE DE QUE HA SIDO ELIMINADO CON EXITO

                //CERRAMOS LA LECTURA
                lectura.Close();
                //CERRAMOS LA ESCRITURA
                escribir.Close();
                //ELIMINAMOS EL DOCUMENTO DE TEXTO inf_contactos YA QUE AL PASAR TODO LO QUE HABIA EN EL ARCHIVO temporal.txt Y DEJAR 
                //UNICAMENTE EL ARCHIVO QUE QUEREMOS ELIMINAR PUES SE ELIMINA. 
                File.Delete("inf_contactos.txt");
                //UTILIZAMOS .Move Y MOVEMOS A UN NUEVO DOCUMENTO DE TEXTO LLAMADO inf_contactos LOS CONTACTOS QUE NO HAN SIDO ELIMINADOS
                File.Move("temporal.txt", "inf_contactos.txt");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\nPresione una tecla para volver al menú principal");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
                contactos_inicio();
            }
            catch (FileNotFoundException fe)
            {
                Console.WriteLine("ERROR" + fe.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR" + e.Message);
            }

        }

        public void verContactos()
        {
            Console.Clear();
            //DECLARANDO VARIABLES
            string lector;
            bool busqueda = false;
            string[] campos = new string[5];

            try
            {
                StreamReader lectura = File.OpenText("inf_contactos.txt");
                Console.ForegroundColor = ConsoleColor.Blue;

                lector = lectura.ReadLine();

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(@"           
                █▀▀ █░█ █▀▀ █▄░█ ▀█▀ █▀█ █▀
                ██▄ ▀▄▀ ██▄ █░▀█ ░█░ █▄█ ▄█

");
                Console.WriteLine("\n");
                while (lector != null)
                {
                    campos = lector.Split('║');

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nInformación de contacto\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\t" + campos[0].Trim() + " " + campos[1].Trim() + "\n");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Teléfono: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(campos[2].Trim() + "\n");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Dirección: ");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(campos[3].Trim() + "\n");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Email: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(campos[4].Trim() + "\n");

                    busqueda = true;
                    lector = lectura.ReadLine();

                }
                if (busqueda == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se encontraron contactos");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                lectura.Close();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\nPresione una tecla para volver al menú principal");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
                contactos_inicio();
            }
            catch (FileNotFoundException fe)
            {
                Console.WriteLine("ERROR" + fe.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR" + e.Message);
            }

            Console.ReadKey();
        }
    }

    class moduloutilitario {
        
        public void inicioMU()
        {
            Program call_inicio = new Program();
            Console.WriteLine(@"
█▀▄▀█ █▀█ █▀▄ █░█ █░░ █▀█   █░█ ▀█▀ █ █░░ █ ▀█▀ ▄▀█ █▀█ █ █▀█
█░▀░█ █▄█ █▄▀ █▄█ █▄▄ █▄█   █▄█ ░█░ █ █▄▄ █ ░█░ █▀█ █▀▄ █ █▄█");
            Console.WriteLine("\n1. Conversor de unidades\n2. Calculadora\n3. Salir");
            string opcion;
            string entrada = Console.ReadLine();

            bool esValido = false;
            while (!esValido)
            {
                if (entrada != "1" && entrada != "2" && entrada != "3")
                {
                    esValido = false;
                }
                else
                {
                    esValido = true;
                }

                if (!esValido)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("OPCION INVALIDA, por favor ingrese una de las opciones disponibles");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("App multifuncional\n");

                    Console.WriteLine("1. Conversor de unidades\n2. Calculadora\n3. Atrás");

                    entrada = Console.ReadLine();
                }
            }

            opcion = entrada;

            switch (opcion)
            {
                case "1":
                    Console.Clear();
                    conversordeUM();
                    break;
                case "2":
                    Console.Clear();
                    calculadora();
                    break;
                case "3":
                    Console.Clear();
                    call_inicio.inicio_programa();
                    break;
            }
        }

        public void conversordeUM()
        {
            Program call_inicio = new Program();
            do
            {
                here:
                int OP1;
                int op2;
                double c, f, k;
                bool salir = false;
                int opc;

                Console.WriteLine("                                   ////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("                                   *                                                                      *");
                Console.WriteLine("                                   *            Bienvenido a este su programa de conversiones             *");
                Console.WriteLine("                                   *                                                                      *");
                Console.WriteLine("                                   *                ¿ Qué programa quiere utilizar ?                      *");
                Console.WriteLine("                                   *                                                                      *");
                Console.WriteLine("                                   *                 [1] conversor de temperatura                         *");
                Console.WriteLine("                                   *                 [2] conversor de monedas                             *");
                Console.WriteLine("                                   *                 [3] Atrás                                            *");
                Console.WriteLine("                                   *                                                                      *");
                Console.WriteLine("                                   *                                                                      *");
                Console.WriteLine("                                   ////////////////////////////////////////////////////////////////////////");
                OP1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (OP1 == 1)
                {

                    //iniciamos con el bucle Do/While para que no se cierrre el programa
                    do
                    {
                        //declaramos las variables


                        //aca el menú de opciones y un convert para que el program lea la opcion dada 
                        Console.WriteLine("                                      //////////////////////////////////////////////");
                        Console.WriteLine("                                      *                                            *");
                        Console.WriteLine("                                      *           conversor de unidades            *");
                        Console.WriteLine("                                      *                                            *");
                        Console.WriteLine("                                      *                 [1] C/F                    *");
                        Console.WriteLine("                                      *                 [2] F/C                    *");
                        Console.WriteLine("                                      *                 [3] K/C                    *");
                        Console.WriteLine("                                      *                 [4] C/K                    *");
                        Console.WriteLine("                                      *                 [5] K/F                    *");
                        Console.WriteLine("                                      *                 [6] F/K                    *");
                        Console.WriteLine("                                      *                 [7] atrás                  *");
                        Console.WriteLine("                                      *                 [0] salir                  *");
                        Console.WriteLine("                                      *                                            *");
                        Console.WriteLine("                                      //////////////////////////////////////////////");
                        opc = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        //iniciamos un switch para la seleccion 
                        switch (opc)
                        {
                            case 1:
                                //**************************[C / F]****************************
                                Console.WriteLine("ingresa los grados Centgrados");
                                c = Convert.ToDouble(Console.ReadLine());

                                f = c * 1.8 + 32;

                                Console.WriteLine(f + "  " + "Grados farenhait. ");
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 2:

                                //***************************[F / C]****************************

                                Console.WriteLine("ingresa los grados Farenhait");
                                f = Convert.ToDouble(Console.ReadLine());

                                c = (f - 32) / 1.8;

                                Console.WriteLine(c + " " + "Grados Centigrados. ");
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 3:

                                //***************************[C / K]****************************

                                Console.WriteLine("ingresa los grados centigrados");
                                c = Convert.ToDouble(Console.ReadLine());

                                k = c + 273.15;

                                Console.WriteLine(k + "  " + "Grados Kelvin. ");
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 4:
                                //***************************[K / C]***************************

                                Console.WriteLine("ingresa los grados Kelvin");
                                k = Convert.ToDouble(Console.ReadLine());

                                c = k - 273.15;

                                Console.WriteLine(k + "  " + "Grados Centigrados. ");
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 5:
                                //***************************[K / F]***************************

                                Console.WriteLine("ingresa los grados Kelvin");
                                k = Convert.ToDouble(Console.ReadLine());

                                f = 1.8 * (k - 273.15) + 32;

                                Console.WriteLine(k + "  " + "Grados Farenhait. ");
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 6:
                                //***************************[F / K]*************************

                                Console.WriteLine("ingresa los grados Farenhait");
                                f = Convert.ToDouble(Console.ReadLine());

                                k = 9 / 5 * (f - 32) + 273.15;

                                Console.WriteLine(k + "  " + "Grados kelvin. ");
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 0:
                                salir = true;
                                Console.Clear();
                                call_inicio.inicio_programa();
                                break;

                            case 7:
                                Console.Clear();
                                goto here;
                                break;
                        }

                    } while (true);
                }
                else if (OP1 == 2)
                {
                    //calculador de monedas

                    //declaramos las variables
                    double RD, USD, EUR, resultado;
                    int opciones;

                    //aca el menú de opciones y un convert para que el program lea la opcion dada 
                    Console.WriteLine("                                      //////////////////////////////////////////////");
                    Console.WriteLine("                                      *                                            *");
                    Console.WriteLine("                                      *           conversor de unidades            *");
                    Console.WriteLine("                                      *                                            *");
                    Console.WriteLine("                                      *                 [1] RD/USD                 *");
                    Console.WriteLine("                                      *                 [2] USD/RD                 *");
                    Console.WriteLine("                                      *                 [3] USD/EUR                *");
                    Console.WriteLine("                                      *                 [4] EUR/USD                *");
                    Console.WriteLine("                                      *                 [5] EUR/RD                 *");
                    Console.WriteLine("                                      *                 [6] RD/EUR                 *");
                    Console.WriteLine("                                      *                 [0] salir                  *");
                    Console.WriteLine("                                      *                                            *");
                    Console.WriteLine("                                      //////////////////////////////////////////////");
                    opciones = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    //iniciamos un switch para la seleccion 
                    switch (opciones)
                    {
                       


                        case 1:
                            //**************************[RD / USD]****************************
                            Console.WriteLine("ingresa el monto en pesos");
                    RD = Convert.ToDouble(Console.ReadLine());


                    //formmula
                    resultado = RD / 52.91;

                    Console.WriteLine(resultado + "  " + "Dolares. ");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                        case 2:

                            //***************************[USD / RD ]****************************

                            Console.WriteLine("ingresa el monto en dolares");
                    USD = Convert.ToDouble(Console.ReadLine());

                    //formmula
                    resultado = USD * 52.91;

                    Console.WriteLine(resultado + " " + "Pesos dominicanos. ");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                        case 3:

                            //***************************[USD / EUR ]****************************

                            Console.WriteLine("ingresa el monto en dolares");
                    USD = Convert.ToDouble(Console.ReadLine());

                    //formmula
                    resultado = USD * 1.0056;

                    Console.WriteLine(resultado + "  " + "Euros. ");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                        case 4:
                            //***************************[EUR/ USD]***************************

                            Console.WriteLine("ingresa el monto en euros");
                    EUR = Convert.ToDouble(Console.ReadLine());
                    //formmula
                    resultado = EUR / 1.0;

                    Console.WriteLine(resultado + "  " + "Dolares. ");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                        case 5:
                            //***************************[EUR / RD ]***************************

                            Console.WriteLine("ingresa el monto en euros");
                    EUR = Convert.ToDouble(Console.ReadLine());

                    //formmula
                    resultado = EUR * 52.83;

                    Console.WriteLine(resultado + "  " + "Pesos dominicanos. ");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                        case 6:
                            //***************************[RD / EUR]*************************

                            Console.WriteLine("ingresa el monto en pesos");
                    RD = Convert.ToDouble(Console.ReadLine());

                    //formmula
                    resultado = RD / 52.87;

                    Console.WriteLine(resultado + "  " + "Euros. ");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                        case 0:

                    Console.WriteLine("                    ***** Gracias por usar el conversor de monedas *****");
                    Thread.Sleep(2000);
                    Console.Clear();
                    goto here;
                    break;
                
                    }


                } 
                else if (OP1 == 3)
                {
                    Console.Clear();
                    salir = false;
                    inicioMU();
                }

                if (OP1 != 1 && OP1 != 2 && OP1 != 3)
                {
                    Console.WriteLine("Por favor ingrese una opcion valida");
                    Thread.Sleep(2000);
                    goto here;
                }

            }
            while (true);

        }
        public void calculadora()
        {
            Program call_inicio = new Program();
            string resp = "";
            do
            {
                int valor1 = 0;
                int valor2 = 0;
                int R = 0;
                Console.WriteLine(@"
        █▀▀ ▄▀█ █░░ █▀▀ █░█ █░░ ▄▀█ █▀▄ █▀█ █▀█ ▄▀█
        █▄▄ █▀█ █▄▄ █▄▄ █▄█ █▄▄ █▀█ █▄▀ █▄█ █▀▄ █▀█");
                Console.WriteLine("\nPresione el simbolo para realizar la operacion:");
                Console.WriteLine("+ para sumar");
                Console.WriteLine("- para restar");
                Console.WriteLine("* para multiplicar");
                Console.WriteLine("/ para dividir");
                Console.WriteLine("[0] Atrás");
                Console.Write("Eliga Una Opcion: ");
                string eleccion = Console.ReadLine();

                switch (eleccion)
                {
                    case "+":
                        Console.WriteLine("Ingrese sus dos numeros");
                        Console.Write("Valor1: ");
                        valor1 = int.Parse(Console.ReadLine());
                        Console.Write("Valor2: ");
                        valor2 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("El resultado de la suma es:");
                        R = valor1 + valor2;
                        Console.WriteLine("{0} + {1} = {2}", valor1, valor2, R);
                        break;
                    case "-":
                        Console.WriteLine("Ingrese sus dos numeros");
                        Console.Write("Valor1: ");
                        valor1 = int.Parse(Console.ReadLine());
                        Console.Write("Valor2: ");
                        valor2 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("El resultado de la resta es:");
                        R = valor1 - valor2;
                        Console.WriteLine("{0} - {1} = {2}", valor1, valor2, R);
                        break;
                    case "*":
                        Console.WriteLine("Ingrese sus dos numeros");
                        Console.Write("Valor1: ");
                        valor1 = int.Parse(Console.ReadLine());
                        Console.Write("Valor2: ");
                        valor2 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("El resultado de la multiplicacion es:");
                        R = valor1 * valor2;
                        Console.WriteLine("{0} * {1} = {2}", valor1, valor2, R);
                        break;
                    case "/":
                        Console.WriteLine("Ingrese sus dos numeros");
                        Console.Write("Valor1: ");
                        valor1 = int.Parse(Console.ReadLine());
                        Console.Write("Valor2: ");
                        valor2 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("El resultado de la division es:");
                        R = valor1 / valor2;
                        Console.WriteLine("{0} / {1} = {2}", valor1, valor2, R);
                        break;
                    case "0":
                        Console.Clear();
                        inicioMU();
                        break;
                    default:
                        Console.WriteLine("Este operador no esta implementado aún"); break;
                }
                Console.Write("¿Desea Continuar? s/n: ");
                resp = Console.ReadLine();

                Console.Clear();
            }

            while (resp == "s" || resp == "s");
            inicioMU();
        }
    }

    }

        

        
    
  















