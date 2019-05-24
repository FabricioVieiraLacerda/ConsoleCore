using System;
using GameTOP.Interface;

namespace GameTOP
{
    public  class JogoFODA{
        private readonly iJogador _jogadorA;

        private readonly iJogador _jogadorB;

        public JogoFODA(iJogador jogador1, iJogador jogador2)
        {
            _jogadorA = jogador1;
            _jogadorB = jogador2;
        }

        public void IniciarJogo()
        {
            //System.Console.Write($"{_jogador._Nome} 1 deu um passe!");
            
            Console.Write( Environment.NewLine + "Primeiro Jogador:");
            Console.Write(_jogadorA.Corre());
            Console.Write(_jogadorA.Chuta());
            Console.Write(_jogadorA.Passe());

            Console.Write( Environment.NewLine +  Environment.NewLine + "Próximo Jogador:");
            Console.Write(_jogadorB.Corre());
            Console.Write(_jogadorB.Chuta());
            Console.Write(_jogadorB.Passe());
            
            Console.Write( Environment.NewLine );
        }
    }
}