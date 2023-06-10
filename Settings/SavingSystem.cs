using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace DJeyeMouseWrapper
{
    public class SavingSystem
    {
        public const string SETTINGSFILENAME = "Settings";

        public SavingSystem(string settingsFilename = SETTINGSFILENAME)
        {
            SettingsFilename = settingsFilename;
        }

        private string SettingsFilename { get; set; }


        public int SaveSettings(DJeyeWrapperSettings settings)
        {
            try
            {
                // Settings

                List<DJeyeWrapperSettings> records = new List<DJeyeWrapperSettings> { settings };

                using (var writer = new StreamWriter(SettingsFilename + ".csv"))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(records);
                }

                return 0;
            }
            catch
            {
                return 1;
            }
        }

        public DJeyeWrapperSettings LoadSettings()
        {
            try
            {
                List<DJeyeWrapperSettings> settings = new List<DJeyeWrapperSettings>();
                using (var reader = new StreamReader(SettingsFilename + ".csv"))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<DJeyeWrapperSettings>();
                    settings = records.ToList();
                }
                return settings[0];
            }
            catch
            {
                return new DefaultSettings();
            }
        }

    }
}