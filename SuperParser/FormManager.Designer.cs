namespace SuperParser
{
    partial class FormManager
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
            this.ResultTextBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownStart = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownEnd = new System.Windows.Forms.NumericUpDown();
            this.buttonHabr = new System.Windows.Forms.Button();
            this.buttonFreelansim = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonPCS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ResultTextBox.FormattingEnabled = true;
            this.ResultTextBox.Location = new System.Drawing.Point(12, 12);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(630, 433);
            this.ResultTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(682, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Point";
            // 
            // numericUpDownStart
            // 
            this.numericUpDownStart.Location = new System.Drawing.Point(652, 28);
            this.numericUpDownStart.Name = "numericUpDownStart";
            this.numericUpDownStart.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownStart.TabIndex = 2;
            this.numericUpDownStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Point";
            // 
            // numericUpDownEnd
            // 
            this.numericUpDownEnd.Location = new System.Drawing.Point(652, 82);
            this.numericUpDownEnd.Name = "numericUpDownEnd";
            this.numericUpDownEnd.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEnd.TabIndex = 4;
            this.numericUpDownEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonHabr
            // 
            this.buttonHabr.Location = new System.Drawing.Point(652, 138);
            this.buttonHabr.Name = "buttonHabr";
            this.buttonHabr.Size = new System.Drawing.Size(119, 23);
            this.buttonHabr.TabIndex = 5;
            this.buttonHabr.Text = "Habr";
            this.buttonHabr.UseVisualStyleBackColor = true;
            this.buttonHabr.Click += new System.EventHandler(this.buttonHabr_Click);
            // 
            // buttonFreelansim
            // 
            this.buttonFreelansim.Location = new System.Drawing.Point(652, 168);
            this.buttonFreelansim.Name = "buttonFreelansim";
            this.buttonFreelansim.Size = new System.Drawing.Size(119, 23);
            this.buttonFreelansim.TabIndex = 6;
            this.buttonFreelansim.Text = "Freelansim";
            this.buttonFreelansim.UseVisualStyleBackColor = true;
            this.buttonFreelansim.Click += new System.EventHandler(this.buttonFreelansim_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(673, 422);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Stop";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(673, 393);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonPCS
            // 
            this.buttonPCS.Location = new System.Drawing.Point(652, 197);
            this.buttonPCS.Name = "buttonPCS";
            this.buttonPCS.Size = new System.Drawing.Size(119, 23);
            this.buttonPCS.TabIndex = 9;
            this.buttonPCS.Text = "Programming-csharp";
            this.buttonPCS.UseVisualStyleBackColor = true;
            this.buttonPCS.Click += new System.EventHandler(this.buttonPCS_Click);
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.buttonPCS);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonFreelansim);
            this.Controls.Add(this.buttonHabr);
            this.Controls.Add(this.numericUpDownEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormManager";
            this.Text = "SuperParser";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ResultTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownEnd;
        private System.Windows.Forms.Button buttonHabr;
        private System.Windows.Forms.Button buttonFreelansim;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonPCS;
    }
}

