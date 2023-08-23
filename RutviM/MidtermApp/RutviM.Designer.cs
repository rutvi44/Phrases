namespace MidtermApp
{
    partial class RutviM
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
            groupBoxQuestion1 = new GroupBox();
            btnCheckAvailability = new Button();
            txtZipCode = new TextBox();
            lblZipCode = new Label();
            groupBoxQuestion3 = new GroupBox();
            listBoxMatchingPhrases = new ListBox();
            lblMatchingPhrases = new Label();
            groupBoxQuestion2 = new GroupBox();
            lblOutput = new Label();
            btnRemoveVowels = new Button();
            txtInputText = new TextBox();
            lblInputText = new Label();
            groupBoxQuestion4 = new GroupBox();
            btnShowPatients = new Button();
            richTextBox = new RichTextBox();
            lblError = new Label();
            btnAddToSchedule = new Button();
            txtPatientAge = new TextBox();
            txtMedicalRecord = new TextBox();
            txtPatientName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBoxQuestion1.SuspendLayout();
            groupBoxQuestion3.SuspendLayout();
            groupBoxQuestion2.SuspendLayout();
            groupBoxQuestion4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxQuestion1
            // 
            groupBoxQuestion1.Controls.Add(btnCheckAvailability);
            groupBoxQuestion1.Controls.Add(txtZipCode);
            groupBoxQuestion1.Controls.Add(lblZipCode);
            groupBoxQuestion1.Location = new Point(47, 41);
            groupBoxQuestion1.Margin = new Padding(5);
            groupBoxQuestion1.Name = "groupBoxQuestion1";
            groupBoxQuestion1.Padding = new Padding(5);
            groupBoxQuestion1.Size = new Size(765, 166);
            groupBoxQuestion1.TabIndex = 0;
            groupBoxQuestion1.TabStop = false;
            groupBoxQuestion1.Text = "1:";
            // 
            // btnCheckAvailability
            // 
            btnCheckAvailability.AutoEllipsis = true;
            btnCheckAvailability.BackColor = SystemColors.ActiveCaption;
            btnCheckAvailability.Location = new Point(531, 98);
            btnCheckAvailability.Name = "btnCheckAvailability";
            btnCheckAvailability.Size = new Size(204, 34);
            btnCheckAvailability.TabIndex = 5;
            btnCheckAvailability.Text = "Check Availability";
            btnCheckAvailability.UseVisualStyleBackColor = false;
            btnCheckAvailability.Click += btnCheckAvailability_Click;
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(178, 50);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(293, 31);
            txtZipCode.TabIndex = 4;
            // 
            // lblZipCode
            // 
            lblZipCode.AutoSize = true;
            lblZipCode.Location = new Point(60, 50);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new Size(80, 25);
            lblZipCode.TabIndex = 3;
            lblZipCode.Text = "Zipcode:";
            lblZipCode.Click += label1_Click;
            // 
            // groupBoxQuestion3
            // 
            groupBoxQuestion3.Controls.Add(listBoxMatchingPhrases);
            groupBoxQuestion3.Controls.Add(lblMatchingPhrases);
            groupBoxQuestion3.Location = new Point(882, 41);
            groupBoxQuestion3.Margin = new Padding(5);
            groupBoxQuestion3.Name = "groupBoxQuestion3";
            groupBoxQuestion3.Padding = new Padding(5);
            groupBoxQuestion3.Size = new Size(258, 375);
            groupBoxQuestion3.TabIndex = 1;
            groupBoxQuestion3.TabStop = false;
            groupBoxQuestion3.Text = "3:";
            // 
            // listBoxMatchingPhrases
            // 
            listBoxMatchingPhrases.FormattingEnabled = true;
            listBoxMatchingPhrases.ItemHeight = 25;
            listBoxMatchingPhrases.Location = new Point(37, 80);
            listBoxMatchingPhrases.Margin = new Padding(5);
            listBoxMatchingPhrases.Name = "listBoxMatchingPhrases";
            listBoxMatchingPhrases.Size = new Size(169, 254);
            listBoxMatchingPhrases.TabIndex = 1;
            listBoxMatchingPhrases.SelectedIndexChanged += listBoxMatchingPhrases_SelectedIndexChanged;
            // 
            // lblMatchingPhrases
            // 
            lblMatchingPhrases.AutoSize = true;
            lblMatchingPhrases.Location = new Point(37, 50);
            lblMatchingPhrases.Margin = new Padding(5, 0, 5, 0);
            lblMatchingPhrases.Name = "lblMatchingPhrases";
            lblMatchingPhrases.Size = new Size(156, 25);
            lblMatchingPhrases.TabIndex = 0;
            lblMatchingPhrases.Text = "Matching phrases:";
            // 
            // groupBoxQuestion2
            // 
            groupBoxQuestion2.Controls.Add(lblOutput);
            groupBoxQuestion2.Controls.Add(btnRemoveVowels);
            groupBoxQuestion2.Controls.Add(txtInputText);
            groupBoxQuestion2.Controls.Add(lblInputText);
            groupBoxQuestion2.Location = new Point(47, 250);
            groupBoxQuestion2.Margin = new Padding(5);
            groupBoxQuestion2.Name = "groupBoxQuestion2";
            groupBoxQuestion2.Padding = new Padding(5);
            groupBoxQuestion2.Size = new Size(765, 166);
            groupBoxQuestion2.TabIndex = 1;
            groupBoxQuestion2.TabStop = false;
            groupBoxQuestion2.Text = "2:";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(81, 100);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(59, 25);
            lblOutput.TabIndex = 3;
            lblOutput.Text = "label1";
            // 
            // btnRemoveVowels
            // 
            btnRemoveVowels.BackColor = SystemColors.ActiveCaption;
            btnRemoveVowels.Location = new Point(562, 37);
            btnRemoveVowels.Name = "btnRemoveVowels";
            btnRemoveVowels.Size = new Size(173, 34);
            btnRemoveVowels.TabIndex = 2;
            btnRemoveVowels.Text = "Remove vowels";
            btnRemoveVowels.UseVisualStyleBackColor = false;
            btnRemoveVowels.Click += btnRemoveVowels_Click;
            // 
            // txtInputText
            // 
            txtInputText.Location = new Point(139, 37);
            txtInputText.Name = "txtInputText";
            txtInputText.Size = new Size(393, 31);
            txtInputText.TabIndex = 1;
            // 
            // lblInputText
            // 
            lblInputText.AutoSize = true;
            lblInputText.Location = new Point(16, 41);
            lblInputText.Name = "lblInputText";
            lblInputText.Size = new Size(98, 25);
            lblInputText.TabIndex = 0;
            lblInputText.Text = "Input Text: ";
            // 
            // groupBoxQuestion4
            // 
            groupBoxQuestion4.Controls.Add(btnShowPatients);
            groupBoxQuestion4.Controls.Add(richTextBox);
            groupBoxQuestion4.Controls.Add(lblError);
            groupBoxQuestion4.Controls.Add(btnAddToSchedule);
            groupBoxQuestion4.Controls.Add(txtPatientAge);
            groupBoxQuestion4.Controls.Add(txtMedicalRecord);
            groupBoxQuestion4.Controls.Add(txtPatientName);
            groupBoxQuestion4.Controls.Add(label3);
            groupBoxQuestion4.Controls.Add(label2);
            groupBoxQuestion4.Controls.Add(label1);
            groupBoxQuestion4.Location = new Point(47, 449);
            groupBoxQuestion4.Margin = new Padding(5);
            groupBoxQuestion4.Name = "groupBoxQuestion4";
            groupBoxQuestion4.Padding = new Padding(5);
            groupBoxQuestion4.Size = new Size(1093, 418);
            groupBoxQuestion4.TabIndex = 2;
            groupBoxQuestion4.TabStop = false;
            groupBoxQuestion4.Text = "4:";
            // 
            // btnShowPatients
            // 
            btnShowPatients.BackColor = SystemColors.ActiveCaption;
            btnShowPatients.Location = new Point(690, 329);
            btnShowPatients.Name = "btnShowPatients";
            btnShowPatients.Size = new Size(298, 45);
            btnShowPatients.TabIndex = 9;
            btnShowPatients.Text = "Show scheduled patients";
            btnShowPatients.UseVisualStyleBackColor = false;
            btnShowPatients.Click += btnShowPatients_Click;
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(586, 32);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(479, 266);
            richTextBox.TabIndex = 8;
            richTextBox.Text = "";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(41, 282);
            lblError.Name = "lblError";
            lblError.Size = new Size(59, 25);
            lblError.TabIndex = 7;
            lblError.Text = "label4";
            // 
            // btnAddToSchedule
            // 
            btnAddToSchedule.BackColor = SystemColors.ActiveCaption;
            btnAddToSchedule.Location = new Point(130, 198);
            btnAddToSchedule.Name = "btnAddToSchedule";
            btnAddToSchedule.Size = new Size(231, 42);
            btnAddToSchedule.TabIndex = 6;
            btnAddToSchedule.Text = "Add to Schedule";
            btnAddToSchedule.UseVisualStyleBackColor = false;
            btnAddToSchedule.Click += btnAddToSchedule_Click;
            // 
            // txtPatientAge
            // 
            txtPatientAge.Location = new Point(202, 140);
            txtPatientAge.Name = "txtPatientAge";
            txtPatientAge.Size = new Size(272, 31);
            txtPatientAge.TabIndex = 5;
            // 
            // txtMedicalRecord
            // 
            txtMedicalRecord.Location = new Point(202, 95);
            txtMedicalRecord.Name = "txtMedicalRecord";
            txtMedicalRecord.Size = new Size(269, 31);
            txtMedicalRecord.TabIndex = 4;
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new Point(202, 54);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(269, 31);
            txtPatientName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 140);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 2;
            label3.Text = "Patient Age:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 95);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 1;
            label2.Text = "Medical record#:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 54);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 0;
            label1.Text = "Patient's full Name:";
            // 
            // RutviM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 881);
            Controls.Add(groupBoxQuestion4);
            Controls.Add(groupBoxQuestion2);
            Controls.Add(groupBoxQuestion3);
            Controls.Add(groupBoxQuestion1);
            Margin = new Padding(5);
            Name = "RutviM";
            Text = "Student: Bart Simpson (123456)";
            Load += RutviM_Load;
            groupBoxQuestion1.ResumeLayout(false);
            groupBoxQuestion1.PerformLayout();
            groupBoxQuestion3.ResumeLayout(false);
            groupBoxQuestion3.PerformLayout();
            groupBoxQuestion2.ResumeLayout(false);
            groupBoxQuestion2.PerformLayout();
            groupBoxQuestion4.ResumeLayout(false);
            groupBoxQuestion4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxQuestion1;
        private GroupBox groupBoxQuestion3;
        private ListBox listBoxMatchingPhrases;
        private Label lblMatchingPhrases;
        private GroupBox groupBoxQuestion2;
        private GroupBox groupBoxQuestion4;
        private Label lblZipCode;
        private TextBox txtZipCode;
        private Button btnCheckAvailability;
        private Label lblInputText;
        private Button btnRemoveVowels;
        private TextBox txtInputText;
        private Label lblOutput;
        private Button btnShowPatients;
        private RichTextBox richTextBox;
        private Label lblError;
        private Button btnAddToSchedule;
        private TextBox txtPatientAge;
        private TextBox txtMedicalRecord;
        private TextBox txtPatientName;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}