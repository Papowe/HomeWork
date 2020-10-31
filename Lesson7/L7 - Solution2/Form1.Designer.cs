namespace L7___Solution2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.enter = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblTxtInfo = new System.Windows.Forms.Label();
            this.lblInfoGame = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(60, 90);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(125, 47);
            this.enter.TabIndex = 0;
            this.enter.Text = " Проверить";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(259, 90);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(188, 26);
            this.txtNumber.TabIndex = 1;
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTxtInfo
            // 
            this.lblTxtInfo.AutoSize = true;
            this.lblTxtInfo.Location = new System.Drawing.Point(255, 119);
            this.lblTxtInfo.Name = "lblTxtInfo";
            this.lblTxtInfo.Size = new System.Drawing.Size(192, 20);
            this.lblTxtInfo.TabIndex = 2;
            this.lblTxtInfo.Text = "Вводить число сюда.";
            // 
            // lblInfoGame
            // 
            this.lblInfoGame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblInfoGame.AutoSize = true;
            this.lblInfoGame.Location = new System.Drawing.Point(56, 240);
            this.lblInfoGame.Name = "lblInfoGame";
            this.lblInfoGame.Size = new System.Drawing.Size(0, 20);
            this.lblInfoGame.TabIndex = 3;
            this.lblInfoGame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(13, 13);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 20);
            this.lblCount.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 269);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblInfoGame);
            this.Controls.Add(this.lblTxtInfo);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.enter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblTxtInfo;
        private System.Windows.Forms.Label lblInfoGame;
        private System.Windows.Forms.Label lblCount;
    }
}

