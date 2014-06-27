using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainConsole
{

    class Program
    {
        static void Main(string[] args)
        {
            // The files used in this example are created in the topic 
            // How to: Write to a Text File. You can change the path and 
            // file name to substitute text files of your own. 

            // Example #1 
            // Read the file as one string. 
            string text = System.IO.File.ReadAllText(@"C:\Users\matthews\Dropbox\personal\Amtrak\trainweb.org\Data - autotrain.csv");

            // Display the file contents to the console. Variable text is a string.
            System.Console.WriteLine("Contents of WriteText.txt = {0}", text);

            // Example #2 
            // Read each line of the file into a string array. Each element 
            // of the array is one line of the file. 
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\matthews\Dropbox\personal\Amtrak\trainweb.org\Data - autotrain.csv");

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            String[] headers = lines[0].Split(',');
            foreach (string header in headers)
            {
                Console.Write(header + "\t");
            }
            lines[0] = "";
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                String[] var=line.Split(',');
                foreach (string cell in var)
                {
                    Console.Write( cell + ":\t");
                }
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
                  
   }
}
// The following displays possible output from this example: 
//       Enter one or more lines of text (press CTRL+Z to exit): 
//        
//          This is line #1. 
//             This is line #1. 
//          This is line #2 
//             This is line #2 
//          ^Z 
//        
//       >

        }
   
