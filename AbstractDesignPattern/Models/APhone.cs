using AbstractDesignPattern.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignPattern.Models
{
    public class APhone : IPhone
    {
        public int Memory;

        public APhone(int memory)
        {
            this.Memory = memory;
        }

        public string Call(string ringTone)
        {
            return $"APhone telefonunda {ringTone} çalıyor";
        }
    }
}
