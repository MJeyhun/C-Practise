namespace WinFormsUI
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
            label1 = new Label();
            FirstNameText = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            LastNameText = new TextBox();
            label5 = new Label();
            combineName = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 63);
            label1.Name = "label1";
            label1.Size = new Size(199, 50);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // FirstNameText
            // 
            FirstNameText.Location = new Point(313, 63);
            FirstNameText.Name = "FirstNameText";
            FirstNameText.Size = new Size(314, 57);
            FirstNameText.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(948, 504);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(314, 57);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(662, 494);
            label2.Name = "label2";
            label2.Size = new Size(199, 50);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(956, 512);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(314, 57);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(670, 502);
            label3.Name = "label3";
            label3.Size = new Size(199, 50);
            label3.TabIndex = 4;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(863, 502);
            label4.Name = "label4";
            label4.Size = new Size(199, 50);
            label4.TabIndex = 6;
            label4.Text = "First Name";
            // 
            // LastNameText
            // 
            LastNameText.Location = new Point(313, 158);
            LastNameText.Name = "LastNameText";
            LastNameText.Size = new Size(314, 57);
            LastNameText.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 165);
            label5.Name = "label5";
            label5.Size = new Size(195, 50);
            label5.TabIndex = 8;
            label5.Text = "Last Name";
            label5.Click += label5_Click;
            // 
            // combineName
            // 
            combineName.Location = new Point(161, 322);
            combineName.Name = "combineName";
            combineName.Size = new Size(340, 96);
            combineName.TabIndex = 9;
            combineName.Text = "Combine Name";
            combineName.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(combineName);
            Controls.Add(label5);
            Controls.Add(LastNameText);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(FirstNameText);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(8, 8, 8, 8);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox FirstNameText;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox LastNameText;
        private Label label5;
        private Button combineName;
    }
}