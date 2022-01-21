namespace userManage
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelMemo = new System.Windows.Forms.Label();
            this.textBoxMemo = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.checkBoxDelShow = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(11, 11);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "추가";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(106, 11);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "수정";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(198, 11);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "삭제";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.comboBoxSearch);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 39);
            this.panel1.TabIndex = 7;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(70, 20);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 21);
            this.textBoxId.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.checkBoxDelShow);
            this.panel2.Controls.Add(this.labelMemo);
            this.panel2.Controls.Add(this.textBoxMemo);
            this.panel2.Controls.Add(this.labelEmail);
            this.panel2.Controls.Add(this.textBoxEmail);
            this.panel2.Controls.Add(this.labelAddress);
            this.panel2.Controls.Add(this.textBoxAddress);
            this.panel2.Controls.Add(this.labelPhone);
            this.panel2.Controls.Add(this.textBoxPhone);
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Controls.Add(this.textBoxName);
            this.panel2.Controls.Add(this.labelDate);
            this.panel2.Controls.Add(this.textBoxDate);
            this.panel2.Controls.Add(this.labelId);
            this.panel2.Controls.Add(this.textBoxId);
            this.panel2.Location = new System.Drawing.Point(12, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 295);
            this.panel2.TabIndex = 9;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(24, 106);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(29, 12);
            this.labelAddress.TabIndex = 26;
            this.labelAddress.Text = "주소";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(70, 103);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(260, 21);
            this.textBoxAddress.TabIndex = 25;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(183, 65);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(41, 12);
            this.labelPhone.TabIndex = 20;
            this.labelPhone.Text = "연락처";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(230, 62);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 21);
            this.textBoxPhone.TabIndex = 19;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(24, 65);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 12);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "이름";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(70, 62);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 21);
            this.textBoxName.TabIndex = 13;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(184, 23);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(41, 12);
            this.labelDate.TabIndex = 12;
            this.labelDate.Text = "등록일";
            this.labelDate.Click += new System.EventHandler(this.labelName_Click);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(230, 20);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 21);
            this.textBoxDate.TabIndex = 11;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(24, 23);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(40, 12);
            this.labelId.TabIndex = 10;
            this.labelId.Text = "회원ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(389, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(399, 295);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(24, 143);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 12);
            this.labelEmail.TabIndex = 32;
            this.labelEmail.Text = "이메일";
            this.labelEmail.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(70, 140);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(260, 21);
            this.textBoxEmail.TabIndex = 31;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelMemo
            // 
            this.labelMemo.AutoSize = true;
            this.labelMemo.Location = new System.Drawing.Point(24, 182);
            this.labelMemo.Name = "labelMemo";
            this.labelMemo.Size = new System.Drawing.Size(29, 12);
            this.labelMemo.TabIndex = 34;
            this.labelMemo.Text = "메모";
            // 
            // textBoxMemo
            // 
            this.textBoxMemo.Location = new System.Drawing.Point(70, 179);
            this.textBoxMemo.Name = "textBoxMemo";
            this.textBoxMemo.Size = new System.Drawing.Size(260, 21);
            this.textBoxMemo.TabIndex = 33;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(586, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 21);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "회원ID",
            "등록일",
            "이름",
            "연락처",
            "주소",
            "이메일",
            "메모"});
            this.comboBoxSearch.Location = new System.Drawing.Point(459, 9);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(121, 25);
            this.comboBoxSearch.TabIndex = 4;
            this.comboBoxSearch.Text = "회원ID";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(712, 11);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "검색";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // checkBoxDelShow
            // 
            this.checkBoxDelShow.AutoSize = true;
            this.checkBoxDelShow.Location = new System.Drawing.Point(279, 276);
            this.checkBoxDelShow.Name = "checkBoxDelShow";
            this.checkBoxDelShow.Size = new System.Drawing.Size(76, 16);
            this.checkBoxDelShow.TabIndex = 35;
            this.checkBoxDelShow.Text = "삭제 보기";
            this.checkBoxDelShow.UseVisualStyleBackColor = true;
            this.checkBoxDelShow.CheckedChanged += new System.EventHandler(this.checkBoxDelShow_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "회원등록";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "회원목록";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 389);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "회원관리 프로그램";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelMemo;
        private System.Windows.Forms.TextBox textBoxMemo;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.CheckBox checkBoxDelShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

