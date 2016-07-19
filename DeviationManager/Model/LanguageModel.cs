using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;

namespace DeviationManager.Model
{
    public class LanguageModel
    {
        private ResourceManager rm;

        public LanguageModel()
        {
            Assembly a = Assembly.Load("DeviationManager");
            rm = new ResourceManager(LanguageName.languageName,a);
        }

        public String getString(String name)
        {
            return this.rm.GetString(name);
        }
    }
}
