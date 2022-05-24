        protected override void OnTick()
        {
            output.Enabled = index.Ready;

            if (index.Ready)
            {
                output.Address = index.Addr;
            }
        }
    }