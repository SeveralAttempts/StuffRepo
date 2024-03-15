using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternPract;

namespace Graphics
{
    class CompositeGraphic
    {
        FigureBox root;
        List<FigureBox> listOfRoots;

        public CompositeGraphic(FigureBox root)
        {
            this.root = root;
            listOfRoots = new();
            listOfRoots.Add(root);
        }

        public void Display()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(root.Display());
                if (!Enter())
                {
                    break;
                }
            }
        }

        private bool Enter()
        {
            Console.WriteLine("\nEnter type:\n");
            var type = Console.ReadLine();
            type = type.ToLower();
            type = type.Replace(" ", "");

            switch (type)
            {
                case "circle":
                    Console.WriteLine("Enter name:\n");
                    var circleName = Console.ReadLine();
                    root.Add(new Circle(circleName));
                    break;
                case "figurebox":
                    Console.WriteLine("Enter name:\n");
                    var figureBoxName = Console.ReadLine();
                    root.Add(this.AddRoot(figureBoxName));
                    break;
                case "square":
                    Console.WriteLine("Enter name:\n");
                    var squareName = Console.ReadLine();
                    root.Add(new Square(squareName));
                    break;
                case "root":
                    Console.WriteLine("Enter name:\n");
                    var rootName = Console.ReadLine();
                    rootName = rootName.ToLower();
                    this.ChangeRoot(rootName);
                    break;
                case "exit":
                    return false;


                default:
                    Console.WriteLine("No such command");
                    break;
            }
            return true;
        }

        private FigureBox AddRoot(string name)
        {
            var box = new FigureBox(name);
            listOfRoots.Add(box);
            return box;
        }

        private void ChangeRoot(string rootName)
        {
            foreach (var singleRoot in listOfRoots)
            {
                var temp = singleRoot.ToString().ToLower();
                if (rootName.Equals(temp))
                {
                    this.root = singleRoot;
                    return;
                }
            }
            Console.WriteLine("No such root!");
        }
    }
}
