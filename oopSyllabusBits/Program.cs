using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopSyllabusBits
{
    class MyFirstClass   // as simple as a structure
    {
        public string message;
    }
    class MySecondClass  // has a method
    {
        public string message;
        public int messageLength()
        {
            return message.Length;
        }
    }
    class MyThirdClass   // hides data
    {
        private string message;
        public void setMessage(string st)
        {
            message = st;
        }
        public string getMessage()
        {
            return message;
        }
        public int messageLength()
        {
            return message.Length;
        }
    }
    class MyFourthClass  // with a constructor
    {
        private string message;
        public void setMessage(string st)
        {
            message = st;
        }
        public string getMessage()
        {
            return message;
        }
        public int messageLength()
        {
            return message.Length;
        }
        public MyFourthClass()
        {
            message = "A level computer science";
        }
    }
    class MyFifthClass   // with an overloaded constructor
    {
        private string message;
        public void setMessage(string st)
        {
            message = st;
        }
        public string getMessage()
        {
            return message;
        }
        public int messageLength()
        {
            return message.Length;
        }
        public MyFifthClass()
        {
            message = "A level computer science";
        }
        public MyFifthClass(string mess)
        {
            message = mess;
        }
    }
    class MySixthClass   // with an overloaded method
    {
        public int getSize(string mess)
        {
            return mess.Length;
        }
        public int getSize(int num1, int num2)
        {
            return (num1 + num2);
        }
    }
    class Shape
    {
        protected double area;
        public double getArea()
        {
            return area;
        }
        public Shape() { }
        public virtual void calcArea() { }
    }
    class Circle : Shape
    {
        private double radius;
        public override void calcArea()
        {
            area = Math.Pow(radius, 2) * Math.PI;
        }
        public Circle() { }
        public Circle(double r)
        {
            radius = r;
        }
    }
    class Rectangle : Shape
    {
        private double length;
        private double width;
        public override void calcArea()
        {
            area = length * width;
        }
        public Rectangle() { }
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
    }
    class Triangle : Shape
    {
        private double bbase;
        private double height;
        public override void calcArea()
        {
            area = bbase * height;
        }
        public Triangle() { }
        public Triangle(double b, double h)
        {
            bbase = b;
            height = h;
        }
    }
    class Node
    {
        public int info;
        public Node left;
        public Node right;
        public int getValue()
        {
            return info;
        }
        public Node() { }
        public Node(int i)
        {
            info = i;
        }
    }
    class Tree
    {
        public Node root;
        public Tree()
        {
            root = null;
        }
        public Node ReturnRoot()
        {
            return root;
        }
        public void Insert(int info)
        {
        //    Node newNode = new Node(info);
        //    if (root == null)
        //        root = newNode;
        //    else
        //    {
        //        Node current = root;
        //        Node parent;
        //        while (true)
        //        {
        //            parent = current;
        //            if (id < current.info)
        //            {
        //                current = current.left;
        //                if (current == null)
        //                {
        //                    parent.left = newNode;
        //                    return;
        //                }
        //            }
        //            else
        //            {
        //                current = current.right;
        //                if (current == null)
        //                {
        //                    parent.right = newNode;
        //                    return;
        //                }
        //            }
        //        }
        //    }
        }
        public void Preorder(Node Root)
        {
            //if (Root != null)
            //{
            //    Console.Write(Root.item + " ");
            //    Preorder(Root.left);
            //    Preorder(Root.right);
            //}
        }
        public void Inorder(Node Root)
        {
        //    if (Root != null)
        //    {
        //        Inorder(Root.left);
        //        Console.Write(Root.item + " ");
        //        Inorder(Root.right);
        //    }
        }
        public void Postorder(Node Root)
        {
            //if (Root != null)
            //{
            //    Postorder(Root.left);
            //    Postorder(Root.right);
            //    Console.Write(Root.item + " ");
            //}
        }
    }

    class Program
    {
        public static void useMyFirstClass()
        {
            string someWords;
            MyFirstClass objectOne = new MyFirstClass();
            MyFirstClass objectTwo = new MyFirstClass();

            Console.Write("Type a message...");
            someWords = Console.ReadLine();

            objectOne.message = someWords;

            Console.Write("and another...");
            objectTwo.message = Console.ReadLine();

            Console.WriteLine("You typed..." + objectOne.message + " " + objectTwo.message);
        }
        public static void useMySecondClass()
        {
            string someWords;
            MySecondClass objectOne = new MySecondClass();

            Console.Write("Type a message...");
            someWords = Console.ReadLine();

            objectOne.message = someWords;

            Console.Write("Your message " + objectOne.message + " is of length " + objectOne.messageLength());
        }
        public static void useMyThirdClass()
        {
            string someWords;
            MyThirdClass objectOne = new MyThirdClass();

            Console.Write("Type a message...");
            someWords = Console.ReadLine();

            objectOne.setMessage(someWords);

            Console.Write("Your message " + objectOne.getMessage() + " is of length " + objectOne.messageLength());
        }
        public static void useMyFourthClass()
        {
            string someWords;
            MyFourthClass objectOne = new MyFourthClass();
            Console.Write("Your message " + objectOne.getMessage());

            Console.Write("Type a message...");
            someWords = Console.ReadLine();
            objectOne.setMessage(someWords);
            Console.Write("Your message " + objectOne.getMessage() + " is of length " + objectOne.messageLength());
        }
        public static void useMyFifthClass()
        {
            string someWords;
            MyFifthClass objectOne = new MyFifthClass();
            MyFifthClass objectTwo = new MyFifthClass("Dogs are better than cats");
            Console.Write("Type a message...");
            someWords = Console.ReadLine();
            MyFifthClass objectThree = new MyFifthClass(someWords);

            Console.WriteLine("Your messages were...");
            Console.WriteLine(objectOne.getMessage());
            Console.WriteLine(objectTwo.getMessage());
            Console.WriteLine(objectThree.getMessage());
        }
        public static void useMySixthClass()
        {
            Console.Write("Type a message...");
            string str = Console.ReadLine();

            int num1, num2;
            Console.Write("Type an integer...");
            num1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Type another integer...");
            num2 = Convert.ToInt16(Console.ReadLine());

            MySixthClass objectOne = new MySixthClass();
            Console.WriteLine(num1 + " + " + num2 + " = " + objectOne.getSize(num1, num2));
            Console.WriteLine(str + " is length " + objectOne.getSize(str));
        }
        public static void useShapesClass()
        {
            //Shape anyOldShape = new Shape();
            Triangle myTriangle = new Triangle(3, 4);
            Rectangle myRectangle = new Rectangle(4, 5);
            Circle myCircle = new Circle(6);

            myTriangle.calcArea();
            myRectangle.calcArea();
            myCircle.calcArea();

            Console.WriteLine("Triangle area " + myTriangle.getArea());
            Console.WriteLine("Rectangle area " + myRectangle.getArea());
            Console.WriteLine("Circle area " + myCircle.getArea());
        }
        public static void listOfShapes()
        {
            List<Shape> allSortsOfShapes = new List<Shape>();
            allSortsOfShapes.Add(new Rectangle(3, 4));
            allSortsOfShapes.Add(new Rectangle(5, 6));
            allSortsOfShapes.Add(new Circle(10));
            allSortsOfShapes.Add(new Triangle(1, 2));

            foreach (var thing in allSortsOfShapes)
            {
                thing.calcArea();
            }

            foreach (var thing in allSortsOfShapes)
            {
                Console.WriteLine("that shape has an area of " + thing.getArea());
            }

        }
        static void Main(string[] args)
        {
            //            useMyFirstClass();
            //            useMySecondClass();
            //            useMyThirdClass();
            //            useMyFourthClass();
            //            useMyFifthClass();
            //            useMySixthClass();
            //            useShapesClass();
            listOfShapes();
            Console.ReadLine();
        }
    }
}
