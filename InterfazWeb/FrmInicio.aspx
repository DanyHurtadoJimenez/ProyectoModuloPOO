<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="FrmInicio.aspx.cs" Inherits="InterfazWeb.FrmInicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">

        <div id="carouselExampleFade" class="carousel slide carousel-fade" data-bs-ride="carousel">
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img src="Multimedia/portrait-of-group-of-students-celebrating-their-graduation.jpg" class="d-block w-100" alt="..." />
                </div>
                <div class="carousel-item">
                    <img src="Multimedia/university-students-discussing-project-together.jpg" class="d-block w-100" alt="..." />
                </div>
                <div class="carousel-item">
                    <img src="Multimedia/young-college-students-walking-together.jpg" class="d-block w-100" alt="..." />
                </div>
            </div>
            <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleFade" data-bs-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Previous</span>
            </button>
            <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleFade" data-bs-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Next</span>
            </button>
        </div>

    </div>

    <div id="contenedorNoticias">

        <div id="info" class="row featurette">
            <div class="col-md-7">
                <h2 class="featurette-heading">Servicio Registro. <span class="text-muted">Universitario.</span></h2>
                <p class="lead">
                    La sección de registro universitario es la responsable de los procesos de abrir cursos, asignar horarios, 
                        asignar profesores,matrícular estudiantes, 
                        retirar matriculas, cierre de cursos y mantener la informacion de estudiantes, 
                        profesores y todo lo concerniente con el proceso de matricula estudiantil.
                </p>
            </div>
            <div class="col-md-5">
                <img src="Multimedia/11_Success-1.jpg" class="imagen" alt="..." />
            </div>
        </div>
    </div>

</asp:Content>
