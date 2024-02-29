using System.IO;

namespace FinalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string Folder = @"C:/dev/Skillfactory/Новая папка"; // указываем путь
            if (Directory.Exists(Folder)) //проверяем, что директория существует
            {
                string[] dirs = Directory.GetDirectories(Folder); //получаем все директории корневого каталога

                foreach (string dir in dirs) // выводим их
                {
                    Console.WriteLine(dir);
                    Console.WriteLine();
                    Console.WriteLine("Файлы");
                    string[] files = Directory.GetFiles(Folder); // получаем все файлы корневого каталога

                    foreach (string file in files) // выводим их
                    {
                        Console.WriteLine(file);
                    }
                }
            }


            try
            {
                TimeSpan interval = TimeSpan.FromMinutes(1); // создаем объект TimeSpan, который представляет 30м интервал
                DirectoryInfo FL = new DirectoryInfo("C:/dev/Skillfactory/Новая папка"); // создаем экземпляр класса для директории

                foreach (FileInfo f in FL.GetFiles()) // foreach перебирает файлы
                {
                    f.Delete();
                }

                foreach (DirectoryInfo f in FL.GetDirectories()) // foreach перебирает поддиректории
                {
                    f.Delete();
                }

            }
            catch (Exception ex) // если будет исключение, то выводится ошибка в консоль
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

