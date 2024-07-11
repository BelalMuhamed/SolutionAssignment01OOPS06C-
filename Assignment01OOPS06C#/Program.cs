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
        }
    }
}
