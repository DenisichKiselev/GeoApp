namespace WindowsFormsApp1
{
    partial class GeneralWindow
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
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.AppMenuBar = new System.Windows.Forms.Panel();
            this.textBoxViewe = new System.Windows.Forms.TextBox();
            this.ViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewPanel
            // 
            this.ViewPanel.Controls.Add(this.textBoxViewe);
            this.ViewPanel.Location = new System.Drawing.Point(468, 2);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(428, 535);
            this.ViewPanel.TabIndex = 0;
            // 
            // AppMenuBar
            // 
            this.AppMenuBar.Location = new System.Drawing.Point(5, 5);
            this.AppMenuBar.Name = "AppMenuBar";
            this.AppMenuBar.Size = new System.Drawing.Size(454, 531);
            this.AppMenuBar.TabIndex = 1;
            // 
            // textBoxViewe
            // 
            this.textBoxViewe.Location = new System.Drawing.Point(12, 13);
            this.textBoxViewe.Multiline = true;
            this.textBoxViewe.Name = "textBoxViewe";
            this.textBoxViewe.ReadOnly = true;
            this.textBoxViewe.Size = new System.Drawing.Size(400, 400);
            this.textBoxViewe.TabIndex = 0;
            // 
            // GeneralWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 538);
            this.Controls.Add(this.AppMenuBar);
            this.Controls.Add(this.ViewPanel);
            this.Name = "GeneralWindow";
            this.Text = "Form1";
            this.ViewPanel.ResumeLayout(false);
            this.ViewPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.TextBox textBoxViewe;
        private System.Windows.Forms.Panel AppMenuBar;
    }
}

