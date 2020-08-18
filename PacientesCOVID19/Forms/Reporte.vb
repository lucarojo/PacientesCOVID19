Imports System.Data.OleDb

Public Class Reporte
    Private Sub Button_Buscar_Click(sender As Object, e As EventArgs) Handles Button_Buscar.Click
        fx_buscar()
    End Sub

    Private Sub fx_buscar()
        DataGridView_Reporte.Rows.Clear()
        Dim cnx As OleDbConnection = New OleDbConnection(My.Settings.PacientesCOVID191ConnectionString)
        Dim sql As String = "SELECT Pacientes.Nombre, Pacientes.[Fecha Nacimiento], Pacientes.[Fecha de Ingreso], MarcadoresInflamatorios.[Marcador Inflamatorio], DetalleRegistroMarcadores.Resultado, RegistroMarcadoresInflamatorios.FechaHora, DATEDIFF('YYYY', Pacientes.[Fecha Nacimiento], RegistroMarcadoresInflamatorios.FechaHora) AS Edad, DATEDIFF('d', Pacientes.[Fecha de Ingreso], RegistroMarcadoresInflamatorios.FechaHora) AS DiasdeIngreso FROM (((DetalleRegistroMarcadores INNER JOIN MarcadoresInflamatorios ON DetalleRegistroMarcadores.MarcadorInflamatorio = MarcadoresInflamatorios.ID) INNER JOIN RegistroMarcadoresInflamatorios ON DetalleRegistroMarcadores.RegistroMarcadores = RegistroMarcadoresInflamatorios.ID) INNER JOIN Pacientes ON RegistroMarcadoresInflamatorios.Paciente = Pacientes.ID) "
        Dim where As String = ""
        If Not String.IsNullOrEmpty(TextBox_Paciente.Text) Or CheckBox_MarcadorInflam.Checked Or CheckBox_FechaHora.Checked Then
            where = " WHERE "
            If TextBox_Paciente.Text IsNot Nothing Then
                where = where + " (Pacientes.Nombre LIKE @paciente OR Pacientes.Identidad LIKE @identidad) "
            End If
            If CheckBox_MarcadorInflam.Checked Then
                If where <> " WHERE " Then
                    where = where + " AND "
                End If
                where = where + " DetalleRegistroMarcadores.[MarcadorInflamatorio] = @marcadorinflam "
            End If
            If CheckBox_FechaHora.Checked Then
                If where <> " WHERE " Then
                    where = where + " AND "
                End If
                'where = where + " RegistroMarcadoresInflamatorios.FechaHora BETWEEN @desde AND @hasta "
                where = where + " RegistroMarcadoresInflamatorios.FechaHora BETWEEN #" + DateTimePicker_Desde.Value.ToShortDateString + " 00:00:00# AND #" + DateTimePicker_Hasta.Value.ToShortDateString + " 23:59:59# "
            End If
        End If
        sql = sql + where
        Dim cmd As OleDbCommand = New OleDbCommand(sql, cnx)
        cmd.Parameters.AddWithValue("@paciente", "%" + TextBox_Paciente.Text + "%")
        cmd.Parameters.AddWithValue("@identidad", "%" + TextBox_Paciente.Text + "%")
        cmd.Parameters.AddWithValue("@marcadorinflam", ComboBox_MarcadorInflam.SelectedValue)
        'cmd.Parameters.AddWithValue("@desde", "#" + DateTimePicker_Desde.Value.ToShortDateString + " 00:00:00#")
        'cmd.Parameters.AddWithValue("@hasta", "#" + DateTimePicker_Hasta.Value.ToShortDateString + " 23:59:59#")
        Try
            cnx.Open()
            Dim query As OleDbDataReader = cmd.ExecuteReader

            If (query.HasRows) Then
                While query.Read
                    DataGridView_Reporte.Rows.Add(query(0), query(1), query(2), query(3), query(4), query(5), query(6), query(7))
                End While
            End If

            cnx.Close()
        Catch ex As OleDbException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox_MarcadorInflam_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_MarcadorInflam.CheckedChanged
        ComboBox_MarcadorInflam.Enabled = CheckBox_MarcadorInflam.Checked
    End Sub

    Private Sub CheckBox_FechaHora_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_FechaHora.CheckedChanged
        Label_Desde.Enabled = CheckBox_FechaHora.Checked
        DateTimePicker_Desde.Enabled = CheckBox_FechaHora.Checked
        Label_Hasta.Enabled = CheckBox_FechaHora.Checked
        DateTimePicker_Hasta.Enabled = CheckBox_FechaHora.Checked
    End Sub

    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PacientesCOVID191DataSet.MarcadoresInflamatorios' table. You can move, or remove it, as needed.
        Me.MarcadoresInflamatoriosTableAdapter.Fill(Me.PacientesCOVID191DataSet.MarcadoresInflamatorios)

    End Sub

    Private Sub TextBox_Paciente_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_Paciente.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                'Aqui mandas a llmar a tu funcion Buscar
                fx_buscar()
        End Select
    End Sub

    Private Sub Button_Exportar_Click(sender As Object, e As EventArgs) Handles Button_Exportar.Click
        Try
            Cursor = Cursors.WaitCursor
            ProgressBar1.Value = 0
            ProgressBar1.Visible = True
            Dim xlApp As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer
            ProgressBar1.Value = 25

            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")
            ProgressBar1.Value = 50

            For i = 0 To DataGridView_Reporte.RowCount - 2
                For j = 0 To DataGridView_Reporte.ColumnCount - 1
                    For k As Integer = 1 To DataGridView_Reporte.Columns.Count
                        xlWorkSheet.Cells(1, k) = DataGridView_Reporte.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = DataGridView_Reporte(j, i).Value.ToString()
                    Next
                Next
            Next
            ProgressBar1.Value = 75

            Dim ruta As New SaveFileDialog()
            'ruta.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            'ruta.FilterIndex = 2
            'ruta.RestoreDirectory = True
            ruta.FileName = "reporte.xlsx"
            Dim archivo As String = ""
            Cursor = Cursors.Default
            If ruta.ShowDialog() = DialogResult.OK Then
                archivo = ruta.FileName
            End If
            xlWorkSheet.SaveAs(archivo)
            xlWorkBook.Close()
            xlApp.Quit()
            ProgressBar1.Value = 100
            MsgBox("Reporte exportado con éxito.", MsgBoxStyle.Information, "Éxito")
            ProgressBar1.Visible = False
            ''releaseObject(xlApp)
            'xlApp.Dispose
            ''releaseObject(xlWorkBook)
            'xlWorkBook.Dispose
            ''releaseObject(xlWorkSheet)
            'xlWorkSheet.Dispose

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class