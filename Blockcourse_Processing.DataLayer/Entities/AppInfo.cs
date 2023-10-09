using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class AppInfo
{
    public int AppInfoId { get; set; }

    public string? AboutUsUrl { get; set; }

    public string? PrivacyPageUrl { get; set; }

    public string? FrequentlyQuestionPageUrl { get; set; }

    public string? InstagramPageUrl { get; set; }

    public string? SitePageUrl { get; set; }

    public string? SupportPageUrl { get; set; }

    public string? TranslateToken { get; set; }

    public int LastUpdateVersionCode { get; set; }

    public DateTime CreateDate { get; set; }
}
