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



        private ContextMenuStripEx _cms;

        private void prControlSettings()
        {
            m_txb31.ImeMode = ImeMode.Hangul;

            _cms = new ContextMenuStripEx(this);
            _cms.Items.Add(new ToolStripMenuItemEx("1) 개발자", "Tsi_1", prToolStripMenu_Click));
            _cms.Items.Add(new ToolStripMenuItemEx("2) 개발자", "Tsi_2", prToolStripMenu_Click));
            _cms.Items.Add(new ToolStripMenuItemEx("3) 개발자", "Tsi_3", prToolStripMenu_Click));
            _cms.Items.Add(new ToolStripSeparator());
            _cms.Items.Add(new ToolStripMenuItemEx("A) 개발자", "Tsi_A", prToolStripMenu_Click));
            _cms.Items.Add(new ToolStripMenuItemEx("B) 개발자", "Tsi_B", prToolStripMenu_Click));
            _cms.Items.Add(new ToolStripMenuItemEx("C) 개발자", "Tsi_C", prToolStripMenu_Click));
            m_btn31.ContextMenuStrip = _cms;
        }

        private void prToolStripMenu_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItemEx tsm)
            {
                string txt = $"# prClickCallback  {tsm.Text}{Environment.NewLine}";
                Debug.WriteLine(txt);
                m_txb31.AppendText(txt);
            }
        }


    }




}
