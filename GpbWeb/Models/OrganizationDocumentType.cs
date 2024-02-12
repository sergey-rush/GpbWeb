using System.ComponentModel.DataAnnotations;

namespace GpbWeb.Models
{
    public enum OrganizationDocumentType
    {
        [Display(Name = "Неизвестно")]
        Unknown = 0,

        [Display(Name = "Банк")]
        Bank = 1,

        [Display(Name = "Контент сайта")]
        Content = 2,

        [Display(Name = "Страхование")]
        Insurance = 3
    }
}