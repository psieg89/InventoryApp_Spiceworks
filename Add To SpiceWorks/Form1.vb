
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Imports System.Diagnostics.Process
Imports System.IO
Imports System.Data.DataTable
Imports System.Runtime.InteropServices


Public Class Form1


    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True, ExactSpelling:=True)> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim screenwidth As Integer
    Dim screenheight As Integer

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        'If drag is set to true then move the form accordingly.
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub



    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("http://server/searchspw.html")

        Me.FormBorderStyle = FormBorderStyle.None
        Me.Top = 0
        Me.Left = 0
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width

        screenwidth = Screen.PrimaryScreen.WorkingArea.Width
        screenheight = Screen.PrimaryScreen.WorkingArea.Height

        Button2.Left = screenwidth - 32
        Button3.Left = screenwidth - 64

        Panel5.Width = Screen.PrimaryScreen.WorkingArea.Width
        Panel6.Width = Screen.PrimaryScreen.WorkingArea.Width

        Panel3.Width = Screen.PrimaryScreen.WorkingArea.Width * 0.5
        Panel3.Height = Screen.PrimaryScreen.WorkingArea.Height - 12

        Panel2.Left = screenwidth * 0.5
        Panel2.Width = Screen.PrimaryScreen.WorkingArea.Width * 0.5

        Panel4.Left = screenwidth * 0.5
        Panel4.Width = Screen.PrimaryScreen.WorkingArea.Width * 0.5
        Panel4.Height = Screen.PrimaryScreen.WorkingArea.Height - 12


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles SubmitButton.Click

        Dim xlApp As New Microsoft.Office.Interop.Excel.Application
        Dim xlBook As Microsoft.Office.Interop.Excel.Workbook = xlApp.Workbooks.Open("\\server\C$\Program Files (x86)\Spiceworks\bin\UserToDevice.csv")
        Dim xlSheet As Microsoft.Office.Interop.Excel.Worksheet = xlBook.Sheets.Item(1) '/// Index Of Worksheet (eg: Sheet1)

        Dim month As String = String.Format("{0:MM}", DateTime.Now)
        Dim day As String = String.Format("{0:dd}", DateTime.Now)
        Dim year As String = String.Format("{0:yyyy}", DateTime.Now)
        Dim savedate As String = month & -day & -year

        Dim History As String = savedate & " " & UserName.Text & " " & UserID.Text & " Loaner-" & Loaner.Text & " Repairing-" & Repairing.Text

        xlSheet.Cells(2, 1) = UserName.Text
        xlSheet.Cells(2, 2) = DeviceName.Text
        xlSheet.Cells(2, 3) = SerialNumber.Text
        xlSheet.Cells(2, 4) = MUFSDTag.Text
        xlSheet.Cells(2, 5) = Location.Text
        xlSheet.Cells(2, 6) = Loaner.Text
        xlSheet.Cells(2, 7) = Repairing.Text
        xlSheet.Cells(2, 8) = UserID.Text
        xlSheet.Cells(2, 9) = DeviceType.Text
        xlSheet.Cells(2, 10) = Manufacturer.Text
        xlSheet.Cells(2, 11) = History


        xlApp.DisplayAlerts = False
        xlBook.SaveAs(Filename:= _
        "\\server\C$\Program Files (x86)\Spiceworks\bin\UserToDevice.csv")
        xlApp.DisplayAlerts = False


        'xlBook.Save()
        xlApp.Quit()

        Dim xlApp1 As New Microsoft.Office.Interop.Excel.Application
        Dim xlBook1 As Microsoft.Office.Interop.Excel.Workbook = xlApp1.Workbooks.Open("\\server\C$\Program Files (x86)\Spiceworks\bin\UserToDeviceMaster.xls")
        Dim xlSheet1 As Microsoft.Office.Interop.Excel.Worksheet = xlBook1.Sheets.Item(1) '/// Index Of Worksheet (eg: Sheet1)
        Dim numRow As Integer
        numRow = 2


        While (xlBook1.ActiveSheet.Cells(numRow, 1).Value IsNot Nothing)
            numRow = numRow + 1
        End While

        xlSheet1.Cells(numRow, 1) = UserName.Text
        xlSheet1.Cells(numRow, 2) = DeviceName.Text
        xlSheet1.Cells(numRow, 3) = SerialNumber.Text
        xlSheet1.Cells(numRow, 4) = MUFSDTag.Text
        xlSheet1.Cells(numRow, 5) = Location.Text
        xlSheet1.Cells(numRow, 6) = Loaner.Text
        xlSheet1.Cells(numRow, 7) = Repairing.Text
        xlSheet1.Cells(numRow, 8) = UserID.Text
        xlSheet1.Cells(numRow, 9) = DeviceType.Text
        xlSheet1.Cells(numRow, 10) = Manufacturer.Text
        xlSheet1.Cells(numRow, 11) = History

        xlBook1.Save()
        xlApp1.Quit()



    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub Panel5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel5.MouseDown

        'This code can be used in the MouseDown event of any control(s) you want to be able to move your form with   
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)

    End Sub


    Private Sub Panel6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel6.MouseDown

        'This code can be used in the MouseDown event of any control(s) you want to be able to move your form with   
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)

    End Sub



    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Const Loaners_SEARCH As String = "http://server/reports/show/84"
        WebBrowser2.Navigate(Loaners_SEARCH)
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Const Repairing_SEARCH As String = "http://server/reports/show/85"
        WebBrowser2.Navigate(Repairing_SEARCH)
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Dim xlApp2 As New Microsoft.Office.Interop.Excel.Application
        Dim xlBook2 As Microsoft.Office.Interop.Excel.Workbook = xlApp2.Workbooks.Open("\\server\C$\Program Files (x86)\Spiceworks\bin\Label.xls")
        Dim xlSheet2 As Microsoft.Office.Interop.Excel.Worksheet = xlBook2.Sheets.Item(1) '/// Index Of Worksheet (eg: Sheet1)

        xlSheet2.Cells(2, 1) = UserName.Text
        xlSheet2.Cells(2, 3) = UserID.Text
        xlSheet2.Cells(2, 5) = DeviceName.Text
        xlSheet2.Cells(2, 7) = SerialNumber.Text
        xlSheet2.Cells(2, 9) = MUFSDTag.Text
        xlSheet2.Cells(2, 11) = Location.Text
        xlSheet2.Cells(16, 1) = UserName.Text
        xlSheet2.Cells(16, 3) = UserID.Text
        xlSheet2.Cells(16, 5) = DeviceName.Text
        xlSheet2.Cells(16, 7) = SerialNumber.Text
        xlSheet2.Cells(16, 9) = MUFSDTag.Text
        xlSheet2.Cells(16, 11) = Location.Text




        xlBook2.Save()
        xlApp2.Quit()


        Dim psi As New ProcessStartInfo
        psi.UseShellExecute = True
        psi.Verb = "print"
        psi.WindowStyle = ProcessWindowStyle.Hidden
        'psi.Arguments = PrintDialog1.PrinterSettings.PrinterName.ToString()
        psi.FileName = "\\server\C$\Program Files (x86)\Spiceworks\bin\Label.xls" ' Here specify a document to be printed
        Process.Start(psi)


        'PrintDocument1.PrinterSettings.Copies = 2
        'PrintDocument1.Print()
    End Sub

End Class
