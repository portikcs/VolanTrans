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
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.tabCar = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.toolStripStatusLabelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProp = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNrImat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNrsasiu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ITP = new System.Windows.Forms.Label();
            this.dateTimePickerITP = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerRCA = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerAsgPers = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewProblem = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.NumarMAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Problema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proprietar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStripMain.SuspendLayout();
            this.tabCar.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProblem)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelDate,
            this.toolStripProgressBar});
            this.statusStripMain.Location = new System.Drawing.Point(0, 707);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1008, 22);
            this.statusStripMain.TabIndex = 0;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // tabCar
            // 
            this.tabCar.Controls.Add(this.tabPageMain);
            this.tabCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCar.Location = new System.Drawing.Point(0, 0);
            this.tabCar.Name = "tabCar";
            this.tabCar.SelectedIndex = 0;
            this.tabCar.Size = new System.Drawing.Size(1008, 707);
            this.tabCar.TabIndex = 1;
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
            this.tabPageMain.Size = new System.Drawing.Size(1000, 674);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Datele autovechiculelor";
            // 
            // toolStripStatusLabelDate
            // 
            this.toolStripStatusLabelDate.Name = "toolStripStatusLabelDate";
            this.toolStripStatusLabelDate.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelDate.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
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
            this.dataGridViewMain.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.RowHeadersVisible = false;
            this.dataGridViewMain.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewMain.Size = new System.Drawing.Size(990, 664);
            this.dataGridViewMain.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Gainsboro;
            this.panelMain.Controls.Add(this.label7);
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
            this.panelMain.Size = new System.Drawing.Size(374, 664);
            this.panelMain.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proprietar :";
            // 
            // textBoxProp
            // 
            this.textBoxProp.Location = new System.Drawing.Point(150, 3);
            this.textBoxProp.Name = "textBoxProp";
            this.textBoxProp.Size = new System.Drawing.Size(218, 26);
            this.textBoxProp.TabIndex = 1;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(150, 44);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(218, 26);
            this.textBoxMarca.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca :";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(150, 88);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(218, 26);
            this.textBoxModel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Model :";
            // 
            // textBoxTip
            // 
            this.textBoxTip.Location = new System.Drawing.Point(150, 131);
            this.textBoxTip.Name = "textBoxTip";
            this.textBoxTip.Size = new System.Drawing.Size(218, 26);
            this.textBoxTip.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tip:";
            // 
            // textBoxNrImat
            // 
            this.textBoxNrImat.Location = new System.Drawing.Point(150, 176);
            this.textBoxNrImat.Name = "textBoxNrImat";
            this.textBoxNrImat.Size = new System.Drawing.Size(218, 26);
            this.textBoxNrImat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nr de imatriculare :";
            // 
            // textBoxNrsasiu
            // 
            this.textBoxNrsasiu.Location = new System.Drawing.Point(150, 217);
            this.textBoxNrsasiu.Name = "textBoxNrsasiu";
            this.textBoxNrsasiu.Size = new System.Drawing.Size(218, 26);
            this.textBoxNrsasiu.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Numar sasiu :";
            // 
            // ITP
            // 
            this.ITP.AutoSize = true;
            this.ITP.Location = new System.Drawing.Point(0, 294);
            this.ITP.Name = "ITP";
            this.ITP.Size = new System.Drawing.Size(92, 20);
            this.ITP.TabIndex = 12;
            this.ITP.Text = "ITP expirat :";
            // 
            // dateTimePickerITP
            // 
            this.dateTimePickerITP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerITP.Location = new System.Drawing.Point(131, 294);
            this.dateTimePickerITP.Name = "dateTimePickerITP";
            this.dateTimePickerITP.Size = new System.Drawing.Size(237, 24);
            this.dateTimePickerITP.TabIndex = 13;
            // 
            // dateTimePickerRCA
            // 
            this.dateTimePickerRCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerRCA.Location = new System.Drawing.Point(131, 331);
            this.dateTimePickerRCA.Name = "dateTimePickerRCA";
            this.dateTimePickerRCA.Size = new System.Drawing.Size(237, 24);
            this.dateTimePickerRCA.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "RCA expirat :";
            // 
            // dateTimePickerAsgPers
            // 
            this.dateTimePickerAsgPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAsgPers.Location = new System.Drawing.Point(131, 374);
            this.dateTimePickerAsgPers.Name = "dateTimePickerAsgPers";
            this.dateTimePickerAsgPers.Size = new System.Drawing.Size(237, 24);
            this.dateTimePickerAsgPers.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Asig. Pers. exp. :";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSave.Location = new System.Drawing.Point(252, 422);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(116, 28);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "Salvare";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonDelete.Location = new System.Drawing.Point(8, 422);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(116, 28);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Stergere";
            this.buttonDelete.UseVisualStyleBackColor = false;
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
            this.dataGridViewProblem.Location = new System.Drawing.Point(0, 497);
            this.dataGridViewProblem.Name = "dataGridViewProblem";
            this.dataGridViewProblem.ReadOnly = true;
            this.dataGridViewProblem.RowHeadersVisible = false;
            this.dataGridViewProblem.Size = new System.Drawing.Size(374, 167);
            this.dataGridViewProblem.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Autovechicule necesita atentie:";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tabCar);
            this.Controls.Add(this.statusStripMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volan Trans";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.tabCar.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProblem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDate;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.TabControl tabCar;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewProblem;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn NumarMAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Problema;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proprietar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipul;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrMat;
    }
}

