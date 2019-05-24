using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testdrillpg52
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Drill");  //Showing Header
            Console.WriteLine("\n\n");          //going down 2 new lines

            //Concatenate three strings

            string strng1 = "I am ";                 //first string to concatenate
            string strng2 = "concatenating ";        //second string to concatenate
            string strng3 = "three strings.";        //third string to concatenate
            Console.WriteLine( string.Concat(string.Concat(strng1, strng2), strng3)); //concatenating all 3 strngs together
            Console.WriteLine("\n");                                                  //new line

            //Convert a string to uppercase.

            string caps = "showing all capitals";                   //text assigned to caps
            caps = caps.ToUpper();                                  //changing caps text to uppercase and reassigning to caps
            Console.WriteLine(caps);                                //writing caps
            Console.WriteLine("\n");                                //new line

            //Create a Stringbuilder and build a paragraph of text, one sentence at a time.

            StringBuilder lineToPgrph = new StringBuilder();
            lineToPgrph.Append("\t This is the first line of a paragraph using escape character tab. "); //assigns text to lineToPgrph
            lineToPgrph.AppendLine();
            lineToPgrph.Append("This is the second line. Is it working correctly?");                    //assigns text to lineToPgrph
            lineToPgrph.AppendLine();
            lineToPgrph.Append("With this line, I will show the new line escape character \nThis is the new line.");//assigns text to lineToPgrph
            lineToPgrph.AppendLine();
            lineToPgrph.Append("This line will show \"quotes\". I hope this is a pass!");                //assigns text to lineToPgrph
            lineToPgrph.AppendLine();
            lineToPgrph.Append("I am not 100% sure how this last process is working, But it is...");     //assigns text to lineToPgrph 
            lineToPgrph.AppendLine();
            lineToPgrph.Append("If you're reading this, let me know...");     //assigns text to lineToPgrph 
            Console.WriteLine(lineToPgrph);
            Console.ReadLine();
        }
    }
}
