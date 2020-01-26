namespace EntityFrameworkCarGalery.Forms
{
    partial class UpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VehicleGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbT = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbM = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.brandCB = new System.Windows.Forms.ComboBox();
            this.kmText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.yearText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fuelTypeText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ClearVehicleBut = new System.Windows.Forms.Button();
            this.UpdateVehicleBut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.vehicleNameText = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // VehicleGridView
            // 
            this.VehicleGridView.AllowUserToAddRows = false;
            this.VehicleGridView.AllowUserToDeleteRows = false;
            this.VehicleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehicleGridView.Location = new System.Drawing.Point(12, 12);
            this.VehicleGridView.Name = "VehicleGridView";
            this.VehicleGridView.ReadOnly = true;
            this.VehicleGridView.Size = new System.Drawing.Size(549, 426);
            this.VehicleGridView.TabIndex = 0;
            this.VehicleGridView.SelectionChanged += new System.EventHandler(this.VehicleGridView_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DeleteButton);
            this.groupBox3.Controls.Add(this.cbT);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cbM);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.brandCB);
            this.groupBox3.Controls.Add(this.kmText);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.yearText);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.fuelTypeText);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.ClearVehicleBut);
            this.groupBox3.Controls.Add(this.UpdateVehicleBut);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.vehicleNameText);
            this.groupBox3.Location = new System.Drawing.Point(582, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 426);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select And Update";
            // 
            // cbT
            // 
            this.cbT.FormattingEnabled = true;
            this.cbT.Location = new System.Drawing.Point(10, 288);
            this.cbT.Name = "cbT";
            this.cbT.Size = new System.Drawing.Size(184, 21);
            this.cbT.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Type";
            // 
            // cbM
            // 
            this.cbM.FormattingEnabled = true;
            this.cbM.Location = new System.Drawing.Point(10, 248);
            this.cbM.Name = "cbM";
            this.cbM.Size = new System.Drawing.Size(184, 21);
            this.cbM.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Model";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Brand";
            // 
            // brandCB
            // 
            this.brandCB.FormattingEnabled = true;
            this.brandCB.Location = new System.Drawing.Point(10, 208);
            this.brandCB.Name = "brandCB";
            this.brandCB.Size = new System.Drawing.Size(184, 21);
            this.brandCB.TabIndex = 10;
            // 
            // kmText
            // 
            this.kmText.Location = new System.Drawing.Point(10, 163);
            this.kmText.Name = "kmText";
            this.kmText.Size = new System.Drawing.Size(184, 20);
            this.kmText.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Km";
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(10, 124);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(184, 20);
            this.yearText.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Year";
            // 
            // fuelTypeText
            // 
            this.fuelTypeText.Location = new System.Drawing.Point(10, 85);
            this.fuelTypeText.Name = "fuelTypeText";
            this.fuelTypeText.Size = new System.Drawing.Size(184, 20);
            this.fuelTypeText.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "FuelType";
            // 
            // ClearVehicleBut
            // 
            this.ClearVehicleBut.Location = new System.Drawing.Point(119, 382);
            this.ClearVehicleBut.Name = "ClearVehicleBut";
            this.ClearVehicleBut.Size = new System.Drawing.Size(75, 23);
            this.ClearVehicleBut.TabIndex = 3;
            this.ClearVehicleBut.Text = "Clear";
            this.ClearVehicleBut.UseVisualStyleBackColor = true;
            this.ClearVehicleBut.Click += new System.EventHandler(this.ClearVehicleBut_Click);
            // 
            // UpdateVehicleBut
            // 
            this.UpdateVehicleBut.Location = new System.Drawing.Point(12, 382);
            this.UpdateVehicleBut.Name = "UpdateVehicleBut";
            this.UpdateVehicleBut.Size = new System.Drawing.Size(75, 23);
            this.UpdateVehicleBut.TabIndex = 2;
            this.UpdateVehicleBut.Text = "Update";
            this.UpdateVehicleBut.UseVisualStyleBackColor = true;
            this.UpdateVehicleBut.Click += new System.EventHandler(this.UpdateVehicleBut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Vehicle Name:";
            // 
            // vehicleNameText
            // 
            this.vehicleNameText.Location = new System.Drawing.Point(10, 46);
            this.vehicleNameText.Name = "vehicleNameText";
            this.vehicleNameText.Size = new System.Drawing.Size(184, 20);
            this.vehicleNameText.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(119, 353);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.VehicleGridView);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VehicleGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView VehicleGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox brandCB;
        private System.Windows.Forms.TextBox kmText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fuelTypeText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ClearVehicleBut;
        private System.Windows.Forms.Button UpdateVehicleBut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vehicleNameText;
        private System.Windows.Forms.Button DeleteButton;
    }
}