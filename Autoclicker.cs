using MelodyAutoclicker.HotKeyEventManager;
using MelodyAutoclicker.SongsDatabase;
using System.Diagnostics;

#pragma warning disable CS8602 // Dereference of a possibly null reference.

namespace MelodyAutoclicker
{
    public partial class Autoclicker : Form
    {
        public Autoclicker()
        {
            InitializeComponent();
            // Hide the up and down arrows of the numeric up-down controls
            numericUpDownX1.Controls[0].Hide();
            numericUpDownX2.Controls[0].Hide();
            numericUpDownY1.Controls[0].Hide();
            numericUpDownY2.Controls[0].Hide();

            // Register application kill hotkey incase anything goes wrong
            HotKeyManager.RegisterHotKey(Keys.Home, KeyModifiers.Alt);
            HotKeyManager.HotKeyPressed += new EventHandler<HotKeyEventArgs>(HotKeyManager_HotKeyPressed);
        }

        private void HotKeyManager_HotKeyPressed(object? sender, HotKeyEventArgs e)
        {
            Application.Exit();
        }

        private Song? Song { get; set; }
        private Playspace? Playspace { get; set; }
        private int countdown = 10;
        private readonly int defaultTimerTickInterval = 675;

        private List<int> cubes = new List<int>();

        /// <summary>
        /// Get's the song's notes from the "database"
        /// </summary>
        /// <returns>Song instance or null if the song was not found in the database</returns>
        private Song? GetSongDetails()
        {
            Song? song = null;
            switch (comboBoxSong.SelectedItem)
            {
                case "Hymn to the Joy":
                    song = new Song(new HymnToTheJoy());
                    break;

                case "Frere Jacques":
                    song = new Song(new FrereJacques());
                    break;

                case "Amazing Grace":
                    song = new Song(new AmazingGrace());
                    break;

                case "Brahms' Lullaby":
                    song = new Song(new BrahmsLullaby());
                    break;

                case "Happy Birthday to You":
                    song = new Song(new HappyBirthdayToYou());
                    break;

                case "Greensleeves":
                    song = new Song(new Greensleeves());
                    break;

                case "Geothermy?":
                    song = new Song(new Geothermy());
                    break;

                case "Minuet":
                    song = new Song(new Minuet());
                    break;

                case "Joy to the World":
                    song = new Song(new JoyToTheWorld());
                    break;

                case "Godly Imagination":
                    song = new Song(new GodlyImagination());
                    break;

                case "La Vie en Rose":
                    song = new Song(new LaVieEnRose());
                    break;
            }

            return song;
        }

        /// <summary>
        /// Validates whether the coordinates entered by the user are valid
        /// </summary>
        /// <returns>true if the coordinates are valid, false otherwise</returns>
        private bool AreCoordsValid()
        {
            try
            {
                return !(
                    numericUpDownX1.Value < 0
                    || numericUpDownX2.Value < 0
                    || numericUpDownY1.Value < 0
                    || numericUpDownY2.Value < 0
                    || numericUpDownX1.Value > numericUpDownX2.Value
                    || numericUpDownY1.Value > numericUpDownY2.Value
                    );
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Get's the pixel color at the specified coordinates
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <returns></returns>
        Color GetColorAt(int x, int y)
        {
            Bitmap bmp = new(1, 1);
            Rectangle bounds = new(x, y, 1, 1);
            using (Graphics g = Graphics.FromImage(bmp))
                try
                {
                    // FIXME: For some reason, this sometimes throws an exception and then it fixes itself after a few seconds
                    g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
                } catch(Exception e)
                {
                    Debug.WriteLine(e.Message);
                }

            return bmp.GetPixel(0, 0);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timerSeconds.Enabled)
            {
                progressBarSong.Value = 0;
                timerSeconds.Stop();
                timerTick.Stop();
                btnStart.Text = "Start";
                return;
            }

            if (comboBoxSong.SelectedIndex == -1)
            {
                MessageBox.Show("You have not selected any song from the list of available songs.", "Please select a song");
                return;
            }

            if (!AreCoordsValid())
            {
                MessageBox.Show("Either you have not entered the {X1,X2 ; Y1,Y2} coordinates or they are not an integer.", "Please enter the coordinates");
                return;
            }

            Song = GetSongDetails();
            if (Song == null)
            {
                MessageBox.Show("Specified song was not found in the database", "Invalid song");
                return;
            }

            Playspace = new((int)numericUpDownX1.Value, (int)numericUpDownY1.Value, (int)numericUpDownX2.Value, (int)numericUpDownY2.Value);
            Song.Playspace = Playspace;

            timerPrepare.Start();
        }

        private void timerSeconds_Tick(object sender, EventArgs e)
        {
            if (progressBarSong.Value == progressBarSong.Maximum)
            {
                labelTimeRemaining.Text = "Finished!";
                timerSeconds.Stop();
                timerTick.Stop();
                MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.MiddleUp);
                btnStart.Text = "Start";
                return;
            }

            labelTimeRemaining.Text = $"{++progressBarSong.Value}s/{progressBarSong.Maximum}s";
        }

        private void timerMouse_Tick(object sender, EventArgs e)
        {
            labelXYCoords.Text = $"X: {Cursor.Position.X}, Y: {Cursor.Position.Y}";
        }

        private void timerTick_Tick(object sender, EventArgs e)
        {
            if (Song == null)
            {
                Debug.WriteLine("Song is null");
                return;
            }

            var noteDuration = Song.PlayNextNote();
            if (noteDuration != null)
            {
                Debug.WriteLine($"Note duration: {noteDuration.Duration}");
                timerTick.Interval = (int)(defaultTimerTickInterval * noteDuration.Duration);
                Debug.WriteLine($"Timer interval: {timerTick.Interval}");
            }
            else
            {
                timerTick.Interval = defaultTimerTickInterval;
            }
        }

        private void timerPrepare_Tick(object sender, EventArgs e)
        {
            labelTimeRemaining.Text = $"Click on the song in {countdown - 5}...";
            countdown--;
            if (countdown == 0)
            {
                timerPrepare.Stop();
                countdown = 10;

                timerSeconds.Start();
                var noteDuration = Song.StartPlaying().Duration;
                timerTick.Interval = (int)(defaultTimerTickInterval * noteDuration);
                timerTick.Start();
                progressBarSong.Value = 0;
                progressBarSong.Maximum = Song.Length;
                labelTimeRemaining.Text = $"0s/{Song.Length}s";

                btnStart.Text = "Stop";
            }
        }

        private void btnColorStart_Click(object sender, EventArgs e)
        {
            if (timerSeconds.Enabled)
            {
                progressBarSong.Value = 0;
                timerColor.Stop();
                btnColorStart.Text = "ColorStart";
                return;
            }

            int length = (int)numericUpDownX2.Value - (int)numericUpDownX1.Value;
            if (length < 0)
            {
                MessageBox.Show("X1 must be smaller than X2", "Invalid coordinates");
                return;
            }

            cubes = new List<int>();
            cubes.Add((int)numericUpDownX1.Value);
            cubes.Add((int)numericUpDownX2.Value);
            for (int x = 1; x <= 5; x++)
            {
                cubes.Add((int)numericUpDownX2.Value + (x * length));
            }

            Debug.WriteLine($"Cubes: {string.Join(", ", cubes)}");

            timerColor.Start();
            btnColorStart.Text = "ColorStop";
            labelTimeRemaining.Text = "Color detection started...";
        }

        private void timerColor_Tick(object sender, EventArgs e)
        {
            Refresh();
            Application.DoEvents();

            foreach (var cube in cubes)
            {
                var color = GetColorAt(cube, (int)numericUpDownY1.Value);
                Debug.WriteLine($"Color at {cube}: {color}");
                if (color.R > 210 && color.G > 210 && color.B > 210)
                {
                    Debug.WriteLine($"Clicking at {cube}");
                    MouseOperations.SetCursorPosition(cube, (int)numericUpDownY1.Value);
                    Thread.Sleep(1);
                    MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.MiddleDown);
                    MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.MiddleUp);
                    Thread.Sleep(1);
                    MouseOperations.SetCursorPosition(100, 100);
                    Thread.Sleep(250);
                }
            }
        }
    }
}