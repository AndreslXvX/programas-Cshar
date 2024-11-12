namespace IF_ELSE
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
            btDescuento = new Button();
            lbValorD = new Label();
            lbValorCD = new Label();
            txtValorC = new TextBox();
            txtValorD = new TextBox();
            txtValorCD = new TextBox();
            lbValorC = new Label();
            SuspendLayout();
            // 
            // btDescuento
            // 
            btDescuento.Location = new Point(181, 177);
            btDescuento.Name = "btDescuento";
            btDescuento.Size = new Size(169, 38);
            btDescuento.TabIndex = 0;
            btDescuento.Text = "calcular descuento";
            btDescuento.UseVisualStyleBackColor = true;
            btDescuento.Click += btDescuento_Click;
            // 
            // lbValorD
            // 
            lbValorD.AutoSize = true;
            lbValorD.Location = new Point(243, 63);
            lbValorD.Name = "lbValorD";
            lbValorD.Size = new Size(41, 15);
            lbValorD.TabIndex = 2;
            lbValorD.Text = "ValorD";
            lbValorD.Click += label2_Click;
            // 
            // lbValorCD
            // 
            lbValorCD.AutoSize = true;
            lbValorCD.Location = new Point(243, 116);
            lbValorCD.Name = "lbValorCD";
            lbValorCD.Size = new Size(49, 15);
            lbValorCD.TabIndex = 3;
            lbValorCD.Text = "ValorCD";
            lbValorCD.Click += label3_Click;
            // 
            // txtValorC
            // 
            txtValorC.Location = new Point(213, 27);
            txtValorC.Name = "txtValorC";
            txtValorC.Size = new Size(100, 23);
            txtValorC.TabIndex = 4;
            // 
            // txtValorD
            // 
            txtValorD.Location = new Point(213, 81);
            txtValorD.Name = "txtValorD";
            txtValorD.Size = new Size(100, 23);
            txtValorD.TabIndex = 5;
            // 
            // txtValorCD
            // 
            txtValorCD.Location = new Point(213, 134);
            txtValorCD.Name = "txtValorCD";
            txtValorCD.Size = new Size(100, 23);
            txtValorCD.TabIndex = 6;
            // 
            // lbValorC
            // 
            lbValorC.AutoSize = true;
            lbValorC.Location = new Point(243, 9);
            lbValorC.Name = "lbValorC";
            lbValorC.Size = new Size(41, 15);
            lbValorC.TabIndex = 7;
            lbValorC.Text = "ValorC";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 266);
            Controls.Add(lbValorC);
            Controls.Add(txtValorCD);
            Controls.Add(txtValorD);
            Controls.Add(txtValorC);
            Controls.Add(lbValorCD);
            Controls.Add(lbValorD);
            Controls.Add(btDescuento);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btDescuento;
        private Label lbValorD;
        private Label lbValorCD;
        private TextBox txtValorC;
        private TextBox txtValorD;
        private TextBox txtValorCD;
        private Label lbValorC;
    }
}
