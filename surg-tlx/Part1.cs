using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace surg_tlx
{
    public partial class Part1 : Form
    {
        public Part1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            mDemandValue = (mDemand.Value * 5);
            errorLabel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void LoadId(String id)
        {
            passedID = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkScales())
            {
                Part2Instructions instructions = new Part2Instructions();
                this.Hide();
                instructions.ShowDialog();
                Part2 part2 = new Part2();
                part2.LoadData(mDemandValue, pDemandValue, tDemandValue, complexityValue, stressValue, distractionsValue, passedID);
                part2.ShowDialog();
                this.Close();
            }
            else
            {
                errorLabel.Visible = true;
            }
        }

        private void pDemand_Scroll(object sender, EventArgs e)
        {
            pDemandValue = (pDemand.Value * 5);
            errorLabel.Visible = false;
        }

        private void tDemand_Scroll(object sender, EventArgs e)
        {
            tDemandValue = (tDemand.Value * 5);
            errorLabel.Visible = false;
        }

        private void tComplexity_Scroll(object sender, EventArgs e)
        {
            complexityValue = (tComplexity.Value * 5);
            errorLabel.Visible = false;
        }

        private void stress_Scroll(object sender, EventArgs e)
        {
            stressValue = (stress.Value * 5);
            errorLabel.Visible = false;
        }

        private void Distractions_Scroll(object sender, EventArgs e)
        {
            distractionsValue = (Distractions.Value * 5);
            errorLabel.Visible = false;
        }

        private bool checkScales(){
            if ((mDemandValue == 0) || (pDemandValue == 0) || (tDemandValue == 0) || (complexityValue == 0) || (stressValue == 0) || (distractionsValue == 0))
            {
                return false;
            }
            return true;
            }
    }
}
