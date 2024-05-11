using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    internal class FileRead
    {
        public static void Main()
        {
            //there are many overloads for FileStream like FileMode.Open
            Stream s = new FileStream(@"E:\CSharp\tutorial\FirstCode\FileRead.cs", FileMode.Open);
            int obj;
            StringBuilder str = new StringBuilder();
            while((obj = s.ReadByte()) != -1)
            {
                str.Append((char)obj);
            }
            Console.Write(str.ToString());
            
        }
    }
}
