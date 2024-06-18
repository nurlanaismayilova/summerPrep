/*//Task 1
using System.Runtime.Intrinsics.X86;

namespace hw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Alex", "Alice", "Bam", "Nurlana" };

            Console.WriteLine(countA(names));
        }
        static int countA(List<string> names)
        {
            int cnt = 0;
            foreach (string name in names)
            {
                if (name.StartsWith('A'))
                {
                    cnt++;
                }
            }
            return cnt;
        }
    }
}
*/