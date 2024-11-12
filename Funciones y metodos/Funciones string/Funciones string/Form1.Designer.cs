namespace Funciones_string
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
            btSubstring = new Button();
            btToLower = new Button();
            btToUpper = new Button();
            txtPalabra = new TextBox();
            txtFuncion = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Escribe el texto";
            // 
            // btSubstring
            // 
            btSubstring.Location = new Point(12, 100);
            btSubstring.Name = "btSubstring";
            btSubstring.Size = new Size(122, 23);
            btSubstring.TabIndex = 1;
            btSubstring.Text = "Substring";
            btSubstring.UseVisualStyleBackColor = true;
            btSubstring.Click += btSubstring_Click;
            // 
            // btToLower
            // 
            btToLower.Location = new Point(268, 100);
            btToLower.Name = "btToLower";
            btToLower.Size = new Size(122, 23);
            btToLower.TabIndex = 2;
            btToLower.Text = "ToLower";
            btToLower.UseVisualStyleBackColor = true;
            btToLower.Click += btToLower_Click;
            // 
            // btToUpper
            // 
            btToUpper.Location = new Point(140, 100);
            btToUpper.Name = "btToUpper";
            btToUpper.Size = new Size(122, 23);
            btToUpper.TabIndex = 3;
            btToUpper.Text = "ToUpper";
            btToUpper.UseVisualStyleBackColor = true;
            btToUpper.Click += btToUpper_Click;
            // 
            // txtPalabra
            // 
            txtPalabra.Location = new Point(12, 27);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(378, 23);
            txtPalabra.TabIndex = 4;
            // 
            // txtFuncion
            // 
            txtFuncion.Location = new Point(12, 71);
            txtFuncion.Name = "txtFuncion";
            txtFuncion.Size = new Size(378, 23);
            txtFuncion.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 6;
            label2.Text = "Nuevo texto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 168);
            Controls.Add(label2);
            Controls.Add(txtFuncion);
            Controls.Add(txtPalabra);
            Controls.Add(btToUpper);
            Controls.Add(btToLower);
            Controls.Add(btSubstring);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btSubstring;
        private Button btToLower;
        private Button btToUpper;
        private TextBox txtPalabra;
        private TextBox txtFuncion;
        private Label label2;
    }
}
