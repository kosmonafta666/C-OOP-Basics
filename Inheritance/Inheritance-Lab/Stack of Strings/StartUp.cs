namespace Stack_of_Strings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings myStack = new StackOfStrings();

            myStack.Push("1");
            myStack.Push("2");
            myStack.Push("3");

            Console.WriteLine(myStack.IsEmpty());

            Console.WriteLine(myStack);
        }
    }
}
