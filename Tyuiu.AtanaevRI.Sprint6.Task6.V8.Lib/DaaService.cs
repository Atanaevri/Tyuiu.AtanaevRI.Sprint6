using System;
using System.IO;
using System.Linq;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AtanaevRI.Sprint6.Task6.V8.Lib
{
    public class DataService : ISprint6Task6V8
    {
        public string CollectTextFromFile(string path)
        {
            try
            {
                string fileContent = File.ReadAllText(path);

                
                string[] lines = fileContent.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
    StringBuilder result = new StringBuilder();

                foreach (string line in lines)
                {
                    string[] words = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                      
                        if (word.Contains('z'))
                        {
                            if (result.Length > 0)
                            {
                                result.Append(" ");
                            }
                            result.Append(word);
                        }
                    }
                }

                return result.ToString();
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException($"Файл {path} не найден");
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при обработке файла: {ex.Message}");
            }
        }
    }
}