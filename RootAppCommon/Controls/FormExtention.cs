﻿using System.Drawing;
using System.Windows.Forms;




namespace RootAppCommon.Controls
{
    public static class FormExtention
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="ax"></param>
        /// <param name="ay"></param>
        public static void AlignBottomRight(this Form frm, int ax = 40, int ay = 40)
        {
            // 모니터다 듀얼 이상일때
            Screen tcs = Screen.FromPoint(Cursor.Position);
            Rectangle tsb = tcs.WorkingArea;
            Point tlp = new Point(tsb.Right, tsb.Bottom);
            Size tws = frm.Size;
            tlp.Offset(-(tws.Width + ax), -(tws.Height + ay));
            frm.Location = tlp;
        }


        public static void ResizeRenderingPass(this Form frm)
        {
            frm.ResizeBegin += delegate
            {
                frm.SuspendLayout();
            };

            frm.ResizeEnd += delegate
            {
                frm.ResumeLayout(true);
            };
        }
    }
}
