namespace Bucle_While
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
            btMostrar = new Button();
            lbNumerosMensajes = new Label();
            ltMensajes = new ListBox();
            txtNumerosMensajes = new TextBox();
            SuspendLayout();
            // 
            // btMostrar
            // 
            btMostrar.Location = new Point(165, 99);
            btMostrar.Name = "btMostrar";
            btMostrar.Size = new Size(75, 23);
            btMostrar.TabIndex = 0;
            btMostrar.Text = "Mostar Mensajes";
            btMostrar.UseVisualStyleBackColor = true;
            btMostrar.Click += btMostrar_Click;
            // 
            // lbNumerosMensajes
            // 
            lbNumerosMensajes.AutoSize = true;
            lbNumerosMensajes.Location = new Point(104, 39);
            lbNumerosMensajes.Name = "lbNumerosMensajes";
            lbNumerosMensajes.Size = new Size(198, 15);
            lbNumerosMensajes.TabIndex = 1;
            lbNumerosMensajes.Text = "Ingresa el numero de mensajes a ver";
            // 
            // ltMensajes
            // 
            ltMensajes.FormattingEnabled = true;
            ltMensajes.ItemHeight = 15;
            ltMensajes.Location = new Point(121, 139);
            ltMensajes.Name = "ltMensajes";
            ltMensajes.Size = new Size(163, 184);
            ltMensajes.TabIndex = 2;
            // 
            // txtNumerosMensajes
            // 
            txtNumerosMensajes.Location = new Point(140, 70);
            txtNumerosMensajes.Name = "txtNumerosMensajes";
            txtNumerosMensajes.Size = new Size(122, 23);
            txtNumerosMensajes.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 371);
            Controls.Add(txtNumerosMensajes);
            Controls.Add(ltMensajes);
            Controls.Add(lbNumerosMensajes);
            Controls.Add(btMostrar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btMostrar;
        private Label lbNumerosMensajes;
        private ListBox ltMensajes;
        private TextBox txtNumerosMensajes;
    }
}
