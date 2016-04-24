namespace HalloweenGame
{
    class Player : Entity
    {
        /*Constructor 
         */
        public Player(string n)
        {
            name = n;
            life = (rand.Next(150, 250));
            Jackolantern lantern = new Jackolantern();
            Sacrificial_Knife knife = new Sacrificial_Knife();
            attack = new int [] { 4, knife.attackKnife(), lantern.attackLantern()};
            atkName = new string[] { "Rusty Ice Pick", "Stab with Sacrificial Knife", "Jackolantern" };  
            attackNum = 2;
            dict[KEY_1] = rand.Next(4, 8);
            dict[KEY_2] = rand.Next(3, 7);
        }

        /*Handles the actual increase of loot from slain enemies
         */
        public void lootInput(int cBars, int pS)
        {
            dict[KEY_1] += cBars;
            dict[KEY_2] += pS;
        }

        public void setLifeCombat(int dmg)
        {
            life += dmg;
        }

        /*Method to allow a player to heal.
         * Needs to be reworked and have some random rolls
         * Maybe disable the heal buttons when at max life
         */
        public override void setLife(int a)
        {
            int healFor;
            if (a == 1)
            {
                healFor = 50;
                dict[KEY_1] -= 1;
            }
            else
            {
                healFor = 90;
                dict[KEY_2] -= 1;
            }
            if (healFor + life > 300)
                life = 300;
            else
                life += healFor;
        }

        /*This is more of a placeholder for the moment.
         * Needs to be reworked to include the use of boss looted weapon classes.
         */
        public string getAttack(Entity target, int attackPicked)
        {
            int totalDmg = 0;
            string msg1 = "";
            for (int i = 0; i < attackNum; i++)
                totalDmg += rand.Next(1, 7);

            if (attackPicked == 0)
                totalDmg += attack[0];
            else if (attackPicked == 1)
                totalDmg += attack[1];
            else if (attackPicked == 2)
                totalDmg += attack[2];

            target.setLife(-totalDmg);
            msg1 = string.Format("You hit {0} with \n{1} for {2} damage", target.getName(), atkName[attackPicked], totalDmg);
            return msg1;
        }
    }
}
