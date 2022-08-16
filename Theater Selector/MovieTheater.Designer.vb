<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovieTheater
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MovieTheater))
        Me.mnuTheater = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblMovieName = New System.Windows.Forms.Label()
        Me.lblNumberOfTickets = New System.Windows.Forms.Label()
        Me.txtMovieName = New System.Windows.Forms.TextBox()
        Me.txtNumberOfTickets = New System.Windows.Forms.TextBox()
        Me.grpTypeOfTicket = New System.Windows.Forms.GroupBox()
        Me.radSeniorTicket = New System.Windows.Forms.RadioButton()
        Me.radAdultTicket = New System.Windows.Forms.RadioButton()
        Me.radChildTicket = New System.Windows.Forms.RadioButton()
        Me.picMovieTheater = New System.Windows.Forms.PictureBox()
        Me.lblHowToUseProgram = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDisplayPrice = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMovieNameDisplay = New System.Windows.Forms.Label()
        Me.lblMovieNameDisplay2 = New System.Windows.Forms.Label()
        Me.lblNumberofTicketsDisplay = New System.Windows.Forms.Label()
        Me.lblNumberOfTicketsDisplay2 = New System.Windows.Forms.Label()
        Me.lblPricePerTicketDisplay = New System.Windows.Forms.Label()
        Me.lblPricePerTicketDisplay2 = New System.Windows.Forms.Label()
        Me.lblTotalPriceDisplay = New System.Windows.Forms.Label()
        Me.lblTotalPriceDisplay2 = New System.Windows.Forms.Label()
        Me.lblHowToUseProgram2 = New System.Windows.Forms.Label()
        Me.mnuTheater.SuspendLayout()
        Me.grpTypeOfTicket.SuspendLayout()
        CType(Me.picMovieTheater, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuTheater
        '
        Me.mnuTheater.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuTheater.Location = New System.Drawing.Point(0, 0)
        Me.mnuTheater.Name = "mnuTheater"
        Me.mnuTheater.Size = New System.Drawing.Size(800, 24)
        Me.mnuTheater.TabIndex = 0
        Me.mnuTheater.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.FileToolStripMenuItem.Text = "FileMenu"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(158, 35)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(360, 42)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Nola Movie Theater"
        '
        'lblMovieName
        '
        Me.lblMovieName.AutoSize = True
        Me.lblMovieName.Font = New System.Drawing.Font("Goudy Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovieName.Location = New System.Drawing.Point(28, 123)
        Me.lblMovieName.Name = "lblMovieName"
        Me.lblMovieName.Size = New System.Drawing.Size(198, 27)
        Me.lblMovieName.TabIndex = 2
        Me.lblMovieName.Text = "Enter Movie Name "
        '
        'lblNumberOfTickets
        '
        Me.lblNumberOfTickets.AutoSize = True
        Me.lblNumberOfTickets.Font = New System.Drawing.Font("Goudy Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfTickets.Location = New System.Drawing.Point(28, 170)
        Me.lblNumberOfTickets.Name = "lblNumberOfTickets"
        Me.lblNumberOfTickets.Size = New System.Drawing.Size(255, 27)
        Me.lblNumberOfTickets.TabIndex = 3
        Me.lblNumberOfTickets.Text = "Enter Number of Tickets:"
        '
        'txtMovieName
        '
        Me.txtMovieName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtMovieName.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovieName.Location = New System.Drawing.Point(225, 123)
        Me.txtMovieName.Name = "txtMovieName"
        Me.txtMovieName.Size = New System.Drawing.Size(69, 27)
        Me.txtMovieName.TabIndex = 4
        '
        'txtNumberOfTickets
        '
        Me.txtNumberOfTickets.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfTickets.Location = New System.Drawing.Point(285, 170)
        Me.txtNumberOfTickets.Name = "txtNumberOfTickets"
        Me.txtNumberOfTickets.Size = New System.Drawing.Size(75, 27)
        Me.txtNumberOfTickets.TabIndex = 5
        '
        'grpTypeOfTicket
        '
        Me.grpTypeOfTicket.Controls.Add(Me.radSeniorTicket)
        Me.grpTypeOfTicket.Controls.Add(Me.radAdultTicket)
        Me.grpTypeOfTicket.Controls.Add(Me.radChildTicket)
        Me.grpTypeOfTicket.Font = New System.Drawing.Font("Goudy Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTypeOfTicket.Location = New System.Drawing.Point(97, 228)
        Me.grpTypeOfTicket.Name = "grpTypeOfTicket"
        Me.grpTypeOfTicket.Size = New System.Drawing.Size(280, 145)
        Me.grpTypeOfTicket.TabIndex = 6
        Me.grpTypeOfTicket.TabStop = False
        Me.grpTypeOfTicket.Text = "Type of Ticket"
        '
        'radSeniorTicket
        '
        Me.radSeniorTicket.AutoSize = True
        Me.radSeniorTicket.Location = New System.Drawing.Point(1, 98)
        Me.radSeniorTicket.Name = "radSeniorTicket"
        Me.radSeniorTicket.Size = New System.Drawing.Size(235, 31)
        Me.radSeniorTicket.TabIndex = 2
        Me.radSeniorTicket.TabStop = True
        Me.radSeniorTicket.Text = "Senior Ticket: $15.09"
        Me.radSeniorTicket.UseVisualStyleBackColor = True
        '
        'radAdultTicket
        '
        Me.radAdultTicket.AutoSize = True
        Me.radAdultTicket.Location = New System.Drawing.Point(1, 64)
        Me.radAdultTicket.Name = "radAdultTicket"
        Me.radAdultTicket.Size = New System.Drawing.Size(229, 31)
        Me.radAdultTicket.TabIndex = 1
        Me.radAdultTicket.TabStop = True
        Me.radAdultTicket.Text = "Adult Ticket: $16.59"
        Me.radAdultTicket.UseVisualStyleBackColor = True
        '
        'radChildTicket
        '
        Me.radChildTicket.AutoSize = True
        Me.radChildTicket.Location = New System.Drawing.Point(1, 29)
        Me.radChildTicket.Name = "radChildTicket"
        Me.radChildTicket.Size = New System.Drawing.Size(229, 31)
        Me.radChildTicket.TabIndex = 0
        Me.radChildTicket.TabStop = True
        Me.radChildTicket.Text = "Child Ticket: $13.59"
        Me.radChildTicket.UseVisualStyleBackColor = True
        '
        'picMovieTheater
        '
        Me.picMovieTheater.Image = CType(resources.GetObject("picMovieTheater.Image"), System.Drawing.Image)
        Me.picMovieTheater.Location = New System.Drawing.Point(396, 92)
        Me.picMovieTheater.Name = "picMovieTheater"
        Me.picMovieTheater.Size = New System.Drawing.Size(377, 267)
        Me.picMovieTheater.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMovieTheater.TabIndex = 7
        Me.picMovieTheater.TabStop = False
        '
        'lblHowToUseProgram
        '
        Me.lblHowToUseProgram.AutoSize = True
        Me.lblHowToUseProgram.Font = New System.Drawing.Font("Goudy Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHowToUseProgram.Location = New System.Drawing.Point(112, 387)
        Me.lblHowToUseProgram.Name = "lblHowToUseProgram"
        Me.lblHowToUseProgram.Size = New System.Drawing.Size(575, 28)
        Me.lblHowToUseProgram.TabIndex = 8
        Me.lblHowToUseProgram.Text = "Enter Movie Name, Number of tickets and Type of Ticket"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSalmon
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(193, 458)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 62)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDisplayPrice
        '
        Me.btnDisplayPrice.BackColor = System.Drawing.Color.LightSalmon
        Me.btnDisplayPrice.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayPrice.Location = New System.Drawing.Point(359, 458)
        Me.btnDisplayPrice.Name = "btnDisplayPrice"
        Me.btnDisplayPrice.Size = New System.Drawing.Size(93, 62)
        Me.btnDisplayPrice.TabIndex = 10
        Me.btnDisplayPrice.Text = "Display Price"
        Me.btnDisplayPrice.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightSalmon
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(528, 458)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 62)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblMovieNameDisplay
        '
        Me.lblMovieNameDisplay.AutoSize = True
        Me.lblMovieNameDisplay.Font = New System.Drawing.Font("Goudy Old Style", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovieNameDisplay.Location = New System.Drawing.Point(90, 541)
        Me.lblMovieNameDisplay.Name = "lblMovieNameDisplay"
        Me.lblMovieNameDisplay.Size = New System.Drawing.Size(157, 31)
        Me.lblMovieNameDisplay.TabIndex = 12
        Me.lblMovieNameDisplay.Text = "Movie Name:"
        Me.lblMovieNameDisplay.Visible = False
        '
        'lblMovieNameDisplay2
        '
        Me.lblMovieNameDisplay2.AutoSize = True
        Me.lblMovieNameDisplay2.Font = New System.Drawing.Font("Goudy Old Style", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovieNameDisplay2.Location = New System.Drawing.Point(244, 540)
        Me.lblMovieNameDisplay2.Name = "lblMovieNameDisplay2"
        Me.lblMovieNameDisplay2.Size = New System.Drawing.Size(157, 31)
        Me.lblMovieNameDisplay2.TabIndex = 13
        Me.lblMovieNameDisplay2.Text = "Movie Name "
        Me.lblMovieNameDisplay2.Visible = False
        '
        'lblNumberofTicketsDisplay
        '
        Me.lblNumberofTicketsDisplay.AutoSize = True
        Me.lblNumberofTicketsDisplay.Font = New System.Drawing.Font("Goudy Old Style", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberofTicketsDisplay.Location = New System.Drawing.Point(90, 572)
        Me.lblNumberofTicketsDisplay.Name = "lblNumberofTicketsDisplay"
        Me.lblNumberofTicketsDisplay.Size = New System.Drawing.Size(228, 31)
        Me.lblNumberofTicketsDisplay.TabIndex = 14
        Me.lblNumberofTicketsDisplay.Text = "Number Of Tickets:"
        Me.lblNumberofTicketsDisplay.Visible = False
        '
        'lblNumberOfTicketsDisplay2
        '
        Me.lblNumberOfTicketsDisplay2.AutoSize = True
        Me.lblNumberOfTicketsDisplay2.Font = New System.Drawing.Font("Goudy Old Style", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfTicketsDisplay2.Location = New System.Drawing.Point(314, 571)
        Me.lblNumberOfTicketsDisplay2.Name = "lblNumberOfTicketsDisplay2"
        Me.lblNumberOfTicketsDisplay2.Size = New System.Drawing.Size(214, 31)
        Me.lblNumberOfTicketsDisplay2.TabIndex = 15
        Me.lblNumberOfTicketsDisplay2.Text = "Number of Tickets"
        Me.lblNumberOfTicketsDisplay2.Visible = False
        '
        'lblPricePerTicketDisplay
        '
        Me.lblPricePerTicketDisplay.AutoSize = True
        Me.lblPricePerTicketDisplay.Font = New System.Drawing.Font("Goudy Old Style", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPricePerTicketDisplay.Location = New System.Drawing.Point(90, 599)
        Me.lblPricePerTicketDisplay.Name = "lblPricePerTicketDisplay"
        Me.lblPricePerTicketDisplay.Size = New System.Drawing.Size(187, 31)
        Me.lblPricePerTicketDisplay.TabIndex = 16
        Me.lblPricePerTicketDisplay.Text = "Price Per Ticket:"
        Me.lblPricePerTicketDisplay.Visible = False
        '
        'lblPricePerTicketDisplay2
        '
        Me.lblPricePerTicketDisplay2.AutoSize = True
        Me.lblPricePerTicketDisplay2.Font = New System.Drawing.Font("Goudy Old Style", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPricePerTicketDisplay2.Location = New System.Drawing.Point(283, 599)
        Me.lblPricePerTicketDisplay2.Name = "lblPricePerTicketDisplay2"
        Me.lblPricePerTicketDisplay2.Size = New System.Drawing.Size(76, 31)
        Me.lblPricePerTicketDisplay2.TabIndex = 17
        Me.lblPricePerTicketDisplay2.Text = "$0.00"
        Me.lblPricePerTicketDisplay2.Visible = False
        '
        'lblTotalPriceDisplay
        '
        Me.lblTotalPriceDisplay.AutoSize = True
        Me.lblTotalPriceDisplay.Font = New System.Drawing.Font("Goudy Old Style", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPriceDisplay.Location = New System.Drawing.Point(90, 627)
        Me.lblTotalPriceDisplay.Name = "lblTotalPriceDisplay"
        Me.lblTotalPriceDisplay.Size = New System.Drawing.Size(136, 31)
        Me.lblTotalPriceDisplay.TabIndex = 18
        Me.lblTotalPriceDisplay.Text = "Total Price:"
        Me.lblTotalPriceDisplay.Visible = False
        '
        'lblTotalPriceDisplay2
        '
        Me.lblTotalPriceDisplay2.AutoSize = True
        Me.lblTotalPriceDisplay2.Font = New System.Drawing.Font("Goudy Old Style", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPriceDisplay2.Location = New System.Drawing.Point(232, 627)
        Me.lblTotalPriceDisplay2.Name = "lblTotalPriceDisplay2"
        Me.lblTotalPriceDisplay2.Size = New System.Drawing.Size(76, 31)
        Me.lblTotalPriceDisplay2.TabIndex = 19
        Me.lblTotalPriceDisplay2.Text = "$0.00"
        Me.lblTotalPriceDisplay2.Visible = False
        '
        'lblHowToUseProgram2
        '
        Me.lblHowToUseProgram2.AutoSize = True
        Me.lblHowToUseProgram2.Font = New System.Drawing.Font("Goudy Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHowToUseProgram2.Location = New System.Drawing.Point(141, 415)
        Me.lblHowToUseProgram2.Name = "lblHowToUseProgram2"
        Me.lblHowToUseProgram2.Size = New System.Drawing.Size(529, 28)
        Me.lblHowToUseProgram2.TabIndex = 20
        Me.lblHowToUseProgram2.Text = "Click Display price when all three above are complete"
        '
        'MovieTheater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(800, 657)
        Me.Controls.Add(Me.lblHowToUseProgram2)
        Me.Controls.Add(Me.lblTotalPriceDisplay2)
        Me.Controls.Add(Me.lblTotalPriceDisplay)
        Me.Controls.Add(Me.lblPricePerTicketDisplay2)
        Me.Controls.Add(Me.lblPricePerTicketDisplay)
        Me.Controls.Add(Me.lblNumberOfTicketsDisplay2)
        Me.Controls.Add(Me.lblNumberofTicketsDisplay)
        Me.Controls.Add(Me.lblMovieNameDisplay2)
        Me.Controls.Add(Me.lblMovieNameDisplay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplayPrice)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblHowToUseProgram)
        Me.Controls.Add(Me.picMovieTheater)
        Me.Controls.Add(Me.grpTypeOfTicket)
        Me.Controls.Add(Me.txtNumberOfTickets)
        Me.Controls.Add(Me.txtMovieName)
        Me.Controls.Add(Me.lblNumberOfTickets)
        Me.Controls.Add(Me.lblMovieName)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnuTheater)
        Me.MainMenuStrip = Me.mnuTheater
        Me.Name = "MovieTheater"
        Me.Text = "Movie Theater"
        Me.mnuTheater.ResumeLayout(False)
        Me.mnuTheater.PerformLayout()
        Me.grpTypeOfTicket.ResumeLayout(False)
        Me.grpTypeOfTicket.PerformLayout()
        CType(Me.picMovieTheater, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuTheater As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblMovieName As Label
    Friend WithEvents lblNumberOfTickets As Label
    Friend WithEvents txtMovieName As TextBox
    Friend WithEvents txtNumberOfTickets As TextBox
    Friend WithEvents grpTypeOfTicket As GroupBox
    Friend WithEvents radSeniorTicket As RadioButton
    Friend WithEvents radAdultTicket As RadioButton
    Friend WithEvents radChildTicket As RadioButton
    Friend WithEvents picMovieTheater As PictureBox
    Friend WithEvents lblHowToUseProgram As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDisplayPrice As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblMovieNameDisplay As Label
    Friend WithEvents lblMovieNameDisplay2 As Label
    Friend WithEvents lblNumberofTicketsDisplay As Label
    Friend WithEvents lblNumberOfTicketsDisplay2 As Label
    Friend WithEvents lblPricePerTicketDisplay As Label
    Friend WithEvents lblPricePerTicketDisplay2 As Label
    Friend WithEvents lblTotalPriceDisplay As Label
    Friend WithEvents lblTotalPriceDisplay2 As Label
    Friend WithEvents lblHowToUseProgram2 As Label
End Class
