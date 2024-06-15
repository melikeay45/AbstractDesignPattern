using AbstractDesignPattern.Abstractions;
using AbstractDesignPattern.Enums;
using AbstractDesignPattern.Models;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignPattern.Factories.Generators
{
    public static class PhoneGenerator
    {
        public static IPhone Generate(PhoneType phoneType,int memory)
        {
            IFactory factory = phoneType switch
            {
                PhoneType.APhone => new APhoneFactory(),
                PhoneType.BPhone => new BPhoneFactory()
            };

            return factory.CreatePhone(memory);
        }
    }
}
