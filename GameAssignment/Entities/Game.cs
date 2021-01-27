using GameAssignment.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameAssignment.Entities
{
    public class Game : IEntity
    {
        public int DefaultPrice { get; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int UnitPrice { get; set; }
        public string Publisher { get; set; }

        public Game(int ıd, string name, int unitPrice, string publisher)
        {
            Id = ıd;
            Name = name;
            UnitPrice = unitPrice;
            Publisher = publisher;
            DefaultPrice = unitPrice;
        }
    }
}
