<%@ Page Title="" Language="C#" MasterPageFile="~/PlantillaBusquedas.Master" AutoEventWireup="true" CodeBehind="frmBuscarAlumnos.aspx.cs" Inherits="InterfazWeb.frmBuscarAlumnos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container mb-10">
        <h1 class="text-center">Buscar Estudiantes</h1>

        <asp:Label ID="Label1" runat="server" CssClass="mt-3" Text="Buscar por Nombre"></asp:Label>
        <asp:TextBox ID="txtNombreEstudiante" CssClass="mt-3" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" CssClass="mt-3" Text="Buscar por Carnet"></asp:Label>
        <asp:TextBox ID="txtCarnetEstudiante" CssClass="mt-3" runat="server"></asp:TextBox>
        <asp:Button ID="btnBuscarEstudiante" CssClass="btn btn-outline-primary ms-2 mt-1" runat="server" Text="Buscar" OnClick="btnBuscarEstudiante_Click" />


        <hr class="mb-3 mt-3" />

        <asp:GridView ID="GrdEstudiantes" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" EmptyDataText="No existen registros" ForeColor="#333333" GridLines="None" Width="100%" PagerSettings-PageButtonCount="4" OnPageIndexChanging="GrdEstudiantes_PageIndexChanging">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkSeleccionar" runat="server" CommandArgument='<%# Eval("CarnetEstudiante").ToString() %>' CommandName="Seleccionar" ToolTip="Seleccionar" OnCommand="lnkSeleccionar_Command">
                                                Seleccionar
                        </asp:LinkButton>

                    </ItemTemplate>
                </asp:TemplateField>

                <asp:BoundField DataField="CarnetEstudiante" HeaderText="Carnet Estudiante" />
                <asp:BoundField DataField="IdEstudiante" HeaderText="Cédula" />
                <asp:BoundField DataField="NombreEstudiante" HeaderText="Nombre Estudiante" />
                <asp:BoundField DataField="TelefonoEstudiante" HeaderText="Telefono Estudiante" />
                <asp:BoundField DataField="CorreoEstudiante" HeaderText="Correo Estudiante" />
                <asp:BoundField DataField="FechaIngresso" HeaderText="Fecha Ingreso" />
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

</asp:Content>
