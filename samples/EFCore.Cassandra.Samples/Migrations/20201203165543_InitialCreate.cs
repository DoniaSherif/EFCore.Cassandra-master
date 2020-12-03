﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Numerics;
using Cassandra;
using EFCore.Cassandra.Samples.Models;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore.Cassandra.Samples.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "bundles");

            migrationBuilder.CreateTable(
                name: "applicants",
                schema: "bundles",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    ApplicantId = table.Column<Guid>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    Long = table.Column<long>(nullable: false),
                    Bool = table.Column<bool>(nullable: false),
                    Decimal = table.Column<decimal>(nullable: false),
                    Double = table.Column<double>(nullable: false),
                    Float = table.Column<float>(nullable: false),
                    Integer = table.Column<int>(nullable: false),
                    SmallInt = table.Column<short>(nullable: false),
                    DateTimeOffset = table.Column<DateTimeOffset>(nullable: false),
                    TimeUuid = table.Column<Guid>(nullable: false),
                    Sbyte = table.Column<sbyte>(nullable: false),
                    BigInteger = table.Column<BigInteger>(nullable: false),
                    Blob = table.Column<byte[]>(nullable: true),
                    LocalDate = table.Column<LocalDate>(nullable: true),
                    Ip = table.Column<IPAddress>(nullable: true),
                    LocalTime = table.Column<LocalTime>(nullable: true),
                    Dic = table.Column<IDictionary<string, string>>(nullable: true),
                    Address = table.Column<ApplicantAddress>(type: "applicant_addr", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_applicants", x => new { x.id, x.Order });
                });

            migrationBuilder.CreateUserDefinedType(
                name: "applicant_addr",
                schema: "bundles",
                columns: table => new
                {
                    City = table.Column<string>(nullable: true),
                    StreetNumber = table.Column<int>(nullable: false)
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "applicants",
                schema: "bundles");

            migrationBuilder.EnsureSchema(
                name: "bundles");

            migrationBuilder.DropUserDefinedType(
                name: "applicant_addr",
                schema: "bundles");
        }
    }
}
