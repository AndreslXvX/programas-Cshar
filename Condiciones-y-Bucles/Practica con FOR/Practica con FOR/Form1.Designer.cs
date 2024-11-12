namespace Practica_con_FOR
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
            btCalcular = new Button();
            ltMultiplicar = new ListBox();
            label1 = new Label();
            txtNumero = new TextBox();
            SuspendLayout();
            // 
            // btCalcular
            // 
            btCalcular.Location = new Point(183, 89);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(124, 36);
            btCalcular.TabIndex = 0;
            btCalcular.Text = "Calcular";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // ltMultiplicar
            // 
            ltMultiplicar.FormattingEnabled = true;
            ltMultiplicar.ItemHeight = 15;
            ltMultiplicar.Location = new Point(151, 131);
            ltMultiplicar.Name = "ltMultiplicar";
            ltMultiplicar.Size = new Size(189, 214);
            ltMultiplicar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 21);
            label1.Name = "label1";
            label1.Size = new Size(292, 15);
            label1.TabIndex = 2;
            label1.Text = "Digita un numero para conocer su tabla de multiplicar";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(193, 51);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 412);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Controls.Add(ltMultiplicar);
            Controls.Add(btCalcular);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCalcular;
        private ListBox ltMultiplicar;
        private Label label1;
        private TextBox txtNumero;
    }
}
