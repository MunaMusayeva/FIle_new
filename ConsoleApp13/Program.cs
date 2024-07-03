
class Program
{
    static void Main()
    {

        //Directory.CreateDirectory("C:\\Users\\musa_qo76\\Desktop\\demo");

        //Console.WriteLine(Directory.GetCurrentDirectory());

        //Directory.Delete("C:\\Users\\musa_qo76\\Desktop\\demo");

        //using StreamWriter sw = new StreamWriter("books.txt");



        //string directoryPath = @"C:\Users\USER\Desktop";
        //Console.Write("Axtarmaq istədiyiniz fayl adını daxil edin (məsələn, *.txt): ");
        //string searchPattern = Console.ReadLine();
        //try
        //{
        //    string[] files = Directory.GetFiles(directoryPath, searchPattern, SearchOption.AllDirectories);
        //    if (files.Length == 0)
        //    {
        //        Console.WriteLine("Heç bir fayl tapılmadı.");
        //    }
        //    else
        //    {
        //        foreach (string file in files)
        //        {
        //            Console.WriteLine($"\nTapıldı: {file}");
        //            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
        //            {
        //                using (StreamReader reader = new StreamReader(fs))
        //                {
        //                    string content = reader.ReadToEnd();
        //                    Console.WriteLine($"Məzmun:\n{content}");
        //                }
        //            }
        //        }
        //    }
        //}
        //catch (DirectoryNotFoundException)
        //{
        //    Console.WriteLine("Göstərilən yol mövcud deyil.");
        //}
        //catch (UnauthorizedAccessException)
        //{
        //    Console.WriteLine("Direktoriyaya daxil olmaq üçün icazə yoxdur.");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine($"Xəta baş verdi: {ex.Message}");
        //}

        //DirectoryInfo directoryInfo = new($"C:\\Users\\USER\\Desktop");
        //foreach (FileInfo file in directoryInfo.GetFiles())
        //    Console.WriteLine(file.Name);
    }
}
