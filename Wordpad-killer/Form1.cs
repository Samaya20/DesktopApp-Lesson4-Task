namespace Wordpad_killer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeFontComboBox();
            InitializeSizeComboBox();
            InitializeColorComboBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeFontComboBox()
        {
            fontComboBox.Items.AddRange(FontFamily.Families);
            fontComboBox.DisplayMember = "Name";
            fontComboBox.SelectedIndex = 0;
        }

        private void InitializeSizeComboBox()
        {
            sizeComboBox.Items.AddRange(new string[] { "8", "10", "12", "14", "16", "18", "24", "36" });
            sizeComboBox.SelectedIndex = 2; 
        }

        private void InitializeColorComboBox()
        {
            colorComboBox.Items.Add("Black");
            colorComboBox.Items.Add("Red");
            colorComboBox.Items.Add("Blue");
            colorComboBox.Items.Add("Green");
            colorComboBox.Items.Add("Yellow");
            colorComboBox.Items.Add("Pink");
            colorComboBox.SelectedIndex = 0; 
        }

        private void LoadTextFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                editTextRichTextBox.Text = File.ReadAllText(fileName);
            }
            else
            {
                MessageBox.Show("Fayl tapılmadı.");
            }
        }

        private void SaveTextToFile(string fileName)
        {
            File.WriteAllText(fileName, editTextRichTextBox.Text);
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            string fileName = loadFilenameTextBox.Text;

            if (string.IsNullOrWhiteSpace(fileName))
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Text Files|*.txt";
                    openFileDialog.Title = "Fayl Seç";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        fileName = openFileDialog.FileName;
                        loadFilenameTextBox.Text = Path.GetFileName(fileName);
                    }
                    else
                    {
                        return;
                    }
                }
            }

            if (!File.Exists(fileName))
            {
                MessageBox.Show("Fayl tapılmadı.");
                return;
            }

            LoadTextFromFile(fileName);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files|*.txt";
                saveFileDialog.Title = "Faylı Save et";
                saveFileDialog.FileName = saveFilenameTextBox.Text;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveTextToFile(saveFileDialog.FileName);
                    saveFilenameTextBox.Text = Path.GetFileName(saveFileDialog.FileName);
                }
            }
        }

        private void fontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFont = fontComboBox.Text;
            Font currentFont = editTextRichTextBox.SelectionFont;
            Font newFont = new Font(selectedFont, currentFont.Size, currentFont.Style);
            editTextRichTextBox.SelectionFont = newFont;
        }

        private void sizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            float newSize = float.Parse(sizeComboBox.Text);
            Font currentFont = editTextRichTextBox.SelectionFont;
            Font newFont = new Font(currentFont.FontFamily, newSize, currentFont.Style);
            editTextRichTextBox.SelectionFont = newFont;
        }

        private void boldFontStyleBtn_Click(object sender, EventArgs e)
        {
            Font currentFont = editTextRichTextBox.SelectionFont;
            FontStyle newStyle = currentFont.Style ^ FontStyle.Bold;
            editTextRichTextBox.SelectionFont = new Font(currentFont, newStyle);
        }

        private void underlineFontStyleBtn_Click(object sender, EventArgs e)
        {
            Font currentFont = editTextRichTextBox.SelectionFont;
            FontStyle newStyle = currentFont.Style ^ FontStyle.Underline;
            editTextRichTextBox.SelectionFont = new Font(currentFont, newStyle);
        }

        private void cursiveFontStyleBtn_Click(object sender, EventArgs e)
        {
            Font currentFont = editTextRichTextBox.SelectionFont;
            FontStyle newStyle = currentFont.Style ^ FontStyle.Italic;
            editTextRichTextBox.SelectionFont = new Font(currentFont, newStyle);
        }

        private void leftAlignmentBtn_Click(object sender, EventArgs e)
        {
            editTextRichTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centerAlignmentBtn_Click(object sender, EventArgs e)
        {
            editTextRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void rightAlignmentBtn_Click(object sender, EventArgs e)
        {
            editTextRichTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColor = colorComboBox.Text;
            Color newColor = Color.Black;

            switch (selectedColor)
            {
                case "Black":
                    newColor = Color.Black;
                    break;
                case "Red":
                    newColor = Color.Red;
                    break;
                case "Blue":
                    newColor = Color.Blue;
                    break;
                case "Green":
                    newColor = Color.Green;
                    break;
                case "Yellow":
                    newColor = Color.Yellow;
                    break;
                case "Pink":
                    newColor = Color.Pink;
                    break;
            }

            editTextRichTextBox.SelectionColor = newColor;
        }
    }
}