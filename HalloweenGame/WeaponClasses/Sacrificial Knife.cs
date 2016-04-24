namespace HalloweenGame
{
    class Sacrificial_Knife : Weapon
    {
        /*We had big dreams for Sacrificial Knife, which drops from the Cultist boss
        We initially wanted to pass the target's life and have it decrease it by 1/4th
        However since this is initiated in the beginning of the program before an instance of 
        an Enemy we could not get it to accept anything as a parameter
        We will continue working on this but for now it has a random attack roll
        */
        public int attackKnife()
        {
            //setDamage(enemy.getLife() / 4);
            setDamage(proc.Next(37, 80));
            return damage;
        }

    }
}
