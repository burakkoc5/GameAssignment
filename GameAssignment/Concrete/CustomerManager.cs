using GameAssignment.Abstract;
using GameAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameAssignment.Concrete
{
    public class CustomerManager : IManagerService
    {
        List<IValidationService> _validationServices;

        public CustomerManager(List<IValidationService> validationServices)
        {
            _validationServices = validationServices;
        }

        public void Add(IEntity customer)
        {
            foreach (IValidationService service in _validationServices)
            {
                service.Validate(customer);

            }
            Console.WriteLine("{0} adlı kullanıcı sisteme eklendi", ((Customer)customer).FirstName);

            
        }

        public void Delete(IEntity customer)
        {
            Console.WriteLine("{0} adlı kullanıcı sistemden kaldırıldı", ((Customer)customer).FirstName);

        }

        public void Update(IEntity customer)
        {
            Console.WriteLine("{0} adlı kullanıcı sistem üzerinde güncellendi", ((Customer)customer).FirstName);

        }
    }
}
