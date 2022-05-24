    [ClockedProcess]
    public class MatMul : SimpleProcess
    {
        [InputBus]
        private SME.Components.SimpleDualPortMemory<double>.IReadResult m_inputA;

        [InputBus]
        private SME.Components.SimpleDualPortMemory<double>.IReadResult m_inputB;
        
        [InputBus]
        private SME.Components.SimpleDualPortMemory<double>.IReadResult m_inputC;

        [InputBus]
        private IndexValue input_pipe;

        [OutputBus]
        private ValueTransfer v_output;
        
        public MatMul(IndexValue inputpipe, SME.Components.SimpleDualPortMemory<double>.IReadResult inputA, SME.Components.SimpleDualPortMemory<double>.IReadResult inputB, SME.Components.SimpleDualPortMemory<double>.IReadResult inputC,   ValueTransfer output)
        {
            input_pipe = inputpipe ?? throw new ArgumentNullException(nameof(inputpipe));
            m_inputA = inputA ?? throw new ArgumentNullException(nameof(inputA));
            m_inputB = inputB ?? throw new ArgumentNullException(nameof(inputB));
            m_inputC = inputC ?? throw new ArgumentNullException(nameof(inputC));
            v_output = output ?? throw new ArgumentNullException(nameof(output));
        }

        protected override void OnTick(){
        
            if (input_pipe.Ready == true){

                v_output.value = m_inputC.Data + (m_inputA.Data * m_inputB.Data);
            }
            else{
                v_output.value = 0;
            }
        }
    }