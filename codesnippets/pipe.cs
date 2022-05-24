    [ClockedProcess]
    public class Pipe : SimpleProcess{
        
        [InputBus]
        private IndexValue v_input;

        [OutputBus]
        private IndexValue v_output;

          
        
        public Pipe (IndexValue v_input, IndexValue v_output){
            this.v_input = v_input;
            this.v_output =v_output;
        }

        protected override void OnTick()
        {
           v_output.Ready = v_input.Ready;
           if (v_input.Ready){
                v_output.Addr = v_input.Addr;    
           }
           
        }
                
    }