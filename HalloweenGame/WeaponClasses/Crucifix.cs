namespace HalloweenGame
{
    /*Crucifix drops from the Vampire boss
        Since it is Silver it has higher attack against
        Vampires and Werewolves
        To make the damage dynamic to your level in the gamne we 
        check the target type and level and let those change the 
        damage amount
        */
    class Crucifix : Weapon
    {
        public int attackCrucifix(Entity target, int targetLvl)
        {
            setDamage(targetLvl * 20);
            if (target is Vampire || target is Werewolf)
            {
                damage += 40;
            }
            return damage;
        }
    }
}
