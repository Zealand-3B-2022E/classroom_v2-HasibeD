using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Studerende
    {
         private string _navn;

        public string navn
        {
            get { return navn; }
            set { navn = value; }
        }


        private int _fødselsmåned;

        public string fødselsmåned
        {
            get { return fødselsmåned; }
            set { fødselsmåned = value; }
        }


        private int _fødselsdag;

        public string fødselsdag
        {
            get { return fødselsdag; }
            set { fødselsdag = value; }
        }


        public Studerende()
        {
             
        }

        public Studerende(string navn, int fødselsmåned, int fødselsdag)
        {
            _navn = navn;
            _fødselsmåned = fødselsmåned;
            _fødselsdag = fødselsdag;
        }

        public override string ToString()
        {
            return ();
        }

    }
}
