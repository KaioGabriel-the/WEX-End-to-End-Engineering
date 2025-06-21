namespace MyAppp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = new int[3];

            for (int i = 0; i < arrayInt.Length; i++)
            {
                arrayInt[i] = i;
                Console.WriteLine(arrayInt[i]);
            }
            foreach (var item in arrayInt)
            {
                Console.WriteLine("For Each");
                Console.WriteLine(item);
            }

            int[] arrayInt2 = new int[4];

            Array.Copy(arrayInt, arrayInt2, arrayInt.Length);
            Array.Resize(ref arrayInt, 8);
            Console.WriteLine(arrayInt.Length);

            List<int> ints = new List<int>();
            ints.Add(1);
        }
    }
}