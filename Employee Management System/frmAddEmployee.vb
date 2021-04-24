Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Diagnostics

Public Class AddEmployeeForm
    Dim StayInStatus, EmployeePosition, Salary As String
    Dim Age As String
    Dim EmployeeID, EmployeePositionID As Integer
    Dim isIDExist, isIDExistForUpdate As Boolean
    Dim _FilePathName, _DirPathName, _FileID, _FileName As String
    '

    Private Sub CheckIDForUpdate()
        Try
            CheckConnectionState()
            cmd = New MySqlCommand("Select * from employee_info where EmployeeIDNo=@employeeid", con)
            cmd.Parameters.AddWithValue("@employeeid", EmployeeIDNo.Text)
            DataRead = cmd.ExecuteReader
            'If DataRead.HasRows > 1 Then
            'While DataRead.Read = True
            'MessageBox.Show("The Employee ID is already existing.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
            'isIDExistForUpdate = True
            'EmployeeIDNo.Focus()
            'End While
            'isIDExistForUpdate = True
            'Else
            'isIDExistForUpdate = False
            'End If

            Dim dt = New DataTable
            dt.Load(DataRead)
            If (dt.Rows.Count > 1) Then
                MessageBox.Show("The Employee ID is already existing.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                isIDExistForUpdate = True
            Else
                isIDExistForUpdate = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            DataRead.Close()
            con.Close()
        End Try
    End Sub

    Private Sub CheckEmployeeID()
        Try
            CheckConnectionState()
            cmd = New MySqlCommand("Select * from employee_info where EmployeeIDNo=@employeeid", con)
            cmd.Parameters.AddWithValue("@employeeid", EmployeeIDNo.Text)
            DataRead = cmd.ExecuteReader
            If DataRead.HasRows Then
                If DataRead.Read = True Then
                    MessageBox.Show("The Employee ID is already existing.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    isIDExist = True
                    'EmployeeIDNo.Focus()
                End If
            Else
                isIDExist = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            DataRead.Close()
            con.Close()
        End Try
    End Sub

    Private Sub AddHistory()
        Try
            CheckConnectionState()
            cmd = New MySqlCommand("insert into employee_history(Employee, Position, DateFrom, DateTo, Company, WorkDescription, Remark) " _
                                                         & "values(@Employee, @Position, @From, @To, @Company, @WorkDescription, @Remark)", con)

            cmd.Parameters.AddWithValue("@Employee", EmployeeIDNo.Text)
            cmd.Parameters.AddWithValue("@Position", Positiontxt.Text)
            cmd.Parameters.AddWithValue("@From", DateStartedDTP.Value.ToString("MM/dd/yyyy"))
            cmd.Parameters.AddWithValue("@To", "PRESENT")
            cmd.Parameters.AddWithValue("@Company", Storetxt.Text)
            cmd.Parameters.AddWithValue("@WorkDescription", "CURRENTLY WORKING AS " & Positiontxt.Text & " " & "AT " & Storetxt.Text)
            cmd.Parameters.AddWithValue("@Remark", "PRESENT")
            cmd.ExecuteNonQuery()
            'MessageBox.Show("Employee history is successfully saved to the database.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try

    End Sub
    Private Sub AddEmployee()

        Try
            CheckConnectionState()
            'cmd = New MySqlCommand("Select * from employee_info where EmployeeIDNo=@employeeid", con)
            'cmd.Parameters.AddWithValue("@employeeid", EmployeeIDNo.Text)
            'DataRead = cmd.ExecuteReader
            'If DataRead.HasRows Then
            '    If DataRead.Read = True Then
            '        MessageBox.Show("The Employee ID is already existing.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '        EmployeeIDNo.Focus()
            '    End If
            'Else


            ' The comment section here is not belong to the comment section above
            'If IsNothing(PictureBox1.Image) Then
            'MessageBox.Show("Please Select Image.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Else
            DataRead.Close()
                    'Dim filesize As UInt32
                    Dim mstream As New System.IO.MemoryStream()
                    PictureBox1.Image.Save(mstream, Imaging.ImageFormat.Jpeg)
                    Dim arrImage() As Byte = mstream.GetBuffer()
                    mstream.Close()
                'MessageBox.Show(filesize)

                cmd = New MySqlCommand("insert into employee_info(" _
                                                                 & "EmployeeIDNo, FirstName, LastName, MiddleName, Pic, Suffix, Gender, FullName, " _
                                                                 & "Type, Address, ContactNo, DOB, POB, Citizenship,EmployeeSalary, Position, " _
                                                                 & "Religion, CivilStatus, Height, Weight, SpouseFname, SpouseLname, " _
                                                                 & "SpouseMname, SpouseSuffix, NumberOfChild, FatherFname, FatherLname, " _
                                                                 & "FatherMname, FatherOccupation, MotherFname, MotherLname, MotherMname," _
                                                                 & "MotherOccupation, ContactPerson, Relationship, Store, DateStarted, " _
                                                                 & "NameOfSchool_College,YearGrad_College, NameOfSchool_HS,YearGrad_HS, NameOfSchool_Elem, YearGrad_Elem, " _
                                                                 & "IDNo_SSS, IDNo_Philhealth, IDNo_Pagibig, IDNo_TIN, EmployeeStatus, IsActive)" _
                                                                 & "values(" _
                                                                             & "@EmployeeIDNo, @Firstname, @Lastname, @Middlename, @pic, @Suffix, @Gender, @Fullname, " _
                                                                             & "@Type, @Address, @Contact, @DOB, @POB, @Citizen, @Salary, @Position, " _
                                                                             & "@Religion, @CivilStatus, @Height, @Weight, @SpouseFname, @SpouseLname, " _
                                                                             & "@SpouseMname, @SpouseSuffix, @NumberOfChild, @FatherFname, @FatherLname, " _
                                                                             & "@FatherMname, @FatherOccupation, @MotherFname, @MotherLname, @MotherMname, " _
                                                                             & "@MotherOccupation, @ContactPerson, @Relationship, @Store, @DateStarted, " _
                                                                             & "@NameOfCollege, @YearGradInCollge,@NameOfHS, @YearGradInHS,@NameOfElem, @YearGradInElem, " _
                                                                             & "@SSS, @Philhealth, @Pagibig, @TIN, @status, @IsActive)", con)


            cmd.Parameters.AddWithValue("@EmployeeIDNo", EmployeeIDNo.Text)
            cmd.Parameters.AddWithValue("@Firstname", FirstNametxt.Text)
            cmd.Parameters.AddWithValue("@Lastname", LastNametxt.Text)
            cmd.Parameters.AddWithValue("@Middlename", MiddleNametxt.Text)
            cmd.Parameters.AddWithValue("@pic", arrImage)
            cmd.Parameters.AddWithValue("@Suffix", Suffixtxt.Text)
            cmd.Parameters.AddWithValue("@Gender", Gendertxt.Text)
            cmd.Parameters.AddWithValue("@Fullname", LastNametxt.Text & ", " & FirstNametxt.Text & " " & MiddleNametxt.Text)
            cmd.Parameters.AddWithValue("@Type", EmployeeType.Text)
            cmd.Parameters.AddWithValue("@Address", Addresstxt.Text)
            cmd.Parameters.AddWithValue("@Contact", MobileNotxt.Text)
            cmd.Parameters.AddWithValue("@DOB", DOBtxt.Value.ToString(Format("MM/dd/yyyy")))
            cmd.Parameters.AddWithValue("@POB", POBtxt.Text)
            cmd.Parameters.AddWithValue("@Citizen", Citizenshiptxt.Text)
            cmd.Parameters.AddWithValue("@Salary", Salarytxt.Text)
            cmd.Parameters.AddWithValue("@Position", EmployeePositionID)
            cmd.Parameters.AddWithValue("@Religion", Religiontxt.Text)
            cmd.Parameters.AddWithValue("@CivilStatus", CivilStatustxt.Text)
            cmd.Parameters.AddWithValue("@Height", Heighttxt.Text)
            cmd.Parameters.AddWithValue("@Weight", Weighttxt.Text)
            cmd.Parameters.AddWithValue("@SpouseFname", SpouseFnametxt.Text)
            cmd.Parameters.AddWithValue("@SpouseLname", SpouseLnametxt.Text)
            cmd.Parameters.AddWithValue("@SpouseMname", SpouseMnametxt.Text)
            cmd.Parameters.AddWithValue("@SpouseSuffix", SpouseSuffixtxt.Text)
            cmd.Parameters.AddWithValue("@NumberOfChild", NumberOfChildtxt.Text)
            cmd.Parameters.AddWithValue("@FatherFname", FatherFnametxt.Text)
            cmd.Parameters.AddWithValue("@FatherLname", FatherLnametxt.Text)
            cmd.Parameters.AddWithValue("@FatherMname", FatherMnametxt.Text)
            cmd.Parameters.AddWithValue("@FatherOccupation", FatherOccuptxt.Text)
            cmd.Parameters.AddWithValue("@MotherFname", MotherFnametxt.Text)
            cmd.Parameters.AddWithValue("@MotherLname", MotherLnametxt.Text)
            cmd.Parameters.AddWithValue("@MotherMname", MotherMnametxt.Text)
            cmd.Parameters.AddWithValue("@MotherOccupation", MotherOccuptxt.Text)
            cmd.Parameters.AddWithValue("@ContactPerson", ContactPersontxt.Text)
            cmd.Parameters.AddWithValue("@Relationship", Relationshiptxt.Text)
            cmd.Parameters.AddWithValue("@Store", Storetxt.Text)
            cmd.Parameters.AddWithValue("@DateStarted", DateStartedDTP.Value.ToString("MM/dd/yyyy"))
            cmd.Parameters.AddWithValue("@NameOfCollege", CollegeNameTxt.Text)
            cmd.Parameters.AddWithValue("@YearGradInCollge", CollegeGradTxt.Text)
            cmd.Parameters.AddWithValue("@NameOfHS", HSNameTxt.Text)
            cmd.Parameters.AddWithValue("@YearGradInHS", HSGradTxt.Text)
            cmd.Parameters.AddWithValue("@NameOfElem", ElemNameTxt.Text)
            cmd.Parameters.AddWithValue("@YearGradInElem", ElemGradTxt.Text)
            cmd.Parameters.AddWithValue("@SSS", SSSIDTxt.Text)
            cmd.Parameters.AddWithValue("@Philhealth", PhilIDTxt.Text)
            cmd.Parameters.AddWithValue("@Pagibig", PagIDTxt.Text)
            cmd.Parameters.AddWithValue("@TIN", TINIDTxt.Text)
            cmd.Parameters.AddWithValue("@status", "1")
            cmd.Parameters.AddWithValue("@IsActive", EmployeeStatus.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Successfully saved.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)

            AddHistory()
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
            DataRead.Close()
        End Try
    End Sub
    Private Sub UpdateEmployee()
        Try

            isUpdate = True

            con.Open()

            cmd = New MySqlCommand("Select * from employee_info where EmployeeIDNo=@employeeid", con)
            cmd.Parameters.AddWithValue("@employeeid", EmployeeIDNo.Text)
            DataRead = cmd.ExecuteReader
            If DataRead.HasRows > 1 Then
                If DataRead.Read = True Then
                    MessageBox.Show("The Employee ID is already existing.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If IsNothing(PictureBox1.Image) Then
                    MessageBox.Show("Please Select Image.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    DataRead.Close()
                    'Dim filesize As UInt32
                    Dim mstream As New System.IO.MemoryStream()
                    PictureBox1.Image.Save(mstream, Imaging.ImageFormat.Jpeg)
                    Dim arrImage() As Byte = mstream.GetBuffer()
                    mstream.Close()
                    'MessageBox.Show(filesize)



                    cmd = New MySqlCommand("update `employee_info` Set `EmployeeIDNo`=@EmployeeIDNo, `FirstName`=@Firstname, `LastName`=@Lastname, `MiddleName`=@Middlename, `Pic`=@pic, `Suffix`=@Suffix, `Gender`=@Gender, `FullName`=@Fullname, " _
                                                                 & "`Type`=@Type, `Address`=@Address, `ContactNo`=@Contact, `DOB`=@DOB, `POB`=@POB, `Citizenship`=@Citizen, `EmployeeSalary`=@Salary, `Position`=@Position, " _
                                                                 & "`Religion`=@Religion, `CivilStatus`=@CivilStatus, `Height`=@Height, `Weight`=@Weight, `SpouseFname`=@SpouseFname, `SpouseLname`=@SpouseLname, " _
                                                                 & "`SpouseMname`=@SpouseMname, `SpouseSuffix`=@SpouseSuffix, `NumberOfChild`=@NumberOfChild, `FatherFname`=@FatherFname, `FatherLname`=@FatherLname, " _
                                                                 & "`FatherMname`=@FatherMname, `FatherOccupation`=@FatherOccupation, `MotherFname`=@MotherFname, `MotherLname`=@MotherLname, `MotherMname`=@MotherMname," _
                                                                 & "`MotherOccupation`=@MotherOccupation, `ContactPerson`=@ContactPerson, `Relationship`=@Relationship, `Store`=@Store, `DateStarted`=@DateStarted, " _
                                                                 & "`NameOfSchool_College`=@NameOfCollege, `YearGrad_College`=@YearGradInCollge, `NameOfSchool_HS`=@NameOfHS, `YearGrad_HS`=@YearGradInHS, `NameOfSchool_Elem`=@NameOfElem, `YearGrad_Elem`=@YearGradInElem, " _
                                                                 & "`IDNo_SSS`=@SSS, `IDNo_Philhealth`=@Philhealth, `IDNo_Pagibig`=@Pagibig, `IDNo_TIN`=@TIN, `IsActive`=@IsActive where employeeid like'" & PersonID & "'", con)

                    cmd.Parameters.AddWithValue("@EmployeeIDNo", EmployeeIDNo.Text)
                    cmd.Parameters.AddWithValue("@Firstname", FirstNametxt.Text)
                    cmd.Parameters.AddWithValue("@Lastname", LastNametxt.Text)
                    cmd.Parameters.AddWithValue("@Middlename", MiddleNametxt.Text)
                    cmd.Parameters.AddWithValue("@pic", arrImage)
                    cmd.Parameters.AddWithValue("@Suffix", Suffixtxt.Text)
                    cmd.Parameters.AddWithValue("@Gender", Gendertxt.Text)
                    cmd.Parameters.AddWithValue("@Fullname", LastNametxt.Text & ", " & FirstNametxt.Text & " " & MiddleNametxt.Text)
                    'cmd.Parameters.AddWithValue("@StayStatus", StayInStatus)
                    cmd.Parameters.AddWithValue("@Type", EmployeeType.Text)
                    cmd.Parameters.AddWithValue("@Address", Addresstxt.Text)
                    cmd.Parameters.AddWithValue("@Contact", MobileNotxt.Text)
                    cmd.Parameters.AddWithValue("@DOB", DOBtxt.Value.ToString(Format("MM/dd/yyyy")))
                    cmd.Parameters.AddWithValue("@POB", POBtxt.Text)
                    cmd.Parameters.AddWithValue("@Citizen", Citizenshiptxt.Text)
                    cmd.Parameters.AddWithValue("@Salary", Salarytxt.Text)
                    cmd.Parameters.AddWithValue("@Position", EmployeePositionID)
                    cmd.Parameters.AddWithValue("@Religion", Religiontxt.Text)
                    cmd.Parameters.AddWithValue("@CivilStatus", CivilStatustxt.Text)
                    cmd.Parameters.AddWithValue("@Height", Heighttxt.Text)
                    cmd.Parameters.AddWithValue("@Weight", Weighttxt.Text)
                    cmd.Parameters.AddWithValue("@SpouseFname", SpouseFnametxt.Text)
                    cmd.Parameters.AddWithValue("@SpouseLname", SpouseLnametxt.Text)
                    cmd.Parameters.AddWithValue("@SpouseMname", SpouseMnametxt.Text)
                    cmd.Parameters.AddWithValue("@SpouseSuffix", SpouseSuffixtxt.Text)
                    cmd.Parameters.AddWithValue("@NumberOfChild", NumberOfChildtxt.Text)
                    cmd.Parameters.AddWithValue("@FatherFname", FatherFnametxt.Text)
                    cmd.Parameters.AddWithValue("@FatherLname", FatherLnametxt.Text)
                    cmd.Parameters.AddWithValue("@FatherMname", FatherMnametxt.Text)
                    cmd.Parameters.AddWithValue("@FatherOccupation", FatherOccuptxt.Text)
                    cmd.Parameters.AddWithValue("@MotherFname", MotherFnametxt.Text)
                    cmd.Parameters.AddWithValue("@MotherLname", MotherLnametxt.Text)
                    cmd.Parameters.AddWithValue("@MotherMname", MotherMnametxt.Text)
                    cmd.Parameters.AddWithValue("@MotherOccupation", MotherOccuptxt.Text)
                    cmd.Parameters.AddWithValue("@ContactPerson", ContactPersontxt.Text)
                    cmd.Parameters.AddWithValue("@Relationship", Relationshiptxt.Text)
                    cmd.Parameters.AddWithValue("@Store", Storetxt.Text)
                    cmd.Parameters.AddWithValue("@DateStarted", DateStartedDTP.Value.ToString("MM/dd/yyyy"))
                    cmd.Parameters.AddWithValue("@NameOfCollege", CollegeNameTxt.Text)
                    cmd.Parameters.AddWithValue("@YearGradInCollge", CollegeGradTxt.Text)
                    cmd.Parameters.AddWithValue("@NameOfHS", HSNameTxt.Text)
                    cmd.Parameters.AddWithValue("@YearGradInHS", HSGradTxt.Text)
                    cmd.Parameters.AddWithValue("@NameOfElem", ElemNameTxt.Text)
                    cmd.Parameters.AddWithValue("@YearGradInElem", ElemGradTxt.Text)
                    cmd.Parameters.AddWithValue("@SSS", SSSIDTxt.Text)
                    cmd.Parameters.AddWithValue("@Philhealth", PhilIDTxt.Text)
                    cmd.Parameters.AddWithValue("@Pagibig", PagIDTxt.Text)
                    cmd.Parameters.AddWithValue("@TIN", TINIDTxt.Text)
                    cmd.Parameters.AddWithValue("@IsActive", EmployeeStatus.Text)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Successfully updated.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            DataRead.Close()
            con.Close()
        End Try
    End Sub

    Private Sub GetImage()
        Try
            If isUpdate = True Then
                Dim adapter As New MySqlDataAdapter
                Dim cmd As New MySqlCommand
                adapter.SelectCommand = cmd
                Dim data As DataTable
                Dim CommandBuild As MySqlCommandBuilder
                data = New DataTable

                adapter = New MySqlDataAdapter("Select Pic from employee_info where EmployeeID Like '%" & PersonID & "%'", con)
                CommandBuild = New MySqlCommandBuilder(adapter)
                adapter.Fill(data)

                Dim lb() As Byte = data.Rows(0).Item("Pic")
                Dim lstr As New System.IO.MemoryStream(lb)

                PictureBox1.Image = Image.FromStream(lstr)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

                End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub DisplayEmployee()
        Try
            isUpdate = True
            ' GetImage()
            con.Open()

            'cmd = New MySqlCommand("Select * from employee_info inner join employee_position on employee_info.position=employee_position.positionID where EmployeeID like'" & PersonID & "'", con)
            cmd = New MySqlCommand("Select * from employee_info inner join employee_position on employee_info.Position=employee_position.PositionID where EmployeeID like'" & PersonID & "'", con)
            DataRead = cmd.ExecuteReader

            While DataRead.Read = True

                EmployeeIDNo.Text = DataRead("EmployeeIDNo").ToString
                FirstNametxt.Text = DataRead("FirstName").ToString()
                LastNametxt.Text = DataRead("LastName").ToString()
                MiddleNametxt.Text = DataRead("MiddleName").ToString()
                Suffixtxt.Text = DataRead("Suffix").ToString()
                Addresstxt.Text = DataRead("Address").ToString()
                MobileNotxt.Text = DataRead("ContactNo").ToString()
                DOBtxt.Text = DataRead("DOB").ToString()
                POBtxt.Text = DataRead("POB").ToString()
                Citizenshiptxt.Text = DataRead("Citizenship").ToString()
                Religiontxt.Text = DataRead("Religion").ToString()
                Gendertxt.Text = DataRead("Gender").ToString()
                CivilStatustxt.Text = DataRead("CivilStatus").ToString()
                Heighttxt.Text = DataRead("Height").ToString()
                Weighttxt.Text = DataRead("Weight").ToString()
                SpouseFnametxt.Text = DataRead("SpouseFname").ToString()
                SpouseLnametxt.Text = DataRead("SpouseLname").ToString()
                SpouseMnametxt.Text = DataRead("SpouseMname").ToString()
                SpouseSuffixtxt.Text = DataRead("SpouseSuffix").ToString()
                FatherFnametxt.Text = DataRead("FatherFname").ToString()
                FatherLnametxt.Text = DataRead("FatherLname").ToString()
                FatherMnametxt.Text = DataRead("FatherMname").ToString()
                FatherOccuptxt.Text = DataRead("FatherOccupation").ToString()
                MotherFnametxt.Text = DataRead("MotherFname").ToString()
                MotherLnametxt.Text = DataRead("MotherLname").ToString()
                MotherMnametxt.Text = DataRead("MotherMname").ToString()
                MotherOccuptxt.Text = DataRead("MotherOccupation").ToString()
                ContactPersontxt.Text = DataRead("ContactPerson").ToString()
                Relationshiptxt.Text = DataRead("Relationship").ToString()
                Salarytxt.Text = FormatNumber(DataRead("EmployeeSalary"), 2, TriState.True).ToString
                Storetxt.Text = DataRead("Store").ToString()
                DateStartedDTP.Text = DataRead("DateStarted").ToString()
                ElemNameTxt.Text = DataRead("NameOfSchool_Elem").ToString()
                ElemGradTxt.Text = DataRead("YearGrad_Elem").ToString()
                HSNameTxt.Text = DataRead("NameOfSchool_HS").ToString()
                HSGradTxt.Text = DataRead("YearGrad_HS").ToString()
                CollegeNameTxt.Text = DataRead("NameOfSchool_College").ToString()
                CollegeGradTxt.Text = DataRead("YearGrad_College").ToString()
                SSSIDTxt.Text = DataRead("IDNo_SSS").ToString()
                PagIDTxt.Text = DataRead("IDNo_Philhealth").ToString()
                PhilIDTxt.Text = DataRead("IDNo_Pagibig").ToString()
                TINIDTxt.Text = DataRead("IDNo_TIN").ToString()
                EmployeeType.Text = DataRead("Type").ToString
                EmployeeStatus.Text = DataRead("IsActive").ToString

                'If DataRead("StayInOut") = "Stay In" Then
                'CheckStayIn.Checked = True
                'Else
                'CheckStayIn.Checked = True
                'End If

            End While

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally

            con.Close()
            DataRead.Close()

        End Try

    End Sub



    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        If ButtonAdd.Text = "&SAVE" Then
            If MessageBox.Show("Are you sure to save this to the database?", sysmessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                CheckEmployeeID()
                If isIDExist = True Then
                    EmployeeIDNo.Focus()
                ElseIf EmployeeIDNo.Text = "" Then
                    MessageBox.Show("Employee ID is required!", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    EmployeeIDNo.Focus()
                ElseIf FirstNametxt.Text = "" Or FirstNametxt.Text = "First Name..." Then
                    MessageBox.Show("Please type the employee first name.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FirstNametxt.Focus()
                ElseIf LastNametxt.Text = "" Or LastNametxt.Text = "Last Name..." Then
                    MessageBox.Show("Please type the employee last name.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LastNametxt.Focus()
                ElseIf MiddleNametxt.Text = "" Or MiddleNametxt.Text = "Middle Name..." Then
                    MessageBox.Show("Please type the employee middle name.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MiddleNametxt.Focus()
                ElseIf Suffixtxt.Text = "" Or Suffixtxt.Text = "Suffix..." Then
                    Suffixtxt.Text = "N/A"
                    Suffixtxt.Focus()
                ElseIf Addresstxt.Text = "" Or Addresstxt.Text = "Address..." Then
                    MessageBox.Show("Please type the employee address.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Addresstxt.Focus()
                ElseIf MobileNotxt.Text = "" Or MobileNotxt.Text = "Cell No..." Then
                    MessageBox.Show("Please type the employee contact number.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MobileNotxt.Focus()
                ElseIf DOBtxt.Text = "" Then
                    DOBtxt.Focus()
                ElseIf POBtxt.Text = "" Or POBtxt.Text = "Place of birth..." Then
                    MessageBox.Show("Please type the employee place of birth.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    POBtxt.Focus()
                ElseIf Citizenshiptxt.Text = "" Or Citizenshiptxt.Text = "Select..." Then
                    MessageBox.Show("Please type the employee citizen.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Citizenshiptxt.Focus()
                ElseIf Religiontxt.Text = "" Or Religiontxt.Text = "Religion..." Then
                    MessageBox.Show("Please type the employee religion.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Religiontxt.Focus()
                ElseIf Gendertxt.Text = "" Then
                    MessageBox.Show("Please select gender.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Gendertxt.Focus()
                ElseIf CivilStatustxt.Text = "" Or CivilStatustxt.Text = "Select..." Then
                    MessageBox.Show("Please type civil status.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CivilStatustxt.Focus()
                ElseIf Heighttxt.Text = "" Then
                    Heighttxt.Text = "N/A"
                ElseIf Weighttxt.Text = "" Then
                    Weighttxt.Text = "N/A"
                ElseIf SpouseFnametxt.Text = "" Or SpouseFnametxt.Text = "First Name..." Then
                    TabControl1.SelectedIndex = 0
                    TabControl3.SelectedIndex = 0
                    SpouseFnametxt.Text = "N/A"
                ElseIf SpouseLnametxt.Text = "" Or SpouseLnametxt.Text = "Last Name..." Then
                    SpouseLnametxt.Text = "N/A"
                ElseIf SpouseMnametxt.Text = "" Or SpouseMnametxt.Text = "Middle Name..." Then
                    SpouseMnametxt.Text = "N/A"
                ElseIf SpouseSuffixtxt.Text = "" Or SpouseSuffixtxt.Text = "Suffix..." Then
                    SpouseSuffixtxt.Text = "N/A"
                ElseIf FatherFnametxt.Text = "" Or FatherFnametxt.Text = "First Name... " Then
                    TabControl1.SelectedIndex = 0
                    TabControl3.SelectedIndex = 0
                    FatherFnametxt.Text = "N/A"
                ElseIf FatherLnametxt.Text = "" Or FatherLnametxt.Text = "Last Name..." Then
                    FatherLnametxt.Text = "N/A"
                ElseIf FatherMnametxt.Text = "" Or FatherMnametxt.Text = "Middle Name..." Then
                    FatherMnametxt.Text = "N/A"
                ElseIf FatherOccuptxt.Text = "" Or FatherOccuptxt.Text = "Occupation..." Then
                    FatherOccuptxt.Text = "N/A"
                ElseIf MotherFnametxt.Text = "" Or MotherFnametxt.Text = "First Name..." Then
                    MotherFnametxt.Text = "N/A"
                ElseIf MotherLnametxt.Text = "" Or MotherLnametxt.Text = "Last Name..." Then
                    MotherLnametxt.Text = "N/A"
                ElseIf MotherMnametxt.Text = "" Or MotherMnametxt.Text = "Middle Name..." Then
                    MotherMnametxt.Text = "N/A"
                ElseIf MotherOccuptxt.Text = "" Or MotherOccuptxt.Text = "Occupation" Then
                    MotherOccuptxt.Text = "N/A"
                ElseIf ContactPersontxt.Text = "" Then
                    ContactPersontxt.Text = "N/A"
                ElseIf Relationshiptxt.Text = "" Then
                    Relationshiptxt.Text = "N/A"
                ElseIf Positiontxt.Text = "" Then
                    Positiontxt.SelectedIndex = 0
                ElseIf Salarytxt.Text = "" Then
                    MessageBox.Show("Please input the salary.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Salarytxt.Focus()
                ElseIf Storetxt.Text = "" Then
                    MessageBox.Show("Please fill the store name.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Storetxt.Focus()
                ElseIf ElemNameTxt.Text = "" Or ElemNameTxt.Text = "Type the name of school and address..." Then
                    ElemNameTxt.Text = "N/A"
                    TabControl1.SelectedIndex = 1
                    ElemNameTxt.Focus()
                ElseIf ElemGradTxt.Text = "" Or ElemGradTxt.Text = "Type year..." Then
                    ElemGradTxt.Text = "N/A"
                    TabControl1.SelectedIndex = 1
                    ElemGradTxt.Focus()
                ElseIf HSNameTxt.Text = "" Or HSNameTxt.Text = "Type the name of school and address..." Then
                    HSNameTxt.Text = "N/A"
                    TabControl1.SelectedIndex = 1
                    HSNameTxt.Focus()
                ElseIf HSGradTxt.Text = "" Or HSGradTxt.Text = "Type year..." Then
                    HSGradTxt.Text = "N/A"
                    TabControl1.SelectedIndex = 1
                    HSGradTxt.Focus()
                ElseIf CollegeNameTxt.Text = "" Or CollegeNameTxt.Text = "Type the name of school and address..." Then
                    CollegeNameTxt.Text = "N/A"
                    TabControl1.SelectedIndex = 1
                    CollegeNameTxt.Focus()
                ElseIf CollegeGradTxt.Text = "" Or CollegeGradTxt.Text = "Type year..." Then
                    CollegeGradTxt.Text = "N/A"
                    TabControl1.SelectedIndex = 1
                    CollegeGradTxt.Focus()
                ElseIf SSSIDTxt.Text = "" Then
                    TabControl1.SelectedIndex = 2
                    TabControl2.SelectedIndex = 0
                    SSSIDTxt.Text = "N/A"
                    SSSIDTxt.Focus()
                ElseIf PagIDTxt.Text = "" Then
                    TabControl1.SelectedIndex = 2
                    TabControl2.SelectedIndex = 0
                    PagIDTxt.Text = "N/A"
                    PagIDTxt.Focus()
                ElseIf PhilIDTxt.Text = "" Then
                    TabControl1.SelectedIndex = 2
                    TabControl2.SelectedIndex = 0
                    PhilIDTxt.Text = "N/A"
                    PhilIDTxt.Focus()
                ElseIf TINIDTxt.Text = "" Then
                    TabControl1.SelectedIndex = 2
                    TabControl2.SelectedIndex = 0
                    TINIDTxt.Text = "N/A"
                    TINIDTxt.Focus()
                ElseIf EmployeeStatus.Text = "" Then
                    EmployeeStatus.Focus()
                ElseIf EmployeeType.Text = "" Then
                    EmployeeType.Focus()
                ElseIf IsNothing(PictureBox1.Image) Then
                    MessageBox.Show("Please Select Image.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Browsebtn_Click(sender, e)
                Else
                    AddEmployee()
                    'UpdateEmployeePosition()
                    frmEmployee.Button1.PerformClick()
                    Me.Dispose()
                End If
            End If
        ElseIf ButtonAdd.Text = "&EDIT" Then
            EnableControls()
            ButtonAdd.Text = "&UPDATE"
        ElseIf ButtonAdd.Text = "&UPDATE" Then
            If MessageBox.Show("Are you sure to update this to the database?", sysmessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                CheckIDForUpdate()
                If isIDExistForUpdate = True Then
                    EmployeeIDNo.Focus()
                ElseIf EmployeeIDNo.Text = "" Then
                    MessageBox.Show("Employee ID is required!", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    EmployeeIDNo.Focus()
                ElseIf FirstNametxt.Text = "" Or FirstNametxt.Text = "First Name..." Then
                    MessageBox.Show("Please type the employee first name.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FirstNametxt.Focus()
                ElseIf LastNametxt.Text = "" Or LastNametxt.Text = "Last Name..." Then
                    MessageBox.Show("Please type the employee last name.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LastNametxt.Focus()
                ElseIf MiddleNametxt.Text = "" Or MiddleNametxt.Text = "Middle Name..." Then
                    MessageBox.Show("Please type the employee middle name.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MiddleNametxt.Focus()
                ElseIf Suffixtxt.Text = "" Or Suffixtxt.Text = "Suffix..." Then
                    Suffixtxt.Text = "N/A"
                    Suffixtxt.Focus()
                ElseIf Addresstxt.Text = "" Or Addresstxt.Text = "Address..." Then
                    MessageBox.Show("Please type the employee address.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Addresstxt.Focus()
                ElseIf MobileNotxt.Text = "" Or MobileNotxt.Text = "Cell No..." Then
                    MessageBox.Show("Please type the employee contact number.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MobileNotxt.Focus()
                ElseIf DOBtxt.Text = "" Then
                    DOBtxt.Focus()
                ElseIf POBtxt.Text = "" Or POBtxt.Text = "Place of birth..." Then
                    MessageBox.Show("Please type the employee place of birth.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    POBtxt.Focus()
                ElseIf Citizenshiptxt.Text = "" Or Citizenshiptxt.Text = "Select..." Then
                    MessageBox.Show("Please type the employee citizen.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Citizenshiptxt.Focus()
                ElseIf Religiontxt.Text = "" Or Religiontxt.Text = "Religion..." Then
                    MessageBox.Show("Please type the employee religion.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Religiontxt.Focus()
                ElseIf Gendertxt.Text = "" Then
                    MessageBox.Show("Please select gender.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Gendertxt.Focus()
                ElseIf CivilStatustxt.Text = "" Or CivilStatustxt.Text = "Select..." Then
                    MessageBox.Show("Please type civil status.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CivilStatustxt.Focus()
                ElseIf Heighttxt.Text = "" Then
                    Heighttxt.Text = "N/A"
                ElseIf Weighttxt.Text = "" Then
                    Weighttxt.Text = "N/A"
                ElseIf SpouseFnametxt.Text = "" Or SpouseFnametxt.Text = "First Name..." Then
                    TabControl1.SelectedIndex = 0
                    TabControl3.SelectedIndex = 0
                    SpouseFnametxt.Text = "N/A"
                ElseIf SpouseLnametxt.Text = "" Or SpouseLnametxt.Text = "Last Name..." Then
                    SpouseLnametxt.Text = "N/A"
                ElseIf SpouseMnametxt.Text = "" Or SpouseMnametxt.Text = "Middle Name..." Then
                    SpouseMnametxt.Text = "N/A"
                ElseIf SpouseSuffixtxt.Text = "" Or SpouseSuffixtxt.Text = "Suffix..." Then
                    SpouseSuffixtxt.Text = "N/A"
                ElseIf FatherFnametxt.Text = "" Or FatherFnametxt.Text = "First Name... " Then
                    TabControl1.SelectedIndex = 0
                    TabControl3.SelectedIndex = 0
                    FatherFnametxt.Text = "N/A"
                ElseIf FatherLnametxt.Text = "" Or FatherLnametxt.Text = "Last Name..." Then
                    FatherLnametxt.Text = "N/A"
                ElseIf FatherMnametxt.Text = "" Or FatherMnametxt.Text = "Middle Name..." Then
                    FatherMnametxt.Text = "N/A"
                ElseIf FatherOccuptxt.Text = "" Or FatherOccuptxt.Text = "Occupation..." Then
                    FatherOccuptxt.Text = "N/A"
                ElseIf MotherFnametxt.Text = "" Or MotherFnametxt.Text = "First Name..." Then
                    MotherFnametxt.Text = "N/A"
                ElseIf MotherLnametxt.Text = "" Or MotherLnametxt.Text = "Last Name..." Then
                    MotherLnametxt.Text = "N/A"
                ElseIf MotherMnametxt.Text = "" Or MotherMnametxt.Text = "Middle Name..." Then
                    MotherMnametxt.Text = "N/A"
                ElseIf MotherOccuptxt.Text = "" Or MotherOccuptxt.Text = "Occupation" Then
                    MotherOccuptxt.Text = "N/A"
                ElseIf ContactPersontxt.Text = "" Then
                    ContactPersontxt.Text = "N/A"
                ElseIf Relationshiptxt.Text = "" Then
                    Relationshiptxt.Text = "N/A"
                ElseIf Positiontxt.Text = "" Then
                    Positiontxt.SelectedIndex = 0
                ElseIf Salarytxt.Text = "" Then
                    MessageBox.Show("Please input the salary.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Salarytxt.Focus()
                ElseIf Storetxt.Text = "" Then
                    MessageBox.Show("Please fill the store name.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Storetxt.Focus()
                ElseIf ElemNameTxt.Text = "" Or ElemNameTxt.Text = "Type the name of school and address..." Then
                    ElemNameTxt.Text = "N/A"
                    TabControl1.SelectedIndex = 1
                    ElemNameTxt.Focus()
                ElseIf ElemGradTxt.Text = "" Or ElemGradTxt.Text = "Type year..." Then
                    ElemGradTxt.Text = "N/A"
                    TabControl1.SelectedIndex = 1
                    ElemGradTxt.Focus()
                ElseIf HSNameTxt.Text = "" Or HSNameTxt.Text = "Type the name of school and address..." Then
                    HSNameTxt.Text = "N/A"
                    TabControl1.SelectedIndex = 1
                    HSNameTxt.Focus()
                ElseIf HSGradTxt.Text = "" Or HSGradTxt.Text = "Type year..." Then
                    HSGradTxt.Text = "N/A"
                    TabControl1.SelectedIndex = 1
                    HSGradTxt.Focus()
                ElseIf CollegeNameTxt.Text = "" Or CollegeNameTxt.Text = "Type the name of school and address..." Then
                    CollegeNameTxt.Text = "N/A"
                    TabControl1.SelectedIndex = 1
                    CollegeNameTxt.Focus()
                ElseIf CollegeGradTxt.Text = "" Or CollegeGradTxt.Text = "Type year..." Then
                    CollegeGradTxt.Text = "N/A"
                    TabControl1.SelectedIndex = 1
                    CollegeGradTxt.Focus()
                ElseIf SSSIDTxt.Text = "" Then
                    TabControl1.SelectedIndex = 2
                    TabControl2.SelectedIndex = 0
                    SSSIDTxt.Text = "N/A"
                    SSSIDTxt.Focus()
                ElseIf PagIDTxt.Text = "" Then
                    TabControl1.SelectedIndex = 2
                    TabControl2.SelectedIndex = 0
                    PagIDTxt.Text = "N/A"
                    PagIDTxt.Focus()
                ElseIf PhilIDTxt.Text = "" Then
                    TabControl1.SelectedIndex = 2
                    TabControl2.SelectedIndex = 0
                    PhilIDTxt.Text = "N/A"
                    PhilIDTxt.Focus()
                ElseIf TINIDTxt.Text = "" Then
                    TabControl1.SelectedIndex = 2
                    TabControl2.SelectedIndex = 0
                    TINIDTxt.Text = "N/A"
                    TINIDTxt.Focus()
                ElseIf EmployeeStatus.Text = "" Then
                    EmployeeStatus.Focus()
                ElseIf EmployeeType.Text = "" Then
                    EmployeeType.Focus()
                ElseIf IsNothing(PictureBox1.Image) Then
                    MessageBox.Show("Please Select Image.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Browsebtn_Click(sender, e)
                Else
                    UpdateEmployee()
                    frmEmployee.Button1.PerformClick()
                    Me.Dispose()
                End If
            End If
        End If
    End Sub

    Private Sub Browsebtn_Click(sender As Object, e As EventArgs) Handles Browsebtn.Click
        Dim openfiledialog1 As New OpenFileDialog
        Try
            With openfiledialog1
                .InitialDirectory = "D:\Images"
                .Filter = "Image File (*.jpg)|*.jpg|(*.png)|*.png"
            End With
            If openfiledialog1.ShowDialog = DialogResult.OK Then
                Dim namefile As String = openfiledialog1.FileName
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox1.Image = Image.FromFile(namefile)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub FirstNametxt_GotFocus(sender As Object, e As EventArgs) Handles FirstNametxt.GotFocus
        GotFocusText(FirstNametxt, "First Name...")
    End Sub

    Private Sub FirstNametxt_LostFocus(sender As Object, e As EventArgs) Handles FirstNametxt.LostFocus
        LostFocusText(FirstNametxt)
    End Sub

    Private Sub LastNametxt_GotFocus(sender As Object, e As EventArgs) Handles LastNametxt.GotFocus
        GotFocusText(LastNametxt, "Last Name...")
    End Sub

    Private Sub LastNametxt_LostFocus(sender As Object, e As EventArgs) Handles LastNametxt.LostFocus
        LostFocusText(LastNametxt)
    End Sub

    Private Sub MiddleNametxt_GotFocus(sender As Object, e As EventArgs) Handles MiddleNametxt.GotFocus
        GotFocusText(MiddleNametxt, "Middle Name...")
    End Sub

    Private Sub MiddleNametxt_LostFocus(sender As Object, e As EventArgs) Handles MiddleNametxt.LostFocus
        LostFocusText(MiddleNametxt)
    End Sub

    Private Sub Suffixtxt_GotFocus(sender As Object, e As EventArgs) Handles Suffixtxt.GotFocus
        GotFocusText(Suffixtxt, "Suffix...")
    End Sub

    Private Sub Suffixtxt_LostFocus(sender As Object, e As EventArgs) Handles Suffixtxt.LostFocus
        LostFocusText(Suffixtxt)
    End Sub

    Private Sub Addresstxt_GotFocus(sender As Object, e As EventArgs) Handles Addresstxt.GotFocus
        GotFocusText(Addresstxt, "Address...")
    End Sub

    Private Sub Addresstxt_LostFocus(sender As Object, e As EventArgs) Handles Addresstxt.LostFocus
        LostFocusText(Addresstxt)
    End Sub

    Private Sub POBtxt_GotFocus(sender As Object, e As EventArgs) Handles POBtxt.GotFocus
        GotFocusText(POBtxt, "Place of birth...")
    End Sub

    Private Sub POBtxt_LostFocus(sender As Object, e As EventArgs) Handles POBtxt.LostFocus
        LostFocusText(POBtxt)
    End Sub

    Private Sub Citizenshiptxt_GotFocus(sender As Object, e As EventArgs) Handles Citizenshiptxt.GotFocus
        GotFocusText(Citizenshiptxt, "Select...")
    End Sub

    Private Sub Citizenshiptxt_LostFocus(sender As Object, e As EventArgs) Handles Citizenshiptxt.LostFocus
        LostFocusText(Citizenshiptxt)
    End Sub

    Private Sub Religiontxt_GotFocus(sender As Object, e As EventArgs) Handles Religiontxt.GotFocus
        GotFocusText(Religiontxt, "Religion...")
    End Sub

    Private Sub Religiontxt_LostFocus(sender As Object, e As EventArgs) Handles Religiontxt.LostFocus
        LostFocusText(Religiontxt)
    End Sub

    Private Sub Gendertxt_GotFocus(sender As Object, e As EventArgs) Handles Gendertxt.GotFocus

        Gendertxt.ForeColor = Color.Black
    End Sub

    Private Sub Gendertxt_LostFocus(sender As Object, e As EventArgs) Handles Gendertxt.LostFocus
        Gendertxt.ForeColor = Color.Black
    End Sub

    Private Sub CivilStatustxt_GotFocus(sender As Object, e As EventArgs) Handles CivilStatustxt.GotFocus
        GotFocusText(CivilStatustxt, "Select...")
    End Sub

    Private Sub CivilStatustxt_LostFocus(sender As Object, e As EventArgs) Handles CivilStatustxt.LostFocus
        LostFocusText(CivilStatustxt)
    End Sub

    Private Sub Heighttxt_GotFocus(sender As Object, e As EventArgs) Handles Heighttxt.GotFocus
        GotFocusText(Heighttxt, "Select...")
    End Sub

    Private Sub Heighttxt_LostFocus(sender As Object, e As EventArgs) Handles Heighttxt.LostFocus
        LostFocusText(Heighttxt)
    End Sub

    Private Sub SpouseFnametxt_GotFocus(sender As Object, e As EventArgs) Handles SpouseFnametxt.GotFocus
        GotFocusText(SpouseFnametxt, "First Name...")
    End Sub

    Private Sub SpouseFnametxt_LostFocus(sender As Object, e As EventArgs) Handles SpouseFnametxt.LostFocus
        LostFocusText(SpouseFnametxt)
    End Sub

    Private Sub SpouseLnametxt_GotFocus(sender As Object, e As EventArgs) Handles SpouseLnametxt.GotFocus
        GotFocusText(SpouseLnametxt, "Last Name...")
    End Sub

    Private Sub SpouseLnametxt_LostFocus(sender As Object, e As EventArgs) Handles SpouseLnametxt.LostFocus
        LostFocusText(SpouseLnametxt)
    End Sub

    Private Sub SpouseMnametxt_GotFocus(sender As Object, e As EventArgs) Handles SpouseMnametxt.GotFocus
        GotFocusText(SpouseMnametxt, "Middle Name...")
    End Sub

    Private Sub SpouseMnametxt_LostFocus(sender As Object, e As EventArgs) Handles SpouseMnametxt.LostFocus
        LostFocusText(SpouseMnametxt)
    End Sub

    Private Sub SpouseSuffixtxt_GotFocus(sender As Object, e As EventArgs) Handles SpouseSuffixtxt.GotFocus
        GotFocusText(SpouseSuffixtxt, "Suffix...")
    End Sub

    Private Sub SpouseSuffixtxt_LostFocus(sender As Object, e As EventArgs) Handles SpouseSuffixtxt.LostFocus
        LostFocusText(SpouseSuffixtxt)
    End Sub

    Private Sub NumberOfChildtxt_GotFocus(sender As Object, e As EventArgs) Handles NumberOfChildtxt.GotFocus
        GotFocusText(NumberOfChildtxt, "0")
    End Sub

    Private Sub NumberOfChildtxt_LostFocus(sender As Object, e As EventArgs) Handles NumberOfChildtxt.LostFocus
        LostFocusText(NumberOfChildtxt)
    End Sub

    Private Sub FatherFnametxt_GotFocus(sender As Object, e As EventArgs) Handles FatherFnametxt.GotFocus
        GotFocusText(FatherFnametxt, "First Name...")
    End Sub

    Private Sub FatherFnametxt_LostFocus(sender As Object, e As EventArgs) Handles FatherFnametxt.LostFocus
        LostFocusText(FatherFnametxt)
    End Sub

    Private Sub FatherLnametxt_GotFocus(sender As Object, e As EventArgs) Handles FatherLnametxt.GotFocus
        GotFocusText(FatherLnametxt, "Last Name...")
    End Sub

    Private Sub FatherLnametxt_LostFocus(sender As Object, e As EventArgs) Handles FatherLnametxt.LostFocus
        LostFocusText(FatherLnametxt)
    End Sub

    Private Sub FatherMnametxt_GotFocus(sender As Object, e As EventArgs) Handles FatherMnametxt.GotFocus
        GotFocusText(FatherMnametxt, "Middle Name...")
    End Sub

    Private Sub FatherMnametxt_LostFocus(sender As Object, e As EventArgs) Handles FatherMnametxt.LostFocus
        LostFocusText(FatherMnametxt)
    End Sub

    Private Sub FatherOccuptxt_GotFocus(sender As Object, e As EventArgs) Handles FatherOccuptxt.GotFocus
        GotFocusText(FatherOccuptxt, "Occupation...")
    End Sub

    Private Sub FatherOccuptxt_LostFocus(sender As Object, e As EventArgs) Handles FatherOccuptxt.LostFocus
        LostFocusText(FatherOccuptxt)
    End Sub

    Private Sub MotherFnametxt_GotFocus(sender As Object, e As EventArgs) Handles MotherFnametxt.GotFocus
        GotFocusText(MotherFnametxt, "First Name...")
    End Sub

    Private Sub MotherFnametxt_LostFocus(sender As Object, e As EventArgs) Handles MotherFnametxt.LostFocus
        LostFocusText(MotherFnametxt)
    End Sub

    Private Sub MotherLnametxt_GotFocus(sender As Object, e As EventArgs) Handles MotherLnametxt.GotFocus
        GotFocusText(MotherLnametxt, "Last Name...")
    End Sub

    Private Sub MotherLnametxt_LostFocus(sender As Object, e As EventArgs) Handles MotherLnametxt.LostFocus
        LostFocusText(MotherLnametxt)
    End Sub

    Private Sub MotherMnametxt_GotFocus(sender As Object, e As EventArgs) Handles MotherMnametxt.GotFocus
        GotFocusText(MotherMnametxt, "Middle Name...")
    End Sub

    Private Sub MotherMnametxt_LostFocus(sender As Object, e As EventArgs) Handles MotherMnametxt.LostFocus
        LostFocusText(MotherMnametxt)
    End Sub

    Private Sub ContactPersontxt_GotFocus(sender As Object, e As EventArgs) Handles ContactPersontxt.GotFocus
        GotFocusText(ContactPersontxt, "Contact Person type here...")
    End Sub

    Private Sub ContactPersontxt_LostFocus(sender As Object, e As EventArgs) Handles ContactPersontxt.LostFocus
        LostFocusText(ContactPersontxt)
    End Sub

    Private Sub Relationshiptxt_GotFocus(sender As Object, e As EventArgs)
        GotFocusText(Relationshiptxt, "Relationship...")
    End Sub

    Private Sub Relationshiptxt_LostFocus(sender As Object, e As EventArgs)
        LostFocusText(Relationshiptxt)
    End Sub

    Private Sub Salarytxt_GotFocus(sender As Object, e As EventArgs) Handles Salarytxt.GotFocus
        GotFocusText(Salarytxt, "Salary...")
    End Sub

    Private Sub Salarytxt_LostFocus(sender As Object, e As EventArgs) Handles Salarytxt.LostFocus
        LostFocusText(Salarytxt)
    End Sub

    Private Sub Storetxt_GotFocus(sender As Object, e As EventArgs)
        'GotFocusText(Storetxt, "Store...")
    End Sub

    Private Sub Storetxt_LostFocus(sender As Object, e As EventArgs)
        ' LostFocusText(Storetxt)
    End Sub

    Private Sub DateStartedtxt_GotFocus(sender As Object, e As EventArgs)
        'GotFocusText(DateStartedtxt, "Date Started...")
    End Sub

    Private Sub DateStartedtxt_LostFocus(sender As Object, e As EventArgs)
        'LostFocusText(DateStartedDTP)
    End Sub

    Private Sub MotherOccuptxt_GotFocus(sender As Object, e As EventArgs) Handles MotherOccuptxt.GotFocus
        GotFocusText(MotherOccuptxt, "Occupation...")
    End Sub

    Private Sub MotherOccuptxt_LostFocus(sender As Object, e As EventArgs) Handles MotherOccuptxt.LostFocus
        LostFocusText(MotherOccuptxt)
    End Sub

    Private Sub FirstNametxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FirstNametxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If FirstNametxt.Text = "" Then
                FirstNametxt.Text = "N/A"
            Else
                FirstNametxt.Text = StrConv(FirstNametxt.Text, vbUpperCase)
                LastNametxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub LastNametxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LastNametxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If LastNametxt.Text = "" Then
                LastNametxt.Text = "N/A"
            Else
                LastNametxt.Text = StrConv(LastNametxt.Text, vbUpperCase)
                MiddleNametxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub MiddleNametxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MiddleNametxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If MiddleNametxt.Text = "" Then
                MiddleNametxt.Text = "N/A"
            Else
                MiddleNametxt.Text = StrConv(MiddleNametxt.Text, vbUpperCase)
                Suffixtxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Suffixtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Suffixtxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Suffixtxt.Text = "" Then
                Suffixtxt.Text = "N/A"
            Else
                Suffixtxt.Text = StrConv(Suffixtxt.Text, vbUpperCase)
                Addresstxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Addresstxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Addresstxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Addresstxt.Text = "" Then
                Addresstxt.Text = "N/A"
            Else
                Addresstxt.Text = StrConv(Addresstxt.Text, vbUpperCase)
                MobileNotxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub POBtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles POBtxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If POBtxt.Text = "" Then
                POBtxt.Text = "N/A"
            Else
                POBtxt.Text = StrConv(POBtxt.Text, vbUpperCase)
                Gendertxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Citizenshiptxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Citizenshiptxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Citizenshiptxt.Text = "" Then
                Citizenshiptxt.Text = "N/A"
            Else
                Citizenshiptxt.Text = StrConv(Citizenshiptxt.Text, vbUpperCase)
                Religiontxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Religiontxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Religiontxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Religiontxt.Text = "" Then
                Religiontxt.Text = "N/A"
            Else
                Religiontxt.Text = StrConv(Religiontxt.Text, vbUpperCase)
                CivilStatustxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Heighttxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Heighttxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Heighttxt.Text = "" Then
                Heighttxt.Text = "N/A"
            Else
                Heighttxt.Text = StrConv(Heighttxt.Text, vbUpperCase)
                Weighttxt.Focus()
            End If
        End If
        Select Case Asc(e.KeyChar)
            Case Asc("0") To Asc("9")
            Case Asc(".")
            Case Asc("'")
            Case Asc("""")
            Case Keys.Back
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub Weighttxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Weighttxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Weighttxt.Text = "" Then
                Weighttxt.Text = "N/A"
            Else
                Weighttxt.Text = StrConv(Weighttxt.Text, vbUpperCase)
                TabControl1.SelectedIndex = 0

                SpouseFnametxt.Focus()
            End If
        End If
        Select Case Asc(e.KeyChar)
            Case Asc("0") To Asc("9")
            Case Asc(".")
            Case Asc("'")
            Case Asc("""")
            Case Keys.Back
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub NumberOfChildtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NumberOfChildtxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If NumberOfChildtxt.Text = "" Then
                NumberOfChildtxt.Text = "N/A"
            Else
                NumberOfChildtxt.Text = StrConv(NumberOfChildtxt.Text, vbUpperCase)
                'TabControl3.SelectTab(10)
                TabControl3.SelectedIndex = 1
                'TabControl1.SelectTab(1)
                FatherFnametxt.Focus()
            End If
        End If
        Select Case Asc(e.KeyChar)
            Case Asc("0") To Asc("9")
            Case Keys.Back
            Case Else
                e.Handled = True
        End Select
    End Sub
    Private Sub FatherFnametxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FatherFnametxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If FatherFnametxt.Text = "" Then
                FatherFnametxt.Text = "N/A"
            Else
                FatherFnametxt.Text = StrConv(FatherFnametxt.Text, vbUpperCase)
                FatherLnametxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub FatherLnametxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FatherLnametxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If FatherLnametxt.Text = "" Then
                FatherLnametxt.Text = "N/A"
            Else
                FatherLnametxt.Text = StrConv(FatherLnametxt.Text, vbUpperCase)
                FatherMnametxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub FatherMnametxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FatherMnametxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If FatherMnametxt.Text = "" Then
                FatherMnametxt.Text = "N/A"
            Else
                FatherMnametxt.Text = StrConv(FatherMnametxt.Text, vbUpperCase)
                FatherOccuptxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub FatherOccuptxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FatherOccuptxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If FatherOccuptxt.Text = "" Then
                FatherOccuptxt.Text = "N/A"
            Else
                FatherOccuptxt.Text = StrConv(FatherOccuptxt.Text, vbUpperCase)
                MotherFnametxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub MotherFnametxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MotherFnametxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If MotherFnametxt.Text = "" Then
                MotherFnametxt.Text = "N/A"
            Else
                MotherFnametxt.Text = StrConv(MotherFnametxt.Text, vbUpperCase)
                MotherLnametxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub MotherLnametxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MotherLnametxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If MotherLnametxt.Text = "" Then
                MotherLnametxt.Text = "N/A"
            Else
                MotherLnametxt.Text = StrConv(MotherLnametxt.Text, vbUpperCase)
                MotherMnametxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub MotherMnametxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MotherMnametxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If MotherMnametxt.Text = "" Then
                MotherMnametxt.Text = "N/A"
            Else
                MotherMnametxt.Text = StrConv(MotherMnametxt.Text, vbUpperCase)
                MotherOccuptxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub MotherOccuptxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MotherOccuptxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If MotherOccuptxt.Text = "" Then
                MotherOccuptxt.Text = "N/A"
            Else
                MotherOccuptxt.Text = StrConv(MotherOccuptxt.Text, vbUpperCase)
                ContactPersontxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ContactPersontxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ContactPersontxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ContactPersontxt.Text = "" Then
                ContactPersontxt.Text = "N/A"
            Else
                ContactPersontxt.Text = StrConv(ContactPersontxt.Text, vbUpperCase)
                Relationshiptxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub Relationshiptxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Relationshiptxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Relationshiptxt.Text = "" Then
                Relationshiptxt.Text = "N/A"
            Else
                Relationshiptxt.Text = StrConv(Relationshiptxt.Text, vbUpperCase)
                TabControl1.SelectedIndex = 1
                ElemNameTxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Positiontxt_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            If Positiontxt.Text = "" Then
                Positiontxt.Text = "N/A"
            Else
                Positiontxt.Text = StrConv(Positiontxt.Text, vbUpperCase)
                Salarytxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Salarytxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Salarytxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Salarytxt.Text = "" Then
                Salarytxt.Text = "N/A"
            Else
                Salarytxt.Text = StrConv(Salarytxt.Text, vbUpperCase)
                Storetxt.Focus()
                e.Handled = True
            End If
        End If
        Select Case Asc(e.KeyChar)
            Case Asc("0") To Asc("9")
            Case Asc(",")
            Case Asc(".")
            Case Keys.Back
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub Storetxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Storetxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Storetxt.Text = "" Then
                Storetxt.Focus()
            Else
                Storetxt.Text = StrConv(Storetxt.Text, vbUpperCase)
                DateStartedDTP.Focus()
                e.Handled = True
            End If

        End If
        Select Case Asc(e.KeyChar)
            Case Keys.Up
            Case Keys.Down
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub DateStartedtxt_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            If DateStartedDTP.Text = "" Then
                DateStartedDTP.Text = Date.Now.ToString(Format("MM/dd/yyyy"))
            Else
                DateStartedDTP.Text = StrConv(DateStartedDTP.Text, vbUpperCase)
                EmployeeStatus.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Weighttxt_GotFocus(sender As Object, e As EventArgs) Handles Weighttxt.GotFocus
        GotFocusText(Weighttxt, "Select...")
    End Sub

    Private Sub Weighttxt_LostFocus(sender As Object, e As EventArgs) Handles Weighttxt.LostFocus
        LostFocusText(Weighttxt)
    End Sub

    Private Sub CivilStatustxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CivilStatustxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If CivilStatustxt.Text = "" Then
                CivilStatustxt.Text = "SINGLE"
            Else
                CivilStatustxt.Text = StrConv(CivilStatustxt.Text, vbUpperCase)
                Heighttxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SpouseFnametxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SpouseFnametxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If SpouseFnametxt.Text = "" Then
                SpouseFnametxt.Text = "N/A"
                SpouseLnametxt.Focus()
                e.Handled = True
            Else
                SpouseFnametxt.Text = StrConv(SpouseFnametxt.Text, vbUpperCase)
                SpouseLnametxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SpouseLnametxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SpouseLnametxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If SpouseLnametxt.Text = "" Then
                SpouseLnametxt.Text = "N/A"
            Else
                SpouseLnametxt.Text = StrConv(SpouseLnametxt.Text, vbUpperCase)
                SpouseMnametxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SpouseMnametxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SpouseMnametxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If SpouseMnametxt.Text = "" Then
                SpouseMnametxt.Text = "N/A"
            Else
                SpouseMnametxt.Text = StrConv(SpouseMnametxt.Text, vbUpperCase)
                SpouseSuffixtxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SpouseSuffixtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SpouseSuffixtxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If SpouseSuffixtxt.Text = "" Then
                SpouseSuffixtxt.Text = "N/A"
            Else
                SpouseSuffixtxt.Text = StrConv(SpouseSuffixtxt.Text, vbUpperCase)
                NumberOfChildtxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CheckStayIn_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            ButtonAdd.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub CheckStayOut_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            If MessageBox.Show("Are you sure to stay out the employee?", sysmessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ButtonAdd.Focus()
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub DOBtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DOBtxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Age = GetYearLength(DOBtxt.Text)
            Agetxt.Text = Val(Age) - 1
            POBtxt.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub Gendertxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Gendertxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Gendertxt.Text = "" Then
                Gendertxt.Focus()
            Else
                Citizenshiptxt.Focus()
                e.Handled = True
            End If
        End If
        Select Case Asc(e.KeyChar)
            Case Keys.Up
            Case Keys.Down
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub DOBtxt_ValueChanged(sender As Object, e As EventArgs) Handles DOBtxt.ValueChanged
        Age = GetYearLength(DOBtxt.Text)
        Agetxt.Text = Val(Age)
    End Sub

    Private Sub MobileNotxt_GotFocus(sender As Object, e As EventArgs) Handles MobileNotxt.GotFocus
        GotFocusText(MobileNotxt, "Cell No...")
    End Sub

    Private Sub MobileNotxt_LostFocus(sender As Object, e As EventArgs) Handles MobileNotxt.LostFocus
        LostFocusText(MobileNotxt)
    End Sub

    Private Sub MobileNotxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MobileNotxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If MobileNotxt.Text = "" Then
                MobileNotxt.Text = "N/A"
            Else
                DOBtxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub AddEmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ButtonAdd.Text = "&SAVE" Then
            LoadPosition()
            LoadStore()
            GetAllTextbox(GroupBox1, True)
            GetAllTextbox(GroupBox5, True)
            GetAllTextbox(GroupBox5, True)
            GetAllTextbox(TabControl1, True)
            GetAllTextbox(TabControl3, True)
            GetAllTextbox(TabControl1, True)
            GetAllTextbox(TabControl2, True)
        ElseIf ButtonAdd.Text = "&UPDATE" Then
            GetImage()
            DisplayEmployee()
            LoadPosition()
            LoadStore()
            LoadEmploymentHistory()
            loadAttachmentFiles()
            'GetAllTextbox(GroupBox1, True)
            'GetAllTextbox(GroupBox5, True)
            'GetAllTextbox(GroupBox5, True)
            'GetAllTextbox(TabControl1, True)
            'GetAllTextbox(TabControl3, True)
            'GetAllTextbox(TabControl1, True)
            'GetAllTextbox(TabControl2, True)
            EnableControls()
        ElseIf ButtonAdd.Text = "&EDIT" Then
            GetImage()
            DisplayEmployee()
            LoadPosition()
            LoadStore()
            LoadEmploymentHistory()
            loadAttachmentFiles()
            'GetAllTextbox(GroupBox1, False)
            'GetAllTextbox(GroupBox5, False)
            'GetAllTextbox(GroupBox5, False)
            'GetAllTextbox(TabControl1, False)
            'GetAllTextbox(TabControl3, False)
            'GetAllTextbox(TabControl1, False)
            'GetAllTextbox(TabControl2, False)
            DisableControls()
        End If

    End Sub


    Private Sub DisableControls()
        GetAllTextbox(GroupBox1, False)
        GetAllTextbox(GroupBox5, False)
        GetAllTextbox(TabPage10, False)
        GetAllTextbox(TabPage5, False)
        GetAllTextbox(TabPage4, False)
        GetAllTextbox(TabPage7, False)
    End Sub
    Private Sub EnableControls()
        GetAllTextbox(GroupBox1, True)
        GetAllTextbox(GroupBox5, True)
        GetAllTextbox(TabPage10, True)
        GetAllTextbox(TabPage5, True)
        GetAllTextbox(TabPage4, True)
        GetAllTextbox(TabPage7, True)
    End Sub
    Private Sub loadAttachmentFiles()
        Try
            con.Open()
            FileLV.Items.Clear()
            cmd = New MySqlCommand("Select FullName, FileID, FileName, FilePath, Description From employee_file, employee_info where employee_file.employee=employee_info.EmployeeID and EmployeeID like '" & PersonID & "' and FileStatus like'1'", con)
            DataRead = cmd.ExecuteReader
            While DataRead.Read = True
                Dim lv As ListViewItem
                lv = FileLV.Items.Add(DataRead("FileID").ToString())
                lv.SubItems.Add(DataRead("FileName")).ToString()
                lv.SubItems.Add(DataRead("Description")).ToString()
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            DataRead.Close()
            con.Close()
        End Try
    End Sub
    Private Sub BindText()
        Try
            con.Open()
            'cmd = New MySqlCommand("select * from employee_history inner join employee_position on employee_history.Position=employee_position.PositionID where PositionStatus like 'Present'", con)
            'cmd = New MySqlCommand("select * from ((employee_history inner join employee_info on employee_history.employee=employee_info.employeeID)inner join employee_position on employee_history.PositionHistory=employee_position.PositionID)where PositionStatus like'Present'", con)
            cmd = New MySqlCommand("select * from employee_info inner join employee_position on employee_info.Position=employee_position.EmployeePosition where AvailablePosition like 'Yes';", con)
            DataRead = cmd.ExecuteReader
            While DataRead.Read = True
                Positiontxt.Text = DataRead("EmployeePosition").ToString()
                Salarytxt.Text = DataRead("Salary").ToString()

            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
            DataRead.Close()
        End Try
    End Sub

    Public Sub LoadEmploymentHistory()
        Try
            EmploymentLV.Items.Clear()
            con.Open()
            'cmd = New MySqlCommand("select * from (employee_history inner join employee_position on employee_history.positionhistory=employee_position.PositionID) inner join employee_info on employee_history.employee=employee_info.EmployeeID where employeeid like'" & PersonID & "' order by positionstatus desc", con)
            cmd = New MySqlCommand("Select * from employee_history inner join employee_info on employee_history.Employee=employee_info.EmployeeIDNo where EmployeeID like'" & PersonID & "' order by remark like'PRESENT' desc", con)
            DataRead = cmd.ExecuteReader
            While DataRead.Read = True
                Dim lv As ListViewItem
                Dim AlterDate As String

                If DataRead("DateTo") = "PRESENT" Then
                    AlterDate = "PRESENT"
                    lv = EmploymentLV.Items.Add(DataRead("HistoryID").ToString())
                    lv.SubItems.Add(DateTime.Parse(DataRead("DateFrom")).Year & "-" & AlterDate).ToString()
                    lv.SubItems.Add(DataRead("Position")).ToString()
                    lv.SubItems.Add(DataRead("Company")).ToString()
                    lv.SubItems.Add(DataRead("WorkDescription")).ToString()
                    lv.SubItems.Add(DataRead("Remark")).ToString()
                Else
                    AlterDate = DateTime.Parse(DataRead("DateTo")).Year
                    lv = EmploymentLV.Items.Add(DataRead("HistoryID").ToString())
                    lv.SubItems.Add(DateTime.Parse(DataRead("DateFrom")).Year & "-" & AlterDate).ToString()
                    lv.SubItems.Add(DataRead("Position")).ToString()
                    lv.SubItems.Add(DataRead("Company")).ToString()
                    lv.SubItems.Add(DataRead("WorkDescription")).ToString()
                    lv.SubItems.Add(DataRead("Remark")).ToString()
                End If
                'lv = EmploymentLV.Items.Add(DataRead("HistoryID").ToString())
                'lv.SubItems.Add(DateTime.Parse(DataRead("DateFrom")).Year & "-" & AlterDate).ToString()
                'lv.SubItems.Add(DataRead("Position")).ToString()
                'lv.SubItems.Add(DataRead("Company")).ToString()
                'lv.SubItems.Add(DataRead("WorkDescription")).ToString()
                'lv.SubItems.Add(DataRead("Remark")).ToString()
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
            DataRead.Close()
        End Try
    End Sub
    Private Sub CheckConnectionState()
        With con
            If .State = ConnectionState.Open Then .Close()
            .Open()
        End With
    End Sub
    Private Sub LoadPosition()
        Try
            CheckConnectionState()
            Positiontxt.Items.Clear()
            cmd = New MySqlCommand("select * from employee_position where AvailablePosition like'Yes'", con)
            DataRead = cmd.ExecuteReader
            While DataRead.Read = True
                Positiontxt.Items.Add(DataRead("EmployeePosition")).ToString()
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
            DataRead.Close()
        End Try
    End Sub

    Public Sub LoadStore()
        Try
            CheckConnectionState()
            Storetxt.Items.Clear()
            cmd = New MySqlCommand("select * from employee_store", con)
            DataRead = cmd.ExecuteReader
            While DataRead.Read = True
                Storetxt.Items.Add(DataRead("StoreName")).ToString()
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
            DataRead.Close()
        End Try
    End Sub

    Private Sub UpdateEmployeePosition()
        Try
            con.Open()
            'Set the position status to old before inserting the new position
            'cmd = New MySqlCommand("update employee_history set `PositionStatus`=@status where Employee like'" & PersonID & "'", con)
            'cmd.Parameters.AddWithValue("@status", "OLDs")
            'cmd.ExecuteNonQuery()
            'cmd.Dispose()

            'Update the employee info and set the position into the new or present position of the employee
            cmd = New MySqlCommand("update employee_info set `position`=@position where employeeid like '" & PersonID & "'", con)
            cmd.Parameters.AddWithValue("@position", EmployeePositionID)
            cmd.ExecuteNonQuery()

            'inserting new history record of the employee
            cmd = New MySqlCommand("Insert into employee_history(Employee, Positionhistory, Year, PositionStatus) Values(@employee, @position, @year, @status)", con)
            cmd.Parameters.AddWithValue("@employee", PersonID)
            cmd.Parameters.AddWithValue("@position", EmployeePositionID)
            cmd.Parameters.AddWithValue("@year", Date.Now.ToString("yyyy"))
            cmd.Parameters.AddWithValue("@status", "Present")
            cmd.ExecuteNonQuery()
            'MessageBox.Show("Employee Position Is Succefully Updated.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub CloseButton_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        PersonID = "0"
        Me.Dispose()
    End Sub

    Private Sub ElemNameTxt_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Positiontxt_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles Positiontxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Positiontxt.Text = "" Then
                Positiontxt.SelectedIndex = 0
                Salarytxt.Focus()
                e.Handled = True
            Else
                Salarytxt.Focus()
                e.Handled = True
            End If
        End If
        Select Case Asc(e.KeyChar)
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub Positiontxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Positiontxt.SelectedIndexChanged
        Try
            CheckConnectionState()
            cmd = New MySqlCommand("select * from employee_position where EmployeePosition like'" & Positiontxt.Text & "'", con)
            DataRead = cmd.ExecuteReader
            While DataRead.Read = True
                EmployeePositionID = DataRead("PositionID")
                'Salarytxt.Text = DataRead("Salary")
                Salarytxt.Text = FormatNumber(DataRead("Salary"), 2, TriState.True)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
            DataRead.Close()
        End Try
    End Sub

    Private Sub Positiontxt_TextChanged(sender As Object, e As EventArgs) Handles Positiontxt.TextChanged
        Try
            CheckConnectionState()
            cmd = New MySqlCommand("select * from employee_position where EmployeePosition like'" & Positiontxt.Text & "'", con)
            DataRead = cmd.ExecuteReader
            While DataRead.Read = True
                EmployeePositionID = DataRead("PositionID")
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
            DataRead.Close()
        End Try
    End Sub

    Private Sub ElemNameTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ElemNameTxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ElemNameTxt.Text = "" Then
                ElemNameTxt.Text = "N/A"
                e.Handled = True
            Else
                ElemNameTxt.Text = StrConv(ElemNameTxt.Text, vbUpperCase)
                ElemGradTxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ElemNameTxt_GotFocus(sender As Object, e As EventArgs) Handles ElemNameTxt.GotFocus
        GotFocusText(ElemNameTxt, "Type the name of school and address...")
    End Sub

    Private Sub ElemNameTxt_LostFocus(sender As Object, e As EventArgs) Handles ElemNameTxt.LostFocus
        LostFocusText(ElemNameTxt)
    End Sub

    Private Sub HSNameTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles HSNameTxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If HSNameTxt.Text = "" Then
                HSNameTxt.Text = "N/A"
                e.Handled = True
            Else
                HSNameTxt.Text = StrConv(HSNameTxt.Text, vbUpperCase)
                HSGradTxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub HSNameTxt_GotFocus(sender As Object, e As EventArgs) Handles HSNameTxt.GotFocus
        GotFocusText(HSNameTxt, "Type the name of school and address...")
    End Sub

    Private Sub ElemGradTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ElemGradTxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ElemGradTxt.Text = "" Then
                ElemGradTxt.Text = "N/A"
                e.Handled = True
            Else
                ElemGradTxt.Text = StrConv(ElemGradTxt.Text, vbUpperCase)
                HSNameTxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub HSGradTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles HSGradTxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If HSGradTxt.Text = "" Then
                HSGradTxt.Text = "N/A"
                e.Handled = True
            Else
                HSGradTxt.Text = StrConv(HSGradTxt.Text, vbUpperCase)
                CollegeNameTxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CollegeNameTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CollegeNameTxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If CollegeNameTxt.Text = "" Then
                CollegeNameTxt.Text = "N/A"
                e.Handled = True
            Else
                CollegeNameTxt.Text = StrConv(CollegeNameTxt.Text, vbUpperCase)
                CollegeGradTxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CollegeGradTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CollegeGradTxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If CollegeGradTxt.Text = "" Then
                CollegeGradTxt.Text = "N/A"
                e.Handled = True
            Else
                CollegeGradTxt.Text = StrConv(CollegeGradTxt.Text, vbUpperCase)
                TabControl1.SelectedIndex = 2
                TabControl2.SelectedIndex = 0
                SSSIDTxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SSSIDTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SSSIDTxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If SSSIDTxt.Text = "" Then
                SSSIDTxt.Text = "N/A"
            Else
                SSSIDTxt.Text = StrConv(SSSIDTxt.Text, vbUpperCase)
                PagIDTxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PagIDTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PagIDTxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If PagIDTxt.Text = "" Then
                PagIDTxt.Text = "N/A"
            Else
                PagIDTxt.Text = StrConv(PagIDTxt.Text, vbUpperCase)
                PhilIDTxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PhilIDTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PhilIDTxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If PhilIDTxt.Text = "" Then
                PhilIDTxt.Text = "N/A"
            Else
                PhilIDTxt.Text = StrConv(PhilIDTxt.Text, vbUpperCase)
                TINIDTxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ElemGradTxt_GotFocus(sender As Object, e As EventArgs) Handles ElemGradTxt.GotFocus
        GotFocusText(ElemGradTxt, "Type year...")
    End Sub

    Private Sub ElemGradTxt_LostFocus(sender As Object, e As EventArgs) Handles ElemGradTxt.LostFocus
        LostFocusText(ElemGradTxt)
    End Sub

    Private Sub HSNameTxt_LostFocus(sender As Object, e As EventArgs) Handles HSNameTxt.LostFocus
        LostFocusText(HSNameTxt)
    End Sub

    Private Sub CollegeNameTxt_GotFocus(sender As Object, e As EventArgs) Handles CollegeNameTxt.GotFocus
        GotFocusText(CollegeNameTxt, "Type the name of school and address...")
    End Sub

    Private Sub CollegeNameTxt_LostFocus(sender As Object, e As EventArgs) Handles CollegeNameTxt.LostFocus
        LostFocusText(CollegeNameTxt)
    End Sub

    Private Sub CollegeGradTxt_GotFocus(sender As Object, e As EventArgs) Handles CollegeGradTxt.GotFocus
        GotFocusText(CollegeGradTxt, "Type year...")
    End Sub

    Private Sub CollegeGradTxt_LostFocus(sender As Object, e As EventArgs) Handles CollegeGradTxt.LostFocus
        LostFocusText(CollegeGradTxt)
    End Sub

    Private Sub SSSIDTxt_GotFocus(sender As Object, e As EventArgs) Handles SSSIDTxt.GotFocus
        GotFocusText(SSSIDTxt, "Type SSS ID here...")
    End Sub

    Private Sub SSSIDTxt_LostFocus(sender As Object, e As EventArgs) Handles SSSIDTxt.LostFocus
        LostFocusText(SSSIDTxt)
    End Sub

    Private Sub PagIDTxt_GotFocus(sender As Object, e As EventArgs) Handles PagIDTxt.GotFocus
        GotFocusText(PagIDTxt, "Type Pag-ibig ID here...")
    End Sub

    Private Sub PagIDTxt_LostFocus(sender As Object, e As EventArgs) Handles PagIDTxt.LostFocus
        LostFocusText(PagIDTxt)
    End Sub

    Private Sub PhilIDTxt_GotFocus(sender As Object, e As EventArgs) Handles PhilIDTxt.GotFocus
        GotFocusText(PhilIDTxt, "Type Philhealth ID here...")
    End Sub

    Private Sub PhilIDTxt_LostFocus(sender As Object, e As EventArgs) Handles PhilIDTxt.LostFocus
        LostFocusText(PhilIDTxt)
    End Sub

    Private Sub TINIDTxt_GotFocus(sender As Object, e As EventArgs) Handles TINIDTxt.GotFocus
        GotFocusText(TINIDTxt, "Type TIN ID here...")
    End Sub

    Private Sub TINIDTxt_LostFocus(sender As Object, e As EventArgs) Handles TINIDTxt.LostFocus
        LostFocusText(TINIDTxt)
    End Sub

    Private Sub HSGradTxt_GotFocus(sender As Object, e As EventArgs) Handles HSGradTxt.GotFocus
        GotFocusText(HSGradTxt, "Type year...")
    End Sub

    Private Sub HSGradTxt_LostFocus(sender As Object, e As EventArgs) Handles HSGradTxt.LostFocus
        LostFocusText(HSGradTxt)
    End Sub

    Private Sub TINIDTxt_TextChanged(sender As Object, e As EventArgs) Handles TINIDTxt.TextChanged

    End Sub

    Private Sub MotherMnametxt_TextChanged(sender As Object, e As EventArgs) Handles MotherMnametxt.TextChanged

    End Sub

    Private Sub Storetxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Storetxt.SelectedIndexChanged

    End Sub

    Private Sub StoreBtn_Click(sender As Object, e As EventArgs)
        frmStore.ShowDialog()
    End Sub

    Private Sub TINIDTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TINIDTxt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TINIDTxt.Text = "" Then
                TINIDTxt.Text = "N/A"
            Else
                TINIDTxt.Text = StrConv(TINIDTxt.Text, vbUpperCase)
                TabControl2.SelectedIndex = 1
                EmployeeIDNo.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub AddStoreLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AddStoreLink.LinkClicked
        frmStore.ShowDialog()
    End Sub

    Private Sub EmployeeIDNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EmployeeIDNo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If EmployeeIDNo.Text = "" Then
                MessageBox.Show("Please type Employee ID number.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                EmployeeIDNo.Focus()
            Else
                EmployeeIDNo.Text = StrConv(EmployeeIDNo.Text, vbUpperCase)
                Positiontxt.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub NumberOfChildtxt_TextChanged(sender As Object, e As EventArgs) Handles NumberOfChildtxt.TextChanged

    End Sub

    Private Sub NumberOfChildtxt_ImeModeChanged(sender As Object, e As EventArgs) Handles NumberOfChildtxt.ImeModeChanged

    End Sub

    Private Sub AddEH_btn_Click(sender As Object, e As EventArgs) Handles AddEH_btn.Click
        If EmployeeIDNo.Text = "" Then
            MessageBox.Show("Please fill the employee id first.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
            EmployeeIDNo.Focus()
        Else
            frmEmploymentHistory.EmployeeId_txt.Text = EmployeeIDNo.Text
            frmEmploymentHistory.AddBtn.Text = "&SAVE"
            frmEmploymentHistory.ShowDialog()
        End If

    End Sub

    Private Sub EmploymentLV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EmploymentLV.SelectedIndexChanged
        If EmploymentLV.SelectedItems.Count > 0 Then
            With EmploymentLV.SelectedItems(0)
                HistoryID = .Text.ToString
            End With
        End If
    End Sub

    Private Sub EditEH_btn_Click(sender As Object, e As EventArgs) Handles EditEH_btn.Click
        If EmploymentLV.SelectedItems.Count > 0 Then
            If EmployeeIDNo.Text = "" Then
                MessageBox.Show("Please fill the employee id first.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                EmployeeIDNo.Focus()
            Else
                frmEmploymentHistory.EmployeeId_txt.Text = EmployeeIDNo.Text
                frmEmploymentHistory.AddBtn.Text = "&UPDATE"
                frmEmploymentHistory.ShowDialog()
            End If
        Else
            MessageBox.Show("Please select from the list to edit.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub DeleteEH_btn_Click(sender As Object, e As EventArgs) Handles DeleteEH_btn.Click
        If EmploymentLV.SelectedItems.Count > 0 Then
            If EmployeeIDNo.Text = "" Then
                MessageBox.Show("Please fill the employee id first.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                EmployeeIDNo.Focus()
            Else
                frmEmploymentHistory.EmployeeId_txt.Text = EmployeeIDNo.Text
                frmEmploymentHistory.AddBtn.Text = "&DELETE"
                frmEmploymentHistory.ShowDialog()
            End If
        Else
            MessageBox.Show("Please select from the list to delete.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub NumberOfChildtxt_KeyUp(sender As Object, e As KeyEventArgs) Handles NumberOfChildtxt.KeyUp

    End Sub

    Private Sub View_btn_Click(sender As Object, e As EventArgs) Handles View_btn.Click
        If EmploymentLV.SelectedItems.Count > 0 Then
            If EmployeeIDNo.Text = "" Then
                MessageBox.Show("Please fill the employee id first.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                EmployeeIDNo.Focus()
            Else
                frmEmploymentHistory.EmployeeId_txt.Text = EmployeeIDNo.Text
                frmEmploymentHistory.AddBtn.Text = "&EDIT"
                frmEmploymentHistory.ShowDialog()
            End If
        Else
            MessageBox.Show("Please select from the list to edit.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Refresh_btn_Click(sender As Object, e As EventArgs) Handles Refresh_btn.Click
        LoadEmploymentHistory()
    End Sub

    Private Sub TitleTxt_Click(sender As Object, e As EventArgs) Handles TitleTxt.Click

    End Sub

    Private Sub _CopyFiles(_NewFileLocation As String)
        Try
            CheckConnectionState()
            _NewFileLocation = _DirPathName

            Dim _id As Integer = Convert.ToInt32(FileLV.SelectedItems(0).Text.ToString())
            cmd = New MySqlCommand("Select * from employee_file where FileID=@ID", con)
            cmd.Parameters.AddWithValue("@ID", _id)
            DataRead = cmd.ExecuteReader

            While DataRead.Read = True
                Dim _filebyte As Byte() = DataRead("File")
                Dim _fs As New FileStream(_NewFileLocation & "\" & DataRead("FileName"), FileMode.Create, FileAccess.Write)
                _fs.Write(_filebyte, 0, _filebyte.Length)
                _fs.Close()
            End While

            MessageBox.Show("File Copied Successfully.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
            DataRead.Close()
        End Try
    End Sub
    Private Sub CopyBtn_Click(sender As Object, e As EventArgs) Handles CopyBtn.Click
        If FileLV.SelectedItems.Count > 0 Then
            Dim FBD As New FolderBrowserDialog
            If FBD.ShowDialog() = DialogResult.OK Then
                _DirPathName = FBD.SelectedPath
                Try
                    'CheckConnectionState()
                    'cmd = New MySqlCommand("Update employee_file set `FilePath` = @FilePath Where FileID like'" & _FileID & "'", con)
                    ''cmd.Parameters.AddWithValue("@FilePath", _DirPathName & "\" & _FileName)
                    'cmd.Parameters.AddWithValue("@FilePath", _DirPathName & "\" & _FileName)
                    'Try
                    '    cmd.ExecuteNonQuery()
                    'Catch ex As Exception
                    'Finally
                    '    con.Close()
                    'End Try
                    _CopyFiles(_DirPathName)
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            End If
        Else
            MessageBox.Show("Please select file to copy.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub RefreshFile_btn_Click(sender As Object, e As EventArgs) Handles RefreshFile_btn.Click
        loadAttachmentFiles()
    End Sub

    Private Sub FileLV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FileLV.SelectedIndexChanged
        Try
            If FileLV.SelectedItems.Count > 0 Then
                _FileID = FileLV.SelectedItems(0).Text
                _FileName = FileLV.SelectedItems(0).SubItems(2).Text
            End If
        Catch ex As Exception
            MessageBox.Show("The file path of the file is not exist or it saved to the server. Please click the 'copy to desk button' to copy the file from the database to your desktop and view the file.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub EmployeeStatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EmployeeStatus.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If EmployeeStatus.Text = "" Then
                MessageBox.Show("Please type Employee Status.", sysmessage, MessageBoxButtons.OK, MessageBoxIcon.Information)
                EmployeeStatus.Text = "ACTIVE"
                EmployeeType.Focus()
                e.Handled = True
            Else
                EmployeeType.SelectedIndex = 0
                EmployeeType.Focus()
                e.Handled = True
            End If

        End If
        Select Case Asc(e.KeyChar)
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub EmployeeType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EmployeeType.KeyPress
        Select Case Asc(e.KeyChar)
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub DateStartedDTP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DateStartedDTP.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            EmployeeStatus.Focus()
            e.Handled = True
        End If
    End Sub
End Class
