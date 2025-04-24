using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RoadMapCsMoureDev.Retos
{
    internal class Reto02 : IDesafio
    {
        public string Desafio { get; set; } = "Reto02";
        public string Descripcion { get; set; } = "02 FUNCIONES Y ALCANCE";
        public string DescripcionLarga { get; set; } = "* EJERCICIO:\r\n * - Crea ejemplos de funciones básicas que representen las diferentes\r\n *   posibilidades del lenguaje:\r\n *   Sin parámetros ni retorno, con uno o varios parámetros, con retorno...\r\n * - Comprueba si puedes crear funciones dentro de funciones.\r\n * - Utiliza algún ejemplo de funciones ya creadas en el lenguaje.\r\n * - Pon a prueba el concepto de variable LOCAL y GLOBAL.\r\n * - Debes hacer print por consola del resultado de todos los ejemplos.\r\n *   (y tener en cuenta que cada lenguaje puede poseer más o menos posibilidades)\r\n *\r\n * DIFICULTAD EXTRA (opcional):\r\n * Crea una función que reciba dos parámetros de tipo cadena de texto y retorne un número.\r\n * - La función imprime todos los números del 1 al 100. Teniendo en cuenta que:\r\n *   - Si el número es múltiplo de 3, muestra la cadena de texto del primer parámetro.\r\n *   - Si el número es múltiplo de 5, muestra la cadena de texto del segundo parámetro.\r\n *   - Si el número es múltiplo de 3 y de 5, muestra las dos cadenas de texto concatenadas.\r\n *   - La función retorna el número de veces que se ha impreso el número en lugar de los textos.\r\n *\r\n * Presta especial atención a la sintaxis que debes utilizar en cada uno de los casos.\r\n * Cada lenguaje sigue una convenciones que debes de respetar para que el código se entienda.";
        string valGlobal = "Y con variable global!";
        public void Solucion()
        {
            /*
                * EJERCICIO:
                * - Crea ejemplos de funciones básicas que representen las diferentes
                *   posibilidades del lenguaje:
                *   Sin parámetros ni retorno, con uno o varios parámetros, con retorno...
                * - Comprueba si puedes crear funciones dentro de funciones.
                * - Utiliza algún ejemplo de funciones ya creadas en el lenguaje.
                * - Pon a prueba el concepto de variable LOCAL y GLOBAL.
                * - Debes hacer print por consola del resultado de todos los ejemplos.
                *   (y tener en cuenta que cada lenguaje puede poseer más o menos posibilidades)
                *
                * DIFICULTAD EXTRA (opcional):
                * Crea una función que reciba dos parámetros de tipo cadena de texto y retorne un número.
                * - La función imprime todos los números del 1 al 100. Teniendo en cuenta que:
                *   - Si el número es múltiplo de 3, muestra la cadena de texto del primer parámetro.
                *   - Si el número es múltiplo de 5, muestra la cadena de texto del segundo parámetro.
                *   - Si el número es múltiplo de 3 y de 5, muestra las dos cadenas de texto concatenadas.
                *   - La función retorna el número de veces que se ha impreso el número en lugar de los textos.
                *
                * Presta especial atención a la sintaxis que debes utilizar en cada uno de los casos.
                * Cada lenguaje sigue una convenciones que debes de respetar para que el código se entienda.
                */

            //Funcion sin parametros ni retorno
            FuncionSinParametrosNiRetorno();

            //Funcion con un parametro y sin retorno
            FuncionConUnParametroSinRetorno(777);

            //Funcion con un parametro y retorno
            FuncionConUnParametroYRetorno(888);
            int resultado = FuncionConUnParametroYRetorno(999);
            Console.WriteLine($"El resultado de la funcion con un parametro y retorno es: {resultado}");

            //Funcion dentro de otra funcion
            Console.WriteLine("Llamando a la funcion dentro de otra funcion");
            FuncionDentroDeOtraFuncion();

            //Funcion que recibe multiples parametros sin retorno 
            FuncionQueRecibeMultiplesParametrosSinRetorno("Hola", "Mundo!", "C#");

            //Funcion que recibe multiples parametros con retorno 
            Console.WriteLine(FuncionQueRecibeMultiplesParametrosConRetorno("Hola", "Mundo!", "C#"));

            //Funcion lambda
            Console.WriteLine(construirMensaje("Hola", "Mundo!", "C# desde Lambda"));

            //Funcion que utiliza funciones existentes y lambda
            Console.WriteLine(FuncionQueUtilizaFuncionesExistentes("Hola", "Mundo!", "C# desde Lambda, con funcion existente"));

            Console.WriteLine("Se imprimieron numeros {0} veces", DificultadExtra("Hola", "Mundo!!"));
            
        }


        public void FuncionSinParametrosNiRetorno()
        {
            Console.WriteLine("Hola desde la funcion sin parametros ni retorno");
        }

        public void FuncionConUnParametroSinRetorno(int numero)
        {
            Console.WriteLine($"Hola desde la funcion con un parametro sin retorno: {numero}");
        }

        public int FuncionConUnParametroYRetorno(int numero)
        {
            Console.WriteLine($"Hola desde la funcion con un parametro y retorno: {numero}");
            return numero;
        }
        public void FuncionDentroDeOtraFuncion()
        {
            Console.WriteLine("Hola desde la funcion dentro de otra funcion");
            FuncionDentroDeOtraFuncion2();
        }
        public void FuncionDentroDeOtraFuncion2()
        {
            Console.WriteLine("Hola desde la funcion dentro de otra funcion 2");
            Console.WriteLine("En C# no se pueden crear funciones dentro de otras funciones de forma regular");
            int FuncionLocal(int x) => x * x;
            Console.WriteLine($"Pero si funciones{FuncionLocal(5)}");
        }

        public void FuncionQueRecibeMultiplesParametrosSinRetorno(string texto1, string texto2, string texto3)
        {
            Console.WriteLine($"No hay retorno, se recibio en argumentos el siguiente mensaje: {texto1} {texto2} {texto3}");
        }
        public string FuncionQueRecibeMultiplesParametrosConRetorno(string texto1, string texto2, string texto3)
        {
            string mensaje = $"Con retorno, se recibio en argumentos el siguiente mensaje: {texto1} {texto2} {texto3}";
            return mensaje;
        }

        Func<string, string, string, string> construirMensaje = (a, b, c) => $"{a} {b} {c}";

        public string FuncionQueUtilizaFuncionesExistentes(string a, string b, string c)
        {
            Func<string, string, string, string,string> Resultado = (w, x, y, z) => $"{w} {x} {y} {z}".ToUpperInvariant();
            return Resultado(a, b, c, valGlobal);
        }


        /* 
         * DIFICULTAD EXTRA(opcional):
                * Crea una función que reciba dos parámetros de tipo cadena de texto y retorne un número.
                * - La función imprime todos los números del 1 al 100. Teniendo en cuenta que:
                *   - Si el número es múltiplo de 3, muestra la cadena de texto del primer parámetro.
                *   - Si el número es múltiplo de 5, muestra la cadena de texto del segundo parámetro.
                *   - Si el número es múltiplo de 3 y de 5, muestra las dos cadenas de texto concatenadas.
                *   - La función retorna el número de veces que se ha impreso el número en lugar de los textos.
        */
        public int DificultadExtra(string par1, string par2)
        {
            int counter=0 ;
            for (int x = 1; x <= 100; x++)
            { 
                if(x % 3 == 0 && x % 5 == 0)
                    Console.WriteLine($"{par1} {par2}");
                
                else if (x%3==0)
                    Console.WriteLine(par1);
                else if (x%5==0)
                    Console.WriteLine(par2);
                else
                {
                    Console.WriteLine(x);
                    counter++;
                }
            }
                return counter;
        }
    }
}
