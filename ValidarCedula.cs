using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRolesConCrystal
{
    internal class ValidarCedula
    {
        //public bool F_Validar_Ruc(string Pv_Ruc)
        //{
        //    bool Lb_Valida = false;
        //    int Ln_Provincia = 0;
        //    double Ln_Suma = 0;
        //    double Ln_Multiplica = 0;
        //    int[] La_Coeficiente = new int[9];
        //    int Ln_Residuo = 0;
        //    int i = 0;

        //    Lb_Valida = false;

        //    if (Pv_Ruc.Length == 13)
        //    {
        //        // Valida la Provincia
        //        Ln_Provincia = int.Parse(Pv_Ruc.Substring(0, 2));
        //        if (Ln_Provincia < 1 || Ln_Provincia > 24)
        //        {
        //            return false;
        //        }

        //        // Valida el 3er Dígito
        //        if ((int.Parse(Pv_Ruc.Substring(2, 1)) < 0 || int.Parse(Pv_Ruc.Substring(2, 1)) > 6) && int.Parse(Pv_Ruc.Substring(2, 1)) != 9)
        //        {
        //            return false;
        //        }

        //        // Valida RUC Personas Naturales
        //        if (int.Parse(Pv_Ruc.Substring(2, 1)) <= 6)
        //        {
        //            if (!P_Valida_Cedula(Pv_Ruc.Substring(0, 10)))
        //            {
        //                return false;
        //            }
        //            else
        //            {
        //                return true;
        //            }
        //            if (Pv_Ruc.Substring(10, 3) == "000")
        //            {
        //                return false;
        //            }
        //        }

        //        // Valida RUC Instituciones Públicas
        //        if (int.Parse(Pv_Ruc.Substring(2, 1)) == 6)
        //        {
        //            // Llena la serie de coeficientes
        //            La_Coeficiente[0] = 3;
        //            La_Coeficiente[1] = 2;
        //            La_Coeficiente[2] = 7;
        //            La_Coeficiente[3] = 6;
        //            La_Coeficiente[4] = 5;
        //            La_Coeficiente[5] = 4;
        //            La_Coeficiente[6] = 3;
        //            La_Coeficiente[7] = 2;

        //            // Valida el Dígito Verificador
        //            for (i = 0; i < 8; i++)
        //            {
        //                Ln_Multiplica = La_Coeficiente[i] * int.Parse(Pv_Ruc.Substring(i, 1));
        //                Ln_Suma += Ln_Multiplica;
        //            }

        //            Ln_Residuo = (int)Ln_Suma % 11;
        //            if (Ln_Residuo == 0)
        //            {
        //                if (Ln_Residuo != int.Parse(Pv_Ruc.Substring(8, 1)))
        //                {
        //                    return false;
        //                }
        //            }
        //            else
        //            {
        //                if ((11 - Ln_Residuo) != int.Parse(Pv_Ruc.Substring(8, 1)))
        //                {
        //                    return false;
        //                }
        //            }

        //            if (Pv_Ruc.Substring(9, 3) == "0000")
        //            {
        //                return false;
        //            }
        //        }

        //        // Valida RUC Jurídicas
        //        if (int.Parse(Pv_Ruc.Substring(2, 1)) == 9)
        //        {
        //            // Llena la serie de coeficientes
        //            La_Coeficiente[0] = 4;
        //            La_Coeficiente[1] = 3;
        //            La_Coeficiente[2] = 2;
        //            La_Coeficiente[3] = 7;
        //            La_Coeficiente[4] = 6;
        //            La_Coeficiente[5] = 5;
        //            La_Coeficiente[6] = 4;
        //            La_Coeficiente[7] = 3;
        //            La_Coeficiente[8] = 2;

        //            // Valida el Dígito Verificador
        //            for (i = 0; i < 9; i++)
        //            {
        //                Ln_Multiplica = La_Coeficiente[i] * int.Parse(Pv_Ruc.Substring(i, 1));
        //                Ln_Suma += Ln_Multiplica;
        //            }

        //            Ln_Residuo = (int)Ln_Suma % 11;
        //            if (Ln_Residuo == 0)
        //            {
        //                if (Ln_Residuo != int.Parse(Pv_Ruc.Substring(9, 1)))
        //                {
        //                    return false;
        //                }
        //            }
        //            else
        //            {
        //                if ((11 - Ln_Residuo) != int.Parse(Pv_Ruc.Substring(9, 1)))
        //                {
        //                    return false;
        //                }
        //            }

        //            if (Pv_Ruc.Substring(10, 3) == "000")
        //            {
        //                return false;
        //            }
        //        }

        //        Lb_Valida = true;
        //    }

        //    return Lb_Valida;
        //}
        public bool P_Valida_Cedula(string cedula)
        {
            int numero=0;
            int suma=0;
            int resultado = 0;
            for(int i = 0; i < cedula.Length; i++)
            {
                numero = int.Parse(cedula[i].ToString());
                if (i%2 == 0)
                {
                    numero=numero*2;
                    if(numero>9){
                        numero = numero - 9;
                    }
                }
                suma = suma + numero;
            }
            if (suma%10 !=0) {
                resultado = 10 - (suma%10);
                if (resultado == numero)
                {
                    return true;
                }
                else { return false; }
            }
            else
            {
                return (true);
            }

        }
    }
}
