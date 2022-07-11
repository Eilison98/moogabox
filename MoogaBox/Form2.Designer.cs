
namespace moogabox
{
    partial class Form2
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
			this.Btn_Next = new System.Windows.Forms.Button();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnNext2 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnNext0 = new System.Windows.Forms.Button();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.btnNext2.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// Btn_Next
			// 
			this.Btn_Next.Location = new System.Drawing.Point(437, 240);
			this.Btn_Next.Name = "Btn_Next";
			this.Btn_Next.Size = new System.Drawing.Size(66, 31);
			this.Btn_Next.TabIndex = 0;
			this.Btn_Next.Text = "다음";
			this.Btn_Next.UseVisualStyleBackColor = true;
			this.Btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(120, 116);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(323, 29);
			this.txtNum.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(50, 116);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "입력 :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.Location = new System.Drawing.Point(230, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 37);
			this.label2.TabIndex = 3;
			this.label2.Text = "예매조회";
			// 
			// btnNext2
			// 
			this.btnNext2.Appearance = System.Windows.Forms.TabAppearance.Buttons;
			this.btnNext2.Controls.Add(this.tabPage1);
			this.btnNext2.Controls.Add(this.tabPage2);
			this.btnNext2.ItemSize = new System.Drawing.Size(70, 25);
			this.btnNext2.Location = new System.Drawing.Point(12, 49);
			this.btnNext2.Name = "btnNext2";
			this.btnNext2.SelectedIndex = 0;
			this.btnNext2.Size = new System.Drawing.Size(560, 352);
			this.btnNext2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.btnNext2.TabIndex = 5;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(552, 319);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "발권번호";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.Btn_Next);
			this.groupBox1.Controls.Add(this.txtNum);
			this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.groupBox1.Location = new System.Drawing.Point(17, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(517, 285);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "발권번호 조회";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox2);
			this.tabPage2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(552, 319);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "전화번호";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.btnNext0);
			this.groupBox2.Controls.Add(this.txtPhone);
			this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.groupBox2.Location = new System.Drawing.Point(17, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(517, 285);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "전화번호 조회";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.Location = new System.Drawing.Point(50, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "입력 :";
			// 
			// btnNext0
			// 
			this.btnNext0.Location = new System.Drawing.Point(437, 240);
			this.btnNext0.Name = "btnNext0";
			this.btnNext0.Size = new System.Drawing.Size(66, 31);
			this.btnNext0.TabIndex = 0;
			this.btnNext0.Text = "다음";
			this.btnNext0.UseVisualStyleBackColor = true;
			this.btnNext0.Click += new System.EventHandler(this.btnNext0_Click);
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(120, 116);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(323, 29);
			this.txtPhone.TabIndex = 1;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 411);
			this.Controls.Add(this.btnNext2);
			this.Controls.Add(this.label2);
			this.Name = "Form2";
			this.Text = "예매조회";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.btnNext2.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl btnNext2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNext0;
        private System.Windows.Forms.TextBox txtPhone;
    }
}

