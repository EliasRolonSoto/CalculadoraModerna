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
            labelResul = new Label();
            Estado = new Label();
            btnGenerate = new Button();
            panelCalc = new Panel();
            btnRemover = new Button();
            btnRemoveOps = new Button();
            btnGenOp = new Button();
            btnResta = new Button();
            btnDiv = new Button();
            btnMult = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(435, 203);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 0;
            button1.Text = "Suma";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelResul
            // 
            labelResul.AutoSize = true;
            labelResul.Location = new Point(610, 287);
            labelResul.Name = "labelResul";
            labelResul.Size = new Size(75, 20);
            labelResul.TabIndex = 1;
            labelResul.Text = "Resultado";
            // 
            // Estado
            // 
            Estado.AutoSize = true;
            Estado.Dock = DockStyle.Bottom;
            Estado.Location = new Point(0, 643);
            Estado.Name = "Estado";
            Estado.Size = new Size(50, 20);
            Estado.TabIndex = 2;
            Estado.Text = "label2";
            Estado.Click += label2_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(67, 45);
            btnGenerate.Margin = new Padding(3, 4, 3, 4);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(101, 83);
            btnGenerate.TabIndex = 3;
            btnGenerate.Text = "Generar Numeros";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // panelCalc
            // 
            panelCalc.AutoSize = true;
            panelCalc.BackColor = SystemColors.ActiveCaption;
            panelCalc.Location = new Point(67, 147);
            panelCalc.Margin = new Padding(3, 4, 3, 4);
            panelCalc.Name = "panelCalc";
            panelCalc.Size = new Size(346, 450);
            panelCalc.TabIndex = 4;
            panelCalc.Paint += panelCalc_Paint;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(293, 45);
            btnRemover.Margin = new Padding(3, 4, 3, 4);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(86, 83);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover Numeros";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnRemoveOps
            // 
            btnRemoveOps.Location = new Point(385, 45);
            btnRemoveOps.Name = "btnRemoveOps";
            btnRemoveOps.Size = new Size(102, 83);
            btnRemoveOps.TabIndex = 6;
            btnRemoveOps.Text = "Remover Operaciones";
            btnRemoveOps.UseVisualStyleBackColor = true;
            btnRemoveOps.Click += btnRemoveOps_Click;
            // 
            // btnGenOp
            // 
            btnGenOp.Location = new Point(174, 45);
            btnGenOp.Name = "btnGenOp";
            btnGenOp.Size = new Size(113, 83);
            btnGenOp.TabIndex = 7;
            btnGenOp.Text = "Generar operaciones";
            btnGenOp.UseVisualStyleBackColor = true;
            btnGenOp.Click += btnGenOp_Click;
            // 
            // btnResta
            // 
            btnResta.Location = new Point(435, 257);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(86, 29);
            btnResta.TabIndex = 8;
            btnResta.Text = "Resta";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(435, 363);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(86, 29);
            btnDiv.TabIndex = 9;
            btnDiv.Text = "Division";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(435, 311);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(86, 29);
            btnMult.TabIndex = 10;
            btnMult.Text = "Mult";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 663);
            Controls.Add(btnMult);
            Controls.Add(btnDiv);
            Controls.Add(btnResta);
            Controls.Add(btnGenOp);
            Controls.Add(btnRemoveOps);
            Controls.Add(btnRemover);
            Controls.Add(panelCalc);
            Controls.Add(btnGenerate);
            Controls.Add(Estado);
            Controls.Add(labelResul);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Resize += Form1_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label labelResul;
        private Label Estado;
        private Button btnGenerate;
        private Panel panelCalc;
        private Button btnRemover;
        private Button btnRemoveOps;
        private Button btnGenOp;
        private Button btnResta;
        private Button btnDiv;
        private Button btnMult;
    }
}