using System;

namespace section3_17
{
    public class PresentationObject
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public void Copy()
        {
            Console.WriteLine("Copied to the clipboard");
        }

        public void Duplicate()
        {
            Console.WriteLine("Obj");
        }
    }
}