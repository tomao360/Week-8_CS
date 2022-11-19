using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8
{
    internal class PenBooster
    {
        private Pen[] PenArr;
        public PenBooster(Pen[] PenArr)
        {
            
           
                this.PenArr = PenArr;
          
        }

        public void PrintBlue()
        {
            for (int i = 0; i < PenArr.Length; i++)
            {
                if (PenArr[i].color == "Blue")
                {
                    PenArr[i].PrintPen();
                }
            }
        }

        public void PrintRed()
        {
            for (int i = 0; i < PenArr.Length; i++)
            {
                if (PenArr[i].color == "Red")
                {
                    PenArr[i].PrintPen();
                }
            }
        }

        public void PrintBlack()
        {
            for (int i = 0; i < PenArr.Length; i++)
            {
                if (PenArr[i].color == "Black")
                {
                    PenArr[i].PrintPen();
                }
            }
        }
    }

}
