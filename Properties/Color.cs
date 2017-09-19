using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha = 255;
        public Color(int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }
        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            
        }
        public int GetRed()
        {
            return red;
        }
        public void SetRed(int value)
        {
            this.red = value;
        }

        public int GetGreen()
        {
            return green;
        }
        public void SetGreen(int value)
        {
            this.green = value;
        }

        public int GetBlue()
        {
            return blue;
        }
        public void SetBlue(int value)
        {
            this.blue = value;
        }
        public int GetAlpha()
        {
            return alpha;
        }
        public void SetAlpha(int value)
        {
            this.alpha = value;
        }
        public int GrayScale ()
        {
            int grayScale =  (red +  green +  blue) / 3;
            return grayScale;
        }
    }
}
