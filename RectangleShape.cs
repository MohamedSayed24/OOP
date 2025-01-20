using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPC_
{
    public class RectangleShape : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area 
        {   get;
            
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"The Area Of The Rectangle = {Area}");
        }
    }
}
