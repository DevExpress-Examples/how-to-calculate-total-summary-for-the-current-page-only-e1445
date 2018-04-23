Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxGridView

Namespace WebApplication1
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub ASPxGridView1_CustomSummaryCalculate(ByVal sender As Object, ByVal e As DevExpress.Data.CustomSummaryEventArgs)
			Dim totalPrice As Decimal = 0
			Dim startIndex As Integer = (CType(sender, ASPxGridView)).PageIndex * (CType(sender, ASPxGridView)).SettingsPager.PageSize
			Dim endIndex As Integer = startIndex + (CType(sender, ASPxGridView)).SettingsPager.PageSize
			For i As Integer = startIndex To endIndex - 1
				Dim currentPrice As Decimal = Convert.ToDecimal((CType(sender, ASPxGridView)).GetRowValues(i, "UnitPrice"))
				totalPrice = totalPrice + currentPrice
			Next i
			e.TotalValue = totalPrice
		End Sub
	End Class
End Namespace
