Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Crear una instancia del CheckedListBox
        Dim checkedListBox As New CheckedListBox()

        ' Establecer propiedades del CheckedListBox
        checkedListBox.Location = New System.Drawing.Point(100, 100)
        checkedListBox.Name = "CheckedListBox"
        checkedListBox.Size = New System.Drawing.Size(245, 169)
        checkedListBox.BackColor = System.Drawing.Color.Orange
        checkedListBox.ForeColor = System.Drawing.Color.Black
        checkedListBox.FormattingEnabled = True

        ' Agregar elementos al CheckedListBox
        checkedListBox.Items.Add("Item 1")
        checkedListBox.Items.Add("Item 2")
        checkedListBox.Items.Add("Item 3")
        checkedListBox.Items.Add("Item 4")

        ' Agregar el CheckedListBox al formulario
        Me.Controls.Add(checkedListBox)
    End Sub

End Class
