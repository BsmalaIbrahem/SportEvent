using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Enums
{
    public enum PlayerPosition
    {
        Goalkeeper = 1,

        // 🛡️ خط الدفاع
        CenterBack,           // قلب دفاع
        LeftBack,             // ظهير أيسر
        RightBack,            // ظهير أيمن
        Sweeper,              // ليبرو (قلب دفاع حر)
        WingBackLeft,         // ظهير جناح أيسر
        WingBackRight,        // ظهير جناح أيمن

        // ⚙️ خط الوسط
        DefensiveMidfielder,  // وسط مدافع (ارتكاز)
        CentralMidfielder,    // وسط مركزي
        AttackingMidfielder,  // صانع ألعاب
        LeftMidfielder,       // جناح أيسر وسط
        RightMidfielder,      // جناح أيمن وسط
        WideMidfielder,       // لاعب وسط طرف
        BoxToBoxMidfielder,   // لاعب وسط شامل

        // 🎯 خط الهجوم
        LeftWinger,           // جناح أيسر هجومي
        RightWinger,          // جناح أيمن هجومي
        SecondStriker,        // مهاجم خلفي / صانع لعب حر
        CenterForward,        // مهاجم صريح
        Striker               // رأس حربة
    }
}
