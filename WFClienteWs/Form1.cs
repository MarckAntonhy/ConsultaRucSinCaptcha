using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFClienteWs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ruc = txtRuc.Text;

            using (WSConsultaRuc.WsConsultaClient cliente = new WSConsultaRuc.WsConsultaClient())
            {
                var empresa =  cliente.ObtenerEmpresa(ruc);

                MessageBox.Show("Raz: " + empresa.RazonSocial);
                MessageBox.Show("Nombre Comercial: " + empresa.NombreComercial);
                MessageBox.Show("Tipo de Contribuyente: " + empresa.TipoComtribuyente);
                MessageBox.Show("Direccion: "+empresa.Direccion);
                MessageBox.Show("Fecha Inscripción: " + empresa.FechaInscripcion);
                MessageBox.Show("Estado Contribuyemte: " + empresa.EstadoContribuyente);
                MessageBox.Show("Fecha Inicio Actividad: " + empresa.FechaInicioActividad);
                MessageBox.Show("Condicion Contribuyente: " + empresa.CondicionContribuyente);
                MessageBox.Show("Sistema Emisión Comprobante: " + empresa.SistemaEmisionComprobante);
                MessageBox.Show("Actividad Comercio Exterior: " + empresa.ActividadComericioExterior);
                MessageBox.Show("Sistema Contabilidad: " + empresa.SistemaContabilidad);

            }
        }
    }
}
