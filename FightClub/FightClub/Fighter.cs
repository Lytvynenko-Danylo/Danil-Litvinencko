using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    public enum PartOfBody { Head, Body, Legs }
    /* Аватар пользователя(почуствуй себя на Пандоре)*/
    class Fighter
    {

        protected string name;
        protected PartOfBody blocked;
        protected int hp;
        public string Name
        { get { return name; } }
        public int HP
        { get { return hp; } }
        /*События - хитрая штука, что вызовет методы из класса, где создали этот грешный экземляр.
         *То есть заходим в этот экземпляр доходим до события, а он берет вызывает метод откуда то из вне
         * даже от куда мы пришли. В даном слцчае для введенич лога (Приметка чисто для себя)*/
        public delegate void MyMethod(string name, int hp);
        public event MyMethod Death;
        public event MyMethod Wound;
        public event MyMethod Block;

        public Fighter(string name = "Gamer", int hp = 100)
        {
            this.name = name;
            this.hp = hp;
        }
        /*Аватар получает оплеуху, аватар оценивет получил он урон или взошла сегодня его счастливая звезда
         * Если заблокировал, то логично вылетает событие Block, и так далее, то безвременой кончины */
        public void GetHit(PartOfBody point, int dm)
        {
            if( point == blocked)
            {
                Block(name, hp);
            }
            else
            {
                hp -= dm;
                   
                if(hp<=0) { Death(name, hp); }
                else { Wound(name, hp); }
            }
        }
        /* Устанавливает блок из вне, то есть блок ставит пользователь и его запоминает аватар*/
        public void SetBlock(PartOfBody block)
        {
            this.blocked = block;
        }
    }
}
