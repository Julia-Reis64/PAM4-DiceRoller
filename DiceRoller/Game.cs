using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Game{
        public int VitoriaSequencia { get; private set; }
        public int TotalVitorias { get; private set; }
        public int UltimaSomaDosDados { get; private set; }

        public Game()
        {
            VitoriaSequencia = 0;
            TotalVitorias = 0;
            UltimaSomaDosDados = 0;
        }

        public bool CheckResult(int dado1, int dado2, int escolha)
        {
            UltimaSomaDosDados = dado1 + dado2;

            if (UltimaSomaDosDados == escolha)
            {
                TotalVitorias++;
                VitoriaSequencia++;
                return true;
            }
            else
            {
                VitoriaSequencia = 0;
                return false;
            }
        }

    }
}
