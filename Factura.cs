using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanchaFutbol.Class
{
    class Factura
    {
        
        public string cancha="";
        public float costo=0;
        public int horas=0;
        public float subtotal=0;
        public float descuento=0;
        public float subtotal2=0;
        public float iva=0;
        public float final=0;
        public float pagado=0;
        public float pendiente=0;
        public string estado="";
        public string Cancha
        {
            get
            { return cancha; }
            set
            {
                if (Cancha =="Futbol"){
                    cancha = "Futbol"; }               
                if (Cancha == "Futbilto"){
                    cancha = value;}
                if (Cancha == "Indor"){
                    cancha = value;}
                if (Cancha == "Basquet"){
                    cancha = "Basquet";}
            }
        }
        public float Costo
        {
            get { return costo; }
            set
            {
                
                if (Cancha == "Futbol"){
                    costo = 20;
                     }
                if (Cancha == "Fulbito"){
                    costo = 15;}
                if (Cancha == "Indor"){
                    costo = 5;}
                if (Cancha == "Basquet"){
                    costo = 5;
                    }
               
            }
        }
        public int Horas
        {
            get { return horas; }
            set
            {
                if (value > 3)
                    throw new Exception("No se puede alquilar mas de 3 horas");
                else
                    horas = value;
                
            }
        }
        public float SubTotal
        {
            get { return subtotal; }
            set
            {
                subtotal = horas * costo;
            }
        }
        public float Descuento
        {
            get { return descuento; }
            set
            {
                if (value == 10)
                {
                    descuento = (subtotal*90)/100;
                }
                if (value == 20)
                {
                    descuento = (subtotal * 80) / 100;
                }
                if(value==0){
                    Console.WriteLine("no hay de descuento");
                }
            }
        }
        public float SubTotal2
        {
            get { return subtotal2; }
            set
            {
                subtotal2 = subtotal - descuento;
            }
        }
        public float IVA
        {
            get { return iva; }
            set
            {
                iva = (subtotal2 * 12) / 100;
            }
        }
        public float Final
        {
            get { return final; }
            set
            {
                final = iva + subtotal2;
            }
        }
        public float Pagado
        {
            get { return pagado; }
            set
            {
                pagado = value;
            }
        }
        public float Pendiente
        {
            get { return pendiente; }
            set
            {
                pendiente = final - pagado;           
            }
        }
        public string Estado
        {
            get { return estado; }
            set
            {
                if (pendiente <= 0)
                {
                    estado = "Pagado";
                }
                else
                {
                    estado = "Pendiente";
                }
            }
        }

    }
}
