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
    public class Form_Del_M : System.Windows.Forms.Form
    {

        public Form_Del_M()
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
        internal System.Windows.Forms.Button Button5;

        internal System.Windows.Forms.Button Button6;

        internal System.Windows.Forms.GroupBox GroupBox1;

        internal System.Windows.Forms.Label Label1;

        internal System.Windows.Forms.Button Button1;

        internal System.Windows.Forms.Button Button2;

        internal System.Windows.Forms.Button Button3;

        internal System.Windows.Forms.Button Button4;

        internal System.Windows.Forms.DataGrid DataGrid1;

        internal System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter1;

        internal System.Data.OleDb.OleDbConnection OleDbConnection1;

        internal VideoLocadora.DataSet1 DataSet11;

        internal System.Data.OleDb.OleDbCommand OleDbSelectCommand1;

        internal System.Data.OleDb.OleDbCommand OleDbInsertCommand1;

        internal System.Data.OleDb.OleDbCommand OleDbUpdateCommand1;

        internal System.Data.OleDb.OleDbCommand OleDbDeleteCommand1;

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Del_M));
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.DataGrid1 = new System.Windows.Forms.DataGrid();
            this.DataSet11 = new VideoLocadora.DataSet1();
            this.OleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.OleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.OleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(136, 328);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(80, 32);
            this.Button5.TabIndex = 5;
            this.Button5.Text = "&Excluir";
            this.Button6.Location = new System.Drawing.Point(232, 328);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(80, 32);
            this.Button6.TabIndex = 6;
            this.Button6.Text = "&Fechar";
            this.GroupBox1.BackColor = System.Drawing.Color.FromArgb(((byte)(255)), ((byte)(224)), ((byte)(192)));
            this.GroupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
                    this.Label1});
            this.GroupBox1.Location = new System.Drawing.Point(8, 264);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(432, 56);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Dica";
            this.Label1.Location = new System.Drawing.Point(48, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(336, 23);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Para excluir um registro , selecione o registro e pressione Excluir";
            this.Button1.Location = new System.Drawing.Point(160, 232);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(32, 23);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "<<";
            this.Button2.Location = new System.Drawing.Point(192, 232);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(32, 23);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "<";
            this.Button3.Location = new System.Drawing.Point(224, 232);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(32, 23);
            this.Button3.TabIndex = 3;
            this.Button3.Text = ">";
            this.Button4.Location = new System.Drawing.Point(256, 232);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(32, 23);
            this.Button4.TabIndex = 4;
            this.Button4.Text = ">>";
            this.DataGrid1.AlternatingBackColor = System.Drawing.Color.GhostWhite;
            this.DataGrid1.BackColor = System.Drawing.Color.GhostWhite;
            this.DataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataGrid1.DataMember = "";
            this.DataGrid1.DataSource = this.DataSet11.Members_Database;
            this.DataGrid1.Enabled = false;
            this.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGrid1.Location = new System.Drawing.Point(8, 8);
            this.DataGrid1.Name = "DataGrid1";
            this.DataGrid1.ReadOnly = true;
            this.DataGrid1.Size = new System.Drawing.Size(432, 216);
            this.DataGrid1.TabIndex = 0;
            // 
            // DataSet11
            // 
            this.DataSet11.DataSetName = "DataSet1";
            this.DataSet11.Locale = new System.Globalization.CultureInfo("pt-BR");
            this.DataSet11.Namespace = "http://www.tempuri.org/DataSet1.xsd";
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
            this.OleDbDeleteCommand1.CommandText = ("DELETE FROM [Members Database] WHERE ([Member ID] = ?) AND (Address = ? OR ? IS N" + ("ULL AND Address IS NULL) AND (Contact = ? OR ? IS NULL AND Contact IS NULL) AND " + ("([First Name] = ? OR ? IS NULL AND [First Name] IS NULL) AND ([Last Name] = ? OR" + " ? IS NULL AND [Last Name] IS NULL)")));
            this.OleDbDeleteCommand1.Connection = this.OleDbConnection1;
            this.OleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Member_ID", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Member ID", System.Data.DataRowVersion.Original, null));
            this.OleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
            this.OleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
            this.OleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Contact", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Contact", System.Data.DataRowVersion.Original, null));
            this.OleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Contact1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Contact", System.Data.DataRowVersion.Original, null));
            this.OleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_First_Name", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "First Name", System.Data.DataRowVersion.Original, null));
            this.OleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_First_Name1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "First Name", System.Data.DataRowVersion.Original, null));
            this.OleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Last_Name", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Last Name", System.Data.DataRowVersion.Original, null));
            this.OleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Last_Name1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Last Name", System.Data.DataRowVersion.Original, null));
            // 
            // OleDbConnection1
            // 
            this.OleDbConnection1.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Password=\"\";User ID=Admin;Data Source=D:\\locador" + ("a\\Video.mdb;Mode=Share Deny None;Extended Properties=\"\";Jet OLEDB:System databas" + ("e=\"\";Jet OLEDB:Registry Path=\"\";Jet OLEDB:Database Password=\"\";Jet OLEDB:Engine " + ("Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet" + (" OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password=\"\";Jet OLEDB:C" + ("reate System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don\'t Cop" + ("y Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLE" + "DB:SFP=False")))))));
            this.OleDbInsertCommand1.CommandText = ("INSERT INTO [Members Database] (Address, Contact, [First Name], [Last Name], [Mem" + "ber ID]) VALUES (?, ?, ?, ?, ?)");
            this.OleDbInsertCommand1.Connection = this.OleDbConnection1;
            this.OleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"));
            this.OleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Contact", System.Data.OleDb.OleDbType.VarWChar, 30, "Contact"));
            this.OleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("First_Name", System.Data.OleDb.OleDbType.VarWChar, 30, "First Name"));
            this.OleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Last_Name", System.Data.OleDb.OleDbType.VarWChar, 30, "Last Name"));
            this.OleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Member_ID", System.Data.OleDb.OleDbType.VarWChar, 30, "Member ID"));
            // 
            // OleDbSelectCommand1
            // 
            this.OleDbSelectCommand1.CommandText = ("SELECT Address, Contact, [First Name], [Last Name], [Member ID] FROM [Members Dat" + "abase]");
            this.OleDbSelectCommand1.Connection = this.OleDbConnection1;
            // 
            // OleDbUpdateCommand1
            // 
            this.OleDbUpdateCommand1.CommandText = ("UPDATE [Members Database] SET Address = ?, Contact = ?, [First Name] = ?, [Last N" + ("ame] = ?, [Member ID] = ? WHERE ([Member ID] = ?) AND (Address = ? OR ? IS NULL " + ("AND Address IS NULL) AND (Contact = ? OR ? IS NULL AND Contact IS NULL) AND ([Fi" + ("rst Name] = ? OR ? IS NULL AND [First Name] IS NULL) AND ([Last Name] = ? OR ? I" + "S NULL AND [Last Name] IS NULL)"))));
            this.OleDbUpdateCommand1.Connection = this.OleDbConnection1;
            this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"));
            this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Contact", System.Data.OleDb.OleDbType.VarWChar, 30, "Contact"));
            this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("First_Name", System.Data.OleDb.OleDbType.VarWChar, 30, "First Name"));
            this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Last_Name", System.Data.OleDb.OleDbType.VarWChar, 30, "Last Name"));
            this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Member_ID", System.Data.OleDb.OleDbType.VarWChar, 30, "Member ID"));
            this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Member_ID", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Member ID", System.Data.DataRowVersion.Original, null));
            this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
            this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
            this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Contact", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Contact", System.Data.DataRowVersion.Original, null));
            this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Contact1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Contact", System.Data.DataRowVersion.Original, null));
            this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_First_Name", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "First Name", System.Data.DataRowVersion.Original, null));
            this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_First_Name1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "First Name", System.Data.DataRowVersion.Original, null));
            this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Last_Name", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Last Name", System.Data.DataRowVersion.Original, null));
            this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Last_Name1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Last Name", System.Data.DataRowVersion.Original, null));
            // 
            // Form_Del_M
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((byte)(224)), ((byte)(224)), ((byte)(224)));
            this.ClientSize = new System.Drawing.Size(450, 375);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                    this.Button1,
                    this.Button2,
                    this.Button3,
                    this.Button4,
                    this.DataGrid1,
                    this.Button5,
                    this.Button6,
                    this.GroupBox1});
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Del_M";
            this.Text = "Excluir membro";
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet11)).EndInit();
            this.ResumeLayout(false);
        }

        // Load data
        private void Form_Del_M_Load(object sender, System.EventArgs e)
        {
            DataSet11.Clear();
            OleDbDataAdapter1.Fill(DataSet11);
            this.Count();
            // With...
            DataGrid1.Refresh();
            DataGrid1.CaptionText = DataSet11.Tables["Members Database"].DefaultView.Count.ToString;
            " Registros";
            // With...
            System.Drawing.Color.Bisque.SelectionBackColor = Color.PaleGreen;
            true.AlternatingBackColor = Color.PaleGreen;
            Color.Bisque.AllowSorting = Color.PaleGreen;
            Color.Red.CaptionForeColor = Color.PaleGreen;
            BorderStyle.Fixed3D.CaptionBackColor = Color.PaleGreen;
            Color.Lavender.BorderStyle = Color.PaleGreen;
            Color.MidnightBlue.HeaderForeColor = Color.PaleGreen;
            Color.RoyalBlue.HeaderBackColor = Color.PaleGreen;
            Color.MidnightBlue.GridLineColor = Color.PaleGreen;
            Color.GhostWhite.ForeColor = Color.PaleGreen;
            Color.GhostWhite.BackColor = Color.PaleGreen;
            DataGrid1.AlternatingBackColor = Color.PaleGreen;
        }

        // <<
        private void Button1_Click(object sender, System.EventArgs e)
        {
            // TODO: On Error GoTo Warning!!!: The statement is not translatable 
            this.BindingContext(DataSet11, "Members Database").Position = 0;
            DataGrid1.UnSelect(DataGrid1.CurrentRowIndex);
            DataGrid1.CurrentRowIndex = 0;
            DataGrid1.Select(DataGrid1.CurrentRowIndex);
            this.Count();
        fix:
            return;
        }

        // <
        private void Button2_Click(object sender, System.EventArgs e)
        {
            // TODO: On Error GoTo Warning!!!: The statement is not translatable 
            this.BindingContext(DataSet11, "Members Database").Position--;
            DataGrid1.UnSelect(DataGrid1.CurrentRowIndex);
            if ((DataGrid1.CurrentRowIndex > 0))
            {
                DataGrid1.CurrentRowIndex--;
            }

            DataGrid1.Select(DataGrid1.CurrentRowIndex);
            this.Count();
        fix:
            return;
        }

        // >
        private void Button3_Click(object sender, System.EventArgs e)
        {
            // TODO: On Error GoTo Warning!!!: The statement is not translatable 
            this.BindingContext(DataSet11, "Members Database").Position++;
            DataGrid1.UnSelect(DataGrid1.CurrentRowIndex);
            DataGrid1.CurrentRowIndex++;
            DataGrid1.Select(DataGrid1.CurrentRowIndex);
            this.Count();
        fix:
            return;
        }

        // >>
        private void Button4_Click(object sender, System.EventArgs e)
        {
            // TODO: On Error GoTo Warning!!!: The statement is not translatable 
            this.BindingContext(DataSet11, "Members Database").Position = (this.BindingContext(DataSet11, "Members Database").Count - 1);
            DataGrid1.UnSelect(DataGrid1.CurrentRowIndex);
            DataGrid1.CurrentRowIndex = (BindingContext(DataSet11, "Video Database").Count - 1);
            DataGrid1.Select(DataGrid1.CurrentRowIndex);
            this.Count();
        fix:
            return;
        }

        // Delete
        private void Button5_Click(object sender, System.EventArgs e)
        {
            // TODO: On Error GoTo Warning!!!: The statement is not translatable 
            int intResponse;
            if ((BindingContext(DataSet11, "Members Database").Position < 0))
            {
                intResponse = MessageBox.Show("Banco de dados Vazio !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                intResponse = MessageBox.Show("Deseja deletar este registro ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if ((intResponse == System.Windows.Forms.MessageBoxButtons.Yes))
                {
                    OleDbConnection1.Open();
                    if ((this.BindingContext(DataSet11, "Members Database").Count > 0))
                    {
                        this.BindingContext(DataSet11, "Members Database").RemoveAt(this.BindingContext(DataSet11, "Members Database").Position);
                    }

                    OleDbDataAdapter1.Update(DataSet11);
                    // With...
                    DataGrid1.Refresh();
                    DataGrid1.CaptionText = DataSet11.Tables["Members Database"].DefaultView.Count.ToString;
                    " Registros";
                    MsgBox("Data was successfully Deleted from DataBase", MsgBoxStyle.Information, this.Text);
                    OleDbConnection1.Close();
                }

            }

        fix:
            return;
        }

        // Close
        private void Button6_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void Count()
        {
            int Records;
            int Current;
            bool enableBack = false;
            bool enableForward = false;
            Records = this.BindingContext(DataSet11, "Members Database").Count;
            Current = (this.BindingContext(DataSet11, "Members Database").Position + 1);
            if ((this.BindingContext(DataSet11, "Members Database").Position > 0))
            {
                enableBack = true;
            }

            if ((BindingContext(DataSet11, "Members Database").Position
                        < (DataSet11.Members_Database.Count - 1)))
            {
                enableForward = true;
            }

            Button1.Enabled = enableBack;
            Button2.Enabled = enableBack;
            Button3.Enabled = enableForward;
            Button4.Enabled = enableForward;
        }
    }
}
