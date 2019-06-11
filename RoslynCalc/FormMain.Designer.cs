namespace RoslynCalc {
   partial class FormMain {
      /// <summary>
      /// 필수 디자이너 변수입니다.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// 사용 중인 모든 리소스를 정리합니다.
      /// </summary>
      /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form 디자이너에서 생성한 코드

      /// <summary>
      /// 디자이너 지원에 필요한 메서드입니다. 
      /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
      /// </summary>
      private void InitializeComponent() {
         this.lbxResult = new System.Windows.Forms.ListBox();
         this.tbxExpression = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // lbxResult
         // 
         this.lbxResult.Dock = System.Windows.Forms.DockStyle.Fill;
         this.lbxResult.FormattingEnabled = true;
         this.lbxResult.ItemHeight = 12;
         this.lbxResult.Location = new System.Drawing.Point(0, 21);
         this.lbxResult.Name = "lbxResult";
         this.lbxResult.Size = new System.Drawing.Size(429, 377);
         this.lbxResult.TabIndex = 0;
         this.lbxResult.SelectedIndexChanged += new System.EventHandler(this.lbxResult_SelectedIndexChanged);
         // 
         // tbxExpression
         // 
         this.tbxExpression.Dock = System.Windows.Forms.DockStyle.Top;
         this.tbxExpression.Location = new System.Drawing.Point(0, 0);
         this.tbxExpression.Name = "tbxExpression";
         this.tbxExpression.Size = new System.Drawing.Size(429, 21);
         this.tbxExpression.TabIndex = 1;
         this.tbxExpression.Text = "3*(1.2+2)";
         this.tbxExpression.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxExpression_KeyDown);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(429, 398);
         this.Controls.Add(this.lbxResult);
         this.Controls.Add(this.tbxExpression);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ListBox lbxResult;
      private System.Windows.Forms.TextBox tbxExpression;
   }
}

