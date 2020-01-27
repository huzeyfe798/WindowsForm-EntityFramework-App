namespace EntityFrameworkCarGalery.Forms
{
    partial class BrowseForm
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
            this.vehicleGridB = new System.Windows.Forms.DataGridView();
            this.filterButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.Filter = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modelsFilter = new System.Windows.Forms.ComboBox();
            this.brandsFilter = new System.Windows.Forms.ComboBox();
            this.typesFilter = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleGridB)).BeginInit();
            this.Filter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehicleGridB
            // 
            this.vehicleGridB.AllowUserToAddRows = false;
            this.vehicleGridB.AllowUserToDeleteRows = false;
            this.vehicleGridB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleGridB.Location = new System.Drawing.Point(12, 104);
            this.vehicleGridB.Name = "vehicleGridB";
            this.vehicleGridB.ReadOnly = true;
            this.vehicleGridB.Size = new System.Drawing.Size(776, 334);
            this.vehicleGridB.TabIndex = 0;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(330, 71);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 23);
            this.filterButton.TabIndex = 1;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(196, 66);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(6, 68);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(184, 20);
            this.searchText.TabIndex = 3;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(411, 71);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Filter
            // 
            this.Filter.Controls.Add(this.label3);
            this.Filter.Controls.Add(this.label2);
            this.Filter.Controls.Add(this.label1);
            this.Filter.Controls.Add(this.modelsFilter);
            this.Filter.Controls.Add(this.brandsFilter);
            this.Filter.Controls.Add(this.typesFilter);
            this.Filter.Controls.Add(this.filterButton);
            this.Filter.Controls.Add(this.clearButton);
            this.Filter.Location = new System.Drawing.Point(12, 2);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(492, 96);
            this.Filter.TabIndex = 5;
            this.Filter.TabStop = false;
            this.Filter.Text = "Filter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Models";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Brands";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Types";
            // 
            // modelsFilter
            // 
            this.modelsFilter.FormattingEnabled = true;
            this.modelsFilter.Location = new System.Drawing.Point(260, 46);
            this.modelsFilter.Name = "modelsFilter";
            this.modelsFilter.Size = new System.Drawing.Size(121, 21);
            this.modelsFilter.TabIndex = 7;
            // 
            // brandsFilter
            // 
            this.brandsFilter.FormattingEnabled = true;
            this.brandsFilter.Location = new System.Drawing.Point(133, 46);
            this.brandsFilter.Name = "brandsFilter";
            this.brandsFilter.Size = new System.Drawing.Size(121, 21);
            this.brandsFilter.TabIndex = 6;
            this.brandsFilter.SelectionChangeCommitted += new System.EventHandler(this.brandsFilter_SelectionChangeCommitted);
            // 
            // typesFilter
            // 
            this.typesFilter.FormattingEnabled = true;
            this.typesFilter.Location = new System.Drawing.Point(6, 46);
            this.typesFilter.Name = "typesFilter";
            this.typesFilter.Size = new System.Drawing.Size(121, 21);
            this.typesFilter.TabIndex = 5;
            this.typesFilter.SelectionChangeCommitted += new System.EventHandler(this.typesFilter_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.searchText);
            this.groupBox1.Location = new System.Drawing.Point(510, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 96);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // BrowseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.vehicleGridB);
            this.Name = "BrowseForm";
            this.Text = "Browse";
            this.Load += new System.EventHandler(this.BrowseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleGridB)).EndInit();
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView vehicleGridB;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox Filter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox modelsFilter;
        private System.Windows.Forms.ComboBox brandsFilter;
        private System.Windows.Forms.ComboBox typesFilter;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}