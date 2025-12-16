using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AtanaevRI.Sprint6.Task5.V23.Lib
{
    public class DataService : ISprint6Task5V23
    {
        public double[] LoadFromDataFile(string path)
        {
            try
            {
               
                string[] lines = File.ReadAllLines(path)
                    .Where(line => !string.IsNullOrWhiteSpace(line))
                    .ToArray();

                double[] numbers = new double[lines.Length];

                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i].Trim();

                    line = line.Replace('.', ',');

                    if (double.TryParse(line, out double number))
                    {
                      
                        numbers[i] = Math.Round(number, 3);
                    }
                    else
                    {
                        
                        numbers[i] = 0;
                    }
                }

                return numbers;
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException($"Файл {path} не найден");
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при чтении файла: {ex.Message}");
            }
        }
    }
}