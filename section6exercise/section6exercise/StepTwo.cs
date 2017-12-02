using System;

namespace section6exercise
{
    public class StepTwo : IWorkflow
    {
        public void Run(Task task)
        {
            Console.WriteLine("Step two..");
        }
    }
}