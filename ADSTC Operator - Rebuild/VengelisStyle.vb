Imports System.Drawing.Drawing2D

Public Class VProgressBar : Inherits Control

    Private _valeur As Integer
    Private _couleur1 As Color
    Private _couleur2 As Color
    Private _CouleurFond As Color

    Public Property Valeur() As Integer
        Get
            Return _valeur
        End Get
        Set(value As Integer)
            _valeur = value
            Refresh()
        End Set
    End Property
    Public Property Couleur1() As Color
        Get
            Return _couleur1
        End Get
        Set(value As Color)
            _couleur1 = value
            Refresh()
        End Set
    End Property
    Public Property Couleur2() As Color
        Get
            Return _couleur2
        End Get
        Set(value As Color)
            _couleur2 = value
            Refresh()
        End Set
    End Property
    Public Property CouleurFond() As Color
        Get
            Return _CouleurFond
        End Get
        Set(value As Color)
            _CouleurFond = value
            Refresh()
        End Set
    End Property

    Public Sub New()
        Size = New Size(200, 30)
        _valeur = 0
        _couleur1 = Color.Black
        _couleur2 = Color.Orange
        _CouleurFond = Color.FromArgb(30, 30, 30)

    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim G As Graphics = e.Graphics
        G.Clear(_CouleurFond)

        Dim Progress As Double = (_valeur / 100) * Width - 4
        If Progress > 0 Then
            Dim r As New Rectangle(2, 2, Progress, Height - 4)
            Dim GB = New LinearGradientBrush(r, _couleur1, _couleur2, 90)
            G.FillRectangle(GB, r)
        End If
    End Sub

End Class
