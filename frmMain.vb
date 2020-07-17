'*******************************************
'*******************************************
'Programmer: {Your name goes here}
'Course: ITSE 1332.xxxx (VB)
'Program purpose: {Program Purpose Goes here}
'*******************************************
'*******************************************

#Region "Compiler_Directives"
'*******************************************
Option Explicit On  'Forces explicit declaration of all variables in a file, or allows implicit declarations of variables
Option Strict On    'Restricts implicit data type conversions to only widening conversions, disallows late binding, and disallows implicit typing
Option Infer Off    'Disables the use of local type inference in declaring variables
#Disable Warning IDE1006    'Disables warnings over class naming convention for controls
'*******************************************
#End Region

Public Class frmMain
    Dim bolExit As Boolean = False
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        If Windows.Forms.DialogResult.Yes = MessageBox.Show("Are you sure you want to Exit?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            bolExit = True
            Application.Exit()
        End If


    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not bolExit Then
            If Windows.Forms.DialogResult.Yes = MessageBox.Show("Are you sure you want to Exit?",
                                                                "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                bolExit = True
                Application.Exit()
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnNewForm_Click(sender As Object, e As EventArgs) Handles btnNewForm.Click
        Dim newForm As frmDavid
        newForm = New frmDavid
        newForm.ShowDialog()

    End Sub
End Class
