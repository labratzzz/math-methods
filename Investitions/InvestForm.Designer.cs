namespace MathMethods
{
    partial class InvestForm
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
            this.components = new System.ComponentModel.Container();
            this.InGrid = new System.Windows.Forms.DataGridView();
            this.InvestLabel = new System.Windows.Forms.Label();
            this.CompLabel = new System.Windows.Forms.Label();
            this.OutBox = new System.Windows.Forms.TextBox();
            this.ResTextLabel = new System.Windows.Forms.Label();
            this.ResValueLabel = new System.Windows.Forms.Label();
            this.ResPanel = new System.Windows.Forms.Panel();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SolveButton = new System.Windows.Forms.Button();
            this.ResetAllButton = new System.Windows.Forms.Button();
            this.ClearCellsButton = new System.Windows.Forms.Button();
            this.CurcyUnQuan = new System.Windows.Forms.NumericUpDown();
            this.CompaniesQuan = new System.Windows.Forms.NumericUpDown();
            this.ControlHolder = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.InGrid)).BeginInit();
            this.ResPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurcyUnQuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompaniesQuan)).BeginInit();
            this.ControlHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // InGrid
            // 
            this.InGrid.AllowUserToAddRows = false;
            this.InGrid.AllowUserToResizeRows = false;
            this.InGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InGrid.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.InGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InGrid.Location = new System.Drawing.Point(23, 67);
            this.InGrid.MultiSelect = false;
            this.InGrid.Name = "InGrid";
            this.InGrid.RowHeadersVisible = false;
            this.InGrid.Size = new System.Drawing.Size(320, 320);
            this.InGrid.TabIndex = 0;
            this.InGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.InGrid_EditingControlShowing);
            // 
            // InvestLabel
            // 
            this.InvestLabel.AutoSize = true;
            this.InvestLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InvestLabel.Location = new System.Drawing.Point(23, 13);
            this.InvestLabel.Name = "InvestLabel";
            this.InvestLabel.Size = new System.Drawing.Size(189, 17);
            this.InvestLabel.TabIndex = 3;
            this.InvestLabel.Text = "Кол-во вариантов инвестиций";
            // 
            // CompLabel
            // 
            this.CompLabel.AutoSize = true;
            this.CompLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompLabel.Location = new System.Drawing.Point(23, 41);
            this.CompLabel.Name = "CompLabel";
            this.CompLabel.Size = new System.Drawing.Size(132, 17);
            this.CompLabel.TabIndex = 4;
            this.CompLabel.Text = "Кол-во предприятий";
            // 
            // OutBox
            // 
            this.OutBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.OutBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutBox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutBox.Location = new System.Drawing.Point(76, 392);
            this.OutBox.Name = "OutBox";
            this.OutBox.ReadOnly = true;
            this.OutBox.Size = new System.Drawing.Size(267, 50);
            this.OutBox.TabIndex = 6;
            this.OutBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ResTextLabel
            // 
            this.ResTextLabel.AutoSize = true;
            this.ResTextLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResTextLabel.Location = new System.Drawing.Point(3, 10);
            this.ResTextLabel.Name = "ResTextLabel";
            this.ResTextLabel.Size = new System.Drawing.Size(170, 21);
            this.ResTextLabel.TabIndex = 12;
            this.ResTextLabel.Text = "Максимальный доход:";
            // 
            // ResValueLabel
            // 
            this.ResValueLabel.AutoSize = true;
            this.ResValueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResValueLabel.Location = new System.Drawing.Point(179, 10);
            this.ResValueLabel.Name = "ResValueLabel";
            this.ResValueLabel.Size = new System.Drawing.Size(63, 21);
            this.ResValueLabel.TabIndex = 13;
            this.ResValueLabel.Text = "Z_value";
            // 
            // ResPanel
            // 
            this.ResPanel.Controls.Add(this.ResValueLabel);
            this.ResPanel.Controls.Add(this.ResTextLabel);
            this.ResPanel.Location = new System.Drawing.Point(17, 434);
            this.ResPanel.Name = "ResPanel";
            this.ResPanel.Size = new System.Drawing.Size(331, 36);
            this.ResPanel.TabIndex = 14;
            this.ResPanel.Visible = false;
            // 
            // SolveButton
            // 
            this.SolveButton.BackgroundImage = global::MathMethods.Properties.Resources.icons8_calculator_filled_50;
            this.SolveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SolveButton.FlatAppearance.BorderSize = 0;
            this.SolveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SolveButton.Location = new System.Drawing.Point(23, 392);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(50, 50);
            this.SolveButton.TabIndex = 5;
            this.ToolTip.SetToolTip(this.SolveButton, "Считать");
            this.SolveButton.UseVisualStyleBackColor = true;
            this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // ResetAllButton
            // 
            this.ResetAllButton.BackgroundImage = global::MathMethods.Properties.Resources.icons8_sync_filled_50;
            this.ResetAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResetAllButton.FlatAppearance.BorderSize = 0;
            this.ResetAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetAllButton.Location = new System.Drawing.Point(63, 28);
            this.ResetAllButton.Name = "ResetAllButton";
            this.ResetAllButton.Size = new System.Drawing.Size(25, 25);
            this.ResetAllButton.TabIndex = 4;
            this.ToolTip.SetToolTip(this.ResetAllButton, "Вернуть значения по умолчанию");
            this.ResetAllButton.UseVisualStyleBackColor = true;
            this.ResetAllButton.Click += new System.EventHandler(this.ResetAllButton_Click);
            // 
            // ClearCellsButton
            // 
            this.ClearCellsButton.BackgroundImage = global::MathMethods.Properties.Resources.icons8_cancel_filled_50;
            this.ClearCellsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearCellsButton.FlatAppearance.BorderSize = 0;
            this.ClearCellsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearCellsButton.Location = new System.Drawing.Point(63, 0);
            this.ClearCellsButton.Name = "ClearCellsButton";
            this.ClearCellsButton.Size = new System.Drawing.Size(25, 25);
            this.ClearCellsButton.TabIndex = 3;
            this.ToolTip.SetToolTip(this.ClearCellsButton, "Очистить ячейки");
            this.ClearCellsButton.UseVisualStyleBackColor = true;
            this.ClearCellsButton.Click += new System.EventHandler(this.ClearCellsBox_Click);
            // 
            // CurcyUnQuan
            // 
            this.CurcyUnQuan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurcyUnQuan.Location = new System.Drawing.Point(8, 0);
            this.CurcyUnQuan.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CurcyUnQuan.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.CurcyUnQuan.Name = "CurcyUnQuan";
            this.CurcyUnQuan.Size = new System.Drawing.Size(45, 25);
            this.CurcyUnQuan.TabIndex = 1;
            this.CurcyUnQuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CurcyUnQuan.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.CurcyUnQuan.ValueChanged += new System.EventHandler(this.SizeChange);
            // 
            // CompaniesQuan
            // 
            this.CompaniesQuan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompaniesQuan.Location = new System.Drawing.Point(8, 28);
            this.CompaniesQuan.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CompaniesQuan.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.CompaniesQuan.Name = "CompaniesQuan";
            this.CompaniesQuan.Size = new System.Drawing.Size(45, 25);
            this.CompaniesQuan.TabIndex = 2;
            this.CompaniesQuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CompaniesQuan.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.CompaniesQuan.ValueChanged += new System.EventHandler(this.SizeChange);
            // 
            // ControlHolder
            // 
            this.ControlHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlHolder.Controls.Add(this.CompaniesQuan);
            this.ControlHolder.Controls.Add(this.CurcyUnQuan);
            this.ControlHolder.Controls.Add(this.ClearCellsButton);
            this.ControlHolder.Controls.Add(this.ResetAllButton);
            this.ControlHolder.Location = new System.Drawing.Point(256, 8);
            this.ControlHolder.Name = "ControlHolder";
            this.ControlHolder.Size = new System.Drawing.Size(87, 53);
            this.ControlHolder.TabIndex = 17;
            // 
            // InvestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 481);
            this.Controls.Add(this.OutBox);
            this.Controls.Add(this.SolveButton);
            this.Controls.Add(this.CompLabel);
            this.Controls.Add(this.InvestLabel);
            this.Controls.Add(this.InGrid);
            this.Controls.Add(this.ResPanel);
            this.Controls.Add(this.ControlHolder);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(620, 520);
            this.MinimumSize = new System.Drawing.Size(380, 520);
            this.Name = "InvestForm";
            this.Text = "Задача распределения инвестиций";
            ((System.ComponentModel.ISupportInitialize)(this.InGrid)).EndInit();
            this.ResPanel.ResumeLayout(false);
            this.ResPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurcyUnQuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompaniesQuan)).EndInit();
            this.ControlHolder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InGrid;
        private System.Windows.Forms.Label InvestLabel;
        private System.Windows.Forms.Label CompLabel;
        private System.Windows.Forms.Button ClearCellsButton;
        private System.Windows.Forms.Button ResetAllButton;
        private System.Windows.Forms.Button SolveButton;
        private System.Windows.Forms.TextBox OutBox;
        private System.Windows.Forms.Label ResTextLabel;
        private System.Windows.Forms.Label ResValueLabel;
        private System.Windows.Forms.Panel ResPanel;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.NumericUpDown CurcyUnQuan;
        private System.Windows.Forms.NumericUpDown CompaniesQuan;
        private System.Windows.Forms.Panel ControlHolder;
    }
}