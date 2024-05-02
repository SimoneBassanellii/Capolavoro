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

        #region Rimbalzi

        #region Offensivi 
        private void MenoRimbalzi_Click(object sender, EventArgs e)
        {
            DiminuisciValoreRimbalziOff();
        }

        private void PiuRimbalzi_Click(object sender, EventArgs e)
        {
            AumentaValoreRimbalziOff();
        }

        private void AumentaValoreRimbalziOff()
        {
            // Controlla se il testo nel label può essere convertito in un numero intero
            if (int.TryParse(StatRimbalziOff.Text, out int valoreAttuale))
            {
                // Aumenta il valore del label di 1
                valoreAttuale++;

                // Aggiorna il testo del label con il nuovo valore
                StatRimbalziOff.Text = valoreAttuale.ToString();
            }
        }

        private void DiminuisciValoreRimbalziOff()
        {
            // Controlla se il testo nel label può essere convertito in un numero intero
            if (int.TryParse(StatRimbalziOff.Text, out int valoreAttuale))
            {
                // Aumenta il valore del label di 1
                valoreAttuale--;

                // Aggiorna il testo del label con il nuovo valore
                StatRimbalziOff.Text = valoreAttuale.ToString();
            }
        }
        #endregion

        #region Difensivi
        private void MenoRimbalziDiff_Click(object sender, EventArgs e)
        {
            DiminuisciValoreRimbalziDiff();
        }

        private void PiuRimbalziDiff_Click(object sender, EventArgs e)
        {
            AumentaValoreRimbalziDiff();
        }

        private void AumentaValoreRimbalziDiff()
        {
            // Controlla se il testo nel label può essere convertito in un numero intero
            if (int.TryParse(StatRimbalziDiff.Text, out int valoreAttuale))
            {
                // Aumenta il valore del label di 1
                valoreAttuale++;

                // Aggiorna il testo del label con il nuovo valore
                StatRimbalziDiff.Text = valoreAttuale.ToString();
            }
        }

        private void DiminuisciValoreRimbalziDiff()
        {
            // Controlla se il testo nel label può essere convertito in un numero intero
            if (int.TryParse(StatRimbalziDiff.Text, out int valoreAttuale))
            {
                // Aumenta il valore del label di 1
                valoreAttuale--;

                // Aggiorna il testo del label con il nuovo valore
                StatRimbalziDiff.Text = valoreAttuale.ToString();
            }
        }
        #endregion

        #endregion

        #region Tiri

        #region Tiri dal campo

        #region Tiri da 2 
        private void button2_Click(object sender, EventArgs e)
        {
            DiminuisciValoreTiriDue();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AumentaValoreTiriDue();
        }

        private void AumentaValoreTiriDue()
        {
            // Controlla se il testo nel label può essere convertito in un numero intero
            if (int.TryParse(StatTiriDue.Text, out int valoreAttuale))
            {
                // Aumenta il valore del label di 1
                valoreAttuale++;

                // Aggiorna il testo del label con il nuovo valore
                StatTiriDue.Text = valoreAttuale.ToString();
            }
        }

        private void DiminuisciValoreTiriDue()
        {
            // Controlla se il testo nel label può essere convertito in un numero intero
            if (int.TryParse(StatTiriDue.Text, out int valoreAttuale))
            {
                // Aumenta il valore del label di 1
                valoreAttuale--;

                // Aggiorna il testo del label con il nuovo valore
                StatTiriDue.Text = valoreAttuale.ToString();
            }
        }
        #endregion

        #region Tiri da 3 

        private void MenoTiriTre_Click(object sender, EventArgs e)
        {
            DiminuisciValoreTiriTre();
        }

        private void PiuTiriTre_Click(object sender, EventArgs e)
        {
            AumentaValoreTiriTre();
        }

        private void AumentaValoreTiriTre()
        {
            // Controlla se il testo nel label può essere convertito in un numero intero
            if (int.TryParse(StatTiriTre.Text, out int valoreAttuale))
            {
                // Aumenta il valore del label di 1
                valoreAttuale++;

                // Aggiorna il testo del label con il nuovo valore
                StatTiriTre.Text = valoreAttuale.ToString();
            }
        }

        private void DiminuisciValoreTiriTre()
        {
            // Controlla se il testo nel label può essere convertito in un numero intero
            if (int.TryParse(StatTiriTre.Text, out int valoreAttuale))
            {
                // Aumenta il valore del label di 1
                valoreAttuale--;

                // Aggiorna il testo del label con il nuovo valore
                StatTiriTre.Text = valoreAttuale.ToString();
            }
        }
        #endregion

        #region Tiri segnati 

        private void MenoTiriTentati_Click(object sender, EventArgs e)
        {
            DiminuisciValoreTiriSegnati();
        }

        private void PiùTiriTentati_Click(object sender, EventArgs e)
        {
            AumentaValoreTiriSegnati();
        }

        private void DiminuisciValoreTiriSegnati()
        {
            // Controlla se il testo nel label può essere convertito in un numero intero
            if (int.TryParse(StatTiriSegnati.Text, out int valoreAttuale))
            {
                // Aumenta il valore del label di 1
                valoreAttuale--;

                // Aggiorna il testo del label con il nuovo valore
                StatTiriSegnati.Text = valoreAttuale.ToString();
            }
        }

        private void AumentaValoreTiriSegnati()
        {
            // Controlla se il testo nel label può essere convertito in un numero intero
            if (int.TryParse(StatTiriSegnati.Text, out int valoreAttuale))
            {
                // Aumenta il valore del label di 1
                valoreAttuale++;

                // Aggiorna il testo del label con il nuovo valore
                StatTiriSegnati.Text = valoreAttuale.ToString();
            }
        }

        #endregion

        #endregion

        #region Tiri lIberi

        #region Tiri Totali

        private void button8_Click(object sender, EventArgs e)
        {
            DiminuisciValoreTiriLiberiTotali();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AumentaValoreTiriLiberiTotali();
        }

        private void DiminuisciValoreTiriLiberiTotali()
        {
            // Controlla se il testo nel label può essere convertito in un numero intero
            if (int.TryParse(StatLiberiTotali.Text, out int valoreAttuale))
            {
                // Aumenta il valore del label di 1
                valoreAttuale--;

                // Aggiorna il testo del label con il nuovo valore
                StatLiberiTotali.Text = valoreAttuale.ToString();
            }
        }

        private void AumentaValoreTiriLiberiTotali()
        {
            // Controlla se il testo nel label può essere convertito in un numero intero
            if (int.TryParse(StatLiberiTotali.Text, out int valoreAttuale))
            {
                // Aumenta il valore del label di 1
                valoreAttuale++;

                // Aggiorna il testo del label con il nuovo valore
                StatLiberiTotali.Text = valoreAttuale.ToString();
            }
        }
        #endregion

        #region Tiri segnati

        private void PiuLiberiSegnati_Click(object sender, EventArgs e)
        {
            AumentaValoreTiriLiberiSegnati();
        }

        private void MenoLiberiSegnati_Click(object sender, EventArgs e)
        {
            DiminuisciValoreTiriLiberiSegnati();
        }

        private void DiminuisciValoreTiriLiberiSegnati()
        {
            // Controlla se il testo nel label può essere convertito in un numero intero
            if (int.TryParse(StatLiberiSegnati.Text, out int valoreAttuale))
            {
                // Aumenta il valore del label di 1
                valoreAttuale--;

                // Aggiorna il testo del label con il nuovo valore
                StatLiberiSegnati.Text = valoreAttuale.ToString();
            }
        }

        private void AumentaValoreTiriLiberiSegnati()
        {
            // Controlla se il testo nel label può essere convertito in un numero intero
            if (int.TryParse(StatLiberiSegnati.Text, out int valoreAttuale))
            {
                // Aumenta il valore del label di 1
                valoreAttuale++;

                // Aggiorna il testo del label con il nuovo valore
                StatLiberiSegnati.Text = valoreAttuale.ToString();
            }
        }
        #endregion

        #endregion

        #endregion

        private void TiriSegnati_Click(object sender, EventArgs e)
        {

        }

        private void NFalli_Click(object sender, EventArgs e)
        {

        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
