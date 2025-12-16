using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
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
                List<double> negativeNumbers = new List<double>();

                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i].Trim();
                    line = line.Replace('.', ',');

                    if (double.TryParse(line, out double number))
                    {
              
                        double roundedNumber = Math.Round(number, 3);

                   
                        if (roundedNumber < 0)
                        {
                            negativeNumbers.Add(roundedNumber);
                        }
                    }
                }

                return negativeNumbers.ToArray();
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