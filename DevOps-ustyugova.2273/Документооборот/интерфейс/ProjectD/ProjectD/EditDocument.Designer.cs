
namespace ProjectD
{
    partial class EditDocument
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDocument));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numderDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDocumentDataSet = new ProjectD.dbDocumentDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.documentStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.typeDocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.initiatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.coordinatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.executorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numderDepartmentTableAdapter = new ProjectD.dbDocumentDataSetTableAdapters.NumderDepartmentTableAdapter();
            this.documentStatusTableAdapter = new ProjectD.dbDocumentDataSetTableAdapters.DocumentStatusTableAdapter();
            this.typeDocumentTableAdapter = new ProjectD.dbDocumentDataSetTableAdapters.TypeDocumentTableAdapter();
            this.initiatorTableAdapter = new ProjectD.dbDocumentDataSetTableAdapters.InitiatorTableAdapter();
            this.coordinatorTableAdapter = new ProjectD.dbDocumentDataSetTableAdapters.CoordinatorTableAdapter();
            this.executorTableAdapter = new ProjectD.dbDocumentDataSetTableAdapters.ExecutorTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numderDepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDocumentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeDocumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initiatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.executorBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(478, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(250, 107);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 30);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(250, 161);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(244, 81);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(250, 423);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(771, 92);
            this.textBox3.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(250, 263);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 31);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Checked = false;
            this.dateTimePicker2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(250, 337);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowCheckBox = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(184, 31);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(250, 300);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(184, 31);
            this.dateTimePicker3.TabIndex = 6;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(250, 374);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(184, 31);
            this.dateTimePicker4.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.numderDepartmentBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(746, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(275, 32);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "idNumderDepartment";
            // 
            // numderDepartmentBindingSource
            // 
            this.numderDepartmentBindingSource.DataMember = "NumderDepartment";
            this.numderDepartmentBindingSource.DataSource = this.dbDocumentDataSet;
            // 
            // dbDocumentDataSet
            // 
            this.dbDocumentDataSet.DataSetName = "dbDocumentDataSet";
            this.dbDocumentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.documentStatusBindingSource;
            this.comboBox2.DisplayMember = "Status";
            this.comboBox2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(746, 159);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(275, 32);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.ValueMember = "idDocumentStatus";
            // 
            // documentStatusBindingSource
            // 
            this.documentStatusBindingSource.DataMember = "DocumentStatus";
            this.documentStatusBindingSource.DataSource = this.dbDocumentDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.typeDocumentBindingSource;
            this.comboBox3.DisplayMember = "Type";
            this.comboBox3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(746, 210);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(275, 32);
            this.comboBox3.TabIndex = 10;
            this.comboBox3.ValueMember = "idTypeDocument";
            // 
            // typeDocumentBindingSource
            // 
            this.typeDocumentBindingSource.DataMember = "TypeDocument";
            this.typeDocumentBindingSource.DataSource = this.dbDocumentDataSet;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.initiatorBindingSource;
            this.comboBox4.DisplayMember = "idPersonelNumber";
            this.comboBox4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(746, 265);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(275, 32);
            this.comboBox4.TabIndex = 11;
            this.comboBox4.ValueMember = "idinitiator";
            // 
            // initiatorBindingSource
            // 
            this.initiatorBindingSource.DataMember = "Initiator";
            this.initiatorBindingSource.DataSource = this.dbDocumentDataSet;
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.coordinatorBindingSource;
            this.comboBox5.DisplayMember = "idPersonelNumber";
            this.comboBox5.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(746, 320);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(275, 32);
            this.comboBox5.TabIndex = 12;
            this.comboBox5.ValueMember = "idCoordinator";
            // 
            // coordinatorBindingSource
            // 
            this.coordinatorBindingSource.DataMember = "Coordinator";
            this.coordinatorBindingSource.DataSource = this.dbDocumentDataSet;
            // 
            // comboBox6
            // 
            this.comboBox6.DataSource = this.executorBindingSource;
            this.comboBox6.DisplayMember = "idPersonelNumber";
            this.comboBox6.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(746, 371);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(275, 32);
            this.comboBox6.TabIndex = 13;
            this.comboBox6.ValueMember = "idExecutor";
            // 
            // executorBindingSource
            // 
            this.executorBindingSource.DataMember = "Executor";
            this.executorBindingSource.DataSource = this.dbDocumentDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(31, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 24);
            this.label7.TabIndex = 27;
            this.label7.Text = "Дата редактирования";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(77, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "Дата окончания";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(106, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Дата начала";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(57, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Дата регистрации";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(101, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Примечание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(114, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Регистрационный номер";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(523, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 24);
            this.label8.TabIndex = 28;
            this.label8.Text = "Номер департамента";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(545, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 24);
            this.label9.TabIndex = 29;
            this.label9.Text = "Статуст документа";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(571, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 24);
            this.label10.TabIndex = 30;
            this.label10.Text = "Тип документа";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(604, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 24);
            this.label11.TabIndex = 31;
            this.label11.Text = "Инициатор";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(581, 320);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 24);
            this.label12.TabIndex = 32;
            this.label12.Text = "Согласующий";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(585, 371);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 24);
            this.label13.TabIndex = 33;
            this.label13.Text = "Исполнитель";
            // 
            // numderDepartmentTableAdapter
            // 
            this.numderDepartmentTableAdapter.ClearBeforeFill = true;
            // 
            // documentStatusTableAdapter
            // 
            this.documentStatusTableAdapter.ClearBeforeFill = true;
            // 
            // typeDocumentTableAdapter
            // 
            this.typeDocumentTableAdapter.ClearBeforeFill = true;
            // 
            // initiatorTableAdapter
            // 
            this.initiatorTableAdapter.ClearBeforeFill = true;
            // 
            // coordinatorTableAdapter
            // 
            this.coordinatorTableAdapter.ClearBeforeFill = true;
            // 
            // executorTableAdapter
            // 
            this.executorTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 92);
            this.panel1.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.SystemColors.Window;
            this.label14.Location = new System.Drawing.Point(271, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(515, 53);
            this.label14.TabIndex = 0;
            this.label14.Text = "Редактирование документа";
            // 
            // EditDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1062, 603);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditDocument";
            this.Text = "МУП \"Энергетик\"";
            this.Load += new System.EventHandler(this.EditDocument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numderDepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDocumentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeDocumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initiatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.executorBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        protected internal System.Windows.Forms.TextBox textBox1;
        protected internal System.Windows.Forms.TextBox textBox2;
        protected internal System.Windows.Forms.TextBox textBox3;
        protected internal System.Windows.Forms.DateTimePicker dateTimePicker1;
        protected internal System.Windows.Forms.DateTimePicker dateTimePicker2;
        protected internal System.Windows.Forms.DateTimePicker dateTimePicker3;
        protected internal System.Windows.Forms.DateTimePicker dateTimePicker4;
        protected internal System.Windows.Forms.ComboBox comboBox1;
        protected internal System.Windows.Forms.ComboBox comboBox2;
        protected internal System.Windows.Forms.ComboBox comboBox3;
        protected internal System.Windows.Forms.ComboBox comboBox4;
        protected internal System.Windows.Forms.ComboBox comboBox5;
        protected internal System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private dbDocumentDataSet dbDocumentDataSet;
        private System.Windows.Forms.BindingSource numderDepartmentBindingSource;
        private dbDocumentDataSetTableAdapters.NumderDepartmentTableAdapter numderDepartmentTableAdapter;
        private System.Windows.Forms.BindingSource documentStatusBindingSource;
        private dbDocumentDataSetTableAdapters.DocumentStatusTableAdapter documentStatusTableAdapter;
        private System.Windows.Forms.BindingSource typeDocumentBindingSource;
        private dbDocumentDataSetTableAdapters.TypeDocumentTableAdapter typeDocumentTableAdapter;
        private System.Windows.Forms.BindingSource initiatorBindingSource;
        private dbDocumentDataSetTableAdapters.InitiatorTableAdapter initiatorTableAdapter;
        private System.Windows.Forms.BindingSource coordinatorBindingSource;
        private dbDocumentDataSetTableAdapters.CoordinatorTableAdapter coordinatorTableAdapter;
        private System.Windows.Forms.BindingSource executorBindingSource;
        private dbDocumentDataSetTableAdapters.ExecutorTableAdapter executorTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
    }
}