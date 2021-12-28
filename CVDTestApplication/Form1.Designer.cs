
namespace CVDTestApplication
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
            this.empInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.tasksListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.empInfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // empInfoDataGridView
            // 
            this.empInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empInfoDataGridView.Location = new System.Drawing.Point(12, 67);
            this.empInfoDataGridView.Name = "empInfoDataGridView";
            this.empInfoDataGridView.RowTemplate.Height = 25;
            this.empInfoDataGridView.Size = new System.Drawing.Size(494, 180);
            this.empInfoDataGridView.TabIndex = 1;
            // 
            // tasksListBox
            // 
            this.tasksListBox.FormattingEnabled = true;
            this.tasksListBox.ItemHeight = 15;
            this.tasksListBox.Items.AddRange(new object[] {
            "Суммарная зарплата в разрезе департаментов (без руководителей и с руководителями)" +
                "",
            "Департамент, в котором у сотрудника зарплата максимальна",
            "Зарплаты руководителей департаментов (по убыванию)"});
            this.tasksListBox.Location = new System.Drawing.Point(12, 12);
            this.tasksListBox.Name = "tasksListBox";
            this.tasksListBox.Size = new System.Drawing.Size(494, 49);
            this.tasksListBox.TabIndex = 3;
            this.tasksListBox.SelectedIndexChanged += new System.EventHandler(this.tasksListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 259);
            this.Controls.Add(this.tasksListBox);
            this.Controls.Add(this.empInfoDataGridView);
            this.Name = "Form1";
            this.Text = "Тектовое задание для ЦВД";
            ((System.ComponentModel.ISupportInitialize)(this.empInfoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView empInfoDataGridView;
        private System.Windows.Forms.ListBox tasksListBox;
    }
}

