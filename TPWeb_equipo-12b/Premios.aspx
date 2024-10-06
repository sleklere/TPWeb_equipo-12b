<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Premios.aspx.cs" Inherits="TPWeb_equipo_12b.Premios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center align-items-center" style="width: 100%; height: 100vh; gap: 1rem;">

        <% foreach (Dominio.Articulo articulo in listaArticulos) { %>
        <div class="card" style="width: 18rem;">
            <img class="card-img-top" src="..." alt="Card image cap">
            <div class="card-body">
                <h5 class="card-title"><%: articulo.Nombre %></h5>
                <p class="card-text"><%: articulo.Descripcion %></p>
                <a href="ClienteForm.aspx" class="btn btn-primary">Quiero este!</a>
            </div>
        </div>
        <% } %>

    </div>
</asp:Content>
