using GameAssignment.Abstract;
using GameAssignment.Concrete;
using GameAssignment.Entities;
using System;
using System.Collections.Generic;

namespace GameAssignment
{
    class Program
    {
        static void Main(string[] args)

        {
            List<IValidationService> validationServices = new List<IValidationService>();
            IValidationService mernisValidation = new MernisValidationManager();
            validationServices.Add(mernisValidation);

            IManagerService customerManager = new CustomerManager(validationServices);
            IManagerService gameManager = new GameManager();

            //Kullanıcılar
            IEntity burak = new Customer(1,"Burak","Koç","11111111111",new DateTime(2002, 10, 27));
            IEntity berk = new Customer(2, "Berk", "Koç", "22222222222", new DateTime(2002, 10, 27));
            IEntity engin = new Customer(3, "Engin", "Demirog", "33333333333", new DateTime(1985, 1, 6));

            customerManager.Add(burak);
            customerManager.Add(engin);
            customerManager.Add(berk);

            //Oyunlar
            IEntity cyberpunk = new Game(00,"Cyberpunk 2077", 250,"CD Projeckt Red");
            IEntity gta5 = new Game(01, "Grand Theft Auto 5",150,"Rockstar Games");
            IEntity csgo = new Game(02,"Counter Strike: Global Offensive",79,"Valve");

            gameManager.Add(cyberpunk);
            gameManager.Add(gta5);
            gameManager.Add(csgo);

            //Steam Platformu
            IPlatformService steam = new SteamPlatformManager();
            steam.Buy(burak,gta5);

            //İndirimler
            IDiscountService studentDiscount = new StudentDiscountManager();
            IDiscountService monthlyFree = new MonthlyFreeGameManager();

            //Oyunlara indirim yapıldı
            studentDiscount.Discount(new List<IEntity> {gta5 });
            monthlyFree.Discount(new List<IEntity> { csgo });

            steam.Buy(engin, gta5);
            steam.Buy(berk,csgo);

            //İndirimler iptal edildi
            studentDiscount.CancelTheDiscount(new List<IEntity> { gta5 });
            monthlyFree.CancelTheDiscount(new List<IEntity> { csgo });


            customerManager.Delete(berk);





        }
    }
}
