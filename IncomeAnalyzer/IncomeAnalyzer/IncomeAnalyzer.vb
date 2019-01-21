Public Class MainForm

    Structure Income

        Dim IdNumberInteger As Integer
        Dim NumOfPeopleInteger As Integer
        Dim AnnualIncomeDecimal As Decimal

    End Structure

    Dim CountInteger As Integer
    Dim Incomes(50) As Income
    Dim TotalInteger As Integer
    Dim AverageInteger As Integer





    Private Sub EnterDataToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EnterDataToolStripMenuItem.Click

        IDTextBox.Enabled = True
        NumOfPeopleTextBox.Enabled = True
        YearlyIncomeTextBox.Enabled = True

        IDTextBox.Focus()
        EnterDataToolStripMenuItem.Enabled = True

        Incomes(CountInteger).IdNumberInteger = Integer.Parse(IDTextBox.Text)
        Incomes(CountInteger).NumOfPeopleInteger = Integer.Parse(NumOfPeopleTextBox.Text)
        Incomes(CountInteger).AnnualIncomeDecimal = Integer.Parse(YearlyIncomeTextBox.Text)

        TotalInteger += Incomes(CountInteger).AnnualIncomeDecimal

        IDTextBox.Clear()
        NumOfPeopleTextBox.Clear()
        YearlyIncomeTextBox.Clear()


        InputDataReportToolStripMenuItem.Enabled = True
        AverageIncomeExceededReportToolStripMenuItem.Enabled = True
        IncomeBelowPovertyReportToolStripMenuItem.Enabled = True

        CountInteger += 1

        EnterDataToolStripMenuItem.Enabled = True





    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub



    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        AboutBox.Show()

    End Sub


    Private Sub PrintDocumentOne_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentOne.PrintPage

        Dim PrintFont As New Font("Arial", 12)
        Dim HeadingFont As New Font("Arial", 14)
        Dim HeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top



        Dim IDNumberString As String
        Dim NumOfPeopleString As String
        Dim AnnualIncomeString As String

        e.Graphics.DrawString("Input Data Report", PrintFont, Brushes.Black, 100, 100)
        e.Graphics.DrawString("ID", PrintFont, Brushes.Black, HorizontalPrintLocationSingle + 200, VerticalPrintLocationSingle)
        e.Graphics.DrawString("Persons", PrintFont, Brushes.Black, HorizontalPrintLocationSingle + 300, VerticalPrintLocationSingle)
        e.Graphics.DrawString("Income", PrintFont, Brushes.Black, HorizontalPrintLocationSingle + 500, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += HeightSingle

        For LoopInteger As Integer = 1 To CountInteger - 1
            IDNumberString = Incomes(LoopInteger).IdNumberInteger
            NumOfPeopleString = Incomes(LoopInteger).NumOfPeopleInteger
            AnnualIncomeString = Incomes(LoopInteger).AnnualIncomeDecimal

            e.Graphics.DrawString(IDNumberString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
            e.Graphics.DrawString(NumOfPeopleString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle + 200, VerticalPrintLocationSingle)
            e.Graphics.DrawString(AnnualIncomeString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle + 400, VerticalPrintLocationSingle)

            VerticalPrintLocationSingle += HeightSingle

        Next LoopInteger

    End Sub


    Private Sub InputDataReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InputDataReportToolStripMenuItem.Click

        PrintPreviewDialog = New PrintPreviewDialog
        PrintPreviewDialog.Document = PrintDocumentOne
        PrintPreviewDialog.ShowDialog()

    End Sub


    Private Sub PrintDocumentTwo_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentTwo.PrintPage

        Dim NumberInteger As Integer
        Dim PrintFont As New Font("Arial", 20)
        Dim HeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top + 150

        Dim MyFont As New Font("Arial", 24)

        Dim IDNumberString As String
        Dim NumOfPeopleString As String
        Dim AnnualIncomeString As String

        NumberInteger = CountInteger - 1

        If NumberInteger > 1 Then
            AverageInteger = TotalInteger / NumberInteger

        End If


        e.Graphics.DrawString("Average Incomee Exceed Report", MyFont, Brushes.Black, 100, 100)
        e.Graphics.DrawString("ID", PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        e.Graphics.DrawString("Persons", PrintFont, Brushes.Black, HorizontalPrintLocationSingle + 300, VerticalPrintLocationSingle)
        e.Graphics.DrawString("Income", PrintFont, Brushes.Black, HorizontalPrintLocationSingle + 500, VerticalPrintLocationSingle)

        VerticalPrintLocationSingle += HeightSingle

        For LoopInteger As Integer = 1 To CountInteger - 1
            If (Incomes(LoopInteger).AnnualIncomeDecimal > AverageInteger) Then
                IDNumberString = Incomes(LoopInteger).IdNumberInteger
                NumOfPeopleString = Incomes(LoopInteger).NumOfPeopleInteger
                AnnualIncomeString = Incomes(LoopInteger).AnnualIncomeDecimal

                e.Graphics.DrawString(IDNumberString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
                e.Graphics.DrawString(NumOfPeopleString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle + 200, VerticalPrintLocationSingle)
                e.Graphics.DrawString(AnnualIncomeString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle + 400, VerticalPrintLocationSingle)

                VerticalPrintLocationSingle += HeightSingle

            End If

        Next LoopInteger



    End Sub

    Private Sub AverageIncomeExceededReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AverageIncomeExceededReportToolStripMenuItem.Click

        If PrintPreviewDialog Is Nothing Then
            PrintPreviewDialog = New PrintPreviewDialog
        End If

        PrintPreviewDialog.Document = PrintDocumentTwo
        PrintPreviewDialog.ShowDialog()

    End Sub


    Private Sub IncomeBelowPovertyReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IncomeBelowPovertyReportToolStripMenuItem.Click

        PrintPreviewDialog.Document = PrintDocumentThree
        PrintPreviewDialog.ShowDialog()

    End Sub


    Private Sub PrintDocumentThree_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentThree.PrintPage


        Dim PrintFont As New Font("Arial", 20)
        Dim HeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top + 150

        Dim MyFont As New Font("Arial", 24)

        Dim TestPrintInteger As Integer
        Dim PercentDecimal As Decimal

        Dim PrintLineInteger As Integer

        e.Graphics.DrawString("Below Poverty Percentage", MyFont, Brushes.Black, 100, 100)

        For LoopInteger As Integer = 1 To CountInteger - 1
            Select Case Incomes(LoopInteger).NumOfPeopleInteger

                Case 1
                    If Incomes(LoopInteger).AnnualIncomeDecimal < 10210 Then
                        PrintLineInteger += 1
                    End If

                Case 2
                    If Incomes(LoopInteger).AnnualIncomeDecimal < 13690 Then
                        PrintLineInteger += 1
                    End If
                Case 3
                    If Incomes(LoopInteger).AnnualIncomeDecimal < 17170 Then
                        PrintLineInteger += 1
                    End If
                Case 4
                    If Incomes(LoopInteger).AnnualIncomeDecimal < 20650 Then
                        PrintLineInteger += 1
                    End If
                Case 5
                    If Incomes(LoopInteger).AnnualIncomeDecimal < 24130 Then
                        PrintLineInteger += 1
                    End If
                Case 6
                    If Incomes(LoopInteger).AnnualIncomeDecimal < 27610 Then
                        PrintLineInteger += 1
                    End If
                Case 7
                    If Incomes(LoopInteger).AnnualIncomeDecimal < 31090 Then
                        PrintLineInteger += 1
                    End If
                Case 8
                    If Incomes(LoopInteger).AnnualIncomeDecimal < 34570 Then
                        PrintLineInteger += 1
                    End If

            End Select

            If (Incomes(LoopInteger).NumOfPeopleInteger > 8) Then
                TestPrintInteger = (Incomes(LoopInteger).NumOfPeopleInteger - 8) * 3480 + 34570
                If Incomes(LoopInteger).AnnualIncomeDecimal < TestPrintInteger Then
                    PrintLineInteger += 1
                End If

                End If


        Next LoopInteger

        PercentDecimal = (PrintLineInteger / (CountInteger - 1)) * 100
        PercentDecimal = PercentDecimal.ToString()

        e.Graphics.DrawString(PercentDecimal & "%", PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)

    End Sub

    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        CountInteger = 1
        TotalInteger = 0

    

    End Sub
End Class
