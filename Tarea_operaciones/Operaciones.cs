using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_operaciones
{
    public  class Operaciones
    {
        public string paroinpar(int k, string M)
        {



            if (k % 2 == 0)
                M = "El numero es par ";
            
            else
                M = "El numero es Impar";
            return M;


            
           
            
            
        }
       public  string mes(int x ,string M)
        {

            switch (x)
            {
                case 1:
                    M = " El mes es Enero";
                    break;
                case 2:
                    M = " El mes es Febrero";
                    break;
                case 3:
                    M = " El mes es Marzo";
                    break;
                case 4:
                    M = " El mes es Abril";
                    break;
                case 5:
                    M = " El mes es Mayo";
                    break;
                case 6:
                    M = " El mes es Junio";
                    break;
                case 7:
                    M=" El mes es julio";
                    break;
                case 8:
                    M=" El mes es Agosto";
                    break;
                case 9:
                    M= " El mes es Septiembre";
                    break;
                case 10:
                    M =" El mes es Octubre";
                    break;
                case 11:
                    M=" El mes es Noviembre";
                    break;
                case 12:
                    M= "  El mes es Diciembre";
                    break;
            }


            return M;
        }
    }
    }
