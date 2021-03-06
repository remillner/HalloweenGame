﻿using System;

namespace HalloweenGame
{
    class CultistGymTeacher : Entity
    {

        public static int CultGymT = 0;

        public CultistGymTeacher(int lvl)
        {
            CultGymT++;
            name = String.Format("level{0} Cultist Gym Teacher", (lvl + 1));
            switch (lvl)
            {
                case 0:                    
                    life = (rand.Next(150, 250));
                    attackNum = 2;
                    dict[KEY_1] = rand.Next(3, 7);
                    dict[KEY_2] = rand.Next(2, 5);
                    attack = new int[] { 4, 12, 5 };
                    atkName = new string[] { "Attack1", "Attack2", "Attack3" };
                    break;
                case 1:
                {
                    life = (rand.Next(160, 260));
                    attackNum = 3;
                    dict[KEY_1] = rand.Next(4, 8);
                    dict[KEY_2] = rand.Next(2, 5);
                    attack = new int[] { 4, 12, 5 };
                    atkName = new string[] { "Attack1", "Attack2", "Attack3" };
                    break;
                }
                case 2:
                {
                    life = (rand.Next(170, 270));
                    attackNum = 4;
                    dict[KEY_1] = rand.Next(5, 9);
                    dict[KEY_2] = rand.Next(2, 5);
                    attack = new int[] { 4, 12, 5 };
                    atkName = new string[] { "Attack1", "Attack2", "Attack3" };
                    break;
                }
                case 3:
                {
                    life = (rand.Next(180, 280));
                    attackNum = 5;
                    dict[KEY_1] = rand.Next(5, 9);
                    dict[KEY_2] = rand.Next(2, 5);
                    attack = new int[] { 4, 12, 5 };
                    atkName = new string[] { "Attack1", "Attack2", "Attack3" };
                    break;
                }
                case 4:
                {
                    life = (rand.Next(190, 290));
                    attackNum = 6;
                    dict[KEY_1] = rand.Next(5, 9);
                    dict[KEY_2] = rand.Next(2, 5);
                    attack = new int[] { 4, 12, 5 };
                    atkName = new string[] { "Attack1", "Attack2", "Attack3" };
                    break;
                }
                default:
                {
                    life = (rand.Next(200, 300));
                    attackNum = 7;
                    dict[KEY_1] = rand.Next(5, 9);
                    dict[KEY_2] = rand.Next(2, 5);
                    attack = new int[] { 4, 12, 5 };
                    atkName = new string[] { "Attack1", "Attack2", "Attack3" };
                    break;
                }
            }
        }
    }
}
