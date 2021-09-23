using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Windows.Forms;

namespace Adressbok
{
    public partial class frmAdressbok : Form
    {
        public frmAdressbok()
        {
            InitializeComponent();
            loadFromFile();
        }

        private void loadFromFile()
        {
            string[] minAdressbok = File.ReadAllLines("Adressbok.txt");

            //rensa listview
            //lägg till från array till listview - loopa med en for each
        }


        private void buttonSkapa_Click(object sender, EventArgs e)
        {
            
            Person newPerson = Prompt.ShowDialog("Skriv in uppgifter: ", "Skapa ny kontakt");
            File.AppendAllText("Adressbok.txt", newPerson.ToString());


            MessageBox.Show(newPerson.ToString());

        }

        private void listAdress_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
