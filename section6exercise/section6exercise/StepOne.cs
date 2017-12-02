using System;

namespace section6exercise
{
    public class StepOne : IWorkflow
    {
        public void Run(Task task)
        {
            Console.WriteLine("Step one.");
        }
    }
}