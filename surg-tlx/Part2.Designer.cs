namespace surg_tlx
{
    partial class Part2
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

        private static string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        private string passedID;
        private int mDemandValue;
        private int pDemandValue;
        private int tDemandValue;
        private int complexityValue;
        private int stressValue;
        private int distractionsValue;

        private float mDemandWeight = 0;
        private float pDemandWeight = 0;
        private float tDemandWeight = 0;
        private float complexityWeight = 0;
        private float stressWeight = 0;
        private float distractionsWeight = 0;

        // Order is the same as Nasa TLX
        private static List<string> choices = ["Mental Demand", "Physical Demand", "Temporal Demand", "Task Complexity", "Situational Stress", "Distractions"];
        private static List<int> topOrder = [2, 4, 5, 5, 1, 3, 1, 2, 2, 3, 1, 0, 0, 4, 3];
        private static  List<int> botOrder = [4, 3, 0, 4, 2, 0, 3, 5, 0, 2, 5, 4, 1, 1, 5];
        private string currentTop = choices[topOrder[0]];
        private string currentBot = choices[botOrder[0]];
        private int orderCount = 0;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            topButton = new Button();
            botButton = new Button();
            label3 = new Label();
            screenLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 17);
            label1.TabIndex = 1;
            label1.Text = "Task Questionnaire - Part 2";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(62, 54);
            label2.Name = "label2";
            label2.Size = new Size(240, 75);
            label2.TabIndex = 2;
            label2.Text = "On each of the following 15 screens, click on the scale title that represents the more important contributor to workload for the task";
            // 
            // topButton
            // 
            topButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            topButton.Location = new Point(111, 149);
            topButton.Name = "topButton";
            topButton.Size = new Size(135, 32);
            topButton.TabIndex = 3;
            topButton.UseVisualStyleBackColor = true;
            topButton.Click += topButton_Click;
            // 
            // botButton
            // 
            botButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botButton.Location = new Point(111, 204);
            botButton.Name = "botButton";
            botButton.Size = new Size(135, 32);
            botButton.TabIndex = 4;
            botButton.UseVisualStyleBackColor = true;
            botButton.Click += botButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(166, 184);
            label3.Name = "label3";
            label3.Size = new Size(21, 17);
            label3.TabIndex = 5;
            label3.Text = "or";
            // 
            // screenLabel
            // 
            screenLabel.AutoSize = true;
            screenLabel.Location = new Point(154, 294);
            screenLabel.Name = "screenLabel";
            screenLabel.Size = new Size(51, 15);
            screenLabel.TabIndex = 6;
            screenLabel.Text = "Screen 1";
            // 
            // Part2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 318);
            ControlBox = false;
            Controls.Add(screenLabel);
            Controls.Add(label3);
            Controls.Add(botButton);
            Controls.Add(topButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Part2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Part2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button topButton;
        private Button botButton;
        private Label label3;
        private Label screenLabel;
    }
}