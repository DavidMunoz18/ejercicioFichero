using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioFicheros.Dtos
{
    internal class ClienteDto
    {
        long refOrdernDomi;

        string idAcreedor = "ES86000Z53010115";

        string nombreAcre = "IONOS";

        string direccionAcre = "Calle Barbero 1";

        long codPostarAcre = 41020;

        string nombreAdeudor = "aaaaa";

        string apellido1 = "aaaaa";

        string apellido2 = "aaaaa";

        string direccionAdeudor = "aaaaa";

        string codPostalAdeudor = "aaaaa";

        string numerCuentaIbanAdeudor = "aaaaa";

        string switchBankAdeudor = "aaaaa";

        char tipPago = 'a';

        public long RefOrdernDomi { get => refOrdernDomi; set => refOrdernDomi = value; }
        public string IdAcreedor { get => idAcreedor; set => idAcreedor = value; }
        public string NombreAcre { get => nombreAcre; set => nombreAcre = value; }
        public string DireccionAcre { get => direccionAcre; set => direccionAcre = value; }
        public long CodPostarAcre { get => codPostarAcre; set => codPostarAcre = value; }
        public string NombreAdeudor { get => nombreAdeudor; set => nombreAdeudor = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string DireccionAdeudor { get => direccionAdeudor; set => direccionAdeudor = value; }
        public string CodPostalAdeudor { get => codPostalAdeudor; set => codPostalAdeudor = value; }
        public string NumerCuentaIbanAdeudor { get => numerCuentaIbanAdeudor; set => numerCuentaIbanAdeudor = value; }
        public string SwitchBankAdeudor { get => switchBankAdeudor; set => switchBankAdeudor = value; }
        public char TipPago { get => tipPago; set => tipPago = value; }

        public ClienteDto(long refOrdernDomi, string idAcreedor, string nombreAcre, string direccionAcre, long codPostarAcre, string nombreAdeudor, string apellido1, string apellido2, string direccionAdeudor, string codPostalAdeudor, string numerCuentaIbanAdeudor, string switchBankAdeudor, char tipPago)
        {
            this.refOrdernDomi = refOrdernDomi;
            this.idAcreedor = idAcreedor;
            this.nombreAcre = nombreAcre;
            this.direccionAcre = direccionAcre;
            this.codPostarAcre = codPostarAcre;
            this.nombreAdeudor = nombreAdeudor;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.direccionAdeudor = direccionAdeudor;
            this.codPostalAdeudor = codPostalAdeudor;
            this.numerCuentaIbanAdeudor = numerCuentaIbanAdeudor;
            this.switchBankAdeudor = switchBankAdeudor;
            this.tipPago = tipPago;
        }

        public ClienteDto()
        {
        }
    }
}
