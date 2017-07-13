Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports System.IO
Public Class frmCheckout
    Private Sub txtFirstName_Validating(sender As Object, e As CancelEventArgs) Handles txtFirstName.Validating
        If Regex.IsMatch(txtFirstName.Text, "[`~!@#\$%\^&\*\(\)_\-\+=\{\}\[\]\\\|:;""'<>,\.\?/\s\d]") Then
            MsgBox("Name Mandatory", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub
    Private Sub txtLastName_Validating(sender As Object, e As CancelEventArgs) Handles txtLastName.Validating
        If Regex.IsMatch(txtFirstName.Text, "[`~!@#\$%\^&\*\(\)_\-\+=\{\}\[\]\\\|:;""'<>,\.\?/\s\d]") Then
            MsgBox("Name Mandatory", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub
    Private Sub txtAddress_Validating(sender As Object, e As CancelEventArgs) Handles txtAddress.Validating
        If Regex.IsMatch(txtFirstName.Text, "[`~!@#\$%\^&\*\(\)_\-\+=\{\}\[\]\\\|:;""'<>,\.\?/\s\d]") Then
            MsgBox("Name Mandatory", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub
    Private Sub txtCreditNum_Validating(sender As Object, e As CancelEventArgs) Handles txtCreditNum.Validating
        If Regex.IsMatch(txtFirstName.Text, "[`~!@#\$%\^&\*\(\)_\-\+=\{\}\[\]\\\|:;""'<>,\.\?/\s\d]") Then
            MsgBox("Name Mandatory", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub mtbZipCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mtbZipCode.Validating
        Try
            If mtbZipCode.Text.Contains(" ") Then
                ErrorProvider1.SetError(mtbZipCode, "Please enter a valid zip code")
            End If

            If Not mtbZipCode.Text.Contains(" ") Then
                ErrorProvider1.Clear()
                ErrorProvider1.SetError(mtbZipCode, "")
                ErrorProvider2.SetError(mtbZipCode, "")
                'ErrorProvider2.s
            End If
        Catch ex As System.StackOverflowException
            MsgBox("ErrorTest!!!!", MsgBoxStyle.OkOnly, "Please enter a valid zip code.")

        End Try

    End Sub

    Private Sub mtbPhoneNum_MaskInputRejected(sender As Object, e As CancelEventArgs) Handles mtbPhoneNum.Validating
        Try
            If mtbZipCode.Text.Contains(" ") Then
                MsgBox("Error!", MsgBoxStyle.OkOnly, "Please enter a valid phone number.")
            End If
        Catch ex As System.ArgumentOutOfRangeException
            MsgBox("Error!!", MsgBoxStyle.OkOnly, "Please enter a valid phone number.")

        End Try

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If Not ErrorProvider1.GetError(mtbZipCode) = "" Then
            MsgBox("Error!", MsgBoxStyle.OkOnly, "Please correct your errors and try again.")
        ElseIf Not ErrorProvider1.GetError(mtbPhoneNum) = "" Then
            MsgBox("Error!!", MsgBoxStyle.OkOnly, "Please correct your errors and try again.")
        ElseIf Not ErrorProvider1.GetError(txtFirstName) = "" Then
            MsgBox("Error!!!", MsgBoxStyle.OkOnly, "Please correct your errors and try again.")
        ElseIf Not ErrorProvider1.GetError(txtLastName) = "" Then
            MsgBox("Error!!!!", MsgBoxStyle.OkOnly, "Please correct your errors and try again.")
        ElseIf Not ErrorProvider1.GetError(txtAddress) = "" Then
            MsgBox("Error!!!!!", MsgBoxStyle.OkOnly, "Please correct your errors and try again.")
        ElseIf Not ErrorProvider1.GetError(txtCreditNum) = "" Then
            MsgBox("Error!!!!!!", MsgBoxStyle.OkOnly, "Please correct your errors and try again.")
        Else
            Me.Hide()

        End If


    End Sub
End Class