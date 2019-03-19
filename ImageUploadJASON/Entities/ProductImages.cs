using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImageUploadJSON.Entities
{
    [Table("product_images")]
    public class ProductImage    //: AuditableEntity
    {
        [Column("id", TypeName = "int(10)")]
        public int Id { get; set; }

        [Column("date_added", TypeName = "date")]
        public DateTime? DateUpdated { get; set; }

        [MaxLength(50)]
        [Column("file_name", TypeName = "varchar(50)")]
        public string FileName { get; set; }

        [MaxLength(65535)]
        [Column("image_thumb", TypeName = "blob")]
        public byte[] ImageThumb { get; set; }

        [MaxLength(16777215)]
        [Column("image_full", TypeName = "mediumblob")]
        public byte[] ImageFull { get; set; }

        public string GetImageThumb()
        {
            var base64 = Convert.ToBase64String(ImageThumb);

            return String.Format("data:image/gif;base64,{0}", base64);
        }

        public string GetImageFull()
        {
            var base64 = Convert.ToBase64String(ImageFull);

            return String.Format("data:image/gif;base64,{0}", base64);
        }
    }
}
