
namespace ParkingSolution
{
    partial class Manager_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_Form));
            this.tabControl_StaffOp = new System.Windows.Forms.TabControl();
            this.tabPage_BasicMn = new System.Windows.Forms.TabPage();
            this.label_TokenID = new System.Windows.Forms.Label();
            this.textBox_CustomerTokenID = new System.Windows.Forms.TextBox();
            this.button_RevenueCheck = new System.Windows.Forms.Button();
            this.button_RemoveCu = new System.Windows.Forms.Button();
            this.button_LogOut1 = new System.Windows.Forms.Button();
            this.button_ExitMn1 = new System.Windows.Forms.Button();
            this.button_CustomerView = new System.Windows.Forms.Button();
            this.dataGridView_CustomerView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_TokenCheckderSal = new System.Windows.Forms.TextBox();
            this.label_EmpSal = new System.Windows.Forms.Label();
            this.textBox_ClerkSal = new System.Windows.Forms.TextBox();
            this.label_OthersSal = new System.Windows.Forms.Label();
            this.textBox_OthersInvest = new System.Windows.Forms.TextBox();
            this.label_TockenCheckSal = new System.Windows.Forms.Label();
            this.label_ClerkSal = new System.Windows.Forms.Label();
            this.textBox_Amount = new System.Windows.Forms.TextBox();
            this.label_TotalAmount = new System.Windows.Forms.Label();
            this.textBox_Revenue = new System.Windows.Forms.TextBox();
            this.label_Revenue = new System.Windows.Forms.Label();
            this.button_FORclerkID = new System.Windows.Forms.Button();
            this.textBox_ManagerID = new System.Windows.Forms.TextBox();
            this.label_CustomerView_Manager = new System.Windows.Forms.Label();
            this.label_ManagerName = new System.Windows.Forms.Label();
            this.tabPage_employeeOp = new System.Windows.Forms.TabPage();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_removeTick = new System.Windows.Forms.Button();
            this.radioButton_TokenCheckD = new System.Windows.Forms.RadioButton();
            this.radioButton_ClerkP = new System.Windows.Forms.RadioButton();
            this.dataGridView_SearchBar = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label_StaffNewpass = new System.Windows.Forms.Label();
            this.label_Type = new System.Windows.Forms.Label();
            this.label_staffNID = new System.Windows.Forms.Label();
            this.label_StaffName = new System.Windows.Forms.Label();
            this.label_UserID = new System.Windows.Forms.Label();
            this.textBox_UserID = new System.Windows.Forms.TextBox();
            this.textBox_ConfirmPaswUP = new System.Windows.Forms.TextBox();
            this.textBox_NameUp = new System.Windows.Forms.TextBox();
            this.textBox_NIDUp = new System.Windows.Forms.TextBox();
            this.textBox_PassUP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button_RefreshEmp = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.dataGridView_Stafflist = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_removeEmp = new System.Windows.Forms.Button();
            this.button_AddEmp = new System.Windows.Forms.Button();
            this.label_Stafflist_Manager = new System.Windows.Forms.Label();
            this.tabControl_StaffOp.SuspendLayout();
            this.tabPage_BasicMn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CustomerView)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage_employeeOp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SearchBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Stafflist)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_StaffOp
            // 
            this.tabControl_StaffOp.Controls.Add(this.tabPage_BasicMn);
            this.tabControl_StaffOp.Controls.Add(this.tabPage_employeeOp);
            this.tabControl_StaffOp.Location = new System.Drawing.Point(-7, 2);
            this.tabControl_StaffOp.Name = "tabControl_StaffOp";
            this.tabControl_StaffOp.SelectedIndex = 0;
            this.tabControl_StaffOp.Size = new System.Drawing.Size(1073, 681);
            this.tabControl_StaffOp.TabIndex = 1;
            // 
            // tabPage_BasicMn
            // 
            this.tabPage_BasicMn.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage_BasicMn.Controls.Add(this.label_TokenID);
            this.tabPage_BasicMn.Controls.Add(this.textBox_CustomerTokenID);
            this.tabPage_BasicMn.Controls.Add(this.button_RevenueCheck);
            this.tabPage_BasicMn.Controls.Add(this.button_RemoveCu);
            this.tabPage_BasicMn.Controls.Add(this.button_LogOut1);
            this.tabPage_BasicMn.Controls.Add(this.button_ExitMn1);
            this.tabPage_BasicMn.Controls.Add(this.button_CustomerView);
            this.tabPage_BasicMn.Controls.Add(this.dataGridView_CustomerView);
            this.tabPage_BasicMn.Controls.Add(this.panel1);
            this.tabPage_BasicMn.Controls.Add(this.textBox_Amount);
            this.tabPage_BasicMn.Controls.Add(this.label_TotalAmount);
            this.tabPage_BasicMn.Controls.Add(this.textBox_Revenue);
            this.tabPage_BasicMn.Controls.Add(this.label_Revenue);
            this.tabPage_BasicMn.Controls.Add(this.button_FORclerkID);
            this.tabPage_BasicMn.Controls.Add(this.textBox_ManagerID);
            this.tabPage_BasicMn.Controls.Add(this.label_CustomerView_Manager);
            this.tabPage_BasicMn.Controls.Add(this.label_ManagerName);
            this.tabPage_BasicMn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_BasicMn.Location = new System.Drawing.Point(4, 22);
            this.tabPage_BasicMn.Name = "tabPage_BasicMn";
            this.tabPage_BasicMn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_BasicMn.Size = new System.Drawing.Size(1065, 655);
            this.tabPage_BasicMn.TabIndex = 0;
            this.tabPage_BasicMn.Text = "BasicOP";
            // 
            // label_TokenID
            // 
            this.label_TokenID.AutoSize = true;
            this.label_TokenID.BackColor = System.Drawing.Color.Transparent;
            this.label_TokenID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TokenID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_TokenID.Location = new System.Drawing.Point(750, 430);
            this.label_TokenID.Name = "label_TokenID";
            this.label_TokenID.Size = new System.Drawing.Size(88, 24);
            this.label_TokenID.TabIndex = 56;
            this.label_TokenID.Text = "TokenID";
            this.label_TokenID.Click += new System.EventHandler(this.label_TokenID_Click);
            // 
            // textBox_CustomerTokenID
            // 
            this.textBox_CustomerTokenID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_CustomerTokenID.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CustomerTokenID.Location = new System.Drawing.Point(698, 394);
            this.textBox_CustomerTokenID.Name = "textBox_CustomerTokenID";
            this.textBox_CustomerTokenID.Size = new System.Drawing.Size(175, 33);
            this.textBox_CustomerTokenID.TabIndex = 55;
            // 
            // button_RevenueCheck
            // 
            this.button_RevenueCheck.Location = new System.Drawing.Point(15, 316);
            this.button_RevenueCheck.Name = "button_RevenueCheck";
            this.button_RevenueCheck.Size = new System.Drawing.Size(103, 35);
            this.button_RevenueCheck.TabIndex = 50;
            this.button_RevenueCheck.Text = "Check";
            this.button_RevenueCheck.UseVisualStyleBackColor = true;
            this.button_RevenueCheck.Click += new System.EventHandler(this.button_RevenueCheck_Click);
            // 
            // button_RemoveCu
            // 
            this.button_RemoveCu.Location = new System.Drawing.Point(870, 392);
            this.button_RemoveCu.Name = "button_RemoveCu";
            this.button_RemoveCu.Size = new System.Drawing.Size(103, 35);
            this.button_RemoveCu.TabIndex = 54;
            this.button_RemoveCu.Text = "Remove";
            this.button_RemoveCu.UseVisualStyleBackColor = true;
            this.button_RemoveCu.Click += new System.EventHandler(this.button_RemoveCu_Click);
            // 
            // button_LogOut1
            // 
            this.button_LogOut1.Location = new System.Drawing.Point(796, 593);
            this.button_LogOut1.Name = "button_LogOut1";
            this.button_LogOut1.Size = new System.Drawing.Size(103, 35);
            this.button_LogOut1.TabIndex = 52;
            this.button_LogOut1.Text = "Log Out";
            this.button_LogOut1.UseVisualStyleBackColor = true;
            this.button_LogOut1.Click += new System.EventHandler(this.button_LogOut1_Click);
            // 
            // button_ExitMn1
            // 
            this.button_ExitMn1.Location = new System.Drawing.Point(934, 593);
            this.button_ExitMn1.Name = "button_ExitMn1";
            this.button_ExitMn1.Size = new System.Drawing.Size(103, 35);
            this.button_ExitMn1.TabIndex = 51;
            this.button_ExitMn1.Text = "Exit";
            this.button_ExitMn1.UseVisualStyleBackColor = true;
            this.button_ExitMn1.Click += new System.EventHandler(this.button_ExitMn1_Click);
            // 
            // button_CustomerView
            // 
            this.button_CustomerView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_CustomerView.Location = new System.Drawing.Point(514, 392);
            this.button_CustomerView.Name = "button_CustomerView";
            this.button_CustomerView.Size = new System.Drawing.Size(170, 35);
            this.button_CustomerView.TabIndex = 46;
            this.button_CustomerView.Text = "Preview Customer";
            this.button_CustomerView.UseVisualStyleBackColor = false;
            this.button_CustomerView.Click += new System.EventHandler(this.button_CustomerView_Click);
            // 
            // dataGridView_CustomerView
            // 
            this.dataGridView_CustomerView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_CustomerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CustomerView.Location = new System.Drawing.Point(362, 60);
            this.dataGridView_CustomerView.Name = "dataGridView_CustomerView";
            this.dataGridView_CustomerView.Size = new System.Drawing.Size(620, 331);
            this.dataGridView_CustomerView.TabIndex = 44;
            this.dataGridView_CustomerView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CustomerView_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.textBox_TokenCheckderSal);
            this.panel1.Controls.Add(this.label_EmpSal);
            this.panel1.Controls.Add(this.textBox_ClerkSal);
            this.panel1.Controls.Add(this.label_OthersSal);
            this.panel1.Controls.Add(this.textBox_OthersInvest);
            this.panel1.Controls.Add(this.label_TockenCheckSal);
            this.panel1.Controls.Add(this.label_ClerkSal);
            this.panel1.Location = new System.Drawing.Point(22, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 242);
            this.panel1.TabIndex = 43;
            // 
            // textBox_TokenCheckderSal
            // 
            this.textBox_TokenCheckderSal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_TokenCheckderSal.Enabled = false;
            this.textBox_TokenCheckderSal.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TokenCheckderSal.Location = new System.Drawing.Point(280, 76);
            this.textBox_TokenCheckderSal.Name = "textBox_TokenCheckderSal";
            this.textBox_TokenCheckderSal.Size = new System.Drawing.Size(175, 43);
            this.textBox_TokenCheckderSal.TabIndex = 36;
            // 
            // label_EmpSal
            // 
            this.label_EmpSal.AutoSize = true;
            this.label_EmpSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EmpSal.Location = new System.Drawing.Point(151, 1);
            this.label_EmpSal.Name = "label_EmpSal";
            this.label_EmpSal.Size = new System.Drawing.Size(155, 24);
            this.label_EmpSal.TabIndex = 34;
            this.label_EmpSal.Text = "Employe Salary";
            // 
            // textBox_ClerkSal
            // 
            this.textBox_ClerkSal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_ClerkSal.Enabled = false;
            this.textBox_ClerkSal.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ClerkSal.Location = new System.Drawing.Point(9, 76);
            this.textBox_ClerkSal.Name = "textBox_ClerkSal";
            this.textBox_ClerkSal.Size = new System.Drawing.Size(175, 43);
            this.textBox_ClerkSal.TabIndex = 35;
            // 
            // label_OthersSal
            // 
            this.label_OthersSal.AutoSize = true;
            this.label_OthersSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_OthersSal.Location = new System.Drawing.Point(9, 128);
            this.label_OthersSal.Name = "label_OthersSal";
            this.label_OthersSal.Size = new System.Drawing.Size(122, 24);
            this.label_OthersSal.TabIndex = 40;
            this.label_OthersSal.Text = "Others: 15%";
            // 
            // textBox_OthersInvest
            // 
            this.textBox_OthersInvest.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_OthersInvest.Enabled = false;
            this.textBox_OthersInvest.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_OthersInvest.Location = new System.Drawing.Point(9, 155);
            this.textBox_OthersInvest.Name = "textBox_OthersInvest";
            this.textBox_OthersInvest.Size = new System.Drawing.Size(175, 43);
            this.textBox_OthersInvest.TabIndex = 37;
            // 
            // label_TockenCheckSal
            // 
            this.label_TockenCheckSal.AutoSize = true;
            this.label_TockenCheckSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TockenCheckSal.Location = new System.Drawing.Point(268, 49);
            this.label_TockenCheckSal.Name = "label_TockenCheckSal";
            this.label_TockenCheckSal.Size = new System.Drawing.Size(220, 24);
            this.label_TockenCheckSal.TabIndex = 39;
            this.label_TockenCheckSal.Text = "TockenCheckerSal:5%";
            // 
            // label_ClerkSal
            // 
            this.label_ClerkSal.AutoSize = true;
            this.label_ClerkSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ClerkSal.Location = new System.Drawing.Point(9, 49);
            this.label_ClerkSal.Name = "label_ClerkSal";
            this.label_ClerkSal.Size = new System.Drawing.Size(154, 24);
            this.label_ClerkSal.TabIndex = 38;
            this.label_ClerkSal.Text = "Clerk Salary:8%";
            // 
            // textBox_Amount
            // 
            this.textBox_Amount.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_Amount.Enabled = false;
            this.textBox_Amount.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Amount.Location = new System.Drawing.Point(11, 188);
            this.textBox_Amount.Name = "textBox_Amount";
            this.textBox_Amount.Size = new System.Drawing.Size(175, 43);
            this.textBox_Amount.TabIndex = 42;
            // 
            // label_TotalAmount
            // 
            this.label_TotalAmount.AutoSize = true;
            this.label_TotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalAmount.Location = new System.Drawing.Point(18, 161);
            this.label_TotalAmount.Name = "label_TotalAmount";
            this.label_TotalAmount.Size = new System.Drawing.Size(134, 24);
            this.label_TotalAmount.TabIndex = 41;
            this.label_TotalAmount.Text = "Total Amount";
            // 
            // textBox_Revenue
            // 
            this.textBox_Revenue.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_Revenue.Enabled = false;
            this.textBox_Revenue.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Revenue.Location = new System.Drawing.Point(12, 264);
            this.textBox_Revenue.Name = "textBox_Revenue";
            this.textBox_Revenue.Size = new System.Drawing.Size(175, 43);
            this.textBox_Revenue.TabIndex = 33;
            // 
            // label_Revenue
            // 
            this.label_Revenue.AutoSize = true;
            this.label_Revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Revenue.Location = new System.Drawing.Point(13, 237);
            this.label_Revenue.Name = "label_Revenue";
            this.label_Revenue.Size = new System.Drawing.Size(146, 24);
            this.label_Revenue.TabIndex = 32;
            this.label_Revenue.Text = "Total Revenue";
            this.label_Revenue.Click += new System.EventHandler(this.label3_Click);
            // 
            // button_FORclerkID
            // 
            this.button_FORclerkID.BackColor = System.Drawing.Color.Red;
            this.button_FORclerkID.ForeColor = System.Drawing.Color.Red;
            this.button_FORclerkID.Location = new System.Drawing.Point(187, 51);
            this.button_FORclerkID.Name = "button_FORclerkID";
            this.button_FORclerkID.Size = new System.Drawing.Size(19, 25);
            this.button_FORclerkID.TabIndex = 31;
            this.button_FORclerkID.UseVisualStyleBackColor = false;
            this.button_FORclerkID.Click += new System.EventHandler(this.button_FORclerkID_Click);
            // 
            // textBox_ManagerID
            // 
            this.textBox_ManagerID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_ManagerID.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ManagerID.Location = new System.Drawing.Point(6, 30);
            this.textBox_ManagerID.Name = "textBox_ManagerID";
            this.textBox_ManagerID.Size = new System.Drawing.Size(175, 43);
            this.textBox_ManagerID.TabIndex = 30;
            this.textBox_ManagerID.TextChanged += new System.EventHandler(this.textBox_ClerkID_TextChanged);
            // 
            // label_CustomerView_Manager
            // 
            this.label_CustomerView_Manager.AutoSize = true;
            this.label_CustomerView_Manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CustomerView_Manager.Location = new System.Drawing.Point(762, 26);
            this.label_CustomerView_Manager.Name = "label_CustomerView_Manager";
            this.label_CustomerView_Manager.Size = new System.Drawing.Size(211, 31);
            this.label_CustomerView_Manager.TabIndex = 2;
            this.label_CustomerView_Manager.Text = "Customer View";
            // 
            // label_ManagerName
            // 
            this.label_ManagerName.AutoSize = true;
            this.label_ManagerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ManagerName.Location = new System.Drawing.Point(7, 3);
            this.label_ManagerName.Name = "label_ManagerName";
            this.label_ManagerName.Size = new System.Drawing.Size(153, 24);
            this.label_ManagerName.TabIndex = 0;
            this.label_ManagerName.Text = "Manager Name";
            // 
            // tabPage_employeeOp
            // 
            this.tabPage_employeeOp.Controls.Add(this.button_Clear);
            this.tabPage_employeeOp.Controls.Add(this.button_removeTick);
            this.tabPage_employeeOp.Controls.Add(this.radioButton_TokenCheckD);
            this.tabPage_employeeOp.Controls.Add(this.radioButton_ClerkP);
            this.tabPage_employeeOp.Controls.Add(this.dataGridView_SearchBar);
            this.tabPage_employeeOp.Controls.Add(this.label9);
            this.tabPage_employeeOp.Controls.Add(this.label_StaffNewpass);
            this.tabPage_employeeOp.Controls.Add(this.label_Type);
            this.tabPage_employeeOp.Controls.Add(this.label_staffNID);
            this.tabPage_employeeOp.Controls.Add(this.label_StaffName);
            this.tabPage_employeeOp.Controls.Add(this.label_UserID);
            this.tabPage_employeeOp.Controls.Add(this.textBox_UserID);
            this.tabPage_employeeOp.Controls.Add(this.textBox_ConfirmPaswUP);
            this.tabPage_employeeOp.Controls.Add(this.textBox_NameUp);
            this.tabPage_employeeOp.Controls.Add(this.textBox_NIDUp);
            this.tabPage_employeeOp.Controls.Add(this.textBox_PassUP);
            this.tabPage_employeeOp.Controls.Add(this.button1);
            this.tabPage_employeeOp.Controls.Add(this.button6);
            this.tabPage_employeeOp.Controls.Add(this.button_RefreshEmp);
            this.tabPage_employeeOp.Controls.Add(this.button_Update);
            this.tabPage_employeeOp.Controls.Add(this.dataGridView_Stafflist);
            this.tabPage_employeeOp.Controls.Add(this.label2);
            this.tabPage_employeeOp.Controls.Add(this.textBox_search);
            this.tabPage_employeeOp.Controls.Add(this.button_removeEmp);
            this.tabPage_employeeOp.Controls.Add(this.button_AddEmp);
            this.tabPage_employeeOp.Controls.Add(this.label_Stafflist_Manager);
            this.tabPage_employeeOp.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tabPage_employeeOp.Location = new System.Drawing.Point(4, 22);
            this.tabPage_employeeOp.Name = "tabPage_employeeOp";
            this.tabPage_employeeOp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_employeeOp.Size = new System.Drawing.Size(1065, 655);
            this.tabPage_employeeOp.TabIndex = 1;
            this.tabPage_employeeOp.Text = "EmployeOP";
            this.tabPage_employeeOp.UseVisualStyleBackColor = true;
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(858, 448);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(97, 30);
            this.button_Clear.TabIndex = 71;
            this.button_Clear.Text = "Clear All";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_removeTick
            // 
            this.button_removeTick.Location = new System.Drawing.Point(973, 280);
            this.button_removeTick.Name = "button_removeTick";
            this.button_removeTick.Size = new System.Drawing.Size(80, 30);
            this.button_removeTick.TabIndex = 70;
            this.button_removeTick.Text = "RM Click";
            this.button_removeTick.UseVisualStyleBackColor = true;
            this.button_removeTick.Click += new System.EventHandler(this.button_removeTick_Click);
            // 
            // radioButton_TokenCheckD
            // 
            this.radioButton_TokenCheckD.AutoSize = true;
            this.radioButton_TokenCheckD.Location = new System.Drawing.Point(878, 283);
            this.radioButton_TokenCheckD.Name = "radioButton_TokenCheckD";
            this.radioButton_TokenCheckD.Size = new System.Drawing.Size(89, 25);
            this.radioButton_TokenCheckD.TabIndex = 69;
            this.radioButton_TokenCheckD.TabStop = true;
            this.radioButton_TokenCheckD.Text = "Demote";
            this.radioButton_TokenCheckD.UseVisualStyleBackColor = true;
            // 
            // radioButton_ClerkP
            // 
            this.radioButton_ClerkP.AutoSize = true;
            this.radioButton_ClerkP.Location = new System.Drawing.Point(778, 283);
            this.radioButton_ClerkP.Name = "radioButton_ClerkP";
            this.radioButton_ClerkP.Size = new System.Drawing.Size(94, 25);
            this.radioButton_ClerkP.TabIndex = 68;
            this.radioButton_ClerkP.TabStop = true;
            this.radioButton_ClerkP.Text = "Promote";
            this.radioButton_ClerkP.UseVisualStyleBackColor = true;
            // 
            // dataGridView_SearchBar
            // 
            this.dataGridView_SearchBar.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_SearchBar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SearchBar.Location = new System.Drawing.Point(655, 52);
            this.dataGridView_SearchBar.Name = "dataGridView_SearchBar";
            this.dataGridView_SearchBar.Size = new System.Drawing.Size(284, 72);
            this.dataGridView_SearchBar.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(560, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 25);
            this.label9.TabIndex = 66;
            this.label9.Text = "Confirm PassWord:";
            // 
            // label_StaffNewpass
            // 
            this.label_StaffNewpass.AutoSize = true;
            this.label_StaffNewpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StaffNewpass.Location = new System.Drawing.Point(597, 334);
            this.label_StaffNewpass.Name = "label_StaffNewpass";
            this.label_StaffNewpass.Size = new System.Drawing.Size(160, 25);
            this.label_StaffNewpass.TabIndex = 65;
            this.label_StaffNewpass.Text = "New Password:";
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Type.Location = new System.Drawing.Point(574, 282);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(178, 25);
            this.label_Type.TabIndex = 64;
            this.label_Type.Text = "Promote/Demote:";
            // 
            // label_staffNID
            // 
            this.label_staffNID.AutoSize = true;
            this.label_staffNID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_staffNID.Location = new System.Drawing.Point(699, 230);
            this.label_staffNID.Name = "label_staffNID";
            this.label_staffNID.Size = new System.Drawing.Size(53, 25);
            this.label_staffNID.TabIndex = 63;
            this.label_staffNID.Text = "NID:";
            // 
            // label_StaffName
            // 
            this.label_StaffName.AutoSize = true;
            this.label_StaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StaffName.Location = new System.Drawing.Point(678, 178);
            this.label_StaffName.Name = "label_StaffName";
            this.label_StaffName.Size = new System.Drawing.Size(74, 25);
            this.label_StaffName.TabIndex = 62;
            this.label_StaffName.Text = "Name:";
            // 
            // label_UserID
            // 
            this.label_UserID.AutoSize = true;
            this.label_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserID.Location = new System.Drawing.Point(382, 494);
            this.label_UserID.Name = "label_UserID";
            this.label_UserID.Size = new System.Drawing.Size(77, 25);
            this.label_UserID.TabIndex = 61;
            this.label_UserID.Text = "UserID";
            // 
            // textBox_UserID
            // 
            this.textBox_UserID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_UserID.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UserID.Location = new System.Drawing.Point(379, 445);
            this.textBox_UserID.Name = "textBox_UserID";
            this.textBox_UserID.Size = new System.Drawing.Size(175, 33);
            this.textBox_UserID.TabIndex = 60;
            this.textBox_UserID.TextChanged += new System.EventHandler(this.textBox_UserID_TextChanged);
            // 
            // textBox_ConfirmPaswUP
            // 
            this.textBox_ConfirmPaswUP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_ConfirmPaswUP.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ConfirmPaswUP.Location = new System.Drawing.Point(763, 375);
            this.textBox_ConfirmPaswUP.Name = "textBox_ConfirmPaswUP";
            this.textBox_ConfirmPaswUP.Size = new System.Drawing.Size(175, 43);
            this.textBox_ConfirmPaswUP.TabIndex = 59;
            // 
            // textBox_NameUp
            // 
            this.textBox_NameUp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_NameUp.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NameUp.Location = new System.Drawing.Point(763, 167);
            this.textBox_NameUp.Name = "textBox_NameUp";
            this.textBox_NameUp.Size = new System.Drawing.Size(175, 43);
            this.textBox_NameUp.TabIndex = 58;
            // 
            // textBox_NIDUp
            // 
            this.textBox_NIDUp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_NIDUp.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NIDUp.Location = new System.Drawing.Point(763, 219);
            this.textBox_NIDUp.Name = "textBox_NIDUp";
            this.textBox_NIDUp.Size = new System.Drawing.Size(175, 43);
            this.textBox_NIDUp.TabIndex = 57;
            // 
            // textBox_PassUP
            // 
            this.textBox_PassUP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_PassUP.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PassUP.Location = new System.Drawing.Point(764, 323);
            this.textBox_PassUP.Name = "textBox_PassUP";
            this.textBox_PassUP.Size = new System.Drawing.Size(175, 43);
            this.textBox_PassUP.TabIndex = 55;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(794, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 35);
            this.button1.TabIndex = 54;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(952, 600);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 35);
            this.button6.TabIndex = 53;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button_RefreshEmp
            // 
            this.button_RefreshEmp.Location = new System.Drawing.Point(131, 22);
            this.button_RefreshEmp.Name = "button_RefreshEmp";
            this.button_RefreshEmp.Size = new System.Drawing.Size(80, 30);
            this.button_RefreshEmp.TabIndex = 25;
            this.button_RefreshEmp.Text = "Refresh";
            this.button_RefreshEmp.UseVisualStyleBackColor = true;
            this.button_RefreshEmp.Click += new System.EventHandler(this.button_RefreshEmp_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(763, 448);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(80, 30);
            this.button_Update.TabIndex = 24;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_Stafflist
            // 
            this.dataGridView_Stafflist.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView_Stafflist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Stafflist.Location = new System.Drawing.Point(13, 52);
            this.dataGridView_Stafflist.Name = "dataGridView_Stafflist";
            this.dataGridView_Stafflist.Size = new System.Drawing.Size(541, 393);
            this.dataGridView_Stafflist.TabIndex = 23;
            this.dataGridView_Stafflist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Stafflist_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(575, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(655, 20);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(284, 29);
            this.textBox_search.TabIndex = 4;
            this.textBox_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_search_KeyPress);
            // 
            // button_removeEmp
            // 
            this.button_removeEmp.Location = new System.Drawing.Point(15, 461);
            this.button_removeEmp.Name = "button_removeEmp";
            this.button_removeEmp.Size = new System.Drawing.Size(80, 30);
            this.button_removeEmp.TabIndex = 3;
            this.button_removeEmp.Text = "Remove";
            this.button_removeEmp.UseVisualStyleBackColor = true;
            this.button_removeEmp.Click += new System.EventHandler(this.button_removeEmp_Click);
            // 
            // button_AddEmp
            // 
            this.button_AddEmp.Location = new System.Drawing.Point(13, 497);
            this.button_AddEmp.Name = "button_AddEmp";
            this.button_AddEmp.Size = new System.Drawing.Size(140, 30);
            this.button_AddEmp.TabIndex = 2;
            this.button_AddEmp.Text = "Add New User";
            this.button_AddEmp.UseVisualStyleBackColor = true;
            this.button_AddEmp.Click += new System.EventHandler(this.button_AddEmp_Click);
            // 
            // label_Stafflist_Manager
            // 
            this.label_Stafflist_Manager.AutoSize = true;
            this.label_Stafflist_Manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Stafflist_Manager.Location = new System.Drawing.Point(7, 18);
            this.label_Stafflist_Manager.Name = "label_Stafflist_Manager";
            this.label_Stafflist_Manager.Size = new System.Drawing.Size(131, 31);
            this.label_Stafflist_Manager.TabIndex = 0;
            this.label_Stafflist_Manager.Text = "Staff List";
            // 
            // Manager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.tabControl_StaffOp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manager_Form";
            this.Text = "Manager_Form";
            this.Load += new System.EventHandler(this.Manager_Form_Load);
            this.tabControl_StaffOp.ResumeLayout(false);
            this.tabPage_BasicMn.ResumeLayout(false);
            this.tabPage_BasicMn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CustomerView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage_employeeOp.ResumeLayout(false);
            this.tabPage_employeeOp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SearchBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Stafflist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_StaffOp;
        private System.Windows.Forms.TabPage tabPage_BasicMn;
        private System.Windows.Forms.Label label_CustomerView_Manager;
        private System.Windows.Forms.TabPage tabPage_employeeOp;
        private System.Windows.Forms.Label label_Stafflist_Manager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_removeEmp;
        private System.Windows.Forms.Button button_AddEmp;
        private System.Windows.Forms.Label label_ManagerName;
        private System.Windows.Forms.DataGridView dataGridView_Stafflist;
        private System.Windows.Forms.TextBox textBox_ManagerID;
        private System.Windows.Forms.Button button_FORclerkID;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_RefreshEmp;
        private System.Windows.Forms.TextBox textBox_ClerkSal;
        private System.Windows.Forms.Label label_EmpSal;
        private System.Windows.Forms.TextBox textBox_Revenue;
        private System.Windows.Forms.Label label_Revenue;
        private System.Windows.Forms.TextBox textBox_OthersInvest;
        private System.Windows.Forms.TextBox textBox_TokenCheckderSal;
        private System.Windows.Forms.DataGridView dataGridView_CustomerView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_OthersSal;
        private System.Windows.Forms.Label label_TockenCheckSal;
        private System.Windows.Forms.Label label_ClerkSal;
        private System.Windows.Forms.TextBox textBox_Amount;
        private System.Windows.Forms.Label label_TotalAmount;
        private System.Windows.Forms.Button button_CustomerView;
        private System.Windows.Forms.Button button_RemoveCu;
        private System.Windows.Forms.Button button_LogOut1;
        private System.Windows.Forms.Button button_ExitMn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button_RevenueCheck;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_StaffNewpass;
        private System.Windows.Forms.Label label_Type;
        private System.Windows.Forms.Label label_staffNID;
        private System.Windows.Forms.Label label_StaffName;
        private System.Windows.Forms.Label label_UserID;
        private System.Windows.Forms.TextBox textBox_UserID;
        private System.Windows.Forms.TextBox textBox_ConfirmPaswUP;
        private System.Windows.Forms.TextBox textBox_NameUp;
        private System.Windows.Forms.TextBox textBox_NIDUp;
        private System.Windows.Forms.TextBox textBox_PassUP;
        private System.Windows.Forms.DataGridView dataGridView_SearchBar;
        private System.Windows.Forms.Label label_TokenID;
        private System.Windows.Forms.TextBox textBox_CustomerTokenID;
        private System.Windows.Forms.RadioButton radioButton_TokenCheckD;
        private System.Windows.Forms.RadioButton radioButton_ClerkP;
        private System.Windows.Forms.Button button_removeTick;
        private System.Windows.Forms.Button button_Clear;
    }
}