using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace surg_tlx
{
    public partial class Part2 : Form
    {
        public Part2()
        {
            InitializeComponent();
            topButton.Text = currentTop;
            botButton.Text = currentBot;
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
            addWeight(currentTop);
            if (orderCount == 14)
            {
                createFile();
                this.Close();
                return;
            }
            updateForm();
        }

        private void botButton_Click(object sender, EventArgs e)
        {
            addWeight(currentBot);
            if (orderCount == 14)
            {
                createFile();
                this.Close();
                return;
            }
            updateForm();
        }

        private void updateForm()
        {
            orderCount++;
            currentTop = choices[topOrder[orderCount]];
            currentBot = choices[botOrder[orderCount]];
            topButton.Text = currentTop;
            botButton.Text = currentBot;
            screenLabel.Text = "Screen " + (orderCount+1).ToString();
        }

        public void createFile()
        {
            mDemandWeight = mDemandWeight / 15;
            pDemandWeight = pDemandWeight / 15;
            tDemandWeight = tDemandWeight / 15;
            complexityWeight = complexityWeight / 15;
            stressWeight = stressWeight / 15;
            distractionsWeight = distractionsWeight / 15;
            float totalWorkload = (mDemandValue*mDemandWeight) + (pDemandValue*pDemandWeight) + (tDemandValue*tDemandWeight) + (complexityValue*complexityWeight) + (stressValue*stressWeight) + (distractionsValue*distractionsWeight);

            using (StreamWriter outputFile = File.CreateText(Path.Combine(path, passedID + ".csv")))
            {
                outputFile.WriteLine("Scale,Value,Weight");
                outputFile.WriteLine("Mental Demand," + mDemandValue.ToString() + "," + mDemandWeight.ToString());
                outputFile.WriteLine("Physical Demand," + pDemandValue.ToString() + "," + pDemandWeight.ToString());
                outputFile.WriteLine("Temporal Demand," + tDemandValue.ToString() + "," + tDemandWeight.ToString());
                outputFile.WriteLine("Task Complexity," + complexityValue.ToString() + "," + complexityWeight.ToString());
                outputFile.WriteLine("Situational Stress," + stressValue.ToString() + "," + stressWeight.ToString());
                outputFile.WriteLine("Distractions," + distractionsValue.ToString() + "," + distractionsWeight.ToString());
                outputFile.WriteLine("Total Workload," + totalWorkload.ToString() + ",1");
            }
        }

        private void addWeight(string demand)
        {
            //["Mental Demand", "Physical Demand", "Temporal Demand", "Task Complexity", "Situational Stress", "Distractions"];
            if (demand == choices[0])
            {
                mDemandWeight++;
            } else if (demand == choices[1])
            {
                pDemandWeight++;
            } else if (demand == choices[2])
            {
                tDemandWeight++;
            } else if (demand == choices[3])
            {
                complexityWeight++;
            } else if (demand == choices[4])
            {
                stressWeight++;
            } else if (demand == choices[5])
            {
                distractionsWeight++;
            }
        }
    }
}
