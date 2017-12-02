using System;

namespace section6exercise
{
    public class StepThree : IWorkflow
    {
        public void Run(Task task)
        {
            Console.WriteLine("Step three...");
        }
    }
}