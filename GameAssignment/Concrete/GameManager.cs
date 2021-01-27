using GameAssignment.Abstract;
using GameAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameAssignment.Concrete
{
    public class GameManager : IManagerService
    {
        public void Add(IEntity game)
        {
            Console.WriteLine("{0} adlı oyun sisteme eklendi", ((Game)game).Name);
        }

        public void Delete(IEntity game)
        {
            Console.WriteLine("{0} adlı oyun sistemden silindi", ((Game)game).Name);
        }

        public void Update(IEntity game)
        {
            Console.WriteLine("{0} adlı oyun güncellendi", ((Game)game).Name);
        }
    }
}
