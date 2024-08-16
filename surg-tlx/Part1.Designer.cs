using System.Runtime.CompilerServices;

namespace surg_tlx
{
    partial class Part1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private string passedID;
        private int mDemandValue;
        private int pDemandValue;
        private int tDemandValue;
        private int complexityValue;
        private int stressValue;
        private int distractionsValue;


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mDemand = new TrackBar();
            cancelButton = new Button();
            contButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pDemand = new TrackBar();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tDemand = new TrackBar();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            tComplexity = new TrackBar();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            stress = new TrackBar();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            Distractions = new TrackBar();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            errorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)mDemand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pDemand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tDemand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tComplexity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Distractions).BeginInit();
            SuspendLayout();
            // 
            // mDemand
            // 
            mDemand.Location = new Point(54, 106);
            mDemand.Maximum = 20;
            mDemand.Name = "mDemand";
            mDemand.Size = new Size(300, 45);
            mDemand.TabIndex = 0;
            mDemand.Scroll += trackBar1_Scroll;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(12, 602);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += button1_Click;
            // 
            // contButton
            // 
            contButton.Location = new Point(329, 602);
            contButton.Name = "contButton";
            contButton.Size = new Size(75, 23);
            contButton.TabIndex = 2;
            contButton.Text = "Continue";
            contButton.UseVisualStyleBackColor = true;
            contButton.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(155, 74);
            label1.Name = "label1";
            label1.Size = new Size(113, 17);
            label1.TabIndex = 3;
            label1.Text = "Mental Demands";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 139);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Very Low";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 139);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Very High";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 219);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 9;
            label4.Text = "Very High";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 219);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 8;
            label5.Text = "Very Low";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(151, 154);
            label6.Name = "label6";
            label6.Size = new Size(120, 17);
            label6.TabIndex = 7;
            label6.Text = "Physical Demands";
            // 
            // pDemand
            // 
            pDemand.Location = new Point(54, 188);
            pDemand.Maximum = 20;
            pDemand.Name = "pDemand";
            pDemand.Size = new Size(300, 45);
            pDemand.TabIndex = 6;
            pDemand.Scroll += pDemand_Scroll;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(321, 301);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 13;
            label7.Text = "Very High";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(54, 301);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 12;
            label8.Text = "Very Low";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label9.Location = new Point(151, 236);
            label9.Name = "label9";
            label9.Size = new Size(128, 17);
            label9.TabIndex = 11;
            label9.Text = "Temporal Demands";
            // 
            // tDemand
            // 
            tDemand.Location = new Point(54, 269);
            tDemand.Maximum = 20;
            tDemand.Name = "tDemand";
            tDemand.Size = new Size(300, 45);
            tDemand.TabIndex = 10;
            tDemand.Scroll += tDemand_Scroll;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(321, 382);
            label10.Name = "label10";
            label10.Size = new Size(80, 15);
            label10.TabIndex = 17;
            label10.Text = "Very Complex";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(54, 382);
            label11.Name = "label11";
            label11.Size = new Size(103, 15);
            label11.TabIndex = 16;
            label11.Text = "Not Very Complex";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label12.Location = new Point(151, 317);
            label12.Name = "label12";
            label12.Size = new Size(109, 17);
            label12.TabIndex = 15;
            label12.Text = "Task Complexity";
            // 
            // tComplexity
            // 
            tComplexity.Location = new Point(54, 352);
            tComplexity.Maximum = 20;
            tComplexity.Name = "tComplexity";
            tComplexity.Size = new Size(300, 45);
            tComplexity.TabIndex = 14;
            tComplexity.Scroll += tComplexity_Scroll;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(321, 480);
            label13.Name = "label13";
            label13.Size = new Size(75, 15);
            label13.TabIndex = 21;
            label13.Text = "Very Anxious";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(54, 480);
            label14.Name = "label14";
            label14.Size = new Size(98, 15);
            label14.TabIndex = 20;
            label14.Text = "Not Very Anxious";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label15.Location = new Point(147, 415);
            label15.Name = "label15";
            label15.Size = new Size(115, 17);
            label15.TabIndex = 19;
            label15.Text = "Situational Stress";
            // 
            // stress
            // 
            stress.Location = new Point(54, 450);
            stress.Maximum = 20;
            stress.Name = "stress";
            stress.Size = new Size(300, 45);
            stress.TabIndex = 18;
            stress.Scroll += stress_Scroll;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(328, 566);
            label16.Name = "label16";
            label16.Size = new Size(29, 15);
            label16.TabIndex = 25;
            label16.Text = "Very";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(61, 566);
            label17.Name = "label17";
            label17.Size = new Size(52, 15);
            label17.TabIndex = 24;
            label17.Text = "Not Very";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label18.Location = new Point(164, 501);
            label18.Name = "label18";
            label18.Size = new Size(82, 17);
            label18.TabIndex = 23;
            label18.Text = "Distractions";
            // 
            // Distractions
            // 
            Distractions.Location = new Point(54, 521);
            Distractions.Maximum = 20;
            Distractions.Name = "Distractions";
            Distractions.Size = new Size(300, 45);
            Distractions.TabIndex = 22;
            Distractions.Scroll += Distractions_Scroll;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(134, 7);
            label19.Name = "label19";
            label19.Size = new Size(147, 15);
            label19.TabIndex = 26;
            label19.Text = "Task Questionnaire - Part 1";
            // 
            // label20
            // 
            label20.Location = new Point(58, 35);
            label20.Name = "label20";
            label20.Size = new Size(300, 35);
            label20.TabIndex = 27;
            label20.Text = "Click on each scale at the point that best indicates your experience of the task";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(96, 91);
            label21.Name = "label21";
            label21.Size = new Size(237, 15);
            label21.TabIndex = 28;
            label21.Text = "How mentally fatiguing was the procedure?";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(92, 171);
            label22.Name = "label22";
            label22.Size = new Size(243, 15);
            label22.TabIndex = 29;
            label22.Text = "How physically fatiguing was the procedure?";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(61, 253);
            label23.Name = "label23";
            label23.Size = new Size(293, 15);
            label23.TabIndex = 30;
            label23.Text = "How hurried or rushed was the pace of the procedure?";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(119, 334);
            label24.Name = "label24";
            label24.Size = new Size(186, 15);
            label24.TabIndex = 31;
            label24.Text = "How complex was the procedure?";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(58, 432);
            label25.Name = "label25";
            label25.Size = new Size(310, 15);
            label25.TabIndex = 32;
            label25.Text = "How anxious id you feel while performing the procedure?";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(79, 518);
            label26.Name = "label26";
            label26.Size = new Size(264, 15);
            label26.TabIndex = 33;
            label26.Text = "How distracting was the operating environment?";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(109, 602);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(196, 15);
            errorLabel.TabIndex = 34;
            errorLabel.Text = "Must Not Leave Any Scale At Zero";
            errorLabel.Visible = false;
            // 
            // Part1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 637);
            ControlBox = false;
            Controls.Add(errorLabel);
            Controls.Add(label26);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(Distractions);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(stress);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(tComplexity);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(tDemand);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(pDemand);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(contButton);
            Controls.Add(cancelButton);
            Controls.Add(mDemand);
            Name = "Part1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Questionnaire";
            ((System.ComponentModel.ISupportInitialize)mDemand).EndInit();
            ((System.ComponentModel.ISupportInitialize)pDemand).EndInit();
            ((System.ComponentModel.ISupportInitialize)tDemand).EndInit();
            ((System.ComponentModel.ISupportInitialize)tComplexity).EndInit();
            ((System.ComponentModel.ISupportInitialize)stress).EndInit();
            ((System.ComponentModel.ISupportInitialize)Distractions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar mDemand;
        private Button cancelButton;
        private Button contButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TrackBar pDemand;
        private Label label7;
        private Label label8;
        private Label label9;
        private TrackBar tDemand;
        private Label label10;
        private Label label11;
        private Label label12;
        private TrackBar tComplexity;
        private Label label13;
        private Label label14;
        private Label label15;
        private TrackBar stress;
        private Label label16;
        private Label label17;
        private Label label18;
        private TrackBar Distractions;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label errorLabel;
    }
}