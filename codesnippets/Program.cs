using System;
using SME;

namespace SIGMOID
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            using (var sim = new Simulation())
            {

                var simulationdata = Scope.CreateBus<ValueTransfer>();
                var sigmoidresulst = Scope.CreateBus<ValueTransfer>();

                var simulator = new SigSimulator(simulationdata);
                var sigmoid = new Sigmoid(simulationdata,sigmoidresulst);
                    
                    
                sim
                .Run();
            }        
           
        }
    }
}
