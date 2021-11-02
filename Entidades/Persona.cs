using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        #region Atributos

            protected string cedula;
            protected string nombre;
            protected string apellido1;
            protected string apellido2;
            protected string correoElectronico;
            protected string telefono;

        #endregion

        #region Constructor

            protected Persona()
            {
                cedula = string.Empty;
                nombre = string.Empty;
                apellido1 = string.Empty;
                apellido2 = string.Empty;
                correoElectronico = string.Empty;
                telefono = string.Empty;
            }

        #endregion

        #region Propiedades
            public string Cedula { get => cedula; set => cedula = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public string Apellido1 { get => apellido1; set => apellido1 = value; }
            public string Apellido2 { get => apellido2; set => apellido2 = value; }
            public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
            public string Telefono { get => telefono; set => telefono = value; }
        #endregion


    }
}
