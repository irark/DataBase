﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    interface IStrategy
    {
        List<Films> Search(Films f, string path);
    }
}
