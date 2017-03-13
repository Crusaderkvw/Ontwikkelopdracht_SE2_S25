using System;
using System.Windows.Forms;
using DLL;

namespace AnimalShelter
{
    public partial class Dier_Invoer : Form
    {
        public Dier_Invoer()
        {
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(Gender)))
                cmbBoxGender.Items.Add(item);
            foreach (var item in Enum.GetValues(typeof(Species)))
                cmbBoxSpecies.Items.Add(item);
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            Animalshelter.AddAnimal(cmbBoxSpecies.SelectedItem, txtBoxName.Text, cmbBoxGender.SelectedItem,
                Convert.ToInt32(nupAge.Value), nupWeight.Value, false, nupPrice.Value);
            Close();
        }
    }
}