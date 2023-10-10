using System;
using System.ComponentModel;
using System.Windows.Forms;




namespace AppNormalForm.CustomControls
{
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


    public sealed class ToolStripMenuItemEx : ToolStripMenuItem
    {
        public ToolStripMenuItemEx(string text, string name, EventHandler clh)
        {
            Text = text;
            Name = name;
            _clh = clh;
            Click += _clh;
        }

        private EventHandler _clh;
    }

}
