using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capolavoro
{
    internal class Giocatore
    {
        private string _punti;
        private string _assist;
        private string _rimabalziOffensivi;
        private string _rimabalziDifensivi;
        private string _palleRubate;
        private string _pallePerse;
        private string _tiritentati2;
        private string _tiritentati3;
        private string _tiritotali;
        private string _tirisegnati;
        private string _tiriliberitentati;
        private string _tiriliberiseganti;
        private string _fallifatti;

        public string Punti
        {
            get => _punti;
            set => _punti = value;
        }

        public string Assist
        {
            get => _assist;
            set => _assist = value;
        }

        public string RimbalziOffensivi
        {
            get => _rimabalziOffensivi;
            set => _rimabalziOffensivi = value;
        }

        public string RimbalziDifensivi
        {
            get => _rimabalziDifensivi;
            set => _rimabalziDifensivi = value;
        }

        public string PalleRubate
        {
            get => _palleRubate;
            set => _palleRubate = value;
        }

        public string PallePerse
        {
            get => _pallePerse;
            set => _pallePerse = value;
        }

        public string TirTentati2
        {
            get => _tiritentati2;
            set => _tiritentati2 = value;
        }

        public string TiriTentati3
        {
            get => _tiritentati3;
            set => _tiritentati3 = value;
        }

        public string TiriTotali
        {
            get => _tiritotali;
            set => _tiritotali = value;
        }

        public string TiriSegnati
        {
            get => _tirisegnati;
            set => _tirisegnati = value;
        }

        public string TiriLiberiTentati
        {
            get => _tiriliberitentati;
            set => _tiriliberitentati = value;
        }

        public string TiriLiberiSegnati
        {
            get => _tiriliberiseganti;
            set => _tiriliberiseganti = value;
        }

        public string FalliFatti
        {
            get => _fallifatti;
            set => _fallifatti = value;
        }

        public Giocatore()
        {
            Punti = "";
            Assist = "";
            RimbalziOffensivi = "";
            RimbalziDifensivi = "";
            PalleRubate = "";
            PallePerse = "";
            TirTentati2 = "";
            TiriTentati3 = "";
            TiriTotali = "";
            TiriSegnati = "";
            TiriLiberiTentati = "";
            TiriLiberiSegnati = "";
            FalliFatti = "";
        }

        public Giocatore(string punti, string assist, string rimbalziOffensivi, string rimbalziDifensivi, string palleRubate, string pallePerse, string tiriTentati2, string tiriTentati3, string tiriTotali, string tiriSegnati, string tiriLiberiTentati, string tiriLiberiSegnati, string falliSubiti)
        {
            Punti = punti;
            Assist = assist;
            RimbalziOffensivi = rimbalziOffensivi;
            RimbalziDifensivi = rimbalziDifensivi;
            PalleRubate = palleRubate;
            PallePerse = pallePerse;
            TirTentati2 = tiriTentati2;
            TiriTentati3 = tiriTentati3;
            TiriTotali = tiriTotali;
            TiriSegnati = tiriSegnati;
            TiriLiberiTentati = tiriLiberiTentati;
            TiriLiberiSegnati = tiriLiberiSegnati;
            FalliFatti = falliSubiti;
        }

    }
}
