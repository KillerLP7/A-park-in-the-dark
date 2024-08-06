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
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.tbxNameplate = new System.Windows.Forms.TextBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.lblCurrentLevel = new System.Windows.Forms.Label();
            this.btnLevelUp = new System.Windows.Forms.Button();
            this.btnLevelDown = new System.Windows.Forms.Button();
            this.gbxSimulation = new System.Windows.Forms.GroupBox();
            this.lblVehicleInfo = new System.Windows.Forms.Label();
            this.lblBuildingInfo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnParkingSlot = new System.Windows.Forms.Button();
            this.nudLevels = new System.Windows.Forms.NumericUpDown();
            this.tbxBuildingName = new System.Windows.Forms.TextBox();
            this.nudParkingSlots = new System.Windows.Forms.NumericUpDown();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblParkingSlots = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbxSimulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParkingSlots)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // lblCurrentLevel
            // 
            this.lblCurrentLevel.AutoSize = true;
            this.lblCurrentLevel.Location = new System.Drawing.Point(471, 307);
            this.lblCurrentLevel.Name = "lblCurrentLevel";
            this.lblCurrentLevel.Size = new System.Drawing.Size(13, 13);
            this.lblCurrentLevel.TabIndex = 3;
            this.lblCurrentLevel.Text = "0";
            // 
            // btnLevelUp
            // 
            this.btnLevelUp.Font = new System.Drawing.Font("Wingdings", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnLevelUp.Location = new System.Drawing.Point(450, 332);
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
            this.btnLevelDown.Location = new System.Drawing.Point(450, 388);
            this.btnLevelDown.Name = "btnLevelDown";
            this.btnLevelDown.Size = new System.Drawing.Size(50, 50);
            this.btnLevelDown.TabIndex = 5;
            this.btnLevelDown.Text = "H";
            this.btnLevelDown.UseVisualStyleBackColor = true;
            this.btnLevelDown.Click += new System.EventHandler(this.btnLevelDown_Click);
            // 
            // gbxSimulation
            // 
            this.gbxSimulation.Controls.Add(this.btnParkingSlot);
            this.gbxSimulation.Location = new System.Drawing.Point(12, 12);
            this.gbxSimulation.Name = "gbxSimulation";
            this.gbxSimulation.Size = new System.Drawing.Size(432, 426);
            this.gbxSimulation.TabIndex = 6;
            this.gbxSimulation.TabStop = false;
            this.gbxSimulation.Text = "Building";
            // 
            // lblVehicleInfo
            // 
            this.lblVehicleInfo.AutoSize = true;
            this.lblVehicleInfo.Location = new System.Drawing.Point(450, 20);
            this.lblVehicleInfo.Name = "lblVehicleInfo";
            this.lblVehicleInfo.Size = new System.Drawing.Size(63, 13);
            this.lblVehicleInfo.TabIndex = 11;
            this.lblVehicleInfo.Text = "Vehicle Info";
            // 
            // lblBuildingInfo
            // 
            this.lblBuildingInfo.AutoSize = true;
            this.lblBuildingInfo.Location = new System.Drawing.Point(447, 200);
            this.lblBuildingInfo.Name = "lblBuildingInfo";
            this.lblBuildingInfo.Size = new System.Drawing.Size(65, 13);
            this.lblBuildingInfo.TabIndex = 12;
            this.lblBuildingInfo.Text = "Building Info";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(450, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(34, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(490, 120);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(34, 23);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnParkingSlot
            // 
            this.btnParkingSlot.Location = new System.Drawing.Point(6, 19);
            this.btnParkingSlot.Name = "btnParkingSlot";
            this.btnParkingSlot.Size = new System.Drawing.Size(50, 100);
            this.btnParkingSlot.TabIndex = 0;
            this.btnParkingSlot.UseVisualStyleBackColor = true;
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
            this.groupBox1.Location = new System.Drawing.Point(619, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 152);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Building";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxType);
            this.groupBox2.Controls.Add(this.tbxNameplate);
            this.groupBox2.Controls.Add(this.btnAddVehicle);
            this.groupBox2.Location = new System.Drawing.Point(637, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 123);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Vehicle";
            // 
            // FrmSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblBuildingInfo);
            this.Controls.Add(this.lblVehicleInfo);
            this.Controls.Add(this.gbxSimulation);
            this.Controls.Add(this.btnLevelDown);
            this.Controls.Add(this.btnLevelUp);
            this.Controls.Add(this.lblCurrentLevel);
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

        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.TextBox tbxNameplate;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label lblCurrentLevel;
        private System.Windows.Forms.Button btnLevelUp;
        private System.Windows.Forms.Button btnLevelDown;
        private System.Windows.Forms.GroupBox gbxSimulation;
        private System.Windows.Forms.Label lblVehicleInfo;
        private System.Windows.Forms.Label lblBuildingInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnParkingSlot;
        private System.Windows.Forms.NumericUpDown nudLevels;
        private System.Windows.Forms.TextBox tbxBuildingName;
        private System.Windows.Forms.NumericUpDown nudParkingSlots;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblParkingSlots;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

