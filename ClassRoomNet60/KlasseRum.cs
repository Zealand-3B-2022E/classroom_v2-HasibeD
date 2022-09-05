using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class KlasseRum
    {
        private string _KlasseNavn;

        public string klasseNavn
        {
            get { return klasseNavn; }
            set { klasseNavn = value; }

        }



        private List<Studerende> _KlasseListe;

        public List<Studerende> KlasseListe
        {
            get { return _KlasseListe; }
            set { _KlasseListe = value; }
        }



        private DateOnly _SemesterStart;

        public DateOnly semesterStart
        {
            get { return _SemesterStart; }
            set { _SemesterStart = value; }
        }


        public KlasseRum()
        {

        }








    }

    


}
