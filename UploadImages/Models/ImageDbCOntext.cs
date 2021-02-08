using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UploadImages.Models
{
    public class ImageDbCOntext : DbContext
    {
        public ImageDbCOntext(DbContextOptions<ImageDbCOntext> options): base(options)
        {

        }

        public DbSet<ImageModel> Images { get; set; }
    }
}
