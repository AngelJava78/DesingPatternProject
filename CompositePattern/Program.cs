using CompositePattern.Items;
using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IComponent<string> tree = new Composite<string>("root");
            IComponent<string> work = tree;
            string option = "";
            string data = "";
            while(option != "6")
            {
                Console.WriteLine($"I'm in {work.Name}");
                Console.WriteLine("1. Add composite 2. Add component. 3. Delete. 4. Find. 5. Show. 6. Close");
                option = Console.ReadLine();
                Console.WriteLine("-------");

                if(option == "1")
                {
                    Console.WriteLine("Input the name of composite: ");
                    data = Console.ReadLine();
                    IComponent<string> component= new Composite<string>(data);
                    work.Add(component);
                    work = component;
                }
                else if(option == "2")
                {
                    Console.WriteLine("Input the name of component: ");
                    data = Console.ReadLine();
                    work.Add(new Component<string>(data));
                }
                else if(option == "3")
                {
                    Console.WriteLine("Input the element to delete: ");
                    data = Console.ReadLine();
                    work = work.Delete(data);
                }
                else if(option =="4")
                {
                    Console.Write("Input the element to find: ");
                    data = Console.ReadLine();
                    work = tree.Find(data);
                }
                else if (option == "5")
                {
                    Console.WriteLine(tree.Show(0));
                }

            }

        }
    }
}
