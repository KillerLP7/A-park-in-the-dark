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
        private int currentBuildingIndex = 0;
        private int selectedSlotIndex = 0;

        public FrmSimulation()
        {
            InitializeComponent();
            InitializeVehicleTypes();
        }

        private void FrmSimulation_Load(object sender, EventArgs e)
        {

        }

        private void InitializeVehicleTypes()
        {
            cbxType.Items.Add("Car");
            cbxType.Items.Add("Motorbike");
            cbxType.SelectedIndex = 0; // Setzt den Standardwert auf "Car"
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

            var currentLevelObj = parkingBuildings[currentBuildingIndex].Levels[level - 1];

            for (int slot = 0; slot < parkingSlotsPerLevel; slot++)
            {
                // Slot initialisieren
                var parkingSlot = currentLevelObj.ParkingSlots[slot];
                parkingSlot.SlotState = 0; // Setze den Slot auf 'frei'
                parkingSlot.ParkingSlotIsFree = true; // Markiere den Slot als frei

                // Button erstellen
                Button btnParkingSlot = new Button
                {
                    Width = btnWidth,
                    Height = btnHeight,
                    Text = $"L{level}S{slot + 1}",
                    BackColor = Color.Green // Frei -> Grün
                };
                btnParkingSlot.Click += BtnParkingSlot_Click;

                int row = slot / maxColumns;
                int col = slot % maxColumns;

                btnParkingSlot.Location = new Point(offsetX + col * (btnWidth + margin), offsetY + row * (btnHeight + margin));
                panView.Controls.Add(btnParkingSlot);
                btnParkingSlot.BringToFront();

                // Button-Tag speichern, um später den Slot zu identifizieren
                btnParkingSlot.Tag = slot;
            }

            // Panel automatisch scrollen lassen, falls die Buttons über das Panel hinausgehen
            panView.AutoScroll = true;
        }

        private void BtnParkingSlot_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int slotIndex = (int)clickedButton.Tag; // Den Slot-Index abrufen
            var currentLevelObj = parkingBuildings[currentBuildingIndex].Levels[currentLevel - 1];
            var selectedSlot = currentLevelObj.ParkingSlots[slotIndex];

            // SlotState zyklisch ändern
            selectedSlot.SlotState = (selectedSlot.SlotState + 1) % 3;

            // Den Slot als frei oder besetzt markieren basierend auf dem neuen Zustand
            selectedSlot.ParkingSlotIsFree = (selectedSlot.SlotState == 0);

            // Button-Farbe basierend auf dem SlotState ändern
            switch (selectedSlot.SlotState)
            {
                case 0:
                    clickedButton.BackColor = Color.Green; // Frei
                    break;
                case 1:
                    clickedButton.BackColor = Color.Red; // Besetzt
                    break;
                case 2:
                    clickedButton.BackColor = Color.Black; // Blockiert
                    break;
            }

            // Slot-Info und Visibility von btnRemove aktualisieren, falls der aktuelle Slot ausgewählt ist
            selectedSlotIndex = slotIndex;
            DisplaySlotInfo();
        }

        //private int currentBuildingIndex = 0;

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
            var currentLevelObj = parkingBuildings[currentBuildingIndex].Levels[currentLevel - 1];

            // Überprüfen, ob ein Fahrzeug auf dem aktuellen Parkplatz vorhanden ist
            if (currentLevelObj.ParkingSlots[selectedSlotIndex].ParkingSlotIsFree == false)
            {
                // Fahrzeug entfernen
                currentLevelObj.ParkingSlots[selectedSlotIndex].RemoveVehicle();
                currentLevelObj.ParkingSlots[selectedSlotIndex].ParkingSlotIsFree = true; // Setze den Slot als frei
                currentLevelObj.ParkingSlots[selectedSlotIndex].SlotState = 0;

                MessageBox.Show($"Fahrzeug auf Slot L{currentLevel}S{selectedSlotIndex + 1} wurde entfernt.");

                // Button-Farbe aktualisieren
                Button clickedButton = panView.Controls.OfType<Button>().FirstOrDefault(b => (int)b.Tag == selectedSlotIndex);
                if (clickedButton != null)
                {
                    clickedButton.BackColor = Color.Green; // Nach Entfernung des Fahrzeugs wird der Slot frei
                }

                DisplaySlotInfo(); // Slot-Info aktualisieren
            }
            else
            {
                MessageBox.Show("Kein Fahrzeug auf dem ausgewählten Parkplatz vorhanden.");
            }
        }


        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            // Fahrzeugtyp und Namensschild aus den Steuerelementen abrufen
            string vehicleType = cbxType.SelectedItem.ToString();
            string nameplate = tbxNameplate.Text;

            if (string.IsNullOrEmpty(nameplate))
            {
                MessageBox.Show("Bitte geben Sie ein gültiges Namensschild ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Fahrzeug erstellen
            Vehicle newVehicle;
            if (vehicleType == "Car")
            {
                newVehicle = new Car { Type = "Car", CurrentNamePlate = nameplate };
            }
            else
            {
                newVehicle = new Motorbike { Type = "Motorbike", CurrentNamePlate = nameplate };
            }

            // Nächstgelegenen freien Parkplatz suchen
            ParkingSlot freeSlot = FindNearestFreeSlot();

            if (freeSlot != null)
            {
                freeSlot.AssignVehicle(newVehicle);
                freeSlot.ParkingSlotIsFree = false;
                freeSlot.SlotState = 1; // Setze den Slot als besetzt

                MessageBox.Show($"Fahrzeug {nameplate} wurde auf Slot L{currentLevel}S{freeSlot.ParkingSlotNr} geparkt.");
                DisplaySlotInfo();
            }
            else
            {
                // Anderes Gebäude empfehlen
                int recommendedBuildingIndex = RecommendBuildingWithMostFreeSlots();
                if (recommendedBuildingIndex != -1)
                {
                    MessageBox.Show($"Kein freier Platz verfügbar. Versuchen Sie es im Gebäude {parkingBuildings[recommendedBuildingIndex].BuildingName}, das die meisten freien Plätze hat.");
                }
                else
                {
                    MessageBox.Show("Kein freier Platz in keinem Gebäude verfügbar.");
                }
            }
        }

        // Methode, um den nächstgelegenen freien Parkplatz zu finden
        private ParkingSlot FindNearestFreeSlot()
        {
            var currentLevelObj = parkingBuildings[currentBuildingIndex].Levels[currentLevel - 1];

            for (int i = 0; i < currentLevelObj.ParkingSlots.Count; i++)
            {
                if (currentLevelObj.ParkingSlots[i].SlotState == 0)
                {
                    return currentLevelObj.ParkingSlots[i];
                }
            }
            return null; // Kein freier Parkplatz gefunden
        }

        // Methode, um das Gebäude mit den meisten freien Plätzen zu empfehlen
        private int RecommendBuildingWithMostFreeSlots()
        {
            int maxFreeSlots = 0;
            int recommendedIndex = -1;

            for (int i = 0; i < parkingBuildings.Count; i++)
            {
                int freeSlots = parkingBuildings[i].Levels.Sum(level => level.ParkingSlots.Count(slot => slot.SlotState == 0));

                if (freeSlots > maxFreeSlots)
                {
                    maxFreeSlots = freeSlots;
                    recommendedIndex = i;
                }
            }
            return recommendedIndex;
        }

        // Methode zur Anzeige der Slot-Informationen
        private void DisplaySlotInfo()
        {
            var currentSlot = parkingBuildings[currentBuildingIndex].Levels[currentLevel - 1].ParkingSlots[selectedSlotIndex];
            string slotState = currentSlot.SlotState == 0 ? "free" : currentSlot.SlotState == 1 ? "occupied" : "blocked";
            lblSlotInfo.Text = $"Slot: L{currentLevel}S{selectedSlotIndex + 1}\n" +
                               $"Slot state: {slotState}\n" +
                               $"Nameplate: {currentSlot.GetCurrentNameplate()}\n" +
                               $"Vehicle Type: {currentSlot.AssignedVehicle?.Type ?? "None"}";

            // Zeige den Remove-Button nur, wenn der Slot besetzt ist
            btnRemove.Visible = currentSlot.SlotState == 1;
        }


        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxType.SelectedIndex == -1) // Wenn nichts ausgewählt ist, Standard auf "Car" setzen
            {
                cbxType.SelectedIndex = 0;
            }
        }


        //private int selectedSlotIndex = 0;

        private void btnNextSlot_Click(object sender, EventArgs e)
        {
            var currentLevelObj = parkingBuildings[currentBuildingIndex].Levels[currentLevel - 1];

            // Index erhöhen und sicherstellen, dass er innerhalb der Grenzen bleibt
            if (currentLevelObj.ParkingSlots.Count > 0)
            {
                selectedSlotIndex = (selectedSlotIndex + 1) % currentLevelObj.ParkingSlots.Count;
                DisplaySlotInfo();
            }
        }

        private void btnPrevSlot_Click(object sender, EventArgs e)
        {
            var currentLevelObj = parkingBuildings[currentBuildingIndex].Levels[currentLevel - 1];

            // Index verringern und sicherstellen, dass er innerhalb der Grenzen bleibt
            if (currentLevelObj.ParkingSlots.Count > 0)
            {
                selectedSlotIndex = (selectedSlotIndex - 1 + currentLevelObj.ParkingSlots.Count) % currentLevelObj.ParkingSlots.Count;
                DisplaySlotInfo();
            }
        }

        #endregion
    }
}
