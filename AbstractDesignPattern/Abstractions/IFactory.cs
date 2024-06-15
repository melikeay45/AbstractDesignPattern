﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignPattern.Abstractions
{
    public interface IFactory
    {
        IPhone CreatePhone(int memory);
    }
}