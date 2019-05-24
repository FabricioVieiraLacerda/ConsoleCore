using System;
using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return Environment.NewLine + "Maradona estas pateando";
        }

        public string Corre()
        {
            return Environment.NewLine + "Maradona estas corriendo";
        }

        public string Passe()
        {
            return Environment.NewLine + "Maradona estas passando";
        }
    }
}