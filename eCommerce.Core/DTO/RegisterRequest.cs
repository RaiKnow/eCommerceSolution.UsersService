using eCommerce.Core.Enum;

namespace eCommerce.Core.DTO;

public record RegisterRequest(string? Email, string? Password, string? PersonName, GenderOptions? Gender);
