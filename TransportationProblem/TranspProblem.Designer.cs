namespace TransportationProblem
{
    partial class TranspProblem
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
            this.RowsCount = new System.Windows.Forms.NumericUpDown();
            this.ColsCount = new System.Windows.Forms.NumericUpDown();
            this.InGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OutGrid = new System.Windows.Forms.DataGridView();
            this.SolveButton = new System.Windows.Forms.Button();
            this.ClearCellsButton = new System.Windows.Forms.Button();
            this.ResetAllButton = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ControlsHolder = new System.Windows.Forms.Panel();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.CostText = new System.Windows.Forms.ToolStripStatusLabel();
            this.CostValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.ContentHolder = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.RowsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutGrid)).BeginInit();
            this.ControlsHolder.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.ContentHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // RowsCount
            // 
            this.RowsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RowsCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RowsCount.Location = new System.Drawing.Point(246, 31);
            this.RowsCount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.RowsCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.RowsCount.Name = "RowsCount";
            this.RowsCount.Size = new System.Drawing.Size(40, 25);
            this.RowsCount.TabIndex = 1;
            this.RowsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RowsCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.RowsCount.ValueChanged += new System.EventHandler(this.NumericGridChange);
            // 
            // ColsCount
            // 
            this.ColsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColsCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColsCount.Location = new System.Drawing.Point(246, 3);
            this.ColsCount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.ColsCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ColsCount.Name = "ColsCount";
            this.ColsCount.Size = new System.Drawing.Size(40, 25);
            this.ColsCount.TabIndex = 2;
            this.ColsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColsCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.ColsCount.ValueChanged += new System.EventHandler(this.NumericGridChange);
            // 
            // InGrid
            // 
            this.InGrid.AllowUserToAddRows = false;
            this.InGrid.AllowUserToDeleteRows = false;
            this.InGrid.AllowUserToResizeColumns = false;
            this.InGrid.AllowUserToResizeRows = false;
            this.InGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.InGrid.BackgroundColor = System.Drawing.Color.White;
            this.InGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InGrid.Location = new System.Drawing.Point(0, 0);
            this.InGrid.MultiSelect = false;
            this.InGrid.Name = "InGrid";
            this.InGrid.Size = new System.Drawing.Size(378, 454);
            this.InGrid.TabIndex = 3;
            this.InGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.InGrid_EditingControlShowing);
            this.InGrid.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.InGrid_RowPostPaint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Кол-во поставщиков";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Кол-во потребителей";
            // 
            // OutGrid
            // 
            this.OutGrid.AllowUserToAddRows = false;
            this.OutGrid.AllowUserToDeleteRows = false;
            this.OutGrid.AllowUserToResizeColumns = false;
            this.OutGrid.AllowUserToResizeRows = false;
            this.OutGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OutGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.OutGrid.BackgroundColor = System.Drawing.Color.White;
            this.OutGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OutGrid.Location = new System.Drawing.Point(0, 261);
            this.OutGrid.Name = "OutGrid";
            this.OutGrid.Size = new System.Drawing.Size(378, 193);
            this.OutGrid.TabIndex = 7;
            // 
            // SolveButton
            // 
            this.SolveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SolveButton.BackgroundImage = global::TransportationProblem.Properties.Resources.icons8_calculator_filled_50;
            this.SolveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SolveButton.FlatAppearance.BorderSize = 0;
            this.SolveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SolveButton.Location = new System.Drawing.Point(322, 5);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(50, 50);
            this.SolveButton.TabIndex = 8;
            this.ToolTip.SetToolTip(this.SolveButton, "Решить");
            this.SolveButton.UseVisualStyleBackColor = true;
            this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // ClearCellsButton
            // 
            this.ClearCellsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearCellsButton.BackgroundImage = global::TransportationProblem.Properties.Resources.icons8_cancel_filled_50;
            this.ClearCellsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearCellsButton.FlatAppearance.BorderSize = 0;
            this.ClearCellsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearCellsButton.Location = new System.Drawing.Point(292, 3);
            this.ClearCellsButton.Name = "ClearCellsButton";
            this.ClearCellsButton.Size = new System.Drawing.Size(25, 25);
            this.ClearCellsButton.TabIndex = 10;
            this.ToolTip.SetToolTip(this.ClearCellsButton, "Очистить ячейки");
            this.ClearCellsButton.UseVisualStyleBackColor = true;
            this.ClearCellsButton.Click += new System.EventHandler(this.ClearCellsButton_Click);
            // 
            // ResetAllButton
            // 
            this.ResetAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetAllButton.BackgroundImage = global::TransportationProblem.Properties.Resources.icons8_sync_filled_50;
            this.ResetAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResetAllButton.FlatAppearance.BorderSize = 0;
            this.ResetAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetAllButton.Location = new System.Drawing.Point(292, 31);
            this.ResetAllButton.Name = "ResetAllButton";
            this.ResetAllButton.Size = new System.Drawing.Size(25, 25);
            this.ResetAllButton.TabIndex = 11;
            this.ToolTip.SetToolTip(this.ResetAllButton, "Установить параметры по умолчанию");
            this.ResetAllButton.UseVisualStyleBackColor = true;
            this.ResetAllButton.Click += new System.EventHandler(this.ResetAllButton_Click);
            // 
            // ControlsHolder
            // 
            this.ControlsHolder.Controls.Add(this.SolveButton);
            this.ControlsHolder.Controls.Add(this.ResetAllButton);
            this.ControlsHolder.Controls.Add(this.label1);
            this.ControlsHolder.Controls.Add(this.ClearCellsButton);
            this.ControlsHolder.Controls.Add(this.label2);
            this.ControlsHolder.Controls.Add(this.RowsCount);
            this.ControlsHolder.Controls.Add(this.ColsCount);
            this.ControlsHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlsHolder.Location = new System.Drawing.Point(0, 0);
            this.ControlsHolder.Name = "ControlsHolder";
            this.ControlsHolder.Size = new System.Drawing.Size(378, 60);
            this.ControlsHolder.TabIndex = 12;
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.Color.White;
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CostText,
            this.CostValue});
            this.StatusStrip.Location = new System.Drawing.Point(0, 514);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(378, 22);
            this.StatusStrip.TabIndex = 15;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // CostText
            // 
            this.CostText.Name = "CostText";
            this.CostText.Size = new System.Drawing.Size(99, 17);
            this.CostText.Text = "Мин. стоимость:";
            // 
            // CostValue
            // 
            this.CostValue.Name = "CostValue";
            this.CostValue.Size = new System.Drawing.Size(64, 17);
            this.CostValue.Text = "Ожидание";
            // 
            // ContentHolder
            // 
            this.ContentHolder.Controls.Add(this.splitter1);
            this.ContentHolder.Controls.Add(this.OutGrid);
            this.ContentHolder.Controls.Add(this.InGrid);
            this.ContentHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentHolder.Location = new System.Drawing.Point(0, 60);
            this.ContentHolder.Name = "ContentHolder";
            this.ContentHolder.Size = new System.Drawing.Size(378, 454);
            this.ContentHolder.TabIndex = 16;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 258);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(378, 3);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // TranspProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(378, 536);
            this.Controls.Add(this.ContentHolder);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.ControlsHolder);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximumSize = new System.Drawing.Size(700, 575);
            this.MinimumSize = new System.Drawing.Size(394, 575);
            this.Name = "TranspProblem";
            this.Text = "Транспортная задача";
            ((System.ComponentModel.ISupportInitialize)(this.RowsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutGrid)).EndInit();
            this.ControlsHolder.ResumeLayout(false);
            this.ControlsHolder.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ContentHolder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown RowsCount;
        private System.Windows.Forms.NumericUpDown ColsCount;
        private System.Windows.Forms.DataGridView InGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView OutGrid;
        private System.Windows.Forms.Button SolveButton;
        private System.Windows.Forms.Button ClearCellsButton;
        private System.Windows.Forms.Button ResetAllButton;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Panel ControlsHolder;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel CostText;
        private System.Windows.Forms.ToolStripStatusLabel CostValue;
        private System.Windows.Forms.Panel ContentHolder;
        private System.Windows.Forms.Splitter splitter1;
    }
}

