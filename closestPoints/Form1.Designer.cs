namespace closestPoints
{
    partial class closestPointsProgram
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pointsNumber = new System.Windows.Forms.NumericUpDown();
            this.generatePointsButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.controlsGroupBox = new System.Windows.Forms.GroupBox();
            this.findClosestPointsButton = new System.Windows.Forms.Button();
            this.showMOMLineButton = new System.Windows.Forms.Button();
            this.highlightMOMButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pointsNumber)).BeginInit();
            this.controlsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(523, 375);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Sair";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantidade de pontos:";
            // 
            // pointsNumber
            // 
            this.pointsNumber.Location = new System.Drawing.Point(526, 13);
            this.pointsNumber.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.pointsNumber.Name = "pointsNumber";
            this.pointsNumber.Size = new System.Drawing.Size(72, 20);
            this.pointsNumber.TabIndex = 3;
            this.pointsNumber.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // generatePointsButton
            // 
            this.generatePointsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generatePointsButton.Location = new System.Drawing.Point(523, 39);
            this.generatePointsButton.Name = "generatePointsButton";
            this.generatePointsButton.Size = new System.Drawing.Size(75, 23);
            this.generatePointsButton.TabIndex = 4;
            this.generatePointsButton.Text = "Gerar";
            this.generatePointsButton.UseVisualStyleBackColor = true;
            this.generatePointsButton.Click += new System.EventHandler(this.generatePointsButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Location = new System.Drawing.Point(403, 375);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Controls.Add(this.findClosestPointsButton);
            this.controlsGroupBox.Controls.Add(this.showMOMLineButton);
            this.controlsGroupBox.Controls.Add(this.highlightMOMButton);
            this.controlsGroupBox.Location = new System.Drawing.Point(407, 68);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Size = new System.Drawing.Size(191, 110);
            this.controlsGroupBox.TabIndex = 6;
            this.controlsGroupBox.TabStop = false;
            this.controlsGroupBox.Text = "Controles";
            // 
            // findClosestPointsButton
            // 
            this.findClosestPointsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findClosestPointsButton.Location = new System.Drawing.Point(6, 79);
            this.findClosestPointsButton.Name = "findClosestPointsButton";
            this.findClosestPointsButton.Size = new System.Drawing.Size(179, 23);
            this.findClosestPointsButton.TabIndex = 2;
            this.findClosestPointsButton.Text = "Achar pontos mais próximos";
            this.findClosestPointsButton.UseVisualStyleBackColor = true;
            this.findClosestPointsButton.Click += new System.EventHandler(this.findClosestPointsButton_Click);
            // 
            // showMOMLineButton
            // 
            this.showMOMLineButton.Enabled = false;
            this.showMOMLineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showMOMLineButton.Location = new System.Drawing.Point(6, 49);
            this.showMOMLineButton.Name = "showMOMLineButton";
            this.showMOMLineButton.Size = new System.Drawing.Size(179, 23);
            this.showMOMLineButton.TabIndex = 1;
            this.showMOMLineButton.Text = "Mostrar linha da MOM";
            this.showMOMLineButton.UseVisualStyleBackColor = true;
            this.showMOMLineButton.Click += new System.EventHandler(this.showMOMLineButton_Click);
            // 
            // highlightMOMButton
            // 
            this.highlightMOMButton.Enabled = false;
            this.highlightMOMButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highlightMOMButton.Location = new System.Drawing.Point(6, 19);
            this.highlightMOMButton.Name = "highlightMOMButton";
            this.highlightMOMButton.Size = new System.Drawing.Size(179, 23);
            this.highlightMOMButton.TabIndex = 0;
            this.highlightMOMButton.Text = "Destacar MOM";
            this.highlightMOMButton.UseVisualStyleBackColor = true;
            this.highlightMOMButton.Click += new System.EventHandler(this.highlightMOMButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(409, 187);
            this.statusLabel.MaximumSize = new System.Drawing.Size(190, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "Status:\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 8;
            // 
            // closestPointsProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.controlsGroupBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.generatePointsButton);
            this.Controls.Add(this.pointsNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "closestPointsProgram";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Closest Points";
            ((System.ComponentModel.ISupportInitialize)(this.pointsNumber)).EndInit();
            this.controlsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown pointsNumber;
        private System.Windows.Forms.Button generatePointsButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.GroupBox controlsGroupBox;
        private System.Windows.Forms.Button findClosestPointsButton;
        private System.Windows.Forms.Button showMOMLineButton;
        private System.Windows.Forms.Button highlightMOMButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Panel panel1;
    }
}

