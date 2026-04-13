namespace ADHDLaarning
{
    partial class Main_Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkedListBox1 = new CheckedListBox();
            ButtonStart = new Button();
            ButtonReset = new Button();
            ButtonStop = new Button();
            licznik = new Label();
            MusicChoice = new ComboBox();
            Info1 = new TextBox();
            interwal = new TextBox();
            przerwa = new TextBox();
            Komunikat1 = new TextBox();
            Komunikat2 = new TextBox();
            Info2 = new TextBox();
            Info3 = new TextBox();
            DodajZadanie = new Button();
            UsunZadanie = new Button();
            ZapiszZadania = new Button();
            WczytajZadania = new Button();
            WprowadzZadanie = new TextBox();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            checkedListBox1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.HorizontalScrollbar = true;
            checkedListBox1.Location = new Point(14, 15);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.RightToLeft = RightToLeft.No;
            checkedListBox1.ScrollAlwaysVisible = true;
            checkedListBox1.Size = new Size(262, 148);
            checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ItemCheck += new ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // ButtonStart
            // 
            ButtonStart.BackColor = Color.White;
            ButtonStart.FlatStyle = FlatStyle.Popup;
            ButtonStart.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonStart.Location = new Point(14, 363);
            ButtonStart.Name = "ButtonStart";
            ButtonStart.Size = new Size(80, 30);
            ButtonStart.TabIndex = 1;
            ButtonStart.Text = "START";
            ButtonStart.UseVisualStyleBackColor = false;
            ButtonStart.Click += ButtonStart_Click;
            // 
            // ButtonReset
            // 
            ButtonReset.BackColor = Color.White;
            ButtonReset.FlatStyle = FlatStyle.Popup;
            ButtonReset.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonReset.Location = new Point(105, 363);
            ButtonReset.Name = "ButtonReset";
            ButtonReset.Size = new Size(80, 30);
            ButtonReset.TabIndex = 2;
            ButtonReset.Text = "RESET";
            ButtonReset.UseVisualStyleBackColor = false;
            ButtonReset.Click += ButtonReset_Click;
            // 
            // ButtonStop
            // 
            ButtonStop.BackColor = Color.White;
            ButtonStop.FlatStyle = FlatStyle.Popup;
            ButtonStop.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonStop.Location = new Point(196, 363);
            ButtonStop.Name = "ButtonStop";
            ButtonStop.Size = new Size(80, 30);
            ButtonStop.TabIndex = 3;
            ButtonStop.Text = "STOP";
            ButtonStop.UseVisualStyleBackColor = false;
            ButtonStop.Click += ButtonStop_Click;
            // 
            // licznik
            // 
            licznik.AutoSize = true;
            licznik.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            licznik.ForeColor = Color.White;
            licznik.Location = new Point(34, 289);
            licznik.Name = "licznik";
            licznik.Size = new Size(228, 55);
            licznik.TabIndex = 6;
            licznik.Text = "00:00:00";
            licznik.Visible = false;
            // 
            // MusicChoice
            // 
            MusicChoice.FormattingEnabled = true;
            MusicChoice.Location = new Point(14, 421);
            MusicChoice.Name = "MusicChoice";
            MusicChoice.Size = new Size(262, 23);
            MusicChoice.TabIndex = 8;
            // 
            // Info1
            // 
            Info1.BackColor = Color.FromArgb(0, 23, 31);
            Info1.BorderStyle = BorderStyle.None;
            Info1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Info1.ForeColor = Color.White;
            Info1.Location = new Point(35, 276);
            Info1.Name = "Info1";
            Info1.ReadOnly = true;
            Info1.Size = new Size(226, 14);
            Info1.TabIndex = 11;
            Info1.Text = "PODAJ OKRES NAUKI I CZAS PRZERW";
            // 
            // interwal
            // 
            interwal.BackColor = Color.FromArgb(0, 23, 31);
            interwal.BorderStyle = BorderStyle.None;
            interwal.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            interwal.ForeColor = Color.White;
            interwal.Location = new Point(63, 289);
            interwal.MaxLength = 2;
            interwal.Name = "interwal";
            interwal.Size = new Size(70, 56);
            interwal.TabIndex = 12;
            interwal.Text = "20";
            interwal.TextAlign = HorizontalAlignment.Center;
            interwal.TextChanged += interwal_TextChanged;
            // 
            // przerwa
            // 
            przerwa.BackColor = Color.FromArgb(0, 23, 31);
            przerwa.BorderStyle = BorderStyle.None;
            przerwa.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            przerwa.ForeColor = Color.White;
            przerwa.Location = new Point(159, 289);
            przerwa.MaxLength = 2;
            przerwa.Name = "przerwa";
            przerwa.Size = new Size(70, 56);
            przerwa.TabIndex = 13;
            przerwa.Text = "5";
            przerwa.TextAlign = HorizontalAlignment.Center;
            przerwa.TextChanged += przerwa_TextChanged;
            // 
            // Komunikat1
            // 
            Komunikat1.BackColor = Color.FromArgb(0, 23, 31);
            Komunikat1.BorderStyle = BorderStyle.None;
            Komunikat1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Komunikat1.ForeColor = Color.White;
            Komunikat1.Location = new Point(65, 343);
            Komunikat1.Name = "Komunikat1";
            Komunikat1.ReadOnly = true;
            Komunikat1.Size = new Size(77, 14);
            Komunikat1.TabIndex = 14;
            Komunikat1.Text = "INTERWAŁ";
            // 
            // Komunikat2
            // 
            Komunikat2.BackColor = Color.FromArgb(0, 23, 31);
            Komunikat2.BorderStyle = BorderStyle.None;
            Komunikat2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Komunikat2.ForeColor = Color.White;
            Komunikat2.Location = new Point(163, 343);
            Komunikat2.Name = "Komunikat2";
            Komunikat2.ReadOnly = true;
            Komunikat2.Size = new Size(71, 14);
            Komunikat2.TabIndex = 15;
            Komunikat2.Text = "PRZERWA";
            // 
            // Info2
            // 
            Info2.BackColor = Color.FromArgb(0, 23, 31);
            Info2.BorderStyle = BorderStyle.None;
            Info2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Info2.ForeColor = Color.White;
            Info2.Location = new Point(76, 343);
            Info2.Name = "Info2";
            Info2.ReadOnly = true;
            Info2.Size = new Size(226, 14);
            Info2.TabIndex = 16;
            Info2.Text = "POZOSTAŁY CZAS NAUKI";
            Info2.Visible = false;
            // 
            // Info3
            // 
            Info3.BackColor = Color.FromArgb(0, 23, 31);
            Info3.BorderStyle = BorderStyle.None;
            Info3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Info3.ForeColor = Color.White;
            Info3.Location = new Point(30, 400);
            Info3.Name = "Info3";
            Info3.ReadOnly = true;
            Info3.Size = new Size(226, 14);
            Info3.TabIndex = 17;
            Info3.Text = "WYBIERZ DŹWIĘK DO NAUKI";
            Info3.TextAlign = HorizontalAlignment.Center;
            // 
            // DodajZadanie
            // 
            DodajZadanie.BackColor = Color.White;
            DodajZadanie.FlatStyle = FlatStyle.Popup;
            DodajZadanie.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DodajZadanie.ForeColor = Color.Black;
            DodajZadanie.Location = new Point(14, 202);
            DodajZadanie.Name = "DodajZadanie";
            DodajZadanie.Size = new Size(125, 30);
            DodajZadanie.TabIndex = 18;
            DodajZadanie.Text = "DODAJ";
            DodajZadanie.UseVisualStyleBackColor = false;
            DodajZadanie.Click += DodajZadanie_Click;
            // 
            // UsunZadanie
            // 
            UsunZadanie.BackColor = Color.White;
            UsunZadanie.FlatStyle = FlatStyle.Popup;
            UsunZadanie.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsunZadanie.ForeColor = Color.Black;
            UsunZadanie.Location = new Point(151, 202);
            UsunZadanie.Name = "UsunZadanie";
            UsunZadanie.Size = new Size(125, 30);
            UsunZadanie.TabIndex = 19;
            UsunZadanie.Text = "USUN";
            UsunZadanie.UseVisualStyleBackColor = false;
            UsunZadanie.Click += UsunZadanie_Click;
            // 
            // ZapiszZadania
            // 
            ZapiszZadania.BackColor = Color.White;
            ZapiszZadania.FlatStyle = FlatStyle.Popup;
            ZapiszZadania.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ZapiszZadania.ForeColor = Color.Black;
            ZapiszZadania.Location = new Point(14, 237);
            ZapiszZadania.Name = "ZapiszZadania";
            ZapiszZadania.Size = new Size(125, 30);
            ZapiszZadania.TabIndex = 20;
            ZapiszZadania.Text = "ZAPISZ";
            ZapiszZadania.UseVisualStyleBackColor = false;
            ZapiszZadania.Click += ZapiszZadania_Click;
            // 
            // WczytajZadania
            // 
            WczytajZadania.BackColor = Color.White;
            WczytajZadania.FlatStyle = FlatStyle.Popup;
            WczytajZadania.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WczytajZadania.ForeColor = Color.Black;
            WczytajZadania.Location = new Point(151, 237);
            WczytajZadania.Name = "WczytajZadania";
            WczytajZadania.Size = new Size(125, 30);
            WczytajZadania.TabIndex = 21;
            WczytajZadania.Text = "WCZYTAJ";
            WczytajZadania.UseVisualStyleBackColor = false;
            WczytajZadania.Click += WczytajZadania_Click;
            // 
            // WprowadzZadanie
            // 
            WprowadzZadanie.Location = new Point(14, 173);
            WprowadzZadanie.Name = "WprowadzZadanie";
            WprowadzZadanie.PlaceholderText = "Wprowadź tytuł zadania";
            WprowadzZadanie.Size = new Size(262, 23);
            WprowadzZadanie.TabIndex = 22;
            // 
            // Main_Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 23, 31);
            ClientSize = new Size(290, 460);
            Controls.Add(WprowadzZadanie);
            Controls.Add(WczytajZadania);
            Controls.Add(ZapiszZadania);
            Controls.Add(UsunZadanie);
            Controls.Add(DodajZadanie);
            Controls.Add(Info3);
            Controls.Add(Info2);
            Controls.Add(Komunikat2);
            Controls.Add(Komunikat1);
            Controls.Add(przerwa);
            Controls.Add(interwal);
            Controls.Add(Info1);
            Controls.Add(MusicChoice);
            Controls.Add(licznik);
            Controls.Add(ButtonStop);
            Controls.Add(ButtonReset);
            Controls.Add(ButtonStart);
            Controls.Add(checkedListBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(306, 499);
            MinimizeBox = false;
            MinimumSize = new Size(306, 499);
            Name = "Main_Window";
            Padding = new Padding(2);
            StartPosition = FormStartPosition.Manual;
            Text = "ADHDLearning";
            Load += Main_Window_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Button ButtonStart;
        private Button ButtonReset;
        private Button ButtonStop;
        private Label licznik;
        private ComboBox MusicChoice;
        private TextBox Info1;
        private TextBox interwal;
        private TextBox przerwa;
        private TextBox Komunikat1;
        private TextBox Komunikat2;
        private TextBox Info2;
        private TextBox Info3;
        private Button DodajZadanie;
        private Button UsunZadanie;
        private Button ZapiszZadania;
        private Button WczytajZadania;
        private TextBox WprowadzZadanie;
    }
}
