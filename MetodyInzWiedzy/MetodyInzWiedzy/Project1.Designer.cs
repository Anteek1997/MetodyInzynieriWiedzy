namespace MetodyInzWiedzy
{
  partial class Project1
  {
    /// <summary> 
    /// Wymagana zmienna projektanta.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Wyczyść wszystkie używane zasoby.
    /// </summary>
    /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Kod wygenerowany przez Projektanta składników

    /// <summary> 
    /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
    /// jej zawartości w edytorze kodu.
    /// </summary>
    private void InitializeComponent()
    {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.btnNormalizuj = new System.Windows.Forms.Button();
            this.btnSaveXML = new System.Windows.Forms.Button();
            this.btnSaveJSON = new System.Windows.Forms.Button();
            this.btnSaveTXT = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Projekt1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.project1cz21 = new MetodyInzWiedzy.Project1cz2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1413, 524);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(1198, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 69);
            this.button3.TabIndex = 3;
            this.button3.Text = "Wczytaj dane";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNormalizuj
            // 
            this.btnNormalizuj.BackColor = System.Drawing.Color.White;
            this.btnNormalizuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNormalizuj.Location = new System.Drawing.Point(1198, 87);
            this.btnNormalizuj.Name = "btnNormalizuj";
            this.btnNormalizuj.Size = new System.Drawing.Size(218, 60);
            this.btnNormalizuj.TabIndex = 4;
            this.btnNormalizuj.Text = "Normalizuj";
            this.btnNormalizuj.UseVisualStyleBackColor = false;
            this.btnNormalizuj.Click += new System.EventHandler(this.btnNormalizuj_Click);
            // 
            // btnSaveXML
            // 
            this.btnSaveXML.BackColor = System.Drawing.Color.White;
            this.btnSaveXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveXML.Location = new System.Drawing.Point(157, 701);
            this.btnSaveXML.Name = "btnSaveXML";
            this.btnSaveXML.Size = new System.Drawing.Size(309, 68);
            this.btnSaveXML.TabIndex = 5;
            this.btnSaveXML.Text = "Zapisz dane w XML";
            this.btnSaveXML.UseVisualStyleBackColor = false;
            this.btnSaveXML.Click += new System.EventHandler(this.btnSaveXML_Click);
            // 
            // btnSaveJSON
            // 
            this.btnSaveJSON.BackColor = System.Drawing.Color.White;
            this.btnSaveJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveJSON.Location = new System.Drawing.Point(539, 701);
            this.btnSaveJSON.Name = "btnSaveJSON";
            this.btnSaveJSON.Size = new System.Drawing.Size(332, 68);
            this.btnSaveJSON.TabIndex = 6;
            this.btnSaveJSON.Text = "Zapisz dane w JSON";
            this.btnSaveJSON.UseVisualStyleBackColor = false;
            this.btnSaveJSON.Click += new System.EventHandler(this.btnSaveJSON_Click);
            // 
            // btnSaveTXT
            // 
            this.btnSaveTXT.BackColor = System.Drawing.Color.White;
            this.btnSaveTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveTXT.Location = new System.Drawing.Point(946, 701);
            this.btnSaveTXT.Name = "btnSaveTXT";
            this.btnSaveTXT.Size = new System.Drawing.Size(332, 68);
            this.btnSaveTXT.TabIndex = 7;
            this.btnSaveTXT.Text = "Zapisz dane w TXT";
            this.btnSaveTXT.UseVisualStyleBackColor = false;
            this.btnSaveTXT.Click += new System.EventHandler(this.btnSaveTXT_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNext.Image = global::MetodyInzWiedzy.Properties.Resources.right_arrow;
            this.btnNext.Location = new System.Drawing.Point(1297, 775);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(110, 85);
            this.btnNext.TabIndex = 10;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = global::MetodyInzWiedzy.Properties.Resources.iconfinder_icon_ios7_undo_211838;
            this.button2.Location = new System.Drawing.Point(3, 779);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 85);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1416, 864);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Projekt1
            // 
            this.Projekt1.AutoSize = true;
            this.Projekt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Projekt1.Location = new System.Drawing.Point(411, 11);
            this.Projekt1.Name = "Projekt1";
            this.Projekt1.Size = new System.Drawing.Size(604, 55);
            this.Projekt1.TabIndex = 11;
            this.Projekt1.Text = "Pierwsza część projektu 1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(24, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(484, 68);
            this.button1.TabIndex = 12;
            this.button1.Text = "Stwórz Plik Konfiguracyjny";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // project1cz21
            // 
            this.project1cz21.BackColor = System.Drawing.Color.Gold;
            this.project1cz21.Location = new System.Drawing.Point(0, 0);
            this.project1cz21.Name = "project1cz21";
            this.project1cz21.Size = new System.Drawing.Size(1420, 864);
            this.project1cz21.TabIndex = 9;
            // 
            // Project1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Projekt1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSaveTXT);
            this.Controls.Add(this.btnSaveJSON);
            this.Controls.Add(this.btnSaveXML);
            this.Controls.Add(this.btnNormalizuj);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.project1cz21);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Project1";
            this.Size = new System.Drawing.Size(1774, 1085);
            this.Load += new System.EventHandler(this.Project1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button btnNormalizuj;
    private System.Windows.Forms.Button btnSaveXML;
    private System.Windows.Forms.Button btnSaveJSON;
    private System.Windows.Forms.Button btnSaveTXT;
    private System.Windows.Forms.PictureBox pictureBox1;
    private Project1cz2 project1cz21;
    private System.Windows.Forms.Button btnNext;
    private System.Windows.Forms.Label Projekt1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
  }
}
