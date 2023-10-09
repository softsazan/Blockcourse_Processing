using Blockcourse_Processing.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blockcourse_Processing.DataLayer.Context;

public partial class TikTokDbContext : DbContext
{
   

    public TikTokDbContext(DbContextOptions<TikTokDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AppInfo> AppInfos { get; set; }

    public virtual DbSet<Discount> Discounts { get; set; }

    public virtual DbSet<ExampleWord> ExampleWords { get; set; }

    public virtual DbSet<FlashCart> FlashCarts { get; set; }

    public virtual DbSet<FlashCartCategory> FlashCartCategories { get; set; }

    public virtual DbSet<Grammer> Grammers { get; set; }

    public virtual DbSet<GrammerCategory> GrammerCategories { get; set; }

    public virtual DbSet<GrammerLesson> GrammerLessons { get; set; }

    public virtual DbSet<GrammerObjectType> GrammerObjectTypes { get; set; }

    public virtual DbSet<MeaningFlashCart> MeaningFlashCarts { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<ReadyTicket> ReadyTickets { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RolePermission> RolePermissions { get; set; }

    public virtual DbSet<SlotMachine> SlotMachines { get; set; }

    public virtual DbSet<SpotifyArtist> SpotifyArtists { get; set; }

    public virtual DbSet<SpotifyCategory> SpotifyCategories { get; set; }

    public virtual DbSet<SpotifyMediaText> SpotifyMediaTexts { get; set; }

    public virtual DbSet<SpotifyMedium> SpotifyMedia { get; set; }

    public virtual DbSet<SpotifyMistakesReport> SpotifyMistakesReports { get; set; }

    public virtual DbSet<SpotifyPoster> SpotifyPosters { get; set; }

    public virtual DbSet<SpotifySpecialCategory> SpotifySpecialCategories { get; set; }

    public virtual DbSet<SpotifyTag> SpotifyTags { get; set; }

    public virtual DbSet<Sub> Subs { get; set; }

    public virtual DbSet<SubType> SubTypes { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<TikTokArtist> TikTokArtists { get; set; }

    public virtual DbSet<TikTokComment> TikTokComments { get; set; }

    public virtual DbSet<TikTokTag> TikTokTags { get; set; }

    public virtual DbSet<TiktokCategory> TiktokCategories { get; set; }

    public virtual DbSet<TiktokLike> TiktokLikes { get; set; }

    public virtual DbSet<TiktokMediaText> TiktokMediaTexts { get; set; }

    public virtual DbSet<TiktokMedium> TiktokMedia { get; set; }

    public virtual DbSet<TiktokMistakesReport> TiktokMistakesReports { get; set; }

    public virtual DbSet<TiktokPoster> TiktokPosters { get; set; }

    public virtual DbSet<TiktokSpecialCategory> TiktokSpecialCategories { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserAchivment> UserAchivments { get; set; }

    public virtual DbSet<UserAchivment1> UserAchivments1 { get; set; }

    public virtual DbSet<UserAchivmentCategory> UserAchivmentCategories { get; set; }

    public virtual DbSet<UserAchivmentType> UserAchivmentTypes { get; set; }

    public virtual DbSet<UserAdmin> UserAdmins { get; set; }

    public virtual DbSet<UserAward> UserAwards { get; set; }

    public virtual DbSet<UserEnglishLevel> UserEnglishLevels { get; set; }

    public virtual DbSet<UserLevel> UserLevels { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<UserSub> UserSubs { get; set; }

    public virtual DbSet<UserTag> UserTags { get; set; }

    public virtual DbSet<UserTicket> UserTickets { get; set; }

    public virtual DbSet<UsersActivity> UsersActivities { get; set; }

    public virtual DbSet<Wallet> Wallets { get; set; }

    public virtual DbSet<WalletType> WalletTypes { get; set; }

    public virtual DbSet<WordDeterminition> WordDeterminitions { get; set; }

    public virtual DbSet<YouTubeArtist> YouTubeArtists { get; set; }

    public virtual DbSet<YouTubeCategory> YouTubeCategories { get; set; }

    public virtual DbSet<YouTubeMistakesReport> YouTubeMistakesReports { get; set; }

    public virtual DbSet<YouTubePoster> YouTubePosters { get; set; }

    public virtual DbSet<YouTubeSpecialCategory> YouTubeSpecialCategories { get; set; }

    public virtual DbSet<YouTubeTag> YouTubeTags { get; set; }

    public virtual DbSet<YoutubeLesson> YoutubeLessons { get; set; }

    public virtual DbSet<YoutubeMediaText> YoutubeMediaTexts { get; set; }

    public virtual DbSet<YoutubeMedium> YoutubeMedia { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=e883e731-4ce8-4ab8-a86a-b298a278ab12.hsvc.ir,31735;Initial Catalog=tiktolki_TikTolk;User Id=sa;password=6L2T6oS68OVRIQE57qEPAqvc5L3NirrJ;Trusted_Connection=False;MultipleActiveResultSets=true;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AS");

        modelBuilder.Entity<AppInfo>(entity =>
        {
            entity.ToTable("AppInfo", "App");

            entity.Property(e => e.AppInfoId)
                .ValueGeneratedNever()
                .HasColumnName("AppInfo_Id");
        });

        modelBuilder.Entity<Discount>(entity =>
        {
            entity.ToTable("Discount", "Subs");

            entity.Property(e => e.DiscountCode).HasMaxLength(20);
        });

        modelBuilder.Entity<ExampleWord>(entity =>
        {
            entity.ToTable("ExampleWord", "FlashCart");

            entity.HasIndex(e => e.MeaningFlashCartId, "IX_ExampleWord_MeaningFlashCartId");

            entity.Property(e => e.Example).HasMaxLength(500);
            entity.Property(e => e.MeaningOfExample).HasMaxLength(500);

            entity.HasOne(d => d.MeaningFlashCart).WithMany(p => p.ExampleWords)
                .HasForeignKey(d => d.MeaningFlashCartId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<FlashCart>(entity =>
        {
            entity.ToTable("FlashCart", "FlashCart");

            entity.HasIndex(e => e.FlashCartCategoryId, "IX_FlashCart_FlashCartCategoryId");

            entity.Property(e => e.Word).HasMaxLength(100);

            entity.HasOne(d => d.FlashCartCategory).WithMany(p => p.FlashCarts)
                .HasForeignKey(d => d.FlashCartCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<FlashCartCategory>(entity =>
        {
            entity.ToTable("FlashCartCategory", "FlashCart");

            entity.Property(e => e.Detail).HasMaxLength(150);
            entity.Property(e => e.Picture).HasMaxLength(200);
            entity.Property(e => e.Title).HasMaxLength(150);
        });

        modelBuilder.Entity<Grammer>(entity =>
        {
            entity.ToTable("Grammers", "Grammer");

            entity.HasIndex(e => e.GrammerCategoryId, "IX_Grammers_GrammerCategoryId");

            entity.Property(e => e.Detail).HasMaxLength(500);
            entity.Property(e => e.Title).HasMaxLength(150);

            entity.HasOne(d => d.GrammerCategory).WithMany(p => p.Grammers)
                .HasForeignKey(d => d.GrammerCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<GrammerCategory>(entity =>
        {
            entity.ToTable("GrammerCategory", "Grammer");

            entity.Property(e => e.Detail).HasMaxLength(300);
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<GrammerLesson>(entity =>
        {
            entity.HasKey(e => e.GrammerLessonsId);

            entity.ToTable("GrammerLessons", "Grammer");

            entity.HasIndex(e => e.GrammerId, "IX_GrammerLessons_GrammerId");

            entity.HasIndex(e => e.GrammerObjectTypeId, "IX_GrammerLessons_GrammerObjectTypeId");

            entity.Property(e => e.BgColor).HasMaxLength(20);
            entity.Property(e => e.EnText).HasColumnName("enText");
            entity.Property(e => e.PeText).HasColumnName("peText");
            entity.Property(e => e.Title).HasMaxLength(200);
            entity.Property(e => e.VideoLink).HasMaxLength(200);

            entity.HasOne(d => d.Grammer).WithMany(p => p.GrammerLessons)
                .HasForeignKey(d => d.GrammerId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.GrammerObjectType).WithMany(p => p.GrammerLessons)
                .HasForeignKey(d => d.GrammerObjectTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<GrammerObjectType>(entity =>
        {
            entity.ToTable("GrammerObjectType", "Grammer");

            entity.Property(e => e.GrammerObjectTypeId).ValueGeneratedNever();
            entity.Property(e => e.Type).HasMaxLength(100);
        });

        modelBuilder.Entity<MeaningFlashCart>(entity =>
        {
            entity.ToTable("MeaningFlashCart", "FlashCart");

            entity.HasIndex(e => e.FlashCartId, "IX_MeaningFlashCart_FlashCartId");

            entity.Property(e => e.Meaning).HasMaxLength(100);

            entity.HasOne(d => d.FlashCart).WithMany(p => p.MeaningFlashCarts)
                .HasForeignKey(d => d.FlashCartId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.ToTable("Permission", "Permission");

            entity.HasIndex(e => e.ParentId, "IX_Permission_ParentId");

            entity.Property(e => e.PermissionTitle).HasMaxLength(50);

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasForeignKey(d => d.ParentId);
        });

        modelBuilder.Entity<ReadyTicket>(entity =>
        {
            entity.ToTable("ReadyTicket", "Ticket");

            entity.HasIndex(e => e.UserAdminId, "IX_ReadyTicket_UserAdminId");

            entity.Property(e => e.PictureLink).HasMaxLength(200);
            entity.Property(e => e.Title).HasMaxLength(200);
            entity.Property(e => e.VideoLink).HasMaxLength(200);

            entity.HasOne(d => d.UserAdmin).WithMany(p => p.ReadyTickets)
                .HasForeignKey(d => d.UserAdminId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("Role", "User");

            entity.Property(e => e.RoleTitle).HasMaxLength(200);
        });

        modelBuilder.Entity<RolePermission>(entity =>
        {
            entity.ToTable("RolePermission", "Permission");

            entity.HasIndex(e => e.PermissionId, "IX_RolePermission_PermissionId");

            entity.HasIndex(e => e.RoleId, "IX_RolePermission_RoleId");

            entity.HasOne(d => d.Permission).WithMany(p => p.RolePermissions)
                .HasForeignKey(d => d.PermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Role).WithMany(p => p.RolePermissions)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<SlotMachine>(entity =>
        {
            entity.HasKey(e => e.SlotMachineAwardsId);

            entity.ToTable("SlotMachine", "SlotMachineAwards");

            entity.Property(e => e.BigImageUrl).HasMaxLength(200);
            entity.Property(e => e.Detai).HasMaxLength(300);
            entity.Property(e => e.Probability).HasColumnType("decimal(18, 9)");
            entity.Property(e => e.SmallImageUrl).HasMaxLength(200);
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<SpotifyArtist>(entity =>
        {
            entity.ToTable("SpotifyArtist", "Spotify");

            entity.Property(e => e.ArtistName).HasMaxLength(50);
            entity.Property(e => e.ArtistPicture).HasMaxLength(200);
        });

        modelBuilder.Entity<SpotifyCategory>(entity =>
        {
            entity.ToTable("SpotifyCategory", "Spotify");

            entity.Property(e => e.Picture).HasMaxLength(150);
            entity.Property(e => e.Title).HasMaxLength(150);
        });

        modelBuilder.Entity<SpotifyMediaText>(entity =>
        {
            entity.ToTable("SpotifyMediaText", "Spotify");

            entity.HasIndex(e => e.SpotifyMediaId, "IX_SpotifyMediaText_SpotifyMediaId").IsUnique();

            entity.Property(e => e.SpotifyMediaTextId).ValueGeneratedNever();

            entity.HasOne(d => d.SpotifyMedia).WithOne(p => p.SpotifyMediaText)
                .HasForeignKey<SpotifyMediaText>(d => d.SpotifyMediaId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<SpotifyMedium>(entity =>
        {
            entity.HasKey(e => e.SpotifyMediaId);

            entity.ToTable("SpotifyMedia", "Spotify");

            entity.HasIndex(e => e.SpotifyArtistId, "IX_SpotifyMedia_SpotifyArtistId");

            entity.HasIndex(e => e.SpotifyCategoryId, "IX_SpotifyMedia_SpotifyCategoryId");

            entity.HasIndex(e => e.SpotifyPosterId, "IX_SpotifyMedia_SpotifyPosterId");

            entity.HasIndex(e => e.SpotifySpecialCategoryId, "IX_SpotifyMedia_SpotifySpecialCategoryId");

            entity.HasIndex(e => e.UserAdminId, "IX_SpotifyMedia_UserAdminId");

            entity.HasIndex(e => e.UserEnglishLevelId, "IX_SpotifyMedia_UserEnglishLevelId");

            entity.Property(e => e.SpotifyMediaId).ValueGeneratedNever();
            entity.Property(e => e.DeepLink).HasMaxLength(200);
            entity.Property(e => e.DownloadMediaUrl).HasMaxLength(200);
            entity.Property(e => e.MediaUrl).HasMaxLength(200);
            entity.Property(e => e.Title).HasMaxLength(200);

            entity.HasOne(d => d.SpotifyArtist).WithMany(p => p.SpotifyMedia)
                .HasForeignKey(d => d.SpotifyArtistId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.SpotifyCategory).WithMany(p => p.SpotifyMedia)
                .HasForeignKey(d => d.SpotifyCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.SpotifyPoster).WithMany(p => p.SpotifyMedia).HasForeignKey(d => d.SpotifyPosterId);

            entity.HasOne(d => d.SpotifySpecialCategory).WithMany(p => p.SpotifyMedia).HasForeignKey(d => d.SpotifySpecialCategoryId);

            entity.HasOne(d => d.UserAdmin).WithMany(p => p.SpotifyMedia)
                .HasForeignKey(d => d.UserAdminId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.UserEnglishLevel).WithMany(p => p.SpotifyMedia)
                .HasForeignKey(d => d.UserEnglishLevelId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<SpotifyMistakesReport>(entity =>
        {
            entity.HasKey(e => e.YouTubeMistakesReportId);

            entity.ToTable("SpotifyMistakesReport", "Spotify");

            entity.HasIndex(e => e.SpotifyMediaId, "IX_SpotifyMistakesReport_SpotifyMediaId");

            entity.HasIndex(e => e.UserId, "IX_SpotifyMistakesReport_UserId");

            entity.Property(e => e.ReportText).HasMaxLength(800);

            entity.HasOne(d => d.SpotifyMedia).WithMany(p => p.SpotifyMistakesReports)
                .HasForeignKey(d => d.SpotifyMediaId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.User).WithMany(p => p.SpotifyMistakesReports)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<SpotifyPoster>(entity =>
        {
            entity.ToTable("SpotifyPoster", "Spotify");

            entity.Property(e => e.ImagePath).HasMaxLength(200);
            entity.Property(e => e.RedirectLink).HasMaxLength(200);
        });

        modelBuilder.Entity<SpotifySpecialCategory>(entity =>
        {
            entity.ToTable("SpotifySpecialCategory", "Spotify");

            entity.Property(e => e.PictureName).HasMaxLength(150);
            entity.Property(e => e.Title).HasMaxLength(150);
        });

        modelBuilder.Entity<SpotifyTag>(entity =>
        {
            entity.HasKey(e => e.SpotifyTagsId);

            entity.ToTable("SpotifyTags", "Spotify");

            entity.HasIndex(e => e.SpotifyMediaId, "IX_SpotifyTags_SpotifyMediaId");

            entity.HasIndex(e => e.TagsId, "IX_SpotifyTags_TagsId");

            entity.HasOne(d => d.SpotifyMedia).WithMany(p => p.SpotifyTags)
                .HasForeignKey(d => d.SpotifyMediaId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Tags).WithMany(p => p.SpotifyTags)
                .HasForeignKey(d => d.TagsId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Sub>(entity =>
        {
            entity.HasKey(e => e.SubsId);

            entity.ToTable("Subs", "Subs");

            entity.HasIndex(e => e.SubTypeId, "IX_Subs_SubTypeId");

            entity.HasOne(d => d.SubType).WithMany(p => p.Subs)
                .HasForeignKey(d => d.SubTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<SubType>(entity =>
        {
            entity.ToTable("SubType", "Subs");

            entity.Property(e => e.CafebazarSku).HasColumnName("cafebazar_sku");
            entity.Property(e => e.CallbackUri).HasColumnName("callback_uri");
            entity.Property(e => e.Deeplink).HasColumnName("deeplink");
            entity.Property(e => e.Detail).HasMaxLength(1000);
            entity.Property(e => e.GoogleplaySku).HasColumnName("googleplay_sku");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.SkuName).HasColumnName("sku_name");
            entity.Property(e => e.Title).HasMaxLength(200);
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.HasKey(e => e.TagsId);

            entity.ToTable("Tags", "Tag");

            entity.Property(e => e.EnName).HasMaxLength(20);
            entity.Property(e => e.PeName).HasMaxLength(20);
        });

        modelBuilder.Entity<TikTokArtist>(entity =>
        {
            entity.ToTable("TikTokArtist", "TikTok");

            entity.Property(e => e.ArtistName).HasMaxLength(50);
            entity.Property(e => e.ArtistPicture).HasMaxLength(200);
        });

        modelBuilder.Entity<TikTokComment>(entity =>
        {
            entity.ToTable("TikTokComment", "TikTok");

            entity.HasIndex(e => e.TiktokMediaId, "IX_TikTokComment_TiktokMediaId");

            entity.HasIndex(e => e.UserId, "IX_TikTokComment_UserId");

            entity.Property(e => e.Comment).HasMaxLength(800);

            entity.HasOne(d => d.TiktokMedia).WithMany(p => p.TikTokComments)
                .HasForeignKey(d => d.TiktokMediaId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.User).WithMany(p => p.TikTokComments)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TikTokTag>(entity =>
        {
            entity.HasKey(e => e.TikTokTagsId);

            entity.ToTable("TikTokTags", "TikTok");

            entity.HasIndex(e => e.TagsId, "IX_TikTokTags_TagsId");

            entity.HasIndex(e => e.TiktokMediaId, "IX_TikTokTags_TiktokMediaId");

            entity.HasOne(d => d.Tags).WithMany(p => p.TikTokTags)
                .HasForeignKey(d => d.TagsId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.TiktokMedia).WithMany(p => p.TikTokTags)
                .HasForeignKey(d => d.TiktokMediaId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TiktokCategory>(entity =>
        {
            entity.ToTable("TiktokCategory", "TikTok");

            entity.Property(e => e.Picture).HasMaxLength(150);
            entity.Property(e => e.Title).HasMaxLength(150);
        });

        modelBuilder.Entity<TiktokLike>(entity =>
        {
            entity.ToTable("TiktokLikes", "TikTok");

            entity.HasIndex(e => e.TiktokMediaId, "IX_TiktokLikes_TiktokMediaId");

            entity.HasIndex(e => e.UserId, "IX_TiktokLikes_UserId");

            entity.HasOne(d => d.TiktokMedia).WithMany(p => p.TiktokLikes)
                .HasForeignKey(d => d.TiktokMediaId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.User).WithMany(p => p.TiktokLikes)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TiktokMediaText>(entity =>
        {
            entity.ToTable("TiktokMediaText", "TikTok");

            entity.HasIndex(e => e.TiktokMediaId, "IX_TiktokMediaText_TiktokMediaId").IsUnique();

            entity.Property(e => e.TiktokMediaTextId).ValueGeneratedNever();

            entity.HasOne(d => d.TiktokMedia).WithOne(p => p.TiktokMediaText)
                .HasForeignKey<TiktokMediaText>(d => d.TiktokMediaId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TiktokMedium>(entity =>
        {
            entity.HasKey(e => e.TiktokMediaId);

            entity.ToTable("TiktokMedia", "TikTok");

            entity.HasIndex(e => e.TikTokArtistId, "IX_TiktokMedia_TikTokArtistId");

            entity.HasIndex(e => e.TiktokCategoryId, "IX_TiktokMedia_TiktokCategoryId");

            entity.HasIndex(e => e.TiktokPosterId, "IX_TiktokMedia_TiktokPosterId");

            entity.HasIndex(e => e.TiktokSpecialCategoryId, "IX_TiktokMedia_TiktokSpecialCategoryId");

            entity.HasIndex(e => e.UserAdminId, "IX_TiktokMedia_UserAdminId");

            entity.HasIndex(e => e.UserEnglishLevelId, "IX_TiktokMedia_UserEnglishLevelId");

            entity.Property(e => e.TiktokMediaId).ValueGeneratedNever();
            entity.Property(e => e.DeepLink).HasMaxLength(200);
            entity.Property(e => e.DownloadMediaUrl).HasMaxLength(200);
            entity.Property(e => e.MediaUrl).HasMaxLength(200);
            entity.Property(e => e.Title).HasMaxLength(200);

            entity.HasOne(d => d.TikTokArtist).WithMany(p => p.TiktokMedia)
                .HasForeignKey(d => d.TikTokArtistId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.TiktokCategory).WithMany(p => p.TiktokMedia)
                .HasForeignKey(d => d.TiktokCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.TiktokPoster).WithMany(p => p.TiktokMedia).HasForeignKey(d => d.TiktokPosterId);

            entity.HasOne(d => d.TiktokSpecialCategory).WithMany(p => p.TiktokMedia).HasForeignKey(d => d.TiktokSpecialCategoryId);

            entity.HasOne(d => d.UserAdmin).WithMany(p => p.TiktokMedia)
                .HasForeignKey(d => d.UserAdminId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.UserEnglishLevel).WithMany(p => p.TiktokMedia)
                .HasForeignKey(d => d.UserEnglishLevelId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TiktokMistakesReport>(entity =>
        {
            entity.ToTable("TiktokMistakesReport", "TikTok");

            entity.HasIndex(e => e.TiktokMediaId, "IX_TiktokMistakesReport_TiktokMediaId");

            entity.HasIndex(e => e.UserId, "IX_TiktokMistakesReport_UserId");

            entity.Property(e => e.ReportText).HasMaxLength(800);

            entity.HasOne(d => d.TiktokMedia).WithMany(p => p.TiktokMistakesReports)
                .HasForeignKey(d => d.TiktokMediaId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.User).WithMany(p => p.TiktokMistakesReports)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TiktokPoster>(entity =>
        {
            entity.ToTable("TiktokPoster", "TikTok");

            entity.Property(e => e.ImagePath).HasMaxLength(200);
            entity.Property(e => e.RedirectLink).HasMaxLength(200);
        });

        modelBuilder.Entity<TiktokSpecialCategory>(entity =>
        {
            entity.ToTable("TiktokSpecialCategory", "TikTok");

            entity.Property(e => e.PictureName).HasMaxLength(150);
            entity.Property(e => e.Title).HasMaxLength(150);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User", "User");

            entity.HasIndex(e => e.UserEnglishLevelId, "IX_User_UserEnglishLevelId");

            entity.HasIndex(e => e.UserLevelId, "IX_User_UserLevelId");

            entity.Property(e => e.Bio)
                .HasMaxLength(500)
                .HasColumnName("bio");
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.PhoneNumber).HasMaxLength(11);
            entity.Property(e => e.ProfilePicture).HasMaxLength(200);
            entity.Property(e => e.SurName).HasMaxLength(100);
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.UserNameInstagram).HasMaxLength(30);
            entity.Property(e => e.VerificationCode).HasMaxLength(4);

            entity.HasOne(d => d.UserEnglishLevel).WithMany(p => p.Users).HasForeignKey(d => d.UserEnglishLevelId);

            entity.HasOne(d => d.UserLevel).WithMany(p => p.Users).HasForeignKey(d => d.UserLevelId);
        });

        modelBuilder.Entity<UserAchivment>(entity =>
        {
            entity.ToTable("UserAchivment", "User");

            entity.HasIndex(e => e.UserAchivmentCategoryId, "IX_UserAchivment_UserAchivmentCategoryId");

            entity.HasIndex(e => e.UserAchivmentTypeId, "IX_UserAchivment_UserAchivmentTypeId");

            entity.Property(e => e.Detail).HasMaxLength(100);
            entity.Property(e => e.Picture).HasMaxLength(200);
            entity.Property(e => e.Title).HasMaxLength(50);

            entity.HasOne(d => d.UserAchivmentCategory).WithMany(p => p.UserAchivments)
                .HasForeignKey(d => d.UserAchivmentCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.UserAchivmentType).WithMany(p => p.UserAchivments)
                .HasForeignKey(d => d.UserAchivmentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<UserAchivment1>(entity =>
        {
            entity.HasKey(e => e.UserAchivmentsId);

            entity.ToTable("UserAchivments", "User");

            entity.HasIndex(e => e.UserAchivmentId, "IX_UserAchivments_UserAchivmentId");

            entity.HasIndex(e => e.UserId, "IX_UserAchivments_UserId");

            entity.HasOne(d => d.UserAchivment).WithMany(p => p.UserAchivment1s)
                .HasForeignKey(d => d.UserAchivmentId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.User).WithMany(p => p.UserAchivment1s)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<UserAchivmentCategory>(entity =>
        {
            entity.ToTable("UserAchivmentCategory", "User");

            entity.Property(e => e.Detail).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<UserAchivmentType>(entity =>
        {
            entity.ToTable("UserAchivmentType", "User");

            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<UserAdmin>(entity =>
        {
            entity.ToTable("UserAdmin", "User");

            entity.HasIndex(e => e.UserId, "IX_UserAdmin_UserId");

            entity.Property(e => e.NameAdmin).HasMaxLength(200);

            entity.HasOne(d => d.User).WithMany(p => p.UserAdmins)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<UserAward>(entity =>
        {
            entity.HasKey(e => e.UserAwardsId);

            entity.ToTable("UserAwards", "User");

            entity.HasIndex(e => e.SlotMachineAwardsId, "IX_UserAwards_SlotMachineAwardsId");

            entity.HasIndex(e => e.UserId, "IX_UserAwards_UserId");

            entity.HasOne(d => d.SlotMachineAwards).WithMany(p => p.UserAwards)
                .HasForeignKey(d => d.SlotMachineAwardsId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.User).WithMany(p => p.UserAwards)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<UserEnglishLevel>(entity =>
        {
            entity.ToTable("UserEnglishLevel", "User");

            entity.Property(e => e.UserEnglishLevelId).ValueGeneratedNever();
            entity.Property(e => e.Detail).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(2);
        });

        modelBuilder.Entity<UserLevel>(entity =>
        {
            entity.ToTable("UserLevel", "User");

            entity.Property(e => e.UserLevelId).ValueGeneratedNever();
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => e.UrId);

            entity.ToTable("UserRole", "User");

            entity.HasIndex(e => e.RoleId, "IX_UserRole_RoleId");

            entity.HasIndex(e => e.UserId, "IX_UserRole_UserId");

            entity.Property(e => e.UrId).HasColumnName("UR_Id");

            entity.HasOne(d => d.Role).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.User).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<UserSub>(entity =>
        {
            entity.HasKey(e => e.UserSubsId);

            entity.ToTable("UserSubs", "User");

            entity.HasIndex(e => e.SubsId, "IX_UserSubs_SubsId");

            entity.HasIndex(e => e.UserId, "IX_UserSubs_UserId");

            entity.HasOne(d => d.Subs).WithMany(p => p.UserSubs)
                .HasForeignKey(d => d.SubsId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.User).WithMany(p => p.UserSubs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<UserTag>(entity =>
        {
            entity.HasKey(e => e.UserTagsId);

            entity.HasIndex(e => e.TagsId, "IX_UserTags_TagsId");

            entity.HasIndex(e => e.UserId, "IX_UserTags_UserId");

            entity.HasOne(d => d.Tags).WithMany(p => p.UserTags)
                .HasForeignKey(d => d.TagsId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.User).WithMany(p => p.UserTags)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<UserTicket>(entity =>
        {
            entity.ToTable("UserTicket", "Ticket");

            entity.HasIndex(e => e.UserAdminId, "IX_UserTicket_UserAdminId");

            entity.HasIndex(e => e.UserId, "IX_UserTicket_UserId");

            entity.Property(e => e.PictureLink).HasMaxLength(200);
            entity.Property(e => e.Title).HasMaxLength(100);
            entity.Property(e => e.VideoLink).HasMaxLength(200);

            entity.HasOne(d => d.UserAdmin).WithMany(p => p.UserTickets)
                .HasForeignKey(d => d.UserAdminId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.User).WithMany(p => p.UserTickets)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<UsersActivity>(entity =>
        {
            entity.HasKey(e => e.UsersActivitiesId);

            entity.ToTable("UsersActivities", "User");

            entity.HasIndex(e => e.UserId, "IX_UsersActivities_UserId");

            entity.Property(e => e.YearlyTiktokWatchTime).HasColumnName("yearlyTiktokWatchTime");

            entity.HasOne(d => d.User).WithMany(p => p.UsersActivities)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Wallet>(entity =>
        {
            entity.ToTable("Wallet", "Wallet");

            entity.HasIndex(e => e.TypeId, "IX_Wallet_TypeId");

            entity.HasIndex(e => e.UserId, "IX_Wallet_UserId");

            entity.Property(e => e.Description).HasMaxLength(300);

            entity.HasOne(d => d.Type).WithMany(p => p.Wallets)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.User).WithMany(p => p.Wallets)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<WalletType>(entity =>
        {
            entity.HasKey(e => e.TypeId);

            entity.ToTable("WalletType", "Wallet");

            entity.Property(e => e.TypeId).ValueGeneratedNever();
            entity.Property(e => e.TypeTitle).HasMaxLength(50);
        });

        modelBuilder.Entity<WordDeterminition>(entity =>
        {
            entity.ToTable("WordDeterminition", "User");

            entity.Property(e => e.Level).HasMaxLength(100);
        });

        modelBuilder.Entity<YouTubeArtist>(entity =>
        {
            entity.ToTable("YouTubeArtist", "YouTube");

            entity.Property(e => e.ArtistName).HasMaxLength(50);
            entity.Property(e => e.ArtistPicture).HasMaxLength(200);
        });

        modelBuilder.Entity<YouTubeCategory>(entity =>
        {
            entity.ToTable("YouTubeCategory", "YouTube");

            entity.Property(e => e.Picture).HasMaxLength(150);
            entity.Property(e => e.Title).HasMaxLength(150);
        });

        modelBuilder.Entity<YouTubeMistakesReport>(entity =>
        {
            entity.HasKey(e => e.TiktokMistakesReportId);

            entity.ToTable("YouTubeMistakesReport", "YouTube");

            entity.HasIndex(e => e.UserId, "IX_YouTubeMistakesReport_UserId");

            entity.HasIndex(e => e.YoutubeMediaId, "IX_YouTubeMistakesReport_YoutubeMediaId");

            entity.Property(e => e.ReportText).HasMaxLength(800);

            entity.HasOne(d => d.User).WithMany(p => p.YouTubeMistakesReports)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.YoutubeMedia).WithMany(p => p.YouTubeMistakesReports)
                .HasForeignKey(d => d.YoutubeMediaId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<YouTubePoster>(entity =>
        {
            entity.ToTable("YouTubePoster", "YouTube");

            entity.Property(e => e.ImagePath).HasMaxLength(200);
            entity.Property(e => e.RedirectLink).HasMaxLength(200);
        });

        modelBuilder.Entity<YouTubeSpecialCategory>(entity =>
        {
            entity.ToTable("YouTubeSpecialCategory", "YouTube");

            entity.Property(e => e.PictureName).HasMaxLength(150);
            entity.Property(e => e.Title).HasMaxLength(150);
        });

        modelBuilder.Entity<YouTubeTag>(entity =>
        {
            entity.HasKey(e => e.YouTubeTagsId);

            entity.ToTable("YouTubeTags", "YouTube");

            entity.HasIndex(e => e.TagsId, "IX_YouTubeTags_TagsId");

            entity.HasIndex(e => e.YoutubeLessonsId, "IX_YouTubeTags_YoutubeLessonsId");

            entity.HasOne(d => d.Tags).WithMany(p => p.YouTubeTags)
                .HasForeignKey(d => d.TagsId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.YoutubeLessons).WithMany(p => p.YouTubeTags)
                .HasForeignKey(d => d.YoutubeLessonsId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<YoutubeLesson>(entity =>
        {
            entity.HasKey(e => e.YoutubeLessonsId);

            entity.ToTable("YoutubeLessons", "YouTube");

            entity.HasIndex(e => e.UserAdminId, "IX_YoutubeLessons_UserAdminId");

            entity.HasIndex(e => e.UserEnglishLevelId, "IX_YoutubeLessons_UserEnglishLevelId");

            entity.HasIndex(e => e.YouTubeArtistId, "IX_YoutubeLessons_YouTubeArtistId");

            entity.HasIndex(e => e.YouTubeCategoryId, "IX_YoutubeLessons_YouTubeCategoryId");

            entity.HasIndex(e => e.YouTubePosterId, "IX_YoutubeLessons_YouTubePosterId");

            entity.HasIndex(e => e.YouTubeSpecialCategoryId, "IX_YoutubeLessons_YouTubeSpecialCategoryId");

            entity.Property(e => e.YoutubeLessonsId).ValueGeneratedNever();
            entity.Property(e => e.Picture).HasMaxLength(200);
            entity.Property(e => e.Title).HasMaxLength(100);

            entity.HasOne(d => d.UserAdmin).WithMany(p => p.YoutubeLessons)
                .HasForeignKey(d => d.UserAdminId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.UserEnglishLevel).WithMany(p => p.YoutubeLessons)
                .HasForeignKey(d => d.UserEnglishLevelId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.YouTubeArtist).WithMany(p => p.YoutubeLessons)
                .HasForeignKey(d => d.YouTubeArtistId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.YouTubeCategory).WithMany(p => p.YoutubeLessons)
                .HasForeignKey(d => d.YouTubeCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.YouTubePoster).WithMany(p => p.YoutubeLessons).HasForeignKey(d => d.YouTubePosterId);

            entity.HasOne(d => d.YouTubeSpecialCategory).WithMany(p => p.YoutubeLessons).HasForeignKey(d => d.YouTubeSpecialCategoryId);
        });

        modelBuilder.Entity<YoutubeMediaText>(entity =>
        {
            entity.ToTable("YoutubeMediaText", "YouTube");

            entity.HasIndex(e => e.YoutubeMediaId, "IX_YoutubeMediaText_YoutubeMediaId").IsUnique();

            entity.Property(e => e.YoutubeMediaTextId).ValueGeneratedNever();

            entity.HasOne(d => d.YoutubeMedia).WithOne(p => p.YoutubeMediaText)
                .HasForeignKey<YoutubeMediaText>(d => d.YoutubeMediaId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<YoutubeMedium>(entity =>
        {
            entity.HasKey(e => e.YoutubeMediaId);

            entity.ToTable("YoutubeMedia", "YouTube");

            entity.HasIndex(e => e.YoutubeLessonsId, "IX_YoutubeMedia_YoutubeLessonsId");

            entity.Property(e => e.YoutubeMediaId).ValueGeneratedNever();
            entity.Property(e => e.DeepLink).HasMaxLength(200);
            entity.Property(e => e.DownloadMediaUrl).HasMaxLength(200);
            entity.Property(e => e.MediaDuration).HasMaxLength(20);
            entity.Property(e => e.MediaPicture).HasMaxLength(200);
            entity.Property(e => e.MediaSize).HasMaxLength(20);
            entity.Property(e => e.MediaUrl).HasMaxLength(200);
            entity.Property(e => e.Title).HasMaxLength(150);

            entity.HasOne(d => d.YoutubeLessons).WithMany(p => p.YoutubeMedia).HasForeignKey(d => d.YoutubeLessonsId);
        });

      

        modelBuilder.Entity<User>()
            .HasQueryFilter(u => !u.IsLocked);
        modelBuilder.Entity<TikTokComment>()
            .HasQueryFilter(c => !c.IsDelete);
        modelBuilder.Entity<Role>()
            .HasQueryFilter(r => !r.IsDelete);
        modelBuilder.Entity<Tag>()
            .HasQueryFilter(t => !t.IsDelete);
        modelBuilder.Entity<SubType>()
            .HasQueryFilter(s => !s.IsDelete);
        modelBuilder.Entity<UserAchivment>()
           .HasQueryFilter(s => !s.IsDelete);
        modelBuilder.Entity<YoutubeLesson>()
            .HasQueryFilter(s => !s.IsDelete);
        #region Media
        modelBuilder.Entity<SpotifyMedium>()
          .HasQueryFilter(s => !s.IsDelete);
        modelBuilder.Entity<YoutubeMedium>()
           .HasQueryFilter(y => !y.IsDelete);
        modelBuilder.Entity<TiktokMedium>()
           .HasQueryFilter(t => !t.IsDelete);
        #endregion

        #region SpotifyPoster
        modelBuilder.Entity<SpotifyPoster>()
            .HasQueryFilter(p => !p.IsActive);
        modelBuilder.Entity<YouTubePoster>()
            .HasQueryFilter(p => !p.IsActive);
        modelBuilder.Entity<TiktokPoster>()
            .HasQueryFilter(p => !p.IsActive);
        #endregion

        #region SpotifySpecialCategory
        modelBuilder.Entity<SpotifySpecialCategory>()
            .HasQueryFilter(s => !s.IsDelete);
        modelBuilder.Entity<YouTubeSpecialCategory>()
            .HasQueryFilter(s => !s.IsDelete);
        modelBuilder.Entity<TiktokSpecialCategory>()
            .HasQueryFilter(s => !s.IsDelete);
        #endregion

        #region Category
        modelBuilder.Entity<SpotifyCategory>()
            .HasQueryFilter(s => !s.IsDelete);
        modelBuilder.Entity<TiktokCategory>()
            .HasQueryFilter(s => !s.IsDelete);
        modelBuilder.Entity<YouTubeCategory>()
            .HasQueryFilter(s => !s.IsDelete);
        #endregion

        #region Poster


        modelBuilder.Entity<SpotifyPoster>()
            .HasQueryFilter(s => !s.IsDelete);
        modelBuilder.Entity<TiktokPoster>()
            .HasQueryFilter(p => !p.IsDelete);
        modelBuilder.Entity<YouTubePoster>()
            .HasQueryFilter(p => !p.IsDelete);

        #endregion

        #region FlashCart
        modelBuilder.Entity<FlashCartCategory>()
            .HasQueryFilter(f => !f.IsDelete);
        #endregion

        #region Grammers
        modelBuilder.Entity<GrammerObjectType>()
            .HasQueryFilter(g => !g.IsDelete);
        modelBuilder.Entity<Grammer>()
           .HasQueryFilter(g => !g.IsDelete);
        modelBuilder.Entity<GrammerCategory>()
            .HasQueryFilter(g => !g.IsDelete);
        #endregion

        #region UserAchivment
        modelBuilder.Entity<UserAchivmentCategory>()
           .HasQueryFilter(a => !a.IsDelete);
        modelBuilder.Entity<UserAchivmentType>()
          .HasQueryFilter(a => !a.IsDelete);
        modelBuilder.Entity<UserAchivment>()
          .HasQueryFilter(a => !a.IsDelete);

        #endregion

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
