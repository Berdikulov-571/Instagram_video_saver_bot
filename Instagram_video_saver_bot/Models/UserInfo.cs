using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Instagram_video_saver_bot.Models
{
    public class UserInfo
    {
        [Key]
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? firstName { get;set; }
        public string? lastName { get;set; }
        public string downloadVideoUrl { get; set; }
    }
}
