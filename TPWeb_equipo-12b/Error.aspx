<%@ Page Title="Error" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="TPWeb_equipo_12b.Error" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-6 text-center">
                <h1 class="display-4 text-danger">¡Error!</h1>
                <asp:Label ID="lblError" runat="server" CssClass="lead"></asp:Label>
                <asp:Button ID="btnVolver" runat="server" Text="Volver" CssClass="btn btn-primary mt-3" OnClick="btnVolver_Click" />
            </div>
        </div>
    </div>
</asp:Content>
