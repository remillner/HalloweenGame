using System;
using System.Collections.Generic;

namespace HalloweenGame
{
    /* This class is the parent class for Player and all the enemy classes
     * I am leaving some commented lines in here, as they will aid me in the future development of this program.
     * You will find lots of variables that are as yet unused and once implemented will greatly increase the complexity
     * of the game.
     */
    class Entity
    {
        protected bool stunned = false, channeling = false;
        protected int life, attackNum, chnlComplete, channelCounter, stunCount, x = 0;
        protected string name;
        public const string KEY_1 = "Chocolate Bar(s) ";
        public const string KEY_2 = "Pixie Stick(s) ";
        //List<string> loot = new List<string>();
        //Dictionary<string,int> loot = new Dictionary<string,int>();
        protected int[] attack;
        protected List<int> doT = new List<int>();
        protected List<int> doTCounter = new List<int>();
        protected Dictionary<string, int> dict;
        Random randAttack = new Random();
        protected Random rand = new Random();
        public string[] atkName;

        /**
        * Constructor, just creating the Dictionary and pushing it down stream.
        */
        public Entity()
        {
            dict = new Dictionary<string, int>();
        }

        public virtual void setLife(int val)
        {
            life += val;
        }

        /*This method might get used in the future.
         */
        public void setAttack(int value)
        {
            attackNum += value;
        }

        public int getLife()
        {
            return life;
        }
    
        /*Method to calculate and bring all the variables together to pull of a fight sequence.
         * Lots of unused variables are waiting inside to be worked in at a future date.
         */ 
        public virtual string getAttack(Player target)
        {
            int totalDmg = 0;
            string msg = "";

            if (isAlive())
            {
                if (doTCounter.Count != 0)
                    doTDmg();
                if (!isChanneling())
                    x = rand.Next(0, attack.Length - 1);
                if (isStunned())
                    totalDmg = 0;
                if (isChanneling())
                {
                    channelCounter++;
                    if (channelCounter == chnlComplete)
                    {
                        //TODO: message to user = String.Format("{0}\nuses {1} attack for {2} damage!", name, atkName[x], totalDmG);
                        // Extra dmg or kill player(target)
                    }
                    else
                        totalDmg = 0;
                }
                for (int i = 0; i < attackNum; i++)
                {
                    totalDmg += rand.Next(1, 7);
                }
                totalDmg += attack[x];
                msg = string.Format("{0}\nuses {1} attack for {2} damage!", name, atkName[x], totalDmg);
            }
            else
                totalDmg = 0;
            target.setLifeCombat(-totalDmg);
            return msg;
        }

        /*Method that triggers and executes a DoTs damage.
         * >>Currently not being used<<
         */
        public void doTDmg()   
        {
            for (int i = 0; i < doT.Count; i++)
            {
                life -= doT[i];
                doT[i] /= 2;
                --doTCounter[i];
                if (doTCounter[i] == 0)
                {
                    doT.RemoveAt(i);
                    doTCounter.RemoveAt(i);
                }
            }
        }

        /*Method to set a DoT.
         * >>Currently not being used<<
         */
        public void setDoT(int dmg, int count)
        {
            doT.Add(dmg);
            doTCounter.Add(count);
        }

        public void setName(String value)
        {
            name = value;
        }
    
        public String getName()
        {
            return name;
        }
        
        /*Method to transfer the Loot from one entity to another.
         */
        public string getLoot(Player player)
        {
            string msg = "";
            int x=0;
            int[] loot = new int[dict.Count];
            foreach (KeyValuePair<string, int> kvp in dict)
            {
                msg += String.Format("You receive:{1} {0}\n!",
                    kvp.Key, kvp.Value);
                loot[x] = kvp.Value;
                x++;
            }
            player.lootInput(loot[0], loot[1]);
            return msg;
        }
        
        public bool isAlive()
        {
            bool boolVal = true;
            if (life < 1) 
                boolVal = false;
            return boolVal;
        }

        /*Method to set a Stun 
         * >>Currently not being used<<
         */
        public void setStunned(bool b)
        {
            channelCounter = 0;
            channeling = false;
            stunned = b;
            stunCount = 2;
        }

        /*Tracks the stun and removes it when the time is up
         * >>Currently not being used<<
         */
        public bool isStunned()
        {
            //TODO: set a message for stunned mob
            --stunCount;
            if (stunCount == 0)
                stunned = false; 
            return stunned;                
        }

        /*Method to check if channeling
         * >>Currently not being used<<
         * This could take most if the channeling counters and whatnots from 
         * the getAttack(). Similar to the above Stun()s
         */
        public bool isChanneling()
        {
            return channeling;
        }

        /*Method to put all the important details of an Entity
         * into a standard pack of String information.
         */
        public override string ToString()
        {
            string lootRO = "";
            foreach (KeyValuePair<string, int> kvp in dict)
            {
                lootRO += String.Format("     Loot:\n>> {1} {0}\n.",
                    kvp.Key, kvp.Value);
            }
            string record = String.Format("Name: {0}\nLife: {1}\nAttack Rolls: {2}\n" + lootRO, name, life, attackNum);
            return record;
        }
    }    
}
