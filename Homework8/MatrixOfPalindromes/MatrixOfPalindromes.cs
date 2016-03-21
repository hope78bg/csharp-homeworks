using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfPalindromes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string[,] elementMatrix = new string[n, m];
                  for (int i = 0; i < n; i++) {
                      for (int j = 0; j < m; j++) {
                        elementMatrix[i,j] = ""+(char)('a'+i)+(char)('a'+j+i)+(char)('a'+i);

                            }
                        }  
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(elementMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
