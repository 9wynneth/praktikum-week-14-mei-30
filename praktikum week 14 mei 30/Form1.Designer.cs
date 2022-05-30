
namespace praktikum_week_14_mei_30
{
    partial class FormTeam
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
            this.btn_Last = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_First = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_teamName = new System.Windows.Forms.Label();
            this.lbl_manager = new System.Windows.Forms.Label();
            this.lbl_stadium = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_topScorer = new System.Windows.Forms.Label();
            this.lbl_worstDiscipline = new System.Windows.Forms.Label();
            this.dataGV_latestMatch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_latestMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Last
            // 
            this.btn_Last.Location = new System.Drawing.Point(418, 41);
            this.btn_Last.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Last.Name = "btn_Last";
            this.btn_Last.Size = new System.Drawing.Size(91, 61);
            this.btn_Last.TabIndex = 72;
            this.btn_Last.Text = ">>";
            this.btn_Last.UseVisualStyleBackColor = true;
            this.btn_Last.Click += new System.EventHandler(this.btn_Last_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(305, 41);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(91, 61);
            this.btn_Next.TabIndex = 71;
            this.btn_Next.Text = ">";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Prev
            // 
            this.btn_Prev.Location = new System.Drawing.Point(191, 41);
            this.btn_Prev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(91, 61);
            this.btn_Prev.TabIndex = 70;
            this.btn_Prev.Text = "<";
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btn_First
            // 
            this.btn_First.Location = new System.Drawing.Point(78, 41);
            this.btn_First.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_First.Name = "btn_First";
            this.btn_First.Size = new System.Drawing.Size(91, 61);
            this.btn_First.TabIndex = 69;
            this.btn_First.Text = "<<";
            this.btn_First.UseVisualStyleBackColor = true;
            this.btn_First.Click += new System.EventHandler(this.btn_First_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "Team Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "Manager :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "Top Scorer :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "Stadium :";
            // 
            // lbl_teamName
            // 
            this.lbl_teamName.AutoSize = true;
            this.lbl_teamName.Location = new System.Drawing.Point(211, 136);
            this.lbl_teamName.Name = "lbl_teamName";
            this.lbl_teamName.Size = new System.Drawing.Size(51, 20);
            this.lbl_teamName.TabIndex = 80;
            this.lbl_teamName.Text = "label5";
            // 
            // lbl_manager
            // 
            this.lbl_manager.AutoSize = true;
            this.lbl_manager.Location = new System.Drawing.Point(211, 173);
            this.lbl_manager.Name = "lbl_manager";
            this.lbl_manager.Size = new System.Drawing.Size(51, 20);
            this.lbl_manager.TabIndex = 79;
            this.lbl_manager.Text = "label6";
            // 
            // lbl_stadium
            // 
            this.lbl_stadium.AutoSize = true;
            this.lbl_stadium.Location = new System.Drawing.Point(211, 212);
            this.lbl_stadium.Name = "lbl_stadium";
            this.lbl_stadium.Size = new System.Drawing.Size(51, 20);
            this.lbl_stadium.TabIndex = 78;
            this.lbl_stadium.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 77;
            this.label8.Text = "Worst Discipline :";
            // 
            // lbl_topScorer
            // 
            this.lbl_topScorer.AutoSize = true;
            this.lbl_topScorer.Location = new System.Drawing.Point(211, 249);
            this.lbl_topScorer.Name = "lbl_topScorer";
            this.lbl_topScorer.Size = new System.Drawing.Size(51, 20);
            this.lbl_topScorer.TabIndex = 83;
            this.lbl_topScorer.Text = "label9";
            // 
            // lbl_worstDiscipline
            // 
            this.lbl_worstDiscipline.AutoSize = true;
            this.lbl_worstDiscipline.Location = new System.Drawing.Point(211, 286);
            this.lbl_worstDiscipline.Name = "lbl_worstDiscipline";
            this.lbl_worstDiscipline.Size = new System.Drawing.Size(60, 20);
            this.lbl_worstDiscipline.TabIndex = 82;
            this.lbl_worstDiscipline.Text = "label10";
            // 
            // dataGV_latestMatch
            // 
            this.dataGV_latestMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_latestMatch.Location = new System.Drawing.Point(78, 329);
            this.dataGV_latestMatch.Name = "dataGV_latestMatch";
            this.dataGV_latestMatch.RowHeadersWidth = 62;
            this.dataGV_latestMatch.RowTemplate.Height = 28;
            this.dataGV_latestMatch.Size = new System.Drawing.Size(644, 352);
            this.dataGV_latestMatch.TabIndex = 84;
            // 
            // FormTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 693);
            this.Controls.Add(this.dataGV_latestMatch);
            this.Controls.Add(this.lbl_topScorer);
            this.Controls.Add(this.lbl_worstDiscipline);
            this.Controls.Add(this.lbl_teamName);
            this.Controls.Add(this.lbl_manager);
            this.Controls.Add(this.lbl_stadium);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Last);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Prev);
            this.Controls.Add(this.btn_First);
            this.Name = "FormTeam";
            this.Text = "Form Team";
            this.Load += new System.EventHandler(this.FormTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_latestMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Last;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_First;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_teamName;
        private System.Windows.Forms.Label lbl_manager;
        private System.Windows.Forms.Label lbl_stadium;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_topScorer;
        private System.Windows.Forms.Label lbl_worstDiscipline;
        private System.Windows.Forms.DataGridView dataGV_latestMatch;
    }
}

