public static double[,] matmul_mat(double[,] x, double[,,] W0)
{
    var hh = Functions.matmul(x,
        Functions.transpose(
            Functions.reshape(W0,
                (int)Parameters.num_networks * (int)Parameters.hidden_size,
                (int)Parameters.input_size
            )
        )
    );

    return hh;
}