using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section6exercise
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var workflow = new WorkflowEngine();
            workflow.GetTask(new StepOne());
            workflow.GetTask(new StepTwo());
            workflow.GetTask(new StepThree());
            workflow.GetTask(new StepFour());

            workflow.Run(new Task());
        }
    }
}
