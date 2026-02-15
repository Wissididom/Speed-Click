Option Strict On
Public Class Form1
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Int32) As Short
    Private Const Default_Key As String = "b"
    Private Const Default_Intervall As Integer = 100
    Public Declare Auto Function SetCursorPos Lib "User32.dll" (ByVal X As Integer, ByVal Y As Integer) As Integer
    Public Declare Auto Function GetCursorPos Lib "User32.dll" (ByRef lpPoint As Point) As Integer
    Public Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Public Const MOUSEEVENTF_MIDDLEDOWN = &H20
    Public Const MOUSEEVENTF_MIDDLEUP = &H40
    Public Const MOUSEEVENTF_RIGHTDOWN = &H8
    Public Const MOUSEEVENTF_RIGHTUP = &H10
    Public X As Integer
    Public Y As Integer
    Dim pactive As Boolean = False

    'Public Sub New()

    '    ' Dieser Aufruf ist für den Designer erforderlich.
    '    InitializeComponent()

    '    ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
    '    X = 500
    '    Y = 300
    '    SetCursorPos(X, Y)
    'End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim tempPos As Point
        Dim R As Long = GetCursorPos(tempPos)
        X = tempPos.X
        Y = tempPos.Y
        Select Case e.KeyCode
            Case Keys.Up
                Y -= 10
                e.Handled = True
            Case Keys.Down
                Y += 10
                e.Handled = True
            Case Keys.Left
                X -= 10
                e.Handled = True
            Case Keys.Right
                X += 10
                e.Handled = True
            Case Keys.Enter
                LeftClick()
                e.Handled = True
        End Select
        SetCursorPos(X, Y)
    End Sub

    Public Sub LeftClick()
        LeftDown()
        LeftUp()
    End Sub

    Public Sub LeftDown()
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
    End Sub

    Public Sub LeftUp()
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
    End Sub

    Public Sub RightClick()
        RightDown()
        RightUp()
    End Sub

    Public Sub RightDown()
        mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)
    End Sub

    Public Sub RightUp()
        mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)
    End Sub

    Private Sub tmrL_Tick(sender As Object, e As EventArgs) Handles tmrL.Tick
        LeftClick()
    End Sub

    Private Sub tmrR_Tick(sender As Object, e As EventArgs) Handles tmrR.Tick
        RightClick()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_key.Text = My.Settings.Key
        txt_intervall.Text = CStr(My.Settings.Intervall)
        timerkeys.Start()
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        If MsgBox("Wollen Sie wirklich beides auf die Standardeinstellungen zurücksetzen?", MsgBoxStyle.YesNo, "Wirklich zurücksetzen") = MsgBoxResult.Yes Then
            My.Settings.Key = Default_Key
            My.Settings.Intervall = Default_Intervall
            txt_key.Text = My.Settings.Key
            txt_intervall.Text = CStr(My.Settings.Intervall)
        End If
    End Sub

    Private Sub btn_apply_Click(sender As Object, e As EventArgs) Handles btn_apply.Click
        My.Settings.Save()
    End Sub

    Private Sub txt_key_TextChanged(sender As Object, e As EventArgs) Handles txt_key.TextChanged
        My.Settings.Key = txt_key.Text
        txt_key.Text.ToUpper()
    End Sub

    Private Sub txt_intervall_TextChanged(sender As Object, e As EventArgs) Handles txt_intervall.TextChanged
        My.Settings.Intervall = CInt(txt_intervall.Text)
        tmrL.Interval = CInt(txt_intervall.Text)
        tmrR.Interval = CInt(txt_intervall.Text)
    End Sub

    Private Sub btn_de_active_Click(sender As Object, e As EventArgs) Handles btn_de_active.Click
        If btn_de_active.Text = "Aktivieren" Then
            btn_de_active.Text = "Deaktivieren"
            If cb_links_rechts.Checked = True Then
                tmrR.Start()
            Else
                tmrL.Start()
            End If
        Else
            btn_de_active.Text = "Aktivieren"
            tmrR.Stop()
            tmrL.Stop()
        End If
    End Sub

    Private Sub timerkeys_Tick(sender As Object, e As EventArgs) Handles timerkeys.Tick
        Dim result As Integer
        Dim key As String
        Dim i As Integer
        For i = 2 To 90
            result = 0
            result = GetAsyncKeyState(i)
            If result = -32767 Then
                key = Chr(i)
                If i = 13 Then key = vbNewLine
                Exit For
            End If
        Next i
        If key <> Nothing Then
            tblog.Text = key
        End If
        If pactive = True Then
            If tblog.Text = txt_key.Text.ToUpper Then
                btn_de_active.PerformClick()
                tblog.Text = ""
            End If
        End If
    End Sub

    Private Sub btn_pactive_Click(sender As Object, e As EventArgs) Handles btn_pactive.Click
        If pactive = True Then
            btn_pactive.Text = "Prüfung aktivieren"
            pactive = False
        Else
            btn_pactive.Text = "Prüfung deaktivieren"
            pactive = True
        End If
    End Sub
End Class
