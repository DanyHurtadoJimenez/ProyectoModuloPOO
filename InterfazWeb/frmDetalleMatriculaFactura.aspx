<%@ Page Title="" Language="C#" MasterPageFile="~/PlantillaBusquedas.Master" AutoEventWireup="true" CodeBehind="frmDetalleMatriculaFactura.aspx.cs" Inherits="InterfazWeb.frmDetalleMatriculaFactura" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="card-header text-center">
            <h1>Detalle de factura de la matrícula</h1>
        </div>

        <div class="card mt-3" style="width: 100%;">

            <div class="card-body">

                <h2 class="card-title mb-3">Matrícula
                </h2>

                <p class="card-text">
                    <asp:Label runat="server" Text="Numero de Factura:"></asp:Label>
                    <asp:Literal ID="ltlNumFactura" runat="server"></asp:Literal>
                </p>

                <p class="card-text">
                    <asp:Label runat="server" Text="Fecha de la Matrícula:"></asp:Label>
                    <asp:Literal ID="ltlFechaMatricula" runat="server"></asp:Literal>
                </p>

                <p class="card-text">
                    <asp:Label runat="server" Text="Carnet del Estudiante:"></asp:Label>
                    <asp:Literal ID="ltlCarnetEstudiante" runat="server"></asp:Literal>
                </p>

                <p class="card-text">
                    <asp:Label runat="server" Text="Nombre del Estudiante:"></asp:Label>
                    <asp:Literal ID="ltlNombreEstudiante" runat="server"></asp:Literal>
                </p>

                <p class="card-text">
                    <asp:Label runat="server" Text="Tipo de pago:"></asp:Label>
                    <asp:Literal ID="ltlTipoPago" runat="server"></asp:Literal>
                </p>
                <asp:Label runat="server" Text="Lista de materias matriculadas:"></asp:Label>
                <asp:GridView ID="GrdVerMaterias" CssClass="mt-1 mb-5" AllowPaging="True" runat="server" AutoGenerateColumns="False" CellPadding="3" EmptyDataText="No se registran materias escogidas." GridLines="Vertical" Width="100%" ForeColor="Black" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:BoundField DataField="CodMateriaAbierta" HeaderText="codMateriaAbierta" Visible="False" />
                        <asp:BoundField DataField="CodigoMateria" HeaderText="Código Materia" />
                        <asp:BoundField DataField="NombreMateria" HeaderText="Nombre Materia" />
                        <asp:BoundField DataField="nombreRequisito" HeaderText="Requisito" />
                        <asp:BoundField DataField="NombreProfesor" HeaderText="Nombre Profesor" />
                        <asp:BoundField DataField="NumeroAula" HeaderText="Número Aula" />
                        <asp:BoundField DataField="Grupo" HeaderText="Grupo" />
                        <asp:BoundField DataField="Costo" HeaderText="Costo" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>

                <h5 class="card-text">
                    <asp:Label runat="server" Text="Valor de la matrícula:"></asp:Label>
                    <asp:Literal ID="ltlValorMatricula" runat="server"></asp:Literal>
                </h5>

                <h5 class="card-text">
                    <asp:Label runat="server" Text="Total Cancelado:"></asp:Label>
                    <asp:Literal ID="ltlMontoMatricula" runat="server"></asp:Literal>
                </h5>

                <asp:LinkButton ID="btnAtras" runat="server" CssClass="btn btn-secondary mt-3" OnClick="btnAtras_Click">Atrás</asp:LinkButton>

            </div>
        </div>
    </div>
</asp:Content>
