namespace Random_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            RandomList myList = new RandomList();

            myList.Data.Add(5);
            myList.Data.Add(6);
            myList.Data.Add(7);
            myList.Data.Add(8);
            myList.Data.Add(9);

            Console.WriteLine(myList.RandomString());
        }
    }
}
