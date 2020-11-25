namespace FormsTesting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sgpControl1 = new SGPControlLibrary.SGPControl();
            this.SuspendLayout();
            // 
            // sgpControl1
            // 
            this.sgpControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sgpControl1.HiddenColumns = ((System.Collections.Generic.List<string>)(resources.GetObject("sgpControl1.HiddenColumns")));
            this.sgpControl1.Location = new System.Drawing.Point(0, 0);
            this.sgpControl1.MinimumSize = new System.Drawing.Size(410, 0);
            this.sgpControl1.Name = "sgpControl1";
            this.sgpControl1.Size = new System.Drawing.Size(978, 578);
            this.sgpControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 578);
            this.Controls.Add(this.sgpControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private SGPControlLibrary.SGPControl sgpControl1;
    }
}

