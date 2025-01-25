Public Class index
    Private Sub index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = operatorName
    End Sub

    Private Sub ثبتاپراتورجدیدToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ثبتاپراتورجدیدToolStripMenuItem.Click
        addOperator.ShowDialog()

    End Sub

    Private Sub انبارToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles انبارToolStripMenuItem.Click
        FormSearch.ShowDialog()

    End Sub

    Private Sub ثبتمحصولجدیدToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ثبتمحصولجدیدToolStripMenuItem.Click
        NewProduct.ShowDialog()

    End Sub

    Private Sub واحداندازهگیریToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles واحداندازهگیریToolStripMenuItem.Click
        UnitForm.ShowDialog()
    End Sub

    Private Sub ثبتمشتریجدیدToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ثبتمشتریجدیدToolStripMenuItem.Click
        addCustomer.ShowDialog()
    End Sub

    Private Sub ثبتفروشToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ثبتفروشToolStripMenuItem.Click
        sell.ShowDialog()
    End Sub
End Class