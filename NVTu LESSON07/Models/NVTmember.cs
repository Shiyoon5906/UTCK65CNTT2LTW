using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NVTu_LESSON07.Models
{
    /// <summary>
    /// model class member
    /// </summary>
    public class NVTmember
    {
        public int Id { get; set; }

        [DisplayName("Tài Khoản")]
        [StringLength(20,MinimumLength =3, ErrorMessage ="tài khoản có độ dài trong khoảng 3-20 ký tự")]
        [Required(ErrorMessage ="Tài khoản ko được để trống")]

        public string NvtUserName { get; set; }
        [DisplayName("Mật khẩu")]
        [StringLength(100,MinimumLength =8 ,8,ErrorMessage ="Mật khẩu tối thiểu 8 kí tự")]
        public string NvtPassWord { get; set; }
        [DisplayName("Email")]
        [Required("email ko được để trống")]
        [DataType.EmailAddress]
        public string NvtEmail { get; set; }
        [DisplayName("Điện thoại")]
        [Required(ErrorMessage ="Bạn chưa nhập điện thoại")]
        [RegularExpression(@"^0\d{9,9}",ErrorMessage = "điện thoại phải là 10 ký tự số, bắt đầu bằng số 0")]
        public string NvtPhone { get; set; }   
    }
}
