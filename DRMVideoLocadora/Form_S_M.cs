using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRMVideoLocadora
{
    public class Form_S_M : System.Windows.Forms.Form
    {

        public Form_S_M()
        {
            // This call is required by the Windows Form Designer.
            this.InitializeComponent();
            // Add any initialization after the InitializeComponent() call
        }

        // Form overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (!(components == null))
                {
                    components.Dispose();
                }

            }

            base.Dispose(disposing);
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        internal System.Windows.Forms.Button Button2;

        internal System.Windows.Forms.Button Button1;

        internal System.Windows.Forms.Label Label8;

        internal System.Windows.Forms.ComboBox ComboBox1;

        internal System.Windows.Forms.Label Label6;

        internal System.Windows.Forms.Label Label1;

        internal System.Windows.Forms.Label Label2;

        internal System.Windows.Forms.TextBox TextBox2;

        internal System.Windows.Forms.TextBox TextBox5;

        internal System.Windows.Forms.TextBox TextBox4;

        internal System.Windows.Forms.TextBox TextBox3;

        internal System.Windows.Forms.Label Label5;

        internal System.Windows.Forms.Label Label4;

        internal System.Windows.Forms.TextBox TextBox1;

        internal System.Windows.Forms.Label Label3;

        internal System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter1;

        internal System.Data.OleDb.OleDbCommand OleDbSelectCommand1;

        internal System.Data.OleDb.OleDbCommand OleDbInsertCommand1;

        internal System.Data.OleDb.OleDbCommand OleDbUpdateCommand1;

        internal System.Data.OleDb.OleDbCommand OleDbDeleteCommand1;

        internal System.Data.OleDb.OleDbConnection OleDbConnection1;

        internal VideoLocadora.DataSet1 DataSet11;

        internal System.Data.OleDb.OleDbCommand OleDbCommand1;

        internal System.Data.OleDb.OleDbCommand OleDbCommand2;

        internal System.Data.OleDb.OleDbCommand OleDbCommand3;

        internal System.Data.OleDb.OleDbCommand OleDbCommand4;

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_S_M));
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.DataSet11 = new VideoLocadora.DataSet1();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.OleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.OleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.OleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbCommand2 = new System.Data.OleDb.OleDbCommand();
            this.OleDbCommand3 = new System.Data.OleDb.OleDbCommand();
            this.OleDbCommand4 = new System.Data.OleDb.OleDbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(192, 256);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 8;
            this.Button2.Text = "&Fechar";
            this.Button1.Location = new System.Drawing.Point(104, 256);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 7;
            this.Button1.Text = "&Procurar";
            this.Label8.Font = new System.Drawing.Font("Arial", 9.75, !, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(8, 224);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(88, 23);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "Procurar por";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboBox1
            // 
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.Items.AddRange(new object[] {
                    "Sobrenome",
                    "Nome",
                    "Endere�o",
                    "Contato"});
            this.ComboBox1.Location = new System.Drawing.Point(104, 224);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(264, 21);
            this.ComboBox1.TabIndex = 6;
            // 
            // Label6
            // 
            this.Label6.Font = new System.Drawing.Font("Arial", 9.75, !, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(8, 184);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(88, 23);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "No. Contato :";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Arial", 12, !, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(128, 8);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(160, 23);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Localizar Cliente";
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75, !, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(8, 56);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(88, 23);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Membro ID :";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBox2
            // 
            this.TextBox2.BackColor = System.Drawing.Color.White;
            this.TextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DataSet11, "Members Database.Last Name", true));
            this.TextBox2.Location = new System.Drawing.Point(104, 88);
            this.TextBox2.MaxLength = 0;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.ReadOnly = true;
            this.TextBox2.Size = new System.Drawing.Size(264, 20);
            this.TextBox2.TabIndex = 2;
            // 
            // DataSet11
            // 
            this.DataSet11.DataSetName = "DataSet1";
            this.DataSet11.Locale = new System.Globalization.CultureInfo("pt-BR");
            this.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TextBox5
            // 
            this.TextBox5.BackColor = System.Drawing.Color.White;
            this.TextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DataSet11, "Members Database.Contact", true));
            this.TextBox5.Location = new System.Drawing.Point(104, 184);
            this.TextBox5.MaxLength = 0;
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.ReadOnly = true;
            this.TextBox5.Size = new System.Drawing.Size(264, 20);
            this.TextBox5.TabIndex = 5;
            // 
            // TextBox4
            // 
            this.TextBox4.BackColor = System.Drawing.Color.White;
            this.TextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DataSet11, "Members Database.Address", true));
            this.TextBox4.Location = new System.Drawing.Point(104, 152);
            this.TextBox4.MaxLength = 0;
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.ReadOnly = true;
            this.TextBox4.Size = new System.Drawing.Size(264, 20);
            this.TextBox4.TabIndex = 4;
            // 
            // TextBox3
            // 
            this.TextBox3.BackColor = System.Drawing.Color.White;
            this.TextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DataSet11, "Members Database.First Name", true));
            this.TextBox3.Location = new System.Drawing.Point(104, 120);
            this.TextBox3.MaxLength = 0;
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.ReadOnly = true;
            this.TextBox3.Size = new System.Drawing.Size(264, 20);
            this.TextBox3.TabIndex = 3;
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Arial", 9.75, !, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(8, 152);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(96, 23);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Endere�o : ";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Arial", 9.75, !, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(8, 120);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(88, 23);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "Nome :";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.White;
            this.TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DataSet11, "Members Database.Member ID", true));
            this.TextBox1.Enabled = false;
            this.TextBox1.Location = new System.Drawing.Point(104, 56);
            this.TextBox1.MaxLength = 0;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ReadOnly = true;
            this.TextBox1.Size = new System.Drawing.Size(264, 20);
            this.TextBox1.TabIndex = 1;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75, !, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(8, 88);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(88, 23);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "SobreNome :";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OleDbDataAdapter1
            // 
            this.OleDbDataAdapter1.DeleteCommand = this.OleDbDeleteCommand1;
            this.OleDbDataAdapter1.InsertCommand = this.OleDbInsertCommand1;
            this.OleDbDataAdapter1.SelectCommand = this.OleDbSelectCommand1;
            this.OleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                    new System.Data.Common.DataTableMapping("Table", "Members Database", new System.Data.Common.DataColumnMapping[] {
                                new System.Data.Common.DataColumnMapping("Member ID", "Member ID"),
                                new System.Data.Common.DataColumnMapping("Last Name", "Last Name"),
                                new System.Data.Common.DataColumnMapping("First Name", "First Name"),
                                new System.Data.Common.DataColumnMapping("Address", "Address"),
                                new System.Data.Common.DataColumnMapping("Contact", "Contact")})});
            this.OleDbDataAdapter1.UpdateCommand = this.OleDbUpdateCommand1;
            // 
            // OleDbDeleteCommand1
            // 
            this.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText");
            this.OleDbDeleteCommand1.Connection = this.OleDbConnection1;
            this.OleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
                    new System.Data.OleDb.OleDbParameter("Original_Member_ID", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Member ID", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Contact", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Contact", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Contact1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Contact", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_First_Name", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "First Name", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_First_Name1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "First Name", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Last_Name", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Last Name", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Last_Name1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Last Name", System.Data.DataRowVersion.Original, null)});
            // 
            // OleDbConnection1
            // 
            this.OleDbConnection1.ConnectionString = resources.GetString("OleDbConnection1.ConnectionString");
            // 
            // OleDbInsertCommand1
            // 
            this.OleDbInsertCommand1.CommandText = ("INSERT INTO [Members Database] (Address, Contact, [First Name], [Last Name], [Mem" + "ber ID]) VALUES (?, ?, ?, ?, ?)");
            this.OleDbInsertCommand1.Connection = this.OleDbConnection1;
            this.OleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
                    new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"),
                    new System.Data.OleDb.OleDbParameter("Contact", System.Data.OleDb.OleDbType.VarWChar, 30, "Contact"),
                    new System.Data.OleDb.OleDbParameter("First_Name", System.Data.OleDb.OleDbType.VarWChar, 30, "First Name"),
                    new System.Data.OleDb.OleDbParameter("Last_Name", System.Data.OleDb.OleDbType.VarWChar, 30, "Last Name"),
                    new System.Data.OleDb.OleDbParameter("Member_ID", System.Data.OleDb.OleDbType.VarWChar, 30, "Member ID")});
            // 
            // OleDbSelectCommand1
            // 
            this.OleDbSelectCommand1.CommandText = ("SELECT Address, Contact, [First Name], [Last Name], [Member ID] FROM [Members Dat" + "abase]");
            this.OleDbSelectCommand1.Connection = this.OleDbConnection1;
            // 
            // OleDbUpdateCommand1
            // 
            this.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText");
            this.OleDbUpdateCommand1.Connection = this.OleDbConnection1;
            this.OleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
                    new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"),
                    new System.Data.OleDb.OleDbParameter("Contact", System.Data.OleDb.OleDbType.VarWChar, 30, "Contact"),
                    new System.Data.OleDb.OleDbParameter("First_Name", System.Data.OleDb.OleDbType.VarWChar, 30, "First Name"),
                    new System.Data.OleDb.OleDbParameter("Last_Name", System.Data.OleDb.OleDbType.VarWChar, 30, "Last Name"),
                    new System.Data.OleDb.OleDbParameter("Member_ID", System.Data.OleDb.OleDbType.VarWChar, 30, "Member ID"),
                    new System.Data.OleDb.OleDbParameter("Original_Member_ID", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Member ID", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Contact", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Contact", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Contact1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Contact", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_First_Name", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "First Name", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_First_Name1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "First Name", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Last_Name", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Last Name", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Last_Name1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Last Name", System.Data.DataRowVersion.Original, null)});
            // 
            // OleDbCommand1
            // 
            this.OleDbCommand1.CommandText = "SELECT * FROM [Members Database] WHERE ([Last Name] = ?)";
            this.OleDbCommand1.Connection = this.OleDbConnection1;
            this.OleDbCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
                    new System.Data.OleDb.OleDbParameter("Last_Name", System.Data.OleDb.OleDbType.VarWChar, 30, "Last Name")});
            // 
            // OleDbCommand2
            // 
            this.OleDbCommand2.CommandText = "SELECT * FROM [Members Database] WHERE ([First Name] = ?)";
            this.OleDbCommand2.Connection = this.OleDbConnection1;
            this.OleDbCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
                    new System.Data.OleDb.OleDbParameter("First_Name", System.Data.OleDb.OleDbType.VarWChar, 30, "First Name")});
            // 
            // OleDbCommand3
            // 
            this.OleDbCommand3.CommandText = "SELECT * FROM [Members Database] WHERE (Contact = ?)";
            this.OleDbCommand3.Connection = this.OleDbConnection1;
            this.OleDbCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
                    new System.Data.OleDb.OleDbParameter("Contact", System.Data.OleDb.OleDbType.VarWChar, 30, "Contact")});
            // 
            // OleDbCommand4
            // 
            this.OleDbCommand4.CommandText = "SELECT * FROM [Members Database] WHERE (Address = ?)";
            this.OleDbCommand4.Connection = this.OleDbConnection1;
            this.OleDbCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
                    new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address")});
            // 
            // Form_S_M
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(376, 295);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox5);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_S_M";
            this.Text = "Localizar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.DataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private OleDb.OleDbDataReader Read;

        // Load data
        private void Form_S_M_Load(object sender, System.EventArgs e)
        {
            DataSet11.Clear();
            OleDbDataAdapter1.Fill(DataSet11);
        }

        // Serach
        private void Button1_Click(object sender, System.EventArgs e)
        {
            if ((ComboBox1.Text == "Sobrenome"))
            {
                a = InputBox("Informe o Sobrenome :", "Localizar", "");
                if ((a == ""))
                {
                    return;
                }

                OleDbCommand1.Parameters.Add("Last_Name", Data.OleDb.OleDbType.VarChar);
                OleDbCommand1.Parameters["Last_Name"].Value = a;
                OleDbConnection1.Open();
                Read = OleDbCommand1.ExecuteReader();
                this.search();
                OleDbConnection1.Close();
            }
            else if ((ComboBox1.Text == "Nome"))
            {
                a = InputBox("Informe o Nome :", "Encontrar", "");
                if ((a == ""))
                {
                    return;
                }

                OleDbCommand2.Parameters.Add("First_Name", Data.OleDb.OleDbType.VarChar);
                OleDbCommand2.Parameters["First_Name"].Value = a;
                OleDbConnection1.Open();
                Read = OleDbCommand2.ExecuteReader();
                this.search();
                OleDbConnection1.Close();
            }
            else if ((ComboBox1.Text == "Endereco"))
            {
                a = InputBox("Informe o endere�o :", "Localizar", "");
                if ((a == ""))
                {
                    return;
                }

                OleDbCommand4.Parameters.Add("Address", Data.OleDb.OleDbType.VarChar);
                OleDbCommand4.Parameters["Address"].Value = a;
                OleDbConnection1.Open();
                Read = OleDbCommand4.ExecuteReader();
                this.search();
                OleDbConnection1.Close();
            }
            else if ((ComboBox1.Text == "Contato"))
            {
                a = InputBox("Informe o no. de Contato :", "Procurar", "");
                if ((a == ""))
                {
                    return;
                }

                OleDbCommand3.Parameters.Add("Contact", Data.OleDb.OleDbType.VarChar);
                OleDbCommand3.Parameters["Contact Number"].Value = a;
                OleDbConnection1.Open();
                Read = OleDbCommand3.ExecuteReader();
                this.search();
                OleDbConnection1.Close();
            }

        }

        private void search()
        {
            // With...
            while (Read.Read)
            {
                TextBox1.Text = Read.GetValue;
                0;
                TextBox2.Text = Read.GetValue;
                1;
                TextBox3.Text = Read.GetValue;
                2;
                TextBox4.Text = Read.GetValue;
                3;
                TextBox5.Text = Read.GetValue;
                4;
                MsgBox("Found !!!", MsgBoxStyle.Information, this.Text);
            }

        }

        // Close
        private void Button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
