Public Class Form3
    Dim rb(5) As RadioButton
    Dim i As Integer
    Dim j As Integer
    Public rtngarrNew() As Integer
    Dim submitted As Boolean
    Dim name As String


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        i = 0
        Label1.Text = Form1.rec.bl.arrbook(i).Title
        submitted = False

        rb(0) = RadioButton1
        rb(1) = RadioButton2
        rb(2) = RadioButton3
        rb(3) = RadioButton4
        rb(4) = RadioButton5
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (submitted = False) Then
            i = i + 1 Mod 55
            Label1.Text = Form1.rec.bl.arrbook(i).Title
            Label3.Text += "0"
            ReDim rtngarrNew(i - 1)
            rtngarrNew(i - 1) = 0
        End If
        submitted = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (rb(0).Checked Or rb(1).Checked Or rb(2).Checked Or rb(3).Checked Or rb(4).Checked) Then
            For j = 0 To 4
                If (rb(j).Checked) Then
                    ReDim rtngarrNew(i)
                    rtngarrNew(i) = Val(rb(j).Text)
                    Label3.Text += rtngarrNew(i).ToString
                End If
            Next
            submitted = True
        Else
            MsgBox("Please select a Rating to submit")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rdBtn As Integer
        i = Math.Abs(i - 1)
        If (rtngarrNew(i) = -5) Then
            rdBtn = 0
        ElseIf (rtngarrNew(i) = -3) Then
            rdBtn = 1
        ElseIf (rtngarrNew(i) = 0) Then
            rdBtn = 2
        ElseIf (rtngarrNew(i) = 3) Then
            rdBtn = 3
        ElseIf (rtngarrNew(i) = 5) Then
            rdBtn = 4
        End If
        Label1.Text = Form1.rec.bl.arrbook(i).Title
        rb(rdBtn).Checked = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'If (Len(rtngarrNew) <= 55) Then
        'For i = 0 To 55
        'If (rtngarrNew(i) Is Nothing) Then
        'rtngarrNew(i) = 0
        'End If
        'Next
        'End If
        Form1.ListBox2.Items.Add(TextBox1.Text + " -- " + Label3.Text)
        Me.Hide()
    End Sub
End Class