<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPWeb_equipo_12b.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-24">
        <div class="row justify-content-center">
            <div class="col-md-6">
                <label for="inputCodigo" class="form-label">¡Ingresá el código de tu voucher!</label>
                <asp:TextBox ID="inputCodigo" runat="server" CssClass="form-control" Placeholder="XXXXXXXXXXXX"></asp:TextBox>
                <asp:Button ID="btnSiguiente" runat="server" Text="Siguiente" CssClass="btn btn-primary mt-3" OnClick="btnSiguiente_Click" />
            </div>
        </div>
    </div>

</asp:Content>
