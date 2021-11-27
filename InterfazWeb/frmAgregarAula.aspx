<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="frmAgregarAula.aspx.cs" Inherits="InterfazWeb.frmAgregarAula" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container">
        <h1 class="text-center mt-3 mb-5">Asignar Aula</h1>

        <% if (Session["_mensaje"] != null)// if metido en medio del codigo html
            {%>

        <div class="alert alert-warning alert-dismissible fade show text-center" role="alert">
            <%= Session["_mensaje"]%>
            <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
        </div>
        <%                                                                          //se muestra el mensaje y lo borra
                //Session["_mensaje"] = null; 
            } %>

        <div class="row mt-5">
            <h2 class="mt-3 mb-3">Informacion del Curso:</h2>
            <div class="col">
                <asp:Label ID="Label4" runat="server" Text="Codigo Materia:"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtCodMateria" runat="server" ReadOnly="True"></asp:TextBox>
            </div>
            <div class="col">
                <asp:Label ID="Label5" runat="server" Text="Nombre Materia:"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtNombreMateria" runat="server" ReadOnly="True"></asp:TextBox>
            </div>

            <div class="col">
                <asp:Label ID="Label7" runat="server" Text="Creditos Materia:"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtCreditosM" runat="server" ReadOnly="True"></asp:TextBox>
            </div>

            <div class="col">
                <asp:Label ID="Label8" runat="server" Text="Nombre Carrera:"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtCarrera" runat="server" ReadOnly="True"></asp:TextBox>
            </div>

            <div class="col">
                <asp:Label ID="Label9" runat="server" Text="Grupo:"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtGrupo" runat="server" ReadOnly="True"></asp:TextBox>
            </div>

            <div class="col">
                <asp:Label ID="Label11" runat="server" Text="Cupo:"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtCupo" runat="server" ReadOnly="True"></asp:TextBox>
            </div>

            <div class="col">
                <asp:Label ID="Label6" runat="server" Text="Periodo:"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtPeriodo" runat="server" ReadOnly="True"></asp:TextBox>
            </div>

            <div class="col">
                <asp:Label ID="Label10" runat="server" Text="Año:"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtAnio" runat="server" ReadOnly="True"></asp:TextBox>
                <asp:TextBox CssClass="form-control" ID="txtCodMateriaAbierta" runat="server" Visible="False"></asp:TextBox>
            </div>

        </div>

        <div class="row mt-5">
            <h2 class="mt-3 mb-3">Informacion del Aula:</h2>
            <div class="col">
                <asp:Label ID="Label1" runat="server" Text="Numero Aula:"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtNumAula" runat="server" ReadOnly="True"></asp:TextBox>
            </div>
            <div class="col">
                <asp:Label ID="Label3" runat="server" Text="Tipo Aula:"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtTipoAula" runat="server" ReadOnly="True"></asp:TextBox>
            </div>

            <div class="col">
                <asp:Label ID="Label2" runat="server" Text="Capacidad:"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtCapacidadAula" runat="server" ReadOnly="True"></asp:TextBox>
                <asp:TextBox CssClass="form-control" ID="txtCodigoAula" runat="server" Visible="False"></asp:TextBox>
            </div>

            <div class="col">
                <asp:Button CssClass="btn btn-outline-danger" ID="btnEliminarAula" runat="server" Text="Retirar Aula" />
            </div>
        </div>

        <hr class="mt-lg-5 mb-lg-5" />

        <h2 class="mt-3 mb-3">Escoja un aula</h2>


        <asp:GridView ID="GrdVerAulas" CssClass="mt-lg-5 mb-lg-5" AllowPaging="True" runat="server" AutoGenerateColumns="False" CellPadding="5" EmptyDataText="No se registran aulas." GridLines="None" Width="100%" ForeColor="#333333" PageSize="5" OnPageIndexChanging="GrdVerAulas_PageIndexChanging">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkSeleccionar" runat="server" CommandArgument='<%# Eval("CodigoAula").ToString() %>' OnCommand="lnkSeleccionar_Command">Seleccionar</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="CodigoAula" HeaderText="Cod Aula" Visible="False" />
                <asp:BoundField HeaderText="Número Aula" DataField="NumeroAula" />
                <asp:BoundField HeaderText="Tipo Aula" DataField="TipoAula" />
                <asp:BoundField HeaderText="Capacidad" DataField="Capacidad" />
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

        <div class="input-group mt-lg-5 mb-lg-5 justify-content-center">
            <asp:Button ID="btnAtras" CssClass="btn btn-primary btn-lg mt-5 ms-5" runat="server" Text="Ir Atrás" Style="width: 114px; left: 0px; top: 0px" />
            <asp:Button ID="btnFinalizar" CssClass="btn btn-primary btn-lg mt-5 ms-5" runat="server" Text="Finalizar Proceso" />
        </div>

    </div>




</asp:Content>


