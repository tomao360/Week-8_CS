using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDll
{
    public class myDll
    {
        Random random = new Random(DateTime.Now.Millisecond);
        public int RandomNum()
        {
            int randomNum = random.Next();
            return randomNum;
        }

        public string getSentence()
        {
            string str = "How you doing?";
            return str;
        }
    }
}
