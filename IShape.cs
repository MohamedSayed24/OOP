﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPC_
{
    public interface IShape
    {
        double Area { get; set; }
        void DisplayShapeInfo();
    }
}
