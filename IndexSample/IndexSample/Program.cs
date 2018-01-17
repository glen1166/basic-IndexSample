using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            A a = new A(10);

            for (int i = 0; i < 5; i++)
            {
                a[i] = i;
            }

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }

    public class A
    {
        private int[] _v;

        public A(int n)
        {
            _v = new int[n];
        }

        public int this[int i]
        {
            get
            {
                return _v[i];
            }

            set
            {
                _v[i] = value;
            }
        }
    }
}
