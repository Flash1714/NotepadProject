namespace NotepadProject
{
    partial class NotepadProject
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotepadProject));
            this.Title = new System.Windows.Forms.Label();
            this.Note = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.bttNew = new System.Windows.Forms.Button();
            this.bttSave = new System.Windows.Forms.Button();
            this.bttRead = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SavedNotes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.InfoText;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.Snow;
            this.Title.Location = new System.Drawing.Point(72, 45);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(65, 32);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            // 
            // Note
            // 
            this.Note.AutoSize = true;
            this.Note.BackColor = System.Drawing.SystemColors.InfoText;
            this.Note.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Note.ForeColor = System.Drawing.Color.Snow;
            this.Note.Location = new System.Drawing.Point(72, 146);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(68, 32);
            this.Note.TabIndex = 1;
            this.Note.Text = "Note";
            // 
            // textTitle
            // 
            this.textTitle.BackColor = System.Drawing.Color.PeachPuff;
            this.textTitle.Location = new System.Drawing.Point(72, 92);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(277, 31);
            this.textTitle.TabIndex = 2;
            // 
            // textMessage
            // 
            this.textMessage.BackColor = System.Drawing.Color.PeachPuff;
            this.textMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMessage.Location = new System.Drawing.Point(72, 193);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(407, 235);
            this.textMessage.TabIndex = 3;
            // 
            // bttNew
            // 
            this.bttNew.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttNew.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttNew.ForeColor = System.Drawing.Color.Snow;
            this.bttNew.Location = new System.Drawing.Point(147, 479);
            this.bttNew.Name = "bttNew";
            this.bttNew.Size = new System.Drawing.Size(112, 34);
            this.bttNew.TabIndex = 4;
            this.bttNew.Text = "New";
            this.bttNew.UseVisualStyleBackColor = false;
            this.bttNew.Click += new System.EventHandler(this.bttNew_Click);
            // 
            // bttSave
            // 
            this.bttSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttSave.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttSave.ForeColor = System.Drawing.Color.Snow;
            this.bttSave.Location = new System.Drawing.Point(301, 479);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(112, 34);
            this.bttSave.TabIndex = 5;
            this.bttSave.Text = "Save";
            this.bttSave.UseVisualStyleBackColor = false;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // bttRead
            // 
            this.bttRead.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttRead.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttRead.ForeColor = System.Drawing.Color.Snow;
            this.bttRead.Location = new System.Drawing.Point(838, 479);
            this.bttRead.Name = "bttRead";
            this.bttRead.Size = new System.Drawing.Size(112, 34);
            this.bttRead.TabIndex = 6;
            this.bttRead.Text = "Read";
            this.bttRead.UseVisualStyleBackColor = false;
            this.bttRead.Click += new System.EventHandler(this.bttRead_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttDelete.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttDelete.ForeColor = System.Drawing.Color.Snow;
            this.bttDelete.Location = new System.Drawing.Point(968, 479);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(112, 34);
            this.bttDelete.TabIndex = 7;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseVisualStyleBackColor = false;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(818, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(285, 336);
            this.dataGridView1.TabIndex = 8;
            // 
            // SavedNotes
            // 
            this.SavedNotes.AutoSize = true;
            this.SavedNotes.BackColor = System.Drawing.SystemColors.InfoText;
            this.SavedNotes.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SavedNotes.ForeColor = System.Drawing.Color.Snow;
            this.SavedNotes.Location = new System.Drawing.Point(818, 45);
            this.SavedNotes.Name = "SavedNotes";
            this.SavedNotes.Size = new System.Drawing.Size(152, 32);
            this.SavedNotes.TabIndex = 9;
            this.SavedNotes.Text = "Saved Notes";
            // 
            // NotepadProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1129, 622);
            this.Controls.Add(this.SavedNotes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttRead);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.bttNew);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.Title);
            this.Name = "NotepadProject";
            this.Text = "NotepadProject";
            this.Load += new System.EventHandler(this.NotepadProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private Label Note;
        private TextBox textTitle;
        private TextBox textMessage;
        private Button bttNew;
        private Button bttSave;
        private Button bttRead;
        private Button bttDelete;
        private DataGridView dataGridView1;
        private Label SavedNotes;
    }
}