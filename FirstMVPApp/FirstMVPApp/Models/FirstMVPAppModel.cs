using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMVPApp.Models
{
    public class FirstMVPAppModel
    {
        public double Operand1 { get; set; }
        public double Operand2 { get; set; }

        public double Result { get; private set; }

        public void Add()
        {
            Result = Operand1 + Operand2;
        }

        public void Subtract()
        {
            Result = Operand1 - Operand2;
        }

        public void Multiply()
        {
            Result = Operand1 * Operand2;
        }

        public void Divide()
        {
            if (Operand2 != 0)
                Result = Operand1 / Operand2;
            else
                System.Windows.Forms.MessageBox.Show("Data error", "Dividing by 0", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }
    }

}
