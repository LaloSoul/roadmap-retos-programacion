/*
 * EJERCICIO:
 * - Crea ejemplos utilizando todos los tipos de operadores de tu lenguaje:
 *   Aritméticos, lógicos, de comparación, asignación, identidad, pertenencia, bits...
 *   (Ten en cuenta que cada lenguaje puede poseer unos diferentes)
 * - Utilizando las operaciones con operadores que tú quieras, crea ejemplos
 *   que representen todos los tipos de estructuras de control que existan
 *   en tu lenguaje:
 *   Condicionales, iterativas, excepciones...
 * - Debes hacer print por consola del resultado de todos los ejemplos.
 *
 * DIFICULTAD EXTRA (opcional):
 * Crea un programa que imprima por consola todos los números comprendidos
 * entre 10 y 55 (incluidos), pares, y que no son ni el 16 ni múltiplos de 3.
 *
 * Seguro que al revisar detenidamente las posibilidades has descubierto algo nuevo.
 */

using System;


namespace LaloSoul01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables utilizadas
            int a = 5;
            int b = 6;

            bool c = true;
            bool d = false;


            /*********    Aritmeticas    **********/
            Console.WriteLine("**************Aritmeticas**************");
            // + Suma
            Console.WriteLine($"Suma: {a} + {b} = {a + b}");
            // - Resta
            Console.WriteLine($"Resta: {a} - {b} = {a - b}");
            // * Multiplicación
            Console.WriteLine($"Multíplicacion: {b} * {a} = {b * a}");
            // / División
            float division =  (float)a/b ;
            Console.WriteLine($"Division: {a} / {b} = {division}");
            // % Módulo (resto de división)
            Console.WriteLine($"Residuo {a} % {b} ={a%b}");
            Console.WriteLine("***************************************\n");
            /*********     Logicos    **********/
            Console.WriteLine("****************Logicas*****************");
            // && Y lógico (AND)
            Console.WriteLine($"&& (AND): {c} && {d} = {c&&d}");
            // || O lógico (OR)
            Console.WriteLine($"|| (OR): {c} || {d} = {c || d}");
            // ! Negación lógica (NOT)
            Console.WriteLine($"! (NOT): !{c} = {!c}");
            /***Comparacion o relacionales****/
            Console.WriteLine("***************Comparacion***************");
            //== Igual
            Console.WriteLine($"== (Igual): {a} == {b} = {a == b}");
            //!= Diferente
            Console.WriteLine($"!= (Diferente): {a} != {b} = {a != b}");
            //> Mayor que
            Console.WriteLine($"> (Mayor que): {a} > {b} = {a > b}");
            //< Menor que
            Console.WriteLine($"< (Menor que): {a} < {b} = {a < b}");
            //>= Mayor o igual que
            Console.WriteLine($">= (Mayor o igual que): {a} >= {b} = {a >= b}");
            //<= Menor o igual que
            Console.WriteLine($"<= (Menor o igual que): {a} <= {b} = {a <= b}");
            /*********     Asignacion    **********/
            Console.WriteLine("**************Asignacion**************");
            // = Asignación simple
            Console.WriteLine("= (asignacion simple) : Si \"a = 5\" entonces \"a\" toma el valor de 5");
            // += Asignación de suma
            Console.WriteLine($"+= (asignacion suma): si a += b entonces al valor en \"a\" se le suma el valor de \"b\" y el resultado se mantiene guardado en \"a\"");
            // -= Asignación de resta
            Console.WriteLine($"-= (asignacion resta): si a -= b entonces al valor en \"a\" se le resta el valor de \"b\" y el resultado se mantiene guardado en \"a\"");
            // *= Asignación de multiplicación
            Console.WriteLine($"*= (asignacion multiplicacion): si a *= b entonces al valor en \"a\" se le multiplica el valor de \"b\" y el resultado se mantiene guardado en \"a\"");
            // /= Asignación de división
            Console.WriteLine($"/= (asignacion division): si a /= b entonces al valor en \"a\" se le divide el valor de \"b\" y el resultado se mantiene guardado en \"a\"");
            // %= Asignación de módulo
            Console.WriteLine($"%= (asignacion modulo): si a %= b entonces al valor en \"a\" se le hace el modulo del valor de \"b\" y el resultado se mantiene guardado en \"a\"");

            /***********     Identidad    **********/
            Console.WriteLine("**************Identidad**************");
            // === Identidad estricta
            Console.WriteLine($"=== (Identidad estricta): {a} === {b} = {a == b}");
            // !== Identidad estricta diferente
            Console.WriteLine($"!== (Identidad estricta diferente): {a} !== {b} = {a != b}");


            /*********     Pertenencia    **********/
            Console.WriteLine("**************Pertenencia**************");
            // in Pertenencia
            Console.WriteLine($"in (Pertenencia): {a} in [1,2,3,4,5] = {a == 5}");
            // instanceof Pertenencia de tipo
            Console.WriteLine($"instanceof (Pertenencia de tipo): {a} instanceof int = {a is int}");
            
            /*********     Bitwise    **********/
            Console.WriteLine("**************Bitwise**************");
            // & AND bit a bit
            Console.WriteLine($"& (AND bit a bit): {a} & {b} = {a & b}");
            // | OR bit a bit
            Console.WriteLine($"| (OR bit a bit): {a} | {b} = {a | b}");
            // ^ XOR bit a bit
            Console.WriteLine($"^ (XOR bit a bit): {a} ^ {b} = {a ^ b}");
            // ~ Complemento a uno
            Console.WriteLine($"~ (Complemento a uno): ~{a} = {~a}");
            // << Desplazamiento a la izquierda
            Console.WriteLine($"<< (Desplazamiento a la izquierda): {a} << 1 = {a << 1}");
            // >> Desplazamiento a la derecha
            Console.WriteLine($">> (Desplazamiento a la derecha): {a} >> 1 = {a >> 1}");

            /*********     Condicionales    **********/
            // Estructura condicional simple
            Console.WriteLine("**************Condicionales**************");
            Console.WriteLine("If:");
            if (a > b)
            {
                Console.WriteLine($"El valor de \"a\" es mayor que el de \"b\"");
            }
            else if (a == b)
            {
                Console.WriteLine($"El valor de \"a\" es igual que el de \"b\"");
            }
            else
            {
                Console.WriteLine($"El valor de \"b\" es mayor que el de \"a\"");
            }
            // Estructura condicional compuesta
            Console.WriteLine("Switch:");
            switch (a)
            {
                case 1:
                    Console.WriteLine($"El valor de \"a\" es 1");
                    break;
                case 2:
                    Console.WriteLine($"El valor de \"a\" es 2");
                    break;
                case 3:
                    Console.WriteLine($"El valor de \"a\" es 3");
                    break;
                default:
                    Console.WriteLine($"El valor de \"a\" no es ni 1, ni 2, ni 3");
                    break;
            }
            /*********     Iterativas    **********/
            Console.WriteLine("**************Iterativas**************");
            // Estructura de control for
            Console.WriteLine("For:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"El valor de \"i\" es {i}");
            }
            // Estructura de control while
            Console.WriteLine("While:");
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine($"El valor de \"j\" es {j}");
                j++;
            }
            // Estructura de control do while
            Console.WriteLine("Do While:");
            int k = 0;
            do
            {
                Console.WriteLine($"El valor de \"k\" es {k}");
                k++;
            } while (k < 5);
            // Estructura de control foreach
            Console.WriteLine("Foreach:");
            int[] array = { 1, 2, 3, 4, 5 };
            foreach (int item in array)
            {
                Console.WriteLine($"El valor de \"item\" es {item}");
            }
            /*********     Excepciones    **********/
            Console.WriteLine("**************Excepciones**************");
            // Estructura de control try-catch
            Console.WriteLine("Try-Catch:");
            try
            {
                int result = a / 0; // Esto lanzará una excepción
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Esto se ejecuta siempre, haya o no habido una excepción.");
            }
            /*********     Extra    **********/
            Console.WriteLine("**************Extra**************");
            // Imprimir números entre 10 y 55 (incluidos), pares, y que no son ni el 16 ni múltiplos de 3.
            Console.WriteLine("Números entre 10 y 55 (incluidos), pares, y que no son ni el 16 ni múltiplos de 3:");
            for (int numero = 10; numero <= 55; numero++)
            { 
                if (numero%2==0 && numero !=16 && numero %3!=0)
                {
                    Console.WriteLine(numero);
                }
            }
            /*******************************/
        }
    }
}
