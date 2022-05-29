namespace Game_of_Life
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
            this.pictureBoxGame = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelStart = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelStop = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.deadCellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aliveCellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabelNewGame = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxGame
            // 
            this.pictureBoxGame.Location = new System.Drawing.Point(0, 30);
            this.pictureBoxGame.Name = "pictureBoxGame";
            this.pictureBoxGame.Size = new System.Drawing.Size(800, 420);
            this.pictureBoxGame.TabIndex = 0;
            this.pictureBoxGame.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelStart,
            this.toolStripLabelStop,
            this.toolStripLabel3,
            this.toolStripLabelNewGame});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabelStart
            // 
            this.toolStripLabelStart.Name = "toolStripLabelStart";
            this.toolStripLabelStart.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabelStart.Text = "Start";
            // 
            // toolStripLabelStop
            // 
            this.toolStripLabelStop.Name = "toolStripLabelStop";
            this.toolStripLabelStop.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabelStop.Text = "Stop";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deadCellToolStripMenuItem,
            this.aliveCellToolStripMenuItem});
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(54, 22);
            this.toolStripLabel3.Text = "Colors";
            // 
            // deadCellToolStripMenuItem
            // 
            this.deadCellToolStripMenuItem.Name = "deadCellToolStripMenuItem";
            this.deadCellToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deadCellToolStripMenuItem.Text = "Dead Cell";
            // 
            // aliveCellToolStripMenuItem
            // 
            this.aliveCellToolStripMenuItem.Name = "aliveCellToolStripMenuItem";
            this.aliveCellToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aliveCellToolStripMenuItem.Text = "Alive Cell";
            // 
            // toolStripLabelNewGame
            // 
            this.toolStripLabelNewGame.Name = "toolStripLabelNewGame";
            this.toolStripLabelNewGame.Size = new System.Drawing.Size(65, 22);
            this.toolStripLabelNewGame.Text = "New Game";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBoxGame);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGame;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabelStop;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel3;
        private System.Windows.Forms.ToolStripMenuItem deadCellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aliveCellToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabelNewGame;
    }
}

