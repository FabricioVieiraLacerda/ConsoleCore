using System;
using GameTOP.Lib;

namespace GameTOP
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Hello World!" + Environment.NewLine);

            var jogo = new JogoFODA( new Jogador2(), new Jogador3());
            jogo.IniciarJogo();
        }
    } 
 
}
