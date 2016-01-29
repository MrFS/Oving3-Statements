Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyBase.Text = "Øving 3 - If Statements - 02/09 - 2015"
        Label8.Text = ""
        Label13.Text = ""
        ListBox1.Visible = 0
        MyBase.MaximizeBox = 0
        MyBase.MinimizeBox = 0
        MyBase.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim alder As Integer = TextBox1.Text

        If alder > 66 Then
            MsgBox("Du er myndig og pensjonist!" & vbNewLine & "Nyt det!", MsgBoxStyle.Information)
        ElseIf alder < 18 Then
            MsgBox("Du er ikke myndig enda.  ಠ_ಠ ", MsgBoxStyle.Critical)
        Else
            MsgBox("Du er myndig!  (っ◕‿◕)っ", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        Dim resultat As String = TextBox2.Text

        If e.KeyCode = Keys.H Then
            Label8.Text = "Hjemmeseier!"
        ElseIf e.KeyCode = Keys.B Then
            Label8.Text = "Borteseier..."
        ElseIf e.KeyCode = Keys.U Then
            Label8.Text = "Uavgjort..."
        ElseIf e.KeyCode = Keys.Back Then
            TextBox2.Clear()
            Label8.Text = ""
        Else
            MsgBox("Her kan du kun bruke 'U', 'B' og 'H'", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim caseResultat As String = TextBox3.Text
        Select Case caseResultat
            Case "b", "B"
                MsgBox("Du tror det blir borteseier")
            Case "u", "U"
                MsgBox("Du tror det blir uavgjort")
            Case "h", "H"
                MsgBox("Du tror det blir hjemmeseier")
            Case Else
                MsgBox("Her kan du kun bruke 'U', 'B' og 'H'", MsgBoxStyle.Critical)
        End Select
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Label13.Text = HScrollBar1.Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim alderBuss As Integer = 0
        Dim pris As Double = HScrollBar1.Value * 3.52
        Dim rabattBarn As Double = pris * 0.5
        Dim rabattPen As Double = pris * 0.2

        ListBox1.Items.Clear()
        ListBox1.Enabled = 0

        alderBuss = TextBox4.Text

        If IsNumeric(TextBox4.Text) Then
            If alderBuss < 12 Then
                ListBox1.Visible = 1
                ListBox1.Items.Add("Kilometerprisen er på 3.52,-")
                ListBox1.Items.Add("Du skal kjøre " & HScrollBar1.Value & "km")
                ListBox1.Items.Add("Du er " & alderBuss & " år gammel")
                ListBox1.Items.Add("Barn u/ 12 år får 50% rabatt")
                ListBox1.Items.Add("Pris u/ rabatt: " & pris & ",-")
                ListBox1.Items.Add("Rabatten er på: " & rabattBarn & ",-")
                ListBox1.Items.Add("Totalpris blir: " & pris - rabattBarn & ",-")

            ElseIf alderBuss > 66 Then
                ListBox1.Visible = 1
                ListBox1.Items.Add("Kilometerprisen er på 3.52,-")
                ListBox1.Items.Add("Du skal kjøre " & HScrollBar1.Value & "km")
                ListBox1.Items.Add("Du er " & alderBuss & " år gammel")
                ListBox1.Items.Add("Pensjonister får 20% rabatt")
                ListBox1.Items.Add("Pris u/ rabatt: " & pris & ",-")
                ListBox1.Items.Add("Rabatten er på: " & rabattPen & ",-")
                ListBox1.Items.Add("Totalpris blir: " & pris - rabattPen & ",-")

            ElseIf alderBuss > 12 Then
                ListBox1.Visible = 1
                ListBox1.Items.Add("Kilometerprisen er på 3.52,-")
                ListBox1.Items.Add("Du skal kjøre " & HScrollBar1.Value & "km")
                ListBox1.Items.Add("Du er " & alderBuss & " år gammel")
                ListBox1.Items.Add("Pris: " & pris & ",-")
            End If
        Else
            MsgBox("Vennligst skriv en alder, i tallformat.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub AvsluttToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvsluttToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
