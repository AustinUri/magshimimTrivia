using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaUiTestII
{
    public static class Arranger
    {

        public static Client client = new Client();
        public static LogInScreen LoginScreen = new LogInScreen();
        public static triviaMenuScreen MenuScreen  = new triviaMenuScreen() ;
        public static CreateRoomScreen CreateRoomS = new CreateRoomScreen();
        public static MemberWaitingRoom MemberWaitingRoomS = new MemberWaitingRoom();
        public static string ClientName = "none";

        public static void init()
        {
            LoginScreen.Visible = true;
            CreateRoomS.Visible = false;
            MenuScreen.Visible = false;   
            MemberWaitingRoomS.Visible = false;     
        }


    }
}
