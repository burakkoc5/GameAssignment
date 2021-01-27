using System;
using System.Collections.Generic;
using System.Text;

namespace GameAssignment.Abstract
{
    public interface IManagerService
    {
        void Add(IEntity entity);
        void Update(IEntity entity);
        void Delete(IEntity entity);
    }
}
