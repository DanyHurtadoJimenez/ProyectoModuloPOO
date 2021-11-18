<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="FrmAbrirC.aspx.cs" Inherits="InterfazWeb.FrmAbrirC" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/estilosAbrirC.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class=" text-center mt-4 mb-5">Abrir Cursos</h1>


    <% if (Session["_mensaje"] != null)// if metido en medio del codigo html
        {%>

    <div class="alert alert-warning alert-dismissible fade show" role="alert">
        <%= Session["_mensaje"]%>
        <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
    </div>
    <%                                                                          //se muestra el mensaje y lo borra
            //Session["_mensaje"] = null; 
        } %>



    <div class="container">

        <label for="basic-url" class="form-label">Escoja la materia</label>

        <div class="input-group mb-4 justify-content-between flex-nowrap align-items-center contenedores ">
            <asp:Label ID="Label1" CssClass="me-3 ms-2" runat="server" Text="Código Materia"></asp:Label>
            <asp:TextBox CssClass="textBox" ID="txtCodigoMateria" runat="server" ReadOnly="True" Width="114px"></asp:TextBox>

            <asp:Label ID="Label2" CssClass="me-3 ms-2" runat="server" Text="Nombre Materia"></asp:Label>
            <asp:TextBox CssClass="textBox" ID="txtNombreMateria" runat="server" ReadOnly="True" Width="151px"></asp:TextBox>

            <asp:Label ID="Label3" CssClass="me-3 ms-2" runat="server" Text="Créditos Materia"></asp:Label>
            <asp:TextBox CssClass="textBox" ID="txtCreditos" runat="server" ReadOnly="True" Width="32px"></asp:TextBox>

            <asp:Label ID="Label4" CssClass="me-3 ms-2" runat="server" Text="Nombre Carrera"></asp:Label>
            <asp:TextBox CssClass="textBox" ID="txtNombreCarrera" runat="server" ReadOnly="True" Width="119px"></asp:TextBox>

            <asp:Button ID="btnBuscarMateria" CssClass="btn btn-outline-secondary ms-3" runat="server" Text="Buscar Materia" Style="left: 0px; top: 0px; width: 156px" />

        </div>

        <hr />

        <label for="basic-url" class="form-label">Escoja los periodos y demas información importante</label>

        <div class="input-group mb-4 justify-content-between flex-nowrap align-items-center contenedores ">
            <asp:Label ID="Label5" CssClass="me-3 ms-2" runat="server" Text="Grupo"></asp:Label>
            <asp:TextBox CssClass="textBox" ID="txtGrupo" runat="server" ReadOnly="True" Width="151px"></asp:TextBox>

            <asp:Label ID="Label6" CssClass="me-3 ms-2" runat="server" Text="Cupo"></asp:Label>
            <asp:TextBox CssClass="textBox" ID="nudCupo" TextMode="Number" runat="server" min="0" max="20" step="1" Width="174px"></asp:TextBox>

            <asp:Label ID="Label7" CssClass="me-3 ms-2" runat="server" Text="Costo"></asp:Label>
            <asp:TextBox CssClass="textBox" ID="txtCosto" runat="server" Width="137px"></asp:TextBox>

            <asp:Label ID="Label8" CssClass="me-3 ms-2" runat="server" Text="Periodo"></asp:Label>
            <asp:TextBox CssClass="textBox" ID="nudPeriodo" TextMode="Number" runat="server" min="1" max="3" step="1"></asp:TextBox>

            <asp:Label ID="Label9" CssClass="me-3 ms-2" runat="server" Text="Año"></asp:Label>
            <asp:DropDownList ID="DropDownAnios" runat="server"></asp:DropDownList>

        </div>

        <hr />

        <label for="basic-url" class="form-label">Escoja los horarios (Debe escoger al menos 1)</label>

        <div class="input-group mb-3 justify-content-between flex-nowrap align-items-center contenedores ">
            <asp:Label ID="Label10" CssClass="me-3 ms-2" runat="server" Text="Día"></asp:Label>
            <asp:DropDownList ID="DropDownListDias" runat="server">
                <asp:ListItem>L</asp:ListItem>
                <asp:ListItem>K</asp:ListItem>
                <asp:ListItem>M</asp:ListItem>
                <asp:ListItem>J</asp:ListItem>
                <asp:ListItem>V</asp:ListItem>
                <asp:ListItem>S</asp:ListItem>
            </asp:DropDownList>

            <asp:Label ID="Label11" CssClass="me-3 ms-2" runat="server" Text="Hora Inicio"></asp:Label>
            <asp:TextBox CssClass="textBox" ID="txtHoraInicio" TextMode="Time" runat="server"></asp:TextBox>

            <asp:Label ID="Label12" CssClass="me-3 ms-2" runat="server" Text="Hora Fin"></asp:Label>
            <asp:TextBox CssClass="textBox" ID="txtHoraFin" TextMode="Time" runat="server"></asp:TextBox>

        </div>

        <div class="input-group mb-3 justify-content-between">
            <asp:GridView ID="GrdVerHorarios" AllowPaging="True" runat="server" AutoGenerateColumns="False" CellPadding="4" EmptyDataText="No se registran horarios escogidos." GridLines="None" Width="100%" ForeColor="#333333" PageSize="5">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkModificar" runat="server">Modificar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkEliminar" runat="server">Eliminar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField HeaderText="Dia" />
                    <asp:BoundField HeaderText="Hora Inicio" />
                    <asp:BoundField HeaderText="Hora Fin" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#070D59" ForeColor="White" Font-Bold="True" />
                <HeaderStyle BackColor="#EE6F57" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#070D59" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </div>

        <div class="input-group mb-5 justify-content-center">
            <asp:Button ID="btnSiguiente" CssClass="btn btn-primary btn-lg" runat="server" Text="Siguiente"/>
        </div>

    </div>


</asp:Content>
