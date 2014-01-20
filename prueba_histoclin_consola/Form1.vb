Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        'TODO: esta línea de código carga datos en la tabla 'bt_equipos.bt_equipos' Puede moverla o quitarla según sea necesario.

        Me.ReportViewer2.RefreshReport()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.ReportViewer2.ShowExportButton = False

    End Sub


   


End Class