using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{ 
    /*Для социофобов друг-компьютер, эммм точнее опотент-компьютер*/
    class Computer : Fighter
    {
        Random r = new Random();
        /*Комп хитрый, он помнит куда ты его бил*/
        int[] hits = { 0, 0, 0 }; // 0 - head 1 - body 2 - legs
        int count = 0;

        public Computer(int hp = 100)
        {
            this.name = "Master Comp";
            this.hp = hp;
        }
        /* Просчет блока*/
        public PartOfBody GetBlock()
        {
            if (count < 4)
            {
                switch (Hit_or_miss(r))
                {
                    case 0: count++; return PartOfBody.Head;  
                    case 1: count++; return PartOfBody.Body; 
                    case 2: count++; return PartOfBody.Legs; 
                    default: count++; return PartOfBody.Head; 
                }
            }
            else
            {
                switch (Array.IndexOf(hits, hits.Max()))
                {
                    case 0: count++; return PartOfBody.Head; 
                    case 1: count++; return PartOfBody.Body; 
                    case 2: count++; return PartOfBody.Legs; 
                    default: count++; return PartOfBody.Head; 
                }
            }
        }
        public new void GetHit(PartOfBody point, int dm)
        {
            SetBlock(GetBlock());
            switch(point)
            {
                case PartOfBody.Head: hits[0] += 1; break;
                case PartOfBody.Body: hits[1] += 1; break;
                case PartOfBody.Legs: hits[2] += 1; break;
            }
            base.GetHit(point, dm);
        }
        /*Просчет удара*/
        public PartOfBody SetHit()
        {
            switch (Hit_or_miss(r))
            {
                case 0: count++; return PartOfBody.Head;
                case 1: count++; return PartOfBody.Body;
                case 2: count++; return PartOfBody.Legs;
                default: count++; return PartOfBody.Head;
            }
        }
        private new void SetBlock(PartOfBody block)
        {
            this.blocked = block;
        }
        /*Рандом. Пан или пропал. Зачем так сложно? Ну, я так вижу ;)*/
        private int Hit_or_miss(Random r)
        {
            int uns = 0;
            for (int i = 0; i < r.Next(10); i++)
                uns = r.Next(3);
           return uns;
        }
    }
}
