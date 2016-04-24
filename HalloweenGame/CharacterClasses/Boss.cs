using System;

namespace HalloweenGame
{
    class Boss : Entity
    {
        string[] bosses = { "Satan", "Ghoul", "Vampire", "Werewolf", "Big Daddy Cultist" };        
        public static int bossCount = 0;
        
        /*Constructor which randomly selects a boss
         */
        public Boss(int lvl)
        {
            int bossPick = rand.Next(0, bosses.Length);
            bossCount++;
            name = String.Format("level {0} {1} Boss", (lvl + 1), bosses[bossPick]);
            switch (bosses[bossPick])
            {
                case "Satan":
                    {
                        atkName = new string[]{ "Hex", "Pitch Fork", "Attack3"};
                        attack = new int [] { 1, 2, 3};
                        dict.Add("Book of Satan", 1);
                        break;
                    }
                case "Ghoul":
                    {
                        atkName = new string[] { "Haunt", "Soul Eat", "Jackolantern"};
                        attack = new int[] { 1, 2, 3};
                        dict.Add("Book of Satan", 1);
                        break;
                    }
                case "Vampire":
                    {
                        atkName = new string[] { "Drain Blood", "Glamour", "Flood of Bats"};
                        attack = new int[] { 1, 2, 3};
                        dict.Add("Silver Cross", 1);
                        break;
                    }
                case "Werewolf":
                    {
                        atkName = new string[] { "Nasty Claw", "Horrible Howl", "Gnarly Bite"};
                        attack = new int[] { 1, 2, 3};
                        dict.Add("Nasty Claw", 1);
                        break;
                    }
                case "Big Daddy Cultist":
                    {
                        atkName = new string[] { "Attack1", "Hex", "Summon Pain"};
                        attack = new int[] { 1, 2, 3};
                        dict.Add("Sacrificial Knife", 1);
                        break;
                    }
            }

            switch (lvl)
            {
                case 0:
                    {
                        switch (bosses[bossPick])
                        {
                            case "Satan":
                                {
                                    life = (rand.Next(900, 1250));
                                    attackNum = 10;
                                    dict[KEY_1] = rand.Next(10, 14);
                                    dict[KEY_2] = rand.Next(5, 9);
                                    //dict.Add("Book of Satan", 1);
                                    break;
                                }
                            case "Ghoul":
                                {
                                    life = (rand.Next(900, 1250));
                                    attackNum = 10;
                                    dict[KEY_1] = rand.Next(10, 14);
                                    dict[KEY_2] = rand.Next(5, 9);
                                    //dict.Add("Book of Satan", 1);
                                    break;
                                }
                            case "Vampire":
                                {
                                    life = (rand.Next(900, 1250));
                                    attackNum = 10;
                                    dict[KEY_1] = rand.Next(10, 14);
                                    dict[KEY_2] = rand.Next(5, 9);
                                    //dict.Add("Silver Cross", 1);
                                    break;
                                }
                            case "Werewolf":
                                {
                                    life = (rand.Next(900, 1250));
                                    attackNum = 10;
                                    dict[KEY_1] = rand.Next(10, 14);
                                    dict[KEY_2] = rand.Next(5, 9);
                                    //dict.Add("Nasty Claw", 1);
                                    break;
                                }
                            case "Big Daddy Cultist":
                                {
                                    life = (rand.Next(900, 1250));
                                    attackNum = 10;
                                    dict[KEY_1] = rand.Next(10, 14);
                                    dict[KEY_2] = rand.Next(5, 9);
                                    //dict.Add("Sacrificial Knife", 1);
                                    break;
                                }
                        }
                        break;
                    }

                case 1:
                    {
                        switch (bosses[bossPick])
                        {
                            case "Satan":
                                {
                                    life = (rand.Next(150, 250));
                                    attackNum = 2;
                                    dict[KEY_1] = rand.Next(3, 7);
                                    dict[KEY_2] = rand.Next(2, 5);
                                    //dict.Add("Book of Satan", 1);
                                    break;
                                }
                            case "Ghoul":
                                {
                                    life = (rand.Next(150, 250));
                                    attackNum = 2;
                                    dict[KEY_1] = rand.Next(3, 7);
                                    dict[KEY_2] = rand.Next(2, 5);
                                    //dict.Add("Book of Satan", 1);
                                    break;
                                }
                            case "Vampire":
                                {
                                    life = (rand.Next(150, 250));
                                    attackNum = 2;
                                    dict[KEY_1] = rand.Next(3, 7);
                                    dict[KEY_2] = rand.Next(2, 5);
                                    //dict.Add("Silver Cross", 1);
                                    break;
                                }
                            case "Werewolf":
                                {
                                    life = (rand.Next(150, 250));
                                    attackNum = 2;
                                    dict[KEY_1] = rand.Next(3, 7);
                                    dict[KEY_2] = rand.Next(2, 5);
                                    //dict.Add("Nasty Claw", 1);
                                    break;
                                }
                            case "Big Daddy Cultist":
                                {
                                    life = (rand.Next(150, 250));
                                    attackNum = 2;
                                    dict[KEY_1] = rand.Next(3, 7);
                                    dict[KEY_2] = rand.Next(2, 5);
                                    //dict.Add("Sacrificial Knife", 1);
                                    break;
                                }
                        }
                        break;
                    }
                case 2:
                    {
                        switch (bosses[bossPick])
                        {
                            case "Satan":
                                {
                                    life = (rand.Next(150, 250));
                                    attackNum = 2;
                                    dict[KEY_1] = rand.Next(3, 7);
                                    dict[KEY_2] = rand.Next(2, 5);
                                    //dict.Add("Book of Satan", 1);
                                    break;
                                }
                            case "Ghoul":
                                {
                                    life = (rand.Next(150, 250));
                                    attackNum = 2;
                                    dict[KEY_1] = rand.Next(3, 7);
                                    dict[KEY_2] = rand.Next(2, 5);
                                    //dict.Add("Book of Satan", 1);
                                    break;
                                }
                            case "Vampire":
                                {
                                    life = (rand.Next(150, 250));
                                    attackNum = 2;
                                    dict[KEY_1] = rand.Next(3, 7);
                                    dict[KEY_2] = rand.Next(2, 5);
                                    //dict.Add("Silver Cross", 1);
                                    break;
                                }
                            case "Werewolf":
                                {
                                    life = (rand.Next(150, 250));
                                    attackNum = 2;
                                    dict[KEY_1] = rand.Next(3, 7);
                                    dict[KEY_2] = rand.Next(2, 5);
                                    //dict.Add("Nasty Claw", 1);
                                    break;
                                }
                            case "Big Daddy Cultist":
                                {
                                    life = (rand.Next(150, 250));
                                    attackNum = 2;
                                    dict[KEY_1] = rand.Next(3, 7);
                                    dict[KEY_2] = rand.Next(2, 5);
                                    //dict.Add("Sacrificial Knife", 1);
                                    break;
                                }
                        }
                        break;
                    }
                case 3:
                    {
                        switch (bosses[bossPick])
                        {
                            case "Satan":
                                {
                                    life = (rand.Next(150, 250));
                                    attackNum = 2;
                                    dict[KEY_1] = rand.Next(3, 7);
                                    dict[KEY_2] = rand.Next(2, 5);
                                    //dict.Add("Book of Satan", 1);
                                    break;
                                }
                            case "Ghoul":
                                {
                                    life = (rand.Next(150, 250));
                                    attackNum = 2;
                                    dict[KEY_1] = rand.Next(3, 7);
                                    dict[KEY_2] = rand.Next(2, 5);
                                    //dict.Add("Book of Satan", 1);
                                    break;
                                }
                            case "Vampire":
                                {
                                    life = (rand.Next(150, 250));
                                    attackNum = 2;
                                    dict[KEY_1] = rand.Next(3, 7);
                                    dict[KEY_2] = rand.Next(2, 5);
                                    //dict.Add("Silver Cross", 1);
                                    break;
                                }
                            case "Werewolf":
                                {
                                    life = (rand.Next(150, 250));
                                    attackNum = 2;
                                    dict[KEY_1] = rand.Next(3, 7);
                                    dict[KEY_2] = rand.Next(2, 5);
                                    //dict.Add("Nasty Claw", 1);
                                    break;
                                }
                            case "Big Daddy Cultist":
                                {
                                    life = (rand.Next(150, 250));
                                    attackNum = 2;
                                    dict[KEY_1] = rand.Next(3, 7);
                                    dict[KEY_2] = rand.Next(2, 5);
                                    //dict.Add("Sacrificial Knife", 1);
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    {
                        switch (bosses[bossPick])
                        {
                            case "Satan":
                                {
                                    life = (rand.Next(150, 250));
                                    attackNum = 2;
                                    dict[KEY_1] = rand.Next(3, 7);
                                    dict[KEY_2] = rand.Next(2, 5);
                                    //dict.Add("Book of Satan", 1);
                                    break;
                                }
                            case "Ghoul":
                                {
                                    life = (rand.Next(150, 250));
                                    attackNum = 2;
                                    dict[KEY_1] = rand.Next(3, 7);
                                    dict[KEY_2] = rand.Next(2, 5);
                                    //dict.Add("Book of Satan", 1);
                                    break;
                                }
                            case "Vampire":
                                {
                                    life = (rand.Next(150, 250));
                                    attackNum = 2;
                                    dict[KEY_1] = rand.Next(3, 7);
                                    dict[KEY_2] = rand.Next(2, 5);
                                    //dict.Add("Silver Cross", 1);
                                    break;
                                }
                            case "Werewolf":
                                {
                                    life = (rand.Next(150, 250));
                                    attackNum = 2;
                                    dict[KEY_1] = rand.Next(3, 7);
                                    dict[KEY_2] = rand.Next(2, 5);
                                    //dict.Add("Nasty Claw", 1);
                                    break;
                                }
                            case "Big Daddy Cultist":
                                {
                                    life = (rand.Next(150, 250));
                                    attackNum = 2;
                                    dict[KEY_1] = rand.Next(3, 7);
                                    dict[KEY_2] = rand.Next(2, 5);
                                    //dict.Add("Sacrificial Knife", 1);
                                    break;
                                }
                        }
                        break;
                    }
                
            }
        }
    }
}
