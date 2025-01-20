using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPC_
{
    public class Circle : ICircle
    {
        double radius;
        public double Area 
        {
            get { return Area; } 

            set { Area = Math.PI * radius * radius; } 
        
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"The Area of Circle = {Area}");
        }
    }
}
