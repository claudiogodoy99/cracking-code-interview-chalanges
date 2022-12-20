
using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsTCPIP;
using System;
using System.Security.Cryptography.X509Certificates;

namespace data_structures
{
    public static class ArrayChalange
    {
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
            void changeFirstPositions() {
                tmp = array[1];
                array[1] = array[0];
            }

            void changeSaveTemporaryAndChangeNext(int i){

                array[0] = array[i + 1];

                array[i + 1] = tmp;

                tmp = array[0];
            }
            #endregion

        }
    }
}
