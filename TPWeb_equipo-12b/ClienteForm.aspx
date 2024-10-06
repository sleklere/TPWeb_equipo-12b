<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ClienteForm.aspx.cs" Inherits="TPWeb_equipo_12b.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2>Ingresá tus datos</h2>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtDNI" Text="DNI"></asp:Label>
            <asp:TextBox runat="server" ID="txtDNI" class="form-control" placeholder="DNI"></asp:TextBox>
        </div>
        
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtNombre" Text="Nombre"></asp:Label>
            <asp:TextBox runat="server" ID="txtNombre" class="form-control" placeholder="Nombre"></asp:TextBox>
        </div>
        
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtApellido" Text="Apellido"></asp:Label>
            <asp:TextBox runat="server" ID="txtApellido" class="form-control" placeholder="Apellido"></asp:TextBox>
        </div>
        
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtEmail" Text="Email"></asp:Label>
            <asp:TextBox runat="server" ID="txtEmail" class="form-control" placeholder="Email"></asp:TextBox>
        </div>
        
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtDireccion" Text="Dirección"></asp:Label>
            <asp:TextBox runat="server" ID="txtDireccion" class="form-control" placeholder="Dirección"></asp:TextBox>
        </div>
        
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtCiudad" Text="Ciudad"></asp:Label>
            <asp:TextBox runat="server" ID="txtCiudad" class="form-control" placeholder="Ciudad"></asp:TextBox>
        </div>
        
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtCP" Text="CP"></asp:Label>
            <asp:TextBox runat="server" ID="txtCP" class="form-control" placeholder="CP"></asp:TextBox>
        </div>
        
        <div class="form-group">
            <asp:CheckBox runat="server" ID="chkTerminos" />
            <asp:Label runat="server" AssociatedControlID="chkTerminos" Text="Acepto los términos y condiciones"></asp:Label>
        </div>
        
        <asp:Label ID="lblError" runat="server" Text="" class="text-danger mb-2" Visible="false"></asp:Label>

        <div class="form-group">
            <asp:Button runat="server" ID="btnSubmit" Text="Participar!" class="btn btn-primary" OnClick="btnSubmit_Click" />
        </div>
    </div>
</asp:Content>