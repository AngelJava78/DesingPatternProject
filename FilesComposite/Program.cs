using System;

namespace FilesComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var root = new Folder("root");
            var file1 = new File("File1.txt", 10);
            var file2 = new File("File2.txt", 30);
            var file3 = new File("File3.txt", 120);
            var file4 = new File("File4.txt", 800);
            var file5 = new File("File5.txt", 340);
            var file6 = new File("File6.txt", 122);
            var file7 = new File("File7.txt", 391);

            var folder1 = new Folder("Folder1");
            var folder2 = new Folder("Folder2");
            var folder3 = new Folder("Folder3");

            folder1.AddChild(file1);
            folder1.AddChild(file6);
            folder2.AddChild(file2);
            folder3.AddChild(file3);
            folder3.AddChild(file4);
            folder1.AddChild(folder3);

            root.AddChild(folder1);
            root.AddChild(folder2);
            root.AddChild(file5);
            root.AddChild(file7);

            Console.WriteLine($"Size of folder {root.Name}: {root.GetSize()} ");
            Console.WriteLine($"Size of folder {folder1.Name}: {folder1.GetSize()} ");
            Console.WriteLine($"Size of folder {folder2.Name}: {folder2.GetSize()} ");
            Console.WriteLine($"Size of folder {folder3.Name}: {folder3.GetSize()} ");
            
        }
    }
}
