using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Gmail.v1;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;


namespace AbsenzenMailProgram
{
    public partial class Form1 : Form
    {
        //Set up Comboboxes
        static ComboBox cBox1 = new ComboBox();
        static ComboBox cBox2 = new ComboBox();
        static ComboBox cBox3 = new ComboBox();
        static ComboBox cBox4 = new ComboBox();
        static ComboBox cBox5 = new ComboBox();
        static ComboBox cBox6 = new ComboBox();
        static ComboBox cBox7 = new ComboBox();
        static ComboBox cBox8 = new ComboBox();
        static ComboBox[] cBoxArray_Faecher = { cBox1, cBox2, cBox3, cBox4, cBox5, cBox6, cBox7, cBox8 };

        //More Comboboxes (for lehrer)
        static ComboBox cBox9 = new ComboBox();
        static ComboBox cBox10 = new ComboBox();
        static ComboBox cBox11 = new ComboBox();
        static ComboBox cBox12 = new ComboBox();
        static ComboBox cBox13 = new ComboBox();
        static ComboBox cBox14 = new ComboBox();
        static ComboBox cBox15 = new ComboBox();
        static ComboBox cBox16 = new ComboBox();
        static ComboBox[] cBoxArray_Lehrer = { cBox9, cBox10, cBox11, cBox12, cBox13, cBox14, cBox15, cBox16 };

        static Boolean[] cBox_FirstTimeCreated = { true, true, true, true, true, true, true, true };


        //The Panel for the first Startup
        Panel panel = new Panel();

        //A dict for the lehrer that need to be safed
        Dictionary<string, string> lehrerThatNeedToBeSafed = new Dictionary<string, string>();


        public Form1()
        {
            InitializeComponent();  //??
            Data.Init();            //Initilalize the Infos about all teachers
            CreateCbox_Faecher();   //Create the first cBox
            Getcredential();        //Sets up a Gmail-Connection
            MailCompiler.CreateMail();
            Print(Properties.Settings.Default.FirstTimeUse.ToString());
                         
            if(Properties.Settings.Default.FirstTimeUse == true)
            {
                Properties.Settings.Default.FirstTimeUse = false;
                Properties.Settings.Default.Save();
                Data.CreateNewXML();
                FirstTimeSetup(); 
            }

        }//End of __init__ method
        
        
        private static int cBoxFaecherCounter = 0;  //Counts the number of cBoxes(Fächer) created
        private static int cBoxLehrerCounter;

        private void CreateCbox_Faecher()
        {
            //Set Location for new Combobox and set new Location for Button
            cBoxArray_Faecher[cBoxFaecherCounter].Location = new Point(b_newbox.Location.X, b_newbox.Location.Y);
            b_newbox.Location = new Point(b_newbox.Location.X, b_newbox.Location.Y + 20);

            //Add cBox Items
            cBoxArray_Faecher[cBoxFaecherCounter].Items.AddRange(Data.GetFaecher());

            //Avtivate AutoCompletion
            cBoxArray_Faecher[cBoxFaecherCounter].AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cBoxArray_Faecher[cBoxFaecherCounter].AutoCompleteSource = AutoCompleteSource.ListItems;

            //Add "item chosen" method
            cBoxArray_Faecher[cBoxFaecherCounter].TextChanged += new EventHandler(cBox_faecher_item_change);

            //Add a Tag to the cBox that is equal to its position in the array
            cBoxArray_Faecher[cBoxFaecherCounter].Tag = cBoxFaecherCounter;

            //Add new Combobox to Frame
            this.Controls.Add(cBoxArray_Faecher[cBoxFaecherCounter]);

            cBoxFaecherCounter += 1;   //Add 1 to the counter so the next box will be the next box

            /* Hide the button if 8 boxes have been created, 
             * so only 8 boxes can be created */
            if(cBoxFaecherCounter == 8)
            {
                b_newbox.Hide();
            }
          
        }//End of CreateCbox()


        private void Print(string input)
        {
            StatusLabel.Text = input;
        }//End of Print(string input)        
               
 
        private void cBox_faecher_item_change(object sender, EventArgs e)
        {
            ComboBox cBox = sender as ComboBox;
            cBoxLehrerCounter = (int)cBox.Tag;

            if(cBox.Items.Contains(cBox.Text) == false)
            {
                return;
            }

            //Add cBoxItems
            cBoxArray_Lehrer[cBoxLehrerCounter].Items.AddRange(Data.GetLehrer(cBox.Text));

            //Add cBox Text (if a lehrer was never chosen for this fach, it returns "")
            cBoxArray_Lehrer[int.Parse(cBox.Tag.ToString())].Text = Data.GetLehrerFromXML(cBox.Text);

            try
            {
              lehrerThatNeedToBeSafed.Add(cBox.Text, "");
            }
            catch (ArgumentException)
            {

            }


            //Add "item chosen" method
            cBoxArray_Lehrer[cBoxLehrerCounter].TextChanged += new EventHandler(cBox_lehrer_item_change);

            if(cBox_FirstTimeCreated[cBoxLehrerCounter] == true)
            {
                cBox_FirstTimeCreated[cBoxLehrerCounter] = false;
                CreateCbox_Lehrer(cBox);
            }

        }//End of cBox item changed method


        private void CreateCbox_Lehrer(ComboBox cBox)
        {
            //Set the location of the new cBox
            cBoxArray_Lehrer[cBoxLehrerCounter].Location = new Point(cBox.Location.X + cBox.Width, cBox.Location.Y);

            //Avtivate AutoCompletion
            cBoxArray_Lehrer[cBoxLehrerCounter].AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cBoxArray_Lehrer[cBoxLehrerCounter].AutoCompleteSource = AutoCompleteSource.ListItems;

            //Add "item chosen" method
            cBoxArray_Lehrer[cBoxLehrerCounter].TextChanged += new EventHandler(cBox_lehrer_item_change);

            //Add new Combobox to Frame
            this.Controls.Add(cBoxArray_Lehrer[cBoxLehrerCounter]);

        }//End of CreateCbox_Lehrer()


        private void cBox_lehrer_item_change(object sender, EventArgs e)
        {
            ComboBox cBox = sender as ComboBox;
            int i = -1;

            if (cBox.Items.Contains(cBox.Text) == false)
            {
                return;
            }

            foreach (ComboBox cBox_lehrer in cBoxArray_Lehrer)
            {
                if(cBox_lehrer.Text == cBox.Text)
                {
                    i = Array.IndexOf(cBoxArray_Lehrer, cBox_lehrer);
                }
            }

            lehrerThatNeedToBeSafed[cBoxArray_Faecher[i].Text] = cBoxArray_Lehrer[i].Text;
        }//End of cBox_lehrer_item_change()


        private void b_newbox_Click(object sender, EventArgs e)
        {
            CreateCbox_Faecher();
        }//End of b_newbox_click()


        private void b_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//End of button_exit()

        
        private void b_restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }//End of button_restart()


        private void b_reset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FirstTimeUse = true;
            Properties.Settings.Default.Save();
        }//End of button_reset()


        private void FirstTimeSetup()
        {
            int startpunkt_y = 90;

            //Panel position and size
            panel.Location = new Point(0, 0);
            panel.Size = new Size(Width, Height);

            //Vorname Label
            Label vorname = new Label();
            vorname.Text = "Dein Vorname";
            vorname.Location = new Point((panel.Width / 2) - vorname.Width, startpunkt_y);
            panel.Controls.Add(vorname);

            //Vorname tBox
            TextBox tBox_vorname = new TextBox();
            tBox_vorname.Location = new Point(panel.Width / 2, startpunkt_y);
            tBox_vorname.Text = "";
            panel.Controls.Add(tBox_vorname);

            //Nachname Label
            Label nachname = new Label();
            nachname.Text = "Dein Nachname";
            nachname.Location = new Point((panel.Width / 2) - nachname.Width, startpunkt_y + vorname.Height);
            panel.Controls.Add(nachname);

            //Nachname tBox
            TextBox tBox_nachname = new TextBox();
            tBox_nachname.Location = new Point(tBox_vorname.Location.X, startpunkt_y + tBox_vorname.Height);
            tBox_nachname.Text = "";
            panel.Controls.Add(tBox_nachname);

            //Klassenlehrer Label
            Label klassenlehrer = new Label();
            klassenlehrer.Text = "Dein Klassenlehrer";
            klassenlehrer.Location = new Point((panel.Width / 2) - klassenlehrer.Width, nachname.Location.Y + (nachname.Height * 2));
            panel.Controls.Add(klassenlehrer);

            //Klassenlehrer cBox
            ComboBox cBox_klassenlehrer = new ComboBox();
            cBox_klassenlehrer.Location = new Point(tBox_nachname.Location.X, tBox_nachname.Location.Y + (tBox_nachname.Height * 2));
            cBox_klassenlehrer.Text = "";

            string[] faecher = Data.GetFaecher();
            List<Array> temporarylist = new List<Array>();
            List<string> betterlistlol = new List<string>();

            //The next few lines add all lehrer to the cBox.Items
            foreach(string fach in faecher)
            {
                temporarylist.Add(Data.GetLehrer(fach));
            }
            foreach(Array array in temporarylist)
            {
                foreach(string element in array)
                {
                    if(betterlistlol.Contains(element) == false)
                    {
                        betterlistlol.Add(element);
                    }
                }
            }
            cBox_klassenlehrer.Items.AddRange(betterlistlol.ToArray());

            //Add autocompletemode
            cBox_klassenlehrer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cBox_klassenlehrer.AutoCompleteSource = AutoCompleteSource.ListItems;

            panel.Controls.Add(cBox_klassenlehrer);

            //Button for finishing the setup process
            Button b_finishsetup = new Button();
            b_finishsetup.Text = "Fertig";
            b_finishsetup.Location = new Point((panel.Width / 2) - (b_finishsetup.Width / 2), klassenlehrer.Location.Y + klassenlehrer.Height * 3);

            b_finishsetup.Click += new EventHandler((s, e) => b_finishsetup_Click(s, e, tBox_vorname.Text, tBox_nachname.Text, cBox_klassenlehrer.Text));    //STACKOVERFLOW CODE -> NO IDEA HOW IT WORKS

            panel.Controls.Add(b_finishsetup);
                        
            // Add the Panel control to the form.
            this.Controls.Add(panel);
            panel.BringToFront();

            //Add the Label and TextBox controls to the Panel.           
        }//End of FirstTimeSetup()


        private void b_finishsetup_Click(object sender, EventArgs e, string vorname, string nachname, string klassenlehrer)
        {
            Data.SavePrivateData(vorname, nachname, klassenlehrer);
            panel.Hide();
        }//End of b_finishsetup_Click(vorname, nachname, klassenlehrer/in)


        private void b_sendmail_Click(object sender, EventArgs e)
        {
            foreach(KeyValuePair<string, string> entry in lehrerThatNeedToBeSafed)
            {
                if(entry.Value != "")
                {
                    Data.SaveTeacher(entry.Key, entry.Value);
                }
            }
        }//End of b_sendmail_Click()


        //RANDOM SHIT FROM https://developers.google.com/gmail/api/quickstart/dotnet
        public void Getcredential()
        {
            UserCredential credential;
            string[] scopes = { GmailService.Scope.GmailSend };
            const string ApplicationName = "AbsenzenMailProgramm v1";

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = Environment.GetFolderPath(
                    Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/gmail-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Gmail API service.
            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }//End of GetCredential()


    }//End of Form1

}
