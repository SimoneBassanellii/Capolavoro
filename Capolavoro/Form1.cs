﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using System.Windows.Forms.DataVisualization.Charting;

namespace Capolavoro
{
    public partial class Duepunti : Form
    {
        private List<Giocatore> listaGiocatori = new List<Giocatore>();

        public Duepunti()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelpanel.Visible = false;
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
        private void btnbutton2_Click(object sender, EventArgs e)
        {
            DiminuisciValoreTiriDue();
            CalcoloTiriTot(StatTiriDue, StatTiriTre);
        }

        private void btnbutton1_Click_1(object sender, EventArgs e)
        {
            AumentaValoreTiriDue();
            CalcoloTiriTot(StatTiriDue, StatTiriTre);
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

        private void btnMenoTiriTre_Click(object sender, EventArgs e)
        {
            DiminuisciValoreTiriTre();
            CalcoloTiriTot(StatTiriDue, StatTiriTre);
        }

        private void btnPiuTiriTre_Click(object sender, EventArgs e)
        {
            AumentaValoreTiriTre();
            CalcoloTiriTot(StatTiriDue, StatTiriTre);
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

        #region Tirati

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

        #region Segnati

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

        #region Calcolo tiri totali  
        private void CalcoloTiriTot(Label StatTiriDue, Label StatTiriTre)
        {
            int valoreStatTiriDue = int.Parse(StatTiriDue.Text);
            int valoreStatTiriTre = int.Parse(StatTiriTre.Text);

            int TiriTotale = valoreStatTiriDue + valoreStatTiriTre;

            StatTiriTotali.Text = TiriTotale.ToString();
        }

        #endregion

        #endregion

        #region Palle

        #region Rubate
        private void MenoPalleRubate_Click(object sender, EventArgs e)
        {
            DiminuisciValorePL();
        }

        private void PiùPalleRubate_Click(object sender, EventArgs e)
        {
            AumentaValorePL();
        }

        private void AumentaValorePL()
        {
            // Controlla se il testo nel label può essere convertito in un numero intero
            if (int.TryParse(StatPalleRubate.Text, out int valoreAttuale))
            {
                // Aumenta il valore del label di 1
                valoreAttuale++;

                // Aggiorna il testo del label con il nuovo valore
                StatPalleRubate.Text = valoreAttuale.ToString();
            }
        }

        private void DiminuisciValorePL()
        {
            // Controlla se il testo nel label può essere convertito in un numero intero
            if (int.TryParse(StatPalleRubate.Text, out int valoreAttuale))
            {
                // Aumenta il valore del label di 1
                valoreAttuale--;

                // Aggiorna il testo del label con il nuovo valore
                StatPalleRubate.Text = valoreAttuale.ToString();
            }
        }
        #endregion

        #region Perse
        private void MenoPallePerse_Click(object sender, EventArgs e)
        {
            DiminuisciValorePP();
        }

        private void PiùPallePerse_Click(object sender, EventArgs e)
        {
            AumentaValorePP();
        }
        private void DiminuisciValorePP()
        {
            // Controlla se il testo nel label può essere convertito in un numero intero
            if (int.TryParse(StatPallePerse.Text, out int valoreAttuale))
            {
                // Aumenta il valore del label di 1
                valoreAttuale--;

                // Aggiorna il testo del label con il nuovo valore
                StatPallePerse.Text = valoreAttuale.ToString();
            }
        }

        private void AumentaValorePP()
        {
            // Controlla se il testo nel label può essere convertito in un numero intero
            if (int.TryParse(StatPallePerse.Text, out int valoreAttuale))
            {
                // Aumenta il valore del label di 1
                valoreAttuale++;

                // Aggiorna il testo del label con il nuovo valore
                StatPallePerse.Text = valoreAttuale.ToString();
            }
        }
        #endregion

        #endregion

        #region Falli
        private void MenoFalli_Click(object sender, EventArgs e)
        {
            DiminuisciValoreF();
        }

        private void PiuFalli_Click(object sender, EventArgs e)
        {
            AumentaValoreF();
        }

        private void DiminuisciValoreF()
        {
            // Controlla se il testo nel label può essere convertito in un numero intero
            if (int.TryParse(StatFalli.Text, out int valoreAttuale))
            {
                // Aumenta il valore del label di 1
                valoreAttuale--;

                // Aggiorna il testo del label con il nuovo valore
                StatFalli.Text = valoreAttuale.ToString();
            }
        }

        private void AumentaValoreF()
        {
            // Controlla se il testo nel label può essere convertito in un numero intero
            if (int.TryParse(StatFalli.Text, out int valoreAttuale))
            {
                // Aumenta il valore del label di 1
                valoreAttuale++;

                // Aggiorna il testo del label con il nuovo valore
                StatFalli.Text = valoreAttuale.ToString();
            }
        }
        #endregion

        #region Serializzazione partite 
        private void btnSalvaPartita_Click(object sender, EventArgs e)
        {
            Giocatore giocatore = new Giocatore(StatPunti.Text, StatAssist.Text, StatRimbalziOff.Text, StatRimbalziDiff.Text, StatPalleRubate.Text, StatPallePerse.Text, StatTiriDue.Text, StatTiriTre.Text, StatTiriTotali.Text, StatTiriSegnati.Text, StatLiberiTotali.Text, StatLiberiSegnati.Text, StatFalli.Text);
            listaGiocatori.Add(giocatore);
        }

        private void Serializza_Click(object sender, EventArgs e)
        {
            // Leggi i valori dalle label
            string statPunti = StatPunti.Text;
            string statAssist = StatAssist.Text;
            string statRimbalziOff = StatRimbalziOff.Text;
            string statRimbalziDiff = StatRimbalziDiff.Text;
            string statPalleRubate = StatPalleRubate.Text;
            string statPallePerse = StatPallePerse.Text;
            string statTiriDue = StatTiriDue.Text;
            string statTiriTre = StatTiriTre.Text;
            string statTiriTotali = StatTiriTotali.Text;
            string statTiriSegnati = StatTiriSegnati.Text;
            string statLiberiTotali = StatLiberiTotali.Text;
            string statLiberiSegnati = StatLiberiSegnati.Text;
            string statFalli = StatFalli.Text;

            // Crea un nuovo giocatore e aggiungilo alla lista
            Giocatore giocatore = new Giocatore(statPunti, statAssist, statRimbalziOff, statRimbalziDiff, statPalleRubate, statPallePerse, statTiriDue, statTiriTre, statTiriTotali, statTiriSegnati, statLiberiTotali, statLiberiSegnati, statFalli);
            listaGiocatori.Add(giocatore);

            // Serializza la lista in un file JSON
            string timeStamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            string fileName = $"giocatori_{timeStamp}.json";
            string json = JsonConvert.SerializeObject(listaGiocatori, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(fileName, json);

            MessageBox.Show($"Lista di giocatori serializzata in {fileName}");
        }

        #endregion

        #region Grafica
        private void grafico_Click(object sender, EventArgs e)
        {
            panelpanel.Visible= true;  
        }

        private void statistische_Click(object sender, EventArgs e)
        {
            panelpanel.Visible = false;
        }

        #endregion

        #region Data visualization

        private void caricafile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "File JSON (*.json)|*.json|Tutti i file (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                MessageBox.Show(openFileDialog1.FileName);
            }
            
            void DeserializzaFile(string fileName)
            {
                string json = File.ReadAllText(fileName);

                listaGiocatori = JsonConvert.DeserializeObject<List<Giocatore>>(json);
            }

            DeserializzaFile(openFileDialog1.FileName);
            AggiungiDatiAlGrafico();
        }

        private void AggiungiDatiAlGrafico()
        {
            chartStat.Series.Clear();

            // Crea una serie per ogni proprietà dell'oggetto Giocatore
            var seriePunti = new Series("Punti");
            seriePunti.ChartType = SeriesChartType.Line;
            var serieAssist = new Series("Assist");
            serieAssist.ChartType = SeriesChartType.Line;
            var serieRimbalziOff = new Series("Rimbalzi offensivi");
            serieRimbalziOff.ChartType = SeriesChartType.Line;
            var serieRimbalziDiff = new Series("Rimbalzi diffensivi");
            serieRimbalziDiff.ChartType = SeriesChartType.Line;
            var seriePalleRubate = new Series("Palle rubate");
            seriePalleRubate.ChartType = SeriesChartType.Line;
            var seriePallePerse = new Series("Palle perse");
            seriePallePerse.ChartType = SeriesChartType.Line;
            var serieTiriDue = new Series("Tiri due");
            serieTiriDue.ChartType = SeriesChartType.Line;
            var serieTiriTre = new Series("Tiri tre");
            serieTiriTre.ChartType = SeriesChartType.Line;
            var serieTiriTotali = new Series("Tiri totali");
            serieTiriTotali.ChartType = SeriesChartType.Line;
            var serieTiriSegnati = new Series("Tiri segnati");
            serieTiriSegnati.ChartType = SeriesChartType.Line;
            var serieLiberiTotali = new Series("Liberi totali");
            serieLiberiTotali.ChartType = SeriesChartType.Line;
            var serieLiberiSegnati = new Series("Liberi segnati");
            serieLiberiSegnati.ChartType = SeriesChartType.Line;
            var serieFalli = new Series("Falli fatti");
            serieFalli.ChartType = SeriesChartType.Line;


            foreach (var giocatore in listaGiocatori)
            {
                seriePunti.Points.Add(int.Parse(giocatore.Punti));
                serieAssist.Points.Add(int.Parse(giocatore.Assist));
                serieRimbalziOff.Points.Add(int.Parse(giocatore.RimbalziOffensivi));
                serieRimbalziDiff.Points.Add(int.Parse(giocatore.RimbalziDifensivi));
                seriePalleRubate.Points.Add(int.Parse(giocatore.PalleRubate));
                seriePallePerse.Points.Add(int.Parse(giocatore.PallePerse));
                serieTiriDue.Points.Add(int.Parse(giocatore.TirTentati2));
                serieTiriTre.Points.Add(int.Parse(giocatore.TiriTentati3));
                serieTiriTotali.Points.Add(int.Parse(giocatore.TiriTotali));
                serieTiriSegnati.Points.Add(int.Parse(giocatore.TiriSegnati));
                serieLiberiTotali.Points.Add(int.Parse(giocatore.TiriLiberiTentati));
                serieLiberiSegnati.Points.Add(int.Parse(giocatore.TiriLiberiSegnati));
                serieFalli.Points.Add(int.Parse(giocatore.FalliFatti));
                
            }

            chartStat.Series.Add(seriePunti);
            chartStat.Series.Add(serieAssist);
            chartStat.Series.Add(serieRimbalziOff);
            chartStat.Series.Add(serieRimbalziDiff);
            chartStat.Series.Add(seriePalleRubate);
            chartStat.Series.Add(seriePallePerse);
            chartStat.Series.Add(serieTiriDue);
            chartStat.Series.Add(serieTiriTre);
            chartStat.Series.Add(serieTiriTotali);
            chartStat.Series.Add(serieTiriSegnati);
            chartStat.Series.Add(serieLiberiTotali);
            chartStat.Series.Add(serieLiberiSegnati);
            chartStat.Series.Add(serieFalli);        
        }
        #endregion
        /*Aggiungere pacchetto da Nuget per serializzazione Newtonsoft.Json, aggiungere riferimenti per visualizzazione grafico andando su riferimenti tasto destro aggiungi riferimenti 
         e cercare spuntarli entrambi*/
    }



}