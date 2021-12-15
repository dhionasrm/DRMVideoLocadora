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
    public class Form_Add_M : System.Windows.Forms.Form
    {

        public Form_Add_M()
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
        internal System.Windows.Forms.TextBox TextBox2;

        internal System.Windows.Forms.Button Button2;

        internal System.Windows.Forms.Button Button1;

        internal System.Windows.Forms.TextBox TextBox4;

        internal System.Windows.Forms.TextBox TextBox3;

        internal System.Windows.Forms.TextBox TextBox1;

        internal System.Windows.Forms.Label Label3;

        internal System.Windows.Forms.TextBox TextBox5;

        internal System.Windows.Forms.Label Label5;

        internal System.Windows.Forms.Label Label4;

        internal System.Windows.Forms.Label Label2;

        internal System.Windows.Forms.Label Label1;

        internal System.Windows.Forms.Button Button3;

        internal System.Windows.Forms.Label Label6;

        internal System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter1;

        internal System.Data.OleDb.OleDbConnection OleDbConnection1;

        internal VideoLocadora.DataSet1 DataSet11;

        internal System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter2;

        internal System.Data.OleDb.OleDbCommand OleDbSelectCommand1;

        internal System.Data.OleDb.OleDbCommand OleDbInsertCommand1;

        internal System.Data.OleDb.OleDbCommand OleDbUpdateCommand1;

        internal System.Data.OleDb.OleDbCommand OleDbDeleteCommand1;

        internal System.Data.OleDb.OleDbCommand OleDbSelectCommand2;

        internal System.Data.OleDb.OleDbCommand OleDbInsertCommand2;

        internal System.Data.OleDb.OleDbCommand OleDbUpdateCommand2;

        internal System.Data.OleDb.OleDbCommand OleDbDeleteCommand2;

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Add_M));
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button3 = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.OleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.OleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.OleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.DataSet11 = new VideoLocadora.DataSet1();
            this.OleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            this.OleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.OleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.OleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.OleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(104, 96);
            this.TextBox2.MaxLength = 0;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(264, 20);
            this.TextBox2.TabIndex = 2;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(200, 224);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 7;
            this.Button2.Text = "&Limpar";
            this.Button1.Location = new System.Drawing.Point(112, 224);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 6;
            this.Button1.Text = "&Salvar";
            this.TextBox4.Location = new System.Drawing.Point(104, 160);
            this.TextBox4.MaxLength = 0;
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(264, 20);
            this.TextBox4.TabIndex = 4;
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(104, 128);
            this.TextBox3.MaxLength = 0;
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(264, 20);
            this.TextBox3.TabIndex = 3;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(104, 64);
            this.TextBox1.MaxLength = 0;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(264, 20);
            this.TextBox1.TabIndex = 1;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75, !, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(8, 96);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(88, 23);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Sobrenome :";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBox5
            // 
            this.TextBox5.Location = new System.Drawing.Point(104, 192);
            this.TextBox5.MaxLength = 0;
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(264, 20);
            this.TextBox5.TabIndex = 5;
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Arial", 9.75, !, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(8, 160);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(96, 23);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Endere�o :";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Arial", 9.75, !, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(8, 128);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(88, 23);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "Nome : ";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75, !, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(8, 64);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(88, 23);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Membro ID:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Arial", 12, !, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.Location = new System.Drawing.Point(128, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(144, 23);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "NOVO MEMBRO";
            this.Button3.Location = new System.Drawing.Point(288, 224);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(75, 23);
            this.Button3.TabIndex = 8;
            this.Button3.Text = "&Fechar";
            this.Label6.Font = new System.Drawing.Font("Arial", 9.75, !, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(8, 192);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(88, 23);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "No. Contato :";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OleDbDataAdapter1
            // 
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
            // OleDbDataAdapter2
            // 
            this.OleDbDataAdapter2.DeleteCommand = this.OleDbDeleteCommand2;
            this.OleDbDataAdapter2.InsertCommand = this.OleDbInsertCommand2;
            this.OleDbDataAdapter2.SelectCommand = this.OleDbSelectCommand2;
            this.OleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                    new System.Data.Common.DataTableMapping("Table", "Member Code Database", new System.Data.Common.DataColumnMapping[] {
                                new System.Data.Common.DataColumnMapping("Member ID", "Member ID"),
                                new System.Data.Common.DataColumnMapping("Member Name", "Member Name")})});
            this.OleDbDataAdapter2.UpdateCommand = this.OleDbUpdateCommand2;
            // 
            // OleDbDeleteCommand2
            // 
            this.OleDbDeleteCommand2.CommandText = ("DELETE FROM [Member Code Database] WHERE ([Member ID] = ?) AND ([Member Name] = ?" + " OR ? IS NULL AND [Member Name] IS NULL)");
            this.OleDbDeleteCommand2.Connection = this.OleDbConnection1;
            this.OleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
                    new System.Data.OleDb.OleDbParameter("Original_Member_ID", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Member ID", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Member_Name", System.Data.OleDb.OleDbType.VarWChar, 62, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Member Name", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Member_Name1", System.Data.OleDb.OleDbType.VarWChar, 62, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Member Name", System.Data.DataRowVersion.Original, null)});
            // 
            // OleDbInsertCommand2
            // 
            this.OleDbInsertCommand2.CommandText = "INSERT INTO [Member Code Database] ([Member ID], [Member Name]) VALUES (?, ?)";
            this.OleDbInsertCommand2.Connection = this.OleDbConnection1;
            this.OleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
                    new System.Data.OleDb.OleDbParameter("Member_ID", System.Data.OleDb.OleDbType.VarWChar, 30, "Member ID"),
                    new System.Data.OleDb.OleDbParameter("Member_Name", System.Data.OleDb.OleDbType.VarWChar, 62, "Member Name")});
            // 
            // OleDbSelectCommand2
            // 
            this.OleDbSelectCommand2.CommandText = "SELECT [Member ID], [Member Name] FROM [Member Code Database]";
            this.OleDbSelectCommand2.Connection = this.OleDbConnection1;
            // 
            // OleDbUpdateCommand2
            // 
            this.OleDbUpdateCommand2.CommandText = ("UPDATE [Member Code Database] SET [Member ID] = ?, [Member Name] = ? WHERE ([Memb" + "er ID] = ?) AND ([Member Name] = ? OR ? IS NULL AND [Member Name] IS NULL)");
            this.OleDbUpdateCommand2.Connection = this.OleDbConnection1;
            this.OleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
                    new System.Data.OleDb.OleDbParameter("Member_ID", System.Data.OleDb.OleDbType.VarWChar, 30, "Member ID"),
                    new System.Data.OleDb.OleDbParameter("Member_Name", System.Data.OleDb.OleDbType.VarWChar, 62, "Member Name"),
                    new System.Data.OleDb.OleDbParameter("Original_Member_ID", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Member ID", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Member_Name", System.Data.OleDb.OleDbType.VarWChar, 62, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Member Name", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Member_Name1", System.Data.OleDb.OleDbType.VarWChar, 62, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Member Name", System.Data.DataRowVersion.Original, null)});
            // 
            // Form_Add_M
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(376, 263);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TextBox5);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Add_M";
            this.Text = "Incluir novo membro";
            ((System.ComponentModel.ISupportInitialize)(this.DataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Save
        private void Button1_Click(object sender, System.EventArgs e)
        {
            DataRow drAddress = DataSet11.Members_Database.NewRow;
            DataRow drAddress2 = DataSet11.Member_Code_Database.NewRow;
            if ((TextBox1.Text.Length == 0))
            {
                MsgBox("C�digo do membro esta vazio", vbExclamation);
                TextBox1.Focus();
                return;
            }
            else if ((TextBox2.Text.Length == 0))
            {
                MsgBox("Sobrenome esta vazio", vbExclamation);
                TextBox2.Focus();
                return;
            }
            else if ((TextBox3.Text.Length == 0))
            {
                MsgBox("Nome esta vazio", vbExclamation);
                TextBox3.Focus();
                return;
            }
            else if ((TextBox4.Text.Length == 0))
            {
                MsgBox("Endere�o esta vazio", vbExclamation);
                TextBox4.Focus();
                return;
            }
            else if ((TextBox5.Text.Length == 0))
            {
                MsgBox("No. Contato esta vazio", vbExclamation);
                TextBox5.Focus();
                return;
            }

            OleDbConnection1.Open();
            try
            {
                drAddress["Member ID"] = TextBox1.Text;
                drAddress["Last Name"] = TextBox2.Text;
                drAddress["First Name"] = TextBox3.Text;
                drAddress["Address"] = TextBox4.Text;
                drAddress["Contact"] = TextBox5.Text;
                drAddress2["Member ID"] = TextBox1.Text;
                drAddress2["Member Name"] = (TextBox3.Text + (" " + TextBox2.Text));
                DataSet11.Tables["Members Database"].Rows.Add(drAddress);
                DataSet11.Tables["Member Code Database"].Rows.Add(drAddress2);
                OleDbDataAdapter1.Update(DataSet11);
                OleDbDataAdapter2.Update(DataSet11);
                MsgBox("Data Was SuccessFully Added To The DataBase", MsgBoxStyle.Information, this.Text);
                TextBox1.Focus();
            }
            catch (System.Exception MessageBox.Show) {
                "O ID do membro ja existe no banco de dados, escolha outro ID...";
                "Locadora";
                MessageBoxButtons.OK;
                MessageBoxIcon.Exclamation;
                TextBox1.SelectionStart = 0;
                TextBox1.SelectionLength = TextBox1.Text.Length;
                TextBox1.Focus();
                drAddress.Delete();
                DataSet11.Clear();
            }

            OleDbConnection1.Close();
            }

            // Clear
            private void Button2_Click(object sender, System.EventArgs e)
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox1.Focus();
            }

            // Close
            private void Button3_Click(object sender, System.EventArgs e)
            {
                this.Close();
            }
        }
    }
