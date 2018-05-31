using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Line2
{
    public partial class _default : System.Web.UI.Page
    {
        const string channelAccessToken = "yFDByTuynZGQnMEe7cUXmGWwkNIJpWzFEREFUtbLEj8NU2jXjgdYPyo29fsC/40A4eOXWxf2mmAfCLN7bkCRxvnzi5YeQMysj5cit9LG0z0eIjIgIiow77XFJwHsPMbKMvw3sXKoANx5XlDoLNUDowdB04t89/1O/w1cDnyilFU=";
        const string AdminUserId = "U3c2655e0d3e1e331fe35df961eaa070b";
        


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, $"測試 {DateTime.Now.ToString()} ! ");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, 1,2);
        }
    }
}