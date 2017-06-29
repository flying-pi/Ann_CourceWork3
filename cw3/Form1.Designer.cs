namespace cw3
{
    partial class Form1
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
            this.kParams = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorField = new System.Windows.Forms.TextBox();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.Chart = new LiveCharts.WinForms.CartesianChart();
            this.GaussianChB = new System.Windows.Forms.CheckBox();
            this.GaussionResult = new System.Windows.Forms.Label();
            this.MonteCarloResultChB = new System.Windows.Forms.CheckBox();
            this.MonteCarloResult = new System.Windows.Forms.Label();
            this.RectChB = new System.Windows.Forms.CheckBox();
            this.RectLabel = new System.Windows.Forms.Label();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // kParams
            // 
            this.kParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kParams.Location = new System.Drawing.Point(328, 12);
            this.kParams.Margin = new System.Windows.Forms.Padding(12);
            this.kParams.Name = "kParams";
            this.kParams.Size = new System.Drawing.Size(200, 26);
            this.kParams.TabIndex = 0;
            this.kParams.Text = "1";
            this.kParams.TextChanged += new System.EventHandler(this.kParams_TextChanged);
            this.kParams.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kParams_OnKeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Коефіцієнт К(ціле, не від\'ємне число)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Похибка(додатнє число)";
            // 
            // errorField
            // 
            this.errorField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorField.Location = new System.Drawing.Point(328, 62);
            this.errorField.Margin = new System.Windows.Forms.Padding(12);
            this.errorField.Name = "errorField";
            this.errorField.Size = new System.Drawing.Size(200, 26);
            this.errorField.TabIndex = 2;
            this.errorField.TextChanged += new System.EventHandler(this.errorField_TextChanged);
            this.errorField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.errorField_KeyPress);
            // 
            // table
            // 
            this.table.ColumnCount = 3;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.Controls.Add(this.kParams, 1, 0);
            this.table.Controls.Add(this.label1, 0, 0);
            this.table.Controls.Add(this.errorField, 1, 1);
            this.table.Controls.Add(this.label2, 0, 1);
            this.table.Controls.Add(this.Chart, 2, 0);
            this.table.Controls.Add(this.GaussianChB, 0, 2);
            this.table.Controls.Add(this.GaussionResult, 1, 2);
            this.table.Controls.Add(this.MonteCarloResultChB, 0, 3);
            this.table.Controls.Add(this.MonteCarloResult, 1, 3);
            this.table.Controls.Add(this.RectChB, 0, 4);
            this.table.Controls.Add(this.RectLabel, 1, 4);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 9;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.Size = new System.Drawing.Size(1522, 888);
            this.table.TabIndex = 5;
            // 
            // Chart
            // 
            this.Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chart.Location = new System.Drawing.Point(555, 15);
            this.Chart.Margin = new System.Windows.Forms.Padding(15);
            this.Chart.Name = "Chart";
            this.table.SetRowSpan(this.Chart, 9);
            this.Chart.Size = new System.Drawing.Size(952, 858);
            this.Chart.TabIndex = 4;
            this.Chart.Text = "Chart";
            this.Chart.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.cartesianChart1_ChildChanged);
            // 
            // GaussianChB
            // 
            this.GaussianChB.AutoSize = true;
            this.GaussianChB.Location = new System.Drawing.Point(12, 112);
            this.GaussianChB.Margin = new System.Windows.Forms.Padding(12);
            this.GaussianChB.Name = "GaussianChB";
            this.GaussianChB.Size = new System.Drawing.Size(132, 24);
            this.GaussianChB.TabIndex = 5;
            this.GaussianChB.Text = "Метод Гауса";
            this.GaussianChB.UseVisualStyleBackColor = true;
            this.GaussianChB.CheckedChanged += new System.EventHandler(this.GaussianChB_CheckedChanged);
            // 
            // GaussionResult
            // 
            this.GaussionResult.AutoSize = true;
            this.GaussionResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GaussionResult.Location = new System.Drawing.Point(316, 100);
            this.GaussionResult.Margin = new System.Windows.Forms.Padding(0);
            this.GaussionResult.Name = "GaussionResult";
            this.GaussionResult.Size = new System.Drawing.Size(224, 48);
            this.GaussionResult.TabIndex = 6;
            this.GaussionResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MonteCarloResultChB
            // 
            this.MonteCarloResultChB.AutoSize = true;
            this.MonteCarloResultChB.Location = new System.Drawing.Point(12, 160);
            this.MonteCarloResultChB.Margin = new System.Windows.Forms.Padding(12);
            this.MonteCarloResultChB.Name = "MonteCarloResultChB";
            this.MonteCarloResultChB.Size = new System.Drawing.Size(190, 24);
            this.MonteCarloResultChB.TabIndex = 7;
            this.MonteCarloResultChB.Text = "Метод Монте Карло";
            this.MonteCarloResultChB.UseVisualStyleBackColor = true;
            this.MonteCarloResultChB.CheckedChanged += new System.EventHandler(this.MonteCarloResultChB_CheckedChanged);
            // 
            // MonteCarloResult
            // 
            this.MonteCarloResult.AutoSize = true;
            this.MonteCarloResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonteCarloResult.Location = new System.Drawing.Point(319, 148);
            this.MonteCarloResult.Name = "MonteCarloResult";
            this.MonteCarloResult.Size = new System.Drawing.Size(218, 48);
            this.MonteCarloResult.TabIndex = 8;
            this.MonteCarloResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RectChB
            // 
            this.RectChB.AutoSize = true;
            this.RectChB.Location = new System.Drawing.Point(12, 208);
            this.RectChB.Margin = new System.Windows.Forms.Padding(12);
            this.RectChB.Name = "RectChB";
            this.RectChB.Size = new System.Drawing.Size(271, 24);
            this.RectChB.TabIndex = 9;
            this.RectChB.Text = "Метод Середніх прямокутників";
            this.RectChB.UseVisualStyleBackColor = true;
            this.RectChB.CheckedChanged += new System.EventHandler(this.RectChB_CheckedChanged);
            // 
            // RectLabel
            // 
            this.RectLabel.AutoSize = true;
            this.RectLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectLabel.Location = new System.Drawing.Point(319, 196);
            this.RectLabel.Name = "RectLabel";
            this.RectLabel.Size = new System.Drawing.Size(218, 48);
            this.RectLabel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 888);
            this.Controls.Add(this.table);
            this.Name = "Form1";
            this.Text = "Form1";
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox kParams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox errorField;
        private System.Windows.Forms.TableLayoutPanel table;
        private LiveCharts.WinForms.CartesianChart Chart;
        private System.Windows.Forms.CheckBox GaussianChB;
        private System.Windows.Forms.Label GaussionResult;
        private System.Windows.Forms.CheckBox MonteCarloResultChB;
        private System.Windows.Forms.Label MonteCarloResult;
        private System.Windows.Forms.CheckBox RectChB;
        private System.Windows.Forms.Label RectLabel;
    }
}

