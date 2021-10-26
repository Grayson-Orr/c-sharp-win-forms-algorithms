namespace FractalTrees
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
            this.createFractalBtn = new System.Windows.Forms.Button();
            this.selectDepthLbl = new System.Windows.Forms.Label();
            this.selectDepthNumeric = new System.Windows.Forms.NumericUpDown();
            this.fractalGroupBox = new System.Windows.Forms.GroupBox();
            this.radioBtnDragon = new System.Windows.Forms.RadioButton();
            this.radioBtnTree = new System.Windows.Forms.RadioButton();
            this.radioBtnSnowflake = new System.Windows.Forms.RadioButton();
            this.radioBtnSierpinski = new System.Windows.Forms.RadioButton();
            this.radioBtnFlower = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.selectDepthNumeric)).BeginInit();
            this.fractalGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createFractalBtn
            // 
            this.createFractalBtn.Location = new System.Drawing.Point(12, 12);
            this.createFractalBtn.Name = "createFractalBtn";
            this.createFractalBtn.Size = new System.Drawing.Size(150, 25);
            this.createFractalBtn.TabIndex = 0;
            this.createFractalBtn.Text = "Create Fractal";
            this.createFractalBtn.UseVisualStyleBackColor = true;
            this.createFractalBtn.Click += new System.EventHandler(this.createFractalBtn_Click);
            // 
            // selectDepthLbl
            // 
            this.selectDepthLbl.AutoSize = true;
            this.selectDepthLbl.Location = new System.Drawing.Point(12, 44);
            this.selectDepthLbl.Name = "selectDepthLbl";
            this.selectDepthLbl.Size = new System.Drawing.Size(72, 13);
            this.selectDepthLbl.TabIndex = 1;
            this.selectDepthLbl.Text = "Select Depth:";
            // 
            // selectDepthNumeric
            // 
            this.selectDepthNumeric.Location = new System.Drawing.Point(90, 42);
            this.selectDepthNumeric.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.selectDepthNumeric.Name = "selectDepthNumeric";
            this.selectDepthNumeric.Size = new System.Drawing.Size(72, 20);
            this.selectDepthNumeric.TabIndex = 2;
            // 
            // fractalGroupBox
            // 
            this.fractalGroupBox.Controls.Add(this.radioBtnFlower);
            this.fractalGroupBox.Controls.Add(this.radioBtnDragon);
            this.fractalGroupBox.Controls.Add(this.radioBtnTree);
            this.fractalGroupBox.Controls.Add(this.radioBtnSnowflake);
            this.fractalGroupBox.Controls.Add(this.radioBtnSierpinski);
            this.fractalGroupBox.Location = new System.Drawing.Point(15, 68);
            this.fractalGroupBox.Name = "fractalGroupBox";
            this.fractalGroupBox.Size = new System.Drawing.Size(147, 159);
            this.fractalGroupBox.TabIndex = 3;
            this.fractalGroupBox.TabStop = false;
            this.fractalGroupBox.Text = "Fractal Patterns";
            // 
            // radioBtnDragon
            // 
            this.radioBtnDragon.AutoSize = true;
            this.radioBtnDragon.Location = new System.Drawing.Point(6, 88);
            this.radioBtnDragon.Name = "radioBtnDragon";
            this.radioBtnDragon.Size = new System.Drawing.Size(91, 17);
            this.radioBtnDragon.TabIndex = 5;
            this.radioBtnDragon.TabStop = true;
            this.radioBtnDragon.Text = "Dragon Curve";
            this.radioBtnDragon.UseVisualStyleBackColor = true;
            // 
            // radioBtnTree
            // 
            this.radioBtnTree.AutoSize = true;
            this.radioBtnTree.Location = new System.Drawing.Point(6, 42);
            this.radioBtnTree.Name = "radioBtnTree";
            this.radioBtnTree.Size = new System.Drawing.Size(82, 17);
            this.radioBtnTree.TabIndex = 4;
            this.radioBtnTree.TabStop = true;
            this.radioBtnTree.Text = "Fractal Tree";
            this.radioBtnTree.UseVisualStyleBackColor = true;
            // 
            // radioBtnSnowflake
            // 
            this.radioBtnSnowflake.AutoSize = true;
            this.radioBtnSnowflake.Location = new System.Drawing.Point(6, 65);
            this.radioBtnSnowflake.Name = "radioBtnSnowflake";
            this.radioBtnSnowflake.Size = new System.Drawing.Size(103, 17);
            this.radioBtnSnowflake.TabIndex = 4;
            this.radioBtnSnowflake.TabStop = true;
            this.radioBtnSnowflake.Text = "Koch Snowflake";
            this.radioBtnSnowflake.UseVisualStyleBackColor = true;
            // 
            // radioBtnSierpinski
            // 
            this.radioBtnSierpinski.AutoSize = true;
            this.radioBtnSierpinski.Location = new System.Drawing.Point(6, 19);
            this.radioBtnSierpinski.Name = "radioBtnSierpinski";
            this.radioBtnSierpinski.Size = new System.Drawing.Size(100, 17);
            this.radioBtnSierpinski.TabIndex = 4;
            this.radioBtnSierpinski.TabStop = true;
            this.radioBtnSierpinski.Text = "Sierpinski Sieve";
            this.radioBtnSierpinski.UseVisualStyleBackColor = true;
            // 
            // radioBtnFlower
            // 
            this.radioBtnFlower.AutoSize = true;
            this.radioBtnFlower.Location = new System.Drawing.Point(6, 111);
            this.radioBtnFlower.Name = "radioBtnFlower";
            this.radioBtnFlower.Size = new System.Drawing.Size(88, 17);
            this.radioBtnFlower.TabIndex = 6;
            this.radioBtnFlower.TabStop = true;
            this.radioBtnFlower.Text = "Flower of Life";
            this.radioBtnFlower.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.fractalGroupBox);
            this.Controls.Add(this.selectDepthNumeric);
            this.Controls.Add(this.selectDepthLbl);
            this.Controls.Add(this.createFractalBtn);
            this.Name = "Form1";
            this.Text = "Fractal Trees";
            ((System.ComponentModel.ISupportInitialize)(this.selectDepthNumeric)).EndInit();
            this.fractalGroupBox.ResumeLayout(false);
            this.fractalGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createFractalBtn;
        private System.Windows.Forms.Label selectDepthLbl;
        private System.Windows.Forms.NumericUpDown selectDepthNumeric;
        private System.Windows.Forms.GroupBox fractalGroupBox;
        private System.Windows.Forms.RadioButton radioBtnSnowflake;
        private System.Windows.Forms.RadioButton radioBtnSierpinski;
        private System.Windows.Forms.RadioButton radioBtnTree;
        private System.Windows.Forms.RadioButton radioBtnDragon;
        private System.Windows.Forms.RadioButton radioBtnFlower;
    }
}

