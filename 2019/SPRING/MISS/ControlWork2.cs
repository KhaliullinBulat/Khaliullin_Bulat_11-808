using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ControlWork2
{
    //    КЛАСС КО ВТОРОМУ ЗАДАНИЮ
    class TestClass
    {
        public void TestMethod(int testInt, string testString)
        {
            Console.WriteLine(testString + testInt);
        }
    }

    class StudentInfo
    {
        public int CountOfRightTasks;
        public List<string>[];
    }

    class Program
    {
        //     1-ОЕ ЗАДАНИЕ  !!!!
        static void SearchDocuments(string dirName)
        {
            string[] files = Directory.GetDirectories(dirName);
            foreach (var file in files)
                Console.WriteLine(file);
        }

        //    2-ОЕ ЗАДАНИЕ  !!!!
        static void CheckingDocuments(string dirName)
        {
            string[] files = Directory.GetDirectories(dirName);
            FileStream fstream = File.OpenRead(dirName);

        }

        static void Main()
        {
            string dirName = Console.ReadLine(); // получаем название директории
            string[][] files = Directory.GetDirectories(dirName).ToArray()[]; // папки в главной папке
            foreach(var e in files)
                Parallel.ForEach(e, SearchDocuments); // многопоточный вывод файлов из папок

            
            foreach (var document in files) // 
            {
                Parallel.ForEach(document, CheckingDocuments);
            }
        }
    }
}
