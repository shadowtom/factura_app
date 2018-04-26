using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib_factura;

namespace Ln_factura
{
    public class ln_factura
    {
        #region Atributos
        private double Valor;
        private double Cant;
        private double Vtotal;
        private double desc;
        private double totalP;
        private string Error;
        #endregion
        #region Propiedades
        //Datos salida
        public double get_Vtotal
        {
            get { return Vtotal; }
        }
        public string get_Error
        {
            get { return Error; }
        }
        public double get_totalP
        {
            get { return totalP; }
        }
        public double get_desc
        {
            get { return desc; }
        }
        //datos entrada
        public double set_Valor
        {
            set { Valor = value; }
        }
        public double set_Cant
        {
            set { Cant = value; }
        }
        #endregion
        #region Metodos
        //Metodo constructor
        public ln_factura(){
            Valor = 0;
            Cant = 0;
            Vtotal = 0;
            desc = 0;
            totalP = 0;
            Error = "";
            }
        public bool Calcular() {
            Rn_factura obj_Rn = new Rn_factura();
            obj_Rn.set_Vtotal = Vtotal;
            if (!obj_Rn.Asisgnarpr())
            {
                Error = obj_Rn.get_Error;
                return false;
            }
            else
            {
                try
                {
                    desc = Vtotal * obj_Rn.get_porc / 100;
                    totalP = Vtotal - desc;
                    return true;
                }
                catch(Exception E)
                {
                    Error = E.Message;
                    return false;
                }
            }
        }
        private bool Validar()
        {
            if(Valor < 0  && Cant < 0)
            {
                Error = "ERROR, valores erroneos";
                return false;
            }
            return true;
        }
        #endregion
    }
}