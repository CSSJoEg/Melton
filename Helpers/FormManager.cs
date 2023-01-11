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
        Dictionary<string, Eigenschaften> eigforms = new Dictionary<string, Eigenschaften>();
        Dictionary<string, Actions> actforms = new Dictionary<string, Actions>();

        private FormManager()
        { 
        }

        public static FormManager GetInstance()
        {
            if (instance == null) 
            { 
                instance = new FormManager();
            }

            return instance;
        }

        public void AddEig(Eigenschaften eigform, string key)
        {
            eigforms.Add(key, eigform);
        }
        public void AddAct(Actions actform, string key)
        {
            actforms.Add(key, actform);
        }
        public Eigenschaften GetEig(string key) 
        {
            Eigenschaften form = null;
            if (eigforms.ContainsKey(key)) 
            {
                form = eigforms[key];
            }

            return form;
        }
        public Actions GetAct(string key)
        {
            Actions form = null;
            if (eigforms.ContainsKey(key))
            {
                form = actforms[key];
            }

            return form;
        }
    }
}
