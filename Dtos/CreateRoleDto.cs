using System.ComponentModel.DataAnnotations;

namespace AuthApi.Dtos
{
    public class CreateRoleDto
    {
        [Required(ErrorMessage = "Role Name es required")]
        public string RoleName { get; set; } = null!;
    }
}
