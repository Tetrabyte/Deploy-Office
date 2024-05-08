<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Timer_Countdown = New System.Windows.Forms.Timer(Me.components)
        Me.MainLabel = New System.Windows.Forms.Label()
        Me.CountdownLabel = New System.Windows.Forms.Label()
        Me.LogTextbox = New System.Windows.Forms.TextBox()
        Me.ComboBox_Edition = New System.Windows.Forms.ComboBox()
        Me.Button_Start = New System.Windows.Forms.Button()
        Me.ComboBox_Year = New System.Windows.Forms.ComboBox()
        Me.Label_Year = New System.Windows.Forms.Label()
        Me.Label_Edition = New System.Windows.Forms.Label()
        Me.CheckBox_CreateDesktopShortcuts = New System.Windows.Forms.CheckBox()
        Me.CheckBox_ExcludeTeams = New System.Windows.Forms.CheckBox()
        Me.CheckBox_ExcludeOneDrive = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Timer_Countdown
        '
        Me.Timer_Countdown.Enabled = True
        Me.Timer_Countdown.Interval = 1000
        '
        'MainLabel
        '
        Me.MainLabel.BackColor = System.Drawing.Color.Transparent
        Me.MainLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainLabel.Location = New System.Drawing.Point(12, 9)
        Me.MainLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.MainLabel.Name = "MainLabel"
        Me.MainLabel.Size = New System.Drawing.Size(460, 48)
        Me.MainLabel.TabIndex = 0
        Me.MainLabel.Text = "Starting Office Installation"
        Me.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        AddHandler Me.MainLabel.Click, AddressOf Me.MainLabel_Click
        '
        'CountdownLabel
        '
        Me.CountdownLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountdownLabel.Location = New System.Drawing.Point(278, 60)
        Me.CountdownLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.CountdownLabel.Name = "CountdownLabel"
        Me.CountdownLabel.Size = New System.Drawing.Size(194, 57)
        Me.CountdownLabel.TabIndex = 1
        Me.CountdownLabel.Text = "Running"
        Me.CountdownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LogTextbox
        '
        Me.LogTextbox.Location = New System.Drawing.Point(12, 179)
        Me.LogTextbox.Multiline = True
        Me.LogTextbox.Name = "LogTextbox"
        Me.LogTextbox.ReadOnly = True
        Me.LogTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LogTextbox.Size = New System.Drawing.Size(460, 290)
        Me.LogTextbox.TabIndex = 2
        '
        'ComboBox_Edition
        '
        Me.ComboBox_Edition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Edition.Enabled = False
        Me.ComboBox_Edition.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Edition.FormattingEnabled = True
        Me.ComboBox_Edition.Location = New System.Drawing.Point(63, 92)
        Me.ComboBox_Edition.Name = "ComboBox_Edition"
        Me.ComboBox_Edition.Size = New System.Drawing.Size(212, 25)
        Me.ComboBox_Edition.TabIndex = 3
        '
        'Button_Start
        '
        Me.Button_Start.Enabled = False
        Me.Button_Start.Location = New System.Drawing.Point(12, 146)
        Me.Button_Start.Name = "Button_Start"
        Me.Button_Start.Size = New System.Drawing.Size(460, 27)
        Me.Button_Start.TabIndex = 6
        Me.Button_Start.Text = "Start"
        Me.Button_Start.UseVisualStyleBackColor = True
        '
        'ComboBox_Year
        '
        Me.ComboBox_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Year.FormattingEnabled = True
        Me.ComboBox_Year.Location = New System.Drawing.Point(63, 60)
        Me.ComboBox_Year.Name = "ComboBox_Year"
        Me.ComboBox_Year.Size = New System.Drawing.Size(120, 25)
        Me.ComboBox_Year.TabIndex = 8
        '
        'Label_Year
        '
        Me.Label_Year.AutoSize = True
        Me.Label_Year.BackColor = System.Drawing.Color.Transparent
        Me.Label_Year.Location = New System.Drawing.Point(12, 64)
        Me.Label_Year.Name = "Label_Year"
        Me.Label_Year.Size = New System.Drawing.Size(33, 17)
        Me.Label_Year.TabIndex = 9
        Me.Label_Year.Text = "Year"
        '
        'Label_Edition
        '
        Me.Label_Edition.AutoSize = True
        Me.Label_Edition.BackColor = System.Drawing.Color.Transparent
        Me.Label_Edition.Location = New System.Drawing.Point(12, 95)
        Me.Label_Edition.Name = "Label_Edition"
        Me.Label_Edition.Size = New System.Drawing.Size(48, 17)
        Me.Label_Edition.TabIndex = 10
        Me.Label_Edition.Text = "Edition"
        '
        'CheckBox_CreateDesktopShortcuts
        '
        Me.CheckBox_CreateDesktopShortcuts.AutoSize = True
        Me.CheckBox_CreateDesktopShortcuts.Checked = True
        Me.CheckBox_CreateDesktopShortcuts.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_CreateDesktopShortcuts.Location = New System.Drawing.Point(14, 122)
        Me.CheckBox_CreateDesktopShortcuts.Name = "CheckBox_CreateDesktopShortcuts"
        Me.CheckBox_CreateDesktopShortcuts.Size = New System.Drawing.Size(175, 21)
        Me.CheckBox_CreateDesktopShortcuts.TabIndex = 11
        Me.CheckBox_CreateDesktopShortcuts.Text = "Create Desktop Shortcuts"
        Me.CheckBox_CreateDesktopShortcuts.UseVisualStyleBackColor = True
        '
        'CheckBox_ExcludeTeams
        '
        Me.CheckBox_ExcludeTeams.AutoSize = True
        Me.CheckBox_ExcludeTeams.Location = New System.Drawing.Point(195, 122)
        Me.CheckBox_ExcludeTeams.Name = "CheckBox_ExcludeTeams"
        Me.CheckBox_ExcludeTeams.Size = New System.Drawing.Size(112, 21)
        Me.CheckBox_ExcludeTeams.TabIndex = 12
        Me.CheckBox_ExcludeTeams.Text = "Exclude Teams"
        Me.CheckBox_ExcludeTeams.UseVisualStyleBackColor = True
        '
        'CheckBox_ExcludeOneDrive
        '
        Me.CheckBox_ExcludeOneDrive.AutoSize = True
        Me.CheckBox_ExcludeOneDrive.Location = New System.Drawing.Point(313, 122)
        Me.CheckBox_ExcludeOneDrive.Name = "CheckBox_ExcludeOneDrive"
        Me.CheckBox_ExcludeOneDrive.Size = New System.Drawing.Size(129, 21)
        Me.CheckBox_ExcludeOneDrive.TabIndex = 13
        Me.CheckBox_ExcludeOneDrive.Text = "Exclude OneDrive"
        Me.CheckBox_ExcludeOneDrive.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 481)
        Me.Controls.Add(Me.CheckBox_ExcludeOneDrive)
        Me.Controls.Add(Me.CheckBox_ExcludeTeams)
        Me.Controls.Add(Me.CheckBox_CreateDesktopShortcuts)
        Me.Controls.Add(Me.Label_Edition)
        Me.Controls.Add(Me.Label_Year)
        Me.Controls.Add(Me.ComboBox_Year)
        Me.Controls.Add(Me.Button_Start)
        Me.Controls.Add(Me.ComboBox_Edition)
        Me.Controls.Add(Me.LogTextbox)
        Me.Controls.Add(Me.CountdownLabel)
        Me.Controls.Add(Me.MainLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tetrabyte - Office Installer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer_Countdown As Timer
    Friend WithEvents MainLabel As Label
    Friend WithEvents CountdownLabel As Label
    Friend WithEvents LogTextbox As TextBox
    Friend WithEvents ComboBox_Edition As ComboBox
    Friend WithEvents Button_Start As Button
    Friend WithEvents ComboBox_Year As ComboBox
    Friend WithEvents Label_Year As Label
    Friend WithEvents Label_Edition As Label
    Friend WithEvents CheckBox_CreateDesktopShortcuts As CheckBox
    Friend WithEvents CheckBox_ExcludeTeams As CheckBox
    Friend WithEvents CheckBox_ExcludeOneDrive As CheckBox
End Class
