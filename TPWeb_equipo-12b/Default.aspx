<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPWeb_equipo_12b.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label for="inputCodigo" class="form-label">Ingresá el código de tu voucher!</label>
    <input type="text" id="inputCodigo" class="form-control" aria-describedby="codigoHelpBlock" placeholder="XXXXXXXXXXXX">
    <%--    <div id="codigoHelpBlock" class="form-text">
        Your password must be 8-20 characters long, contain letters and numbers, and must not contain spaces, special characters, or emoji.
    </div>--%>
    <button type="button" class="btn btn-primary">Siguiente</button>

</asp:Content>
