﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Online_Courses.Models;

namespace Online_Courses.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200412111415_Prototype")]
    partial class Prototype
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Online_Courses.Models.CompanyContactInfo", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("CompanyUrl");

                    b.Property<string>("Email");

                    b.Property<string>("ImagePath");

                    b.Property<string>("MobileNumber");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("SecondLandLine");

                    b.HasKey("UserID");

                    b.ToTable("CompanyContactInfos");
                });

            modelBuilder.Entity("Online_Courses.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CertificateTemplatePath");

                    b.Property<string>("DemoUrl");

                    b.Property<string>("Description");

                    b.Property<string>("ImagePath");

                    b.Property<string>("MobileNumber");

                    b.Property<string>("Name");

                    b.Property<decimal>("PassPercentage");

                    b.Property<decimal>("TotalCourseHours");

                    b.Property<decimal>("price");

                    b.HasKey("CourseID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Online_Courses.Models.CourseFile", b =>
                {
                    b.Property<int>("CourseFileID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseID");

                    b.Property<string>("FilePath");

                    b.Property<int>("PartNumber");

                    b.Property<string>("VideoPath");

                    b.HasKey("CourseFileID");

                    b.HasIndex("CourseID");

                    b.ToTable("CourseFiles");
                });

            modelBuilder.Entity("Online_Courses.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Email");

                    b.Property<string>("ImagePath");

                    b.Property<bool>("IsApproved");

                    b.Property<string>("MobileNumber");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("Role");

                    b.Property<string>("Token");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Online_Courses.Models.UserCourse", b =>
                {
                    b.Property<int>("UserID");

                    b.Property<int>("CourseID");

                    b.Property<decimal?>("AmountPaid");

                    b.Property<DateTime?>("FromTime");

                    b.Property<bool>("IsBookmark");

                    b.Property<bool>("IsInstructor");

                    b.Property<DateTime?>("LastViewed");

                    b.Property<int?>("PartsCompleted");

                    b.Property<DateTime?>("ToTime");

                    b.Property<string>("UserCourseState");

                    b.Property<int?>("UserRate");

                    b.HasKey("UserID", "CourseID");

                    b.HasAlternateKey("CourseID", "UserID");

                    b.ToTable("UserCourses");
                });

            modelBuilder.Entity("Online_Courses.Models.UserCourseCertificate", b =>
                {
                    b.Property<int>("UserID");

                    b.Property<int>("CourseID");

                    b.Property<string>("CertificatePath");

                    b.HasKey("UserID", "CourseID");

                    b.HasAlternateKey("CourseID", "UserID");

                    b.ToTable("UserCourseCertificates");
                });

            modelBuilder.Entity("Online_Courses.Models.CourseFile", b =>
                {
                    b.HasOne("Online_Courses.Models.Course", "Course")
                        .WithMany("Files")
                        .HasForeignKey("CourseID");
                });

            modelBuilder.Entity("Online_Courses.Models.UserCourse", b =>
                {
                    b.HasOne("Online_Courses.Models.Course", "Courses")
                        .WithMany("UserCourse")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Online_Courses.Models.User", "Users")
                        .WithMany("UserCourse")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Online_Courses.Models.UserCourseCertificate", b =>
                {
                    b.HasOne("Online_Courses.Models.Course", "Courses")
                        .WithMany("UserCourseCertificate")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Online_Courses.Models.User", "Users")
                        .WithMany("UserCourseCertificate")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}