using System;

namespace HalloweenGame
{
    class Weapon
    {
        protected int damage, dotDamage = 30, dotCount = 4, procRoll;
        protected bool isDoT = false;
        protected Random proc = new Random();

        /**
        * Constructor for weapon without DoT damage
        */
        public Weapon()
        {

        }

        public void setDamage(int val)
        {
            damage = val;
        }
        public virtual void setDoTDamage(int val)
        {
            dotDamage = val;
        }
        public virtual void setDoTCount(int val)
        {
            dotCount = val;
        }
        public int getDamage()
        {
            return damage;
        }
        public int getDoTDamage()
        {
            return dotDamage;
        }

        /*Method set up to roll for a weapon to proc, mainly used in Nasty Claw
        */
        public bool rollDoT()
        {
            procRoll = proc.Next(1, 13);
            if (procRoll == 5)
                isDoT = true;
            return isDoT;
        }
    }
}
