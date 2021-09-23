using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adressbok
{
    class Prompt
    {
        public static Person ShowDialog(string text, string caption)
        {
            Person person = new Person();

            Form prompt = new Form();
            prompt.Width = 1000;
            prompt.Height = 700;
            prompt.Text = caption;

            //Namn label
            Label LabelNamn = new Label() { Left = 50, Top = 20, Text = text };
            TextBox inputNamn = new TextBox() { Left = 50, Top = 50, Width = 400 };
            inputNamn.PlaceholderText = "Namn";

            //Gatuadress label
            Label LabelGatuadress = new Label() { Left = 50, Top = 20, Text = text };
            TextBox inputGatuadress = new TextBox() { Left = 50, Top = 100, Width = 400 };

            //Postnummer label
            Label LabelPostnummer = new Label() { Left = 50, Top = 20, Text = text };
            TextBox inputPostnummer = new TextBox() { Left = 50, Top = 150, Width = 400 };

            //Postort label
            Label LabelPostort = new Label() { Left = 50, Top = 20, Text = text };
            TextBox inputPostort = new TextBox() { Left = 50, Top = 200, Width = 400 };

            //Telefon label
            Label LabelTelefon = new Label() { Left = 50, Top = 20, Text = text };
            TextBox inputTelefon = new TextBox() { Left = 50, Top = 250, Width = 400 };

            //Epost label
            Label LabelEpost = new Label() { Left = 50, Top = 20, Text = text };
            TextBox inputEpost = new TextBox() { Left = 50, Top = 300, Width = 400 };


            Button confirmation = new Button() { Text = "Spara", Left = 350, Height = 60, Width = 100, Top = 400 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);

            //Namn
            prompt.Controls.Add(LabelNamn);
            prompt.Controls.Add(inputNamn);

            //Gatuadress
            prompt.Controls.Add(LabelGatuadress);
            prompt.Controls.Add(inputGatuadress);

            //Postnummer
            prompt.Controls.Add(LabelPostnummer);
            prompt.Controls.Add(inputPostnummer);

            //Postort
            prompt.Controls.Add(LabelPostort);
            prompt.Controls.Add(inputPostort);

            //Telefon
            prompt.Controls.Add(LabelTelefon);
            prompt.Controls.Add(inputTelefon);

            //Epost
            prompt.Controls.Add(LabelEpost);
            prompt.Controls.Add(inputEpost);

            prompt.ShowDialog();

            //Tilldelar inputvärdet från formuläret till objektet person
            person.Namn = inputNamn.Text;
            person.Gatuadress = inputGatuadress.Text;
            person.Postnummer = inputPostnummer.Text;
            person.Postort = inputPostort.Text;
            person.Telefon = inputTelefon.Text;
            person.Epost = inputEpost.Text;

            return person;
        }
    }
}
