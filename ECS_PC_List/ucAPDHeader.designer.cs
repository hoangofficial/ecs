namespace APD_ChangeToCSV
{
    partial class ucAPDHeader
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName01 = new System.Windows.Forms.Label();
            this.cbItemList = new System.Windows.Forms.ComboBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkValidation = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblName01
            // 
            this.lblName01.BackColor = System.Drawing.Color.Gray;
            this.lblName01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName01.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblName01.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName01.ForeColor = System.Drawing.Color.White;
            this.lblName01.Location = new System.Drawing.Point(0, 0);
            this.lblName01.Name = "lblName01";
            this.lblName01.Size = new System.Drawing.Size(86, 23);
            this.lblName01.TabIndex = 108;
            this.lblName01.Tag = "1010,1015";
            this.lblName01.Text = "KeyName";
            this.lblName01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbItemList
            // 
            this.cbItemList.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbItemList.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbItemList.FormattingEnabled = true;
            this.cbItemList.Location = new System.Drawing.Point(86, 0);
            this.cbItemList.Name = "cbItemList";
            this.cbItemList.Size = new System.Drawing.Size(155, 25);
            this.cbItemList.TabIndex = 211;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddItem.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAddItem.Location = new System.Drawing.Point(241, 0);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(82, 23);
            this.btnAddItem.TabIndex = 212;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(412, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 23);
            this.btnDelete.TabIndex = 213;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chkValidation
            // 
            this.chkValidation.AutoSize = true;
            this.chkValidation.Location = new System.Drawing.Point(331, 3);
            this.chkValidation.Name = "chkValidation";
            this.chkValidation.Size = new System.Drawing.Size(79, 16);
            this.chkValidation.TabIndex = 214;
            this.chkValidation.Text = "Validation";
            this.chkValidation.UseVisualStyleBackColor = true;
            this.chkValidation.CheckedChanged += new System.EventHandler(this.chkValidation_CheckedChanged);
            // 
            // ucAPDHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkValidation);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.cbItemList);
            this.Controls.Add(this.lblName01);
            this.Name = "ucAPDHeader";
            this.Size = new System.Drawing.Size(494, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblName01;
        private System.Windows.Forms.ComboBox cbItemList;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chkValidation;
    }
}
