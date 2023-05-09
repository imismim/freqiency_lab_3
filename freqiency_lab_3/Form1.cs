using WinFormsApp1;

namespace freqiency_lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private List<(char Symbol, float CalcPercent, float StandartPercent)> TrueTable { get; set; }
        private string fileName { get; set; }
        private string EncodedText { get; set; }
        private string DecodedText { get; set; }
        private List<(char letter1, char letter2)> letters { get; set; }
        private string lang { get; set; } = "EN";
        object[] ukrAlphabet = { 'À', 'Á', 'Â', 'Ã', '¥', 'Ä', 'Å', 'ª', 'Æ', 'Ç', 'È', '²', '¯', 'É', 'Ê', 'Ë', 'Ì', 'Í', 'Î', 'Ï', 'Ð', 'Ñ', 'Ò', 'Ó', 'Ô', 'Õ', 'Ö', '×', 'Ø', 'Ù', 'Ü', 'Þ', 'ß' };
        object[] engAlphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        object[] rusAlphabet = { 'À', 'Á', 'Â', 'Ã', 'Ä', 'Å', '¨', 'Æ', 'Ç', 'È', 'É', 'Ê', 'Ë', 'Ì', 'Í', 'Î', 'Ï', 'Ð', 'Ñ', 'Ò', 'Ó', 'Ô', 'Õ', 'Ö', '×', 'Ø', 'Ù', 'Ú', 'Û', 'Ü', 'Ý', 'Þ', 'ß' };
        public string LogString { get; set; } = string.Empty;

        private void FDTselectTextButton_Click(object sender, EventArgs e)
        {
            var post = this.FDTopenFileDialog.ShowDialog();
            if (post == DialogResult.OK)
            {
                this.fileName = this.FDTopenFileDialog.FileName;
                if (this.fileName[^3..]!="txt")
                {
                    MessageBox.Show("You selected the wrong file format!\nChoose txt format!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);

                }
                else
                {
                    this.EncodedText = FrequencyDecoding.ReadFile(this.FDTopenFileDialog.FileName);
                    this.DecodedText = FrequencyDecoding.DecodedText(this.EncodedText, this.fileName, this.lang);

                    this.FDTencodedTextBox.Text = this.EncodedText;
                    this.FDTdecodedTextBox.Text = this.DecodedText;
                    this.ChangeReplaceAlphabet(this.engAlphabet);
                }
            }
        }

        private void FDTdoChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                var firstLetter = char.ToLower(char.Parse(this.FDTletterReplace1ComboBox.SelectedItem.ToString()));
                var secondLetter = char.ToLower(char.Parse(this.FDTletterReplace2ComboBox.SelectedItem.ToString()));
                this.LogString += $"{firstLetter}<->{secondLetter}{Environment.NewLine}";
                this.DecodedText = FrequencyDecoding.OneTimeReplaceLetter(this.DecodedText, firstLetter, secondLetter);
                this.FDTdecodedTextBox.Text = this.DecodedText;
            }
            catch (Exception)
            {

                MessageBox.Show("You selected the wrong file format!\nChoose txt format!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
            }

        }

        private void FDTsaveLogFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.FDTsaveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                var post = this.FDTsaveFileDialog.ShowDialog();
                if (post == DialogResult.OK)
                {
                    string log = string.Empty;
                    var list = FrequencyDecoding.ListLettersChanged(this.fileName, this.lang);
                    foreach (var item in list)
                    {
                        log+=$"{item.letter1}->{item.letter2}{Environment.NewLine}";
                    }
                    log += $"{Environment.NewLine}Manual Replace{Environment.NewLine}";
                    log += this.LogString;
                    FrequencyDecoding.SaveLogFile(this.FDTsaveFileDialog.FileName, log);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("You selected the wrong file format!\nChoose txt format!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
            }

        }

        private void FDTsaveDecodedTextButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.FDTsaveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                var post = this.FDTsaveFileDialog.ShowDialog();
                if (post == DialogResult.OK)
                {
                    using (var wr = new StreamWriter(this.FDTsaveFileDialog.FileName))
                    {
                        wr.Write(this.DecodedText);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("You selected the wrong file format!\nChoose txt format!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
            }

        }

        private void ChangeReplaceAlphabet(in object[] alphabet)
        {
            letters = FrequencyDecoding.ListLettersChanged(this.fileName, this.lang);
            this.FDTletterReplace1ComboBox.Items.Clear();
            this.FDTletterReplace2ComboBox.Items.Clear();
            this.FDTletterReplace1ComboBox.Items.AddRange(alphabet);
            this.FDTletterReplace1ComboBox.Text = alphabet[0].ToString();
            this.FDTletterReplace2ComboBox.Items.AddRange(alphabet);
            this.FDTletterReplace2ComboBox.Text = alphabet[0].ToString();
            this.LogString = string.Empty;

        }

        private void FDTuaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.lang = "UA";
                this.ChangeReplaceAlphabet(this.ukrAlphabet);
                this.FDTdecodedTextBox.Text = FrequencyDecoding.DecodedText(this.EncodedText, this.fileName, this.lang);
            }
            catch (Exception)
            {

                MessageBox.Show("You selected the wrong file format!\nChoose txt format!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
            }
        }

        private void FDTenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.lang = "EN";
                this.ChangeReplaceAlphabet(this.engAlphabet);
                this.FDTdecodedTextBox.Text = FrequencyDecoding.DecodedText(this.EncodedText, this.fileName, this.lang);
            }
            catch (Exception)
            {

                MessageBox.Show("You selected the wrong file format!\nChoose txt format!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
            }

        }

        private void FDTruRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.lang = "RU";
                this.ChangeReplaceAlphabet(this.rusAlphabet);
                this.FDTdecodedTextBox.Text = FrequencyDecoding.DecodedText(this.EncodedText, this.fileName, this.lang);
            }
            catch (Exception)
            {

                MessageBox.Show("You selected the wrong file format!\nChoose txt format!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
            }
        }

        private void ImportTableButton_Click(object sender, EventArgs e)
        {
            var post = this.FDTopenFileDialog.ShowDialog();
            if (post == DialogResult.OK)
            {
                if (this.FDTopenFileDialog.FileName[^3..]!="txt")
                {
                    MessageBox.Show("You selected the wrong file format!\nChoose txt format!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);

                }
                else
                {
                    var table = FrequencyTable.ImportTable(this.FDTopenFileDialog.FileName);

                    this.DecodedText = FrequencyDecoding.DecodedTextFrequencyTable(table.OrderByDescending(i => i.CalcPercent).Select(i => i.Symbol).ToList(), this.EncodedText, this.fileName, this.lang);
                    this.ViewTabletextBox.Text = FrequencyTable.BuildTable(table.OrderByDescending(i => i.CalcPercent).ToList());

                    this.FDTdecodedTextBox.Text = this.DecodedText;
                    this.ChangeReplaceAlphabet(this.engAlphabet);
                }
            }

        }

        public List<(char Symbol, float CalcPercent, float StandartPercent)> GetTable(string text, string Lang)
        {
            var AllSymbols = text.Select(i => char.ToUpper(i)).ToList();
            var frequencyTabel = new List<(char, float, float)>();

            float CountAllSymbols = AllSymbols.Count;
            float CountSymbol, CalculatePercent;
            for (int i = 0; i < FrequencyTable.standartFrequencyTable[Lang].Count(); i++)/////////////////////////////////////
            {
                CountSymbol = AllSymbols.Where(sym => sym == FrequencyTable.standartFrequencyTable[Lang][i].Symbol).Count();
                CalculatePercent = (float)Math.Round((CountSymbol / CountAllSymbols)*100, 3);
                frequencyTabel.Add((FrequencyTable.standartFrequencyTable[Lang][i].Symbol, CalculatePercent, FrequencyTable.standartFrequencyTable[Lang][i].StandartPercent));
            }
            return frequencyTabel.OrderByDescending(x => x.Item2).ToList();

        }

        private void FDTSaveTableButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.saveFileDialog3.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                var post = this.saveFileDialog3.ShowDialog();

                if (post == DialogResult.OK)
                {
                    this.TrueTable = this.GetTable(this.DecodedText, this.lang);

                    using (var sw = new StreamWriter(this.saveFileDialog3.FileName))
                    {
                        foreach (var item in this.TrueTable)
                        {
                            sw.WriteLine($"{item.Symbol};{item.CalcPercent};{item.StandartPercent}");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You are doing something wrong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var table = GetTable(this.DecodedText, this.lang);
            this.ViewTabletextBox.Text = FrequencyTable.BuildTable(table.OrderByDescending(i => i.CalcPercent).ToList());
        }

    }

}
