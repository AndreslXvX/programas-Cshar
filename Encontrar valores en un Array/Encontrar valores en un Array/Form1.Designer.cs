namespace Encontrar_valores_en_un_Array
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
            btBuscar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            txtPosicion = new TextBox();
            SuspendLayout();
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(133, 116);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(75, 23);
            btBuscar.TabIndex = 0;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 43);
            label1.Name = "label1";
            label1.Size = new Size(163, 15);
            label1.TabIndex = 1;
            label1.Text = "Escribe el nombre que buscas";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(89, 78);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(156, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtPosicion
            // 
            txtPosicion.Location = new Point(12, 165);
            txtPosicion.Name = "txtPosicion";
            txtPosicion.Size = new Size(416, 23);
            txtPosicion.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 261);
            Controls.Add(txtPosicion);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btBuscar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btBuscar;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtPosicion;
    }
}
