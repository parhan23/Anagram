namespace Anagram
{
    partial class mainForm
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
            this.source_rtBox = new System.Windows.Forms.RichTextBox();
            this.anagram_rtBox = new System.Windows.Forms.RichTextBox();
            this.shuffle_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.load_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.source_lbl = new System.Windows.Forms.Label();
            this.anagram_lbl = new System.Windows.Forms.Label();
            this.length_lbl = new System.Windows.Forms.Label();
            this.length_lblVal = new System.Windows.Forms.Label();
            this.loadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.about_btn = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // source_rtBox
            // 
            this.source_rtBox.Location = new System.Drawing.Point(12, 29);
            this.source_rtBox.Name = "source_rtBox";
            this.source_rtBox.Size = new System.Drawing.Size(576, 79);
            this.source_rtBox.TabIndex = 0;
            this.source_rtBox.Text = "";
            this.source_rtBox.TextChanged += new System.EventHandler(this.source_rtBox_TextChanged);
            // 
            // anagram_rtBox
            // 
            this.anagram_rtBox.Location = new System.Drawing.Point(12, 153);
            this.anagram_rtBox.Name = "anagram_rtBox";
            this.anagram_rtBox.ReadOnly = true;
            this.anagram_rtBox.Size = new System.Drawing.Size(576, 79);
            this.anagram_rtBox.TabIndex = 0;
            this.anagram_rtBox.Text = "";
            // 
            // shuffle_btn
            // 
            this.shuffle_btn.Location = new System.Drawing.Point(327, 238);
            this.shuffle_btn.Name = "shuffle_btn";
            this.shuffle_btn.Size = new System.Drawing.Size(138, 79);
            this.shuffle_btn.TabIndex = 1;
            this.shuffle_btn.Text = "Make Anagram";
            this.shuffle_btn.UseVisualStyleBackColor = true;
            this.shuffle_btn.Click += new System.EventHandler(this.shuffle_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(149, 238);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(138, 79);
            this.clear_btn.TabIndex = 1;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // load_btn
            // 
            this.load_btn.Location = new System.Drawing.Point(596, 29);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(138, 79);
            this.load_btn.TabIndex = 1;
            this.load_btn.Text = "Load";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(594, 153);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(138, 79);
            this.save_btn.TabIndex = 1;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // source_lbl
            // 
            this.source_lbl.AutoSize = true;
            this.source_lbl.Location = new System.Drawing.Point(12, 9);
            this.source_lbl.Name = "source_lbl";
            this.source_lbl.Size = new System.Drawing.Size(84, 17);
            this.source_lbl.TabIndex = 2;
            this.source_lbl.Text = "Source Text";
            // 
            // anagram_lbl
            // 
            this.anagram_lbl.AutoSize = true;
            this.anagram_lbl.Location = new System.Drawing.Point(12, 133);
            this.anagram_lbl.Name = "anagram_lbl";
            this.anagram_lbl.Size = new System.Drawing.Size(65, 17);
            this.anagram_lbl.TabIndex = 2;
            this.anagram_lbl.Text = "Anagram";
            // 
            // length_lbl
            // 
            this.length_lbl.AutoSize = true;
            this.length_lbl.Location = new System.Drawing.Point(593, 309);
            this.length_lbl.Name = "length_lbl";
            this.length_lbl.Size = new System.Drawing.Size(68, 17);
            this.length_lbl.TabIndex = 0;
            this.length_lbl.Text = "Length = ";
            // 
            // length_lblVal
            // 
            this.length_lblVal.AutoSize = true;
            this.length_lblVal.Location = new System.Drawing.Point(656, 309);
            this.length_lblVal.Name = "length_lblVal";
            this.length_lblVal.Size = new System.Drawing.Size(16, 17);
            this.length_lblVal.TabIndex = 0;
            this.length_lblVal.Text = "0";
            // 
            // loadFileDialog
            // 
            this.loadFileDialog.FileName = "openFileDialog1";
            this.loadFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.loadFileDialog_FileOk);
            // 
            // about_btn
            // 
            this.about_btn.Location = new System.Drawing.Point(7, 301);
            this.about_btn.Name = "about_btn";
            this.about_btn.Size = new System.Drawing.Size(70, 25);
            this.about_btn.TabIndex = 1;
            this.about_btn.Text = "About";
            this.about_btn.UseVisualStyleBackColor = true;
            this.about_btn.Click += new System.EventHandler(this.about_btn_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 333);
            this.Controls.Add(this.length_lblVal);
            this.Controls.Add(this.length_lbl);
            this.Controls.Add(this.anagram_lbl);
            this.Controls.Add(this.source_lbl);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.about_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.shuffle_btn);
            this.Controls.Add(this.anagram_rtBox);
            this.Controls.Add(this.source_rtBox);
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.Text = "Anagram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox source_rtBox;
        private System.Windows.Forms.RichTextBox anagram_rtBox;
        private System.Windows.Forms.Button shuffle_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label source_lbl;
        private System.Windows.Forms.Label anagram_lbl;
        private System.Windows.Forms.Label length_lbl;
        private System.Windows.Forms.Label length_lblVal;
        private System.Windows.Forms.OpenFileDialog loadFileDialog;
        private System.Windows.Forms.Button about_btn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

