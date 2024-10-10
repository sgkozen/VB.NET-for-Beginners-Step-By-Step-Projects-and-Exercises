Public Class InventoryControl

    Structure Book
        Dim title As String
        Dim author As String
        Dim category As String
        Dim stock As String
        Dim price As Double
    End Structure

    Public books() As Book
    Public numOfBooks As Integer
    Public flagNewBook As Boolean = False
    Public n As Integer

    Private Sub InventoryControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("Books.txt") Then
            Dim fileBooks() As String = IO.File.ReadAllLines("Books.txt")
            numOfBooks = fileBooks.Count()
            ReDim books(numOfBooks - 1)
            For i As Integer = 0 To numOfBooks - 1
                Dim arr() = fileBooks(i).Split(","c)
                books(i).title = arr(0)
                books(i).author = arr(1)
                books(i).category = arr(2)
                books(i).stock = CInt(arr(3))
                books(i).price = CDbl(arr(4))
            Next

            Dim query = From book In books
                        Let title As String = book.title
                        Select title

            lstBooks.DataSource = query.ToList
        End If
    End Sub

    Private Sub Display(cat1 As String, cat2 As String)
        Dim query = From book In books
                    Where book.category = cat1 Or book.category = cat2
                    Select book.title

        lstBooks.DataSource = query.ToList

    End Sub



    Private Sub mnuAll_Click(sender As Object, e As EventArgs) Handles mnuAll.Click
        Display("N", "F")
        mnuAll.Checked = True
        mnuFiction.Checked = False
        mnuNonfiction.Checked = False
    End Sub

    Private Sub mnuFiction_Click(sender As Object, e As EventArgs) Handles mnuFiction.Click
        Display("F", "")
        mnuFiction.Checked = True
        mnuNonfiction.Checked = False
        mnuAll.Checked = False
    End Sub

    Private Sub mnuNonfiction_Click(sender As Object, e As EventArgs) Handles mnuNonfiction.Click
        Display("N", "")
        mnuNonfiction.Checked = True
        mnuFiction.Checked = False
        mnuAll.Checked = False
    End Sub

    Private Sub mnuAddBook_Click(sender As Object, e As EventArgs) Handles mnuAddBook.Click
        flagNewBook = True
        frmDetails.txtTitle.Clear()
        frmDetails.txtAuthor.Clear()
        frmDetails.txtStock.Clear()
        frmDetails.txtPrice.Clear()
        frmDetails.rdbFiction.Checked = True
        frmDetails.ShowDialog()
    End Sub

    Private Sub mnuDeleteBook_Click(sender As Object, e As EventArgs) Handles mnuDeleteBook.Click
        n = lstBooks.SelectedIndex

        If n >= 0 Then
            numOfBooks = numOfBooks - 1
            For i = n To numOfBooks - 1
                books(i) = books(i + 1)
            Next
            ReDim Preserve books(numOfBooks - 1)
            Display("N", "F")
        End If
    End Sub

    Private Sub mnuUpdateBook_Click(sender As Object, e As EventArgs) Handles mnuUpdateBook.Click
        n = lstBooks.SelectedIndex
        If n >= 0 Then
            flagNewBook = False
            frmDetails.txtTitle.Text = books(n).title
            frmDetails.txtAuthor.Text = books(n).author
            frmDetails.txtStock.Text = books(n).stock.ToString()
            frmDetails.txtPrice.Text = (books(n).price).ToString("C")

            If books(n).category = "F" Then
                frmDetails.rdbFiction.Checked = True
            Else
                frmDetails.rdbNonfiction.Checked = True
            End If
        End If
        frmDetails.ShowDialog()
    End Sub

    Private Sub mnuSaveFile_Click(sender As Object, e As EventArgs) Handles mnuSaveFile.Click
        Dim query = From book In books
                    Let line = book.title & "," & book.author & "," & book.category & "," & book.stock & "," & book.price
                    Select line

        IO.File.WriteAllLines("Books.txt", query)
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        End
    End Sub

    Private Sub mnuValuesAll_Click(sender As Object, e As EventArgs) Handles mnuValuesAll.Click
        Dim query = From book In books
                    Select book.price * book.stock

        MessageBox.Show("Value of all books is: " & query.Sum().ToString("C"), "Book value", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub mnuValuesFiction_Click(sender As Object, e As EventArgs) Handles mnuValuesFiction.Click
        Dim query = From book In books
                    Where book.category = "F"
                    Select book.price * book.stock
        MessageBox.Show("Value of all fiction books is: " & query.Sum().ToString("C"), "Book value", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub mnuValuesNonFiction_Click(sender As Object, e As EventArgs) Handles mnuValuesNonFiction.Click
        Dim query = From book In books
                    Where book.category = "N"
                    Select book.price * book.stock
        MessageBox.Show("Value of all nonfiction books is: " & query.Sum().ToString("C"), "Book value", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
