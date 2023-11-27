using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DeepthiKingstonWebApiDemo.Controllers
{
    public class FibonacchiController : ApiController
    {
        public List<int> Get(int x, int y)
        {
            return FindFibonacchiNumbers(x, y);
        }
        public List<int> FindFibonacchiNumbers(int x, int y)
        {
            int n1 = 0, n2 = 1, n3;
            n3 = n1 + n2;
            List<int> Fib = new List<int>();

            while (n3 > 0)
            {

                n1 = n2;
                n2 = n3;
                n3 = n1 + n2;
                if (n3 > y)
                    Fib.Add(n3);
                if (x == Fib.Count())
                    break;

            }
            return Fib;
        }

    }
}