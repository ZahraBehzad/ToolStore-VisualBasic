<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sell
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sell))
        Timer1 = New Timer(components)
        Label9 = New Label()
        Label8 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        TextBox1 = New TextBox()
        Label10 = New Label()
        ComboBox3 = New ComboBox()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Label9.Location = New Point(844, 176)
        Label9.Name = "Label9"
        Label9.Size = New Size(44, 25)
        Label9.TabIndex = 16
        Label9.Text = "Time"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Label8.Location = New Point(944, 176)
        Label8.Name = "Label8"
        Label8.Size = New Size(39, 25)
        Label8.TabIndex = 15
        Label8.Text = "4:11"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Label3.Location = New Point(924, 141)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 25)
        Label3.TabIndex = 14
        Label3.Text = "2025-9-12"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Label4.Location = New Point(844, 141)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 25)
        Label4.TabIndex = 13
        Label4.Text = "Date"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Label1.Location = New Point(825, 247)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 25)
        Label1.TabIndex = 17
        Label1.Text = "customer"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Label2.Location = New Point(836, 292)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 25)
        Label2.TabIndex = 18
        Label2.Text = "product"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Label5.Location = New Point(837, 339)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 25)
        Label5.TabIndex = 19
        Label5.Text = "amount"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Label6.Location = New Point(856, 387)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 25)
        Label6.TabIndex = 20
        Label6.Text = "price"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Label7.Location = New Point(773, 435)
        Label7.Name = "Label7"
        Label7.Size = New Size(119, 25)
        Label7.TabIndex = 21
        Label7.Text = "payment method"
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Right
        Button2.BackColor = SystemColors.ControlLightLight
        Button2.Font = New Font("Dubai", 9F, FontStyle.Bold)
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.MiddleRight
        Button2.Location = New Point(982, 571)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(123, 48)
        Button2.TabIndex = 29
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
        Button1.Location = New Point(844, 571)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(123, 48)
        Button1.TabIndex = 28
        Button1.Text = "submit"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.Right
        ComboBox1.Font = New Font("Dubai", 9F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(914, 244)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(169, 33)
        ComboBox1.TabIndex = 30
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Anchor = AnchorStyles.Right
        ComboBox2.Font = New Font("Dubai", 9F)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(914, 289)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(169, 33)
        ComboBox2.TabIndex = 31
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Right
        TextBox1.Font = New Font("Dubai", 9F)
        TextBox1.Location = New Point(914, 337)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(169, 33)
        TextBox1.TabIndex = 32
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Font = New Font("Dubai", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(982, 387)
        Label10.Name = "Label10"
        Label10.Size = New Size(20, 25)
        Label10.TabIndex = 33
        Label10.Text = "0"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Anchor = AnchorStyles.Right
        ComboBox3.Font = New Font("Dubai", 9F)
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"cash", "credit"})
        ComboBox3.Location = New Point(914, 433)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(169, 33)
        ComboBox3.TabIndex = 34
        ' 
        ' sell
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1132, 760)
        Controls.Add(ComboBox3)
        Controls.Add(Label10)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label3)
        Controls.Add(Label4)
        DoubleBuffered = True
        Font = New Font("Arial", 9F, FontStyle.Bold)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "sell"
        StartPosition = FormStartPosition.CenterScreen
        Text = "sale"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox3 As ComboBox
End Class
