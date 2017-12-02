using System;
using System.CodeDom;
using System.Collections;

namespace section4_exercise
{
    public class Stack
    {
        public ArrayList stack = new ArrayList();

        public void Push(object obj)
        {
            if (obj != null)
            {
                stack.Add(obj);
            }
            else
            {
                throw  new Exception("Null is not a valid argument for the Push method");
            }
        }

        public object Pop()
        {

            

            if (stack.Count < 1)
            {
                throw new Exception("Stack empty");
                
            }
            else
            {
                object obj = stack[stack.Count - 1];
                stack.RemoveAt(stack.Count - 1);
                return obj;
            }

            
            

        }

        public void Clear()
        {
            for (var i = 0; i < stack.Count; i++)
            {
                stack.RemoveAt(i);
            }
        }
        
    }
}