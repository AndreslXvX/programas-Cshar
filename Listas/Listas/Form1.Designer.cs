namespace Listas
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
            LblEleccionCPU = new Label();
            BtnPiedra = new Button();
            BtnPapel = new Button();
            BtnTijera = new Button();
            label2 = new Label();
            label3 = new Label();
            LblElije = new Label();
            LblPuntosJugador = new Label();
            LblPuntosCPU = new Label();
            label7 = new Label();
            label8 = new Label();
            label1 = new Label();
            LblRondas = new Label();
            LblEleccionJugador = new Label();
            LblResultado = new Label();
            SuspendLayout();
            // 
            // LblEleccionCPU
            // 
            LblEleccionCPU.AutoSize = true;
            LblEleccionCPU.Location = new Point(118, 115);
            LblEleccionCPU.Name = "LblEleccionCPU";
            LblEleccionCPU.Size = new Size(30, 15);
            LblEleccionCPU.TabIndex = 0;
            LblEleccionCPU.Text = "CPU";
            // 
            // BtnPiedra
            // 
            BtnPiedra.Location = new Point(12, 74);
            BtnPiedra.Name = "BtnPiedra";
            BtnPiedra.Size = new Size(75, 23);
            BtnPiedra.TabIndex = 1;
            BtnPiedra.Text = "Piedra";
            BtnPiedra.UseVisualStyleBackColor = true;
            BtnPiedra.Click += BtnPiedra_Click;
            // 
            // BtnPapel
            // 
            BtnPapel.Location = new Point(93, 74);
            BtnPapel.Name = "BtnPapel";
            BtnPapel.Size = new Size(75, 23);
            BtnPapel.TabIndex = 2;
            BtnPapel.Text = "Papel";
            BtnPapel.UseVisualStyleBackColor = true;
            BtnPapel.Click += BtnPapel_Click;
            // 
            // BtnTijera
            // 
            BtnTijera.Location = new Point(174, 74);
            BtnTijera.Name = "BtnTijera";
            BtnTijera.Size = new Size(75, 23);
            BtnTijera.TabIndex = 3;
            BtnTijera.Text = "Tijera";
            BtnTijera.UseVisualStyleBackColor = true;
            BtnTijera.Click += BtnTijera_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Tu Eleccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 100);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 5;
            label3.Text = "Eleccion de CPU";
            // 
            // LblElije
            // 
            LblElije.AutoSize = true;
            LblElije.Location = new Point(12, 56);
            LblElije.Name = "LblElije";
            LblElije.Size = new Size(91, 15);
            LblElije.TabIndex = 6;
            LblElije.Text = "Elije una opcion";
            // 
            // LblPuntosJugador
            // 
            LblPuntosJugador.AutoSize = true;
            LblPuntosJugador.Location = new Point(12, 150);
            LblPuntosJugador.Name = "LblPuntosJugador";
            LblPuntosJugador.Size = new Size(13, 15);
            LblPuntosJugador.TabIndex = 7;
            LblPuntosJugador.Text = "0";
            LblPuntosJugador.Click += LblPuntosJugador_Click;
            // 
            // LblPuntosCPU
            // 
            LblPuntosCPU.AutoSize = true;
            LblPuntosCPU.Location = new Point(135, 150);
            LblPuntosCPU.Name = "LblPuntosCPU";
            LblPuntosCPU.Size = new Size(13, 15);
            LblPuntosCPU.TabIndex = 8;
            LblPuntosCPU.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(75, 150);
            label7.Name = "label7";
            label7.Size = new Size(12, 15);
            label7.TabIndex = 9;
            label7.Text = "-";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(163, 30);
            label8.TabIndex = 10;
            label8.Text = "Juego de Piedra Papel Tijera :)\r\nGana el mejor de 3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 206);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 11;
            label1.Text = "Ronda:";
            // 
            // LblRondas
            // 
            LblRondas.AutoSize = true;
            LblRondas.Location = new Point(66, 206);
            LblRondas.Name = "LblRondas";
            LblRondas.Size = new Size(13, 15);
            LblRondas.TabIndex = 12;
            LblRondas.Text = "0";
            // 
            // LblEleccionJugador
            // 
            LblEleccionJugador.AutoSize = true;
            LblEleccionJugador.Location = new Point(16, 115);
            LblEleccionJugador.Name = "LblEleccionJugador";
            LblEleccionJugador.Size = new Size(49, 15);
            LblEleccionJugador.TabIndex = 13;
            LblEleccionJugador.Text = "Jugador";
            // 
            // LblResultado
            // 
            LblResultado.AutoSize = true;
            LblResultado.Location = new Point(12, 179);
            LblResultado.Name = "LblResultado";
            LblResultado.Size = new Size(59, 15);
            LblResultado.TabIndex = 14;
            LblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 390);
            Controls.Add(LblResultado);
            Controls.Add(LblEleccionJugador);
            Controls.Add(LblRondas);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(LblPuntosCPU);
            Controls.Add(LblPuntosJugador);
            Controls.Add(LblElije);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnTijera);
            Controls.Add(BtnPapel);
            Controls.Add(BtnPiedra);
            Controls.Add(LblEleccionCPU);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblEleccionCPU;
        private Button BtnPiedra;
        private Button BtnPapel;
        private Button BtnTijera;
        private Label label2;
        private Label label3;
        private Label LblElije;
        private Label LblPuntosJugador;
        private Label LblPuntosCPU;
        private Label label7;
        private Label label8;
        private Label label1;
        private Label LblRondas;
        private Label LblEleccionJugador;
        private Label LblResultado;
    }
}
