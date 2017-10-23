using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace AbsenzenMailProgram
{
    class Data
    {
        //Liste, die alle Instances von LehrerInfo speichert
        private static List<DataOrdner.LehrerInfo> LehrerInfoListe = new List<DataOrdner.LehrerInfo>();

        //Alle Fächer deklarieren
        private static DataOrdner.LehrerInfo Deutsch;
        private static DataOrdner.LehrerInfo Englisch;
        private static DataOrdner.LehrerInfo Französisch;
        private static DataOrdner.LehrerInfo Sport;
        private static DataOrdner.LehrerInfo BG;
        private static DataOrdner.LehrerInfo Musik;
        private static DataOrdner.LehrerInfo ICT;
        private static DataOrdner.LehrerInfo Chemie;
        private static DataOrdner.LehrerInfo Physik;
        private static DataOrdner.LehrerInfo Math;
        private static DataOrdner.LehrerInfo Geo;
        private static DataOrdner.LehrerInfo Geschichte;
        private static DataOrdner.LehrerInfo Bio;
        private static DataOrdner.LehrerInfo Philo;
        private static DataOrdner.LehrerInfo PP;
        private static DataOrdner.LehrerInfo Religion;
        private static DataOrdner.LehrerInfo WR;

        public static void Init()   //Adds Data to every instance of "LehrerInfo"
        {
            //Deutschlehrer
            Deutsch = new DataOrdner.LehrerInfo("Deutsch");

            Deutsch.Add("Dietrich", "birgit.diedrich@gymhofwil.ch");
            Deutsch.Add("Gerber", "stephan.gerber@gymhofwil.ch");
            Deutsch.Add("Grädel", "jana.graedel@gymhofwil.ch");
            Deutsch.Add("Marraffino", "michele.marraffino@gymhofwil.ch");
            Deutsch.Add("Schäfer", "beatrice.schaefer@gymhofwil.ch");
            Deutsch.Add("Schmid", "lukas.schmid@gymhofwil.ch");

            LehrerInfoListe.Add(Deutsch);

            //Englischlehrer
            Englisch = new DataOrdner.LehrerInfo("Englisch");

            Englisch.Add("Gerber", "stephan.gerber@gymhofwil.ch");
            Englisch.Add("Huber", "andrea.huber@gymhofwil.ch");
            Englisch.Add("Lützen", "sabine.luetzen@gymhofwil.ch");
            Englisch.Add("Stockwell", "kim.stockwell@gymhofwil.ch");
            Englisch.Add("Zollinger", "kim.zollinger@gymhofwil.ch");

            LehrerInfoListe.Add(Englisch);

            //Französischlehrer
            Französisch = new DataOrdner.LehrerInfo("Französisch");

            Französisch.Add("Duvoisin", "eric.duvoisin@gymhofwil.ch");
            Französisch.Add("Granell", "margarida.granell@gymhofwil.ch");
            Französisch.Add("Rihs", "philip.rihs@gymhofwil.ch");
            Französisch.Add("Siksou", "deborah.siksou@gymhofwil.ch");
            Französisch.Add("Stolz", "zuzana.stolz@gymhofwil.ch");

            LehrerInfoListe.Add(Französisch);

            //Sportlehrer
            Sport = new DataOrdner.LehrerInfo("Sport");

            Sport.Add("Flütsch", "ursina.fluetsch@gymhofwil.ch");
            Sport.Add("Gehring", "barbara.gehring@gymhofwil.ch");
            Sport.Add("Reber", "daniel.reber@gymhofwil.ch");
            Sport.Add("Sulc", "vladimir.sulc@gymhofwil.ch");
            Sport.Add("Tobler", "marcel.tobler@gymhofwil.ch");

            LehrerInfoListe.Add(Sport);

            //Bildnerisches Gestalten
            BG = new DataOrdner.LehrerInfo("Bildnerisches Gestalten");
            BG.Fach_ForData = "BildnerischesGestalten";

            BG.Add("Aerni", "peter.aerni@gymhofwil.ch");
            BG.Add("Bieri", "franziska.bieri@gymhofwil.ch");
            BG.Add("Dünner", "li.duenner@gymhofwil.ch");
            BG.Add("Krethlow", "michael.krethlow@gymhofwil.ch");
            BG.Add("Loux", "andrea.loux@gymhofwil.ch");
            BG.Add("Lüthi", "prisca.luethi@gymhofwil.ch");
            BG.Add("Schneider", "christian.schneider@gymhofwil.ch");

            LehrerInfoListe.Add(BG);

            //Musik
            Musik = new DataOrdner.LehrerInfo("Musik");

            Musik.Add("Gut", "andreas.gut@gymhofwil.ch");
            Musik.Add("Ischer", "martina.ischer@gymhofwil.ch");
            Musik.Add("Kobi", "christian.kobi@gymhofwil.ch");
            Musik.Add("Neidhart", "eva-maria.neidhart@gymhofwil.ch");
            Musik.Add("Scherler", "susanna.scherler@gymhofwil.ch");
            Musik.Add("Schürch", "dieter.schuerch@gymhofwil.ch");

            LehrerInfoListe.Add(Musik);

            //ICT
            ICT = new DataOrdner.LehrerInfo("ICT");

            ICT.Add("Durand", "yannick.durand@gymhofwil.ch");
            ICT.Add("Liniger", "timy.liniger@gymhofwil.ch");
            ICT.Add("Schürch", "samuel.schuerch@gymhofwil.ch");
            ICT.Add("Seger", "urban.seger@gymhofwil.ch");

            LehrerInfoListe.Add(ICT);

            //Chemie
            Chemie = new DataOrdner.LehrerInfo("Chemie");

            Chemie.Add("Baumgartner", "renato.baumgartner@gymhofwil.ch");
            Chemie.Add("Kuhn", "andre.kuhn@gymhofwil.ch");
            Chemie.Add("Lauber", "anita.lauber@gymhofwil.ch");
            Chemie.Add("Streit", "niklaus.streit@gymhofwil.ch");

            LehrerInfoListe.Add(Chemie);

            //Physik
            Physik = new DataOrdner.LehrerInfo("Physik");

            Physik.Add("Haffner", "tilman.haffner@gymhofwil.ch");
            Physik.Add("Palacios", "gabriel.palacios@gymhofwil.ch");
            Physik.Add("Pham", "van.pham@gymhofwil.ch");
            Physik.Add("Seger", "urban.seger@gymhofwil.ch");

            LehrerInfoListe.Add(Physik);

            //Mathematik
            Math = new DataOrdner.LehrerInfo("Mathematik");

            Math.Add("Haffner", "tilman.haffner@gymhofwil.ch");
            Math.Add("Pham", "van.pham@gymhofwil.ch");
            Math.Add("Portmann", "joana.portmann@gymhofwil.ch");
            Math.Add("Salvisberg", "christian.salvisberg@gymhofwil.ch");
            Math.Add("Schürch", "samuel.schuerch@gymhofwil.ch");

            LehrerInfoListe.Add(Math);

            //Geographie
            Geo = new DataOrdner.LehrerInfo("Geographie");

            Geo.Add("Bandi", "victor.bandi@gymhofwil.ch");
            Geo.Add("Essig", "martin.essig@gymhofwil.ch");
            Geo.Add("Flütsch", "ursina.fluetsch@gymhofwil.ch");
            Geo.Add("Liniger", "timy.liniger@gymhofwil.ch");

            LehrerInfoListe.Add(Geo);

            //Geschichte
            Geschichte = new DataOrdner.LehrerInfo("Geschichte");

            Geschichte.Add("Hegner", "edgar.hegner@gymhofwil.ch");
            Geschichte.Add("Liniger", "timy.liniger@gymhofwil.ch");
            Geschichte.Add("Schwitter", "thomas.schwitter@gymhofwil.ch");
            Geschichte.Add("Speck", "anton.speck@gymhofwil.ch");

            LehrerInfoListe.Add(Geschichte);

            //Biologie
            Bio = new DataOrdner.LehrerInfo("Biologie");

            Bio.Add("Keller", "christine.keller@gymhofwil.ch");
            Bio.Add("Lauber", "anita.lauber@gymhofwil.ch");
            Bio.Add("Pfenniger", "andreas.pfenninger@gymhofwil.ch");

            LehrerInfoListe.Add(Bio);

            //Philosophie
            Philo = new DataOrdner.LehrerInfo("Philosophie");

            Philo.Add("Hegner", "edgar.hegner@gymhofwil.ch");

            LehrerInfoListe.Add(Philo);

            //PP
            PP = new DataOrdner.LehrerInfo("Psychologie/Pädagogik");
            PP.Fach_ForData = "PsychologieUndPädagogik";

            PP.Add("Balla", "ioanna.balla@gymhofwil.ch");
            PP.Add("Schori", "christine.schori@gymhofwil.ch");

            LehrerInfoListe.Add(PP);

            //Religion
            Religion = new DataOrdner.LehrerInfo("Religion");

            Religion.Add("Grädel", "fritz.graedel@gymhofwil.ch");

            LehrerInfoListe.Add(Religion);

            //Wirtschaft und Recht
            WR = new DataOrdner.LehrerInfo("Wirtschaft&Recht");
            WR.Fach_ForData = "WirtschaftUndRecht";

            WR.Add("Durant", "yannick.durand@gymhofwil.ch");

            LehrerInfoListe.Add(WR);            
                                    
        }//End Init()


        public static String[] GetFaecher() //Returns all fächer in a Array
        {
            List<string> Faecher = new List<string>();

            foreach(DataOrdner.LehrerInfo element in LehrerInfoListe)
            {
                Faecher.Add(element.Fach);
            }

            return (Faecher.ToArray());
        }//End GetFaecher()


        public static String[] GetLehrer(string fach)   //Returns all lehrer of a fach in a Array
        {
            foreach(DataOrdner.LehrerInfo element in LehrerInfoListe)
            {
                if(element.Fach == fach)
                {
                    return element.Lehrer.ToArray();
                }
            }

            MessageBox.Show("You should never see this box" + "\n" + "Data.GetLehrer()");
            return null;
        }//End of GetLehrer(fach)


        public static void CreateNewXML()   //Creates a new .xml in which the lehrer can be saved
        {
            XmlDocument xDoc = new XmlDocument();
            XmlNode newNode = xDoc.CreateElement("Faecher");
            xDoc.AppendChild(newNode);

            XmlNode FachNode;
            XmlAttribute Fach;
            
            foreach(DataOrdner.LehrerInfo element in LehrerInfoListe)
            {
                FachNode = xDoc.CreateElement("Fach");
                Fach = xDoc.CreateAttribute(element.Fach_ForData ?? element.Fach);
                Fach.Value = "null";
                FachNode.Attributes.Append(Fach);
                newNode.AppendChild(FachNode);
            }

            xDoc.Save("SavedLehrer.xml");
        }//End of CreateNewXML()


        public static string GetLehrerFromXML(string fach)  //Searches the .xml for already safed teachers retruns "" if no teacher was found
        {
            string fachInDataFormat = FachToDataFormat(fach);

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("SavedLehrer.xml");
            XmlNodeList nodeList = xDoc.SelectNodes("//Faecher/Fach");

            foreach(XmlNode fachNode in nodeList)
            {
                if(fachNode.Attributes[0].Name == fachInDataFormat)
                {
                    if(fachNode.Attributes[0].Value.ToString() != "null")
                    {
                        return fachNode.Attributes[0].Value.ToString();
                    }//End of if(fachNode.Attribute(fach) != "null)

                    else
                    {
                        return "";
                    }//End of "else"

                }//End of if(fachNode.Attribute == fach)
                
            }//End of "foreach"-loop

            MessageBox.Show("You should never see this box" + "\n" + "Data.GetLehrerFromXML()");
            return "ERROR";

        }//End of GetLehrerByFach
        

        private static string FachToDataFormat(string fach) //Returns the .xml-friendly version of the Fach
        {
            foreach(DataOrdner.LehrerInfo element in LehrerInfoListe)
            {
                if(element.Fach == fach)
                {
                    return element.Fach_ForData ?? element.Fach;
                }
            }

            MessageBox.Show("You should never see this box" + "\n" + "Data.FachToDataFormat()");
            return "ERROR";
        }//End of FachToFachInDataFormat


        public static void SavePrivateData(string vorname, string nachname, string klassenlehrer)   //Creates a new xml with the private datta
        {
            XmlDocument xDoc = new XmlDocument();
            XmlNode newNode = xDoc.CreateElement("PrivateData");
            xDoc.AppendChild(newNode);

            XmlNode pDataNode;
            XmlAttribute pData;

            pDataNode = xDoc.CreateElement("Vorname");
            pData = xDoc.CreateAttribute("Vorname");
            pData.Value = vorname;
            pDataNode.Attributes.Append(pData);
            newNode.AppendChild(pDataNode);

            pDataNode = xDoc.CreateElement("Nachname");
            pData = xDoc.CreateAttribute("Nachname");
            pData.Value = nachname;
            pDataNode.Attributes.Append(pData);
            newNode.AppendChild(pDataNode);

            pDataNode = xDoc.CreateElement("Klassenlehrer");
            pData = xDoc.CreateAttribute("Klassenlehrer");
            pData.Value = klassenlehrer;
            pDataNode.Attributes.Append(pData);
            newNode.AppendChild(pDataNode);

            xDoc.Save("OtherStuff.xml");
        }//End of SavePrivatedata(vorname, nachname, klassenlehrer)


        public static void SaveTeacher(string fach, string teacher) //Saves a teacher in his coresponding fach
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("SavedLehrer.xml");
            XmlNodeList nodeList = xDoc.SelectNodes("//Faecher/Fach");

            foreach(XmlNode fachnode in nodeList)
            {
                if(fachnode.Attributes[0].Name == fach)
                {
                    fachnode.Attributes[0].Value = teacher;
                }
            }

            xDoc.Save("SavedLehrer.xml");
        }//End of SaveTeacher(fach, teacher)

    }
}
