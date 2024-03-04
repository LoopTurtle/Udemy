using System;
using System.Text;

namespace Coding.Exercise
{
    // ***Target output:***
    //public class Person
    //{
    //    public string Name;
    //    public int Age;
    //}

    public class CodeBuilder
    {
        private StringBuilder sb = new StringBuilder();
        private string className;

        public CodeBuilder(string className)
        {
            this.className = className;
            sb.AppendLine($"public class {className}");
            sb.AppendLine("{");
        }

        public CodeBuilder AddField(string fieldName, string fieldType)
        {
            sb.AppendLine($"  public {fieldType} {fieldName};");
            return this;
        }


        public override string ToString()
        {
            sb.AppendLine("}");
            return sb.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int").AddField("Northern", "bool").AddField("Hairstyle", "string");
            Console.WriteLine(cb);
        }
    }
}

