Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Module MyFunction
    Dim cmd As MySqlCommand
    Dim dataRead As MySqlDataReader
    Dim EmployeeID As Integer
    Public HistoryID As Integer
    Public isUpdate, isView, OpenPosition, OpenSystemUser As Boolean

    Public Sub CheckConnectionState()
        With con
            If .State = ConnectionState.Open Then .Close()
            .Open()
        End With
    End Sub
    Public Sub GotFocusText(ByVal txt As TextBox, ByVal tempDefaultText As String)
        Dim defaultText As String
        defaultText = tempDefaultText
        If txt.Text = defaultText Then
            txt.Text = ""
            txt.ForeColor = Color.Black
        End If
    End Sub
    Public Sub LostFocusText(ByVal txt As TextBox)
        txt.ForeColor = Color.Black
    End Sub

    Public Function GetYearLength(ByVal birthDate As String)
        Dim MyAge As String
        Dim dateofBirth As Date
        dateofBirth = Format(Date.Parse(birthDate), "MM/dd/yyyy")
        MyAge = DateDiff(DateInterval.Year, dateofBirth, Now)
        Return MyAge
    End Function

    Public Function GetLengthOfYear(ByVal YearJoined As String)

        Dim lengthOfYear As Integer
        Dim joined As Date
        joined = Format(Date.Parse(YearJoined), "MM/dd/yyyy")
        lengthOfYear = DateDiff(DateInterval.Year, joined, Now)
        lengthOfYear = lengthOfYear

        If lengthOfYear <= 0 Then
            lengthOfYear = 0
            Return lengthOfYear
        Else
            Return lengthOfYear
        End If

    End Function
    Public Function GetLengthOfMonth(ByVal YearJoined As String)

        Dim lengthOfMonth As Integer
        'Dim GetLenghtResult As String
        Dim joined As Date
        joined = Format(Date.Parse(YearJoined), "MM/dd/yyyy")
        lengthOfMonth = Date.Now.Month - joined.Month

        If lengthOfMonth <= 0 Then
            lengthOfMonth = lengthOfMonth + 12
            Return lengthOfMonth
        Else
            Return lengthOfMonth
        End If

    End Function
    Public Sub GetAllTextbox(ByVal group As Object, ByVal isEnable As Boolean)
        If isEnable = False Then

            For Each ctrl As Control In group.Controls
                If ctrl.GetType Is GetType(TextBox) Then
                    ctrl.Enabled = False
                End If
            Next
            For Each ctrl As Control In group.Controls
                If ctrl.GetType Is GetType(DateTimePicker) Then
                    ctrl.Enabled = False
                End If
            Next
            For Each ctrl As Control In group.Controls
                If ctrl.GetType Is GetType(ComboBox) Then
                    ctrl.Enabled = False
                End If
            Next
            For Each ctrl As Control In group.Controls
                If ctrl.GetType Is GetType(CheckBox) Then
                    ctrl.Enabled = False
                End If
            Next

        ElseIf isEnable = True Then

            For Each ctrl As Control In group.Controls
                If ctrl.GetType Is GetType(TextBox) Then
                    ctrl.Enabled = True
                End If
            Next
            For Each ctrl As Control In group.Controls
                If ctrl.GetType Is GetType(DateTimePicker) Then
                    ctrl.Enabled = True
                End If
            Next
            For Each ctrl As Control In group.Controls
                If ctrl.GetType Is GetType(ComboBox) Then
                    ctrl.Enabled = True
                End If
            Next
            For Each ctrl As Control In group.Controls
                If ctrl.GetType Is GetType(CheckBox) Then
                    ctrl.Enabled = True
                End If
            Next
            For Each ctrl As Control In group.Controls
                If ctrl.GetType Is GetType(TabControl) Then
                    ctrl.Enabled = True
                End If
            Next
        End If

    End Sub

End Module
