namespace CollaborativeWhiteBoard
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
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.colorIndicatorPanel = new System.Windows.Forms.Panel();
            this.lblColorIndicator = new System.Windows.Forms.Label();
            this.groupBoxThickness = new System.Windows.Forms.GroupBox();
            this.btnThin = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnThick = new System.Windows.Forms.Button();
            this.lblThickness = new System.Windows.Forms.Label();
            this.lblThicknessValue = new System.Windows.Forms.Label();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolPanel.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.groupBoxThickness.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawingPanel
            // 
            this.drawingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawingPanel.BackColor = System.Drawing.Color.White;
            this.drawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingPanel.Location = new System.Drawing.Point(12, 50);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(960, 600);
            this.drawingPanel.TabIndex = 0;
            this.drawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
            this.drawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseDown);
            this.drawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseMove);
            this.drawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseUp);
            // 
            // toolPanel
            // 
            this.toolPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolPanel.Controls.Add(this.groupBoxActions);
            this.toolPanel.Controls.Add(this.groupBoxThickness);
            this.toolPanel.Controls.Add(this.groupBoxColors);
            this.toolPanel.Location = new System.Drawing.Point(978, 50);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(214, 600);
            this.toolPanel.TabIndex = 1;
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.lblColorIndicator);
            this.groupBoxColors.Controls.Add(this.colorIndicatorPanel);
            this.groupBoxColors.Controls.Add(this.btnYellow);
            this.groupBoxColors.Controls.Add(this.btnGreen);
            this.groupBoxColors.Controls.Add(this.btnBlue);
            this.groupBoxColors.Controls.Add(this.btnRed);
            this.groupBoxColors.Controls.Add(this.btnBlack);
            this.groupBoxColors.Location = new System.Drawing.Point(12, 12);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(188, 180);
            this.groupBoxColors.TabIndex = 0;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Colors";
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlack.Location = new System.Drawing.Point(16, 28);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(40, 40);
            this.btnBlack.TabIndex = 0;
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.BtnBlack_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRed.Location = new System.Drawing.Point(62, 28);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(40, 40);
            this.btnRed.TabIndex = 1;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.BtnRed_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlue.Location = new System.Drawing.Point(108, 28);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(40, 40);
            this.btnBlue.TabIndex = 2;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.BtnBlue_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreen.Location = new System.Drawing.Point(16, 74);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(40, 40);
            this.btnGreen.TabIndex = 3;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.BtnGreen_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYellow.Location = new System.Drawing.Point(62, 74);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(40, 40);
            this.btnYellow.TabIndex = 4;
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.BtnYellow_Click);
            // 
            // colorIndicatorPanel
            // 
            this.colorIndicatorPanel.BackColor = System.Drawing.Color.Black;
            this.colorIndicatorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorIndicatorPanel.Location = new System.Drawing.Point(16, 137);
            this.colorIndicatorPanel.Name = "colorIndicatorPanel";
            this.colorIndicatorPanel.Size = new System.Drawing.Size(60, 30);
            this.colorIndicatorPanel.TabIndex = 5;
            // 
            // lblColorIndicator
            // 
            this.lblColorIndicator.AutoSize = true;
            this.lblColorIndicator.Location = new System.Drawing.Point(16, 117);
            this.lblColorIndicator.Name = "lblColorIndicator";
            this.lblColorIndicator.Size = new System.Drawing.Size(75, 15);
            this.lblColorIndicator.TabIndex = 6;
            this.lblColorIndicator.Text = "Current Color:";
            // 
            // groupBoxThickness
            // 
            this.groupBoxThickness.Controls.Add(this.lblThicknessValue);
            this.groupBoxThickness.Controls.Add(this.lblThickness);
            this.groupBoxThickness.Controls.Add(this.btnThick);
            this.groupBoxThickness.Controls.Add(this.btnMedium);
            this.groupBoxThickness.Controls.Add(this.btnThin);
            this.groupBoxThickness.Location = new System.Drawing.Point(12, 198);
            this.groupBoxThickness.Name = "groupBoxThickness";
            this.groupBoxThickness.Size = new System.Drawing.Size(188, 150);
            this.groupBoxThickness.TabIndex = 1;
            this.groupBoxThickness.TabStop = false;
            this.groupBoxThickness.Text = "Thickness";
            // 
            // btnThin
            // 
            this.btnThin.Location = new System.Drawing.Point(16, 28);
            this.btnThin.Name = "btnThin";
            this.btnThin.Size = new System.Drawing.Size(156, 28);
            this.btnThin.TabIndex = 0;
            this.btnThin.Text = "Thin (2px)";
            this.btnThin.UseVisualStyleBackColor = true;
            this.btnThin.Click += new System.EventHandler(this.BtnThin_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(16, 62);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(156, 28);
            this.btnMedium.TabIndex = 1;
            this.btnMedium.Text = "Medium (5px)";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.BtnMedium_Click);
            // 
            // btnThick
            // 
            this.btnThick.Location = new System.Drawing.Point(16, 96);
            this.btnThick.Name = "btnThick";
            this.btnThick.Size = new System.Drawing.Size(156, 28);
            this.btnThick.TabIndex = 2;
            this.btnThick.Text = "Thick (10px)";
            this.btnThick.UseVisualStyleBackColor = true;
            this.btnThick.Click += new System.EventHandler(this.BtnThick_Click);
            // 
            // lblThickness
            // 
            this.lblThickness.AutoSize = true;
            this.lblThickness.Location = new System.Drawing.Point(16, 127);
            this.lblThickness.Name = "lblThickness";
            this.lblThickness.Size = new System.Drawing.Size(55, 15);
            this.lblThickness.TabIndex = 3;
            this.lblThickness.Text = "Current: ";
            // 
            // lblThicknessValue
            // 
            this.lblThicknessValue.AutoSize = true;
            this.lblThicknessValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblThicknessValue.Location = new System.Drawing.Point(77, 127);
            this.lblThicknessValue.Name = "lblThicknessValue";
            this.lblThicknessValue.Size = new System.Drawing.Size(25, 15);
            this.lblThicknessValue.TabIndex = 4;
            this.lblThicknessValue.Text = "2px";
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.btnLoad);
            this.groupBoxActions.Controls.Add(this.btnSave);
            this.groupBoxActions.Controls.Add(this.btnClear);
            this.groupBoxActions.Location = new System.Drawing.Point(12, 354);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(188, 160);
            this.groupBoxActions.TabIndex = 2;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(16, 28);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(156, 35);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear Board";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(16, 69);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 35);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save Drawing";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(16, 110);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(156, 35);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load Drawing";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(293, 30);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Collaborative White Board";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 661);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.toolPanel);
            this.Controls.Add(this.drawingPanel);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Collaborative White Board";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.toolPanel.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.groupBoxColors.PerformLayout();
            this.groupBoxThickness.ResumeLayout(false);
            this.groupBoxThickness.PerformLayout();
            this.groupBoxActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Panel colorIndicatorPanel;
        private System.Windows.Forms.Label lblColorIndicator;
        private System.Windows.Forms.GroupBox groupBoxThickness;
        private System.Windows.Forms.Button btnThin;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnThick;
        private System.Windows.Forms.Label lblThickness;
        private System.Windows.Forms.Label lblThicknessValue;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblTitle;
    }
}
