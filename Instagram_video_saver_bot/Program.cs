using Instagram_video_saver_bot.Services;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace Instagram_video_saver_bot
{
    public class Program
    {
        private static ITelegramBotClient botClient;

        static void Main(string[] args)
        {
            botClient = new TelegramBotClient("6065122235:AAFann0LaizoHB7dU1-5T99VhPRrroVSNRo");

            botClient.OnMessage += Bot_OnMessage;

            botClient.StartReceiving();

            Console.ReadLine();
        }
        private static async void Bot_OnMessage(object? sender, MessageEventArgs e)
        {
            var text = e.Message.Text;

            if (text == "/start")
            {
                await botClient.SendTextMessageAsync(e.Message.Chat.Id, $"Assalomu aleykum {e.Message.Chat.FirstName}");
            }
            else if (text.StartsWith("https://www.instagram.com"))
            {
                try
                {
                    await botClient.SendTextMessageAsync(e.Message.Chat.Id, "Downloading📥", replyToMessageId: e.Message.MessageId);

                    var newText = text.Substring(12);

                    await botClient.SendVideoAsync(e.Message.Chat.Id, video: "https://dd" + newText);

                    UserService userServices = new UserService();
                    var user = e.Message.Chat;
                    userServices.WriteUserInfos(user.Username,user.FirstName,user.LastName,text);
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}


//https://www.instagram.com/reel/Cv2s8Pmhv3M/?utm_source=ig_web_copy_link
//https://www.instagram.com/reel/Cxhs-BMMhcC/?utm_source=ig_web_copy_link
//https://www.instagram.com/reel/Cxll5nah41x/?utm_source=ig_web_copy_link
//https://www.instagram.com/reel/CxQJSiftjVQ/?utm_source=ig_web_copy_link