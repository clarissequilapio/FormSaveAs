﻿Public Class Form1
    Dim i As Short
    Dim j As Short
    Dim k As Short
    Private Sub nameInfo_TextChanged(sender As Object, e As EventArgs) Handles nameInfo.TextChanged



    End Sub
    Public Sub NumberOnly(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8) Then
            ErrorProvider1.Clear()

        Else
            e.Handled = True
            'MsgBox("Number Only", MsgBoxStyle.Information)
            ErrorProvider1.SetError(ageInfo, "Please Enter Number Only")

        End If

    End Sub
    Private Sub ageInfo_KeyPress(sender As Object, e As EventArgs) Handles ageInfo.KeyPress
        NumberOnly(e)



    End Sub

    Private Sub addressInfo_TextChanged(sender As Object, e As EventArgs) Handles addressInfo.TextChanged
        Dim addressInfo As String

    End Sub

    Private Sub nameLabel_Click(sender As Object, e As EventArgs) Handles nameLabel.Click

    End Sub

    Private Sub txtbtn_Click(sender As Object, e As EventArgs) Handles txtbtn.Click

        If nameInfo.Text <> "" And ageInfo.Text <> "" And addressInfo.Text <> "" Then
            i += 1

            allInfo.Text = "==============================================" + vbNewLine +
            nameLabel.Text + " " + nameInfo.Text + vbNewLine + ageLabel.Text + " " + ageInfo.Text +
            vbNewLine + addressLabel.Text + " " + addressInfo.Text + vbNewLine +
            "==============================================" + vbNewLine

            My.Computer.FileSystem.WriteAllText("C:\Users\Clarisse\Documents\5th year documents\2nd sem\electives 3\Files\Text\SampleTxt" & i & ".txt", "" & allInfo.Text, True)

            MsgBox("Successfully saved as Text File.", MsgBoxStyle.Information, "Successfully Saved")

        Else
            MsgBox("Please Write all Information.", MsgBoxStyle.Critical, "Input Data")

        End If
    End Sub
    Private Sub xmlbtn_Click(sender As Object, e As EventArgs) Handles xmlbtn.Click
        If nameInfo.Text <> "" And ageInfo.Text <> "" And addressInfo.Text <> "" Then
            j += 1

            allInfo.Text = "==============================================" + vbNewLine +
            nameLabel.Text + " " + nameInfo.Text + vbNewLine + ageLabel.Text + " " + ageInfo.Text +
            vbNewLine + addressLabel.Text + " " + addressInfo.Text + vbNewLine +
            "==============================================" + vbNewLine

            My.Computer.FileSystem.WriteAllText("C:\Users\Clarisse\Documents\5th year documents\2nd sem\electives 3\Files\XML\SampleXML" & i & ".xml", "" & allInfo.Text, True)
            MsgBox("Successfully saved as XML File.", MsgBoxStyle.Information, "Successfully Saved")

        Else
            MsgBox("Please Write all Information.", MsgBoxStyle.Critical, "Input Data")

        End If
    End Sub
    Private Sub jsonbtn_Click(sender As Object, e As EventArgs) Handles jsonbtn.Click
        If nameInfo.Text <> "" And ageInfo.Text <> "" And addressInfo.Text <> "" Then
            k += 1

            allInfo.Text = "==============================================" + vbNewLine +
            nameLabel.Text + " " + nameInfo.Text + vbNewLine + ageLabel.Text + " " + ageInfo.Text +
            vbNewLine + addressLabel.Text + " " + addressInfo.Text + vbNewLine +
            "==============================================" + vbNewLine

            My.Computer.FileSystem.WriteAllText("C:\Users\Clarisse\Documents\5th year documents\2nd sem\electives 3\Files\JSON\SampleJSON" & i & ".json", "" & allInfo.Text, True)
            MsgBox("Successfully saved as JSON File.", MsgBoxStyle.Information, "Successfully Saved")

        Else
            MsgBox("Please Write all Information.", MsgBoxStyle.Critical, "Input Data")

        End If
    End Sub

    Private Sub allInfo_TextChanged(sender As Object, e As EventArgs) Handles allInfo.TextChanged


    End Sub

    Private Sub displayBtn_Click(sender As Object, e As EventArgs) Handles displayBtn.Click

        allInfo.Visible = True
        allInfo.Text = "==============================================" + vbNewLine +
            nameLabel.Text + " " + nameInfo.Text + vbNewLine + ageLabel.Text + " " + ageInfo.Text +
        vbNewLine + addressLabel.Text + " " + addressInfo.Text + vbNewLine +
        "==============================================" + vbNewLine

    End Sub
    Private Sub clrDataBtn_Click(sender As Object, e As EventArgs) Handles clrDataBtn.Click
        clearboxes()

    End Sub
    Sub clearboxes()
        nameInfo.Clear()
        ageInfo.Clear()
        addressInfo.Clear()
        allInfo.Clear()
        allInfo.Visible = False
    End Sub


End Class
