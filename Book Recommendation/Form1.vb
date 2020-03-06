Public Class Form1
    Dim rpos As Integer
    'Dim arrratings() As Integer
    'Dim getbstr As String
    'Dim flag As Integer
    Dim i As Integer
    Dim j As Integer
    Dim sum As Long
    Dim picflag As Integer
    Dim arrsl(86) As Integer
    Dim avg As Integer
    Dim flag(55) As Integer
    Dim large As Integer
    Dim realj As Integer
    Dim pathstring As String
    Dim arravg(55) As Integer
    Dim total As Integer
    Dim Delete As Boolean
    Public index As Integer

    Structure Recommend
        Public bl As Booklist
        Public rl As Readerlist


        'Dim bl As Booklist
        'Dim arrratings() As String

        Structure Booklist
            'Dim bl As Booklist
            Public arrbook() As Book
            Dim temp As Book
            Structure Book
                Dim Title As String
                Dim Author As String


                Function getbstr() As String



                    'getbstr = ""

                    getbstr = Title + " -- " + Author
                End Function
            End Structure

            Sub FillBookList()
                Dim i As Integer
                Dim j As Integer
                Dim strline As String
                Dim tstr As String
                Dim astr As String
                Dim nike As Integer
                Dim chuck As Integer
                ReDim arrbook(55)




                FileOpen(1, "C:\Data\CP2\BookRec\books.txt", OpenMode.Input)
                j = 0
                While Not EOF(1)
                    strline = Trim(LineInput(1))
                    nike = Len(strline)
                    For i = 1 To nike
                        If Mid(strline, i, 1) = "," Then
                            astr = Mid(strline, 1, i - 1)
                            arrbook(j).Author = astr
                            'arrbook(i).Author = astr
                            'A(i) = astr
                            ' ListBox1.Items.Add(rec)
                            chuck = nike - (i + 1)
                            tstr = Mid(strline, i + 1, chuck + 1)
                            arrbook(j).Title = tstr
                            'T(i) = tstr
                            'ListBox2.Items.Add(T(i))

                        End If
                    Next i




                    temp = arrbook(35)



                    j = j + 1
                End While
                FileClose(1)



            End Sub
        End Structure

        Structure Readerlist
            Dim arrreaders() As Reader
            Dim rdr As Reader


            Structure Reader
                Dim name As String
                Dim arrratings() As String
                Dim gertrstr() As String

                Function getrstr() As String


                    ' Dim i As Integer
                    'Dim flag As Integer
                    'Select Case name
                    'Case Else
                    'getrstr = name
                    'End Select


                    'Select Case arrratings()

                    'Case Else
                    'For i = 1 To 86
                    'If i = flag Then
                    'getrstr = getrstr + arrratings(i)
                    'End If
                    'Next i


                    ' End Select


                End Function

            End Structure
            Sub FillReaderList()
                ReDim arrreaders(86)

                Dim i As Integer
                Dim r As Integer
                Dim j As Integer

                Dim k As Integer
                Dim tempstr(86) As String
                Dim calcstr As String
                Dim tc
                Dim strline(86) As String
                Dim strline2(86) As String
                ' Dim tstr As String
                'Dim astr As String
                Dim nike As Integer

                ' arrreaders(55).getrstr()

                'Dim chuck As Integer

                'For i = 1 To 55
                'For j = 1 To 55
                'For i = 1 To 86
                'ReDim arrreaders(i).arrratings(55)
                'Next i


                ' Next j
                'Next i

                i = -1
                FileOpen(1, "C:\Data\CP2\BookRec\readerratings.txt", OpenMode.Input)
                tc = 0
                Do While Not EOF(1)
                    i = i + 1
                    strline(i) = LineInput(1)

                    strline2(i) = Trim(LineInput(1))
                Loop
                FileClose(1)


                For i = 0 To 85
                    calcstr = ""
                    arrreaders(i).name = strline(i)
                    tempstr = strline2(i).Split(" ")
                    ReDim arrreaders(i).arrratings(55)
                    For j = 0 To 54
                        arrreaders(i).arrratings(j) = tempstr(j)
                    Next j
                    For j = 0 To 54
                        calcstr = calcstr + Str(arrreaders(i).arrratings(j))
                    Next j

                    arrreaders(i).getrstr()



                Next i







                'Dim u As Integer
                '
                'For u = 1 To 55
                'If Trim(Mid(strline2, k, 2)) = "-" Then
                'k = k + 1
                'End If
                'arrreaders(tc).arrratings(u) = strline2, k, 2))
                'If u = 54 Then
                'Exit For
                'End If
                'k = k + 2
                ' Next u
                'k = 1
                'tc = tc + 1






                'strline2 = Trim(LineInput(1))

                'If Mid(strline2, 1, 1) = "A" Or Mid(strline2, 1, 1) = "B" Or Mid(strline2, 1, 1) = "C" Or Mid(strline2, 1, 1) = "D" Or Mid(strline2, 1, 1) = "E" Or Mid(strline2, 1, 1) = "F" Or Mid(strline2, 1, 1) = "G" Or Mid(strline2, 1, 1) = "H" Or Mid(strline2, 1, 1) = "I" Or Mid(strline2, 1, 1) = "J" Or Mid(strline2, 1, 1) = "K" Or Mid(strline2, 1, 1) = "L" Or Mid(strline2, 1, 1) = "M" Or Mid(strline2, 1, 1) = "N" Or Mid(strline2, 1, 1) = "O" Or Mid(strline2, 1, 1) = "P" Or Mid(strline2, 1, 1) = "Q" Or Mid(strline2, 1, 1) = "R" Or Mid(strline2, 1, 1) = "S" Or Mid(strline2, 1, 1) = "T" Or Mid(strline2, 1, 1) = "U" Or Mid(strline2, 1, 1) = "V" Or Mid(strline2, 1, 1) = "W" Or Mid(strline2, 1, 1) = "X" Or Mid(strline2, 1, 1) = "Y" Or Mid(strline2, 1, 1) = "Z" Then
                'arrreaders(j).name = Trim(LineInput(1))


                'Else
                'nike = Trim(Len(strline2))

                'r = 1
                'For i = 1 To nike
                'If Mid(strline2, i, 1) <> " " Or Mid(strline2, i, 1) <> "-" Then
                'arrratings(r) = Mid(strline2, i, 1)
                'r = r + 1
                '
                ' End If

                ' If Mid(strline2, i, 1) = "-" Then
                '           arrratings(r) = Mid(strline2, i, 2)
                'arrreaders(j).arrratings(i) = Mid(strline2, i, 2)
                ' r = r + 1
                'End If

                'If Mid(strline2, i, 1) = " " Then

                'End If


                'r = r + 1
                'chuck = nike - (i + 1)
                'tstr = Mid(strline, i + 1, chuck)

                'T(i) = tstr
                'ListBox2.Items.Add(T(i))


                'Next i





                'End If

                'Loop
                ' Next j




            End Sub
        End Structure




    End Structure
    Dim arrpic(15) As PictureBox
    Public rec As Recommend

    Sub FindavgRatings()
        sum = 0
        large = 0
        realj = 0
        For i = 0 To 85
            sum = 0
            If i = rpos Then
                sum = 0
            Else

                For j = 0 To total

                    sum = sum + rec.rl.arrreaders(i).arrratings(j) * rec.rl.arrreaders(rpos).arrratings(j)



                Next j
                arrsl(i) = sum

            End If
            If arrsl(i) > large Then
                large = arrsl(i)
                realj = i
            End If
        Next i

    End Sub
    Sub picarray()
        arrpic(1) = pic1
        arrpic(2) = pic2
        arrpic(3) = pic3
        arrpic(4) = pic4
        arrpic(5) = pic5
        arrpic(6) = pic6
        arrpic(7) = pic7
        arrpic(8) = pic8
        arrpic(9) = pic9
        arrpic(10) = pic10
        arrpic(11) = pic11
        arrpic(12) = pic12
        arrpic(13) = pic13
        arrpic(14) = pic14
        arrpic(15) = pic15
        'arrpic(16) = pic16
        'arrpic(17) = pic17
        ' arrpic(18) = pic18
        'arrpic(19) = pic19
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Delete = False
        total = 54
        Dim arrauthor(55) As String
        Dim arrreal(86) As String

        rec.bl.FillBookList()
        rec.rl.FillReaderList()

        Dim i As Integer
        'For i = 1 To 10
        'ListBox1.Items.Add(rec.arrbook(i).getbstr)
        'ListBox2.Items.Add(rec.arrbook(i).Title)


        'Next i

        For i = 0 To 54
            ListBox1.Items.Add(rec.bl.arrbook(i).getbstr)
        Next i
        For j = 0 To 85
            arrreal(j) = rec.rl.arrreaders(j).name + " -- "
            For i = 0 To 54
                arrreal(j) = arrreal(j) + (Str(rec.rl.arrreaders(j).arrratings(i)))
            Next i
            ListBox2.Items.Add(arrreal(j))
        Next j
        picarray()
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        If (Delete = False) Then
            AddBtn.Visible = True
            DeleteBtn.Visible = True
            ChangeBtn.Visible = True

            ListBox4.Items.Clear()
            ListBox5.Items.Clear()
            ListBox6.Items.Clear()
            ListBox3.Items.Clear()

            For i = 0 To 84
                arrsl(i) = 0
            Next
            realj = 0
            For i = 1 To 15
                arrpic(i).Visible = False
            Next
            rpos = ListBox2.SelectedIndex
            large = 0
            picflag = 1

            FindavgRatings()

            For i = 0 To 85
                ListBox3.Items.Add(arrsl(i))
            Next i

            Label1.Text = large

            For i = 1 To 54
                If rec.rl.arrreaders(realj).arrratings(i) = 5 And rec.rl.arrreaders(rpos).arrratings(i) = 0 Then
                    pathstring = ""
                    pathstring = Trim(rec.bl.arrbook(i).Title)
                    arrpic(picflag).ImageLocation = "C:\Data\CP2\BookRec\Images\attachments\" + pathstring + ".jpg"
                    If picflag < 16 Then
                        arrpic(picflag).Visible = True
                        picflag = picflag + 1
                    End If
                    ListBox4.Items.Add(rec.bl.arrbook(i).Author + " -- " + Trim(rec.bl.arrbook(i).Title))
                End If


            Next i


            '' Method A
            large = 0
            For i = 0 To 54
                avg = 0
                For j = 0 To 85
                    avg = avg + rec.rl.arrreaders(j).arrratings(i)

                Next j
                arravg(i) = avg / 86
                If arravg(i) > large And rec.rl.arrreaders(rpos).arrratings(i) = 0 Then
                    large = arravg(i)
                    realj = i
                End If
            Next i

            ListBox5.Items.Add(rec.bl.arrbook(realj).Author + " -- " + rec.bl.arrbook(realj).Title)
            pathstring = ""
            pathstring = Trim(rec.bl.arrbook(realj).Title)

            If picflag < 16 Then
                arrpic(picflag).ImageLocation = "C:\Data\CP2\BookRec\Images\attachments\" + pathstring + ".jpg"
                arrpic(picflag).Visible = True
                picflag = picflag + 1
            End If
            large = 0
            realj = 0
            For i = 0 To 54
                sum = 0
                For j = 0 To 85
                    sum = sum + arrsl(j) * rec.rl.arrreaders(j).arrratings(i)
                    'sum = sum + arrsl(i) * 10
                Next j
                arravg(i) = 0
                arravg(i) = sum
                If arravg(i) > large And rec.rl.arrreaders(rpos).arrratings(i) = 0 Then
                    large = arravg(i)
                    realj = i
                End If

            Next i

            ListBox6.Items.Add(rec.bl.arrbook(realj).Author + " -- " + rec.bl.arrbook(realj).Title)
            pathstring = ""
            pathstring = Trim(rec.bl.arrbook(realj).Title)
            If picflag < 16 Then
                arrpic(picflag).ImageLocation = "C:\Data\CP2\BookRec\Images\attachments\" + pathstring + ".jpg"
                arrpic(picflag).Visible = True
                picflag = picflag + 1
            End If
        End If

        Delete = False
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim epos As String
        'epos = Str(rec.rl.arrreaders(2).arrratings(1))
        Label6.Text = rec.bl.temp.Author


    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        Label1.Text = ListBox3.SelectedIndex
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click

        Delete = True
        ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
    End Sub

    Function RemoveAt(Of T)(ByVal arr As T(), ByVal index As Integer) As T()
        Dim uBound = arr.GetUpperBound(0)
        Dim lBound = arr.GetLowerBound(0)
        Dim arrLen = uBound - lBound

        If index < lBound OrElse index > uBound Then
            Throw New ArgumentOutOfRangeException(
            String.Format("Index must be from {0} to {1}.", lBound, uBound))

        Else
            'create an array 1 element less than the input array
            Dim outArr(arrLen - 1) As T
            'copy the first part of the input array
            Array.Copy(arr, 0, outArr, 0, index)
            'then copy the second part of the input array
            Array.Copy(arr, index + 1, outArr, index, uBound - index)

            Return outArr
        End If
    End Function

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Form3.Show()

        For i = 0 To 54
            Form2.ListBox1.Items.Add(rec.bl.arrbook(i).getbstr)
        Next i
    End Sub

    Private Sub ChangeBtn_Click(sender As Object, e As EventArgs) Handles ChangeBtn.Click
        Form2.Show()

        Form2.TextBox1.Text = rec.rl.arrreaders(ListBox2.SelectedIndex).name

        For i = 0 To 54
            Form2.TextBox2.Text += Str(rec.rl.arrreaders(ListBox2.SelectedIndex).arrratings(i)) + " "
        Next i

        For i = 0 To 54
            Form2.ListBox1.Items.Add(rec.bl.arrbook(i).getbstr)
        Next i

        Delete = True
        ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
