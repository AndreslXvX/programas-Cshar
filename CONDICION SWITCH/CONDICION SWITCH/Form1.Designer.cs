namespace CONDICION_SWITCH
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
            cmbOpciones = new ComboBox();
            label1 = new Label();
            btProcesar = new Button();
            txtMes = new TextBox();
            SuspendLayout();
            // 
            // cmbOpciones
            // 
            cmbOpciones.FormattingEnabled = true;
            cmbOpciones.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cmbOpciones.Location = new Point(106, 60);
            cmbOpciones.Name = "cmbOpciones";
            cmbOpciones.Size = new Size(121, 23);
            cmbOpciones.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 42);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 1;
            label1.Text = "Mes seleccionado";
            // 
            // btProcesar
            // 
            btProcesar.Location = new Point(233, 60);
            btProcesar.Name = "btProcesar";
            btProcesar.Size = new Size(123, 28);
            btProcesar.TabIndex = 2;
            btProcesar.Text = "Procesar";
            btProcesar.UseVisualStyleBackColor = true;
            btProcesar.Click += btProcesar_Click;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(247, 94);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 23);
            txtMes.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 242);
            Controls.Add(txtMes);
            Controls.Add(btProcesar);
            Controls.Add(label1);
            Controls.Add(cmbOpciones);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOpciones;
        private Label label1;
        private Button btProcesar;
        private TextBox txtMes;
    }
}
