namespace Blockcourse_Processing.DataLayer.Entities;

public partial class Permission
{
    public int PermissionId { get; set; }

    public string PermissionTitle { get; set; } = null!;

    public int? ParentId { get; set; }

    public virtual ICollection<Permission> InverseParent { get; set; } = new List<Permission>();

    public virtual Permission? Parent { get; set; }

    public virtual ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
}
