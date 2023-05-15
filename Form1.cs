using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            maskedTextBoxHora.ValidatingType = typeof(DateTime);
        }

        private void maskedTextBoxHora_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                maskedTextBoxHora.BackColor = Color.Red;
            }else
            {
                maskedTextBoxHora.BackColor = Color.Green;
            }
        }

        private void maskedTextBoxID_Validating(object sender, CancelEventArgs e)
        {
            if (!IDVendedorEsCorrecto(maskedTextBoxID.Text))
            {
                maskedTextBoxID.BackColor = Color.Red;
            }
            else
            {
                maskedTextBoxID.BackColor = Color.Green;
            }
        }

        private bool IDVendedorEsCorrecto(string id)
        {
            bool ok = false;
            foreach (char number in id)
            {
                if ((number != '9' && number != '0') || number == 'V')
                {
                    ok = true;
                }
                else
                {
                    return false;
                }
            }
            return ok;
        }

        private void maskedTextBoxTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (!maskedTextBoxTelefono.Text.StartsWith("6"))
            {
                maskedTextBoxTelefono.BackColor = Color.Red;
            }
            else
            {
                maskedTextBoxTelefono.BackColor = Color.Green;
            }
        }

        private void maskedTextBoxMatricula_Validating(object sender, CancelEventArgs e)
        {
            if (maskedTextBoxMatricula.Text.Length >= 3 && maskedTextBoxMatricula.Text.EndsWith(maskedTextBoxMatricula.Text.Substring(maskedTextBoxMatricula.Text.Length - 3).ToUpper()))
            {
                maskedTextBoxMatricula.BackColor = Color.Green;
            }
            else
            {
                maskedTextBoxMatricula.BackColor = Color.Red;
            }
        }

    }
}
