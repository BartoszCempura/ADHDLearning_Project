using System.Timers;
//----------------------
using System.Media;
using System.Numerics;
//-------------------------
namespace ADHDLaarning
{
    public partial class Main_Window : System.Windows.Forms.Form
    {
        //---------------------------------------------------------------
        // Declare the dictionary to associate MP3 file names with their paths
        private Dictionary<string, string> musicFiles = new Dictionary<string, string>();
        private SoundPlayer player; //deklaracja klasy 
        //-------------------------------------------------------------------------
        System.Timers.Timer timer;
        int h, m, s;
        int i, p, suma, komunikatPrzerwa;
        int uncheckedItemCount;
        private bool isTimerRunning = false;

        public Main_Window()
        {   
        //załadowanie wartości zmiennych domyślnych
        InitializeComponent();
            i = 20;
            p = 5;
            uncheckedItemCount = 1;
            komunikatPrzerwa = 0;
        }

        private void Main_Window_Load(object sender, EventArgs e)
        {
            //----------------------------------------------------------------------------
            string musicDirectory = @"C:\Repozytorium Programy\ADHDLearning_Project\Sounds"; // folder gdzie są pliki
            string[] wavFiles = Directory.GetFiles(musicDirectory, "*.wav");

            // dodaj każdy plik z rozszerzeniem wav do combobox
            foreach (string file in wavFiles)
            {
                string fileName = Path.GetFileName(file);
                musicFiles.Add(fileName, file);
                MusicChoice.Items.Add(fileName);
            }

            //-----------------------------------------------------------------------------------
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += OnTimeEvent;


        }

        private void OnTimeEvent(object? sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {

                //Mechanizm co sekunde zmieniający znak licznika
                if (s == 0)
                {

                    if (m == 0)
                    {

                        if (h == 0)
                        {
                            timer.Stop();
                            isTimerRunning = false;
                            MessageBox.Show("Time's up!", "Timer Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        h--;
                        m = 60;
                    }

                    m--;
                    s = 60;

                }
                s--;
                komunikatPrzerwa++;

                if (komunikatPrzerwa == (i * 60))
                {
                    PrzerwaForm przerwaForm = new PrzerwaForm(p * 60);
                    przerwaForm.ShowDialog();
                    komunikatPrzerwa = 0;
                }

                licznik.Text = string.Format("{0}:{1}:{2}",
                    h.ToString().PadLeft(2, '0'),
                    m.ToString().PadLeft(2, '0'),
                    s.ToString().PadLeft(2, '0'));

            }));

        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (isTimerRunning)
                return;

            if (uncheckedItemCount == 0)
            {
                MessageBox.Show("Brak zadań do wykonania. Dodaj lub odznacz zadania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            licznik.Visible = true;
            interwal.Visible = false;
            Komunikat1.Visible = false;
            przerwa.Visible = false;
            Komunikat2.Visible = false;
            Info1.Visible = false;
            Info2.Visible = true;

            if (h == 0 && m == 0 && s == 0)
            {
                int totalSeconds = (i + p) * uncheckedItemCount * 60;
                h = totalSeconds / 3600;
                totalSeconds %= 3600;
                m = totalSeconds / 60;
                s = totalSeconds % 60;
            }

            timer.Start();
            isTimerRunning = true;

            if (MusicChoice.SelectedItem != null)
            {
                string selectedFileName = MusicChoice.SelectedItem.ToString();
                if (musicFiles.ContainsKey(selectedFileName))
                {
                    string selectedFilePath = musicFiles[selectedFileName];
                    PlayAudio(selectedFilePath);
                }
            }
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            StopAudio();
            isTimerRunning = false;
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            isTimerRunning = false;
            h = 0;
            m = 0;
            s = 0;
            licznik.Text = "00:00:00";
            licznik.Visible = false;
            interwal.Visible = true;
            Komunikat1.Visible = true;
            przerwa.Visible = true;
            Komunikat2.Visible = true;
            Info1.Visible = true;
            Info2.Visible = false;

        }

        private void interwal_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(interwal.Text))
            {
                i = 20;
            }
            else if (int.TryParse(interwal.Text, out int interval))
            {
                if (interval != 0)
                {
                    i = interval;
                }
                else
                {
                    interwal.Text = "1";
                    i = 1;
                }
            }
            else
            {
                MessageBox.Show("Wprowadź ilość minut dla interwału pracy.");
            }
        }
        private void przerwa_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(przerwa.Text))
            {
                p = 5;  // Jeśli pole tekstowe jest puste, ustawiamy p na 5
            }
            else if (int.TryParse(przerwa.Text, out int breakTime))
            {
                if (breakTime != 0)
                {
                    p = breakTime;  // Jeśli wprowadzone dane są poprawne, przypisujemy je do p
                }
                else
                {
                    przerwa.Text = "1"; //nie może wynosić mniej niż 1
                    p = 1;
                }
            }
            else
            {
                MessageBox.Show("Wprowadź ilość minut dla przerw między interwałami");
            }
        }


        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int count = 0;
            for (int j = 0; j < checkedListBox1.Items.Count; j++)
            {
                CheckState state = (j == e.Index) ? e.NewValue : checkedListBox1.GetItemCheckState(j);
                if (state != CheckState.Checked)
                    count++;
            }
            uncheckedItemCount = count;
        }

        private void DodajZadanie_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(WprowadzZadanie.Text))
            {
                // jeżeli tekst w TextBox nie jest pusty dodajemy tekst do CheckedListBox
                checkedListBox1.Items.Add(WprowadzZadanie.Text);

                //Czyścimy TextBox po dodaniu zadania
                WprowadzZadanie.Clear();
                PrzeliczNiezaznaczone();
            }
            else
            {
                MessageBox.Show("Proszę wpisać treść zadania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UsunZadanie_Click(object sender, EventArgs e)
        {
            // sprawdzam czy jest zaznaczony jakikolwiek element na liście
            if (checkedListBox1.SelectedIndex != -1)
            {
                // Usuwamy zaznaczony element (indeks)
                checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
                PrzeliczNiezaznaczone();
            }
            else
            {
                MessageBox.Show("Proszę wybrać zadanie do usunięcia.", "Brak zaznaczenia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ZapiszZadania_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (var item in checkedListBox1.Items)
                        {
                            // Zapisz zadanie i stan zaznaczenia w formacie CSV
                            bool isChecked = checkedListBox1.GetItemChecked(checkedListBox1.Items.IndexOf(item));
                            writer.WriteLine($"{item},{isChecked}");
                        }
                    }
                    MessageBox.Show("Zadania zostały zapisane.");
                }
            }
        }

        private void WczytajZadania_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        checkedListBox1.Items.Clear(); // Wyczyść aktualną listę przed załadowaniem nowych danych
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            var parts = line.Split(',');
                            if (parts.Length == 2)
                            {
                                string itemText = parts[0];
                                bool isChecked = bool.Parse(parts[1]);

                                // Dodaj zadanie i ustaw stan zaznaczenia
                                checkedListBox1.Items.Add(itemText, isChecked);
                            }
                        }
                    }
                    MessageBox.Show("Zadania zostały wczytane.");
                    PrzeliczNiezaznaczone();
                }
            }
        }
        //------------------------------------------------------------------

        private void PrzeliczNiezaznaczone()
{
            int count = 0;
            for (int j = 0; j < checkedListBox1.Items.Count; j++)
            {
                if (!checkedListBox1.GetItemChecked(j))
                    count++;
            }
            uncheckedItemCount = count;
        }
        //--------------------------------------------------------------------

        private void PlayAudio(string filePath)
        {
            try
            {
                // If an audio is already playing, stop it before starting the new one
                if (player != null)
                {
                    player.Stop();
                    player.Dispose(); // Dispose the old player to free up resources
                }

                // Create a new instance of SoundPlayer to load and play the audio file
                player = new SoundPlayer(filePath);
                player.Load();  // Load the file into memory
                player.Play();  // Play the audio asynchronously
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error playing audio: {ex.Message}");
            }
        }

        private void StopAudio()
        {
            if (player != null)
            {
                player.Stop();  // Stop the audio if it's playing
                player.Dispose(); // Dispose of the player to free up resources
            }
        }
        //---------------------------------------------------------------------------------------------------
    }
}
