using System;
using System.Collections.Generic;
using System.Text;

namespace GameAssignment.Abstract
{
    public interface IPlatformService
    {
        void Buy(IEntity customer, IEntity game);
        void Refund(IEntity customer, IEntity game);
    }
}
