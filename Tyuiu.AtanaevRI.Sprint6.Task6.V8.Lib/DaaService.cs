using System;
using System.IO;
using System.Linq;
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

                char[] separators = new char[]
                {
                    ' ', ',', '.', '!', '?', ';', ':', '\t', '\n', '\r',
                    '(', ')', '[', ']', '{', '}', '"', '\'', '-', '_'
                };

                string[] words = fileContent.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    var wordsWithZ = words
                    .Where(word => word.IndexOf('z', StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToArray();

        
                string result = string.Join(Environment.NewLine, wordsWithZ);

                return result;
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