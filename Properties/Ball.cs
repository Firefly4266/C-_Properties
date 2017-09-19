using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Ball
    {
        private int size;
        private int color;
        private int timesThrown = 0;

        public Ball() { }

        public Ball(int size, int color)
        {
            this.size = size;
            this.color = color;
        }
        public int GetSize()
        {
            return size; 
        }
        public void SetSize(int value)
        {
            this.size = value;
        }
        public void Pop()
        {
            this.size = 0;
            timesThrown = -10;
        }
        public void Throw()
        {
            if(timesThrown != -10)
            {
                timesThrown++;                
            }
            else
                Console.WriteLine("\n Sorry, the ball has been poped!\n");
        }
        public void TimesThrown()
        {
            Console.WriteLine($"\n The ball has been thrown {timesThrown} times.\n");
        }
    }
}
