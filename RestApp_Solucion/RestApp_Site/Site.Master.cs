using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RestApp_Site
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
              Conexion.laConexion.StringConexion = Conexion.laConexion.LeerCampoXML("stringConexion");
            if (!IsPostBack)
            {
                if (Request.Cookies["UsuarioEntrada"] != null)
                {
                    Session["Usuario"] = Request.Cookies["UsuarioEntrada"].Value;
                    using (ServicioUsuario elGestor2 = new ServicioUsuario())
                    {
                        DataRow drUsuario = elGestor2.ConsultarUsuario(Session["Usuario"].ToString());

                        Session["usuariotipo"] = drUsuario["usuario_tipo"].ToString();
                       
                    }
                }
            }
            
            if (!(Request.FilePath.ToLower().Contains("frmingresar") || Request.FilePath.ToLower().Contains("frmsalir")))
                if (Session["Usuario"] == null)
                    Response.Redirect("frmIngresar");
             */
        }

        public string UsuarioLogin()
        {
            if (Request.Cookies["UsuarioEntrada"] != null)
                return Request.Cookies["UsuarioEntrada"].Value;
            else
                return "SIN USUARIO";
        }
        public string CargarMenu()
        {
            // Response.Write("<ul id ='menu' class='nav navbar-nav'><li class='dropdown active'><a href='#' class='dropdown-toggle' data-toggle='dropdown'>Vigilancia Epi.<b class='caret'></b></a><ul class='dropdown-menu'> <li><a href='../Formularios/ListadoNotificaciones.aspx'>Notificaciones</a></li> <li><a href='../Formularios/ListadoEventos.aspx'>Eventos</a></li> <li><a href='../Formularios/ListadosHatos.aspx'>Hato Libre</a></li> <li><a href='../Formularios/MisSolicitudesHato.aspx'>Mis Solicitudes hato libre</a></li> <li><a href='../Formularios/ListadoSolicitudHato.aspx'>Listado Solicitud Hato</a></li> <li><a href='../Formularios/MantResultadoPorUsuario.aspx'>Nuevo Resultado Tuberculina</a></li> <li><a href='../Formularios/RelacionFacturaSolicitudHL.aspx'>Relación Factura - Solicitud HL</a></li> <li><a href='../Formularios/ListadoResultadoPorUsuario.aspx'>Resultados Tuberculina</a></li></ul></li><li class='dropdown active'><a href='#' class='dropdown-toggle' data-toggle='dropdown'>Laboratorio<b class='caret'></b></a><ul class='dropdown-menu'> <li><a href='../Formularios/MantMuestra.aspx'>Nuevo Protocolo</a></li> <li><a href='../Formularios/MantMuestra.aspx?humano=si'>Nuevo Protocolo (para HUMANO)</a></li> <li><a href='../Formularios/MisRenaldives.aspx'>Mis Protocolos</a></li> <li><a href='../Formularios/MisResultados.aspx'>Mis Resultados</a></li> <li><a href='../Formularios/ListadoRenaldives.aspx'>Listado Protocolos</a></li> <li><a href='../Formularios/ListadoResultados.aspx'>Listado Resultados</a></li> <li><a href='../Formularios/ListadoMuestrasParaRecepcion.aspx'>Recepcion Protocolos</a></li> <li><a href='../Formularios/RelacionFacturaProtocolo.aspx'>Relación Factura - Protocolo</a></li></ul></li><li class='dropdown active'><a href='#' class='dropdown-toggle' data-toggle='dropdown'>Administración<b class='caret'></b></a><ul class='dropdown-menu'> <li><a href='../Formularios/ListadoFuncionarios.aspx'>Usuarios</a></li> <li><a href='../Formularios/CatEnfermedad.aspx'>Catalogo Enfermedad</a></li> <li><a href='../Formularios/CatEspecie.aspx'>Catalogo Especie</a></li> <li><a href='../Formularios/CatFinalidad.aspx'>Catalogo finalidad</a></li> <li><a href='../Formularios/CatGrupoEnfermedad.aspx'>Catalogo grupo enfermedad</a></li> <li><a href='../Formularios/CatLaboratorio.aspx'>Catalogo laboratorio</a></li> <li><a href='../Formularios/CatMedida.aspx'>Catalogo medidas a tomar</a></li> <li><a href='../Formularios/CatOficina.aspx'>Catalogo oficina</a></li> <li><a href='../Formularios/CatRegion.aspx'>Catalogo region</a></li> <li><a href='../Formularios/MantRoles.aspx'>Catalogo Roles</a></li> <li><a href='../Formularios/CatSistemaProduccion.aspx'>Catalogo sistema produccion</a></li> <li><a href='../Formularios/CatTipoAnimal.aspx'>Catalogo tipo animal</a></li> <li><a href='../Formularios/CatTratamientoAgua.aspx'>Catalogo tratamiento</a></li> <li><a href='../Formularios/ListadoEstablecimientos.aspx'>Establecimientos</a></li></ul></li><li class='dropdown active'><a href='#' class='dropdown-toggle' data-toggle='dropdown'>Reportes<b class='caret'></b></a><ul class='dropdown-menu'> <li><a href='../Formularios/ReporteBitacora.aspx'>Reporte Bitácora del Sistema</a></li> <li><a href='../Formularios/ReporteEstablecimiento.aspx'>Reporte historial establecimiento</a></li> <li class='divider'>Reportes</li><li><a href='../Formularios/AtencionDistritos.aspx'>Atención de Distritos</a></li><li><h5>&nbsp;&nbsp;Gráficos</h5></li><li><a href='../Formularios/ReporteGraficoUsuario.aspx'>Por Usuario</a></li><li><a href='../Formularios/ReporteGraficoRegion.aspx'>Por Región</a></li> <li class='divider'>Reportes</li><li><h5>&nbsp;&nbsp;Vigilancia Epi.</h5></li> <li><a href='../Formularios/ReporteNotificaciones.aspx'>Reporte Notificaciones</a></li> <li><a href='../Formularios/ReporteEventos.aspx'>Reporte Evento</a></li> <li><a href='../Formularios/ReporteSospechas.aspx'>Reporte Sospechas</a></li> <li><a href='../Formularios/ReporteCasos.aspx'>Reporte Casos</a></li> <li><a href='../Formularios/ReporteBoletinInformativo2.aspx'>Reporte Boletin Informativo</a></li> <li><a href='../Formularios/ReporteHatoLibre.aspx'>Reporte Hato Libre</a></li> <li><a href='../Formularios/ReporteDetalleAnimal.aspx'>Reporte Detalle Animal importado</a></li> <li><a href='../Formularios/ReporteSolicitudHatoLibre.aspx'>Reporte Solicitud Hato Libre</a></li> <li><a href='../Formularios/ReporteResultadoPorUsuario.aspx'>Reporte Tuberculina</a></li> <li class='divider'>Reportes</li><li><h5>&nbsp;&nbsp;Laboratorio</h5></li> <li><a href='../Formularios/ReporteRenaldive.aspx'>Reporte Protocolos</a></li> <li><a href='../Formularios/ReporteResultadoRenaldive.aspx'>Reporte resultado protocolo</a></li> <li><a href='../Formularios/ReportePorEnfermedad.aspx'>Reporte por Enfermedad</a></li> <li><a href='../Formularios/ReporteEncuestaNerviosa.aspx'>Reporte Encuesta Nerviosa</a></li></ul></li><li class='dropdown active'><a href='#' class='dropdown-toggle' data-toggle='dropdown'>Usuario: Luis Angulo Jimenez<b class='caret'></b></a><ul class='dropdown-menu'> <li><a href='../Formularios/DatosUsuario.aspx'>Datos de usuario</a></li> <li><a href='../Formularios/Ayuda.aspx'>Ayuda</a></li>  <li class='divider'></li> <li><a href='../Formularios/logout.aspx'>Salir</a></li></ul></li></ul>")
            string menuSalida = "";
            if (Session["usuario"] is null)
            {
                menuSalida = "<ul id='menu' class='nav nav-pills' >" + "<li ><a href='frmIngresar'>Ingresar</a></li>" + "</ul>";
            }
            else
            {
                menuSalida = "<div class='navbar-collapse collapse'>" +
                    "<ul class='nav navbar-nav'>" +
                        "<li><a runat = 'server' href='~/'>Inicio</a></li>" +
                        "<li><a runat = 'server' href='~/frmUsuarios'>Usuario</a></li>" +
                        "<li><a runat = 'server' href='~/frmCompraEntradasAdmin'>Compra de entradas(Admin)</a></li>" +
                        "<li><a runat = 'server' href='~/frmCompraEntradas'>Compra de entradas(Usuario)</a></li>" +
                        "<li><a runat = 'server' href='~/frmVerificar'>Verificar Entrada</a></li>" +
                    "</ul></div>";
            }

            Response.Write(menuSalida);
            return "";
        }

        public void MostrarMensaje(string mensaje, bool tipoError = false)
        {

            // cambiar caracteres
            mensaje = mensaje.Replace("'", "\"").Replace("\t", "").Replace(@"\n\r", "");
            mensaje = QuitarSaltoLinea(mensaje);
            //mensaje = filtrarMensaje(mensaje);
            if (tipoError)
            {
                // es un mensaje de error 
                // lblMensajeError.Text = mensaje
                // divError.Attributes("class") = "alert alert-danger mostrarElemento"
                // Page.ClientScript.RegisterStartupScript(this.GetType(), "toastr_message", "toastr.options.positionClass = 'toast-top-full-width';toastr.error('"+mensaje+"', '');", true);
                Page.ClientScript.RegisterStartupScript(GetType(), "swal_message", Convert.ToString("swal({   title: 'Error',   text: '") + mensaje + "',      showConfirmButton: true,type: 'error' }); ", true);
            }
            // BootstrapAlert(LblMensaje, mensaje, BootstrapAlertType.Danger)
            else
            {
                // lblMensajeCorrecto.Text = mensaje
                // divCorrecto.Attributes("class") = "alert alert-success mostrarElemento"
                // Page.ClientScript.RegisterStartupScript(this.GetType(), "toastr_message", "toastr.options.positionClass = 'toast-top-full-width';toastr.success('" + mensaje + "', '');", true);
                Page.ClientScript.RegisterStartupScript(GetType(), "swal_message", Convert.ToString("swal({   title: '',   text: '") + mensaje + "',   timer: 3000,   showConfirmButton: true,type: 'success' }); ", true);
                // BootstrapAlert(LblMensaje, mensaje, BootstrapAlertType.Success)
            }
        }

        public void MostrarMensaje(UpdatePanel up, string mensaje, bool tipoError = false)
        {

            // cambiar caracteres
            mensaje = mensaje.Replace("'", "\"").Replace("\t", "").Replace(@"\n\r", "");
            mensaje = QuitarSaltoLinea(mensaje);
            if (tipoError)
            {
                // es un mensaje de error

                ScriptManager.RegisterStartupScript(up, GetType(), "swal_message", Convert.ToString("swal({   title: 'Error',   text: '") + mensaje + "',      showConfirmButton: true,type: 'error' }); ", true);
            }
            else
            {
                // lblMensajeCorrecto.Text = mensaje
                ScriptManager.RegisterStartupScript(up, GetType(), "swal_message", Convert.ToString("swal({   title: '',   text: '") + mensaje + "',   timer: 3000,   showConfirmButton: true,type: 'success' }); ", true);
            }
        }

        public static string QuitarSaltoLinea(string text)
        {
            string sb = "";
            int i;
            var charArray = text.ToCharArray();
            // display contents of charArray
            var loopTo = charArray.Length - 1;
            for (i = 0; i <= loopTo; i++)
            {
                if (charArray[i].GetHashCode() != 655370) // omitir salto de linea
                {
                    // sb.Append((String.Format("&#{0};", Asc(charArray(i)))) & ",")
                    sb += charArray[i];
                    // sb.Append((String.Format("{0}", Asc(charArray(i)))))
                }

                if (i > 350)
                {
                    return sb.ToString();
                }
            }

            return sb.ToString();
        }

    }
}