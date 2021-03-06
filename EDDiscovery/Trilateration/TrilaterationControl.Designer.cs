﻿namespace EDDiscovery
{
    partial class TrilaterationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDistances = new System.Windows.Forms.DataGridView();
            this.ColumnSystem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCalculated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSystemName = new System.Windows.Forms.TextBox();
            this.labelTargetSystem = new System.Windows.Forms.Label();
            this.buttonSubmitToEDSC = new System.Windows.Forms.Button();
            this.labelCoordinates = new System.Windows.Forms.Label();
            this.textBoxCoordinateX = new System.Windows.Forms.TextBox();
            this.labelCoordinateX = new System.Windows.Forms.Label();
            this.labelCoordinateY = new System.Windows.Forms.Label();
            this.textBoxCoordinateY = new System.Windows.Forms.TextBox();
            this.labelCoordinateZ = new System.Windows.Forms.Label();
            this.textBoxCoordinateZ = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.dataGridViewClosestSystems = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnClosestSystemsSystem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnClosestSystemsDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSuggestedSystems = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnSuggestedSystemsSystem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelImplementation = new System.Windows.Forms.Panel();
            this.labelAlgorithm = new System.Windows.Forms.Label();
            this.radioButtonAlgorithmJs = new System.Windows.Forms.RadioButton();
            this.radioButtonAlgorithmCsharp = new System.Windows.Forms.RadioButton();
            this.toolTipAlgorithm = new System.Windows.Forms.ToolTip(this.components);
            this.labelSuggestedSystems = new System.Windows.Forms.Label();
            this.labelClosestSystems = new System.Windows.Forms.Label();
            this.labelLastKnownSystem = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LabelTrilateration = new System.Windows.Forms.Label();
            this.buttonCloseTrilateration = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDistances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClosestSystems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuggestedSystems)).BeginInit();
            this.panelImplementation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDistances
            // 
            this.dataGridViewDistances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDistances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSystem,
            this.ColumnDistance,
            this.ColumnCalculated,
            this.ColumnStatus});
            this.dataGridViewDistances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDistances.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDistances.Name = "dataGridViewDistances";
            this.dataGridViewDistances.Size = new System.Drawing.Size(574, 188);
            this.dataGridViewDistances.TabIndex = 0;
            this.dataGridViewDistances.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDistances_CellEndEdit);
            this.dataGridViewDistances.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewDistances_CellValidating);
            this.dataGridViewDistances.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewDistances_EditingControlShowing);
            // 
            // ColumnSystem
            // 
            this.ColumnSystem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSystem.HeaderText = "System";
            this.ColumnSystem.MinimumWidth = 100;
            this.ColumnSystem.Name = "ColumnSystem";
            // 
            // ColumnDistance
            // 
            this.ColumnDistance.HeaderText = "Distance";
            this.ColumnDistance.MinimumWidth = 30;
            this.ColumnDistance.Name = "ColumnDistance";
            this.ColumnDistance.Width = 75;
            // 
            // ColumnCalculated
            // 
            this.ColumnCalculated.HeaderText = "Calculated";
            this.ColumnCalculated.Name = "ColumnCalculated";
            this.ColumnCalculated.ReadOnly = true;
            this.ColumnCalculated.Width = 75;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            this.ColumnStatus.Width = 121;
            // 
            // textBoxSystemName
            // 
            this.textBoxSystemName.Location = new System.Drawing.Point(1, 60);
            this.textBoxSystemName.Name = "textBoxSystemName";
            this.textBoxSystemName.ReadOnly = true;
            this.textBoxSystemName.Size = new System.Drawing.Size(178, 20);
            this.textBoxSystemName.TabIndex = 1;
            // 
            // labelTargetSystem
            // 
            this.labelTargetSystem.AutoSize = true;
            this.labelTargetSystem.Location = new System.Drawing.Point(1, 44);
            this.labelTargetSystem.Name = "labelTargetSystem";
            this.labelTargetSystem.Size = new System.Drawing.Size(44, 13);
            this.labelTargetSystem.TabIndex = 2;
            this.labelTargetSystem.Text = "System:";
            // 
            // buttonSubmitToEDSC
            // 
            this.buttonSubmitToEDSC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSubmitToEDSC.Enabled = false;
            this.buttonSubmitToEDSC.Location = new System.Drawing.Point(456, 58);
            this.buttonSubmitToEDSC.Name = "buttonSubmitToEDSC";
            this.buttonSubmitToEDSC.Size = new System.Drawing.Size(109, 23);
            this.buttonSubmitToEDSC.TabIndex = 4;
            this.buttonSubmitToEDSC.Text = "Submit Distances";
            this.buttonSubmitToEDSC.UseVisualStyleBackColor = true;
            this.buttonSubmitToEDSC.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelCoordinates
            // 
            this.labelCoordinates.AutoSize = true;
            this.labelCoordinates.Location = new System.Drawing.Point(199, 44);
            this.labelCoordinates.Name = "labelCoordinates";
            this.labelCoordinates.Size = new System.Drawing.Size(122, 13);
            this.labelCoordinates.TabIndex = 5;
            this.labelCoordinates.Text = "Trilaterated Coordinates:";
            // 
            // textBoxCoordinateX
            // 
            this.textBoxCoordinateX.Location = new System.Drawing.Point(202, 60);
            this.textBoxCoordinateX.Name = "textBoxCoordinateX";
            this.textBoxCoordinateX.ReadOnly = true;
            this.textBoxCoordinateX.Size = new System.Drawing.Size(50, 20);
            this.textBoxCoordinateX.TabIndex = 6;
            this.textBoxCoordinateX.Text = "?";
            this.textBoxCoordinateX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCoordinateX
            // 
            this.labelCoordinateX.AutoSize = true;
            this.labelCoordinateX.Location = new System.Drawing.Point(185, 63);
            this.labelCoordinateX.Name = "labelCoordinateX";
            this.labelCoordinateX.Size = new System.Drawing.Size(17, 13);
            this.labelCoordinateX.TabIndex = 7;
            this.labelCoordinateX.Text = "X:";
            // 
            // labelCoordinateY
            // 
            this.labelCoordinateY.AutoSize = true;
            this.labelCoordinateY.Location = new System.Drawing.Point(252, 63);
            this.labelCoordinateY.Name = "labelCoordinateY";
            this.labelCoordinateY.Size = new System.Drawing.Size(17, 13);
            this.labelCoordinateY.TabIndex = 9;
            this.labelCoordinateY.Text = "Y:";
            // 
            // textBoxCoordinateY
            // 
            this.textBoxCoordinateY.Location = new System.Drawing.Point(269, 60);
            this.textBoxCoordinateY.Name = "textBoxCoordinateY";
            this.textBoxCoordinateY.ReadOnly = true;
            this.textBoxCoordinateY.Size = new System.Drawing.Size(50, 20);
            this.textBoxCoordinateY.TabIndex = 8;
            this.textBoxCoordinateY.Text = "?";
            this.textBoxCoordinateY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCoordinateZ
            // 
            this.labelCoordinateZ.AutoSize = true;
            this.labelCoordinateZ.Location = new System.Drawing.Point(319, 63);
            this.labelCoordinateZ.Name = "labelCoordinateZ";
            this.labelCoordinateZ.Size = new System.Drawing.Size(17, 13);
            this.labelCoordinateZ.TabIndex = 11;
            this.labelCoordinateZ.Text = "Z:";
            // 
            // textBoxCoordinateZ
            // 
            this.textBoxCoordinateZ.Location = new System.Drawing.Point(336, 60);
            this.textBoxCoordinateZ.Name = "textBoxCoordinateZ";
            this.textBoxCoordinateZ.ReadOnly = true;
            this.textBoxCoordinateZ.Size = new System.Drawing.Size(50, 20);
            this.textBoxCoordinateZ.TabIndex = 10;
            this.textBoxCoordinateZ.Text = "?";
            this.textBoxCoordinateZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatus.Location = new System.Drawing.Point(51, 25);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(335, 19);
            this.labelStatus.TabIndex = 12;
            this.labelStatus.Text = "Status";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewClosestSystems
            // 
            this.dataGridViewClosestSystems.AllowUserToAddRows = false;
            this.dataGridViewClosestSystems.AllowUserToDeleteRows = false;
            this.dataGridViewClosestSystems.AllowUserToResizeRows = false;
            this.dataGridViewClosestSystems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClosestSystems.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClosestSystems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewClosestSystems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClosestSystems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnClosestSystemsSystem,
            this.dataGridViewTextBoxColumnClosestSystemsDistance});
            this.dataGridViewClosestSystems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewClosestSystems.Location = new System.Drawing.Point(0, 28);
            this.dataGridViewClosestSystems.Name = "dataGridViewClosestSystems";
            this.dataGridViewClosestSystems.ReadOnly = true;
            this.dataGridViewClosestSystems.RowHeadersVisible = false;
            this.dataGridViewClosestSystems.Size = new System.Drawing.Size(320, 157);
            this.dataGridViewClosestSystems.TabIndex = 13;
            this.dataGridViewClosestSystems.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewClosestSystems_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumnClosestSystemsSystem
            // 
            this.dataGridViewTextBoxColumnClosestSystemsSystem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumnClosestSystemsSystem.HeaderText = "System";
            this.dataGridViewTextBoxColumnClosestSystemsSystem.MinimumWidth = 100;
            this.dataGridViewTextBoxColumnClosestSystemsSystem.Name = "dataGridViewTextBoxColumnClosestSystemsSystem";
            this.dataGridViewTextBoxColumnClosestSystemsSystem.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnClosestSystemsDistance
            // 
            this.dataGridViewTextBoxColumnClosestSystemsDistance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumnClosestSystemsDistance.HeaderText = "Distance";
            this.dataGridViewTextBoxColumnClosestSystemsDistance.MinimumWidth = 80;
            this.dataGridViewTextBoxColumnClosestSystemsDistance.Name = "dataGridViewTextBoxColumnClosestSystemsDistance";
            this.dataGridViewTextBoxColumnClosestSystemsDistance.ReadOnly = true;
            this.dataGridViewTextBoxColumnClosestSystemsDistance.Width = 80;
            // 
            // dataGridViewSuggestedSystems
            // 
            this.dataGridViewSuggestedSystems.AllowUserToAddRows = false;
            this.dataGridViewSuggestedSystems.AllowUserToDeleteRows = false;
            this.dataGridViewSuggestedSystems.AllowUserToResizeRows = false;
            this.dataGridViewSuggestedSystems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSuggestedSystems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSuggestedSystems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuggestedSystems.ColumnHeadersVisible = false;
            this.dataGridViewSuggestedSystems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnSuggestedSystemsSystem});
            this.dataGridViewSuggestedSystems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewSuggestedSystems.Location = new System.Drawing.Point(324, 28);
            this.dataGridViewSuggestedSystems.Name = "dataGridViewSuggestedSystems";
            this.dataGridViewSuggestedSystems.ReadOnly = true;
            this.dataGridViewSuggestedSystems.RowHeadersVisible = false;
            this.dataGridViewSuggestedSystems.Size = new System.Drawing.Size(246, 157);
            this.dataGridViewSuggestedSystems.TabIndex = 14;
            this.dataGridViewSuggestedSystems.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSuggestedSystems_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumnSuggestedSystemsSystem
            // 
            this.dataGridViewTextBoxColumnSuggestedSystemsSystem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumnSuggestedSystemsSystem.HeaderText = "System";
            this.dataGridViewTextBoxColumnSuggestedSystemsSystem.MinimumWidth = 100;
            this.dataGridViewTextBoxColumnSuggestedSystemsSystem.Name = "dataGridViewTextBoxColumnSuggestedSystemsSystem";
            this.dataGridViewTextBoxColumnSuggestedSystemsSystem.ReadOnly = true;
            // 
            // panelImplementation
            // 
            this.panelImplementation.Controls.Add(this.labelAlgorithm);
            this.panelImplementation.Controls.Add(this.radioButtonAlgorithmJs);
            this.panelImplementation.Controls.Add(this.radioButtonAlgorithmCsharp);
            this.panelImplementation.Location = new System.Drawing.Point(401, 25);
            this.panelImplementation.Name = "panelImplementation";
            this.panelImplementation.Size = new System.Drawing.Size(49, 60);
            this.panelImplementation.TabIndex = 16;
            // 
            // labelAlgorithm
            // 
            this.labelAlgorithm.AutoSize = true;
            this.labelAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAlgorithm.Location = new System.Drawing.Point(0, 12);
            this.labelAlgorithm.Name = "labelAlgorithm";
            this.labelAlgorithm.Size = new System.Drawing.Size(48, 12);
            this.labelAlgorithm.TabIndex = 2;
            this.labelAlgorithm.Text = "Algorithm:";
            // 
            // radioButtonAlgorithmJs
            // 
            this.radioButtonAlgorithmJs.AutoSize = true;
            this.radioButtonAlgorithmJs.Location = new System.Drawing.Point(3, 27);
            this.radioButtonAlgorithmJs.Name = "radioButtonAlgorithmJs";
            this.radioButtonAlgorithmJs.Size = new System.Drawing.Size(37, 17);
            this.radioButtonAlgorithmJs.TabIndex = 1;
            this.radioButtonAlgorithmJs.Text = "JS";
            this.toolTipAlgorithm.SetToolTip(this.radioButtonAlgorithmJs, "Original algoritthm from ed-systems, written in Javascript (slower)");
            this.radioButtonAlgorithmJs.UseVisualStyleBackColor = true;
            this.radioButtonAlgorithmJs.CheckedChanged += new System.EventHandler(this.radioButtonAlgorithm_CheckedChanged);
            // 
            // radioButtonAlgorithmCsharp
            // 
            this.radioButtonAlgorithmCsharp.AutoSize = true;
            this.radioButtonAlgorithmCsharp.Checked = true;
            this.radioButtonAlgorithmCsharp.Location = new System.Drawing.Point(3, 44);
            this.radioButtonAlgorithmCsharp.Name = "radioButtonAlgorithmCsharp";
            this.radioButtonAlgorithmCsharp.Size = new System.Drawing.Size(39, 17);
            this.radioButtonAlgorithmCsharp.TabIndex = 0;
            this.radioButtonAlgorithmCsharp.TabStop = true;
            this.radioButtonAlgorithmCsharp.Text = "C#";
            this.toolTipAlgorithm.SetToolTip(this.radioButtonAlgorithmCsharp, "Algorithm from ed-systems rewritten to C# (fast, experimental)");
            this.radioButtonAlgorithmCsharp.UseVisualStyleBackColor = true;
            // 
            // labelSuggestedSystems
            // 
            this.labelSuggestedSystems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSuggestedSystems.AutoSize = true;
            this.labelSuggestedSystems.Location = new System.Drawing.Point(321, 9);
            this.labelSuggestedSystems.Name = "labelSuggestedSystems";
            this.labelSuggestedSystems.Size = new System.Drawing.Size(146, 13);
            this.labelSuggestedSystems.TabIndex = 17;
            this.labelSuggestedSystems.Text = "Suggested reference systems";
            // 
            // labelClosestSystems
            // 
            this.labelClosestSystems.AutoSize = true;
            this.labelClosestSystems.Location = new System.Drawing.Point(0, 9);
            this.labelClosestSystems.Name = "labelClosestSystems";
            this.labelClosestSystems.Size = new System.Drawing.Size(187, 13);
            this.labelClosestSystems.TabIndex = 18;
            this.labelClosestSystems.Text = "Closest systems to last known location";
            // 
            // labelLastKnownSystem
            // 
            this.labelLastKnownSystem.AutoSize = true;
            this.labelLastKnownSystem.Location = new System.Drawing.Point(187, 9);
            this.labelLastKnownSystem.MaximumSize = new System.Drawing.Size(190, 0);
            this.labelLastKnownSystem.Name = "labelLastKnownSystem";
            this.labelLastKnownSystem.Size = new System.Drawing.Size(53, 13);
            this.labelLastKnownSystem.TabIndex = 19;
            this.labelLastKnownSystem.Text = "Unknown";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 89);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewDistances);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelSuggestedSystems);
            this.splitContainer1.Panel2.Controls.Add(this.labelLastKnownSystem);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewClosestSystems);
            this.splitContainer1.Panel2.Controls.Add(this.labelClosestSystems);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewSuggestedSystems);
            this.splitContainer1.Size = new System.Drawing.Size(574, 380);
            this.splitContainer1.SplitterDistance = 188;
            this.splitContainer1.TabIndex = 20;
            // 
            // LabelTrilateration
            // 
            this.LabelTrilateration.AutoSize = true;
            this.LabelTrilateration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTrilateration.Location = new System.Drawing.Point(-4, 0);
            this.LabelTrilateration.Name = "LabelTrilateration";
            this.LabelTrilateration.Size = new System.Drawing.Size(105, 20);
            this.LabelTrilateration.TabIndex = 21;
            this.LabelTrilateration.Text = "Trilateration";
            // 
            // buttonCloseTrilateration
            // 
            this.buttonCloseTrilateration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseTrilateration.Location = new System.Drawing.Point(490, 3);
            this.buttonCloseTrilateration.Name = "buttonCloseTrilateration";
            this.buttonCloseTrilateration.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseTrilateration.TabIndex = 22;
            this.buttonCloseTrilateration.Text = "Close";
            this.buttonCloseTrilateration.UseVisualStyleBackColor = true;
            this.buttonCloseTrilateration.Click += new System.EventHandler(this.buttonCloseTrilateration_Click);
            // 
            // TrilaterationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCloseTrilateration);
            this.Controls.Add(this.LabelTrilateration);
            this.Controls.Add(this.panelImplementation);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelCoordinateZ);
            this.Controls.Add(this.textBoxCoordinateZ);
            this.Controls.Add(this.labelCoordinateY);
            this.Controls.Add(this.textBoxCoordinateY);
            this.Controls.Add(this.labelCoordinateX);
            this.Controls.Add(this.textBoxCoordinateX);
            this.Controls.Add(this.labelCoordinates);
            this.Controls.Add(this.buttonSubmitToEDSC);
            this.Controls.Add(this.labelTargetSystem);
            this.Controls.Add(this.textBoxSystemName);
            this.Name = "TrilaterationControl";
            this.Size = new System.Drawing.Size(574, 469);
            this.VisibleChanged += new System.EventHandler(this.TrilaterationControl_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDistances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClosestSystems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuggestedSystems)).EndInit();
            this.panelImplementation.ResumeLayout(false);
            this.panelImplementation.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDistances;
        private System.Windows.Forms.TextBox textBoxSystemName;
        private System.Windows.Forms.Label labelTargetSystem;
        private System.Windows.Forms.Button buttonSubmitToEDSC;
        private System.Windows.Forms.Label labelCoordinates;
        private System.Windows.Forms.TextBox textBoxCoordinateX;
        private System.Windows.Forms.Label labelCoordinateX;
        private System.Windows.Forms.Label labelCoordinateY;
        private System.Windows.Forms.TextBox textBoxCoordinateY;
        private System.Windows.Forms.Label labelCoordinateZ;
        private System.Windows.Forms.TextBox textBoxCoordinateZ;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.DataGridView dataGridViewClosestSystems;
        private System.Windows.Forms.DataGridView dataGridViewSuggestedSystems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSystem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCalculated;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.Panel panelImplementation;
        private System.Windows.Forms.RadioButton radioButtonAlgorithmJs;
        private System.Windows.Forms.RadioButton radioButtonAlgorithmCsharp;
        private System.Windows.Forms.Label labelAlgorithm;
        private System.Windows.Forms.ToolTip toolTipAlgorithm;
        private System.Windows.Forms.Label labelSuggestedSystems;
        private System.Windows.Forms.Label labelClosestSystems;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnSuggestedSystemsSystem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnClosestSystemsSystem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnClosestSystemsDistance;
        private System.Windows.Forms.Label labelLastKnownSystem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label LabelTrilateration;
        private System.Windows.Forms.Button buttonCloseTrilateration;
    }
}
