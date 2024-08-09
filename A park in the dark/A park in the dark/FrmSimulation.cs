using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace A_park_in_the_dark
{
    public partial class FrmSimulation : Form
    {
        private int currentLevel = 1;
        private int totalLevels = 0;
        private int parkingSlotsPerLevel = 0;
        private List<ParkingBuilding> parkingBuildings = new List<ParkingBuilding>();

        public FrmSimulation()
        {
            InitializeComponent();
        }

        private void FrmSimulation_Load(object sender, EventArgs e)
        {

        }

        private void btnLevelUp_Click(object sender, EventArgs e)
        {
            if (currentLevel < totalLevels)
            {
                currentLevel++;
                lblCurrentLevel.Text = currentLevel.ToString();
                DisplayParkingSlotsForLevel(currentLevel);
            }
        }

        private void btnLevelDown_Click(object sender, EventArgs e)
        {
            if (currentLevel > 1)
            {
                currentLevel--;
                lblCurrentLevel.Text = currentLevel.ToString();
                DisplayParkingSlotsForLevel(currentLevel);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Name des Gebäudes abrufen
            string buildingName = tbxBuildingName.Text;

            // Anzahl der Parkplätze pro Etage und Anzahl der Etagen abrufen
            parkingSlotsPerLevel = (int)nudParkingSlots.Value;
            totalLevels = (int)nudLevels.Value;

            // Überprüfen, ob die Eingaben gültig sind
            if (string.IsNullOrEmpty(buildingName) || parkingSlotsPerLevel <= 0 || totalLevels <= 0)
            {
                MessageBox.Show("Bitte geben Sie gültige Werte ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Überprüfen, ob das Gebäude bereits existiert
            ParkingBuilding existingBuilding = parkingBuildings.Find(b => b.BuildingName == buildingName);
            if (existingBuilding != null)
            {
                // Gebäude ersetzen
                existingBuilding.Levels.Clear();
                for (int i = 0; i < totalLevels; i++)
                {
                    existingBuilding.Levels.Add(new Level(parkingSlotsPerLevel));
                }

                currentBuildingIndex = parkingBuildings.IndexOf(existingBuilding); // Setze den Index auf das ersetzte Gebäude
            }
            else
            {
                // Neues Gebäude hinzufügen
                ParkingBuilding newBuilding = new ParkingBuilding(buildingName, totalLevels, parkingSlotsPerLevel);
                parkingBuildings.Add(newBuilding);
                currentBuildingIndex = parkingBuildings.Count - 1; // Setze den Index auf das neue Gebäude
            }

            // Simulation Panel aktualisieren
            gbxSimulation.Text = buildingName;

            // Initiales Level anzeigen
            currentLevel = 1;
            lblCurrentLevel.Text = currentLevel.ToString();

            DisplayParkingSlotsForLevel(currentLevel);
            DisplayBuildingInfo(); // Gebäudeinformationen aktualisieren
        }


        private void DisplayParkingSlotsForLevel(int level)
        {
            // Sicherstellen, dass das Panel sichtbar ist
            panView.Visible = true;

            // Panel vorher leeren
            panView.Controls.Clear();

            // Berechne die maximale Anzahl der Spalten basierend auf der Panel-Größe
            int btnWidth = 50;
            int btnHeight = 100;
            int margin = 10; // Abstand zwischen den Buttons
            int offsetX = 10; // Abstand von der linken Seite des Panels
            int offsetY = 10; // Abstand von der oberen Seite des Panels
            int maxColumns = (panView.Width - offsetX - margin) / (btnWidth + margin);

            // Debug: Überprüfen, ob die Berechnungen korrekt sind
            Console.WriteLine($"Panel Width: {panView.Width}, Max Columns: {maxColumns}");

            Console.WriteLine("We have: "+ parkingSlotsPerLevel);
            for (int slot = 0; slot < parkingSlotsPerLevel; slot++)
            {
                Button btnParkingSlot = new Button
                {
                    Width = btnWidth,
                    Height = btnHeight,
                    Text = $"L{level}S{slot + 1}"
                };
                btnParkingSlot.Click += BtnParkingSlot_Click;

                int row = slot / maxColumns;
                int col = slot % maxColumns;

                // Debug: Überprüfen der Positionen
                int posX = offsetX + col * (btnWidth + margin);
                int posY = offsetY + row * (btnHeight + margin);
                Console.WriteLine($"Slot {slot}: Position ({posX}, {posY})");

                btnParkingSlot.Location = new Point(posX, posY);
                panView.Controls.Add(btnParkingSlot);

                // Sicherstellen, dass der Button im Vordergrund ist
                btnParkingSlot.BringToFront();
            }

            // Panel automatisch scrollen lassen, falls die Buttons über das Panel hinausgehen
            panView.AutoScroll = true;
        }

        private void BtnParkingSlot_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            MessageBox.Show($"Parkplatz {clickedButton.Text} ausgewählt.");
        }

        private int currentBuildingIndex = 0;

        private void btnNextBuilding_Click(object sender, EventArgs e)
        {
            // Index erhöhen
            if (parkingBuildings.Count > 0)
            {
                currentBuildingIndex = (currentBuildingIndex + 1) % parkingBuildings.Count; // Zyklisches Navigieren durch die Liste
                DisplayBuildingInfo();
            }
        }

        private void btnPrevBuilding_Click(object sender, EventArgs e)
        {
            // Index verringern
            if (parkingBuildings.Count > 0)
            {
                currentBuildingIndex = (currentBuildingIndex - 1 + parkingBuildings.Count) % parkingBuildings.Count; // Zyklisches Navigieren durch die Liste
                DisplayBuildingInfo();
            }
        }

        private void DisplayBuildingInfo()
        {
            if (parkingBuildings.Count == 0)
            {
                lblBuildingInfo.Text = "Keine Gebäude verfügbar.";
                return;
            }

            var currentBuilding = parkingBuildings[currentBuildingIndex];

            int totalSlots = 0;
            int totalFreeSlots = 0;
            int totalCars = 0;
            int totalMotorbikes = 0;

            foreach (var level in currentBuilding.Levels)
            {
                totalSlots += level.ParkingSlots.Count;
                foreach (var slot in level.ParkingSlots)
                {
                    if (slot.ParkingSlotIsFree)
                    {
                        totalFreeSlots++;
                    }
                    else if (slot.AssignedVehicle is Car)
                    {
                        totalCars++;
                    }
                    else if (slot.AssignedVehicle is Motorbike)
                    {
                        totalMotorbikes++;
                    }
                }
            }

            int slotsPerLevel = currentBuilding.Levels[0].ParkingSlots.Count;
            lblBuildingInfo.Text = $"Name: {currentBuilding.BuildingName}\n" +
                                   $"{totalFreeSlots}/{totalSlots} parkingslots are available\n" +
                                   $"The building has {slotsPerLevel} levels\n" +
                                   $"Cars: {totalCars}\n" +
                                   $"Motorbikes: {totalMotorbikes}\n" +
                                   $"Building: {currentBuildingIndex + 1}/{parkingBuildings.Count}";
        }
        #region ---------->!ToDo!<----------
        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Soll das momentane Fahrzeug, aus der Liste entfernen, slotState wird zu 0
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            //Erstelle ein Fahrzeug, mit was für ein Typ es ist, von der combobox "cbxType" und der Namensschild soll von der "tbxNameplate"
            //Füge das Fahrzeug nur ein, wenn es im Gebäude einen frien platz hat, sonst soll ein anderes Gebäude empfohlen werden, wo es die meisten Freie Plätze hat
            //Das Fahrzeug soll, auf den nahliegfensten platz, zum Beispiel: Von Level 1 von 1 bis 6 dann Level 2 bis 1 bis 6 war eine Lücke bei 3, was frei ist, somit dort soll das Fahrzeug rein.
            //(Eventuell eine Methode erstellen hierfür) Die Liste die angezeigt werden soll ist: lblSlotInfo.text = $"Slot: L{level}S{slot}\nSlot state: {slotState}\nNameplate: {nameplate}\nVehicle Type: {Type}"
            //Note: ("slotState" should be like this: 0 = free; 1 = occupied; 2 = blocked)
            //Keine Fahrzeuge auf einen Platz mit (slotState = 1 || slotState = 2) bringen.
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Man kann zwsichen "Car" und "Motorbike" wählen, bei der combobox "cbxType", standart soll "Car" sein
        }

        private void btnNextSlot_Click(object sender, EventArgs e)
        {
            //index++
        }

        private void btnPrevSlot_Click(object sender, EventArgs e)
        {
            //index--
        }
        #endregion
    }
}
