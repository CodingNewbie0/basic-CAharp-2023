using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs16_inheritance
{
    class Base // 기반 또는 부모클래스
    {   // 자식클래스에서 상속 받으려면 private은 안써야 함
        protected string Name;
        private string Color; // 만약에 상속을 할꺼면 private을 protected로 변경!!
        public int Age;

        public Base(string Name, string Color, int Age)
        {
            this.Name = Name;
            this.Color = Color;
            this.Age = Age;
            Console.WriteLine("{0}.Base()", Name);
        }

        public void BaseMethod()
        {
            Console.WriteLine("{0}.BaseMethod()", Name);
        }

        public void BaseGetColor() 
        {
            Console.WriteLine("{0}.BaseGetColor()", Color);
        }

    }

    class Child : Base
    {
        public Child(string Name, string Color, int Age) : base(Name, Color, Age) 
        {
            Console.WriteLine("{0}.Child()", Name);
        }

        public void ChildMethod()
        {
            Console.WriteLine("{0}.ChildMethod()", Name);
        }

        //public void GetColor() // 보호 수준때문에 접근불가
        //{
        //    return Color;
        //}

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base("NameB", "White", 1);
            b.BaseMethod();
            b.BaseGetColor();

            Child c = new Child("NameC", "Black", 2);
            c.BaseMethod();
            c.ChildMethod();
            c.BaseGetColor(); // Base.GetColor Black... c에서 Color에 접근불가!
        }
    }
}
