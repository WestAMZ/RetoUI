using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RetoUI
{
    internal class DataReader
    {
        private static string filePath = ".\\database.json";
        public static Root Read()
        {
            Root root = null;
            try
            {
                // Leer todo el contenido del archivo
                string jsonContent = File.ReadAllText(filePath);

                // Deserializar el JSON en el objeto Root
                root = JsonSerializer.Deserialize<Root>(jsonContent);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer o deserializar el archivo: {ex.Message}");
            }
            return root;
        }
        public static void Write(Root root) 
        {
            try
            {

                // Deserializar el JSON en el objeto Root
                var stringRoot = JsonSerializer.Serialize<Root>(root);

                // Escribir en archivo
                File.WriteAllText(filePath, stringRoot);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir o deserializar el archivo: {ex.Message}");
            }
        }
    }
}
