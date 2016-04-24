namespace HalloweenGame
{
    /*I+Jackolantern was intended to drop from the Ghoul boss 
        but since it was a more basic attack we decided to showcase
        it in this demo from the beginning
        It has a standard basic static attack 
        */
    class Jackolantern : Weapon
    {
        public int attackLantern()
        {
            setDamage(15);
            return damage;
        }
    }
}
