        public LoadStage(int size, string CSVfile, int row, int col)
        {
            var load_control = Scope.CreateBus<IndexControl>();
            var load_index = Scope.CreateBus<IndexValue>();
            control = Scope.CreateBus<IndexControl>();

            output = new SimpleDualPortMemory<double>(size);

            var generate_load = new Dataload(size, CSVfile, load_index, output.WriteControl);
            var load_sim = new TestIndexSim(load_control, row, col);
            var load_ind = new Index(load_control, load_index, control);

            expected = generate_load.input;
        }