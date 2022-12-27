

using Microsoft.Diagnostics.Tracing.Parsers.Clr;
using System.Collections;
using System.Security.Cryptography;

namespace data_structures
{
    public static class BinarySeach
    {

        public static bool check(long[] A, long[] B, int n)
        { 
            Dictionary<long, int> pairs= new Dictionary<long, int>();

            for (int i = 0; i < n; i++)
            {
                if (pairs.ContainsKey(A[i]))
                {
                 
                    pairs[A[i]]++;
                }
                else {
                    pairs.Add(A[i], 1);
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (pairs.ContainsKey(B[i])) 
                {
                    pairs[B[i]]--;

                    if (pairs[B[i]] < 0) return false;
                }
                else
                {
                    return false;
                }
            }

            foreach (int v in pairs.Values)
            {
                if(v != 0) return false;
            }

            return true;
        }

        public static int Search(int[] arr, int n, int k) {
           return Recursivity(arr, n, 0);

           int Recursivity(int[] array, int higher, int lower) {

                int mid = (lower + higher) / 2;

                if (array[mid] == k) return mid;

                else if (array[mid] > k)
                {
                    if(lower == n) return -1;

                    lower = mid + 1;
                    return Recursivity(array, higher, lower);
                }

                else 
                {
                    if (higher == 0) return -1;

                    higher = mid - 1;
                    return Recursivity(array, higher, lower);
                }

                
            }


        }
    }
}
