using System;
using System.Collections.Generic;
using System.Text;

namespace GameAssignment.Abstract
{
    public interface IValidationService
    {
        void Validate(IEntity customer);
    }
}
