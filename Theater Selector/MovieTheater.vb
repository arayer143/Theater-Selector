'   Program Name: Movie Theater Ticket Selector 
'   Developer: Alexander Rayer
'   Date: March 3 2021
'   Purpose: This application lets the user select a movie and add up price of tickets based on 
'   Adult, Child, and Senior ticket prices.



Public Class MovieTheater
    Private Sub btnDisplayPrice_Click(sender As Object, e As EventArgs) Handles btnDisplayPrice.Click

        ' Declaration Section
        Dim strMovieName As String
        Dim strNumberOfTickets As String
        Dim decCostPerTicket As Decimal
        Dim decTotalCost As Decimal
        Dim decAdultTicket As Decimal = 16.59D
        Dim decChildTicket As Decimal = 13.59D
        Dim decSeniorTicket As Decimal = 15.09D


        ' Variables declared for txt boxes and link them to the display labels at bottom of program 
        strNumberOfTickets = txtNumberOfTickets.Text
        strMovieName = txtMovieName.Text
        lblMovieNameDisplay2.Text = strMovieName
        lblNumberOfTicketsDisplay2.Text = strNumberOfTickets



        ' This if statement checks to see if any input is entered in txt box Number of tickets
        If Not IsNumeric(txtNumberOfTickets.Text) Then
            MsgBox("Please enter a Movie Name with letters and Number of Tickets with a numeric value")
        End If


        ' This if statement calculates the price according to Adult, Child and Senior 
        ' radio buttons and takes in the input from the txt box txtNumberOfTicket

        If IsNumeric(txtNumberOfTickets.Text) Then

            If strNumberOfTickets > 0 Then


                If radAdultTicket.Checked Then
                    decCostPerTicket = decAdultTicket
                ElseIf radChildTicket.Checked Then
                    decCostPerTicket = decChildTicket
                ElseIf radSeniorTicket.Checked Then
                    decCostPerTicket = decSeniorTicket

                End If


                ' Displays calculations from above to show movie name, number of tickets
                ' price per ticket, and total price in the labels at bottom of program
                lblMovieNameDisplay.Visible = True
                lblMovieNameDisplay2.Visible = True
                lblNumberofTicketsDisplay.Visible = True
                lblNumberOfTicketsDisplay2.Visible = True
                lblPricePerTicketDisplay.Visible = True
                lblPricePerTicketDisplay2.Visible = True
                lblTotalPriceDisplay.Visible = True
                lblTotalPriceDisplay2.Visible = True


            Else
                ' If a negative number is entered in the text box number of tickets then a message box will pop up
                ' text box will clear and no labels will show up
                MsgBox("Please enter postive number of Tickets")

                txtNumberOfTickets.Clear()
                txtMovieName.Clear()

                ' Clears all labels at bottom of program 
                lblMovieNameDisplay.Visible = False
                lblMovieNameDisplay2.Visible = False
                lblNumberofTicketsDisplay.Visible = False
                lblNumberOfTicketsDisplay2.Visible = False
                lblPricePerTicketDisplay.Visible = False
                lblPricePerTicketDisplay2.Visible = False
                lblTotalPriceDisplay.Visible = False
                lblTotalPriceDisplay2.Visible = False

                ' Clears out all radio buttons
                radAdultTicket.Checked = False
                radChildTicket.Checked = False
                radSeniorTicket.Checked = False


            End If


            ' Code to calculate the ticket price and display the total price and
            ' price per ticket in lblTotalPriceDisplay2 and lblProcePerTicketDisplay2
            decTotalCost = strNumberOfTickets * decCostPerTicket
            lblTotalPriceDisplay2.Text = decTotalCost.ToString("C")
            lblPricePerTicketDisplay2.Text = decCostPerTicket.ToString("C")

        End If


        ' Displays message box if a number is entered into the movie name text box 
        If IsNumeric(txtMovieName.Text) Then
            MsgBox("You entered " & strMovieName.ToString() & " for the movie name. Please enter a nonnumeric input.")
            txtMovieName.Text = ""
            txtMovieName.Focus()
            txtMovieName.Clear()
            txtNumberOfTickets.Clear()


            ' Clears all labels at bottom of program
            lblMovieNameDisplay.Visible = False
            lblMovieNameDisplay2.Visible = False
            lblNumberofTicketsDisplay.Visible = False
            lblNumberOfTicketsDisplay2.Visible = False
            lblPricePerTicketDisplay.Visible = False
            lblPricePerTicketDisplay2.Visible = False
            lblTotalPriceDisplay.Visible = False
            lblTotalPriceDisplay2.Visible = False

            ' Clears out all radio buttons 
            radAdultTicket.Checked = False
            radChildTicket.Checked = False
            radSeniorTicket.Checked = False


        End If


    End Sub

    Private Sub MovieTheater_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' focuses on the two text boxes txtNumberOfTickets and txtMovieName 
        txtNumberOfTickets.Focus()
        lblTotalPriceDisplay2.Text = ""

        txtMovieName.Focus()
        lblMovieNameDisplay2.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' When this button is pressed it clears all labels and text boxes 
        txtMovieName.Clear()
        txtNumberOfTickets.Clear()
        lblMovieNameDisplay2.Text = ""
        lblNumberOfTicketsDisplay2.Text = ""
        lblPricePerTicketDisplay2.Text = ""
        lblTotalPriceDisplay2.Text = ""

        ' Clears all labels at bottom of program 
        lblMovieNameDisplay.Visible = False
        lblMovieNameDisplay2.Visible = False
        lblNumberofTicketsDisplay.Visible = False
        lblNumberOfTicketsDisplay2.Visible = False
        lblPricePerTicketDisplay.Visible = False
        lblPricePerTicketDisplay2.Visible = False
        lblTotalPriceDisplay.Visible = False
        lblTotalPriceDisplay2.Visible = False

        ' Clears all radio buttons
        radAdultTicket.Checked = False
        radChildTicket.Checked = False
        radSeniorTicket.Checked = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' When this button is pressed, it closes out of program
        Close()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click

        ' When this menu strip clear button is clicked it clears all labels and text boxes 
        txtMovieName.Clear()
        txtNumberOfTickets.Clear()
        lblMovieNameDisplay2.Text = ""
        lblNumberOfTicketsDisplay2.Text = ""
        lblPricePerTicketDisplay2.Text = ""
        lblTotalPriceDisplay2.Text = ""

        ' Clears all labels at bottom of the program 
        lblMovieNameDisplay.Visible = False
        lblMovieNameDisplay2.Visible = False
        lblNumberofTicketsDisplay.Visible = False
        lblNumberOfTicketsDisplay2.Visible = False
        lblPricePerTicketDisplay.Visible = False
        lblPricePerTicketDisplay2.Visible = False
        lblTotalPriceDisplay.Visible = False
        lblTotalPriceDisplay2.Visible = False

        ' Clears all radio buttons
        radAdultTicket.Checked = False
        radChildTicket.Checked = False
        radSeniorTicket.Checked = False

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        ' When this menu strip exit button is clicked it closes out of program 
        Close()
    End Sub


End Class
