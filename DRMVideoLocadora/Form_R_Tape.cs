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
    Public Class Form_R_Tape
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not(components Is Nothing) Then
               components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DataSet11 As VideoLocadora.DataSet1
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form_R_Tape))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.DataSet11 = New VideoLocadora.DataSet1()
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(152, 72)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(216, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cód. do Video/DVD:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(48, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vídeo - DVD : DEVOLUÇÃO"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(216, 352)
        Me.Button3.Name = "Button3"
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "&Limpa"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(160, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&Verificar"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cod. Cliente :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.TextBox5, Me.TextBox6, Me.Label8, Me.TextBox4, Me.TextBox3, Me.Label7, Me.Label5, Me.Label4
})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 160)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status Video/DVD :"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(160, 128)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(112, 20)
        Me.TextBox5.TabIndex = 4
        Me.TextBox5.Text = ""
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.White
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(160, 96)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(112, 20)
        Me.TextBox6.TabIndex = 3
        Me.TextBox6.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(48, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Data devolução :"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(160, 64)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(192, 20)
        Me.TextBox4.TabIndex = 2
        Me.TextBox4.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(160, 32)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(192, 20)
        Me.TextBox3.TabIndex = 1
        Me.TextBox3.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(48, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Data locação :"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(48, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nome Cliente :"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(48, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Título :"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(136, 352)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "&Retorna"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(152, 104)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(216, 20)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = ""
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(296, 352)
        Me.Button4.Name = "Button4"
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "&Cancela"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() { New System.Data.Common.DataTableMapping("Table", "Members Database", New System.Data.Common.DataColumnMapping() { New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("Contact", "Contact"), New System.Data.Common.DataColumnMapping("First Name", "First Name"), New System.Data.Common.DataColumnMapping("Last Name", "Last Name"), New System.Data.Common.DataColumnMapping("Member ID", "Member ID")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM [Members Database] WHERE ([Member ID] = ?) AND (Address = ? OR ? IS N" & _
        "ULL AND Address IS NULL) AND (Contact = ? OR ? IS NULL AND Contact IS NULL) AND " & _
        "([First Name] = ? OR ? IS NULL AND [First Name] IS NULL) AND ([Last Name] = ? OR" & _
        " ? IS NULL AND [Last Name] IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Member_ID", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Member ID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Contact", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contact", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Contact1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contact", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_First_Name", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "First Name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_First_Name1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "First Name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Last_Name", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Last Name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Last_Name1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Last Name", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=D:\locador" & _
        "a\Video.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System databas" & _
        "e="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine " & _
        "Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet" & _
        " OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:C" & _
        "reate System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Cop" & _
        "y Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLE" & _
        "DB:SFP=False"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO [Members Database] (Address, Contact, [First Name], [Last Name], [Mem" & _
        "ber ID]) VALUES (?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Contact", System.Data.OleDb.OleDbType.VarWChar, 30, "Contact"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("First_Name", System.Data.OleDb.OleDbType.VarWChar, 30, "First Name"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Last_Name", System.Data.OleDb.OleDbType.VarWChar, 30, "Last Name"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Member_ID", System.Data.OleDb.OleDbType.VarWChar, 30, "Member ID"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Address, Contact, [First Name], [Last Name], [Member ID] FROM [Members Dat" & _
        "abase]"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE [Members Database] SET Address = ?, Contact = ?, [First Name] = ?, [Last N" & _
        "ame] = ?, [Member ID] = ? WHERE ([Member ID] = ?) AND (Address = ? OR ? IS NULL " & _
        "AND Address IS NULL) AND (Contact = ? OR ? IS NULL AND Contact IS NULL) AND ([Fi" & _
        "rst Name] = ? OR ? IS NULL AND [First Name] IS NULL) AND ([Last Name] = ? OR ? I" & _
        "S NULL AND [Last Name] IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Contact", System.Data.OleDb.OleDbType.VarWChar, 30, "Contact"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("First_Name", System.Data.OleDb.OleDbType.VarWChar, 30, "First Name"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Last_Name", System.Data.OleDb.OleDbType.VarWChar, 30, "Last Name"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Member_ID", System.Data.OleDb.OleDbType.VarWChar, 30, "Member ID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Member_ID", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Member ID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Contact", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contact", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Contact1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contact", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_First_Name", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "First Name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_First_Name1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "First Name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Last_Name", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Last Name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Last_Name1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Last Name", System.Data.DataRowVersion.Original, Nothing))
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.Locale = New System.Globalization.CultureInfo("pt-BR")
        Me.DataSet11.Namespace = "http://www.tempuri.org/DataSet1.xsd"
        '
        'OleDbCommand1
        '
        Me.OleDbCommand1.CommandText = "SELECT * FROM [Members Database] WHERE ([Member ID] = ?)"
        Me.OleDbCommand1.Connection = Me.OleDbConnection1
        Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Member_ID", System.Data.OleDb.OleDbType.VarWChar, 30, "Member ID"))
        '
        'OleDbCommand2
        '
        Me.OleDbCommand2.CommandText = "SELECT * FROM [Video Database] WHERE ([Video Code] = ?)"
        Me.OleDbCommand2.Connection = Me.OleDbConnection1
        Me.OleDbCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Video_Code", System.Data.OleDb.OleDbType.VarWChar, 30, "Video Code"))
        '
        'OleDbCommand3
        '
        Me.OleDbCommand3.CommandText = "SELECT * FROM [Rentals Database]"
        Me.OleDbCommand3.Connection = Me.OleDbConnection1
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() { New System.Data.Common.DataTableMapping("Table", "Returnee Database", New System.Data.Common.DataColumnMapping() { New System.Data.Common.DataColumnMapping("Member ID", "Member ID"), New System.Data.Common.DataColumnMapping("Return Date", "Return Date"), New System.Data.Common.DataColumnMapping("Returned", "Returned"), New System.Data.Common.DataColumnMapping("Video Code", "Video Code")})})
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO [Returnee Database] ([Member ID], [Return Date], Returned, [Video Cod" & _
        "e]) VALUES (?, ?, ?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Member_ID", System.Data.OleDb.OleDbType.VarWChar, 30, "Member ID"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Return_Date", System.Data.OleDb.OleDbType.DBDate, 0, "Return Date"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Returned", System.Data.OleDb.OleDbType.VarWChar, 3, "Returned"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Video_Code", System.Data.OleDb.OleDbType.VarWChar, 30, "Video Code"))
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT [Member ID], [Return Date], Returned, [Video Code] FROM [Returnee Database" & _
        "]"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'Form_R_Tape
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.ClientSize = New System.Drawing.Size(386, 391)
        Me.Controls.AddRange(New System.Windows.Forms.Control() { Me.Button2, Me.TextBox2, Me.Button4, Me.TextBox1, Me.Label2, Me.Label1, Me.Button3, Me.Button1, Me.Label3, Me.GroupBox1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_R_Tape"
        Me.Text = "Devolução "
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim a As Integer
    Dim Read As OleDb.OleDbDataReader

    'Load date
    Private Sub Form_R_Tape_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dtt As DateTime = DateTime.Now
        Dim stbTgl As String
        stbTgl = dtt.ToShortDateString
        TextBox5.Text = stbTgl
    End Sub

    'Check
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OleDbCommand1.Parameters.Add("Member_ID", Data.OleDb.OleDbType.VarChar)
        OleDbCommand1.Parameters("Member_ID").Value = TextBox2.Text
        OleDbCommand2.Parameters.Add("Video_Code", Data.OleDb.OleDbType.VarChar)
        OleDbCommand2.Parameters("Video_Code").Value = TextBox1.Text
        OleDbCommand3.Parameters.Add("Member_ID", Data.OleDb.OleDbType.VarChar)
        OleDbCommand3.Parameters("Member_ID").Value = TextBox2.Text

        OleDbConnection1.Open()
        Read = OleDbCommand1.ExecuteReader()
        search()
        OleDbConnection1.Close()

        OleDbConnection1.Open()
        Read = OleDbCommand2.ExecuteReader()
        search2()
        OleDbConnection1.Close()

        OleDbConnection1.Open()
        Read = OleDbCommand3.ExecuteReader()
        search3()
        OleDbConnection1.Close()

        Button1.Enabled = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox6.Enabled = False
        TextBox5.Enabled = False
    End Sub

    Private Sub search()
        With Read
            If .Read Then
                Button2.Enabled = True
                TextBox4.Text = .GetValue(2) &" " & .GetValue(1)
            Else
                MessageBox.Show("Membro ID : " & TextBox2.Text & " doesn't exit. Please enter an existing number...", "Locadora", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Dispose()
            End If
        End With
    End Sub

    Private Sub search2()
        With Read
            If .Read Then
                Button2.Enabled = True
                TextBox3.Text = .GetValue(1)
            Else
                MessageBox.Show("Código do Vídeo : " & TextBox1.Text & " não existe. Informe um código válido...", "Locadora", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Dispose()
            End If
        End With
    End Sub

    Private Sub search3()
        With Read
            If .Read Then
                Button2.Enabled = True
                TextBox6.Text = .GetValue(2)
            Else
                Dispose()
            End If
        End With
    End Sub

    'Return
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim drAddress As DataRow = DataSet11.Returnee_Database.NewRow

        If TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox6.Text = "" Then
            Me.Dispose()
        Else
            OleDbConnection1.Open()
            drAddress("Member ID") = TextBox2.Text
            drAddress("Video Code") = TextBox1.Text
            drAddress("Return Date") = TextBox5.Text
            drAddress("Returned") = "Yes"
            DataSet11.Tables("Returnee Database").Rows.Add(drAddress)
            OleDbDataAdapter2.Update(DataSet11)
            MsgBox("Member " & TextBox4.Text & " succesfully returned " & TextBox3.Text, MsgBoxStyle.Information, Me.Text)
            OleDbConnection1.Close()
        End If
    End Sub

    'Clear
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button1.Enabled = True
        Button2.Enabled = False
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox1.ResetText()
        TextBox2.ResetText()
        TextBox3.ResetText()
        TextBox4.ResetText()
        TextBox6.ResetText()
        TextBox1.Focus()
    End Sub

    'Cancel
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

End Class
}
