using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SellingManager : IGameSellingService
    {
        public void Sell()
        {
            Console.WriteLine("Satış Başarılı");
        }
    }
}
