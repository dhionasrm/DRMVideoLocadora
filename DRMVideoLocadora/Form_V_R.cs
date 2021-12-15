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
    public class Form_V_R : System.Windows.Forms.Form
    {

        public Form_V_R()
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
        internal System.Windows.Forms.Button Button4;

        internal System.Windows.Forms.DataGrid DataGrid1;

        internal System.Windows.Forms.Button Button6;

        internal System.Windows.Forms.Button Button5;

        internal System.Windows.Forms.GroupBox GroupBox1;

        internal System.Windows.Forms.Label Label1;

        internal System.Windows.Forms.Button Button3;

        internal System.Windows.Forms.Button Button1;

        internal System.Windows.Forms.Button Button2;

        internal System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter1;

        internal System.Data.OleDb.OleDbConnection OleDbConnection1;

        internal VideoLocadora.DataSet1 DataSet11;

        internal System.Data.OleDb.OleDbCommand OleDbSelectCommand1;

        internal System.Data.OleDb.OleDbCommand OleDbInsertCommand1;

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_V_R));
            this.Button4 = new System.Windows.Forms.Button();
            this.DataGrid1 = new System.Windows.Forms.DataGrid();
            this.DataSet11 = new VideoLocadora.DataSet1();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.OleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.OleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.OleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet11)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(224, 232);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(32, 23);
            this.Button4.TabIndex = 4;
            this.Button4.Text = ">>";
            this.DataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataGrid1.DataMember = "";
            this.DataGrid1.DataSource = this.DataSet11.Rentals_Database;
            this.DataGrid1.Enabled = false;
            this.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGrid1.Location = new System.Drawing.Point(8, 8);
            this.DataGrid1.Name = "DataGrid1";
            this.DataGrid1.ReadOnly = true;
            this.DataGrid1.Size = new System.Drawing.Size(360, 216);
            this.DataGrid1.TabIndex = 0;
            // 
            // DataSet11
            // 
            this.DataSet11.DataSetName = "DataSet1";
            this.DataSet11.Locale = new System.Globalization.CultureInfo("pt-BR");
            this.DataSet11.Namespace = "http://www.tempuri.org/DataSet1.xsd";
            this.Button6.Location = new System.Drawing.Point(200, 344);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(80, 32);
            this.Button6.TabIndex = 6;
            this.Button6.Text = "&Fecha";
            this.Button5.Location = new System.Drawing.Point(104, 344);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(80, 32);
            this.Button5.TabIndex = 5;
            this.Button5.Text = "&Atualiza";
            this.GroupBox1.BackColor = System.Drawing.Color.FromArgb(((byte)(255)), ((byte)(224)), ((byte)(192)));
            this.GroupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
                    this.Label1});
            this.GroupBox1.Location = new System.Drawing.Point(8, 272);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(360, 56);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Loca��es";
            this.Label1.Location = new System.Drawing.Point(112, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(136, 23);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Rela��o das loca��es";
            this.Button3.Location = new System.Drawing.Point(192, 232);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(32, 23);
            this.Button3.TabIndex = 3;
            this.Button3.Text = ">";
            this.Button1.Location = new System.Drawing.Point(128, 232);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(32, 23);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "<<";
            this.Button2.Location = new System.Drawing.Point(160, 232);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(32, 23);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "<";
            this.OleDbDataAdapter1.InsertCommand = this.OleDbInsertCommand1;
            this.OleDbDataAdapter1.SelectCommand = this.OleDbSelectCommand1;
            this.OleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                    new System.Data.Common.DataTableMapping("Table", "Rentals Database", new System.Data.Common.DataColumnMapping[] {
                                new System.Data.Common.DataColumnMapping("Member ID", "Member ID"),
                                new System.Data.Common.DataColumnMapping("Rent Date", "Rent Date"),
                                new System.Data.Common.DataColumnMapping("Rented", "Rented"),
                                new System.Data.Common.DataColumnMapping("Video Code", "Video Code")})});
            // 
            // OleDbInsertCommand1
            // 
            this.OleDbInsertCommand1.CommandText = ("INSERT INTO [Rentals Database] ([Member ID], [Rent Date], Rented, [Video Code]) V" + "ALUES (?, ?, ?, ?)");
            this.OleDbInsertCommand1.Connection = this.OleDbConnection1;
            this.OleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Member_ID", System.Data.OleDb.OleDbType.VarWChar, 30, "Member ID"));
            this.OleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Rent_Date", System.Data.OleDb.OleDbType.DBDate, 0, "Rent Date"));
            this.OleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Rented", System.Data.OleDb.OleDbType.VarWChar, 3, "Rented"));
            this.OleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Video_Code", System.Data.OleDb.OleDbType.VarWChar, 30, "Video Code"));
            // 
            // OleDbConnection1
            // 
            this.OleDbConnection1.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Password=\"\";User ID=Admin;Data Source=D:\\locador" + ("a\\Video.mdb;Mode=Share Deny None;Extended Properties=\"\";Jet OLEDB:System databas" + ("e=\"\";Jet OLEDB:Registry Path=\"\";Jet OLEDB:Database Password=\"\";Jet OLEDB:Engine " + ("Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet" + (" OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password=\"\";Jet OLEDB:C" + ("reate System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don\'t Cop" + ("y Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLE" + "DB:SFP=False")))))));
            this.OleDbSelectCommand1.CommandText = "SELECT [Member ID], [Rent Date], Rented, [Video Code] FROM [Rentals Database]";
            this.OleDbSelectCommand1.Connection = this.OleDbConnection1;
            // 
            // Form_V_R
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((byte)(224)), ((byte)(224)), ((byte)(224)));
            this.ClientSize = new System.Drawing.Size(378, 391);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                    this.Button5,
                    this.GroupBox1,
                    this.Button3,
                    this.Button1,
                    this.Button2,
                    this.Button4,
                    this.DataGrid1,
                    this.Button6});
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_V_R";
            this.Text = "Rela��o das loca��es";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet11)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private OleDb.OleDbDataReader Read;

        // Load data
        private void Form_V_R_Load(object sender, System.EventArgs e)
        {
            DataSet11.Clear();
            OleDbDataAdapter1.Fill(DataSet11);
            // With...
            DataGrid1.CaptionText = DataSet11.Tables["Rentals Database"].DefaultView.Count.ToString;
            " Registros";
            this.Count();
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
            this.BindingContext(DataSet11, "Rentals Database").Position = 0;
            DataGrid1.UnSelect(DataGrid1.CurrentRowIndex);
            DataGrid1.CurrentRowIndex = 0;
            DataGrid1.Select(DataGrid1.CurrentRowIndex);
            this.Count();
        }

        // <
        private void Button2_Click(object sender, System.EventArgs e)
        {
            this.BindingContext(DataSet11, "Rentals Database").Position--;
            DataGrid1.UnSelect(DataGrid1.CurrentRowIndex);
            if ((DataGrid1.CurrentRowIndex > 0))
            {
                DataGrid1.CurrentRowIndex--;
            }

            DataGrid1.Select(DataGrid1.CurrentRowIndex);
            this.Count();
        }

        // >
        private void Button3_Click(object sender, System.EventArgs e)
        {
            this.BindingContext(DataSet11, "Rentals Database").Position++;
            DataGrid1.UnSelect(DataGrid1.CurrentRowIndex);
            DataGrid1.CurrentRowIndex++;
            DataGrid1.Select(DataGrid1.CurrentRowIndex);
            this.Count();
        }

        // >>
        private void Button4_Click(object sender, System.EventArgs e)
        {
            this.BindingContext(DataSet11, "Rentals Database").Position = (this.BindingContext(DataSet11, "Rentals Database").Count - 1);
            DataGrid1.UnSelect(DataGrid1.CurrentRowIndex);
            DataGrid1.CurrentRowIndex = (BindingContext(DataSet11, "Rentals Database").Count - 1);
            DataGrid1.Select(DataGrid1.CurrentRowIndex);
            this.Count();
        }

        // Refresh
        private void Button5_Click(object sender, System.EventArgs e)
        {
            DataSet11.Clear();
            OleDbDataAdapter1.Fill(DataSet11);
            DataGrid1.CurrentRowIndex = 0;
            this.Count();
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
            Records = this.BindingContext(DataSet11, "Rentals Database").Count;
            Current = (this.BindingContext(DataSet11, "Rentals Database").Position + 1);
            if ((this.BindingContext(DataSet11, "Rentals Database").Position > 0))
            {
                enableBack = true;
            }

            if ((BindingContext(DataSet11, "Rentals Database").Position
                        < (DataSet11.Rentals_Database.Count - 1)))
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
