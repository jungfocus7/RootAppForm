using System.Drawing;
using System.Windows.Forms;




namespace RootAppCommon.Controls
{
    public static class FormExtention
    {
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
    }
}
