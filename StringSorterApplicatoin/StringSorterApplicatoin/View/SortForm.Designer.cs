namespace StringSorterApplicatoin
{
    partial class SortForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxInput = new TextBox();
            comboBoxStrategy = new ComboBox();
            sortBtn = new Button();
            resultLbl = new Label();
            inputLbl = new Label();
            textBoxOutput = new TextBox();
            StrategyLbl = new Label();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.BackColor = SystemColors.ButtonHighlight;
            textBoxInput.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxInput.Location = new Point(382, 132);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(295, 37);
            textBoxInput.TabIndex = 0;
        
            // 
            // comboBoxStrategy
            // 
            comboBoxStrategy.Font = new Font("Segoe UI", 14F);
            comboBoxStrategy.FormattingEnabled = true;
            comboBoxStrategy.Location = new Point(382, 191);
            comboBoxStrategy.Name = "comboBoxStrategy";
            comboBoxStrategy.Size = new Size(192, 33);
            comboBoxStrategy.TabIndex = 1;
            // 
            // sortBtn
            // 
            sortBtn.BackColor = Color.LimeGreen;
            sortBtn.Font = new Font("Segoe UI", 15F);
            sortBtn.ForeColor = SystemColors.ControlLightLight;
            sortBtn.Location = new Point(580, 189);
            sortBtn.Name = "sortBtn";
            sortBtn.Size = new Size(97, 37);
            sortBtn.TabIndex = 2;
            sortBtn.Text = "Sort";
            sortBtn.UseVisualStyleBackColor = false;
            sortBtn.Click += sortBtn_Click;
            // 
            // resultLbl
            // 
            resultLbl.AutoSize = true;
            resultLbl.Font = new Font("Segoe UI", 25F);
            resultLbl.Location = new Point(126, 242);
            resultLbl.Name = "resultLbl";
            resultLbl.Size = new Size(224, 46);
            resultLbl.TabIndex = 3;
            resultLbl.Text = "Sorted String:";
            // 
            // inputLbl
            // 
            inputLbl.AutoSize = true;
            inputLbl.Font = new Font("Segoe UI", 25F);
            inputLbl.Location = new Point(126, 123);
            inputLbl.Name = "inputLbl";
            inputLbl.Size = new Size(199, 46);
            inputLbl.TabIndex = 5;
            inputLbl.Text = "Enter string:";
            // 
            // textBoxOutput
            // 
            textBoxOutput.BackColor = SystemColors.ButtonHighlight;
            textBoxOutput.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxOutput.ForeColor = SystemColors.ActiveCaptionText;
            textBoxOutput.Location = new Point(382, 251);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(295, 37);
            textBoxOutput.TabIndex = 6;
            // 
            // StrategyLbl
            // 
            StrategyLbl.AutoSize = true;
            StrategyLbl.Font = new Font("Segoe UI", 25F);
            StrategyLbl.Location = new Point(126, 178);
            StrategyLbl.Name = "StrategyLbl";
            StrategyLbl.Size = new Size(250, 46);
            StrategyLbl.TabIndex = 7;
            StrategyLbl.Text = "Select Strategy:";
            // 
            // SortForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StrategyLbl);
            Controls.Add(textBoxOutput);
            Controls.Add(inputLbl);
            Controls.Add(resultLbl);
            Controls.Add(sortBtn);
            Controls.Add(comboBoxStrategy);
            Controls.Add(textBoxInput);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "SortForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "String Sorting App";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput;
        private ComboBox comboBoxStrategy;
        private Button sortBtn;
        private Label resultLbl;
        private Label inputLbl;
        private TextBox textBoxOutput;
        private Label StrategyLbl;
    }
}
