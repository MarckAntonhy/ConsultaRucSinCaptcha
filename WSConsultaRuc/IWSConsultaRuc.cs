using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WSConsultaRuc
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWsConsulta
    {
        [OperationContract]
        Empresa ObtenerEmpresa(string ruc);

        // TODO: agregue aquí sus operaciones de servicio
    }

    [DataContract]
    public class Empresa 
    {
        [DataMember]
        public string RazonSocial { get; set; }

        [DataMember]
        public string NombreComercial { get; set; }

        [DataMember]
        public string Direccion { get; set; }

        [DataMember]
        public string TipoComtribuyente { get; set; }

        [DataMember]
        public string FechaInscripcion { get; set; }

        [DataMember]
        public string EstadoContribuyente { get; set; }

        [DataMember]
        public string FechaInicioActividad { get; set; }

        [DataMember]
        public string CondicionContribuyente { get; set; }

        [DataMember]
        public string SistemaEmisionComprobante { get; set; }

        [DataMember]
        public string ActividadComericioExterior { get; set; }

        [DataMember]
        public string SistemaContabilidad { get; set; }
    }

    
    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
