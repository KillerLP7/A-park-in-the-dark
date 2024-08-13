namespace A_park_in_the_dark
{
    partial class FrmSimulation
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCurrentLevel = new System.Windows.Forms.Label();
            this.btnLevelUp = new System.Windows.Forms.Button();
            this.btnLevelDown = new System.Windows.Forms.Button();
            this.gbxSimulation = new System.Windows.Forms.GroupBox();
            this.panView = new System.Windows.Forms.Panel();
            this.btnParkingSlot = new System.Windows.Forms.Button();
            this.lblSlotInfo = new System.Windows.Forms.Label();
            this.lblBuildingInfo = new System.Windows.Forms.Label();
            this.nudLevels = new System.Windows.Forms.NumericUpDown();
            this.tbxBuildingName = new System.Windows.Forms.TextBox();
            this.nudParkingSlots = new System.Windows.Forms.NumericUpDown();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblParkingSlots = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNextBuilding = new System.Windows.Forms.Button();
            this.btnPrevBuilding = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.tbxNameplate = new System.Windows.Forms.TextBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNextSlot = new System.Windows.Forms.Button();
            this.btnPrevSlot = new System.Windows.Forms.Button();
            this.gbxSimulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParkingSlots)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrentLevel
            // 
            this.lblCurrentLevel.AutoSize = true;
            this.lblCurrentLevel.Location = new System.Drawing.Point(427, 307);
            this.lblCurrentLevel.Name = "lblCurrentLevel";
            this.lblCurrentLevel.Size = new System.Drawing.Size(13, 13);
            this.lblCurrentLevel.TabIndex = 3;
            this.lblCurrentLevel.Text = "0";
            // 
            // btnLevelUp
            // 
            this.btnLevelUp.Font = new System.Drawing.Font("Wingdings", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnLevelUp.Location = new System.Drawing.Point(406, 332);
            this.btnLevelUp.Name = "btnLevelUp";
            this.btnLevelUp.Size = new System.Drawing.Size(50, 50);
            this.btnLevelUp.TabIndex = 4;
            this.btnLevelUp.Text = "G";
            this.btnLevelUp.UseVisualStyleBackColor = true;
            this.btnLevelUp.Click += new System.EventHandler(this.btnLevelUp_Click);
            // 
            // btnLevelDown
            // 
            this.btnLevelDown.Font = new System.Drawing.Font("Wingdings", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnLevelDown.Location = new System.Drawing.Point(406, 388);
            this.btnLevelDown.Name = "btnLevelDown";
            this.btnLevelDown.Size = new System.Drawing.Size(50, 50);
            this.btnLevelDown.TabIndex = 5;
            this.btnLevelDown.Text = "H";
            this.btnLevelDown.UseVisualStyleBackColor = true;
            this.btnLevelDown.Click += new System.EventHandler(this.btnLevelDown_Click);
            // 
            // gbxSimulation
            // 
            this.gbxSimulation.Controls.Add(this.panView);
            this.gbxSimulation.Controls.Add(this.btnParkingSlot);
            this.gbxSimulation.Location = new System.Drawing.Point(12, 12);
            this.gbxSimulation.Name = "gbxSimulation";
            this.gbxSimulation.Size = new System.Drawing.Size(391, 426);
            this.gbxSimulation.TabIndex = 6;
            this.gbxSimulation.TabStop = false;
            this.gbxSimulation.Text = "Building";
            // 
            // panView
            // 
            this.panView.AutoScroll = true;
            this.panView.BackColor = System.Drawing.SystemColors.Control;
            this.panView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panView.Location = new System.Drawing.Point(3, 16);
            this.panView.Name = "panView";
            this.panView.Size = new System.Drawing.Size(385, 407);
            this.panView.TabIndex = 1;
            // 
            // btnParkingSlot
            // 
            this.btnParkingSlot.Location = new System.Drawing.Point(6, 19);
            this.btnParkingSlot.Name = "btnParkingSlot";
            this.btnParkingSlot.Size = new System.Drawing.Size(50, 100);
            this.btnParkingSlot.TabIndex = 0;
            this.btnParkingSlot.UseVisualStyleBackColor = true;
            // 
            // lblSlotInfo
            // 
            this.lblSlotInfo.Location = new System.Drawing.Point(462, 31);
            this.lblSlotInfo.Name = "lblSlotInfo";
            this.lblSlotInfo.Size = new System.Drawing.Size(532, 117);
            this.lblSlotInfo.TabIndex = 11;
            this.lblSlotInfo.Text = "Vehicle Info";
            // 
            // lblBuildingInfo
            // 
            this.lblBuildingInfo.Location = new System.Drawing.Point(462, 177);
            this.lblBuildingInfo.Name = "lblBuildingInfo";
            this.lblBuildingInfo.Size = new System.Drawing.Size(533, 83);
            this.lblBuildingInfo.TabIndex = 12;
            this.lblBuildingInfo.Text = "Building Info";
            // 
            // nudLevels
            // 
            this.nudLevels.Location = new System.Drawing.Point(130, 95);
            this.nudLevels.Name = "nudLevels";
            this.nudLevels.Size = new System.Drawing.Size(39, 20);
            this.nudLevels.TabIndex = 15;
            // 
            // tbxBuildingName
            // 
            this.tbxBuildingName.Location = new System.Drawing.Point(10, 43);
            this.tbxBuildingName.Name = "tbxBuildingName";
            this.tbxBuildingName.Size = new System.Drawing.Size(159, 20);
            this.tbxBuildingName.TabIndex = 16;
            // 
            // nudParkingSlots
            // 
            this.nudParkingSlots.Location = new System.Drawing.Point(128, 69);
            this.nudParkingSlots.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudParkingSlots.Name = "nudParkingSlots";
            this.nudParkingSlots.Size = new System.Drawing.Size(41, 20);
            this.nudParkingSlots.TabIndex = 17;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(10, 121);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(159, 23);
            this.btnCreate.TabIndex = 18;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(7, 97);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(115, 13);
            this.lblLevel.TabIndex = 19;
            this.lblLevel.Text = "Level/s in the Building:";
            // 
            // lblParkingSlots
            // 
            this.lblParkingSlots.AutoSize = true;
            this.lblParkingSlots.Location = new System.Drawing.Point(8, 71);
            this.lblParkingSlots.Name = "lblParkingSlots";
            this.lblParkingSlots.Size = new System.Drawing.Size(114, 13);
            this.lblParkingSlots.TabIndex = 20;
            this.lblParkingSlots.Text = "Parkingslots per Level:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblParkingSlots);
            this.groupBox1.Controls.Add(this.lblLevel);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.nudParkingSlots);
            this.groupBox1.Controls.Add(this.tbxBuildingName);
            this.groupBox1.Controls.Add(this.nudLevels);
            this.groupBox1.Location = new System.Drawing.Point(872, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 152);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Building";
            // 
            // btnNextBuilding
            // 
            this.btnNextBuilding.Font = new System.Drawing.Font("Wingdings", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnNextBuilding.Location = new System.Drawing.Point(1001, 177);
            this.btnNextBuilding.Name = "btnNextBuilding";
            this.btnNextBuilding.Size = new System.Drawing.Size(50, 50);
            this.btnNextBuilding.TabIndex = 24;
            this.btnNextBuilding.Text = "F";
            this.btnNextBuilding.UseVisualStyleBackColor = true;
            this.btnNextBuilding.Click += new System.EventHandler(this.btnNextBuilding_Click);
            // 
            // btnPrevBuilding
            // 
            this.btnPrevBuilding.Font = new System.Drawing.Font("Wingdings", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnPrevBuilding.Location = new System.Drawing.Point(406, 177);
            this.btnPrevBuilding.Name = "btnPrevBuilding";
            this.btnPrevBuilding.Size = new System.Drawing.Size(50, 50);
            this.btnPrevBuilding.TabIndex = 23;
            this.btnPrevBuilding.Text = "E";
            this.btnPrevBuilding.UseVisualStyleBackColor = true;
            this.btnPrevBuilding.Click += new System.EventHandler(this.btnPrevBuilding_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(465, 151);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(530, 23);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(16, 88);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(121, 23);
            this.btnAddVehicle.TabIndex = 0;
            this.btnAddVehicle.Text = "Add";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // tbxNameplate
            // 
            this.tbxNameplate.Location = new System.Drawing.Point(16, 62);
            this.tbxNameplate.Name = "tbxNameplate";
            this.tbxNameplate.Size = new System.Drawing.Size(121, 20);
            this.tbxNameplate.TabIndex = 1;
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(16, 35);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 21);
            this.cbxType.TabIndex = 2;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxType);
            this.groupBox2.Controls.Add(this.tbxNameplate);
            this.groupBox2.Controls.Add(this.btnAddVehicle);
            this.groupBox2.Location = new System.Drawing.Point(716, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 123);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Vehicle";
            // 
            // btnNextSlot
            // 
            this.btnNextSlot.Font = new System.Drawing.Font("Wingdings", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnNextSlot.Location = new System.Drawing.Point(1001, 28);
            this.btnNextSlot.Name = "btnNextSlot";
            this.btnNextSlot.Size = new System.Drawing.Size(50, 50);
            this.btnNextSlot.TabIndex = 26;
            this.btnNextSlot.Text = "F";
            this.btnNextSlot.UseVisualStyleBackColor = true;
            this.btnNextSlot.Click += new System.EventHandler(this.btnNextSlot_Click);
            // 
            // btnPrevSlot
            // 
            this.btnPrevSlot.Font = new System.Drawing.Font("Wingdings", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnPrevSlot.Location = new System.Drawing.Point(406, 28);
            this.btnPrevSlot.Name = "btnPrevSlot";
            this.btnPrevSlot.Size = new System.Drawing.Size(50, 50);
            this.btnPrevSlot.TabIndex = 25;
            this.btnPrevSlot.Text = "E";
            this.btnPrevSlot.UseVisualStyleBackColor = true;
            this.btnPrevSlot.Click += new System.EventHandler(this.btnPrevSlot_Click);
            // 
            // FrmSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 450);
            this.Controls.Add(this.btnNextSlot);
            this.Controls.Add(this.btnPrevSlot);
            this.Controls.Add(this.btnNextBuilding);
            this.Controls.Add(this.btnPrevBuilding);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblBuildingInfo);
            this.Controls.Add(this.lblSlotInfo);
            this.Controls.Add(this.btnLevelDown);
            this.Controls.Add(this.btnLevelUp);
            this.Controls.Add(this.lblCurrentLevel);
            this.Controls.Add(this.gbxSimulation);
            this.Name = "FrmSimulation";
            this.Text = "Parking Simulator";
            this.Load += new System.EventHandler(this.FrmSimulation_Load);
            this.gbxSimulation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudLevels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParkingSlots)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCurrentLevel;
        private System.Windows.Forms.Button btnLevelUp;
        private System.Windows.Forms.Button btnLevelDown;
        private System.Windows.Forms.GroupBox gbxSimulation;
        private System.Windows.Forms.Label lblSlotInfo;
        private System.Windows.Forms.Label lblBuildingInfo;
        private System.Windows.Forms.Button btnParkingSlot;
        private System.Windows.Forms.NumericUpDown nudLevels;
        private System.Windows.Forms.TextBox tbxBuildingName;
        private System.Windows.Forms.NumericUpDown nudParkingSlots;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblParkingSlots;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panView;
        private System.Windows.Forms.Button btnNextBuilding;
        private System.Windows.Forms.Button btnPrevBuilding;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.TextBox tbxNameplate;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNextSlot;
        private System.Windows.Forms.Button btnPrevSlot;
    }
}

