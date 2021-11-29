﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="FrmMatricular.aspx.cs" Inherits="InterfazWeb.FrmMatricular" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">

        <h1 class="text-center mt-3">Matricular</h1>

        <% if (Session["_mensaje"] != null)// if metido en medio del codigo html
            {%>

        <div class="alert alert-warning alert-dismissible fade show text-center" role="alert">
            <%= Session["_mensaje"]%>
            <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
        </div>
        <%                                                                          //se muestra el mensaje y lo borra
                //Session["_mensaje"] = null; 
            } %>

        <div class="row mb-3">

            <h4>Informacion de la matrícula:</h4>

            <div class="col">
                <asp:Label ID="Label4" runat="server" Text="Num Factura:"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtNumFactura" runat="server" ReadOnly="True"></asp:TextBox>
            </div>

            <div class="col">
                <asp:Label ID="Label1" runat="server" Text="Fecha Matrícula:"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtFechaMatricula" runat="server" ReadOnly="True" TextMode="Date"></asp:TextBox>
            </div>

            <div class="col">
                <asp:Label ID="Label2" runat="server" Text="Periodo:"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtPeriodo" runat="server" ReadOnly="True"></asp:TextBox>
            </div>

            <div class="col">
                <asp:Label ID="Label3" runat="server" Text="Año:"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtAnio" runat="server" ReadOnly="True"></asp:TextBox>
            </div>

        </div>

        <hr class="mb-1 mt-1" />

        <div class="row mb-2">

            <h4>Informacion del estudiante:</h4>

            <div class="col">
                <asp:Label ID="Label5" runat="server" Text="Carnet:"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtCarnet" runat="server" ReadOnly="True"></asp:TextBox>
            </div>

            <div class="col">
                <asp:Label ID="Label6" runat="server" Text="Cédula:"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtCedula" runat="server" ReadOnly="True"></asp:TextBox>
            </div>

            <div class="col">
                <asp:Label ID="Label7" runat="server" Text="Nombre Estudiante:"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtNombre" runat="server" ReadOnly="True"></asp:TextBox>
            </div>

            <div class="col">
                <asp:Label ID="Label8" runat="server" Text="Email:"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server" ReadOnly="True"></asp:TextBox>
            </div>

            <div class="col">
                <asp:Label ID="Label9" runat="server" Text="Descuento:"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtDescuento" runat="server" ReadOnly="True"></asp:TextBox>
            </div>

            <div class="col">
                <asp:Button ID="btnBuscarEstudiante" CssClass="btn btn-outline-secondary mb-3 mt-5" runat="server" Text="Buscar Estudiante" OnClick="btnBuscarEstudiante_Click" />
            </div>

        </div>

        <hr class="mb-2 mt-2" />

        <div class="mt-1 mb-3" style="display: flex; justify-content: flex-start; align-items: center">
            <h4>Buscar Materia a Matricular</h4>
            <asp:Button ID="btnBuscarMateria" CssClass="btn btn-outline-primary ms-5" runat="server" Text="Buscar Curso" OnClick="btnBuscarMateria_Click" />
        </div>

        <asp:GridView ID="GrdVerMaterias" CssClass="mt-lg-2 mb-lg-2" AllowPaging="True" runat="server" AutoGenerateColumns="False" CellPadding="5" EmptyDataText="No se registran materias escogidas." GridLines="None" Width="100%" ForeColor="#333333" PageSize="5">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkEliminar" CommandArgument='<%# Eval("CodMateriaAbierta").ToString() %>' runat="server">Eliminar</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="CodMateriaAbierta" HeaderText="codMateriaAbierta" Visible="False" />
                <asp:BoundField DataField="CodigoMateria" HeaderText="Código Materia" />
                <asp:BoundField DataField="NombreMateria" HeaderText="Nombre Materia" />
                <asp:BoundField DataField="Requisito" HeaderText="Cod Requisito" />
                <asp:BoundField DataField="nombreRequisito" HeaderText="Requisito" />
                <asp:BoundField DataField="NombreProfesor" HeaderText="Nombre Profesor" />
                <asp:BoundField DataField="NumeroAula" HeaderText="Número Aula" />
                <asp:BoundField DataField="Grupo" HeaderText="Grupo" />
                <asp:BoundField DataField="Costo" HeaderText="Costo" />
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

        <hr class="mb-2 mt-2" />

    </div>

</asp:Content>


