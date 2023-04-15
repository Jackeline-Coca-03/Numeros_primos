using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_ejemplo_1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtN1.Text);
            int numero2 = Convert.ToInt32(txtN2.Text);

            int suma = Sumar(numero1, numero2);
            int resta = Restar(numero1, numero2);
            int multiplicacion = Multiplicar(numero1, numero2);
            double division = Dividir(numero1, numero2);

            MessageBox.Show($"La Suma es: {suma}\n" +
                $"La Resta es: {resta}\n" +
                $"La Multiplicacion es: {multiplicacion}\n" +
                $"La Division es: {division}");
        }

        private double Dividir(int numero1, int numero2)
        {
            return numero1 / (double)numero2;
        }

        private int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        private int Restar(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        private int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        private bool EsPrimo(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        private string Primo(int numero1, int numero2)
        {
            string prim="";
            for(int i = numero1; i <= numero2; i++)
            {
                if (EsPrimo(i))
                {
                    prim = prim + i + " ";
                }
            }
            return prim;
        }
        private void btnPrimos_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtN1.Text);
            int numero2 = Convert.ToInt32(txtN2.Text);
            
            MessageBox.Show("Los numeros primos desde "+numero1+" hasta "+numero2+" es: \n\n"+Primo(numero1, numero2));
        }
    }
}
