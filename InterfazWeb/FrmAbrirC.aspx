<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="FrmAbrirC.aspx.cs" Inherits="InterfazWeb.FrmAbrirC" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/estilosAbrirC.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class=" text-center mt-4 mb-5">Abrir Cursos</h1>


    <% if (Session["_mensaje"] != null)// if metido en medio del codigo html
        {%>

    <div class="alert alert-warning alert-dismissible fade show text-center" role="alert">
        <%= Session["_mensaje"]%>
        <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
    </div>
    <%                                                                          //se muestra el mensaje y lo borra
            //Session["_mensaje"] = null; 
        } %>



    <div class="container">

        <label for="basic-url" class="form-label">Escoja la materia</label>

        <div class="input-group mb-4 justify-content-between flex-nowrap align-items-center contenedores ">
            <asp:Label ID="Label1" CssClass="me-3 ms-2" runat="server" Text="Código Materia">
                <asp:RequiredFieldValidator ID="rfvCodigoMateria" runat="server"
                    ErrorMessage="Debe de BUSCAR UNA MATERIA"
                    Text="*"
                    ControlToValidate="txtCodigoMateria"
                    ValidationGroup="1"
                    ForeColor="#FF3300">
                </asp:RequiredFieldValidator>
            </asp:Label>

            <asp:TextBox CssClass="textBox" ID="txtCodigoMateria" runat="server" ReadOnly="True" Width="72px"></asp:TextBox>

            <asp:Label ID="Label2" CssClass="me-3 ms-2" runat="server" Text="Nombre Materia">
            </asp:Label>
            <asp:TextBox CssClass="textBox" ID="txtNombreMateria" runat="server" ReadOnly="True" Width="245px"></asp:TextBox>

            <asp:Label ID="Label3" CssClass="me-3 ms-2" runat="server" Text="Créditos Materia"></asp:Label>
            <asp:TextBox CssClass="textBox" ID="txtCreditos" runat="server" ReadOnly="True" Width="32px"></asp:TextBox>

            <asp:Label ID="Label4" CssClass="me-3 ms-2" runat="server" Text="Nombre Carrera"></asp:Label>
            <asp:TextBox CssClass="textBox" ID="txtNombreCarrera" runat="server" ReadOnly="True" Width="404px"></asp:TextBox>
            <asp:TextBox ID="txtCodMateriaCarrera" runat="server" Visible="False"></asp:TextBox>
            <asp:Button ID="btnBuscarMateria" CssClass="btn btn-outline-secondary ms-3" runat="server" Text="Buscar Materia" OnClick="btnBuscarMateria_Click" />
            <asp:Button ID="btnModificarMateria" CssClass="btn btn-outline-info ms-3" runat="server" Text="Modificar un curso" OnClick="btnModificarMateria_Click" />
        </div>

        <hr />

        <label for="basic-url" class="form-label">Escoja los periodos y demas información importante</label>

        <div class="input-group mb-4 justify-content-between flex-nowrap align-items-center contenedores ">

            <asp:Label ID="Label6" CssClass="me-3 ms-2" runat="server" Text="Cupo">
                <asp:RequiredFieldValidator ID="rfvCupo" runat="server"
                    ErrorMessage="Debe definir un CUPO para el curso"
                    Text="*"
                    ControlToValidate="nudCupo"
                    ValidationGroup="1"
                    ForeColor="#FF3300">
                </asp:RequiredFieldValidator>
            </asp:Label>
            <asp:TextBox CssClass="textBox" ID="nudCupo" TextMode="Number" runat="server" min="1" max="40" step="1" Width="174px"></asp:TextBox>

            <asp:Label ID="Label7" CssClass="me-3 ms-2" runat="server" Text="Costo">
                <asp:RequiredFieldValidator ID="rfvCosto" runat="server"
                    ErrorMessage="Debe definir un COSTO para el curso"
                    Text="*"
                    ControlToValidate="txtCosto"
                    ValidationGroup="1"
                    ForeColor="#FF3300">
                </asp:RequiredFieldValidator>
            </asp:Label>
            <asp:TextBox CssClass="textBox" ID="txtCosto" runat="server" Width="137px" min="1" TextMode="Number"></asp:TextBox>

            <asp:Label ID="Label8" CssClass="me-3 ms-2" runat="server" Text="Periodo">
                <asp:RequiredFieldValidator ID="rfvPeriodo" runat="server"
                    ErrorMessage="Debe definir un PERIODO para el curso"
                    Text="*"
                    ControlToValidate="nudPeriodo"
                    ValidationGroup="1"
                    ForeColor="#FF3300">
                </asp:RequiredFieldValidator>
            </asp:Label>
            <asp:TextBox CssClass="textBox" ID="nudPeriodo" TextMode="Number" runat="server" min="1" max="3" step="1"></asp:TextBox>

            <asp:Label ID="Label9" CssClass="me-3 ms-2" runat="server" Text="Año">
                <asp:RequiredFieldValidator ID="rfvAnio" runat="server"
                    ErrorMessage="Debe definir EL AÑO para el curso"
                    Text="*"
                    ControlToValidate="DropDownAnios"
                    ValidationGroup="1"
                    ForeColor="#FF3300">
                </asp:RequiredFieldValidator>
            </asp:Label>
            <asp:DropDownList ID="DropDownAnios" runat="server"></asp:DropDownList>

            <asp:Label ID="Label5" CssClass="me-3 ms-2" runat="server" Text="Grupo">
                <asp:RequiredFieldValidator ID="rfvGrupo" runat="server"
                    ErrorMessage="Debe de GENERAR UN GRUPO para abrir el curso"
                    Text="*"
                    ControlToValidate="txtGrupo"
                    ValidationGroup="1"
                    ForeColor="#FF3300">
                </asp:RequiredFieldValidator>
            </asp:Label>
            <asp:TextBox CssClass="textBox" ID="txtGrupo" runat="server" ReadOnly="True" Width="151px" MaxLength="2" TextMode="Number"></asp:TextBox>

            <asp:Button ID="btnCrearGrupo" CssClass="btn btn-outline-secondary ms-2" runat="server" Text="Crear Numero Grupo" OnClick="btnCrearGrupo_Click" />

        </div>

        <hr />

        <label for="basic-url" class="form-label">Escoja los horarios (Debe escoger al menos 1)</label>

        <div class="input-group mb-3 justify-content-between flex-nowrap align-items-center contenedores ">
            <asp:Label ID="Label10" CssClass="me-3 ms-2" runat="server" Text="Día">
                <asp:RequiredFieldValidator ID="rfvDias" runat="server"
                    ErrorMessage="Debe definir un DIA para el horario"
                    Text="*"
                    ControlToValidate="DropDownListDias"
                    ValidationGroup="1"
                    ForeColor="#FF3300">
                </asp:RequiredFieldValidator>
            </asp:Label>
            <asp:DropDownList ID="DropDownListDias" runat="server">
                <asp:ListItem>L</asp:ListItem>
                <asp:ListItem>K</asp:ListItem>
                <asp:ListItem>M</asp:ListItem>
                <asp:ListItem>J</asp:ListItem>
                <asp:ListItem>V</asp:ListItem>
                <asp:ListItem>S</asp:ListItem>
            </asp:DropDownList>

            <asp:Label ID="Label11" CssClass="me-3 ms-2" runat="server" Text="Hora Inicio">
                <asp:RequiredFieldValidator ID="rfvHoraInicio" runat="server"
                    ErrorMessage="Debe definir una HORA DE INICIO para el horario"
                    Text="*"
                    ControlToValidate="txtHoraInicio"
                    ValidationGroup="1"
                    ForeColor="#FF3300">
                </asp:RequiredFieldValidator>
            </asp:Label>
            <asp:TextBox CssClass="textBox" ID="txtHoraInicio" TextMode="Time" runat="server"></asp:TextBox>

            <asp:Label ID="Label12" CssClass="me-3 ms-2" runat="server" Text="Hora Fin">
                <asp:RequiredFieldValidator ID="rfvHoraFin" runat="server"
                    ErrorMessage="Debe definir una HORA DE FIN para el horario"
                    Text="*"
                    ControlToValidate="txtHoraFin"
                    ValidationGroup="1"
                    ForeColor="#FF3300">
                </asp:RequiredFieldValidator>

            </asp:Label>
            <asp:TextBox CssClass="textBox" ID="txtHoraFin" TextMode="Time" runat="server"></asp:TextBox>

            <asp:Button ID="btnAniadirHorario" CssClass="btn btn-outline-secondary ms-2" runat="server" Text="Asignar Horario" ValidationGroup="1" OnClick="btnAniadirHorario_Click" />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" class="mt-3" Font-Italic="True" ForeColor="#CC0000" ValidationGroup="1" />

        </div>

        <asp:GridView ID="GrdVerHorarios" CssClass="mt-3" AllowPaging="True" runat="server" AutoGenerateColumns="False" CellPadding="5" EmptyDataText="No se registran horarios escogidos." GridLines="None" Width="100%" ForeColor="#333333" PageSize="5" OnPageIndexChanging="GrdVerHorarios_PageIndexChanging">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkEliminar" runat="server" CommandArgument='<%# Eval("CodHorario").ToString() %>' OnCommand="lnkEliminar_Command">Eliminar</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="CodHorario" HeaderText="Cod Horario" Visible="False" />
                <asp:BoundField HeaderText="Dia" DataField="dia" />
                <asp:BoundField HeaderText="Hora Inicio" DataField="HoraInicio" />
                <asp:BoundField HeaderText="Hora Fin" DataField="HoraFin" />
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


        <div class="input-group mb-5 justify-content-center">
            <asp:Button ID="Button1" CssClass="btn btn-danger mt-5 ms-5 " runat="server" Text="Eliminar Curso" />
            <asp:Button ID="btnSiguiente" CssClass="btn btn-primary btn-lg mt-5 ms-5" runat="server" ValidationGroup="1" Text="Siguiente" OnClick="btnSiguiente_Click" />
        </div>




    </div>

</asp:Content>


