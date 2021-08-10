using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MySqlDb
{
    public partial class HerkDeStadDbTestContext : DbContext
    {
        public HerkDeStadDbTestContext()
        {
        }

        public HerkDeStadDbTestContext(DbContextOptions<HerkDeStadDbTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Efmigrationshistory> Efmigrationshistories { get; set; }
        public virtual DbSet<Exportcount> Exportcounts { get; set; }
        public virtual DbSet<Gemeenten> Gemeentens { get; set; }
        public virtual DbSet<Huisartsen> Huisartsens { get; set; }
        public virtual DbSet<Inschrijving> Inschrijving { get; set; }
        public virtual DbSet<Inschrijvingtmp> Inschrijvingtmps { get; set; }
        public virtual DbSet<LstLlnMail> LstLlnMails { get; set; }
        public virtual DbSet<Nationaliteit> Nationaliteits { get; set; }
        public virtual DbSet<Otraject> Otrajects { get; set; }
        public virtual DbSet<Paramtabel> Paramtabels { get; set; }
        public virtual DbSet<Scholen> Scholens { get; set; }
        public virtual DbSet<Sequence> Sequences { get; set; }
        public virtual DbSet<Studierichting> Studierichtings { get; set; }
        public virtual DbSet<TblGemeente> TblGemeentes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<VwBeroep> VwBeroeps { get; set; }
        public virtual DbSet<VwBurgerlijkeStand> VwBurgerlijkeStands { get; set; }
        public virtual DbSet<VwNoodtelefoonbij> VwNoodtelefoonbijs { get; set; }
        public virtual DbSet<VwScholen> VwScholens { get; set; }
        public virtual DbSet<Wisaresult> Wisaresults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;port=3306;database=HerkDeStadDbTest;user=root;password=Plpl9633++", Microsoft.EntityFrameworkCore.ServerVersion.FromString("8.0.19-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Efmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__efmigrationshistory");

                entity.Property(e => e.MigrationId)
                    .HasColumnType("varchar(95)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Exportcount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("exportcount");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<Gemeenten>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gemeenten");

                entity.Property(e => e.Deelgemeente)
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Fusiegemeente)
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Niscode)
                    .HasColumnType("text")
                    .HasColumnName("NISCode")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Postcode)
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Postnummer)
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Recordtype)
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Huisartsen>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("huisartsen");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Naam)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Straat)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Telefoonnr)
                    .HasColumnType("varchar(16)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Inschrijving>(entity =>
            {
                entity.ToTable("inschrijving");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Biandere)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("BIAndere")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Biavondstudie).HasColumnName("BIAvondstudie");

                entity.Property(e => e.Biclbattest).HasColumnName("BICLBAttest");

                entity.Property(e => e.Bicompetitiesport).HasColumnName("BICompetitiesport");

                entity.Property(e => e.BicompetitiesportInfo)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("BICompetitiesportInfo")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.BigesprekKlassenleraar).HasColumnName("BIGesprekKlassenleraar");

                entity.Property(e => e.Bikeuze)
                    .IsRequired()
                    .HasColumnType("varchar(90)")
                    .HasColumnName("BIKeuze")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Biklasgenoten)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("BIKlasgenoten")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Bileesniveau)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("BILeesniveau")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Bimiddagpas).HasColumnName("BIMiddagpas");

                entity.Property(e => e.Bioverlegmoment).HasColumnName("BIOverlegmoment");

                entity.Property(e => e.BistrekePunten)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("BIStrekePunten")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DatumInschrijving).HasColumnType("datetime");

                entity.Property(e => e.DatumWijziging).HasColumnType("datetime");

                entity.Property(e => e.Gandere)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("GAndere")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GbroerZusOpSchool)
                    .IsRequired()
                    .HasColumnType("varchar(90)")
                    .HasColumnName("GBroerZusOpSchool")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Gbroers).HasColumnName("GBroers");

                entity.Property(e => e.GeboorteGemeenteId).HasColumnName("GeboorteGemeenteID");

                entity.Property(e => e.Geboortedatum)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Geboorteplaats)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Gebruikersnaaam)
                    .IsRequired()
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Geslacht)
                    .IsRequired()
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Ghoeveelste).HasColumnName("GHoeveelste");

                entity.Property(e => e.Gzussen).HasColumnName("GZussen");

                entity.Property(e => e.Iadd).HasColumnName("IADD");

                entity.Property(e => e.Iadhd).HasColumnName("IADHD");

                entity.Property(e => e.Iandere).HasColumnName("IAndere");

                entity.Property(e => e.IandereInfo)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("IAndereInfo")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Iass).HasColumnName("IASS");

                entity.Property(e => e.IattestLeerPu).HasColumnName("IAttestLeerPU");

                entity.Property(e => e.IbaSofiche).HasColumnName("IBaSOfiche");

                entity.Property(e => e.Iconcentratie).HasColumnName("IConcentratie");

                entity.Property(e => e.Ifobie).HasColumnName("IFobie");

                entity.Property(e => e.IgillesdelaTourette).HasColumnName("IGillesdelaTourette");

                entity.Property(e => e.IkopieOrgineelGetuigschrift).HasColumnName("IKopieOrgineelGetuigschrift");

                entity.Property(e => e.IkopieRapport).HasColumnName("IKopieRapport");

                entity.Property(e => e.Inld).HasColumnName("INLD");

                entity.Property(e => e.Internet)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LandId).HasColumnName("LandID");

                entity.Property(e => e.Lbogedubbeld1)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("LBOGedubbeld1")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lbogedubbeld2)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("LBOGedubbeld2")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lboinstellingsnr1)
                    .IsRequired()
                    .HasColumnType("varchar(6)")
                    .HasColumnName("LBOInstellingsnr1")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lboinstellingsnr2)
                    .IsRequired()
                    .HasColumnType("varchar(6)")
                    .HasColumnName("LBOInstellingsnr2")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lbojaar1).HasColumnName("LBOJaar1");

                entity.Property(e => e.Lbojaar2).HasColumnName("LBOJaar2");

                entity.Property(e => e.Lboschool1)
                    .IsRequired()
                    .HasColumnType("varchar(128)")
                    .HasColumnName("LBOSchool1")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lboschool2)
                    .IsRequired()
                    .HasColumnType("varchar(128)")
                    .HasColumnName("LBOSchool2")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Leerjaar)
                    .IsRequired()
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LlNoodTelefoon)
                    .IsRequired()
                    .HasColumnType("varchar(15)")
                    .HasColumnName("llNoodTelefoon")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LlNoodTelefoonBijId).HasColumnName("llNoodTelefoonBijID");

                entity.Property(e => e.LlnBus)
                    .IsRequired()
                    .HasColumnType("varchar(5)")
                    .HasColumnName("llnBus")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LlnDringendegevallen)
                    .IsRequired()
                    .HasColumnType("varchar(128)")
                    .HasColumnName("llnDringendegevallen")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LlnEmail)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("llnEmail")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LlnGemeente)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("llnGemeente")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LlnGemeenteId).HasColumnName("llnGemeenteID");

                entity.Property(e => e.LlnGsm)
                    .IsRequired()
                    .HasColumnType("varchar(15)")
                    .HasColumnName("llnGSM")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LlnNr)
                    .IsRequired()
                    .HasColumnType("varchar(5)")
                    .HasColumnName("llnNr")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LlnPhone)
                    .IsRequired()
                    .HasColumnType("varchar(15)")
                    .HasColumnName("llnPhone")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LlnPostcode)
                    .IsRequired()
                    .HasColumnType("varchar(6)")
                    .HasColumnName("llnPostcode")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LlnStraat)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("llnStraat")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LsoattestAdvies1)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("LSOAttestAdvies1")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LsoattestAdvies2)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("LSOAttestAdvies2")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LsoattestAdvies3)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("LSOAttestAdvies3")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lsoinstellingsnr1)
                    .IsRequired()
                    .HasColumnType("varchar(6)")
                    .HasColumnName("LSOInstellingsnr1")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lsoinstellingsnr2)
                    .IsRequired()
                    .HasColumnType("varchar(6)")
                    .HasColumnName("LSOInstellingsnr2")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lsoinstellingsnr3)
                    .IsRequired()
                    .HasColumnType("varchar(6)")
                    .HasColumnName("LSOInstellingsnr3")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lsojaar1).HasColumnName("LSOJaar1");

                entity.Property(e => e.Lsojaar2).HasColumnName("LSOJaar2");

                entity.Property(e => e.Lsojaar3).HasColumnName("LSOJaar3");

                entity.Property(e => e.Lsoschool1)
                    .IsRequired()
                    .HasColumnType("varchar(128)")
                    .HasColumnName("LSOSchool1")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lsoschool2)
                    .IsRequired()
                    .HasColumnType("varchar(128)")
                    .HasColumnName("LSOSchool2")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lsoschool3)
                    .IsRequired()
                    .HasColumnType("varchar(128)")
                    .HasColumnName("LSOSchool3")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lzandere).HasColumnName("LZAndere");

                entity.Property(e => e.Lzandereinfo)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("LZAndereinfo")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lzdyscalculie).HasColumnName("LZDyscalculie");

                entity.Property(e => e.Lzdyslexie).HasColumnName("LZDyslexie");

                entity.Property(e => e.Lzdysorthografie).HasColumnName("LZDysorthografie");

                entity.Property(e => e.Lzdyspraxie).HasColumnName("LZDyspraxie");

                entity.Property(e => e.Lzfaalangst).HasColumnName("LZFaalangst");

                entity.Property(e => e.Lzhoogbegaafd).HasColumnName("LZHoogbegaafd");

                entity.Property(e => e.Lzhoogsensitief).HasColumnName("LZHoogsensitief");

                entity.Property(e => e.Lztaalproblemen).HasColumnName("LZTaalproblemen");

                entity.Property(e => e.Mandere).HasColumnName("MAndere");

                entity.Property(e => e.Mandereinfo)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("MAndereinfo")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Mberoep)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("MBeroep")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Mburgelijkestand)
                    .IsRequired()
                    .HasColumnType("varchar(40)")
                    .HasColumnName("MBurgelijkestand")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Mbus)
                    .IsRequired()
                    .HasColumnType("varchar(5)")
                    .HasColumnName("MBus")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Mconcerta).HasColumnName("MConcerta");

                entity.Property(e => e.Memail)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("MEmail")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Mgallergie).HasColumnName("MGAllergie");

                entity.Property(e => e.Mgandere).HasColumnName("MGAndere");

                entity.Property(e => e.Mgandereinfo)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("MGAndereinfo")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Mgastma).HasColumnName("MGAstma");

                entity.Property(e => e.Mgdiabetes).HasColumnName("MGDiabetes");

                entity.Property(e => e.Mgemeente)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("MGemeente")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.MgemeenteId).HasColumnName("MGemeenteID");

                entity.Property(e => e.Mgepilepsie).HasColumnName("MGEpilepsie");

                entity.Property(e => e.Mggehoorprobleem).HasColumnName("MGGehoorprobleem");

                entity.Property(e => e.Mghartafwijking).HasColumnName("MGHartafwijking");

                entity.Property(e => e.Mghooikoorts).HasColumnName("MGHooikoorts");

                entity.Property(e => e.Mglactoseintolerantie).HasColumnName("MGLactoseintolerantie");

                entity.Property(e => e.Mgmigraine).HasColumnName("MGMigraine");

                entity.Property(e => e.Mgmotorischeproblemen).HasColumnName("MGMotorischeproblemen");

                entity.Property(e => e.Mgreuma).HasColumnName("MGReuma");

                entity.Property(e => e.Mgsm)
                    .IsRequired()
                    .HasColumnType("varchar(15)")
                    .HasColumnName("MGSM")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Mgzichtsprobleem).HasColumnName("MGZichtsprobleem");

                entity.Property(e => e.Mgzindelijkheid).HasColumnName("MGZindelijkheid");

                entity.Property(e => e.Mnaam)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("MNaam")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Mnationaliteit)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("MNationaliteit")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.MnationaliteitId).HasColumnName("MNationaliteitID");

                entity.Property(e => e.Mnr)
                    .IsRequired()
                    .HasColumnType("varchar(5)")
                    .HasColumnName("MNr")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Mpostcode)
                    .IsRequired()
                    .HasColumnType("varchar(6)")
                    .HasColumnName("MPostcode")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Mrilatine).HasColumnName("MRilatine");

                entity.Property(e => e.Mrisperdal).HasColumnName("MRisperdal");

                entity.Property(e => e.Mstraat)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("MStraat")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Mvoornaam)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("MVoornaam")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Naam)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Nationaliteit)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NationaliteitId).HasColumnName("NationaliteitID");

                entity.Property(e => e.NicommunicatieOudersRechtstreeks).HasColumnName("NICommunicatieOudersRechtstreeks");

                entity.Property(e => e.NicommunicatieOudersVia)
                    .IsRequired()
                    .HasColumnType("varchar(90)")
                    .HasColumnName("NICommunicatieOudersVia")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NihuisArts)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("NIHuisArts")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NihuisArtsStraat)
                    .IsRequired()
                    .HasColumnType("varchar(90)")
                    .HasColumnName("NIHuisArtsStraat")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NihuisArtsTelef)
                    .IsRequired()
                    .HasColumnType("varchar(16)")
                    .HasColumnName("NIHuisArtsTelef")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Rijksregisternummer)
                    .IsRequired()
                    .HasColumnType("varchar(11)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Roepnaam)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Studierichting)
                    .IsRequired()
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Test).HasColumnName("test");

                entity.Property(e => e.Tsbroeroverleden).HasColumnName("TSBroeroverleden");

                entity.Property(e => e.Tscoouderschap).HasColumnName("TSCoouderschap");

                entity.Property(e => e.Tsernstigziekfamilielid).HasColumnName("TSErnstigziekfamilielid");

                entity.Property(e => e.Tsgeencontactmoeder).HasColumnName("TSGeencontactmoeder");

                entity.Property(e => e.Tsgeencontactvader).HasColumnName("TSGeencontactvader");

                entity.Property(e => e.Tshoederrechtmoeder).HasColumnName("TSHoederrechtmoeder");

                entity.Property(e => e.Tshoederrechtvader).HasColumnName("TSHoederrechtvader");

                entity.Property(e => e.Tsinternaatsleerling).HasColumnName("TSInternaatsleerling");

                entity.Property(e => e.Tsmoederoverleden).HasColumnName("TSMoederoverleden");

                entity.Property(e => e.Tsondertoezichtofjeugdinstelling).HasColumnName("TSOndertoezichtofjeugdinstelling");

                entity.Property(e => e.Tsoudersgescheiden).HasColumnName("TSOudersgescheiden");

                entity.Property(e => e.Tsvaderoverleden).HasColumnName("TSVaderoverleden");

                entity.Property(e => e.TszonderVasteVerblijfplaats).HasColumnName("TSZonderVasteVerblijfplaats");

                entity.Property(e => e.Tszusoverleden).HasColumnName("TSZusoverleden");

                entity.Property(e => e.Vberoep)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VBeroep")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vburgelijkestand)
                    .IsRequired()
                    .HasColumnType("varchar(40)")
                    .HasColumnName("VBurgelijkestand")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vbus)
                    .IsRequired()
                    .HasColumnType("varchar(5)")
                    .HasColumnName("VBus")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vemail)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VEmail")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vgemeente)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VGemeente")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.VgemeenteId).HasColumnName("VGemeenteID");

                entity.Property(e => e.Vgsm)
                    .IsRequired()
                    .HasColumnType("varchar(15)")
                    .HasColumnName("VGSM")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vnaam)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VNaam")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vnationaliteit)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VNationaliteit")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.VnationaliteitId).HasColumnName("VNationaliteitID");

                entity.Property(e => e.Vnr)
                    .IsRequired()
                    .HasColumnType("varchar(5)")
                    .HasColumnName("VNr")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vobus)
                    .IsRequired()
                    .HasColumnType("varchar(5)")
                    .HasColumnName("VOBus")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Voemail)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VOEmail")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vogemeente)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VOGemeente")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.VogemeenteId).HasColumnName("VOGemeenteID");

                entity.Property(e => e.Vogsm)
                    .IsRequired()
                    .HasColumnType("varchar(15)")
                    .HasColumnName("VOGSM")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Voinstelling)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VOInstelling")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.VolgnrAma).HasColumnName("volgnrAma");

                entity.Property(e => e.VolgnrUrs).HasColumnName("volgnrUrs");

                entity.Property(e => e.Vonaam)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VONaam")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vonr)
                    .IsRequired()
                    .HasColumnType("varchar(5)")
                    .HasColumnName("VONr")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Voornamen)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vopostcode)
                    .IsRequired()
                    .HasColumnType("varchar(6)")
                    .HasColumnName("VOPostcode")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.VorelatieTotLln)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VORelatieTotLln")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vostraat)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VOStraat")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vovoornaam)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VOVoornaam")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vpostcode)
                    .IsRequired()
                    .HasColumnType("varchar(6)")
                    .HasColumnName("VPostcode")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vstraat)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VStraat")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vvoornaam)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VVoornaam")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Wisanr)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("WISANR")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Inschrijvingtmp>(entity =>
            {
                entity.ToTable("inschrijvingtmp");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Biandere)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("BIAndere")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Biavondstudie).HasColumnName("BIAvondstudie");

                entity.Property(e => e.Biclbattest).HasColumnName("BICLBAttest");

                entity.Property(e => e.Bicompetitiesport).HasColumnName("BICompetitiesport");

                entity.Property(e => e.BicompetitiesportInfo)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("BICompetitiesportInfo")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.BigesprekKlassenleraar).HasColumnName("BIGesprekKlassenleraar");

                entity.Property(e => e.Bikeuze)
                    .IsRequired()
                    .HasColumnType("varchar(90)")
                    .HasColumnName("BIKeuze")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Biklasgenoten)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("BIKlasgenoten")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Bileesniveau)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("BILeesniveau")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Bimiddagpas).HasColumnName("BIMiddagpas");

                entity.Property(e => e.Bioverlegmoment).HasColumnName("BIOverlegmoment");

                entity.Property(e => e.BistrekePunten)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("BIStrekePunten")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DatumInschrijving).HasColumnType("datetime");

                entity.Property(e => e.DatumWijziging).HasColumnType("datetime");

                entity.Property(e => e.Gandere)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("GAndere")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GbroerZusOpSchool)
                    .IsRequired()
                    .HasColumnType("varchar(90)")
                    .HasColumnName("GBroerZusOpSchool")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Gbroers).HasColumnName("GBroers");

                entity.Property(e => e.GeboorteGemeenteId).HasColumnName("GeboorteGemeenteID");

                entity.Property(e => e.Geboortedatum)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Geboorteplaats)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Gebruikersnaaam)
                    .IsRequired()
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Geslacht)
                    .IsRequired()
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Ghoeveelste).HasColumnName("GHoeveelste");

                entity.Property(e => e.Gzussen).HasColumnName("GZussen");

                entity.Property(e => e.Iadd).HasColumnName("IADD");

                entity.Property(e => e.Iadhd).HasColumnName("IADHD");

                entity.Property(e => e.Iandere).HasColumnName("IAndere");

                entity.Property(e => e.IandereInfo)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("IAndereInfo")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Iass).HasColumnName("IASS");

                entity.Property(e => e.IattestLeerPu).HasColumnName("IAttestLeerPU");

                entity.Property(e => e.IbaSofiche).HasColumnName("IBaSOfiche");

                entity.Property(e => e.Iconcentratie).HasColumnName("IConcentratie");

                entity.Property(e => e.Ifobie).HasColumnName("IFobie");

                entity.Property(e => e.IgillesdelaTourette).HasColumnName("IGillesdelaTourette");

                entity.Property(e => e.IkopieOrgineelGetuigschrift).HasColumnName("IKopieOrgineelGetuigschrift");

                entity.Property(e => e.IkopieRapport).HasColumnName("IKopieRapport");

                entity.Property(e => e.Inld).HasColumnName("INLD");

                entity.Property(e => e.Internet)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LandId).HasColumnName("LandID");

                entity.Property(e => e.Lbogedubbeld1)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("LBOGedubbeld1")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lbogedubbeld2)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("LBOGedubbeld2")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lboinstellingsnr1)
                    .IsRequired()
                    .HasColumnType("varchar(6)")
                    .HasColumnName("LBOInstellingsnr1")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lboinstellingsnr2)
                    .IsRequired()
                    .HasColumnType("varchar(6)")
                    .HasColumnName("LBOInstellingsnr2")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lbojaar1).HasColumnName("LBOJaar1");

                entity.Property(e => e.Lbojaar2).HasColumnName("LBOJaar2");

                entity.Property(e => e.Lboschool1)
                    .IsRequired()
                    .HasColumnType("varchar(128)")
                    .HasColumnName("LBOSchool1")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lboschool2)
                    .IsRequired()
                    .HasColumnType("varchar(128)")
                    .HasColumnName("LBOSchool2")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Leerjaar)
                    .IsRequired()
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LlNoodTelefoon)
                    .IsRequired()
                    .HasColumnType("varchar(15)")
                    .HasColumnName("llNoodTelefoon")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LlNoodTelefoonBijId).HasColumnName("llNoodTelefoonBijID");

                entity.Property(e => e.LlnBus)
                    .IsRequired()
                    .HasColumnType("varchar(5)")
                    .HasColumnName("llnBus")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LlnDringendegevallen)
                    .IsRequired()
                    .HasColumnType("varchar(128)")
                    .HasColumnName("llnDringendegevallen")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LlnEmail)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("llnEmail")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LlnGemeente)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("llnGemeente")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LlnGemeenteId).HasColumnName("llnGemeenteID");

                entity.Property(e => e.LlnGsm)
                    .IsRequired()
                    .HasColumnType("varchar(15)")
                    .HasColumnName("llnGSM")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LlnNr)
                    .IsRequired()
                    .HasColumnType("varchar(5)")
                    .HasColumnName("llnNr")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LlnPhone)
                    .IsRequired()
                    .HasColumnType("varchar(15)")
                    .HasColumnName("llnPhone")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LlnPostcode)
                    .IsRequired()
                    .HasColumnType("varchar(6)")
                    .HasColumnName("llnPostcode")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LlnStraat)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("llnStraat")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LsoattestAdvies1)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("LSOAttestAdvies1")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LsoattestAdvies2)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("LSOAttestAdvies2")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LsoattestAdvies3)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("LSOAttestAdvies3")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lsoinstellingsnr1)
                    .IsRequired()
                    .HasColumnType("varchar(6)")
                    .HasColumnName("LSOInstellingsnr1")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lsoinstellingsnr2)
                    .IsRequired()
                    .HasColumnType("varchar(6)")
                    .HasColumnName("LSOInstellingsnr2")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lsoinstellingsnr3)
                    .IsRequired()
                    .HasColumnType("varchar(6)")
                    .HasColumnName("LSOInstellingsnr3")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lsojaar1).HasColumnName("LSOJaar1");

                entity.Property(e => e.Lsojaar2).HasColumnName("LSOJaar2");

                entity.Property(e => e.Lsojaar3).HasColumnName("LSOJaar3");

                entity.Property(e => e.Lsoschool1)
                    .IsRequired()
                    .HasColumnType("varchar(128)")
                    .HasColumnName("LSOSchool1")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lsoschool2)
                    .IsRequired()
                    .HasColumnType("varchar(128)")
                    .HasColumnName("LSOSchool2")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lsoschool3)
                    .IsRequired()
                    .HasColumnType("varchar(128)")
                    .HasColumnName("LSOSchool3")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lzandere).HasColumnName("LZAndere");

                entity.Property(e => e.Lzandereinfo)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("LZAndereinfo")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lzdyscalculie).HasColumnName("LZDyscalculie");

                entity.Property(e => e.Lzdyslexie).HasColumnName("LZDyslexie");

                entity.Property(e => e.Lzdysorthografie).HasColumnName("LZDysorthografie");

                entity.Property(e => e.Lzdyspraxie).HasColumnName("LZDyspraxie");

                entity.Property(e => e.Lzfaalangst).HasColumnName("LZFaalangst");

                entity.Property(e => e.Lzhoogbegaafd).HasColumnName("LZHoogbegaafd");

                entity.Property(e => e.Lzhoogsensitief).HasColumnName("LZHoogsensitief");

                entity.Property(e => e.Lztaalproblemen).HasColumnName("LZTaalproblemen");

                entity.Property(e => e.Mandere).HasColumnName("MAndere");

                entity.Property(e => e.Mandereinfo)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("MAndereinfo")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Mberoep)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("MBeroep")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Mburgelijkestand)
                    .IsRequired()
                    .HasColumnType("varchar(40)")
                    .HasColumnName("MBurgelijkestand")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Mbus)
                    .IsRequired()
                    .HasColumnType("varchar(5)")
                    .HasColumnName("MBus")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Mconcerta).HasColumnName("MConcerta");

                entity.Property(e => e.Memail)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("MEmail")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Mgallergie).HasColumnName("MGAllergie");

                entity.Property(e => e.Mgandere).HasColumnName("MGAndere");

                entity.Property(e => e.Mgandereinfo)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("MGAndereinfo")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Mgastma).HasColumnName("MGAstma");

                entity.Property(e => e.Mgdiabetes).HasColumnName("MGDiabetes");

                entity.Property(e => e.Mgemeente)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("MGemeente")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.MgemeenteId).HasColumnName("MGemeenteID");

                entity.Property(e => e.Mgepilepsie).HasColumnName("MGEpilepsie");

                entity.Property(e => e.Mggehoorprobleem).HasColumnName("MGGehoorprobleem");

                entity.Property(e => e.Mghartafwijking).HasColumnName("MGHartafwijking");

                entity.Property(e => e.Mghooikoorts).HasColumnName("MGHooikoorts");

                entity.Property(e => e.Mglactoseintolerantie).HasColumnName("MGLactoseintolerantie");

                entity.Property(e => e.Mgmigraine).HasColumnName("MGMigraine");

                entity.Property(e => e.Mgmotorischeproblemen).HasColumnName("MGMotorischeproblemen");

                entity.Property(e => e.Mgreuma).HasColumnName("MGReuma");

                entity.Property(e => e.Mgsm)
                    .IsRequired()
                    .HasColumnType("varchar(15)")
                    .HasColumnName("MGSM")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Mgzichtsprobleem).HasColumnName("MGZichtsprobleem");

                entity.Property(e => e.Mgzindelijkheid).HasColumnName("MGZindelijkheid");

                entity.Property(e => e.Mnaam)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("MNaam")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Mnationaliteit)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("MNationaliteit")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.MnationaliteitId).HasColumnName("MNationaliteitID");

                entity.Property(e => e.Mnr)
                    .IsRequired()
                    .HasColumnType("varchar(5)")
                    .HasColumnName("MNr")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Mpostcode)
                    .IsRequired()
                    .HasColumnType("varchar(6)")
                    .HasColumnName("MPostcode")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Mrilatine).HasColumnName("MRilatine");

                entity.Property(e => e.Mrisperdal).HasColumnName("MRisperdal");

                entity.Property(e => e.Mstraat)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("MStraat")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Mvoornaam)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("MVoornaam")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Naam)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Nationaliteit)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NationaliteitId).HasColumnName("NationaliteitID");

                entity.Property(e => e.NicommunicatieOudersRechtstreeks).HasColumnName("NICommunicatieOudersRechtstreeks");

                entity.Property(e => e.NicommunicatieOudersVia)
                    .IsRequired()
                    .HasColumnType("varchar(90)")
                    .HasColumnName("NICommunicatieOudersVia")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NihuisArts)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("NIHuisArts")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NihuisArtsStraat)
                    .IsRequired()
                    .HasColumnType("varchar(90)")
                    .HasColumnName("NIHuisArtsStraat")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NihuisArtsTelef)
                    .IsRequired()
                    .HasColumnType("varchar(16)")
                    .HasColumnName("NIHuisArtsTelef")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Rijksregisternummer)
                    .IsRequired()
                    .HasColumnType("varchar(11)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Roepnaam)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Studierichting)
                    .IsRequired()
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Test).HasColumnName("test");

                entity.Property(e => e.Tsbroeroverleden).HasColumnName("TSBroeroverleden");

                entity.Property(e => e.Tscoouderschap).HasColumnName("TSCoouderschap");

                entity.Property(e => e.Tsernstigziekfamilielid).HasColumnName("TSErnstigziekfamilielid");

                entity.Property(e => e.Tsgeencontactmoeder).HasColumnName("TSGeencontactmoeder");

                entity.Property(e => e.Tsgeencontactvader).HasColumnName("TSGeencontactvader");

                entity.Property(e => e.Tshoederrechtmoeder).HasColumnName("TSHoederrechtmoeder");

                entity.Property(e => e.Tshoederrechtvader).HasColumnName("TSHoederrechtvader");

                entity.Property(e => e.Tsinternaatsleerling).HasColumnName("TSInternaatsleerling");

                entity.Property(e => e.Tsmoederoverleden).HasColumnName("TSMoederoverleden");

                entity.Property(e => e.Tsondertoezichtofjeugdinstelling).HasColumnName("TSOndertoezichtofjeugdinstelling");

                entity.Property(e => e.Tsoudersgescheiden).HasColumnName("TSOudersgescheiden");

                entity.Property(e => e.Tsvaderoverleden).HasColumnName("TSVaderoverleden");

                entity.Property(e => e.TszonderVasteVerblijfplaats).HasColumnName("TSZonderVasteVerblijfplaats");

                entity.Property(e => e.Tszusoverleden).HasColumnName("TSZusoverleden");

                entity.Property(e => e.Vberoep)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VBeroep")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vburgelijkestand)
                    .IsRequired()
                    .HasColumnType("varchar(40)")
                    .HasColumnName("VBurgelijkestand")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vbus)
                    .IsRequired()
                    .HasColumnType("varchar(5)")
                    .HasColumnName("VBus")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vemail)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VEmail")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vgemeente)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VGemeente")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.VgemeenteId).HasColumnName("VGemeenteID");

                entity.Property(e => e.Vgsm)
                    .IsRequired()
                    .HasColumnType("varchar(15)")
                    .HasColumnName("VGSM")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vnaam)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VNaam")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vnationaliteit)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VNationaliteit")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.VnationaliteitId).HasColumnName("VNationaliteitID");

                entity.Property(e => e.Vnr)
                    .IsRequired()
                    .HasColumnType("varchar(5)")
                    .HasColumnName("VNr")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vobus)
                    .IsRequired()
                    .HasColumnType("varchar(5)")
                    .HasColumnName("VOBus")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Voemail)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VOEmail")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vogemeente)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VOGemeente")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.VogemeenteId).HasColumnName("VOGemeenteID");

                entity.Property(e => e.Vogsm)
                    .IsRequired()
                    .HasColumnType("varchar(15)")
                    .HasColumnName("VOGSM")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Voinstelling)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VOInstelling")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.VolgnrAma).HasColumnName("volgnrAma");

                entity.Property(e => e.VolgnrUrs).HasColumnName("volgnrUrs");

                entity.Property(e => e.Vonaam)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VONaam")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vonr)
                    .IsRequired()
                    .HasColumnType("varchar(5)")
                    .HasColumnName("VONr")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Voornamen)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vopostcode)
                    .IsRequired()
                    .HasColumnType("varchar(6)")
                    .HasColumnName("VOPostcode")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.VorelatieTotLln)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VORelatieTotLln")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vostraat)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VOStraat")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vovoornaam)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VOVoornaam")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vpostcode)
                    .IsRequired()
                    .HasColumnType("varchar(6)")
                    .HasColumnName("VPostcode")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vstraat)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VStraat")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vvoornaam)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("VVoornaam")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Wisanr)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("WISANR")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<LstLlnMail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lst_lln_mail");

                entity.Property(e => e.AlleLlnUitWisaexportGebruikersnaam)
                    .HasColumnType("varchar(9)")
                    .HasColumnName("alle_lln_uit_wisaexportGEBRUIKERSNAAM")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.BicompetitiesportInfo)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("BICompetitiesportInfo")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.BistrekePunten)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("BIStrekePunten")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Busnummer)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("BUSNUMMER")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Gandere)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("GAndere")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Geboorteland)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("GEBOORTELAND")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Geboorteplaats)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("GEBOORTEPLAATS")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Geslacht)
                    .HasColumnType("varchar(1)")
                    .HasColumnName("GESLACHT")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Huisnummer)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("HUISNUMMER")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Inter)
                    .HasColumnType("varchar(2)")
                    .HasColumnName("INTER")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Klasofgroepsnaam)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("KLASOFGROEPSNAAM")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Mgsm)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("MGSM")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Mnm)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("MNM")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Moedermail)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("MOEDERMAIL")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Naam)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("NAAM")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NieuwellnwisaGebruikersnaam)
                    .HasColumnType("varchar(9)")
                    .HasColumnName("nieuwellnwisaGEBRUIKERSNAAM")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NihuisArts)
                    .HasColumnType("varchar(12)")
                    .HasColumnName("NIHuisArts")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NihuisArtsTelef)
                    .HasColumnType("varchar(12)")
                    .HasColumnName("NIHuisArtsTelef")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Postcode)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("POSTCODE")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Sportcomp)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("SPORTCOMP")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Stadgemeente)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("STADGEMEENTE")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Straat)
                    .HasColumnType("varchar(41)")
                    .HasColumnName("STRAAT")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vadermail)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("VADERMAIL")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vgsm)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("VGSM")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vnm)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("VNM")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vogsm)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("VOGSM")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Voinstelling)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("VOInstelling")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vonaam)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("VONaam")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Voornaam)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("VOORNAAM")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.VorelatieTotLln)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("VORelatieTotLln")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vovoornaam)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("VOVoornaam")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Wachtwoord)
                    .HasColumnType("varchar(9)")
                    .HasColumnName("WACHTWOORD")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Wachtwoordcoacc1)
                    .HasColumnType("varchar(9)")
                    .HasColumnName("WACHTWOORDCOACC1")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Wachtwoordcoacc2)
                    .HasColumnType("varchar(9)")
                    .HasColumnName("WACHTWOORDCOACC2")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Nationaliteit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("nationaliteit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Niscode)
                    .HasColumnType("text")
                    .HasColumnName("NISCode")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Omschrijving)
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Vluchteling)
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Otraject>(entity =>
            {
                entity.ToTable("otraject");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Inhoud)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("inhoud")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Keuze)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("keuze")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Otraj)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("otraj")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Paramtabel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("paramtabel");

                entity.Property(e => e.PCode)
                    .HasColumnType("text")
                    .HasColumnName("P_CODE")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PExtra)
                    .HasColumnType("text")
                    .HasColumnName("P_EXTRA")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PId).HasColumnName("P_ID");

                entity.Property(e => e.POmschrijving)
                    .HasColumnType("text")
                    .HasColumnName("P_OMSCHRIJVING")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PRecordtype)
                    .HasColumnType("text")
                    .HasColumnName("P_RECORDTYPE")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PType)
                    .HasColumnType("text")
                    .HasColumnName("P_TYPE")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PVeranderddoor).HasColumnName("P_VERANDERDDOOR");

                entity.Property(e => e.PVeranderdop)
                    .HasColumnType("text")
                    .HasColumnName("P_VERANDERDOP")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Scholen>(entity =>
            {
                entity.ToTable("scholen");

                entity.HasIndex(e => e.Id, "ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bus)
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Email)
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Fax)
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Gemeente)
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GemeenteId).HasColumnName("GemeenteID");

                entity.Property(e => e.Instellingsnummer)
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Naam)
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Nr)
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Postcode)
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Straat)
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Telefoon)
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Typeonderwijs)
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Www)
                    .HasColumnType("text")
                    .HasColumnName("www")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Sequence>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sequence");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<Studierichting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("studierichting");

                entity.Property(e => e.Jaar)
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Keuze).HasColumnName("keuze");

                entity.Property(e => e.Otraject)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("otraject")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Richting)
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<TblGemeente>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_gemeente");

                entity.Property(e => e.GmDeelgemeente)
                    .HasColumnType("varchar(48)")
                    .HasColumnName("GM_DEELGEMEENTE")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GmFusiegemeente)
                    .HasColumnType("varchar(28)")
                    .HasColumnName("GM_FUSIEGEMEENTE")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GmId).HasColumnName("GM_ID");

                entity.Property(e => e.GmLandFk).HasColumnName("GM_LAND_FK");

                entity.Property(e => e.GmNiscode)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("GM_NISCODE")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GmPostcode)
                    .HasColumnType("varchar(9)")
                    .HasColumnName("GM_POSTCODE")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GmPostnummer)
                    .HasColumnType("varchar(9)")
                    .HasColumnName("GM_POSTNUMMER")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GmRecordtype)
                    .HasColumnType("varchar(1)")
                    .HasColumnName("GM_RECORDTYPE")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GmVeranderddoor).HasColumnName("GM_VERANDERDDOOR");

                entity.Property(e => e.GmVeranderdop)
                    .HasColumnType("varchar(24)")
                    .HasColumnName("GM_VERANDERDOP")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.HasIndex(e => e.Username, "username")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Actief).HasColumnName("actief");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("password")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Selection).HasColumnName("selection");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnType("char(32)")
                    .HasColumnName("username")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<VwBeroep>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("vw_beroep");

                entity.Property(e => e.PCode)
                    .HasColumnType("text")
                    .HasColumnName("P_CODE")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PId).HasColumnName("P_ID");

                entity.Property(e => e.POmschrijving)
                    .HasColumnType("text")
                    .HasColumnName("P_OMSCHRIJVING")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<VwBurgerlijkeStand>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("vw_burgerlijke_stand");

                entity.Property(e => e.PCode)
                    .HasColumnType("text")
                    .HasColumnName("P_CODE")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PId).HasColumnName("P_ID");

                entity.Property(e => e.POmschrijving)
                    .HasColumnType("text")
                    .HasColumnName("P_OMSCHRIJVING")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<VwNoodtelefoonbij>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("vw_noodtelefoonbij");

                entity.Property(e => e.PCode)
                    .HasColumnType("text")
                    .HasColumnName("P_CODE")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PId).HasColumnName("P_ID");

                entity.Property(e => e.POmschrijving)
                    .HasColumnType("text")
                    .HasColumnName("P_OMSCHRIJVING")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<VwScholen>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("vw_scholen");

                entity.Property(e => e.Instellingsnummer)
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.School)
                    .HasColumnType("mediumtext")
                    .HasColumnName("school")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Wisaresult>(entity =>
            {
                entity.ToTable("wisaresult");

                entity.HasIndex(e => e.Rowid, "rowid")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Error)
                    .HasColumnType("text")
                    .HasColumnName("error")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.Wisanr).HasColumnName("wisanr");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
