namespace TermProject
{
    partial class BookCancel
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
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Area_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roomname_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.person_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pay_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookCancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("문체부 돋음체", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(153, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 33);
            this.label2.TabIndex = 16;
            this.label2.Text = "님이 예약하신 펜션";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Area_column,
            this.name_column,
            this.roomname_column,
            this.date_column,
            this.person_column,
            this.pay_column,
            this.price_column});
            this.listView1.Font = new System.Drawing.Font("문체부 돋음체", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 112);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1045, 308);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Area_column
            // 
            this.Area_column.Text = "지역";
            this.Area_column.Width = 101;
            // 
            // name_column
            // 
            this.name_column.Text = "펜션 이름";
            this.name_column.Width = 216;
            // 
            // roomname_column
            // 
            this.roomname_column.Text = "객실 이름";
            this.roomname_column.Width = 176;
            // 
            // date_column
            // 
            this.date_column.Text = "예약하신 날짜";
            this.date_column.Width = 228;
            // 
            // person_column
            // 
            this.person_column.Text = "투숙 인원";
            this.person_column.Width = 100;
            // 
            // pay_column
            // 
            this.pay_column.Text = "결제방식";
            this.pay_column.Width = 110;
            // 
            // price_column
            // 
            this.price_column.Text = "지불금액";
            this.price_column.Width = 124;
            // 
            // BookCancel_button
            // 
            this.BookCancel_button.BackColor = System.Drawing.SystemColors.Control;
            this.BookCancel_button.Font = new System.Drawing.Font("문체부 돋음체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BookCancel_button.Location = new System.Drawing.Point(891, 15);
            this.BookCancel_button.Name = "BookCancel_button";
            this.BookCancel_button.Size = new System.Drawing.Size(175, 91);
            this.BookCancel_button.TabIndex = 37;
            this.BookCancel_button.Text = "예약취소";
            this.BookCancel_button.UseVisualStyleBackColor = false;
            this.BookCancel_button.Click += new System.EventHandler(this.BookCancel_button_Click);
            // 
            // BookCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 458);
            this.Controls.Add(this.BookCancel_button);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Name = "BookCancel";
            this.Text = "BookCancel";
            this.Load += new System.EventHandler(this.BookCancel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Area_column;
        private System.Windows.Forms.ColumnHeader name_column;
        private System.Windows.Forms.ColumnHeader roomname_column;
        private System.Windows.Forms.ColumnHeader date_column;
        private System.Windows.Forms.Button BookCancel_button;
        private System.Windows.Forms.ColumnHeader pay_column;
        private System.Windows.Forms.ColumnHeader price_column;
        private System.Windows.Forms.ColumnHeader person_column;
    }
}