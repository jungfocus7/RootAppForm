using RootAppCommon.Models;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;




namespace RootAppCommon
{
    public static class AppCommon
    {
        /// <summary>
        /// 설정 초기화
        /// </summary>
        static AppCommon()
        {
            string wdp = Environment.GetCommandLineArgs()[0];
            wdp = Path.GetDirectoryName(wdp);
            AppWorkDirectory = wdp;

            MainForm = Application.OpenForms["MainForm"];
            _sfim = new FormInfoMap();
        }


        //public static void MainFormSettings()
        //{

        //}

        /// <summary>
        /// 어플리케이션 시작 경로
        /// </summary>
        public static readonly string AppWorkDirectory;


        /// <summary>
        /// 메인 폼
        /// </summary>
        public static readonly Form MainForm;


        /// <summary>
        /// SubFormInfoMap
        /// </summary>
        private static readonly FormInfoMap _sfim;
        /// <summary>
        /// 자식 폼 정보 가져오기
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static FormInfo GetFormInfo(string name)
        {
            if (_sfim.ContainsKey(name))
                return _sfim[name];
            else
            {
                FormInfo rfi = new FormInfo(name);
                _sfim.Add(name, rfi);
                return rfi;
            }
        }

    }
}
