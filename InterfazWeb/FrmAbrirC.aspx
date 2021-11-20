<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="FrmAbrirC.aspx.cs" Inherits="InterfazWeb.FrmAbrirC" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/estilosAbrirC.css" rel="stylesheet" />

    <script src="JQuery/jQuery.js"></script>
    <script src="js/funciones.js"></script>
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

            <input id="btnBuscarMateria" class="btn btn-outline-secondary ms-3" type="button" value="Buscar Materia" data-bs-toggle="modal" data-bs-target="#materiaModal" />
        </div>

        <hr />

        <label for="basic-url" class="form-label">Escoja los periodos y demas información importante</label>

        <div class="input-group mb-4 justify-content-between flex-nowrap align-items-center contenedores ">
            <asp:Label ID="Label5" CssClass="me-3 ms-2" runat="server" Text="Grupo"></asp:Label>
            <asp:TextBox CssClass="textBox" ID="txtGrupo" runat="server" ReadOnly="True" Width="151px" MaxLength="2" TextMode="Number"></asp:TextBox>

            <asp:Label ID="Label6" CssClass="me-3 ms-2" runat="server" Text="Cupo"></asp:Label>
            <asp:TextBox CssClass="textBox" ID="nudCupo" TextMode="Number" runat="server" min="0" max="20" step="1" Width="174px"></asp:TextBox>

            <asp:Label ID="Label7" CssClass="me-3 ms-2" runat="server" Text="Costo"></asp:Label>
            <asp:TextBox CssClass="textBox" ID="txtCosto" runat="server" Width="137px" TextMode="Number"></asp:TextBox>

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
            <asp:Button ID="btnSiguiente" CssClass="btn btn-primary btn-lg" runat="server" Text="Siguiente" />
        </div>

    </div>

    <%--Modal Buscar Materia--%>
    <div class="modal fade" id="materiaModal" tabindex="-1" aria-labelledby="MateriaModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="MateriaModalLabel">Buscar Materia</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <div class="row ">
                        <div class="col">

                            <div class="row mt-3">
                                <div class="col-auto">

                                </div>
                                <div class="col-auto">
                                    <asp:TextBox ID="txtnombreMateriaCarrera" runat="server" class="form-control"></asp:TextBox>
                                </div>
                                <div class="col-auto">
                                    <asp:Button ID="btnBuscar" runat="server" class="btn btn-primary" Text="Buscar"/>
                                </div>
                            </div>
                            <br />

                            <br />
                            <asp:GridView ID="GrdListaMaterias" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" EmptyDataText="No existen registros" ForeColor="#333333" GridLines="None" Width="100%" PagerSettings-PageButtonCount="4" OnPageIndexChanging="GrdListaMaterias_PageIndexChanging">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkSeleccionar" runat="server" CommandArgument='<%# Eval("CodMateriaCarrera").ToString()%>' CommandName="Seleccionar" ToolTip="Seleccionar" OnCommand="lnkSeleccionar_Command">
                                                Seleccionar
                                            </asp:LinkButton>

                                        </ItemTemplate
                                    </asp:TemplateField>

                                    <asp:BoundField DataField="CodigoMateria" HeaderText="Código Materia"/>
                                    <asp:BoundField DataField="NombreMateria" HeaderText="Nombre Materia" />
                                    <asp:BoundField DataField="CreditosMateria" HeaderText="Creditos" />
                                    <asp:BoundField DataField="NombreCarrera" HeaderText="Carrera" />
                                </Columns>
                                <EditRowStyle BackColor="#2461BF" />
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />

                                <PagerSettings PageButtonCount="4"></PagerSettings>

                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#EFF3FB" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                <SortedDescendingHeaderStyle BackColor="#4870BE" />
                            </asp:GridView>
                        </div>

                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cerrar</button>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
