
namespace MVP.View
{
    partial class GUIDieteticean
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIDieteticean));
            this.searchText = new System.Windows.Forms.TextBox();
            this.Statistici = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Varsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Greutate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dieta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filtru1 = new System.Windows.Forms.ComboBox();
            this.comboGrafic = new System.Windows.Forms.ComboBox();
            this.filtruText = new System.Windows.Forms.TextBox();
            this.grafic1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Filtrare = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafic1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(622, 75);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(148, 22);
            this.searchText.TabIndex = 3;
            // 
            // Statistici
            // 
            this.Statistici.Location = new System.Drawing.Point(916, 22);
            this.Statistici.Name = "Statistici";
            this.Statistici.Size = new System.Drawing.Size(127, 75);
            this.Statistici.TabIndex = 7;
            this.Statistici.Text = "Statistici";
            this.Statistici.UseVisualStyleBackColor = true;
            this.Statistici.Click += new System.EventHandler(this.Statistici_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nume,
            this.Varsta,
            this.Greutate,
            this.Dieta});
            this.dataGridView2.Location = new System.Drawing.Point(12, 230);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(726, 205);
            this.dataGridView2.TabIndex = 9;
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Nume";
            this.Nume.MinimumWidth = 6;
            this.Nume.Name = "Nume";
            this.Nume.Width = 125;
            // 
            // Varsta
            // 
            this.Varsta.HeaderText = "Varsta";
            this.Varsta.MinimumWidth = 6;
            this.Varsta.Name = "Varsta";
            this.Varsta.Width = 125;
            // 
            // Greutate
            // 
            this.Greutate.HeaderText = "Greutate";
            this.Greutate.MinimumWidth = 6;
            this.Greutate.Name = "Greutate";
            this.Greutate.Width = 125;
            // 
            // Dieta
            // 
            this.Dieta.HeaderText = "Dieta";
            this.Dieta.MinimumWidth = 6;
            this.Dieta.Name = "Dieta";
            this.Dieta.Width = 125;
            // 
            // filtru1
            // 
            this.filtru1.FormattingEnabled = true;
            this.filtru1.Items.AddRange(new object[] {
            "varsta",
            "greutate",
            "dieta"});
            this.filtru1.Location = new System.Drawing.Point(425, 22);
            this.filtru1.Name = "filtru1";
            this.filtru1.Size = new System.Drawing.Size(121, 24);
            this.filtru1.TabIndex = 10;
            // 
            // comboGrafic
            // 
            this.comboGrafic.FormattingEnabled = true;
            this.comboGrafic.Items.AddRange(new object[] {
            "greutate",
            "varsta"});
            this.comboGrafic.Location = new System.Drawing.Point(916, 117);
            this.comboGrafic.Name = "comboGrafic";
            this.comboGrafic.Size = new System.Drawing.Size(127, 24);
            this.comboGrafic.TabIndex = 11;
            // 
            // filtruText
            // 
            this.filtruText.Location = new System.Drawing.Point(425, 75);
            this.filtruText.Name = "filtruText";
            this.filtruText.Size = new System.Drawing.Size(121, 22);
            this.filtruText.TabIndex = 12;
            // 
            // grafic1
            // 
            chartArea1.Name = "ChartArea1";
            this.grafic1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafic1.Legends.Add(legend1);
            this.grafic1.Location = new System.Drawing.Point(761, 201);
            this.grafic1.Name = "grafic1";
            this.grafic1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafic1.Series.Add(series1);
            this.grafic1.Size = new System.Drawing.Size(423, 356);
            this.grafic1.TabIndex = 13;
            this.grafic1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(534, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 49);
            this.button1.TabIndex = 14;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(622, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 47);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cautare Client";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Filtrare
            // 
            this.Filtrare.Location = new System.Drawing.Point(245, 22);
            this.Filtrare.Name = "Filtrare";
            this.Filtrare.Size = new System.Drawing.Size(148, 75);
            this.Filtrare.TabIndex = 1;
            this.Filtrare.Text = "Filtrare";
            this.Filtrare.UseVisualStyleBackColor = true;
            this.Filtrare.Click += new System.EventHandler(this.Filtrare_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 75);
            this.button3.TabIndex = 16;
            this.button3.Text = "Vizualizare Clienti";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GUIDieteticean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1214, 618);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grafic1);
            this.Controls.Add(this.filtruText);
            this.Controls.Add(this.comboGrafic);
            this.Controls.Add(this.filtru1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Statistici);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.Filtrare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GUIDieteticean";
            this.Text = "Dieteticean";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button Statistici;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Varsta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Greutate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dieta;
        private System.Windows.Forms.ComboBox filtru1;
        private System.Windows.Forms.ComboBox comboGrafic;
        private System.Windows.Forms.TextBox filtruText;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafic1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Filtrare;
        private System.Windows.Forms.Button button3;
    }
}