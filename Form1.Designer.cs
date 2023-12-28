namespace Sound_FX_Player
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
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            openFileDialog2 = new OpenFileDialog();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            openFileDialog3 = new OpenFileDialog();
            label3 = new Label();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            label4 = new Label();
            openFileDialog4 = new OpenFileDialog();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // button1
            // 
            button1.Location = new Point(276, 77);
            button1.Name = "button1";
            button1.Size = new Size(100, 61);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(382, 77);
            button2.Name = "button2";
            button2.Size = new Size(120, 61);
            button2.TabIndex = 1;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(138, 77);
            button3.Name = "button3";
            button3.Size = new Size(112, 61);
            button3.TabIndex = 2;
            button3.Text = "Open File...";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // button4
            // 
            button4.Location = new Point(138, 165);
            button4.Name = "button4";
            button4.Size = new Size(112, 56);
            button4.TabIndex = 3;
            button4.Text = "Open File...";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(276, 165);
            button5.Name = "button5";
            button5.Size = new Size(100, 56);
            button5.TabIndex = 4;
            button5.Text = "Start";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(382, 165);
            button6.Name = "button6";
            button6.Size = new Size(120, 56);
            button6.TabIndex = 5;
            button6.Text = "Stop";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 77);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 6;
            label1.Text = "Player 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 165);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 7;
            label2.Text = "Player 2";
            // 
            // button7
            // 
            button7.Location = new Point(138, 241);
            button7.Name = "button7";
            button7.Size = new Size(112, 51);
            button7.TabIndex = 8;
            button7.Text = "Open File...";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(276, 241);
            button8.Name = "button8";
            button8.Size = new Size(100, 51);
            button8.TabIndex = 9;
            button8.Text = "Start";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(382, 241);
            button9.Name = "button9";
            button9.Size = new Size(120, 51);
            button9.TabIndex = 10;
            button9.Text = "Stop";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName = "openFileDialog3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 241);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 11;
            label3.Text = "Player 3";
            // 
            // button10
            // 
            button10.Location = new Point(138, 319);
            button10.Name = "button10";
            button10.Size = new Size(112, 46);
            button10.TabIndex = 12;
            button10.Text = "Open File...";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(276, 319);
            button11.Name = "button11";
            button11.Size = new Size(100, 46);
            button11.TabIndex = 13;
            button11.Text = "Start";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(382, 319);
            button12.Name = "button12";
            button12.Size = new Size(120, 46);
            button12.TabIndex = 14;
            button12.Text = "Stop";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 319);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 15;
            label4.Text = "Player 4";
            // 
            // openFileDialog4
            // 
            openFileDialog4.FileName = "openFileDialog4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 580);
            Controls.Add(label4);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(label3);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Button button2;
        private Button button3;
        private OpenFileDialog openFileDialog2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private Label label2;
        private Button button7;
        private Button button8;
        private Button button9;
        private OpenFileDialog openFileDialog3;
        private Label label3;
        private Button button10;
        private Button button11;
        private Button button12;
        private Label label4;
        private OpenFileDialog openFileDialog4;
    }
}