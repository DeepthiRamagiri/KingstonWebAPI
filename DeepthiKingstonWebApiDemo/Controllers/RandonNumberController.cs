using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DeepthiKingstonWebApiDemo.Controllers
{
    public class RandonNumberController : ApiController
    {

        public List<string> Get(int x, int y)
        {
            return RandomNumber(x, y);
        }

        public List<string> RandomNumber(int x, int y)
        {
            List<string> randomKeys = new List<string>();
            Random res = new Random();

            // String that contain both alphabets and numbers 
            String str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int size = x;

          
            int p = 1;
            while (p > 0)
            {
                String randomstring = "";
                for (int i = 1; i <= y; i++)
                {
                    
                    int q = res.Next(str.Length);
 
                    randomstring = randomstring + str[q];
                }

                //Console.WriteLine("Random alphanumeric String:" + randomstring);
                randomKeys.Add(randomstring);
                if (p == x)
                    break;
                p = p + 1;
            }
            return randomKeys;
        }
        }
}