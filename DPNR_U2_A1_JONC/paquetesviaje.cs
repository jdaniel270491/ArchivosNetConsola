using System;
using System.Collections.Generic;
using System.Text;

namespace DPNR_U2_A1_JONC
{
    class paquetesviaje : viajes //se crea herencia de la clase viajes
    {
        //se crean nuevos atributos

        private string pnombre;
        private string pincluye;
        private int pextra;
        // creación de encapsulación con get y set
        public string Pnombre
        {
            get { return pnombre; }
            set { pnombre = value; }
        }

        public string Pincluye {
            get { return pincluye; }
            set { pincluye = value; }
        }

        public int Pextra {
            get { return pextra; }
            set { pextra = value; }
        }

        ~paquetesviaje() //creación del destructor
        {
            this.Nombre = "";
            this.Pderotacion = 0;
            this.Pdeorbita = 0;
            this.Diametro = 0;
            this.Clima = "";
            this.Gravedad = "";
            this.Terrreno = "";
            this.Poblacion = "";
            this.Pxpersona = 0;
            this.Cextra = 0;
            this.Pnombre = "";
            this.Pincluye = "";
            this.Pextra = 0;
        }

        public void MostrarInformacion()//metodo mostrar información
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Los datos de tu viaje espacial son: ");
            Console.WriteLine("Destino: " + this.Nombre);
            Console.WriteLine("Periodo de rotación: " + this.Pderotacion);
            Console.WriteLine("Periodo de orbita: " + this.Pdeorbita);
            Console.WriteLine("Diametro: " + this.Diametro);
            Console.WriteLine("Clima: "+ this.Clima);
            Console.WriteLine("Gravedad "+ this.Gravedad);
            Console.WriteLine("Terreno: "+ this.Terrreno);
            Console.WriteLine("Población:" +this.Poblacion);
            Console.WriteLine("Precio X Persona: "+ this.Pxpersona);
            Console.WriteLine("Costo extra X Persona: "+ this.Cextra);
            Console.WriteLine("Tu paquete Elegido es: ");
            Console.WriteLine("Nombre de paquete: "+ this.Pnombre);
            Console.WriteLine("Incluye: "+ this.Pincluye);
            Console.WriteLine("Precio extra X persona:" +this.Pextra);
            // Pausa para permitir la lectura del texto en pantalla
            Console.ReadKey();
        }
        //método para obtener precio
        public void ObtenerPrecio(int npersonas)
        {
            
            double pfinal; //variable para realizar calculos
            int a, b;
            string nombre;
            nombre = this.Nombre;
            a = this.Pxpersona;
            b = this.Cextra;
            pfinal = (npersonas * a) + (Cextra * npersonas); //se realiza calculo de n de personas + npersonas para paquetes de viaje
            if (nombre == "Tatooine" || nombre == "Hoth") {//condicional para aplicar cargo del 5% a planetas extremos
                pfinal = pfinal+(pfinal * .05);
                Console.WriteLine("El precio final es: " + pfinal);
                Console.WriteLine("se aplico cargo extra del 5% por ser planeta extremo");
            }
            if (nombre == "Alderaan" || nombre == "YavinIV") //condicional para descuento en planetas normales
            {
                pfinal = pfinal - (pfinal * .10);
                Console.WriteLine("El precio final es: " + pfinal);
                Console.WriteLine("se aplico descuento del 10% por ser planeta normal y se te obsequia kit de recuerdos");

            }

        }

        public void LimpearPlaneación()//metodo limpieza de valores
        {
            this.Nombre = "";
            this.Pderotacion = 0;
            this.Pdeorbita = 0;
            this.Diametro = 0;
            this.Clima = "";
            this.Gravedad = "";
            this.Terrreno = "";
            this.Poblacion = "";
            this.Pxpersona = 0;
            this.Cextra = 0;
            this.Pnombre = "";
            this.Pincluye = "";
            this.Pextra = 0;
            Console.WriteLine("La aplicación a reseteado los valores");
            // Pausa para permitir la lectura del texto en pantalla
            Console.ReadKey();
        }

    }
    }
