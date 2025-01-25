<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addCustomer
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addCustomer))
        Label1 = New Label()
        Label2 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        ComboBox1 = New ComboBox()
        RichTextBox1 = New RichTextBox()
        Button2 = New Button()
        Button1 = New Button()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Label1.Location = New Point(754, 162)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 25)
        Label1.TabIndex = 0
        Label1.Text = "code"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Label2.Location = New Point(754, 223)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 25)
        Label2.TabIndex = 1
        Label2.Text = "name"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Label9.Location = New Point(754, 66)
        Label9.Name = "Label9"
        Label9.Size = New Size(44, 25)
        Label9.TabIndex = 12
        Label9.Text = "Time"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Label8.Location = New Point(898, 66)
        Label8.Name = "Label8"
        Label8.Size = New Size(39, 25)
        Label8.TabIndex = 11
        Label8.Text = "4:11"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Label3.Location = New Point(880, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 25)
        Label3.TabIndex = 10
        Label3.Text = "2025-9-12"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Label4.Location = New Point(754, 32)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 25)
        Label4.TabIndex = 9
        Label4.Text = "Date"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Label5.Location = New Point(754, 290)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 25)
        Label5.TabIndex = 13
        Label5.Text = "gender"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Label6.Location = New Point(754, 366)
        Label6.Name = "Label6"
        Label6.Size = New Size(32, 25)
        Label6.TabIndex = 14
        Label6.Text = "tel."
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Label7.Location = New Point(748, 423)
        Label7.Name = "Label7"
        Label7.Size = New Size(62, 25)
        Label7.TabIndex = 15
        Label7.Text = "address"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Right
        TextBox1.Font = New Font("Dubai", 9F)
        TextBox1.Location = New Point(823, 162)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(205, 33)
        TextBox1.TabIndex = 16
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Right
        TextBox2.Font = New Font("Dubai", 9F)
        TextBox2.Location = New Point(823, 222)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(205, 33)
        TextBox2.TabIndex = 17
        ' 
        ' TextBox3
        ' 
        TextBox3.Anchor = AnchorStyles.Right
        TextBox3.Font = New Font("Dubai", 9F)
        TextBox3.Location = New Point(823, 366)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(205, 33)
        TextBox3.TabIndex = 18
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.Right
        ComboBox1.Font = New Font("Dubai", 9F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"female", "male"})
        ComboBox1.Location = New Point(823, 288)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(205, 33)
        ComboBox1.TabIndex = 19
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Anchor = AnchorStyles.Right
        RichTextBox1.Location = New Point(823, 423)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(205, 108)
        RichTextBox1.TabIndex = 20
        RichTextBox1.Text = ""
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Right
        Button2.BackColor = SystemColors.ControlLightLight
        Button2.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.MiddleRight
        Button2.Location = New Point(940, 600)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(113, 61)
        Button2.TabIndex = 27
        Button2.Text = "cancel"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Right
        Button1.BackColor = SystemColors.ControlLightLight
        Button1.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleRight
        Button1.Location = New Point(804, 600)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(113, 61)
        Button1.TabIndex = 26
        Button1.Text = "submit"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        ' 
        ' addCustomer
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1132, 802)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(RichTextBox1)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Arial", 9F, FontStyle.Bold)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "addCustomer"
        StartPosition = FormStartPosition.CenterScreen
        Text = "add new customer"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
End Class
