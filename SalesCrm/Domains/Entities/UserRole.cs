namespace SalesCrm.Domains.Entities;

public class UserRole
{
    public string? Id { get; set; }

    public List<string>? Roles { get; set; }

    public string? UserName { get; set; }

    public DateTime Created { get; set; }

    public string? Email { get; set; }

    public DateTimeOffset? LockoutEnd { get; set; }
}
