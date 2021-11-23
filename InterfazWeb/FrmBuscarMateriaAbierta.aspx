<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmBuscarMateriaAbierta.aspx.cs" Inherits="InterfazWeb.FrmBuscarMateriaAbierta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
    <link href="CSS/estiloMasterPage.css" rel="stylesheet" />
    <title>Buscar Cursos Disponibles</title>
</head>
<body>
    <header id="encabezado">
        <a id="linkInicio" href="FrmInicio.aspx">
            <h1>Universidad Tica</h1>
        </a>
    </header>
    <form id="form1" runat="server">
        <div class="container mb-10">
            <h1 class="text-center">Buscar Curso Disponible</h1>
            <asp:Label ID="Label1" runat="server" CssClass="mt-3" Text="Buscar por Nombre de Curso"></asp:Label>
            <asp:TextBox ID="txtNombreMateria" CssClass="mt-3 mb-5" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" CssClass="mt-3" Text="Buscar por código del Curso"></asp:Label>
            <asp:TextBox ID="txtCodigoMateria" CssClass="mt-3 mb-5" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" CssClass="btn btn-outline-primary ms-2" runat="server" Text="Buscar" OnClick="Button1_Click"/>


            <asp:GridView ID="GrdListaMaterias" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" EmptyDataText="No existen registros" ForeColor="#333333" GridLines="None" Width="100%" PagerSettings-PageButtonCount="4" OnPageIndexChanging="GrdListaMaterias_PageIndexChanging">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkSeleccionar" runat="server" CommandArgument='<%# Eval("CodMateriaAbierta").ToString() %>' CommandName="Seleccionar" ToolTip="Seleccionar" OnCommand="lnkSeleccionar_Command">
                                                Seleccionar
                            </asp:LinkButton>

                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField DataField="CodMateriaAbierta" HeaderText="CodMateriaAbierta" Visible="False" />

                    <asp:BoundField DataField="CodigoMateria" HeaderText="Código Materia" />
                    <asp:BoundField DataField="NombreMateria" HeaderText="Nombre Materia" />
                    <asp:BoundField DataField="NombreProfesor" HeaderText="Nombre Profesor" />
                    <asp:BoundField DataField="NumeroAula" HeaderText="Num Aula" />
                    <asp:BoundField DataField="Grupo" HeaderText="Grupo" />
                    <asp:BoundField DataField="Cupo" HeaderText="Cupo" />
                    <asp:BoundField DataField="Costo" HeaderText="Costo" />
                    <asp:BoundField DataField="Periodo" HeaderText="Periodo" />
                    <asp:BoundField DataField="Anio" HeaderText="Año" />
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
    </form>
    <footer id="piePagina" class="mt-5">
        <div id="contenedorPiePagina">
            <p>
                Copyright © 2021 Departamento de Registro. Todos los derechos reservados. Universidad Tica.
            </p>
            <p>
                Sitio Web diseñado y desarrollado por Dany Hurtado Jiménez.
            </p>
        </div>
    </footer>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
</body>
</html>
