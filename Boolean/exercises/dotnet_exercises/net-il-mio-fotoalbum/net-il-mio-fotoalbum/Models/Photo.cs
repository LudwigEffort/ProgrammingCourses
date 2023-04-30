using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace net_il_mio_fotoalbum.Models
{
    public class Photo
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Insert a title!")]
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage="Insert a description!")]
        public string Decription { get; set; } = string.Empty;
        [Required(ErrorMessage="Insert a url!")]
        public string ImgUrl { get; set; } = string.Empty;
        [Required(ErrorMessage="Insert a value!")]
        public bool IsVisible { get; set; }
    }
}