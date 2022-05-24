public static double[,] matmul(double[,] X, double[,] Y)
{
    int x_row = X.GetLength(0); // find dimensions
    int x_col = X.GetLength(1);
    int y_row = Y.GetLength(0);
    int y_col = Y.GetLength(1);
    double[,] result = new double[x_row, y_col];

    for (int i = 0; i < x_row; i++) // loops over row and col
    {
        for (int j = 0; j < y_col ; j++)
        {
            for (int k = 0; k < x_col; k++)
            {
                result[i,j] += X[i,k] * Y[k,j];
            }
        }
    }

    return result;
}