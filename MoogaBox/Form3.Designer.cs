
namespace moogabox
{
    partial class Form3
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbSitnum = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pbMovie = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSeat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHall = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovie)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTitle.Location = new System.Drawing.Point(229, 35);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(67, 30);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "제목 :";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTime.Location = new System.Drawing.Point(229, 99);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(67, 30);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "시간 :";
            // 
            // lbSitnum
            // 
            this.lbSitnum.AutoSize = true;
            this.lbSitnum.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSitnum.Location = new System.Drawing.Point(229, 227);
            this.lbSitnum.Name = "lbSitnum";
            this.lbSitnum.Size = new System.Drawing.Size(67, 30);
            this.lbSitnum.TabIndex = 2;
            this.lbSitnum.Text = "좌석 :";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(520, 250);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(78, 38);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "발권";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pbMovie
            // 
            this.pbMovie.ErrorImage = null;
            this.pbMovie.Location = new System.Drawing.Point(27, 39);
            this.pbMovie.Name = "pbMovie";
            this.pbMovie.Size = new System.Drawing.Size(163, 214);
            this.pbMovie.TabIndex = 6;
            this.pbMovie.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(302, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 23);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTime.Location = new System.Drawing.Point(302, 102);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 23);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Time";
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSeat.Location = new System.Drawing.Point(302, 231);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(43, 23);
            this.lblSeat.TabIndex = 9;
            this.lblSeat.Text = "Seat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(229, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "상영관 :";
            // 
            // lblHall
            // 
            this.lblHall.AutoSize = true;
            this.lblHall.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblHall.Location = new System.Drawing.Point(323, 171);
            this.lblHall.Name = "lblHall";
            this.lblHall.Size = new System.Drawing.Size(39, 23);
            this.lblHall.TabIndex = 9;
            this.lblHall.Text = "Hall";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbMovie);
            this.panel1.Controls.Add(this.lblHall);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.lblSeat);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Controls.Add(this.lbSitnum);
            this.panel1.Location = new System.Drawing.Point(14, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 295);
            this.panel1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(254, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 32);
            this.label7.TabIndex = 10;
            this.label7.Text = "예매현황";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Name = "Form3";
            this.Text = "예매현황";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMovie)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbSitnum;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PictureBox pbMovie;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHall;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
    }
}