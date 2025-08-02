using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Enums
{
    public enum StatisticType
    {
        Goal,              // هدف
        OwnGoal,           // هدف في مرماه
        Assist,            // تمريرة حاسمة
        YellowCard,        // كارت أصفر
        RedCard,           // كارت أحمر
        Foul,              // فاول
        Offside,           // تسلل
        CornerKick,        // ركنية
        Shot,              // تسديدة
        ShotOnTarget,      // تسديدة على المرمى
        Pass,              // تمريرة
        AccuratePass,      // تمريرة دقيقة
        Save,              // تصدي من الحارس
        SubstitutionIn,    // دخول لاعب كبديل
        SubstitutionOut,   // خروج لاعب
        Injury,            // إصابة
        Possession,        // استحواذ (نسبة مئوية)
        Clearance,         // تشتيت
        Tackle,            // تدخل دفاعي
        Block,             // قطع تسديدة أو تمريرة
        Dribble,           // مراوغة ناجحة
        PenaltyWon,        // حصل على ركلة جزاء
        PenaltyScored,     // أحرز ركلة جزاء
        PenaltyMissed,     // أضاع ركلة جزاء
        PenaltySaved       // الحارس تصدى لركلة جزاء
    }
}
