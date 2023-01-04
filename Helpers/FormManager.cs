using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melton.Helpers
{
    public class FormManager
    {
        static FormManager instance;

        Dictionary<string, Eigenschaften> forms = new Dictionary<string, Eigenschaften>();

        private FormManager() { }

        public static FormManager GetInstance()
        {
            if (instance == null) 
            { 
                instance = new FormManager();
            }

            return instance;
        }

        public void Add(Eigenschaften form, string key)
        { 
            forms.Add(key, form);
        }

        public Eigenschaften Get(string key) 
        {
            Eigenschaften form = null;
            if (forms.ContainsKey(key)) 
            {
                form = forms[key];
            }

            return form;
        }
    }
}
