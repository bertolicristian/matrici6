namespace matrici6
{
    internal class Program
    {
        static void Funzione(float[,] M)
        {
            int C = 10, C2 = 10;
           

            for (int i = 0; i < M.GetLength(0); i++)
            {
                C = 10;
                Console.WriteLine();
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    M[i, j] = C * C2;
                    C--;
                    Console.Write($"[{M[i, j]}]" + " ");
                }
                C2--;
            }
        }

        static int Intervallo(float[,] M , int x, int y)
        {
            int cont = 0;

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0;j < M.GetLength(1); j++)
                {
                    if (M[i,j] >= x &&  M[i,j] <= y)
                    {
                        cont++;
                    }
                }
            }
            return cont;
        }

        static float[] MediaRighe (float[,] M)
        {
            float[] V1 = new float[M.GetLength(0)];

            for (int i = 0;i < M.GetLength(0);i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    V1[i] += M[i, j];
                }
                V1[i] = V1[i] / M.GetLength(1);
            }
            
            for (int i = 0; i < V1.Length; i++)
            {
                Console.Write($"[{V1[i]}]" + " ");
            }
            return V1;
        }

        static void SommaColonne(float[,] M , int[] V2)
        {
            for (int i = 0; i < M.GetLength (0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {

                }
            }
        }
       


        static void Main(string[] args)
        {
            float[,] M = new float[10, 10];
            float[] V1 = new float[M.GetLength(1)];
            int[] V2 = new int[M.GetLength(1)];
            Funzione(M);
            int Int = 0;

            Console.WriteLine("\n\nprimo numero dell' intervallo");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("dimmi il secondo numero dell' intervallo");
            int y = Convert.ToInt32(Console.ReadLine());

            Int = Intervallo(M, x, y);

            Console.WriteLine(Int);

            Console.WriteLine();
            Console.WriteLine();

            MediaRighe(M);

            
        }
    }
}
