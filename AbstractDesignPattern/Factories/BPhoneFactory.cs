using AbstractDesignPattern.Abstractions;
using AbstractDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignPattern.Factories
{
    public class BPhoneFactory:IFactory
    {
        public IPhone CreatePhone(int memory)
        {
            return new BPhone(memory);
        }
    }
}
