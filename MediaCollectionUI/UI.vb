
Public Class UI
    Dim drag As Boolean

    Dim mousex As Integer

    Dim mousey As Integer


    Private Sub UI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseDown


        ' If e.Button = MouseButtons.Left Then

        drag = True

        mousex = Cursor.Position.X - Me.Left

        mousey = Cursor.Position.Y - Me.Top

        ' End If

    End Sub


    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseMove

        If drag Then

            Me.Top = Cursor.Position.Y - mousey

            Me.Left = Cursor.Position.X - mousex

        End If

    End Sub


    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseUp

        drag = False

    End Sub





End Class