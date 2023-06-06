namespace GitHub_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GitHub test！");
            int[] s = { 10, 26, 45, 30, 47, 21, 1, 6, 45 };
            s = BubbleSort(s);
            foreach (var item in s)
            {
                Console.Write(item+"    ");
            }
        }

        public static int[] BubbleSort(int[] s)
        {
            for (int i = 0; i < s.Count() - 1; i++)
            {
                for (int j = 0; j < s.Count() - 1 - i; j++)
                {
                    if (s[j] > s[j + 1])
                    {
                        int tem = s[j];
                        s[j] = s[j + 1];
                        s[j + 1] = tem;
                    }
                }
            }
            return s;
        }
    }
}