namespace Devolver_valores_con_funciones
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
            label2 = new Label();
            label3 = new Label();
            txtPrecio = new TextBox();
            txtDescuento = new TextBox();
            txtTotal = new TextBox();
            btCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingresa el precio de la compra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Descuento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 2;
            label3.Text = "Total neto a pagar";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(12, 27);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 3;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(12, 71);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 4;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(12, 115);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 5;
            // 
            // btCalcular
            // 
            btCalcular.Location = new Point(12, 144);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(185, 23);
            btCalcular.TabIndex = 6;
            btCalcular.Text = "Calcular precio";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 390);
            Controls.Add(btCalcular);
            Controls.Add(txtTotal);
            Controls.Add(txtDescuento);
            Controls.Add(txtPrecio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPrecio;
        private TextBox txtDescuento;
        private TextBox txtTotal;
        private Button btCalcular;
    }
}
