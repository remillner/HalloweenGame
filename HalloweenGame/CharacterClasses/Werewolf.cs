using System;

namespace HalloweenGame
{
    //>>Not Currently Used<<
    class Werewolf : Entity
    {
        public static int Werewolves = 0;
        string[] atkName = { "Cursed Bite", "Howl", "Scratch" };
        //int[] attack = { 4, 12, 5 };

        public Werewolf(int lvl)
        {
            Werewolves++;
            name = String.Format("level{0} Werewolf", (lvl + 1));
            switch (lvl)
            {
                case 0:
                    life = (rand.Next(150, 250));
                    attackNum = 2;
                    dict[KEY_1] = rand.Next(3, 7);
                    dict[KEY_2] = rand.Next(2, 5);
                    attack = new int[] { 4, 12, 5 };
                    break;
                case 1:
                    {
                        life = (rand.Next(160, 260));
                        attackNum = 3;
                        dict[KEY_1] = rand.Next(4, 8);
                        dict[KEY_2] = rand.Next(2, 5);
                        attack = new int[] { 4, 12, 5 };
                        break;
                    }
                case 2:
                    {
                        life = (rand.Next(170, 270));
                        attackNum = 4;
                        dict[KEY_1] = rand.Next(5, 9);
                        dict[KEY_2] = rand.Next(2, 5);
                        attack = new int[] { 4, 12, 5 };
                        break;
                    }
                case 3:
                    {
                        life = (rand.Next(180, 280));
                        attackNum = 5;
                        dict[KEY_1] = rand.Next(5, 9);
                        dict[KEY_2] = rand.Next(2, 5);
                        attack = new int[] { 4, 12, 5 };
                        break;
                    }
                case 4:
                    {
                        life = (rand.Next(190, 290));
                        attackNum = 6;
                        dict[KEY_1] = rand.Next(5, 9);
                        dict[KEY_2] = rand.Next(2, 5);
                        attack = new int[] { 4, 12, 5 };
                        break;
                    }
                default:
                    {
                        life = (rand.Next(200, 300));
                        attackNum = 7;
                        dict[KEY_1] = rand.Next(5, 9);
                        dict[KEY_2] = rand.Next(2, 5);
                        attack = new int[] { 4, 12, 5 };
                        break;
                    }
            }
        }
    }
}

