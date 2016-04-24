using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloweenGame
{
    public partial class Form1 : Form
    {
        public List<string> story = new List<string>();
        public List<string> outStory = new List<string>();
        public static int storyIndex = 0;
        //Entity[] enemies;// = new Entity[1];  //for future use after level one
        Entity enemy;   //remove if using Entity array
        public static int lvl = 0;
        int combatRound, enemyNum = 0;
        bool fight = false;
        Player player = new Player("Player");     //will be user supplied in the future


        public Form1()
        {
            InitializeComponent();
        }

        /*Method to bring in the game story, thus alowing for easy replacement.
          Should probably make a method for setting all those panel and button values.  
        */
        private void btnBegin_Click(object sender, EventArgs e)
        {
            string line; 

            try
            {
                using (StreamReader sr = new StreamReader("story.txt"))
                {
                    line = sr.ReadLine();
                    while (sr.Peek() > -1)
                    {
                        story.Add(line);
                        line = sr.ReadLine();
                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not read the file!\n" + ex.ToString());
            }
            lblStory.Text = displayStory();
            panel1.Enabled = true;
            panel1.Visible = true;
            btnBegin.Enabled = false;
            btnBegin.Visible = false;
        }

        /*Method continues the story and checks for fight, then calls the fightScene().
        */
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (fight)
            {
                panel1.Enabled = false;
                panel1.Visible = false;
                btnHealChocBar.Enabled = true;
                btnHealChocBar.Visible = true;
                btnHealPix.Enabled = true;
                btnHealPix.Visible = true;
                playerAttackInput.Enabled = true;
                combatRound = 0;
                lblAtkPrompt.Text = "Choose your attack!";
                foreach (string item in player.atkName)
                {
                    playerAttackInput.Items.Add(item);
                }
                fightScene();
            }
            else
                lblStory.Text = displayStory();  //story[storyIndex];
        }

        private void fightScene()
        {
            lblPlayer.Text = player.ToString();
            lblEnemy1.Text = enemy.ToString();
            lblcombatRound.Text = String.Format("Round {0}", ++combatRound);
        }

        /*Method to check each line of the story for an enemy and calls the createEnemy() if one is present
         and displays the story for the user.
       */
        private string displayStory()
        {
            string msg;
            if (story[storyIndex].Contains("{0}"))
            {
                createEnemy();
                msg = String.Format(story[storyIndex], enemy.getName());
                //if (enemies.Length < 1)
                //{
                //    msg = String.Format(story[storyIndex], enemies[0].getName());  //replace (roll) with {0}
                //}
                //else
                //{
                //    msg = String.Format(story[storyIndex], enemies[0].getName(), enemies[0].getName());
                //}
               
            }
            else
                msg = story[storyIndex];
            outStory.Add(msg);
            storyIndex++;
            return msg;
        }

        /*Method used to write the Player's story out to a text file. 
            Currently this is only called when the player dies, but could be used as a save.
            At the least should include a message to the User. Maybe put it in the lblStory
        */
        private void writeOut()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("Halloween Story " + DateTime.Now.ToLongDateString() + ".txt"))
                {
                    foreach (string item in outStory)
                    {
                        sw.WriteLine(item);
                    }
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not read the file!\n" + ex.ToString());
            }
        }

        /*`Method activated by the User picking an Attack, 
        we see which one they picked and calculate then display the damage
        Once the attack round is over we check to see if the Player or Enemy died
        If so, we initiate the next part of the story/Display the end message
        */
        private void playerAttackInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            int attack = playerAttackInput.SelectedIndex;
            switch(attack)
            {
                case 0:
                    lblUserAttack.Text = player.getAttack(enemy, 0);
                    break;
                case 1:
                    lblUserAttack.Text = player.getAttack(enemy, 1);
                    break;
                case 2:
                    lblUserAttack.Text = player.getAttack(enemy, 2);
                    break;
            }
            lblEnemyAttack.Text = enemy.getAttack(player);
            fightScene();

            if (!enemy.isAlive())
            {
                panel1.Enabled = true;
                panel1.Visible = true;
                enemy.getLoot(player);
                fight = false;
                lblStory.Text = "You won!";
                lblAtkPrompt.Text = "";
                lblEnemy1.Text = "";
                lblEnemy2.Text = "";                //Maybe move all this to a method
                lblcombatRound.Text = "";
                lblEnemyAttack.Text = "";
                lblUserAttack.Text = "";
                btnHealChocBar.Enabled = false;
                btnHealChocBar.Visible = false;
                btnHealPix.Enabled = false;
                btnHealPix.Visible = false;
                playerAttackInput.Enabled = false;
                playerAttackInput.Items.Clear();
                
            }
            else if(!player.isAlive())
            {
                panel1.Enabled = true;
                panel1.Visible = true;
                lblAtkPrompt.Text = "";
                playerAttackInput.Enabled = false;
                btnHealChocBar.Enabled = false;             //Same as above
                btnHealPix.Enabled = false;
                playerAttackInput.Items.Clear();
                lblStory.Text = "You are Dead.\nHappy Halloween!";
                outStory.Add(lblStory.Text);
                writeOut();
            }
        }

        /*Method to create an instance of an Enemy
        writes information about the Enemy to the story file
        */
        private void createEnemy()
        {
            enemyNum++;
            Random rand = new Random();
            fight = true;

            if (enemyNum == 6 || enemyNum == 12)
            {
                Boss boss = new Boss(lvl);
                enemy = boss;
            }
            else
            { 
                int randomMob = rand.Next(0, 3);
                
                switch (randomMob)
                {
                    case 0:
                    {
                        CultistGymTeacher enemy1 = new CultistGymTeacher(lvl);
                        enemy = enemy1;
                        break;
                    }
                    case 1:
                    {
                        CultistStayAtHomeMom enemy1 = new CultistStayAtHomeMom(lvl);
                        enemy = enemy1;
                        //enemies = new Entity[] {enemy1};
                        break;
                    }
                    default:
                    {
                        RobedFigure enemy1 = new RobedFigure(lvl);
                        enemy = enemy1;
                        //enemies = new Entity[] {enemy1};
                        break;
                    }
                }
                outStory.Add(enemy.ToString());
            }
        }

        private void btnHealChocBar_Click(object sender, EventArgs e)
        {
            player.setLife(1);
            lblPlayer.Text = player.ToString();
        }

        private void btnHealPix_Click(object sender, EventArgs e)
        {
            player.setLife(2);
            lblPlayer.Text = player.ToString();
        }
    }
}
