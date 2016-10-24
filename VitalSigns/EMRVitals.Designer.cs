namespace VitalSigns
{
    partial class VitalSign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VitalSign));
            this.vitalSignPanel = new System.Windows.Forms.Panel();
            this.historyPanel = new System.Windows.Forms.Panel();
            this.gridVitals = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.BMIlabel = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.link_btnBMI = new System.Windows.Forms.LinkLabel();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtResp = new System.Windows.Forms.TextBox();
            this.txtPulse = new System.Windows.Forms.TextBox();
            this.txtBP = new System.Windows.Forms.TextBox();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sInfogramPanel = new System.Windows.Forms.Panel();
            this.link_btnPatientFinder = new System.Windows.Forms.LinkLabel();
            this.lblPhysician = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.sPictureBx = new System.Windows.Forms.PictureBox();
            this.lblVisitType = new System.Windows.Forms.Label();
            this.lblLastVisit = new System.Windows.Forms.Label();
            this.lblPlanType = new System.Windows.Forms.Label();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.lblHmoid = new System.Windows.Forms.Label();
            this.lblHmoname = new System.Windows.Forms.Label();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.lblPatientType = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.summarySearchPanel = new System.Windows.Forms.Panel();
            this.sSearchGroupBx = new System.Windows.Forms.GroupBox();
            this.sSearchGrid = new System.Windows.Forms.DataGridView();
            this.txt_Filter = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.btn_sSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.staffID = new System.Windows.Forms.Label();
            this.vitalSignPanel.SuspendLayout();
            this.historyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVitals)).BeginInit();
            this.panel1.SuspendLayout();
            this.sInfogramPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPictureBx)).BeginInit();
            this.summarySearchPanel.SuspendLayout();
            this.sSearchGroupBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sSearchGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // vitalSignPanel
            // 
            this.vitalSignPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vitalSignPanel.Controls.Add(this.historyPanel);
            this.vitalSignPanel.Controls.Add(this.panel1);
            this.vitalSignPanel.Controls.Add(this.sInfogramPanel);
            this.vitalSignPanel.Location = new System.Drawing.Point(2, 26);
            this.vitalSignPanel.Name = "vitalSignPanel";
            this.vitalSignPanel.Size = new System.Drawing.Size(777, 561);
            this.vitalSignPanel.TabIndex = 0;
            // 
            // historyPanel
            // 
            this.historyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.historyPanel.Controls.Add(this.gridVitals);
            this.historyPanel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyPanel.Location = new System.Drawing.Point(2, 383);
            this.historyPanel.Name = "historyPanel";
            this.historyPanel.Size = new System.Drawing.Size(772, 173);
            this.historyPanel.TabIndex = 5;
            // 
            // gridVitals
            // 
            this.gridVitals.AllowUserToAddRows = false;
            this.gridVitals.AllowUserToDeleteRows = false;
            this.gridVitals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVitals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVitals.Location = new System.Drawing.Point(3, 2);
            this.gridVitals.Name = "gridVitals";
            this.gridVitals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVitals.Size = new System.Drawing.Size(764, 166);
            this.gridVitals.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.BMIlabel);
            this.panel1.Controls.Add(this.lblBMI);
            this.panel1.Controls.Add(this.link_btnBMI);
            this.panel1.Controls.Add(this.txtHeight);
            this.panel1.Controls.Add(this.txtWeight);
            this.panel1.Controls.Add(this.txtResp);
            this.panel1.Controls.Add(this.txtPulse);
            this.panel1.Controls.Add(this.txtBP);
            this.panel1.Controls.Add(this.txtTemperature);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(2, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 128);
            this.panel1.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(662, 96);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BMIlabel
            // 
            this.BMIlabel.AutoSize = true;
            this.BMIlabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIlabel.Location = new System.Drawing.Point(694, 72);
            this.BMIlabel.Name = "BMIlabel";
            this.BMIlabel.Size = new System.Drawing.Size(0, 13);
            this.BMIlabel.TabIndex = 15;
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMI.Location = new System.Drawing.Point(616, 72);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(0, 13);
            this.lblBMI.TabIndex = 14;
            // 
            // link_btnBMI
            // 
            this.link_btnBMI.AutoSize = true;
            this.link_btnBMI.Location = new System.Drawing.Point(519, 72);
            this.link_btnBMI.Name = "link_btnBMI";
            this.link_btnBMI.Size = new System.Drawing.Size(58, 13);
            this.link_btnBMI.TabIndex = 13;
            this.link_btnBMI.TabStop = true;
            this.link_btnBMI.Text = "[Calculate]";
            this.link_btnBMI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_btnBMI_LinkClicked);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(522, 40);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(215, 21);
            this.txtHeight.TabIndex = 12;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(522, 11);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(215, 21);
            this.txtWeight.TabIndex = 11;
            // 
            // txtResp
            // 
            this.txtResp.Location = new System.Drawing.Point(158, 98);
            this.txtResp.Name = "txtResp";
            this.txtResp.Size = new System.Drawing.Size(215, 21);
            this.txtResp.TabIndex = 10;
            // 
            // txtPulse
            // 
            this.txtPulse.Location = new System.Drawing.Point(158, 69);
            this.txtPulse.Name = "txtPulse";
            this.txtPulse.Size = new System.Drawing.Size(215, 21);
            this.txtPulse.TabIndex = 9;
            // 
            // txtBP
            // 
            this.txtBP.Location = new System.Drawing.Point(158, 40);
            this.txtBP.Name = "txtBP";
            this.txtBP.Size = new System.Drawing.Size(215, 21);
            this.txtBP.TabIndex = 8;
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(158, 11);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(215, 21);
            this.txtTemperature.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Respiration (c/m)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(402, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Body Mass Index (BMI)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Height (m)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Weight (Kg)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Pulse (bpm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Blood Pressure (mm Hg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Temperature (°C)";
            // 
            // sInfogramPanel
            // 
            this.sInfogramPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sInfogramPanel.Controls.Add(this.link_btnPatientFinder);
            this.sInfogramPanel.Controls.Add(this.lblPhysician);
            this.sInfogramPanel.Controls.Add(this.label102);
            this.sInfogramPanel.Controls.Add(this.label100);
            this.sInfogramPanel.Controls.Add(this.label99);
            this.sInfogramPanel.Controls.Add(this.sPictureBx);
            this.sInfogramPanel.Controls.Add(this.lblVisitType);
            this.sInfogramPanel.Controls.Add(this.lblLastVisit);
            this.sInfogramPanel.Controls.Add(this.lblPlanType);
            this.sInfogramPanel.Controls.Add(this.lblServiceType);
            this.sInfogramPanel.Controls.Add(this.lblHmoid);
            this.sInfogramPanel.Controls.Add(this.lblHmoname);
            this.sInfogramPanel.Controls.Add(this.lblBloodGroup);
            this.sInfogramPanel.Controls.Add(this.lblPatientType);
            this.sInfogramPanel.Controls.Add(this.lblAge);
            this.sInfogramPanel.Controls.Add(this.lblDOB);
            this.sInfogramPanel.Controls.Add(this.lblCardNumber);
            this.sInfogramPanel.Controls.Add(this.label87);
            this.sInfogramPanel.Controls.Add(this.label86);
            this.sInfogramPanel.Controls.Add(this.lblName);
            this.sInfogramPanel.Controls.Add(this.label84);
            this.sInfogramPanel.Controls.Add(this.label83);
            this.sInfogramPanel.Controls.Add(this.label82);
            this.sInfogramPanel.Controls.Add(this.label81);
            this.sInfogramPanel.Controls.Add(this.label80);
            this.sInfogramPanel.Controls.Add(this.label79);
            this.sInfogramPanel.Controls.Add(this.label78);
            this.sInfogramPanel.Controls.Add(this.label77);
            this.sInfogramPanel.Location = new System.Drawing.Point(2, 1);
            this.sInfogramPanel.Name = "sInfogramPanel";
            this.sInfogramPanel.Size = new System.Drawing.Size(772, 243);
            this.sInfogramPanel.TabIndex = 3;
            // 
            // link_btnPatientFinder
            // 
            this.link_btnPatientFinder.AutoSize = true;
            this.link_btnPatientFinder.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_btnPatientFinder.Location = new System.Drawing.Point(7, 13);
            this.link_btnPatientFinder.Name = "link_btnPatientFinder";
            this.link_btnPatientFinder.Size = new System.Drawing.Size(102, 13);
            this.link_btnPatientFinder.TabIndex = 27;
            this.link_btnPatientFinder.TabStop = true;
            this.link_btnPatientFinder.Text = "[Select New Patient]";
            this.link_btnPatientFinder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_btnPatientFinder_LinkClicked);
            // 
            // lblPhysician
            // 
            this.lblPhysician.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPhysician.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhysician.Location = new System.Drawing.Point(223, 215);
            this.lblPhysician.Name = "lblPhysician";
            this.lblPhysician.Size = new System.Drawing.Size(226, 21);
            this.lblPhysician.TabIndex = 26;
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label102.Location = new System.Drawing.Point(153, 219);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(52, 13);
            this.label102.TabIndex = 25;
            this.label102.Text = "Physician";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.Location = new System.Drawing.Point(455, 185);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(52, 13);
            this.label100.TabIndex = 24;
            this.label100.Text = "Visit Type";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.Location = new System.Drawing.Point(455, 155);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(50, 13);
            this.label99.TabIndex = 23;
            this.label99.Text = "Last Visit";
            // 
            // sPictureBx
            // 
            this.sPictureBx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sPictureBx.Location = new System.Drawing.Point(4, 37);
            this.sPictureBx.Name = "sPictureBx";
            this.sPictureBx.Size = new System.Drawing.Size(147, 151);
            this.sPictureBx.TabIndex = 22;
            this.sPictureBx.TabStop = false;
            // 
            // lblVisitType
            // 
            this.lblVisitType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVisitType.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitType.Location = new System.Drawing.Point(524, 184);
            this.lblVisitType.Name = "lblVisitType";
            this.lblVisitType.Size = new System.Drawing.Size(226, 21);
            this.lblVisitType.TabIndex = 21;
            // 
            // lblLastVisit
            // 
            this.lblLastVisit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLastVisit.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastVisit.Location = new System.Drawing.Point(524, 154);
            this.lblLastVisit.Name = "lblLastVisit";
            this.lblLastVisit.Size = new System.Drawing.Size(226, 21);
            this.lblLastVisit.TabIndex = 20;
            // 
            // lblPlanType
            // 
            this.lblPlanType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlanType.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanType.Location = new System.Drawing.Point(524, 124);
            this.lblPlanType.Name = "lblPlanType";
            this.lblPlanType.Size = new System.Drawing.Size(226, 21);
            this.lblPlanType.TabIndex = 19;
            // 
            // lblServiceType
            // 
            this.lblServiceType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblServiceType.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceType.Location = new System.Drawing.Point(524, 94);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(226, 21);
            this.lblServiceType.TabIndex = 18;
            // 
            // lblHmoid
            // 
            this.lblHmoid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHmoid.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHmoid.Location = new System.Drawing.Point(524, 64);
            this.lblHmoid.Name = "lblHmoid";
            this.lblHmoid.Size = new System.Drawing.Size(226, 21);
            this.lblHmoid.TabIndex = 17;
            // 
            // lblHmoname
            // 
            this.lblHmoname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHmoname.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHmoname.Location = new System.Drawing.Point(524, 34);
            this.lblHmoname.Name = "lblHmoname";
            this.lblHmoname.Size = new System.Drawing.Size(226, 21);
            this.lblHmoname.TabIndex = 16;
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBloodGroup.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodGroup.Location = new System.Drawing.Point(223, 184);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(226, 21);
            this.lblBloodGroup.TabIndex = 15;
            // 
            // lblPatientType
            // 
            this.lblPatientType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPatientType.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientType.Location = new System.Drawing.Point(223, 154);
            this.lblPatientType.Name = "lblPatientType";
            this.lblPatientType.Size = new System.Drawing.Size(226, 21);
            this.lblPatientType.TabIndex = 14;
            // 
            // lblAge
            // 
            this.lblAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAge.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(223, 124);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(226, 21);
            this.lblAge.TabIndex = 13;
            // 
            // lblDOB
            // 
            this.lblDOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDOB.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(223, 94);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(226, 21);
            this.lblDOB.TabIndex = 12;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCardNumber.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(223, 64);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(226, 21);
            this.lblCardNumber.TabIndex = 11;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label87.Location = new System.Drawing.Point(153, 158);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(65, 13);
            this.label87.TabIndex = 10;
            this.label87.Text = "Patient Type";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label86.Location = new System.Drawing.Point(153, 188);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(65, 13);
            this.label86.TabIndex = 9;
            this.label86.Text = "Blood Group";
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(223, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(226, 21);
            this.lblName.TabIndex = 8;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label84.Location = new System.Drawing.Point(455, 128);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(52, 13);
            this.label84.TabIndex = 7;
            this.label84.Text = "Plan Type";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label83.Location = new System.Drawing.Point(153, 68);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(69, 13);
            this.label83.TabIndex = 6;
            this.label83.Text = "Card Number";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label82.Location = new System.Drawing.Point(153, 98);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(66, 13);
            this.label82.TabIndex = 5;
            this.label82.Text = "Date of Birth";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label81.Location = new System.Drawing.Point(155, 128);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(24, 13);
            this.label81.TabIndex = 4;
            this.label81.Text = "Age";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label80.Location = new System.Drawing.Point(455, 38);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(60, 13);
            this.label80.TabIndex = 3;
            this.label80.Text = "HMO Name";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.Location = new System.Drawing.Point(455, 68);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(42, 13);
            this.label79.TabIndex = 2;
            this.label79.Text = "HMO ID";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label78.Location = new System.Drawing.Point(455, 98);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(65, 13);
            this.label78.TabIndex = 1;
            this.label78.Text = "Service Type";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label77.Location = new System.Drawing.Point(153, 38);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(35, 13);
            this.label77.TabIndex = 0;
            this.label77.Text = "Name";
            // 
            // summarySearchPanel
            // 
            this.summarySearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.summarySearchPanel.Controls.Add(this.sSearchGroupBx);
            this.summarySearchPanel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summarySearchPanel.Location = new System.Drawing.Point(2, 26);
            this.summarySearchPanel.Name = "summarySearchPanel";
            this.summarySearchPanel.Size = new System.Drawing.Size(777, 124);
            this.summarySearchPanel.TabIndex = 11;
            // 
            // sSearchGroupBx
            // 
            this.sSearchGroupBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sSearchGroupBx.BackColor = System.Drawing.SystemColors.Control;
            this.sSearchGroupBx.Controls.Add(this.sSearchGrid);
            this.sSearchGroupBx.Controls.Add(this.txt_Filter);
            this.sSearchGroupBx.Controls.Add(this.label76);
            this.sSearchGroupBx.Controls.Add(this.btn_sSearch);
            this.sSearchGroupBx.Location = new System.Drawing.Point(3, 0);
            this.sSearchGroupBx.Name = "sSearchGroupBx";
            this.sSearchGroupBx.Size = new System.Drawing.Size(768, 122);
            this.sSearchGroupBx.TabIndex = 8;
            this.sSearchGroupBx.TabStop = false;
            this.sSearchGroupBx.Text = "Search Patient";
            // 
            // sSearchGrid
            // 
            this.sSearchGrid.AllowUserToAddRows = false;
            this.sSearchGrid.AllowUserToDeleteRows = false;
            this.sSearchGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.sSearchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sSearchGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sSearchGrid.Location = new System.Drawing.Point(3, 53);
            this.sSearchGrid.MultiSelect = false;
            this.sSearchGrid.Name = "sSearchGrid";
            this.sSearchGrid.ReadOnly = true;
            this.sSearchGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sSearchGrid.Size = new System.Drawing.Size(762, 66);
            this.sSearchGrid.TabIndex = 3;
            this.sSearchGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sSearchGrid_CellContentClick);
            // 
            // txt_Filter
            // 
            this.txt_Filter.Location = new System.Drawing.Point(156, 28);
            this.txt_Filter.Name = "txt_Filter";
            this.txt_Filter.Size = new System.Drawing.Size(487, 21);
            this.txt_Filter.TabIndex = 2;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(12, 31);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(137, 13);
            this.label76.TabIndex = 1;
            this.label76.Text = "Card Number/Patient Name";
            // 
            // btn_sSearch
            // 
            this.btn_sSearch.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sSearch.Location = new System.Drawing.Point(651, 28);
            this.btn_sSearch.Name = "btn_sSearch";
            this.btn_sSearch.Size = new System.Drawing.Size(100, 20);
            this.btn_sSearch.TabIndex = 0;
            this.btn_sSearch.Text = "Search";
            this.btn_sSearch.UseVisualStyleBackColor = true;
            this.btn_sSearch.Click += new System.EventHandler(this.btn_sSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(597, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Welcome:";
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.Location = new System.Drawing.Point(651, 7);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(79, 14);
            this.lblStaff.TabIndex = 13;
            this.lblStaff.Text = "Ayotola Jinadu";
            // 
            // staffID
            // 
            this.staffID.AutoSize = true;
            this.staffID.Location = new System.Drawing.Point(557, 6);
            this.staffID.Name = "staffID";
            this.staffID.Size = new System.Drawing.Size(0, 13);
            this.staffID.TabIndex = 14;
            this.staffID.Visible = false;
            // 
            // VitalSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 590);
            this.Controls.Add(this.summarySearchPanel);
            this.Controls.Add(this.staffID);
            this.Controls.Add(this.vitalSignPanel);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VitalSign";
            this.Text = "VITAL SIGNS";
            this.vitalSignPanel.ResumeLayout(false);
            this.historyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVitals)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sInfogramPanel.ResumeLayout(false);
            this.sInfogramPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPictureBx)).EndInit();
            this.summarySearchPanel.ResumeLayout(false);
            this.sSearchGroupBx.ResumeLayout(false);
            this.sSearchGroupBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sSearchGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel vitalSignPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label BMIlabel;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.LinkLabel link_btnBMI;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtResp;
        private System.Windows.Forms.TextBox txtPulse;
        private System.Windows.Forms.TextBox txtBP;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel sInfogramPanel;
        private System.Windows.Forms.Label lblPhysician;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.PictureBox sPictureBx;
        private System.Windows.Forms.Label lblVisitType;
        private System.Windows.Forms.Label lblLastVisit;
        private System.Windows.Forms.Label lblPlanType;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Label lblHmoid;
        private System.Windows.Forms.Label lblHmoname;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.Label lblPatientType;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Panel summarySearchPanel;
        private System.Windows.Forms.GroupBox sSearchGroupBx;
        private System.Windows.Forms.DataGridView sSearchGrid;
        private System.Windows.Forms.TextBox txt_Filter;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Button btn_sSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Panel historyPanel;
        private System.Windows.Forms.DataGridView gridVitals;
        private System.Windows.Forms.LinkLabel link_btnPatientFinder;
        private System.Windows.Forms.Label staffID;
    }
}

