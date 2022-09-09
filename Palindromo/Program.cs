using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            string palabra;                                              //v para la palabra
            int i;                                                       //v para el for que decrementa
            int Cont = 0;                                                //v para un contador que incrementa
            bool palindromo = true;                                      //v boleana para saber si la palabra es palindromo y lo asignamos un true


            Write("Ingrese palabra: ");                                  
            palabra = ReadLine();       
            palabra = palabra.ToLower();                                 //convierto en minuscula
                    
            for ( i = palabra.Length - 1; i >= 0; i--)                   //for de decremento que empieza en la ultima letra de la palabra y va decrementando
            {
               if(palabra[i] != palabra[Cont])                           //if para ver si letra en la posicion i (decrementando) es distinta a letra en la posicion Cont (incrementando) son distinta.
                {
                    palindromo = false;                                  //al ser distinta se pone en false la variable palindromo
                    break;                                               //y con break finaliza el ciclo for
                }
                Cont++;                                                  //v Cont que va incremenando
            }


            if (palindromo == true)                                      //y por ultimo la salida preguntando si palindromo es true 
            {
                WriteLine($"La palabra '{palabra}' ES Palindromo");      //si sigue en true entonces es Palindromo
            }
            else
            {
                WriteLine($"La palabra '{palabra}' NO es Palindromo");  //y si cambia a falso entonces no es
            }

            ReadKey();


        }
    }
}
