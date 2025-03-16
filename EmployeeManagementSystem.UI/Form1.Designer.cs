namespace EmployeeManagementSystem.UI;

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
        dataGridView1 = new DataGridView();
        groupBox1 = new GroupBox();
        txtSalary = new TextBox();
        label8 = new Label();
        txtDepartment = new TextBox();
        label7 = new Label();
        dtpHireDate = new DateTimePicker();
        label6 = new Label();
        dtpDateOfBirth = new DateTimePicker();
        label5 = new Label();
        txtPhone = new TextBox();
        label4 = new Label();
        txtEmail = new TextBox();
        label3 = new Label();
        txtLastName = new TextBox();
        label2 = new Label();
        txtFirstName = new TextBox();
        label1 = new Label();
        btnAdd = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        
        // 
        // dataGridView1
        // 
        dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(12, 250);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(776, 188);
        dataGridView1.TabIndex = 0;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(txtSalary);
        groupBox1.Controls.Add(label8);
        groupBox1.Controls.Add(txtDepartment);
        groupBox1.Controls.Add(label7);
        groupBox1.Controls.Add(dtpHireDate);
        groupBox1.Controls.Add(label6);
        groupBox1.Controls.Add(dtpDateOfBirth);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(txtPhone);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(txtEmail);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(txtLastName);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(txtFirstName);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(776, 191);
        groupBox1.TabIndex = 1;
        groupBox1.Text = "Employee Details";
        
        // Labels and TextBoxes
        label1.AutoSize = true;
        label1.Location = new Point(20, 30);
        label1.Name = "label1";
        label1.Size = new Size(64, 15);
        label1.Text = "First Name:";
        
        txtFirstName.Location = new Point(90, 27);
        txtFirstName.Name = "txtFirstName";
        txtFirstName.Size = new Size(200, 23);
        
        label2.AutoSize = true;
        label2.Location = new Point(20, 60);
        label2.Name = "label2";
        label2.Size = new Size(64, 15);
        label2.Text = "Last Name:";
        
        txtLastName.Location = new Point(90, 57);
        txtLastName.Name = "txtLastName";
        txtLastName.Size = new Size(200, 23);
        
        label3.AutoSize = true;
        label3.Location = new Point(20, 90);
        label3.Name = "label3";
        label3.Size = new Size(39, 15);
        label3.Text = "Email:";
        
        txtEmail.Location = new Point(90, 87);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(200, 23);
        
        label4.AutoSize = true;
        label4.Location = new Point(20, 120);
        label4.Name = "label4";
        label4.Size = new Size(44, 15);
        label4.Text = "Phone:";
        
        txtPhone.Location = new Point(90, 117);
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new Size(200, 23);
        
        label5.AutoSize = true;
        label5.Location = new Point(320, 30);
        label5.Name = "label5";
        label5.Size = new Size(76, 15);
        label5.Text = "Date of Birth:";
        
        dtpDateOfBirth.Location = new Point(400, 27);
        dtpDateOfBirth.Name = "dtpDateOfBirth";
        dtpDateOfBirth.Size = new Size(200, 23);
        
        label6.AutoSize = true;
        label6.Location = new Point(320, 60);
        label6.Name = "label6";
        label6.Size = new Size(61, 15);
        label6.Text = "Hire Date:";
        
        dtpHireDate.Location = new Point(400, 57);
        dtpHireDate.Name = "dtpHireDate";
        dtpHireDate.Size = new Size(200, 23);
        
        label7.AutoSize = true;
        label7.Location = new Point(320, 90);
        label7.Name = "label7";
        label7.Size = new Size(73, 15);
        label7.Text = "Department:";
        
        txtDepartment.Location = new Point(400, 87);
        txtDepartment.Name = "txtDepartment";
        txtDepartment.Size = new Size(200, 23);
        
        label8.AutoSize = true;
        label8.Location = new Point(320, 120);
        label8.Name = "label8";
        label8.Size = new Size(41, 15);
        label8.Text = "Salary:";
        
        txtSalary.Location = new Point(400, 117);
        txtSalary.Name = "txtSalary";
        txtSalary.Size = new Size(200, 23);
        
        // Buttons
        btnAdd.Location = new Point(12, 209);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(75, 23);
        btnAdd.TabIndex = 2;
        btnAdd.Text = "Add";
        btnAdd.Click += btnAdd_Click;
        
        btnUpdate.Location = new Point(93, 209);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(75, 23);
        btnUpdate.TabIndex = 3;
        btnUpdate.Text = "Update";
        btnUpdate.Click += btnUpdate_Click;
        
        btnDelete.Location = new Point(174, 209);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(75, 23);
        btnDelete.TabIndex = 4;
        btnDelete.Text = "Delete";
        btnDelete.Click += btnDelete_Click;
        
        // Form
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnDelete);
        Controls.Add(btnUpdate);
        Controls.Add(btnAdd);
        Controls.Add(groupBox1);
        Controls.Add(dataGridView1);
        Name = "Form1";
        Text = "Employee Management System";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridView1;
    private GroupBox groupBox1;
    private TextBox txtSalary;
    private Label label8;
    private TextBox txtDepartment;
    private Label label7;
    private DateTimePicker dtpHireDate;
    private Label label6;
    private DateTimePicker dtpDateOfBirth;
    private Label label5;
    private TextBox txtPhone;
    private Label label4;
    private TextBox txtEmail;
    private Label label3;
    private TextBox txtLastName;
    private Label label2;
    private TextBox txtFirstName;
    private Label label1;
    private Button btnAdd;
    private Button btnUpdate;
    private Button btnDelete;
}
