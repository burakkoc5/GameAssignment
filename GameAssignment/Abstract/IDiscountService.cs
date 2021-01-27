using System;
using System.Collections.Generic;
using System.Text;

namespace GameAssignment.Abstract
{
    public interface IDiscountService
    {
        public int DiscountRate { get; set; }
        void Discount(List<IEntity> games);
        void CancelTheDiscount(List<IEntity> games);
    }
}

