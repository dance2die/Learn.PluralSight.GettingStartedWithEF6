using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringClass sc = new StringClass();
            sc.setField("new value");

            Console.WriteLine(sc.getField());
        }
    }

    internal class StringClass
    {
        private string field = "default";

        public void setField(string field)
        {
            field = field;
        }

        public string getField()
        {
            return field;
        }
    }
}
