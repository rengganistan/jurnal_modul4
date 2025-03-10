using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurnalModul4_2311104065.Bagian_E
{
    public class PosisiKarakterGame
    {
        public enum State { Berdiri, Jongkok, Terbang, Tengkurap }
        private State currentState;

        public PosisiKarakterGame()
        {
            currentState = State.Berdiri;
        }

        public void TombolS()
        {
            if (currentState == State.Berdiri)
            {
                currentState = State.Jongkok;
                Console.WriteLine("tombol arah bawah ditekan");
            }
        }

        public void TombolW()
        {
            if (currentState == State.Jongkok)
            {
                currentState = State.Berdiri;
                Console.WriteLine("tombol arah atas ditekan");
            }
        }
    }
}


