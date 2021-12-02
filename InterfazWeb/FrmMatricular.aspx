<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="FrmMatricular.aspx.cs" Inherits="InterfazWeb.FrmMatricular" %>

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
        <%                                                                          
                Session["_mensaje"] = null;
            } %>

        <div class="row mb-3">

            <h4>Informacion de la matrícula:</h4>

            <div class="col">
                <asp:Label ID="Label4" runat="server" Text="Num Factura:">
                    <asp:RequiredFieldValidator ID="RfvNumFactura" runat="server"
                        ErrorMessage="Para facturar debe de haber una factura cargada"
                        Text="*"
                        ControlToValidate="txtCarnet"
                        ValidationGroup="2"
                        ForeColor="#FF3300">
                    </asp:RequiredFieldValidator>
                </asp:Label>
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
                <asp:Label ID="Label5" runat="server" Text="Carnet:">
                    <asp:RequiredFieldValidator ID="rfvCarnetEstudiante" runat="server"
                        ErrorMessage="Debe de BUSCAR UN ESTUDIANTE PARA CARGAR UNA MATRICULA"
                        Text="*"
                        ControlToValidate="txtCarnet"
                        ValidationGroup="1"
                        ForeColor="#FF3300">
                    </asp:RequiredFieldValidator>
                </asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtCarnet" runat="server" ReadOnly="True">
                </asp:TextBox>
            </div>

            <div class="col">
                <asp:Label ID="Label6" runat="server" Text="Cédula:">
                    <asp:RequiredFieldValidator ID="RfvCedulaEstudiante" runat="server"
                        Text="*"
                        ControlToValidate="txtCedula"
                        ValidationGroup="1"
                        ForeColor="#FF3300">
                    </asp:RequiredFieldValidator>
                </asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtCedula" runat="server" ReadOnly="True"></asp:TextBox>
            </div>

            <div class="col">
                <asp:Label ID="Label7" runat="server" Text="Nombre Estudiante:">
                    <asp:RequiredFieldValidator ID="RfvNombreE" runat="server"
                        Text="*"
                        ControlToValidate="txtNombre"
                        ValidationGroup="1"
                        ForeColor="#FF3300">
                    </asp:RequiredFieldValidator>
                </asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtNombre" runat="server" ReadOnly="True"></asp:TextBox>
            </div>

            <div class="col">
                <asp:Label ID="Label8" runat="server" Text="Email:">
                    <asp:RequiredFieldValidator ID="RfvEmail" runat="server"
                        Text="*"
                        ControlToValidate="txtEmail"
                        ValidationGroup="1"
                        ForeColor="#FF3300">
                    </asp:RequiredFieldValidator>
                </asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server" ReadOnly="True"></asp:TextBox>
            </div>

            <div class="col">
                <asp:Label ID="Label9" runat="server" Text="Descuento:">
                    <asp:RequiredFieldValidator ID="RfvDescuento" runat="server"
                        Text="*"
                        ControlToValidate="txtDescuento"
                        ValidationGroup="1"
                        ForeColor="#FF3300">
                    </asp:RequiredFieldValidator>
                </asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtDescuento" runat="server" ReadOnly="True"></asp:TextBox>
            </div>

            <div class="col">
                <asp:Button ID="btnBuscarEstudiante" CssClass="btn btn-outline-secondary mb-3 mt-5" runat="server" Text="Buscar Estudiante" OnClick="btnBuscarEstudiante_Click" />
            </div>

        </div>

        <hr class="mb-2 mt-2" />

        <div class="mt-1 mb-3" style="display: flex; justify-content: flex-start; align-items: center">
            <h4>Buscar Materia a Matricular</h4>
            <asp:Button ID="btnBuscarMateria" CssClass="btn btn-outline-primary ms-5" runat="server" ValidationGroup="1" Text="Buscar Curso" OnClick="btnBuscarMateria_Click" />
        </div>
        <hr class="mb-1 mt-1" />
        <asp:GridView ID="GrdVerMaterias" CssClass="mt-5 mb-5" AllowPaging="True" runat="server" AutoGenerateColumns="False" CellPadding="5" EmptyDataText="No se registran materias escogidas." GridLines="None" Width="100%" ForeColor="#333333" PageSize="5">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkEliminar" CommandArgument='<%# Eval("CodMateriaAbierta").ToString() %>' runat="server" OnCommand="lnkEliminar_Command">Eliminar</asp:LinkButton>
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

        <div class="row mb-2">

            <div class="col">
                <asp:Label ID="Label10" runat="server" Text="Monto de la matrícula:"></asp:Label>
                <asp:Label ID="lblMontoMatricula" runat="server" Text=""></asp:Label>
            </div>

            <div class="col">
                <asp:Label ID="Label11" runat="server" Text="Subtotal:"></asp:Label>
                <asp:Label ID="lblSubtotal" runat="server" Text=""></asp:Label>
            </div>

            <div class="col">
                <asp:Label ID="Label13" runat="server" Text="Descuento Estudiante:"></asp:Label>
                <asp:Label ID="lblDescuentoEstudiante" runat="server" Text=""></asp:Label>
            </div>

        </div>
        <hr />
        <div class="row mb-2">
            <div class="col">
                <asp:Label ID="Label12" runat="server" Text="Monto Descuento:"></asp:Label>
                <asp:Label ID="lblMontoDescuento" runat="server" Text=""></asp:Label>
            </div>

            <div class="col">
                <asp:Label ID="Label14" runat="server" Text="Monto IVA 2%:"></asp:Label>
                <asp:Label ID="lblMontoIva" runat="server" Text=""></asp:Label>
            </div>

            <div class="col">
                <strong>
                    <asp:Label ID="Label15" runat="server" Text="Total a Pagar:"></asp:Label></strong>
                <asp:Label ID="lblTotalPagar" runat="server" Text=""></asp:Label>
            </div>
        </div>

        <div style="display: flex; justify-content: flex-end; align-items: baseline;">
            <asp:Label ID="Label16" runat="server" CssClass="me-2" Text="Escoja un tipo de pago:"></asp:Label>
            <asp:DropDownList CssClass="me-3" ID="dropDownTipoPago" runat="server">
                <asp:ListItem>Efectivo</asp:ListItem>
                <asp:ListItem>Tarjeta</asp:ListItem>
                <asp:ListItem>Transferencia</asp:ListItem>
                <asp:ListItem>Sinpe</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="btnFacturar" CssClass="btn btn-outline-primary mt-3" runat="server" ValidationGroup="2" Text="Pagar Matrícula" OnClick="btnFacturar_Click" />
        </div>

        <asp:ValidationSummary CssClass="mt-2" ID="ValidationSummary1" Font-Italic="True" ForeColor="#CC0000" runat="server" ValidationGroup="1" />
        <asp:ValidationSummary CssClass="mt-2" ID="ValidationSummary2" Font-Italic="True" ForeColor="#CC0000" runat="server" ValidationGroup="2" />

    </div>

</asp:Content>


