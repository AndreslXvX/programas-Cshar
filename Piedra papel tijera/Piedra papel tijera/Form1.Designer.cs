namespace Piedra_papel_tijera
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
            LblJugador = new Label();
            LblCPU = new Label();
            BtnPiedra = new Button();
            BtnPapel = new Button();
            BtnTijera = new Button();
            LblGanador = new Label();
            label1 = new Label();
            LblRondas = new Label();
            label2 = new Label();
            label3 = new Label();
            LblVictoriasJugador = new Label();
            LblVictoriasCPU = new Label();
            SuspendLayout();
            // 
            // LblJugador
            // 
            LblJugador.AutoSize = true;
            LblJugador.Location = new Point(12, 90);
            LblJugador.Name = "LblJugador";
            LblJugador.Size = new Size(89, 15);
            LblJugador.TabIndex = 0;
            LblJugador.Text = "Jugada Jugador";
            // 
            // LblCPU
            // 
            LblCPU.AutoSize = true;
            LblCPU.Location = new Point(107, 90);
            LblCPU.Name = "LblCPU";
            LblCPU.Size = new Size(70, 15);
            LblCPU.TabIndex = 1;
            LblCPU.Text = "Jugada CPU";
            LblCPU.Click += Label2_Click;
            // 
            // BtnPiedra
            // 
            BtnPiedra.Location = new Point(12, 42);
            BtnPiedra.Name = "BtnPiedra";
            BtnPiedra.Size = new Size(75, 23);
            BtnPiedra.TabIndex = 2;
            BtnPiedra.Text = "piedra";
            BtnPiedra.UseVisualStyleBackColor = true;
            BtnPiedra.Click += BtnPiedra_Click;
            // 
            // BtnPapel
            // 
            BtnPapel.Location = new Point(93, 42);
            BtnPapel.Name = "BtnPapel";
            BtnPapel.Size = new Size(75, 23);
            BtnPapel.TabIndex = 3;
            BtnPapel.Text = "papel";
            BtnPapel.UseVisualStyleBackColor = true;
            BtnPapel.Click += BtnPapel_Click;
            // 
            // BtnTijera
            // 
            BtnTijera.Location = new Point(174, 42);
            BtnTijera.Name = "BtnTijera";
            BtnTijera.Size = new Size(75, 23);
            BtnTijera.TabIndex = 4;
            BtnTijera.Text = "tijera";
            BtnTijera.UseVisualStyleBackColor = true;
            BtnTijera.Click += BtnTijera_Click;
            // 
            // LblGanador
            // 
            LblGanador.AutoSize = true;
            LblGanador.Location = new Point(12, 119);
            LblGanador.Name = "LblGanador";
            LblGanador.Size = new Size(52, 15);
            LblGanador.TabIndex = 5;
            LblGanador.Text = "Ganador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 146);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 6;
            label1.Text = "Rondas: ";
            // 
            // LblRondas
            // 
            LblRondas.AutoSize = true;
            LblRondas.Location = new Point(74, 146);
            LblRondas.Name = "LblRondas";
            LblRondas.Size = new Size(13, 15);
            LblRondas.TabIndex = 7;
            LblRondas.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 176);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 8;
            label2.Text = "Victorias Jugador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 176);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 9;
            label3.Text = "Victorias CPU";
            // 
            // LblVictoriasJugador
            // 
            LblVictoriasJugador.AutoSize = true;
            LblVictoriasJugador.Location = new Point(38, 203);
            LblVictoriasJugador.Name = "LblVictoriasJugador";
            LblVictoriasJugador.Size = new Size(13, 15);
            LblVictoriasJugador.TabIndex = 10;
            LblVictoriasJugador.Text = "0";
            // 
            // LblVictoriasCPU
            // 
            LblVictoriasCPU.AutoSize = true;
            LblVictoriasCPU.Location = new Point(164, 203);
            LblVictoriasCPU.Name = "LblVictoriasCPU";
            LblVictoriasCPU.Size = new Size(13, 15);
            LblVictoriasCPU.TabIndex = 11;
            LblVictoriasCPU.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 241);
            Controls.Add(LblVictoriasCPU);
            Controls.Add(LblVictoriasJugador);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LblRondas);
            Controls.Add(label1);
            Controls.Add(LblGanador);
            Controls.Add(BtnTijera);
            Controls.Add(BtnPapel);
            Controls.Add(BtnPiedra);
            Controls.Add(LblCPU);
            Controls.Add(LblJugador);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblJugador;
        private Label LblCPU;
        private Button BtnPiedra;
        private Button BtnPapel;
        private Button BtnTijera;
        public Label LblGanador;
        private Label label1;
        private Label LblRondas;
        private Label label2;
        private Label label3;
        private Label LblVictoriasJugador;
        private Label LblVictoriasCPU;
    }
}
