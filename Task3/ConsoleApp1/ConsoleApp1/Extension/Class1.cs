using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Extension
{
    static class Class1
    {
        public static void Met(this string word, string part)
        {
            bool res = false;


            #region 1-ci usul
            for (int i = 0; i < word.Length; i++)
            {
                for (int a = 0; a <= word.Length - i; a++)
                {
                    if (word.Substring(i, a) == part)
                    {
                        res = true;
                    }
                }
            }
            #endregion 1ci usulun sonu



            #region 2ci usul
            //string[] bos = new string[0];
            //int s = 1;

            //for (int i = 0; i < word.Length; i++)
            //{
            //    for (int a = 0; a < word.Length - i; a++)
            //    {
            //        Array.Resize(ref bos, s += i);
            //        bos[i] += word[a + i];

            //        if (bos[i] == part)
            //        {
            //            res = true;
            //        }
            //    }
            //}
            #endregion 2ci usulun sonu



            if (res)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
           
        }
    }
}

