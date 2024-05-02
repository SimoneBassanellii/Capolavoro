namespace Capolavoro
{
    partial class Duepunti
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Punti = new System.Windows.Forms.Label();
            this.Assist = new System.Windows.Forms.Label();
            this.Rimbalzi = new System.Windows.Forms.Label();
            this.PalleRubate = new System.Windows.Forms.Label();
            this.PallePerse = new System.Windows.Forms.Label();
            this.TiriTentati = new System.Windows.Forms.Label();
            this.TiriSegnati = new System.Windows.Forms.Label();
            this.NFalli = new System.Windows.Forms.Label();
            this.StatPunti = new System.Windows.Forms.Label();
            this.PiuPuntiII = new System.Windows.Forms.Button();
            this.PiuPuntiIII = new System.Windows.Forms.Button();
            this.PiuPuntiI = new System.Windows.Forms.Button();
            this.MenopuntiI = new System.Windows.Forms.Button();
            this.StatAssist = new System.Windows.Forms.Label();
            this.MenoAssist = new System.Windows.Forms.Button();
            this.PiuAssist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Punti
            // 
            this.Punti.AutoSize = true;
            this.Punti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Punti.Location = new System.Drawing.Point(81, 42);
            this.Punti.Name = "Punti";
            this.Punti.Size = new System.Drawing.Size(56, 25);
            this.Punti.TabIndex = 0;
            this.Punti.Text = "Punti";
            // 
            // Assist
            // 
            this.Assist.AutoSize = true;
            this.Assist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assist.Location = new System.Drawing.Point(81, 79);
            this.Assist.Name = "Assist";
            this.Assist.Size = new System.Drawing.Size(65, 25);
            this.Assist.TabIndex = 1;
            this.Assist.Text = "Assist";
            // 
            // Rimbalzi
            // 
            this.Rimbalzi.AutoSize = true;
            this.Rimbalzi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rimbalzi.Location = new System.Drawing.Point(81, 120);
            this.Rimbalzi.Name = "Rimbalzi";
            this.Rimbalzi.Size = new System.Drawing.Size(85, 25);
            this.Rimbalzi.TabIndex = 2;
            this.Rimbalzi.Text = "Rimbalzi";
            // 
            // PalleRubate
            // 
            this.PalleRubate.AutoSize = true;
            this.PalleRubate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PalleRubate.Location = new System.Drawing.Point(70, 205);
            this.PalleRubate.Name = "PalleRubate";
            this.PalleRubate.Size = new System.Drawing.Size(115, 25);
            this.PalleRubate.TabIndex = 3;
            this.PalleRubate.Text = "Palle rubate";
            // 
            // PallePerse
            // 
            this.PallePerse.AutoSize = true;
            this.PallePerse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PallePerse.Location = new System.Drawing.Point(70, 240);
            this.PallePerse.Name = "PallePerse";
            this.PallePerse.Size = new System.Drawing.Size(109, 25);
            this.PallePerse.TabIndex = 4;
            this.PallePerse.Text = "Palle perse";
            // 
            // TiriTentati
            // 
            this.TiriTentati.AutoSize = true;
            this.TiriTentati.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TiriTentati.Location = new System.Drawing.Point(415, 235);
            this.TiriTentati.Name = "TiriTentati";
            this.TiriTentati.Size = new System.Drawing.Size(96, 25);
            this.TiriTentati.TabIndex = 5;
            this.TiriTentati.Text = "Tiri tentati";
            // 
            // TiriSegnati
            // 
            this.TiriSegnati.AutoSize = true;
            this.TiriSegnati.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TiriSegnati.Location = new System.Drawing.Point(415, 269);
            this.TiriSegnati.Name = "TiriSegnati";
            this.TiriSegnati.Size = new System.Drawing.Size(107, 25);
            this.TiriSegnati.TabIndex = 6;
            this.TiriSegnati.Text = "Tiri segnati";
            this.TiriSegnati.Click += new System.EventHandler(this.TiriSegnati_Click);
            // 
            // NFalli
            // 
            this.NFalli.AutoSize = true;
            this.NFalli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NFalli.Location = new System.Drawing.Point(72, 327);
            this.NFalli.Name = "NFalli";
            this.NFalli.Size = new System.Drawing.Size(140, 25);
            this.NFalli.TabIndex = 7;
            this.NFalli.Text = "Falli commessi";
            this.NFalli.Click += new System.EventHandler(this.NFalli_Click);
            // 
            // StatPunti
            // 
            this.StatPunti.AutoSize = true;
            this.StatPunti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatPunti.Location = new System.Drawing.Point(185, 42);
            this.StatPunti.Name = "StatPunti";
            this.StatPunti.Size = new System.Drawing.Size(23, 25);
            this.StatPunti.TabIndex = 9;
            this.StatPunti.Text = "0";
            // 
            // PiuPuntiII
            // 
            this.PiuPuntiII.Location = new System.Drawing.Point(248, 40);
            this.PiuPuntiII.Name = "PiuPuntiII";
            this.PiuPuntiII.Size = new System.Drawing.Size(28, 27);
            this.PiuPuntiII.TabIndex = 10;
            this.PiuPuntiII.Text = "+2";
            this.PiuPuntiII.UseVisualStyleBackColor = true;
            this.PiuPuntiII.Click += new System.EventHandler(this.PiuPuntiII_Click);
            // 
            // PiuPuntiIII
            // 
            this.PiuPuntiIII.Location = new System.Drawing.Point(282, 40);
            this.PiuPuntiIII.Name = "PiuPuntiIII";
            this.PiuPuntiIII.Size = new System.Drawing.Size(28, 27);
            this.PiuPuntiIII.TabIndex = 11;
            this.PiuPuntiIII.Text = "+3";
            this.PiuPuntiIII.UseVisualStyleBackColor = true;
            this.PiuPuntiIII.Click += new System.EventHandler(this.PiuPuntiIII_Click);
            // 
            // PiuPuntiI
            // 
            this.PiuPuntiI.Location = new System.Drawing.Point(214, 40);
            this.PiuPuntiI.Name = "PiuPuntiI";
            this.PiuPuntiI.Size = new System.Drawing.Size(28, 27);
            this.PiuPuntiI.TabIndex = 12;
            this.PiuPuntiI.Text = "+1";
            this.PiuPuntiI.UseVisualStyleBackColor = true;
            this.PiuPuntiI.Click += new System.EventHandler(this.PiuPuntiI_Click);
            // 
            // MenopuntiI
            // 
            this.MenopuntiI.Location = new System.Drawing.Point(152, 42);
            this.MenopuntiI.Name = "MenopuntiI";
            this.MenopuntiI.Size = new System.Drawing.Size(27, 25);
            this.MenopuntiI.TabIndex = 13;
            this.MenopuntiI.Text = "-1";
            this.MenopuntiI.UseVisualStyleBackColor = true;
            this.MenopuntiI.Click += new System.EventHandler(this.MenopuntiI_Click);
            // 
            // StatAssist
            // 
            this.StatAssist.AutoSize = true;
            this.StatAssist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatAssist.Location = new System.Drawing.Point(185, 79);
            this.StatAssist.Name = "StatAssist";
            this.StatAssist.Size = new System.Drawing.Size(23, 25);
            this.StatAssist.TabIndex = 14;
            this.StatAssist.Text = "0";
            this.StatAssist.Click += new System.EventHandler(this.StatAssist_Click);
            // 
            // MenoAssist
            // 
            this.MenoAssist.Location = new System.Drawing.Point(152, 79);
            this.MenoAssist.Name = "MenoAssist";
            this.MenoAssist.Size = new System.Drawing.Size(27, 25);
            this.MenoAssist.TabIndex = 15;
            this.MenoAssist.Text = "-1";
            this.MenoAssist.UseVisualStyleBackColor = true;
            this.MenoAssist.Click += new System.EventHandler(this.MenoAssist_Click);
            // 
            // PiuAssist
            // 
            this.PiuAssist.Location = new System.Drawing.Point(214, 79);
            this.PiuAssist.Name = "PiuAssist";
            this.PiuAssist.Size = new System.Drawing.Size(28, 27);
            this.PiuAssist.TabIndex = 16;
            this.PiuAssist.Text = "+1";
            this.PiuAssist.UseVisualStyleBackColor = true;
            this.PiuAssist.Click += new System.EventHandler(this.PiuAssist_Click);
            // 
            // Duepunti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PiuAssist);
            this.Controls.Add(this.MenoAssist);
            this.Controls.Add(this.StatAssist);
            this.Controls.Add(this.MenopuntiI);
            this.Controls.Add(this.PiuPuntiI);
            this.Controls.Add(this.PiuPuntiIII);
            this.Controls.Add(this.PiuPuntiII);
            this.Controls.Add(this.StatPunti);
            this.Controls.Add(this.NFalli);
            this.Controls.Add(this.TiriSegnati);
            this.Controls.Add(this.TiriTentati);
            this.Controls.Add(this.PallePerse);
            this.Controls.Add(this.PalleRubate);
            this.Controls.Add(this.Rimbalzi);
            this.Controls.Add(this.Assist);
            this.Controls.Add(this.Punti);
            this.Name = "Duepunti";
            this.Text = "Statistiche ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Punti;
        private System.Windows.Forms.Label Assist;
        private System.Windows.Forms.Label Rimbalzi;
        private System.Windows.Forms.Label PalleRubate;
        private System.Windows.Forms.Label PallePerse;
        private System.Windows.Forms.Label TiriTentati;
        private System.Windows.Forms.Label TiriSegnati;
        private System.Windows.Forms.Label NFalli;
        private System.Windows.Forms.Label StatPunti;
        private System.Windows.Forms.Button PiuPuntiII;
        private System.Windows.Forms.Button PiuPuntiIII;
        private System.Windows.Forms.Button PiuPuntiI;
        private System.Windows.Forms.Button MenopuntiI;
        private System.Windows.Forms.Label StatAssist;
        private System.Windows.Forms.Button MenoAssist;
        private System.Windows.Forms.Button PiuAssist;
    }
}

