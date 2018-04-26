using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_factura
{
    public class Rn_factura{

        #region Atributos
        private double Vtotal;
        private double porc;
        private string Error;
        #endregion
        #region Propiedades
        public double set_Vtotal
        {
            set { Vtotal = value; }
        }
        public double get_porc
        {
            get { return porc; }
        }
        public string get_Error
        {
            get { return Error; }
        }
        #endregion
        #region Metodos
        //La clase se debe llamar igual al metodo constructor
        public Rn_factura(){
            Vtotal = 0;
            porc = 0;
            Error = "";

            }
        public bool Asisgnarpr()
        {
            if (!validar())
            {
                return false;
            }
            try
            {
                if (Vtotal >= 700000)
                {
                    porc = 0.20;
                    return true;
                }
                else
                {
                    porc = 0.05;
                    return true;
                }
            }
            catch(Exception E)
            {
                Error = E.Message;
                return false;
            }
        }
        private bool validar()
        {
            if(Vtotal< 0)
            {
                Error = "ERROR, los valores son negativos";
                return false;
            }
            return true;
        }
        #endregion
    }
}
