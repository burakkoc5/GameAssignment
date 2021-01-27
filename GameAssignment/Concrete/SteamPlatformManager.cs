using GameAssignment.Abstract;
using GameAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameAssignment.Concrete
{
    class SteamPlatformManager : IPlatformService
    {
        public void Buy(IEntity customer, IEntity game)
        {
            Console.WriteLine("{0} adlı kullanıcı {1}' adlı oyunu {2} TL karşılığında steam üzerinden satın aldı", ((Customer)customer).FirstName, ((Game)game).Name, ((Game)game).UnitPrice);
        }
        
        public void Refund(IEntity customer, IEntity game)
        {
            Console.WriteLine("{0} adlı kullanıcı {1}' adlı oyunu steam üzerinden iade etti", ((Customer)customer).FirstName, ((Game)game).Name);
        }
    }
}
