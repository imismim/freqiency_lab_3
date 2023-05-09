namespace freqiency_lab_3
{
    partial class Form1
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
            openFileDialog1=new OpenFileDialog();
            openFileDialog2=new OpenFileDialog();
            saveFileDialog1=new SaveFileDialog();
            openFileDialog3=new OpenFileDialog();
            saveFileDialog2=new SaveFileDialog();
            saveFileDialog3=new SaveFileDialog();
            panel7=new Panel();
            button1=new Button();
            FDTSaveTableButton=new Button();
            ImportTableButton=new Button();
            FDTsaveDecodedTextButton=new Button();
            FDTsaveLogFileButton=new Button();
            FDTdoChangeButton=new Button();
            label4=new Label();
            FDTletterReplace1ComboBox=new ComboBox();
            FDTletterReplace2ComboBox=new ComboBox();
            label3=new Label();
            label2=new Label();
            label1=new Label();
            FDTselectTextButton=new Button();
            panel6=new Panel();
            FDTruRadioButton=new RadioButton();
            FDTuaRadioButton=new RadioButton();
            FDTenRadioButton=new RadioButton();
            FDTdecodedTextBox=new TextBox();
            FDTencodedTextBox=new TextBox();
            FDTopenFileDialog=new OpenFileDialog();
            FDTsaveFileDialog=new SaveFileDialog();
            ViewTabletextBox=new TextBox();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName="openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName="openFileDialog2";
            openFileDialog2.Multiselect=true;
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName="openFileDialog2";
            openFileDialog3.Multiselect=true;
            // 
            // panel7
            // 
            panel7.Controls.Add(button1);
            panel7.Controls.Add(FDTSaveTableButton);
            panel7.Controls.Add(ImportTableButton);
            panel7.Controls.Add(FDTsaveDecodedTextButton);
            panel7.Controls.Add(FDTsaveLogFileButton);
            panel7.Controls.Add(FDTdoChangeButton);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(FDTletterReplace1ComboBox);
            panel7.Controls.Add(FDTletterReplace2ComboBox);
            panel7.Controls.Add(label3);
            panel7.Location=new Point(12, 554);
            panel7.Name="panel7";
            panel7.Size=new Size(921, 113);
            panel7.TabIndex=23;
            // 
            // button1
            // 
            button1.AutoSizeMode=AutoSizeMode.GrowAndShrink;
            button1.BackColor=SystemColors.ButtonHighlight;
            button1.Font=new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor=SystemColors.ControlDarkDark;
            button1.Location=new Point(820, 14);
            button1.Name="button1";
            button1.Size=new Size(98, 99);
            button1.TabIndex=29;
            button1.Text="Показати\r\nтаблицю\r\n";
            button1.UseVisualStyleBackColor=false;
            button1.Click+=button1_Click;
            // 
            // FDTSaveTableButton
            // 
            FDTSaveTableButton.AutoSizeMode=AutoSizeMode.GrowAndShrink;
            FDTSaveTableButton.BackColor=SystemColors.ButtonHighlight;
            FDTSaveTableButton.Font=new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FDTSaveTableButton.ForeColor=SystemColors.ControlDarkDark;
            FDTSaveTableButton.Location=new Point(553, 84);
            FDTSaveTableButton.Name="FDTSaveTableButton";
            FDTSaveTableButton.Size=new Size(261, 30);
            FDTSaveTableButton.TabIndex=28;
            FDTSaveTableButton.Text="Зберегти таблицю";
            FDTSaveTableButton.UseVisualStyleBackColor=false;
            FDTSaveTableButton.Click+=FDTSaveTableButton_Click;
            // 
            // ImportTableButton
            // 
            ImportTableButton.Location=new Point(441, 14);
            ImportTableButton.Name="ImportTableButton";
            ImportTableButton.Size=new Size(106, 100);
            ImportTableButton.TabIndex=27;
            ImportTableButton.Text="Імпортувати таблицю";
            ImportTableButton.UseVisualStyleBackColor=true;
            ImportTableButton.Click+=ImportTableButton_Click;
            // 
            // FDTsaveDecodedTextButton
            // 
            FDTsaveDecodedTextButton.AutoSizeMode=AutoSizeMode.GrowAndShrink;
            FDTsaveDecodedTextButton.BackColor=SystemColors.ButtonHighlight;
            FDTsaveDecodedTextButton.Font=new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FDTsaveDecodedTextButton.ForeColor=SystemColors.ControlDarkDark;
            FDTsaveDecodedTextButton.Location=new Point(553, 50);
            FDTsaveDecodedTextButton.Name="FDTsaveDecodedTextButton";
            FDTsaveDecodedTextButton.Size=new Size(261, 30);
            FDTsaveDecodedTextButton.TabIndex=26;
            FDTsaveDecodedTextButton.Text="Зберегти розкодований текст";
            FDTsaveDecodedTextButton.UseVisualStyleBackColor=false;
            FDTsaveDecodedTextButton.Click+=FDTsaveDecodedTextButton_Click;
            // 
            // FDTsaveLogFileButton
            // 
            FDTsaveLogFileButton.AutoSizeMode=AutoSizeMode.GrowAndShrink;
            FDTsaveLogFileButton.BackColor=SystemColors.ButtonHighlight;
            FDTsaveLogFileButton.Font=new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FDTsaveLogFileButton.ForeColor=SystemColors.ControlDarkDark;
            FDTsaveLogFileButton.Location=new Point(553, 14);
            FDTsaveLogFileButton.Name="FDTsaveLogFileButton";
            FDTsaveLogFileButton.Size=new Size(261, 30);
            FDTsaveLogFileButton.TabIndex=25;
            FDTsaveLogFileButton.Text="Зберегти лог файл";
            FDTsaveLogFileButton.UseVisualStyleBackColor=false;
            FDTsaveLogFileButton.Click+=FDTsaveLogFileButton_Click;
            // 
            // FDTdoChangeButton
            // 
            FDTdoChangeButton.AutoSizeMode=AutoSizeMode.GrowAndShrink;
            FDTdoChangeButton.BackColor=SystemColors.ButtonHighlight;
            FDTdoChangeButton.Font=new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FDTdoChangeButton.ForeColor=SystemColors.ControlDarkDark;
            FDTdoChangeButton.Location=new Point(3, 50);
            FDTdoChangeButton.Name="FDTdoChangeButton";
            FDTdoChangeButton.Size=new Size(432, 30);
            FDTdoChangeButton.TabIndex=24;
            FDTdoChangeButton.Text="OK";
            FDTdoChangeButton.UseVisualStyleBackColor=false;
            FDTdoChangeButton.Click+=FDTdoChangeButton_Click;
            // 
            // label4
            // 
            label4.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor=SystemColors.ActiveCaptionText;
            label4.Location=new Point(252, 13);
            label4.Name="label4";
            label4.Size=new Size(96, 31);
            label4.TabIndex=22;
            label4.Text="на букву";
            // 
            // FDTletterReplace1ComboBox
            // 
            FDTletterReplace1ComboBox.FormattingEnabled=true;
            FDTletterReplace1ComboBox.ImeMode=ImeMode.Close;
            FDTletterReplace1ComboBox.Location=new Point(162, 14);
            FDTletterReplace1ComboBox.Name="FDTletterReplace1ComboBox";
            FDTletterReplace1ComboBox.Size=new Size(84, 28);
            FDTletterReplace1ComboBox.TabIndex=17;
            // 
            // FDTletterReplace2ComboBox
            // 
            FDTletterReplace2ComboBox.FormattingEnabled=true;
            FDTletterReplace2ComboBox.Location=new Point(354, 14);
            FDTletterReplace2ComboBox.Name="FDTletterReplace2ComboBox";
            FDTletterReplace2ComboBox.Size=new Size(81, 28);
            FDTletterReplace2ComboBox.TabIndex=21;
            // 
            // label3
            // 
            label3.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor=SystemColors.ActiveCaptionText;
            label3.Location=new Point(3, 13);
            label3.Name="label3";
            label3.Size=new Size(168, 28);
            label3.TabIndex=20;
            label3.Text="Змінити букву";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor=SystemColors.ActiveCaptionText;
            label2.Location=new Point(478, 86);
            label2.Name="label2";
            label2.Size=new Size(378, 41);
            label2.TabIndex=19;
            label2.Text="РОЗШИФРОВАНИЙ ТЕКСТ";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor=SystemColors.ActiveCaptionText;
            label1.Location=new Point(12, 86);
            label1.Name="label1";
            label1.Size=new Size(357, 41);
            label1.TabIndex=18;
            label1.Text="ЗАШИФРОВАНИЙ ТЕКСТ";
            // 
            // FDTselectTextButton
            // 
            FDTselectTextButton.AutoSizeMode=AutoSizeMode.GrowAndShrink;
            FDTselectTextButton.BackColor=SystemColors.ButtonHighlight;
            FDTselectTextButton.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FDTselectTextButton.ForeColor=SystemColors.ControlDarkDark;
            FDTselectTextButton.Location=new Point(12, 15);
            FDTselectTextButton.Name="FDTselectTextButton";
            FDTselectTextButton.Size=new Size(460, 50);
            FDTselectTextButton.TabIndex=15;
            FDTselectTextButton.Text="ВИБРАТИ ЗАШИФРОВАНИЙ ТЕКСТ";
            FDTselectTextButton.UseVisualStyleBackColor=false;
            FDTselectTextButton.Click+=FDTselectTextButton_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(FDTruRadioButton);
            panel6.Controls.Add(FDTuaRadioButton);
            panel6.Controls.Add(FDTenRadioButton);
            panel6.Location=new Point(478, 12);
            panel6.Name="panel6";
            panel6.Size=new Size(455, 53);
            panel6.TabIndex=14;
            // 
            // FDTruRadioButton
            // 
            FDTruRadioButton.AutoSize=true;
            FDTruRadioButton.BackColor=Color.Transparent;
            FDTruRadioButton.FlatStyle=FlatStyle.Flat;
            FDTruRadioButton.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FDTruRadioButton.ForeColor=SystemColors.InfoText;
            FDTruRadioButton.Location=new Point(276, 19);
            FDTruRadioButton.Name="FDTruRadioButton";
            FDTruRadioButton.Size=new Size(95, 24);
            FDTruRadioButton.TabIndex=12;
            FDTruRadioButton.Text="ТЕКСТ РУ";
            FDTruRadioButton.UseVisualStyleBackColor=false;
            FDTruRadioButton.CheckedChanged+=FDTruRadioButton_CheckedChanged;
            // 
            // FDTuaRadioButton
            // 
            FDTuaRadioButton.AutoSize=true;
            FDTuaRadioButton.BackColor=Color.Transparent;
            FDTuaRadioButton.FlatStyle=FlatStyle.Flat;
            FDTuaRadioButton.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FDTuaRadioButton.ForeColor=SystemColors.InfoText;
            FDTuaRadioButton.Location=new Point(21, 19);
            FDTuaRadioButton.Name="FDTuaRadioButton";
            FDTuaRadioButton.Size=new Size(104, 24);
            FDTuaRadioButton.TabIndex=10;
            FDTuaRadioButton.Text="ТЕКСТ ЮА";
            FDTuaRadioButton.UseVisualStyleBackColor=false;
            FDTuaRadioButton.CheckedChanged+=FDTuaRadioButton_CheckedChanged;
            // 
            // FDTenRadioButton
            // 
            FDTenRadioButton.AutoSize=true;
            FDTenRadioButton.BackColor=Color.Transparent;
            FDTenRadioButton.Checked=true;
            FDTenRadioButton.FlatStyle=FlatStyle.Flat;
            FDTenRadioButton.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FDTenRadioButton.ForeColor=SystemColors.InfoText;
            FDTenRadioButton.Location=new Point(159, 19);
            FDTenRadioButton.Name="FDTenRadioButton";
            FDTenRadioButton.Size=new Size(107, 24);
            FDTenRadioButton.TabIndex=11;
            FDTenRadioButton.TabStop=true;
            FDTenRadioButton.Text="ТЕКСТ АНГ";
            FDTenRadioButton.UseVisualStyleBackColor=false;
            FDTenRadioButton.CheckedChanged+=FDTenRadioButton_CheckedChanged;
            // 
            // FDTdecodedTextBox
            // 
            FDTdecodedTextBox.Location=new Point(477, 130);
            FDTdecodedTextBox.Multiline=true;
            FDTdecodedTextBox.Name="FDTdecodedTextBox";
            FDTdecodedTextBox.ReadOnly=true;
            FDTdecodedTextBox.ScrollBars=ScrollBars.Both;
            FDTdecodedTextBox.Size=new Size(453, 418);
            FDTdecodedTextBox.TabIndex=3;
            FDTdecodedTextBox.WordWrap=false;
            // 
            // FDTencodedTextBox
            // 
            FDTencodedTextBox.Location=new Point(12, 130);
            FDTencodedTextBox.Multiline=true;
            FDTencodedTextBox.Name="FDTencodedTextBox";
            FDTencodedTextBox.ReadOnly=true;
            FDTencodedTextBox.ScrollBars=ScrollBars.Both;
            FDTencodedTextBox.Size=new Size(460, 418);
            FDTencodedTextBox.TabIndex=2;
            FDTencodedTextBox.WordWrap=false;
            // 
            // FDTopenFileDialog
            // 
            FDTopenFileDialog.FileName="FDTopenFileDialog";
            // 
            // ViewTabletextBox
            // 
            ViewTabletextBox.Location=new Point(950, 15);
            ViewTabletextBox.Multiline=true;
            ViewTabletextBox.Name="ViewTabletextBox";
            ViewTabletextBox.ReadOnly=true;
            ViewTabletextBox.ScrollBars=ScrollBars.Both;
            ViewTabletextBox.Size=new Size(358, 646);
            ViewTabletextBox.TabIndex=24;
            ViewTabletextBox.WordWrap=false;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            AutoSize=true;
            BackColor=SystemColors.ActiveCaption;
            ClientSize=new Size(1318, 679);
            Controls.Add(ViewTabletextBox);
            Controls.Add(panel7);
            Controls.Add(label2);
            Controls.Add(FDTencodedTextBox);
            Controls.Add(label1);
            Controls.Add(FDTdecodedTextBox);
            Controls.Add(FDTselectTextButton);
            Controls.Add(panel6);
            ForeColor=SystemColors.ControlDark;
            Name="Form1";
            StartPosition=FormStartPosition.CenterScreen;
            Text="ТАБЛИЦІ ЧАСТОТ";
            Load+=Form1_Load;
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog3;
        private SaveFileDialog saveFileDialog2;
        private SaveFileDialog saveFileDialog3;
        private Button FDTselectTextButton;
        private Panel panel6;
        private RadioButton FDTruRadioButton;
        private RadioButton FDTuaRadioButton;
        private RadioButton FDTenRadioButton;
        private TextBox FDTdecodedTextBox;
        private TextBox FDTencodedTextBox;
        private ComboBox FDTletterReplace1ComboBox;
        private Panel panel7;
        private Label label4;
        private ComboBox FDTletterReplace2ComboBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button FDTdoChangeButton;
        private Button FDTsaveLogFileButton;
        private Button FDTsaveDecodedTextButton;
        private OpenFileDialog FDTopenFileDialog;
        private SaveFileDialog FDTsaveFileDialog;
        private Button ImportTableButton;
        private TextBox ViewTabletextBox;
        private Button FDTSaveTableButton;
        private Button button1;
    }
}
