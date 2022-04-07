using java.lang.management;
using java.text;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ElectronicScale2MES
{
    public class UUIDGenerator
    {
        private static long START_TMP = 1465142400000L;
        private static long DIFF_TIME = 19700101000000000L;
        private static String PID = "";
        private static long PARTITION_ID = 1L;
        private static long sequence = 0L;
        private static long userSequence = 0L;
        private static long tenantSequence = 0L;
        private static long last_tmp = -1L;
        private static long lastTenantId = -1L;
        private static long lastUserId = -1L;

        private UUIDGenerator() { }

        private static long getCurrentTime()
        {
            return (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
        }

        private static long getDiffTime()
        {
            SimpleDateFormat sdf = new SimpleDateFormat("HHmmssSSS");
            
            long diff_long = getCurrentTime() - START_TMP;
            //DateTime start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            //DateTime sdt = new DateTime.("HHmmssfff");
            String s = sdf.format(diff_long); //(start.AddMilliseconds(diff_long).ToLocalTime()).ToString("HHmmssfff");
            diff_long = long.Parse(diff_long / 86400000L + s);
            return diff_long;
        }

        public static String getId()
        {
            long sec = getDiffTime();
            if (sec == last_tmp)
            {
                ++sequence;
            }
            else
            {
                sequence = 0L;
            }

            last_tmp = sec;
            String p = sec * 10000L + sequence + PID;
            return p;
        }

        public static String getAscId()
        {
            long sec = getDiffTime();
            if (sec == last_tmp)
            {
                ++sequence;
            }
            else
            {
                sequence = 0L;
            }

            last_tmp = sec;
            String p = HexTransformatUtil.hex10ToAnly(sec * 10000L + sequence) + HexTransformatUtil.hex10ToAnly(long.Parse(PID));
            return p;
        }

        public static String getUserId()
        {
            long sec = getDiffTime() / 1000L;
            if (sec == lastUserId)
            {
                ++userSequence;
            }
            else
            {
                userSequence = 0L;
            }


            lastUserId = sec;
            String userId = HexTransformatUtil.hex10ToAnly(sec) + HexTransformatUtil.hex10ToAnly(userSequence) + HexTransformatUtil.hex10ToAnly(long.Parse(PID));
            return userId;
        }

        public static String getTenantId()
        {
            long sec = getDiffTime() / 100000L;
            if (sec == lastTenantId)
            {
                ++tenantSequence;
            }
            else
            {
                tenantSequence = 0L;
            }


            lastTenantId = sec;
            String tenantId = HexTransformatUtil.hex10ToAnly(sec) + HexTransformatUtil.hex10ToAnly(tenantSequence) + HexTransformatUtil.hex10ToAnly(long.Parse(PID));
            return tenantId;
        }

        static UUIDGenerator()
        {
            PID = ManagementFactory.getRuntimeMXBean().getName().Split('@')[0];        
        }
    }
}
