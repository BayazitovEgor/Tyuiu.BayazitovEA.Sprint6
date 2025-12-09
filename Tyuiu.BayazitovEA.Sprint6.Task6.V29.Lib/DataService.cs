using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.BayazitovEA.Sprint6.Task6.V29.Lib
{
    public class DataService : ISprint6Task6V29
    {
        public string CollectTextFromFile(string path)
        {
            string result = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Split line into words
                    string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        // Check if word contains lowercase 'i'
                        if (word.Contains("i"))
                        {
                            // Add to result with space if not first word
                            if (!string.IsNullOrEmpty(result))
                            {
                                result += " ";
                            }
                            result += word;
                        }
                    }
                }
            }

            return result;
        }
    }
}