using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capolavoro
{
    public partial class Duepunti : Form
    {
        public Duepunti()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        #region Punti
        private void MenopuntiI_Click(object sender, EventArgs e)
        {
            DiminuisciValoreLabel();
        }

        private void PiuPuntiI_Click(object sender, EventArgs e)
        {
            AumentaValoreLabel();
        }

        private void PiuPuntiII_Click(object sender, EventArgs e)
        {
            AumentaValore2Label();
        }

        private void PiuPuntiIII_Click(object sender, EventArgs e)
        {
            AumentaValore3Label();
        }

        private void AumentaValoreLabel()
        {
            // Controlla se il testo nel label può essere convertito in un numero intero
            if (int.TryParse(StatPunti.Text, out int valoreAttuale))
            {
                // Aumenta il valore del label di 1
                valoreAttuale++;

                // Aggiorna il testo del label con il nuovo valore
                StatPunti.Text = valoreAttuale.ToString();
            }
        }

        private void AumentaValore2Label()
        {
            // Controlla se il testo nel label può essere convertito in un numero intero
            if (int.TryParse(StatPunti.Text, out int valoreAttuale))
            {
                // Aumenta il valore del label di 1
                valoreAttuale += 2;
                 
                // Aggiorna il testo del label con il nuovo valore
                StatPunti.Text = valoreAttuale.ToString();
            }
        }

        private void AumentaValore3Label()
        {
            // Controlla se il testo nel label può essere convertito in un numero intero
            if (int.TryParse(StatPunti.Text, out int valoreAttuale))
            {
                // Aumenta il valore del label di 1
                valoreAttuale += 3;

                // Aggiorna il testo del label con il nuovo valore
                StatPunti.Text = valoreAttuale.ToString();
            }
        }

        private void DiminuisciValoreLabel()
        {
            // Controlla se il testo nel label può essere convertito in un numero intero
            if (int.TryParse(StatPunti.Text, out int valoreAttuale))
            {
                // Aumenta il valore del label di 1
                valoreAttuale--;

                // Aggiorna il testo del label con il nuovo valore
                StatPunti.Text = valoreAttuale.ToString();
            }
        }
        #endregion

        #region Assist
        private void MenoAssist_Click(object sender, EventArgs e)
        {
            DiminuisciValoreAssist();
        }

        private void PiuAssist_Click(object sender, EventArgs e)
        {
            AumentaValoreAssist();
        }

        private void StatAssist_Click(object sender, EventArgs e)
        {

        }

        private void AumentaValoreAssist()
        {
            // Controlla se il testo nel label può essere convertito in un numero intero
            if (int.TryParse(StatAssist.Text, out int valoreAttuale))
            {
                // Aumenta il valore del label di 1
                valoreAttuale++;

                // Aggiorna il testo del label con il nuovo valore
                StatAssist.Text = valoreAttuale.ToString();
            }
        }

        private void DiminuisciValoreAssist()
        {
            // Controlla se il testo nel label può essere convertito in un numero intero
            if (int.TryParse(StatAssist.Text, out int valoreAttuale))
            {
                // Aumenta il valore del label di 1
                valoreAttuale--;

                // Aggiorna il testo del label con il nuovo valore
                StatAssist.Text = valoreAttuale.ToString();
            }
        }
        #endregion


        private void TiriSegnati_Click(object sender, EventArgs e)
        {

        }

        private void NFalli_Click(object sender, EventArgs e)
        {

        }

        
    }
}
