using GameAssignment.Abstract;
using GameAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameAssignment.Concrete
{
    class MonthlyFreeGameManager : IDiscountService
    {
        int rate = 100;
        public int DiscountRate { get { return rate; } set { rate = value; } }



        public void Discount(List<IEntity> games)
        {
            foreach (IEntity game in games)
            {
                int tempPrice = ((Game)game).UnitPrice;
                ((Game)game).UnitPrice -= (int)(((Game)game).UnitPrice * rate / 100);
                Console.WriteLine("{0} adlı oyunun fiyatı {1}'den {2}'ye düşürüldü ", ((Game)game).Name, tempPrice, ((Game)game).UnitPrice);
            }
        }
        
        public void CancelTheDiscount(List<IEntity> games)
        {
            foreach (IEntity game in games)
            {

                ((Game)game).UnitPrice = ((Game)game).DefaultPrice;
                Console.WriteLine("{0} adlı oyuna uygulanan indirim iptal edildi fiyat tekrar {1} olarak ayarlandı", ((Game)game).Name, ((Game)game).UnitPrice);


            }
        }
    }
}
