namespace Filtro
{
    partial class FrmFiltro
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRegGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegComent = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkRegGorra = new System.Windows.Forms.CheckBox();
            this.chkLentes = new System.Windows.Forms.CheckBox();
            this.chkRegLap = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRegCel = new System.Windows.Forms.ComboBox();
            this.chkRegOtro = new System.Windows.Forms.CheckBox();
            this.chkRegLonc = new System.Windows.Forms.CheckBox();
            this.chkRegMochila = new System.Windows.Forms.CheckBox();
            this.chkRegBolsa = new System.Windows.Forms.CheckBox();
            this.LABEL = new System.Windows.Forms.Label();
            this.txtRegNoEmp = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblRegNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgVer = new System.Windows.Forms.DataGridView();
            this.dtVerFecha = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnGenExDia = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVer)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(592, 347);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRegGuardar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtRegComent);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.LABEL);
            this.tabPage1.Controls.Add(this.txtRegNoEmp);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(584, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar entrada";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRegGuardar
            // 
            this.btnRegGuardar.Location = new System.Drawing.Point(104, 68);
            this.btnRegGuardar.Name = "btnRegGuardar";
            this.btnRegGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnRegGuardar.TabIndex = 6;
            this.btnRegGuardar.Text = "Registar";
            this.btnRegGuardar.UseVisualStyleBackColor = true;
            this.btnRegGuardar.Click += new System.EventHandler(this.btnRegGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Comentarios:";
            // 
            // txtRegComent
            // 
            this.txtRegComent.Location = new System.Drawing.Point(9, 159);
            this.txtRegComent.Multiline = true;
            this.txtRegComent.Name = "txtRegComent";
            this.txtRegComent.Size = new System.Drawing.Size(567, 80);
            this.txtRegComent.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.chkRegGorra);
            this.groupBox1.Controls.Add(this.chkLentes);
            this.groupBox1.Controls.Add(this.chkRegLap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbRegCel);
            this.groupBox1.Controls.Add(this.chkRegOtro);
            this.groupBox1.Controls.Add(this.chkRegLonc);
            this.groupBox1.Controls.Add(this.chkRegMochila);
            this.groupBox1.Controls.Add(this.chkRegBolsa);
            this.groupBox1.Location = new System.Drawing.Point(205, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 94);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Objetos";
            // 
            // chkRegGorra
            // 
            this.chkRegGorra.AutoSize = true;
            this.chkRegGorra.Location = new System.Drawing.Point(264, 60);
            this.chkRegGorra.Name = "chkRegGorra";
            this.chkRegGorra.Size = new System.Drawing.Size(52, 17);
            this.chkRegGorra.TabIndex = 11;
            this.chkRegGorra.Text = "Gorra";
            this.chkRegGorra.UseVisualStyleBackColor = true;
            // 
            // chkLentes
            // 
            this.chkLentes.AutoSize = true;
            this.chkLentes.Location = new System.Drawing.Point(200, 60);
            this.chkLentes.Name = "chkLentes";
            this.chkLentes.Size = new System.Drawing.Size(58, 17);
            this.chkLentes.TabIndex = 10;
            this.chkLentes.Text = "Lentes";
            this.chkLentes.UseVisualStyleBackColor = true;
            // 
            // chkRegLap
            // 
            this.chkRegLap.AutoSize = true;
            this.chkRegLap.Location = new System.Drawing.Point(135, 61);
            this.chkRegLap.Name = "chkRegLap";
            this.chkRegLap.Size = new System.Drawing.Size(59, 17);
            this.chkRegLap.TabIndex = 9;
            this.chkRegLap.Text = "Laptop";
            this.chkRegLap.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Celular:";
            // 
            // cmbRegCel
            // 
            this.cmbRegCel.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbRegCel.FormattingEnabled = true;
            this.cmbRegCel.Items.AddRange(new object[] {
            "LG",
            "SAMSUNG",
            "NOKIA",
            "IPHONE",
            "M4",
            "ZTE",
            "SONY",
            "MOTOROLA",
            "HUAWEI",
            "ALCATEL",
            "HTC",
            "BLU"});
            this.cmbRegCel.Location = new System.Drawing.Point(158, 23);
            this.cmbRegCel.Name = "cmbRegCel";
            this.cmbRegCel.Size = new System.Drawing.Size(81, 21);
            this.cmbRegCel.TabIndex = 7;
            this.cmbRegCel.Text = "Ninguno";
            this.cmbRegCel.SelectedIndexChanged += new System.EventHandler(this.cmbRegCel_SelectedIndexChanged);
            // 
            // chkRegOtro
            // 
            this.chkRegOtro.AutoSize = true;
            this.chkRegOtro.Location = new System.Drawing.Point(83, 62);
            this.chkRegOtro.Name = "chkRegOtro";
            this.chkRegOtro.Size = new System.Drawing.Size(46, 17);
            this.chkRegOtro.TabIndex = 6;
            this.chkRegOtro.Text = "Otro";
            this.chkRegOtro.UseVisualStyleBackColor = true;
            // 
            // chkRegLonc
            // 
            this.chkRegLonc.AutoSize = true;
            this.chkRegLonc.Location = new System.Drawing.Point(15, 62);
            this.chkRegLonc.Name = "chkRegLonc";
            this.chkRegLonc.Size = new System.Drawing.Size(62, 17);
            this.chkRegLonc.TabIndex = 5;
            this.chkRegLonc.Text = "Lonche";
            this.chkRegLonc.UseVisualStyleBackColor = true;
            // 
            // chkRegMochila
            // 
            this.chkRegMochila.AutoSize = true;
            this.chkRegMochila.Location = new System.Drawing.Point(77, 19);
            this.chkRegMochila.Name = "chkRegMochila";
            this.chkRegMochila.Size = new System.Drawing.Size(63, 17);
            this.chkRegMochila.TabIndex = 4;
            this.chkRegMochila.Text = "Mochila";
            this.chkRegMochila.UseVisualStyleBackColor = true;
            // 
            // chkRegBolsa
            // 
            this.chkRegBolsa.AutoSize = true;
            this.chkRegBolsa.Location = new System.Drawing.Point(6, 19);
            this.chkRegBolsa.Name = "chkRegBolsa";
            this.chkRegBolsa.Size = new System.Drawing.Size(52, 17);
            this.chkRegBolsa.TabIndex = 2;
            this.chkRegBolsa.Text = "Bolsa";
            this.chkRegBolsa.UseVisualStyleBackColor = true;
            // 
            // LABEL
            // 
            this.LABEL.AutoSize = true;
            this.LABEL.Location = new System.Drawing.Point(6, 30);
            this.LABEL.Name = "LABEL";
            this.LABEL.Size = new System.Drawing.Size(78, 13);
            this.LABEL.TabIndex = 1;
            this.LABEL.Text = "# de empleado";
            // 
            // txtRegNoEmp
            // 
            this.txtRegNoEmp.Location = new System.Drawing.Point(90, 27);
            this.txtRegNoEmp.Name = "txtRegNoEmp";
            this.txtRegNoEmp.Size = new System.Drawing.Size(100, 20);
            this.txtRegNoEmp.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblRegNum);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dtgVer);
            this.tabPage2.Controls.Add(this.dtVerFecha);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(584, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ver registrados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblRegNum
            // 
            this.lblRegNum.AutoSize = true;
            this.lblRegNum.Location = new System.Drawing.Point(465, 285);
            this.lblRegNum.Name = "lblRegNum";
            this.lblRegNum.Size = new System.Drawing.Size(0, 13);
            this.lblRegNum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // dtgVer
            // 
            this.dtgVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVer.Location = new System.Drawing.Point(33, 89);
            this.dtgVer.Name = "dtgVer";
            this.dtgVer.Size = new System.Drawing.Size(520, 189);
            this.dtgVer.TabIndex = 1;
            // 
            // dtVerFecha
            // 
            this.dtVerFecha.Location = new System.Drawing.Point(183, 47);
            this.dtVerFecha.Name = "dtVerFecha";
            this.dtVerFecha.Size = new System.Drawing.Size(200, 20);
            this.dtVerFecha.TabIndex = 0;
            this.dtVerFecha.ValueChanged += new System.EventHandler(this.dtVerFecha_ValueChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dateTimePicker1);
            this.tabPage3.Controls.Add(this.btnGenExDia);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(584, 321);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Generar Reporte";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnGenExDia
            // 
            this.btnGenExDia.Location = new System.Drawing.Point(207, 126);
            this.btnGenExDia.Name = "btnGenExDia";
            this.btnGenExDia.Size = new System.Drawing.Size(135, 23);
            this.btnGenExDia.TabIndex = 0;
            this.btnGenExDia.Text = "Generar excel";
            this.btnGenExDia.UseVisualStyleBackColor = true;
            this.btnGenExDia.Click += new System.EventHandler(this.btnGenExDia_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(181, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Celular:";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "LG",
            "SAMSUNG",
            "NOKIA",
            "IPHONE",
            "M4",
            "ZTE",
            "SONY",
            "MOTOROLA",
            "HUAWEI",
            "ALCATEL",
            "HTC",
            "BLU"});
            this.comboBox1.Location = new System.Drawing.Point(245, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(81, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Ninguno";
            // 
            // FrmFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 347);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmFiltro";
            this.Text = "Filtro - Inicio";
            this.Load += new System.EventHandler(this.FrmFiltro_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVer)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnRegGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegComent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkRegOtro;
        private System.Windows.Forms.CheckBox chkRegLonc;
        private System.Windows.Forms.CheckBox chkRegMochila;
        private System.Windows.Forms.CheckBox chkRegBolsa;
        private System.Windows.Forms.Label LABEL;
        private System.Windows.Forms.TextBox txtRegNoEmp;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgVer;
        private System.Windows.Forms.DateTimePicker dtVerFecha;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenExDia;
        private System.Windows.Forms.Label lblRegNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRegCel;
        private System.Windows.Forms.CheckBox chkRegGorra;
        private System.Windows.Forms.CheckBox chkLentes;
        private System.Windows.Forms.CheckBox chkRegLap;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}