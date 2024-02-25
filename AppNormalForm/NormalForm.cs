using AppNormalForm.CustomControls;
using RootAppCommon.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace AppNormalForm
{
    public sealed partial class NormalForm : Form
    {
        public NormalForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.AlignBottomRight(40, 40);
            this.ResizeRenderingPass();
            MinimumSize = Size;

            prControlSettings();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Exit();
        }



        private Cms31 _cms;

        private void prControlSettings()
        {
            m_txb31.ImeMode = ImeMode.Hangul;

            _cms = new Cms31(this);
            _cms.Items.Add(new Tsmi31("1) 개발자", "Tsi_1", prToolStripMenu_Click));
            //ToolStripMenuItem tsmi = new Tsmi31("1) 개발자", "Tsi_1", prToolStripMenu_Click);
            //tsmi.DropDownItems.Add(new Tsmi31("1) Sub", "Tsi_1", null));
            //tsmi.DropDownItems.Add(new Tsmi31("2) Sub", "Tsi_2", null));
            Tsmi31 tsmi = new Tsmi31("1) 개발자", "Tsi_1", prToolStripMenu_Click);
            Tsmi41Group mig = new Tsmi41Group(string.Empty,
                new Tsmi41[]
                {
                    new Tsmi41("91) 개구리", "gmp1"),
                    new Tsmi41("92) 개구리", "gmp2"),
                    new Tsmi41("93) 개구리", "gmp3"),
                });
            tsmi.DropDownItems.AddRange(mig.Arr);
            _cms.Items.Add(tsmi);
            _cms.Items.Add(new Tsmi31("2) 개발자", "Tsi_2", prToolStripMenu_Click));
            _cms.Items.Add(new Tsmi31("3) 개발자", "Tsi_3", prToolStripMenu_Click));
            _cms.Items.Add(new ToolStripSeparator());
            _cms.Items.Add(new Tsmi31("a) 개발자", "Tsi_a", prToolStripMenu_Click));
            _cms.Items.Add(new Tsmi31("b) 개발자", "Tsi_b", prToolStripMenu_Click));
            _cms.Items.Add(new Tsmi31("c) 개발자", "Tsi_c", prToolStripMenu_Click));
            m_btn31.ContextMenuStrip = _cms;
        }

        private void prToolStripMenu_Click(object sender, EventArgs e)
        {
            if (sender is Tsmi31 tsm)
            {
                string txt = $"# prClickCallback  {tsm.Text}{Environment.NewLine}";
                Debug.WriteLine(txt);
                m_txb31.AppendText(txt);
            }
        }


    }




}
