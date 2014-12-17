<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.DeviceName = New System.Windows.Forms.TextBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.SerialNumber = New System.Windows.Forms.TextBox()
        Me.MUFSDTag = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Manufacturer = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DeviceType = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Repairing = New System.Windows.Forms.ComboBox()
        Me.Loaner = New System.Windows.Forms.ComboBox()
        Me.Location = New System.Windows.Forms.ComboBox()
        Me.UserID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserName
        '
        Me.UserName.Location = New System.Drawing.Point(14, 48)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(100, 20)
        Me.UserName.TabIndex = 0
        Me.UserName.Text = "User's Name"
        '
        'DeviceName
        '
        Me.DeviceName.Location = New System.Drawing.Point(226, 48)
        Me.DeviceName.Name = "DeviceName"
        Me.DeviceName.Size = New System.Drawing.Size(100, 20)
        Me.DeviceName.TabIndex = 2
        Me.DeviceName.Text = "Device Name"
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(1085, 25)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(71, 20)
        Me.SubmitButton.TabIndex = 10
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'SerialNumber
        '
        Me.SerialNumber.Location = New System.Drawing.Point(332, 48)
        Me.SerialNumber.Name = "SerialNumber"
        Me.SerialNumber.Size = New System.Drawing.Size(100, 20)
        Me.SerialNumber.TabIndex = 3
        Me.SerialNumber.Text = "Serial Number"
        '
        'MUFSDTag
        '
        Me.MUFSDTag.Location = New System.Drawing.Point(438, 48)
        Me.MUFSDTag.Name = "MUFSDTag"
        Me.MUFSDTag.Size = New System.Drawing.Size(100, 20)
        Me.MUFSDTag.TabIndex = 4
        Me.MUFSDTag.Text = "MUFSD Tag"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "User's Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(223, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Device Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(329, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Serial Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(435, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "MUFSD Tag"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(541, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Location"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(945, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(913, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "_____"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Location = New System.Drawing.Point(443, 92)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(536, 48)
        Me.Panel2.TabIndex = 14
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(82, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(71, 23)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Repairing"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(6, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(61, 23)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Loaners"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.WebBrowser1)
        Me.Panel3.Location = New System.Drawing.Point(0, 92)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(443, 475)
        Me.Panel3.TabIndex = 15
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(441, 473)
        Me.WebBrowser1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.WebBrowser2)
        Me.Panel4.Location = New System.Drawing.Point(443, 132)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(536, 434)
        Me.Panel4.TabIndex = 16
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser2.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.ScrollBarsEnabled = False
        Me.WebBrowser2.Size = New System.Drawing.Size(534, 432)
        Me.WebBrowser2.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Manufacturer)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.DeviceType)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.Repairing)
        Me.Panel5.Controls.Add(Me.Loaner)
        Me.Panel5.Controls.Add(Me.Location)
        Me.Panel5.Controls.Add(Me.UserID)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.PrintButton)
        Me.Panel5.Controls.Add(Me.Button3)
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.MUFSDTag)
        Me.Panel5.Controls.Add(Me.SerialNumber)
        Me.Panel5.Controls.Add(Me.SubmitButton)
        Me.Panel5.Controls.Add(Me.DeviceName)
        Me.Panel5.Controls.Add(Me.UserName)
        Me.Panel5.Location = New System.Drawing.Point(0, -1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1438, 93)
        Me.Panel5.TabIndex = 17
        '
        'Manufacturer
        '
        Me.Manufacturer.AllowDrop = True
        Me.Manufacturer.FormattingEnabled = True
        Me.Manufacturer.Items.AddRange(New Object() {"Acer", "Dell", "Google", "HP", "Lexmark", "Samsung", "SMART", "Teq"})
        Me.Manufacturer.Location = New System.Drawing.Point(756, 49)
        Me.Manufacturer.Name = "Manufacturer"
        Me.Manufacturer.Size = New System.Drawing.Size(100, 21)
        Me.Manufacturer.TabIndex = 7
        Me.Manufacturer.Text = "Select"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(753, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Manufacturer"
        '
        'DeviceType
        '
        Me.DeviceType.AllowDrop = True
        Me.DeviceType.FormattingEnabled = True
        Me.DeviceType.Items.AddRange(New Object() {"Chromebook", "Desktop", "iPad", "Laptop", "Printer", "Projector", "SMART Board"})
        Me.DeviceType.Location = New System.Drawing.Point(650, 48)
        Me.DeviceType.Name = "DeviceType"
        Me.DeviceType.Size = New System.Drawing.Size(100, 21)
        Me.DeviceType.TabIndex = 6
        Me.DeviceType.Text = "Select"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(647, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Device Type"
        Me.Label9.UseMnemonic = False
        '
        'Repairing
        '
        Me.Repairing.AllowDrop = True
        Me.Repairing.FormattingEnabled = True
        Me.Repairing.Items.AddRange(New Object() {"No", "Yes"})
        Me.Repairing.Location = New System.Drawing.Point(968, 50)
        Me.Repairing.Name = "Repairing"
        Me.Repairing.Size = New System.Drawing.Size(100, 21)
        Me.Repairing.TabIndex = 9
        Me.Repairing.Text = "No"
        '
        'Loaner
        '
        Me.Loaner.AllowDrop = True
        Me.Loaner.FormattingEnabled = True
        Me.Loaner.Items.AddRange(New Object() {"No", "Yes"})
        Me.Loaner.Location = New System.Drawing.Point(862, 49)
        Me.Loaner.Name = "Loaner"
        Me.Loaner.Size = New System.Drawing.Size(100, 21)
        Me.Loaner.TabIndex = 8
        Me.Loaner.Text = "No"
        '
        'Location
        '
        Me.Location.AllowDrop = True
        Me.Location.FormattingEnabled = True
        Me.Location.Items.AddRange(New Object() {"AHS", "BLE", "BMS", "ELE", "FFE", "LHE", "MDO", "MHS", "MKE", "UQE"})
        Me.Location.Location = New System.Drawing.Point(544, 48)
        Me.Location.Name = "Location"
        Me.Location.Size = New System.Drawing.Size(100, 21)
        Me.Location.TabIndex = 5
        Me.Location.Text = "Select"
        '
        'UserID
        '
        Me.UserID.Location = New System.Drawing.Point(120, 48)
        Me.UserID.Name = "UserID"
        Me.UserID.Size = New System.Drawing.Size(100, 20)
        Me.UserID.TabIndex = 1
        Me.UserID.Text = "User's ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(117, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "User's ID"
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(1085, 51)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(71, 20)
        Me.PrintButton.TabIndex = 11
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(965, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Repairing"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(859, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Loaner"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(914, 8)
        Me.Panel6.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1646, 569)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel5)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(610, 140)
        Me.Name = "Form1"
        Me.Text = "Assign User To Device"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UserName As System.Windows.Forms.TextBox
    Friend WithEvents DeviceName As System.Windows.Forms.TextBox
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
    Friend WithEvents SerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents MUFSDTag As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents UserID As System.Windows.Forms.TextBox
    Friend WithEvents Location As System.Windows.Forms.ComboBox
    Friend WithEvents Repairing As System.Windows.Forms.ComboBox
    Friend WithEvents Loaner As System.Windows.Forms.ComboBox
    Friend WithEvents Manufacturer As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DeviceType As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
