

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

            int start = 0;
            int end = n - 1;
            int middle = n/2;


            while (start < end) {

                if (arr[middle] == k) return arr[middle];
                else if (arr[middle] < k) end = middle - 1;
                else start = middle + 1;

                middle = (start + end) / 2;
            }

            return -1;
         }
        public static string longestCommonPrefix(string[] arr, int n)
        {
            int endCommonPrefix = 0;
            int tmpEndCommonPrefix = 0;

            for (int i = 1; i < n ; i++)
            {

                string a = arr[i];
                string b = arr[i -1];
                int shorterLength = 0;

                if (a.Length <= b.Length) shorterLength = a.Length;
                else shorterLength = b.Length;
                
                for (int c = 0; c < shorterLength; c++)
                {
                    if (a[c] == b[c]) {

                        if (i> 1 && c > endCommonPrefix) { 
                            break; 
                        }

                        tmpEndCommonPrefix = c; 
                    }
                    else
                    {
                        if (c == 0) return "-1";
                        break;
                    }
                }

                if (tmpEndCommonPrefix < endCommonPrefix && i > 1 ) {
                    endCommonPrefix = tmpEndCommonPrefix;
                }

                if (i == 1) {
                    endCommonPrefix = tmpEndCommonPrefix;
                }
            }

            return arr[0].Substring(0, endCommonPrefix + 1);
        }


        public static int firstElementKTime(int[] a, int n, int k)
        {
            Dictionary<int, int> keyValues = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int count;
                keyValues.TryGetValue(a[n], out count);

                if (count > 0)
                {
                    count = count++;

                    if (count == k) return a[n];

                    keyValues.Remove(a[n]);
                    keyValues.Add(a[n], count);
                }
                else {
                    keyValues.Add(a[n], 1);
                }
            }

            return -1;
        }
    }
}
