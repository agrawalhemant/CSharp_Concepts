using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    internal class Test
    {
        static void Main()
        {
            string[] strs = { "flower", "flow", "flight" };
            Console.WriteLine(LongestCommonPrefix(strs));
            int[] a = { 1, 5 , 9 ,88 ,0000};
            int[] b = { 2, 3};
            var output = Merge(a, b);
            foreach(int k in output)
            {
                Console.Write(k + " ");
            }
        }
        public static int[] Merge(int[] a, int[] b)
        {
            int al = a.Length;
            int bl = b.Length;
            int[] output = new int[al + bl];
            int ax = 0; int bx = 0;
            for (int i = 0; i < output.Length; i++)
            {
                if (bl >= al)
                {
                    if ((i%2 == 0 && bx<bl) || ax>=al)
                    {
                        output[i] = b[bx];
                        bx++;
                    }
                    else if ((i % 2 != 0 && ax<al) || bx>bl)
                    {
                        output[i] = a[ax];
                        ax++;
                    }
                }
                else
                {
                    if ((i % 2 == 0 && ax < al) || bx >= bl)
                    {
                        output[i] = a[ax];
                        ax++;
                    }
                    else if ((i % 2 != 0 && bx < bl) || ax > al)
                    {
                        output[i] = b[bx];
                        bx++;
                    }
                }
            }
            return output;
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            Array.Sort(strs);
            string common = "";
            int limit = Math.Min(strs[0].Length, strs[strs.Length-1].Length);
            for(int i= 0; i<limit; i++)
            {
                if (strs[0][i] != strs[strs.Length - 1][i])
                {
                    return common;
                }
                else
                {
                    common += strs[0][i];
                }
            }            
            return common;
        }     
    }
}
