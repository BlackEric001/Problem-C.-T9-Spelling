using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace T9Spelling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> result = new List<string>();

            CheckT9Spelling checkSpelling = new CheckT9Spelling();
            checkSpelling.buildDictionary();

            //using (StreamReader fs = new StreamReader(@"h:\Downloads\C-small-practice.in"))
            using (StreamReader fs = new StreamReader(@"h:\Downloads\C-large-practice.in"))
            {
                int lineCount = Int32.Parse(fs.ReadLine());
                int lineNumber = 1;

                //Skip empty line
                //fs.ReadLine();

                while (true)
                {
                    // Читаем строку из файла во временную переменную.
                    string temp = fs.ReadLine();

                    // Если достигнут конец входящего файла, прерываем считывание.
                    if (temp == null)
                        break;

                    //Проверка строки и добавление в итоговый список
                    result.Add(String.Format("Case #{0}: {1}", lineNumber, checkSpelling.get_pattern(temp)));

                    lineNumber++;
                }
            }

            //Сохраняем результат в выходной файл
            //using (TextWriter tw = new StreamWriter(@"h:\Downloads\C-small-practice.out"))
            using (TextWriter tw = new StreamWriter(@"h:\Downloads\C-large-practice.out"))
            {
                foreach (String s in result)
                    tw.WriteLine(s);
            }

            // Выводим на экран.
            //Console.WriteLine(text);
        }

    }
}
