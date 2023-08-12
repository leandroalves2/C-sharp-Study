using System;
using System.Collections.Generic;


namespace _7_exemplo_list {
    internal class Program {
        static void Main(string[] args) {

            List<string> list = new List<string> {"Maria", "Joao" };

            list.Add("Alex");
            list.Add("bob");
            list.Add("Rafael");
            list.Add("Marco");
            list.Insert(2, "Paulo");
            list.Insert(2, "Monica");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            Console.WriteLine("List Count: " + list.Count);
            Console.WriteLine();

            Console.WriteLine();
            string s1 = list.Find(Test);
            Console.WriteLine("Fist 'M': " + s1);

            string s2 = list.FindLast(x => x[0] == 'M');
            Console.WriteLine("Last 'M': " + s2);
            Console.WriteLine();


            int posi = list.FindIndex(Test2);
            Console.WriteLine("Fist position 'M': " + posi);

            int posi2 = list.FindLastIndex(x => x[0] == 'M');
            Console.WriteLine("Fist position 'M': " + posi2);
            Console.WriteLine();

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("List 2");
            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("--------------------------------------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            list.RemoveAt(2);
            Console.WriteLine("--------------------------------------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            list.RemoveRange(2,2);
            Console.WriteLine("--------------------------------------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();


        }

        static bool Test(string s) {
            return s[0] == 'M';
        }
        static bool Test2(string s) {
            return s[0] == 'M';
        }

    }
}
