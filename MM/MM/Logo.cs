using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM
{
    class Logo
    {
        private int n;
        private char[,] arr;

        public Logo(int n)
        {
            int k = 10 * n;
             arr = new char[n + 1, k];
            this.n = n;
            for (int i = 0; i < n+ 1; i++)
            {

                for (int j = 0; j < n * 10; j++)
                {

                    arr[i, j] = '-';
                }
            }
        }


        public void produceLogo()
        {
            for (int i = 0; i < n + 1; i++)
            {

                ////////////   FIRST M    /////////////////

                int j = 0;

                for (j = 0; j < n * 2; j++)
                {
                    for (int t = 0; t < n; t++)
                    {
                        if (j + i == n + t)
                        {
                            arr[i, j] = '*';
                        }

                    }
                }
                for (j = n; j < n * 3; j++)
                {
                    for (int t = 0; t < n; t++)
                    {
                        if (j - i == n + t)
                        {
                            arr[i, j] = '*';
                        }
                    }
                }
                for (j = n * 2; j < n * 4; j++)
                {
                    for (int t = 0; t < n; t++)
                    {
                        if (j + i == 3 * n + t)
                        {
                            arr[i, j] = '*';
                        }
                    }

                }
                for (j = n * 3; j < n * 5; j++)
                {
                    for (int t = 0; t < n; t++)
                    {
                        if (j - i == 3 * n + t)
                        {
                            arr[i, j] = '*';
                        }
                    }

                }

                ////////////   SECOND M    /////////////////

                for (j = n * 5; j < n * 7; j++)
                {
                    for (int t = 0; t < n; t++)
                    {
                        if (j + i == 6 * n + t)
                        {
                            arr[i, j] = '*';
                        }

                    }
                }

                for (j = n * 6; j < n * 8; j++)
                {
                    for (int t = 0; t < n; t++)
                    {
                        if (j - i == 6 * n + t)
                        {
                            arr[i, j] = '*';
                        }

                    }
                }

                for (j = n * 7; j < n * 9; j++)
                {
                    for (int t = 0; t < n; t++)
                    {
                        if (j + i == 8 * n + t)
                        {
                            arr[i, j] = '*';
                        }

                    }
                }

                for (j = n * 8; j < n * 10; j++)
                {
                    for (int t = 0; t < n; t++)
                    {
                        if (j - i == 8 * n + t)
                        {
                            arr[i, j] = '*';
                        }

                    }
                }

            }
        }
        public void printLogo()
        {
            for (int i = 0; i < n + 1; i++)
            {
                Console.Write('\n');

                for (int j = 0; j < n * 10; j++)
                {

                    Console.Write(arr[i, j]);

                }
            }


            Console.Read();
        }
    }
}
