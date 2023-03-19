using System.Configuration;

namespace Lab2_Anagram {
    internal static class Program {
        // Config variables
        public static string[] words = { };
        public static int minWordLength;
        public static int maxWordLength;
        public static string? wordListPath;
        public static int MAX_NB_TRIES;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMainWindow());
        }

        public static void AddSetting(string key, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Add(key, value);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static void RemoveSetting(string key)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove(key);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static void UpdateSetting(string key, string newValue)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings.AllKeys.Contains(key))
            {
                config.AppSettings.Settings[key].Value = newValue;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            else
            {
                AddSetting(key, newValue);
            }
        }

        public static string GetSetting(string key)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings.AllKeys.Contains(key))
            {
                return config.AppSettings.Settings[key].Value;
            }
            else
            {
                return null;
            }
        }

        public static void loadConfig()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            Program.minWordLength = int.Parse(Program.GetSetting("minWordLength") ?? "3");
            Program.maxWordLength = int.Parse(Program.GetSetting("maxWordLength") ?? "10");
            Program.wordListPath = Program.GetSetting("wordListPath") ?? "./files/word_lists/wordsEN.txt";
            Program.MAX_NB_TRIES = int.Parse(Program.GetSetting("maxTries") ?? "5");

            // Load the word list
            try { Program.words = File.ReadAllLines(Program.wordListPath); }
            catch (Exception ex)
            {
                MessageBox.Show("Error while reading the words list file. Changing the path to the default one." + Environment.NewLine + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.UpdateSetting("wordListPath", "./files/word_lists/wordsEN.txt");
                return;
            }

            // Make sure the min and max word length are valid
            string shortestWord = "", longestWord = "";
            foreach (string word in Program.words)
            {
                if (word.Length < shortestWord.Length || shortestWord == "") { shortestWord = word; }
                if (word.Length > longestWord.Length || longestWord == "") { longestWord = word; }
            }
            // We make sure that the min and max word length are between the shortest and longest word length
            Program.minWordLength = Math.Min(Math.Max(Program.minWordLength, shortestWord.Length), longestWord.Length);
            Program.maxWordLength = Math.Max(Math.Min(Program.maxWordLength, longestWord.Length), shortestWord.Length);
            Program.UpdateSetting("minWordLength", Program.minWordLength.ToString());
            Program.UpdateSetting("maxWordLength", Program.maxWordLength.ToString());
        }
    }
}