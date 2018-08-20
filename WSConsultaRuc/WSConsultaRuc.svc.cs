using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WSConsultaRuc.Clases;

namespace WSConsultaRuc
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WsConsulta : IWsConsulta
    {
        Empresas myInfo;

        public Empresa ObtenerEmpresa(string ruc)
        {
            try
            {
                if (myInfo == null)
                {
                    myInfo = new Empresas();
                }


                string codigoCatcher = myInfo.UseTesseract();
                myInfo.GetInfo(ruc, codigoCatcher);

                return new Empresa() {  RazonSocial= myInfo.RazonSocial,ActividadComericioExterior=myInfo.ActividadComercioExterior,NombreComercial=myInfo.NombreComercial,Direccion = myInfo.Direccion,TipoComtribuyente = myInfo.TipoComtribuyente,
                                        FechaInscripcion = myInfo.FechaInscripcion,EstadoContribuyente=myInfo.EstadoContribuyente,FechaInicioActividad=myInfo.FechaInicioActividad,
                                        CondicionContribuyente=myInfo.CondicionContribuyente,SistemaEmisionComprobante=myInfo.SistemaEmisionComprobante,SistemaContabilidad=myInfo.SistemaContabilidad};

            }
            catch(Exception ex)
            {
                return null;
            }
        }


 
    }
}
