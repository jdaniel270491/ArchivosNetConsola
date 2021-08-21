using System;

namespace DPNR_U2_A1_JONC
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcion = 0; // Variable para las opciones del menú
            paquetesviaje Viajes;//instanciamos la clase paquete viajes donde tomara como base paquetes viajes heredando los atributos de clase viajes
            Viajes = new paquetesviaje(); //se debe colocar en esta parte para poder obtener los datos sin perder la información
            // Menú interactivo con casos de uso
            do
            {
                Console.Clear();
                Console.WriteLine("Agencia de viajes espaciales");
                Console.WriteLine("Bienvenido a actividad 1 Unidad 2 NET2");
                Console.WriteLine("Menú de incio");
                Console.WriteLine("Selecciona una opción");
                Console.WriteLine("1 - Planear viaje");
                Console.WriteLine("2 - Obtener precio");
                Console.WriteLine("3 - Limpiar planeación");
                opcion = int.Parse(Console.ReadLine()); //se toma la opción digitada

                switch (opcion) 
                {

                    case 1: // primer caso de uso
                        // Limpia la pantalla
                        Console.Clear();

                        // Se muestran las opciones de destino
                        Console.WriteLine("Opciones de destino: \n\n" +
                            "a.-**Destino Tattoine** \n" +
                            "------------------------------------------------------------------------------\n"+
                            "||Periodo de rotación :23 || Pediodo órbita: 304     ||                     ||\n" +
                            "-----------------------------------------------------|| Diametro: 10465     ||\n" +
                            "|| Clima: Árido           || Gravedad: 2 veces tierra||                     ||\n" +
                            "------------------------------------------------------------------------------\n"+
                            "||Terreno: Desértico      || Población: 2000         || PrecioXPersona:9600 ||\n" +
                            "------------------------------------------------------------------------------\n"+
                            "|| CargosExtra X Persona (obligatorio) Especial Supervivencia: 100          ||\n" +
                            "------------------------------------------------------------------------------\n\n" +
                            "b.-**Destino Aldreraan** \n" +
                            "------------------------------------------------------------------------------\n" +
                            "||Periodo de rotación :24 || Pediodo órbita: 264     ||                     ||\n" +
                            "-----------------------------------------------------|| Diametro: 12500     ||\n" +
                            "|| Clima: Templado        || Gravedad: 1 estándar    ||                     ||\n" +
                            "------------------------------------------------------------------------------\n" +
                            "||Terreno: Montañoso      || Población: 20000000     || PrecioXPersona:18700||\n" +
                            "------------------------------------------------------------------------------\n" +
                            "|| CargosExtra X Persona (obligatorio) Botiquín antivirus: 200              ||\n" +
                            "------------------------------------------------------------------------------\n\n" +
                            "c.-**Destino Yavin IV** \n" +
                            "------------------------------------------------------------------------------\n" +
                            "||Periodo de rotación :24 || Pediodo órbita: 4818    ||                     ||\n" +
                            "-----------------------------------------------------|| Diametro: 10200     ||\n" +
                            "|| Clima: Tropical        || Gravedad: 1 estándar    ||                     ||\n" +
                            "------------------------------------------------------------------------------\n" +
                            "||Terreno: Jungla         || Población: 1000         || PrecioXPersona:7900 ||\n" +
                            "------------------------------------------------------------------------------\n" +
                            "|| CargosExtra X Persona (obligatorio) Botiquín antivirus: 100              ||\n" +
                            "------------------------------------------------------------------------------\n\n" +
                            "d.-**Destino Hoth** \n" +
                            "------------------------------------------------------------------------------\n" +
                            "||Periodo de rotación :23 || Pediodo órbita: 549     ||                     ||\n" +
                            "-----------------------------------------------------|| Diametro: 7200      ||\n" +
                            "|| Clima: Frío            || Gravedad: 2 veces tierra||                     ||\n" +
                            "------------------------------------------------------------------------------\n" +
                            "||Terreno: Túndra         || Población: desconocida  || PrecioXPersona:8790 ||\n" +
                            "------------------------------------------------------------------------------\n" +
                            "|| CargosExtra X Persona (obligatorio) Especial supervivencia: 200          ||\n" +
                            "------------------------------------------------------------------------------\n");
                        Console.WriteLine("Elige tu destino digitando letra en minúscula:"); //se piede elegir destino
                        string validacion = Console.ReadLine(); //se lee variable
                        if (validacion == "a") //vamos a validar la opcion si es a ingresa en esta opción
                        {
                            Console.WriteLine("Haz elegido tu destino a Taatooine");
                          //  paquetesviaje Viajes;//instanciamos la clase paquete viajes donde tomara como base paquetes viajes heredando los atributos de clase viajes
                   //     Viajes = new paquetesviaje();
                            Viajes.Nombre = "Tatooine";//mandamos datos a nuestro constructor
                            Viajes.Pderotacion = 23;
                            Viajes.Pdeorbita = 304;
                            Viajes.Diametro = 10465;
                            Viajes.Clima = "Arido";
                            Viajes.Gravedad = "2 veces la tierra";
                            Viajes.Terrreno = "Desertico";
                            Viajes.Poblacion = "2000";
                            Viajes.Pxpersona = 9600;
                            Viajes.Cextra = 100;
                            //se muestran los paquetes disponibles
                            Console.WriteLine("Seleciona un paquete:\n\n" +
                             "1.-**Paquete Bronce * * \n" +
                            "------------------------------------------------------------------------------\n" +
                            "||Incluye :Boletos de viaje                 || Precio Extra X persona: N/A  ||\n\n" +
                             "**2.-Paquete Plata * * \n" +
                            "------------------------------------------------------------------------------\n" +
                            "||Incluye :Boletos de viaje y comida        || Precio Extra X persona: 5000 ||\n\n" +
                             "**3.-Paquete Bronce * * \n" +
                            "------------------------------------------------------------------------------\n" +
                            "||Incluye :Boletos de viaje, comida, y tour || Precio Extra X persona: 9000 ||\n" );
                            Console.WriteLine("Ingresa el num opción:"); //se solicita ingresar opción de paquete
                            int validacionp = int.Parse(Console.ReadLine());
                            if (validacionp == 1) {
                                Console.WriteLine("Haz elegido paquete bronce");
                                Viajes.Pnombre = "Bronce"; //se aplica herencia estamos anexando datos nuevos al contructor
                                Viajes.Pincluye = "Boletos de viaje";
                                Viajes.Pextra = 0;                          
                            }
                            if (validacionp == 2) //opcion 2 si elige paquete plata los datos cambiaran
                            {
                                Console.WriteLine("Haz elegido paquete plata");
                                Viajes.Pnombre = "Plata"; //se aplica herencia estamos anexando datos nuevos
                                Viajes.Pincluye = "Boletos de viaje y comida";
                                Viajes.Pextra = 5000;
                            }
                            if (validacionp == 3)
                            {
                                Console.WriteLine("Haz elegido paquete oro");
                                Viajes.Pnombre = "Oro"; //se aplica herencia estamos anexando datos nuevos
                                Viajes.Pincluye = "Boletos de viaje, comida y tour a zona turisticas";
                                Viajes.Pextra = 9000;
                            }
                        }
                        if (validacion == "b") //opcion para diferente destino
                        {

                            Console.WriteLine("Haz elegido tu destino a Alderaan");
                        //    paquetesviaje Viajes;//instanciamos la clase paquete viajes donde tomara como base paquetes viajes heredando los atributos de clase viajes
                        //    Viajes = new paquetesviaje();
                            Viajes.Nombre = "Alderaan";//mandamos datos a nuestro constructor
                            Viajes.Pderotacion = 24;
                            Viajes.Pdeorbita = 264;
                            Viajes.Diametro = 12500;
                            Viajes.Clima = "Templado";
                            Viajes.Gravedad = "1 estándar";
                            Viajes.Terrreno = "Montañoso";
                            Viajes.Poblacion = "20000000";
                            Viajes.Pxpersona = 18700;
                            Viajes.Cextra = 200;
                            Console.WriteLine("Seleciona un paquete:\n\n" +
                             "1.-**Paquete Bronce * * \n" +
                            "------------------------------------------------------------------------------\n" +
                            "||Incluye :Boletos de viaje                 || Precio Extra X persona: N/A  ||\n\n" +
                             "**2.-Paquete Plata * * \n" +
                            "------------------------------------------------------------------------------\n" +
                            "||Incluye :Boletos de viaje y comida        || Precio Extra X persona: 5000 ||\n\n" +
                             "**3.-Paquete Bronce * * \n" +
                            "------------------------------------------------------------------------------\n" +
                            "||Incluye :Boletos de viaje, comida, y tour || Precio Extra X persona: 9000 ||\n");
                            Console.WriteLine("Ingresa el num opción:");
                            int validacionp = int.Parse(Console.ReadLine());
                            if (validacionp == 1)
                            {
                                Console.WriteLine("Haz elegido paquete bronce");
                                Viajes.Pnombre = "Bronce"; //se aplica herencia estamos anexando datos nuevos
                                Viajes.Pincluye = "Boletos de viaje";
                                Viajes.Pextra = 0;
                            }
                            if (validacionp == 2)
                            {
                                Console.WriteLine("Haz elegido paquete plata");
                                Viajes.Pnombre = "Plata"; //se aplica herencia estamos anexando datos nuevos
                                Viajes.Pincluye = "Boletos de viaje y comida";
                                Viajes.Pextra = 5000;
                            }
                            if (validacionp == 3)
                            {
                                Console.WriteLine("Haz elegido paquete oro");
                                Viajes.Pnombre = "Oro"; //se aplica herencia estamos anexando datos nuevos
                                Viajes.Pincluye = "Boletos de viaje, comida y tour a zona turisticas";
                                Viajes.Pextra = 9000;
                            }

                        }
                        if (validacion == "c")
                        {


                            Console.WriteLine("Haz elegido tu destino a Yavin IV");
                         //   paquetesviaje Viajes;//instanciamos la clase paquete viajes donde tomara como base paquetes viajes heredando los atributos de clase viajes
                          //  Viajes = new paquetesviaje();
                            Viajes.Nombre = "YavinIV";//mandamos datos a nuestro constructor
                            Viajes.Pderotacion = 24;
                            Viajes.Pdeorbita = 4818;
                            Viajes.Diametro = 10200;
                            Viajes.Clima = "Tropical";
                            Viajes.Gravedad = "1 estandar";
                            Viajes.Terrreno = "Jungla";
                            Viajes.Poblacion = "1000";
                            Viajes.Pxpersona = 7900;
                            Viajes.Cextra = 100;
                            Console.WriteLine("Seleciona un paquete:\n\n" +
                             "1.-**Paquete Bronce * * \n" +
                            "------------------------------------------------------------------------------\n" +
                            "||Incluye :Boletos de viaje                 || Precio Extra X persona: N/A  ||\n\n" +
                             "**2.-Paquete Plata * * \n" +
                            "------------------------------------------------------------------------------\n" +
                            "||Incluye :Boletos de viaje y comida        || Precio Extra X persona: 5000 ||\n\n" +
                             "**3.-Paquete Bronce * * \n" +
                            "------------------------------------------------------------------------------\n" +
                            "||Incluye :Boletos de viaje, comida, y tour || Precio Extra X persona: 9000 ||\n");
                            Console.WriteLine("Ingresa el num opción:");
                            int validacionp = int.Parse(Console.ReadLine());
                            if (validacionp == 1)
                            {
                                Console.WriteLine("Haz elegido paquete bronce");
                                Viajes.Pnombre = "Bronce"; //se aplica herencia estamos anexando datos nuevos
                                Viajes.Pincluye = "Boletos de viaje";
                                Viajes.Pextra = 0;
                            }
                            if (validacionp == 2)
                            {
                                Console.WriteLine("Haz elegido paquete plata");
                                Viajes.Pnombre = "Plata"; //se aplica herencia estamos anexando datos nuevos
                                Viajes.Pincluye = "Boletos de viaje y comida";
                                Viajes.Pextra = 5000;
                            }
                            if (validacionp == 3)
                            {
                                Console.WriteLine("Haz elegido paquete oro");
                                Viajes.Pnombre = "Oro"; //se aplica herencia estamos anexando datos nuevos
                                Viajes.Pincluye = "Boletos de viaje, comida y tour a zona turisticas";
                                Viajes.Pextra = 9000;
                            }


                        }
                        if (validacion == "d")
                        {
                            Console.WriteLine("Haz elegido tu destino a Hoth");
                         //   paquetesviaje Viajes;//instanciamos la clase paquete viajes donde tomara como base paquetes viajes heredando los atributos de clase viajes
                          //  Viajes = new paquetesviaje();
                            Viajes.Nombre = "Hoth";//mandamos datos a nuestro constructor
                            Viajes.Pderotacion = 23;
                            Viajes.Pdeorbita = 549;
                            Viajes.Diametro = 7200;
                            Viajes.Clima = "Frio";
                            Viajes.Gravedad = "2 veces la tierra";
                            Viajes.Terrreno = "Tundra";
                            Viajes.Poblacion = "Desconocido";
                            Viajes.Pxpersona = 8790;
                            Viajes.Cextra = 200;
                            Console.WriteLine("Seleciona un paquete:\n\n" +
                             "1.-**Paquete Bronce * * \n" +
                            "------------------------------------------------------------------------------\n" +
                            "||Incluye :Boletos de viaje                 || Precio Extra X persona: N/A  ||\n\n" +
                             "**2.-Paquete Plata * * \n" +
                            "------------------------------------------------------------------------------\n" +
                            "||Incluye :Boletos de viaje y comida        || Precio Extra X persona: 5000 ||\n\n" +
                             "**3.-Paquete Bronce * * \n" +
                            "------------------------------------------------------------------------------\n" +
                            "||Incluye :Boletos de viaje, comida, y tour || Precio Extra X persona: 9000 ||\n");
                            Console.WriteLine("Ingresa el num opción:");
                            int validacionp = int.Parse(Console.ReadLine());
                            if (validacionp == 1)
                            {
                                Console.WriteLine("Haz elegido paquete bronce");
                                Viajes.Pnombre = "Bronce"; //se aplica herencia estamos anexando datos nuevos
                                Viajes.Pincluye = "Boletos de viaje";
                                Viajes.Pextra = 0;
                            }
                            if (validacionp == 2)
                            {
                                Console.WriteLine("Haz elegido paquete plata");
                                Viajes.Pnombre = "Plata"; //se aplica herencia estamos anexando datos nuevos
                                Viajes.Pincluye = "Boletos de viaje y comida";
                                Viajes.Pextra = 5000;
                            }
                            if (validacionp == 3)
                            {
                                Console.WriteLine("Haz elegido paquete oro");
                                Viajes.Pnombre = "Oro"; //se aplica herencia estamos anexando datos nuevos
                                Viajes.Pincluye = "Boletos de viaje, comida y tour a zona turisticas";
                                Viajes.Pextra = 9000;
                            }
                           
                        }
                     
                        Console.ReadKey(); 
                        break;
                        //caso de uso obtener precio
                    case 2:

                        Console.WriteLine("¿Cuál es el número de personas que viajan al destino de " +Viajes.Nombre + "?");//pregunta de persona a destino capturado
                        int valor = int.Parse(Console.ReadLine());
                        Viajes.ObtenerPrecio(valor);
                        Console.ReadKey();
                        //     Viajes.MostrarInformacion();
                        break;
                        //caso de uso limpear planeación
                    case 3:
                        Viajes.LimpearPlaneación();
                        break;
                        
                }
            } while (opcion != 4);

        }


    }
    }

