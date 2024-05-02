using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herencia
{
    class operacion
    {
        //declaracion de variables que usa la clase
        //tipo de acceso        tipo de dato          nombre de dato
        protected               int                     valor1;
        protected               int                      valor2;
        protected               int                     resultado;

        //atributos de la calse operación NINGUNO

        //metodos o fuciones de operacion
        /*los metodos que se ponen acontinuacón
         * son las funciones de obtener el valor
         * de la caja de texto y guardarlo en la 
         * memoria dentro de la variable indicada*/
        //USAMOS UN constructor POR CADA CAJA DE MEMORIA
        public int Valor1 //CAJA DE MEMORIA 1
        {
            get { return valor1; } //vamos por el valor
                                   //de la caja de texto
            set { valor1 = value; }//lo guardamos en memoria
        }
        public int Valor2 //CAJA DE MEMORIA 2
        {
            get { return valor2; } //vamos por el valor
                                   //de la caja de texto
            set { valor2 = value; }//lo guardamos en memoria
        }
        public int Resultado //CAJA DE MEMORIA 3
        {
            get { return resultado; } //vamos por el valor
                                   //de la caja de texto
            set { resultado = value; }//lo guardamos en memoria
        }
    }
    //creamos nuestras clases hijo que usara los
    //metodos de crear dato
    class Sumar : operacion //los : nos dan permiso de usar
                            //lo que tiene operacion
    {
        //las clases hijas tambien pueden tener sus
        //propios atributos y métodos
        //pueden tener variables de uso solamente
        //para la clase hijo
        //declarar variables de esta clase
        //atributos de esta clase
        //metodos de clase
        public int operar(int v1, int v2)
        {
            valor1 = v1; //accemos al constructor de operación
            valor2 = v2;
            return resultado = valor1 + valor2;
        }
     }
    class Restar : operacion //los : nos dan permiso de usar
                            //lo que tiene operacion
    {
        //las clases hijas tambien pueden tener sus
        //propios atributos y métodos
        //pueden tener variables de uso solamente
        //para la clase hijo
        //declarar variables de esta clase
        //atributos de esta clase
        //metodos de clase
        public int operar(int v1, int v2)
        {
            valor1 = v1; //accemos al constructor de operación
            valor2 = v2;
            return resultado = valor1 - valor2;
        }
    }
    class Multiplicar : operacion //los : nos dan permiso de usar
                            //lo que tiene operacion
    {
        //las clases hijas tambien pueden tener sus
        //propios atributos y métodos
        //pueden tener variables de uso solamente
        //para la clase hijo
        //declarar variables de esta clase
        //atributos de esta clase
        //metodos de clase
        public int operar(int v1, int v2)
        {
            valor1 = v1; //accemos al constructor de operación
            valor2 = v2;
            return resultado = valor1 * valor2;
        }
    }
    //esto es un comentario nuevo 26 de abril
    //esto es un segunod comentario nuevo 26 de abril
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
