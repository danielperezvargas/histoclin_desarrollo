Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'histoclinDataSet.bt_canc_dosisunitaria' Puede moverla o quitarla según sea necesario.
        Me.bt_canc_dosisunitariaTableAdapter.Fill(Me.histoclinDataSet.bt_canc_dosisunitaria)

        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



    End Sub


   


End Class