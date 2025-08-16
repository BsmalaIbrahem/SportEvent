using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Enums
{
    public enum MatchStatus
    {
        Scheduled = 1, // المباراة مجدولة
        InProgress = 2,   // المباراة جارية
        HalfTime = 3, // الشوط الأول
        Finished = 4, // المباراة انتهت
        Postponed = 5, // المباراة مؤجلة
        Cancelled = 6 , // المباراة ملغاة
        Abandoned = 7 // المباراة متوقفة
    }
}
