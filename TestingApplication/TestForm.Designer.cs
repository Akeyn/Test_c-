namespace TestingApplication
{
   partial class TestForm
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
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
          this.bCkeckAll = new System.Windows.Forms.Button();
          this.chAutoSpelling = new System.Windows.Forms.CheckBox();
          this.splitContainer1 = new System.Windows.Forms.SplitContainer();
          this.splitContainer2 = new System.Windows.Forms.SplitContainer();
          this.spellingWorker2 = new NHunspellComponent.Spelling.SpellingWorker();
          this.customPaintRichText21 = new TestingApplication.CustomPaintRichText();
          this.spellingWorker1 = new NHunspellComponent.Spelling.SpellingWorker();
          this.splitContainer1.Panel1.SuspendLayout();
          this.splitContainer1.Panel2.SuspendLayout();
          this.splitContainer1.SuspendLayout();
          this.splitContainer2.Panel1.SuspendLayout();
          this.splitContainer2.Panel2.SuspendLayout();
          this.splitContainer2.SuspendLayout();
          this.SuspendLayout();
          // 
          // bCkeckAll
          // 
          this.bCkeckAll.Dock = System.Windows.Forms.DockStyle.Fill;
          this.bCkeckAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
          this.bCkeckAll.Location = new System.Drawing.Point(0, 0);
          this.bCkeckAll.Name = "bCkeckAll";
          this.bCkeckAll.Size = new System.Drawing.Size(232, 28);
          this.bCkeckAll.TabIndex = 9;
          this.bCkeckAll.Text = "Check All";
          this.bCkeckAll.UseVisualStyleBackColor = true;
          this.bCkeckAll.Click += new System.EventHandler(this.bCkeckAll_Click);
          // 
          // chAutoSpelling
          // 
          this.chAutoSpelling.Anchor = System.Windows.Forms.AnchorStyles.Right;
          this.chAutoSpelling.AutoSize = true;
          this.chAutoSpelling.Checked = true;
          this.chAutoSpelling.CheckState = System.Windows.Forms.CheckState.Checked;
          this.chAutoSpelling.ImeMode = System.Windows.Forms.ImeMode.NoControl;
          this.chAutoSpelling.Location = new System.Drawing.Point(29, 7);
          this.chAutoSpelling.Name = "chAutoSpelling";
          this.chAutoSpelling.Size = new System.Drawing.Size(85, 17);
          this.chAutoSpelling.TabIndex = 10;
          this.chAutoSpelling.Text = "AutoSpelling";
          this.chAutoSpelling.UseVisualStyleBackColor = true;
          this.chAutoSpelling.CheckedChanged += new System.EventHandler(this.chAutoSpelling_CheckedChanged);
          // 
          // splitContainer1
          // 
          this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
          this.splitContainer1.Location = new System.Drawing.Point(0, 0);
          this.splitContainer1.Name = "splitContainer1";
          this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
          // 
          // splitContainer1.Panel1
          // 
          this.splitContainer1.Panel1.Controls.Add(this.customPaintRichText21);
          // 
          // splitContainer1.Panel2
          // 
          this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
          this.splitContainer1.Size = new System.Drawing.Size(384, 212);
          this.splitContainer1.SplitterDistance = 180;
          this.splitContainer1.TabIndex = 15;
          // 
          // splitContainer2
          // 
          this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
          this.splitContainer2.Location = new System.Drawing.Point(0, 0);
          this.splitContainer2.Name = "splitContainer2";
          // 
          // splitContainer2.Panel1
          // 
          this.splitContainer2.Panel1.Controls.Add(this.bCkeckAll);
          // 
          // splitContainer2.Panel2
          // 
          this.splitContainer2.Panel2.Controls.Add(this.chAutoSpelling);
          this.splitContainer2.Size = new System.Drawing.Size(384, 28);
          this.splitContainer2.SplitterDistance = 232;
          this.splitContainer2.TabIndex = 16;
          // 
          // spellingWorker2
          // 
          this.spellingWorker2.Editor = null;
          this.spellingWorker2.IsEditorSpellingAutoEnabled = false;
          this.spellingWorker2.IsEditorSpellingEnabled = false;
          // 
          // customPaintRichText21
          // 
          this.customPaintRichText21.Dock = System.Windows.Forms.DockStyle.Fill;
          this.customPaintRichText21.Font = new System.Drawing.Font("Arial", 12F);
          this.customPaintRichText21.IsPassWordProtected = false;
          this.customPaintRichText21.IsSpellingAutoEnabled = true;
          this.customPaintRichText21.IsSpellingEnabled = true;
          this.customPaintRichText21.Location = new System.Drawing.Point(0, 0);
          this.customPaintRichText21.Name = "customPaintRichText21";
          this.customPaintRichText21.Size = new System.Drawing.Size(384, 180);
          this.customPaintRichText21.TabIndex = 14;
          this.customPaintRichText21.Text = resources.GetString("customPaintRichText21.Text");
          this.customPaintRichText21.UnderlinedSections = ((System.Collections.Generic.Dictionary<int, int>)(resources.GetObject("customPaintRichText21.UnderlinedSections")));
          // 
          // spellingWorker1
          // 
          this.spellingWorker1.Editor = this.customPaintRichText21;
          // 
          // TestForm
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(384, 212);
          this.Controls.Add(this.splitContainer1);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
          this.MaximizeBox = false;
          this.MinimizeBox = false;
          this.Name = "TestForm";
          this.Text = "English Spell Check";
          this.Load += new System.EventHandler(this.TestForm_Load);
          this.splitContainer1.Panel1.ResumeLayout(false);
          this.splitContainer1.Panel2.ResumeLayout(false);
          this.splitContainer1.ResumeLayout(false);
          this.splitContainer2.Panel1.ResumeLayout(false);
          this.splitContainer2.Panel2.ResumeLayout(false);
          this.splitContainer2.Panel2.PerformLayout();
          this.splitContainer2.ResumeLayout(false);
          this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button bCkeckAll;
      private System.Windows.Forms.CheckBox chAutoSpelling;
      private CustomPaintRichText customPaintRichText21;
      private NHunspellComponent.Spelling.SpellingWorker spellingWorker1;
      private NHunspellComponent.Spelling.SpellingWorker spellingWorker2;
      private System.Windows.Forms.SplitContainer splitContainer1;
      private System.Windows.Forms.SplitContainer splitContainer2;
   }
}

