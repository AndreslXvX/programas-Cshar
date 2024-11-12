namespace Matrices_y_bucle_foreach
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
            txtCodigo = new TextBox();
            txtPrecio = new TextBox();
            txtNombreProducto = new TextBox();
            label1 = new Label();
            lbProducto = new Label();
            label3 = new Label();
            btBuscar = new Button();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(12, 27);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(200, 23);
            txtCodigo.TabIndex = 0;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(12, 144);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(200, 23);
            txtPrecio.TabIndex = 1;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(12, 100);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(200, 23);
            txtNombreProducto.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 3;
            label1.Text = "Escribe el codigo a buscar";
            // 
            // lbProducto
            // 
            lbProducto.AutoSize = true;
            lbProducto.Location = new Point(12, 82);
            lbProducto.Name = "lbProducto";
            lbProducto.Size = new Size(122, 15);
            lbProducto.TabIndex = 4;
            lbProducto.Text = "Nombre del Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 126);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Precio";
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(12, 56);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(200, 23);
            btBuscar.TabIndex = 6;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 393);
            Controls.Add(btBuscar);
            Controls.Add(label3);
            Controls.Add(lbProducto);
            Controls.Add(label1);
            Controls.Add(txtNombreProducto);
            Controls.Add(txtPrecio);
            Controls.Add(txtCodigo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private TextBox txtPrecio;
        private TextBox txtNombreProducto;
        private Label label1;
        private Label lbProducto;
        private Label label3;
        private Button btBuscar;
    }
}
