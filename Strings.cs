

using BenchmarkDotNet.Columns;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Diagnostics.Tracing.Parsers.Clr;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace data_structures
{
    public class Strings
    {

        public static void IsRotation(string a, string b) {

            if (a.Length == b.Length && !string.IsNullOrEmpty(a)) {
                string c = a + a;

                //Console.WriteLine(isSubstring(c,b));
            }
        }

        public static void CompressAZ(string str)
        {
            StringBuilder sb = new StringBuilder();

            int[] char_set = new int[128];
            for (int i = 0; i < str.Length; i++) {
                char_set[str[i]] += 1;
            }

            for (int i = 0; i < str.Length; i++) {
                int numberEncountered = char_set[str[i]];

                if (numberEncountered == 1)
                {
                    sb.Append(str[i]);
                }
                else if(numberEncountered > 1){
                    sb.Append(str[i]);
                    sb.Append(numberEncountered);
                    i += numberEncountered - 1;
                }
            }
            if (sb.Length > str.Length)
            {
                Console.WriteLine(str);
            }
            else {
                Console.WriteLine(sb.ToString());
            }
        }

        public static void IsAReplaceEditOrInsert(string first, string second) {

            if (first.Length == second.Length)
            {
                int countChanges = 0;
                for (int i = 0; i < first.Length; i++)
                {
                    if (first[i] != second[i]) countChanges++;
                }

                if (countChanges == 0) Console.WriteLine("False");
                if (countChanges == 1) Console.WriteLine("True");

                if (countChanges > 1) Console.WriteLine(false);
            }
            else if (first.Length + 1 == second.Length) IsInsertionOrDeletion(second, first);
            else if (first.Length - 1 == second.Length) IsInsertionOrDeletion(first, second);
            else Console.WriteLine("false");

            void IsInsertionOrDeletion(string larger,string smaller) {

                int foundDiference = 0;

                for (int i = 0; i < smaller.Length;i++) {
                    if (smaller[i] != larger[i])
                    {
                        if (foundDiference > 1) {
                            break;
                        }
                        foundDiference += 1;
                    }
                }

                Console.WriteLine(foundDiference <= 1);
            }
        }
        
        public static void URLReplaceSpaces(char[] str, int true_length) {

            int space_count = 0;

            for (int i = 0; i < true_length; i++) {
                if (str[i] == ' ') space_count++; 
            }

        

            int new_length = true_length + space_count * 2;

            char[] new_str = new char[new_length];

            int index = new_length - 1;

            for (int i = true_length -1; i >= 0; i--)
            {
                if (str[i] == ' ')
                {
                    new_str[index] = '0';
                    new_str[index - 1] = '2';
                    new_str[index - 2] = '%';
                    index -= 3;
                }   
                else {
                    new_str[index] = str[i];
                    index--;
                }
            }

            Console.WriteLine(new_str);
        }

        //public static char[] URLReplaceSpaces(string str) 
        //{
        //    int space_count = 0;
        //    int true_length = 0;

        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (str[i] == ' ') space_count++;
        //    }

        //    for (int i = str.Length - 1; i >= 0; i--)
        //    {
        //        if (str[i] != ' ') { true_length = i; break; };
        //        space_count--;
        //    }


        //    int new_length = true_length + space_count * 2;
        //    char[] newchar = new char[new_length];

        //    int offset = 0;

        //    for (int i = 0; i < true_length ; i++)
        //    {
        //        if (str[i] == ' ')
        //        {
        //            newchar[offset] = '%';
        //            newchar[offset + 1] = '2';
        //            newchar[offset + 2] = '3';

        //            offset += 3;
        //        }
        //        else 
        //        {
        //            newchar[offset] = str[i];
        //            offset++;
        //        }
        //    }

        //    return newchar;
        //}

        public static char[] URLReplaceSpaces(string str) {

            int space_count = 0;
            int new_length = 0;
            int truly_length = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ') space_count++;
            }

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == ' ')
                {
                    space_count--;
                }
                else 
                {
                    truly_length = i;
                    break;
                }
            }

            if (space_count == 0) return str.ToCharArray();

            new_length = truly_length + (space_count * 2) + 1;

            char[] new_str = new char[new_length];

            int index_new_str = 0;

            for (int i = 0; i <= truly_length; i++)
            {
                if (str[i] == ' ')
                {
                    new_str[index_new_str] = '0';
                    new_str[index_new_str + 1] = '%';
                    new_str[index_new_str + 2] = '2';

                    index_new_str += 3;
                }
                else
                {
                    new_str[index_new_str] = str[i];
                    index_new_str++;
                }
            }

            return new_str;

        }

        public static bool IsPermutation(string a, string b) 
        {
            if (a.Length != b.Length) return false;

            int[] char_set_a = new int[256];
            int[] char_set_b = new int[256];

            for (int i = 0; i < a.Length; i++)
            {
                char_set_a[a[i]]++;
                char_set_b[b[i]]++;
            }

            for (int i = 0; i < 256; i++)
            {
                if (char_set_b[i] != char_set_a[i]) return false;
            }

            return true;
        }

        public static bool IsAllUnic(string a)
        {
            bool[] char_Set = new bool[256];

            foreach (char c in a)
            {
                int char_code = (int)c;
                if (char_Set[char_code])
                {
                    return false;
                }
                else {
                    char_Set[c] = true;
                }
            }
            return true;
        }
    }
}