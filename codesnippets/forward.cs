        protected override void OnTick()
        {
            if (new_input.Ready && new_input.Addr == old_input.Addr)
            {
                v_output.Data = v_inputNew.value;
            }
            else if (old_input.Ready)
            {
                v_output.Data = v_inputOld.Data;
            }
            else
            {
                v_output.Data = 0;
            }
        }