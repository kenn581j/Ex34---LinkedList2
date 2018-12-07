using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ex32_linkedlist
{
    public class ClubMember
    {
        private int nr;
        private string fNavn;
        private string lNavn;
        private int alder;

        public int Nr
        {
            get => nr;
            set { nr = value; }
        }
        public string FNavn
        {
            get => fNavn;
            set { fNavn = value; }
        }
        public string LNavn
        {
            get => lNavn;
            set { lNavn = value; }
        }
        public int Alder
        {
            get => alder;
            set { alder = value; }
        }

        public ClubMember(int nr, string fNavn, string lNavn, int alder)
        {

            Nr = nr;
            FNavn = fNavn;
            LNavn = lNavn;
            Alder = alder;

        }

        public override string ToString()
        {
            return Nr + " " + FNavn + " " + LNavn + " " + Alder;
        }
    }
    

}
