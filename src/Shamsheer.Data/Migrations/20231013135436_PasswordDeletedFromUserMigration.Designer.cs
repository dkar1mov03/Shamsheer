﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Shamsheer.Data.DbContexts;

#nullable disable

namespace Shamsheer.Data.Migrations
{
    [DbContext(typeof(ShamsheerDbContext))]
    [Migration("20231013135436_PasswordDeletedFromUserMigration")]
    partial class PasswordDeletedFromUserMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Shamsheer.Domain.Entities.Assets.ChannelAsset", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("ChannelId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Extension")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Path")
                        .HasColumnType("text");

                    b.Property<long>("Size")
                        .HasColumnType("bigint");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ChannelId");

                    b.ToTable("ChannelAssets");
                });

            modelBuilder.Entity("Shamsheer.Domain.Entities.Assets.GroupAsset", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Extension")
                        .HasColumnType("text");

                    b.Property<long>("GroupId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Path")
                        .HasColumnType("text");

                    b.Property<long>("Size")
                        .HasColumnType("bigint");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("GroupAssets");
                });

            modelBuilder.Entity("Shamsheer.Domain.Entities.Assets.UserAsset", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Extension")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Path")
                        .HasColumnType("text");

                    b.Property<long>("Size")
                        .HasColumnType("bigint");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserAssets");
                });

            modelBuilder.Entity("Shamsheer.Domain.Entities.Chats.Channel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("AccessType")
                        .HasColumnType("integer");

                    b.Property<int>("ChatType")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("InviteLink")
                        .HasColumnType("text");

                    b.Property<long>("OwnerId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Channels");
                });

            modelBuilder.Entity("Shamsheer.Domain.Entities.Chats.Group", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("AccessType")
                        .HasColumnType("integer");

                    b.Property<int>("ChatType")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("InviteLink")
                        .HasColumnType("text");

                    b.Property<long>("OwnerId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Shamsheer.Domain.Entities.Chats.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("ChatType")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Shamsheer.Domain.Entities.Chats.UserChannel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("ChannelId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<long>("SubscriberId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ChannelId");

                    b.HasIndex("SubscriberId");

                    b.ToTable("UserChannels");
                });

            modelBuilder.Entity("Shamsheer.Domain.Entities.Chats.UserGroup", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("GroupId")
                        .HasColumnType("bigint");

                    b.Property<long>("MemberId")
                        .HasColumnType("bigint");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("MemberId");

                    b.ToTable("UserGroups");
                });

            modelBuilder.Entity("Shamsheer.Domain.Entities.Messages.Message", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("FormatType")
                        .HasColumnType("integer");

                    b.Property<long>("FromId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ParentId")
                        .HasColumnType("bigint");

                    b.Property<long>("ToId")
                        .HasColumnType("bigint");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("FromId");

                    b.HasIndex("ParentId");

                    b.HasIndex("ToId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Shamsheer.Domain.Entities.Messages.MessageContent", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<byte[]>("Content")
                        .HasColumnType("bytea");

                    b.Property<int>("ContentType")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("MessageId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("MessageId");

                    b.ToTable("MessageContents");
                });

            modelBuilder.Entity("Shamsheer.Domain.Entities.Assets.ChannelAsset", b =>
                {
                    b.HasOne("Shamsheer.Domain.Entities.Chats.Channel", "Channel")
                        .WithMany("Assets")
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Channel");
                });

            modelBuilder.Entity("Shamsheer.Domain.Entities.Assets.GroupAsset", b =>
                {
                    b.HasOne("Shamsheer.Domain.Entities.Chats.Group", "Group")
                        .WithMany("Assets")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("Shamsheer.Domain.Entities.Assets.UserAsset", b =>
                {
                    b.HasOne("Shamsheer.Domain.Entities.Chats.User", "User")
                        .WithMany("Assets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Shamsheer.Domain.Entities.Chats.Channel", b =>
                {
                    b.HasOne("Shamsheer.Domain.Entities.Chats.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Shamsheer.Domain.Entities.Chats.Group", b =>
                {
                    b.HasOne("Shamsheer.Domain.Entities.Chats.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Shamsheer.Domain.Entities.Chats.UserChannel", b =>
                {
                    b.HasOne("Shamsheer.Domain.Entities.Chats.Channel", "Channel")
                        .WithMany("Subscribers")
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shamsheer.Domain.Entities.Chats.User", "Subscriber")
                        .WithMany()
                        .HasForeignKey("SubscriberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Channel");

                    b.Navigation("Subscriber");
                });

            modelBuilder.Entity("Shamsheer.Domain.Entities.Chats.UserGroup", b =>
                {
                    b.HasOne("Shamsheer.Domain.Entities.Chats.Group", "Group")
                        .WithMany("Members")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shamsheer.Domain.Entities.Chats.User", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Shamsheer.Domain.Entities.Messages.Message", b =>
                {
                    b.HasOne("Shamsheer.Domain.Entities.Chats.User", "From")
                        .WithMany()
                        .HasForeignKey("FromId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shamsheer.Domain.Entities.Messages.Message", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.HasOne("Shamsheer.Domain.Entities.Chats.User", "To")
                        .WithMany()
                        .HasForeignKey("ToId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("From");

                    b.Navigation("Parent");

                    b.Navigation("To");
                });

            modelBuilder.Entity("Shamsheer.Domain.Entities.Messages.MessageContent", b =>
                {
                    b.HasOne("Shamsheer.Domain.Entities.Messages.Message", "Message")
                        .WithMany()
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Message");
                });

            modelBuilder.Entity("Shamsheer.Domain.Entities.Chats.Channel", b =>
                {
                    b.Navigation("Assets");

                    b.Navigation("Subscribers");
                });

            modelBuilder.Entity("Shamsheer.Domain.Entities.Chats.Group", b =>
                {
                    b.Navigation("Assets");

                    b.Navigation("Members");
                });

            modelBuilder.Entity("Shamsheer.Domain.Entities.Chats.User", b =>
                {
                    b.Navigation("Assets");
                });
#pragma warning restore 612, 618
        }
    }
}