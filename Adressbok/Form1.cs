using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using CsvHelper;
using System.Globalization;


namespace Adressbok
{
    public partial class frmAdressbok : Form
    {
        //private List<string> minAdressbok = new List<string>();
        private List<Person> minAdressbok = new List<Person>();
        
        public frmAdressbok()
        {
            InitializeComponent();
            loadFromFile();
            updateListBox();
            
        }

        //Load funktion som uppdaterar/läser in filen Adressbok.txt
        private void loadFromFile()
        {
            string[] minAdressbokArr = File.ReadAllLines("Adressbok.txt");
            //var lines = File.ReadAllLines("Adressbok.csv");
            foreach (string line in minAdressbokArr)
            {
                string[] value = line.Split(' ');

                Person minPerson = new Person(value[0], value[1], value[2], value[3], value[4], value[5]);
                minAdressbok.Add(minPerson);
            }
        }

        private void writeToFile()
        {
            StreamWriter writer = new StreamWriter("Adressbok.txt");

            foreach(Person minPerson in minAdressbok)
            {
                writer.WriteLine(minPerson);
            }
            writer.Close();
        }

        //Funktionen uppdaterar vyn/textboxen
        private void updateListBox()
        {
            listAdress.Items.Clear();
            foreach (var rad in minAdressbok)
            {
                listAdress.Items.Add(rad);
            }
        }

        private void buttonSkapa_Click(object sender, EventArgs e)
        {
            //Skapar ny kontakt med dialogruta.
            Person newPerson = Prompt.ShowDialog("Skriv in uppgifter: ", "Skapa ny kontakt");

            //Lägg till newPerson i minAdressbok
            //Om inget ny person lägss till (avrbyt knappen trycks) hanteras det med en return
            if(newPerson == null)
            {
                return;
            }
            minAdressbok.Add(newPerson);

            //Skriver över hela listan med adressbok till textfilen adressbok.
            writeToFile();


            //Om kontaktformuläret är tomt stängs rutan. Annars visas dialogruta med vilka uppgifter som är inmatade.
            if(newPerson.Namn != "" || 
                newPerson.Gatuadress != "" || 
                newPerson.Postnummer != "" || 
                newPerson.Postort != "" || 
                newPerson.Telefon != "" || 
                newPerson.Epost != "")
            {
                MessageBox.Show(newPerson.ToString());
            }

            updateListBox();

        }

        private void Delete()
        {
         
            if(MessageBox.Show("Vill du radera?", "Radera", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                //Hämtar indexnumret från listAdress som ska raderas
                int toBeRemoved = listAdress.SelectedIndex;

                //Raderar rad från listAdress
                listAdress.Items.RemoveAt(toBeRemoved);

                //raderar rad/kontakt från textfilen
                minAdressbok.RemoveAt(toBeRemoved);

                //Skriver över hela listan med adressbok till textfilen adressbok.
                writeToFile();
            }
        }
        private void buttonTabort_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void buttonAndra_Click(object sender, EventArgs e)
        {
            //Hämtar indexnumret från listAdress som ska redigeras
            int toBeEdited = listAdress.SelectedIndex;

            //Hämtar kontaktraden o lägger in en variabel
            string editedPost = minAdressbok[toBeEdited].ToString();

            //lägger in kontaktraden i en array
            string[] editedPostArr = editedPost.Split(' ');

            //Spara redigerade värden
            Person editedPerson = Prompt.ShowDialogEdit(editedPostArr[0], editedPostArr[1], editedPostArr[2], 
                editedPostArr[3], editedPostArr[4], editedPostArr[5]);

            //Tillderar listan minAdressbok den nya redigerade kontakten i en specifik position.
            minAdressbok[toBeEdited] = editedPerson;

            //Skriver över hela listan med adressbok till textfilen adressbok.
            writeToFile();

            //Uppdaterade personen tilldelas till listvyn == listvyn uppdateras. 
            listAdress.Items[toBeEdited] = editedPerson.ToString();
        }

        private void buttonSok_Click(object sender, EventArgs e)
        {
            //Listboxen/rutan rensas
            //Går igenom objektet minadressbok för att matcha mot sökvärden
            //Finns en match läggs de till i listboxrutan.

            listAdress.Items.Clear();
            foreach (Person person in minAdressbok)
            {
                
                if(textBoxNamn.Text != "" && textBoxPostort.Text != "")
                {
                    if(person.Namn.ToLower().Contains(textBoxNamn.Text.ToLower()) &&
                        person.Postort.ToLower().Contains(textBoxPostort.Text.ToLower()))
                    {
                        listAdress.Items.Add(person.ToString());
                    }
                }
                else if(textBoxNamn.Text != "")
                {
                    if (person.Namn.ToLower().Contains(textBoxNamn.Text.ToLower()))
                    {
                        listAdress.Items.Add(person.ToString());
                    }
                }
                else if (textBoxPostort.Text != "")
                {
                    if (person.Postort.ToLower().Contains(textBoxPostort.Text.ToLower()))
                    {
                        listAdress.Items.Add(person.ToString());
                    }
                }
            }
        }

        private void buttonRensa_Click(object sender, EventArgs e)
        {
            Rensa();
        }

        private void Rensa()
        {
            //När rensa knappen trycks tas värden i textboxarna bort
            //Sedan uppdateras listboxen tillbaka till original listan
            textBoxNamn.Text = "";
            textBoxPostort.Text = "";
            updateListBox();
        }
    }
}


