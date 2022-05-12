using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicScale2MES
{
    public class MoveNoGenerator
    {
        private static String moveNo = "";
        public static String moveNoGenerate()
        {
            DateTime date = DateTime.Now;
            moveNo = "MV" + date.ToString("yyyyMMddHHmmssfff");
            return moveNo;
        }
    }
}
