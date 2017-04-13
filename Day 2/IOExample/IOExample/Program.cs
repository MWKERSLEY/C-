using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOExample
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(@"C:\Users\student\Desktop\MatthewKersley\C#\Day 2\IOExample\IOExample\TextFile.txt");
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                File.Copy(@"C:\Users\student\Desktop\MatthewKersley\C#\Day 2\IOExample\IOExample\txt3.txt",@"C:\Users\student\Desktop\MatthewKersley\C#\Day 2\IOExample\IOExample\txt0.txt");
            }
        }
    }
}
