using Demo.EX1;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Example - 1  [SWAP]
            //int a = 10, b = 20;
            //Console.WriteLine($"Before Swap: a = {a}, b = {b}");
            //Helper.Swap(ref a, ref b);
            //Console.WriteLine($"After Swap: a = {a}, b = {b}");

            //decimal x = 10.5m, y = 20.5m;
            //Console.WriteLine($"Before Swap: x = {x}, y = {y}");
            //Helper.Swap(ref x, ref y);
            //Console.WriteLine($"After Swap: x = {x}, y = {y}");


            //Point p1 = new Point(10, 20);
            //Point p2 = new Point(30, 40);
            //Console.WriteLine($"Before Swap: p1 = {p1}, p2 = {p2}");
            //Helper.Swap(ref p1, ref p2);
            //Console.WriteLine($"After Swap: p1 = {p1}, p2 = {p2}");

            //object obj1 = 12;
            //object obj2 = 10;
            //Console.WriteLine($"Before Swap: obj1 = {obj1}, obj2 = {obj2}");
            //Helper.Swap(ref obj1, ref obj2);
            //Console.WriteLine($"After Swap: obj1 = {obj1}, obj2 = {obj2}");
            //Console.Read();


            //Helper<int>.Swap(ref a, ref b);
            //Helper<decimal>.Swap(ref x, ref y);
            //Helper<Point>.Swap(ref p1, ref p2);

            #endregion
            #region 2) Example - 2 [Linear Search]
            //int[] arr = { 10, 20, 30, 40, 50 };
            //int result = Helper.LinearSearch(ref arr, 30);
            //Console.WriteLine($"Index Of target value = {result}");
            //result = Helper.LinearSearch(ref arr, 90);
            //Console.WriteLine($"Index Of target value = {result}");



            //Point[] points =
            //  {
            //    new Point(10, 20),
            //    new Point(30, 40),
            //    new Point(50, 60)
            //  };
            //int result = Helper.LinearSearch(points, new Point(30, 40));
            //Console.WriteLine($"Index Of target value = {result}");
            //Employee[] employees =
            //{
            //    new Employee (10 , 1000 , "Abdol"),
            //    new Employee (12 , 4000 , "Abdol"),
            //    new Employee (10 , 1040 , "Abdol")
            //};
            //Employee employee = new Employee (12, 4000, "Abdol");
            //result = Helper.LinearSearch(employees, employee);
            //Console.WriteLine($"Index Of target value = {result}");
            ////if(employee01 == employee02)
            ////    Console.WriteLine("Equal");
            ////else
            ////    Console.WriteLine("Not Equal");

            #endregion
        }
    }
}
