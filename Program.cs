using System;
using System.Linq;
using System.Text;

namespace CesarEncrypt
{
    class Program
    {
        static char[] letrasAlfabeto = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        static char[] letrasEncriptadas = new char[] { 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A', 'B', 'C' };

        static void Main(string[] args)
        {
            int nEntradas = 0;

            nEntradas = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nEntradas; i++)
            {
                string palavra = Console.ReadLine();
                string palavraEncriptada = EncriptarString(palavra);
                Console.WriteLine(palavraEncriptada);
            }
        }

        static string EncriptarString(string palavra)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in palavra)
            {
                if (c == ' ')
                {
                    sb.Append(' ');
                }
                else
                {
                    for (int i = 0; i < letrasAlfabeto.Count(); i++)
                    {
                        if (letrasAlfabeto[i] == c)
                        {
                            sb.Append(letrasEncriptadas[i]);
                        }
                    }
                }
            }
            return sb.ToString();
        }
    }
}
