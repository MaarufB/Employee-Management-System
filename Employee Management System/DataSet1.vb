Partial Class DataSet1
    Partial Public Class ReportEmployeeDataTable
        Private Sub ReportEmployeeDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.LENGTH_OF_WORKColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class ReportByStoreDataTable

    End Class
End Class
