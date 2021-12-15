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
    public class Form_V_tapes : System.Windows.Forms.Form
    {

        public Form_V_tapes()
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
        internal System.Windows.Forms.Button Button6;

        internal System.Windows.Forms.Button Button1;

        internal System.Windows.Forms.Button Button5;

        internal System.Windows.Forms.GroupBox GroupBox1;

        internal System.Windows.Forms.Label Label1;

        internal System.Windows.Forms.Button Button3;

        internal System.Windows.Forms.Button Button2;

        internal System.Windows.Forms.DataGrid DataGrid1;

        internal System.Windows.Forms.Button Button4;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_V_tapes));
            this.Button6 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.DataGrid1 = new System.Windows.Forms.DataGrid();
            this.DataSet11 = new VideoLocadora.DataSet1();
            this.Button4 = new System.Windows.Forms.Button();
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
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(280, 328);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(80, 32);
            this.Button6.TabIndex = 6;
            this.Button6.Text = "&Fecha";
            this.Button1.Location = new System.Drawing.Point(216, 224);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(32, 23);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "<<";
            this.Button5.Location = new System.Drawing.Point(192, 328);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(80, 32);
            this.Button5.TabIndex = 5;
            this.Button5.Text = "&Atualiza";
            this.GroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(8, 264);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(496, 56);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "V�deo /DVD";
            this.Label1.Location = new System.Drawing.Point(208, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(128, 23);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Rela��o de V�deos / DVDs";
            this.Button3.Location = new System.Drawing.Point(280, 224);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(32, 23);
            this.Button3.TabIndex = 3;
            this.Button3.Text = ">";
            this.Button2.Location = new System.Drawing.Point(248, 224);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(32, 23);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "<";
            this.DataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataGrid1.DataMember = "";
            this.DataGrid1.DataSource = this.DataSet11.Video_Database;
            this.DataGrid1.Enabled = false;
            this.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGrid1.Location = new System.Drawing.Point(8, 8);
            this.DataGrid1.Name = "DataGrid1";
            this.DataGrid1.ReadOnly = true;
            this.DataGrid1.Size = new System.Drawing.Size(504, 208);
            this.DataGrid1.TabIndex = 0;
            // 
            // DataSet11
            // 
            this.DataSet11.DataSetName = "DataSet1";
            this.DataSet11.Locale = new System.Globalization.CultureInfo("pt-BR");
            this.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(312, 224);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(32, 23);
            this.Button4.TabIndex = 4;
            this.Button4.Text = ">>";
            this.OleDbDataAdapter1.DeleteCommand = this.OleDbDeleteCommand1;
            this.OleDbDataAdapter1.InsertCommand = this.OleDbInsertCommand1;
            this.OleDbDataAdapter1.SelectCommand = this.OleDbSelectCommand1;
            this.OleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                    new System.Data.Common.DataTableMapping("Table", "Video Database", new System.Data.Common.DataColumnMapping[] {
                                new System.Data.Common.DataColumnMapping("Category", "Category"),
                                new System.Data.Common.DataColumnMapping("Main Cast", "Main Cast"),
                                new System.Data.Common.DataColumnMapping("Second Cast", "Second Cast"),
                                new System.Data.Common.DataColumnMapping("Tapes In", "Tapes In"),
                                new System.Data.Common.DataColumnMapping("Title", "Title"),
                                new System.Data.Common.DataColumnMapping("Video Code", "Video Code")})});
            this.OleDbDataAdapter1.UpdateCommand = this.OleDbUpdateCommand1;
            // 
            // OleDbDeleteCommand1
            // 
            this.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText");
            this.OleDbDeleteCommand1.Connection = this.OleDbConnection1;
            this.OleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
                    new System.Data.OleDb.OleDbParameter("Original_Video_Code", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Video Code", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Category", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Category", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Category1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Category", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Main_Cast", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Main Cast", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Main_Cast1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Main Cast", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Second_Cast", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Second Cast", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Second_Cast1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Second Cast", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Title", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Title1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, null)});
            // 
            // OleDbConnection1
            // 
            this.OleDbConnection1.ConnectionString = resources.GetString("OleDbConnection1.ConnectionString");
            // 
            // OleDbInsertCommand1
            // 
            this.OleDbInsertCommand1.CommandText = ("INSERT INTO [Video Database] (Category, [Main Cast], [Second Cast], [Tapes In], T" + "itle, [Video Code]) VALUES (?, ?, ?, ?, ?, ?)");
            this.OleDbInsertCommand1.Connection = this.OleDbConnection1;
            this.OleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
                    new System.Data.OleDb.OleDbParameter("Category", System.Data.OleDb.OleDbType.VarWChar, 30, "Category"),
                    new System.Data.OleDb.OleDbParameter("Main_Cast", System.Data.OleDb.OleDbType.VarWChar, 30, "Main Cast"),
                    new System.Data.OleDb.OleDbParameter("Second_Cast", System.Data.OleDb.OleDbType.VarWChar, 30, "Second Cast"),
                    new System.Data.OleDb.OleDbParameter("Tapes_In", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "Tapes In", System.Data.DataRowVersion.Current, null),
                    new System.Data.OleDb.OleDbParameter("Title", System.Data.OleDb.OleDbType.VarWChar, 30, "Title"),
                    new System.Data.OleDb.OleDbParameter("Video_Code", System.Data.OleDb.OleDbType.VarWChar, 30, "Video Code")});
            // 
            // OleDbSelectCommand1
            // 
            this.OleDbSelectCommand1.CommandText = ("SELECT Category, [Main Cast], [Second Cast], [Tapes In], Title, [Video Code] FROM" + " [Video Database]");
            this.OleDbSelectCommand1.Connection = this.OleDbConnection1;
            // 
            // OleDbUpdateCommand1
            // 
            this.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText");
            this.OleDbUpdateCommand1.Connection = this.OleDbConnection1;
            this.OleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
                    new System.Data.OleDb.OleDbParameter("Category", System.Data.OleDb.OleDbType.VarWChar, 30, "Category"),
                    new System.Data.OleDb.OleDbParameter("Main_Cast", System.Data.OleDb.OleDbType.VarWChar, 30, "Main Cast"),
                    new System.Data.OleDb.OleDbParameter("Second_Cast", System.Data.OleDb.OleDbType.VarWChar, 30, "Second Cast"),
                    new System.Data.OleDb.OleDbParameter("Tapes_In", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "Tapes In", System.Data.DataRowVersion.Current, null),
                    new System.Data.OleDb.OleDbParameter("Title", System.Data.OleDb.OleDbType.VarWChar, 30, "Title"),
                    new System.Data.OleDb.OleDbParameter("Video_Code", System.Data.OleDb.OleDbType.VarWChar, 30, "Video Code"),
                    new System.Data.OleDb.OleDbParameter("Original_Video_Code", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Video Code", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Category", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Category", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Category1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Category", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Main_Cast", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Main Cast", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Main_Cast1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Main Cast", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Second_Cast", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Second Cast", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Second_Cast1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Second Cast", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Title", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Title1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, null)});
            // 
            // Form_V_tapes
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(522, 375);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.DataGrid1);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_V_tapes";
            this.Text = "Ver Banco de dados";
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet11)).EndInit();
            this.ResumeLayout(false);
        }

        // Load data
        private void Form_V_tapes_Load(object sender, System.EventArgs e)
        {
            DataSet11.Clear();
            OleDbDataAdapter1.Fill(DataSet11);
            // With...
            DataGrid1.CaptionText = DataSet11.Tables["Video Database"].DefaultView.Count.ToString;
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
            try
            {
                this.BindingContext(DataSet11, "Video Database").Position = 0;
                DataGrid1.UnSelect(DataGrid1.CurrentRowIndex);
                DataGrid1.CurrentRowIndex = 0;
                DataGrid1.Select(DataGrid1.CurrentRowIndex);
                this.Count();
            }
            catch (Exception ex)
            {
            }

        }

        // <
        private void Button2_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.BindingContext(DataSet11, "Video Database").Position--;
                DataGrid1.UnSelect(DataGrid1.CurrentRowIndex);
                if ((DataGrid1.CurrentRowIndex > 0))
                {
                    DataGrid1.CurrentRowIndex--;
                }

                DataGrid1.Select(DataGrid1.CurrentRowIndex);
                this.Count();
            }
            catch (Exception ex)
            {
            }

        }

        // >
        private void Button3_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.BindingContext(DataSet11, "Video Database").Position++;
                DataGrid1.UnSelect(DataGrid1.CurrentRowIndex);
                DataGrid1.CurrentRowIndex++;
                DataGrid1.Select(DataGrid1.CurrentRowIndex);
                this.Count();
            }
            catch (Exception ex)
            {
            }

        }

        // >>
        private void Button4_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.BindingContext(DataSet11, "Video Database").Position = (this.BindingContext(DataSet11, "Video Database").Count - 1);
                DataGrid1.UnSelect(DataGrid1.CurrentRowIndex);
                DataGrid1.CurrentRowIndex = (BindingContext(DataSet11, "Video Database").Count - 1);
                DataGrid1.Select(DataGrid1.CurrentRowIndex);
                this.Count();
            }
            catch (Exception ex)
            {
            }

        }

        // Refresh
        private void Button5_Click(object sender, System.EventArgs e)
        {
            try
            {
                DataSet11.Clear();
                OleDbDataAdapter1.Fill(DataSet11);
                DataGrid1.CurrentRowIndex = 0;
                this.Count();
            }
            catch (Exception ex)
            {
            }

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
            Records = this.BindingContext(DataSet11, "Video Database").Count;
            Current = (this.BindingContext(DataSet11, "Video Database").Position + 1);
            if ((this.BindingContext(DataSet11, "Video Database").Position > 0))
            {
                enableBack = true;
            }

            if ((BindingContext(DataSet11, "Video Database").Position
                        < (DataSet11.Video_Database.Count - 1)))
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
