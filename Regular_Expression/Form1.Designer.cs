
namespace Regular_Expression
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tboxReplace = new System.Windows.Forms.TextBox();
            this.rdoReplace = new System.Windows.Forms.RadioButton();
            this.rdoSplit = new System.Windows.Forms.RadioButton();
            this.rdoIsMatch = new System.Windows.Forms.RadioButton();
            this.rdoMatch = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSample = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.cboxRegexName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDataCheck = new System.Windows.Forms.Button();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.tboxCheckData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgRegex = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegex)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tboxReplace);
            this.groupBox1.Controls.Add(this.rdoReplace);
            this.groupBox1.Controls.Add(this.rdoSplit);
            this.groupBox1.Controls.Add(this.rdoIsMatch);
            this.groupBox1.Controls.Add(this.rdoMatch);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcion Select";
            // 
            // tboxReplace
            // 
            this.tboxReplace.Location = new System.Drawing.Point(332, 21);
            this.tboxReplace.Name = "tboxReplace";
            this.tboxReplace.Size = new System.Drawing.Size(121, 25);
            this.tboxReplace.TabIndex = 4;
            // 
            // rdoReplace
            // 
            this.rdoReplace.AutoSize = true;
            this.rdoReplace.Location = new System.Drawing.Point(247, 24);
            this.rdoReplace.Name = "rdoReplace";
            this.rdoReplace.Size = new System.Drawing.Size(81, 19);
            this.rdoReplace.TabIndex = 3;
            this.rdoReplace.TabStop = true;
            this.rdoReplace.Text = "Replace";
            this.rdoReplace.UseVisualStyleBackColor = true;
            // 
            // rdoSplit
            // 
            this.rdoSplit.AutoSize = true;
            this.rdoSplit.Location = new System.Drawing.Point(182, 24);
            this.rdoSplit.Name = "rdoSplit";
            this.rdoSplit.Size = new System.Drawing.Size(56, 19);
            this.rdoSplit.TabIndex = 2;
            this.rdoSplit.TabStop = true;
            this.rdoSplit.Text = "Split";
            this.rdoSplit.UseVisualStyleBackColor = true;
            // 
            // rdoIsMatch
            // 
            this.rdoIsMatch.AutoSize = true;
            this.rdoIsMatch.Location = new System.Drawing.Point(94, 24);
            this.rdoIsMatch.Name = "rdoIsMatch";
            this.rdoIsMatch.Size = new System.Drawing.Size(79, 19);
            this.rdoIsMatch.TabIndex = 1;
            this.rdoIsMatch.TabStop = true;
            this.rdoIsMatch.Text = "IsMatch";
            this.rdoIsMatch.UseVisualStyleBackColor = true;
            // 
            // rdoMatch
            // 
            this.rdoMatch.AutoSize = true;
            this.rdoMatch.Location = new System.Drawing.Point(17, 24);
            this.rdoMatch.Name = "rdoMatch";
            this.rdoMatch.Size = new System.Drawing.Size(68, 19);
            this.rdoMatch.TabIndex = 0;
            this.rdoMatch.TabStop = true;
            this.rdoMatch.Text = "Match";
            this.rdoMatch.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSample);
            this.groupBox2.Controls.Add(this.lblFormat);
            this.groupBox2.Controls.Add(this.cboxRegexName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(715, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Regex Select";
            // 
            // lblSample
            // 
            this.lblSample.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSample.Location = new System.Drawing.Point(70, 103);
            this.lblSample.Name = "lblSample";
            this.lblSample.Size = new System.Drawing.Size(600, 28);
            this.lblSample.TabIndex = 5;
            this.lblSample.Text = "-";
            this.lblSample.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFormat
            // 
            this.lblFormat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblFormat.Location = new System.Drawing.Point(70, 62);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(600, 28);
            this.lblFormat.TabIndex = 4;
            this.lblFormat.Text = "-";
            this.lblFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboxRegexName
            // 
            this.cboxRegexName.FormattingEnabled = true;
            this.cboxRegexName.Location = new System.Drawing.Point(69, 25);
            this.cboxRegexName.Name = "cboxRegexName";
            this.cboxRegexName.Size = new System.Drawing.Size(181, 23);
            this.cboxRegexName.TabIndex = 3;
            this.cboxRegexName.SelectedIndexChanged += new System.EventHandler(this.cboxRegexName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sample";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Format";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDataCheck);
            this.groupBox3.Controls.Add(this.lblErrorMsg);
            this.groupBox3.Controls.Add(this.lblResult);
            this.groupBox3.Controls.Add(this.tboxCheckData);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(12, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(715, 102);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Check Result";
            // 
            // btnDataCheck
            // 
            this.btnDataCheck.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDataCheck.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDataCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDataCheck.Location = new System.Drawing.Point(583, 32);
            this.btnDataCheck.Name = "btnDataCheck";
            this.btnDataCheck.Size = new System.Drawing.Size(126, 23);
            this.btnDataCheck.TabIndex = 11;
            this.btnDataCheck.Text = "Check";
            this.btnDataCheck.UseVisualStyleBackColor = false;
            this.btnDataCheck.Click += new System.EventHandler(this.btnDataCheck_Click);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblErrorMsg.ForeColor = System.Drawing.SystemColors.Control;
            this.lblErrorMsg.Location = new System.Drawing.Point(164, 61);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(545, 28);
            this.lblErrorMsg.TabIndex = 10;
            this.lblErrorMsg.Text = "-";
            this.lblErrorMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblResult.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResult.Location = new System.Drawing.Point(70, 61);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(88, 28);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "-";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tboxCheckData
            // 
            this.tboxCheckData.Location = new System.Drawing.Point(69, 32);
            this.tboxCheckData.Name = "tboxCheckData";
            this.tboxCheckData.Size = new System.Drawing.Size(508, 25);
            this.tboxCheckData.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Result";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Data";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgRegex);
            this.groupBox4.Location = new System.Drawing.Point(13, 348);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(714, 303);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Regex Sample";
            // 
            // dgRegex
            // 
            this.dgRegex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRegex.Location = new System.Drawing.Point(0, 24);
            this.dgRegex.Name = "dgRegex";
            this.dgRegex.RowHeadersWidth = 51;
            this.dgRegex.RowTemplate.Height = 27;
            this.dgRegex.Size = new System.Drawing.Size(708, 273);
            this.dgRegex.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 663);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRegex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tboxReplace;
        private System.Windows.Forms.RadioButton rdoReplace;
        private System.Windows.Forms.RadioButton rdoSplit;
        private System.Windows.Forms.RadioButton rdoIsMatch;
        private System.Windows.Forms.RadioButton rdoMatch;
        private System.Windows.Forms.Label lblSample;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.ComboBox cboxRegexName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxCheckData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDataCheck;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.DataGridView dgRegex;
    }
}

