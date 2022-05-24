        public class ToRam : SimpleProcess{
        [InputBus]
        private ValueTransfer v_input;

        [InputBus]
        private IndexValue Address;
        
        [OutputBus]
        private SME.Components.SimpleDualPortMemory<double>.IWriteControl output;

        public ToRam(ValueTransfer v_input,  IndexValue Address, SME.Components.SimpleDualPortMemory<double>.IWriteControl output){
            this.v_input = v_input;
            this.Address = Address;
            this.output = output;
        }
        protected override void OnTick(){

            
            output.Enabled = Address.Ready;

            if (Address.Ready){
                output.Address = Address.Addr;
                output.Data = v_input.value; 
            }
        }


    }