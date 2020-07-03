using System;

namespace ConsoleApp_FinalAnswer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Adult adult = new Adult();
            adult.FirstName = "Yun";
            adult.LastName = "Han";
            Child child = new Child();
            child.FirstName = "Fei";
            child.LastName = "Sun";
            Object[] Objs = new Object[2];
            Objs[0] = adult;
            Objs[1] = child;
            //Console.WriteLine("ADULT: " + adult.FirstName);
            foreach (Object o in Objs) 
            {
                //Console.WriteLine(o.GetType());
                if (o.GetType() == typeof(Adult))
                {
                    Adult a = (Adult)o;
                    Console.WriteLine("ADULT: " + a.FirstName + " " + a.LastName);
                }else 
                {
                    Child c = (Child)o;
                    Console.WriteLine("CHILD: " + c.FirstName + " " + c.LastName);
                }
            }

            
        }
    }

    class Adult
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Child
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


}
