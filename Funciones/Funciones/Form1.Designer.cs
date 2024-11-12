namespace Funciones
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
            label1 = new Label();
            label2 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            SuspendLayout();
            // 
            // btCalcular
            // 
            btCalcular.Location = new Point(12, 100);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(75, 23);
            btCalcular.TabIndex = 0;
            btCalcular.Text = "Calcular";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 1;
            label1.Text = "Escribe el primer numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(150, 15);
            label2.TabIndex = 2;
            label2.Text = "Escribe el segundo numero";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(12, 27);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(12, 71);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(226, 343);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btCalcular);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCalcular;
        private Label label1;
        private Label label2;
        private TextBox txtNum1;
        private TextBox txtNum2;
    }
}
