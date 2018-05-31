using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _0531_line
{
    public partial class Line1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("yFDByTuynZGQnMEe7cUXmGWwkNIJpWzFEREFUtbLEj8NU2jXjgdYPyo29fsC/40A4eOXWxf2mmAfCLN7bkCRxvnzi5YeQMysj5cit9LG0z0eIjIgIiow77XFJwHsPMbKMvw3sXKoANx5XlDoLNUDowdB04t89/1O/w1cDnyilFU=");

            bot.PushMessage("U3c2655e0d3e1e331fe35df961eaa070b","textxxxxxxxxxxx");
            bot.PushMessage("U3c2655e0d3e1e331fe35df961eaa070b", 1,2);

            bot.PushMessage("U3c2655e0d3e1e331fe35df961eaa070b",new Uri("https://img.meyabook.com/hotchick/upload/image/20150626/143528894336704.jpg"));
            bot.PushMessage("U3c2655e0d3e1e331fe35df961eaa070b", new Uri("https://s2.yimg.com/bt/api/res/1.2/5Vumz_UOYRPBAoDjzl.JXw--/YXBwaWQ9eW5ld3M7cT04NTt3PTQwMA--/http://media.zenfs.com/zh-Hant_TW/News/yahoobeauty/20150622223206_easonhou_512635.jpg"));
        }
    }
}