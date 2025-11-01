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
        public static Root Read()
        {
            Root root = null;
            try
            {
                // Ruta del archivo JSON
                //string filePath = Application.StartupPath + ".\\...\\...\\data.json";
                string filePath = ".\\database.json";

                // Leer todo el contenido del archivo
                string jsonContent = File.ReadAllText(filePath);

                // Deserializar el JSON en el objeto Root
                root = JsonSerializer.Deserialize<Root>(jsonContent);

                // Acceder a los datos
                Console.WriteLine($"Usuario: {root.settings.username}");
                Console.WriteLine("Clientes:");

                foreach (var c in root.data.customers)
                {
                    Console.WriteLine($"ID: {c.id}");
                    Console.WriteLine($"Nombre: {c.name}");
                    Console.WriteLine($"Teléfono: {c.cellphone}");
                    Console.WriteLine($"Dirección: {c.address}");
                    Console.WriteLine("---------------------------");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer o deserializar el archivo: {ex.Message}");
            }
            return root;
        }
    }
}
