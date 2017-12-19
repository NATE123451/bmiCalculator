namespace bmiCalculator
{
    partial class bmi_calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bmi_calculator));
            this.title_lbl = new System.Windows.Forms.Label();
            this.height_lbl = new System.Windows.Forms.Label();
            this.weight_lbl = new System.Windows.Forms.Label();
            this.rdo_group = new System.Windows.Forms.GroupBox();
            this.metric_rdo = new System.Windows.Forms.RadioButton();
            this.imperial_rdo = new System.Windows.Forms.RadioButton();
            this.heightMain_txt = new System.Windows.Forms.TextBox();
            this.heightInch_txt = new System.Windows.Forms.TextBox();
            this.weightMain_txt = new System.Windows.Forms.TextBox();
            this.heightEntry1_lbl = new System.Windows.Forms.Label();
            this.heightEntry2_lbl = new System.Windows.Forms.Label();
            this.weightEntry_lbl = new System.Windows.Forms.Label();
            this.calculate_btn = new System.Windows.Forms.Button();
            this.bmi_lbl = new System.Windows.Forms.Label();
            this.bmiOutput_txt = new System.Windows.Forms.TextBox();
            this.heightEntryCM_lbl = new System.Windows.Forms.Label();
            this.weightEntryKG_lbl = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            this.rdo_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.title_lbl.Location = new System.Drawing.Point(74, 9);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(236, 44);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "BMI Calculator";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.title_lbl.UseCompatibleTextRendering = true;
            // 
            // height_lbl
            // 
            this.height_lbl.AutoSize = true;
            this.height_lbl.Location = new System.Drawing.Point(40, 96);
            this.height_lbl.Name = "height_lbl";
            this.height_lbl.Size = new System.Drawing.Size(66, 13);
            this.height_lbl.TabIndex = 1;
            this.height_lbl.Text = "Your Height:";
            // 
            // weight_lbl
            // 
            this.weight_lbl.AutoSize = true;
            this.weight_lbl.Location = new System.Drawing.Point(40, 140);
            this.weight_lbl.Name = "weight_lbl";
            this.weight_lbl.Size = new System.Drawing.Size(69, 13);
            this.weight_lbl.TabIndex = 2;
            this.weight_lbl.Text = "Your Weight:";
            // 
            // rdo_group
            // 
            this.rdo_group.Controls.Add(this.metric_rdo);
            this.rdo_group.Controls.Add(this.imperial_rdo);
            this.rdo_group.Location = new System.Drawing.Point(43, 249);
            this.rdo_group.Name = "rdo_group";
            this.rdo_group.Size = new System.Drawing.Size(110, 105);
            this.rdo_group.TabIndex = 3;
            this.rdo_group.TabStop = false;
            this.rdo_group.Text = "Units Selection";
            // 
            // metric_rdo
            // 
            this.metric_rdo.AutoSize = true;
            this.metric_rdo.Location = new System.Drawing.Point(7, 72);
            this.metric_rdo.Name = "metric_rdo";
            this.metric_rdo.Size = new System.Drawing.Size(54, 17);
            this.metric_rdo.TabIndex = 1;
            this.metric_rdo.Text = "Metric";
            this.metric_rdo.UseVisualStyleBackColor = true;
            this.metric_rdo.CheckedChanged += new System.EventHandler(this.metric_rdo_CheckedChanged);
            // 
            // imperial_rdo
            // 
            this.imperial_rdo.AutoSize = true;
            this.imperial_rdo.Location = new System.Drawing.Point(7, 32);
            this.imperial_rdo.Name = "imperial_rdo";
            this.imperial_rdo.Size = new System.Drawing.Size(61, 17);
            this.imperial_rdo.TabIndex = 0;
            this.imperial_rdo.Text = "Imperial";
            this.imperial_rdo.UseVisualStyleBackColor = true;
            this.imperial_rdo.CheckedChanged += new System.EventHandler(this.imperial_rdo_CheckedChanged);
            // 
            // heightMain_txt
            // 
            this.heightMain_txt.Location = new System.Drawing.Point(126, 93);
            this.heightMain_txt.Name = "heightMain_txt";
            this.heightMain_txt.Size = new System.Drawing.Size(100, 20);
            this.heightMain_txt.TabIndex = 4;
            // 
            // heightInch_txt
            // 
            this.heightInch_txt.Location = new System.Drawing.Point(254, 93);
            this.heightInch_txt.Name = "heightInch_txt";
            this.heightInch_txt.Size = new System.Drawing.Size(100, 20);
            this.heightInch_txt.TabIndex = 5;
            // 
            // weightMain_txt
            // 
            this.weightMain_txt.Location = new System.Drawing.Point(126, 137);
            this.weightMain_txt.Name = "weightMain_txt";
            this.weightMain_txt.Size = new System.Drawing.Size(100, 20);
            this.weightMain_txt.TabIndex = 6;
            // 
            // heightEntry1_lbl
            // 
            this.heightEntry1_lbl.AutoSize = true;
            this.heightEntry1_lbl.Location = new System.Drawing.Point(156, 116);
            this.heightEntry1_lbl.Name = "heightEntry1_lbl";
            this.heightEntry1_lbl.Size = new System.Drawing.Size(0, 13);
            this.heightEntry1_lbl.TabIndex = 7;
            // 
            // heightEntry2_lbl
            // 
            this.heightEntry2_lbl.AutoSize = true;
            this.heightEntry2_lbl.Location = new System.Drawing.Point(278, 116);
            this.heightEntry2_lbl.Name = "heightEntry2_lbl";
            this.heightEntry2_lbl.Size = new System.Drawing.Size(0, 13);
            this.heightEntry2_lbl.TabIndex = 8;
            // 
            // weightEntry_lbl
            // 
            this.weightEntry_lbl.AutoSize = true;
            this.weightEntry_lbl.Location = new System.Drawing.Point(140, 160);
            this.weightEntry_lbl.Name = "weightEntry_lbl";
            this.weightEntry_lbl.Size = new System.Drawing.Size(0, 13);
            this.weightEntry_lbl.TabIndex = 9;
            // 
            // calculate_btn
            // 
            this.calculate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_btn.Location = new System.Drawing.Point(201, 249);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(153, 49);
            this.calculate_btn.TabIndex = 10;
            this.calculate_btn.Text = "Calculate BMI";
            this.calculate_btn.UseVisualStyleBackColor = true;
            this.calculate_btn.Click += new System.EventHandler(this.calculate_btn_Click);
            // 
            // bmi_lbl
            // 
            this.bmi_lbl.AutoSize = true;
            this.bmi_lbl.Location = new System.Drawing.Point(40, 196);
            this.bmi_lbl.Name = "bmi_lbl";
            this.bmi_lbl.Size = new System.Drawing.Size(54, 13);
            this.bmi_lbl.TabIndex = 11;
            this.bmi_lbl.Text = "Your BMI:";
            // 
            // bmiOutput_txt
            // 
            this.bmiOutput_txt.Location = new System.Drawing.Point(126, 193);
            this.bmiOutput_txt.Name = "bmiOutput_txt";
            this.bmiOutput_txt.ReadOnly = true;
            this.bmiOutput_txt.Size = new System.Drawing.Size(228, 20);
            this.bmiOutput_txt.TabIndex = 12;
            // 
            // heightEntryCM_lbl
            // 
            this.heightEntryCM_lbl.AutoSize = true;
            this.heightEntryCM_lbl.Location = new System.Drawing.Point(140, 116);
            this.heightEntryCM_lbl.Name = "heightEntryCM_lbl";
            this.heightEntryCM_lbl.Size = new System.Drawing.Size(0, 13);
            this.heightEntryCM_lbl.TabIndex = 13;
            this.heightEntryCM_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // weightEntryKG_lbl
            // 
            this.weightEntryKG_lbl.AutoSize = true;
            this.weightEntryKG_lbl.Location = new System.Drawing.Point(138, 160);
            this.weightEntryKG_lbl.Name = "weightEntryKG_lbl";
            this.weightEntryKG_lbl.Size = new System.Drawing.Size(0, 13);
            this.weightEntryKG_lbl.TabIndex = 14;
            // 
            // clear_btn
            // 
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.Location = new System.Drawing.Point(201, 305);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(153, 49);
            this.clear_btn.TabIndex = 15;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // bmi_calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 389);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.weightEntryKG_lbl);
            this.Controls.Add(this.heightEntryCM_lbl);
            this.Controls.Add(this.bmiOutput_txt);
            this.Controls.Add(this.bmi_lbl);
            this.Controls.Add(this.calculate_btn);
            this.Controls.Add(this.weightEntry_lbl);
            this.Controls.Add(this.heightEntry2_lbl);
            this.Controls.Add(this.heightEntry1_lbl);
            this.Controls.Add(this.weightMain_txt);
            this.Controls.Add(this.heightInch_txt);
            this.Controls.Add(this.heightMain_txt);
            this.Controls.Add(this.rdo_group);
            this.Controls.Add(this.weight_lbl);
            this.Controls.Add(this.height_lbl);
            this.Controls.Add(this.title_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bmi_calculator";
            this.Text = "BMI Calculator";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.rdo_group.ResumeLayout(false);
            this.rdo_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label height_lbl;
        private System.Windows.Forms.Label weight_lbl;
        private System.Windows.Forms.GroupBox rdo_group;
        private System.Windows.Forms.RadioButton metric_rdo;
        private System.Windows.Forms.RadioButton imperial_rdo;
        private System.Windows.Forms.TextBox heightMain_txt;
        private System.Windows.Forms.TextBox heightInch_txt;
        private System.Windows.Forms.TextBox weightMain_txt;
        private System.Windows.Forms.Label heightEntry1_lbl;
        private System.Windows.Forms.Label heightEntry2_lbl;
        private System.Windows.Forms.Label weightEntry_lbl;
        private System.Windows.Forms.Button calculate_btn;
        private System.Windows.Forms.Label bmi_lbl;
        private System.Windows.Forms.TextBox bmiOutput_txt;
        private System.Windows.Forms.Label heightEntryCM_lbl;
        private System.Windows.Forms.Label weightEntryKG_lbl;
        private System.Windows.Forms.Button clear_btn;
    }
}

