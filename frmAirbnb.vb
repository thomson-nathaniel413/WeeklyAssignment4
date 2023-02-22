Public Class frmAirbnb
    Private Sub frmAirbnb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' On form load, both txtNights and lblTotalCost should be cleared of all text
        ' This removes the placeholder text so it is not visible to the user
        ' Places focus immediately on txtNights for user convenience
        txtNights.Text = ""
        lblTotalCost.Text = ""
        txtNights.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' This button should exit the program
        Close()
    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        ' This button should take the contents of txtNights and calculate the cost per night
        ' It should then set the text of lblTotalCost to the result

        ' Variable declarations
        Const cdecCostPerNight As Decimal = 79D
        Dim strEnterNumberOfNights As String
        Dim intEnterNumberOfNights As Integer
        Dim decTotalCostOfStay As Decimal

        ' Obtain number of nights from txtNights
        strEnterNumberOfNights = txtNights.Text
        ' Attempt to convert to integer
        intEnterNumberOfNights = Convert.ToInt32(strEnterNumberOfNights)
        ' Calculate total cost of stay
        decTotalCostOfStay = intEnterNumberOfNights * cdecCostPerNight

        ' display result in lblTotalCost
        lblTotalCost.Text = decTotalCostOfStay.ToString("C")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This button should clear both txtNights and lblTotalCost
        ' Places focus back on txtNights for user convenience
        txtNights.Text = ""
        lblTotalCost.Text = ""
        txtNights.Focus()
    End Sub
End Class
