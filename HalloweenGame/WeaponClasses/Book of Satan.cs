namespace HalloweenGame
{
    /*Book of Satan drops after battling Satan as a boss
        It has special attacks for Vampires, Werewolves, and other Bosses
        Currently we just make the attack roll higher
        But in the future we may include special attacks based on the Enemy
        */
    class Book_of_Satan : Weapon
    {

        public int attackBook(Entity target)
        {
            if (target is Vampire || target is Werewolf || target is Boss)
                setDamage(proc.Next(30, 80));
            else
                setDamage(proc.Next(15, 40));

            return damage;
        }
    }
}
