<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="frmAgregarProfe.aspx.cs" Inherits="InterfazWeb.frmAgregarProfe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container">
        <h1 class="text-center mt-3 mb-5">Asignar Profesor</h1>

        <% if (Session["_mensaje"] != null)// if metido en medio del codigo html
            {%>

        <div class="alert alert-warning alert-dismissible fade show text-center" role="alert">
            <%= Session["_mensaje"]%>
            <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
        </div>
        <%                                                                          //se muestra el mensaje y lo borra
                Session["_mensaje"] = null; 
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
            <h2 class="mt-3 mb-3">Informacion del Profesor:</h2>
            <div class="col">
                <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtNombreProfe" runat="server" ReadOnly="True"></asp:TextBox>
            </div>
            <div class="col">
                <asp:Label ID="Label3" runat="server" Text="Primer Apellido:"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtApellido1P" runat="server" ReadOnly="True"></asp:TextBox>
            </div>

            <div class="col">
                <asp:Label ID="Label2" runat="server" Text="Segundo Apellido:"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtApellido2P" runat="server" ReadOnly="True"></asp:TextBox>
                <asp:TextBox CssClass="form-control" ID="txtCodigoProfe" runat="server" Visible="False"></asp:TextBox>
            </div>

            <div class="col">
                <asp:Button CssClass="btn btn-outline-danger" ID="btnEliminarProfe" runat="server" Text="Retirar Profesor" OnClick="btnEliminarProfe_Click" />
            </div>
        </div>

        <hr class="mt-lg-5 mb-lg-5" />

        <h2 class="mt-3 mb-3">Escoja un Profesor</h2>

        <asp:GridView ID="GrdVerProfesores" CssClass="mt-lg-5 mb-lg-5" AllowPaging="True" runat="server" AutoGenerateColumns="False" CellPadding="5" EmptyDataText="No se registran profesores escogidos." GridLines="None" Width="100%" ForeColor="#333333" PageSize="5" OnPageIndexChanging="GrdVerProfesores_PageIndexChanging">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkSeleccionar" runat="server" CommandArgument='<%# Eval("CodigoProfesor").ToString() %>' OnCommand="lnkSeleccionar_Command">Seleccionar</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="CodigoProfesor" HeaderText="Cod Profe" Visible="False" />
                <asp:BoundField HeaderText="Cédula Profesor" DataField="IdProfesor" />
                <asp:BoundField HeaderText="Nombre Profesor" DataField="NombreProfesor" />
                <asp:BoundField HeaderText="Primer Apellido" DataField="Apellido1Profesor" />
                <asp:BoundField DataField="Apellido2Profesor" HeaderText="Segundo Apellido" />
                <asp:BoundField DataField="TelefonoProfesor" HeaderText="Teléfono" />
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
            <asp:Button ID="btnAtras" CssClass="btn btn-primary btn-lg mt-5 ms-5" runat="server" Text="Ir Atrás" OnClick="btnAtras_Click" style="width: 114px; left: 0px; top: 0px" />
            <asp:Button ID="btnSiguiente" CssClass="btn btn-primary btn-lg mt-5 ms-5" runat="server" Text="Siguiente" OnClick="btnSiguiente_Click" />
        </div>

    </div>



</asp:Content>
