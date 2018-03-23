using FirstMVPApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMVPApp.Presenters
{
    public class FirstMVPAppPresenter
    {
        private Models.FirstMVPAppModel model;
        private FirstMVPAppView view;
        public FirstMVPAppPresenter(Models.FirstMVPAppModel model, FirstMVPAppView view)
        {
            this.model = model;
            this.view = view;

            view.Presenter = this;
        }

        public void OnOperand1Changed(double operand1)
        {
            model.Operand1 = operand1;
        }

        public void OnOperand2Changed(double operand2)
        {
            model.Operand2 = operand2;
        }

        public void OnAddClicked()
        {
            model.Add();
            UpdateView();
        }

        public void OnSubtractClicked()
        {
            model.Subtract();
            UpdateView();
        }

        public void OnMultiplyClicked()
        {
            model.Multiply();
            UpdateView();
        }

        public void OnDivideClicked()
        {
            model.Divide();
            UpdateView();
        }

        private void UpdateView()
        {
            view.UpdateView(model.Operand1, model.Operand2, model.Result);

        }
    }
}
