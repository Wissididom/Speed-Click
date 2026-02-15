<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_apply = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.txt_key = New System.Windows.Forms.TextBox()
        Me.tmrL = New System.Windows.Forms.Timer(Me.components)
        Me.tmrR = New System.Windows.Forms.Timer(Me.components)
        Me.txt_intervall = New System.Windows.Forms.TextBox()
        Me.btn_de_active = New System.Windows.Forms.Button()
        Me.cb_links_rechts = New System.Windows.Forms.CheckBox()
        Me.timerkeys = New System.Windows.Forms.Timer(Me.components)
        Me.tblog = New System.Windows.Forms.TextBox()
        Me.btn_pactive = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_apply
        '
        Me.btn_apply.Location = New System.Drawing.Point(102, 122)
        Me.btn_apply.Name = "btn_apply"
        Me.btn_apply.Size = New System.Drawing.Size(81, 23)
        Me.btn_apply.TabIndex = 0
        Me.btn_apply.Text = "Übernehmen"
        Me.btn_apply.UseVisualStyleBackColor = True
        '
        'btn_reset
        '
        Me.btn_reset.Location = New System.Drawing.Point(188, 168)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(84, 23)
        Me.btn_reset.TabIndex = 1
        Me.btn_reset.Text = "Zurücksetzten"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'txt_key
        '
        Me.txt_key.Location = New System.Drawing.Point(92, 70)
        Me.txt_key.Name = "txt_key"
        Me.txt_key.Size = New System.Drawing.Size(100, 20)
        Me.txt_key.TabIndex = 2
        '
        'tmrL
        '
        '
        'tmrR
        '
        '
        'txt_intervall
        '
        Me.txt_intervall.Location = New System.Drawing.Point(92, 96)
        Me.txt_intervall.Name = "txt_intervall"
        Me.txt_intervall.Size = New System.Drawing.Size(100, 20)
        Me.txt_intervall.TabIndex = 3
        '
        'btn_de_active
        '
        Me.btn_de_active.Location = New System.Drawing.Point(12, 168)
        Me.btn_de_active.Name = "btn_de_active"
        Me.btn_de_active.Size = New System.Drawing.Size(84, 23)
        Me.btn_de_active.TabIndex = 4
        Me.btn_de_active.Text = "Aktivieren"
        Me.btn_de_active.UseVisualStyleBackColor = True
        '
        'cb_links_rechts
        '
        Me.cb_links_rechts.AutoSize = True
        Me.cb_links_rechts.Location = New System.Drawing.Point(92, 12)
        Me.cb_links_rechts.Name = "cb_links_rechts"
        Me.cb_links_rechts.Size = New System.Drawing.Size(108, 17)
        Me.cb_links_rechts.TabIndex = 5
        Me.cb_links_rechts.Text = "rechte Maustaste"
        Me.cb_links_rechts.UseVisualStyleBackColor = True
        '
        'timerkeys
        '
        Me.timerkeys.Enabled = True
        Me.timerkeys.Interval = 5
        '
        'tblog
        '
        Me.tblog.Location = New System.Drawing.Point(92, 214)
        Me.tblog.Name = "tblog"
        Me.tblog.Size = New System.Drawing.Size(100, 20)
        Me.tblog.TabIndex = 6
        Me.tblog.Visible = False
        '
        'btn_pactive
        '
        Me.btn_pactive.Location = New System.Drawing.Point(102, 159)
        Me.btn_pactive.Name = "btn_pactive"
        Me.btn_pactive.Size = New System.Drawing.Size(75, 40)
        Me.btn_pactive.TabIndex = 7
        Me.btn_pactive.Text = "Prüfung aktivieren"
        Me.btn_pactive.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btn_pactive)
        Me.Controls.Add(Me.tblog)
        Me.Controls.Add(Me.cb_links_rechts)
        Me.Controls.Add(Me.btn_de_active)
        Me.Controls.Add(Me.txt_intervall)
        Me.Controls.Add(Me.txt_key)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_apply)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Speed-Click"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_apply As System.Windows.Forms.Button
    Friend WithEvents btn_reset As System.Windows.Forms.Button
    Friend WithEvents txt_key As System.Windows.Forms.TextBox
    Friend WithEvents tmrL As System.Windows.Forms.Timer
    Friend WithEvents tmrR As System.Windows.Forms.Timer
    Friend WithEvents txt_intervall As System.Windows.Forms.TextBox
    Friend WithEvents btn_de_active As System.Windows.Forms.Button
    Friend WithEvents cb_links_rechts As System.Windows.Forms.CheckBox
    Friend WithEvents timerkeys As System.Windows.Forms.Timer
    Friend WithEvents tblog As System.Windows.Forms.TextBox
    Friend WithEvents btn_pactive As System.Windows.Forms.Button

End Class
