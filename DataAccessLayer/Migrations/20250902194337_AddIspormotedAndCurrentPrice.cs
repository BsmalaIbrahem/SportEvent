using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddIspormotedAndCurrentPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "CurrentPrice",
                table: "Tickets",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "IsPromoted",
                table: "Tickets",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PriceUpdatedAt",
                table: "Tickets",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Coaches",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "ImageUrl", "IsActive", "IsDeleted", "Name", "Nationality", "UpdatedAt", "isBigMatch", "isSold" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(2346), null, "Head coach since May 29, 2025", "Jose_Riveiro.jpg", true, false, "José Riveiro", "Spain", new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(2350), false, false },
                    { 2, new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4671), null, "Head coach since February 2024", "Jose_Gomes.jpg", true, false, "José Gomes", "Portugal", new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4671), false, false },
                    { 3, new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4674), null, "Head coach since February 2024", "Krunoslav_Jurcic.jpg", true, false, "Krunoslav Jurcic", "Croatia", new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4674), false, false },
                    { 4, new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4676), null, "Head coach since July 2025", "Nabil_Kouki.jpg", true, false, "Nabil Kouki", "Tunisia", new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4676), false, false },
                    { 5, new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4677), null, "Head coach since February 2025", "Ali_Maher.jpg", true, false, "Ali Maher", "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4678), false, false },
                    { 6, new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4679), null, "Head coach since July 2025", "Khaled_Eid.jpg", true, false, "Khaled Eid", "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4679), false, false },
                    { 7, new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4681), null, "Head coach since July 2025", "Ahmed_El_Agouz.jpg", true, false, "Ahmed El Agouz", "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4681), false, false },
                    { 8, new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4717), null, "Head coach since July 2024", "Magdy_Abdel_Ati.jpg", true, false, "Magdy Abdel Ati", "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4718), false, false },
                    { 9, new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4719), null, "Head coach since July 2024", "Sayed_Yassin.jpg", true, false, "Sayed Yassin", "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4719), false, false },
                    { 10, new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4720), null, "Head coach from January 2023 to April 2025", "Ahmed_Samy.jpg", true, false, "Ahmed Samy", "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4720), false, false },
                    { 11, new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4722), null, "Head coach from April 2025 to June 2025 and post-June 2025", "Ahmed_Abdelaziz.jpg", true, false, "Ahmed Abdelaziz", "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4722), false, false },
                    { 12, new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4723), null, "Head coach since July 2024", "Abdelhamid_Bassiouni.jpg", true, false, "Abdelhamid Bassiouni", "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4723), false, false },
                    { 13, new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4725), null, "Head coach since July 2024", "Ahmed_Koshary.jpg", true, false, "Ahmed Koshary", "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4725), false, false },
                    { 14, new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4726), null, "Head coach since July 2024", "Mohamed_Mekky.jpg", true, false, "Mohamed Mekky", "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4727), false, false },
                    { 15, new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4728), null, "Head coach since July 2024", "Sayed_Eid.jpg", true, false, "Sayed Eid", "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4728), false, false },
                    { 16, new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4729), null, "Head coach since January 2025", "Hossam_Hassan.jpg", true, false, "Hossam Hassan", "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4729), false, false },
                    { 17, new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4730), null, "Head coach since January 2025", "Ehab_Galal.jpg", true, false, "Ehab Galal", "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4731), false, false },
                    { 18, new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4732), null, "Head coach since November 2024", "Alaa_Abdel_Aal.jpg", true, false, "Alaa Abdel Aal", "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4732), false, false },
                    { 19, new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4733), null, "Head coach since July 2024", "Ahmed_Khaled.jpg", true, false, "Ahmed Khaled", "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4733), false, false },
                    { 20, new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4870), null, "Head coach since July 2024", "Mohamed_Ouda.jpg", true, false, "Mohamed Ouda", "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4870), false, false },
                    { 21, new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4872), null, "Head coach since July 2024", "Igor_Tolic.jpg", true, false, "Igor Tolic", "Croatia", new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4872), false, false },
                    { 22, new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4873), null, "Head coach since July 2024", "Amr_Abdel_Salam.jpg", true, false, "Amr Abdel Salam", "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 78, DateTimeKind.Utc).AddTicks(4873), false, false }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "DeletedAt", "Description", "ImgPath", "IsActive", "IsDeleted", "Name", "Nationality", "Position", "UpdatedAt", "isBigMatch", "isSold" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(3722), new DateTime(1988, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Shenawy.jpg", true, false, "Mohamed El Shenawy", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(3724), false, false },
                    { 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7539), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Oufa_Shobeir.jpg", true, false, "Oufa Shobeir", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7540), false, false },
                    { 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7544), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Seha.jpg", true, false, "Mohamed Seha", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7544), false, false },
                    { 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7546), new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Makhlouf.jpg", true, false, "Mostafa Makhlouf", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7547), false, false },
                    { 5, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7574), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Achraf_Dari.jpg", true, false, "Achraf Dari", "Morocco", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7575), false, false },
                    { 6, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7576), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Ramadan.jpg", true, false, "Ahmed Ramadan", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7577), false, false },
                    { 7, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7578), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_El_Aash.jpg", true, false, "Mostafa El Aash", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7579), false, false },
                    { 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7581), new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Yasser_Ibrahim.jpg", true, false, "Yasser Ibrahim", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7581), false, false },
                    { 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7583), new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Yassin_Marei.jpg", true, false, "Yassin Marei", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7583), false, false },
                    { 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7585), new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Abdin.jpg", true, false, "Ahmed Abdin", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7585), false, false },
                    { 11, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7587), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Shokry.jpg", true, false, "Mohamed Shokry", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7588), false, false },
                    { 12, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7589), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Hany.jpg", true, false, "Mohamed Hany", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7589), false, false },
                    { 13, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7591), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Omar_Kamal.jpg", true, false, "Omar Kamal", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7592), false, false },
                    { 14, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7593), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Aliou_Dieng.jpg", true, false, "Aliou Dieng", "Mali", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7593), false, false },
                    { 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7596), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Marwan_Ateya.jpg", true, false, "Marwan Ateya", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7596), false, false },
                    { 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7598), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Kouka.jpg", true, false, "Ahmed Kouka", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7598), false, false },
                    { 17, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7667), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Reda.jpg", true, false, "Ahmed Reda", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7667), false, false },
                    { 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7686), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Emam_Ashour.jpg", true, false, "Emam Ashour", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7686), false, false },
                    { 19, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7688), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Ali_Ben_Romdhane.jpg", true, false, "Mohamed Ali Ben Romdhane", "Tunisia", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7688), false, false },
                    { 20, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7690), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Afsha.jpg", true, false, "Afsha", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7690), false, false },
                    { 21, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7692), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Trezeguet.jpg", true, false, "Mahmoud Trezeguet", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7692), false, false },
                    { 22, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7694), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Achraf_Bencharki.jpg", true, false, "Achraf Bencharki", "Morocco", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7694), false, false },
                    { 23, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7696), new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hussein_El_Shahat.jpg", true, false, "Hussein El Shahat", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7696), false, false },
                    { 24, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7698), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Abdelkader.jpg", true, false, "Ahmed Abdelkader", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7698), false, false },
                    { 25, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7700), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Zizo.jpg", true, false, "Zizo", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7700), false, false },
                    { 26, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7702), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Reda_Slim.jpg", true, false, "Reda Slim", "Morocco", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7702), false, false },
                    { 27, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7704), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Taher_Mohamed.jpg", true, false, "Taher Mohamed", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7704), false, false },
                    { 28, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7706), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Karim_Fouad.jpg", true, false, "Karim Fouad", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7706), false, false },
                    { 29, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7708), new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Abdallah.jpg", true, false, "Mohamed Abdallah", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7709), false, false },
                    { 30, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7710), new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Nejc_Gradisar.jpg", true, false, "Nejc Gradisar", "Slovenia", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7711), false, false },
                    { 31, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7712), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Sherif.jpg", true, false, "Mohamed Sherif", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7713), false, false },
                    { 32, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7730), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Yasser.jpg", true, false, "Mohamed Yasser", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7731), false, false },
                    { 33, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7732), new DateTime(1999, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Sobhi.jpg", true, false, "Mohamed Sobhi", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7733), false, false },
                    { 34, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7734), new DateTime(1992, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Awad.jpg", true, false, "Mohamed Awad", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7735), false, false },
                    { 35, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7736), new DateTime(2004, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_Nafad.jpg", true, false, "Abdelrahman Nafad", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7737), false, false },
                    { 36, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7738), new DateTime(1992, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hamza_Mathlouthi.jpg", true, false, "Hamza Mathlouthi", "Tunisia", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7739), false, false },
                    { 37, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7740), new DateTime(2001, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hossam_Abdelmaguid.jpg", true, false, "Hossam Abdelmaguid", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7741), false, false },
                    { 38, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7742), new DateTime(1999, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_El_Zenary.jpg", true, false, "Mostafa El Zenary", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7743), false, false },
                    { 39, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7744), new DateTime(2003, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Esho.jpg", true, false, "Ahmed Esho", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7745), false, false },
                    { 40, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7746), new DateTime(1992, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Omar_Gaber.jpg", true, false, "Omar Gaber", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7747), false, false },
                    { 41, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7748), new DateTime(1998, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Fatouh.jpg", true, false, "Ahmed Fatouh", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7749), false, false },
                    { 42, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7750), new DateTime(2001, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Shehata.jpg", true, false, "Mohamed Shehata", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7750), false, false },
                    { 43, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7752), new DateTime(1996, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Nabil_Emad_Dunga.jpg", true, false, "Nabil Emad Dunga", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7753), false, false },
                    { 44, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7754), new DateTime(1999, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Seif_Gaafar.jpg", true, false, "Seif Gaafar", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7755), false, false },
                    { 45, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7756), new DateTime(1998, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Hamdi.jpg", true, false, "Ahmed Hamdi", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7757), false, false },
                    { 46, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7775), new DateTime(1994, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Shalaby.jpg", true, false, "Mostafa Shalaby", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7775), false, false },
                    { 47, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7776), new DateTime(1986, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Shikabala.jpg", true, false, "Shikabala", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7777), false, false },
                    { 48, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7778), new DateTime(1996, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Sayed_Zizo.jpg", true, false, "Ahmed Sayed Zizo", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7779), false, false },
                    { 49, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7780), new DateTime(1995, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_El_Wensh.jpg", true, false, "Mahmoud El Wensh", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7781), false, false },
                    { 50, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7782), new DateTime(1985, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Abdelshafi.jpg", true, false, "Mohamed Abdelshafi", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7783), false, false },
                    { 51, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7784), new DateTime(1985, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdallah_El_Said.jpg", true, false, "Abdallah El Said", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7785), false, false },
                    { 52, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7786), new DateTime(1997, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Nasser_Maher.jpg", true, false, "Nasser Maher", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7787), false, false },
                    { 53, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7788), new DateTime(2002, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Atef.jpg", true, false, "Mohamed Atef", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7789), false, false },
                    { 54, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7790), new DateTime(1993, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Seifeddine_Jaziri.jpg", true, false, "Seifeddine Jaziri", "Tunisia", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7791), false, false },
                    { 55, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7792), new DateTime(1997, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Nasser_Mansi.jpg", true, false, "Nasser Mansi", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7792), false, false },
                    { 56, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7794), new DateTime(1999, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amr_Nasser.jpg", true, false, "Amr Nasser", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7794), false, false },
                    { 57, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7796), new DateTime(1998, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Chico_Banza.jpg", true, false, "Chico Banza", "Angola", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7796), false, false },
                    { 58, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7798), new DateTime(2003, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Abdel_Rahim.jpg", true, false, "Ahmed Abdel Rahim", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7798), false, false },
                    { 59, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7800), new DateTime(2003, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Hamdi_Ibrahim.jpg", true, false, "Mohamed Hamdi Ibrahim", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7800), false, false },
                    { 60, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7818), new DateTime(1991, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Shenawy.jpg", true, false, "Ahmed El Shenawy", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7819), false, false },
                    { 61, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7820), new DateTime(1983, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Sherif_Ekramy.jpg", true, false, "Sherif Ekramy", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7821), false, false },
                    { 62, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7822), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Youssef_Nader.jpg", true, false, "Youssef Nader", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7823), false, false },
                    { 63, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7824), new DateTime(1993, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Chibi.jpg", true, false, "Mohamed Chibi", "Morocco", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7825), false, false },
                    { 64, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7826), new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Samy.jpg", true, false, "Ahmed Samy", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7826), false, false },
                    { 65, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7828), new DateTime(1989, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ali_Gabr.jpg", true, false, "Ali Gabr", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7829), false, false },
                    { 66, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7830), new DateTime(1998, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Marie.jpg", true, false, "Mahmoud Marie", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7830), false, false },
                    { 67, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7832), new DateTime(1996, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Karim_Hafez.jpg", true, false, "Karim Hafez", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7832), false, false },
                    { 68, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7834), new DateTime(1995, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Hamdi.jpg", true, false, "Mohamed Hamdi", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7834), false, false },
                    { 69, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7836), new DateTime(1991, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Tawfik.jpg", true, false, "Ahmed Tawfik", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7836), false, false },
                    { 70, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7838), new DateTime(1994, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ibrahim_Blati_Toure.jpg", true, false, "Ibrahim Blati Touré", "Burkina Faso", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7838), false, false },
                    { 71, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7877), new DateTime(1995, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohanad_Lasheen.jpg", true, false, "Mohanad Lasheen", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7877), false, false },
                    { 72, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7879), new DateTime(1992, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Abdul_Aati_Dunga.jpg", true, false, "Mahmoud Abdul Aati Dunga", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7879), false, false },
                    { 73, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7897), new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Tarek_Alaa.jpg", true, false, "Tarek Alaa", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7897), false, false },
                    { 74, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7899), new DateTime(1994, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Fathi.jpg", true, false, "Mostafa Fathi", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7899), false, false },
                    { 75, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7901), new DateTime(1997, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ramadan_Sobhi.jpg", true, false, "Ramadan Sobhi", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7901), false, false },
                    { 76, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7903), new DateTime(2001, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ibrahim_Adel.jpg", true, false, "Ibrahim Adel", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7903), false, false },
                    { 77, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7905), new DateTime(1995, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Youssef_Obama.jpg", true, false, "Youssef Obama", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7905), false, false },
                    { 78, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7907), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Zalaka.jpg", true, false, "Mahmoud Zalaka", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7907), false, false },
                    { 79, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7909), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdel_Rahman_Magdi.jpg", true, false, "Abdel Rahman Magdi", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7909), false, false },
                    { 80, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7911), new DateTime(1994, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Fiston_Mayele.jpg", true, false, "Fiston Mayele", "DR Congo", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7911), false, false },
                    { 81, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7913), new DateTime(1996, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Marwan_Hamdy.jpg", true, false, "Marwan Hamdy", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7913), false, false },
                    { 82, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7915), new DateTime(1987, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Gabas.jpg", true, false, "Mohamed El Gabas", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7915), false, false },
                    { 83, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7917), new DateTime(1991, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Fakhreddine_Ben_Youssef.jpg", true, false, "Fakhreddine Ben Youssef", "Tunisia", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7917), false, false },
                    { 84, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7919), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Dodo_El_Gabbas.jpg", true, false, "Dodo El Gabbas", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7919), false, false },
                    { 85, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7921), new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Youssef_Shousha.jpg", true, false, "Youssef Shousha", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7921), false, false },
                    { 86, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7922), new DateTime(1997, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Injured: Cruciate ligament tear", "Essam_Tharwat.jpg", true, false, "Essam Tharwat", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7923), false, false },
                    { 87, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7940), new DateTime(1993, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Hamdy.jpg", true, false, "Mahmoud Hamdy", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7940), false, false },
                    { 88, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7942), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Shehata.jpg", true, false, "Mohamed Shehata", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7942), false, false },
                    { 89, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7944), new DateTime(1994, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Injured: Cruciate ligament tear", "Ahmed_Ayman_Mansour.jpg", true, false, "Ahmed Ayman Mansour", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7944), false, false },
                    { 90, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7946), new DateTime(1996, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Baher_El_Mohamady.jpg", true, false, "Baher El Mohamady", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7946), false, false },
                    { 91, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7949), new DateTime(1999, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Tarek.jpg", true, false, "Mohamed Tarek", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7949), false, false },
                    { 92, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7951), new DateTime(1994, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hossam_Hassan.jpg", true, false, "Hossam Hassan", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7951), false, false },
                    { 93, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7953), new DateTime(2002, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Islam_El_Mizzayn.jpg", true, false, "Islam El Mizzayn", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7953), false, false },
                    { 94, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7955), new DateTime(1998, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Karim_El_Eraki.jpg", true, false, "Karim El Eraki", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7955), false, false },
                    { 95, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7957), new DateTime(1991, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hussein_El_Sayed.jpg", true, false, "Hussein El Sayed", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7957), false, false },
                    { 96, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7958), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Eid.jpg", true, false, "Ahmed Eid", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7959), false, false },
                    { 97, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7961), new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ehab_El_Aidy.jpg", true, false, "Ehab El Aidy", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7961), false, false },
                    { 98, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7962), new DateTime(2001, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Saber.jpg", true, false, "Mahmoud Saber", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7963), false, false },
                    { 99, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7965), new DateTime(1988, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amr_Moussa.jpg", true, false, "Amr Moussa", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7965), false, false },
                    { 100, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7967), new DateTime(1997, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Youssef_El_Gohary.jpg", true, false, "Youssef El Gohary", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7967), false, false },
                    { 101, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7985), new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Moaz_Mosaad.jpg", true, false, "Moaz Mosaad", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7985), false, false },
                    { 102, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7987), new DateTime(2005, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Listowell_Amankona.jpg", true, false, "Listowell Amankona", "Ghana", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7987), false, false },
                    { 103, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7989), new DateTime(1994, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Hamada.jpg", true, false, "Mahmoud Hamada", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7989), false, false },
                    { 104, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7991), new DateTime(1992, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Injured: Foot surgery", "Mido_Gaber.jpg", true, false, "Mido Gaber", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7991), false, false },
                    { 105, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7993), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Injured: Cruciate ligament tear", "Mohamed_El_Shami.jpg", true, false, "Mohamed El Shami", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7993), false, false },
                    { 106, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7995), new DateTime(1991, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Fakhreddine_Ben_Youssef.jpg", true, false, "Fakhreddine Ben Youssef", "Tunisia", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7995), false, false },
                    { 107, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7997), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hossam_Greisha.jpg", true, false, "Hossam Greisha", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7997), false, false },
                    { 108, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7999), new DateTime(1998, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abderrahim_Deghmoum.jpg", true, false, "Abderrahim Deghmoum", "Algeria", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(7999), false, false },
                    { 109, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8001), new DateTime(1994, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Saleh_Chihadeh.jpg", true, false, "Saleh Chihadeh", "Palestine", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8001), false, false },
                    { 110, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8003), new DateTime(2001, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Franck_Etouga.jpg", true, false, "Franck Etouga", "Cameroon", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8003), false, false },
                    { 111, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8005), new DateTime(1999, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Abdel_Samia.jpg", true, false, "Mohamed Abdel Samia", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8005), false, false },
                    { 112, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8007), new DateTime(1990, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Fakih.jpg", true, false, "Mohamed El Fakih", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8007), false, false },
                    { 113, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8008), new DateTime(1999, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdo_Yahia.jpg", true, false, "Abdo Yahia", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8009), false, false },
                    { 114, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8010), new DateTime(1992, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Sheikh.jpg", true, false, "Ahmed El Sheikh", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8011), false, false },
                    { 115, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8029), new DateTime(1998, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Islam_Ateya.jpg", true, false, "Islam Ateya", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8029), false, false },
                    { 116, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8031), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Abou_Gouda.jpg", true, false, "Mahmoud Abou Gouda", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8031), false, false },
                    { 117, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8033), new DateTime(1990, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Bassam.jpg", true, false, "Mohamed Bassam", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8033), false, false },
                    { 118, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8035), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ali_El_Gabry.jpg", true, false, "Ali El Gabry", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8035), false, false },
                    { 119, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8037), new DateTime(1997, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amer_Amer.jpg", true, false, "Amer Amer", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8037), false, false },
                    { 120, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8042), new DateTime(1997, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Ramadan.jpg", true, false, "Ahmed Ramadan", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8043), false, false },
                    { 121, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8045), new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Khaled_Sobhi.jpg", true, false, "Khaled Sobhi", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8045), false, false },
                    { 122, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8048), new DateTime(1993, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ragab_Nabil.jpg", true, false, "Ragab Nabil", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8048), false, false },
                    { 123, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8050), new DateTime(1997, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Hany.jpg", true, false, "Ahmed Hany", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8050), false, false },
                    { 124, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8087), new DateTime(1991, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hussein_El_Sayed.jpg", true, false, "Hussein El Sayed", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8088), false, false },
                    { 125, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8089), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_Body.jpg", true, false, "Abdelrahman Body", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8090), false, false },
                    { 126, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8092), new DateTime(1995, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Toni.jpg", true, false, "Mohamed Toni", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8092), false, false },
                    { 127, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8094), new DateTime(1999, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Kendouci.jpg", true, false, "Ahmed Kendouci", "Algeria", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8094), false, false },
                    { 128, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8111), new DateTime(1992, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Ibrahim.jpg", true, false, "Mohamed Ibrahim", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8112), false, false },
                    { 129, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8113), new DateTime(1997, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Sadek.jpg", true, false, "Mohamed Sadek", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8114), false, false },
                    { 130, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8115), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Armouty.jpg", true, false, "Ahmed El Armouty", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8115), false, false },
                    { 131, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8117), new DateTime(1997, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Fagrie_Lakay.jpg", true, false, "Fagrie Lakay", "South Africa", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8117), false, false },
                    { 132, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8119), new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Samuel_Amadi.jpg", true, false, "Samuel Amadi", "Nigeria", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8119), false, false },
                    { 133, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8121), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ayman_Moka.jpg", true, false, "Ayman Moka", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8121), false, false },
                    { 134, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8123), new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Marwan_Otaka.jpg", true, false, "Marwan Otaka", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8123), false, false },
                    { 135, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8125), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Belhadji.jpg", true, false, "Ahmed Belhadji", "Morocco", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8125), false, false },
                    { 136, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8127), new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Nour_Alaa.jpg", true, false, "Nour Alaa", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8127), false, false },
                    { 137, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8129), new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mazen_Yasser.jpg", true, false, "Mazen Yasser", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8129), false, false },
                    { 138, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8131), new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdulkareem_Ayinde.jpg", true, false, "Abdulkareem Ayinde", "Nigeria", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8131), false, false },
                    { 139, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8133), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Alaa_Shaaban.jpg", true, false, "Alaa Shaaban", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8133), false, false },
                    { 140, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8135), new DateTime(2004, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "On loan to El Gouna until 30th June 2025", "Favour_Akem.jpg", true, false, "Favour Akem", "Nigeria", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8135), false, false },
                    { 141, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8137), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "On loan to Pyramids until 30th June 2025", "Sodiq_Awujoola.jpg", true, false, "Sodiq Awujoola", "Nigeria", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8137), false, false },
                    { 142, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8153), new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Ashraf.jpg", true, false, "Ahmed Ashraf", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8154), false, false },
                    { 143, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8155), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abasi_Kyeyune.jpg", true, false, "Abasi Kyeyune", "Uganda", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8156), false, false },
                    { 144, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8157), new DateTime(2002, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Islam_El_Mezayen.jpg", true, false, "Islam El Mezayen", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8158), false, false },
                    { 145, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8159), new DateTime(1989, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Abou_Gabal.jpg", true, false, "Mohamed Abou Gabal", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8160), false, false },
                    { 146, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8161), new DateTime(1995, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Sobhi.jpg", true, false, "Ahmed Sobhi", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8162), false, false },
                    { 147, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8163), new DateTime(1993, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hassan_Shahin.jpg", true, false, "Hassan Shahin", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8164), false, false },
                    { 148, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8166), new DateTime(1992, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_El_Zanfaly.jpg", true, false, "Mahmoud El Zanfaly", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8166), false, false },
                    { 149, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8168), new DateTime(1991, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ayman_Ashraf.jpg", true, false, "Ayman Ashraf", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8168), false, false },
                    { 150, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8170), new DateTime(1998, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Injured: Cruciate ligament tear", "Mahmoud_El_Gazzar.jpg", true, false, "Mahmoud El Gazzar", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8170), false, false },
                    { 151, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8172), new DateTime(1994, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Moussa_Diawara.jpg", true, false, "Moussa Diawara", "Guinea", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8172), false, false },
                    { 152, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8174), new DateTime(1997, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amir_Medhat.jpg", true, false, "Amir Medhat", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8174), false, false },
                    { 153, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8176), new DateTime(1994, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Issahaku_Yakubu.jpg", true, false, "Issahaku Yakubu", "Ghana", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8176), false, false },
                    { 154, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8178), new DateTime(1997, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Yassin.jpg", true, false, "Ahmed Yassin", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8178), false, false },
                    { 155, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8180), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Osama_Faisal.jpg", true, false, "Osama Faisal", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8180), false, false },
                    { 156, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8197), new DateTime(1993, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Karim_Bambo.jpg", true, false, "Karim Bambo", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8198), false, false },
                    { 157, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8199), new DateTime(1988, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Kaoud.jpg", true, false, "Mahmoud Kaoud", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8200), false, false },
                    { 158, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8201), new DateTime(1989, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Bassiouny.jpg", true, false, "Mohamed Bassiouny", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8202), false, false },
                    { 159, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8203), new DateTime(1994, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Fathi.jpg", true, false, "Mohamed Fathi", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8204), false, false },
                    { 160, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8205), new DateTime(1997, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Said.jpg", true, false, "Ahmed Said", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8205), false, false },
                    { 161, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8207), new DateTime(1994, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Serge_Aka.jpg", true, false, "Serge Aka", "Côte d'Ivoire", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8207), false, false },
                    { 162, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8209), new DateTime(1996, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Helal.jpg", true, false, "Mohamed Helal", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8209), false, false },
                    { 163, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8212), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Injured: Cruciate ligament tear", "Ahmed_Rabia.jpg", true, false, "Ahmed Rabia", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8212), false, false },
                    { 164, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8214), new DateTime(1993, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Emad_Fathi.jpg", true, false, "Emad Fathi", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8214), false, false },
                    { 165, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8216), new DateTime(1990, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ibrahim_Hassan.jpg", true, false, "Ibrahim Hassan", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8216), false, false },
                    { 166, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8218), new DateTime(1991, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Grendo.jpg", true, false, "Mohamed Grendo", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8218), false, false },
                    { 167, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8220), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Yahia_Hamed.jpg", true, false, "Yahia Hamed", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8220), false, false },
                    { 168, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8222), new DateTime(1994, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Yasser.jpg", true, false, "Ahmed Yasser", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8222), false, false },
                    { 169, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8224), new DateTime(2003, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Youssef_Hassan.jpg", true, false, "Youssef Hassan", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8224), false, false },
                    { 170, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8242), new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Basem_Morsy.jpg", true, false, "Basem Morsy", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8242), false, false },
                    { 171, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8244), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Essam.jpg", true, false, "Mohamed Essam", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8244), false, false },
                    { 172, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8245), new DateTime(1988, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Sayed.jpg", true, false, "Mahmoud Sayed", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8246), false, false },
                    { 173, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8247), new DateTime(1994, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Madbouli.jpg", true, false, "Ahmed Madbouli", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8248), false, false },
                    { 174, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8249), new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Moustafa_Yasser.jpg", true, false, "Moustafa Yasser", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8250), false, false },
                    { 175, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8251), new DateTime(1987, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Genesh.jpg", true, false, "Mahmoud Genesh", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8252), false, false },
                    { 176, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8253), new DateTime(1988, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Yehia.jpg", true, false, "Ahmed Yehia", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8254), false, false },
                    { 177, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8255), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelaziz_El_Balouti.jpg", true, false, "Abdelaziz El Balouti", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8256), false, false },
                    { 178, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8294), new DateTime(1995, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Hamdy.jpg", true, false, "Mahmoud Hamdy", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8294), false, false },
                    { 179, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8296), new DateTime(1990, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ali_Elfeel.jpg", true, false, "Ali Elfeel", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8296), false, false },
                    { 180, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8298), new DateTime(1999, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Ismail.jpg", true, false, "Mohamed Ismail", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8298), false, false },
                    { 181, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8300), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Khaled_Reda.jpg", true, false, "Khaled Reda", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8300), false, false },
                    { 182, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8301), new DateTime(1997, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ghanam_Mohamed.jpg", true, false, "Ghanam Mohamed", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8302), false, false },
                    { 183, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8319), new DateTime(1998, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Injured: Cruciate ligament tear", "Mohamed_Mahmoud.jpg", true, false, "Mohamed Mahmoud", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8319), false, false },
                    { 184, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8321), new DateTime(1993, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Injured: Heart condition", "Ahmed_Refaat.jpg", true, false, "Ahmed Refaat", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8321), false, false },
                    { 185, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8323), new DateTime(1997, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Nasser_Maher.jpg", true, false, "Nasser Maher", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8323), false, false },
                    { 186, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8325), new DateTime(1996, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hesham_Balaha.jpg", true, false, "Hesham Balaha", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8325), false, false },
                    { 187, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8327), new DateTime(1998, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Atef.jpg", true, false, "Ahmed Atef", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8327), false, false },
                    { 188, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8329), new DateTime(1989, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Marwan_Mohsen.jpg", true, false, "Marwan Mohsen", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8329), false, false },
                    { 189, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8331), new DateTime(1996, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Rabia.jpg", true, false, "Mohamed Rabia", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8331), false, false },
                    { 190, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8333), new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_Rashdan.jpg", true, false, "Abdelrahman Rashdan", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8333), false, false },
                    { 191, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8335), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Youssef.jpg", true, false, "Mohamed Youssef", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8335), false, false },
                    { 192, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8337), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_Youssef.jpg", true, false, "Abdelrahman Youssef", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8337), false, false },
                    { 193, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8338), new DateTime(1988, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Gomaa.jpg", true, false, "Ahmed Gomaa", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8339), false, false },
                    { 194, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8340), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_El_Badry.jpg", true, false, "Mostafa El Badry", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8341), false, false },
                    { 195, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8342), new DateTime(2001, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ali_Zaazaa.jpg", true, false, "Ali Zaazaa", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8343), false, false },
                    { 196, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8344), new DateTime(1989, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Farouk.jpg", true, false, "Mohamed Farouk", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8345), false, false },
                    { 197, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8363), new DateTime(1990, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Omar_El_Said.jpg", true, false, "Omar El Said", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8363), false, false },
                    { 198, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8365), new DateTime(1993, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hassan_Youssef.jpg", true, false, "Hassan Youssef", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8365), false, false },
                    { 199, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8367), new DateTime(2003, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Kajally_Drammeh.jpg", true, false, "Kajally Drammeh", "Gambia", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8367), false, false },
                    { 200, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8369), new DateTime(1997, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Abdelsalam.jpg", true, false, "Mohamed Abdelsalam", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8369), false, false },
                    { 201, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8371), new DateTime(1990, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hassan_Magdy.jpg", true, false, "Hassan Magdy", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8371), false, false },
                    { 202, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8373), new DateTime(1988, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Nasef.jpg", true, false, "Mohamed Nasef", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8373), false, false },
                    { 203, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8375), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_Shika.jpg", true, false, "Abdelrahman Shika", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8375), false, false },
                    { 204, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8377), new DateTime(1994, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amr_El_Sisi.jpg", true, false, "Amr El Sisi", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8377), false, false },
                    { 205, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8379), new DateTime(1989, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ali_Lotfi.jpg", true, false, "Ali Lotfi", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8379), false, false },
                    { 206, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8381), new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amr_Hossam.jpg", true, false, "Amr Hossam", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8381), false, false },
                    { 207, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8383), new DateTime(1985, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_El_Sayed.jpg", true, false, "Mahmoud El Sayed", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8383), false, false },
                    { 208, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8385), new DateTime(1996, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Injured: Cruciate ligament tear", "Mohamed_Samir.jpg", true, false, "Mohamed Samir", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8385), false, false },
                    { 209, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8387), new DateTime(1993, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Ashraf.jpg", true, false, "Mohamed Ashraf", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8387), false, false },
                    { 210, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8389), new DateTime(1999, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Zaki.jpg", true, false, "Ahmed Zaki", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8389), false, false },
                    { 211, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8406), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Kajo.jpg", true, false, "Mostafa Kajo", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8406), false, false },
                    { 212, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8408), new DateTime(1999, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Ismail.jpg", true, false, "Mohamed Ismail", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8408), false, false },
                    { 213, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8410), new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Sayed.jpg", true, false, "Ahmed Sayed", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8410), false, false },
                    { 214, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8412), new DateTime(2001, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Saber.jpg", true, false, "Mahmoud Saber", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8412), false, false },
                    { 215, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8414), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Zareef.jpg", true, false, "Mohamed El Zareef", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8414), false, false },
                    { 216, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8416), new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Sayed.jpg", true, false, "Mohamed El Sayed", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8416), false, false },
                    { 217, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8418), new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Abdel_Naby.jpg", true, false, "Ahmed Abdel Naby", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8418), false, false },
                    { 218, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8420), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Ziko.jpg", true, false, "Mostafa Ziko", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8420), false, false },
                    { 219, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8421), new DateTime(1990, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Shady_Hussein.jpg", true, false, "Shady Hussein", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8422), false, false },
                    { 220, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8423), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_El_Banouby.jpg", true, false, "Abdelrahman El Banouby", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8424), false, false },
                    { 221, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8426), new DateTime(2000, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ziad_Kamal.jpg", true, false, "Ziad Kamal", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8426), false, false },
                    { 222, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8428), new DateTime(1992, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Sheikh.jpg", true, false, "Ahmed El Sheikh", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8428), false, false },
                    { 223, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8429), new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Islam_Abdallah.jpg", true, false, "Islam Abdallah", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8430), false, false },
                    { 224, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8447), new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Salah_Basha.jpg", true, false, "Salah Basha", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8447), false, false },
                    { 225, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8449), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_Abdelnabi.jpg", true, false, "Abdelrahman Abdelnabi", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8449), false, false },
                    { 226, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8451), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Zaalouk.jpg", true, false, "Mohamed Zaalouk", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8451), false, false },
                    { 227, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8453), new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hassan_Mahmoud.jpg", true, false, "Hassan Mahmoud", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8453), false, false },
                    { 228, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8455), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Nadim.jpg", true, false, "Mohamed Nadim", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8455), false, false },
                    { 229, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8457), new DateTime(1998, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Peter_Mutumosi.jpg", true, false, "Peter Mutumosi", "DR Congo", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8457), false, false },
                    { 230, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8459), new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Okasha.jpg", true, false, "Mohamed Okasha", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8459), false, false },
                    { 231, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8461), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_Atef.jpg", true, false, "Abdelrahman Atef", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8461), false, false },
                    { 232, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8498), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hesham_Hafez.jpg", true, false, "Hesham Hafez", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8498), false, false },
                    { 233, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8500), new DateTime(2000, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_Samir.jpg", true, false, "Abdelrahman Samir", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8501), false, false },
                    { 234, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8502), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Khalil.jpg", true, false, "Ahmed Khalil", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8503), false, false },
                    { 235, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8504), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Magdy.jpg", true, false, "Mohamed Magdy", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8505), false, false },
                    { 236, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8506), new DateTime(1993, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Agouz.jpg", true, false, "Ahmed El Agouz", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8507), false, false },
                    { 237, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8510), new DateTime(1995, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Injured: Cruciate ligament tear", "Mohamed_Hamdi.jpg", true, false, "Mohamed Hamdi", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8510), false, false },
                    { 238, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8527), new DateTime(1992, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ali_Fawzi.jpg", true, false, "Ali Fawzi", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8528), false, false },
                    { 239, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8530), new DateTime(1999, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Sabeha.jpg", true, false, "Ahmed Sabeha", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8530), false, false },
                    { 240, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8531), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Hamed.jpg", true, false, "Mohamed Hamed", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8532), false, false },
                    { 241, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8533), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Adel.jpg", true, false, "Mostafa Adel", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8534), false, false },
                    { 242, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8536), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Youssef.jpg", true, false, "Ahmed Youssef", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8536), false, false },
                    { 243, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8538), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mody_Naser.jpg", true, false, "Mody Naser", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8538), false, false },
                    { 244, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8540), new DateTime(2000, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ziad_Kamal.jpg", true, false, "Ziad Kamal", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8540), false, false },
                    { 245, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8542), new DateTime(1996, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Amin.jpg", true, false, "Ahmed Amin", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8542), false, false },
                    { 246, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8544), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ziad_Tarek.jpg", true, false, "Ziad Tarek", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8545), false, false },
                    { 247, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8546), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Nahhas.jpg", true, false, "Mohamed El Nahhas", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8546), false, false },
                    { 248, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8548), new DateTime(2000, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Shakshak.jpg", true, false, "Mostafa Shakshak", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8548), false, false },
                    { 249, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8550), new DateTime(2003, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Nader_Hawash.jpg", true, false, "Ahmed Nader Hawash", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8550), false, false },
                    { 250, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8552), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Naser.jpg", true, false, "Mohamed Naser", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8552), false, false },
                    { 251, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8554), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Youssef_Labib.jpg", true, false, "Youssef Labib", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8554), false, false },
                    { 252, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8571), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Salah_Zayed.jpg", true, false, "Salah Zayed", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8572), false, false },
                    { 253, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8573), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Emad.jpg", true, false, "Ahmed Emad", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8574), false, false },
                    { 254, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8575), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Karim_El_Tayeb.jpg", true, false, "Karim El Tayeb", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8576), false, false },
                    { 255, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8577), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hesham_Adel.jpg", true, false, "Hesham Adel", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8578), false, false },
                    { 256, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8579), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Maghraby.jpg", true, false, "Mohamed El Maghraby", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8580), false, false },
                    { 257, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8581), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Eid.jpg", true, false, "Ahmed Eid", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8582), false, false },
                    { 258, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8583), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Sherif.jpg", true, false, "Mohamed Sherif", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8584), false, false },
                    { 259, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8585), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Fathi_El_Sayed.jpg", true, false, "Fathi El Sayed", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8586), false, false },
                    { 260, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8587), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Adel_Mid.jpg", true, false, "Mostafa Adel", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8587), false, false },
                    { 261, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8589), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_Emad.jpg", true, false, "Abdelrahman Emad", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8589), false, false },
                    { 262, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8591), new DateTime(1984, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "El_Hany_Soliman.jpg", true, false, "El Hany Soliman", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8591), false, false },
                    { 263, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8593), new DateTime(1999, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hussein_Faisal.jpg", true, false, "Hussein Faisal", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8593), false, false },
                    { 264, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8595), new DateTime(1994, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Sabahi.jpg", true, false, "Mohamed El Sabahi", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8595), false, false },
                    { 265, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8597), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_El_Badry.jpg", true, false, "Mostafa El Badry", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8597), false, false },
                    { 266, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8615), new DateTime(1998, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Khaled.jpg", true, false, "Ahmed Khaled", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8615), false, false },
                    { 267, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8617), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Saeed.jpg", true, false, "Mohamed Saeed", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8617), false, false },
                    { 268, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8619), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_Amer.jpg", true, false, "Abdelrahman Amer", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8619), false, false },
                    { 269, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8620), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Tarek_Alaa.jpg", true, false, "Tarek Alaa", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8621), false, false },
                    { 270, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8623), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Mkaari.jpg", true, false, "Mohamed Mkaari", "Tunisia", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8623), false, false },
                    { 271, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8625), new DateTime(1999, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Canaria.jpg", true, false, "Canaria", "Nigeria", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8625), false, false },
                    { 272, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8627), new DateTime(1997, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Mostafa.jpg", true, false, "Ahmed Mostafa", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8627), false, false },
                    { 273, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8629), new DateTime(1993, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hossam_Hassan.jpg", true, false, "Hossam Hassan", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8629), false, false },
                    { 274, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8631), new DateTime(1999, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Metwaly.jpg", true, false, "Mohamed Metwaly", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8631), false, false },
                    { 275, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8633), new DateTime(1994, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Gamal.jpg", true, false, "Ahmed Gamal", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8633), false, false },
                    { 276, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8635), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Essam.jpg", true, false, "Mohamed Essam", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8635), false, false },
                    { 277, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8636), new DateTime(1997, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amr_Kalawa.jpg", true, false, "Amr Kalawa", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8637), false, false },
                    { 278, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8638), new DateTime(1993, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Emad_Fathi.jpg", true, false, "Emad Fathi", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8639), false, false },
                    { 279, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8657), new DateTime(1996, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Islam_Gaber.jpg", true, false, "Islam Gaber", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8657), false, false },
                    { 280, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8659), new DateTime(1997, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Fady_Farid.jpg", true, false, "Fady Farid", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8659), false, false },
                    { 281, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8661), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Omar_Salah.jpg", true, false, "Omar Salah", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8661), false, false },
                    { 282, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8663), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Abdelrasoul.jpg", true, false, "Ahmed Abdelrasoul", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8663), false, false },
                    { 283, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8665), new DateTime(1998, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Justice_Arthur.jpg", true, false, "Justice Arthur", "Ghana", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8665), false, false },
                    { 284, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8667), new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Adham_Alaa.jpg", true, false, "Adham Alaa", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8667), false, false },
                    { 285, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8669), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_El_Khawaga.jpg", true, false, "Mostafa El Khawaga", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8669), false, false },
                    { 286, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8706), new DateTime(1998, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Emam_Ashour.jpg", true, false, "Emam Ashour", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8707), false, false },
                    { 287, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8709), new DateTime(1996, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Junior_Ajayi.jpg", true, false, "Junior Ajayi", "Nigeria", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8709), false, false },
                    { 288, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8711), new DateTime(1997, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Lakay.jpg", true, false, "Lakay", "South Africa", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8711), false, false },
                    { 289, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8713), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelaziz_El_Sayed.jpg", true, false, "Abdelaziz El Sayed", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8713), false, false },
                    { 290, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8715), new DateTime(1994, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Shaaban.jpg", true, false, "Mohamed Shaaban", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8715), false, false },
                    { 291, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8717), new DateTime(1986, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Emad_El_Sayed.jpg", true, false, "Emad El Sayed", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8717), false, false },
                    { 292, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8719), new DateTime(1997, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Omar_Radwan.jpg", true, false, "Omar Radwan", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8719), false, false },
                    { 293, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8737), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Abdelmonem.jpg", true, false, "Ahmed Abdelmonem", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8737), false, false },
                    { 294, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8739), new DateTime(1989, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Khaled_Stouhi.jpg", true, false, "Khaled Stouhi", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8739), false, false },
                    { 295, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8741), new DateTime(1998, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Houssem_Dagdoug.jpg", true, false, "Houssem Dagdoug", "Tunisia", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8741), false, false },
                    { 296, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8743), new DateTime(1992, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amro_Tarek.jpg", true, false, "Amro Tarek", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8743), false, false },
                    { 297, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8745), new DateTime(1996, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Meteb.jpg", true, false, "Ahmed Meteb", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8746), false, false },
                    { 298, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8747), new DateTime(1990, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hassan_Magdy.jpg", true, false, "Hassan Magdy", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8748), false, false },
                    { 299, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8749), new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Islam_Mohareb.jpg", true, false, "Islam Mohareb", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8750), false, false },
                    { 300, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8751), new DateTime(1994, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Samir.jpg", true, false, "Ahmed Samir", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8752), false, false },
                    { 301, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8753), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Yahia_Hamed.jpg", true, false, "Yahia Hamed", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8754), false, false },
                    { 302, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8755), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_Shika.jpg", true, false, "Abdelrahman Shika", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8756), false, false },
                    { 303, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8757), new DateTime(1996, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Hany.jpg", true, false, "Mohamed Hany", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8758), false, false },
                    { 304, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8760), new DateTime(1989, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Farid_Shawki.jpg", true, false, "Farid Shawki", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8760), false, false },
                    { 305, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8762), new DateTime(1999, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ali_Hamdy.jpg", true, false, "Ali Hamdy", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8762), false, false },
                    { 306, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8764), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Paul_Joules.jpg", true, false, "Paul Joules", "Nigeria", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8764), false, false },
                    { 307, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8781), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Godwin_Okwara.jpg", true, false, "Godwin Okwara", "Nigeria", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8782), false, false },
                    { 308, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8783), new DateTime(1992, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Karim_Tarek.jpg", true, false, "Karim Tarek", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8784), false, false },
                    { 309, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8785), new DateTime(1995, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Momen_Rady.jpg", true, false, "Momen Rady", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8786), false, false },
                    { 310, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8787), new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Khawaga.jpg", true, false, "Mostafa Khawaga", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8788), false, false },
                    { 311, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8789), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Shehata.jpg", true, false, "Mohamed Shehata", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8790), false, false },
                    { 312, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8791), new DateTime(1988, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Khaled_Kamar.jpg", true, false, "Khaled Kamar", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8792), false, false },
                    { 313, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8793), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Kout.jpg", true, false, "Mohamed El Kout", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8794), false, false },
                    { 314, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8795), new DateTime(1994, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Mansour.jpg", true, false, "Ahmed Mansour", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8795), false, false },
                    { 315, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8797), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Karim_Halawa.jpg", true, false, "Karim Halawa", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8797), false, false },
                    { 316, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8799), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Omar_Tarek.jpg", true, false, "Omar Tarek", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8799), false, false },
                    { 317, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8801), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Yehia_Zakaria.jpg", true, false, "Yehia Zakaria", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8801), false, false },
                    { 318, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8803), new DateTime(1987, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "El_Mahdy_Soliman.jpg", true, false, "El Mahdy Soliman", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8803), false, false },
                    { 319, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8805), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Omar_Salah.jpg", true, false, "Omar Salah", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8805), false, false },
                    { 320, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8807), new DateTime(1993, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amr_Khalil.jpg", true, false, "Amr Khalil", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8807), false, false },
                    { 321, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8825), new DateTime(1990, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hesham_Mohamed.jpg", true, false, "Hesham Mohamed", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8825), false, false },
                    { 322, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8826), new DateTime(1991, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Khaled_El_Ghandour.jpg", true, false, "Khaled El Ghandour", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8827), false, false },
                    { 323, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8828), new DateTime(1990, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Abdelaziz.jpg", true, false, "Mahmoud Abdelaziz", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8829), false, false },
                    { 324, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8830), new DateTime(1995, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Karim_El_Deeb.jpg", true, false, "Karim El Deeb", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8831), false, false },
                    { 325, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8833), new DateTime(1995, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Shabana.jpg", true, false, "Mahmoud Shabana", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8833), false, false },
                    { 326, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8835), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Ghoneim.jpg", true, false, "Ahmed Ghoneim", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8835), false, false },
                    { 327, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8836), new DateTime(1997, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelghani_Mohamed.jpg", true, false, "Abdelghani Mohamed", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8837), false, false },
                    { 328, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8838), new DateTime(1992, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mabululu.jpg", true, false, "Mabululu", "Angola", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8839), false, false },
                    { 329, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8840), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Adel.jpg", true, false, "Ahmed Adel", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8841), false, false },
                    { 330, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8843), new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Omar_El_Saaiy.jpg", true, false, "Omar El Saaiy", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8843), false, false },
                    { 331, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8845), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hany_El_Tamy.jpg", true, false, "Hany El Tamy", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8845), false, false },
                    { 332, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8847), new DateTime(1990, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Nader_Ramadan.jpg", true, false, "Nader Ramadan", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8847), false, false },
                    { 333, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8849), new DateTime(1996, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Islam_Gaber.jpg", true, false, "Islam Gaber", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8849), false, false },
                    { 334, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8892), new DateTime(1996, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amr_Saleh.jpg", true, false, "Amr Saleh", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8892), false, false },
                    { 335, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8894), new DateTime(1998, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Fawzy_El_Henawy.jpg", true, false, "Fawzy El Henawy", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8894), false, false },
                    { 336, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8896), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Adel_Badr.jpg", true, false, "Adel Badr", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8896), false, false },
                    { 337, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8898), new DateTime(1991, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Benjamin_Boateng.jpg", true, false, "Benjamin Boateng", "Ghana", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8898), false, false },
                    { 338, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8900), new DateTime(2003, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Bekale_Aubame.jpg", true, false, "Bekale Aubame", "Gabon", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8900), false, false },
                    { 339, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8902), new DateTime(1992, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Sheikh.jpg", true, false, "Ahmed El Sheikh", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8902), false, false },
                    { 340, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8926), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hesham_Hafez.jpg", true, false, "Hesham Hafez", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8926), false, false },
                    { 341, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8929), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Ragab.jpg", true, false, "Mohamed Ragab", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8929), false, false },
                    { 342, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8931), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Karim_Yahia.jpg", true, false, "Karim Yahia", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8931), false, false },
                    { 343, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8933), new DateTime(1994, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amr_El_Sisi.jpg", true, false, "Amr El Sisi", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8933), false, false },
                    { 344, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8935), new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdo_Semida.jpg", true, false, "Abdo Semida", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8935), false, false },
                    { 345, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8937), new DateTime(1999, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Ismail.jpg", true, false, "Mohamed Ismail", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8937), false, false },
                    { 346, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8938), new DateTime(1994, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Fathi.jpg", true, false, "Mohamed Fathi", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8939), false, false },
                    { 347, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8940), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Bahaa.jpg", true, false, "Ahmed Bahaa", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8941), false, false },
                    { 348, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8958), new DateTime(1990, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Fawzi.jpg", true, false, "Mohamed Fawzi", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8959), false, false },
                    { 349, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8960), new DateTime(1997, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Karim_Emad.jpg", true, false, "Karim Emad", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8961), false, false },
                    { 350, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8962), new DateTime(1988, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Felix.jpg", true, false, "Ahmed Felix", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8963), false, false },
                    { 351, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8964), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Sobhi.jpg", true, false, "Mostafa Sobhi", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8965), false, false },
                    { 352, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8966), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Mamdouh.jpg", true, false, "Mahmoud Mamdouh", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8966), false, false },
                    { 353, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8968), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Khaled_Sami.jpg", true, false, "Khaled Sami", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8969), false, false },
                    { 354, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8970), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hatem_El_Sharkawy.jpg", true, false, "Hatem El Sharkawy", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8970), false, false },
                    { 355, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8972), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Ayman.jpg", true, false, "Ahmed Ayman", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8972), false, false },
                    { 356, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8974), new DateTime(1996, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Reda.jpg", true, false, "Mohamed Reda", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8974), false, false },
                    { 357, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8976), new DateTime(1990, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Gamal.jpg", true, false, "Mostafa Gamal", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8976), false, false },
                    { 358, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8978), new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Shedid_Kenawi.jpg", true, false, "Ahmed Shedid Kenawi", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8978), false, false },
                    { 359, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8980), new DateTime(1998, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Wagih_Abdelhakim.jpg", true, false, "Wagih Abdelhakim", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8981), false, false },
                    { 360, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8982), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hamed_El_Gabry.jpg", true, false, "Hamed El Gabry", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8983), false, false },
                    { 361, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8985), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Abdelsalam.jpg", true, false, "Mohamed Abdelsalam", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(8985), false, false },
                    { 362, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9003), new DateTime(1998, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Emam_Ashour.jpg", true, false, "Emam Ashour", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9003), false, false },
                    { 363, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9005), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Hashem.jpg", true, false, "Mohamed Hashem", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9005), false, false },
                    { 364, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9006), new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Dawooda.jpg", true, false, "Ahmed Dawooda", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9007), false, false },
                    { 365, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9008), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Gharib_Yasser.jpg", true, false, "Gharib Yasser", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9009), false, false },
                    { 366, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9010), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hossam_Aboelazm.jpg", true, false, "Hossam Aboelazm", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9011), false, false },
                    { 367, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9012), new DateTime(1992, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Islam_Abdelnaim.jpg", true, false, "Islam Abdelnaim", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9013), false, false },
                    { 368, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9014), new DateTime(1990, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ibrahim_El_Kadi.jpg", true, false, "Ibrahim El Kadi", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9015), false, false },
                    { 369, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9016), new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_Khaled.jpg", true, false, "Abdelrahman Khaled", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9017), false, false },
                    { 370, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9018), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Nagy.jpg", true, false, "Mohamed Nagy", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9018), false, false },
                    { 371, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9022), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Ziko.jpg", true, false, "Mostafa Ziko", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9022), false, false },
                    { 372, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9024), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Abdelnasser.jpg", true, false, "Mohamed Abdelnasser", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9024), false, false },
                    { 373, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9026), new DateTime(1997, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Hany.jpg", true, false, "Ahmed Hany", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9026), false, false },
                    { 374, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9028), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Ragab.jpg", true, false, "Mohamed Ragab", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9028), false, false },
                    { 375, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9030), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Vidjannagni_Saizonou.jpg", true, false, "Vidjannagni Saïzonou", "Benin", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9030), false, false },
                    { 376, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9047), new DateTime(1993, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Shika.jpg", true, false, "Mohamed Shika", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9047), false, false },
                    { 377, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9050), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Abdelaziz.jpg", true, false, "Ahmed Abdelaziz", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9050), false, false },
                    { 378, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9053), new DateTime(1993, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Hamdy.jpg", true, false, "Mahmoud Hamdy", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9053), false, false },
                    { 379, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9055), new DateTime(1999, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hossam_Aly.jpg", true, false, "Hossam Aly", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9055), false, false },
                    { 380, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9057), new DateTime(1999, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Ismail.jpg", true, false, "Mohamed Ismail", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9057), false, false },
                    { 381, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9059), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Reda.jpg", true, false, "Ahmed Reda", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9059), false, false },
                    { 382, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9061), new DateTime(1993, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Chibi.jpg", true, false, "Mohamed Chibi", "Morocco", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9061), false, false },
                    { 383, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9063), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hamed_Hamdan.jpg", true, false, "Hamed Hamdan", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9063), false, false },
                    { 384, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9066), new DateTime(1996, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Emad.jpg", true, false, "Mahmoud Emad", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9067), false, false },
                    { 385, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9068), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_El_Dah.jpg", true, false, "Abdelrahman El Dah", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9069), false, false },
                    { 386, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9070), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Sedki.jpg", true, false, "Mohamed Sedki", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9071), false, false },
                    { 387, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9072), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ismail_Boubekeur.jpg", true, false, "Ismail Boubekeur", "Algeria", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9073), false, false },
                    { 388, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9074), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Favour_Nwobgo.jpg", true, false, "Favour Nwobgo", "Nigeria", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9075), false, false },
                    { 389, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9093), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Salem.jpg", true, false, "Mohamed Salem", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9093), false, false },
                    { 390, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9095), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Fawzy.jpg", true, false, "Ahmed Fawzy", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9095), false, false },
                    { 391, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9097), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Bahaa.jpg", true, false, "Ahmed Bahaa", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9097), false, false },
                    { 392, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9099), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hossam_Ashraf.jpg", true, false, "Hossam Ashraf", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9099), false, false },
                    { 393, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9165), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ziad_Ashraf.jpg", true, false, "Ziad Ashraf", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9165), false, false },
                    { 394, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9167), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Touny.jpg", true, false, "Mohamed El Touny", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9168), false, false },
                    { 395, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9169), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Moawad.jpg", true, false, "Mostafa Moawad", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9170), false, false },
                    { 396, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9171), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hatem_Mohamed.jpg", true, false, "Hatem Mohamed", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9172), false, false },
                    { 397, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9173), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Sosta.jpg", true, false, "Mohamed Sosta", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9174), false, false },
                    { 398, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9175), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Agamy.jpg", true, false, "Ahmed El Agamy", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9175), false, false },
                    { 399, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9177), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Abdelnabi.jpg", true, false, "Mahmoud Abdelnabi", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9177), false, false },
                    { 400, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9179), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Shahin.jpg", true, false, "Mohamed Shahin", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9179), false, false },
                    { 401, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9181), new DateTime(2000, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Jibril_Bojang.jpg", true, false, "Jibril Bojang", "Gambia", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9181), false, false },
                    { 402, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9183), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_El_Kout.jpg", true, false, "Mahmoud El Kout", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9183), false, false },
                    { 403, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9202), new DateTime(1993, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amr_Shaaban.jpg", true, false, "Amr Shaaban", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9202), false, false },
                    { 404, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9204), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_El_Hadary.jpg", true, false, "Mahmoud El Hadary", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9205), false, false },
                    { 405, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9206), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Nadry.jpg", true, false, "Ahmed El Nadry", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9206), false, false },
                    { 406, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9209), new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Sami.jpg", true, false, "Mohamed Sami", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9210), false, false },
                    { 407, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9211), new DateTime(1990, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Moaz_El_Henawy.jpg", true, false, "Moaz El Henawy", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9212), false, false },
                    { 408, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9213), new DateTime(1993, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Bazoka.jpg", true, false, "Mohamed Bazoka", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9214), false, false },
                    { 409, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9215), new DateTime(1990, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Sheikh.jpg", true, false, "Ahmed El Sheikh", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9215), false, false },
                    { 410, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9217), new DateTime(1993, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ehab_Samir.jpg", true, false, "Ehab Samir", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9217), false, false },
                    { 411, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9219), new DateTime(1999, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdo_Yehia.jpg", true, false, "Abdo Yehia", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9219), false, false },
                    { 412, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9221), new DateTime(1996, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Geaidy.jpg", true, false, "Ahmed El Geaidy", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9221), false, false },
                    { 413, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9223), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Saleh_Nasr.jpg", true, false, "Saleh Nasr", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9223), false, false },
                    { 414, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9225), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Charles_Ekpenyong.jpg", true, false, "Charles Ekpenyong", "Nigeria", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9225), false, false },
                    { 415, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9227), new DateTime(1998, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Youssef_Hassan.jpg", true, false, "Youssef Hassan", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9227), false, false },
                    { 416, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9229), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Khaled_El_Akhmimi.jpg", true, false, "Khaled El Akhmimi", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9229), false, false },
                    { 417, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9247), new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Nadry2.jpg", true, false, "Ahmed El Nadry", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9247), false, false },
                    { 418, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9249), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Osama.jpg", true, false, "Mostafa Osama", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9249), false, false },
                    { 419, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9251), new DateTime(1991, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hamid_Mao.jpg", true, false, "Hamid Mao", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9251), false, false },
                    { 420, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9253), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelkader_Yehia.jpg", true, false, "Abdelkader Yehia", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9254), false, false },
                    { 421, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9255), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Gabriel_Chukwudi.jpg", true, false, "Gabriel Chukwudi", "Nigeria", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9256), false, false },
                    { 422, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9257), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Gaber.jpg", true, false, "Mohamed Gaber", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9258), false, false },
                    { 423, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9259), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hesham_Nabawi.jpg", true, false, "Hesham Nabawi", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9260), false, false },
                    { 424, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9261), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ibrahima_Mbaye.jpg", true, false, "Ibrahima Mbaye", "Senegal", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9262), false, false },
                    { 425, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9263), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Abdel_Aati.jpg", true, false, "Mohamed Abdel Aati", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9263), false, false },
                    { 426, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9265), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Aboulkheir.jpg", true, false, "Ahmed Aboulkheir", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9265), false, false },
                    { 427, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9267), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Kalosha.jpg", true, false, "Mostafa Kalosha", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9267), false, false },
                    { 428, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9269), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hossam_Hassan.jpg", true, false, "Hossam Hassan", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9269), false, false },
                    { 429, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9271), new DateTime(1998, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Peter_Zilu_Mutumosi.jpg", true, false, "Peter Zilu Mutumosi", "DR Congo", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9271), false, false },
                    { 430, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9273), new DateTime(1993, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Fawzi.jpg", true, false, "Mohamed Fawzi", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9273), false, false },
                    { 431, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9293), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Adel.jpg", true, false, "Ahmed Adel", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9293), false, false },
                    { 432, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9295), new DateTime(1999, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Kamal_El_Sayed.jpg", true, false, "Kamal El Sayed", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9295), false, false },
                    { 433, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9297), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Essam_El_Hadary.jpg", true, false, "Essam El Hadary", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9297), false, false },
                    { 434, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9299), new DateTime(1992, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Nasr.jpg", true, false, "Mohamed Nasr", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9299), false, false },
                    { 435, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9300), new DateTime(1997, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Desouki.jpg", true, false, "Mohamed Desouki", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9301), false, false },
                    { 436, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9302), new DateTime(2001, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hatem_Sukar.jpg", true, false, "Hatem Sukar", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9303), false, false },
                    { 437, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9304), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Bayoumi.jpg", true, false, "Mohamed Bayoumi", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9305), false, false },
                    { 438, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9306), new DateTime(1993, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Karim_Arafat.jpg", true, false, "Karim Arafat", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9307), false, false },
                    { 439, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9308), new DateTime(2001, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Nader_Farag.jpg", true, false, "Nader Farag", "Sudan", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9309), false, false },
                    { 440, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9310), new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Omar_El_Saaiy.jpg", true, false, "Omar El Saaiy", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9310), false, false },
                    { 441, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9312), new DateTime(1993, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Emad_Hamdy.jpg", true, false, "Emad Hamdy", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9312), false, false },
                    { 442, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9314), new DateTime(1998, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Makhlouf.jpg", true, false, "Mohamed Makhlouf", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9314), false, false },
                    { 443, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9316), new DateTime(1996, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Eric_Traore.jpg", true, false, "Eric Traoré", "Burkina Faso", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9316), false, false },
                    { 444, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9335), new DateTime(1997, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_Magdy.jpg", true, false, "Abdelrahman Magdy", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9335), false, false },
                    { 445, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9337), new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Basem_Morsy.jpg", true, false, "Basem Morsy", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9337), false, false },
                    { 446, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9390), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Anas_Shendy.jpg", true, false, "Anas Shendy", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9390), false, false },
                    { 447, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9392), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Zidan.jpg", true, false, "Mohamed Zidan", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9392), false, false },
                    { 448, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9394), new DateTime(1990, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hesham_Mohamed.jpg", true, false, "Hesham Mohamed", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9394), false, false },
                    { 449, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9396), new DateTime(2003, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Khaled_Al_Nabris.jpg", true, false, "Khaled Al Nabris", "Palestine", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9396), false, false },
                    { 450, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9398), new DateTime(1996, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Marwan_Hamdi.jpg", true, false, "Marwan Hamdi", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9398), false, false },
                    { 451, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9400), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Abdel_Samia.jpg", true, false, "Mohamed Abdel Samia", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9400), false, false },
                    { 452, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9402), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Mohsen.jpg", true, false, "Ahmed Mohsen", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9402), false, false },
                    { 453, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9404), new DateTime(1995, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Hashem.jpg", true, false, "Mohamed Hashem", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9404), false, false },
                    { 454, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9405), new DateTime(1993, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Omar_Mamdouh.jpg", true, false, "Omar Mamdouh", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9406), false, false },
                    { 455, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9407), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdelrahman_El_Dah.jpg", true, false, "Abdelrahman El Dah", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9408), false, false },
                    { 456, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9409), new DateTime(1994, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Bismark_Boateng.jpg", true, false, "Bismark Boateng", "Ghana", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9410), false, false },
                    { 457, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9411), new DateTime(1997, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Sobhi_Soliman.jpg", true, false, "Sobhi Soliman", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9412), false, false },
                    { 458, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9429), new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Mahmoud.jpg", true, false, "Ahmed Mahmoud", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9429), false, false },
                    { 459, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9431), new DateTime(1991, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Masoud.jpg", true, false, "Ahmed Masoud", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9431), false, false },
                    { 460, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9433), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Abdel_Rasoul.jpg", true, false, "Ahmed Abdel Rasoul", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9433), false, false },
                    { 461, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9435), new DateTime(1998, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_El_Gazzar.jpg", true, false, "Mahmoud El Gazzar", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9435), false, false },
                    { 462, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9437), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Hossam.jpg", true, false, "Ahmed Hossam", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9437), false, false },
                    { 463, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9439), new DateTime(1997, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Kamal_Aboul_Fetouh.jpg", true, false, "Kamal Aboul Fetouh", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9439), false, false },
                    { 464, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9441), new DateTime(1987, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Sabri_Rahil.jpg", true, false, "Sabri Rahil", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9441), false, false },
                    { 465, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9443), new DateTime(2001, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Arnaud_Randianantenaina.jpg", true, false, "Arnaud Randianantenaina", "Madagascar", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9443), false, false },
                    { 466, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9445), new DateTime(1996, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ayman_Moka.jpg", true, false, "Ayman Moka", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9445), false, false },
                    { 467, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9447), new DateTime(1997, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Belhadji.jpg", true, false, "Ahmed Belhadji", "Morocco", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9447), false, false },
                    { 468, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9449), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Seif_Shika.jpg", true, false, "Seif Shika", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9449), false, false },
                    { 469, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9450), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Reda_Salah.jpg", true, false, "Reda Salah", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9451), false, false },
                    { 470, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9452), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Okka.jpg", true, false, "Mahmoud Okka", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9453), false, false },
                    { 471, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9454), new DateTime(1994, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Sabahi.jpg", true, false, "Mohamed El Sabahi", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9455), false, false },
                    { 472, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9472), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hossam_Ghanem.jpg", true, false, "Hossam Ghanem", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9472), false, false },
                    { 473, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9474), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdel_Fattah_Sheta.jpg", true, false, "Abdel Fattah Sheta", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9474), false, false },
                    { 474, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9476), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Emad.jpg", true, false, "Mohamed Emad", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9476), false, false },
                    { 475, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9478), new DateTime(1997, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ashraf_Magdy.jpg", true, false, "Ashraf Magdy", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9478), false, false },
                    { 476, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9479), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ziad_Tarek.jpg", true, false, "Ziad Tarek", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9480), false, false },
                    { 477, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9482), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Youssef.jpg", true, false, "Mohamed Youssef", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9482), false, false },
                    { 478, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9484), new DateTime(2001, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Franck_Etouga.jpg", true, false, "Franck Etouga", "Cameroon", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9484), false, false },
                    { 479, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9486), new DateTime(1997, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Hany.jpg", true, false, "Ahmed Hany", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9486), false, false },
                    { 480, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9487), new DateTime(1992, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Valentin_Zoungrana.jpg", true, false, "Valentin Zoungrana", "Burkina Faso", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9488), false, false },
                    { 481, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9490), new DateTime(1991, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amr_Gamal.jpg", true, false, "Amr Gamal", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9490), false, false },
                    { 482, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9491), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Abdel_Gawad.jpg", true, false, "Mohamed Abdel Gawad", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9492), false, false },
                    { 483, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9493), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Salah.jpg", true, false, "Mahmoud Salah", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9494), false, false },
                    { 484, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9495), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Saeed.jpg", true, false, "Mohamed Saeed", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9496), false, false },
                    { 485, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9497), new DateTime(1994, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Shafik.jpg", true, false, "Mohamed Shafik", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9498), false, false },
                    { 486, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9515), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Fares_El_Sayed.jpg", true, false, "Fares El Sayed", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9515), false, false },
                    { 487, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9517), new DateTime(1997, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Gaber_Kamel.jpg", true, false, "Gaber Kamel", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9517), false, false },
                    { 488, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9519), new DateTime(1992, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Awad.jpg", true, false, "Ahmed Awad", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9519), false, false },
                    { 489, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9521), new DateTime(1995, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Bahrawi.jpg", true, false, "Ahmed El Bahrawi", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9521), false, false },
                    { 490, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9523), new DateTime(1998, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Jefferson_Encada.jpg", true, false, "Jefferson Encada", "Guinea-Bissau", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9523), false, false },
                    { 491, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9525), new DateTime(2001, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Seif_El_Agouz.jpg", true, false, "Seif El Agouz", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9525), false, false },
                    { 492, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9527), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Gehad.jpg", true, false, "Mahmoud Gehad", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9527), false, false },
                    { 493, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9529), new DateTime(1999, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Fakhry.jpg", true, false, "Mohamed Fakhry", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9529), false, false },
                    { 494, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9531), new DateTime(1994, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Saif_Terry.jpg", true, false, "Saif Terry", "Sudan", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9531), false, false },
                    { 495, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9533), new DateTime(1994, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Shokry_Naguib.jpg", true, false, "Shokry Naguib", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9533), false, false },
                    { 496, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9535), new DateTime(2001, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Walid_Farag.jpg", true, false, "Walid Farag", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9535), false, false },
                    { 497, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9537), new DateTime(2003, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Fouad.jpg", true, false, "Ahmed Fouad", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9537), false, false },
                    { 498, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9539), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Bangoura.jpg", true, false, "Mohamed Bangoura", "Guinea", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9539), false, false },
                    { 499, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9557), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Hamada.jpg", true, false, "Mostafa Hamada", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9557), false, false },
                    { 500, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9594), new DateTime(2001, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Tarek.jpg", true, false, "Mostafa Tarek", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9594), false, false },
                    { 501, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9596), new DateTime(1998, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Sageer.jpg", true, false, "Ahmed El Sageer", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9596), false, false },
                    { 502, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9598), new DateTime(1987, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Rami_Sabri.jpg", true, false, "Rami Sabri", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9598), false, false },
                    { 503, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9600), new DateTime(1998, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Azmi_Ghouma.jpg", true, false, "Azmi Ghouma", "Tunisia", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9600), false, false },
                    { 504, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9602), new DateTime(1999, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_El_Badry.jpg", true, false, "Mahmoud El Badry", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9602), false, false },
                    { 505, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9604), new DateTime(1991, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Khaled_El_Ghandour.jpg", true, false, "Khaled El Ghandour", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9604), false, false },
                    { 506, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9606), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Armouty.jpg", true, false, "Ahmed El Armouty", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9606), false, false },
                    { 507, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9608), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Emad.jpg", true, false, "Mahmoud Emad", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9608), false, false },
                    { 508, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9610), new DateTime(1995, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Kingsley_Sokari.jpg", true, false, "Kingsley Sokari", "Nigeria", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9610), false, false },
                    { 509, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9612), new DateTime(1998, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Moussa_Camara.jpg", true, false, "Moussa Camara", "Guinea", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9612), false, false },
                    { 510, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9614), new DateTime(1993, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amr_Warda.jpg", true, false, "Amr Warda", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9614), false, false },
                    { 511, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9615), new DateTime(1997, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amer_Amer.jpg", true, false, "Amer Amer", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9616), false, false },
                    { 512, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9617), new DateTime(1987, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Aboul_Saoud.jpg", true, false, "Mahmoud Aboul Saoud", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9618), false, false },
                    { 513, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9635), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Ahmed.jpg", true, false, "Mohamed Ahmed", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9635), false, false },
                    { 514, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9637), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Farouq_Noor.jpg", true, false, "Farouq Noor", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9637), false, false },
                    { 515, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9639), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Ghalwesh.jpg", true, false, "Mohamed Ghalwesh", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9639), false, false },
                    { 516, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9640), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Eid.jpg", true, false, "Ahmed Eid", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9641), false, false },
                    { 517, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9642), new DateTime(1993, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Joseph_Ochaya.jpg", true, false, "Joseph Ochaya", "Uganda", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9643), false, false },
                    { 518, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9644), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Alaa.jpg", true, false, "Ahmed Alaa", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9645), false, false },
                    { 519, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9646), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Salem.jpg", true, false, "Mohamed Salem", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9646), false, false },
                    { 520, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9648), new DateTime(2002, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Favour_Aniekan.jpg", true, false, "Favour Aniekan", "Nigeria", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9648), false, false },
                    { 521, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9650), new DateTime(1993, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Antar.jpg", true, false, "Mohamed Antar", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9650), false, false },
                    { 522, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9652), new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Arabi.jpg", true, false, "Ahmed El Arabi", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9652), false, false },
                    { 523, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9654), new DateTime(1996, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Magli.jpg", true, false, "Mohamed Magli", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9654), false, false },
                    { 524, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9656), new DateTime(1994, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Shabrawy.jpg", true, false, "Mahmoud Shabrawy", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9656), false, false },
                    { 525, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9658), new DateTime(1999, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amar_Hamdi.jpg", true, false, "Amar Hamdi", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9658), false, false },
                    { 526, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9660), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Shawky.jpg", true, false, "Mohamed Shawky", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9660), false, false },
                    { 527, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9677), new DateTime(1992, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Omar_Fathi.jpg", true, false, "Omar Fathi", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9678), false, false },
                    { 528, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9679), new DateTime(1998, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Atef.jpg", true, false, "Ahmed Atef", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9680), false, false },
                    { 529, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9681), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Hany.jpg", true, false, "Mohamed Hany", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9682), false, false },
                    { 530, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9683), new DateTime(1994, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Niass.jpg", true, false, "Mohamed Niass", "Senegal", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9684), false, false },
                    { 531, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9685), new DateTime(1994, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdallah_Yaisien.jpg", true, false, "Abdallah Yaisien", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9686), false, false },
                    { 532, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9687), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Manga.jpg", true, false, "Mahmoud Manga", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9688), false, false },
                    { 533, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9689), new DateTime(1989, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Amir_Abed.jpg", true, false, "Amir Abed", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9689), false, false },
                    { 534, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9691), new DateTime(1992, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Louay_Wael.jpg", true, false, "Louay Wael", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9691), false, false },
                    { 535, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9693), new DateTime(1993, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Omar_Bassam.jpg", true, false, "Omar Bassam", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9693), false, false },
                    { 536, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9695), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_El_Koh.jpg", true, false, "Ahmed El Koh", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9695), false, false },
                    { 537, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9698), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ojo_Tolulope.jpg", true, false, "Ojo Tolulope", "Nigeria", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9698), false, false },
                    { 538, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9701), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Aboul_Naga.jpg", true, false, "Mohamed Aboul-Naga", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9701), false, false },
                    { 539, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9703), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Abdel_Kafi_Ragab.jpg", true, false, "Abdel Kafi Ragab", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9704), false, false },
                    { 540, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9705), new DateTime(1991, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Seif_Teka.jpg", true, false, "Seif Teka", "Tunisia", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9706), false, false },
                    { 541, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9723), new DateTime(1997, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Kamal_Aboul_Fetouh.jpg", true, false, "Kamal Aboul-Fetouh", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9723), false, false },
                    { 542, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9725), new DateTime(1993, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Youssef_Camacho.jpg", true, false, "Mohamed Youssef Camacho", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9725), false, false },
                    { 543, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9727), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Shebini.jpg", true, false, "Mohamed El Shebini", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9727), false, false },
                    { 544, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9729), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Dahesh.jpg", true, false, "Ahmed Dahesh", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9729), false, false },
                    { 545, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9731), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Omar_Adly.jpg", true, false, "Omar Adly", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9731), false, false },
                    { 546, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9733), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Dahroug.jpg", true, false, "Ahmed Dahroug", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9733), false, false },
                    { 547, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9735), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Fahd_Aboul_Fetouh.jpg", true, false, "Fahd Aboul-Fetouh", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9735), false, false },
                    { 548, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9736), new DateTime(1991, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Winful_Cobbinah.jpg", true, false, "Winful Cobbinah", "Ghana", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9737), false, false },
                    { 549, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9738), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Abdel_Aati.jpg", true, false, "Mohamed Abdel Aati", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9739), false, false },
                    { 550, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9740), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Momen_Atef.jpg", true, false, "Momen Atef", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9741), false, false },
                    { 551, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9742), new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Walid_Adel.jpg", true, false, "Walid Adel", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9743), false, false },
                    { 552, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9744), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Islam_Adel.jpg", true, false, "Islam Adel", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9745), false, false },
                    { 553, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9746), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Said_El_Wensh.jpg", true, false, "Said El Wensh", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9746), false, false },
                    { 554, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9799), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Talaat.jpg", true, false, "Mahmoud Talaat", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9799), false, false },
                    { 555, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9801), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Karim_Halawa.jpg", true, false, "Karim Halawa", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9802), false, false },
                    { 556, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9803), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Walid_Ateya.jpg", true, false, "Walid Ateya", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9804), false, false },
                    { 557, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9805), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ali_Hussein.jpg", true, false, "Ali Hussein", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9805), false, false },
                    { 558, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9807), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Abdel_Khalek.jpg", true, false, "Mostafa Abdel Khalek", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9807), false, false },
                    { 559, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9809), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hassan_Mahmoud.jpg", true, false, "Hassan Mahmoud", "Egypt", 1, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9809), false, false },
                    { 560, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9811), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Sayed.jpg", true, false, "Mohamed El Sayed", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9811), false, false },
                    { 561, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9813), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hesham_Adel.jpg", true, false, "Hesham Adel", "Egypt", 2, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9813), false, false },
                    { 562, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9815), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Abdel_Mawgoud.jpg", true, false, "Ahmed Abdel Mawgoud", "Egypt", 3, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9815), false, false },
                    { 563, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9817), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mostafa_Kajo.jpg", true, false, "Mostafa Kajo", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9817), false, false },
                    { 564, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9819), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Fayoumi.jpg", true, false, "Mohamed El Fayoumi", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9819), false, false },
                    { 565, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9821), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Essam.jpg", true, false, "Ahmed Essam", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9821), false, false },
                    { 566, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9823), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Zareef.jpg", true, false, "Mohamed El Zareef", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9823), false, false },
                    { 567, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9825), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mahmoud_Nabil.jpg", true, false, "Mahmoud Nabil", "Egypt", 8, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9825), false, false },
                    { 568, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9842), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hesham_Hafez.jpg", true, false, "Hesham Hafez", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9843), false, false },
                    { 569, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9844), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Ali.jpg", true, false, "Ahmed Ali", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9845), false, false },
                    { 570, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9846), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ibrahim_El_Kadi.jpg", true, false, "Ibrahim El Kadi", "Egypt", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9846), false, false },
                    { 571, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9848), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_Ramadan.jpg", true, false, "Mohamed Ramadan", "Egypt", 16, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9848), false, false },
                    { 572, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9850), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Hussein_Anwar.jpg", true, false, "Hussein Anwar", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9850), false, false },
                    { 573, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9852), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Stanley_Anigbogu.jpg", true, false, "Stanley Anigbogu", "Nigeria", 18, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9852), false, false },
                    { 574, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9854), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Mohamed_El_Sabahi.jpg", true, false, "Mohamed El Sabahi", "Egypt", 15, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9854), false, false },
                    { 575, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9856), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ahmed_Zaki.jpg", true, false, "Ahmed Zaki", "Egypt", 4, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9856), false, false },
                    { 576, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9858), new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Youssef_El_Gohary.jpg", true, false, "Youssef El Gohary", "Egypt", 9, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9858), false, false },
                    { 577, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9860), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Ali_Lotfi.jpg", true, false, "Ali Lotfi", "Egypt", 10, new DateTime(2025, 9, 2, 19, 43, 35, 79, DateTimeKind.Utc).AddTicks(9860), false, false }
                });

            migrationBuilder.InsertData(
                table: "Tournaments",
                columns: new[] { "Id", "Country", "CreatedAt", "DeletedAt", "Description", "EndDate", "IsActive", "IsDeleted", "Logo", "Season", "StartDate", "Title", "Type", "UpdatedAt", "Venue", "isBigMatch", "isSold" },
                values: new object[] { 1, "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(1644), null, "Top professional league for association football clubs in Egypt", new DateTime(2026, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Egyptian_Premier_League_Logo.jpg", "2025/2026", new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(1645), "Various stadiums in Egypt", false, false });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CoachId", "Country", "CreatedAt", "DeletedAt", "Description", "Founded", "IsActive", "IsDeleted", "LogoUrl", "Name", "UpdatedAt", "isBigMatch", "isSold" },
                values: new object[,]
                {
                    { 1, 1, "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(1489), null, "Official club name: Al Ahly Sporting Club", new DateTime(1907, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Al_Ahly_Logo.png", "Al Ahly FC", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(1490), false, false },
                    { 2, 2, "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4795), null, "One of Egypt's most successful clubs", new DateTime(1911, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Zamalek_Logo.png", "Zamalek SC", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4795), false, false },
                    { 3, 3, "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4799), null, "Formerly known as Al Assiouty Sport", new DateTime(2008, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Pyramids_Logo.png", "Pyramids FC", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4799), false, false },
                    { 4, 4, "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4837), null, "Founded in 1920, known for winning the Egypt Cup in 1998", new DateTime(1920, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "El_Masry_Logo.png", "El Masry SC", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4837), false, false },
                    { 5, 5, "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4839), null, "Promoted to the Egyptian Premier League in 2020", new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Ceramica_Cleopatra_Logo.png", "Ceramica Cleopatra FC", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4840), false, false },
                    { 6, 6, "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4842), null, "Promoted to the Egyptian Premier League in 2020", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "National_Bank_Logo.png", "National Bank of Egypt SC", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4842), false, false },
                    { 7, 7, "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4844), null, "Formerly Future FC, promoted to the Egyptian Premier League in 2021", new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Modern_Sport_Logo.png", "Modern Sport FC", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4844), false, false },
                    { 8, 8, "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4846), null, "Formerly FC Masr, promoted to the Egyptian Premier League in 2023", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "ZED_Logo.png", "ZED FC", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4846), false, false },
                    { 9, 9, "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4848), null, "Founded in 1985, competes in the Egyptian Premier League, won Egypt Cup in 2005 and 2011", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "ENPPI_Logo.png", "ENPPI SC", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4848), false, false },
                    { 10, 10, "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4850), null, "Founded in 1948, competes in the Egyptian Premier League, runner-up in 2013-14", new DateTime(1948, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Smouha_Logo.png", "Smouha SC", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4850), false, false },
                    { 11, 12, "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4852), null, "Founded in 1996, competes in the Egyptian Premier League, won Egyptian Super Cup in 2007", new DateTime(1996, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Talaea_El_Gaish_Logo.png", "Tala'ea El Gaish SC", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4853), false, false },
                    { 12, 13, "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4855), null, "Founded in 1914, competes in the Egyptian Premier League, won Egypt Cup 6 times", new DateTime(1914, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Al_Ittihad_Alexandria_Logo.png", "Al Ittihad Alexandria", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4855), false, false },
                    { 13, 14, "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4857), null, "Founded in 1932, competes in the Egyptian Premier League, won Egypt Cup and Super Cup in 2009", new DateTime(1932, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Haras_El_Hodoud_Logo.png", "Haras El Hodoud SC", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4857), false, false },
                    { 14, 15, "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4859), null, "Founded in 2000, competes in the Egyptian Premier League, promoted in 2023-24", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Petrojet_Logo.png", "Petrojet SC", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4859), false, false },
                    { 15, 16, "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4861), null, "Founded in 1936, competes in the Egyptian Premier League, won the league in 1972-73", new DateTime(1936, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Ghazl_El_Mahalla_Logo.png", "Ghazl El Mahalla SC", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4861), false, false },
                    { 16, 17, "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4863), null, "Founded in 1924, competes in the Egyptian Premier League, won CAF Champions League in 1969, Egyptian Premier League 3 times(1967, 1991, 2002),and Egypt Cup twice(1997, 2000)", new DateTime(1924, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Ismaily_SC_Logo.png", "Ismaily SC", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4863), false, false },
                    { 17, 18, "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4865), null, "Founded in 2003, competes in the Egyptian Premier League, promoted in 2023-24", new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "El_Gouna_Logo.png", "El Gouna FC", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4865), false, false },
                    { 18, 19, "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4883), null, "Founded in 2010, competes in the Egyptian Premier League since 2021, based in Alexandria", new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Pharco_Logo.png", "Pharco FC", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4884), false, false },
                    { 19, 20, "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4886), null, "Founded in 1973, competes in the Egyptian Premier League, won the Egyptian Premier League in 1983, Egypt Cup 3 times (1990, 1995, 2004), and CAF Cup Winners' Cup 3 times (1982, 1983, 1996)", new DateTime(1973, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Al_Mokawloon_Al_Arab_Logo.png", "Al Mokawloon Al Arab SC", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4886), false, false },
                    { 20, 21, "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4887), null, "Founded in 2002, competes in Egyptian Second Division A, promoted to Egyptian Premier League in 2009-10", new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Wadi_Degla_Logo.png", "Wadi Degla SC", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4888), false, false },
                    { 21, 22, "Egypt", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4889), null, "Founded in 1935, competes in the Egyptian Premier League for the first time in 2025-26 after promotion from the Second Division A", new DateTime(1935, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Kahrabaa_Ismailia_Logo.png", "Kahrabaa Ismailia SC", new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(4890), false, false }
                });

            migrationBuilder.InsertData(
                table: "TeamPlayer",
                columns: new[] { "PlayerId", "TeamId", "CreatedAt", "DeletedAt", "IsActive", "IsCaptain", "IsDeleted", "JoinedDate", "LeftDate", "Number", "UpdatedAt", "isBigMatch", "isSold" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(6033), null, true, false, false, new DateTime(2016, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(6033), false, false },
                    { 2, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8314), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8315), false, false },
                    { 3, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8319), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8320), false, false },
                    { 4, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8321), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8321), false, false },
                    { 5, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8323), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8323), false, false },
                    { 6, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8324), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8324), false, false },
                    { 7, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8326), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8326), false, false },
                    { 8, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8327), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8328), false, false },
                    { 9, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8329), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8329), false, false },
                    { 10, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8331), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8331), false, false },
                    { 11, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8333), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8333), false, false },
                    { 12, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8358), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8358), false, false },
                    { 13, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8359), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8360), false, false },
                    { 14, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8361), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8361), false, false },
                    { 15, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8362), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8363), false, false },
                    { 16, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8364), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8364), false, false },
                    { 17, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8366), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8366), false, false },
                    { 18, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8367), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8368), false, false },
                    { 19, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8369), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8369), false, false },
                    { 20, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8370), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8371), false, false },
                    { 21, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8372), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8373), false, false },
                    { 22, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8374), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8374), false, false },
                    { 23, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8376), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8376), false, false },
                    { 24, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8377), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8377), false, false },
                    { 25, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8379), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8379), false, false },
                    { 26, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8380), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8381), false, false },
                    { 27, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8398), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8399), false, false },
                    { 28, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8400), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8401), false, false },
                    { 29, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8402), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 38, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8402), false, false },
                    { 30, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8431), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8431), false, false },
                    { 31, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8433), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8433), false, false },
                    { 32, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8435), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8435), false, false },
                    { 33, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8436), null, true, false, false, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8436), false, false },
                    { 34, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8438), null, true, false, false, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8438), false, false },
                    { 35, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8439), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8440), false, false },
                    { 36, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8443), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8443), false, false },
                    { 37, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8445), null, true, false, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8445), false, false },
                    { 38, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8446), null, true, false, false, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8446), false, false },
                    { 39, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8448), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8448), false, false },
                    { 40, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8449), null, true, false, false, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8450), false, false },
                    { 41, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8451), null, true, false, false, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8452), false, false },
                    { 42, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8468), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8469), false, false },
                    { 43, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8470), null, true, false, false, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8470), false, false },
                    { 44, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8472), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8472), false, false },
                    { 45, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8473), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8473), false, false },
                    { 46, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8475), null, true, false, false, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8475), false, false },
                    { 47, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8476), null, true, false, false, new DateTime(2003, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8477), false, false },
                    { 48, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8478), null, true, false, false, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8478), false, false },
                    { 49, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8479), null, true, false, false, new DateTime(2015, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8480), false, false },
                    { 50, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8481), null, true, false, false, new DateTime(2011, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8481), false, false },
                    { 51, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8482), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8483), false, false },
                    { 52, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8484), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8484), false, false },
                    { 53, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8485), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8486), false, false },
                    { 54, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8487), null, true, false, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8487), false, false },
                    { 55, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8489), null, true, false, false, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8489), false, false },
                    { 56, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8490), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8490), false, false },
                    { 57, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8492), null, true, false, false, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8492), false, false },
                    { 58, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8508), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8509), false, false },
                    { 59, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8510), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8510), false, false },
                    { 60, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8512), null, true, false, false, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8512), false, false },
                    { 61, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8513), null, true, false, false, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8513), false, false },
                    { 62, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8515), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8515), false, false },
                    { 63, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8516), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8516), false, false },
                    { 64, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8518), null, true, false, false, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8518), false, false },
                    { 65, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8519), null, true, false, false, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8520), false, false },
                    { 66, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8521), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8521), false, false },
                    { 67, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8522), null, true, false, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8523), false, false },
                    { 68, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8524), null, true, false, false, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8525), false, false },
                    { 69, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8526), null, true, false, false, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8526), false, false },
                    { 70, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8527), null, true, false, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8528), false, false },
                    { 71, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8529), null, true, false, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8529), false, false },
                    { 72, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8530), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8531), false, false },
                    { 73, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8548), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8548), false, false },
                    { 74, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8549), null, true, false, false, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8550), false, false },
                    { 75, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8551), null, true, false, false, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8551), false, false },
                    { 76, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8552), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8553), false, false },
                    { 77, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8554), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8554), false, false },
                    { 78, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8556), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8556), false, false },
                    { 79, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8557), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8557), false, false },
                    { 80, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8559), null, true, false, false, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8559), false, false },
                    { 81, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8560), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8560), false, false },
                    { 82, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8562), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8562), false, false },
                    { 83, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8563), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8563), false, false },
                    { 84, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8565), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8565), false, false },
                    { 85, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8566), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8567), false, false },
                    { 86, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8568), null, true, false, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8568), false, false },
                    { 87, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8569), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8570), false, false },
                    { 88, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8571), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8571), false, false },
                    { 89, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8588), null, true, false, false, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8589), false, false },
                    { 90, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8590), null, true, false, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8590), false, false },
                    { 91, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8591), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8592), false, false },
                    { 92, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8593), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8593), false, false },
                    { 93, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8595), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8595), false, false },
                    { 94, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8596), null, true, false, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8597), false, false },
                    { 95, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8598), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8598), false, false },
                    { 96, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8658), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8659), false, false },
                    { 97, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8660), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8661), false, false },
                    { 98, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8662), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8662), false, false },
                    { 99, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8664), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8664), false, false },
                    { 100, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8665), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8665), false, false },
                    { 101, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8667), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8667), false, false },
                    { 102, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8668), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8668), false, false },
                    { 103, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8670), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8670), false, false },
                    { 104, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8688), null, true, false, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8688), false, false },
                    { 105, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8690), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8690), false, false },
                    { 106, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8691), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8691), false, false },
                    { 107, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8693), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8693), false, false },
                    { 108, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8694), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8694), false, false },
                    { 109, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8696), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8696), false, false },
                    { 110, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8697), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8698), false, false },
                    { 111, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8699), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8699), false, false },
                    { 112, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8700), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8701), false, false },
                    { 113, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8702), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8702), false, false },
                    { 114, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8704), null, true, false, false, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8704), false, false },
                    { 115, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8705), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8705), false, false },
                    { 116, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8707), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8707), false, false },
                    { 117, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8708), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8708), false, false },
                    { 118, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8710), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8710), false, false },
                    { 119, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8727), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8727), false, false },
                    { 120, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8729), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8729), false, false },
                    { 121, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8730), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8731), false, false },
                    { 122, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8732), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8732), false, false },
                    { 123, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8733), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8734), false, false },
                    { 124, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8735), null, true, false, false, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8735), false, false },
                    { 125, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8737), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8737), false, false },
                    { 126, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8738), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8738), false, false },
                    { 127, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8740), null, true, false, false, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8740), false, false },
                    { 128, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8741), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8741), false, false },
                    { 129, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8743), null, true, false, false, new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8743), false, false },
                    { 130, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8744), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8745), false, false },
                    { 131, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8746), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8746), false, false },
                    { 132, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8747), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8748), false, false },
                    { 133, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8749), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8749), false, false },
                    { 134, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8751), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8751), false, false },
                    { 135, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8768), null, true, false, false, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8769), false, false },
                    { 136, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8770), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8770), false, false },
                    { 137, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8771), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8772), false, false },
                    { 138, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8773), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8773), false, false },
                    { 139, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8774), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8775), false, false },
                    { 140, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8776), null, true, false, false, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8776), false, false },
                    { 141, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8778), null, true, false, false, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8778), false, false },
                    { 142, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8779), null, true, false, false, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8779), false, false },
                    { 143, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8781), null, true, false, false, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8781), false, false },
                    { 144, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8782), null, true, false, false, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8783), false, false },
                    { 145, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8784), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8784), false, false },
                    { 146, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8785), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8786), false, false },
                    { 147, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8787), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8787), false, false },
                    { 148, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8789), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8789), false, false },
                    { 149, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8790), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8790), false, false },
                    { 150, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8808), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8808), false, false },
                    { 151, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8810), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8810), false, false },
                    { 152, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8811), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8811), false, false },
                    { 153, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8813), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8813), false, false },
                    { 154, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8814), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8814), false, false },
                    { 155, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8816), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8817), false, false },
                    { 156, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8818), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8818), false, false },
                    { 157, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8820), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8820), false, false },
                    { 158, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8821), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8822), false, false },
                    { 159, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8823), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8824), false, false },
                    { 160, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8993), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8994), false, false },
                    { 161, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8995), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8996), false, false },
                    { 162, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8997), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8997), false, false },
                    { 163, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8999), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(8999), false, false },
                    { 164, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9054), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9054), false, false },
                    { 165, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9055), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9056), false, false },
                    { 166, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9073), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9073), false, false },
                    { 167, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9075), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9075), false, false },
                    { 168, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9076), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9077), false, false },
                    { 169, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9078), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9078), false, false },
                    { 170, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9080), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9080), false, false },
                    { 171, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9081), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9082), false, false },
                    { 172, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9083), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9084), false, false },
                    { 173, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9085), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9085), false, false },
                    { 174, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9086), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9087), false, false },
                    { 175, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9088), null, true, false, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9089), false, false },
                    { 176, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9090), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9090), false, false },
                    { 177, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9092), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9092), false, false },
                    { 178, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9093), null, true, false, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9093), false, false },
                    { 179, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9095), null, true, false, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9095), false, false },
                    { 180, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9096), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9097), false, false },
                    { 181, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9114), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9114), false, false },
                    { 182, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9116), null, true, false, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9116), false, false },
                    { 183, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9117), null, true, false, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9118), false, false },
                    { 184, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9119), null, true, false, false, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9119), false, false },
                    { 185, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9121), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9121), false, false },
                    { 186, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9122), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9122), false, false },
                    { 187, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9124), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9124), false, false },
                    { 188, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9125), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9126), false, false },
                    { 189, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9127), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9127), false, false },
                    { 190, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9128), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9129), false, false },
                    { 191, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9130), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9130), false, false },
                    { 192, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9132), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9132), false, false },
                    { 193, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9133), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9133), false, false },
                    { 194, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9135), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9135), false, false },
                    { 195, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9136), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9137), false, false },
                    { 196, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9155), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9155), false, false },
                    { 197, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9156), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9157), false, false },
                    { 198, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9158), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9158), false, false },
                    { 199, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9160), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9160), false, false },
                    { 200, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9161), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9162), false, false },
                    { 201, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9163), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9163), false, false },
                    { 202, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9164), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9165), false, false },
                    { 203, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9166), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9166), false, false },
                    { 204, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9168), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9168), false, false },
                    { 205, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9169), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9169), false, false },
                    { 206, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9171), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9171), false, false },
                    { 207, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9172), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9173), false, false },
                    { 208, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9174), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9174), false, false },
                    { 209, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9176), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9176), false, false },
                    { 210, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9177), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9178), false, false },
                    { 211, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9179), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9179), false, false },
                    { 212, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9196), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9197), false, false },
                    { 213, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9198), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9198), false, false },
                    { 214, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9200), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9200), false, false },
                    { 215, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9201), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9201), false, false },
                    { 216, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9203), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9203), false, false },
                    { 217, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9204), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9205), false, false },
                    { 218, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9206), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9206), false, false },
                    { 219, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9208), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9208), false, false },
                    { 220, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9209), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9209), false, false },
                    { 221, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9211), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9211), false, false },
                    { 222, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9212), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9213), false, false },
                    { 223, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9214), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9214), false, false },
                    { 224, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9215), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9216), false, false },
                    { 225, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9217), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9217), false, false },
                    { 226, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9219), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9219), false, false },
                    { 227, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9236), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9237), false, false },
                    { 228, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9238), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9238), false, false },
                    { 229, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9240), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9240), false, false },
                    { 230, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9241), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 32, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9241), false, false },
                    { 231, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9243), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9243), false, false },
                    { 232, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9244), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9245), false, false },
                    { 233, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9282), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9283), false, false },
                    { 234, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9284), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9285), false, false },
                    { 235, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9286), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9286), false, false },
                    { 236, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9288), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9288), false, false },
                    { 237, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9289), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9290), false, false },
                    { 238, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9291), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9291), false, false },
                    { 239, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9293), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9293), false, false },
                    { 240, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9294), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9295), false, false },
                    { 241, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9296), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9296), false, false },
                    { 242, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9298), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9298), false, false },
                    { 243, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9315), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9316), false, false },
                    { 244, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9317), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9317), false, false },
                    { 245, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9319), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9319), false, false },
                    { 246, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9321), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9321), false, false },
                    { 247, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9322), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9322), false, false },
                    { 248, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9324), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9324), false, false },
                    { 249, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9325), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9326), false, false },
                    { 250, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9327), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9327), false, false },
                    { 251, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9329), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9329), false, false },
                    { 252, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9330), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9331), false, false },
                    { 253, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9332), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9332), false, false },
                    { 254, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9334), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9334), false, false },
                    { 255, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9335), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9335), false, false },
                    { 256, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9337), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9337), false, false },
                    { 257, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9339), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9339), false, false },
                    { 258, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9357), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9357), false, false },
                    { 259, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9359), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9359), false, false },
                    { 260, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9360), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9361), false, false },
                    { 261, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9362), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9362), false, false },
                    { 262, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9364), null, true, false, false, new DateTime(2014, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9364), false, false },
                    { 263, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9365), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9365), false, false },
                    { 264, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9367), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9367), false, false },
                    { 265, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9368), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9369), false, false },
                    { 266, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9370), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9370), false, false },
                    { 267, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9372), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9372), false, false },
                    { 268, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9373), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9374), false, false },
                    { 269, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9375), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9375), false, false },
                    { 270, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9377), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9377), false, false },
                    { 271, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9378), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9378), false, false },
                    { 272, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9380), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9380), false, false },
                    { 273, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9397), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9397), false, false },
                    { 274, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9399), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9399), false, false },
                    { 275, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9400), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9401), false, false },
                    { 276, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9402), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9402), false, false },
                    { 277, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9404), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9404), false, false },
                    { 278, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9405), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9406), false, false },
                    { 279, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9407), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9407), false, false },
                    { 280, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9408), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9409), false, false },
                    { 281, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9410), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9410), false, false },
                    { 282, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9412), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9412), false, false },
                    { 283, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9413), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9414), false, false },
                    { 284, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9415), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9416), false, false },
                    { 285, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9417), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9417), false, false },
                    { 286, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9419), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9419), false, false },
                    { 287, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9420), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9420), false, false },
                    { 288, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9422), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9422), false, false },
                    { 289, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9439), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9440), false, false },
                    { 290, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9441), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9441), false, false },
                    { 291, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9443), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9443), false, false },
                    { 292, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9444), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9445), false, false },
                    { 293, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9446), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9446), false, false },
                    { 294, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9447), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9448), false, false },
                    { 295, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9449), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9449), false, false },
                    { 296, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9451), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9451), false, false },
                    { 297, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9452), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9453), false, false },
                    { 298, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9454), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9454), false, false },
                    { 299, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9455), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9456), false, false },
                    { 300, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9457), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9457), false, false },
                    { 301, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9496), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9497), false, false },
                    { 302, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9498), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9499), false, false },
                    { 303, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9501), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9501), false, false },
                    { 304, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9519), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9520), false, false },
                    { 305, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9521), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9522), false, false },
                    { 306, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9523), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9523), false, false },
                    { 307, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9524), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9525), false, false },
                    { 308, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9526), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9526), false, false },
                    { 309, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9528), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9528), false, false },
                    { 310, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9529), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9530), false, false },
                    { 311, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9531), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9531), false, false },
                    { 312, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9533), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9534), false, false },
                    { 313, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9535), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9535), false, false },
                    { 314, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9537), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9537), false, false },
                    { 315, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9541), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9541), false, false },
                    { 316, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9542), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9543), false, false },
                    { 317, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9544), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9544), false, false },
                    { 318, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9545), null, true, false, false, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9546), false, false },
                    { 319, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9547), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9547), false, false },
                    { 320, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9565), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9565), false, false },
                    { 321, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9566), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9567), false, false },
                    { 322, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9568), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9568), false, false },
                    { 323, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9570), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9570), false, false },
                    { 324, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9571), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9572), false, false },
                    { 325, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9573), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9573), false, false },
                    { 326, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9574), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9575), false, false },
                    { 327, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9576), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9576), false, false },
                    { 328, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9578), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9578), false, false },
                    { 329, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9579), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9580), false, false },
                    { 330, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9581), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9581), false, false },
                    { 331, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9583), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9583), false, false },
                    { 332, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9584), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9584), false, false },
                    { 333, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9586), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9586), false, false },
                    { 334, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9587), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9588), false, false },
                    { 335, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9605), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9606), false, false },
                    { 336, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9607), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9607), false, false },
                    { 337, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9609), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9609), false, false },
                    { 338, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9610), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9611), false, false },
                    { 339, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9612), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9612), false, false },
                    { 340, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9614), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9614), false, false },
                    { 341, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9615), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9615), false, false },
                    { 342, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9617), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9617), false, false },
                    { 343, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9618), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9618), false, false },
                    { 344, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9620), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9620), false, false },
                    { 345, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9621), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9622), false, false },
                    { 346, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9623), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9623), false, false },
                    { 347, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9625), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 32, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9625), false, false },
                    { 348, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9626), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9626), false, false },
                    { 349, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9629), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9629), false, false },
                    { 350, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9646), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9647), false, false },
                    { 351, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9648), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9648), false, false },
                    { 352, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9650), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9650), false, false },
                    { 353, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9651), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9651), false, false },
                    { 354, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9653), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9653), false, false },
                    { 355, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9654), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9655), false, false },
                    { 356, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9656), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9656), false, false },
                    { 357, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9658), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9658), false, false },
                    { 358, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9659), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9660), false, false },
                    { 359, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9661), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9661), false, false },
                    { 360, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9663), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9663), false, false },
                    { 361, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9664), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9664), false, false },
                    { 362, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9666), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9666), false, false },
                    { 363, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9667), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9668), false, false },
                    { 364, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9669), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9669), false, false },
                    { 365, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9671), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9671), false, false },
                    { 366, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9689), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9689), false, false },
                    { 367, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9690), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9690), false, false },
                    { 368, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9692), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9692), false, false },
                    { 369, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9730), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9730), false, false },
                    { 370, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9732), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9732), false, false },
                    { 371, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9734), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9734), false, false },
                    { 372, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9735), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9735), false, false },
                    { 373, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9737), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9737), false, false },
                    { 374, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9738), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9739), false, false },
                    { 375, 13, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9740), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9740), false, false },
                    { 376, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9741), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9742), false, false },
                    { 377, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9743), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9743), false, false },
                    { 378, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9745), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9745), false, false },
                    { 379, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9746), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9746), false, false },
                    { 380, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9748), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9748), false, false },
                    { 381, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9766), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9766), false, false },
                    { 382, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9768), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9768), false, false },
                    { 383, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9769), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9769), false, false },
                    { 384, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9771), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9771), false, false },
                    { 385, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9772), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9773), false, false },
                    { 386, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9774), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9774), false, false },
                    { 387, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9776), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9776), false, false },
                    { 388, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9777), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9777), false, false },
                    { 389, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9779), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9779), false, false },
                    { 390, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9780), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9781), false, false },
                    { 391, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9782), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9782), false, false },
                    { 392, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9783), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9784), false, false },
                    { 393, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9785), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9785), false, false },
                    { 394, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9786), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9787), false, false },
                    { 395, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9788), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9788), false, false },
                    { 396, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9790), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9790), false, false },
                    { 397, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9808), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9808), false, false },
                    { 398, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9809), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9810), false, false },
                    { 399, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9811), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9811), false, false },
                    { 400, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9812), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9813), false, false },
                    { 401, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9814), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9814), false, false },
                    { 402, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9816), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9816), false, false },
                    { 403, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9817), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9817), false, false },
                    { 404, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9819), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9819), false, false },
                    { 405, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9820), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9821), false, false },
                    { 406, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9822), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9822), false, false },
                    { 407, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9824), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9824), false, false },
                    { 408, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9825), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9825), false, false },
                    { 409, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9827), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9827), false, false },
                    { 410, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9828), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9829), false, false },
                    { 411, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9830), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9831), false, false },
                    { 412, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9851), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9851), false, false },
                    { 413, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9852), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9853), false, false },
                    { 414, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9854), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9854), false, false },
                    { 415, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9856), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9856), false, false },
                    { 416, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9857), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9857), false, false },
                    { 417, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9859), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9859), false, false },
                    { 418, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9860), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9861), false, false },
                    { 419, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9862), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9862), false, false },
                    { 420, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9863), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9864), false, false },
                    { 421, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9865), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9865), false, false },
                    { 422, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9867), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9867), false, false },
                    { 423, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9868), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9868), false, false },
                    { 424, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9870), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9870), false, false },
                    { 425, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9871), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9871), false, false },
                    { 426, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9873), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9873), false, false },
                    { 427, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9890), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9890), false, false },
                    { 428, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9892), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9892), false, false },
                    { 429, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9893), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9894), false, false },
                    { 430, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9895), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9895), false, false },
                    { 431, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9897), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9897), false, false },
                    { 432, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9898), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9899), false, false },
                    { 433, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9900), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9900), false, false },
                    { 434, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9901), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9902), false, false },
                    { 435, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9903), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9903), false, false },
                    { 436, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9905), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9905), false, false },
                    { 437, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9906), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9907), false, false },
                    { 438, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9946), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9946), false, false },
                    { 439, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9947), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9948), false, false },
                    { 440, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9949), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9949), false, false },
                    { 441, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9951), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9951), false, false },
                    { 442, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9952), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9953), false, false },
                    { 443, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9970), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9970), false, false },
                    { 444, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9972), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9972), false, false },
                    { 445, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9973), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9974), false, false },
                    { 446, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9975), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9975), false, false },
                    { 447, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9977), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9977), false, false },
                    { 448, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9978), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9979), false, false },
                    { 449, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9980), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9980), false, false },
                    { 450, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9982), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9982), false, false },
                    { 451, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9984), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9984), false, false },
                    { 452, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9985), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9985), false, false },
                    { 453, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9987), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9987), false, false },
                    { 454, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9988), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9989), false, false },
                    { 455, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9990), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9990), false, false },
                    { 456, 16, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9991), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9992), false, false },
                    { 457, 17, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9993), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 9, 2, 19, 43, 35, 80, DateTimeKind.Utc).AddTicks(9993), false, false },
                    { 458, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(11), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(11), false, false },
                    { 459, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(12), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(13), false, false },
                    { 460, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(14), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(14), false, false },
                    { 461, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(16), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(16), false, false },
                    { 462, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(17), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(18), false, false },
                    { 463, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(19), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(19), false, false },
                    { 464, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(20), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(21), false, false },
                    { 465, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(22), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(22), false, false },
                    { 466, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(24), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(24), false, false },
                    { 467, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(25), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(25), false, false },
                    { 468, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(27), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(27), false, false },
                    { 469, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(28), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(28), false, false },
                    { 470, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(30), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(30), false, false },
                    { 471, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(31), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(31), false, false },
                    { 472, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(33), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(33), false, false },
                    { 473, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(34), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(35), false, false },
                    { 474, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(52), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(52), false, false },
                    { 475, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(54), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(54), false, false },
                    { 476, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(55), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(55), false, false },
                    { 477, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(57), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(57), false, false },
                    { 478, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(58), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(59), false, false },
                    { 479, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(60), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(60), false, false },
                    { 480, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(61), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(62), false, false },
                    { 481, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(63), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(63), false, false },
                    { 482, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(65), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(65), false, false },
                    { 483, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(66), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(66), false, false },
                    { 484, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(68), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(68), false, false },
                    { 485, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(69), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(70), false, false },
                    { 486, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(71), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(71), false, false },
                    { 487, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(72), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(73), false, false },
                    { 488, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(74), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(74), false, false },
                    { 489, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(94), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(94), false, false },
                    { 490, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(95), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(96), false, false },
                    { 491, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(97), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(97), false, false },
                    { 492, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(99), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(99), false, false },
                    { 493, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(100), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(100), false, false },
                    { 494, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(102), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(102), false, false },
                    { 495, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(103), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(104), false, false },
                    { 496, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(105), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(105), false, false },
                    { 497, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(106), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(107), false, false },
                    { 498, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(108), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(108), false, false },
                    { 499, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(110), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(110), false, false },
                    { 500, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(111), null, true, false, false, new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(111), false, false },
                    { 501, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(113), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(113), false, false },
                    { 502, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(114), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(115), false, false },
                    { 503, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(116), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(116), false, false },
                    { 504, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(134), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(134), false, false },
                    { 505, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(136), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(136), false, false },
                    { 506, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(173), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(173), false, false },
                    { 507, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(175), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(175), false, false },
                    { 508, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(176), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(177), false, false },
                    { 509, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(178), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 32, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(178), false, false },
                    { 510, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(180), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(180), false, false },
                    { 511, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(181), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(182), false, false },
                    { 512, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(183), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(183), false, false },
                    { 513, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(185), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(185), false, false },
                    { 514, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(186), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(187), false, false },
                    { 515, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(188), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(188), false, false },
                    { 516, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(189), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(190), false, false },
                    { 517, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(191), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(191), false, false },
                    { 518, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(193), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(193), false, false },
                    { 519, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(194), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(195), false, false },
                    { 520, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(212), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(212), false, false },
                    { 521, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(213), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(214), false, false },
                    { 522, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(215), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(215), false, false },
                    { 523, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(217), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(217), false, false },
                    { 524, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(218), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(219), false, false },
                    { 525, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(220), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(220), false, false },
                    { 526, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(221), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(222), false, false },
                    { 527, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(223), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(223), false, false },
                    { 528, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(225), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(225), false, false },
                    { 529, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(226), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(227), false, false },
                    { 530, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(228), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(228), false, false },
                    { 531, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(229), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(230), false, false },
                    { 532, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(231), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(231), false, false },
                    { 533, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(233), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(233), false, false },
                    { 534, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(234), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(235), false, false },
                    { 535, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(252), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(252), false, false },
                    { 536, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(254), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(255), false, false },
                    { 537, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(256), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(256), false, false },
                    { 538, 20, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(258), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(258), false, false },
                    { 539, 20, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(259), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(260), false, false },
                    { 540, 20, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(261), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(261), false, false },
                    { 541, 20, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(263), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(263), false, false },
                    { 542, 20, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(264), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(264), false, false },
                    { 543, 20, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(266), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(266), false, false },
                    { 544, 20, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(267), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(268), false, false },
                    { 545, 20, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(269), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(269), false, false },
                    { 546, 20, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(270), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(271), false, false },
                    { 547, 20, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(272), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(272), false, false },
                    { 548, 20, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(274), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(274), false, false },
                    { 549, 20, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(276), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(276), false, false },
                    { 550, 20, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(277), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(278), false, false },
                    { 551, 20, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(295), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(295), false, false },
                    { 552, 20, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(297), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(297), false, false },
                    { 553, 20, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(298), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(299), false, false },
                    { 554, 20, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(300), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(300), false, false },
                    { 555, 20, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(301), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(302), false, false },
                    { 556, 20, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(304), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(304), false, false },
                    { 557, 20, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(306), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(306), false, false },
                    { 558, 21, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(307), null, true, false, false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(307), false, false },
                    { 559, 21, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(309), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(309), false, false },
                    { 560, 21, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(310), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(311), false, false },
                    { 561, 21, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(312), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(312), false, false },
                    { 562, 21, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(313), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(314), false, false },
                    { 563, 21, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(315), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(315), false, false },
                    { 564, 21, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(316), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(317), false, false },
                    { 565, 21, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(318), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(318), false, false },
                    { 566, 21, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(320), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(320), false, false },
                    { 567, 21, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(321), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(322), false, false },
                    { 568, 21, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(323), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(323), false, false },
                    { 569, 21, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(325), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(325), false, false },
                    { 570, 21, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(326), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(326), false, false },
                    { 571, 21, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(328), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(328), false, false },
                    { 572, 21, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(329), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(330), false, false },
                    { 573, 21, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(331), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(331), false, false },
                    { 574, 21, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(353), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(354), false, false },
                    { 575, 21, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(355), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(355), false, false },
                    { 576, 21, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(357), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(357), false, false },
                    { 577, 21, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(358), null, true, false, false, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2025, 9, 2, 19, 43, 35, 81, DateTimeKind.Utc).AddTicks(359), false, false }
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

            migrationBuilder.DropColumn(
                name: "CurrentPrice",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "IsPromoted",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "PriceUpdatedAt",
                table: "Tickets");
        }
    }
}
