namespace CharmPointerVSTO
{
    partial class PointerForm
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
            this.pictureBoxPointer = new System.Windows.Forms.PictureBox();
            this.timerForMainLoop = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPointer)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPointer
            // 
            this.pictureBoxPointer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPointer.Image = global::CharmPointerVSTO.Properties.Resources.pointer01;
            this.pictureBoxPointer.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPointer.Name = "pictureBoxPointer";
            this.pictureBoxPointer.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxPointer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPointer.TabIndex = 0;
            this.pictureBoxPointer.TabStop = false;
            // 
            // timerForMainLoop
            // 
            this.timerForMainLoop.Interval = 20;
            this.timerForMainLoop.Tick += new System.EventHandler(this.timerForMainLoop_Tick);
            // 
            // PointerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.Controls.Add(this.pictureBoxPointer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PointerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "PointerForm";
            this.TransparencyKey = System.Drawing.Color.Yellow;
            this.Load += new System.EventHandler(this.PointerForm_Load);
            this.Shown += new System.EventHandler(this.PointerForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPointer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPointer;
        private System.Windows.Forms.Timer timerForMainLoop;
    }
}