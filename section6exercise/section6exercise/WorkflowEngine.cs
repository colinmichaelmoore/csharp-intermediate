using System;
using System.Collections;
using System.Collections.Generic;

namespace section6exercise
{
    public class WorkflowEngine : IWorkflow
    {
        private readonly IList<IWorkflow> _workflow;

        public WorkflowEngine()
        {
            _workflow = new List<IWorkflow>();
        }

        public void Run(Task task)
        {
            foreach (var n in _workflow)
            {
                
                n.Run(new Task());
            }
            
        }

        public void GetTask(IWorkflow task)
        {
            _workflow.Add(task);
        }
    }
}