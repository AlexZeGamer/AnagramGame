using System.Configuration;
using static System.Windows.Forms.AxHost;
using System.Windows.Forms.VisualStyles;
using System.Security.Cryptography;

namespace Lab2_Anagram {
    internal static class Program {
        // Config variables
        public static string[] words = { };
        public static int minWordLength;
        public static int maxWordLength;
        public static string? wordListPath;
        public static int MAX_NB_TRIES;
        public static Color colorBackground;
        public static Color colorSecondaryBackground;
        public static Color colorForeground;

        // Other variables
        public static frmMainWindow mainForm = new frmMainWindow();
        public static frmConfig configForm = new frmConfig(mainForm);

        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(mainForm);
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

        public static string? GetSetting(string key)
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

            // Load the colors (if they are not set, we set them to the default values)
            // If any of the colors is invalid, we call the light_mode function
            if (Program.GetSetting("colorBackground") == null || Program.GetSetting("colorSecondaryBackground") == null || Program.GetSetting("colorForeground") == null)
            {
                Program.colorBackground = Control.DefaultBackColor;
                Program.colorForeground = Control.DefaultForeColor;
                Program.colorSecondaryBackground = Button.DefaultBackColor;
                Program.light_mode(Program.mainForm);
            }
            else
            {
                Program.colorBackground = Color.FromArgb(int.Parse(Program.GetSetting("colorBackground") ?? Control.DefaultBackColor.ToArgb().ToString()));
                Program.colorForeground = Color.FromArgb(int.Parse(Program.GetSetting("colorForeground") ?? Control.DefaultForeColor.ToArgb().ToString()));
                Program.colorSecondaryBackground = Color.FromArgb(int.Parse(Program.GetSetting("colorSecondaryBackground") ?? Button.DefaultBackColor.ToArgb().ToString()));
                Program.SetColors(Program.mainForm, Program.colorBackground, Program.colorSecondaryBackground, Program.colorForeground);
            }
        }

        public static void light_mode(Form form)
        {
            // the secondary background color and the foreground color are automatically set in tabSettingsAppearance_Load()
            Program.SetBackColor(form, Control.DefaultBackColor);
            Program.UpdateSetting("customFGColor", "False");
            Program.UpdateSetting("customSecondaryBGColor", "False");
            autoFGColor(form);
            autoSecondaryBGColor(form);
        }

        public static void dark_mode(Form form)
        {
            // the secondary background color and the foreground color are automatically set in tabSettingsAppearance_Load()
            Program.SetBackColor(form, Color.FromArgb(32, 32, 32));
            Program.UpdateSetting("customFGColor", "False");
            Program.UpdateSetting("customSecondaryBGColor", "False");
            autoFGColor(form);
            autoSecondaryBGColor(form);
        }

        public static void autoFGColor(Form form)
        {
            Color color = Program.colorBackground;

            // take the inverse color
            int r = 255 - color.R;
            int g = 255 - color.G;
            int b = 255 - color.B;
            Color newColor = Color.FromArgb(r, g, b);
            Program.SetForeColor(form, newColor);
        }

        public static void autoSecondaryBGColor(Form form)
        {
            Color color = Program.colorBackground;

            // make the color a bit lighter, without going over 255 (the max value)
            int r = Math.Min(255, color.R + 50);
            int g = Math.Min(255, color.G + 50);
            int b = Math.Min(255, color.B + 50);
            Color newColor = Color.FromArgb(r, g, b);
            Program.SetSecondaryBackColor(form, newColor);
        }

        public static void SetColors(Form form, Color colorBG, Color colorSecondaryBG, Color colorFG)
        {
            // Set the color of the form
            SetBackColor(form, colorBG);
            SetSecondaryBackColor(form, colorSecondaryBG);
            SetForeColor(form, colorFG);
        }

        public static void SetBackColor(Control parent, Color newColor)
        {
            Program.colorBackground = newColor;
            Program.UpdateSetting("colorBackground", newColor.ToArgb().ToString());
            parent.BackColor = newColor;
        }

        public static void SetSecondaryBackColor(Control parent, Color newColor)
        {
            Program.colorSecondaryBackground = newColor;
            Program.UpdateSetting("colorSecondaryBackground", newColor.ToArgb().ToString());
            SetSecondaryBackColorRecursively(parent, newColor);
        }

        public static void SetSecondaryBackColorRecursively(Control parent, Color newColor)
        {
            var types = new List<Type> { typeof(Button), typeof(TextBox), typeof(ListBox), typeof(ComboBox), typeof(NumericUpDown), typeof(CheckBox), typeof(RadioButton), typeof(Panel) };
            foreach (Control control in parent.Controls)
            {
                if (types.Contains(control.GetType())) // If the control is a button, textbox, listbox, combobox, numericupdown, checkbox, radiobutton or panel
                {
                    control.BackColor = newColor;
                }
                SetSecondaryBackColorRecursively(control, newColor);
            }
        }

        public static void SetForeColor(Control parent, Color newColor)
        {
            Program.colorForeground = newColor;
            Program.UpdateSetting("colorForeground", newColor.ToArgb().ToString());
            SetForeColorRecursively(parent, newColor);
        }

        public static void SetForeColorRecursively(Control parent, Color newColor)
        {
            parent.ForeColor = newColor;
            foreach (Control control in parent.Controls)
            {
                SetForeColorRecursively(control, newColor);
            }
        }
    }
}