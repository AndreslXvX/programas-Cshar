namespace Objetos_asociados
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
            groupBox1 = new GroupBox();
            lbNCelular = new Label();
            lbMontoVenta = new Label();
            lbNCliente = new Label();
            lbApellido = new Label();
            lbNombre = new Label();
            btAVenta = new Button();
            txtMVenta = new TextBox();
            txtCelular = new TextBox();
            txtNCliente = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            txtCFechaVenta = new TextBox();
            txtCTotalVenta = new TextBox();
            txtCNombreCliente = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtNumeroVenta = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbNCelular);
            groupBox1.Controls.Add(lbMontoVenta);
            groupBox1.Controls.Add(lbNCliente);
            groupBox1.Controls.Add(lbApellido);
            groupBox1.Controls.Add(lbNombre);
            groupBox1.Controls.Add(btAVenta);
            groupBox1.Controls.Add(txtMVenta);
            groupBox1.Controls.Add(txtCelular);
            groupBox1.Controls.Add(txtNCliente);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(472, 143);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crear venta";
            // 
            // lbNCelular
            // 
            lbNCelular.AutoSize = true;
            lbNCelular.Location = new Point(6, 19);
            lbNCelular.Name = "lbNCelular";
            lbNCelular.Size = new Size(44, 15);
            lbNCelular.TabIndex = 12;
            lbNCelular.Text = "Celular";
            // 
            // lbMontoVenta
            // 
            lbMontoVenta.AutoSize = true;
            lbMontoVenta.Location = new Point(6, 63);
            lbMontoVenta.Name = "lbMontoVenta";
            lbMontoVenta.Size = new Size(91, 15);
            lbMontoVenta.TabIndex = 11;
            lbMontoVenta.Text = "Monto de Venta";
            // 
            // lbNCliente
            // 
            lbNCliente.AutoSize = true;
            lbNCliente.Location = new Point(324, 19);
            lbNCliente.Name = "lbNCliente";
            lbNCliente.Size = new Size(91, 15);
            lbNCliente.TabIndex = 10;
            lbNCliente.Text = "Numero Cliente";
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.Location = new Point(218, 19);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(51, 15);
            lbApellido.TabIndex = 9;
            lbApellido.Text = "Apellido";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(112, 19);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(51, 15);
            lbNombre.TabIndex = 8;
            lbNombre.Text = "Nombre";
            // 
            // btAVenta
            // 
            btAVenta.Location = new Point(6, 110);
            btAVenta.Name = "btAVenta";
            btAVenta.Size = new Size(137, 23);
            btAVenta.TabIndex = 6;
            btAVenta.Text = "Agregar Venta";
            btAVenta.UseVisualStyleBackColor = true;
            btAVenta.Click += btAVenta_Click;
            // 
            // txtMVenta
            // 
            txtMVenta.Location = new Point(6, 81);
            txtMVenta.Name = "txtMVenta";
            txtMVenta.Size = new Size(100, 23);
            txtMVenta.TabIndex = 5;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(6, 37);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(100, 23);
            txtCelular.TabIndex = 4;
            txtCelular.Text = " ";
            // 
            // txtNCliente
            // 
            txtNCliente.Location = new Point(324, 37);
            txtNCliente.Name = "txtNCliente";
            txtNCliente.Size = new Size(100, 23);
            txtNCliente.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(218, 37);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(112, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(txtCFechaVenta);
            groupBox2.Controls.Add(txtCTotalVenta);
            groupBox2.Controls.Add(txtCNombreCliente);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtNumeroVenta);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 161);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(472, 176);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Consultar venta";
            // 
            // button1
            // 
            button1.Location = new Point(62, 51);
            button1.Name = "button1";
            button1.Size = new Size(150, 23);
            button1.TabIndex = 8;
            button1.Text = "Consultar Venta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtCFechaVenta
            // 
            txtCFechaVenta.Location = new Point(230, 102);
            txtCFechaVenta.Name = "txtCFechaVenta";
            txtCFechaVenta.Size = new Size(236, 23);
            txtCFechaVenta.TabIndex = 7;
            // 
            // txtCTotalVenta
            // 
            txtCTotalVenta.Location = new Point(124, 102);
            txtCTotalVenta.Name = "txtCTotalVenta";
            txtCTotalVenta.Size = new Size(100, 23);
            txtCTotalVenta.TabIndex = 6;
            // 
            // txtCNombreCliente
            // 
            txtCNombreCliente.Location = new Point(6, 102);
            txtCNombreCliente.Name = "txtCNombreCliente";
            txtCNombreCliente.Size = new Size(100, 23);
            txtCNombreCliente.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 84);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 4;
            label4.Text = "Fecha de venta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 84);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 3;
            label3.Text = "Total de venta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 84);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre del cliente";
            // 
            // txtNumeroVenta
            // 
            txtNumeroVenta.Location = new Point(6, 52);
            txtNumeroVenta.Name = "txtNumeroVenta";
            txtNumeroVenta.Size = new Size(50, 23);
            txtNumeroVenta.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(104, 30);
            label1.TabIndex = 0;
            label1.Text = "Escribe el numero \r\nde la venta";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 349);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lbNCelular;
        private Label lbMontoVenta;
        private Label lbNCliente;
        private Label lbApellido;
        private Label lbNombre;
        private Button btAVenta;
        private TextBox txtMVenta;
        private TextBox txtCelular;
        private TextBox txtNCliente;
        private GroupBox groupBox2;
        private TextBox txtNumeroVenta;
        private Label label1;
        private Button button1;
        private TextBox txtCFechaVenta;
        private TextBox txtCTotalVenta;
        private TextBox txtCNombreCliente;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
