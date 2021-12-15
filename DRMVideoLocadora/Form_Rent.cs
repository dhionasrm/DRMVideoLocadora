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
    public class Form_Rent : System.Windows.Forms.Form
    {

        public Form_Rent()
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
        internal System.Windows.Forms.Button Button1;

        internal System.Windows.Forms.TextBox TextBox2;

        internal System.Windows.Forms.Button Button3;

        internal System.Windows.Forms.GroupBox GroupBox1;

        internal System.Windows.Forms.TextBox TextBox4;

        internal System.Windows.Forms.TextBox TextBox3;

        internal System.Windows.Forms.Label Label7;

        internal System.Windows.Forms.Label Label5;

        internal System.Windows.Forms.Label Label4;

        internal System.Windows.Forms.TextBox TextBox1;

        internal System.Windows.Forms.Button Button2;

        internal System.Windows.Forms.Button Button4;

        internal System.Windows.Forms.Label Label3;

        internal System.Windows.Forms.Label Label2;

        internal System.Windows.Forms.Label Label1;

        internal System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter1;

        internal System.Data.OleDb.OleDbConnection OleDbConnection1;

        internal VideoLocadora.DataSet1 DataSet11;

        internal System.Data.OleDb.OleDbCommand OleDbCommand1;

        internal System.Data.OleDb.OleDbCommand OleDbCommand2;

        internal System.Windows.Forms.TextBox TextBox6;

        internal System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter2;

        internal System.Windows.Forms.TextBox TextBox5;

        internal System.Windows.Forms.Label Label6;

        internal System.Data.OleDb.OleDbCommand OleDbSelectCommand1;

        internal System.Data.OleDb.OleDbCommand OleDbInsertCommand1;

        internal System.Data.OleDb.OleDbCommand OleDbUpdateCommand1;

        internal System.Data.OleDb.OleDbCommand OleDbDeleteCommand1;

        internal System.Data.OleDb.OleDbCommand OleDbSelectCommand2;

        internal System.Data.OleDb.OleDbCommand OleDbInsertCommand2;

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Rent));
            this.Button1 = new System.Windows.Forms.Button();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.OleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.OleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.OleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.DataSet11 = new VideoLocadora.DataSet1();
            this.OleDbCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbCommand2 = new System.Data.OleDb.OleDbCommand();
            this.OleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            this.OleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.OleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(160, 136);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "&Verificar";
            this.TextBox2.BackColor = System.Drawing.Color.White;
            this.TextBox2.Location = new System.Drawing.Point(120, 96);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(248, 20);
            this.TextBox2.TabIndex = 2;
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(216, 360);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(75, 23);
            this.Button3.TabIndex = 5;
            this.Button3.Text = "L&impar";
            this.GroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.GroupBox1.Controls.Add(this.TextBox6);
            this.GroupBox1.Controls.Add(this.TextBox5);
            this.GroupBox1.Controls.Add(this.TextBox4);
            this.GroupBox1.Controls.Add(this.TextBox3);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Location = new System.Drawing.Point(8, 176);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(368, 168);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Status";
            this.TextBox6.BackColor = System.Drawing.Color.White;
            this.TextBox6.Enabled = false;
            this.TextBox6.Location = new System.Drawing.Point(160, 128);
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Size = new System.Drawing.Size(112, 20);
            this.TextBox6.TabIndex = 4;
            // 
            // TextBox5
            // 
            this.TextBox5.BackColor = System.Drawing.Color.White;
            this.TextBox5.Enabled = false;
            this.TextBox5.Location = new System.Drawing.Point(160, 96);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(112, 20);
            this.TextBox5.TabIndex = 3;
            // 
            // TextBox4
            // 
            this.TextBox4.BackColor = System.Drawing.Color.White;
            this.TextBox4.Enabled = false;
            this.TextBox4.Location = new System.Drawing.Point(160, 64);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(192, 20);
            this.TextBox4.TabIndex = 2;
            // 
            // TextBox3
            // 
            this.TextBox3.BackColor = System.Drawing.Color.White;
            this.TextBox3.Enabled = false;
            this.TextBox3.Location = new System.Drawing.Point(160, 32);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(192, 20);
            this.TextBox3.TabIndex = 1;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(48, 128);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(100, 23);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "Data Loca��o :";
            this.Label6.Location = new System.Drawing.Point(48, 96);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(100, 23);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "C�pias  :";
            this.Label5.Location = new System.Drawing.Point(48, 64);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(100, 23);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Cliente :";
            this.Label4.Location = new System.Drawing.Point(48, 32);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(100, 23);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "T�tulo :";
            this.TextBox1.BackColor = System.Drawing.Color.White;
            this.TextBox1.Location = new System.Drawing.Point(120, 64);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(248, 20);
            this.TextBox1.TabIndex = 1;
            // 
            // Button2
            // 
            this.Button2.Enabled = false;
            this.Button2.Location = new System.Drawing.Point(136, 360);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 4;
            this.Button2.Text = "&Locar";
            this.Button4.Location = new System.Drawing.Point(296, 360);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(75, 23);
            this.Button4.TabIndex = 6;
            this.Button4.Text = "&Cancelar";
            this.Label3.Location = new System.Drawing.Point(8, 96);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 23);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "C�d. Cliente :";
            this.Label2.Location = new System.Drawing.Point(8, 64);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 23);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "C�d. Video/DVD : ";
            this.Label1.Font = new System.Drawing.Font("Arial Black", 14.25, !, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.Location = new System.Drawing.Point(64, 8);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(272, 32);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "V�deo - DVD - LOCA��O";
            this.OleDbDataAdapter1.DeleteCommand = this.OleDbDeleteCommand1;
            this.OleDbDataAdapter1.InsertCommand = this.OleDbInsertCommand1;
            this.OleDbDataAdapter1.SelectCommand = this.OleDbSelectCommand1;
            this.OleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                    new System.Data.Common.DataTableMapping("Table", "Members Database", new System.Data.Common.DataColumnMapping[] {
                                new System.Data.Common.DataColumnMapping("Address", "Address"),
                                new System.Data.Common.DataColumnMapping("Contact", "Contact"),
                                new System.Data.Common.DataColumnMapping("First Name", "First Name"),
                                new System.Data.Common.DataColumnMapping("Last Name", "Last Name"),
                                new System.Data.Common.DataColumnMapping("Member ID", "Member ID")})});
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
            // DataSet11
            // 
            this.DataSet11.DataSetName = "DataSet1";
            this.DataSet11.Locale = new System.Globalization.CultureInfo("pt-BR");
            this.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OleDbCommand1
            // 
            this.OleDbCommand1.CommandText = "SELECT * FROM [Members Database] WHERE ([Member ID] = ?)";
            this.OleDbCommand1.Connection = this.OleDbConnection1;
            this.OleDbCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
                    new System.Data.OleDb.OleDbParameter("Member_ID", System.Data.OleDb.OleDbType.VarWChar, 30, "Member ID")});
            // 
            // OleDbCommand2
            // 
            this.OleDbCommand2.CommandText = "SELECT * FROM [Video Database] WHERE ([Video Code] = ?)";
            this.OleDbCommand2.Connection = this.OleDbConnection1;
            this.OleDbCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
                    new System.Data.OleDb.OleDbParameter("Video_Code", System.Data.OleDb.OleDbType.VarWChar, 30, "Video Code")});
            // 
            // OleDbDataAdapter2
            // 
            this.OleDbDataAdapter2.InsertCommand = this.OleDbInsertCommand2;
            this.OleDbDataAdapter2.SelectCommand = this.OleDbSelectCommand2;
            this.OleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                    new System.Data.Common.DataTableMapping("Table", "Rentals Database", new System.Data.Common.DataColumnMapping[] {
                                new System.Data.Common.DataColumnMapping("Member ID", "Member ID"),
                                new System.Data.Common.DataColumnMapping("Rent Date", "Rent Date"),
                                new System.Data.Common.DataColumnMapping("Rented", "Rented"),
                                new System.Data.Common.DataColumnMapping("Video Code", "Video Code")})});
            // 
            // OleDbInsertCommand2
            // 
            this.OleDbInsertCommand2.CommandText = ("INSERT INTO [Rentals Database] ([Member ID], [Rent Date], Rented, [Video Code]) V" + "ALUES (?, ?, ?, ?)");
            this.OleDbInsertCommand2.Connection = this.OleDbConnection1;
            this.OleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
                    new System.Data.OleDb.OleDbParameter("Member_ID", System.Data.OleDb.OleDbType.VarWChar, 30, "Member ID"),
                    new System.Data.OleDb.OleDbParameter("Rent_Date", System.Data.OleDb.OleDbType.DBDate, 0, "Rent Date"),
                    new System.Data.OleDb.OleDbParameter("Rented", System.Data.OleDb.OleDbType.VarWChar, 3, "Rented"),
                    new System.Data.OleDb.OleDbParameter("Video_Code", System.Data.OleDb.OleDbType.VarWChar, 30, "Video Code")});
            // 
            // OleDbSelectCommand2
            // 
            this.OleDbSelectCommand2.CommandText = "SELECT [Member ID], [Rent Date], Rented, [Video Code] FROM [Rentals Database]";
            this.OleDbSelectCommand2.Connection = this.OleDbConnection1;
            // 
            // Form_Rent
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(386, 399);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Rent";
            this.Text = "Loca��o";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private int a;

        private OleDb.OleDbDataReader Read;

        // Load date
        private void Form_Rent_Load(object sender, System.EventArgs e)
        {
            DateTime dtt = DateTime.Now;
            string stbTgl;
            stbTgl = dtt.ToShortDateString;
            TextBox6.Text = stbTgl;
        }

        // Check
        private void Button1_Click(object sender, System.EventArgs e)
        {
            OleDbCommand1.Parameters.Add("Member_ID", Data.OleDb.OleDbType.VarChar);
            OleDbCommand1.Parameters["Member_ID"].Value = TextBox2.Text;
            OleDbCommand2.Parameters.Add("Video_Code", Data.OleDb.OleDbType.VarChar);
            OleDbCommand2.Parameters["Video_Code"].Value = TextBox1.Text;
            OleDbConnection1.Open();
            Read = OleDbCommand1.ExecuteReader();
            this.search();
            OleDbConnection1.Close();
            OleDbConnection1.Open();
            Read = OleDbCommand2.ExecuteReader();
            this.search2();
            OleDbConnection1.Close();
            Button1.Enabled = false;
            TextBox1.Enabled = false;
            TextBox2.Enabled = false;
            TextBox3.Enabled = false;
            TextBox4.Enabled = false;
            TextBox6.Enabled = false;
        }

        private void search()
        {
            // With...
            if (Read.Read)
            {
                Button2.Enabled = true;
                TextBox4.Text = Read.GetValue;
                (2 + (" " + Read.GetValue));
                1;
            }
            else
            {
                MessageBox.Show(("C�digo Cliente : "
                                + (TextBox2.Text + " doesn\'t exit. Please enter an existing number...")), "Locadora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }

        }

        private void search2()
        {
            // With...
            if (Read.Read)
            {
                Button2.Enabled = true;
                TextBox3.Text = Read.GetValue;
                1;
                TextBox5.Text = Read.GetValue;
                5;
            }
            else
            {
                MessageBox.Show(("C�digo  : "
                                + (TextBox1.Text + " doesn\'t exit. Please enter an existing video tape...")), "Locadora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }

        }

        // Rent
        private void Button2_Click(object sender, System.EventArgs e)
        {
            DataRow drAddress = DataSet11.Rentals_Database.NewRow;
            DataRow drAddress2 = DataSet11.Video_Database.NewRow;
            if (((TextBox3.Text == "")
                        || ((TextBox4.Text == "")
                        || (TextBox5.Text == ""))))
            {
                this.Dispose();
            }
            else
            {
                OleDbConnection1.Open();
                drAddress["Member ID"] = TextBox2.Text;
                drAddress["Video Code"] = TextBox1.Text;
                drAddress["Rent Date"] = TextBox6.Text;
                drAddress["Rented"] = "Yes";
                DataSet11.Tables["Rentals Database"].Rows.Add(drAddress);
                OleDbDataAdapter2.Update(DataSet11);
                MsgBox(("Cliente "
                                + (TextBox4.Text + (" efetuou loca��o de " + TextBox3.Text))), MsgBoxStyle.Information, this.Text);
                OleDbConnection1.Close();
            }

        }

        // Clear
        private void Button3_Click(object sender, System.EventArgs e)
        {
            Button1.Enabled = true;
            Button2.Enabled = false;
            TextBox1.Enabled = true;
            TextBox2.Enabled = true;
            TextBox5.ResetText();
            TextBox1.ResetText();
            TextBox2.ResetText();
            TextBox3.ResetText();
            TextBox4.ResetText();
            TextBox1.Focus();
        }

        // Cancel
        private void Button4_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
