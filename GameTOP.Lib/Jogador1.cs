using System;
using GameTOP.Interface;

namespace GameTOP.Lib
{
     public class Jogador1 : iJogador
    {
        public readonly String _Nome;

        public Jogador1()
        {
            _Nome = "Ronaldo";            
        }

        public string Chuta()
        {
            return Environment.NewLine + $"{_Nome} está Chutando";
        }

        public string Corre()
        {
            return Environment.NewLine +  $"{_Nome} está Correndo";
        }

        public string Passe()
        {
            return Environment.NewLine +  $"{_Nome} está Passando";
        }
        
    }

}