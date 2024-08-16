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
            label1 = new Label();
            label2 = new Label();
            topButton = new Button();
            botButton = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(282, 32);
            label1.Name = "label1";
            label1.Size = new Size(165, 17);
            label1.TabIndex = 1;
            label1.Text = "Task Questionnaire - Part 2";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(250, 66);
            label2.Name = "label2";
            label2.Size = new Size(240, 75);
            label2.TabIndex = 2;
            label2.Text = "On each of the following 15 screens, click on the scale title that represents the more important contributor to workload for the task";
            // 
            // topButton
            // 
            topButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            topButton.Location = new Point(314, 195);
            topButton.Name = "topButton";
            topButton.Size = new Size(107, 27);
            topButton.TabIndex = 3;
            topButton.Text = "button1";
            topButton.UseVisualStyleBackColor = true;
            topButton.Click += topButton_Click;
            // 
            // botButton
            // 
            botButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botButton.Location = new Point(314, 306);
            botButton.Name = "botButton";
            botButton.Size = new Size(120, 27);
            botButton.TabIndex = 4;
            botButton.Text = "button2";
            botButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(353, 253);
            label3.Name = "label3";
            label3.Size = new Size(21, 17);
            label3.TabIndex = 5;
            label3.Text = "or";
            // 
            // Part2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
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
    }
}