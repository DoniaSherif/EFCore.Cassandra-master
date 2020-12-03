﻿// <auto-generated />
using System;
using System.Collections.Generic;
using System.Net;
using System.Numerics;
using Cassandra;
using EFCore.Cassandra.Samples;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCore.Cassandra.Samples.Migrations
{
    [DbContext(typeof(FakeDbContext))]
    [Migration("20201203165543_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Cassandra:KeyspaceConfiguration", "{\"ReplicationFactor\":2,\"ReplicationClass\":0}")
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("EFCore.Cassandra.Samples.Models.Applicant", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<Guid>("ApplicantId")
                        .HasColumnType("uuid");

                    b.Property<BigInteger>("BigInteger")
                        .HasColumnType("varint");

                    b.Property<byte[]>("Blob")
                        .HasColumnType("blob");

                    b.Property<bool>("Bool")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset>("DateTimeOffset")
                        .HasColumnType("timestamp");

                    b.Property<decimal>("Decimal")
                        .HasColumnType("decimal");

                    b.Property<IDictionary<string, string>>("Dic")
                        .HasColumnType("map<text,text>");

                    b.Property<double>("Double")
                        .HasColumnType("double");

                    b.Property<float>("Float")
                        .HasColumnType("float");

                    b.Property<int>("Integer")
                        .HasColumnType("int");

                    b.Property<IPAddress>("Ip")
                        .HasColumnType("inet");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<LocalDate>("LocalDate")
                        .HasColumnType("date");

                    b.Property<LocalTime>("LocalTime")
                        .HasColumnType("time");

                    b.Property<long>("Long")
                        .HasColumnType("bigint");

                    b.Property<sbyte>("Sbyte")
                        .HasColumnType("tinyint");

                    b.Property<short>("SmallInt")
                        .HasColumnType("smallint");

                    b.Property<Guid>("TimeUuid")
                        .HasColumnType("uuid");

                    b.HasKey("Id", "Order");

                    b.ToTable("applicants");

                    b.HasAnnotation("Cassandra:ClusterColumns", new[] { "Order" });

                    b.HasAnnotation("Cassandra:ClusteringOrderByOptions", "[{\"ColumnName\":\"Order\",\"Order\":0}]");
                });

            modelBuilder.Entity("EFCore.Cassandra.Samples.Models.ApplicantAddress", b =>
                {
                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<int>("StreetNumber")
                        .HasColumnType("int");

                    b.ToTable("applicant_addr");

                    b.HasAnnotation("Cassandra:IsUserDefinedType", true);
                });
#pragma warning restore 612, 618
        }
    }
}
