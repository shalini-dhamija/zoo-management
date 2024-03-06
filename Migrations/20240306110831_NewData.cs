using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZooManagement.Migrations
{
    /// <inheritdoc />
    public partial class NewData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "DateOfAcquisition", "DateOfBirth", "Name", "Sex", "SpeciesId" },
                values: new object[,]
                {
                    { 4, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(8720), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(8725), "Garfield", 0, -1 },
                    { 36, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9442), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9449), "Snoopy", 0, -1 },
                    { 39, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9490), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9496), "Snoopy", 1, -1 },
                    { 54, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9746), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9753), "Tabatha", 0, -1 },
                    { 59, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9823), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9829), "Snoopy", 1, -1 },
                    { 67, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9962), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9967), "Pooh", 0, -1 },
                    { 69, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9993), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9999), "Peter", 0, -1 },
                    { 77, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(127), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(133), "Winston", 1, -1 },
                    { 84, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(263), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(270), "Spot", 1, -1 },
                    { 85, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(279), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(286), "Kanga", 1, -1 },
                    { 88, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(330), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(336), "Pooh", 1, -1 }
                });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "Id", "Classification", "Name" },
                values: new object[,]
                {
                    { 1, 0, "elephant" },
                    { 2, 0, "zebra" },
                    { 3, 1, "snake" },
                    { 4, 0, "giraffe" },
                    { 5, 3, "spider" },
                    { 6, 0, "hippo" },
                    { 7, 2, "parrot" },
                    { 8, 4, "goldfish" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "DateOfAcquisition", "DateOfBirth", "Name", "Sex", "SpeciesId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(8625), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(8667), "Snoopy", 0, 7 },
                    { 2, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(8685), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(8692), "Daffy", 1, 3 },
                    { 3, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(8704), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(8710), "Kanga", 1, 2 },
                    { 5, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(8735), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(8741), "Daffy", 1, 2 },
                    { 6, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(8750), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(8757), "Daffy", 0, 1 },
                    { 7, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(8922), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(8933), "Garfield", 1, 5 },
                    { 8, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(8946), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(8953), "Winston", 1, 4 },
                    { 9, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(8965), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(8972), "Winston", 1, 1 },
                    { 10, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(8983), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(8990), "Spot", 0, 4 },
                    { 11, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9001), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9008), "Mickey", 1, 3 },
                    { 12, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9018), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9025), "Pooh", 1, 5 },
                    { 13, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9037), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9044), "Tabatha", 1, 3 },
                    { 14, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9055), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9062), "Snoopy", 0, 7 },
                    { 15, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9073), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9080), "Spot", 1, 6 },
                    { 16, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9092), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9099), "Snoopy", 0, 6 },
                    { 17, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9108), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9114), "Tabatha", 0, 6 },
                    { 18, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9126), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9134), "Pooh", 1, 7 },
                    { 19, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9146), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9152), "Kanga", 1, 2 },
                    { 20, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9163), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9170), "Tabatha", 0, 4 },
                    { 21, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9179), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9184), "Piglet", 0, 7 },
                    { 22, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9194), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9200), "Garfield", 1, 6 },
                    { 23, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9209), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9216), "Piglet", 1, 4 },
                    { 24, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9227), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9234), "Garfield", 0, 3 },
                    { 25, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9245), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9251), "Tabatha", 0, 3 },
                    { 26, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9263), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9269), "Winston", 1, 2 },
                    { 27, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9279), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9285), "Daffy", 1, 6 },
                    { 28, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9296), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9302), "Peter", 1, 3 },
                    { 29, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9313), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9318), "Garfield", 0, 3 },
                    { 30, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9327), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9335), "Tabatha", 0, 2 },
                    { 31, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9346), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9353), "Spot", 0, 3 },
                    { 32, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9363), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9371), "Mickey", 0, 6 },
                    { 33, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9384), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9392), "Piglet", 0, 5 },
                    { 34, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9404), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9412), "Piglet", 1, 2 },
                    { 35, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9425), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9431), "Mickey", 1, 5 },
                    { 37, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9459), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9464), "Piglet", 1, 1 },
                    { 38, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9474), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9481), "Tabatha", 1, 3 },
                    { 40, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9506), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9511), "Mickey", 0, 7 },
                    { 41, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9521), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9528), "Mickey", 0, 1 },
                    { 42, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9537), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9543), "Pooh", 0, 3 },
                    { 43, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9552), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9558), "Daffy", 1, 4 },
                    { 44, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9567), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9574), "Daffy", 1, 7 },
                    { 45, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9584), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9591), "Snoopy", 0, 1 },
                    { 46, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9603), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9609), "Garfield", 1, 5 },
                    { 47, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9621), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9629), "Spot", 1, 4 },
                    { 48, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9641), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9649), "Winston", 1, 4 },
                    { 49, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9663), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9669), "Peter", 0, 4 },
                    { 50, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9679), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9686), "Pooh", 1, 7 },
                    { 51, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9697), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9703), "Tabatha", 1, 6 },
                    { 52, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9715), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9721), "Peter", 1, 5 },
                    { 53, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9731), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9736), "Garfield", 0, 7 },
                    { 55, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9763), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9768), "Spot", 1, 1 },
                    { 56, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9778), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9783), "Tabatha", 0, 4 },
                    { 57, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9793), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9799), "Winston", 0, 1 },
                    { 58, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9808), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9813), "Snoopy", 0, 6 },
                    { 60, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9837), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9843), "Pooh", 1, 3 },
                    { 61, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9855), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9863), "Tabatha", 1, 1 },
                    { 62, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9873), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9878), "Mickey", 1, 1 },
                    { 63, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9889), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9897), "Pooh", 1, 2 },
                    { 64, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9908), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9914), "Winston", 0, 2 },
                    { 65, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9927), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9935), "Mickey", 1, 3 },
                    { 66, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9945), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9952), "Tabatha", 1, 2 },
                    { 68, new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9976), new DateTime(2024, 3, 6, 11, 8, 31, 111, DateTimeKind.Utc).AddTicks(9983), "Winston", 0, 1 },
                    { 70, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(9), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(16), "Daffy", 0, 6 },
                    { 71, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(25), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(32), "Daffy", 0, 1 },
                    { 72, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(44), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(52), "Daffy", 0, 7 },
                    { 73, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(64), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(69), "Pooh", 0, 5 },
                    { 74, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(81), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(87), "Winston", 1, 2 },
                    { 75, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(98), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(104), "Garfield", 0, 1 },
                    { 76, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(113), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(119), "Peter", 0, 4 },
                    { 78, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(143), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(149), "Garfield", 0, 7 },
                    { 79, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(159), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(167), "Mickey", 0, 2 },
                    { 80, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(191), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(198), "Pooh", 1, 7 },
                    { 81, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(214), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(220), "Kanga", 0, 5 },
                    { 82, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(229), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(235), "Spot", 1, 7 },
                    { 83, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(246), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(252), "Spot", 0, 1 },
                    { 86, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(297), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(303), "Pooh", 0, 1 },
                    { 87, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(313), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(319), "Pooh", 0, 2 },
                    { 89, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(346), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(353), "Pooh", 1, 6 },
                    { 90, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(366), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(374), "Tabatha", 1, 3 },
                    { 91, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(387), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(395), "Garfield", 1, 2 },
                    { 92, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(407), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(414), "Daffy", 0, 1 },
                    { 93, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(537), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(547), "Daffy", 1, 1 },
                    { 94, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(559), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(566), "Pooh", 0, 6 },
                    { 95, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(576), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(583), "Kanga", 0, 2 },
                    { 96, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(593), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(600), "Pooh", 1, 4 },
                    { 97, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(610), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(616), "Winston", 1, 1 },
                    { 98, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(625), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(632), "Tabatha", 1, 2 },
                    { 99, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(641), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(648), "Kanga", 0, 7 },
                    { 100, new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(661), new DateTime(2024, 3, 6, 11, 8, 31, 112, DateTimeKind.Utc).AddTicks(668), "Daffy", 1, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
