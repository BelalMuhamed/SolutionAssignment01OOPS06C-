namespace Assignment01OOPS06C_
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            #region V01
            Point point1 = new Point();
            Console.WriteLine(point1.ToString());
            Point point2 = new Point(5,6);
            Console.WriteLine(point2.ToString());

            #endregion

            #region v02
            employee em=new employee();
            em.SetId(1);
            em.SetSalary(50000);
            em.SetName("Bilal");
            Console.WriteLine(em.GetId());
            Console.WriteLine(em.GetSalary());
            Console.WriteLine(em.GetName());

            #endregion

            #region v04
            employee2 emp = new employee2();
            emp.Id = 2;
            emp.Age = 25;
            emp.Name = "Bilal";
         
            Console.WriteLine(emp.ToString());
            #endregion

            #region v05
            Console.Clear();
            BookNumber bookNumber = new BookNumber(3);
            bookNumber.Add(0, "Bilal", 123456);
            bookNumber.Add(1, "Ibrahim", 1236);
            bookNumber.Add(2, "yahya", 123);

            Console.WriteLine(bookNumber["Bilal"]);
            bookNumber["yahya"] = 999;
            Console.WriteLine(bookNumber["yahya"]);

            #endregion
            #region v06
            Car car = new Car(10, 500, "BMW");
            Car car1 = new Car(10, 500);
            Car car2 = new Car(10);
            Console.WriteLine(car.ToString());
            Console.WriteLine(car1.ToString());
            Console.WriteLine(car2.ToString());

            #endregion
        }
    }
}
