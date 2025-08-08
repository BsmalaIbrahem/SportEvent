using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddDataToModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Coaches",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "ImageUrl", "IsActive", "IsDeleted", "Name", "Nationality", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 4, 16, 41, 23, 94, DateTimeKind.Utc).AddTicks(9899), null, "Head coach since May 29, 2025", "Jose_Riveiro.jpg", true, false, "José Riveiro", "Spain", new DateTime(2025, 8, 4, 16, 41, 23, 94, DateTimeKind.Utc).AddTicks(9901) },
                    { 2, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1120), null, "Head coach since February 2024", "Jose_Gomes.jpg", true, false, "José Gomes", "Portugal", new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1121) },
                    { 3, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1123), null, "Head coach since February 2024", "Krunoslav_Jurcic.jpg", true, false, "Krunoslav Jurcic", "Croatia", new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1123) },
                    { 4, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1124), null, "Head coach since July 2025", "Nabil_Kouki.jpg", true, false, "Nabil Kouki", "Tunisia", new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1124) },
                    { 5, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1125), null, "Head coach since February 2025", "Ali_Maher.jpg", true, false, "Ali Maher", "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1126) },
                    { 6, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1127), null, "Head coach since July 2025", "Khaled_Eid.jpg", true, false, "Khaled Eid", "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1127) },
                    { 7, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1128), null, "Head coach since July 2025", "Ahmed_El_Agouz.jpg", true, false, "Ahmed El Agouz", "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1128) },
                    { 8, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1165), null, "Head coach since July 2024", "Magdy_Abdel_Ati.jpg", true, false, "Magdy Abdel Ati", "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1165) },
                    { 9, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1166), null, "Head coach since July 2024", "Sayed_Yassin.jpg", true, false, "Sayed Yassin", "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1166) },
                    { 10, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1167), null, "Head coach from January 2023 to April 2025", "Ahmed_Samy.jpg", true, false, "Ahmed Samy", "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1168) },
                    { 11, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1169), null, "Head coach from April 2025 to June 2025 and post-June 2025", "Ahmed_Abdelaziz.jpg", true, false, "Ahmed Abdelaziz", "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1170) },
                    { 12, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1171), null, "Head coach since July 2024", "Abdelhamid_Bassiouni.jpg", true, false, "Abdelhamid Bassiouni", "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1171) },
                    { 13, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1172), null, "Head coach since July 2024", "Ahmed_Koshary.jpg", true, false, "Ahmed Koshary", "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1172) },
                    { 14, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1173), null, "Head coach since July 2024", "Mohamed_Mekky.jpg", true, false, "Mohamed Mekky", "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1174) },
                    { 15, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1175), null, "Head coach since July 2024", "Sayed_Eid.jpg", true, false, "Sayed Eid", "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1175) },
                    { 16, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1176), null, "Head coach since January 2025", "Hossam_Hassan.jpg", true, false, "Hossam Hassan", "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1176) },
                    { 17, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1177), null, "Head coach since January 2025", "Ehab_Galal.jpg", true, false, "Ehab Galal", "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1178) },
                    { 18, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1179), null, "Head coach since November 2024", "Alaa_Abdel_Aal.jpg", true, false, "Alaa Abdel Aal", "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1179) },
                    { 19, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1180), null, "Head coach since July 2024", "Ahmed_Khaled.jpg", true, false, "Ahmed Khaled", "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1181) },
                    { 20, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1182), null, "Head coach since July 2024", "Mohamed_Ouda.jpg", true, false, "Mohamed Ouda", "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1182) },
                    { 21, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1183), null, "Head coach since July 2024", "Igor_Tolic.jpg", true, false, "Igor Tolic", "Croatia", new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1184) },
                    { 22, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1185), null, "Head coach since July 2024", "Amr_Abdel_Salam.jpg", true, false, "Amr Abdel Salam", "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(1185) }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "DeletedAt", "Description", "ImgPath", "IsActive", "IsDeleted", "Name", "Nationality", "Position", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(7344), new DateTime(1988, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Shenawy.jpg", true, false, "Mohamed El Shenawy", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(7344) },
                    { 2, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9503), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Oufa_Shobeir.jpg", true, false, "Oufa Shobeir", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9504) },
                    { 3, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9507), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Seha.jpg", true, false, "Mohamed Seha", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9508) },
                    { 4, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9510), new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Makhlouf.jpg", true, false, "Mostafa Makhlouf", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9510) },
                    { 5, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9542), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Achraf_Dari.jpg", true, false, "Achraf Dari", "Morocco", 2, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9543) },
                    { 6, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9544), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Ramadan.jpg", true, false, "Ahmed Ramadan", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9545) },
                    { 7, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9546), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_El_Aash.jpg", true, false, "Mostafa El Aash", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9547) },
                    { 8, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9548), new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Yasser_Ibrahim.jpg", true, false, "Yasser Ibrahim", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9548) },
                    { 9, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9550), new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Yassin_Marei.jpg", true, false, "Yassin Marei", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9550) },
                    { 10, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9552), new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Abdin.jpg", true, false, "Ahmed Abdin", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9552) },
                    { 11, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9554), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Shokry.jpg", true, false, "Mohamed Shokry", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9554) },
                    { 12, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9556), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Hany.jpg", true, false, "Mohamed Hany", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9556) },
                    { 13, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9558), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Omar_Kamal.jpg", true, false, "Omar Kamal", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9558) },
                    { 14, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9561), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Aliou_Dieng.jpg", true, false, "Aliou Dieng", "Mali", 8, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9561) },
                    { 15, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9563), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Marwan_Ateya.jpg", true, false, "Marwan Ateya", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9563) },
                    { 16, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9564), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Kouka.jpg", true, false, "Ahmed Kouka", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9565) },
                    { 17, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9566), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Reda.jpg", true, false, "Ahmed Reda", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9567) },
                    { 18, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9584), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Emam_Ashour.jpg", true, false, "Emam Ashour", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9585) },
                    { 19, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9586), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Ali_Ben_Romdhane.jpg", true, false, "Mohamed Ali Ben Romdhane", "Tunisia", 9, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9587) },
                    { 20, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9588), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Afsha.jpg", true, false, "Afsha", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9589) },
                    { 21, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9590), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Trezeguet.jpg", true, false, "Mahmoud Trezeguet", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9591) },
                    { 22, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9592), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Achraf_Bencharki.jpg", true, false, "Achraf Bencharki", "Morocco", 15, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9593) },
                    { 23, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9633), new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hussein_El_Shahat.jpg", true, false, "Hussein El Shahat", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9633) },
                    { 24, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9635), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Abdelkader.jpg", true, false, "Ahmed Abdelkader", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9635) },
                    { 25, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9637), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Zizo.jpg", true, false, "Zizo", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9637) },
                    { 26, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9639), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Reda_Slim.jpg", true, false, "Reda Slim", "Morocco", 16, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9639) },
                    { 27, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9641), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Taher_Mohamed.jpg", true, false, "Taher Mohamed", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9641) },
                    { 28, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9643), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Karim_Fouad.jpg", true, false, "Karim Fouad", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9643) },
                    { 29, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9645), new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Abdallah.jpg", true, false, "Mohamed Abdallah", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9645) },
                    { 30, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9647), new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Nejc_Gradisar.jpg", true, false, "Nejc Gradisar", "Slovenia", 18, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9647) },
                    { 31, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9648), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Sherif.jpg", true, false, "Mohamed Sherif", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9649) },
                    { 32, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9666), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Yasser.jpg", true, false, "Mohamed Yasser", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9666) },
                    { 33, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9668), new DateTime(1999, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Sobhi.jpg", true, false, "Mohamed Sobhi", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9668) },
                    { 34, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9670), new DateTime(1992, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Awad.jpg", true, false, "Mohamed Awad", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9670) },
                    { 35, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9672), new DateTime(2004, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_Nafad.jpg", true, false, "Abdelrahman Nafad", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9672) },
                    { 36, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9674), new DateTime(1992, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hamza_Mathlouthi.jpg", true, false, "Hamza Mathlouthi", "Tunisia", 2, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9674) },
                    { 37, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9676), new DateTime(2001, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hossam_Abdelmaguid.jpg", true, false, "Hossam Abdelmaguid", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9676) },
                    { 38, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9678), new DateTime(1999, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_El_Zenary.jpg", true, false, "Mostafa El Zenary", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9678) },
                    { 39, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9680), new DateTime(2003, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Esho.jpg", true, false, "Ahmed Esho", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9680) },
                    { 40, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9682), new DateTime(1992, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Omar_Gaber.jpg", true, false, "Omar Gaber", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9682) },
                    { 41, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9683), new DateTime(1998, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Fatouh.jpg", true, false, "Ahmed Fatouh", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9684) },
                    { 42, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9685), new DateTime(2001, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Shehata.jpg", true, false, "Mohamed Shehata", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9686) },
                    { 43, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9687), new DateTime(1996, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Nabil_Emad_Dunga.jpg", true, false, "Nabil Emad Dunga", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9688) },
                    { 44, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9689), new DateTime(1999, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Seif_Gaafar.jpg", true, false, "Seif Gaafar", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9689) },
                    { 45, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9691), new DateTime(1998, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Hamdi.jpg", true, false, "Ahmed Hamdi", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9692) },
                    { 46, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9708), new DateTime(1994, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Shalaby.jpg", true, false, "Mostafa Shalaby", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9709) },
                    { 47, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9710), new DateTime(1986, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Shikabala.jpg", true, false, "Shikabala", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9711) },
                    { 48, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9712), new DateTime(1996, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Sayed_Zizo.jpg", true, false, "Ahmed Sayed Zizo", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9712) },
                    { 49, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9714), new DateTime(1995, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_El_Wensh.jpg", true, false, "Mahmoud El Wensh", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9714) },
                    { 50, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9716), new DateTime(1985, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Abdelshafi.jpg", true, false, "Mohamed Abdelshafi", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9716) },
                    { 51, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9718), new DateTime(1985, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdallah_El_Said.jpg", true, false, "Abdallah El Said", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9718) },
                    { 52, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9720), new DateTime(1997, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Nasser_Maher.jpg", true, false, "Nasser Maher", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9720) },
                    { 53, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9722), new DateTime(2002, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Atef.jpg", true, false, "Mohamed Atef", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9722) },
                    { 54, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9724), new DateTime(1993, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Seifeddine_Jaziri.jpg", true, false, "Seifeddine Jaziri", "Tunisia", 18, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9724) },
                    { 55, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9726), new DateTime(1997, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Nasser_Mansi.jpg", true, false, "Nasser Mansi", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9726) },
                    { 56, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9727), new DateTime(1999, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amr_Nasser.jpg", true, false, "Amr Nasser", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9728) },
                    { 57, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9729), new DateTime(1998, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Chico_Banza.jpg", true, false, "Chico Banza", "Angola", 18, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9730) },
                    { 58, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9731), new DateTime(2003, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Abdel_Rahim.jpg", true, false, "Ahmed Abdel Rahim", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9731) },
                    { 59, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9733), new DateTime(2003, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Hamdi_Ibrahim.jpg", true, false, "Mohamed Hamdi Ibrahim", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9733) },
                    { 60, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9750), new DateTime(1991, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Shenawy.jpg", true, false, "Ahmed El Shenawy", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9750) },
                    { 61, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9752), new DateTime(1983, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Sherif_Ekramy.jpg", true, false, "Sherif Ekramy", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9752) },
                    { 62, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9754), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Youssef_Nader.jpg", true, false, "Youssef Nader", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9754) },
                    { 63, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9756), new DateTime(1993, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Chibi.jpg", true, false, "Mohamed Chibi", "Morocco", 4, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9756) },
                    { 64, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9758), new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Samy.jpg", true, false, "Ahmed Samy", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9758) },
                    { 65, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9759), new DateTime(1989, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ali_Gabr.jpg", true, false, "Ali Gabr", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9760) },
                    { 66, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9761), new DateTime(1998, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Marie.jpg", true, false, "Mahmoud Marie", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9762) },
                    { 67, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9763), new DateTime(1996, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Karim_Hafez.jpg", true, false, "Karim Hafez", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9764) },
                    { 68, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9765), new DateTime(1995, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Hamdi.jpg", true, false, "Mohamed Hamdi", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9766) },
                    { 69, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9767), new DateTime(1991, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Tawfik.jpg", true, false, "Ahmed Tawfik", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9767) },
                    { 70, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9769), new DateTime(1994, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ibrahim_Blati_Toure.jpg", true, false, "Ibrahim Blati Touré", "Burkina Faso", 8, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9769) },
                    { 71, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9771), new DateTime(1995, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohanad_Lasheen.jpg", true, false, "Mohanad Lasheen", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9771) },
                    { 72, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9773), new DateTime(1992, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Abdul_Aati_Dunga.jpg", true, false, "Mahmoud Abdul Aati Dunga", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9773) },
                    { 73, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9792), new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Tarek_Alaa.jpg", true, false, "Tarek Alaa", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9792) },
                    { 74, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9794), new DateTime(1994, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Fathi.jpg", true, false, "Mostafa Fathi", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9794) },
                    { 75, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9796), new DateTime(1997, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ramadan_Sobhi.jpg", true, false, "Ramadan Sobhi", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9796) },
                    { 76, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9798), new DateTime(2001, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ibrahim_Adel.jpg", true, false, "Ibrahim Adel", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9798) },
                    { 77, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9830), new DateTime(1995, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Youssef_Obama.jpg", true, false, "Youssef Obama", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9830) },
                    { 78, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9832), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Zalaka.jpg", true, false, "Mahmoud Zalaka", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9832) },
                    { 79, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9834), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdel_Rahman_Magdi.jpg", true, false, "Abdel Rahman Magdi", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9834) },
                    { 80, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9836), new DateTime(1994, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Fiston_Mayele.jpg", true, false, "Fiston Mayele", "DR Congo", 18, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9836) },
                    { 81, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9837), new DateTime(1996, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Marwan_Hamdy.jpg", true, false, "Marwan Hamdy", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9838) },
                    { 82, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9839), new DateTime(1987, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Gabas.jpg", true, false, "Mohamed El Gabas", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9840) },
                    { 83, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9841), new DateTime(1991, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Fakhreddine_Ben_Youssef.jpg", true, false, "Fakhreddine Ben Youssef", "Tunisia", 18, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9842) },
                    { 84, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9843), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Dodo_El_Gabbas.jpg", true, false, "Dodo El Gabbas", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9843) },
                    { 85, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9845), new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Youssef_Shousha.jpg", true, false, "Youssef Shousha", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9845) },
                    { 86, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9847), new DateTime(1997, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Injured: Cruciate ligament tear", "Essam_Tharwat.jpg", true, false, "Essam Tharwat", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9847) },
                    { 87, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9864), new DateTime(1993, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Hamdy.jpg", true, false, "Mahmoud Hamdy", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9864) },
                    { 88, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9866), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Shehata.jpg", true, false, "Mohamed Shehata", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9866) },
                    { 89, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9868), new DateTime(1994, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Injured: Cruciate ligament tear", "Ahmed_Ayman_Mansour.jpg", true, false, "Ahmed Ayman Mansour", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9868) },
                    { 90, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9870), new DateTime(1996, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Baher_El_Mohamady.jpg", true, false, "Baher El Mohamady", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9870) },
                    { 91, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9872), new DateTime(1999, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Tarek.jpg", true, false, "Mohamed Tarek", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9872) },
                    { 92, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9874), new DateTime(1994, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hossam_Hassan.jpg", true, false, "Hossam Hassan", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9874) },
                    { 93, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9876), new DateTime(2002, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Islam_El_Mizzayn.jpg", true, false, "Islam El Mizzayn", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9876) },
                    { 94, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9877), new DateTime(1998, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Karim_El_Eraki.jpg", true, false, "Karim El Eraki", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9878) },
                    { 95, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9879), new DateTime(1991, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hussein_El_Sayed.jpg", true, false, "Hussein El Sayed", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9880) },
                    { 96, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9881), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Eid.jpg", true, false, "Ahmed Eid", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9881) },
                    { 97, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9883), new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ehab_El_Aidy.jpg", true, false, "Ehab El Aidy", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9883) },
                    { 98, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9885), new DateTime(2001, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Saber.jpg", true, false, "Mahmoud Saber", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9885) },
                    { 99, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9887), new DateTime(1988, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amr_Moussa.jpg", true, false, "Amr Moussa", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9887) },
                    { 100, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9889), new DateTime(1997, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Youssef_El_Gohary.jpg", true, false, "Youssef El Gohary", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9889) },
                    { 101, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9906), new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Moaz_Mosaad.jpg", true, false, "Moaz Mosaad", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9906) },
                    { 102, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9908), new DateTime(2005, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Listowell_Amankona.jpg", true, false, "Listowell Amankona", "Ghana", 9, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9908) },
                    { 103, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9910), new DateTime(1994, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Hamada.jpg", true, false, "Mahmoud Hamada", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9910) },
                    { 104, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9911), new DateTime(1992, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Injured: Foot surgery", "Mido_Gaber.jpg", true, false, "Mido Gaber", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9912) },
                    { 105, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9913), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Injured: Cruciate ligament tear", "Mohamed_El_Shami.jpg", true, false, "Mohamed El Shami", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9914) },
                    { 106, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9915), new DateTime(1991, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Fakhreddine_Ben_Youssef.jpg", true, false, "Fakhreddine Ben Youssef", "Tunisia", 18, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9916) },
                    { 107, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9917), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hossam_Greisha.jpg", true, false, "Hossam Greisha", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9918) },
                    { 108, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9919), new DateTime(1998, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abderrahim_Deghmoum.jpg", true, false, "Abderrahim Deghmoum", "Algeria", 16, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9919) },
                    { 109, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9921), new DateTime(1994, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Saleh_Chihadeh.jpg", true, false, "Saleh Chihadeh", "Palestine", 18, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9921) },
                    { 110, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9923), new DateTime(2001, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Franck_Etouga.jpg", true, false, "Franck Etouga", "Cameroon", 18, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9923) },
                    { 111, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9925), new DateTime(1999, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Abdel_Samia.jpg", true, false, "Mohamed Abdel Samia", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9925) },
                    { 112, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9927), new DateTime(1990, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Fakih.jpg", true, false, "Mohamed El Fakih", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9927) },
                    { 113, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9929), new DateTime(1999, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdo_Yahia.jpg", true, false, "Abdo Yahia", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9929) },
                    { 114, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9930), new DateTime(1992, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Sheikh.jpg", true, false, "Ahmed El Sheikh", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9931) },
                    { 115, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9950), new DateTime(1998, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Islam_Ateya.jpg", true, false, "Islam Ateya", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9951) },
                    { 116, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9952), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Abou_Gouda.jpg", true, false, "Mahmoud Abou Gouda", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9953) },
                    { 117, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9954), new DateTime(1990, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Bassam.jpg", true, false, "Mohamed Bassam", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9955) },
                    { 118, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9956), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ali_El_Gabry.jpg", true, false, "Ali El Gabry", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9956) },
                    { 119, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9958), new DateTime(1997, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amer_Amer.jpg", true, false, "Amer Amer", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9958) },
                    { 120, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9960), new DateTime(1997, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Ramadan.jpg", true, false, "Ahmed Ramadan", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9960) },
                    { 121, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9962), new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Khaled_Sobhi.jpg", true, false, "Khaled Sobhi", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9962) },
                    { 122, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9964), new DateTime(1993, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ragab_Nabil.jpg", true, false, "Ragab Nabil", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9964) },
                    { 123, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9966), new DateTime(1997, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Hany.jpg", true, false, "Ahmed Hany", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9966) },
                    { 124, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9967), new DateTime(1991, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hussein_El_Sayed.jpg", true, false, "Hussein El Sayed", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9968) },
                    { 125, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9969), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_Body.jpg", true, false, "Abdelrahman Body", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9969) },
                    { 126, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9971), new DateTime(1995, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Toni.jpg", true, false, "Mohamed Toni", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9971) },
                    { 127, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9973), new DateTime(1999, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Kendouci.jpg", true, false, "Ahmed Kendouci", "Algeria", 9, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9973) },
                    { 128, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9990), new DateTime(1992, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Ibrahim.jpg", true, false, "Mohamed Ibrahim", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9990) },
                    { 129, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9992), new DateTime(1997, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Sadek.jpg", true, false, "Mohamed Sadek", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9992) },
                    { 130, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9994), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Armouty.jpg", true, false, "Ahmed El Armouty", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 95, DateTimeKind.Utc).AddTicks(9994) },
                    { 131, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(15), new DateTime(1997, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Fagrie_Lakay.jpg", true, false, "Fagrie Lakay", "South Africa", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(15) },
                    { 132, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(17), new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Samuel_Amadi.jpg", true, false, "Samuel Amadi", "Nigeria", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(17) },
                    { 133, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(19), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ayman_Moka.jpg", true, false, "Ayman Moka", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(19) },
                    { 134, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(21), new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Marwan_Otaka.jpg", true, false, "Marwan Otaka", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(22) },
                    { 135, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(23), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Belhadji.jpg", true, false, "Ahmed Belhadji", "Morocco", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(23) },
                    { 136, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(25), new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Nour_Alaa.jpg", true, false, "Nour Alaa", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(25) },
                    { 137, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(27), new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mazen_Yasser.jpg", true, false, "Mazen Yasser", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(27) },
                    { 138, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(29), new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdulkareem_Ayinde.jpg", true, false, "Abdulkareem Ayinde", "Nigeria", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(29) },
                    { 139, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(31), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Alaa_Shaaban.jpg", true, false, "Alaa Shaaban", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(31) },
                    { 140, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(33), new DateTime(2004, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "On loan to El Gouna until 30th June 2025", "Favour_Akem.jpg", true, false, "Favour Akem", "Nigeria", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(33) },
                    { 141, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(34), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "On loan to Pyramids until 30th June 2025", "Sodiq_Awujoola.jpg", true, false, "Sodiq Awujoola", "Nigeria", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(35) },
                    { 142, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(52), new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Ashraf.jpg", true, false, "Ahmed Ashraf", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(52) },
                    { 143, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(54), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abasi_Kyeyune.jpg", true, false, "Abasi Kyeyune", "Uganda", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(54) },
                    { 144, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(56), new DateTime(2002, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Islam_El_Mezayen.jpg", true, false, "Islam El Mezayen", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(56) },
                    { 145, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(58), new DateTime(1989, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Abou_Gabal.jpg", true, false, "Mohamed Abou Gabal", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(58) },
                    { 146, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(59), new DateTime(1995, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Sobhi.jpg", true, false, "Ahmed Sobhi", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(60) },
                    { 147, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(61), new DateTime(1993, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hassan_Shahin.jpg", true, false, "Hassan Shahin", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(62) },
                    { 148, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(63), new DateTime(1992, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_El_Zanfaly.jpg", true, false, "Mahmoud El Zanfaly", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(63) },
                    { 149, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(65), new DateTime(1991, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ayman_Ashraf.jpg", true, false, "Ayman Ashraf", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(66) },
                    { 150, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(67), new DateTime(1998, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Injured: Cruciate ligament tear", "Mahmoud_El_Gazzar.jpg", true, false, "Mahmoud El Gazzar", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(67) },
                    { 151, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(69), new DateTime(1994, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Moussa_Diawara.jpg", true, false, "Moussa Diawara", "Guinea", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(69) },
                    { 152, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(71), new DateTime(1997, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amir_Medhat.jpg", true, false, "Amir Medhat", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(71) },
                    { 153, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(73), new DateTime(1994, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Issahaku_Yakubu.jpg", true, false, "Issahaku Yakubu", "Ghana", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(73) },
                    { 154, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(75), new DateTime(1997, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Yassin.jpg", true, false, "Ahmed Yassin", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(75) },
                    { 155, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(76), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Osama_Faisal.jpg", true, false, "Osama Faisal", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(77) },
                    { 156, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(94), new DateTime(1993, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Karim_Bambo.jpg", true, false, "Karim Bambo", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(94) },
                    { 157, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(97), new DateTime(1988, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Kaoud.jpg", true, false, "Mahmoud Kaoud", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(97) },
                    { 158, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(99), new DateTime(1989, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Bassiouny.jpg", true, false, "Mohamed Bassiouny", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(99) },
                    { 159, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(100), new DateTime(1994, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Fathi.jpg", true, false, "Mohamed Fathi", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(101) },
                    { 160, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(102), new DateTime(1997, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Said.jpg", true, false, "Ahmed Said", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(103) },
                    { 161, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(104), new DateTime(1994, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Serge_Aka.jpg", true, false, "Serge Aka", "Côte d'Ivoire", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(104) },
                    { 162, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(106), new DateTime(1996, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Helal.jpg", true, false, "Mohamed Helal", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(106) },
                    { 163, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(108), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Injured: Cruciate ligament tear", "Ahmed_Rabia.jpg", true, false, "Ahmed Rabia", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(108) },
                    { 164, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(110), new DateTime(1993, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Emad_Fathi.jpg", true, false, "Emad Fathi", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(110) },
                    { 165, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(112), new DateTime(1990, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ibrahim_Hassan.jpg", true, false, "Ibrahim Hassan", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(112) },
                    { 166, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(114), new DateTime(1991, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Grendo.jpg", true, false, "Mohamed Grendo", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(114) },
                    { 167, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(116), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Yahia_Hamed.jpg", true, false, "Yahia Hamed", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(116) },
                    { 168, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(118), new DateTime(1994, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Yasser.jpg", true, false, "Ahmed Yasser", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(118) },
                    { 169, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(119), new DateTime(2003, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Youssef_Hassan.jpg", true, false, "Youssef Hassan", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(120) },
                    { 170, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(136), new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Basem_Morsy.jpg", true, false, "Basem Morsy", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(137) },
                    { 171, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(138), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Essam.jpg", true, false, "Mohamed Essam", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(139) },
                    { 172, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(140), new DateTime(1988, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Sayed.jpg", true, false, "Mahmoud Sayed", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(140) },
                    { 173, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(142), new DateTime(1994, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Madbouli.jpg", true, false, "Ahmed Madbouli", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(142) },
                    { 174, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(144), new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Moustafa_Yasser.jpg", true, false, "Moustafa Yasser", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(144) },
                    { 175, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(146), new DateTime(1987, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Genesh.jpg", true, false, "Mahmoud Genesh", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(146) },
                    { 176, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(148), new DateTime(1988, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Yehia.jpg", true, false, "Ahmed Yehia", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(148) },
                    { 177, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(150), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelaziz_El_Balouti.jpg", true, false, "Abdelaziz El Balouti", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(150) },
                    { 178, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(152), new DateTime(1995, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Hamdy.jpg", true, false, "Mahmoud Hamdy", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(152) },
                    { 179, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(153), new DateTime(1990, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ali_Elfeel.jpg", true, false, "Ali Elfeel", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(154) },
                    { 180, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(155), new DateTime(1999, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Ismail.jpg", true, false, "Mohamed Ismail", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(156) },
                    { 181, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(157), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Khaled_Reda.jpg", true, false, "Khaled Reda", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(157) },
                    { 182, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(159), new DateTime(1997, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ghanam_Mohamed.jpg", true, false, "Ghanam Mohamed", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(159) },
                    { 183, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(241), new DateTime(1998, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Injured: Cruciate ligament tear", "Mohamed_Mahmoud.jpg", true, false, "Mohamed Mahmoud", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(241) },
                    { 184, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(244), new DateTime(1993, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Injured: Heart condition", "Ahmed_Refaat.jpg", true, false, "Ahmed Refaat", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(244) },
                    { 185, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(246), new DateTime(1997, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Nasser_Maher.jpg", true, false, "Nasser Maher", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(246) },
                    { 186, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(247), new DateTime(1996, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hesham_Balaha.jpg", true, false, "Hesham Balaha", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(248) },
                    { 187, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(249), new DateTime(1998, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Atef.jpg", true, false, "Ahmed Atef", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(250) },
                    { 188, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(251), new DateTime(1989, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Marwan_Mohsen.jpg", true, false, "Marwan Mohsen", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(252) },
                    { 189, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(253), new DateTime(1996, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Rabia.jpg", true, false, "Mohamed Rabia", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(253) },
                    { 190, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(255), new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_Rashdan.jpg", true, false, "Abdelrahman Rashdan", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(255) },
                    { 191, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(257), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Youssef.jpg", true, false, "Mohamed Youssef", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(257) },
                    { 192, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(259), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_Youssef.jpg", true, false, "Abdelrahman Youssef", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(259) },
                    { 193, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(261), new DateTime(1988, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Gomaa.jpg", true, false, "Ahmed Gomaa", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(261) },
                    { 194, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(263), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_El_Badry.jpg", true, false, "Mostafa El Badry", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(263) },
                    { 195, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(265), new DateTime(2001, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ali_Zaazaa.jpg", true, false, "Ali Zaazaa", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(265) },
                    { 196, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(266), new DateTime(1989, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Farouk.jpg", true, false, "Mohamed Farouk", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(267) },
                    { 197, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(286), new DateTime(1990, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Omar_El_Said.jpg", true, false, "Omar El Said", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(286) },
                    { 198, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(288), new DateTime(1993, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hassan_Youssef.jpg", true, false, "Hassan Youssef", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(288) },
                    { 199, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(289), new DateTime(2003, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Kajally_Drammeh.jpg", true, false, "Kajally Drammeh", "Gambia", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(290) },
                    { 200, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(292), new DateTime(1997, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Abdelsalam.jpg", true, false, "Mohamed Abdelsalam", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(292) },
                    { 201, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(294), new DateTime(1990, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hassan_Magdy.jpg", true, false, "Hassan Magdy", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(295) },
                    { 202, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(296), new DateTime(1988, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Nasef.jpg", true, false, "Mohamed Nasef", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(297) },
                    { 203, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(298), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_Shika.jpg", true, false, "Abdelrahman Shika", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(299) },
                    { 204, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(300), new DateTime(1994, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amr_El_Sisi.jpg", true, false, "Amr El Sisi", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(300) },
                    { 205, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(302), new DateTime(1989, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ali_Lotfi.jpg", true, false, "Ali Lotfi", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(302) },
                    { 206, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(304), new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amr_Hossam.jpg", true, false, "Amr Hossam", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(304) },
                    { 207, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(306), new DateTime(1985, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_El_Sayed.jpg", true, false, "Mahmoud El Sayed", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(306) },
                    { 208, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(308), new DateTime(1996, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Injured: Cruciate ligament tear", "Mohamed_Samir.jpg", true, false, "Mohamed Samir", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(308) },
                    { 209, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(310), new DateTime(1993, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Ashraf.jpg", true, false, "Mohamed Ashraf", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(310) },
                    { 210, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(312), new DateTime(1999, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Zaki.jpg", true, false, "Ahmed Zaki", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(312) },
                    { 211, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(329), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Kajo.jpg", true, false, "Mostafa Kajo", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(330) },
                    { 212, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(331), new DateTime(1999, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Ismail.jpg", true, false, "Mohamed Ismail", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(332) },
                    { 213, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(333), new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Sayed.jpg", true, false, "Ahmed Sayed", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(334) },
                    { 214, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(335), new DateTime(2001, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Saber.jpg", true, false, "Mahmoud Saber", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(336) },
                    { 215, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(337), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Zareef.jpg", true, false, "Mohamed El Zareef", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(337) },
                    { 216, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(339), new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Sayed.jpg", true, false, "Mohamed El Sayed", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(339) },
                    { 217, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(343), new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Abdel_Naby.jpg", true, false, "Ahmed Abdel Naby", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(343) },
                    { 218, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(344), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Ziko.jpg", true, false, "Mostafa Ziko", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(345) },
                    { 219, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(346), new DateTime(1990, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Shady_Hussein.jpg", true, false, "Shady Hussein", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(347) },
                    { 220, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(348), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_El_Banouby.jpg", true, false, "Abdelrahman El Banouby", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(348) },
                    { 221, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(350), new DateTime(2000, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ziad_Kamal.jpg", true, false, "Ziad Kamal", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(351) },
                    { 222, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(352), new DateTime(1992, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Sheikh.jpg", true, false, "Ahmed El Sheikh", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(352) },
                    { 223, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(355), new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Islam_Abdallah.jpg", true, false, "Islam Abdallah", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(355) },
                    { 224, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(356), new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Salah_Basha.jpg", true, false, "Salah Basha", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(357) },
                    { 225, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(374), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_Abdelnabi.jpg", true, false, "Abdelrahman Abdelnabi", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(374) },
                    { 226, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(376), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Zaalouk.jpg", true, false, "Mohamed Zaalouk", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(377) },
                    { 227, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(378), new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hassan_Mahmoud.jpg", true, false, "Hassan Mahmoud", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(379) },
                    { 228, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(380), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Nadim.jpg", true, false, "Mohamed Nadim", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(381) },
                    { 229, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(382), new DateTime(1998, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Peter_Mutumosi.jpg", true, false, "Peter Mutumosi", "DR Congo", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(383) },
                    { 230, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(384), new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Okasha.jpg", true, false, "Mohamed Okasha", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(384) },
                    { 231, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(386), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_Atef.jpg", true, false, "Abdelrahman Atef", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(386) },
                    { 232, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(388), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hesham_Hafez.jpg", true, false, "Hesham Hafez", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(388) },
                    { 233, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(390), new DateTime(2000, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_Samir.jpg", true, false, "Abdelrahman Samir", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(390) },
                    { 234, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(392), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Khalil.jpg", true, false, "Ahmed Khalil", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(392) },
                    { 235, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(394), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Magdy.jpg", true, false, "Mohamed Magdy", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(394) },
                    { 236, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(395), new DateTime(1993, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Agouz.jpg", true, false, "Ahmed El Agouz", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(396) },
                    { 237, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(449), new DateTime(1995, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Injured: Cruciate ligament tear", "Mohamed_Hamdi.jpg", true, false, "Mohamed Hamdi", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(449) },
                    { 238, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(466), new DateTime(1992, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ali_Fawzi.jpg", true, false, "Ali Fawzi", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(466) },
                    { 239, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(468), new DateTime(1999, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Sabeha.jpg", true, false, "Ahmed Sabeha", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(468) },
                    { 240, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(470), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Hamed.jpg", true, false, "Mohamed Hamed", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(470) },
                    { 241, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(472), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Adel.jpg", true, false, "Mostafa Adel", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(472) },
                    { 242, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(474), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Youssef.jpg", true, false, "Ahmed Youssef", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(474) },
                    { 243, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(476), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mody_Naser.jpg", true, false, "Mody Naser", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(476) },
                    { 244, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(478), new DateTime(2000, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ziad_Kamal.jpg", true, false, "Ziad Kamal", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(478) },
                    { 245, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(480), new DateTime(1996, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Amin.jpg", true, false, "Ahmed Amin", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(480) },
                    { 246, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(482), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ziad_Tarek.jpg", true, false, "Ziad Tarek", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(482) },
                    { 247, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(484), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Nahhas.jpg", true, false, "Mohamed El Nahhas", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(484) },
                    { 248, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(486), new DateTime(2000, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Shakshak.jpg", true, false, "Mostafa Shakshak", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(486) },
                    { 249, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(488), new DateTime(2003, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Nader_Hawash.jpg", true, false, "Ahmed Nader Hawash", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(488) },
                    { 250, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(490), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Naser.jpg", true, false, "Mohamed Naser", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(490) },
                    { 251, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(492), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Youssef_Labib.jpg", true, false, "Youssef Labib", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(492) },
                    { 252, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(508), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Salah_Zayed.jpg", true, false, "Salah Zayed", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(509) },
                    { 253, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(510), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Emad.jpg", true, false, "Ahmed Emad", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(511) },
                    { 254, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(512), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Karim_El_Tayeb.jpg", true, false, "Karim El Tayeb", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(513) },
                    { 255, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(514), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hesham_Adel.jpg", true, false, "Hesham Adel", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(514) },
                    { 256, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(516), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Maghraby.jpg", true, false, "Mohamed El Maghraby", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(516) },
                    { 257, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(518), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Eid.jpg", true, false, "Ahmed Eid", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(519) },
                    { 258, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(521), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Sherif.jpg", true, false, "Mohamed Sherif", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(521) },
                    { 259, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(523), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Fathi_El_Sayed.jpg", true, false, "Fathi El Sayed", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(523) },
                    { 260, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(525), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Adel_Mid.jpg", true, false, "Mostafa Adel", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(525) },
                    { 261, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(527), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_Emad.jpg", true, false, "Abdelrahman Emad", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(527) },
                    { 262, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(530), new DateTime(1984, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "El_Hany_Soliman.jpg", true, false, "El Hany Soliman", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(530) },
                    { 263, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(532), new DateTime(1999, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hussein_Faisal.jpg", true, false, "Hussein Faisal", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(532) },
                    { 264, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(534), new DateTime(1994, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Sabahi.jpg", true, false, "Mohamed El Sabahi", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(534) },
                    { 265, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(536), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_El_Badry.jpg", true, false, "Mostafa El Badry", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(536) },
                    { 266, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(553), new DateTime(1998, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Khaled.jpg", true, false, "Ahmed Khaled", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(553) },
                    { 267, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(555), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Saeed.jpg", true, false, "Mohamed Saeed", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(555) },
                    { 268, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(557), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_Amer.jpg", true, false, "Abdelrahman Amer", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(557) },
                    { 269, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(559), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Tarek_Alaa.jpg", true, false, "Tarek Alaa", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(559) },
                    { 270, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(561), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Mkaari.jpg", true, false, "Mohamed Mkaari", "Tunisia", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(561) },
                    { 271, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(563), new DateTime(1999, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Canaria.jpg", true, false, "Canaria", "Nigeria", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(563) },
                    { 272, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(565), new DateTime(1997, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Mostafa.jpg", true, false, "Ahmed Mostafa", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(565) },
                    { 273, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(567), new DateTime(1993, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hossam_Hassan.jpg", true, false, "Hossam Hassan", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(567) },
                    { 274, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(569), new DateTime(1999, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Metwaly.jpg", true, false, "Mohamed Metwaly", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(569) },
                    { 275, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(571), new DateTime(1994, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Gamal.jpg", true, false, "Ahmed Gamal", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(571) },
                    { 276, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(572), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Essam.jpg", true, false, "Mohamed Essam", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(573) },
                    { 277, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(574), new DateTime(1997, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amr_Kalawa.jpg", true, false, "Amr Kalawa", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(575) },
                    { 278, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(576), new DateTime(1993, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Emad_Fathi.jpg", true, false, "Emad Fathi", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(577) },
                    { 279, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(579), new DateTime(1996, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Islam_Gaber.jpg", true, false, "Islam Gaber", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(580) },
                    { 280, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(596), new DateTime(1997, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Fady_Farid.jpg", true, false, "Fady Farid", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(596) },
                    { 281, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(598), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Omar_Salah.jpg", true, false, "Omar Salah", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(598) },
                    { 282, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(600), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Abdelrasoul.jpg", true, false, "Ahmed Abdelrasoul", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(600) },
                    { 283, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(602), new DateTime(1998, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Justice_Arthur.jpg", true, false, "Justice Arthur", "Ghana", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(602) },
                    { 284, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(604), new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Adham_Alaa.jpg", true, false, "Adham Alaa", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(604) },
                    { 285, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(606), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_El_Khawaga.jpg", true, false, "Mostafa El Khawaga", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(606) },
                    { 286, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(608), new DateTime(1998, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Emam_Ashour.jpg", true, false, "Emam Ashour", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(608) },
                    { 287, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(610), new DateTime(1996, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Junior_Ajayi.jpg", true, false, "Junior Ajayi", "Nigeria", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(610) },
                    { 288, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(612), new DateTime(1997, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Lakay.jpg", true, false, "Lakay", "South Africa", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(612) },
                    { 289, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(614), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelaziz_El_Sayed.jpg", true, false, "Abdelaziz El Sayed", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(614) },
                    { 290, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(615), new DateTime(1994, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Shaaban.jpg", true, false, "Mohamed Shaaban", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(616) },
                    { 291, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(649), new DateTime(1986, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Emad_El_Sayed.jpg", true, false, "Emad El Sayed", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(649) },
                    { 292, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(651), new DateTime(1997, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Omar_Radwan.jpg", true, false, "Omar Radwan", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(651) },
                    { 293, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(688), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Abdelmonem.jpg", true, false, "Ahmed Abdelmonem", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(688) },
                    { 294, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(690), new DateTime(1989, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Khaled_Stouhi.jpg", true, false, "Khaled Stouhi", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(691) },
                    { 295, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(692), new DateTime(1998, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Houssem_Dagdoug.jpg", true, false, "Houssem Dagdoug", "Tunisia", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(693) },
                    { 296, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(694), new DateTime(1992, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amro_Tarek.jpg", true, false, "Amro Tarek", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(695) },
                    { 297, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(696), new DateTime(1996, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Meteb.jpg", true, false, "Ahmed Meteb", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(696) },
                    { 298, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(698), new DateTime(1990, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hassan_Magdy.jpg", true, false, "Hassan Magdy", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(698) },
                    { 299, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(701), new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Islam_Mohareb.jpg", true, false, "Islam Mohareb", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(701) },
                    { 300, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(703), new DateTime(1994, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Samir.jpg", true, false, "Ahmed Samir", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(703) },
                    { 301, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(705), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Yahia_Hamed.jpg", true, false, "Yahia Hamed", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(705) },
                    { 302, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(707), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_Shika.jpg", true, false, "Abdelrahman Shika", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(707) },
                    { 303, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(709), new DateTime(1996, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Hany.jpg", true, false, "Mohamed Hany", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(709) },
                    { 304, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(711), new DateTime(1989, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Farid_Shawki.jpg", true, false, "Farid Shawki", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(711) },
                    { 305, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(712), new DateTime(1999, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ali_Hamdy.jpg", true, false, "Ali Hamdy", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(713) },
                    { 306, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(714), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Paul_Joules.jpg", true, false, "Paul Joules", "Nigeria", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(715) },
                    { 307, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(734), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Godwin_Okwara.jpg", true, false, "Godwin Okwara", "Nigeria", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(735) },
                    { 308, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(736), new DateTime(1992, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Karim_Tarek.jpg", true, false, "Karim Tarek", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(737) },
                    { 309, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(739), new DateTime(1995, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Momen_Rady.jpg", true, false, "Momen Rady", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(739) },
                    { 310, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(741), new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Khawaga.jpg", true, false, "Mostafa Khawaga", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(741) },
                    { 311, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(743), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Shehata.jpg", true, false, "Mohamed Shehata", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(743) },
                    { 312, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(745), new DateTime(1988, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Khaled_Kamar.jpg", true, false, "Khaled Kamar", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(745) },
                    { 313, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(747), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Kout.jpg", true, false, "Mohamed El Kout", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(747) },
                    { 314, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(748), new DateTime(1994, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Mansour.jpg", true, false, "Ahmed Mansour", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(749) },
                    { 315, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(750), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Karim_Halawa.jpg", true, false, "Karim Halawa", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(751) },
                    { 316, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(752), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Omar_Tarek.jpg", true, false, "Omar Tarek", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(752) },
                    { 317, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(754), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Yehia_Zakaria.jpg", true, false, "Yehia Zakaria", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(754) },
                    { 318, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(756), new DateTime(1987, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "El_Mahdy_Soliman.jpg", true, false, "El Mahdy Soliman", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(756) },
                    { 319, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(758), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Omar_Salah.jpg", true, false, "Omar Salah", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(758) },
                    { 320, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(760), new DateTime(1993, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amr_Khalil.jpg", true, false, "Amr Khalil", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(760) },
                    { 321, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(777), new DateTime(1990, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hesham_Mohamed.jpg", true, false, "Hesham Mohamed", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(777) },
                    { 322, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(779), new DateTime(1991, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Khaled_El_Ghandour.jpg", true, false, "Khaled El Ghandour", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(779) },
                    { 323, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(781), new DateTime(1990, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Abdelaziz.jpg", true, false, "Mahmoud Abdelaziz", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(781) },
                    { 324, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(784), new DateTime(1995, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Karim_El_Deeb.jpg", true, false, "Karim El Deeb", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(784) },
                    { 325, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(785), new DateTime(1995, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Shabana.jpg", true, false, "Mahmoud Shabana", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(786) },
                    { 326, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(788), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Ghoneim.jpg", true, false, "Ahmed Ghoneim", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(788) },
                    { 327, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(790), new DateTime(1997, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelghani_Mohamed.jpg", true, false, "Abdelghani Mohamed", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(790) },
                    { 328, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(792), new DateTime(1992, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mabululu.jpg", true, false, "Mabululu", "Angola", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(792) },
                    { 329, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(794), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Adel.jpg", true, false, "Ahmed Adel", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(794) },
                    { 330, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(796), new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Omar_El_Saaiy.jpg", true, false, "Omar El Saaiy", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(796) },
                    { 331, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(797), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hany_El_Tamy.jpg", true, false, "Hany El Tamy", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(798) },
                    { 332, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(799), new DateTime(1990, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Nader_Ramadan.jpg", true, false, "Nader Ramadan", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(800) },
                    { 333, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(802), new DateTime(1996, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Islam_Gaber.jpg", true, false, "Islam Gaber", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(802) },
                    { 334, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(804), new DateTime(1996, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amr_Saleh.jpg", true, false, "Amr Saleh", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(805) },
                    { 335, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(822), new DateTime(1998, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Fawzy_El_Henawy.jpg", true, false, "Fawzy El Henawy", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(822) },
                    { 336, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(824), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Adel_Badr.jpg", true, false, "Adel Badr", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(824) },
                    { 337, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(826), new DateTime(1991, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Benjamin_Boateng.jpg", true, false, "Benjamin Boateng", "Ghana", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(826) },
                    { 338, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(828), new DateTime(2003, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Bekale_Aubame.jpg", true, false, "Bekale Aubame", "Gabon", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(829) },
                    { 339, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(830), new DateTime(1992, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Sheikh.jpg", true, false, "Ahmed El Sheikh", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(830) },
                    { 340, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(832), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hesham_Hafez.jpg", true, false, "Hesham Hafez", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(832) },
                    { 341, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(834), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Ragab.jpg", true, false, "Mohamed Ragab", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(834) },
                    { 342, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(836), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Karim_Yahia.jpg", true, false, "Karim Yahia", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(836) },
                    { 343, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(838), new DateTime(1994, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amr_El_Sisi.jpg", true, false, "Amr El Sisi", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(838) },
                    { 344, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(840), new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdo_Semida.jpg", true, false, "Abdo Semida", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(840) },
                    { 345, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(874), new DateTime(1999, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Ismail.jpg", true, false, "Mohamed Ismail", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(875) },
                    { 346, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(876), new DateTime(1994, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Fathi.jpg", true, false, "Mohamed Fathi", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(876) },
                    { 347, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(878), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Bahaa.jpg", true, false, "Ahmed Bahaa", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(878) },
                    { 348, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(896), new DateTime(1990, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Fawzi.jpg", true, false, "Mohamed Fawzi", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(897) },
                    { 349, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(898), new DateTime(1997, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Karim_Emad.jpg", true, false, "Karim Emad", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(898) },
                    { 350, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(900), new DateTime(1988, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Felix.jpg", true, false, "Ahmed Felix", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(900) },
                    { 351, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(902), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Sobhi.jpg", true, false, "Mostafa Sobhi", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(902) },
                    { 352, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(904), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Mamdouh.jpg", true, false, "Mahmoud Mamdouh", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(904) },
                    { 353, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(906), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Khaled_Sami.jpg", true, false, "Khaled Sami", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(906) },
                    { 354, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(908), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hatem_El_Sharkawy.jpg", true, false, "Hatem El Sharkawy", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(908) },
                    { 355, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(909), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Ayman.jpg", true, false, "Ahmed Ayman", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(910) },
                    { 356, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(911), new DateTime(1996, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Reda.jpg", true, false, "Mohamed Reda", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(912) },
                    { 357, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(913), new DateTime(1990, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Gamal.jpg", true, false, "Mostafa Gamal", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(914) },
                    { 358, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(915), new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Shedid_Kenawi.jpg", true, false, "Ahmed Shedid Kenawi", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(915) },
                    { 359, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(917), new DateTime(1998, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Wagih_Abdelhakim.jpg", true, false, "Wagih Abdelhakim", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(917) },
                    { 360, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(919), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hamed_El_Gabry.jpg", true, false, "Hamed El Gabry", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(920) },
                    { 361, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(921), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Abdelsalam.jpg", true, false, "Mohamed Abdelsalam", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(922) },
                    { 362, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(938), new DateTime(1998, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Emam_Ashour.jpg", true, false, "Emam Ashour", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(938) },
                    { 363, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(940), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Hashem.jpg", true, false, "Mohamed Hashem", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(940) },
                    { 364, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(942), new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Dawooda.jpg", true, false, "Ahmed Dawooda", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(942) },
                    { 365, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(943), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Gharib_Yasser.jpg", true, false, "Gharib Yasser", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(944) },
                    { 366, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(945), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hossam_Aboelazm.jpg", true, false, "Hossam Aboelazm", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(946) },
                    { 367, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(947), new DateTime(1992, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Islam_Abdelnaim.jpg", true, false, "Islam Abdelnaim", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(947) },
                    { 368, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(949), new DateTime(1990, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ibrahim_El_Kadi.jpg", true, false, "Ibrahim El Kadi", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(949) },
                    { 369, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(951), new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_Khaled.jpg", true, false, "Abdelrahman Khaled", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(951) },
                    { 370, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(953), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Nagy.jpg", true, false, "Mohamed Nagy", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(953) },
                    { 371, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(955), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Ziko.jpg", true, false, "Mostafa Ziko", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(955) },
                    { 372, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(957), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Abdelnasser.jpg", true, false, "Mohamed Abdelnasser", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(957) },
                    { 373, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(959), new DateTime(1997, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Hany.jpg", true, false, "Ahmed Hany", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(959) },
                    { 374, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(961), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Ragab.jpg", true, false, "Mohamed Ragab", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(961) },
                    { 375, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(962), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Vidjannagni_Saizonou.jpg", true, false, "Vidjannagni Saïzonou", "Benin", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(963) },
                    { 376, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(979), new DateTime(1993, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Shika.jpg", true, false, "Mohamed Shika", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(979) },
                    { 377, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(981), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Abdelaziz.jpg", true, false, "Ahmed Abdelaziz", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(981) },
                    { 378, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(982), new DateTime(1993, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Hamdy.jpg", true, false, "Mahmoud Hamdy", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(983) },
                    { 379, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(984), new DateTime(1999, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hossam_Aly.jpg", true, false, "Hossam Aly", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(985) },
                    { 380, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(986), new DateTime(1999, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Ismail.jpg", true, false, "Mohamed Ismail", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(986) },
                    { 381, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(988), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Reda.jpg", true, false, "Ahmed Reda", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(988) },
                    { 382, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(990), new DateTime(1993, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Chibi.jpg", true, false, "Mohamed Chibi", "Morocco", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(990) },
                    { 383, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(992), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hamed_Hamdan.jpg", true, false, "Hamed Hamdan", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(992) },
                    { 384, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(994), new DateTime(1996, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Emad.jpg", true, false, "Mahmoud Emad", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(994) },
                    { 385, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(996), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_El_Dah.jpg", true, false, "Abdelrahman El Dah", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(996) },
                    { 386, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(998), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Sedki.jpg", true, false, "Mohamed Sedki", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(998) },
                    { 387, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1000), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ismail_Boubekeur.jpg", true, false, "Ismail Boubekeur", "Algeria", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1000) },
                    { 388, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1002), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Favour_Nwobgo.jpg", true, false, "Favour Nwobgo", "Nigeria", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1002) },
                    { 389, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1019), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Salem.jpg", true, false, "Mohamed Salem", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1019) },
                    { 390, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1021), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Fawzy.jpg", true, false, "Ahmed Fawzy", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1021) },
                    { 391, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1022), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Bahaa.jpg", true, false, "Ahmed Bahaa", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1023) },
                    { 392, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1024), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hossam_Ashraf.jpg", true, false, "Hossam Ashraf", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1025) },
                    { 393, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1026), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ziad_Ashraf.jpg", true, false, "Ziad Ashraf", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1026) },
                    { 394, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1028), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Touny.jpg", true, false, "Mohamed El Touny", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1028) },
                    { 395, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1030), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Moawad.jpg", true, false, "Mostafa Moawad", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1030) },
                    { 396, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1032), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hatem_Mohamed.jpg", true, false, "Hatem Mohamed", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1032) },
                    { 397, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1034), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Sosta.jpg", true, false, "Mohamed Sosta", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1034) },
                    { 398, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1036), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Agamy.jpg", true, false, "Ahmed El Agamy", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1036) },
                    { 399, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1070), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Abdelnabi.jpg", true, false, "Mahmoud Abdelnabi", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1071) },
                    { 400, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1072), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Shahin.jpg", true, false, "Mohamed Shahin", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1072) },
                    { 401, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1074), new DateTime(2000, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Jibril_Bojang.jpg", true, false, "Jibril Bojang", "Gambia", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1074) },
                    { 402, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1076), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_El_Kout.jpg", true, false, "Mahmoud El Kout", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1076) },
                    { 403, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1093), new DateTime(1993, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amr_Shaaban.jpg", true, false, "Amr Shaaban", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1093) },
                    { 404, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1096), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_El_Hadary.jpg", true, false, "Mahmoud El Hadary", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1097) },
                    { 405, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1098), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Nadry.jpg", true, false, "Ahmed El Nadry", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1099) },
                    { 406, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1100), new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Sami.jpg", true, false, "Mohamed Sami", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1100) },
                    { 407, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1102), new DateTime(1990, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Moaz_El_Henawy.jpg", true, false, "Moaz El Henawy", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1102) },
                    { 408, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1104), new DateTime(1993, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Bazoka.jpg", true, false, "Mohamed Bazoka", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1104) },
                    { 409, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1106), new DateTime(1990, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Sheikh.jpg", true, false, "Ahmed El Sheikh", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1106) },
                    { 410, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1108), new DateTime(1993, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ehab_Samir.jpg", true, false, "Ehab Samir", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1108) },
                    { 411, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1111), new DateTime(1999, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdo_Yehia.jpg", true, false, "Abdo Yehia", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1112) },
                    { 412, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1113), new DateTime(1996, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Geaidy.jpg", true, false, "Ahmed El Geaidy", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1113) },
                    { 413, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1115), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Saleh_Nasr.jpg", true, false, "Saleh Nasr", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1115) },
                    { 414, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1117), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Charles_Ekpenyong.jpg", true, false, "Charles Ekpenyong", "Nigeria", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1117) },
                    { 415, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1123), new DateTime(1998, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Youssef_Hassan.jpg", true, false, "Youssef Hassan", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1123) },
                    { 416, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1125), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Khaled_El_Akhmimi.jpg", true, false, "Khaled El Akhmimi", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1125) },
                    { 417, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1142), new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Nadry2.jpg", true, false, "Ahmed El Nadry", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1142) },
                    { 418, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1144), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Osama.jpg", true, false, "Mostafa Osama", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1144) },
                    { 419, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1146), new DateTime(1991, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hamid_Mao.jpg", true, false, "Hamid Mao", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1146) },
                    { 420, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1147), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelkader_Yehia.jpg", true, false, "Abdelkader Yehia", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1148) },
                    { 421, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1149), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Gabriel_Chukwudi.jpg", true, false, "Gabriel Chukwudi", "Nigeria", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1150) },
                    { 422, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1151), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Gaber.jpg", true, false, "Mohamed Gaber", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1151) },
                    { 423, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1153), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hesham_Nabawi.jpg", true, false, "Hesham Nabawi", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1153) },
                    { 424, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1155), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ibrahima_Mbaye.jpg", true, false, "Ibrahima Mbaye", "Senegal", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1155) },
                    { 425, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1157), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Abdel_Aati.jpg", true, false, "Mohamed Abdel Aati", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1157) },
                    { 426, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1159), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Aboulkheir.jpg", true, false, "Ahmed Aboulkheir", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1159) },
                    { 427, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1161), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Kalosha.jpg", true, false, "Mostafa Kalosha", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1161) },
                    { 428, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1163), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hossam_Hassan.jpg", true, false, "Hossam Hassan", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1163) },
                    { 429, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1165), new DateTime(1998, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Peter_Zilu_Mutumosi.jpg", true, false, "Peter Zilu Mutumosi", "DR Congo", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1165) },
                    { 430, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1166), new DateTime(1993, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Fawzi.jpg", true, false, "Mohamed Fawzi", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1167) },
                    { 431, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1184), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Adel.jpg", true, false, "Ahmed Adel", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1184) },
                    { 432, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1186), new DateTime(1999, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Kamal_El_Sayed.jpg", true, false, "Kamal El Sayed", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1186) },
                    { 433, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1187), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Essam_El_Hadary.jpg", true, false, "Essam El Hadary", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1188) },
                    { 434, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1189), new DateTime(1992, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Nasr.jpg", true, false, "Mohamed Nasr", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1190) },
                    { 435, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1191), new DateTime(1997, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Desouki.jpg", true, false, "Mohamed Desouki", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1192) },
                    { 436, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1193), new DateTime(2001, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hatem_Sukar.jpg", true, false, "Hatem Sukar", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1193) },
                    { 437, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1195), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Bayoumi.jpg", true, false, "Mohamed Bayoumi", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1195) },
                    { 438, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1197), new DateTime(1993, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Karim_Arafat.jpg", true, false, "Karim Arafat", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1197) },
                    { 439, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1199), new DateTime(2001, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Nader_Farag.jpg", true, false, "Nader Farag", "Sudan", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1199) },
                    { 440, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1201), new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Omar_El_Saaiy.jpg", true, false, "Omar El Saaiy", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1201) },
                    { 441, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1203), new DateTime(1993, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Emad_Hamdy.jpg", true, false, "Emad Hamdy", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1203) },
                    { 442, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1205), new DateTime(1998, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Makhlouf.jpg", true, false, "Mohamed Makhlouf", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1205) },
                    { 443, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1206), new DateTime(1996, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Eric_Traore.jpg", true, false, "Eric Traoré", "Burkina Faso", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1207) },
                    { 444, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1224), new DateTime(1997, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_Magdy.jpg", true, false, "Abdelrahman Magdy", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1224) },
                    { 445, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1226), new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Basem_Morsy.jpg", true, false, "Basem Morsy", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1226) },
                    { 446, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1228), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Anas_Shendy.jpg", true, false, "Anas Shendy", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1228) },
                    { 447, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1230), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Zidan.jpg", true, false, "Mohamed Zidan", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1230) },
                    { 448, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1232), new DateTime(1990, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hesham_Mohamed.jpg", true, false, "Hesham Mohamed", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1232) },
                    { 449, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1234), new DateTime(2003, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Khaled_Al_Nabris.jpg", true, false, "Khaled Al Nabris", "Palestine", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1234) },
                    { 450, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1235), new DateTime(1996, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Marwan_Hamdi.jpg", true, false, "Marwan Hamdi", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1236) },
                    { 451, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1237), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Abdel_Samia.jpg", true, false, "Mohamed Abdel Samia", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1238) },
                    { 452, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1239), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Mohsen.jpg", true, false, "Ahmed Mohsen", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1240) },
                    { 453, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1274), new DateTime(1995, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Hashem.jpg", true, false, "Mohamed Hashem", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1274) },
                    { 454, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1276), new DateTime(1993, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Omar_Mamdouh.jpg", true, false, "Omar Mamdouh", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1276) },
                    { 455, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1277), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_El_Dah.jpg", true, false, "Abdelrahman El Dah", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1278) },
                    { 456, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1279), new DateTime(1994, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Bismark_Boateng.jpg", true, false, "Bismark Boateng", "Ghana", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1279) },
                    { 457, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1281), new DateTime(1997, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Sobhi_Soliman.jpg", true, false, "Sobhi Soliman", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1281) },
                    { 458, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1298), new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Mahmoud.jpg", true, false, "Ahmed Mahmoud", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1298) },
                    { 459, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1300), new DateTime(1991, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Masoud.jpg", true, false, "Ahmed Masoud", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1301) },
                    { 460, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1302), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Abdel_Rasoul.jpg", true, false, "Ahmed Abdel Rasoul", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1302) },
                    { 461, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1305), new DateTime(1998, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_El_Gazzar.jpg", true, false, "Mahmoud El Gazzar", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1305) },
                    { 462, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1306), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Hossam.jpg", true, false, "Ahmed Hossam", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1307) },
                    { 463, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1308), new DateTime(1997, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Kamal_Aboul_Fetouh.jpg", true, false, "Kamal Aboul Fetouh", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1309) },
                    { 464, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1310), new DateTime(1987, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Sabri_Rahil.jpg", true, false, "Sabri Rahil", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1310) },
                    { 465, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1312), new DateTime(2001, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Arnaud_Randianantenaina.jpg", true, false, "Arnaud Randianantenaina", "Madagascar", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1312) },
                    { 466, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1314), new DateTime(1996, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ayman_Moka.jpg", true, false, "Ayman Moka", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1314) },
                    { 467, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1316), new DateTime(1997, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Belhadji.jpg", true, false, "Ahmed Belhadji", "Morocco", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1316) },
                    { 468, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1318), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Seif_Shika.jpg", true, false, "Seif Shika", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1318) },
                    { 469, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1320), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Reda_Salah.jpg", true, false, "Reda Salah", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1320) },
                    { 470, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1321), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Okka.jpg", true, false, "Mahmoud Okka", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1322) },
                    { 471, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1323), new DateTime(1994, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Sabahi.jpg", true, false, "Mohamed El Sabahi", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1324) },
                    { 472, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1340), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hossam_Ghanem.jpg", true, false, "Hossam Ghanem", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1340) },
                    { 473, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1342), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdel_Fattah_Sheta.jpg", true, false, "Abdel Fattah Sheta", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1342) },
                    { 474, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1344), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Emad.jpg", true, false, "Mohamed Emad", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1344) },
                    { 475, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1346), new DateTime(1997, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ashraf_Magdy.jpg", true, false, "Ashraf Magdy", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1346) },
                    { 476, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1347), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ziad_Tarek.jpg", true, false, "Ziad Tarek", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1348) },
                    { 477, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1349), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Youssef.jpg", true, false, "Mohamed Youssef", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1350) },
                    { 478, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1351), new DateTime(2001, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Franck_Etouga.jpg", true, false, "Franck Etouga", "Cameroon", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1351) },
                    { 479, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1353), new DateTime(1997, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Hany.jpg", true, false, "Ahmed Hany", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1353) },
                    { 480, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1355), new DateTime(1992, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Valentin_Zoungrana.jpg", true, false, "Valentin Zoungrana", "Burkina Faso", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1355) },
                    { 481, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1357), new DateTime(1991, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amr_Gamal.jpg", true, false, "Amr Gamal", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1357) },
                    { 482, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1359), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Abdel_Gawad.jpg", true, false, "Mohamed Abdel Gawad", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1359) },
                    { 483, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1361), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Salah.jpg", true, false, "Mahmoud Salah", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1361) },
                    { 484, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1363), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Saeed.jpg", true, false, "Mohamed Saeed", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1363) },
                    { 485, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1365), new DateTime(1994, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Shafik.jpg", true, false, "Mohamed Shafik", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1365) },
                    { 486, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1382), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Fares_El_Sayed.jpg", true, false, "Fares El Sayed", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1382) },
                    { 487, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1384), new DateTime(1997, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Gaber_Kamel.jpg", true, false, "Gaber Kamel", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1384) },
                    { 488, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1386), new DateTime(1992, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Awad.jpg", true, false, "Ahmed Awad", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1386) },
                    { 489, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1388), new DateTime(1995, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Bahrawi.jpg", true, false, "Ahmed El Bahrawi", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1388) },
                    { 490, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1390), new DateTime(1998, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Jefferson_Encada.jpg", true, false, "Jefferson Encada", "Guinea-Bissau", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1390) },
                    { 491, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1392), new DateTime(2001, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Seif_El_Agouz.jpg", true, false, "Seif El Agouz", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1392) },
                    { 492, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1394), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Gehad.jpg", true, false, "Mahmoud Gehad", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1394) },
                    { 493, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1396), new DateTime(1999, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Fakhry.jpg", true, false, "Mohamed Fakhry", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1396) },
                    { 494, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1398), new DateTime(1994, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Saif_Terry.jpg", true, false, "Saif Terry", "Sudan", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1398) },
                    { 495, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1400), new DateTime(1994, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Shokry_Naguib.jpg", true, false, "Shokry Naguib", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1400) },
                    { 496, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1401), new DateTime(2001, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Walid_Farag.jpg", true, false, "Walid Farag", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1402) },
                    { 497, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1403), new DateTime(2003, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Fouad.jpg", true, false, "Ahmed Fouad", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1404) },
                    { 498, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1405), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Bangoura.jpg", true, false, "Mohamed Bangoura", "Guinea", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1406) },
                    { 499, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1422), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Hamada.jpg", true, false, "Mostafa Hamada", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1423) },
                    { 500, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1424), new DateTime(2001, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Tarek.jpg", true, false, "Mostafa Tarek", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1425) },
                    { 501, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1426), new DateTime(1998, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Sageer.jpg", true, false, "Ahmed El Sageer", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1427) },
                    { 502, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1428), new DateTime(1987, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Rami_Sabri.jpg", true, false, "Rami Sabri", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1429) },
                    { 503, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1430), new DateTime(1998, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Azmi_Ghouma.jpg", true, false, "Azmi Ghouma", "Tunisia", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1430) },
                    { 504, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1432), new DateTime(1999, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_El_Badry.jpg", true, false, "Mahmoud El Badry", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1432) },
                    { 505, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1434), new DateTime(1991, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Khaled_El_Ghandour.jpg", true, false, "Khaled El Ghandour", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1434) },
                    { 506, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1436), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Armouty.jpg", true, false, "Ahmed El Armouty", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1436) },
                    { 507, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1469), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Emad.jpg", true, false, "Mahmoud Emad", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1469) },
                    { 508, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1471), new DateTime(1995, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Kingsley_Sokari.jpg", true, false, "Kingsley Sokari", "Nigeria", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1472) },
                    { 509, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1473), new DateTime(1998, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Moussa_Camara.jpg", true, false, "Moussa Camara", "Guinea", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1474) },
                    { 510, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1475), new DateTime(1993, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amr_Warda.jpg", true, false, "Amr Warda", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1476) },
                    { 511, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1477), new DateTime(1997, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amer_Amer.jpg", true, false, "Amer Amer", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1477) },
                    { 512, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1479), new DateTime(1987, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Aboul_Saoud.jpg", true, false, "Mahmoud Aboul Saoud", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1479) },
                    { 513, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1496), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Ahmed.jpg", true, false, "Mohamed Ahmed", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1496) },
                    { 514, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1497), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Farouq_Noor.jpg", true, false, "Farouq Noor", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1498) },
                    { 515, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1499), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Ghalwesh.jpg", true, false, "Mohamed Ghalwesh", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1500) },
                    { 516, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1501), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Eid.jpg", true, false, "Ahmed Eid", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1502) },
                    { 517, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1503), new DateTime(1993, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Joseph_Ochaya.jpg", true, false, "Joseph Ochaya", "Uganda", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1503) },
                    { 518, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1505), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Alaa.jpg", true, false, "Ahmed Alaa", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1505) },
                    { 519, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1508), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Salem.jpg", true, false, "Mohamed Salem", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1508) },
                    { 520, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1510), new DateTime(2002, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Favour_Aniekan.jpg", true, false, "Favour Aniekan", "Nigeria", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1510) },
                    { 521, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1512), new DateTime(1993, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Antar.jpg", true, false, "Mohamed Antar", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1512) },
                    { 522, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1514), new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Arabi.jpg", true, false, "Ahmed El Arabi", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1514) },
                    { 523, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1516), new DateTime(1996, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Magli.jpg", true, false, "Mohamed Magli", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1516) },
                    { 524, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1518), new DateTime(1994, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Shabrawy.jpg", true, false, "Mahmoud Shabrawy", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1518) },
                    { 525, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1520), new DateTime(1999, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amar_Hamdi.jpg", true, false, "Amar Hamdi", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1520) },
                    { 526, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1522), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Shawky.jpg", true, false, "Mohamed Shawky", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1522) },
                    { 527, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1539), new DateTime(1992, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Omar_Fathi.jpg", true, false, "Omar Fathi", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1539) },
                    { 528, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1541), new DateTime(1998, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Atef.jpg", true, false, "Ahmed Atef", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1541) },
                    { 529, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1543), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Hany.jpg", true, false, "Mohamed Hany", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1543) },
                    { 530, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1545), new DateTime(1994, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Niass.jpg", true, false, "Mohamed Niass", "Senegal", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1545) },
                    { 531, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1547), new DateTime(1994, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdallah_Yaisien.jpg", true, false, "Abdallah Yaisien", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1547) },
                    { 532, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1548), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Manga.jpg", true, false, "Mahmoud Manga", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1549) },
                    { 533, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1551), new DateTime(1989, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amir_Abed.jpg", true, false, "Amir Abed", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1551) },
                    { 534, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1553), new DateTime(1992, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Louay_Wael.jpg", true, false, "Louay Wael", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1553) },
                    { 535, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1555), new DateTime(1993, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Omar_Bassam.jpg", true, false, "Omar Bassam", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1555) },
                    { 536, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1557), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Koh.jpg", true, false, "Ahmed El Koh", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1557) },
                    { 537, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1558), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ojo_Tolulope.jpg", true, false, "Ojo Tolulope", "Nigeria", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1559) },
                    { 538, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1560), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Aboul_Naga.jpg", true, false, "Mohamed Aboul-Naga", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1561) },
                    { 539, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1562), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdel_Kafi_Ragab.jpg", true, false, "Abdel Kafi Ragab", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1563) },
                    { 540, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1564), new DateTime(1991, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Seif_Teka.jpg", true, false, "Seif Teka", "Tunisia", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1564) },
                    { 541, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1581), new DateTime(1997, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Kamal_Aboul_Fetouh.jpg", true, false, "Kamal Aboul-Fetouh", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1581) },
                    { 542, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1583), new DateTime(1993, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Youssef_Camacho.jpg", true, false, "Mohamed Youssef Camacho", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1583) },
                    { 543, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1585), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Shebini.jpg", true, false, "Mohamed El Shebini", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1585) },
                    { 544, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1587), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Dahesh.jpg", true, false, "Ahmed Dahesh", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1587) },
                    { 545, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1588), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Omar_Adly.jpg", true, false, "Omar Adly", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1589) },
                    { 546, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1590), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Dahroug.jpg", true, false, "Ahmed Dahroug", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1591) },
                    { 547, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1592), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Fahd_Aboul_Fetouh.jpg", true, false, "Fahd Aboul-Fetouh", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1592) },
                    { 548, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1594), new DateTime(1991, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Winful_Cobbinah.jpg", true, false, "Winful Cobbinah", "Ghana", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1594) },
                    { 549, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1596), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Abdel_Aati.jpg", true, false, "Mohamed Abdel Aati", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1596) },
                    { 550, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1598), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Momen_Atef.jpg", true, false, "Momen Atef", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1598) },
                    { 551, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1600), new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Walid_Adel.jpg", true, false, "Walid Adel", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1600) },
                    { 552, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1602), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Islam_Adel.jpg", true, false, "Islam Adel", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1602) },
                    { 553, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1604), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Said_El_Wensh.jpg", true, false, "Said El Wensh", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1604) },
                    { 554, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1620), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Talaat.jpg", true, false, "Mahmoud Talaat", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1621) },
                    { 555, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1622), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Karim_Halawa.jpg", true, false, "Karim Halawa", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1622) },
                    { 556, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1624), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Walid_Ateya.jpg", true, false, "Walid Ateya", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1624) },
                    { 557, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1626), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ali_Hussein.jpg", true, false, "Ali Hussein", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1626) },
                    { 558, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1628), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Abdel_Khalek.jpg", true, false, "Mostafa Abdel Khalek", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1628) },
                    { 559, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1630), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hassan_Mahmoud.jpg", true, false, "Hassan Mahmoud", "Egypt", 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1630) },
                    { 560, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1632), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Sayed.jpg", true, false, "Mohamed El Sayed", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1632) },
                    { 561, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1652), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hesham_Adel.jpg", true, false, "Hesham Adel", "Egypt", 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1652) },
                    { 562, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1654), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Abdel_Mawgoud.jpg", true, false, "Ahmed Abdel Mawgoud", "Egypt", 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1654) },
                    { 563, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1655), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Kajo.jpg", true, false, "Mostafa Kajo", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1656) },
                    { 564, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1657), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Fayoumi.jpg", true, false, "Mohamed El Fayoumi", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1658) },
                    { 565, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1659), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Essam.jpg", true, false, "Ahmed Essam", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1660) },
                    { 566, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1661), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Zareef.jpg", true, false, "Mohamed El Zareef", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1661) },
                    { 567, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1663), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Nabil.jpg", true, false, "Mahmoud Nabil", "Egypt", 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1663) },
                    { 568, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1680), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hesham_Hafez.jpg", true, false, "Hesham Hafez", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1680) },
                    { 569, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1682), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Ali.jpg", true, false, "Ahmed Ali", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1682) },
                    { 570, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1683), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ibrahim_El_Kadi.jpg", true, false, "Ibrahim El Kadi", "Egypt", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1684) },
                    { 571, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1685), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Ramadan.jpg", true, false, "Mohamed Ramadan", "Egypt", 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1686) },
                    { 572, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1687), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hussein_Anwar.jpg", true, false, "Hussein Anwar", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1687) },
                    { 573, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1689), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Stanley_Anigbogu.jpg", true, false, "Stanley Anigbogu", "Nigeria", 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1689) },
                    { 574, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1691), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Sabahi.jpg", true, false, "Mohamed El Sabahi", "Egypt", 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1691) },
                    { 575, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1693), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Zaki.jpg", true, false, "Ahmed Zaki", "Egypt", 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1693) },
                    { 576, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1695), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Youssef_El_Gohary.jpg", true, false, "Youssef El Gohary", "Egypt", 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1695) },
                    { 577, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1697), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ali_Lotfi.jpg", true, false, "Ali Lotfi", "Egypt", 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(1697) }
                });

            migrationBuilder.InsertData(
                table: "Tournaments",
                columns: new[] { "Id", "Country", "CreatedAt", "DeletedAt", "Description", "EndDate", "IsActive", "IsDeleted", "Logo", "Season", "StartDate", "Title", "Type", "UpdatedAt", "Venue" },
                values: new object[] { 1, "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 97, DateTimeKind.Utc).AddTicks(116), null, "Top professional league for association football clubs in Egypt", new DateTime(2026, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Egyptian_Premier_League_Logo.jpg", "2025/2026", new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Egyptian Premier League", 0, new DateTime(2025, 8, 4, 16, 41, 23, 97, DateTimeKind.Utc).AddTicks(117), "Various stadiums in Egypt" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CoachId", "Country", "CreatedAt", "DeletedAt", "Description", "Founded", "IsActive", "IsDeleted", "LogoUrl", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(2928), null, "Official club name: Al Ahly Sporting Club", new DateTime(1907, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Al_Ahly_Logo.jpg", "Al Ahly FC", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(2929) },
                    { 2, 2, "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4519), null, "One of Egypt's most successful clubs", new DateTime(1911, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Zamalek_Logo.jpg", "Zamalek SC", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4520) },
                    { 3, 3, "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4523), null, "Formerly known as Al Assiouty Sport", new DateTime(2008, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Pyramids_Logo.jpg", "Pyramids FC", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4523) },
                    { 4, 4, "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4525), null, "Founded in 1920, known for winning the Egypt Cup in 1998", new DateTime(1920, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "El_Masry_Logo.jpg", "El Masry SC", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4526) },
                    { 5, 5, "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4558), null, "Promoted to the Egyptian Premier League in 2020", new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Ceramica_Cleopatra_Logo.jpg", "Ceramica Cleopatra FC", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4558) },
                    { 6, 6, "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4560), null, "Promoted to the Egyptian Premier League in 2020", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "National_Bank_Logo.jpg", "National Bank of Egypt SC", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4560) },
                    { 7, 7, "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4562), null, "Formerly Future FC, promoted to the Egyptian Premier League in 2021", new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Modern_Sport_Logo.jpg", "Modern Sport FC", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4562) },
                    { 8, 8, "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4564), null, "Formerly FC Masr, promoted to the Egyptian Premier League in 2023", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "ZED_Logo.jpg", "ZED FC", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4564) },
                    { 9, 9, "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4566), null, "Founded in 1985, competes in the Egyptian Premier League, won Egypt Cup in 2005 and 2011", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "ENPPI_Logo.jpg", "ENPPI SC", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4566) },
                    { 10, 10, "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4567), null, "Founded in 1948, competes in the Egyptian Premier League, runner-up in 2013-14", new DateTime(1948, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Smouha_Logo.jpg", "Smouha SC", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4568) },
                    { 11, 12, "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4569), null, "Founded in 1996, competes in the Egyptian Premier League, won Egyptian Super Cup in 2007", new DateTime(1996, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Talaea_El_Gaish_Logo.jpg", "Tala'ea El Gaish SC", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4570) },
                    { 12, 13, "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4571), null, "Founded in 1914, competes in the Egyptian Premier League, won Egypt Cup 6 times", new DateTime(1914, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Al_Ittihad_Alexandria_Logo.jpg", "Al Ittihad Alexandria", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4572) },
                    { 13, 14, "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4573), null, "Founded in 1932, competes in the Egyptian Premier League, won Egypt Cup and Super Cup in 2009", new DateTime(1932, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Haras_El_Hodoud_Logo.jpg", "Haras El Hodoud SC", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4573) },
                    { 14, 15, "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4575), null, "Founded in 2000, competes in the Egyptian Premier League, promoted in 2023-24", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Petrojet_Logo.jpg", "Petrojet SC", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4575) },
                    { 15, 16, "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4577), null, "Founded in 1936, competes in the Egyptian Premier League, won the league in 1972-73", new DateTime(1936, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Ghazl_El_Mahalla_Logo.jpg", "Ghazl El Mahalla SC", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4577) },
                    { 16, 17, "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4579), null, "Founded in 1924, competes in the Egyptian Premier League, won CAF Champions League in 1969, Egyptian Premier League 3 times(1967, 1991, 2002),and Egypt Cup twice(1997, 2000)", new DateTime(1924, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Ismaily_SC_Logo.jpg", "Ismaily SC", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4579) },
                    { 17, 18, "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4581), null, "Founded in 2003, competes in the Egyptian Premier League, promoted in 2023-24", new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "El_Gouna_Logo.jpg", "El Gouna FC", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4581) },
                    { 18, 19, "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4583), null, "Founded in 2010, competes in the Egyptian Premier League since 2021, based in Alexandria", new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Pharco_Logo.jpg", "Pharco FC", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4583) },
                    { 19, 20, "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4585), null, "Founded in 1973, competes in the Egyptian Premier League, won the Egyptian Premier League in 1983, Egypt Cup 3 times (1990, 1995, 2004), and CAF Cup Winners' Cup 3 times (1982, 1983, 1996)", new DateTime(1973, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Al_Mokawloon_Al_Arab_Logo.jpg", "Al Mokawloon Al Arab SC", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4585) },
                    { 20, 21, "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4602), null, "Founded in 2002, competes in Egyptian Second Division A, promoted to Egyptian Premier League in 2009-10", new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Wadi_Degla_Logo.jpg", "Wadi Degla SC", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4602) },
                    { 21, 22, "Egypt", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4604), null, "Founded in 1935, competes in the Egyptian Premier League for the first time in 2025-26 after promotion from the Second Division A", new DateTime(1935, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Kahrabaa_Ismailia_Logo.jpg", "Kahrabaa Ismailia SC", new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(4604) }
                });

            migrationBuilder.InsertData(
                table: "TeamPlayer",
                columns: new[] { "PlayerId", "TeamId", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "JoinedDate", "LeftDate", "Number", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(5348), null, true, false, new DateTime(2016, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(5349) },
                    { 2, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6532), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6533) },
                    { 3, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6536), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6536) },
                    { 4, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6538), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6538) },
                    { 5, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6539), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6539) },
                    { 6, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6541), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6541) },
                    { 7, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6542), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6542) },
                    { 8, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6544), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6544) },
                    { 9, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6545), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6545) },
                    { 10, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6547), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6547) },
                    { 11, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6548), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6549) },
                    { 12, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6550), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6550) },
                    { 13, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6551), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6552) },
                    { 14, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6581), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6581) },
                    { 15, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6583), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6583) },
                    { 16, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6584), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6584) },
                    { 17, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6586), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6586) },
                    { 18, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6587), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6588) },
                    { 19, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6589), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6589) },
                    { 20, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6590), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6591) },
                    { 21, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6592), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6592) },
                    { 22, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6593), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6594) },
                    { 23, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6595), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6595) },
                    { 24, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6596), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6597) },
                    { 25, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6598), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6598) },
                    { 26, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6600), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6600) },
                    { 27, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6601), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6601) },
                    { 28, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6603), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6603) },
                    { 29, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6622), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 38, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6623) },
                    { 30, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6624), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6624) },
                    { 31, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6626), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6626) },
                    { 32, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6627), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6627) },
                    { 33, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6629), null, true, false, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6629) },
                    { 34, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6630), null, true, false, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6630) },
                    { 35, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6632), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6632) },
                    { 36, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6633), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6634) },
                    { 37, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6635), null, true, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6635) },
                    { 38, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6637), null, true, false, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6637) },
                    { 39, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6638), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6638) },
                    { 40, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6678), null, true, false, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6678) },
                    { 41, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6680), null, true, false, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6680) },
                    { 42, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6682), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6683) },
                    { 43, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6684), null, true, false, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6684) },
                    { 44, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6685), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6686) },
                    { 45, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6703), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6703) },
                    { 46, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6705), null, true, false, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6705) },
                    { 47, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6706), null, true, false, new DateTime(2003, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6706) },
                    { 48, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6708), null, true, false, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6708) },
                    { 49, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6709), null, true, false, new DateTime(2015, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6710) },
                    { 50, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6711), null, true, false, new DateTime(2011, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6711) },
                    { 51, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6712), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6713) },
                    { 52, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6714), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6714) },
                    { 53, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6715), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6716) },
                    { 54, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6717), null, true, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6717) },
                    { 55, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6718), null, true, false, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6719) },
                    { 56, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6720), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6720) },
                    { 57, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6721), null, true, false, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6722) },
                    { 58, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6723), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6723) },
                    { 59, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6725), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6725) },
                    { 60, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6741), null, true, false, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6742) },
                    { 61, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6743), null, true, false, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6743) },
                    { 62, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6744), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6745) },
                    { 63, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6746), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6746) },
                    { 64, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6748), null, true, false, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6748) },
                    { 65, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6749), null, true, false, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6749) },
                    { 66, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6751), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6751) },
                    { 67, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6752), null, true, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6752) },
                    { 68, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6754), null, true, false, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6754) },
                    { 69, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6755), null, true, false, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6755) },
                    { 70, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6757), null, true, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6757) },
                    { 71, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6758), null, true, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6758) },
                    { 72, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6760), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6760) },
                    { 73, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6761), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6762) },
                    { 74, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6763), null, true, false, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6763) },
                    { 75, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6764), null, true, false, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6765) },
                    { 76, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6782), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6782) },
                    { 77, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6783), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6783) },
                    { 78, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6785), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6785) },
                    { 79, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6786), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6787) },
                    { 80, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6788), null, true, false, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6788) },
                    { 81, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6789), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6790) },
                    { 82, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6791), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6791) },
                    { 83, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6792), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6793) },
                    { 84, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6794), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6794) },
                    { 85, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6795), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6796) },
                    { 86, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6797), null, true, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6797) },
                    { 87, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6798), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6799) },
                    { 88, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6800), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6800) },
                    { 89, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6802), null, true, false, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6802) },
                    { 90, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6803), null, true, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6803) },
                    { 91, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6819), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6819) },
                    { 92, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6821), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6821) },
                    { 93, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6822), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6822) },
                    { 94, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6824), null, true, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6824) },
                    { 95, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6825), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6825) },
                    { 96, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6827), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6827) },
                    { 97, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6828), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6829) },
                    { 98, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6830), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6830) },
                    { 99, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6831), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6832) },
                    { 100, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6833), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6833) },
                    { 101, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6834), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6835) },
                    { 102, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6836), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6836) },
                    { 103, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6837), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6838) },
                    { 104, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6839), null, true, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6839) },
                    { 105, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6841), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6841) },
                    { 106, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6857), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6857) },
                    { 107, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6859), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6859) },
                    { 108, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6860), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6861) },
                    { 109, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6862), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6862) },
                    { 110, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6863), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6864) },
                    { 111, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6865), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6865) },
                    { 112, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6866), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6867) },
                    { 113, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6900), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6901) },
                    { 114, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6902), null, true, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6902) },
                    { 115, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6903), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6904) },
                    { 116, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6905), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6905) },
                    { 117, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6906), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6907) },
                    { 118, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6908), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6908) },
                    { 119, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6910), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6910) },
                    { 120, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6911), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6911) },
                    { 121, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6913), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6913) },
                    { 122, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6933), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6933) },
                    { 123, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6935), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6935) },
                    { 124, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6936), null, true, false, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6937) },
                    { 125, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6938), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6938) },
                    { 126, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6940), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6940) },
                    { 127, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6941), null, true, false, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6941) },
                    { 128, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6943), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6943) },
                    { 129, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6944), null, true, false, new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6945) },
                    { 130, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6946), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6946) },
                    { 131, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6948), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6948) },
                    { 132, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6949), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6949) },
                    { 133, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6951), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6951) },
                    { 134, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6952), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6952) },
                    { 135, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6954), null, true, false, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6954) },
                    { 136, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6955), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6955) },
                    { 137, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6972), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6972) },
                    { 138, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6973), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6974) },
                    { 139, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6975), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6975) },
                    { 140, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6976), null, true, false, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6977) },
                    { 141, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6978), null, true, false, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6978) },
                    { 142, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6979), null, true, false, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6980) },
                    { 143, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6981), null, true, false, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6981) },
                    { 144, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6983), null, true, false, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6983) },
                    { 145, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6984), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6984) },
                    { 146, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6986), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6986) },
                    { 147, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6987), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6988) },
                    { 148, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6989), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6989) },
                    { 149, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6990), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6991) },
                    { 150, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6992), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6992) },
                    { 151, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6994), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6994) },
                    { 152, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6995), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(6995) },
                    { 153, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7013), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7013) },
                    { 154, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7015), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7015) },
                    { 155, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7016), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7016) },
                    { 156, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7018), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7018) },
                    { 157, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7019), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7020) },
                    { 158, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7021), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7022) },
                    { 159, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7024), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7024) },
                    { 160, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7025), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7025) },
                    { 161, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7028), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7028) },
                    { 162, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7030), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7031) },
                    { 163, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7032), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7033) },
                    { 164, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7034), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7034) },
                    { 165, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7036), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7036) },
                    { 166, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7037), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7038) },
                    { 167, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7039), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7039) },
                    { 168, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7063), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7064) },
                    { 169, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7065), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7065) },
                    { 170, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7067), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7067) },
                    { 171, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7069), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7069) },
                    { 172, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7070), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7071) },
                    { 173, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7072), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7072) },
                    { 174, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7074), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7074) },
                    { 175, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7076), null, true, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7076) },
                    { 176, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7077), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7077) },
                    { 177, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7079), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7079) },
                    { 178, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7081), null, true, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7081) },
                    { 179, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7082), null, true, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7082) },
                    { 180, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7084), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7084) },
                    { 181, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7086), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7086) },
                    { 182, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7087), null, true, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7088) },
                    { 183, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7108), null, true, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7109) },
                    { 184, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7110), null, true, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7111) },
                    { 185, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7112), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7112) },
                    { 186, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7159), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7159) },
                    { 187, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7161), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7161) },
                    { 188, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7163), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7163) },
                    { 189, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7164), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7165) },
                    { 190, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7166), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7166) },
                    { 191, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7168), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7168) },
                    { 192, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7170), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7170) },
                    { 193, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7171), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7172) },
                    { 194, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7173), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7173) },
                    { 195, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7175), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7175) },
                    { 196, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7176), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7177) },
                    { 197, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7178), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7178) },
                    { 198, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7180), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7180) },
                    { 199, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7205), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7205) },
                    { 200, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7207), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7207) },
                    { 201, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7208), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7209) },
                    { 202, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7210), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7210) },
                    { 203, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7212), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7212) },
                    { 204, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7213), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7214) },
                    { 205, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7215), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7215) },
                    { 206, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7217), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7217) },
                    { 207, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7218), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7219) },
                    { 208, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7221), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7221) },
                    { 209, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7223), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7223) },
                    { 210, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7225), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7225) },
                    { 211, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7227), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7227) },
                    { 212, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7228), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7228) },
                    { 213, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7232), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7232) },
                    { 214, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7289), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7289) },
                    { 215, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7291), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7292) },
                    { 216, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7293), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7293) },
                    { 217, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7295), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7295) },
                    { 218, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7297), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7297) },
                    { 219, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7299), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7299) },
                    { 220, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7300), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7301) },
                    { 221, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7302), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7302) },
                    { 222, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7304), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7304) },
                    { 223, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7306), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7306) },
                    { 224, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7308), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7308) },
                    { 225, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7310), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7310) },
                    { 226, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7311), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7312) },
                    { 227, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7313), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7314) },
                    { 228, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7315), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7315) },
                    { 229, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7317), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7317) },
                    { 230, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7340), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 32, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7341) },
                    { 231, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7342), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7342) },
                    { 232, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7344), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7344) },
                    { 233, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7345), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7346) },
                    { 234, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7347), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7347) },
                    { 235, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7349), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7349) },
                    { 236, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7351), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7351) },
                    { 237, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7352), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7353) },
                    { 238, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7354), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7354) },
                    { 239, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7358), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7358) },
                    { 240, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7360), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7360) },
                    { 241, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7362), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7362) },
                    { 242, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7363), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7364) },
                    { 243, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7365), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7365) },
                    { 244, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7367), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7367) },
                    { 245, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7387), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7387) },
                    { 246, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7388), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7389) },
                    { 247, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7390), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7391) },
                    { 248, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7392), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7393) },
                    { 249, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7395), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7396) },
                    { 250, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7397), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7397) },
                    { 251, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7399), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7399) },
                    { 252, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7401), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7401) },
                    { 253, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7402), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7403) },
                    { 254, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7404), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7405) },
                    { 255, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7406), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7406) },
                    { 256, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7408), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7408) },
                    { 257, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7410), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7410) },
                    { 258, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7411), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7412) },
                    { 259, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7413), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7413) },
                    { 260, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7493), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7494) },
                    { 261, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7496), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7496) },
                    { 262, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7499), null, true, false, new DateTime(2014, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7499) },
                    { 263, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7501), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7501) },
                    { 264, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7502), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7503) },
                    { 265, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7504), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7504) },
                    { 266, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7506), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7506) },
                    { 267, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7507), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7508) },
                    { 268, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7509), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7509) },
                    { 269, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7511), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7511) },
                    { 270, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7513), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7513) },
                    { 271, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7516), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7516) },
                    { 272, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7518), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7518) },
                    { 273, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7519), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7520) },
                    { 274, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7521), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7521) },
                    { 275, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7523), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7523) },
                    { 276, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7545), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7545) },
                    { 277, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7547), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7547) },
                    { 278, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7548), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7549) },
                    { 279, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7550), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7551) },
                    { 280, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7552), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7552) },
                    { 281, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7554), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7554) },
                    { 282, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7556), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7556) },
                    { 283, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7558), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7558) },
                    { 284, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7559), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7560) },
                    { 285, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7561), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7561) },
                    { 286, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7563), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7564) },
                    { 287, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7565), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7565) },
                    { 288, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7567), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7567) },
                    { 289, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7569), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7570) },
                    { 290, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7571), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7571) },
                    { 291, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7620), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7621) },
                    { 292, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7622), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7623) },
                    { 293, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7624), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7624) },
                    { 294, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7626), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7626) },
                    { 295, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7628), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7629) },
                    { 296, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7630), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7630) },
                    { 297, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7632), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7632) },
                    { 298, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7633), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7634) },
                    { 299, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7635), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7635) },
                    { 300, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7637), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7637) },
                    { 301, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7638), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7639) },
                    { 302, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7641), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7641) },
                    { 303, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7643), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7643) },
                    { 304, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7644), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7645) },
                    { 305, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7646), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7646) },
                    { 306, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7648), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7649) },
                    { 307, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7682), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7682) },
                    { 308, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7684), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7684) },
                    { 309, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7685), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7686) },
                    { 310, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7687), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7687) },
                    { 311, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7689), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7689) },
                    { 312, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7693), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7694) },
                    { 313, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7695), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7696) },
                    { 314, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7697), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7697) },
                    { 315, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7699), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7700) },
                    { 316, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7701), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7702) },
                    { 317, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7703), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7703) },
                    { 318, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7705), null, true, false, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7706) },
                    { 319, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7708), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7708) },
                    { 320, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7710), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7711) },
                    { 321, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7713), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7713) },
                    { 322, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7737), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7738) },
                    { 323, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7741), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7742) },
                    { 324, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7744), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7745) },
                    { 325, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7748), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7749) },
                    { 326, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7751), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7752) },
                    { 327, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7756), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7756) },
                    { 328, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7759), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7760) },
                    { 329, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7761), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7761) },
                    { 330, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7763), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7763) },
                    { 331, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7765), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7765) },
                    { 332, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7766), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7766) },
                    { 333, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7858), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7858) },
                    { 334, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7860), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7861) },
                    { 335, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7862), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7862) },
                    { 336, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7864), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7864) },
                    { 337, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7889), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7889) },
                    { 338, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7891), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7891) },
                    { 339, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7892), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7893) },
                    { 340, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7894), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7895) },
                    { 341, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7896), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7896) },
                    { 342, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7898), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7898) },
                    { 343, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7899), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7900) },
                    { 344, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7901), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7901) },
                    { 345, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7903), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7903) },
                    { 346, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7904), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7905) },
                    { 347, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7906), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 32, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7906) },
                    { 348, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7908), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7908) },
                    { 349, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7910), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7910) },
                    { 350, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7911), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7912) },
                    { 351, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7913), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7914) },
                    { 352, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7915), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7915) },
                    { 353, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7942), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7942) },
                    { 354, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7944), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7944) },
                    { 355, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7946), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7946) },
                    { 356, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7948), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7948) },
                    { 357, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7950), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7950) },
                    { 358, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7952), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7953) },
                    { 359, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7954), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7955) },
                    { 360, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7956), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7956) },
                    { 361, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7958), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7958) },
                    { 362, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7960), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7960) },
                    { 363, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7961), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7962) },
                    { 364, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7964), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7964) },
                    { 365, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7966), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7966) },
                    { 366, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7967), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7968) },
                    { 367, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7969), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7969) },
                    { 368, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7992), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7992) },
                    { 369, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7994), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7994) },
                    { 370, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7996), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7997) },
                    { 371, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7998), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(7998) },
                    { 372, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8000), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8000) },
                    { 373, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8005), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8005) },
                    { 374, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8007), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8007) },
                    { 375, 13, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8008), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8009) },
                    { 376, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8010), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8010) },
                    { 377, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8012), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8012) },
                    { 378, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8014), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8014) },
                    { 379, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8015), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8016) },
                    { 380, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8017), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8017) },
                    { 381, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8019), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8019) },
                    { 382, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8020), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8021) },
                    { 383, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8023), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8023) },
                    { 384, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8048), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8048) },
                    { 385, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8050), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8051) },
                    { 386, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8052), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8052) },
                    { 387, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8054), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8054) },
                    { 388, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8055), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8056) },
                    { 389, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8058), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8058) },
                    { 390, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8059), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8060) },
                    { 391, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8061), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8061) },
                    { 392, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8063), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8063) },
                    { 393, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8064), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8064) },
                    { 394, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8066), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8066) },
                    { 395, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8068), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8068) },
                    { 396, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8070), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8070) },
                    { 397, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8073), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8074) },
                    { 398, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8075), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8075) },
                    { 399, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8096), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8096) },
                    { 400, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8097), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8098) },
                    { 401, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8099), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8099) },
                    { 402, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8101), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8101) },
                    { 403, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8103), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8103) },
                    { 404, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8190), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8190) },
                    { 405, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8192), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8193) },
                    { 406, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8194), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8195) },
                    { 407, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8196), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8196) },
                    { 408, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8198), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8199) },
                    { 409, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8200), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8201) },
                    { 410, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8202), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8203) },
                    { 411, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8204), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8205) },
                    { 412, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8206), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8206) },
                    { 413, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8208), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8208) },
                    { 414, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8235), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8235) },
                    { 415, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8239), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8239) },
                    { 416, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8241), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8241) },
                    { 417, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8243), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8243) },
                    { 418, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8245), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8245) },
                    { 419, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8246), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8247) },
                    { 420, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8248), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8248) },
                    { 421, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8251), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8251) },
                    { 422, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8253), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8253) },
                    { 423, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8255), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8255) },
                    { 424, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8256), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8257) },
                    { 425, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8258), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8258) },
                    { 426, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8261), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8261) },
                    { 427, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8262), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8263) },
                    { 428, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8264), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8265) },
                    { 429, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8266), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8266) },
                    { 430, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8289), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8289) },
                    { 431, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8291), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8291) },
                    { 432, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8294), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8294) },
                    { 433, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8296), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8296) },
                    { 434, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8297), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8298) },
                    { 435, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8300), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8300) },
                    { 436, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8301), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8302) },
                    { 437, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8303), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8304) },
                    { 438, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8305), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8305) },
                    { 439, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8307), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8307) },
                    { 440, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8308), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8309) },
                    { 441, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8310), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8310) },
                    { 442, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8312), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8312) },
                    { 443, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8318), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8318) },
                    { 444, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8320), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8320) },
                    { 445, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8343), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8343) },
                    { 446, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8345), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8345) },
                    { 447, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8347), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8347) },
                    { 448, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8348), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8349) },
                    { 449, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8350), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8350) },
                    { 450, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8352), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8352) },
                    { 451, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8354), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8354) },
                    { 452, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8356), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8356) },
                    { 453, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8358), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8358) },
                    { 454, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8360), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8360) },
                    { 455, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8362), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8362) },
                    { 456, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8364), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8364) },
                    { 457, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8366), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8366) },
                    { 458, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8367), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8368) },
                    { 459, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8369), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8369) },
                    { 460, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8371), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8371) },
                    { 461, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8397), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8398) },
                    { 462, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8400), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8400) },
                    { 463, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8402), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8402) },
                    { 464, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8406), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8406) },
                    { 465, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8408), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8408) },
                    { 466, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8409), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8410) },
                    { 467, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8412), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8413) },
                    { 468, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8414), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8414) },
                    { 469, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8416), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8416) },
                    { 470, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8418), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8418) },
                    { 471, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8420), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8420) },
                    { 472, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8422), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8422) },
                    { 473, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8424), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8424) },
                    { 474, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8425), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8426) },
                    { 475, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8427), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8428) },
                    { 476, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8450), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8451) },
                    { 477, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8522), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8523) },
                    { 478, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8525), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8525) },
                    { 479, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8527), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8527) },
                    { 480, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8529), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8529) },
                    { 481, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8530), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8531) },
                    { 482, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8533), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8533) },
                    { 483, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8535), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8535) },
                    { 484, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8537), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8537) },
                    { 485, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8539), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8539) },
                    { 486, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8540), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8541) },
                    { 487, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8542), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8542) },
                    { 488, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8546), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8546) },
                    { 489, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8548), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8549) },
                    { 490, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8553), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8553) },
                    { 491, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8574), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8575) },
                    { 492, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8576), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8577) },
                    { 493, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8578), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8578) },
                    { 494, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8580), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8580) },
                    { 495, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8581), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8582) },
                    { 496, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8583), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8583) },
                    { 497, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8585), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8585) },
                    { 498, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8587), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8587) },
                    { 499, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8589), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8590) },
                    { 500, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8591), null, true, false, new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8592) },
                    { 501, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8593), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8594) },
                    { 502, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8596), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8596) },
                    { 503, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8598), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8598) },
                    { 504, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8599), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8599) },
                    { 505, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8601), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8601) },
                    { 506, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8603), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8603) },
                    { 507, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8625), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8625) },
                    { 508, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8631), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8631) },
                    { 509, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8633), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 32, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8633) },
                    { 510, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8635), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8635) },
                    { 511, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8637), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8637) },
                    { 512, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8639), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8639) },
                    { 513, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8640), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8641) },
                    { 514, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8642), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8642) },
                    { 515, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8644), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8645) },
                    { 516, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8646), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8646) },
                    { 517, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8648), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8648) },
                    { 518, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8649), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8650) },
                    { 519, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8651), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8651) },
                    { 520, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8653), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8653) },
                    { 521, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8655), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8655) },
                    { 522, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8680), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8680) },
                    { 523, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8682), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8682) },
                    { 524, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8683), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8684) },
                    { 525, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8685), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8686) },
                    { 526, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8687), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8687) },
                    { 527, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8689), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8689) },
                    { 528, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8690), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8691) },
                    { 529, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8693), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8693) },
                    { 530, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8695), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8695) },
                    { 531, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8697), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8697) },
                    { 532, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8699), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8699) },
                    { 533, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8700), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8701) },
                    { 534, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8702), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8702) },
                    { 535, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8704), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8704) },
                    { 536, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8709), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8709) },
                    { 537, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8711), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8711) },
                    { 538, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8731), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8732) },
                    { 539, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8734), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8734) },
                    { 540, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8735), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8735) },
                    { 541, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8737), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8737) },
                    { 542, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8739), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8739) },
                    { 543, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8740), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8741) },
                    { 544, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8742), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8742) },
                    { 545, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8744), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8744) },
                    { 546, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8745), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8746) },
                    { 547, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8747), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8747) },
                    { 548, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8749), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8749) },
                    { 549, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8751), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8751) },
                    { 550, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8806), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8806) },
                    { 551, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8808), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8808) },
                    { 552, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8810), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8810) },
                    { 553, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8831), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8832) },
                    { 554, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8833), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8834) },
                    { 555, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8835), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8836) },
                    { 556, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8838), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8838) },
                    { 557, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8839), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8840) },
                    { 558, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8850), null, true, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8850) },
                    { 559, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8852), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8852) },
                    { 560, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8854), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8854) },
                    { 561, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8856), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8856) },
                    { 562, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8857), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8857) },
                    { 563, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8865), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8866) },
                    { 564, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8868), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8869) },
                    { 565, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8870), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8870) },
                    { 566, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8872), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8872) },
                    { 567, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8874), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8874) },
                    { 568, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8877), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8877) },
                    { 569, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8879), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8879) },
                    { 570, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8881), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8881) },
                    { 571, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8882), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8883) },
                    { 572, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8884), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8885) },
                    { 573, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8886), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8886) },
                    { 574, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8888), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8888) },
                    { 575, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8890), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8890) },
                    { 576, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8892), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8892) },
                    { 577, 21, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8893), null, true, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 8, 4, 16, 41, 23, 96, DateTimeKind.Utc).AddTicks(8894) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 27, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 29, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 30, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 31, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 32, 1 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 33, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 34, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 35, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 36, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 37, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 38, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 39, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 40, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 41, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 42, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 43, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 44, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 45, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 46, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 47, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 48, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 49, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 50, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 51, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 52, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 53, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 54, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 55, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 56, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 57, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 58, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 59, 2 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 60, 3 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 61, 3 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 62, 3 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 63, 3 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 64, 3 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 65, 3 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 66, 3 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 67, 3 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 68, 3 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 69, 3 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 70, 3 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 71, 3 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 72, 3 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 73, 3 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 74, 3 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 75, 3 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 76, 3 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 77, 3 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 78, 3 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 79, 3 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 80, 3 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 81, 3 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 82, 3 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 83, 3 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 84, 3 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 85, 3 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 86, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 87, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 88, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 89, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 90, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 91, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 92, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 93, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 94, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 95, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 96, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 97, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 98, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 99, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 100, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 101, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 102, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 103, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 104, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 105, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 106, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 107, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 108, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 109, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 110, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 111, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 112, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 113, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 114, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 115, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 116, 4 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 117, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 118, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 119, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 120, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 121, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 122, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 123, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 124, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 125, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 126, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 127, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 128, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 129, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 130, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 131, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 132, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 133, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 134, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 135, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 136, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 137, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 138, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 139, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 140, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 141, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 142, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 143, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 144, 5 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 145, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 146, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 147, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 148, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 149, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 150, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 151, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 152, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 153, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 154, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 155, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 156, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 157, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 158, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 159, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 160, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 161, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 162, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 163, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 164, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 165, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 166, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 167, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 168, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 169, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 170, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 171, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 172, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 173, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 174, 6 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 175, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 176, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 177, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 178, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 179, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 180, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 181, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 182, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 183, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 184, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 185, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 186, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 187, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 188, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 189, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 190, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 191, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 192, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 193, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 194, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 195, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 196, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 197, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 198, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 199, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 200, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 201, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 202, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 203, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 204, 7 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 205, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 206, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 207, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 208, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 209, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 210, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 211, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 212, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 213, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 214, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 215, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 216, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 217, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 218, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 219, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 220, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 221, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 222, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 223, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 224, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 225, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 226, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 227, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 228, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 229, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 230, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 231, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 232, 8 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 233, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 234, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 235, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 236, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 237, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 238, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 239, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 240, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 241, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 242, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 243, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 244, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 245, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 246, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 247, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 248, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 249, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 250, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 251, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 252, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 253, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 254, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 255, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 256, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 257, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 258, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 259, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 260, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 261, 9 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 262, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 263, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 264, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 265, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 266, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 267, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 268, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 269, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 270, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 271, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 272, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 273, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 274, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 275, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 276, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 277, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 278, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 279, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 280, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 281, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 282, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 283, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 284, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 285, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 286, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 287, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 288, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 289, 10 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 290, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 291, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 292, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 293, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 294, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 295, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 296, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 297, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 298, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 299, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 300, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 301, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 302, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 303, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 304, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 305, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 306, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 307, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 308, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 309, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 310, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 311, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 312, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 313, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 314, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 315, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 316, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 317, 11 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 318, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 319, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 320, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 321, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 322, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 323, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 324, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 325, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 326, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 327, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 328, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 329, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 330, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 331, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 332, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 333, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 334, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 335, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 336, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 337, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 338, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 339, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 340, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 341, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 342, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 343, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 344, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 345, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 346, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 347, 12 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 348, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 349, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 350, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 351, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 352, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 353, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 354, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 355, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 356, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 357, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 358, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 359, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 360, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 361, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 362, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 363, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 364, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 365, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 366, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 367, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 368, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 369, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 370, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 371, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 372, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 373, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 374, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 375, 13 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 376, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 377, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 378, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 379, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 380, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 381, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 382, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 383, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 384, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 385, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 386, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 387, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 388, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 389, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 390, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 391, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 392, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 393, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 394, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 395, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 396, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 397, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 398, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 399, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 400, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 401, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 402, 14 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 403, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 404, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 405, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 406, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 407, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 408, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 409, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 410, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 411, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 412, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 413, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 414, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 415, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 416, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 417, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 418, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 419, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 420, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 421, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 422, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 423, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 424, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 425, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 426, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 427, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 428, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 429, 15 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 430, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 431, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 432, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 433, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 434, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 435, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 436, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 437, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 438, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 439, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 440, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 441, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 442, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 443, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 444, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 445, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 446, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 447, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 448, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 449, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 450, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 451, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 452, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 453, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 454, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 455, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 456, 16 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 457, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 458, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 459, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 460, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 461, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 462, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 463, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 464, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 465, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 466, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 467, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 468, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 469, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 470, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 471, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 472, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 473, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 474, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 475, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 476, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 477, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 478, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 479, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 480, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 481, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 482, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 483, 17 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 484, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 485, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 486, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 487, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 488, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 489, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 490, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 491, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 492, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 493, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 494, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 495, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 496, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 497, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 498, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 499, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 500, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 501, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 502, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 503, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 504, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 505, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 506, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 507, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 508, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 509, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 510, 18 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 511, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 512, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 513, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 514, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 515, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 516, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 517, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 518, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 519, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 520, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 521, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 522, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 523, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 524, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 525, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 526, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 527, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 528, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 529, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 530, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 531, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 532, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 533, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 534, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 535, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 536, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 537, 19 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 538, 20 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 539, 20 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 540, 20 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 541, 20 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 542, 20 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 543, 20 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 544, 20 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 545, 20 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 546, 20 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 547, 20 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 548, 20 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 549, 20 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 550, 20 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 551, 20 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 552, 20 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 553, 20 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 554, 20 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 555, 20 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 556, 20 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 557, 20 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 558, 21 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 559, 21 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 560, 21 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 561, 21 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 562, 21 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 563, 21 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 564, 21 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 565, 21 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 566, 21 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 567, 21 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 568, 21 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 569, 21 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 570, 21 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 571, 21 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 572, 21 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 573, 21 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 574, 21 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 575, 21 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 576, 21 });

            migrationBuilder.DeleteData(
                table: "TeamPlayer",
                keyColumns: new[] { "PlayerId", "TeamId" },
                keyValues: new object[] { 577, 21 });

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 22);
        }
    }
}
