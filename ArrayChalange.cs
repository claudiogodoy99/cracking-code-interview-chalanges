
using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsTCPIP;
using System;
using System.Collections;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace data_structures
{
    public static class ArrayChalange
    {
        public static int[] leaders(int[] a, int n)
        {
            var leaders = new Stack<int>();

            leaders.Push(a[n -1]);

            int tmp = a[n-1];
            for (int i = n - 2; i >=0 ; i--)
            {
               
                if (tmp < a[i]) {

                    tmp = a[i];
                    leaders.Push(a[i]); 
                }
            }

            return leaders.ToArray();
        }
        public static int MissingNumber(int[] array, int n) {

            int total = 0 ;

            int shouldBe =0;

            int i = 0;

            for (i = 0; i < array.Length; i++)
            {

                total += array[i];
                shouldBe += i + 1 ;
            }

            shouldBe += i + 1;

            int diference = shouldBe - total;

            return diference;

        }
        public static void Sort012s(int[] array)
        {
            int l = 0;
            int mid = 0;
            int h = array.Length - 1;

            int tmp = 0;

            while (mid < h)
            {
                switch (array[mid])
                {

                    case 0:
                        {
                            tmp = array[l];
                            array[l] = array[mid];
                            array[mid] = tmp;

                            l++;
                            mid ++;
                            break;
                        }
                    case 1:
                        {
                            mid++;
                            break;
                        }
                    default:
                        {
                            tmp = array[h];
                            array[h] = array[mid];
                            array[mid] = tmp;

                            h--;
                            mid++;
                            break;
                        }
                }

            }
        }

        public static void Rotate(int[] array)
        {
            int tmp = 0;

            changeFirstPositions();

            for (int i = 1; i < array.Length - 1; i++)
            {
                changeSaveTemporaryAndChangeNext(i);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            #region
            void changeFirstPositions()
            {
                tmp = array[1];
                array[1] = array[0];
            }

            void changeSaveTemporaryAndChangeNext(int i)
            {

                array[0] = array[i + 1];

                array[i + 1] = tmp;

                tmp = array[0];
            }
            #endregion

        }
    }
}
