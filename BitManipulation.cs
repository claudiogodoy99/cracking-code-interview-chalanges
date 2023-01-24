
namespace data_structures
{
    public static   class BitManipulation
    {
        public static void TransformOddPair(int[] array) 
        {
            ///0(N)
            for (int i = 0; i < array.Length; i++)
            {
                /// Bit AND operation to se if a Number is pair or odd 
                int pairOrOdd = array[i]& 1;
                array[i] = pairOrOdd;
            }

        }
    
    }
}
