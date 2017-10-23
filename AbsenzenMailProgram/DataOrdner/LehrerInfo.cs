using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenzenMailProgram.DataOrdner
{
    public class LehrerInfo
    {
        public List<string> Lehrer = new List<string>();

        private List<string> Mails = new List<string>();

        public string Fach; //Name des Fachs

        public string Fach_ForData = null;  //Name des Fachs in einem Format, das in xml-dateien gespeichert werden kann (wenn nötig, sonst null)
       

        public LehrerInfo(string Schulfach)
        {
            Fach = Schulfach;
        }


        public void Add(string Teacher, string Mail)
        {
            Lehrer.Add(Teacher);
            Mails.Add(Mail);
        }

        
    }//End class LehrerInfo
}
