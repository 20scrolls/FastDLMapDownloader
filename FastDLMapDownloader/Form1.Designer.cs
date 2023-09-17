namespace FastDLMapDownloader
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
            this.mapName = new System.Windows.Forms.RichTextBox();
            this.Find = new System.Windows.Forms.Button();
            this.strikepath = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mapName
            // 
            this.mapName.Location = new System.Drawing.Point(12, 36);
            this.mapName.Name = "mapName";
            this.mapName.Size = new System.Drawing.Size(131, 29);
            this.mapName.TabIndex = 0;
            this.mapName.Text = "";
            this.mapName.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(12, 71);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(75, 23);
            this.Find.TabIndex = 1;
            this.Find.Text = "Download";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // strikepath
            // 
            this.strikepath.Location = new System.Drawing.Point(255, 36);
            this.strikepath.Name = "strikepath";
            this.strikepath.Size = new System.Drawing.Size(418, 29);
            this.strikepath.TabIndex = 2;
            this.strikepath.Text = "E:\\Steam2\\steamapps\\common\\Counter-Strike Source\\cstrike\\download\\maps/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Map Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CS:S Path";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(12, 182);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(521, 178);
            this.output.TabIndex = 5;
            this.output.Text = "";
            this.output.TextChanged += new System.EventHandler(this.output_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.strikepath);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.mapName);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox mapName;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.RichTextBox strikepath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Label label3;
    }
}

