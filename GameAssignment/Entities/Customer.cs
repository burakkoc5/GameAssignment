using GameAssignment.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameAssignment.Entities
{
    public class Customer : IEntity

    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime BirthOfDate { get; set; }

        public Customer(int ıd, string firstName, string lastName, string nationalityId, DateTime birthOfDate)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            NationalityId = nationalityId;
            BirthOfDate = birthOfDate;
        }
    }
}
