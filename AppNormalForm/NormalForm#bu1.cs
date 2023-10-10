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
            _cms.Items.Add(new ToolStripMenuItemEx("1) 개발자", "Tsi_1", prClickCallback));
            _cms.Items.Add(new ToolStripMenuItemEx("2) 개발자", "Tsi_2", prClickCallback));
            _cms.Items.Add(new ToolStripMenuItemEx("3) 개발자", "Tsi_3", prClickCallback));
            _cms.Items.Add(new ToolStripMenuItemEx("A) 개발자", "Tsi_A", prClickCallback));
            _cms.Items.Add(new ToolStripMenuItemEx("B) 개발자", "Tsi_B", prClickCallback));
            m_txb31.ContextMenuStrip = _cms;
        }

        private void prClickCallback(ToolStripMenuItemEx tsm)
        {
            Debug.WriteLine($"# prClickCallback  {tsm.Text}");
        }


    }



    public sealed class ContextMenuStripEx : ContextMenuStrip
    {
        public ContextMenuStripEx(Form frm)
        {
            _frm = frm;
        }
        
        private Form _frm;
        private ImeMode _imb;

        protected override void OnOpening(CancelEventArgs e)
        {
            base.OnOpening(e);

            if (_frm.ActiveControl is Control ac)
            {
                _imb = ac.ImeMode;
                ac.ImeMode = ImeMode.Off;
            }
        }

        protected override void OnClosing(ToolStripDropDownClosingEventArgs e)
        {
            base.OnClosing(e);

            if (_frm.ActiveControl is Control ac)
            {
                ac.ImeMode = _imb;
            }
        }

        protected override void OnMouseDown(MouseEventArgs mea)
        {
            base.OnMouseDown(mea);

            //Debug.WriteLine("# OnMouseDown");

            if (mea.Button == MouseButtons.Left)
            {
                //if (GetItemAt(mea.Location) is ToolStripMenuItemEx tsm)
                //    tsm._bc = true;
            }
            else
            {
                Close();
            }
        }

        //protected override void OnMouseClick(MouseEventArgs e)
        //{
        //    base.OnMouseClick(e);

        //    Debug.WriteLine("# OnMouseClick");

        //    if (e.Button == MouseButtons.Left)
        //    {
        //        if (GetItemAt(e.Location) is ToolStripMenuItemEx tsm)
        //            tsm._bc = true;
        //    }
        //    else
        //    {
        //        //if (GetItemAt(e.Location) is ToolStripMenuItemEx tsm)
        //        //    tsm._bc = false;
        //        Close();
        //    }
        //}

        protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        {
            base.OnPreviewKeyDown(e);

            //Debug.WriteLine(e.KeyData);
        }
    }


    public sealed class ToolStripMenuItemEx : ToolStripMenuItem
    {
        public ToolStripMenuItemEx(string text, string name, Action<ToolStripMenuItemEx> ccb)
        {
            Text = text;
            Name = name;
            _ccb = ccb;
        }

        private Action<ToolStripMenuItemEx> _ccb;
        //internal bool _bc = false;


        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            //Debug.WriteLine($"# OnClick  {Text}");

            //if (_bc)
            //{
            //    _ccb();
            //    _bc = false;
            //}

            _ccb(this);
        }
    }


}
