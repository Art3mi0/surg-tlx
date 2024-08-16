using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace surg_tlx
{
    public partial class Part2 : Form
    {
        public Part2()
        {
            InitializeComponent();
        }

        internal void LoadData(int MD, int PD, int TD, int TC, int SS, int D, string ID)
        {
            passedID = ID;
            mDemandValue = MD;
            pDemandValue = PD;
            tDemandValue = TD;
            complexityValue = TC;
            stressValue = SS;
            distractionsValue = D;
        }

        private void topButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
