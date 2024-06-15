using AbstractDesignPattern.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignPattern.Models
{
    public class BPhone:IPhone
    {
        public int memory;

        public BPhone(int memory)
        {
            this.memory = memory;
        }

        public string Call(string ringTone)
        {
            return $"BPhone telefonunda {ringTone} çalıyor.";
        }
    }
}
