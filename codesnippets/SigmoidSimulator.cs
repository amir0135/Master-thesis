using System;
using SME;

namespace SIGMOID
{

    /* Defining the bus*/
    public interface ValueTransfer : IBus{
        double value {get; set;}
    }
    
        /*defining sigsimulator*/
       public class SigSimulator : SimulationProcess{

        [OutputBus]
        private ValueTransfer m_output;


        public SigSimulator ( ValueTransfer output)
        {
            m_output = output ?? throw new ArgumentNullException(nameof(output));
        }

            public async override System.Threading.Tasks.Task Run()
        {
            await ClockAsync();
            for (int i = 0; i < 10; i++)
            {
                m_output.value = i;

                await ClockAsync();
            }
        }      
    }
}