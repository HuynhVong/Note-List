namespace ListNote
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnOption = new System.Windows.Forms.Panel();
            this.btnSet = new System.Windows.Forms.Button();
            this.bntDocument = new System.Windows.Forms.Button();
            this.bntNote = new System.Windows.Forms.Button();
            this.btnCalender = new System.Windows.Forms.Button();
            this.pnShow = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Title = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnOption.SuspendLayout();
            this.pnShow.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // pnOption
            // 
            this.pnOption.Controls.Add(this.btnSet);
            this.pnOption.Controls.Add(this.bntDocument);
            this.pnOption.Controls.Add(this.bntNote);
            this.pnOption.Controls.Add(this.btnCalender);
            this.pnOption.Location = new System.Drawing.Point(0, 31);
            this.pnOption.Name = "pnOption";
            this.pnOption.Size = new System.Drawing.Size(192, 540);
            this.pnOption.TabIndex = 1;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(0, 492);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(50, 45);
            this.btnSet.TabIndex = 3;
            this.btnSet.Text = "Cài Đặt";
            this.btnSet.UseVisualStyleBackColor = true;
            // 
            // bntDocument
            // 
            this.bntDocument.Location = new System.Drawing.Point(0, 216);
            this.bntDocument.Name = "bntDocument";
            this.bntDocument.Size = new System.Drawing.Size(186, 69);
            this.bntDocument.TabIndex = 2;
            this.bntDocument.Text = "Tài Liệu";
            this.bntDocument.UseVisualStyleBackColor = true;
            // 
            // bntNote
            // 
            this.bntNote.Location = new System.Drawing.Point(0, 358);
            this.bntNote.Name = "bntNote";
            this.bntNote.Size = new System.Drawing.Size(186, 69);
            this.bntNote.TabIndex = 1;
            this.bntNote.Text = "Ghi Chú";
            this.bntNote.UseVisualStyleBackColor = true;
            // 
            // btnCalender
            // 
            this.btnCalender.Location = new System.Drawing.Point(0, 64);
            this.btnCalender.Name = "btnCalender";
            this.btnCalender.Size = new System.Drawing.Size(186, 69);
            this.btnCalender.TabIndex = 0;
            this.btnCalender.Text = "Tạo Lịch";
            this.btnCalender.UseVisualStyleBackColor = true;
            // 
            // pnShow
            // 
            this.pnShow.Controls.Add(this.panel1);
            this.pnShow.Location = new System.Drawing.Point(192, 95);
            this.pnShow.Name = "pnShow";
            this.pnShow.Size = new System.Drawing.Size(784, 493);
            this.pnShow.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 28);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lịch Của Tôi",
            "Tài Liệu",
            "Ghi Chú"});
            this.comboBox1.Location = new System.Drawing.Point(652, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(470, 31);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(170, 36);
            this.Title.TabIndex = 3;
            this.Title.Text = "LIST-NOTE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 573);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pnShow);
            this.Controls.Add(this.pnOption);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnOption.ResumeLayout(false);
            this.pnShow.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel pnOption;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button bntDocument;
        private System.Windows.Forms.Button bntNote;
        private System.Windows.Forms.Button btnCalender;
        private System.Windows.Forms.Panel pnShow;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

