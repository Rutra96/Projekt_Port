namespace Program_Port
{
    partial class Form1
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.insert_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.Search_btn = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.kodPort_label = new System.Windows.Forms.Label();
            this.data_label = new System.Windows.Forms.Label();
            this.godzina_label = new System.Windows.Forms.Label();
            this.kodPortuZ_label = new System.Windows.Forms.Label();
            this.NazwaStatku_label = new System.Windows.Forms.Label();
            this.bandera_label = new System.Windows.Forms.Label();
            this.nrIMO_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kodPortu_tb = new System.Windows.Forms.TextBox();
            this.kodPortuZ_tb = new System.Windows.Forms.TextBox();
            this.godzina_tb = new System.Windows.Forms.TextBox();
            this.pojemnosc_tb = new System.Windows.Forms.TextBox();
            this.dlugosc_tb = new System.Windows.Forms.TextBox();
            this.bandera_tb = new System.Windows.Forms.TextBox();
            this.nazwaStatku_tb = new System.Windows.Forms.TextBox();
            this.nrIMO_tb = new System.Windows.Forms.TextBox();
            this.sygnal_tb = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(406, 319);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(75, 23);
            this.insert_btn.TabIndex = 0;
            this.insert_btn.Text = "Dodaj";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(506, 319);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 1;
            this.delete_btn.Text = "Usuń";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.Location = new System.Drawing.Point(605, 319);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(75, 23);
            this.Update_btn.TabIndex = 2;
            this.Update_btn.Text = "Aktualizuj";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(693, 319);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(75, 23);
            this.refresh_btn.TabIndex = 3;
            this.refresh_btn.Text = "Odśwież";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(793, 319);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(75, 23);
            this.Search_btn.TabIndex = 4;
            this.Search_btn.Text = "Wyszukaj";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(43, 377);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1160, 273);
            this.dgv.TabIndex = 5;
            // 
            // kodPort_label
            // 
            this.kodPort_label.AutoSize = true;
            this.kodPort_label.Location = new System.Drawing.Point(382, 78);
            this.kodPort_label.Name = "kodPort_label";
            this.kodPort_label.Size = new System.Drawing.Size(54, 13);
            this.kodPort_label.TabIndex = 6;
            this.kodPort_label.Text = "Kod Portu";
            // 
            // data_label
            // 
            this.data_label.AutoSize = true;
            this.data_label.Location = new System.Drawing.Point(382, 119);
            this.data_label.Name = "data_label";
            this.data_label.Size = new System.Drawing.Size(30, 13);
            this.data_label.TabIndex = 7;
            this.data_label.Text = "Data";
            // 
            // godzina_label
            // 
            this.godzina_label.AutoSize = true;
            this.godzina_label.Location = new System.Drawing.Point(382, 157);
            this.godzina_label.Name = "godzina_label";
            this.godzina_label.Size = new System.Drawing.Size(46, 13);
            this.godzina_label.TabIndex = 8;
            this.godzina_label.Text = "Godzina";
            // 
            // kodPortuZ_label
            // 
            this.kodPortuZ_label.AutoSize = true;
            this.kodPortuZ_label.Location = new System.Drawing.Point(382, 194);
            this.kodPortuZ_label.Name = "kodPortuZ_label";
            this.kodPortuZ_label.Size = new System.Drawing.Size(112, 26);
            this.kodPortuZ_label.TabIndex = 9;
            this.kodPortuZ_label.Text = "Kod portu, z którego \r\njednostka przypłynęła";
            // 
            // NazwaStatku_label
            // 
            this.NazwaStatku_label.AutoSize = true;
            this.NazwaStatku_label.Location = new System.Drawing.Point(382, 241);
            this.NazwaStatku_label.Name = "NazwaStatku_label";
            this.NazwaStatku_label.Size = new System.Drawing.Size(74, 13);
            this.NazwaStatku_label.TabIndex = 10;
            this.NazwaStatku_label.Text = "Nazwa Statku";
            // 
            // bandera_label
            // 
            this.bandera_label.AutoSize = true;
            this.bandera_label.Location = new System.Drawing.Point(665, 75);
            this.bandera_label.Name = "bandera_label";
            this.bandera_label.Size = new System.Drawing.Size(47, 13);
            this.bandera_label.TabIndex = 11;
            this.bandera_label.Text = "Bandera";
            // 
            // nrIMO_label
            // 
            this.nrIMO_label.AutoSize = true;
            this.nrIMO_label.Location = new System.Drawing.Point(662, 119);
            this.nrIMO_label.Name = "nrIMO_label";
            this.nrIMO_label.Size = new System.Drawing.Size(39, 13);
            this.nrIMO_label.TabIndex = 12;
            this.nrIMO_label.Text = "nr IMO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(662, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sygnał Wywoławczy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(662, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pojemność";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(665, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Długość";
            // 
            // kodPortu_tb
            // 
            this.kodPortu_tb.Location = new System.Drawing.Point(506, 75);
            this.kodPortu_tb.Name = "kodPortu_tb";
            this.kodPortu_tb.Size = new System.Drawing.Size(100, 20);
            this.kodPortu_tb.TabIndex = 16;
            // 
            // kodPortuZ_tb
            // 
            this.kodPortuZ_tb.Location = new System.Drawing.Point(506, 197);
            this.kodPortuZ_tb.Name = "kodPortuZ_tb";
            this.kodPortuZ_tb.Size = new System.Drawing.Size(100, 20);
            this.kodPortuZ_tb.TabIndex = 18;
            // 
            // godzina_tb
            // 
            this.godzina_tb.Location = new System.Drawing.Point(506, 154);
            this.godzina_tb.Name = "godzina_tb";
            this.godzina_tb.Size = new System.Drawing.Size(100, 20);
            this.godzina_tb.TabIndex = 19;
            // 
            // pojemnosc_tb
            // 
            this.pojemnosc_tb.Location = new System.Drawing.Point(789, 191);
            this.pojemnosc_tb.Name = "pojemnosc_tb";
            this.pojemnosc_tb.Size = new System.Drawing.Size(100, 20);
            this.pojemnosc_tb.TabIndex = 20;
            // 
            // dlugosc_tb
            // 
            this.dlugosc_tb.Location = new System.Drawing.Point(789, 238);
            this.dlugosc_tb.Name = "dlugosc_tb";
            this.dlugosc_tb.Size = new System.Drawing.Size(100, 20);
            this.dlugosc_tb.TabIndex = 21;
            // 
            // bandera_tb
            // 
            this.bandera_tb.Location = new System.Drawing.Point(789, 75);
            this.bandera_tb.Name = "bandera_tb";
            this.bandera_tb.Size = new System.Drawing.Size(100, 20);
            this.bandera_tb.TabIndex = 22;
            // 
            // nazwaStatku_tb
            // 
            this.nazwaStatku_tb.Location = new System.Drawing.Point(506, 241);
            this.nazwaStatku_tb.Name = "nazwaStatku_tb";
            this.nazwaStatku_tb.Size = new System.Drawing.Size(100, 20);
            this.nazwaStatku_tb.TabIndex = 23;
            // 
            // nrIMO_tb
            // 
            this.nrIMO_tb.Location = new System.Drawing.Point(789, 116);
            this.nrIMO_tb.Name = "nrIMO_tb";
            this.nrIMO_tb.Size = new System.Drawing.Size(100, 20);
            this.nrIMO_tb.TabIndex = 24;
            // 
            // sygnal_tb
            // 
            this.sygnal_tb.Location = new System.Drawing.Point(789, 154);
            this.sygnal_tb.Name = "sygnal_tb";
            this.sygnal_tb.Size = new System.Drawing.Size(100, 20);
            this.sygnal_tb.TabIndex = 25;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "PRZYBYCIA Statków";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 59);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(115, 17);
            this.checkBox2.TabIndex = 27;
            this.checkBox2.Text = "WYJŚCIA Statków";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Location = new System.Drawing.Point(43, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 92);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statek :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Przybycia";
            this.label1.Visible = false;
            // 
            // id_tb
            // 
            this.id_tb.Location = new System.Drawing.Point(506, 35);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(100, 20);
            this.id_tb.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Id";
            // 
            // dtp
            // 
            this.dtp.CustomFormat = "dd-MM-yyyy";
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(506, 113);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(100, 20);
            this.dtp.TabIndex = 33;
            this.dtp.Value = new System.DateTime(2020, 6, 4, 0, 0, 0, 0);
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 662);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sygnal_tb);
            this.Controls.Add(this.nrIMO_tb);
            this.Controls.Add(this.nazwaStatku_tb);
            this.Controls.Add(this.bandera_tb);
            this.Controls.Add(this.dlugosc_tb);
            this.Controls.Add(this.pojemnosc_tb);
            this.Controls.Add(this.godzina_tb);
            this.Controls.Add(this.kodPortuZ_tb);
            this.Controls.Add(this.kodPortu_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nrIMO_label);
            this.Controls.Add(this.bandera_label);
            this.Controls.Add(this.NazwaStatku_label);
            this.Controls.Add(this.kodPortuZ_label);
            this.Controls.Add(this.godzina_label);
            this.Controls.Add(this.data_label);
            this.Controls.Add(this.kodPort_label);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.insert_btn);
            this.Name = "Form1";
            this.Text = "Program Portowy";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label kodPort_label;
        private System.Windows.Forms.Label data_label;
        private System.Windows.Forms.Label godzina_label;
        private System.Windows.Forms.Label kodPortuZ_label;
        private System.Windows.Forms.Label NazwaStatku_label;
        private System.Windows.Forms.Label bandera_label;
        private System.Windows.Forms.Label nrIMO_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kodPortu_tb;
        private System.Windows.Forms.TextBox kodPortuZ_tb;
        private System.Windows.Forms.TextBox godzina_tb;
        private System.Windows.Forms.TextBox pojemnosc_tb;
        private System.Windows.Forms.TextBox dlugosc_tb;
        private System.Windows.Forms.TextBox bandera_tb;
        private System.Windows.Forms.TextBox nazwaStatku_tb;
        private System.Windows.Forms.TextBox nrIMO_tb;
        private System.Windows.Forms.TextBox sygnal_tb;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp;
    }
}

