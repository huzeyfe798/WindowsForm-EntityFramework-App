namespace EntityFrameworkCarGalery.Forms
{
    partial class AddForm
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
            this.textTypeName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddTypeBut = new System.Windows.Forms.Button();
            this.ClearTypeBut = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClearBMBut = new System.Windows.Forms.Button();
            this.AddBMBut = new System.Windows.Forms.Button();
            this.BrandTextName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ClearVehicleBut = new System.Windows.Forms.Button();
            this.AddVehicleBut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.vehicleNameText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ModelTextName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fuelTypeText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.yearText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kmText = new System.Windows.Forms.TextBox();
            this.brandCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbM = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbT = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.clearBrand = new System.Windows.Forms.Button();
            this.AddBrand = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.brandCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textTypeName
            // 
            this.textTypeName.Location = new System.Drawing.Point(10, 46);
            this.textTypeName.Name = "textTypeName";
            this.textTypeName.Size = new System.Drawing.Size(184, 20);
            this.textTypeName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearTypeBut);
            this.groupBox1.Controls.Add(this.AddTypeBut);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textTypeName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 229);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Types";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type Name:";
            // 
            // AddTypeBut
            // 
            this.AddTypeBut.Location = new System.Drawing.Point(10, 165);
            this.AddTypeBut.Name = "AddTypeBut";
            this.AddTypeBut.Size = new System.Drawing.Size(75, 23);
            this.AddTypeBut.TabIndex = 2;
            this.AddTypeBut.Text = "Add";
            this.AddTypeBut.UseVisualStyleBackColor = true;
            this.AddTypeBut.Click += new System.EventHandler(this.AddTypeBut_Click);
            // 
            // ClearTypeBut
            // 
            this.ClearTypeBut.Location = new System.Drawing.Point(119, 165);
            this.ClearTypeBut.Name = "ClearTypeBut";
            this.ClearTypeBut.Size = new System.Drawing.Size(75, 23);
            this.ClearTypeBut.TabIndex = 3;
            this.ClearTypeBut.Text = "Clear";
            this.ClearTypeBut.UseVisualStyleBackColor = true;
            this.ClearTypeBut.Click += new System.EventHandler(this.ClearTypeBut_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.brandCombo);
            this.groupBox2.Controls.Add(this.ModelTextName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ClearBMBut);
            this.groupBox2.Controls.Add(this.AddBMBut);
            this.groupBox2.Location = new System.Drawing.Point(287, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 229);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add  Model";
            // 
            // ClearBMBut
            // 
            this.ClearBMBut.Location = new System.Drawing.Point(119, 165);
            this.ClearBMBut.Name = "ClearBMBut";
            this.ClearBMBut.Size = new System.Drawing.Size(75, 23);
            this.ClearBMBut.TabIndex = 3;
            this.ClearBMBut.Text = "Clear";
            this.ClearBMBut.UseVisualStyleBackColor = true;
            this.ClearBMBut.Click += new System.EventHandler(this.ClearBMBut_Click);
            // 
            // AddBMBut
            // 
            this.AddBMBut.Location = new System.Drawing.Point(10, 165);
            this.AddBMBut.Name = "AddBMBut";
            this.AddBMBut.Size = new System.Drawing.Size(75, 23);
            this.AddBMBut.TabIndex = 2;
            this.AddBMBut.Text = "Add";
            this.AddBMBut.UseVisualStyleBackColor = true;
            this.AddBMBut.Click += new System.EventHandler(this.AddBMBut_Click);
            // 
            // BrandTextName
            // 
            this.BrandTextName.Location = new System.Drawing.Point(10, 46);
            this.BrandTextName.Name = "BrandTextName";
            this.BrandTextName.Size = new System.Drawing.Size(184, 20);
            this.BrandTextName.TabIndex = 0;
            // 
            // groupBox3
            // 
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
            this.groupBox3.Controls.Add(this.AddVehicleBut);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.vehicleNameText);
            this.groupBox3.Location = new System.Drawing.Point(561, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 388);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Vehicle";
            // 
            // ClearVehicleBut
            // 
            this.ClearVehicleBut.Location = new System.Drawing.Point(119, 336);
            this.ClearVehicleBut.Name = "ClearVehicleBut";
            this.ClearVehicleBut.Size = new System.Drawing.Size(75, 23);
            this.ClearVehicleBut.TabIndex = 3;
            this.ClearVehicleBut.Text = "Clear";
            this.ClearVehicleBut.UseVisualStyleBackColor = true;
            this.ClearVehicleBut.Click += new System.EventHandler(this.ClearVehicleBut_Click);
            // 
            // AddVehicleBut
            // 
            this.AddVehicleBut.Location = new System.Drawing.Point(10, 336);
            this.AddVehicleBut.Name = "AddVehicleBut";
            this.AddVehicleBut.Size = new System.Drawing.Size(75, 23);
            this.AddVehicleBut.TabIndex = 2;
            this.AddVehicleBut.Text = "Add";
            this.AddVehicleBut.UseVisualStyleBackColor = true;
            this.AddVehicleBut.Click += new System.EventHandler(this.AddVehicleBut_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Model Name:";
            // 
            // ModelTextName
            // 
            this.ModelTextName.Location = new System.Drawing.Point(6, 85);
            this.ModelTextName.Name = "ModelTextName";
            this.ModelTextName.Size = new System.Drawing.Size(184, 20);
            this.ModelTextName.TabIndex = 5;
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
            // fuelTypeText
            // 
            this.fuelTypeText.Location = new System.Drawing.Point(10, 85);
            this.fuelTypeText.Name = "fuelTypeText";
            this.fuelTypeText.Size = new System.Drawing.Size(184, 20);
            this.fuelTypeText.TabIndex = 5;
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
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(10, 124);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(184, 20);
            this.yearText.TabIndex = 7;
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
            // kmText
            // 
            this.kmText.Location = new System.Drawing.Point(10, 163);
            this.kmText.Name = "kmText";
            this.kmText.Size = new System.Drawing.Size(184, 20);
            this.kmText.TabIndex = 9;
            // 
            // brandCB
            // 
            this.brandCB.FormattingEnabled = true;
            this.brandCB.Location = new System.Drawing.Point(10, 208);
            this.brandCB.Name = "brandCB";
            this.brandCB.Size = new System.Drawing.Size(184, 21);
            this.brandCB.TabIndex = 10;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Model";
            // 
            // cbM
            // 
            this.cbM.FormattingEnabled = true;
            this.cbM.Location = new System.Drawing.Point(10, 248);
            this.cbM.Name = "cbM";
            this.cbM.Size = new System.Drawing.Size(184, 21);
            this.cbM.TabIndex = 13;
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
            // cbT
            // 
            this.cbT.FormattingEnabled = true;
            this.cbT.Location = new System.Drawing.Point(10, 288);
            this.cbT.Name = "cbT";
            this.cbT.Size = new System.Drawing.Size(184, 21);
            this.cbT.TabIndex = 15;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.clearBrand);
            this.groupBox4.Controls.Add(this.AddBrand);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.BrandTextName);
            this.groupBox4.Location = new System.Drawing.Point(12, 260);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(206, 178);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add Brand ";
            // 
            // clearBrand
            // 
            this.clearBrand.Location = new System.Drawing.Point(119, 133);
            this.clearBrand.Name = "clearBrand";
            this.clearBrand.Size = new System.Drawing.Size(75, 23);
            this.clearBrand.TabIndex = 3;
            this.clearBrand.Text = "Clear";
            this.clearBrand.UseVisualStyleBackColor = true;
            this.clearBrand.Click += new System.EventHandler(this.clearBrand_Click);
            // 
            // AddBrand
            // 
            this.AddBrand.Location = new System.Drawing.Point(10, 133);
            this.AddBrand.Name = "AddBrand";
            this.AddBrand.Size = new System.Drawing.Size(75, 23);
            this.AddBrand.TabIndex = 2;
            this.AddBrand.Text = "Add";
            this.AddBrand.UseVisualStyleBackColor = true;
            this.AddBrand.Click += new System.EventHandler(this.AddBrand_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Brand Name:";
            // 
            // brandCombo
            // 
            this.brandCombo.FormattingEnabled = true;
            this.brandCombo.Location = new System.Drawing.Point(6, 46);
            this.brandCombo.Name = "brandCombo";
            this.brandCombo.Size = new System.Drawing.Size(184, 21);
            this.brandCombo.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Brand";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textTypeName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ClearTypeBut;
        private System.Windows.Forms.Button AddTypeBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ModelTextName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ClearBMBut;
        private System.Windows.Forms.Button AddBMBut;
        private System.Windows.Forms.TextBox BrandTextName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox kmText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fuelTypeText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ClearVehicleBut;
        private System.Windows.Forms.Button AddVehicleBut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vehicleNameText;
        private System.Windows.Forms.ComboBox cbT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox brandCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox brandCombo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button clearBrand;
        private System.Windows.Forms.Button AddBrand;
        private System.Windows.Forms.Label label12;
    }
}