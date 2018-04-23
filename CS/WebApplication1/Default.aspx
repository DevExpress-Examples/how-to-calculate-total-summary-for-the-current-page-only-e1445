<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<%@ register Assembly="DevExpress.Web.ASPxEditors.v9.1, Version=9.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>

<%@ register Assembly="DevExpress.Web.ASPxGridView.v9.1, Version=9.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dxwgv:aspxgridview ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="AccessDataSource1" KeyFieldName="ProductID" OnCustomSummaryCalculate="ASPxGridView1_CustomSummaryCalculate">
            <totalsummary>
                <dxwgv:aspxsummaryitem DisplayFormat="c" FieldName="UnitPrice" ShowInColumn="Unit Price"
                    SummaryType="Custom" />
            </totalsummary>
            <columns>
                <dxwgv:gridviewdatatextcolumn FieldName="ProductID" ReadOnly="True" VisibleIndex="0">
                    <editformsettings Visible="False" />
                </dxwgv:gridviewdatatextcolumn>
                <dxwgv:gridviewdatatextcolumn FieldName="ProductName" VisibleIndex="1">
                </dxwgv:gridviewdatatextcolumn>
                <dxwgv:gridviewdatatextcolumn FieldName="CategoryID" VisibleIndex="2">
                </dxwgv:gridviewdatatextcolumn>
                <dxwgv:gridviewdatatextcolumn FieldName="UnitPrice" VisibleIndex="3">
                </dxwgv:gridviewdatatextcolumn>
            </columns>
            <settings ShowFooter="True" />
        </dxwgv:aspxgridview>
        <asp:accessdatasource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/nwind.mdb"
            SelectCommand="SELECT [ProductID], [ProductName], [CategoryID], [UnitPrice] FROM [Products]">
        </asp:accessdatasource>
    </div>
    </form>
</body>
</html>
