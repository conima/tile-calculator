namespace tile_calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbxTileSize = new System.Windows.Forms.GroupBox();
            this.lblTileLengthError = new System.Windows.Forms.Label();
            this.lblTileWidthError = new System.Windows.Forms.Label();
            this.cmbTileUnits = new System.Windows.Forms.ComboBox();
            this.txtTileLength = new System.Windows.Forms.TextBox();
            this.txtTileWidth = new System.Windows.Forms.TextBox();
            this.lblTileUnits = new System.Windows.Forms.Label();
            this.lblTileLength = new System.Windows.Forms.Label();
            this.lblTileWidth = new System.Windows.Forms.Label();
            this.gbxAreaSize = new System.Windows.Forms.GroupBox();
            this.lblAreaLengthError = new System.Windows.Forms.Label();
            this.lblAreaWidthError = new System.Windows.Forms.Label();
            this.cmbAreaUnits = new System.Windows.Forms.ComboBox();
            this.btnResetArea = new System.Windows.Forms.Button();
            this.btnAddArea = new System.Windows.Forms.Button();
            this.lblUnits = new System.Windows.Forms.Label();
            this.lblTotalArea = new System.Windows.Forms.Label();
            this.txtTotalArea = new System.Windows.Forms.TextBox();
            this.lblAreaUnits = new System.Windows.Forms.Label();
            this.lblAreaLength = new System.Windows.Forms.Label();
            this.lblAreaWidth = new System.Windows.Forms.Label();
            this.txtAreaLength = new System.Windows.Forms.TextBox();
            this.txtAreaWidth = new System.Windows.Forms.TextBox();
            this.txtTotalTiles = new System.Windows.Forms.TextBox();
            this.lblNumTiles = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.errorProviderEmpty = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderError = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxTileSize.SuspendLayout();
            this.gbxAreaSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmpty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderError)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxTileSize
            // 
            this.gbxTileSize.Controls.Add(this.lblTileLengthError);
            this.gbxTileSize.Controls.Add(this.lblTileWidthError);
            this.gbxTileSize.Controls.Add(this.cmbTileUnits);
            this.gbxTileSize.Controls.Add(this.txtTileLength);
            this.gbxTileSize.Controls.Add(this.txtTileWidth);
            this.gbxTileSize.Controls.Add(this.lblTileUnits);
            this.gbxTileSize.Controls.Add(this.lblTileLength);
            this.gbxTileSize.Controls.Add(this.lblTileWidth);
            this.gbxTileSize.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxTileSize.ForeColor = System.Drawing.Color.Navy;
            this.gbxTileSize.Location = new System.Drawing.Point(12, 12);
            this.gbxTileSize.Name = "gbxTileSize";
            this.gbxTileSize.Size = new System.Drawing.Size(459, 196);
            this.gbxTileSize.TabIndex = 0;
            this.gbxTileSize.TabStop = false;
            this.gbxTileSize.Text = "Tile Size";
            // 
            // lblTileLengthError
            // 
            this.lblTileLengthError.AutoSize = true;
            this.lblTileLengthError.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTileLengthError.ForeColor = System.Drawing.Color.Red;
            this.lblTileLengthError.Location = new System.Drawing.Point(13, 153);
            this.lblTileLengthError.Name = "lblTileLengthError";
            this.lblTileLengthError.Size = new System.Drawing.Size(35, 18);
            this.lblTileLengthError.TabIndex = 7;
            this.lblTileLengthError.Text = "error";
            this.lblTileLengthError.Visible = false;
            // 
            // lblTileWidthError
            // 
            this.lblTileWidthError.AutoSize = true;
            this.lblTileWidthError.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTileWidthError.ForeColor = System.Drawing.Color.Red;
            this.lblTileWidthError.Location = new System.Drawing.Point(12, 116);
            this.lblTileWidthError.Name = "lblTileWidthError";
            this.lblTileWidthError.Size = new System.Drawing.Size(35, 18);
            this.lblTileWidthError.TabIndex = 6;
            this.lblTileWidthError.Text = "error";
            this.lblTileWidthError.Visible = false;
            // 
            // cmbTileUnits
            // 
            this.cmbTileUnits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTileUnits.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbTileUnits.FormattingEnabled = true;
            this.cmbTileUnits.Items.AddRange(new object[] {
            "Meters",
            "Millimeters",
            "Centimeters",
            "Yards",
            "Feet",
            "Inches"});
            this.cmbTileUnits.Location = new System.Drawing.Point(322, 72);
            this.cmbTileUnits.Name = "cmbTileUnits";
            this.cmbTileUnits.Size = new System.Drawing.Size(125, 28);
            this.cmbTileUnits.TabIndex = 5;
            // 
            // txtTileLength
            // 
            this.txtTileLength.Font = new System.Drawing.Font("Trebuchet MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTileLength.Location = new System.Drawing.Point(168, 72);
            this.txtTileLength.Name = "txtTileLength";
            this.txtTileLength.Size = new System.Drawing.Size(125, 28);
            this.txtTileLength.TabIndex = 4;
            this.txtTileLength.Text = "0";
            this.txtTileLength.Validating += new System.ComponentModel.CancelEventHandler(this.txtTileLength_Validating);
            // 
            // txtTileWidth
            // 
            this.txtTileWidth.Font = new System.Drawing.Font("Trebuchet MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTileWidth.Location = new System.Drawing.Point(15, 72);
            this.txtTileWidth.Name = "txtTileWidth";
            this.txtTileWidth.Size = new System.Drawing.Size(125, 28);
            this.txtTileWidth.TabIndex = 3;
            this.txtTileWidth.Text = "0";
            this.txtTileWidth.Validating += new System.ComponentModel.CancelEventHandler(this.txtTileWidth_Validating);
            // 
            // lblTileUnits
            // 
            this.lblTileUnits.AutoSize = true;
            this.lblTileUnits.Location = new System.Drawing.Point(300, 39);
            this.lblTileUnits.Name = "lblTileUnits";
            this.lblTileUnits.Size = new System.Drawing.Size(44, 20);
            this.lblTileUnits.TabIndex = 2;
            this.lblTileUnits.Text = "Units";
            // 
            // lblTileLength
            // 
            this.lblTileLength.AutoSize = true;
            this.lblTileLength.Location = new System.Drawing.Point(158, 39);
            this.lblTileLength.Name = "lblTileLength";
            this.lblTileLength.Size = new System.Drawing.Size(58, 20);
            this.lblTileLength.TabIndex = 1;
            this.lblTileLength.Text = "Length";
            // 
            // lblTileWidth
            // 
            this.lblTileWidth.AutoSize = true;
            this.lblTileWidth.Location = new System.Drawing.Point(12, 39);
            this.lblTileWidth.Name = "lblTileWidth";
            this.lblTileWidth.Size = new System.Drawing.Size(50, 20);
            this.lblTileWidth.TabIndex = 0;
            this.lblTileWidth.Text = "Width";
            // 
            // gbxAreaSize
            // 
            this.gbxAreaSize.Controls.Add(this.lblAreaLengthError);
            this.gbxAreaSize.Controls.Add(this.lblAreaWidthError);
            this.gbxAreaSize.Controls.Add(this.cmbAreaUnits);
            this.gbxAreaSize.Controls.Add(this.btnResetArea);
            this.gbxAreaSize.Controls.Add(this.btnAddArea);
            this.gbxAreaSize.Controls.Add(this.lblUnits);
            this.gbxAreaSize.Controls.Add(this.lblTotalArea);
            this.gbxAreaSize.Controls.Add(this.txtTotalArea);
            this.gbxAreaSize.Controls.Add(this.lblAreaUnits);
            this.gbxAreaSize.Controls.Add(this.lblAreaLength);
            this.gbxAreaSize.Controls.Add(this.lblAreaWidth);
            this.gbxAreaSize.Controls.Add(this.txtAreaLength);
            this.gbxAreaSize.Controls.Add(this.txtAreaWidth);
            this.gbxAreaSize.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxAreaSize.ForeColor = System.Drawing.Color.Navy;
            this.gbxAreaSize.Location = new System.Drawing.Point(490, 12);
            this.gbxAreaSize.Name = "gbxAreaSize";
            this.gbxAreaSize.Size = new System.Drawing.Size(460, 329);
            this.gbxAreaSize.TabIndex = 1;
            this.gbxAreaSize.TabStop = false;
            this.gbxAreaSize.Text = "Area Size";
            // 
            // lblAreaLengthError
            // 
            this.lblAreaLengthError.AutoSize = true;
            this.lblAreaLengthError.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAreaLengthError.ForeColor = System.Drawing.Color.Red;
            this.lblAreaLengthError.Location = new System.Drawing.Point(14, 153);
            this.lblAreaLengthError.Name = "lblAreaLengthError";
            this.lblAreaLengthError.Size = new System.Drawing.Size(35, 18);
            this.lblAreaLengthError.TabIndex = 17;
            this.lblAreaLengthError.Text = "error";
            this.lblAreaLengthError.Visible = false;
            // 
            // lblAreaWidthError
            // 
            this.lblAreaWidthError.AutoSize = true;
            this.lblAreaWidthError.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAreaWidthError.ForeColor = System.Drawing.Color.Red;
            this.lblAreaWidthError.Location = new System.Drawing.Point(13, 116);
            this.lblAreaWidthError.Name = "lblAreaWidthError";
            this.lblAreaWidthError.Size = new System.Drawing.Size(35, 18);
            this.lblAreaWidthError.TabIndex = 16;
            this.lblAreaWidthError.Text = "error";
            this.lblAreaWidthError.Visible = false;
            // 
            // cmbAreaUnits
            // 
            this.cmbAreaUnits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbAreaUnits.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbAreaUnits.FormattingEnabled = true;
            this.cmbAreaUnits.Items.AddRange(new object[] {
            "Meters",
            "Millimeters",
            "Centimeters",
            "Yards",
            "Feet",
            "Inches"});
            this.cmbAreaUnits.Location = new System.Drawing.Point(320, 70);
            this.cmbAreaUnits.Name = "cmbAreaUnits";
            this.cmbAreaUnits.Size = new System.Drawing.Size(125, 28);
            this.cmbAreaUnits.TabIndex = 15;
            this.cmbAreaUnits.SelectedValueChanged += new System.EventHandler(this.cmbAreaUnits_SelectedValueChanged);
            // 
            // btnResetArea
            // 
            this.btnResetArea.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResetArea.ForeColor = System.Drawing.Color.Maroon;
            this.btnResetArea.Location = new System.Drawing.Point(132, 260);
            this.btnResetArea.Name = "btnResetArea";
            this.btnResetArea.Size = new System.Drawing.Size(100, 33);
            this.btnResetArea.TabIndex = 14;
            this.btnResetArea.Text = "Reset Area";
            this.btnResetArea.UseVisualStyleBackColor = true;
            this.btnResetArea.Click += new System.EventHandler(this.btnResetArea_Click);
            // 
            // btnAddArea
            // 
            this.btnAddArea.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddArea.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddArea.Location = new System.Drawing.Point(315, 198);
            this.btnAddArea.Name = "btnAddArea";
            this.btnAddArea.Size = new System.Drawing.Size(108, 30);
            this.btnAddArea.TabIndex = 13;
            this.btnAddArea.Text = "Add Area";
            this.btnAddArea.UseVisualStyleBackColor = true;
            this.btnAddArea.Click += new System.EventHandler(this.btnAddArea_Click);
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.ForeColor = System.Drawing.Color.Black;
            this.lblUnits.Location = new System.Drawing.Point(252, 203);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(29, 20);
            this.lblUnits.TabIndex = 12;
            this.lblUnits.Text = "m²";
            // 
            // lblTotalArea
            // 
            this.lblTotalArea.AutoSize = true;
            this.lblTotalArea.Location = new System.Drawing.Point(22, 203);
            this.lblTotalArea.Name = "lblTotalArea";
            this.lblTotalArea.Size = new System.Drawing.Size(88, 20);
            this.lblTotalArea.TabIndex = 11;
            this.lblTotalArea.Text = "Total Area:";
            // 
            // txtTotalArea
            // 
            this.txtTotalArea.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTotalArea.Font = new System.Drawing.Font("Trebuchet MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTotalArea.ForeColor = System.Drawing.Color.Navy;
            this.txtTotalArea.Location = new System.Drawing.Point(119, 197);
            this.txtTotalArea.Margin = new System.Windows.Forms.Padding(5);
            this.txtTotalArea.Name = "txtTotalArea";
            this.txtTotalArea.ReadOnly = true;
            this.txtTotalArea.Size = new System.Drawing.Size(125, 28);
            this.txtTotalArea.TabIndex = 10;
            this.txtTotalArea.Text = "0";
            // 
            // lblAreaUnits
            // 
            this.lblAreaUnits.AutoSize = true;
            this.lblAreaUnits.Location = new System.Drawing.Point(295, 39);
            this.lblAreaUnits.Name = "lblAreaUnits";
            this.lblAreaUnits.Size = new System.Drawing.Size(44, 20);
            this.lblAreaUnits.TabIndex = 9;
            this.lblAreaUnits.Text = "Units";
            // 
            // lblAreaLength
            // 
            this.lblAreaLength.AutoSize = true;
            this.lblAreaLength.Location = new System.Drawing.Point(153, 39);
            this.lblAreaLength.Name = "lblAreaLength";
            this.lblAreaLength.Size = new System.Drawing.Size(58, 20);
            this.lblAreaLength.TabIndex = 8;
            this.lblAreaLength.Text = "Length";
            // 
            // lblAreaWidth
            // 
            this.lblAreaWidth.AutoSize = true;
            this.lblAreaWidth.Location = new System.Drawing.Point(13, 39);
            this.lblAreaWidth.Name = "lblAreaWidth";
            this.lblAreaWidth.Size = new System.Drawing.Size(50, 20);
            this.lblAreaWidth.TabIndex = 7;
            this.lblAreaWidth.Text = "Width";
            // 
            // txtAreaLength
            // 
            this.txtAreaLength.Font = new System.Drawing.Font("Trebuchet MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAreaLength.Location = new System.Drawing.Point(165, 71);
            this.txtAreaLength.Name = "txtAreaLength";
            this.txtAreaLength.Size = new System.Drawing.Size(125, 28);
            this.txtAreaLength.TabIndex = 6;
            this.txtAreaLength.Text = "0";
            this.txtAreaLength.Validating += new System.ComponentModel.CancelEventHandler(this.txtAreaLength_Validating);
            // 
            // txtAreaWidth
            // 
            this.txtAreaWidth.Font = new System.Drawing.Font("Trebuchet MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAreaWidth.Location = new System.Drawing.Point(16, 71);
            this.txtAreaWidth.Name = "txtAreaWidth";
            this.txtAreaWidth.Size = new System.Drawing.Size(125, 28);
            this.txtAreaWidth.TabIndex = 5;
            this.txtAreaWidth.Text = "0";
            this.txtAreaWidth.Validating += new System.ComponentModel.CancelEventHandler(this.txtAreaWidth_Validating);
            // 
            // txtTotalTiles
            // 
            this.txtTotalTiles.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTotalTiles.Font = new System.Drawing.Font("Trebuchet MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTotalTiles.ForeColor = System.Drawing.Color.Navy;
            this.txtTotalTiles.Location = new System.Drawing.Point(222, 242);
            this.txtTotalTiles.Margin = new System.Windows.Forms.Padding(5);
            this.txtTotalTiles.Name = "txtTotalTiles";
            this.txtTotalTiles.ReadOnly = true;
            this.txtTotalTiles.Size = new System.Drawing.Size(125, 28);
            this.txtTotalTiles.TabIndex = 10;
            // 
            // lblNumTiles
            // 
            this.lblNumTiles.AutoSize = true;
            this.lblNumTiles.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumTiles.ForeColor = System.Drawing.Color.Navy;
            this.lblNumTiles.Location = new System.Drawing.Point(24, 248);
            this.lblNumTiles.Name = "lblNumTiles";
            this.lblNumTiles.Size = new System.Drawing.Size(183, 20);
            this.lblNumTiles.TabIndex = 11;
            this.lblNumTiles.Text = "Number of tiles needed:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Maroon;
            this.btnCalculate.Location = new System.Drawing.Point(764, 367);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(149, 46);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNote.ForeColor = System.Drawing.Color.Maroon;
            this.lblNote.Location = new System.Drawing.Point(25, 294);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(418, 18);
            this.lblNote.TabIndex = 12;
            this.lblNote.Text = "* Note that probably you will need about 10% more of calculated quantity";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(312, 384);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(245, 18);
            this.lblError.TabIndex = 14;
            this.lblError.Text = "Tile size or Area values cannot be zero !";
            this.lblError.Visible = false;
            // 
            // errorProviderEmpty
            // 
            this.errorProviderEmpty.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderEmpty.ContainerControl = this;
            // 
            // errorProviderError
            // 
            this.errorProviderError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderError.ContainerControl = this;
            this.errorProviderError.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderError.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 441);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblNumTiles);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.txtTotalTiles);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gbxAreaSize);
            this.Controls.Add(this.gbxTileSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiles Calculator";
            this.gbxTileSize.ResumeLayout(false);
            this.gbxTileSize.PerformLayout();
            this.gbxAreaSize.ResumeLayout(false);
            this.gbxAreaSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmpty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTileSize;
        private System.Windows.Forms.GroupBox gbxAreaSize;
        private System.Windows.Forms.TextBox txtTileLength;
        private System.Windows.Forms.TextBox txtTileWidth;
        private System.Windows.Forms.Label lblTileUnits;
        private System.Windows.Forms.Label lblTileLength;
        private System.Windows.Forms.Label lblTileWidth;
        private System.Windows.Forms.Button btnResetArea;
        private System.Windows.Forms.Button btnAddArea;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Label lblTotalArea;
        private System.Windows.Forms.TextBox txtTotalArea;
        private System.Windows.Forms.Label lblAreaUnits;
        private System.Windows.Forms.Label lblAreaLength;
        private System.Windows.Forms.Label lblAreaWidth;
        private System.Windows.Forms.TextBox txtAreaLength;
        private System.Windows.Forms.TextBox txtAreaWidth;
        private System.Windows.Forms.TextBox txtTotalTiles;
        private System.Windows.Forms.Label lblNumTiles;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.ComboBox cmbTileUnits;
        private System.Windows.Forms.ComboBox cmbAreaUnits;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ErrorProvider errorProviderEmpty;
        private System.Windows.Forms.ErrorProvider errorProviderError;
        private System.Windows.Forms.Label lblTileWidthError;
        private System.Windows.Forms.Label lblAreaWidthError;
        private System.Windows.Forms.Label lblTileLengthError;
        private System.Windows.Forms.Label lblAreaLengthError;
    }
}

