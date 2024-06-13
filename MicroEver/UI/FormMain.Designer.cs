namespace UI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            label4 = new System.Windows.Forms.Label();
            txtOutput = new System.Windows.Forms.TextBox();
            txtInputString = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            pnlControleAqueceimento = new System.Windows.Forms.Panel();
            btnCancel = new System.Windows.Forms.Button();
            btnStart = new System.Windows.Forms.Button();
            btnTranslate = new System.Windows.Forms.Button();
            dtpTimer = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            txtPotency = new System.Windows.Forms.NumericUpDown();
            panel1 = new System.Windows.Forms.Panel();
            lbxTemplate = new System.Windows.Forms.ListBox();
            btnStartTemplate = new System.Windows.Forms.Button();
            pnlTemplateCommands = new System.Windows.Forms.Panel();
            gbxMealKind = new System.Windows.Forms.GroupBox();
            rdbAny = new System.Windows.Forms.RadioButton();
            rdbCheese = new System.Windows.Forms.RadioButton();
            rdbChicken = new System.Windows.Forms.RadioButton();
            rdbtnMeat = new System.Windows.Forms.RadioButton();
            txtSearchTemplate = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            btnAddTemplate = new System.Windows.Forms.Button();
            deleteTemplate = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            pnlControleAqueceimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPotency).BeginInit();
            panel1.SuspendLayout();
            pnlTemplateCommands.SuspendLayout();
            gbxMealKind.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(5, 5);
            splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(txtOutput);
            splitContainer1.Panel1.Controls.Add(txtInputString);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(pnlControleAqueceimento);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(btnStartTemplate);
            splitContainer1.Panel2.Controls.Add(pnlTemplateCommands);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Size = new System.Drawing.Size(1081, 555);
            splitContainer1.SplitterDistance = 809;
            splitContainer1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            label4.Location = new System.Drawing.Point(0, 426);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(96, 15);
            label4.TabIndex = 1;
            label4.Text = "OUTPUT STRING:";
            // 
            // txtOutput
            // 
            txtOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            txtOutput.Location = new System.Drawing.Point(0, 441);
            txtOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new System.Drawing.Size(617, 114);
            txtOutput.TabIndex = 2;
            // 
            // txtInputString
            // 
            txtInputString.Dock = System.Windows.Forms.DockStyle.Fill;
            txtInputString.Location = new System.Drawing.Point(0, 15);
            txtInputString.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtInputString.Multiline = true;
            txtInputString.Name = "txtInputString";
            txtInputString.Size = new System.Drawing.Size(617, 540);
            txtInputString.TabIndex = 2;
            txtInputString.Text = resources.GetString("txtInputString.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Top;
            label2.Location = new System.Drawing.Point(0, 0);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "INPUT STRING:";
            // 
            // pnlControleAqueceimento
            // 
            pnlControleAqueceimento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pnlControleAqueceimento.Controls.Add(btnCancel);
            pnlControleAqueceimento.Controls.Add(btnStart);
            pnlControleAqueceimento.Controls.Add(btnTranslate);
            pnlControleAqueceimento.Controls.Add(dtpTimer);
            pnlControleAqueceimento.Controls.Add(label1);
            pnlControleAqueceimento.Controls.Add(txtPotency);
            pnlControleAqueceimento.Dock = System.Windows.Forms.DockStyle.Right;
            pnlControleAqueceimento.Location = new System.Drawing.Point(617, 0);
            pnlControleAqueceimento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlControleAqueceimento.Name = "pnlControleAqueceimento";
            pnlControleAqueceimento.Size = new System.Drawing.Size(192, 555);
            pnlControleAqueceimento.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnCancel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.Location = new System.Drawing.Point(15, 490);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(167, 50);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnStart
            // 
            btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnStart.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnStart.Location = new System.Drawing.Point(15, 439);
            btnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(167, 44);
            btnStart.TabIndex = 4;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnTranslate
            // 
            btnTranslate.Location = new System.Drawing.Point(22, 175);
            btnTranslate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnTranslate.Name = "btnTranslate";
            btnTranslate.Size = new System.Drawing.Size(150, 42);
            btnTranslate.TabIndex = 3;
            btnTranslate.Text = "<= Translate to imput string";
            btnTranslate.UseVisualStyleBackColor = true;
            btnTranslate.Click += btnTranslate_Click;
            // 
            // dtpTimer
            // 
            dtpTimer.CustomFormat = "mm:ss";
            dtpTimer.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dtpTimer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpTimer.Location = new System.Drawing.Point(63, 31);
            dtpTimer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtpTimer.MaxDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpTimer.Name = "dtpTimer";
            dtpTimer.ShowUpDown = true;
            dtpTimer.Size = new System.Drawing.Size(110, 40);
            dtpTimer.TabIndex = 1;
            dtpTimer.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpTimer.ValueChanged += dtpTimer_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(24, 118);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 18);
            label1.TabIndex = 3;
            label1.Text = "Potency:";
            // 
            // txtPotency
            // 
            txtPotency.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtPotency.Location = new System.Drawing.Point(103, 107);
            txtPotency.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPotency.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            txtPotency.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtPotency.Name = "txtPotency";
            txtPotency.Size = new System.Drawing.Size(70, 40);
            txtPotency.TabIndex = 2;
            txtPotency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txtPotency.Value = new decimal(new int[] { 1, 0, 0, 0 });
            txtPotency.ValueChanged += txtPotency_ValueChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Controls.Add(lbxTemplate);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 15);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(268, 227);
            panel1.TabIndex = 7;
            // 
            // lbxTemplate
            // 
            lbxTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            lbxTemplate.FormattingEnabled = true;
            lbxTemplate.ItemHeight = 15;
            lbxTemplate.Location = new System.Drawing.Point(0, 0);
            lbxTemplate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lbxTemplate.Name = "lbxTemplate";
            lbxTemplate.Size = new System.Drawing.Size(264, 223);
            lbxTemplate.TabIndex = 1;
            lbxTemplate.DoubleClick += lbxTemplate_DoubleClick;
            // 
            // btnStartTemplate
            // 
            btnStartTemplate.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnStartTemplate.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnStartTemplate.Location = new System.Drawing.Point(0, 242);
            btnStartTemplate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnStartTemplate.Name = "btnStartTemplate";
            btnStartTemplate.Size = new System.Drawing.Size(268, 44);
            btnStartTemplate.TabIndex = 6;
            btnStartTemplate.Text = "START TEMPLATE";
            btnStartTemplate.UseVisualStyleBackColor = true;
            btnStartTemplate.Click += btnStartTemplate_Click;
            // 
            // pnlTemplateCommands
            // 
            pnlTemplateCommands.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pnlTemplateCommands.Controls.Add(gbxMealKind);
            pnlTemplateCommands.Controls.Add(txtSearchTemplate);
            pnlTemplateCommands.Controls.Add(btnSearch);
            pnlTemplateCommands.Controls.Add(btnAddTemplate);
            pnlTemplateCommands.Controls.Add(deleteTemplate);
            pnlTemplateCommands.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlTemplateCommands.Location = new System.Drawing.Point(0, 286);
            pnlTemplateCommands.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlTemplateCommands.Name = "pnlTemplateCommands";
            pnlTemplateCommands.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            pnlTemplateCommands.Size = new System.Drawing.Size(268, 269);
            pnlTemplateCommands.TabIndex = 2;
            // 
            // gbxMealKind
            // 
            gbxMealKind.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gbxMealKind.Controls.Add(rdbAny);
            gbxMealKind.Controls.Add(rdbCheese);
            gbxMealKind.Controls.Add(rdbChicken);
            gbxMealKind.Controls.Add(rdbtnMeat);
            gbxMealKind.Location = new System.Drawing.Point(5, 10);
            gbxMealKind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbxMealKind.Name = "gbxMealKind";
            gbxMealKind.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbxMealKind.Size = new System.Drawing.Size(256, 105);
            gbxMealKind.TabIndex = 9;
            gbxMealKind.TabStop = false;
            gbxMealKind.Text = "Meal Kind";
            // 
            // rdbAny
            // 
            rdbAny.AutoSize = true;
            rdbAny.Checked = true;
            rdbAny.Location = new System.Drawing.Point(7, 80);
            rdbAny.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rdbAny.Name = "rdbAny";
            rdbAny.Size = new System.Drawing.Size(46, 19);
            rdbAny.TabIndex = 2;
            rdbAny.TabStop = true;
            rdbAny.Text = "Any";
            rdbAny.UseVisualStyleBackColor = true;
            // 
            // rdbCheese
            // 
            rdbCheese.AutoSize = true;
            rdbCheese.Location = new System.Drawing.Point(7, 59);
            rdbCheese.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rdbCheese.Name = "rdbCheese";
            rdbCheese.Size = new System.Drawing.Size(63, 19);
            rdbCheese.TabIndex = 2;
            rdbCheese.Text = "Cheese";
            rdbCheese.UseVisualStyleBackColor = true;
            // 
            // rdbChicken
            // 
            rdbChicken.AutoSize = true;
            rdbChicken.Location = new System.Drawing.Point(7, 38);
            rdbChicken.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rdbChicken.Name = "rdbChicken";
            rdbChicken.Size = new System.Drawing.Size(68, 19);
            rdbChicken.TabIndex = 1;
            rdbChicken.Text = "Chicken";
            rdbChicken.UseVisualStyleBackColor = true;
            // 
            // rdbtnMeat
            // 
            rdbtnMeat.AutoSize = true;
            rdbtnMeat.Location = new System.Drawing.Point(7, 17);
            rdbtnMeat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rdbtnMeat.Name = "rdbtnMeat";
            rdbtnMeat.Size = new System.Drawing.Size(52, 19);
            rdbtnMeat.TabIndex = 0;
            rdbtnMeat.Text = "Meat";
            rdbtnMeat.UseVisualStyleBackColor = true;
            // 
            // txtSearchTemplate
            // 
            txtSearchTemplate.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtSearchTemplate.Location = new System.Drawing.Point(4, 122);
            txtSearchTemplate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtSearchTemplate.Name = "txtSearchTemplate";
            txtSearchTemplate.Size = new System.Drawing.Size(208, 23);
            txtSearchTemplate.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSearch.Location = new System.Drawing.Point(219, 118);
            btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(42, 28);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "...";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAddTemplate
            // 
            btnAddTemplate.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnAddTemplate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAddTemplate.Location = new System.Drawing.Point(54, 153);
            btnAddTemplate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddTemplate.Name = "btnAddTemplate";
            btnAddTemplate.Size = new System.Drawing.Size(206, 44);
            btnAddTemplate.TabIndex = 6;
            btnAddTemplate.Text = "Add template";
            btnAddTemplate.UseVisualStyleBackColor = true;
            btnAddTemplate.Click += btnAddTemplate_Click;
            // 
            // deleteTemplate
            // 
            deleteTemplate.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            deleteTemplate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            deleteTemplate.Location = new System.Drawing.Point(54, 203);
            deleteTemplate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            deleteTemplate.Name = "deleteTemplate";
            deleteTemplate.Size = new System.Drawing.Size(206, 50);
            deleteTemplate.TabIndex = 6;
            deleteTemplate.Text = "Delete template";
            deleteTemplate.UseVisualStyleBackColor = true;
            deleteTemplate.Click += deleteTemplate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Top;
            label3.Location = new System.Drawing.Point(0, 0);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(63, 15);
            label3.TabIndex = 0;
            label3.Text = "Templates:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1091, 565);
            Controls.Add(splitContainer1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormMain";
            Padding = new System.Windows.Forms.Padding(5);
            Text = "Benner: Digital Microwave 2020++";
            FormClosing += FormMain_FormClosing;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            pnlControleAqueceimento.ResumeLayout(false);
            pnlControleAqueceimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPotency).EndInit();
            panel1.ResumeLayout(false);
            pnlTemplateCommands.ResumeLayout(false);
            pnlTemplateCommands.PerformLayout();
            gbxMealKind.ResumeLayout(false);
            gbxMealKind.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlControleAqueceimento;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown txtPotency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTimer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtInputString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlTemplateCommands;
        private System.Windows.Forms.Button deleteTemplate;
        private System.Windows.Forms.Button btnAddTemplate;
        private System.Windows.Forms.TextBox txtSearchTemplate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbxMealKind;
        private System.Windows.Forms.RadioButton rdbtnMeat;
        private System.Windows.Forms.RadioButton rdbCheese;
        private System.Windows.Forms.RadioButton rdbChicken;
        private System.Windows.Forms.RadioButton rdbAny;
        private System.Windows.Forms.Button btnStartTemplate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbxTemplate;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label4;
    }
}

