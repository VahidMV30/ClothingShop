using System.ComponentModel.DataAnnotations;

namespace ClothingShop.Application.DTOs.Category
{
    public class CategoryDto
    {
        [Display(Name = "کد گروه")]
        public long Id { get; set; }

        [Display(Name = "عنوان")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "اسلاگ")]
        public string Slug { get; set; } = string.Empty;

        [Display(Name = "عکس")]
        public string Picture { get; set; } = string.Empty;

        [Display(Name = "Alt عکس")]
        public string PictureAlt { get; set; } = string.Empty;

        [Display(Name = "عنوان عکس")]
        public string PictureTitle { get; set; } = string.Empty;

        [Display(Name = "کلمات کلیدی")]
        public string Keywords { get; set; } = string.Empty;

        [Display(Name = "توضیحات")]
        public string Description { get; set; } = string.Empty;

        [Display(Name = "توضیحات متا")]
        public string MetaDescription { get; set; } = string.Empty;
    }
}
