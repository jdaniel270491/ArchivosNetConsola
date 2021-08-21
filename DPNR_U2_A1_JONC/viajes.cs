using System;
using System.Collections.Generic;
using System.Text;

namespace DPNR_U2_A1_JONC
{
    public class viajes // cración de clase viajes

        {
            // Atributos de la clase
            private string nombre;
            private int pderotacion;
            private int pdeorbita;
            private double diametro;
            private string clima;
            private string gravedad;
            private string terrreno;
            private string poblacion;
            private int pxpersona;
            private int cextra;

            // Get/Set para acceder a los atributos
            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }
            public int Pderotacion
            {
                get { return pderotacion; }
                set { pderotacion = value; }
            }

            public int Pdeorbita {
                get { return pdeorbita; }
                set { pdeorbita = value; }
            }
            public double Diametro {
                get { return diametro; }
                set { diametro = value; }
            }
            public string Clima {
                get { return clima; }
                set { clima = value; }
            }
            public string Gravedad {
                get { return gravedad; }
                set { gravedad = value; }
            }
            public string Terrreno {
                get { return terrreno; }
                set { terrreno = value; }
            }
            public string Poblacion {
                get { return poblacion; }
                set { poblacion = value; }
            }
            public int Pxpersona {
                get { return pxpersona; }
                set { pxpersona = value; }
            }
            public int Cextra {
                get { return cextra; }
                set { cextra = value; }
            }

            // creación del constructor para parametros de destinos inicializando

            public viajes() {
                this.nombre = "";
                this.pderotacion = 0;
                this.pdeorbita = 0;
                this.diametro = 0;
                this.clima = "";
                this.gravedad = "";
                this.terrreno = "";
                this.poblacion = "";
                this.pxpersona = 0;
                this.cextra = 0;

}

        }
    }
