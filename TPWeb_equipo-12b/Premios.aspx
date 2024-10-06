<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Premios.aspx.cs" Inherits="TPWeb_equipo_12b.Premios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center align-items-center" style="width: 100%; height: 100vh; gap: 1rem;">
        <% foreach (Dominio.Articulo articulo in listaArticulos) { %>
        <div class="card" style="width: 18rem;">
            <!-- Cada carrusel tiene un ID único basado en el ID del artículo -->
            <div id="carousel_<%= articulo.Id %>" class="carousel slide" data-ride="carousel">
              <div class="carousel-inner">
                <% 
                var imagenes = imagenesPorArticulo[articulo.Id];
                if (imagenes.Count > 0) 
                { 
                    bool isActive = true;
                    foreach (var img in imagenes) 
                    { 
                %>
                    <div class="carousel-item <%= isActive ? "active" : "" %>">
                      <img src="<%= img.ImagenUrl %>" class="d-block w-100" alt="Imagen de <%= articulo.Nombre %>">
                      <script>
                          console.log('Imagen URL: <%= img.ImagenUrl %>');
                          console.log('Imagen URL: <%= imagenes.Count %>');
                      </script>
                    </div>
                <% 
                    isActive = false;
                    }
                } 
                %>
              </div>
              <!-- Controles de navegación -->
              <a class="carousel-control-prev" href="#carousel_<%= articulo.Id %>" role="button" data-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
              </a>
              <a class="carousel-control-next" href="#carousel_<%= articulo.Id %>" role="button" data-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
              </a>
            </div>
            <div class="card-body">
                <h5 class="card-title"><%: articulo.Nombre %></h5>
                <p class="card-text"><%: articulo.Descripcion %></p>
                <a href="ClienteForm.aspx" class="btn btn-primary">Quiero este!</a>
            </div>
        </div>
        <% } %>
    </div>
</asp:Content>