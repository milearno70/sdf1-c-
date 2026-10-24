namespace sdf1_c_
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
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.lstEmployees = new System.Windows.Forms.ListBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.tabPayment = new System.Windows.Forms.TabPage();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtPaymentTitle = new System.Windows.Forms.TextBox();
            this.lblPaymentTitle = new System.Windows.Forms.Label();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.lblSelectEmployee = new System.Windows.Forms.Label();
            this.tabStats = new System.Windows.Forms.TabPage();
            this.lstPayments = new System.Windows.Forms.ListBox();
            this.lblPaymentsTitle = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchCode = new System.Windows.Forms.TextBox();
            this.lblSearchCode = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.tabPayment.SuspendLayout();
            this.tabStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAdd);
            this.tabControl1.Controls.Add(this.tabPayment);
            this.tabControl1.Controls.Add(this.tabStats);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(880, 492);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.lblEmployees);
            this.tabAdd.Controls.Add(this.lstEmployees);
            this.tabAdd.Controls.Add(this.btnAddEmployee);
            this.tabAdd.Controls.Add(this.txtAge);
            this.tabAdd.Controls.Add(this.lblAge);
            this.tabAdd.Controls.Add(this.txtLastName);
            this.tabAdd.Controls.Add(this.lblLastName);
            this.tabAdd.Controls.Add(this.txtFirstName);
            this.tabAdd.Controls.Add(this.lblFirstName);
            this.tabAdd.Controls.Add(this.txtCode);
            this.tabAdd.Controls.Add(this.lblCode);
            this.tabAdd.Location = new System.Drawing.Point(4, 25);
            this.tabAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAdd.Size = new System.Drawing.Size(872, 463);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "İşçi əlavə et";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Location = new System.Drawing.Point(400, 28);
            this.lblEmployees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(42, 16);
            this.lblEmployees.TabIndex = 10;
            this.lblEmployees.Text = "İşçilər";
            // 
            // lstEmployees
            // 
            this.lstEmployees.FormattingEnabled = true;
            this.lstEmployees.ItemHeight = 16;
            this.lstEmployees.Location = new System.Drawing.Point(400, 55);
            this.lstEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(439, 180);
            this.lstEmployees.TabIndex = 9;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(147, 209);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(127, 39);
            this.btnAddEmployee.TabIndex = 8;
            this.btnAddEmployee.Text = "Əlavə et";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(147, 154);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(199, 22);
            this.txtAge.TabIndex = 7;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(27, 158);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(31, 16);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Yaş";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(147, 111);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(199, 22);
            this.txtLastName.TabIndex = 5;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(27, 114);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(47, 16);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Soyad";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(147, 68);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(199, 22);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(27, 71);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(24, 16);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "Ad";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(147, 25);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(199, 22);
            this.txtCode.TabIndex = 1;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(27, 28);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(60, 16);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "İşçi kodu";
            // 
            // tabPayment
            // 
            this.tabPayment.Controls.Add(this.btnAddPayment);
            this.tabPayment.Controls.Add(this.txtAmount);
            this.tabPayment.Controls.Add(this.lblAmount);
            this.tabPayment.Controls.Add(this.txtPaymentTitle);
            this.tabPayment.Controls.Add(this.lblPaymentTitle);
            this.tabPayment.Controls.Add(this.cmbEmployees);
            this.tabPayment.Controls.Add(this.lblSelectEmployee);
            this.tabPayment.Location = new System.Drawing.Point(4, 25);
            this.tabPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPayment.Name = "tabPayment";
            this.tabPayment.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPayment.Size = new System.Drawing.Size(872, 463);
            this.tabPayment.TabIndex = 1;
            this.tabPayment.Text = "Ödəniş yaz";
            this.tabPayment.UseVisualStyleBackColor = true;
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(104, 183);
            this.btnAddPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(122, 39);
            this.btnAddPayment.TabIndex = 6;
            this.btnAddPayment.Text = "Ödənişi yaz";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(187, 123);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(345, 22);
            this.txtAmount.TabIndex = 5;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(27, 127);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(53, 16);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Məbləğ";
            // 
            // txtPaymentTitle
            // 
            this.txtPaymentTitle.Location = new System.Drawing.Point(187, 74);
            this.txtPaymentTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPaymentTitle.Name = "txtPaymentTitle";
            this.txtPaymentTitle.Size = new System.Drawing.Size(345, 22);
            this.txtPaymentTitle.TabIndex = 3;
            // 
            // lblPaymentTitle
            // 
            this.lblPaymentTitle.AutoSize = true;
            this.lblPaymentTitle.Location = new System.Drawing.Point(27, 78);
            this.lblPaymentTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentTitle.Name = "lblPaymentTitle";
            this.lblPaymentTitle.Size = new System.Drawing.Size(82, 16);
            this.lblPaymentTitle.TabIndex = 2;
            this.lblPaymentTitle.Text = "Ödənişin adı";
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(187, 25);
            this.cmbEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(345, 24);
            this.cmbEmployees.TabIndex = 1;
            // 
            // lblSelectEmployee
            // 
            this.lblSelectEmployee.AutoSize = true;
            this.lblSelectEmployee.Location = new System.Drawing.Point(27, 28);
            this.lblSelectEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectEmployee.Name = "lblSelectEmployee";
            this.lblSelectEmployee.Size = new System.Drawing.Size(62, 16);
            this.lblSelectEmployee.TabIndex = 0;
            this.lblSelectEmployee.Text = "İşçi seçin";
            // 
            // tabStats
            // 
            this.tabStats.Controls.Add(this.lstPayments);
            this.tabStats.Controls.Add(this.lblPaymentsTitle);
            this.tabStats.Controls.Add(this.lblInfo);
            this.tabStats.Controls.Add(this.btnSearch);
            this.tabStats.Controls.Add(this.txtSearchCode);
            this.tabStats.Controls.Add(this.lblSearchCode);
            this.tabStats.Location = new System.Drawing.Point(4, 25);
            this.tabStats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabStats.Name = "tabStats";
            this.tabStats.Size = new System.Drawing.Size(872, 463);
            this.tabStats.TabIndex = 2;
            this.tabStats.Text = "Statistika";
            this.tabStats.UseVisualStyleBackColor = true;
            // 
            // lstPayments
            // 
            this.lstPayments.FormattingEnabled = true;
            this.lstPayments.ItemHeight = 16;
            this.lstPayments.Location = new System.Drawing.Point(27, 246);
            this.lstPayments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstPayments.Name = "lstPayments";
            this.lstPayments.Size = new System.Drawing.Size(810, 180);
            this.lstPayments.TabIndex = 5;
            // 
            // lblPaymentsTitle
            // 
            this.lblPaymentsTitle.AutoSize = true;
            this.lblPaymentsTitle.Location = new System.Drawing.Point(27, 222);
            this.lblPaymentsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentsTitle.Name = "lblPaymentsTitle";
            this.lblPaymentsTitle.Size = new System.Drawing.Size(65, 16);
            this.lblPaymentsTitle.TabIndex = 4;
            this.lblPaymentsTitle.Text = "Ödənişlər";
            // 
            // lblInfo
            // 
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfo.Location = new System.Drawing.Point(27, 86);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(636, 110);
            this.lblInfo.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(373, 21);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Axtar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchCode
            // 
            this.txtSearchCode.Location = new System.Drawing.Point(147, 25);
            this.txtSearchCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchCode.Name = "txtSearchCode";
            this.txtSearchCode.Size = new System.Drawing.Size(199, 22);
            this.txtSearchCode.TabIndex = 1;
            // 
            // lblSearchCode
            // 
            this.lblSearchCode.AutoSize = true;
            this.lblSearchCode.Location = new System.Drawing.Point(27, 28);
            this.lblSearchCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchCode.Name = "lblSearchCode";
            this.lblSearchCode.Size = new System.Drawing.Size(60, 16);
            this.lblSearchCode.TabIndex = 0;
            this.lblSearchCode.Text = "İşçi kodu";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(763, 523);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 43);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Çıxış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 581);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşçi Maaş Proqramı";
            this.tabControl1.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabPayment.ResumeLayout(false);
            this.tabPayment.PerformLayout();
            this.tabStats.ResumeLayout(false);
            this.tabStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabPayment;
        private System.Windows.Forms.TabPage tabStats;
        private System.Windows.Forms.Button btnExit;

        // Vərəqə 1
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.ListBox lstEmployees;

        // Vərəqə 2
        private System.Windows.Forms.Label lblSelectEmployee;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.Label lblPaymentTitle;
        private System.Windows.Forms.TextBox txtPaymentTitle;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnAddPayment;

        // Vərəqə 3
        private System.Windows.Forms.Label lblSearchCode;
        private System.Windows.Forms.TextBox txtSearchCode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblPaymentsTitle;
        private System.Windows.Forms.ListBox lstPayments;
    }
}

