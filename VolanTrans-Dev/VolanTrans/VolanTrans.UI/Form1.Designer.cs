namespace VolanTrans.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewPerson = new System.Windows.Forms.Button();
            this.btnDeletePerson = new System.Windows.Forms.Button();
            this.btnSavePerson = new System.Windows.Forms.Button();
            this.textPersonPhone = new System.Windows.Forms.TextBox();
            this.textPersonEmail = new System.Windows.Forms.TextBox();
            this.textPersonName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewPerson = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNewCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.btnSaveCar = new System.Windows.Forms.Button();
            this.textCarYear = new System.Windows.Forms.TextBox();
            this.textCarMM = new System.Windows.Forms.TextBox();
            this.textCarLp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewCar = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRenewNew = new System.Windows.Forms.Button();
            this.dateTimePickerExp = new System.Windows.Forms.DateTimePicker();
            this.richTextBoxRemarks = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRenewDelete = new System.Windows.Forms.Button();
            this.btnRenewSave = new System.Windows.Forms.Button();
            this.textRenewAppliesTo = new System.Windows.Forms.TextBox();
            this.textRenewName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewRenew = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridViewAlert = new System.Windows.Forms.DataGridView();
            this.PersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicensePlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MakeAndModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mijarle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.When = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kiemie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RenewId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppliesTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remaks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerson)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRenew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Controls.Add(this.btnNewPerson);
            this.panel1.Controls.Add(this.btnDeletePerson);
            this.panel1.Controls.Add(this.btnSavePerson);
            this.panel1.Controls.Add(this.textPersonPhone);
            this.panel1.Controls.Add(this.textPersonEmail);
            this.panel1.Controls.Add(this.textPersonName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewPerson);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 129);
            this.panel1.TabIndex = 0;
            // 
            // btnNewPerson
            // 
            this.btnNewPerson.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNewPerson.Location = new System.Drawing.Point(638, 94);
            this.btnNewPerson.Name = "btnNewPerson";
            this.btnNewPerson.Size = new System.Drawing.Size(110, 33);
            this.btnNewPerson.TabIndex = 21;
            this.btnNewPerson.Text = "Új";
            this.btnNewPerson.UseVisualStyleBackColor = false;
            this.btnNewPerson.Click += new System.EventHandler(this.btnNewPerson_Click);
            // 
            // btnDeletePerson
            // 
            this.btnDeletePerson.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDeletePerson.Location = new System.Drawing.Point(886, 94);
            this.btnDeletePerson.Name = "btnDeletePerson";
            this.btnDeletePerson.Size = new System.Drawing.Size(110, 33);
            this.btnDeletePerson.TabIndex = 8;
            this.btnDeletePerson.Text = "Törlés";
            this.btnDeletePerson.UseVisualStyleBackColor = false;
            this.btnDeletePerson.Click += new System.EventHandler(this.btnDeletePerson_Click);
            // 
            // btnSavePerson
            // 
            this.btnSavePerson.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSavePerson.Location = new System.Drawing.Point(759, 94);
            this.btnSavePerson.Name = "btnSavePerson";
            this.btnSavePerson.Size = new System.Drawing.Size(110, 33);
            this.btnSavePerson.TabIndex = 7;
            this.btnSavePerson.Text = "Mentés";
            this.btnSavePerson.UseVisualStyleBackColor = false;
            this.btnSavePerson.Click += new System.EventHandler(this.btnSavePerson_Click);
            // 
            // textPersonPhone
            // 
            this.textPersonPhone.Location = new System.Drawing.Point(697, 65);
            this.textPersonPhone.Name = "textPersonPhone";
            this.textPersonPhone.Size = new System.Drawing.Size(299, 26);
            this.textPersonPhone.TabIndex = 6;
            // 
            // textPersonEmail
            // 
            this.textPersonEmail.Location = new System.Drawing.Point(697, 36);
            this.textPersonEmail.Name = "textPersonEmail";
            this.textPersonEmail.Size = new System.Drawing.Size(299, 26);
            this.textPersonEmail.TabIndex = 5;
            // 
            // textPersonName
            // 
            this.textPersonName.Location = new System.Drawing.Point(697, 8);
            this.textPersonName.Name = "textPersonName";
            this.textPersonName.Size = new System.Drawing.Size(299, 26);
            this.textPersonName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(618, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(618, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név:";
            // 
            // dataGridViewPerson
            // 
            this.dataGridViewPerson.AllowUserToAddRows = false;
            this.dataGridViewPerson.AllowUserToDeleteRows = false;
            this.dataGridViewPerson.AllowUserToOrderColumns = true;
            this.dataGridViewPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonId,
            this.PersonName,
            this.Email,
            this.Phone});
            this.dataGridViewPerson.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPerson.MultiSelect = false;
            this.dataGridViewPerson.Name = "dataGridViewPerson";
            this.dataGridViewPerson.ReadOnly = true;
            this.dataGridViewPerson.RowHeadersVisible = false;
            this.dataGridViewPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPerson.Size = new System.Drawing.Size(612, 130);
            this.dataGridViewPerson.TabIndex = 0;
            this.dataGridViewPerson.SelectionChanged += new System.EventHandler(this.dataGridViewPerson_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 5);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel3.Controls.Add(this.btnNewCar);
            this.panel3.Controls.Add(this.btnDeleteCar);
            this.panel3.Controls.Add(this.btnSaveCar);
            this.panel3.Controls.Add(this.textCarYear);
            this.panel3.Controls.Add(this.textCarMM);
            this.panel3.Controls.Add(this.textCarLp);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.dataGridViewCar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 130);
            this.panel3.TabIndex = 3;
            // 
            // btnNewCar
            // 
            this.btnNewCar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNewCar.Location = new System.Drawing.Point(638, 96);
            this.btnNewCar.Name = "btnNewCar";
            this.btnNewCar.Size = new System.Drawing.Size(110, 33);
            this.btnNewCar.TabIndex = 21;
            this.btnNewCar.Text = "Új";
            this.btnNewCar.UseVisualStyleBackColor = false;
            this.btnNewCar.Click += new System.EventHandler(this.btnNewCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDeleteCar.Location = new System.Drawing.Point(886, 96);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(110, 33);
            this.btnDeleteCar.TabIndex = 8;
            this.btnDeleteCar.Text = "Törlés";
            this.btnDeleteCar.UseVisualStyleBackColor = false;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // btnSaveCar
            // 
            this.btnSaveCar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveCar.Location = new System.Drawing.Point(759, 96);
            this.btnSaveCar.Name = "btnSaveCar";
            this.btnSaveCar.Size = new System.Drawing.Size(110, 33);
            this.btnSaveCar.TabIndex = 7;
            this.btnSaveCar.Text = "Mentés";
            this.btnSaveCar.UseVisualStyleBackColor = false;
            this.btnSaveCar.Click += new System.EventHandler(this.btnSaveCar_Click);
            // 
            // textCarYear
            // 
            this.textCarYear.Location = new System.Drawing.Point(745, 65);
            this.textCarYear.Name = "textCarYear";
            this.textCarYear.Size = new System.Drawing.Size(251, 26);
            this.textCarYear.TabIndex = 6;
            // 
            // textCarMM
            // 
            this.textCarMM.Location = new System.Drawing.Point(745, 36);
            this.textCarMM.Name = "textCarMM";
            this.textCarMM.Size = new System.Drawing.Size(251, 26);
            this.textCarMM.TabIndex = 5;
            // 
            // textCarLp
            // 
            this.textCarLp.Location = new System.Drawing.Point(745, 8);
            this.textCarLp.Name = "textCarLp";
            this.textCarLp.Size = new System.Drawing.Size(251, 26);
            this.textCarLp.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Márka és típus:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Évjárat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(618, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Rendszám:";
            // 
            // dataGridViewCar
            // 
            this.dataGridViewCar.AllowUserToAddRows = false;
            this.dataGridViewCar.AllowUserToDeleteRows = false;
            this.dataGridViewCar.AllowUserToOrderColumns = true;
            this.dataGridViewCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarId,
            this.LicensePlate,
            this.MakeAndModel,
            this.Year});
            this.dataGridViewCar.Location = new System.Drawing.Point(0, 12);
            this.dataGridViewCar.MultiSelect = false;
            this.dataGridViewCar.Name = "dataGridViewCar";
            this.dataGridViewCar.ReadOnly = true;
            this.dataGridViewCar.RowHeadersVisible = false;
            this.dataGridViewCar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCar.Size = new System.Drawing.Size(612, 118);
            this.dataGridViewCar.TabIndex = 0;
            this.dataGridViewCar.SelectionChanged += new System.EventHandler(this.dataGridViewCar_SelectionChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Info;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 264);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1008, 5);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Menu;
            this.panel5.Controls.Add(this.btnRenewNew);
            this.panel5.Controls.Add(this.dateTimePickerExp);
            this.panel5.Controls.Add(this.richTextBoxRemarks);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.btnRenewDelete);
            this.panel5.Controls.Add(this.btnRenewSave);
            this.panel5.Controls.Add(this.textRenewAppliesTo);
            this.panel5.Controls.Add(this.textRenewName);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.dataGridViewRenew);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 269);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1008, 181);
            this.panel5.TabIndex = 5;
            // 
            // btnRenewNew
            // 
            this.btnRenewNew.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRenewNew.Location = new System.Drawing.Point(638, 144);
            this.btnRenewNew.Name = "btnRenewNew";
            this.btnRenewNew.Size = new System.Drawing.Size(110, 33);
            this.btnRenewNew.TabIndex = 20;
            this.btnRenewNew.Text = "Új";
            this.btnRenewNew.UseVisualStyleBackColor = false;
            this.btnRenewNew.Click += new System.EventHandler(this.btnRenewNew_Click);
            // 
            // dateTimePickerExp
            // 
            this.dateTimePickerExp.Location = new System.Drawing.Point(717, 62);
            this.dateTimePickerExp.Name = "dateTimePickerExp";
            this.dateTimePickerExp.Size = new System.Drawing.Size(279, 26);
            this.dateTimePickerExp.TabIndex = 19;
            // 
            // richTextBoxRemarks
            // 
            this.richTextBoxRemarks.Location = new System.Drawing.Point(717, 95);
            this.richTextBoxRemarks.Name = "richTextBoxRemarks";
            this.richTextBoxRemarks.Size = new System.Drawing.Size(279, 43);
            this.richTextBoxRemarks.TabIndex = 18;
            this.richTextBoxRemarks.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(618, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Megjegyzés";
            // 
            // btnRenewDelete
            // 
            this.btnRenewDelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRenewDelete.Location = new System.Drawing.Point(886, 144);
            this.btnRenewDelete.Name = "btnRenewDelete";
            this.btnRenewDelete.Size = new System.Drawing.Size(110, 33);
            this.btnRenewDelete.TabIndex = 16;
            this.btnRenewDelete.Text = "Törlés";
            this.btnRenewDelete.UseVisualStyleBackColor = false;
            this.btnRenewDelete.Click += new System.EventHandler(this.btnRenewDelete_Click);
            // 
            // btnRenewSave
            // 
            this.btnRenewSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRenewSave.Location = new System.Drawing.Point(759, 144);
            this.btnRenewSave.Name = "btnRenewSave";
            this.btnRenewSave.Size = new System.Drawing.Size(110, 33);
            this.btnRenewSave.TabIndex = 15;
            this.btnRenewSave.Text = "Mentés";
            this.btnRenewSave.UseVisualStyleBackColor = false;
            this.btnRenewSave.Click += new System.EventHandler(this.btnRenewSave_Click);
            // 
            // textRenewAppliesTo
            // 
            this.textRenewAppliesTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textRenewAppliesTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textRenewAppliesTo.Location = new System.Drawing.Point(717, 33);
            this.textRenewAppliesTo.Name = "textRenewAppliesTo";
            this.textRenewAppliesTo.Size = new System.Drawing.Size(279, 26);
            this.textRenewAppliesTo.TabIndex = 13;
            // 
            // textRenewName
            // 
            this.textRenewName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textRenewName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textRenewName.Location = new System.Drawing.Point(717, 5);
            this.textRenewName.Name = "textRenewName";
            this.textRenewName.Size = new System.Drawing.Size(279, 26);
            this.textRenewName.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(618, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Kié, mié?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(618, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Lejár ekkor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(618, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Dok. típus:";
            // 
            // dataGridViewRenew
            // 
            this.dataGridViewRenew.AllowUserToAddRows = false;
            this.dataGridViewRenew.AllowUserToDeleteRows = false;
            this.dataGridViewRenew.AllowUserToOrderColumns = true;
            this.dataGridViewRenew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRenew.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RenewId,
            this.NameType,
            this.AppliesTo,
            this.ExpiryDate,
            this.Remaks});
            this.dataGridViewRenew.Location = new System.Drawing.Point(0, 6);
            this.dataGridViewRenew.MultiSelect = false;
            this.dataGridViewRenew.Name = "dataGridViewRenew";
            this.dataGridViewRenew.ReadOnly = true;
            this.dataGridViewRenew.RowHeadersVisible = false;
            this.dataGridViewRenew.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRenew.Size = new System.Drawing.Size(612, 172);
            this.dataGridViewRenew.TabIndex = 0;
            this.dataGridViewRenew.SelectionChanged += new System.EventHandler(this.dataGridViewRenew_SelectionChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 450);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1008, 5);
            this.panel6.TabIndex = 6;
            // 
            // dataGridViewAlert
            // 
            this.dataGridViewAlert.AllowUserToAddRows = false;
            this.dataGridViewAlert.AllowUserToDeleteRows = false;
            this.dataGridViewAlert.AllowUserToOrderColumns = true;
            this.dataGridViewAlert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mijarle,
            this.When,
            this.Kiemie,
            this.Remarks});
            this.dataGridViewAlert.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewAlert.Location = new System.Drawing.Point(0, 455);
            this.dataGridViewAlert.MultiSelect = false;
            this.dataGridViewAlert.Name = "dataGridViewAlert";
            this.dataGridViewAlert.ReadOnly = true;
            this.dataGridViewAlert.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.dataGridViewAlert.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAlert.Size = new System.Drawing.Size(1008, 272);
            this.dataGridViewAlert.TabIndex = 7;
            // 
            // PersonId
            // 
            this.PersonId.HeaderText = "PersonId";
            this.PersonId.Name = "PersonId";
            this.PersonId.ReadOnly = true;
            this.PersonId.Visible = false;
            // 
            // PersonName
            // 
            this.PersonName.HeaderText = "Név";
            this.PersonName.Name = "PersonName";
            this.PersonName.ReadOnly = true;
            this.PersonName.Width = 220;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Telefon";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 190;
            // 
            // CarId
            // 
            this.CarId.HeaderText = "CarId";
            this.CarId.Name = "CarId";
            this.CarId.ReadOnly = true;
            this.CarId.Visible = false;
            // 
            // LicensePlate
            // 
            this.LicensePlate.HeaderText = "Rendszám";
            this.LicensePlate.Name = "LicensePlate";
            this.LicensePlate.ReadOnly = true;
            this.LicensePlate.Width = 160;
            // 
            // MakeAndModel
            // 
            this.MakeAndModel.HeaderText = "Márka és típus";
            this.MakeAndModel.Name = "MakeAndModel";
            this.MakeAndModel.ReadOnly = true;
            this.MakeAndModel.ToolTipText = "Például: Opel Astra";
            this.MakeAndModel.Width = 300;
            // 
            // Year
            // 
            this.Year.HeaderText = "Évjárat";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Width = 150;
            // 
            // Mijarle
            // 
            this.Mijarle.HeaderText = "Mi fog lejárni?";
            this.Mijarle.Name = "Mijarle";
            this.Mijarle.ReadOnly = true;
            this.Mijarle.Width = 270;
            // 
            // When
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.When.DefaultCellStyle = dataGridViewCellStyle1;
            this.When.HeaderText = "Mikor?";
            this.When.Name = "When";
            this.When.ReadOnly = true;
            this.When.Width = 150;
            // 
            // Kiemie
            // 
            this.Kiemie.HeaderText = "Mihez vagy kihez tartozik?";
            this.Kiemie.Name = "Kiemie";
            this.Kiemie.ReadOnly = true;
            this.Kiemie.Width = 250;
            // 
            // Remarks
            // 
            this.Remarks.HeaderText = "Megjegyzés";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            this.Remarks.Width = 340;
            // 
            // RenewId
            // 
            this.RenewId.HeaderText = "RenewId";
            this.RenewId.Name = "RenewId";
            this.RenewId.ReadOnly = true;
            this.RenewId.ToolTipText = "Az érvényesség lejáratának utolsó napja";
            this.RenewId.Visible = false;
            this.RenewId.Width = 110;
            // 
            // NameType
            // 
            this.NameType.HeaderText = "Dokumentumtípus";
            this.NameType.Name = "NameType";
            this.NameType.ReadOnly = true;
            this.NameType.ToolTipText = "Például: Cazier, ITP, RCA, Rovinieta, Aviz medical stb.";
            this.NameType.Width = 150;
            // 
            // AppliesTo
            // 
            this.AppliesTo.FillWeight = 41.66667F;
            this.AppliesTo.HeaderText = "Kié, mié?";
            this.AppliesTo.Name = "AppliesTo";
            this.AppliesTo.ReadOnly = true;
            this.AppliesTo.ToolTipText = "Autó rendszáma vagy oktató kollega neve, a rögzített dokumentum típustól függően";
            this.AppliesTo.Width = 150;
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.HeaderText = "Lejár ekkor";
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.ReadOnly = true;
            this.ExpiryDate.Width = 120;
            // 
            // Remaks
            // 
            this.Remaks.FillWeight = 158.3333F;
            this.Remaks.HeaderText = "Megjegyzés";
            this.Remaks.Name = "Remaks";
            this.Remaks.ReadOnly = true;
            this.Remaks.Width = 200;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.dataGridViewAlert);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VolanTrans";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerson)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRenew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeletePerson;
        private System.Windows.Forms.Button btnSavePerson;
        private System.Windows.Forms.TextBox textPersonPhone;
        private System.Windows.Forms.TextBox textPersonEmail;
        private System.Windows.Forms.TextBox textPersonName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewPerson;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Button btnSaveCar;
        private System.Windows.Forms.TextBox textCarYear;
        private System.Windows.Forms.TextBox textCarMM;
        private System.Windows.Forms.TextBox textCarLp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewCar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RichTextBox richTextBoxRemarks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRenewDelete;
        private System.Windows.Forms.Button btnRenewSave;
        private System.Windows.Forms.TextBox textRenewAppliesTo;
        private System.Windows.Forms.TextBox textRenewName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewRenew;
        private System.Windows.Forms.DateTimePicker dateTimePickerExp;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridViewAlert;
        private System.Windows.Forms.Button btnRenewNew;
        private System.Windows.Forms.Button btnNewPerson;
        private System.Windows.Forms.Button btnNewCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicensePlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MakeAndModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn RenewId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppliesTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remaks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mijarle;
        private System.Windows.Forms.DataGridViewTextBoxColumn When;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kiemie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
    }
}

