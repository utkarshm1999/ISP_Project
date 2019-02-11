Imports System.Drawing.Drawing2D

Public Class CustomRoundedPanel
    Inherits Panel
    Public Sub New()
    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaintBackground(e)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        Dim brush As New LinearGradientBrush(New Point(Me.Width / 2, 0), New Point(Me.Width / 2, Me.Height), SystemColors.GradientInactiveCaption, ControlPaint.Dark(SystemColors.GradientActiveCaption, 0.5F))
        'g.FillRoundedRectangle(brush, 0, 0, Me.Width - 1, Me.Height, 10)
        'g.FillRoundedRectangle(New SolidBrush(Color.FromArgb(100, 118, 173, 218)), 0, 0, Me.Width, Me.Height, 10)
        g.DrawRoundedRectangle(New Pen(ControlPaint.Light(SystemColors.WindowFrame, 0.0F)), 0, 0, Me.Width - 1, Me.Height - 1, 5)
    End Sub

End Class