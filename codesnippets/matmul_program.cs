//expected output of Matmul
var matmul_expected = Deflib.Functions.Flatten(Deflib.Generate_data.matmul_mat(Deflib.dataMatrix.x, Deflib.dataMatrix.W0));
// generate data
var matmul_x_ready = new Deflib.TestIndexSim(control_x, (int)Deflib.Parameters.Batchsize,(int)Deflib.Parameters.input_size);
var prelu_W0_ready = new Deflib.TestIndexSim(control_W0, (int)Deflib.Parameters.input_size, (int)Deflib.Parameters.num_networks* (int)Deflib.Parameters.hidden_size);
// SME output of Matmul
var matmul = new MatmulStage(control_x, control_W0, array_x, array_W0);

// simulate and compare outputs
var outsimtra = new OutputSim(matmul.control_out, matmul.ram_out_1, matmul_expected);

