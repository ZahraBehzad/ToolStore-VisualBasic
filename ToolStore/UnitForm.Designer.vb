<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnitForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UnitForm))
        DataGridView1 = New DataGridView()
        Edit = New DataGridViewButtonColumn()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Edit})
        DataGridView1.Location = New Point(109, 70)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RightToLeft = RightToLeft.Yes
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(462, 371)
        DataGridView1.TabIndex = 1
        ' 
        ' Edit
        ' 
        Edit.HeaderText = "Choose"
        Edit.MinimumWidth = 6
        Edit.Name = "Edit"
        Edit.ReadOnly = True
        Edit.Text = "Edit"
        Edit.UseColumnTextForButtonValue = True
        Edit.Width = 125
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ControlLight
        Label1.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Label1.Location = New Point(626, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(226, 25)
        Label1.TabIndex = 2
        Label1.Text = "*If you want to submit a new unit, "
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Dubai", 9F, FontStyle.Bold)
        TextBox1.Location = New Point(626, 243)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(110, 33)
        TextBox1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ControlLightLight
        Button1.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleRight
        Button1.Location = New Point(627, 282)
        Button1.Name = "Button1"
        Button1.Size = New Size(109, 54)
        Button1.TabIndex = 4
        Button1.Text = "Submit"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ControlLight
        Label2.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Label2.Location = New Point(626, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(379, 25)
        Label2.TabIndex = 5
        Label2.Text = " please write its name and then press the ""Submit"" button."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ControlLight
        Label3.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Label3.Location = New Point(626, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(318, 25)
        Label3.TabIndex = 6
        Label3.Text = " *If you want to edit the name of an existing unit,"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ControlLight
        Label4.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Label4.Location = New Point(626, 145)
        Label4.Name = "Label4"
        Label4.Size = New Size(466, 25)
        Label4.TabIndex = 7
        Label4.Text = "press the corresponding ""Edit"" button for that unit, make your changes,"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ControlLight
        Label5.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Label5.Location = New Point(626, 170)
        Label5.Name = "Label5"
        Label5.Size = New Size(240, 25)
        Label5.TabIndex = 8
        Label5.Text = "and then press the ""Submit"" button."
        ' 
        ' UnitForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1086, 713)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Font = New Font("Arial Narrow", 9F)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(898, 760)
        Name = "UnitForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "unit"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents Label5 As Label
End Class
