using AbstractDesignPattern.Abstractions;
using AbstractDesignPattern.Models;

namespace AbstractDesignPattern.Factories
{
    public class APhoneFactory : IFactory
    {
        public IPhone CreatePhone(int memory)
        {
            return new APhone(memory);
        }
    }
}
