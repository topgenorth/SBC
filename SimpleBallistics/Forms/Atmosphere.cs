using System;
using System.Windows.Forms;

namespace SimpleBallistics.Forms
{
    public partial class Atmosphere : Form
    {
        public Atmosphere()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Load our previous settings.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Atmosphere_Load(object sender, EventArgs e)
        {
            numAlt.Value = (decimal)Properties.Settings.Default.Altitude;
            numBaro.Value = (decimal)Properties.Settings.Default.Barometer;
            numTemp.Value = (decimal)Properties.Settings.Default.Temperature;
            numHum.Value = (decimal)Properties.Settings.Default.RelativeHumidity;
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Close();
        }

        void SaveSettings()
        {
            Properties.Settings.Default.Altitude = (double)numAlt.Value;
            Properties.Settings.Default.Barometer = (double)numBaro.Value;
            Properties.Settings.Default.Temperature = (double)numTemp.Value;
            Properties.Settings.Default.RelativeHumidity = (double)numHum.Value;

            Properties.Settings.Default.Save();
        }
    }
}
