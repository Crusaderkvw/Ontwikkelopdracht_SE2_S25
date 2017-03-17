using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL;
using DLL.DomainClasses;

namespace AnimalShelter
{
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
            foreach (Animal animal in Animalshelter.AnimalList)
            {
                cmbBoxAnimalSelection.Items.Add(animal);
            }
            foreach (Customer customer in Animalshelter.CustomerList)
            {
                cmbBoxCustomerSelection.Items.Add(customer);
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            Animalshelter.ReserveAnimal(cmbBoxAnimalSelection.SelectedItem, cmbBoxCustomerSelection.SelectedItem);
            Close();
        }
    }
}
