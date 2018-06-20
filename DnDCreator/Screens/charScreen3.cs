using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDCreator
{
    public partial class charScreen3 : UserControl
    {
        public int skillNum = 0;

        public charScreen3()
        {
            InitializeComponent();

            //  skills limit
           
        

            // class skill choices
            if (Form1.newCharacter.type == "Barbarian")
            {
                skillNum = skillNum + 2;

                aniButton.Enabled = true;
                athButton.Enabled = true;
                survButton.Enabled = true;
                intimButton.Enabled = true;
                natButton.Enabled = true;
                percButton.Enabled = true;
            }
            else if (Form1.newCharacter.type == "Bard")
            {
                skillNum = skillNum + 3;

                athButton.Enabled = true;
                acroButton.Enabled = true;
                handButton.Enabled = true;
                stealthButton.Enabled = true;
                arcaButton.Enabled = true;
                hisButton.Enabled = true;
                inveButton.Enabled = true;
                natButton.Enabled = true;
                religButton.Enabled = true;
                aniButton.Enabled = true;
                insButton.Enabled = true;
                medButton.Enabled = true;
                percButton.Enabled = true;
                survButton.Enabled = true;
                decButton.Enabled = true;
                intimButton.Enabled = true;
                perfButton.Enabled = true;
                persuaButton.Enabled = true;
            }

            else if (Form1.newCharacter.type == "Cleric")
            {
                skillNum = skillNum + 2;

                hisButton.Enabled = true;
                insButton.Enabled = true;
                medButton.Enabled = true;
                persuaButton.Enabled = true;
                religButton.Enabled = true;

            }
            else if (Form1.newCharacter.type == "Druid")
            {
                skillNum = skillNum + 2;

                arcaButton.Enabled = true;
                aniButton.Enabled = true;
                insButton.Enabled = true;
                medButton.Enabled = true;
                natButton.Enabled = true;
                percButton.Enabled = true;
                religButton.Enabled = true;
                survButton.Enabled = true;

            }
            else if (Form1.newCharacter.type == "Fighter")
            {
                skillNum = skillNum + 2;

                acroButton.Enabled = true;
                aniButton.Enabled = true;
                athButton.Enabled = true;
                hisButton.Enabled = true;
                insButton.Enabled = true;
                percButton.Enabled = true;
                intimButton.Enabled = true;
                survButton.Enabled = true;

            }
            else if (Form1.newCharacter.type == "Monk")
            {
                skillNum = skillNum + 2;

                acroButton.Enabled = true;
                athButton.Enabled = true;
                hisButton.Enabled = true;
                insButton.Enabled = true;
                religButton.Enabled = true;
                stealthButton.Enabled = true;

            }
            else if (Form1.newCharacter.type == "Paladin")
            {
                skillNum = skillNum + 2;

                intimButton.Enabled = true;
                athButton.Enabled = true;
                medButton.Enabled = true;
                insButton.Enabled = true;
                religButton.Enabled = true;
                persuaButton.Enabled = true;

            }
            else if (Form1.newCharacter.type == "Ranger")
            {
                skillNum = skillNum + 3;

                aniButton.Enabled = true;
                athButton.Enabled = true;
                inveButton.Enabled = true;
                insButton.Enabled = true;
                natButton.Enabled = true;
                percButton.Enabled = true;
                stealthButton.Enabled = true;
                survButton.Enabled = true;

            }
            else if (Form1.newCharacter.type == "Rogue")
            {
                skillNum = skillNum + 4;

                athButton.Enabled = true;
                acroButton.Enabled = true;
                handButton.Enabled = true;
                stealthButton.Enabled = true;
                inveButton.Enabled = true;
                insButton.Enabled = true;
                percButton.Enabled = true;
                decButton.Enabled = true;
                intimButton.Enabled = true;
                perfButton.Enabled = true;
                persuaButton.Enabled = true;
            }
            else if (Form1.newCharacter.type == "Sorcerer")
            {
                skillNum = skillNum + 2;

                arcaButton.Enabled = true;
                decButton.Enabled = true;
                insButton.Enabled = true;
                intimButton.Enabled = true;
                persuaButton.Enabled = true;
                religButton.Enabled = true;

            }
            else if (Form1.newCharacter.type == "Warlock")
            {
                skillNum = skillNum + 2;

                arcaButton.Enabled = true;
                decButton.Enabled = true;
                hisButton.Enabled = true;
                intimButton.Enabled = true;
                inveButton.Enabled = true;
                religButton.Enabled = true;
                natButton.Enabled = true;

            }
            else if (Form1.newCharacter.type == "Wizard")
            {
                skillNum = skillNum + 2;

                arcaButton.Enabled = true;
                insButton.Enabled = true;
                hisButton.Enabled = true;
                medButton.Enabled = true;
                inveButton.Enabled = true;
                religButton.Enabled = true;

            }

            if (Form1.newCharacter.background == "Acolyte")
            {
                skillNum += 2;
                insButton.Checked = true;
                religButton.Checked = true;
                insButton.Enabled = false;
                religButton.Enabled = false;
               
            }
            else if (Form1.newCharacter.background == "Charlatan")
            {
                skillNum += 2;
                decButton.Checked = true;
                handButton.Checked = true;
                decButton.Enabled = false;
                handButton.Enabled = false;
            }
            else if (Form1.newCharacter.background == "Criminal")
            {
                skillNum += 2;
                decButton.Checked = true;
                stealthButton.Checked = true;
                decButton.Enabled = false;
                stealthButton.Enabled = false;
            }
            else if (Form1.newCharacter.background == "Entertainer")
            {
                skillNum += 2;
                acroButton.Checked = true;
                perfButton.Checked = true;
                acroButton.Enabled = false;
                percButton.Enabled = false;
            }
            else if (Form1.newCharacter.background == "Guild Merchant")
            {
                skillNum += 2;
                insButton.Checked = true;
                persuaButton.Checked = true;
                insButton.Enabled = false;
                persuaButton.Enabled = false;
            }
            else if (Form1.newCharacter.background == "Hermit")
            {
                skillNum += 2;
                medButton.Checked = true;
                religButton.Checked = true;
                medButton.Enabled = false;
                religButton.Enabled = false;
            }
            else if (Form1.newCharacter.background == "Noble")
            {
                skillNum += 2;
                hisButton.Checked = true;
                persuaButton.Checked = true;
                hisButton.Enabled = false;
                persuaButton.Enabled = false;
            }
            else if (Form1.newCharacter.background == "Outlander")
            {
                skillNum += 2;
                athButton.Checked = true;
                survButton.Checked = true;
                athButton.Enabled = false;
                survButton.Enabled = false;
            }
            else if (Form1.newCharacter.background == "Sage")
            {
                skillNum += 2;
                arcaButton.Checked = true;
                hisButton.Checked = true;
                arcaButton.Enabled = false;
                hisButton.Enabled = false;
            }
            else if (Form1.newCharacter.background == "Sailor")
            {
                skillNum += 2;
                athButton.Checked = true;
                percButton.Checked = true;
                athButton.Enabled = false;
                percButton.Enabled = false;
            }
            else if (Form1.newCharacter.background == "Soldier")
            {
                skillNum += 2;
                athButton.Checked = true;
                intimButton.Checked = true;
                athButton.Enabled = false;
                intimButton.Enabled = false;
            }
            else if (Form1.newCharacter.background == "Urchin")
            {
                skillNum += 2;
                handButton.Checked = true;
                stealthButton.Checked = true;
                handButton.Enabled = false;
                stealthButton.Enabled = false;
            }
        }

        private void athButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void skillList()
        {
           
                athButton.Enabled = false;
                acroButton.Enabled = false;
                handButton.Enabled = false;
                stealthButton.Enabled = false;
                arcaButton.Enabled = false;
                hisButton.Enabled = false;
                inveButton.Enabled = false;
                natButton.Enabled = false;
                religButton.Enabled = false;
                aniButton.Enabled = false;
                insButton.Enabled = false;
                medButton.Enabled = false;
                percButton.Enabled = false;
                survButton.Enabled = false;
                decButton.Enabled = false;
                intimButton.Enabled = false;
                perfButton.Enabled = false;
                persuaButton.Enabled = false;

        }

        private void char3NextButton_Click(object sender, EventArgs e)
        {
           
            
        }

        private void char3BackButton_Click(object sender, EventArgs e)
        {

        }

        private void athButton_CheckedChanged_1(object sender, EventArgs e)
        {
            if (athButton.Checked && skillNum > 0)
            {
                Form1.newCharacter.skills.Add("Athletics");
                skillNum--;
            }
            else
            {
                skillNum++;
            }

            if (skillNum == 0)
            {
                skillList();
            }          
        }

        private void acroButton_CheckedChanged(object sender, EventArgs e)
        {
            if (acroButton.Checked && skillNum > 0)
            {
                Form1.newCharacter.skills.Add("Acrobatics");
                skillNum--;
            }
            else
            {
                skillNum++;
            }

            if (skillNum == 0)
            {
                skillList();
            }
        }

        private void handButton_CheckedChanged(object sender, EventArgs e)
        {
            if (handButton.Checked && skillNum > 0)
            {
                Form1.newCharacter.skills.Add("Sleight of Hand");
                skillNum--;
            }
            else
            {
                skillNum++;
            }

            if (skillNum == 0)
            {
                skillList();
            }
        }

        private void stealthButton_CheckedChanged(object sender, EventArgs e)
        {
            if (stealthButton.Checked && skillNum > 0)
            {
                Form1.newCharacter.skills.Add("Stealth");
                skillNum--;
            }
            else
            {
                skillNum++;
            }

            if (skillNum == 0)
            {
                skillList();
            }
        }

        private void arcaButton_CheckedChanged(object sender, EventArgs e)
        {
            if (arcaButton.Checked && skillNum > 0)
            {
                Form1.newCharacter.skills.Add("Arcana");
                skillNum--;
            }
            else
            {
                skillNum++;
            }

            if (skillNum == 0)
            {
                skillList();
            }
        }

        private void religButton_CheckedChanged(object sender, EventArgs e)
        {
            if (religButton.Checked && skillNum > 0)
            {
                Form1.newCharacter.skills.Add("Religion");
                skillNum--;
            }
            else
            {
                skillNum++;
            }

            if (skillNum == 0)
            {
                skillList();
            }
        }

        private void hisButton_CheckedChanged(object sender, EventArgs e)
        {
            if (hisButton.Checked && skillNum > 0)
            {
                Form1.newCharacter.skills.Add("History");
                skillNum--;
            }
            else
            {
                skillNum++;
            }

            if (skillNum == 0)
            {
                skillList();
            }
        }

        private void inveButton_CheckedChanged(object sender, EventArgs e)
        {
            if (inveButton.Checked && skillNum > 0)
            {
                Form1.newCharacter.skills.Add("Investigation");
                skillNum--;
            }
            else
            {
                skillNum++;
            }

            if (skillNum == 0)
            {
                skillList();
            }
        }

        private void natButton_CheckedChanged(object sender, EventArgs e)
        {
            if (natButton.Checked && skillNum > 0)
            {
                Form1.newCharacter.skills.Add("Nature");
                skillNum--;
            }
            else
            {
                skillNum++;
            }

            if (skillNum == 0)
            {
                skillList();
            }
        }

        private void aniButton_CheckedChanged(object sender, EventArgs e)
        {
            if (aniButton.Checked && skillNum > 0)
            {
                Form1.newCharacter.skills.Add("Animal Handling");
                skillNum--;
            }
            else
            {
                skillNum++;
            }

            if (skillNum == 0)
            {
                skillList();
            }
        }

        private void insButton_CheckedChanged(object sender, EventArgs e)
        {
            if (insButton.Checked && skillNum > 0)
            {
                Form1.newCharacter.skills.Add("Insight");
                skillNum--;
            }
            else
            {
                skillNum++;
            }

            if (skillNum == 0)
            {
                skillList();
            }
        }

        private void medButton_CheckedChanged(object sender, EventArgs e)
        {
            if (medButton.Checked && skillNum > 0)
            {
                Form1.newCharacter.skills.Add("Medicine");
                skillNum--;
            }
            else
            {
                skillNum++;
            }

            if (skillNum == 0)
            {
                skillList();
            }
        }

        private void percButton_CheckedChanged(object sender, EventArgs e)
        {
            if (percButton.Checked && skillNum > 0)
            {
                Form1.newCharacter.skills.Add("Perception");
                skillNum--;
            }
            else
            {
                skillNum++;
            }

            if (skillNum == 0)
            {
                skillList();
            }
        }

        private void survButton_CheckedChanged(object sender, EventArgs e)
        {
            if (survButton.Checked && skillNum > 0)
            {
                Form1.newCharacter.skills.Add("Survival");
                skillNum--;
            }
            else
            {
                skillNum++;
            }

            if (skillNum == 0)
            {
                skillList();
            }
        }

        private void decButton_CheckedChanged(object sender, EventArgs e)
        {
            if (decButton.Checked && skillNum > 0)
            {
                Form1.newCharacter.skills.Add("Deception");
                skillNum--;
            }
            else
            {
                skillNum++;
            }

            if (skillNum == 0)
            {
                skillList();
            }
        }

        private void intimButton_CheckedChanged(object sender, EventArgs e)
        {
            if (intimButton.Checked && skillNum > 0)
            {
                Form1.newCharacter.skills.Add("Intimidation");
                skillNum--;
            }
            else
            {
                skillNum++;
            }

            if (skillNum == 0)
            {
                skillList();
            }
        }

        private void perfButton_CheckedChanged(object sender, EventArgs e)
        {
            if (perfButton.Checked && skillNum > 0)
            {
                Form1.newCharacter.skills.Add("Performance");
                skillNum--;
            }
            else
            {
                skillNum++;
            }

            if (skillNum == 0)
            {
                skillList();
            }
        }

        private void persuaButton_CheckedChanged(object sender, EventArgs e)
        {
            if (persuaButton.Checked && skillNum > 0)
            {
                Form1.newCharacter.skills.Add("Persuasion");
                skillNum--;
            }
            else
            {
                skillNum++;
            }

            if (skillNum == 0)
            {
                skillList();
            }
        }

        private void skillButtonNext_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            DnDCreator.Screens.CharScreen4 cs4 = new DnDCreator.Screens.CharScreen4();
            f.Controls.Add(cs4);
        }

        private void skillButtonBack_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            charScreen2 cs2 = new charScreen2();
            f.Controls.Add(cs2);
        }
    }

  
    
}
