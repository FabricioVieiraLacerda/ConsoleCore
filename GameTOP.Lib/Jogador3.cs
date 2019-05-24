using System;
using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador3 : iJogador
    {
        string iJogador.Chuta()
        {
            return Environment.NewLine +  "teste Chuta";
        }

        string iJogador.Corre()
        {
            return Environment.NewLine +  "teste Corre";
        }

        string iJogador.Passe()
        {
            return Environment.NewLine +  "teste Passe";
        }
    }
}