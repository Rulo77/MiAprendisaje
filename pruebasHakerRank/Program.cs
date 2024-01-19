
using System.Diagnostics;


namespace pruebasHakerRank
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Stopwatch stopwatch = new Stopwatch();

            char[] a = { 'a', 'b', 'c', 'c', 'c' };
            char[] b = { 'a', 'b', 'c', 'd' };
            stopwatch.Start();
            bool resultado = ContieneDuplicados3(b);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            Console.WriteLine(resultado);

        }


        static bool ContieneDuplicados(char[] caracteres)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (var caracter in caracteres)
            {
                set.Add(caracter);    
            }
            return set.Count != caracteres.Length;
        }

        static bool ContieneDuplicados2(char[] caracteres)
        {
            for (int i = 0; i < caracteres.Length; i++)
            {
                for (int j = 0; j < caracteres.Length; j++)
                {
                    if(j != i & caracteres[i] == caracteres[j])
                    {
                        return true;
                    }

                }
            }

            return false;
        }

        static bool ContieneDuplicados3(char[] caracteres)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (char caracter in caracteres) 
            {
                if (set.Contains(caracter))
                {
                    return true;
                }
            
                set.Add(caracter);
            }

            return false;
        }
    }
}