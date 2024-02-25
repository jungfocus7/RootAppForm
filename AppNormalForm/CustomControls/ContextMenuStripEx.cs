using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;




namespace AppNormalForm.CustomControls
{
    public sealed class Cms31 : ContextMenuStrip
    {
        public Cms31(Form frm)
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
                ac.ImeMode = ImeMode.Disable;
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

            if (mea.Button != MouseButtons.Left)
                Close();
        }

        
        //protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        //{
        //    base.OnPreviewKeyDown(e);

        //    Keys key = e.KeyData;
        //    if ((key >= Keys.D0) && (key <= Keys.D9)) { }
        //    else if ((key >= Keys.A) && (key <= Keys.Z)) { }
        //    else
        //    {
        //        Close();
        //    }
        //}

    }


    public sealed class Tsmi31 : ToolStripMenuItem
    {
        public Tsmi31(string text, string name, EventHandler clh)
        {
            Text = text;
            Name = name;
            _clh = clh;
            Click += _clh;
        }

        private EventHandler _clh;

        //protected override void OnCheckedChanged(EventArgs e)
        //{
        //    base.OnCheckedChanged(e);

        //    if (Parent is ContextMenuStripEx tx)
        //    {
        //        Debug.WriteLine("tx");
        //    }
        //    //if (Parent is ToolStripMenuItemEx ty)
        //    //{
        //    //    Debug.WriteLine("ty");
        //    //}
        //}
    }






    public sealed class Tsmi41 : ToolStripMenuItem
    {
        public Tsmi41(string text, string name)
        {
            Text = text;
            Name = name;
        }
    }

    public sealed class Tsmi41Group
    {
        private readonly string m_gnm;
        public Tsmi41[] Arr { get; private set; }
        private Tsmi41 m_dm;

        public Tsmi41Group(string gnm, Tsmi41[] arr)
        {   
            m_gnm = gnm;
            Arr = arr;

            foreach (Tsmi41 mi in Arr)
            {
                mi.Click += prItemsClick;
            }
        }

        private ToolStripItem m_parent;
        private ToolStripItem prGetParent(ToolStripMenuItem mi)
        {
            if (m_parent == null)
            {
                m_parent = mi.OwnerItem;
            }
            return m_parent;
        }

        private void prUnselected()
        {
            if (m_dm != null)
            {
                m_dm.Checked = false;
                m_dm = null;
            }
        }

        private void prSelected(Tsmi41 mi)
        {
            prUnselected();
            m_dm = mi;
            m_dm.Checked = true;

            ToolStripItem tsi = prGetParent(mi);
            tsi.Text = m_dm.Text;
        }

        private void prItemsClick(object sender, EventArgs e)
        {
            if (sender is Tsmi41 mi)
            {
                prSelected(mi);
            }
        }
    }


}
