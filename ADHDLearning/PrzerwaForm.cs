using System;
using System.Timers;
using System.Windows.Forms;

namespace ADHDLaarning
{
    public partial class PrzerwaForm : Form
    {
        System.Timers.Timer? timerPrzerwa;
        private int timerDuration;
        private int mp, sp;


        public PrzerwaForm(int duration)
        {
            InitializeComponent();
            timerDuration = duration;
        }


        private void PrzerwaForm_Load(object sender, EventArgs e)
        {

            mp = timerDuration / 60;
            sp= timerDuration % 60;

            timerPrzerwa = new System.Timers.Timer();
            timerPrzerwa.Interval = 1000;
            timerPrzerwa.Elapsed += OnTimeEvent; 


            timerPrzerwa.Start();
        }

        // to zdażenie uruchamia się co sekunde
        private void OnTimeEvent(object? sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                if (sp == 0)
                {
                    //gdy sekundy są równe 0 zmniejsza ilośc minut i ustawia sekundy na 60
                    mp--;
                    sp = 60;
                }

                // sekundy -1
                sp--;

                // aktualizujemy element aby pokazywał czas przewy
                licznikPrzerwa.Text = string.Format("{0}:{1}", mp.ToString().PadLeft(2, '0'), sp.ToString().PadLeft(2, '0'));

                // gdy odliczanie osiągnie wyłącza wimer i zamyka okno
                if (mp == 0 && sp == 0)
                {
                    timerPrzerwa?.Stop();
                    mp = 0;
                    sp = 0;
                    licznikPrzerwa.Text = "00:00";
                    this.Close();         
                }
            }));
        }
    }
}
