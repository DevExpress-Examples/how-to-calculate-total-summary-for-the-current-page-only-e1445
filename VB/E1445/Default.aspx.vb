Imports DevExpress.Web
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

    End Sub
    Protected Sub ASPxGridView1_CustomSummaryCalculate(ByVal sender As Object, ByVal e As DevExpress.Data.CustomSummaryEventArgs)
        Dim totalPrice As Decimal = 0
        Dim startIndex As Integer = DirectCast(sender, ASPxGridView).PageIndex * DirectCast(sender, ASPxGridView).SettingsPager.PageSize
        Dim endIndex As Integer = startIndex + DirectCast(sender, ASPxGridView).SettingsPager.PageSize
        For i As Integer = startIndex To endIndex - 1
            Dim currentPrice As Decimal = Convert.ToDecimal(DirectCast(sender, ASPxGridView).GetRowValues(i, "UnitPrice"))
            totalPrice = totalPrice + currentPrice
        Next i
        e.TotalValue = totalPrice
    End Sub
End Class