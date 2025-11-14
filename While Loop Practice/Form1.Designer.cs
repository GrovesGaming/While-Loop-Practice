namespace While_Loop_Practice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            enterButton = new Label();
            enterBox = new TextBox();
            endBox = new TextBox();
            endLabel = new Label();
            button1 = new Button();
            outputLabel = new Label();
            SuspendLayout();
            // 
            // enterButton
            // 
            enterButton.AutoSize = true;
            enterButton.Location = new Point(168, 129);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(178, 20);
            enterButton.TabIndex = 0;
            enterButton.Text = "Enter a number to start at";
            // 
            // enterBox
            // 
            enterBox.Location = new Point(370, 132);
            enterBox.Name = "enterBox";
            enterBox.Size = new Size(180, 27);
            enterBox.TabIndex = 1;
            // 
            // endBox
            // 
            endBox.Location = new Point(373, 205);
            endBox.Name = "endBox";
            endBox.Size = new Size(207, 27);
            endBox.TabIndex = 2;
            // 
            // endLabel
            // 
            endLabel.AutoSize = true;
            endLabel.Location = new Point(168, 212);
            endLabel.Name = "endLabel";
            endLabel.Size = new Size(174, 20);
            endLabel.TabIndex = 3;
            endLabel.Text = "enter a number to end at";
            // 
            // button1
            // 
            button1.Location = new Point(382, 265);
            button1.Name = "button1";
            button1.Size = new Size(216, 26);
            button1.TabIndex = 4;
            button1.Text = "Show value";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(166, 326);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(50, 20);
            outputLabel.TabIndex = 5;
            outputLabel.Text = "label1";
            outputLabel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(outputLabel);
            Controls.Add(button1);
            Controls.Add(endLabel);
            Controls.Add(endBox);
            Controls.Add(enterBox);
            Controls.Add(enterButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label enterButton;
        private TextBox enterBox;
        private TextBox endBox;
        private Label endLabel;
        private Button button1;
        private Label outputLabel;
    }
}
