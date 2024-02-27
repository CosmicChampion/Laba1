using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    internal class FileManger
    {
        private const string FILEPATH = "D:\\Programing\\CS\\WindowsFormsApp1\\WindowsFormsApp1\\INFO.json";
        public void WriteToJsonFile<T>(T data)
        {
            
                // Конвертуємо об'єкт у JSON формат
                string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);

                // Записуємо JSON дані у файл
                File.WriteAllText(FILEPATH, jsonData);
           
        }

        public List<T> ReadFromJsonFile<T>()
        {
            
                // Зчитуємо JSON дані з файлу
                string jsonData = File.ReadAllText(FILEPATH);

                
                return JsonConvert.DeserializeObject<List<T>>(jsonData);
           
            
        }
    }
}

