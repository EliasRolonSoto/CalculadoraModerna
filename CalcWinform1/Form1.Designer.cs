namespace CalcWinform1
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
            button1 = new Button();
            label1 = new Label();
            Estado = new Label();
            btnGenerate = new Button();
            panelCalc = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(34, 42);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Suma";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 81);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // Estado
            // 
            Estado.AutoSize = true;
            Estado.Dock = DockStyle.Bottom;
            Estado.Location = new Point(0, 616);
            Estado.Name = "Estado";
            Estado.Size = new Size(38, 15);
            Estado.TabIndex = 2;
            Estado.Text = "label2";
            Estado.Click += label2_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(252, 51);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 23);
            btnGenerate.TabIndex = 3;
            btnGenerate.Text = "Generar";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // panelCalc
            // 
            panelCalc.AutoSize = true;
            panelCalc.BackColor = SystemColors.ActiveCaption;
            panelCalc.Location = new Point(59, 110);
            panelCalc.Name = "panelCalc";
            panelCalc.Size = new Size(577, 456);
            panelCalc.TabIndex = 4;
            panelCalc.Paint += panelCalc_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 631);
            Controls.Add(panelCalc);
            Controls.Add(btnGenerate);
            Controls.Add(Estado);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Resize += Form1_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label Estado;
        private Button btnGenerate;
        private Panel panelCalc;
    }
}