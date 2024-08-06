using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_park_in_the_dark
{
    public partial class FrmSimulation : Form
    {
        public FrmSimulation()
        {
            InitializeComponent();
        }

        private void FrmSimulation_Load(object sender, EventArgs e)
        {

        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {

        }

        private void btnLevelUp_Click(object sender, EventArgs e)
        {

        }

        private void btnLevelDown_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Name des Gebäudes abrufen
            string buildingName = tbxBuildingName.Text;

            // Anzahl der Parkplätze pro Etage und Anzahl der Etagen abrufen
            int parkingSlotsPerLevel = (int)nudParkingSlots.Value;
            int numberOfLevels = (int)nudLevels.Value;

            // Überprüfen, ob die Eingaben gültig sind
            if (string.IsNullOrEmpty(buildingName) || parkingSlotsPerLevel <= 0 || numberOfLevels <= 0)
            {
                MessageBox.Show("Bitte geben Sie gültige Werte ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gebäude erstellen und zur Simulation GroupBox hinzufügen
            gbxSimulation.Text = buildingName;
            gbxSimulation.Controls.Clear();

            // Parkplätze hinzufügen
            int btnWidth = 50;
            int btnHeight = 100;
            int margin = 25;

            for (int level = 0; level < numberOfLevels; level++)
            {
                for (int slot = 0; slot < parkingSlotsPerLevel; slot++)
                {
                    Button btnParkingSlot = new Button
                    {
                        Width = btnWidth,
                        Height = btnHeight,
                        Text = $"L{level + 1}S{slot + 1}"
                    };
                    btnParkingSlot.Click += BtnParkingSlot_Click;

                    int row = slot / 5;
                    int col = slot % 5;

                    btnParkingSlot.Location = new Point(col * (btnWidth + margin), level * (btnHeight + margin) + row * (btnHeight + margin));
                    gbxSimulation.Controls.Add(btnParkingSlot);
                }
            }
        }

        private void BtnParkingSlot_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            MessageBox.Show($"Parkplatz {clickedButton.Text} ausgewählt.");
        }
    }
}
