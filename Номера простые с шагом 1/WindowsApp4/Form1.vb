Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.ColumnCount = 101
        Dim i = 1
        Do While i < 101
            DataGridView1.Rows.Add()
            i += 1
        Loop

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Red
        DataGridView1.RowsDefaultCellStyle.BackColor = Color.Red
        Dim num As Integer = 2
        Dim row As Integer = 50
        Dim col As Integer = 50
        'For a As Integer = 7 To 8
        '    DataGridView1.Rows(row).Cells(a).Value = num
        '    num += 1
        '    col = a
        'Next
        Dim b As Integer
        Dim j As Integer
        Dim counta As Integer = 0
        Dim countb As Integer = 1
        While b < 50
            ' DataGridView1.Rows(row).Cells(col).Value = num
            'num += 1
            col += 1
            For a As Integer = 0 To counta
                'DataGridView1.Rows(row).Cells(col).Value = num
                DataGridView1.Rows(row).Height = 5
                DataGridView1.Columns(col).Width = 5
                For j = 2 To (num - 1)
                    If num Mod j = 0 Then
                        DataGridView1.Rows(row).Cells(col).Style.BackColor = Color.White
                    End If
                Next
                num += 1
                row -= 1
            Next
            For a As Integer = 0 To 0
                ' DataGridView1.Rows(row).Cells(col).Value = num
                DataGridView1.Rows(row).Height = 5
                DataGridView1.Columns(col).Width = 5
                For j = 2 To (num - 1)
                    If num Mod j = 0 Then
                        DataGridView1.Rows(row).Cells(col).Style.BackColor = Color.White
                    End If
                Next
                num += 1
            Next

            For a As Integer = 0 To countb
                col -= 1
                ' DataGridView1.Rows(row).Cells(col).Value = num
                DataGridView1.Rows(row).Height = 5
                DataGridView1.Columns(col).Width = 5
                For j = 2 To (num - 1)
                    If num Mod j = 0 Then
                        DataGridView1.Rows(row).Cells(col).Style.BackColor = Color.White
                    End If
                Next
                num += 1
            Next
            For a As Integer = 0 To countb
                row += 1
                'DataGridView1.Rows(row).Cells(col).Value = num
                DataGridView1.Rows(row).Height = 5
                DataGridView1.Columns(col).Width = 5
                For j = 2 To (num - 1)
                    If num Mod j = 0 Then
                        DataGridView1.Rows(row).Cells(col).Style.BackColor = Color.White
                    End If
                Next
                num += 1
            Next
            For a As Integer = 0 To countb
                col += 1
                ' DataGridView1.Rows(row).Cells(col).Value = num
                DataGridView1.Rows(row).Height = 5
                DataGridView1.Columns(col).Width = 5
                For j = 2 To (num - 1)
                    If num Mod j = 0 Then
                        DataGridView1.Rows(row).Cells(col).Style.BackColor = Color.White
                    End If
                Next
                num += 1
            Next
            'col += 1
            b += 1
            counta += 2
            countb += 2
        End While
        DataGridView1.Rows(50).Cells(50).Style.BackColor = Color.Black
    End Sub
End Class