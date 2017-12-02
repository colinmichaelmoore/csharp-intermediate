using System;

namespace section6exercise
{
    public class StepFour : IWorkflow
    {
        public void Run(Task task)
        {
            Console.WriteLine("Step four....");
        }
    }
}