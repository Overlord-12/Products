using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Products.Model;
using System.Data.Entity;

namespace Products.ViewModel
{
    class Control
    {
        public string Desription { get; set; }
        public string Id { get; set; }
        public int Quantity{ get; set; }

        public void Save(object obj)
        {
           
        }
        public bool CanSave(object obj)
        {
            if (Desription != "" && Id != "" && Quantity != 0) return true;       
            else return false;
        }


        public ICommand SaveClick
        {
            get
            {
                return new Comand(Save,CanSave);
            }
        }
    }
}
