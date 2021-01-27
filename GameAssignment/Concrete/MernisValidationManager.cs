using GameAssignment.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameAssignment.Concrete
{
    public class MernisValidationManager : IValidationService
    {
        public void Validate(IEntity customer)
        {
            Console.WriteLine("Mernis doğrulaması yapıldı");
        }
    }
}
