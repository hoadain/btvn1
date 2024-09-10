<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tính lãi suất</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center; padding-top:50px;">
            <h2>Tính lãi suất</h2>
            <table align="center">
                <tr>
                    <td>Nhập số tiền gửi:</td>
                    <td>
                        <asp:TextBox ID="txtTienGui" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Lãi suất (%):</td>
                    <td>
                        <asp:TextBox ID="txtLaiSuat" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Số năm gửi:</td>
                    <td>
                        <asp:TextBox ID="txtSoNam" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnTinh" runat="server" Text="Tính" OnClick="btnTinh_Click" />
                    </td>
                </tr>
                <tr>
                    <td>Kết quả tiền lãi:</td>
                    <td>
                        <asp:Label ID="lblTienLai" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Tổng số tiền sau lãi:</td>
                    <td>
                        <asp:Label ID="lblTongTien" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>