﻿using System;
using System.Windows.Forms;
using DLL;

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (var animal in Animalshelter.AnimalList)
                lstBoxOverview.Items.Add(animal);
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            Dier_Invoer DI = new Dier_Invoer();
            DI.Show();
        }

        private void btnSellAnimal_Click(object sender, EventArgs e)
        {

        }

        private void btnReserveAnimal_Click(object sender, EventArgs e)
        {
            ReservationForm RF = new ReservationForm();
            RF.Show();
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            lstBoxOverview.Items.Clear();
            foreach (var animal in Animalshelter.AnimalList)
                lstBoxOverview.Items.Add(animal);
        }
    }
}