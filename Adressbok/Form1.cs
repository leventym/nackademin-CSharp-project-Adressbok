using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace Adressbok
{
    public partial class frmAdressbok : Form
    {
        private List<string> minAdressbok = new List<string>();
        
        public frmAdressbok()
        {
            InitializeComponent();
            loadFromFile();
            updateListBox();
            
        }

        //Load funktion som uppdaterar/läser in filen Adressbok.txt
        private void loadFromFile()
        {
            this.minAdressbok = File.ReadAllLines("Adressbok.txt").ToList(); 
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
            minAdressbok.Add(newPerson.ToString());
           
            //Skriver över hela listan med adressbok till textfilen adressbok.
            File.WriteAllLines("Adressbok.txt", minAdressbok);

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
                File.WriteAllLines("Adressbok.txt", minAdressbok);
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
            string editedPost = minAdressbok[toBeEdited];

            //lägger in kontaktraden i en array
            string[] editedPostArr = editedPost.Split(' ');

            //Spara redigerade värden
            Person editedPerson = Prompt.ShowDialogEdit(editedPostArr[0], editedPostArr[1], editedPostArr[2], 
                editedPostArr[3], editedPostArr[4], editedPostArr[5]);

            //Tillderar listan minAdressbok den nya redigerade kontakten i en specifik position.
            minAdressbok[toBeEdited] = editedPerson.ToString();

            //Skriver över hela listan med adressbok till textfilen adressbok.
            File.WriteAllLines("Adressbok.txt", minAdressbok);

            //Uppdaterade personen tilldelas till listvyn == listvyn uppdateras. 
            listAdress.Items[toBeEdited] = editedPerson.ToString();
        }

        private void buttonSok_Click(object sender, EventArgs e)
        {
            //Loopar igenom lisboxen listAdress 'bakifrån' (-1)
            //Kollar om värdet i textboxen finns i listboxen
            //Om den finns markeras den.
            //De som inte matchas tas bort från listboxen

            for (int i = listAdress.Items.Count - 1; i >= 0; i--)
            {
                if (listAdress.Items[i].ToString().Contains(textBoxNamn.Text))
                {
                    listAdress.SetSelected(i, true);
                }
                else
                {
                    listAdress.Items.RemoveAt(i);
                }
            }

            for (int i = listAdress.Items.Count - 1; i >= 0; i--)
            {
                if (listAdress.Items[i].ToString().Contains(textBoxPostort.Text))
                {
                    listAdress.SetSelected(i, true);
                }
                else
                {
                    listAdress.Items.RemoveAt(i);
                }
            }
        }

        private void buttonRensa_Click(object sender, EventArgs e)
        {
            //När rensa knappen trycks tas värden i textboxarna bort
            //Sedan uppdateras listboxen tillbaka till original listan
            textBoxNamn.Text = "";
            textBoxPostort.Text = "";
            updateListBox();
        }
    }
}


