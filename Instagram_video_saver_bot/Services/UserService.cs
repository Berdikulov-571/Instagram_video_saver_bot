using Instagram_video_saver_bot.DataContexts;
using Instagram_video_saver_bot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Instagram_video_saver_bot.Services
{
    public class UserService
    {
        public void WriteUserInfos(string userName,string firstName,string lastName,string videoUrl)
        {
            using(DataContext contexts = new DataContext())
            {
                UserInfo userInfo = new UserInfo();

                userInfo.UserName = userName;
                userInfo.firstName = firstName;
                userInfo.lastName = lastName;
                userInfo.downloadVideoUrl = videoUrl;

                contexts.UserInfos.Add(userInfo);
                contexts.SaveChanges();
            }

        }
    }
}
