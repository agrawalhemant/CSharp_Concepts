using System; 

//base-class libraries are imported using "using"

namespace FirstCode
{
    class FirstClass :ParentClass
    {
        static void Main(string[] args)
        {
            Class3 c = new Class3();
            c.show();
            ParentClass.x = 4;
            Console.WriteLine("x in child class become: "+ParentClass.x);
            c.show();
            ParentClass.x = 10;
            ParentClass p = new ParentClass();
            p.y = 20;
            p.View();
            Console.WriteLine("x in child class become : " + ParentClass.x);
            c.show();
            Object obj = new Object();
            Console.WriteLine(obj.GetType());
            Console.Read();
        } 
    }

    class ParentClass 
    {
        public static int x;
        public int y = 15;
        static ParentClass()
        {
            x = 1;
            Console.WriteLine("x : " + x);
            Console.WriteLine("Parent class constructor called");
        }

        public void View()
        {
            Console.WriteLine("x : " + x + " and y : " + y);

        }
    } 

    class Class3 : ParentClass
    {
        public void show()
        {
            Console.WriteLine("x in Class3 become: " + ParentClass.x);
        }
    }
}
