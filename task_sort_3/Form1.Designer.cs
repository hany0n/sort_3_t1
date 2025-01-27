namespace task_sort_3
{
    partial class Form1
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
            labelSize = new Label();
            textBoxSize = new TextBox();
            labelMin = new Label();
            textBoxMin = new TextBox();
            labelMax = new Label();
            textBoxMax = new TextBox();
            buttonGenerate = new Button();
            buttonSort = new Button();
            listBoxOriginal = new ListBox();
            listBoxSorted = new ListBox();
            labelBubbleResult = new Label();
            labelInsertionResult = new Label();
            labelSelectionResult = new Label();
            SuspendLayout();
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.Location = new Point(12, 9);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(127, 15);
            labelSize.TabIndex = 0;
            labelSize.Text = "Размерность массива";
            // 
            // textBoxSize
            // 
            textBoxSize.Location = new Point(12, 27);
            textBoxSize.Name = "textBoxSize";
            textBoxSize.Size = new Size(100, 23);
            textBoxSize.TabIndex = 1;
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.Location = new Point(226, 9);
            labelMin.Name = "labelMin";
            labelMin.Size = new Size(35, 15);
            labelMin.TabIndex = 2;
            labelMin.Text = "Мин:";
            // 
            // textBoxMin
            // 
            textBoxMin.Location = new Point(226, 27);
            textBoxMin.Name = "textBoxMin";
            textBoxMin.Size = new Size(100, 23);
            textBoxMin.TabIndex = 3;
            // 
            // labelMax
            // 
            labelMax.AutoSize = true;
            labelMax.Location = new Point(421, 9);
            labelMax.Name = "labelMax";
            labelMax.Size = new Size(39, 15);
            labelMax.TabIndex = 4;
            labelMax.Text = "Макс:";
            // 
            // textBoxMax
            // 
            textBoxMax.Location = new Point(421, 27);
            textBoxMax.Name = "textBoxMax";
            textBoxMax.Size = new Size(100, 23);
            textBoxMax.TabIndex = 5;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(668, 27);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(108, 23);
            buttonGenerate.TabIndex = 6;
            buttonGenerate.Text = "Сгенерировать";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(445, 313);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(171, 23);
            buttonSort.TabIndex = 7;
            buttonSort.Text = "Выполнить сортировку";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // listBoxOriginal
            // 
            listBoxOriginal.FormattingEnabled = true;
            listBoxOriginal.ItemHeight = 15;
            listBoxOriginal.Location = new Point(668, 91);
            listBoxOriginal.Name = "listBoxOriginal";
            listBoxOriginal.Size = new Size(120, 94);
            listBoxOriginal.TabIndex = 8;
            // 
            // listBoxSorted
            // 
            listBoxSorted.FormattingEnabled = true;
            listBoxSorted.ItemHeight = 15;
            listBoxSorted.Location = new Point(668, 232);
            listBoxSorted.Name = "listBoxSorted";
            listBoxSorted.Size = new Size(120, 94);
            listBoxSorted.TabIndex = 9;
            // 
            // labelBubbleResult
            // 
            labelBubbleResult.AutoSize = true;
            labelBubbleResult.Location = new Point(21, 112);
            labelBubbleResult.Name = "labelBubbleResult";
            labelBubbleResult.Size = new Size(38, 15);
            labelBubbleResult.TabIndex = 10;
            labelBubbleResult.Text = "label1";
            // 
            // labelInsertionResult
            // 
            labelInsertionResult.AutoSize = true;
            labelInsertionResult.Location = new Point(21, 202);
            labelInsertionResult.Name = "labelInsertionResult";
            labelInsertionResult.Size = new Size(38, 15);
            labelInsertionResult.TabIndex = 11;
            labelInsertionResult.Text = "label1";
            // 
            // labelSelectionResult
            // 
            labelSelectionResult.AutoSize = true;
            labelSelectionResult.Location = new Point(21, 276);
            labelSelectionResult.Name = "labelSelectionResult";
            labelSelectionResult.Size = new Size(38, 15);
            labelSelectionResult.TabIndex = 12;
            labelSelectionResult.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 348);
            Controls.Add(labelSelectionResult);
            Controls.Add(labelInsertionResult);
            Controls.Add(labelBubbleResult);
            Controls.Add(listBoxSorted);
            Controls.Add(listBoxOriginal);
            Controls.Add(buttonSort);
            Controls.Add(buttonGenerate);
            Controls.Add(textBoxMax);
            Controls.Add(labelMax);
            Controls.Add(textBoxMin);
            Controls.Add(labelMin);
            Controls.Add(textBoxSize);
            Controls.Add(labelSize);
            Name = "Form1";
            Text = "Three sorting methods";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSize;
        private TextBox textBoxSize;
        private Label labelMin;
        private TextBox textBoxMin;
        private Label labelMax;
        private TextBox textBoxMax;
        private Button buttonGenerate;
        private Button buttonSort;
        private ListBox listBoxOriginal;
        private ListBox listBoxSorted;
        private Label labelBubbleResult;
        private Label labelInsertionResult;
        private Label labelSelectionResult;
    }
}
