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
    public class Form_Edit_DB : System.Windows.Forms.Form
    {

        public Form_Edit_DB()
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

        internal System.Windows.Forms.Button Button2;

        internal System.Windows.Forms.Button Button3;

        internal System.Windows.Forms.TextBox TextBox6;

        internal System.Windows.Forms.Button Button1;

        internal System.Windows.Forms.TextBox TextBox5;

        internal System.Windows.Forms.TextBox TextBox4;

        internal System.Windows.Forms.TextBox TextBox3;

        internal System.Windows.Forms.TextBox TextBox2;

        internal System.Windows.Forms.TextBox TextBox1;

        internal System.Windows.Forms.Label Label7;

        internal System.Windows.Forms.Label Label6;

        internal System.Windows.Forms.Label Label5;

        internal System.Windows.Forms.Label Label4;

        internal System.Windows.Forms.Label Label3;

        internal System.Windows.Forms.Label Label2;

        internal System.Windows.Forms.Label Label1;

        internal System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter1;

        internal System.Data.OleDb.OleDbConnection OleDbConnection1;

        internal VideoLocadora.DataSet1 DataSet11;

        internal System.Data.OleDb.OleDbCommand OleDbSelectCommand1;

        internal System.Data.OleDb.OleDbCommand OleDbInsertCommand1;

        internal System.Data.OleDb.OleDbCommand OleDbUpdateCommand1;

        internal System.Data.OleDb.OleDbCommand OleDbDeleteCommand1;

        internal System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter2;

        internal System.Data.OleDb.OleDbCommand OleDbDeleteCommand2;

        internal System.Data.OleDb.OleDbCommand OleDbInsertCommand2;

        internal System.Data.OleDb.OleDbCommand OleDbSelectCommand2;

        internal System.Data.OleDb.OleDbCommand OleDbUpdateCommand2;

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Edit_DB));
            this.Button4 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.DataSet11 = new VideoLocadora.DataSet1();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.OleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.OleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.OleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            this.OleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.OleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.OleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.OleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button4.Location = new System.Drawing.Point(216, 248);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(75, 23);
            this.Button4.TabIndex = 9;
            this.Button4.Text = "&Pr�ximo";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button2.Location = new System.Drawing.Point(56, 248);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 7;
            this.Button2.Text = "&Anterior";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button3.Location = new System.Drawing.Point(296, 248);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(75, 23);
            this.Button3.TabIndex = 10;
            this.Button3.Text = "&Fechar";
            this.Button3.UseVisualStyleBackColor = false;
            this.TextBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DataSet11, "Video Database.Tapes In", true));
            this.TextBox6.Location = new System.Drawing.Point(104, 208);
            this.TextBox6.MaxLength = 0;
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Size = new System.Drawing.Size(264, 20);
            this.TextBox6.TabIndex = 6;
            // 
            // DataSet11
            // 
            this.DataSet11.DataSetName = "DataSet1";
            this.DataSet11.Locale = new System.Globalization.CultureInfo("pt-BR");
            this.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button1.Location = new System.Drawing.Point(136, 248);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 8;
            this.Button1.Text = "&Salvar";
            this.Button1.UseVisualStyleBackColor = false;
            this.TextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DataSet11, "Video Database.Category", true));
            this.TextBox5.Location = new System.Drawing.Point(104, 176);
            this.TextBox5.MaxLength = 0;
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(264, 20);
            this.TextBox5.TabIndex = 5;
            // 
            // TextBox4
            // 
            this.TextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DataSet11, "Video Database.Second Cast", true));
            this.TextBox4.Location = new System.Drawing.Point(104, 144);
            this.TextBox4.MaxLength = 0;
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(264, 20);
            this.TextBox4.TabIndex = 4;
            // 
            // TextBox3
            // 
            this.TextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DataSet11, "Video Database.Main Cast", true));
            this.TextBox3.Location = new System.Drawing.Point(104, 112);
            this.TextBox3.MaxLength = 0;
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(264, 20);
            this.TextBox3.TabIndex = 3;
            // 
            // TextBox2
            // 
            this.TextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DataSet11, "Video Database.Title", true));
            this.TextBox2.Location = new System.Drawing.Point(104, 80);
            this.TextBox2.MaxLength = 0;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(264, 20);
            this.TextBox2.TabIndex = 2;
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.White;
            this.TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DataSet11, "Video Database.Video Code", true));
            this.TextBox1.Enabled = false;
            this.TextBox1.Location = new System.Drawing.Point(104, 48);
            this.TextBox1.MaxLength = 0;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(264, 20);
            this.TextBox1.TabIndex = 1;
            // 
            // Label7
            // 
            this.Label7.Font = new System.Drawing.Font("Arial", 9.75, !, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(8, 208);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(96, 23);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "No. de DVDs :";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label6
            // 
            this.Label6.Font = new System.Drawing.Font("Arial", 9.75, !, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(8, 176);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(88, 23);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Categoria:";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Arial", 9.75, !, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(8, 144);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(96, 23);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Ator Secund.";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Arial", 9.75, !, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(8, 112);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(88, 23);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "Ator Princip.";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75, !, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(8, 80);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(88, 23);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Tit. Filme::";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75, !, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(8, 48);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(88, 23);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "C�d. V�deo";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Arial", 12, !, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.Location = new System.Drawing.Point(112, 8);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(168, 23);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "EDITAR REGISTRO";
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
            // OleDbDataAdapter2
            // 
            this.OleDbDataAdapter2.DeleteCommand = this.OleDbDeleteCommand2;
            this.OleDbDataAdapter2.InsertCommand = this.OleDbInsertCommand2;
            this.OleDbDataAdapter2.SelectCommand = this.OleDbSelectCommand2;
            this.OleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                    new System.Data.Common.DataTableMapping("Table", "Video Code Database", new System.Data.Common.DataColumnMapping[] {
                                new System.Data.Common.DataColumnMapping("Title", "Title"),
                                new System.Data.Common.DataColumnMapping("Video Code", "Video Code")})});
            this.OleDbDataAdapter2.UpdateCommand = this.OleDbUpdateCommand2;
            // 
            // OleDbDeleteCommand2
            // 
            this.OleDbDeleteCommand2.CommandText = ("DELETE FROM [Video Code Database] WHERE ([Video Code] = ?) AND (Title = ? OR ? IS" + " NULL AND Title IS NULL)");
            this.OleDbDeleteCommand2.Connection = this.OleDbConnection1;
            this.OleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
                    new System.Data.OleDb.OleDbParameter("Original_Video_Code", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Video Code", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Title", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Title1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, null)});
            // 
            // OleDbInsertCommand2
            // 
            this.OleDbInsertCommand2.CommandText = "INSERT INTO [Video Code Database] (Title, [Video Code]) VALUES (?, ?)";
            this.OleDbInsertCommand2.Connection = this.OleDbConnection1;
            this.OleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
                    new System.Data.OleDb.OleDbParameter("Title", System.Data.OleDb.OleDbType.VarWChar, 30, "Title"),
                    new System.Data.OleDb.OleDbParameter("Video_Code", System.Data.OleDb.OleDbType.VarWChar, 30, "Video Code")});
            // 
            // OleDbSelectCommand2
            // 
            this.OleDbSelectCommand2.CommandText = "SELECT Title, [Video Code] FROM [Video Code Database]";
            this.OleDbSelectCommand2.Connection = this.OleDbConnection1;
            // 
            // OleDbUpdateCommand2
            // 
            this.OleDbUpdateCommand2.CommandText = ("UPDATE [Video Code Database] SET Title = ?, [Video Code] = ? WHERE ([Video Code] " + "= ?) AND (Title = ? OR ? IS NULL AND Title IS NULL)");
            this.OleDbUpdateCommand2.Connection = this.OleDbConnection1;
            this.OleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
                    new System.Data.OleDb.OleDbParameter("Title", System.Data.OleDb.OleDbType.VarWChar, 30, "Title"),
                    new System.Data.OleDb.OleDbParameter("Video_Code", System.Data.OleDb.OleDbType.VarWChar, 30, "Video Code"),
                    new System.Data.OleDb.OleDbParameter("Original_Video_Code", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Video Code", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Title", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, null),
                    new System.Data.OleDb.OleDbParameter("Original_Title1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, null)});
            // 
            // Form_Edit_DB
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(376, 287);
            this.Controls.Add(this.TextBox6);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox5);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Edit_DB";
            this.Text = "Editar Registro";
            ((System.ComponentModel.ISupportInitialize)(this.DataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Load data
        private void Form_Edit_DB_Load(object sender, System.EventArgs e)
        {
            try
            {
                TextBox2.Focus();
                DataSet11.Clear();
                OleDbDataAdapter1.Fill(DataSet11);
                this.Count();
            }
            catch (Exception ex)
            {
            }

        }

        // Previous
        private void Button2_Click(object sender, System.EventArgs e)
        {
            // TODO: On Error GoTo Warning!!!: The statement is not translatable 
            this.BindingContext(DataSet11, "Video Database").Position--;
            this.Count();
        fix:
            return;
        }

        // Save
        private void Button1_Click(object sender, System.EventArgs e)
        {
            int intResponse;
            DataRow drAddress2 = DataSet11.Video_Code_Database.NewRow;
            if ((BindingContext(DataSet11, "Video Database").Position < 0))
            {
                intResponse = MessageBox.Show("Banco de dados esta vazio !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                OleDbConnection1.Open();
                try
                {
                    int intRowSwapper = (this.BindingContext(DataSet11, "Video Database").Position - 1);
                    this.BindingContext(DataSet11, "Video Database").Position = (this.BindingContext(DataSet11, "Video Database").Position + intRowSwapper);
                    OleDbDataAdapter1.Update(DataSet11);
                    MsgBox("Dados atualizado com sucesso", MsgBoxStyle.Information, this.Text);
                    drAddress2["Video Code"] = TextBox1.Text;
                    drAddress2["Title"] = TextBox2.Text;
                    DataSet11.Tables["Video Code Database"].Rows.Add(drAddress2);
                    OleDbDataAdapter2.Update(DataSet11);
                }
                catch (System.Exception End)
                {
                    try
                    {
                        OleDbConnection1.Close();
                    }


            }

                // Next
                Button4_Click(((object)(sender)), ((System.EventArgs)(e)));
                Button4.Click;
                // TODO: On Error GoTo Warning!!!: The statement is not translatable 
                this.BindingContext(DataSet11, "Video Database").Position++;
                this.Count();
            fix:
                return;
            }

            // Close
        }

        void Button3_Click(object sender, System.EventArgs e)
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

            Button2.Enabled = enableBack;
            Button4.Enabled = enableForward;
        }
    }
}
