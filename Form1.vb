Public Class Objectdemo

    ' Form Load event
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Form has loaded successfully!")  ' Changed MsgBox to MessageBox.Show for consistency
    End Sub

    ' Button1 Click event
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Button Click")  ' Using MessageBox.Show for consistency
    End Sub

    ' Button3 Click event
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Button Click")  ' Changed MsgBox to MessageBox.Show
    End Sub

    ' btnLoadpicture Click event
    Private Sub btnLoadpicture_Click(sender As Object, e As EventArgs) Handles btnLoadpicture.Click
        MessageBox.Show("Picture load button was clicked!")  ' Changed MsgBox to MessageBox.Show
    End Sub

    ' btnGaramond Click event
    Private Sub btnGaramond_Click(sender As Object, e As EventArgs) Handles btnGaramond.Click
        MessageBox.Show("Garamond font has been selected!")  ' Changed MsgBox to MessageBox.Show
    End Sub

    ' btnMagneto Click event
    Private Sub btnMagneto_Click(sender As Object, e As EventArgs) Handles btnMagneto.Click
        MessageBox.Show("Magneto font has been selected!")  ' Changed MsgBox to MessageBox.Show
    End Sub

    ' btnTahoma Click event
    Private Sub btnTahoma_Click(sender As Object, e As EventArgs) Handles btnTahoma.Click
        MessageBox.Show("Tahoma font has been selected!")  ' Changed MsgBox to MessageBox.Show
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Close the form if the user clicks Yes
            Me.Close()
        Else
            ' Do nothing if the user clicks No
            ' This will simply cancel the closing action
        End If
    End Sub
End Class
