using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelizNavidad2020
{
    class Program
    {
        static void Main(string[] args)
        {
            var startTimeSpan = TimeSpan.Zero; //Intervalo de tiempo.
            var periodTimeSpan = TimeSpan.FromSeconds(
                5); //Contador en segundos.
            var timer = new System.Threading.Timer((e) => //Iniciamos un nuevo cronómetro que actualizará el árbol cada 15 segundos.
            {
                DibujarÁrbol(); //Llamamos al método.
            }, null, startTimeSpan, periodTimeSpan);

            Console.ReadKey();
        }

        ///<summary>Método donde se dibujará el árbol de Navidad.</summary>
        private static void DibujarÁrbol()
        {
            Console.ResetColor();
            Console.Clear(); //Limpiamos la consola.
            Console.ForegroundColor = ConsoleColor.DarkYellow; //Establecemos el color del texto de la consola en amarillo oscuro para la corona del árbol.
            Console.Write("         ▄▄\n");
            Console.Write("       ▄▄██▄▄\n");
            Console.Write("         ██\n");
            Console.Write("\n");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j < 10 - i + 1; j++)
                {
                    Console.Write(" "); //Espacio antes de cada rama del pino.
                }
                for (int k = 1; k <= i; k++)
                {
                    Random random = new Random((int)DateTime.Now.Ticks); //Generamos números aleatorios para la posición de las esferas.
                    int x = random.Next(1, 6);
                    int y = random.Next(1, 45);
                    switch (x)
                    {
                        case 2:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                    }
                    Console.Write("■");
                    switch (y)
                    {
                        case 2:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                    }
                    Console.Write("■");
                }
                Console.WriteLine("");
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (i == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("        ■■■■\n");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("        ■");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("■■■\n");
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" ");
            string texto = "¡FELIZ NAVIDAD! :3";
            for (int i = 0; i < texto.ToCharArray().Length; i++)
            {
                if (i % 2 == 0)
                    Console.BackgroundColor = ConsoleColor.White;
                else
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write(texto.ToCharArray()[i]);
            }
        }
    }
}
