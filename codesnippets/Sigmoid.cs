using System;
using SME;

namespace SIGMOID
{
    
    public class Sigmoid: SimpleProcess {
        [InputBus]
        private ValueTransfer m_input;
        [OutputBus]
        private ValueTransfer m_output;

        public Sigmoid(ValueTransfer input, ValueTransfer output)
        {
            m_input = input ?? throw new ArgumentNullException(nameof(input));
            m_output = output ?? throw new ArgumentNullException(nameof(output));
        }

        protected override void OnTick()
        {
            var tmp = 1 /(1 + Math.Exp(m_input.value));
            Console.WriteLine(tmp);
            m_output.value = tmp;
        }       
    }    
}