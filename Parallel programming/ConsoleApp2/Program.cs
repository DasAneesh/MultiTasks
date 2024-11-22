using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LiveCharts;
using LiveCharts.Wpf;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();

            List<int> InitilazeComp(int Sz_Count)
            {
                Random rnd = new Random();
                List<int> Newarr = new List<int>();
                for (int i = 0; i < Sz_Count; i++)
                {
                    Newarr.Add(rnd.Next(-100, 100));
                }
                return Newarr;

            }
            void Showarr(List<int> ints)
            {
                for (int i = 0; i < ints.Count; i++)
                {
                    Console.WriteLine(ints[i]);
                }
            }
            int SimpleSums(List<int> ints)
            {
                int sum = 0;
                for (int i = 0; i < ints.Count; i++)
                {
                    sum += ints[i];
                }
                return sum;
            }
            int TaskSums(List<int> ints,int threadCount)
            {
                int sum = 0;
                Task[] tasks = new Task[threadCount];
                for (var i = 0; i < threadCount; i++)
                {
                    tasks[i] = Task.Run(
                        () =>
                    {
                        //Вычислить диапазон суммирования
                        List<int> nwints = new List<int>();

                        //суммировать

                    }
                    );
                    tasks[i].Start();   // запускаем задачу
                }
                Console.WriteLine("Завершение метода Main");

                Task.WaitAll(tasks); // ожидаем завершения всех задач}
                return sum;
            }

            Console.WriteLine(SimpleSums(InitilazeComp(200)));
            Console.ReadLine();

        }

        }
    }
