        public TestIndexSim(IndexControl control, int Row, int Col, int Dim)
        {
            this.control = control;
            this.Row = Row;
            this.Col = Col;
            this.Dim = Dim;
        }


        public override async Task Run()
        {
            control.OffsetA = 0;
            control.OffsetB = 0;
            control.OffsetC = 0;

            await ClockAsync();

            control.Ready = true;

            control.Height = Row;
            control.Width = Col;
            control.Dim = Dim ;

            await ClockAsync();

            control.Ready = false;





        }
    }
