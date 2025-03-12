using System.ComponentModel.DataAnnotations;

namespace Active.Models {
    public class Message {
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string name { get; set; }

        [Required(ErrorMessage = "Поле email обязательно для заполнения")]
        [EmailAddress(ErrorMessage = "Email заполнен некорректно")]
        public string email { get; set; }

        [Required(ErrorMessage = "Поле Subject обязательно для заполнения")]
        public string subject { get; set; }

        [Required(ErrorMessage = "Поле Message обязательно для заполнения")]
        public string message { get; set; }
    }
}
