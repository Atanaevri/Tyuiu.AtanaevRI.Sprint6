using System;
using System.Windows.Forms;
using System.IO;
using Tyuiu.AtanaevRI.Sprint6.Task6.V8.Lib;

namespace Tyuiu.AtanaevRI.Sprint6.Task6.V8
{
    public partial class FormMain : Form
    {
        private DataService ds;

        public FormMain()
        {
            InitializeComponent();
            ds = new DataService();
        }

        private void buttonOpenFile_ARI_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                    openFileDialog.FileName = "InPutFileTask6V8.txt";
                    openFileDialog.Title = "Выберите файл для анализа";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;

                     
                        string fileContent = File.ReadAllText(filePath);
                        textBoxIn_ARI.Text = fileContent;
                        labelFilePath_ARI.Text = $"Файл: {Path.GetFileName(filePath)}";

                      
                        string result = ds.CollectTextFromFile(filePath);
                        textBoxOut_ARI.Text = result;

                        UpdateStatistics(fileContent, result);

                        MessageBox.Show($"Файл загружен успешно!\nНайдено слов с 'z': {CountLines(result)}",
                            "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обработке файла:\n{ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStatistics(string inputText, string outputText)
        {
          
            char[] separators = new char[] { ' ', ',', '.', '!', '?', ';', ':', '\t', '\n', '\r' };
            string[] inputWords = inputText.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int outputWordCount = CountLines(outputText);

            labelInputCount_ARI.Text = $"Всего слов: {inputWords.Length}";
            labelOutputCount_ARI.Text = $"Слов с 'z': {outputWordCount}";
        }

        private int CountLines(string text)
        {
            if (string.IsNullOrEmpty(text))
                return 0;

            return text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        private void buttonHelp_ARI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 | Таск 6 | Вариант 8 | Атанаев Р.И. | РППБ-25-1\n\n" +
                "Задание:\n" +
                "1. Загрузить файл InPutFileTask6V8.txt через OpenFileDialog\n" +
                "2. Вывести содержимое файла в textBoxIn\n" +
                "3. Найти все слова, содержащие букву 'z' (без учета регистра)\n" +
                "4. Вывести найденные слова в textBoxOut (каждое слово на новой строке)\n" +
                "5. Показать статистику: общее количество слов и количество слов с 'z'",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonClear_ARI_Click(object sender, EventArgs e)
        {
       textBoxIn_ARI.Clear();
            textBoxOut_ARI.Clear();
            labelFilePath_ARI.Text = "Файл: не выбран";
            labelInputCount_ARI.Text = "Всего слов: 0";
            labelOutputCount_ARI.Text = "Слов с 'z': 0";
        }

        private void buttonCreateTestFile_ARI_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "InPutFileTask6V8.txt");
                string[] testData = {
                    "The quick brown fox jumps over the lazy dog",
                    "Zebra is an amazing animal from Africa",
                    "In the zoo, you can see many animals",
                    "Some words with z: puzzle, crazy, buzz, fuzzy, dizzy",
                    "The wizard waved his magic wand",
                    "Winter in New Zealand is amazing",
                    "Programming in C# is awesome"
                };

                File.WriteAllLines(path, testData);

                MessageBox.Show($"Тестовый файл создан:\n{path}",
                    "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании файла:\n{ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxIn_ARI_TextChanged(object sender, EventArgs e)
        {
          
            if (!string.IsNullOrEmpty(textBoxIn_ARI.Text))
            {
                try
                {
                    string tempPath = Path.GetTempFileName();
                    File.WriteAllText(tempPath, textBoxIn_ARI.Text);

                    string result = ds.CollectTextFromFile(tempPath);
                    textBoxOut_ARI.Text = result;
                    UpdateStatistics(textBoxIn_ARI.Text, result);

                    File.Delete(tempPath);
                }
                catch
                {
                  
                }
            }
            else
            {
                textBoxOut_ARI.Clear();
                labelInputCount_ARI.Text = "Всего слов: 0";
                labelOutputCount_ARI.Text = "Слов с 'z': 0";
            }
        }
    }
}