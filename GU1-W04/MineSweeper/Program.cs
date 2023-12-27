internal class Program
{
    private static void Main(string[] args)
    {
        
            string[,] array = {
            {"*", ".", ".", "."},
            {".", ".", ".", "."},
            {".", "*", ".", "."},
            {".", ".", ".", "."}
                             };
            int row = array.GetLength(0);
            int colum = array.GetLength(1);

            string[,] mapReport = new string[row, colum];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colum; j++)
                {
                    if (array[i, j].Equals("*"))
                    {
                        mapReport[i, j] = "*";
                    }
                    else
                    {
                        int[,] NEIGHBOURS_ORDINATE = {
                        {i - 1, j - 1}, {i - 1, j}, {i - 1, j + 1},
                        {i, j - 1}, {i, j + 1},
                        {i + 1, j - 1}, {i + 1, j}, {i + 1, j + 1},};

                        int minesAround = 0;
                        int length = NEIGHBOURS_ORDINATE.GetLength(0);
                        for (int q = 0; q < length; q++)
                        {
                            int xOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[q, 1];
                            int yOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[q, 0];

                            bool isOutOfMapNeighbour = xOrdinateOfNeighbour < 0
                                    || xOrdinateOfNeighbour == colum
                                    || yOrdinateOfNeighbour < 0
                                    || yOrdinateOfNeighbour == row;
                            if (isOutOfMapNeighbour)
                            {
                                continue;
                            }

                            bool isMineOwnerNeighbour = array[yOrdinateOfNeighbour, xOrdinateOfNeighbour].Equals("*");
                            if (isMineOwnerNeighbour)
                            {
                                minesAround++;
                            }
                        }
                        
                        mapReport[i, j] = minesAround.ToString();
                    }
                }
            }
             //ket thuc lenh nay thu duoc mang Mapreport
             //hien thi mang Mapreport ra man hinh
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < colum; j++)
                {
                    Console.Write(mapReport[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
