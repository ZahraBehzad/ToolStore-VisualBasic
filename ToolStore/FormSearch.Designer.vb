<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSearch
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSearch))
        DataGridView1 = New DataGridView()
        Edit = New DataGridViewButtonColumn()
        Delete = New DataGridViewButtonColumn()
        ToolStrip1 = New ToolStrip()
        ToolStripLabel1 = New ToolStripLabel()
        ToolStripComboBox1 = New ToolStripComboBox()
        ToolStripSeparator1 = New ToolStripSeparator()
        ToolStripLabel2 = New ToolStripLabel()
        ToolStripTextBox1 = New ToolStripTextBox()
        ToolStripButton1 = New ToolStripButton()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.LightSteelBlue
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.BackgroundColor = Color.Lavender
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Edit, Delete})
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 28)
        DataGridView1.Margin = New Padding(2, 3, 2, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(880, 685)
        DataGridView1.TabIndex = 2
        ' 
        ' Edit
        ' 
        Edit.HeaderText = "choose"
        Edit.MinimumWidth = 6
        Edit.Name = "Edit"
        Edit.ReadOnly = True
        Edit.Text = "Edit"
        Edit.UseColumnTextForButtonValue = True
        Edit.Width = 50
        ' 
        ' Delete
        ' 
        Delete.HeaderText = "choose"
        Delete.MinimumWidth = 6
        Delete.Name = "Delete"
        Delete.ReadOnly = True
        Delete.Text = "delete"
        Delete.UseColumnTextForButtonValue = True
        Delete.Width = 45
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.BackColor = Color.MediumSlateBlue
        ToolStrip1.Font = New Font("Dubai", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ToolStrip1.ImageScalingSize = New Size(20, 20)
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripLabel1, ToolStripComboBox1, ToolStripSeparator1, ToolStripLabel2, ToolStripTextBox1, ToolStripButton1})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(880, 28)
        ToolStrip1.TabIndex = 3
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripLabel1
        ' 
        ToolStripLabel1.ForeColor = SystemColors.ButtonHighlight
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.Size = New Size(62, 25)
        ToolStripLabel1.Text = "filterby:"
        ' 
        ' ToolStripComboBox1
        ' 
        ToolStripComboBox1.ForeColor = Color.MidnightBlue
        ToolStripComboBox1.Items.AddRange(New Object() {"product name", "product code", "product size"})
        ToolStripComboBox1.Name = "ToolStripComboBox1"
        ToolStripComboBox1.Size = New Size(107, 28)
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 28)
        ' 
        ' ToolStripLabel2
        ' 
        ToolStripLabel2.ForeColor = SystemColors.ButtonHighlight
        ToolStripLabel2.Name = "ToolStripLabel2"
        ToolStripLabel2.Size = New Size(57, 25)
        ToolStripLabel2.Text = "search:"
        ' 
        ' ToolStripTextBox1
        ' 
        ToolStripTextBox1.ForeColor = Color.MidnightBlue
        ToolStripTextBox1.Name = "ToolStripTextBox1"
        ToolStripTextBox1.Size = New Size(88, 28)
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New Size(29, 25)
        ToolStripButton1.Text = "ToolStripButton1"
        ' 
        ' FormSearch
        ' 
        AutoScaleDimensions = New SizeF(7F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(880, 713)
        Controls.Add(DataGridView1)
        Controls.Add(ToolStrip1)
        Font = New Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2, 3, 2, 3)
        MinimumSize = New Size(898, 760)
        Name = "FormSearch"
        StartPosition = FormStartPosition.CenterScreen
        Text = "search"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
End Class
