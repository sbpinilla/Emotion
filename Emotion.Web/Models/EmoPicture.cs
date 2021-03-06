﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Emotion.Web.Models
{
    public class EmoPicture
    {
        public int Id { get; set; }
        [Display(Name="Foto")]
        public String Name{ get; set; }

        [Required]
        [MaxLength(10,ErrorMessage ="Máximo 10 caracteres")]
        public String  Path  { get; set; }

        public virtual ObservableCollection<EmoFace> Faces { get; set; }

    }
}