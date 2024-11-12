namespace Bucle_Do_While
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
            btNumeros = new Button();
            label1 = new Label();
            ltMensajes = new ListBox();
            txtNumeros = new TextBox();
            SuspendLayout();
            // 
            // btNumeros
            // 
            btNumeros.Location = new Point(100, 113);
            btNumeros.Name = "btNumeros";
            btNumeros.Size = new Size(196, 23);
            btNumeros.TabIndex = 0;
            btNumeros.Text = "Ver Mensajes";
            btNumeros.UseVisualStyleBackColor = true;
            btNumeros.Click += btNumeros_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 56);
            label1.Name = "label1";
            label1.Size = new Size(202, 15);
            label1.TabIndex = 1;
            label1.Text = "Escribe el numeros de mensajes a ver";
            // 
            // ltMensajes
            // 
            ltMensajes.FormattingEnabled = true;
            ltMensajes.ItemHeight = 15;
            ltMensajes.Location = new Point(118, 142);
            ltMensajes.Name = "ltMensajes";
            ltMensajes.Size = new Size(169, 139);
            ltMensajes.TabIndex = 2;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(151, 84);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(100, 23);
            txtNumeros.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 347);
            Controls.Add(txtNumeros);
            Controls.Add(ltMensajes);
            Controls.Add(label1);
            Controls.Add(btNumeros);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btNumeros;
        private Label label1;
        private ListBox ltMensajes;
        private TextBox txtNumeros;
    }
}
