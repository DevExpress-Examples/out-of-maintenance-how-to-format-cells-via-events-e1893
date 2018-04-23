Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxPivotGrid
Imports DevExpress.XtraPivotGrid

Namespace FormattingViaEvents
     Partial Public Class _Default
          Inherits Page
          Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
          End Sub
          Protected Sub CustomCellDisplayText(ByVal sender As Object, _
                    ByVal e As PivotCellDisplayTextEventArgs)
               If e.RowValueType <> PivotGridValueType.GrandTotal OrElse _
                         e.ColumnValueType = PivotGridValueType.GrandTotal Then
                    Return
               End If
               If Convert.ToSingle(e.Value) < 50000 Then
                    e.DisplayText = "Low"
               ElseIf Convert.ToSingle(e.Value) > 100000 Then
                    e.DisplayText = "High"
               Else
                    e.DisplayText = "Middle"
               End If
          End Sub
     End Class
End Namespace
