using System.Collections.Generic;
using System.Windows.Forms;



namespace RootAppCommon.Models
{
    public sealed class FormInfo
    {
        public FormInfo(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public Form RefFrom;
    }



    public sealed class FormInfoMap : Dictionary<string, FormInfo>
    {
    }

}
