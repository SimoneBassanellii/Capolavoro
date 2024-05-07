using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capolavoro
{
    internal class Giocatore
    {
        private int _punti;
        private int _assist;
        private int _rimabalziOffensivi;
        private int _rimabalziDifensivi;
        private int _palleRubate;
        private int _pallePerse;
        private int _tiritentati2;
        private int _tiritentati3;
        private int _tiritotali;
        private int _tirisegnati;
        private int _tiriliberitentati;
        private int _tiriliberiseganti;
        private int _fallisubiti;

        public int Punti
        {
            get => _punti;
            set => _punti = value;
        }

        public int Assist
        {
            get => _assist;
            set => _assist = value;
        }

        public int RimbalziOffensivi
        {
            get => _rimabalziOffensivi;
            set => _rimabalziOffensivi = value;
        }

        public int RimbalziDifensivi
        {
            get => _rimabalziDifensivi;
            set => _rimabalziDifensivi = value;
        }

        public int PalleRubate
        {
            get => _palleRubate;
            set => _palleRubate = value;
        }

        public int PallePerse
        {
            get => _pallePerse;
            set => _pallePerse = value;
        }

        public int TirTentati2
        {
            get => _tiritentati2;
            set => _tiritentati2 = value;
        }

        public int TiriTentati3
        {
            get => _tiritentati3;
            set => _tiritentati3 = value;
        }

        public int TiriTotali
        {
            get => _tiritotali;
            set => _tiritotali = value;
        }

        public int TiriSegnati
        {
            get => _tirisegnati;
            set => _tirisegnati = value;
        }

        public int TiriLiberiTentati
        {
            get => _tiriliberitentati;
            set => _tiriliberitentati = value;
        }

        public int TiriLiberiSegnati
        {
            get => _tiriliberiseganti;
            set => _tiriliberiseganti = value;
        }

        public int FalliSubiti
        {
            get => _fallisubiti;
            set => _fallisubiti = value;
        }

        public Giocatore()
        {
            Punti = 0;
            Assist = 0;
            RimbalziOffensivi = 0;
            RimbalziDifensivi = 0;
            PalleRubate = 0;
            PallePerse = 0;
            TirTentati2 = 0;
            TiriTentati3 = 0;
            TiriTotali = 0;
            TiriSegnati = 0;
            TiriLiberiTentati = 0;
            TiriLiberiSegnati = 0;
            FalliSubiti = 0;
        }

        public Giocatore(int punti, int assist, int rimbalziOffensivi, int rimbalziDifensivi, int palleRubate, int pallePerse, int tiriTentati2, int tiriTentati3, int tiriTotali, int tiriSegnati, int tiriLiberiTentati, int tiriLiberiSegnati, int falliSubiti)
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
            FalliSubiti = falliSubiti;
        }

    }
}
