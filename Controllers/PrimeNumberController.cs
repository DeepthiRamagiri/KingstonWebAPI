using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DeepthiKingstonWebApiDemo.Controllers
{
    public class PrimeNumberController : ApiController
    {
        // GET api/values
        public List<int> Get(int x, int y)
        {
            return FindPrimeNumbers(x, y);
        }

        public List<int> FindPrimeNumbers(int startNo, int endNo)
        {
            List<int> saPrimeNum = new List<int>();
            int num, i, ctr = 0;

            for (num = endNo; num >= endNo; num++)
            {
                ctr = 0;
                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }
                endNo++;
                if (ctr == 0 && num != 1)
                    saPrimeNum.Add(num);
                int actualcount = saPrimeNum.Count();
                if (actualcount == startNo)
                    break;
            }
            return saPrimeNum;
        }


    }
}
