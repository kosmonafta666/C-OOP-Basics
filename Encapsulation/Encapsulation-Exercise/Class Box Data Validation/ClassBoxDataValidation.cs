namespace Class_Box_Data_Validation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;


    class ClassBoxDataValidation
    {
        static void Main(string[] args)
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());


            //read the length
            var length = double.Parse(Console.ReadLine());

            //read the width;
            var width = double.Parse(Console.ReadLine());

            //read the height;
            var height = double.Parse(Console.ReadLine());

            try
            {
                //create box object;
                var box = new Box(length, width, height);

                //printing the result;
                Console.WriteLine("Surface Area - {0:F2}", box.SurfaceArea());

                Console.WriteLine("Lateral Surface Area - {0:F2}", box.LateralSurfaceArea());

                Console.WriteLine("Volume - {0:F2}", box.Volume());

            }
            catch(ArgumentException error)
            {
                Console.WriteLine(error.Message);
            }
                       
        }
    }
}
