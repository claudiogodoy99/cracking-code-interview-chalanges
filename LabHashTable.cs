
using BenchmarkDotNet.Attributes;
using System.Collections;

namespace data_structures
{

    [MemoryDiagnoser(true)]
    public class LabHashTable
    {
        [Benchmark]
        public void ExempleWithHash() 
        {
            Hashtable hashtable = new Hashtable();

            var random = new Random();

            for (int i = 0; i <= 100000; i++) {

                var next = random.Next(0, int.MaxValue);
                var hash = next.GetHashCode();
                if (!hashtable.Contains(hash)) hashtable.Add(next.GetHashCode(), next);
            }

            int mats = 0;


            for (int i = 0; i <= 50; i++)
            {
                var next = random.Next(0, int.MaxValue);

                 if(hashtable.Contains(next.GetHashCode()))mats++;
            }

            Console.WriteLine(mats);
        }

        [Benchmark]
        public void ExempleWithOutHash()
        {
            List<int> hashtable = new List<int>();

            var random = new Random();

            for (int i = 0; i <= 100000; i++)
            {

                var next = random.Next(0, int.MaxValue);
                if(!hashtable.Contains(next)) hashtable.Add(next);
            }

            int mats = 0;


            for (int i = 0; i <= 50; i++)
            {
                var next = random.Next(0, int.MaxValue);

                if (hashtable.Contains(next)) mats++;
            }

            Console.WriteLine(mats);
        }
    }
}
