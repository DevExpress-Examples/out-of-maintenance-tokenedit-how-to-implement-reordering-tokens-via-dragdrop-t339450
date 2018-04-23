Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace T269192
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            AddHandler tokenEdit1.MouseMove, AddressOf tokenEdit1_MouseMove
            AddHandler tokenEdit1.MouseDown, AddressOf tokenEdit1_MouseDown
            tokenEdit1.AllowDrop = True
        End Sub

        Private Sub tokenEdit1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            tokenEditToken = tokenEdit1.CalcHitInfo(e.Location)
        End Sub

        Private Sub tokenEdit1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            If (e.Button And MouseButtons.Left) = MouseButtons.Left Then
                tokenEdit1.DoDragDrop(tokenEditToken,DragDropEffects.Move)
            End If
        End Sub
        Private tokenEditToken As TokenEditHitInfo

        Private Sub tokenEdit1_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles tokenEdit1.DragEnter
            e.Effect = DragDropEffects.Move
        End Sub

        Private Sub tokenEdit1_DragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles tokenEdit1.DragOver
            e.Effect = DragDropEffects.Move
        End Sub

        Private Sub tokenEdit1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles tokenEdit1.DragDrop
            Dim token As TokenEditHitInfo = DirectCast(e.Data.GetData(GetType(TokenEditHitInfo)), TokenEditHitInfo)
            Dim allTokens = tokenEdit1.GetTokenList()
            Dim newPl = tokenEdit1.CalcHitInfo(tokenEdit1.PointToClient(New Point(e.X, e.Y)))
            If (Not newPl.InToken) AndAlso newPl.InEditorRect Then
                Dim values = DirectCast(tokenEdit1.EditValue, IList)
                values.Remove(token.Token.Value.ToString())
                values.Add(token.Token.Value.ToString())
                tokenEdit1.EditValue = values
            ElseIf newPl.InToken Then
                Dim hitPoint = CType(newPl, DevExpress.XtraEditors.ViewInfo.EditHitInfo).HitPoint.X

                Dim tokenStartX = newPl.TokenInfo.Bounds.X
                Dim tokenEndX = newPl.TokenInfo.Bounds.X + newPl.TokenInfo.Bounds.Width
                Dim before As Boolean = hitPoint - tokenStartX < tokenEndX - hitPoint
                Dim values = DirectCast(tokenEdit1.EditValue, IList)
                values.Remove(token.Token.Value.ToString())
                Dim index As Integer = values.IndexOf(newPl.Token.Value)
                values.Insert(If(before, index, index +1), token.Token.Value.ToString())
            End If
        End Sub
    End Class
End Namespace
