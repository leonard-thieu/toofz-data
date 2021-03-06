﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using toofz.Data;

namespace toofz.Data.Migrations
{
    [DbContext(typeof(NecroDancerContext))]
    [Migration("20180106130103_InitialCreate")]
    partial class InitialCreate
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("toofz.Data.Character", b =>
                {
                    b.Property<int>("CharacterId");

                    b.Property<string>("DisplayName")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.HasKey("CharacterId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("toofz.Data.DailyEntry", b =>
                {
                    b.Property<int>("LeaderboardId");

                    b.Property<int>("Rank");

                    b.Property<int>("Level");

                    b.Property<long?>("ReplayId");

                    b.Property<int>("Score");

                    b.Property<long>("SteamId");

                    b.Property<int>("Zone");

                    b.HasKey("LeaderboardId", "Rank");

                    b.HasIndex("ReplayId");

                    b.HasIndex("SteamId");

                    b.ToTable("DailyEntries");
                });

            modelBuilder.Entity("toofz.Data.DailyLeaderboard", b =>
                {
                    b.Property<int>("LeaderboardId");

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<string>("DisplayName")
                        .IsRequired();

                    b.Property<bool>("IsProduction");

                    b.Property<DateTime?>("LastUpdate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("ProductId");

                    b.HasKey("LeaderboardId");

                    b.HasIndex("ProductId");

                    b.HasIndex("Date", "ProductId", "IsProduction")
                        .IsUnique()
                        .HasName("IX_DailyLeaderboards");

                    b.ToTable("DailyLeaderboards");
                });

            modelBuilder.Entity("toofz.Data.Entry", b =>
                {
                    b.Property<int>("LeaderboardId");

                    b.Property<int>("Rank");

                    b.Property<int>("Level");

                    b.Property<long?>("ReplayId");

                    b.Property<int>("Score");

                    b.Property<long>("SteamId");

                    b.Property<int>("Zone");

                    b.HasKey("LeaderboardId", "Rank");

                    b.HasIndex("ReplayId");

                    b.HasIndex("SteamId");

                    b.ToTable("Entries");
                });

            modelBuilder.Entity("toofz.Data.Leaderboard", b =>
                {
                    b.Property<int>("LeaderboardId");

                    b.Property<int>("CharacterId");

                    b.Property<string>("DisplayName")
                        .IsRequired();

                    b.Property<bool>("IsCoOp");

                    b.Property<bool>("IsCustomMusic");

                    b.Property<bool>("IsProduction");

                    b.Property<DateTime?>("LastUpdate");

                    b.Property<int>("ModeId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("ProductId");

                    b.Property<int>("RunId");

                    b.HasKey("LeaderboardId");

                    b.HasIndex("ModeId");

                    b.HasIndex("ProductId");

                    b.HasIndex("RunId");

                    b.HasIndex("CharacterId", "RunId", "ModeId", "ProductId", "IsProduction", "IsCoOp", "IsCustomMusic")
                        .IsUnique()
                        .HasName("IX_Leaderboards");

                    b.ToTable("Leaderboards");
                });

            modelBuilder.Entity("toofz.Data.Mode", b =>
                {
                    b.Property<int>("ModeId");

                    b.Property<string>("DisplayName")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.HasKey("ModeId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Modes");
                });

            modelBuilder.Entity("toofz.Data.Player", b =>
                {
                    b.Property<long>("SteamId");

                    b.Property<string>("Avatar");

                    b.Property<bool?>("Exists");

                    b.Property<DateTime?>("LastUpdate");

                    b.Property<string>("Name")
                        .HasMaxLength(64);

                    b.HasKey("SteamId");

                    b.HasIndex("Name");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("toofz.Data.Product", b =>
                {
                    b.Property<int>("ProductId");

                    b.Property<string>("DisplayName")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.HasKey("ProductId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Products");
                });

            modelBuilder.Entity("toofz.Data.Replay", b =>
                {
                    b.Property<long>("ReplayId");

                    b.Property<int?>("ErrorCode");

                    b.Property<string>("KilledBy");

                    b.Property<int?>("Seed");

                    b.Property<string>("Uri");

                    b.Property<int?>("Version");

                    b.HasKey("ReplayId");

                    b.ToTable("Replays");
                });

            modelBuilder.Entity("toofz.Data.Run", b =>
                {
                    b.Property<int>("RunId");

                    b.Property<string>("DisplayName")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.HasKey("RunId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Runs");
                });

            modelBuilder.Entity("toofz.NecroDancer.Data.Enemy", b =>
                {
                    b.Property<string>("Name");

                    b.Property<int>("Type");

                    b.Property<string>("DisplayName")
                        .IsRequired();

                    b.Property<string>("FriendlyName");

                    b.Property<int?>("Id");

                    b.HasKey("Name", "Type");

                    b.ToTable("Enemies");
                });

            modelBuilder.Entity("toofz.NecroDancer.Data.Item", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Bouncer");

                    b.Property<int?>("CoinCost");

                    b.Property<bool>("Consumable");

                    b.Property<int?>("Cooldown");

                    b.Property<int?>("Data");

                    b.Property<int?>("DiamondCost");

                    b.Property<int?>("DiamondDealable");

                    b.Property<string>("DisplayName")
                        .IsRequired();

                    b.Property<bool?>("FromTransmute");

                    b.Property<int>("ImageHeight");

                    b.Property<string>("ImagePath");

                    b.Property<int>("ImageWidth");

                    b.Property<bool>("IsArmor");

                    b.Property<bool>("IsAxe");

                    b.Property<bool>("IsBlood");

                    b.Property<bool>("IsBlunderbuss");

                    b.Property<bool>("IsBow");

                    b.Property<bool>("IsBroadsword");

                    b.Property<bool>("IsCat");

                    b.Property<bool>("IsCoin");

                    b.Property<bool>("IsCrossbow");

                    b.Property<bool>("IsCutlass");

                    b.Property<bool>("IsDagger");

                    b.Property<bool>("IsDiamond");

                    b.Property<bool>("IsFamiliar");

                    b.Property<bool>("IsFlail");

                    b.Property<bool>("IsFood");

                    b.Property<bool>("IsFrost");

                    b.Property<bool>("IsGlass");

                    b.Property<bool>("IsGold");

                    b.Property<bool>("IsHarp");

                    b.Property<bool>("IsLongsword");

                    b.Property<bool>("IsMagicFood");

                    b.Property<bool>("IsObsidian");

                    b.Property<bool>("IsPhasing");

                    b.Property<bool>("IsPiercing");

                    b.Property<bool>("IsRapier");

                    b.Property<bool>("IsRifle");

                    b.Property<bool>("IsScroll");

                    b.Property<bool>("IsShovel");

                    b.Property<bool>("IsSpear");

                    b.Property<bool>("IsSpell");

                    b.Property<bool>("IsStackable");

                    b.Property<bool>("IsStaff");

                    b.Property<bool>("IsTemp");

                    b.Property<bool>("IsTitanium");

                    b.Property<bool>("IsTorch");

                    b.Property<bool>("IsWarhammer");

                    b.Property<bool>("IsWeapon");

                    b.Property<bool>("IsWhip");

                    b.Property<bool>("PlayerKnockback");

                    b.Property<int>("Quantity");

                    b.Property<string>("Set");

                    b.Property<string>("Slot");

                    b.Property<bool>("TemporaryMapSight");

                    b.Property<bool?>("UseGreater");

                    b.HasKey("Name");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("toofz.Data.DailyEntry", b =>
                {
                    b.HasOne("toofz.Data.DailyLeaderboard", "Leaderboard")
                        .WithMany("Entries")
                        .HasForeignKey("LeaderboardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("toofz.Data.Replay", "Replay")
                        .WithMany()
                        .HasForeignKey("ReplayId");

                    b.HasOne("toofz.Data.Player", "Player")
                        .WithMany("DailyEntries")
                        .HasForeignKey("SteamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("toofz.Data.DailyLeaderboard", b =>
                {
                    b.HasOne("toofz.Data.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("toofz.Data.Entry", b =>
                {
                    b.HasOne("toofz.Data.Leaderboard", "Leaderboard")
                        .WithMany("Entries")
                        .HasForeignKey("LeaderboardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("toofz.Data.Replay", "Replay")
                        .WithMany()
                        .HasForeignKey("ReplayId");

                    b.HasOne("toofz.Data.Player", "Player")
                        .WithMany("Entries")
                        .HasForeignKey("SteamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("toofz.Data.Leaderboard", b =>
                {
                    b.HasOne("toofz.Data.Character", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("toofz.Data.Mode", "Mode")
                        .WithMany()
                        .HasForeignKey("ModeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("toofz.Data.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("toofz.Data.Run", "Run")
                        .WithMany()
                        .HasForeignKey("RunId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("toofz.NecroDancer.Data.Enemy", b =>
                {
                    b.OwnsOne("toofz.NecroDancer.Data.OptionalStats", "OptionalStats", b1 =>
                        {
                            b1.Property<string>("EnemyName");

                            b1.Property<int>("EnemyType");

                            b1.Property<bool>("Boss");

                            b1.Property<bool>("BounceOnMovementFail");

                            b1.Property<bool>("Floating");

                            b1.Property<bool>("IgnoreLiquids");

                            b1.Property<bool>("IgnoreWalls");

                            b1.Property<bool>("IsMonkeyLike");

                            b1.Property<bool>("Massive");

                            b1.Property<bool>("Miniboss");

                            b1.ToTable("Enemies");

                            b1.HasOne("toofz.NecroDancer.Data.Enemy")
                                .WithOne("OptionalStats")
                                .HasForeignKey("toofz.NecroDancer.Data.OptionalStats", "EnemyName", "EnemyType")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("toofz.NecroDancer.Data.Stats", "Stats", b1 =>
                        {
                            b1.Property<string>("EnemyName");

                            b1.Property<int>("EnemyType");

                            b1.Property<int>("BeatsPerMove");

                            b1.Property<int>("CoinsToDrop");

                            b1.Property<int>("DamagePerHit");

                            b1.Property<int>("Health");

                            b1.Property<string>("Movement");

                            b1.ToTable("Enemies");

                            b1.HasOne("toofz.NecroDancer.Data.Enemy")
                                .WithOne("Stats")
                                .HasForeignKey("toofz.NecroDancer.Data.Stats", "EnemyName", "EnemyType")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
