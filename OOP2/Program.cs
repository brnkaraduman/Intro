using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("asdasd");
            myList.Add("asdasd");
            myList.Add("asdasd");
            myList.Add("asdasd");
            myList.Add("asdasd");
            myList.Add("asdasd");
            Console.WriteLine(myList.Length);
        }
    }
}
