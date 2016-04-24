namespace HalloweenGame
{
    /*Nasty Claw drops from the Werewolf boss
        If it procs it will produce a DoT on the current Enemy
        If it does not it also contains a basic attack 
        */
    class Nasty_Claw : Weapon
    {
        private int DoT;
        public int attackClaw()
        {
            setDamage(30);
            isDoT = rollDoT();
            return damage;
        }

    }
}
