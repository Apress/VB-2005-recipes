Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Management
Imports System.Collections
Imports System.text
'  All designed code is stored in the autogenerated partial
'  class called Recipe08-18.Designer.vb.  You can see this
'  file by selecting "Show All Files" in solution explorer.
Partial Public Class Recipe08_18

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click

        '  Select all the outstanding print jobs.
        Dim query As String = "SELECT * FROM Win32_PrintJob"

        Using jobQuery As New ManagementObjectSearcher(query)
            Using jobs As ManagementObjectCollection = jobQuery.Get()
                '  Add the jobs in the queue to the list box.
                lstJobs.Items.Clear()
                txtJobInfo.Text = ""

                For Each job As ManagementObject In jobs
                    lstJobs.Items.Add(job("JobID"))
                Next
            End Using
        End Using

    End Sub
    Private Sub Recipe08_18_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        cmdRefresh_Click(Nothing, Nothing)

    End Sub
    '  This helper method performs a WMI query and returns the
    '  WMI job for the currently selected list box item.
    Private Function GetSelectedJob(ByVal jobID As String) As ManagementObject

        Try
            '  Select the matching print job.
            Dim query As String = "SELECT * FROM Win32_PrintJob WHERE JobID='" & jobID & "'"
            Dim job As ManagementObject = Nothing

            Using jobQuery As New ManagementObjectSearcher(query)
                Dim jobs As ManagementObjectCollection = jobQuery.Get
                Dim enumerator As IEnumerator = jobs.GetEnumerator

                enumerator.MoveNext()
                job = DirectCast(enumerator.Current, ManagementObject)
            End Using
            Return job
        Catch ex As InvalidOperationException
            '  The current property of the enumerator is invalid.
            Return Nothing
        End Try

    End Function
    Private Sub lstJobs_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstJobs.SelectedIndexChanged

        Dim job As ManagementObject = GetSelectedJob(lstJobs.Text)

        If job Is Nothing Then
            txtJobInfo.Text = ""
            Exit Sub
        End If

        '  Display job information.
        Dim jobInfo As New StringBuilder

        jobInfo.AppendFormat("Document: {0}", job("Document").ToString)
        jobInfo.Append(Environment.NewLine)
        jobInfo.AppendFormat("DriverName: {0}", job("DriverName").ToString)
        jobInfo.Append(Environment.NewLine)
        jobInfo.AppendFormat("Status: {0}", job("Status").ToString)
        jobInfo.Append(Environment.NewLine)
        jobInfo.AppendFormat("Owner: {0}", job("Owner").ToString)
        jobInfo.Append(Environment.NewLine)
        jobInfo.AppendFormat("PagesPrinted: {0}", job("PagesPrinted").ToString)
        jobInfo.Append(Environment.NewLine)
        jobInfo.AppendFormat("TotalPages: {0}", job("TotalPages").ToString)

        If job("JobStatus") IsNot Nothing Then
            txtJobInfo.Text += Environment.NewLine
            txtJobInfo.Text += "JobStatus: " & job("JobStatus").ToString
        End If

        If job("StartTime") IsNot Nothing Then
            jobInfo.Append(Environment.NewLine)
            jobInfo.AppendFormat("StartTime: {0}", job("StartTime").ToString)
        End If
        txtJobInfo.Text = jobInfo.ToString

    End Sub
    Private Sub cmdPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPause.Click

        If lstJobs.SelectedIndex = -1 Then Exit Sub

        Dim job As ManagementObject = GetSelectedJob(lstJobs.Text)

        If job Is Nothing Then Exit Sub

        '  Attempt to pause the job.
        Dim returnValue As Integer = CType(job.InvokeMethod("Pause", Nothing), Integer)

        '  Display information about the return value.
        If returnValue = 0 Then
            MessageBox.Show("Successfully paused job.")
        Else
            MessageBox.Show("Unrecognized return value when pausing job.")
        End If

    End Sub
    Private Sub cmdResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdResume.Click

        If lstJobs.SelectedIndex = -1 Then Exit Sub

        Dim job As ManagementObject = GetSelectedJob(lstJobs.Text)

        If job Is Nothing Then Exit Sub

        If (CInt(job("StatusMask") And 1)) = 1 Then
            '  Attempt to resume the job.
            Dim returnValue As Integer = CType(job.InvokeMethod("Resume", Nothing), Integer)

            '  Display information about the return value.
            If returnValue = 0 Then
                MessageBox.Show("Successfully resumed job.")
            ElseIf returnValue = 5 Then
                MessageBox.Show("Access denied.")
            Else
                MessageBox.Show("Unrecognized return value when resuming job.")
            End If

        End If

    End Sub

End Class
