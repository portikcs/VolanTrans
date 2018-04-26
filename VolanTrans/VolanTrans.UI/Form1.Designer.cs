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
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.panelMain = new System.Windows.Forms.Panel();
            this.dataGridViewProblem = new System.Windows.Forms.DataGridView();
            this.NumarMAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Problema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dateTimePickerAsgPers = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerRCA = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerITP = new System.Windows.Forms.DateTimePicker();
            this.ITP = new System.Windows.Forms.Label();
            this.textBoxNrsasiu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNrImat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proprietar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCar = new System.Windows.Forms.TabControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonProp = new System.Windows.Forms.RadioButton();
            this.radioButtonInMat = new System.Windows.Forms.RadioButton();
            this.radioButtonSasiu = new System.Windows.Forms.RadioButton();
            this.radioButtonMarca = new System.Windows.Forms.RadioButton();
            this.tabPageMain.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProblem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.tabCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageMain
            // 
            this.tabPageMain.BackColor = System.Drawing.Color.Cyan;
            this.tabPageMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageMain.Controls.Add(this.panelMain);
            this.tabPageMain.Controls.Add(this.dataGridViewMain);
            this.tabPageMain.Location = new System.Drawing.Point(4, 29);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(1000, 696);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Datele autovechiculelor";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Gainsboro;
            this.panelMain.Controls.Add(this.dataGridViewProblem);
            this.panelMain.Controls.Add(this.buttonDelete);
            this.panelMain.Controls.Add(this.buttonSave);
            this.panelMain.Controls.Add(this.dateTimePickerAsgPers);
            this.panelMain.Controls.Add(this.label9);
            this.panelMain.Controls.Add(this.dateTimePickerRCA);
            this.panelMain.Controls.Add(this.label8);
            this.panelMain.Controls.Add(this.dateTimePickerITP);
            this.panelMain.Controls.Add(this.ITP);
            this.panelMain.Controls.Add(this.textBoxNrsasiu);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.textBoxNrImat);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.textBoxTip);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.textBoxModel);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.textBoxMarca);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.textBoxProp);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMain.Location = new System.Drawing.Point(619, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(374, 686);
            this.panelMain.TabIndex = 1;
            // 
            // dataGridViewProblem
            // 
            this.dataGridViewProblem.AllowUserToAddRows = false;
            this.dataGridViewProblem.AllowUserToDeleteRows = false;
            this.dataGridViewProblem.AllowUserToOrderColumns = true;
            this.dataGridViewProblem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProblem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumarMAT,
            this.Problema});
            this.dataGridViewProblem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewProblem.Location = new System.Drawing.Point(0, 515);
            this.dataGridViewProblem.Name = "dataGridViewProblem";
            this.dataGridViewProblem.ReadOnly = true;
            this.dataGridViewProblem.RowHeadersVisible = false;
            this.dataGridViewProblem.Size = new System.Drawing.Size(374, 171);
            this.dataGridViewProblem.TabIndex = 20;
            // 
            // NumarMAT
            // 
            this.NumarMAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumarMAT.HeaderText = "Numar MAT";
            this.NumarMAT.Name = "NumarMAT";
            this.NumarMAT.ReadOnly = true;
            // 
            // Problema
            // 
            this.Problema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Problema.HeaderText = "Problema";
            this.Problema.Name = "Problema";
            this.Problema.ReadOnly = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDelete.Location = new System.Drawing.Point(0, 481);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(374, 28);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Stergere";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSave.Location = new System.Drawing.Point(0, 453);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(374, 28);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Salvare";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dateTimePickerAsgPers
            // 
            this.dateTimePickerAsgPers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePickerAsgPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAsgPers.Location = new System.Drawing.Point(0, 429);
            this.dateTimePickerAsgPers.Name = "dateTimePickerAsgPers";
            this.dateTimePickerAsgPers.Size = new System.Drawing.Size(374, 24);
            this.dateTimePickerAsgPers.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(0, 404);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label9.Size = new System.Drawing.Size(125, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Asig. Pers. exp. :";
            // 
            // dateTimePickerRCA
            // 
            this.dateTimePickerRCA.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePickerRCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerRCA.Location = new System.Drawing.Point(0, 380);
            this.dateTimePickerRCA.Name = "dateTimePickerRCA";
            this.dateTimePickerRCA.Size = new System.Drawing.Size(374, 24);
            this.dateTimePickerRCA.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(0, 355);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label8.Size = new System.Drawing.Size(102, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "RCA expirat :";
            // 
            // dateTimePickerITP
            // 
            this.dateTimePickerITP.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePickerITP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerITP.Location = new System.Drawing.Point(0, 331);
            this.dateTimePickerITP.Name = "dateTimePickerITP";
            this.dateTimePickerITP.Size = new System.Drawing.Size(374, 24);
            this.dateTimePickerITP.TabIndex = 8;
            // 
            // ITP
            // 
            this.ITP.AutoSize = true;
            this.ITP.Dock = System.Windows.Forms.DockStyle.Top;
            this.ITP.Location = new System.Drawing.Point(0, 306);
            this.ITP.Name = "ITP";
            this.ITP.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ITP.Size = new System.Drawing.Size(92, 25);
            this.ITP.TabIndex = 12;
            this.ITP.Text = "ITP expirat :";
            // 
            // textBoxNrsasiu
            // 
            this.textBoxNrsasiu.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxNrsasiu.Location = new System.Drawing.Point(0, 280);
            this.textBoxNrsasiu.Name = "textBoxNrsasiu";
            this.textBoxNrsasiu.Size = new System.Drawing.Size(374, 26);
            this.textBoxNrsasiu.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 255);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Numar sasiu :";
            // 
            // textBoxNrImat
            // 
            this.textBoxNrImat.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxNrImat.Location = new System.Drawing.Point(0, 229);
            this.textBoxNrImat.Name = "textBoxNrImat";
            this.textBoxNrImat.Size = new System.Drawing.Size(374, 26);
            this.textBoxNrImat.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 204);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nr de imatriculare :";
            // 
            // textBoxTip
            // 
            this.textBoxTip.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTip.Location = new System.Drawing.Point(0, 178);
            this.textBoxTip.Name = "textBoxTip";
            this.textBoxTip.Size = new System.Drawing.Size(374, 26);
            this.textBoxTip.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 153);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label4.Size = new System.Drawing.Size(34, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tip:";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxModel.Location = new System.Drawing.Point(0, 127);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(374, 26);
            this.textBoxModel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 102);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Model :";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxMarca.Location = new System.Drawing.Point(0, 76);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(374, 26);
            this.textBoxMarca.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 51);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca :";
            // 
            // textBoxProp
            // 
            this.textBoxProp.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxProp.Location = new System.Drawing.Point(0, 25);
            this.textBoxProp.Name = "textBoxProp";
            this.textBoxProp.Size = new System.Drawing.Size(374, 26);
            this.textBoxProp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proprietar :";
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.AllowUserToOrderColumns = true;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Proprietar,
            this.Marca,
            this.Tipul,
            this.NrMat});
            this.dataGridViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewMain.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMain.MultiSelect = false;
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.RowHeadersVisible = false;
            this.dataGridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMain.ShowEditingIcon = false;
            this.dataGridViewMain.ShowRowErrors = false;
            this.dataGridViewMain.Size = new System.Drawing.Size(990, 686);
            this.dataGridViewMain.TabIndex = 0;
            this.dataGridViewMain.SelectionChanged += new System.EventHandler(this.dataGridViewMain_SelectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Proprietar
            // 
            this.Proprietar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Proprietar.HeaderText = "Proprietar";
            this.Proprietar.Name = "Proprietar";
            this.Proprietar.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Tipul
            // 
            this.Tipul.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tipul.HeaderText = "Tipul";
            this.Tipul.Name = "Tipul";
            this.Tipul.ReadOnly = true;
            // 
            // NrMat
            // 
            this.NrMat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NrMat.HeaderText = "Numar MAT";
            this.NrMat.Name = "NrMat";
            this.NrMat.ReadOnly = true;
            // 
            // tabCar
            // 
            this.tabCar.Controls.Add(this.tabPageMain);
            this.tabCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCar.Location = new System.Drawing.Point(0, 0);
            this.tabCar.Name = "tabCar";
            this.tabCar.SelectedIndex = 0;
            this.tabCar.Size = new System.Drawing.Size(1008, 729);
            this.tabCar.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(324, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cautare :";
            // 
            // radioButtonProp
            // 
            this.radioButtonProp.AutoSize = true;
            this.radioButtonProp.Location = new System.Drawing.Point(563, 5);
            this.radioButtonProp.Name = "radioButtonProp";
            this.radioButtonProp.Size = new System.Drawing.Size(96, 24);
            this.radioButtonProp.TabIndex = 4;
            this.radioButtonProp.TabStop = true;
            this.radioButtonProp.Text = "Proprietar";
            this.radioButtonProp.UseVisualStyleBackColor = true;
            // 
            // radioButtonInMat
            // 
            this.radioButtonInMat.AutoSize = true;
            this.radioButtonInMat.Location = new System.Drawing.Point(657, 5);
            this.radioButtonInMat.Name = "radioButtonInMat";
            this.radioButtonInMat.Size = new System.Drawing.Size(163, 24);
            this.radioButtonInMat.TabIndex = 5;
            this.radioButtonInMat.TabStop = true;
            this.radioButtonInMat.Text = "Nr. de inmatriculare";
            this.radioButtonInMat.UseVisualStyleBackColor = true;
            // 
            // radioButtonSasiu
            // 
            this.radioButtonSasiu.AutoSize = true;
            this.radioButtonSasiu.Location = new System.Drawing.Point(816, 5);
            this.radioButtonSasiu.Name = "radioButtonSasiu";
            this.radioButtonSasiu.Size = new System.Drawing.Size(88, 24);
            this.radioButtonSasiu.TabIndex = 6;
            this.radioButtonSasiu.TabStop = true;
            this.radioButtonSasiu.Text = "Nr. sasiu";
            this.radioButtonSasiu.UseVisualStyleBackColor = true;
            // 
            // radioButtonMarca
            // 
            this.radioButtonMarca.AutoSize = true;
            this.radioButtonMarca.Location = new System.Drawing.Point(910, 5);
            this.radioButtonMarca.Name = "radioButtonMarca";
            this.radioButtonMarca.Size = new System.Drawing.Size(71, 24);
            this.radioButtonMarca.TabIndex = 7;
            this.radioButtonMarca.TabStop = true;
            this.radioButtonMarca.Text = "Marca";
            this.radioButtonMarca.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.radioButtonMarca);
            this.Controls.Add(this.radioButtonSasiu);
            this.Controls.Add(this.radioButtonInMat);
            this.Controls.Add(this.radioButtonProp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabCar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volan Trans";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabPageMain.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProblem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.tabCar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dataGridViewProblem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumarMAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Problema;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker dateTimePickerAsgPers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePickerRCA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerITP;
        private System.Windows.Forms.Label ITP;
        private System.Windows.Forms.TextBox textBoxNrsasiu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNrImat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proprietar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipul;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrMat;
        private System.Windows.Forms.TabControl tabCar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonProp;
        private System.Windows.Forms.RadioButton radioButtonInMat;
        private System.Windows.Forms.RadioButton radioButtonSasiu;
        private System.Windows.Forms.RadioButton radioButtonMarca;
    }
}

