
namespace moogabox
{
    partial class Form0
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblPw = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblID.Location = new System.Drawing.Point(69, 40);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(70, 37);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID : ";
            // 
            // lblPw
            // 
            this.lblPw.AutoSize = true;
            this.lblPw.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPw.Location = new System.Drawing.Point(53, 99);
            this.lblPw.Name = "lblPw";
            this.lblPw.Size = new System.Drawing.Size(86, 37);
            this.lblPw.TabIndex = 1;
            this.lblPw.Text = "PW : ";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.txtId.Location = new System.Drawing.Point(160, 47);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(131, 29);
            this.txtId.TabIndex = 2;
            // 
            // txtPw
            // 
            this.txtPw.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.txtPw.Location = new System.Drawing.Point(160, 107);
            this.txtPw.Name = "txtPw";
            this.txtPw.PasswordChar = '*';
            this.txtPw.Size = new System.Drawing.Size(131, 29);
            this.txtPw.TabIndex = 3;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(334, 174);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(78, 34);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "로그인";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.Location = new System.Drawing.Point(253, 174);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(75, 34);
            this.btnSignup.TabIndex = 5;
            this.btnSignup.Text = "회원가입";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 217);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblPw);
            this.Controls.Add(this.lblID);
            this.Name = "Form0";
            this.Text = "로그인";
            this.Load += new System.EventHandler(this.Form0_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPw;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSignup;
    }
}

