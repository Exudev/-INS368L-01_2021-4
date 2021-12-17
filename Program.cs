using System;
using System.Collections.Generic;
using System.IO;

namespace KataAnagrama1096394
{
    class Program
    {
        static void Main(string[] args)
        {

          
        }
        public static List<string> leyendoArchivo(string path)

        {
            List<string> result = new List<string>();
            string line;
            if (!File.Exists(path))
            {
                throw new FileNotFoundException();
            }
            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                result.Add(line);
            }

            return result;
        }
        private static bool RevisarAnagrama(string palabra1, string palabra2)
        {
            if (palabra1 == null || palabra2 == null)
            {
                throw new ArgumentNullException();
            }

            if (palabra1.Length != palabra2.Length)
            {
                return false;
            }

            else
            {
                palabra1 = anagramHash(palabra1);
                palabra2 = anagramHash(palabra2);
                if (palabra1 == palabra2)
                {
                    return true;
                }
                else
                    return false;
            }
        }
        private static string anagramHash(string input)
        {
            char[] temp = input.ToLowerInvariant().ToCharArray();
            Array.Sort(temp);
            return new string(temp);
        }
        private static Dictionary<string, string> quitarNoAnagramas(Dictionary<string, string> anagrams)
        {
            foreach (var anagram in anagrams)
            {
                if (RevisarAnagrama(anagram.Key, anagram.Value))
                {
                    anagrams.Remove(anagram.Key);
                }
            }
            return anagrams;
        }
        public static Dictionary<string, string> encontrarAnagrama(List<string> listadoDePalabras)
        {
            Dictionary<string, string> anagrams = new Dictionary<string, string>();

            foreach (var palabra in listadoDePalabras)
            {
                string key = anagramHash(palabra);
                if (anagrams.ContainsKey(key))
                {
                    string value = anagrams[key];
                    anagrams[key] = string.Concat(value, ',', palabra);
                }
                else
                {
                    anagrams.Add(key, palabra);
                }
            }
            anagrams = quitarNoAnagramas(anagrams);
            return anagrams;
        }
        public static string Normalize(string entrada)
        {
            
            string salida;
            salida = entrada.ToLower();
            return salida;
        }
    }
}
