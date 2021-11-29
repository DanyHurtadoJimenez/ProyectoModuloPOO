<%@ Page Title="" Language="C#" MasterPageFile="~/PlantillaBusquedas.Master" AutoEventWireup="true" CodeBehind="frmBuscarCursosAbiertos.aspx.cs" Inherits="InterfazWeb.frmBuscarCursosAbiertos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container mb-10">
        <h1 class="text-center">Buscar Cursos para Matricular</h1>
        <asp:Label ID="Label1" runat="server" CssClass="mt-3" Text="Buscar por Nombre de Curso"></asp:Label>
        <asp:TextBox ID="txtNombreMateria" CssClass="mt-3 mb-5" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" CssClass="mt-3" Text="Buscar por código del Curso"></asp:Label>
        <asp:TextBox ID="txtCodigoMateria" CssClass="mt-3 mb-5" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" CssClass="btn btn-outline-primary ms-2" runat="server" Text="Buscar" OnClick="Button1_Click" />


        <asp:GridView ID="GrdListaMaterias" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" EmptyDataText="No existen registros" ForeColor="#333333" GridLines="None" Width="100%" PagerSettings-PageButtonCount="4" OnPageIndexChanging="GrdListaMaterias_PageIndexChanging">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkSeleccionar" runat="server" CommandArgument='<%# Eval("CodMateriaAbierta").ToString() %>' CommandName="Seleccionar" ToolTip="Seleccionar">
                                                Seleccionar
                        </asp:LinkButton>

                    </ItemTemplate>
                </asp:TemplateField>

                <asp:BoundField DataField="CodMateriaAbierta" HeaderText="CodMateriaAbierta" Visible="False" />

                <asp:BoundField DataField="CodigoMateria" HeaderText="Código Materia" />
                <asp:BoundField DataField="NombreMateria" HeaderText="Nombre Materia" />
                <asp:BoundField DataField="Requisito" HeaderText="Cod Requisito" />
                <asp:BoundField DataField="nombreRequisito" HeaderText="Nombre Requisito" />
                <asp:BoundField DataField="NombreProfesor" HeaderText="Nombre Profesor" />
                <asp:BoundField DataField="NumeroAula" HeaderText="Num Aula" />
                <asp:BoundField DataField="Grupo" HeaderText="Grupo" />
                <asp:BoundField DataField="Cupo" HeaderText="Cupo" />
                <asp:BoundField DataField="Costo" HeaderText="Costo" />
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
