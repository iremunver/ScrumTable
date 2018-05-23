namespace Scrum
{
    partial class Scrum
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtpTask = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTask = new System.Windows.Forms.ComboBox();
            this.btnTaskEkle = new System.Windows.Forms.Button();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStoryEkle = new System.Windows.Forms.Button();
            this.txtStory = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbDone = new System.Windows.Forms.GroupBox();
            this.flowLayoutDone = new System.Windows.Forms.FlowLayoutPanel();
            this.gbInProgress = new System.Windows.Forms.GroupBox();
            this.flowLayoutInProgress = new System.Windows.Forms.FlowLayoutPanel();
            this.gbNotStarted = new System.Windows.Forms.GroupBox();
            this.flowLayoutNotStarted = new System.Windows.Forms.FlowLayoutPanel();
            this.gbStory = new System.Windows.Forms.GroupBox();
            this.flowLayoutStory = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbTaskdegistir = new System.Windows.Forms.ComboBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTaskDurum = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbDone.SuspendLayout();
            this.gbInProgress.SuspendLayout();
            this.gbNotStarted.SuspendLayout();
            this.gbStory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 469);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Azure;
            this.tabPage1.Controls.Add(this.dtpTask);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cmbTask);
            this.tabPage1.Controls.Add(this.btnTaskEkle);
            this.tabPage1.Controls.Add(this.txtTask);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnStoryEkle);
            this.tabPage1.Controls.Add(this.txtStory);
            this.tabPage1.Controls.Add(this.txtAdSoyad);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(644, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Story";
            // 
            // dtpTask
            // 
            this.dtpTask.Location = new System.Drawing.Point(368, 80);
            this.dtpTask.Name = "dtpTask";
            this.dtpTask.Size = new System.Drawing.Size(214, 20);
            this.dtpTask.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Task eklemek istediğiniz story seçiniz";
            // 
            // cmbTask
            // 
            this.cmbTask.FormattingEnabled = true;
            this.cmbTask.Location = new System.Drawing.Point(461, 37);
            this.cmbTask.Name = "cmbTask";
            this.cmbTask.Size = new System.Drawing.Size(121, 21);
            this.cmbTask.TabIndex = 8;
            // 
            // btnTaskEkle
            // 
            this.btnTaskEkle.Location = new System.Drawing.Point(507, 365);
            this.btnTaskEkle.Name = "btnTaskEkle";
            this.btnTaskEkle.Size = new System.Drawing.Size(75, 23);
            this.btnTaskEkle.TabIndex = 7;
            this.btnTaskEkle.Text = "Task Ekle";
            this.btnTaskEkle.UseVisualStyleBackColor = true;
            this.btnTaskEkle.Click += new System.EventHandler(this.btnTaskEkle_Click);
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(368, 129);
            this.txtTask.Multiline = true;
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(214, 213);
            this.txtTask.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Task Ekleyiniz";
            // 
            // btnStoryEkle
            // 
            this.btnStoryEkle.Location = new System.Drawing.Point(148, 365);
            this.btnStoryEkle.Name = "btnStoryEkle";
            this.btnStoryEkle.Size = new System.Drawing.Size(75, 23);
            this.btnStoryEkle.TabIndex = 4;
            this.btnStoryEkle.Text = "Story Ekle";
            this.btnStoryEkle.UseVisualStyleBackColor = true;
            this.btnStoryEkle.Click += new System.EventHandler(this.btnStoryEkle_Click);
            // 
            // txtStory
            // 
            this.txtStory.Location = new System.Drawing.Point(34, 129);
            this.txtStory.Multiline = true;
            this.txtStory.Name = "txtStory";
            this.txtStory.Size = new System.Drawing.Size(189, 213);
            this.txtStory.TabIndex = 3;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(103, 34);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Story ekleyiniz";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbDone);
            this.tabPage2.Controls.Add(this.gbInProgress);
            this.tabPage2.Controls.Add(this.gbNotStarted);
            this.tabPage2.Controls.Add(this.gbStory);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(644, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Scrum Table";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbDone
            // 
            this.gbDone.Controls.Add(this.flowLayoutDone);
            this.gbDone.Location = new System.Drawing.Point(499, 21);
            this.gbDone.Name = "gbDone";
            this.gbDone.Size = new System.Drawing.Size(142, 417);
            this.gbDone.TabIndex = 2;
            this.gbDone.TabStop = false;
            this.gbDone.Text = "DONE";
            // 
            // flowLayoutDone
            // 
            this.flowLayoutDone.AutoScroll = true;
            this.flowLayoutDone.BackColor = System.Drawing.Color.MistyRose;
            this.flowLayoutDone.Location = new System.Drawing.Point(6, 18);
            this.flowLayoutDone.Name = "flowLayoutDone";
            this.flowLayoutDone.Size = new System.Drawing.Size(130, 392);
            this.flowLayoutDone.TabIndex = 2;
            // 
            // gbInProgress
            // 
            this.gbInProgress.Controls.Add(this.flowLayoutInProgress);
            this.gbInProgress.Location = new System.Drawing.Point(351, 20);
            this.gbInProgress.Name = "gbInProgress";
            this.gbInProgress.Size = new System.Drawing.Size(142, 417);
            this.gbInProgress.TabIndex = 2;
            this.gbInProgress.TabStop = false;
            this.gbInProgress.Text = "IN PROGRESS";
            // 
            // flowLayoutInProgress
            // 
            this.flowLayoutInProgress.AutoScroll = true;
            this.flowLayoutInProgress.BackColor = System.Drawing.Color.MistyRose;
            this.flowLayoutInProgress.Location = new System.Drawing.Point(6, 19);
            this.flowLayoutInProgress.Name = "flowLayoutInProgress";
            this.flowLayoutInProgress.Size = new System.Drawing.Size(130, 392);
            this.flowLayoutInProgress.TabIndex = 1;
            // 
            // gbNotStarted
            // 
            this.gbNotStarted.Controls.Add(this.flowLayoutNotStarted);
            this.gbNotStarted.Location = new System.Drawing.Point(197, 20);
            this.gbNotStarted.Name = "gbNotStarted";
            this.gbNotStarted.Size = new System.Drawing.Size(142, 417);
            this.gbNotStarted.TabIndex = 1;
            this.gbNotStarted.TabStop = false;
            this.gbNotStarted.Text = "NOT STARTED";
            // 
            // flowLayoutNotStarted
            // 
            this.flowLayoutNotStarted.AutoScroll = true;
            this.flowLayoutNotStarted.BackColor = System.Drawing.Color.MistyRose;
            this.flowLayoutNotStarted.Location = new System.Drawing.Point(6, 19);
            this.flowLayoutNotStarted.Name = "flowLayoutNotStarted";
            this.flowLayoutNotStarted.Size = new System.Drawing.Size(130, 392);
            this.flowLayoutNotStarted.TabIndex = 0;
            // 
            // gbStory
            // 
            this.gbStory.Controls.Add(this.flowLayoutStory);
            this.gbStory.Location = new System.Drawing.Point(6, 20);
            this.gbStory.Name = "gbStory";
            this.gbStory.Size = new System.Drawing.Size(171, 417);
            this.gbStory.TabIndex = 0;
            this.gbStory.TabStop = false;
            this.gbStory.Text = "STORY";
            // 
            // flowLayoutStory
            // 
            this.flowLayoutStory.AutoScroll = true;
            this.flowLayoutStory.BackColor = System.Drawing.Color.MistyRose;
            this.flowLayoutStory.Location = new System.Drawing.Point(6, 19);
            this.flowLayoutStory.Name = "flowLayoutStory";
            this.flowLayoutStory.Size = new System.Drawing.Size(159, 392);
            this.flowLayoutStory.TabIndex = 0;
            // 
            // cmbTaskdegistir
            // 
            this.cmbTaskdegistir.FormattingEnabled = true;
            this.cmbTaskdegistir.Location = new System.Drawing.Point(373, 487);
            this.cmbTaskdegistir.Name = "cmbTaskdegistir";
            this.cmbTaskdegistir.Size = new System.Drawing.Size(99, 21);
            this.cmbTaskdegistir.TabIndex = 1;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(478, 515);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(77, 21);
            this.btnDegistir.TabIndex = 2;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Yerini değiştirme istediğiniz taskı seçiniz";
            // 
            // cmbTaskDurum
            // 
            this.cmbTaskDurum.FormattingEnabled = true;
            this.cmbTaskDurum.Items.AddRange(new object[] {
            "InProgress",
            "Done"});
            this.cmbTaskDurum.Location = new System.Drawing.Point(373, 515);
            this.cmbTaskDurum.Name = "cmbTaskDurum";
            this.cmbTaskDurum.Size = new System.Drawing.Size(99, 21);
            this.cmbTaskDurum.TabIndex = 4;
            // 
            // Scrum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 592);
            this.Controls.Add(this.cmbTaskDurum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.cmbTaskdegistir);
            this.Controls.Add(this.tabControl1);
            this.Name = "Scrum";
            this.Text = "Scrum";
            this.Load += new System.EventHandler(this.Scrum_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gbDone.ResumeLayout(false);
            this.gbInProgress.ResumeLayout(false);
            this.gbNotStarted.ResumeLayout(false);
            this.gbStory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnTaskEkle;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStoryEkle;
        private System.Windows.Forms.TextBox txtStory;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbDone;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutDone;
        private System.Windows.Forms.GroupBox gbInProgress;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutInProgress;
        private System.Windows.Forms.GroupBox gbNotStarted;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutNotStarted;
        private System.Windows.Forms.GroupBox gbStory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutStory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTask;
        private System.Windows.Forms.ComboBox cmbTaskdegistir;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTaskDurum;
        private System.Windows.Forms.DateTimePicker dtpTask;
    }
}