using System.ComponentModel.DataAnnotations;
namespace RiderBBS.Model
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="用户名不能为空")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "密码不能为空")]
        public  string Password { get; set; }
    }
}
