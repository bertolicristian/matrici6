namespace matrici6
{
    internal class Program
    {
        static void Funzione(int[,] M)
        {
            int C = 90;
            int C1 = 10;

            for (int i = 1; i < M.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    M[i, j] = C + C1;
                    Console.Write($"[{M[i,j]}]");
                    C--;
                }
            }
        }
        static void Main(string[] args)
        {
            int[,] M = new int[11, 10];
            Funzione(M);
        }
    }
}
