using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;



namespace RootAppCommon.Models
{
    public sealed class FormInfo
    {
        public FormInfo(string name)
        {
            Name = name;
            _LoadSubForm();
        }

        public string Name { get; private set; }
        public Form RefFrom { get; private set; }

        private void _LoadSubForm()
        {
            string dfp = Path.Combine(AppCommon.AppWorkDirectory, $"App{Name}.dll");
            if (File.Exists(dfp))
            {
                try
                {
                    Assembly asm = Assembly.LoadFrom(dfp);
                    string fnm = $"App{Name}.{Name}";
                    Type tp = asm.GetType(fnm);
                    RefFrom = (Form)Activator.CreateInstance(tp);
                }
                catch { }
            }
        }
    }



    public sealed class FormInfoMap : Dictionary<string, FormInfo>
    {
    }

}
