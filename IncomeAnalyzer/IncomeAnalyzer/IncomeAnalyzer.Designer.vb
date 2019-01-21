<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputDataReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AverageIncomeExceededReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncomeBelowPovertyReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.NumberofMemberLabel = New System.Windows.Forms.Label()
        Me.YearlyLabel = New System.Windows.Forms.Label()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NumOfPeopleTextBox = New System.Windows.Forms.TextBox()
        Me.YearlyIncomeTextBox = New System.Windows.Forms.TextBox()
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocumentOne = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocumentTwo = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocumentThree = New System.Drawing.Printing.PrintDocument()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ReportToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(467, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterDataToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'EnterDataToolStripMenuItem
        '
        Me.EnterDataToolStripMenuItem.Name = "EnterDataToolStripMenuItem"
        Me.EnterDataToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.EnterDataToolStripMenuItem.Text = "&Enter Data"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputDataReportToolStripMenuItem, Me.AverageIncomeExceededReportToolStripMenuItem, Me.IncomeBelowPovertyReportToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportToolStripMenuItem.Text = "&Reports"
        '
        'InputDataReportToolStripMenuItem
        '
        Me.InputDataReportToolStripMenuItem.Name = "InputDataReportToolStripMenuItem"
        Me.InputDataReportToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.InputDataReportToolStripMenuItem.Text = "&Input Data Report"
        '
        'AverageIncomeExceededReportToolStripMenuItem
        '
        Me.AverageIncomeExceededReportToolStripMenuItem.Name = "AverageIncomeExceededReportToolStripMenuItem"
        Me.AverageIncomeExceededReportToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.AverageIncomeExceededReportToolStripMenuItem.Text = "&Average Income Exceeded Report"
        '
        'IncomeBelowPovertyReportToolStripMenuItem
        '
        Me.IncomeBelowPovertyReportToolStripMenuItem.Name = "IncomeBelowPovertyReportToolStripMenuItem"
        Me.IncomeBelowPovertyReportToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.IncomeBelowPovertyReportToolStripMenuItem.Text = "Income Below &Poverty Report"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.Location = New System.Drawing.Point(175, 68)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(49, 13)
        Me.IDLabel.TabIndex = 1
        Me.IDLabel.Text = "ID &Code:"
        '
        'NumberofMemberLabel
        '
        Me.NumberofMemberLabel.AutoSize = True
        Me.NumberofMemberLabel.Location = New System.Drawing.Point(37, 116)
        Me.NumberofMemberLabel.Name = "NumberofMemberLabel"
        Me.NumberofMemberLabel.Size = New System.Drawing.Size(188, 13)
        Me.NumberofMemberLabel.TabIndex = 2
        Me.NumberofMemberLabel.Text = "Number of &Members in the Household:"
        '
        'YearlyLabel
        '
        Me.YearlyLabel.AutoSize = True
        Me.YearlyLabel.Location = New System.Drawing.Point(147, 162)
        Me.YearlyLabel.Name = "YearlyLabel"
        Me.YearlyLabel.Size = New System.Drawing.Size(77, 13)
        Me.YearlyLabel.TabIndex = 3
        Me.YearlyLabel.Text = "Yearly Income:"
        '
        'IDTextBox
        '
        Me.IDTextBox.Location = New System.Drawing.Point(231, 65)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 4
        '
        'NumOfPeopleTextBox
        '
        Me.NumOfPeopleTextBox.Location = New System.Drawing.Point(231, 113)
        Me.NumOfPeopleTextBox.Name = "NumOfPeopleTextBox"
        Me.NumOfPeopleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumOfPeopleTextBox.TabIndex = 5
        '
        'YearlyIncomeTextBox
        '
        Me.YearlyIncomeTextBox.Location = New System.Drawing.Point(231, 159)
        Me.YearlyIncomeTextBox.Name = "YearlyIncomeTextBox"
        Me.YearlyIncomeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.YearlyIncomeTextBox.TabIndex = 6
        '
        'PrintPreviewDialog
        '
        Me.PrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog.Enabled = True
        Me.PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog.Name = "PrintPreviewDialog"
        Me.PrintPreviewDialog.Visible = False
        '
        'PrintDocumentOne
        '
        '
        'PrintDocumentTwo
        '
        '
        'PrintDocumentThree
        '
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 230)
        Me.Controls.Add(Me.YearlyIncomeTextBox)
        Me.Controls.Add(Me.NumOfPeopleTextBox)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.YearlyLabel)
        Me.Controls.Add(Me.NumberofMemberLabel)
        Me.Controls.Add(Me.IDLabel)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MainForm"
        Me.Text = "Income Analyzer"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnterDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputDataReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AverageIncomeExceededReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IncomeBelowPovertyReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IDLabel As System.Windows.Forms.Label
    Friend WithEvents NumberofMemberLabel As System.Windows.Forms.Label
    Friend WithEvents YearlyLabel As System.Windows.Forms.Label
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumOfPeopleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents YearlyIncomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrintPreviewDialog As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocumentOne As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDocumentTwo As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDocumentThree As System.Drawing.Printing.PrintDocument

End Class
