using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Angular.Repository.Models
{
    public partial class rardbContext : DbContext
    {
        public rardbContext()
        {
        }

        public rardbContext(DbContextOptions<rardbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<Clientdatum> Clientdata { get; set; }
        public virtual DbSet<Compensation> Compensations { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Empdatum> Empdata { get; set; }
        public virtual DbSet<Empexp> Empexps { get; set; }
        public virtual DbSet<Employee1> Employee1s { get; set; }
        public virtual DbSet<Employee2> Employee2s { get; set; }
        public virtual DbSet<Entity> Entities { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<FileDatum> FileData { get; set; }
        public virtual DbSet<Fileupload> Fileuploads { get; set; }
        public virtual DbSet<ImageDatum> ImageData { get; set; }
        public virtual DbSet<Imgexp> Imgexps { get; set; }
        public virtual DbSet<Jobinformation> Jobinformations { get; set; }
        public virtual DbSet<Mgmtexp> Mgmtexps { get; set; }
        public virtual DbSet<Orgndatum> Orgndata { get; set; }
        public virtual DbSet<Payrollexpense> Payrollexpenses { get; set; }
        public virtual DbSet<Ram> Rams { get; set; }
        public virtual DbSet<Reg> Regs { get; set; }
        public virtual DbSet<RegisterUser> RegisterUsers { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Studentdatum> Studentdata { get; set; }
        public virtual DbSet<Timesheet> Timesheets { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Visainformation> Visainformations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:snad-rardb.database.windows.net;Database=rardb;user id=rardb;password=Qwerty123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId, "IX_AspNetUserRoles_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Clientdatum>(entity =>
            {
                entity.HasKey(e => e.Clientcode)
                    .HasName("clientdata_PK");

                entity.ToTable("clientdata");

                entity.Property(e => e.Clientcode)
                    .ValueGeneratedNever()
                    .HasColumnName("clientcode");

                entity.Property(e => e.Agreementenddate)
                    .HasColumnType("text")
                    .HasColumnName("agreementenddate");

                entity.Property(e => e.Agreementstartdate)
                    .HasColumnType("text")
                    .HasColumnName("agreementstartdate");

                entity.Property(e => e.Clientlocation)
                    .HasColumnType("text")
                    .HasColumnName("clientlocation");

                entity.Property(e => e.Clientname)
                    .HasColumnType("text")
                    .HasColumnName("clientname");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Serviceagreementonboarded)
                    .HasColumnType("text")
                    .HasColumnName("serviceagreementonboarded");

                entity.Property(e => e.Taxfederal).HasColumnName("taxfederal");
            });

            modelBuilder.Entity<Compensation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("compensation");

                entity.Property(e => e.Changereason)
                    .HasColumnType("text")
                    .HasColumnName("changereason");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment");

                entity.Property(e => e.Compensationeffectivedate)
                    .HasColumnType("text")
                    .HasColumnName("compensationeffectivedate");

                entity.Property(e => e.Employeeid).HasColumnName("employeeid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Overtime)
                    .HasColumnType("text")
                    .HasColumnName("overtime");

                entity.Property(e => e.Overtimerate)
                    .HasColumnType("text")
                    .HasColumnName("overtimerate");

                entity.Property(e => e.Payrate)
                    .HasColumnType("text")
                    .HasColumnName("payrate");

                entity.Property(e => e.Payschedule)
                    .HasColumnType("text")
                    .HasColumnName("payschedule");

                entity.Property(e => e.Paytype)
                    .HasColumnType("text")
                    .HasColumnName("paytype");
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("education");

                entity.Property(e => e.Degreeenddate)
                    .HasColumnType("text")
                    .HasColumnName("degreeenddate");

                entity.Property(e => e.Degreestartdate)
                    .HasColumnType("text")
                    .HasColumnName("degreestartdate");

                entity.Property(e => e.Employeeid).HasColumnName("employeeid");

                entity.Property(e => e.Gpa)
                    .HasColumnType("text")
                    .HasColumnName("gpa");

                entity.Property(e => e.Highestdegree)
                    .HasColumnType("text")
                    .HasColumnName("highestdegree");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Specialization)
                    .HasColumnType("text")
                    .HasColumnName("specialization");

                entity.Property(e => e.University)
                    .HasColumnType("text")
                    .HasColumnName("university");
            });

            modelBuilder.Entity<Empdatum>(entity =>
            {
                entity.HasKey(e => e.Employeeid)
                    .HasName("empdata_PK");

                entity.ToTable("empdata");

                entity.Property(e => e.Employeeid)
                    .ValueGeneratedNever()
                    .HasColumnName("employeeid");

                entity.Property(e => e.Addressline1)
                    .HasColumnType("text")
                    .HasColumnName("addressline1");

                entity.Property(e => e.Addressline2)
                    .HasColumnType("text")
                    .HasColumnName("addressline2");

                entity.Property(e => e.Changereason)
                    .HasColumnType("text")
                    .HasColumnName("changereason");

                entity.Property(e => e.City)
                    .HasColumnType("text")
                    .HasColumnName("city");

                entity.Property(e => e.Clientcode)
                    .HasColumnType("text")
                    .HasColumnName("clientcode");

                entity.Property(e => e.Clientname)
                    .HasColumnType("text")
                    .HasColumnName("clientname");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment");

                entity.Property(e => e.Compensationeffectivedate)
                    .HasColumnType("text")
                    .HasColumnName("compensationeffectivedate");

                entity.Property(e => e.Contactnumber).HasColumnName("contactnumber");

                entity.Property(e => e.Country)
                    .HasColumnType("text")
                    .HasColumnName("country");

                entity.Property(e => e.Createdby)
                    .HasColumnType("text")
                    .HasColumnName("createdby");

                entity.Property(e => e.Date)
                    .HasColumnType("text")
                    .HasColumnName("date");

                entity.Property(e => e.Dateofbirth)
                    .HasColumnType("text")
                    .HasColumnName("dateofbirth");

                entity.Property(e => e.Degreeenddate)
                    .HasColumnType("text")
                    .HasColumnName("degreeenddate");

                entity.Property(e => e.Degreestartdate)
                    .HasColumnType("text")
                    .HasColumnName("degreestartdate");

                entity.Property(e => e.Effectivedate)
                    .HasColumnType("text")
                    .HasColumnName("effectivedate");

                entity.Property(e => e.Emailaddress)
                    .HasColumnType("text")
                    .HasColumnName("emailaddress");

                entity.Property(e => e.Emergencynumber).HasColumnName("emergencynumber");

                entity.Property(e => e.Employementstatus)
                    .HasColumnType("text")
                    .HasColumnName("employementstatus");

                entity.Property(e => e.Empstatus)
                    .HasColumnType("text")
                    .HasColumnName("empstatus");

                entity.Property(e => e.Entity)
                    .HasColumnType("text")
                    .HasColumnName("entity");

                entity.Property(e => e.Expirationdate)
                    .HasColumnType("text")
                    .HasColumnName("expirationdate");

                entity.Property(e => e.Firstname)
                    .HasColumnType("text")
                    .HasColumnName("firstname");

                entity.Property(e => e.Fullname)
                    .HasColumnType("text")
                    .HasColumnName("fullname");

                entity.Property(e => e.Gender)
                    .HasColumnType("text")
                    .HasColumnName("gender");

                entity.Property(e => e.Gpa)
                    .HasColumnType("text")
                    .HasColumnName("gpa");

                entity.Property(e => e.Highestdegree)
                    .HasColumnType("text")
                    .HasColumnName("highestdegree");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Immigrationstatus)
                    .HasColumnType("text")
                    .HasColumnName("immigrationstatus");

                entity.Property(e => e.Internalstaff)
                    .HasColumnType("text")
                    .HasColumnName("internalstaff");

                entity.Property(e => e.Issueddate)
                    .HasColumnType("text")
                    .HasColumnName("issueddate");

                entity.Property(e => e.Issuingcountry)
                    .HasColumnType("text")
                    .HasColumnName("issuingcountry");

                entity.Property(e => e.Jobeffectivedate)
                    .HasColumnType("text")
                    .HasColumnName("jobeffectivedate");

                entity.Property(e => e.Jobtitle)
                    .HasColumnType("text")
                    .HasColumnName("jobtitle");

                entity.Property(e => e.Lastname)
                    .HasColumnType("text")
                    .HasColumnName("lastname");

                entity.Property(e => e.Location)
                    .HasColumnType("text")
                    .HasColumnName("location");

                entity.Property(e => e.Overtime)
                    .HasColumnType("text")
                    .HasColumnName("overtime");

                entity.Property(e => e.Overtimerate)
                    .HasColumnType("text")
                    .HasColumnName("overtimerate");

                entity.Property(e => e.Payrate)
                    .HasColumnType("text")
                    .HasColumnName("payrate");

                entity.Property(e => e.Payschedule)
                    .HasColumnType("text")
                    .HasColumnName("payschedule");

                entity.Property(e => e.Paytype)
                    .HasColumnType("text")
                    .HasColumnName("paytype");

                entity.Property(e => e.Reportsto)
                    .HasColumnType("text")
                    .HasColumnName("reportsto");

                entity.Property(e => e.Specialization)
                    .HasColumnType("text")
                    .HasColumnName("specialization");

                entity.Property(e => e.Ssn)
                    .HasColumnType("text")
                    .HasColumnName("ssn");

                entity.Property(e => e.Startdate)
                    .HasColumnType("text")
                    .HasColumnName("startdate");

                entity.Property(e => e.State)
                    .HasColumnType("text")
                    .HasColumnName("state");

                entity.Property(e => e.Status)
                    .HasColumnType("text")
                    .HasColumnName("status");

                entity.Property(e => e.Supervisor).HasColumnName("supervisor");

                entity.Property(e => e.Taxfilenumber).HasColumnName("taxfilenumber");

                entity.Property(e => e.University)
                    .HasColumnType("text")
                    .HasColumnName("university");

                entity.Property(e => e.Updatedby)
                    .HasColumnType("text")
                    .HasColumnName("updatedby");

                entity.Property(e => e.Visastatus)
                    .HasColumnType("text")
                    .HasColumnName("visastatus");

                entity.Property(e => e.Zipcode).HasColumnName("zipcode");

                entity.HasOne(d => d.SupervisorNavigation)
                    .WithMany(p => p.InverseSupervisorNavigation)
                    .HasForeignKey(d => d.Supervisor)
                    .HasConstraintName("empdata_FK");
            });

            modelBuilder.Entity<Empexp>(entity =>
            {
                entity.ToTable("empexp");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Approvaldate)
                    .HasColumnType("text")
                    .HasColumnName("approvaldate");

                entity.Property(e => e.Approvedby).HasColumnName("approvedby");

                entity.Property(e => e.Clientcode).HasColumnName("clientcode");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("text")
                    .HasColumnName("creationdate");

                entity.Property(e => e.Employeeid).HasColumnName("employeeid");

                entity.Property(e => e.Entity)
                    .HasColumnType("text")
                    .HasColumnName("entity");

                entity.Property(e => e.Expensecode)
                    .HasColumnType("text")
                    .HasColumnName("expensecode");

                entity.Property(e => e.Expensedate)
                    .HasColumnType("text")
                    .HasColumnName("expensedate");

                entity.Property(e => e.Modeofpayment)
                    .HasColumnType("text")
                    .HasColumnName("modeofpayment");

                entity.Property(e => e.Paymentdate)
                    .HasColumnType("text")
                    .HasColumnName("paymentdate");

                entity.Property(e => e.Updatedby).HasColumnName("updatedby");

                entity.HasOne(d => d.ApprovedbyNavigation)
                    .WithMany(p => p.InverseApprovedbyNavigation)
                    .HasForeignKey(d => d.Approvedby)
                    .HasConstraintName("empexp_FK");

                entity.HasOne(d => d.ClientcodeNavigation)
                    .WithMany(p => p.InverseClientcodeNavigation)
                    .HasForeignKey(d => d.Clientcode)
                    .HasConstraintName("empexp_FK_1");

                entity.HasOne(d => d.CreatedbyNavigation)
                    .WithMany(p => p.InverseCreatedbyNavigation)
                    .HasForeignKey(d => d.Createdby)
                    .HasConstraintName("empexp_FK_2");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.InverseEmployee)
                    .HasForeignKey(d => d.Employeeid)
                    .HasConstraintName("empexp_FK_3");

                entity.HasOne(d => d.UpdatedbyNavigation)
                    .WithMany(p => p.InverseUpdatedbyNavigation)
                    .HasForeignKey(d => d.Updatedby)
                    .HasConstraintName("empexp_FK_5");
            });

            modelBuilder.Entity<Employee1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Employee1");

                entity.Property(e => e.EmpId).ValueGeneratedOnAdd();

                entity.Property(e => e.EmpName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpSalary).HasColumnType("money");
            });

            modelBuilder.Entity<Employee2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Employee2");

                entity.Property(e => e.EmpAddress)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId).ValueGeneratedOnAdd();

                entity.Property(e => e.EmpName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpSalary).HasColumnType("money");
            });

            modelBuilder.Entity<Entity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("entity");

                entity.Property(e => e.Entity1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("entity");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<Expense>(entity =>
            {
                entity.HasKey(e => e.Expensecode)
                    .HasName("expenses_PK");

                entity.ToTable("expenses");

                entity.Property(e => e.Expensecode)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("expensecode");

                entity.Property(e => e.Expenses)
                    .HasColumnType("text")
                    .HasColumnName("expenses");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<FileDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("file_data");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("file_path");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Fileupload>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fileupload");

                entity.Property(e => e.Column1)
                    .HasColumnType("text")
                    .HasColumnName("column1");

                entity.Property(e => e.Column2)
                    .HasColumnType("text")
                    .HasColumnName("column2");

                entity.Property(e => e.Column3)
                    .HasColumnType("text")
                    .HasColumnName("column3");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<ImageDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("image_data");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Imagedata).HasColumnName("imagedata");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Imgexp>(entity =>
            {
                entity.ToTable("imgexp");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Approvaldate)
                    .HasColumnType("text")
                    .HasColumnName("approvaldate");

                entity.Property(e => e.Approvedby).HasColumnName("approvedby");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("text")
                    .HasColumnName("creationdate");

                entity.Property(e => e.Employeeid).HasColumnName("employeeid");

                entity.Property(e => e.Entity)
                    .HasColumnType("text")
                    .HasColumnName("entity");

                entity.Property(e => e.Expdate)
                    .HasColumnType("text")
                    .HasColumnName("expdate");

                entity.Property(e => e.Expensescode)
                    .HasColumnType("text")
                    .HasColumnName("expensescode");

                entity.Property(e => e.Modeofpayment)
                    .HasColumnType("text")
                    .HasColumnName("modeofpayment");

                entity.Property(e => e.Paymentdate)
                    .HasColumnType("text")
                    .HasColumnName("paymentdate");

                entity.Property(e => e.Updatedby).HasColumnName("updatedby");

                entity.HasOne(d => d.CreatedbyNavigation)
                    .WithMany(p => p.ImgexpCreatedbyNavigations)
                    .HasForeignKey(d => d.Createdby)
                    .HasConstraintName("imgexp_FK_1");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ImgexpEmployees)
                    .HasForeignKey(d => d.Employeeid)
                    .HasConstraintName("imgexp_FK_2");
            });

            modelBuilder.Entity<Jobinformation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("jobinformation");

                entity.Property(e => e.Clientname)
                    .HasColumnType("text")
                    .HasColumnName("clientname");

                entity.Property(e => e.Employeeid).HasColumnName("employeeid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Jobeffectivedate)
                    .HasColumnType("text")
                    .HasColumnName("jobeffectivedate");

                entity.Property(e => e.Jobtitle)
                    .HasColumnType("text")
                    .HasColumnName("jobtitle");

                entity.Property(e => e.Location)
                    .HasColumnType("text")
                    .HasColumnName("location");

                entity.Property(e => e.Reportsto)
                    .HasColumnType("text")
                    .HasColumnName("reportsto");
            });

            modelBuilder.Entity<Mgmtexp>(entity =>
            {
                entity.ToTable("mgmtexp");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Approvaldate)
                    .HasColumnType("text")
                    .HasColumnName("approvaldate");

                entity.Property(e => e.Approvedby).HasColumnName("approvedby");

                entity.Property(e => e.Clientcode).HasColumnName("clientcode");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("text")
                    .HasColumnName("creationdate");

                entity.Property(e => e.Employeeid).HasColumnName("employeeid");

                entity.Property(e => e.Entity)
                    .HasColumnType("text")
                    .HasColumnName("entity");

                entity.Property(e => e.Expdate)
                    .HasColumnType("text")
                    .HasColumnName("expdate");

                entity.Property(e => e.Expensecode)
                    .HasColumnType("text")
                    .HasColumnName("expensecode");

                entity.Property(e => e.Expensedate)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("expensedate");

                entity.Property(e => e.Modeofpayment)
                    .HasColumnType("text")
                    .HasColumnName("modeofpayment");

                entity.Property(e => e.Paymentdate)
                    .HasColumnType("text")
                    .HasColumnName("paymentdate");

                entity.Property(e => e.Updatedby).HasColumnName("updatedby");
            });

            modelBuilder.Entity<Orgndatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("orgndata");

                entity.Property(e => e.Entity)
                    .HasColumnType("text")
                    .HasColumnName("entity");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<Payrollexpense>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("payrollexpense");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Creatioddate)
                    .HasColumnType("text")
                    .HasColumnName("creatioddate");

                entity.Property(e => e.Employeeid).HasColumnName("employeeid");

                entity.Property(e => e.Grosspay).HasColumnName("grosspay");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Insurancebycompany).HasColumnName("insurancebycompany");

                entity.Property(e => e.Noofhours).HasColumnName("noofhours");

                entity.Property(e => e.Paymentdate)
                    .HasColumnType("text")
                    .HasColumnName("paymentdate");

                entity.Property(e => e.Payperiodenddate)
                    .HasColumnType("text")
                    .HasColumnName("payperiodenddate");

                entity.Property(e => e.Payperiodstartdate)
                    .HasColumnType("text")
                    .HasColumnName("payperiodstartdate");

                entity.Property(e => e.Payrate).HasColumnName("payrate");

                entity.Property(e => e.Payrollexpense1).HasColumnName("payrollexpense");

                entity.Property(e => e.Totalpayroll).HasColumnName("totalpayroll");

                entity.Property(e => e.Updatedby).HasColumnName("updatedby");

                entity.Property(e => e.Updateddate)
                    .HasColumnType("text")
                    .HasColumnName("updateddate");
            });

            modelBuilder.Entity<Ram>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ram");

                entity.Property(e => e.Empid).HasColumnName("empid");

                entity.Property(e => e.Empname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("empname");
            });

            modelBuilder.Entity<Reg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("reg");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("address2");

                entity.Property(e => e.Ans1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ans1");

                entity.Property(e => e.Ans2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ans2");

                entity.Property(e => e.Ans3)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ans3");

                entity.Property(e => e.Ans4)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ans4");

                entity.Property(e => e.Ans5)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ans5");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("city");

                entity.Property(e => e.ConfirmPassword)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("confirmPassword");

                entity.Property(e => e.ConfirmPassword1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("confirm_password");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("country");

                entity.Property(e => e.DateofBirth)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("dateofBirth");

                entity.Property(e => e.DateofBirth1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dateof_birth");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Entity)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("entity");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("firstName");

                entity.Property(e => e.FirstName1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("gender");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Idnumber)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("idnumber");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("lastName");

                entity.Property(e => e.LastName1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("password");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.PhoneNumber1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("role");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("state");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("status");

                entity.Property(e => e.Zipcode)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("zipcode");
            });

            modelBuilder.Entity<RegisterUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RegisterUser");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Passsword)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("registration");

                entity.Property(e => e.AddressLine1).HasColumnType("text");

                entity.Property(e => e.AddressLine2).HasColumnType("text");

                entity.Property(e => e.City)
                    .HasColumnType("text")
                    .HasColumnName("city");

                entity.Property(e => e.ConfirmPassword)
                    .HasColumnType("text")
                    .HasColumnName("Confirm Password");

                entity.Property(e => e.Country)
                    .HasColumnType("text")
                    .HasColumnName("country");

                entity.Property(e => e.Email)
                    .HasColumnType("text")
                    .HasColumnName("email");

                entity.Property(e => e.EmployeeFullName)
                    .HasColumnType("text")
                    .HasColumnName("Employee Full Name");

                entity.Property(e => e.EntityName)
                    .HasColumnType("text")
                    .HasColumnName("Entity Name");

                entity.Property(e => e.FirstName)
                    .HasColumnType("text")
                    .HasColumnName("firstName");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.IdNumber)
                    .IsUnicode(false)
                    .HasColumnName("ID Number");

                entity.Property(e => e.LastName)
                    .HasColumnType("text")
                    .HasColumnName("lastName");

                entity.Property(e => e.Password).HasColumnType("text");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnType("text")
                    .HasColumnName("Phone Number");

                entity.Property(e => e.Role).HasColumnType("text");

                entity.Property(e => e.State)
                    .HasColumnType("text")
                    .HasColumnName("state");

                entity.Property(e => e.Zipcode)
                    .HasColumnType("text")
                    .HasColumnName("zipcode");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("roles");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Roles)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("roles");
            });

            modelBuilder.Entity<Studentdatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("studentdata");

                entity.Property(e => e.Gender)
                    .HasColumnType("text")
                    .HasColumnName("gender");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("name");

                entity.Property(e => e.Role)
                    .HasColumnType("text")
                    .HasColumnName("role");
            });

            modelBuilder.Entity<Timesheet>(entity =>
            {
                entity.ToTable("timesheet");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("text")
                    .HasColumnName("creationdate");

                entity.Property(e => e.Employeeid).HasColumnName("employeeid");

                entity.Property(e => e.Noofhours).HasColumnName("noofhours");

                entity.Property(e => e.Operationalcost).HasColumnName("operationalcost");

                entity.Property(e => e.Payrate).HasColumnName("payrate");

                entity.Property(e => e.Period)
                    .HasColumnType("text")
                    .HasColumnName("period");

                entity.Property(e => e.Receivables).HasColumnName("receivables");

                entity.Property(e => e.Receivablespaid)
                    .HasColumnType("text")
                    .HasColumnName("receivablespaid");

                entity.Property(e => e.Revenuerate).HasColumnName("revenuerate");

                entity.Property(e => e.Updatedby).HasColumnName("updatedby");

                entity.Property(e => e.Updateddate)
                    .HasColumnType("text")
                    .HasColumnName("updateddate");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("users");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Permissions)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("permissions");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.Role)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("role");
            });

            modelBuilder.Entity<Visainformation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("visainformation");

                entity.Property(e => e.Changereason)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("changereason");

                entity.Property(e => e.Comment)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Date)
                    .HasColumnType("text")
                    .HasColumnName("date");

                entity.Property(e => e.Employeeid).HasColumnName("employeeid");

                entity.Property(e => e.Expirationdate)
                    .HasColumnType("text")
                    .HasColumnName("expirationdate");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Issuedate)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("issuedate");

                entity.Property(e => e.Issueddate)
                    .HasColumnType("text")
                    .HasColumnName("issueddate");

                entity.Property(e => e.Issuingcountry)
                    .HasColumnType("text")
                    .HasColumnName("issuingcountry");

                entity.Property(e => e.Overtime)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("overtime");

                entity.Property(e => e.Overtimerate).HasColumnName("overtimerate");

                entity.Property(e => e.Payrate).HasColumnName("payrate");

                entity.Property(e => e.Payschedule)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("payschedule");

                entity.Property(e => e.Paytype)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("paytype");

                entity.Property(e => e.Status)
                    .HasColumnType("text")
                    .HasColumnName("status");

                entity.Property(e => e.Visastatus)
                    .HasColumnType("text")
                    .HasColumnName("visastatus");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
