using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.LinkLabel;

namespace thuc_hanh_3
{
    public partial class Form1 : Form
    {
        DataTable VIRALHITS = new DataTable();
        DataTable VNHITS = new DataTable();
        DataTable ENHITS = new DataTable();
        DataTable Liked = new DataTable();
        DataTable PlayList = new DataTable();
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();


        public Form1()
        {
            InitializeComponent();

        }
     
        private void VIRALHITSLoad()
        {
            VIRALHITS.Columns.Add("theloai", typeof(string));
            VIRALHITS.Columns.Add("hinhanh", typeof(object));
            VIRALHITS.Columns.Add("liked", typeof(int));
            VIRALHITS.Columns.Add("tenbaihat", typeof(string));
            VIRALHITS.Columns.Add("tencasi", typeof(string));
            VIRALHITS.Columns.Add("tennhacsi", typeof(string));
            VIRALHITS.Columns.Add("thoiluong", typeof(string));
            VIRALHITS.Columns.Add("binhluan", typeof(string));
            VIRALHITS.Columns.Add("baihat", typeof(string));
            VIRALHITS.Columns.Add("loibaihat", typeof(string));

            // the loai - hinh anh - ten bai hat - ten ca si - thoi luong - bai hat - lyric

            VIRALHITS.Rows.Add("VR", Properties.Resources.ngtanoise,0, "NGTANOISE", "Vsoul", "MinhMinh" , "3:50", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - NGTANOISE - VSOUL.wav", "Giọt nước mắt rớt trên khuôn nhạc\r\nRớt cứ rớt rơi từng hạt\r\nGiọt nước mắt thấm trên tay người\r\nVẫn còn nhớ ai hay cười\r\nĐã từng bước khắp nơi chân trời\r\nNói mãi không vâng lời\r\nVì đã từng hứa sẽ không đau buồn\r\nBước đi qua từng cuộc chơi\r\nVì đã có nhiều lúc chẵng biết phải nói điều gì\r\nVậy thì là giờ hiện bên mình có ai?\r\nSao không ai nói những lời chân thật \r\nvà nhẹ nhàng và chấp nhận nhiều điều đó sai\r\nAnh cảm thấy bản thân này như là\r\n Batman đi tìm màu buồn màu sầu tối đen\r\nNo no no ta không hợp chẵng có điều gì ấm êm\r\nTại sao như vậy?\r\nTại sao che đậy?\r\nNào có ai nghe đâu, nghe đâu, nghe đâu, nghe đâu\r\nĐừng nên âu sầu\r\nTa đã biết bao nhiêu lần buồn và lần sầu\r\n từ ngày nào đã khiến lòng này khó feel\r\nPoppin’ pills biết bao nhiêu lần và thật\r\n nhiều nhưng mà nhiều lần thật sự là khó quên\r\nTrong một phút giây ngày nào đã trao\r\n nhiều thật nhiều những nụ cười thật ấm êm \r\nVà lời nói nào làm lòng này nóng lên\r\nNgười ta cứ nói đừng quá yêu\r\nNgười ta cứ nói đừng quá tin\r\nNgười ta cứ nói đừng quá yêuuuu\r\nNgười ta cứ nói đừng quá tin");
            VIRALHITS.Rows.Add("VR", Properties.Resources.querry, 0, "QUERRY", "QNT","Cong Phuong", "3:31", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - QUERRY - QNT - Trung Trần - RPT MCK.wav", "QNT:\r\nHàng ngày anh vẫn chọn cách dậy sớm, cùng một ly cafe bên đường\r\nLặng nhìn từng đàn chim đang sải cánh bay đi\r\nLựa chọn outfit ra đón ngày mới, tâm hồn ta như lạc vô chốn thiên đường\r\nVà nụ cười của em đẹp như là hoa đó baby\r\nEm đang dạo bước trên con đường dài\r\nAnh không còn thấy ưu phiền trên vai\r\nEm không còn giống trông như thường ngày\r\nKhông ưa lời nói mật ngọt bên tai\r\nSo, baby I love it !\r\nBaby follow me, follow me….\r\nNgọt ngào vị cherry, đôi môi của em tỏa ra mùi hương thú vị\r\nYou sweet like berry nhưng anh vẫn luôn gọi em là baby Jully\r\nNàng đẹp tựa là Kathy anh vẫn thường hay được xem ở trên tivi\r\nNhư Playboy Carti khi bên cạnh anh thì em chẳng cần phải nghĩ suy\r\nQNT:\r\nAnh không cần biết cho dù ngày hay là canh đêm, anh vẫn sống trọn vẹn đến từng giờ\r\nAnh mong được viết cho bạn bè cho cả anh em, nhưng em khiến anh không thể ngừng mơ, về em\r\nNỗi nhớ cứ kéo đến hàng đêm\r\noutside rollin with my gang\r\nNhưng trong tim anh vẫn hướng về em, em, em\r\nI’m in love, love, love\r\nbaby skz skz skz\r\nYou leaving in my mind !\r\nNgoài trời rớt rơi mưa mưa\r\nNhẹ nhàng phất phơ lưa thưa\r\nBaby gotta feel my vibe !!\r\nNgọt ngào vị cherry, đôi môi của em tỏa ra mùi hương thú vị\r\nYou sweet like berry nhưng anh vẫn luôn gọi em là baby Jully\r\nNàng đẹp tựa là Kathy anh vẫn thường hay được xem ở trên tivi\r\nNhư Playboy Carti khi bên cạnh anh thì em chẳng cần phải nghĩ suy\r\nTrung Trần:\r\nVì sao nhờ ? Cứ tình hình này ôi thôi chết dở\r\nAnh như chú cá mắc cạn trên bờ\r\nNghĩ về em lại tức khẩu thành thơ\r\nVà điều đó giúp anh miệt mài hàng giờ\r\nVà mỗi khi em buồn\r\nAnh thức hết đêm muộn\r\nĐể kể cho em\r\nVà vẽ thêm môi em cười\r\nNhư mùa xuân đến\r\nChiều nay em ghé chơi\r\nVà đó là tất cả những điều anh muốn\r\nYeah đó là tất cả những gì anh muốn\r\nMCK:\r\nCó lẽ anh sẽ cho anh thời gian, tận hưởng niềm vui bên em hàng ngày\r\nMặt trời ngủ quên, ánh chiều muộn màng chiếu xuống dưới những tán cây\r\nNgày mai dậy sớm với những giấc mộng tuyệt vời và lồng ngực em sẽ luôn tràn đầy\r\nHận thù khổ đau với ghen tuông gì tầm này !!\r\nNgọt ngào vị cherry đôi môi của em tại sao lại cong thế nhờ\r\nyeah bọn họ tripping nghĩ đến em, nên là lòng dễ mơ\r\nChỉ cần biết là em ở đây, chẳng còn thêm nghi ngờ\r\nĐể vệt son đó nó sẽ đưa anh, tan vào trong từng ý thơ");
            VIRALHITS.Rows.Add("VR", Properties.Resources.tayto, 0, "TAYTO", "RPT MCK","Quyen Phuong", "3:24", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - Tay To - RPT MCK - RPT PhongKhin.wav", "Anh là tay to khá là hay ho nhưng anh lại hay lo\r\nNên phen này gay to\r\nEm lại trông xinh (em ấy look good)\r\nHơi bị thông minh\r\nMà nhìn em lại chất\r\nNhưng em đi một mình\r\nEm muốn quên đi một cuộc tình (quên)\r\nKhông cho tình yêu chơi đùa mình (no)\r\nNhưng mà quá khứ em chìm sâu (chìm sâu)\r\nEm quay cuồng trong ánh đèn màu (đèn màu)\r\nVà em không biết lối ra đâu\r\nChỉ mong ngày dài trôi qua mau\r\nAnh ra chuyện trò đôi ba câu\r\nVì những thứ làm ta đau (anh nói là)\r\nHey girl khi em bước ra đường bước ra đường (yeah)\r\nĐây không phải nước hoa thường mà là Louis V (LV)\r\nUh baby girl em quá ngọt em rất khác bọt\r\nAnh thấy cả Yết Kiêu đang bơi trong đôi mắt em\r\nOk anh lại trằn trọc suốt đêm qua đặt ra một câu hỏi là tại sao tên em không phải là Mẫn Nhi\r\nVà nếu em có thắc mắc về vấn đề đấy thì em có thể đọc ngược nó lại cho anh\r\nTrên thế giới này có hơn 7 tỷ nụ cười\r\nNhưng mà với anh thì nụ cười của em mới là đẹp nhất\r\nThế nên là làm ơn hãy để anh giúp em giữ cái nụ cười của em trên môi\r\nAnh sẽ tán nàng anh sẽ tán nàng yeah\r\nKhông cần cầu kỳ cho dù nhà anh bán vàng nhà anh bán vàng yeah\r\nAnh đưa em đi vi vu dạo phố quanh Hồ Tây táp vào Circle K\r\nNhớ mua thêm nước vào mình ngồi trà đá em châm cho anh phê thuốc lào\r\nTay anh không to (tay anh không to)\r\nKhông như Long Ngơ (oh no)\r\nTay bận say cỏ (anh đang say em nói đi)\r\nTên anh là Phong cơ (Phong Vân)\r\nVì anh cũng chỉ muốn cảm nhận em từng thời gian\r\nNụ cười thật tươi thật nhiều gout thời trang\r\nBaby no flexin' em biết em là ai\r\nVì một ngày nào đó chứ không phải ngày mai\r\nCộng thêm một suất đi ăn Hồ Tây xong rồi cà phê dưới phố\r\nPhiền em make up đi ngay và luôn anh đang chạy đến đấy đón em\r\nMột bông xanh ngát anh đem tặng em anh mong rằng em sẽ tưới nó oh\r\nYeah có thể là em sẽ cảm thấy cái bài hát này nó quá là sến súa quá là hmm alo alo nhưng mà\r\nNếu em dậy sớm buổi sáng em hãy cứ pha cho mình một cốc trà\r\nYeah và bật bài nhạc này lên anh nghĩ là nó sẽ làm cho em vui");
            VIRALHITS.Rows.Add("VR", Properties.Resources.thichthich, 0, "THICHTHICH", "Phương Ly","HAHA", "3:23", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - THICHTHICH - PHƯƠNG LY.wav", "Em không được xinh đẹp, không hay cười duyên\r\nChẳng biết làm sao cho trông thật ngoan hiền như bao cô ngoài kia\r\nEm đây nhìn cứ ngốc ngốc nghếch nghếch\r\nLắm lúc đứng ngắm mình trong gương, cứ thấy choáng váng\r\nNhưng mà anh ơi\r\nEm rất là vâng lời, không la cà ham chơi\r\nEm hồn nhiên, vô tư và yêu đời\r\nNên anh này, mong anh không cười chê\r\nNếu có thấy chán, em sẽ đến hát đàn anh nghe\r\nDẫu sáng, dẫu tối, em sẽ đến bên cạnh anh thôi\r\nAnh sẽ thấy ngoài kia đấy bao cô gái như em\r\nCũng cần tình yêu, cần được hiểu, cần một chút nuông chiều\r\nI don't wanna let you go, 'cause I know I love you so\r\nVì cuộc đời chẳng có gì ý nghĩa khi mà không có anh\r\nAnh sẽ biết điều cần thiết là nắm lấy tay em\r\nVì lúc này đây, em chỉ muốn gần bên anh mỗi ngày\r\nI don't wanna let you go, 'cause I know I love you so\r\nVà thật lòng em chỉ cần anh biết một điều duy nhất là\r\nEm thích anh\r\nThích, thích, thích, thích, ooh-woah-oh\r\nThích, thích, thích, thích, ooh-woah-oh\r\nThích, thích, thích, thích, ooh-woah-hoo\r\n(Và thật lòng em chỉ cần anh biết một điều duy nhất là)\r\nSau bao ngày mong chờ\r\nMong anh lại bên em ta cùng vui, xin anh đừng hững hờ\r\nXa anh một giây thôi, trong lòng em đã thấy nhớ nhớ\r\nChỉ muốn nhấc máy gọi cho anh, nhưng em chẳng dám\r\nVì biết anh có nhớ đến em?\r\n(Just close your eyes)\r\nAnh sẽ thấy ngoài kia đấy bao cô gái như em\r\nCũng cần tình yêu, cần được hiểu, cần một chút nuông chiều\r\nI don't wanna let you go, 'cause I know I love you so\r\nVì cuộc đời chẳng có gì ý nghĩa khi mà không có anh\r\nAnh sẽ biết điều cần thiết là nắm lấy tay em\r\nVì lúc này đây, em chỉ muốn gần bên anh mỗi ngày\r\nI don't wanna let you go, 'cause I know I love you so\r\nVà thật lòng em chỉ cần anh biết một điều duy nhất là\r\nEm thích anh\r\nCó biết trái tim em đang rung rinh lên chỉ vì anh?\r\nNhưng đâu dám nói, chỉ biết hát khúc ca này tặng anh\r\nLiệu anh có thích em không? (Hoh-oh, hoh-uh-oh-hoh)\r\nAnh sẽ thấy ngoài kia đấy bao cô gái như em\r\nCũng cần tình yêu, cần được hiểu, cần một chút nuông chiều\r\nI don't wanna let you go, 'cause I know I love you so\r\nVì cuộc đời chẳng có gì ý nghĩa khi mà không có anh\r\nAnh sẽ biết điều cần thiết là nắm lấy tay em\r\nVì lúc này đây, em chỉ muốn gần bên anh mỗi ngày\r\nI don't wanna let you go, 'cause I know I love you so\r\nVà thật lòng em chỉ cần anh biết một điều duy nhất là\r\nEm thích anh\r\nThích, thích, thích, thích, ooh-woah-oh\r\nThích, thích, thích, thích, ooh-woah-oh\r\nThích, thích, thích, thích, ooh-woah-hoo\r\n(Và thật lòng em chỉ cần anh biết một điều duy nhất là...)");
            VIRALHITS.Rows.Add("VR", Properties.Resources.tiny_love, 0, "tiny love", "Thịnh Suy","Thịnh Suy", "3:27", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - tiny love - Thịnh Suy.wav", "Làm lại từ những thứ đơn giản nhất chuyện trò như lúc mới yêu\r\nTình mình như thứ nước hoa phảng phất nồng nàn như bát bún riêu\r\nNày người yêu dấu nếu trong một chốc buồn sầu đeo bám chúng ta\r\nThì đừng vội trách cớ sao tàn khốc vì niềm đau ấy sẽ qua\r\nSẽ qua thôi những u buồn thế gian\r\nTình yêu sẽ cháy nhưng không tro tàn\r\nYou're my ti ti tiny love\r\nBaby you're my ti ti tiny love\r\nYou're my ti ti tiny love\r\nBaby you're my time time timeless love\r\nMột chiều ta đứng kế bên nhìn ngắm cuộc đời như những bức tranh\r\nDạo từng khu phố lúc xưa chìm đắm mà giờ sao thấy mới toanh\r\nĐồng hồ nhanh quá mới đây mà hết đời người như những giấc mơ\r\nLàm gì cho đáng để sau này vết lời mình như những ý thơ\r\nÝ thơ trong những đau buồn thế gian\r\nTình yêu sẽ cháy nhưng không tro tàn\r\nYou're my ti ti tiny love\r\nBaby you're my ti ti tiny love\r\nYou're my ti ti tiny love\r\nBaby you're my time time timeless love\r\nI wanna love you till the end of time\r\nThings gonna change but not my mind\r\nI needed love just like I need you\r\nI love you my tiny tiny baby blue");
            VIRALHITS.Rows.Add("VR", Properties.Resources.my_house, 0, "My House", "Flo Rida","Flo Rida", "3:25", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - My House - Flo Rida.wav", "Open up the champagne, pop!\r\nIt's my house, come on, turn it up\r\nHear a knock on the door and the night begins\r\n'Cause we done this before so you come on in\r\nMake yourself at my home, tell me where you been\r\nPour yourself something cold, baby, cheers to this\r\nSometimes you gotta stay in\r\nAnd you know where I live\r\nYeah, you know what we is\r\nSometimes you gotta stay in, in\r\nWelcome to my house\r\nBaby take control now\r\nWe can't even slow down\r\nWe don't like to go out\r\nWelcome to my house\r\nPlay that music too loud\r\nShow me what you do now\r\nWe don't like to go out\r\nWelcome to my house\r\nWelcome to my house\r\nMorning comes and you know that you wanna stay\r\nClose the blinds, let's pretend that the time has changed\r\nKeep our clothes on the floor, open up champagne\r\nLet's continue tonight, come on, celebrate\r\nSometimes you gotta stay in\r\nAnd you know where I live\r\nYeah, you know what we is\r\nSometimes you gotta stay in, in\r\nWelcome to my house\r\nBaby take control now\r\nWe can't even slow down\r\nWe don't like to go out\r\nWelcome to my house\r\nPlay that music too loud\r\nShow me what you do now\r\nWe don't like to go out\r\nWelcome to my house\r\nWelcome to my house\r\nWelcome to my duck off the crib, the spot, the pad\r\nBut my house is your house if you throwin' it back\r\nExcuse me if my home bringing the sad\r\nSoon as these happy faces, you can run with the cash\r\nHomerun, slam dunk, touchdown, pass\r\nMi casa es tu casa so it ain't no holding back\r\nAnother shot of vodka, you know what's in my glass\r\nIt's my house, just relax\r\nWelcome to my house\r\nBaby take control now\r\nWe can't even slow down\r\nWe don't like to go out\r\nWelcome to my house\r\nPlay that music too loud\r\nShow me what you do now\r\nWe don't like to go out\r\nWelcome to my house\r\nWelcome to my house\r\nWelcome to my house\r\nIt's my house");
            VIRALHITS.Rows.Add("VR", Properties.Resources.new_genesis, 0, "New Genesis", "Ado","Tokuda", "3:10", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - New Genesis  - Uta.wav", "新時代はこの未来だ\r\n世界中全部 変えてしまえば 変えてしまえば\r\nジャマモノ やなもの なんて消して\r\nこの世とメタモルフォーゼしようぜ\r\nミュージック キミが起こす マジック\r\n目を閉じれば未来が開いて\r\nいつまでも終わりが来ないようにって\r\nこの歌を歌うよ\r\nDo you wanna play? リアルゲーム ギリギリ\r\n綱渡りみたいな旋律 認めない戻れない忘れたい\r\n夢の中に居させて I wanna be free\r\n見えるよ新時代が 世界の向こうへ\r\nさあ行くよ new world\r\n新時代はこの未来だ\r\n世界中全部 変えてしまえば 変えてしまえば\r\n果てしない音楽がもっと届くように\r\n夢は見ないわ キミが話した「ボクを信じて」\r\nあれこれいらないものは消して\r\nリアルをカラフルに越えようぜ\r\nミュージック 今始まる ライジング\r\n目をつぶりみんなで逃げようよ\r\n今よりイイモノを見せてあげるよ\r\nこの歌を歌えば\r\nDo you wanna play? リアルゲーム ギリギリ\r\n綱渡りみたいな運命 認めない戻れない忘れたい\r\n夢の中に居させて I wanna be free\r\n見えるよ新時代が 世界の向こうへ\r\nさあ行くよ new world\r\n信じたいわ この未来を\r\n世界中全部 変えてしまえば 変えてしまえば\r\n果てしない音楽がもっと届くように\r\n夢を見せるよ 夢を見せるよ 新時代だ\r\nOoh\r\n新時代だ");
            VIRALHITS.Rows.Add("VR", Properties.Resources.Sorry, 0, "Sorry", "Justin Beiber","Hashley", "3:30", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Sorry - Justin Bieber.wav", "You gotta go and get angry at all of my honesty\r\nYou know I try but I don't do too well with apologies\r\nI hope I don't run out of time, could someone call a referee?\r\nCause I just need one more shot at forgiveness\r\nI know you know that I made those mistakes maybe once or twice\r\nBy once or twice I mean maybe a couple a hundred times\r\nSo let me, oh let me redeem, oh redeem, oh myself tonight\r\nCause I just need one more shot at second chances\r\nYeah, is it too late now to say sorry?\r\nCause I'm missing more than just your body\r\nIs it too late now to say sorry?\r\nYeah I know that I let you down\r\nIs it too late to say I'm sorry now?\r\nI'm sorry, yeah\r\nSorry, yeah\r\nSorry\r\nYeah I know that I let you down\r\nIs it too late to say I'm sorry now?\r\nI'll take every single piece of the blame if you want me to\r\nBut you know that there is no innocent one in this game for two\r\nI'll go, I'll go and then you go, you go out and spill the truth\r\nCan we both say the words and forget this?\r\nIs it too late now to say sorry?\r\nCause I'm missing more than just your body\r\nIs it too late now to say sorry?\r\nYeah I know that I let you down\r\nIs it too late to say I'm sorry now?\r\nI'm not just trying to get you back on me\r\nCause I'm missing more than just your body\r\nIs it too late now to say sorry?\r\nYeah I know that I let you down\r\nIs it too late to say I'm sorry now?\r\nI'm sorry, yeah\r\nSorry, oh\r\nSorry\r\nYeah I know that I let you down\r\nIs it too late to say I'm sorry now?\r\nI'm sorry, yeah\r\nSorry, oh\r\nSorry\r\nYeah I know that I let you down\r\nIs it too late to say I'm sorry now?");
            VIRALHITS.Rows.Add("VR", Properties.Resources.sunflower, 0, "Sunflower", "Post Malone","Perry", "3:48", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Sunflower - Post Malone, Swae Lee.wav", "Eh, eh, eh, eh (Ooh)\r\nUh, uh, uh, uh (Uh)\r\nEh, eh\r\nUh uh, some things you just can't refuse\r\nShe wanna ride me like a cruise and I'm not tryna lose\r\nThen you're left in the dust, unless I stuck by ya\r\nYou're a sunflower, I think your love would be too much\r\nOr you'll be left in the dust, unless I stuck by ya\r\nYou're the sunflower, you're the sunflower\r\nYo no sé lo que tú tienes\r\nCómo hace' lo que quiera' con mi vida, tú te vas y luego vienes\r\nYo no sé qué tiene' tú, pero a la ve' yo pienso que no me convienes\r\nA veces trato de buscar una salida, rápido tú me detienes\r\nAsí de loco tú me quieres\r\nPero soy un loco por ti\r\nTú no sabe' lo que por dentro yo siento por ti\r\nY por má' que no quiero verte, vuelvo a repetir\r\nY sentir cada parte de tu cuerpo cuando estas aquí\r\nNo te puedo mentir\r\nSiempre estoy buscándote, yeah-yey\r\nTrato de alejarme y tú acercándote, yeah-yey\r\nDe lo que nos pasa siempre culpándote, yeah-yey\r\nPero se me olvida cuando te veo desnudándote\r\nY no sé por qué\r\nAnd you'll be left in the dust, unless I stuck by ya\r\nYou're the sunflower, I think your love would be too much\r\nOr you'll be left in the dust, unless I stuck by ya\r\nYou're the sunflower, you're the sunflower\r\nEse día que te conocí\r\nNo sabía que iba a ser así\r\nEl girasol más lindo del jardín\r\nY verte en el amanecer\r\nCon un beso volví a caer\r\nDime a dónde se fue, a dónde se fue\r\nY ahora me quedo con la confusión\r\nCon sentimientos de amor y dolor\r\nTe juro que esa no fue mi intención\r\nLa flor de antes cambió de color\r\nUh-uh-uh-uuh\r\nEn mi vida solo existes tú\r\nBaby, tell what we trynna prove\r\nSi tú sabes que yo soy tu luz (Si tú sabes que yo soy tu luz)\r\nAnd you'll be left in the dust, unless I stuck by ya\r\nYou're the sunflower, es que tu amor es just too much\r\nOr you'll be left in the dust, unless I stuck by ya\r\nYou're the sunflower, you're the sunflower");
            VIRALHITS.Rows.Add("VR", Properties.Resources.there_for_you, 0, "There for you", "Martin Garrix","HIHI", "3:31", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - There For You - Martin Garrix - Troye Sivan.wav", "I woke up pissed off today\r\nAnd lately everyone feels fake\r\nSomewhere, I lost a piece of me\r\nSmoking cigarettes on balconies\r\nBut I can't do this alone\r\nSometimes I just need a light\r\nIf I call you on the phone\r\nNeed you on the other side\r\nSo when your tears roll down your pillow like a river\r\nI'll be there for you\r\nI'll be there for you\r\nWhen you're screaming, but they only hear you whisper\r\nI'll be loud for you\r\nBut you gotta be there for me too\r\nBut you gotta be there for me too\r\nLast year took a toll on me\r\nBut I made it with you next to me\r\nAround the world and back again\r\nI hope you're waiting at the end\r\nBut I can't do this alone\r\nSometimes I just need a light\r\nIf I call you on the phone\r\nNeed you on the other side\r\nSo when your tears roll down your pillow like a river\r\nI'll be there for you\r\nI'll be there for you\r\nWhen you're screaming, but they only hear you whisper\r\nI'll be loud for you\r\nI'll be loud for you\r\nI got you, I promise\r\nBut let me be honest\r\nLove is a road that goes both ways\r\nWhen your tears roll down your pillow like a river\r\nI'll be there for you\r\nBut you gotta be there for me too\r\nBut you gotta be there for me too\r\nBoy, I'm holdin' onto something\r\nWon't let go of you for nothing\r\nI'm runnin', runnin' just to keep my hands on you\r\nThere was a time that I was so blue\r\nWhat I got to do to show you?\r\nI'm runnin', runnin' just to keep my hands on you\r\nRunnin', runnin' just to keep my hands on you\r\nRunnin', runnin' just to keep my hands on you\r\nSaid, I'm runnin', runnin' just to keep my hands on you\r\nBut you gotta be there for me too\r\nBut you gotta be there for me too");
            // string a = VIRALHITS.Rows[1]["hinhanh"].ToString();
        }
        
        private void VNHITSLoad()
        {
            VNHITS.Columns.Add("theloai", typeof(string));
            VNHITS.Columns.Add("hinhanh", typeof(object));
            VNHITS.Columns.Add("liked", typeof(int));
            VNHITS.Columns.Add("tenbaihat", typeof(string));
            VNHITS.Columns.Add("tencasi", typeof(string));
            VNHITS.Columns.Add("tennhacsi", typeof(string));
            VNHITS.Columns.Add("thoiluong", typeof(string));
            VNHITS.Columns.Add("binhluan", typeof(string));
            VNHITS.Columns.Add("baihat", typeof(string));
            VNHITS.Columns.Add("loibaihat", typeof(string));

            // the loai - hinh anh - ten bai hat - ten ca si - thoi luong - bai hat - lyric

            VNHITS.Rows.Add("VN", Properties.Resources._25, 0, "25", "TÁO","Bray", "3:30", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - 25 - TÁO.wav", "Lần đầu tiên anh mong tìm ra cho riêng mình\r\nMột ai quan tâm và nghe lời anh hát\r\nNgồi kề bên đưa anh bờ vai khi anh buồn\r\nLặng im em khâu lành tim từng vỡ nát.\r\n\r\nCó những lúc cô đơn nhưng anh không nói\r\nLê đôi bàn chân bâng khuâng tìm đâu yên vui ngày xưa vẫn đong đầy\r\nNếu kí ức hôm qua tan như mây khói,\r\nxin em đừng đi ngang qua đường chung ta thường đan tay bước qua.\r\n\r\nBóng tối khiến đôi ta về ngược lối\r\nCó những thứ anh chưa từng được nói\r\nNếu biết trước anh không thể dừng lại\r\nThì anh cũng đã chẳng đi.\r\n\r\nMột ngày khác đã đến hôm nay\r\nCăn phòng anh cô đơn chẳng còn chút nắng\r\nSau ô cửa , giam mình trong những tiếng mơ hồ\r\nAnh nghe lời em thoáng qua, nghe thời gian đứng yên nghiêng mình\r\nNhìn mọi thứ trống vắng mông lung\r\nXung quanh tường cao nên anh nhìn sao chẳng thấy\r\nEm ơi mình xa bao lâu rồi đã trôi đi\r\nĐôi mi của em đã khô, con tim của anh tan vỡ\r\n\r\nAnh còn không nhớ nổi ngày cuối cùng trời nắng hay mưa\r\nBên nhau hôm đó mình có nắm tay chưa\r\nNếu chưa cho anh xin của em thêm chỉ một ngày nữa\r\nĐể anh an tâm rời bỏ em, không một chút dây dưa\r\nAnh không biết trước chuyện hôm nay em ơi,xa là không gần\r\nChắc em không đợi, còn chân anh bị bong gân\r\nĐẩy xe về, thành phố trên lưng anh nặng lắm\r\nAnh yêu em được hai năm,giờ anh bệnh thì ai thăm ?\r\nChắc đơn giản phần của anh là sai lầm\r\nDù cho sâu trong thâm tâm anh nghĩ mình lâu hơn trăm năm\r\nNhững thứ anh tặng em, xin em giữ đừng bụi bặm\r\nVì mình cũ kĩ được rồi nhiều vạn dặm xa xăm\r\nAnh đã khóc, cười, khô cả nước mắt\r\nNhưng thực tế, chia tay nhau là bước ngoặc\r\nĐể mình hoàn thành trọn vẹn lí do sống trên đời\r\nDù những thứ mình mong đợi không được bên nhau , em ơi.\r\n\r\nCó những lúc cô đơn nhưng anh không nói\r\nLê đôi bàn chân bâng khuâng tìm đâu yên vui ngày xưa vẫn đong đầy\r\nNếu kí ức hôm qua tan như mây khói,\r\nxin em đừng đi ngang qua đường chung ta thường đan tay bước qua.\r\n\r\nMột ngày khác đã đến hôm nay\r\nCăn phòng anh cô đơn chẳng còn chút nắng\r\nSau ô cửa , giam mình trong những tiếng mơ hồ\r\nAnh nghe lời em thoáng qua, nghe thời gian đứng yên nghiêng mình\r\nNhìn mọi thứ trống vắng mông lung\r\nXung quanh tường cao nên anh nhìn sao chẳng thấy\r\nEm ơi mình xa bao lâu rồi đã trôi đi\r\nĐôi mi của em đã khô, con tim của anh tan vỡ");
            VNHITS.Rows.Add("VN", Properties.Resources._3107, 0, "3107", "W/n","W/n", "3:20", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - 3107 - W_n.wav", "Đêm dần buông\r\nChỉ có đôi ta đứng đây hơi buồn\r\nNhấm nháp những suy tư\r\nCủa ngày hôm qua vừa đây, đã xa\r\nRiêng mình ta\r\nVẫn mãi lang thang dưới ánh chiều tà\r\nVẫn nỗi nhớ miên man\r\nKý ức bên em bây giờ đang ở một nơi xa\r\nChỉ cần bên nhau như những ngày ấy\r\nAnh sẽ cùng em đi hết tháng ngày\r\nĐể trong cơn mơ anh chẳng tìm thấy\r\nĐể anh bơ vơ mãi phút nơi đây\r\nTình yêu khi xưa đôi ta vụn vỡ\r\nTrong một chiều mưa hai đứa chia tay\r\nChỉ cần cho anh được thêm một chút\r\nCho anh được gần bên em\r\n\r\nXin lỗi vì những cuộc điện thoại\r\nĐã làm phiền em với nửa kia\r\nDưới góc phố lặng thinh\r\nTiếng bước chân chậm chạp\r\nLúc giữa khuya\r\nTất nhiên thì anh cũng như họ\r\nChọn buông bỏ để em thấy yên bình\r\nCòn riêng phần anh\r\nThì lại thầm trách mọi thứ\r\nTrái ngược với duyên tình, em!\r\n\r\nLúc mình buồn nhìn trời và thở hắc\r\nMưa tháng bảy là cơn buồn dào dạt\r\nLẫn về tình yêu mà anh đã lỡ mất\r\nHẳn ai cũng từng nếm phải\r\nCảm giác trống trải\r\nTrong lòng mình em ha\r\nNhư em cũng từng đau khổ vì họ rồi\r\nLại thức trắng bao đêm qua\r\nNếu ta có dịp ngồi lại\r\nThì anh xin phép kể cho em nghe\r\nBình yên của anh thì cũng giống như họ\r\nLà có em ngồi phía sau xe\r\nLà buộc phải cố lượm lặt được hết\r\nNhững thứ trước kia đã xa mình\r\nLà em hồi đó hay là anh bây giờ\r\nCô đơn đứng giữa ngã ba tình\r\nHoàng hôn tháng bảy chưa bao giờ\r\nGiết chết trái tim buồn bã đã cũ mềm\r\nBầu trời đêm nay lại có mưa rơi\r\nQua một ô cửa đã phủ rèm, em\r\nAnh còn chẳng dám khẳng định\r\nMình đã nhớ về em bao nhiêu đêm\r\nNhưng sau tất cả thì chỉ có\r\nAnh và anh tự buộc mình yêu em\r\n\r\nChỉ cần bên nhau như những ngày ấy\r\nAnh sẽ cùng em đi hết tháng ngày\r\nDù chờ ngàn năm anh vẫn ở đấy\r\nDù anh đã cố gắng nghĩ đến em\r\nRồi trong nhân gian bao nhiêu người đến\r\nThanh xuân này anh chỉ muốn bên em\r\nDìu nhau đi qua những con phố dài\r\nChỉ yêu đôi ta chẳng biết đúng sai\r\nVì sao?\r\n\r\nĐêm chờ đông\r\nGió vẫn lao xao khiến ta thêm sầu\r\nGiấu ký ức nơi đây vào gọn trong tim\r\nDù mai đổi thay\r\nRiêng mình ta\r\nVẫn mãi cô đơn dưới ánh trăng vàng\r\nVẫn nỗi nhớ khi xưa\r\nNhững lúc bên em\r\nBây giờ đang ở một nơi xa");
            VNHITS.Rows.Add("VN", Properties.Resources.ai_biet, 0, "AI BIET", "WEAN","Naomi", "3:43"," ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - AI BIET - WEAN.wav", "Và biết bao nhiêu cho vừa\r\nVà biết bao lâu cho vừa\r\nNào biết đang dư hay thừa\r\nNào biết đâu nào biết đâu\r\nNào biết đâu\r\nSài Gòn ngoài cửa\r\nBầu trời tối sầm\r\nLoay hoay đi kiếm bật lửa\r\nKéo rèm nhìn trời\r\nĐốt một điếu thuốc\r\nHôm nay thành phố lại mưa\r\nMưa rơi kế bên lửa\r\nEm yêu đã dậy hay chưa\r\nĐôi lúc bình yên là vậy\r\nNhững thứ đơn giản\r\nLàm ta say sưa\r\nVà biết bao nhiêu cho vừa\r\nVà biết bao lâu cho vừa\r\nDù biết hút thuốc là xấu\r\nNhưng biết bao lâu cho chừa\r\nEm như là nơi ta có thể\r\nNói hết những thứ còn chưa\r\nRồi sẽ ra sao\r\nNếu những suy nghĩ\r\nMột ngày chẳng còn được đưa em\r\nVà biết bao nhiêu cho vừa\r\nVà biết bao lâu cho vừa\r\nChắc ta sẽ bị hoá đá\r\nNhư trong cổ tích\r\nNgày xửa ngày xưa\r\nThường mơ thấy em\r\nTrong giấc ngủ trưa yeah yeah\r\nThường mơ thấy em\r\nTrong giấc ngủ trưa uh\r\nThôi mở một bài nhạc nghe\r\nNghe bài một bài nhạc nhẹ\r\nGiọng nữ ca sĩ thật khẽ\r\nHoà tan vào ta vào khói\r\nVào trong cơn mưa đầu hè\r\nHạnh phúc đâu cần màu mè\r\nNhìn tóc em tôi đầy me\r\nEm yêu vừa đi đâu về\r\nĐó là lời nhạc của chú Trần Tiến\r\nỞ trong bài Thành Phố Trẻ\r\nCòn tôi thì vẫn một mình\r\nBước tiếp ở giữa con đường\r\nĐầy người và xe\r\nCòn tôi thì vẫn một mình\r\nBước tiếp ở giữa\r\nCon đường đầy người và xe\r\nVà biết bao nhiêu cho vừa\r\nVà biết bao lâu cho vừa\r\nNào biết đang dư hay thừa\r\nNào biết đâu nào biết đâu\r\nNào biết đâu\r\nVà biết bao nhiêu cho vừa\r\nVà biết bao lâu cho vừa\r\nNào biết đang dư hay thừa\r\nNào biết đang dư hay thừa\r\nNào biết đang dư hay thừa\r\nNào biết đang dư hay thừa\r\nChưa biết bao nhiêu cho vừa\r\nHôm nay thành phố vẫn mưa\r\nTa vẫn đi kiếm bật lửa\r\nSong song con đường đi kiếm\r\nMột nửa còn lại và\r\nCó đôi lúc khờ dại\r\nCó đôi lúc dừng bút ngừng hát\r\nChẳng muốn mọi thứ tồn tại\r\nNhững sức ép dồn lại\r\nỞ hai bên tai\r\nĐang vang lên tên ai\r\nAlways in my mind\r\nĐôi lúc thấy trở ngại nhưng rồi\r\nNiềm tin là thứ ở lại cuối cùng\r\nEm như bài hát chill lúc cuối tuần\r\nLà cảm hứng khi trời tối dần\r\nVà dù lúc đó\r\nMặt mũi thối đần\r\nVẫn muốn được hát\r\nEm nghe mấy lần yeah\r\nBài hát này nghe\r\nThật là rối uh uh\r\nĐơn giản chỉ như\r\nSuy nghĩ của tôi thôi\r\nCon beat kia đang trôi trôi\r\nNhững cảm xúc đi lôi thôi\r\nNhớ môi em trên môi tôi\r\nMuốn em trên môi tôi\r\nGiống như Thanh Thảo Quang Dũng\r\nThì em cũng có\r\nVị ngọt trên đôi môi\r\nThat’s right\r\nThat’s right\r\nGiống như Thanh Thảo Quang Dũng\r\nThì em cũng có\r\nVị ngọt trên đôi môi\r\nVà đâu là đúng đâu là sai\r\nCon người luôn mâu thuẫn\r\nCó khi chẳng biết\r\nBên mình là ai\r\nĐiều gì là mãi mãi\r\nĐôi khi điều tích cực\r\nLại nằm ở sâu trong tiếng thở dài\r\nViết văn phải có mở bài\r\nCòn thứ mà bạn vừa nghe\r\nLà mớ hỗn độn\r\nĐược viết trong chiều thứ hai\r\nMột chiều mưa thứ hai\r\nYeah");
            VNHITS.Rows.Add("VN", Properties.Resources.chim_sau, 0, "CHIM SAU", "Sony tran","HoangTon", "3:15", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - CHIM SAU - Sony Tran - Hoang Ton - Blacka.wav", "Chìm sâu trong màn đêm\r\nNói chuyện mấy câu\r\nKhông để quá lâu\r\nÔm chặt lấy nhau\r\nI gotta make a move\r\nAnh liền tiến sâu\r\nTâm trạng đến mau\r\nKhông để e thấy đau đâu\r\nVerse 1 (Sony Tran)\r\nOh baby em so đẹp,\r\ntrong bộ váy nhưng càng đẹp hơn khi không mặc gì\r\nCăn phòng này bỗng dưng lại bùng cháy,\r\nnói anh nghe lý do chạy khỏi đây là gì\r\nPre Chorus\r\nEm không cần làm màu đâu, I like it raw\r\nJust take it off cause I take it all\r\nI’ll have a puff if you don’t mind\r\nI’ll put on a show and you got main role\r\nChorus\r\nChìm sâu trong màn đêm\r\nNói chuyện mấy câu\r\nKhông để quá lâu\r\nÔm chặt lấy nhau\r\nI gotta make a move\r\nAnh liền tiến sâu\r\nTâm trạng đến mau\r\nKhông để e thấy đau đâu\r\nVerse 2 (Hoang Ton)\r\nAnh cũng muốn nói tất cả những điều là thần kỳ\r\nNhưng baby em đẹp nhất là khi không mặc gì\r\nEm làm cho anh đã biến thành một gã tình si\r\nEm luôn biết cách tỏa sáng ở những chỗ mình đi\r\nYeah uh yeah\r\nEm cũng chẳng phải nói là tối nay em thích gì\r\nYeah uh yeah\r\nĐã có anh x3 đã…\r\nI know i know I know\r\nAnh biết một chỗ mà mình có thể đi thể đi cả nhau\r\nAnh chỉ muốn ở một mình cùng em cùng em cùng em\r\nThật lâu…\r\nPre chorus\r\nEm không cần làm màu đâu, I like it raw\r\nJust take it off cause I take it all\r\nI’ll have a puff if you don’t mind\r\nI’ll put on a show and you got main role\r\n\r\nChorus\r\nChìm sâu trong màn đêm\r\nNói chuyện mấy câu\r\nKhông để quá lâu\r\nÔm chặt lấy nhau\r\nI gotta make a move\r\nAnh liền tiến sâu\r\nTâm trạng đến mau\r\nKhông để e thấy đau đâu\r\nverse 3 (Blacka)\r\nNhớ không lầm anh viết câu đầu là kế bên nhà\r\nLúc đó em cười vì thế nên là\r\nAnh thấy yên bình\r\nem nấu thêm trà đêm ấy riêng mình, bên dưới hiên nhà , ba má trên lầu , anh nói em là\r\nEm không thể nào biết được thời gian có thể bào mòn cả một phiến đá\r\nVì nếu không thể tiến xa , thì đến lúc mình phải cần tiến hóa\r\nChỉ cần nhớ lúc đó mình đã – ” rất đã”\r\nTa đã có những điều tuyệt nhất có nhớ có quên nên có ra đi anh xin em là đừng đòi anh trả – tất cả\r\nChừa một chút cho người đến sau\r\nVì nếu anh thật sự tồi sau này\r\nHai đứa có thể mến nhau\r\nThương em nhiều nên anh nhắc kĩ\r\nKhi nhạc bật và đèn tắt đi\r\nThì em đẹp nhất khi không mặc gì\r\nChorus 2x\r\nChìm sâu trong màn đêm\r\nNói chuyện mấy câu\r\nKhông để quá lâu\r\nÔm chặt lấy nhau\r\nI gotta make a move\r\nAnh liền tiến sâu\r\nTâm trạng đến mau\r\nKhông để e thấy đau đâu");
            VNHITS.Rows.Add("VN", Properties.Resources.cua, 0, "CUA", "HIEUTHUHAI","GERNANG", "3:47", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - CUA - HIETHUHAI.wav", "Nhìn tụi anh thật cool\r\nLạnh như băng mà không cần cố\r\nTên tuổi lên càng cao\r\nNhư Bray Ở Trong Thành Phố\r\nBài ra bài ra bài\r\nLiên tục lặp lại\r\nNhư một tần số\r\nCòn bạn trai cũ của em\r\nMother****er một thằng ngố\r\nTay phải gạt cần số\r\nCòn tay trái thì cầm vô lăng\r\nNhìn tụi anh như băng khủng bố\r\nCầm tay lái là phải đeo găng\r\nChạy đến khi mà\r\nKhông còn gì mới dừng cơ\r\nLên đây đâu dễ\r\nBắt kịp anh thì không thể\r\nNhư Nguyễn Trọng Tài em Ngừng Mơ\r\nSắc đẹp là điều thứ nhất\r\nĐể làm một nửa của HIEUTHUHAI\r\nSo if you wanna ****\r\nMy DMs let it slide\r\nAnh cua em thì dễ\r\nKhông bao giờ có chuyện ngược lại\r\nNên say bye bye bye\r\nNhiều mảnh vỡ và có Malphite\r\nBắn là bang bang\r\nMake you dance dance\r\nWe the man man\r\nHurrykng KNG\r\nNhững ngày lang thang\r\nSẽ còn sang trang\r\nÂm nhạc vang vang\r\nTích tịch tang tang\r\nNerd GANG GANG\r\nĐi hàng ngang ngang\r\nPop the Champagne\r\nYou gotta stick to the plan\r\nBiến những cú sút trở thành bàn\r\nCó thể gọi tao Johnny Dang\r\nTất cả mọi thứ làm bằng vàng\r\nBaby I’m cool cool\r\nGiơ tay lên nếu cần một ít\r\nTụi anh cua cua\r\nChỉ dừng chân khi qua đường pit\r\nWe say cua cua\r\nHẹn gặp lại ngay ở vạch đích\r\nNên là thích thì cua\r\nMà không thích thì cua\r\nCool cool\r\nGiơ tay lên nếu cần một ít\r\nTụi anh cua cua\r\nChỉ dừng chân khi qua đường pit\r\nWe say cua cua\r\nHẹn gặp lại ngay ở vạch đích\r\nNên là thích thì cua\r\nMà không thích thì cua cua\r\nNerd không coi ***\r\nChỉ coi tiền làm tình\r\nAnh thì đẹp trai\r\nHieuthuhai thì xăm mình\r\nDây chuyền ở trên cổ\r\nKhông phải chân em đâu\r\nDưới Hiên Nhà hút xì gà\r\nNgầu như là Đen Vâu\r\nĐi xe hiệu\r\nEm chân dài rất thích là bo cua\r\nTay cầm Chivas\r\nCòn tay cầm chai Soju\r\nDù Âu hay Hàn thì\r\nAnh được gọi là thần tượng\r\nBận đồ hiệu\r\nEm đi bên anh không cần ngượng\r\nNhạc là kinh doanh\r\nAnh là doanh nhân\r\nThẻ thì trong ngăn\r\nTiền thì trong bank\r\nSố tài khoản trải dài\r\nHơn 15 chữ số\r\nAnh không ngọt ngào\r\nSao cứ gọi anh là bố\r\nThích giàu tích tiền\r\nManbo tính hiền\r\nDing dong dong\r\nChing chang chong\r\nTao Gold Asian Young\r\nBaby I’m cool cool\r\nGiơ tay lên nếu cần một ít\r\nTụi anh cua cua\r\nChỉ dừng chân khi qua đường pit\r\nWe say cua cua\r\nHẹn gặp lại ngay ở vạch đích\r\nNên là thích thì cua\r\nMà không thích thì cua\r\nCool cool\r\nGiơ tay lên nếu cần một ít\r\nTụi anh cua cua\r\nChỉ dừng chân khi qua đường pit\r\nWe say cua cua\r\nHẹn gặp lại ngay ở vạch đích\r\nNên là thích thì cua\r\nMà không thích thì cua cua\r\nNên là thích thì cua\r\nMà không thích thì cua cua cua\r\nNên là thích thì cua\r\nMà không thích thì cua cua\r\nCua cua cua cua cua\r\nThích thì cua\r\nMà không thích thì cua\r\nCua cua cua cua\r\nHẹn gặp lại ngay ở vạch đích\r\nNên là thích thì cua\r\nMà không thích thì cua cua");
            VNHITS.Rows.Add("VN", Properties.Resources.giayphut, 0, "GIAYPHUT", "KIDSAI","CAO VAN TUNG", "3:40", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - GIAYPHUT - KIDSAI.wav", "Chỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nCó lẽ không\r\nAnh chắc chắn trông\r\nChờ đợi baby girl\r\nAnh muốn kế bên em oh baby\r\nAnh muốn có\r\nCó được shawty\r\nEm là\r\nMọi thứ em à\r\nMàu hồng tím\r\nAnh không muốn đau tim đâu em\r\nMàu hồng tím\r\nAnh không muốn tim phải đau em\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nCho bao nhiêu yêu thương xa vời\r\nTrong tim ta đã không có nhau\r\nĐi bên em nói không nên lời\r\nCho anh xin giây phút nhiệm màu\r\nBaby nói cho anh bao điều\r\nKhiến cho con tim anh thêm đau\r\nNếu như giây này không thành\r\nAnh chỉ mong là mình quên nhau\r\nCodeine yeah\r\nTan vào tim\r\nBaby no\r\nAnh lại say\r\nCho thời gian\r\nQuay về đây\r\nCho tình yêu\r\nNhư lúc đầu\r\nCho con tim anh tan vào nicotine\r\nCho đôi ta tan\r\nTrong màn đêm lặng im\r\nCho hai đôi môi\r\nTrai thật lâu nụ hôn\r\nCho anh bên em\r\nThêm một giây được không\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nCho con tim anh tan vào nicotine\r\nCho đôi ta tan\r\nTrong màn đêm lặng im\r\nCho hai đôi môi\r\nTrai thật lâu nụ hôn\r\nCho anh bên em\r\nThêm một giây được không");
            VNHITS.Rows.Add("VN", Properties.Resources.gu, 0, "GU", "Freaky", "Seachains", "3:23", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - Gu - Freaky - Seachains.wav", "Baby girl, I like you move\r\nCan we talk about your shoes?\r\nYeah! Anh xin thề anh không nói về gu\r\nAi mà nói em không đẹp thì có mắt như mù\r\nBaby girl, I like you move\r\nCan we talk about your shoes?\r\nCuộc đời này mình sống phong lưu\r\nSo I keep mah groove with you my boo\r\nBaby girl, I like you move\r\nCan we talk about your shoes?\r\nYeah! Anh xin thề anh không nói về gu\r\nAi mà nói em không đẹp thì có mắt như mù\r\nBaby girl, I like you move\r\nCan we talk about your shoes?\r\nCuộc đời này mình sống phong lưu\r\nSo I keep mah groove with you my boo\r\nNếu như em là trà sữa, thì anh là đường tinh\r\nNếu như em là trang web, thì anh là đường link\r\nKhiến anh đau đầu, em là phương trình\r\nNếu như em là Âu Cơ, kế bên anh là Trường Chinh\r\nAnh không hề thông minh, nên được gọi là chàng ngơ\r\nGood gril trong bộ váy ngắn, nên anh tạm gọi là nàng thơ\r\nSài Gòn thì rất nóng, còn tim em như đóng băng\r\nNgười yêu cũ em sống lỗi, nên anh bắt buộc phải sống nhăn\r\nEm là buổi sáng, anh là điểm tâm\r\nYêu em không thể thiếu ngày nào, như bị đuổi học vì điểm danh\r\nNgười thì nói anh đa tình, người thì nói anh ga lăng\r\nHọ thấy anh là qua hình, viết một bài là ra trend\r\nBaby girl, I like you move\r\nCan we talk about your shoes?\r\nYeah! Anh xin thề anh không nói về gu\r\nAi mà nói em không đẹp thì có mắt như mù\r\nBaby girl, I like you move\r\nCan we talk about your shoes?\r\nCuộc đời này mình sống phong lưu\r\nSo I keep mah groove with you my boo\r\nAnh là Hip Hop, em là Lofi\r\nQuay clip TikTok, nói mình là mối tình lâu phai\r\nFuckboiz đặt em lên giường, anh đặt nhẫn em lên tay\r\nBad boy bỏ em bên đường, giống như khứa Seachains, eh\r\nGái nhà ai thấy thiệt cool\r\nXuống mần quen thấy hợp gu (oh my god)\r\nMá nó kêu lấy vàng cây, đến nhà em, muốn mần sui\r\nRước làm dâu, xuống miền Tây\r\nBạn trai cũ em đáng ghét, còn em đây thì đáng thương\r\nLý do đây anh thức khuya, vì nick em còn sáng trưng\r\nBa mẹ nói là chúng mình, như là thanh mai trúc mã\r\nChờ tới đủ tuổi được gả, như phải chờ từng tháng lương\r\nBaby girl, I like you move\r\nCan we talk about your shoes?\r\nYeah! Anh xin thề anh không nói về gu\r\nAi mà nói em không đẹp thì có mắt như mù\r\nBaby girl, I like you move\r\nCan we talk about your shoes?\r\nCuộc đời này mình sống phong lưu\r\nSo I keep mah groove with you my boo");
            VNHITS.Rows.Add("VN", Properties.Resources.holdmyhand, 0, "HOLD MY HAND", "POLL", "TDY", "3:39", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - HOLD MY HAND - Poll - TDY.wav", "Đôi chân anh cô đơn lang thang 1 mình giữa phố Đông\r\nTìm 1 người hẹn hò mà làm anh ngóng trông...\r\nBaby...anh tương tư em suốt cả đêm dài\r\nTự hỏi mình 1 câu là \"Tại sao luôn anh yêu em hoài?\"\r\nChạm vào ánh mắt và cả bờ môi\r\nYêu em say đắm...chỉ có vậy thôi\r\nYêu em mặc kệ ai đúng sai\r\nI just need a smile\r\nFalling in your eyes\r\n\r\n(Hold my hand...go to the fancy town\r\nHold my hand...touch me and kiss your mouth\r\nHold my hand...Anh vẫn sẽ luôn yêu em\r\nI hope u know u are my memories) x2\r\n\r\nAnh biết rằng từ lâu và em đây chính là loài hoa\r\nLoài hoa cho ngà sức sống và để ghi giấu vào lời ca\r\nI'm feeling them chỉ vỏn vẹn vài ba câu hát\r\nNụ cười thơ ngây vô tình thoáng qua mà lại say đắm cả đời ta\r\n\r\nÁnh mắt dịu dàng, bồi hồi ta nắm tay nhau\r\nVài lời mật ngọt mà làm anh đắm say sao ? (noo...)\r\nYêu em, dù phong ba hay bao nhiêu trắc trở\r\nKhông như sách vở, yêu em luôn cả ngay trong cách thở\r\n\r\nĐôi chân anh cô đơn lang thang 1 mình giữa phố Đông\r\nTìm 1 người hẹn hò mà làm anh ngóng trông...\r\nBaby...anh tương tư em suốt cả đêm dài\r\nTự hỏi mình 1 câu là \"Tại sao luôn anh yêu em hoài?\"\r\nChạm vào ánh mắt và cả bờ môi\r\nYêu em say đắm...chỉ có vậy thôi\r\nYêu em mặc kệ ai đúng sai\r\nI just need a smile\r\nFalling in your eyes\r\n\r\nHold my hand...go to the fancy town\r\nHold my hand...touch me and kiss your mouth\r\nHold my hand...Anh vẫn sẽ luôn yêu em\r\nI hope u know u are my memories\r\n\r\nSau giờ tan ca, làm việc mệt mỏi\r\nEm cần tâm sự và tìm người lắng nghe\r\nVậy thì để anh ở đây luôn bên em mỗi tối\r\nVà dắt tay em về trên con đường vắng xe\r\n\r\nQuan tâm chi em ơi hàng tá công việc\r\nNếu mà cứ lao lực khi nào mình xong xuôi\r\nHãy cứ để bản thân nhận lấy điều tốt đẹp nhất\r\nVì tuổi trẻ đẹp nhất khi ta được rong chơi\r\n\r\nNên là anh sẽ uống cùng em khi phố phường yên giấc\r\nTâm tư anh gánh vác sẽ nhẹ nhàng hơn\r\nAnh chỉ muốn được ôm em thường xuyên nhất\r\nVà nhìn thấy môi em cười dưới ánh hoàng hôn\r\n\r\nI just wanne be with u when the Sunset\r\nCuz baby girl u always in my mind\r\nDont overthink let make life so fresh\r\nVà cùng nhau cố gắng...It will be alright!\r\n\r\nNeed u (lalalaa..)\r\nJust need u (lalalaa..)\r\nTại vì sao anh như người trên mây?\r\nGặp em nơi đâu vẫn xoay vòng\r\nSaxophone trên tay, đôi mình cùng đắm say\r\nFeel my song đêm nay, chỉ cần 1 cái nắm tay\r\n(Em không thoát khỏi anh được đâu)\r\n1 2 3...Now we lets gooo\r\n\r\nĐôi chân anh cô đơn lang thang 1 mình giữa phố Đông\r\nTìm 1 người hẹn hò mà làm anh ngóng trông...\r\nBaby...anh tương tư em suốt cả đêm dài\r\nTự hỏi mình 1 câu là \"Tại sao luôn anh yêu em hoài?\"\r\n\r\nChạm vào ánh mắt và cả bờ môi\r\nYêu em say đắm...chỉ có vậy thôi\r\nYêu em mặc kệ ai đúng sai\r\nI just need a smile\r\nFalling in your eyes\r\n\r\n(Hold my hand...go to the fancy town\r\nHold my hand...touch me and kiss your mouth\r\nHold my hand...Anh vẫn sẽ luôn yêu em\r\nI hope u know u are my memories) x2");
            VNHITS.Rows.Add("VN", Properties.Resources.iceman, 0, "ICEMAN", "SOL7","BinZ", "3:41", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - iceman - SOL7.wav", "Rolling some tree và mọi thứ dần chậm đi\r\nNgồi đây nhâm nhi nghe giai điệu đó đang thầm thì\r\nPut some ice vào trong ly chấm bi (ice ice)\r\nKhi ở trên mái là một cơn mưa đang ầm ĩ (drop drop)\r\nTrở lại Bồng Sơn hay là Sài Gòn, anh vẫn không lonely\r\nBịt khẩu trang như là Sinobi để tránh thấy covi (coco)\r\nKeep it lowkey, anh đang giải trí cùng với mấy homies\r\nĐặt bàn tay vào trang giấy lấy ra vài cái ô ly\r\nOutside với ai trong team cùng với những đôi mắt lim dim\r\nLuôn luôn có aice ở trong tim\r\nLạnh lùng như vai ở trong phim\r\nSay say trong đêm nay\r\nSome ice ở trên tay\r\nNhún nhảy ở trên stage\r\nBăng giá trong con tim này\r\nGucci jackey đem xuống\r\nRồi khoác nó lên đi\r\nMùi nước hoa mà anh muốn\r\nĐó là mùi của money (dollar)\r\nMoney talk làm ai phải gật đầu\r\nMan not hot 'cause heart cold\r\nNếu em nhất trí bên anh thật lâu\r\nThì chấp nhận anh có tật xấu\r\nGucci jacket đem xuống\r\nRồi khoác nó lên đi\r\nMùi nước hoa mà anh muốn\r\nĐó là mùi của money (dollar)\r\nCái điều em đang cuốn\r\nRồi đốt nó lên đi\r\nMùi nước hoa mà anh muốn\r\nĐó là mùi của money\r\nYea money man\r\nDollar ở đâu thì anh ở đấy (ya ooh)\r\nAnh đưa em về nơi\r\nEm chưa bao giờ thấy (ohhh)\r\nRolling với cả gang đưa anh tờ giấy (Ohhh)\r\nImma smoke some iceee\r\nPut some ice on your neck\r\nBaby imma watch it frozeee\r\nHit me up with icy lemonade\r\nMck cùng dân chơi overdoseeee\r\nTại sao anh lại có thể bằng giá với mức đấy?\r\nI cannot move\r\nStaying in my ground, chưa đến lúc gãy\r\nCan not lose\r\nBởi vì ai cũng có việc mình thôi\r\nBaby don't hate on the law\r\nAnh chỉ muốn được ngồi chill\r\nBut oh my god, fuck the news\r\nGạt điếu em đang cuốn, rồi đốt nó lên đi!\r\nMùi nước hoa mà anh muốn\r\nĐó là mùi của money (dollar)\r\nMoney talk làm ai phải gật đầu\r\nMan not hot 'cause heart cold\r\nMck-overdose icy heart! (yeah yeah)\r\nGạt điếu em đang cuốn, rồi đốt nó lên đi\r\nMùi nước hoa mà anh muốn\r\nĐó là mùi của money (dollar)\r\nGạt điếu em đang cuốn, rồi đốt nó lên đi!\r\nMùi nước hoa mà anh muốn\r\nĐó là mùi của money (dollar)\r\nWhole gang iceout in the club\r\nĐó là mùi của money");
            VNHITS.Rows.Add("VN", Properties.Resources.lochi, 0, "LOCHI", "FSRIO","LowG", "3:20", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - LO CHI - FSRIO.wav", "Ɲhớ đến em bao đêm dài.\r\nThức trắng đêm ra thêm bài.\r\nƁắt lấу âm thanh nên sài.\r\n\r\nGirl this song is for уa.\r\nƁao nhiêu ngàу qua, con tim rộn ràng bồi hồi đâu уên.\r\nVì anh muốn viết ra khúc ca cho em, thức đêm với anh nào đâu phiền.\r\n\r\nMột người con gái trông thật xinh đang ngồi bàn kế.\r\nƖ like уour smile, môi cười xinh như là nắng đang về.\r\nƁae em đừng mang Fendi, Gucci haу là LV.\r\nƐm vẫn sáng như ngôi một sao, уou are the beautу.\r\n\r\nỪ xin số phone, mình về nhắn tin.\r\nLượn lờ phố đông và đưa nàng đi xem phim.\r\nMình đi đến Hồ Tâу rồi.\r\nMình qua Ϲircle K ngồi.\r\n\r\nRồi ra Ϲoffee thôi đừng lo chi có anh đâу rồi.\r\nLấу đi, em đã lấу trong mơ là từng câu hát mang mùi hương ngát, hai ta đứng kế ông tơ.\r\n(Và)\r\nϹhớ lo! Anh sẽ hát thêm cho em.\r\nϹhỉ cần em muốn dù là giông tố anh sẽ vẫn luôn ở bên.\r\n\r\nĐừng lo nhé vì anh đã nhớ tên em.\r\nƝgân nga dành cho nàng câu hát dù anh đã có thêm fan.\r\nϹho em niềm vui mới nàу.\r\nMong em đừng lo lắng nhé.\r\nƊon’t run awaу! Vì anh sẽ tới bên em.\r\n\r\n*****\r\nAууa lonelу gurl, tối naу trông em có vẻ không vui.\r\nGiữa làn khói mập mờ, có người nói cần chờ, trái tim em vụn rồi nên em cười không nổi.\r\nJust L O V Ɛ, để tình cảm khiến em tự do.\r\nLet уour soul be free, hãу để anh đưa em hoà vào trong làn gió.\r\n\r\nRide around the citу, từ trung tâm tới đích đến chưa biết.\r\nĐể em ngồi phía sau khiến cho уên xe luôn trong tình trạng thừa nhiệt.\r\n2 taу ôm thật chặt nhá, vì mình đang di chuуển trong cái xã hội đảo điên.\r\nƝhà thì chẳng có gì mấу, ơn giời được cái xe với hai mũ bảo hiểm.\r\n\r\nƁabe em chẳng cần phải làm gì, mà các boу vẫn tự mê.\r\nϹhúng mình lang thang hết cả thủ đô chỉ để tìm ra thêm một vẻ đẹp như thế.\r\nTrăng thì đang dần lên cao, lên cao, lên cao lên khỏi tầng cao ốc.\r\n9pm, em và GTM, đang trên xe đi xem, trên đồi có những vì sao khóc.");

        }

        private void ENHITSLoad()
        {
            ENHITS.Columns.Add("theloai", typeof(string));
            ENHITS.Columns.Add("hinhanh", typeof(object));
            ENHITS.Columns.Add("liked", typeof(int));
            ENHITS.Columns.Add("tenbaihat", typeof(string));
            ENHITS.Columns.Add("tencasi", typeof(string));
            ENHITS.Columns.Add("tennhacsi", typeof(string));
            ENHITS.Columns.Add("thoiluong", typeof(string));
            ENHITS.Columns.Add("binhluan", typeof(string));
            ENHITS.Columns.Add("baihat", typeof(string));
            ENHITS.Columns.Add("loibaihat", typeof(string));

            // the loai - hinh anh - liked - ten bai hat - ten ca si - thoi luong - comment - bai hat - lyric

            ENHITS.Rows.Add("EN", Properties.Resources.All_We_Know, 0, "All We Know", "ChainSmokers","DESAR", "3:30", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - All We Know - The Chainsmokers.wav", "Fighting flames of fire\r\nHang onto burning wires\r\nWe don't care anymore\r\nAre we fading lovers?\r\nWe keep wasting colors\r\nMaybe we should let this go\r\nWe're fallin' apart, still we hold together\r\nWe've passed the end, so we chase forever\r\n'Cause this is all we know\r\nThis feeling's all we know\r\nI'll ride my bike up to the road\r\nDown the streets, right through the city\r\nI'll go everywhere you go\r\nFrom Chicago to the coast\r\nYou tell me, \"Hit this and let's go\r\nBlow the smoke right through the window\"\r\n'Cause this is all we know\r\n'Cause this is all we know\r\n'Cause this is all we know\r\nNever face each other\r\nOne bed, different covers\r\nWe don't care anymore\r\nTwo hearts still beating\r\nOn with different rhythms\r\nMaybe we should let this go\r\nWe're fallin' apart, still we hold together\r\nWe've passed the end, so we chase forever\r\n'Cause this is all we know\r\nThis feeling's all we know\r\nI'll ride my bike up to the road\r\nDown the streets, right through the city\r\nI'll go everywhere you go\r\nFrom Chicago to the coast\r\nYou tell me, \"Hit this and let's go\r\nBlow the smoke right through the window\"\r\n'Cause this is all we know\r\n'Cause this is all we know\r\n'Cause this is all we know");
            ENHITS.Rows.Add("EN", Properties.Resources.Bad_Habits, 0, "Bad Habits", "Ed Sheeran","Taylor", "3:20", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Bad Habits - Ed Sheeran.wav", "One, two, three, four\r\nOoh-ooh, ooh-ooh-ooh\r\nEvery time you come around, you know I can't say no\r\nEvery time the sun goes down, I let you take control\r\nI can feel the paradise before my world implodes\r\nAnd tonight had something wonderful\r\nMy bad habits lead to late nights endin' alone\r\nConversations with a stranger I barely know\r\nSwearin' this will be the last, but it probably won't\r\nI got nothin' left to lose, or use, or do\r\nMy bad habits lead to wide eyes stare into space\r\nAnd I know I'll lose control of the things that I say\r\nYeah, I was lookin' for a way out, now I can't escape\r\nNothin' happens after two, it's true\r\nIt's true, my bad habits lead to you\r\nOoh-ooh, ooh-ooh-ooh\r\nMy bad habits lead to you\r\nOoh-ooh, ooh-ooh-ooh\r\nMy bad habits lead to you\r\nEvery pure intention ends when the good times start\r\nFallin' over everything to reach the first time's spark\r\nIt started under neon lights, and then it all got dark\r\nI only know how to go too far\r\nMy bad habits lead to late nights endin' alone\r\nConversations with a stranger I barely know\r\nSwearin' this will be the last, but it probably won't\r\nI got nothin' left to lose, or use, or do\r\nMy bad habits lead to wide eyes stare into space\r\nAnd I know I'll lose control of the things that I say\r\nYeah, I was lookin' for a way out, now I can't escape\r\nNothin' happens after two, it's true\r\nIt's true, my bad habits lead to you\r\nOoh-ooh, ooh-ooh-ooh\r\nMy bad habits lead to you\r\nOoh-ooh, ooh-ooh-ooh\r\nWe took the long way 'round\r\nAnd burned 'til the fun ran out, now\r\nMy bad habits lead to late nights endin' alone\r\nConversations with a stranger I barely know\r\nSwearin' this will be the last, but it probably won't\r\nI got nothin' left to lose, or use, or do\r\nMy bad habits lead to wide eyes stare into space\r\nAnd I know I'll lose control of the things that I say\r\nYeah, I was lookin' for a way out, now I can't escape\r\nNothin' happens after two, it's true\r\nIt's true, my bad habits lead to you\r\nOoh-ooh, ooh-ooh-ooh\r\nMy bad habits lead to you\r\nOoh-ooh, ooh-ooh-ooh\r\nMy bad habits lead to you");
            ENHITS.Rows.Add("EN", Properties.Resources.Better_Now, 0, "Better Now", "Post Malone","QNT", "3:40", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Better Now - Post Malone.wav", "You prolly think that you are better now, better now\r\nYou only say that 'cause I'm not around, not around\r\nYou know I never meant to let you down, let you down\r\nWoulda gave you anything\r\nWoulda gave you everything\r\nYou know I say that I am better now, better now\r\nI only say that 'cause you're not around, not around\r\nYou know I never meant to let you down, let you down\r\nWoulda gave you anything\r\nWoulda gave you everything, oh-oh\r\nI did not believe that it would end, no (end, no)\r\nEverything came second to the Benzo (Benzo)\r\nYou're not even speakin' to my friends, no\r\nYou knew all my uncles and my aunts though\r\n20 candles, blow 'em out and open your eyes\r\nWe were lookin' forward to the rest of our lives\r\nUsed to keep my picture posted by your bedside\r\nNow it's in your dresser with the socks you don't like\r\nAnd I'm rollin', rollin', rollin', rollin'\r\nWith my brothers like it's Jonas, Jonas\r\nDrinkin' Henny and I'm tryna forget\r\nBut I can't get this shit outta my head\r\nYou prolly think that you are better now, better now\r\nYou only say that 'cause I'm not around, not around\r\nYou know I never meant to let you down, let you down\r\nWoulda gave you anything\r\nWoulda gave you everything\r\nYou know I say that I am better now, better now\r\nI only say that 'cause you're not around, not around\r\nYou know I never meant to let you down, let you down\r\nWoulda gave you anything\r\nWoulda gave you everything, oh-oh\r\nI seen you with your other dude\r\nHe seemed like he was pretty cool\r\nI was so broken over you\r\nLife, it goes on, what can you do?\r\nI just wonder what it's gonna take (what it's gonna take?)\r\nAnother foreign or a bigger chain (bigger chain)\r\nBecause no matter how my life has changed\r\nI keep on looking back on better days\r\nYou prolly think that you are better now, better now\r\nYou only say that 'cause I'm not around, not around\r\nYou know I never meant to let you down, let you down\r\nWoulda gave you anything\r\nWoulda gave you everything\r\nYou know I say that I am better now, better now\r\nI only say that 'cause you're not around, not around\r\nYou know I never meant to let you down, let you down\r\nWoulda gave you anything\r\nWoulda gave you everything, oh-oh\r\nI promise, I swear to you, I'll be okay\r\nYou're only the love of my life (the love of my life)\r\nYou prolly think that you are better now, better now\r\nYou only say that 'cause I'm not around, not around\r\nYou know I never meant to let you down, let you down\r\nWoulda gave you anything\r\nWoulda gave you everything\r\nYou know I say that I am better now, better now\r\nI only say that 'cause you're not around, not around\r\nYou know I never meant to let you down, let you down\r\nWoulda gave you anything\r\nWoulda gave you everything, oh-oh");
            ENHITS.Rows.Add("EN", Properties.Resources.CBTO, 0, "Cake By The Ocean", "DNCE","WEHIT", "3:30", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Cake By The Ocean - DNCE.wav", "Nah, nah, yeah\r\n(Cake by the ocean)\r\nOh, no\r\nSee you walkin' 'round like it's a funeral\r\nNot so serious, girl, why those feet cold?\r\nWe just gettin' started, don't you tiptoe, tiptoe (ah)\r\nWaste time with a masterpiece, don't waste time with a masterpiece (huh)\r\nYou should be rollin' with me, you should be rollin' with me (ah-ah-ah)\r\nYou're a real-life fantasy, you're a real-life fantasy (huh)\r\nBut you're movin' so carefully, let's start livin' dangerously\r\nTalk to me, baby\r\nI'm goin' blind from this sweet-sweet cravin', whoa-oh\r\nLet's lose our minds and go fuckin' crazy\r\nI-I-I-I-I-I keep on hopin' we'll eat cake by the ocean (uh)\r\nWalk for me, baby\r\nI'll be Diddy, you'll be Naomi, whoa-oh\r\nLet's lose our minds and go fuckin' crazy\r\nI-I-I-I-I-I keep on hopin' we'll eat cake by the ocean (uh)\r\nGoddamn\r\nSee you lickin' frostin' from your own hands\r\nWant another taste, I'm beggin', \"Yes, ma'am\"\r\nI'm tired of all this candy on the dry land, dry land, ooh\r\nWaste time with a masterpiece, don't waste time with a masterpiece (huh)\r\nYou should be rollin' with me, you should be rollin' with me (ah-ah-ah)\r\nYou're a real-life fantasy, you're a real-life fantasy (huh)\r\nBut you're movin' so carefully, let's start livin' dangerously (whoa-oh)\r\nTalk to me, baby\r\nI'm goin' blind from this sweet-sweet cravin', whoa-oh\r\nLet's lose our minds and go fuckin' crazy (ah)\r\nI-I-I-I-I-I keep on hopin' we'll eat cake by the ocean (uh)\r\nWalk for me, baby (walk for me now)\r\nI'll be Diddy, you'll be Naomi, whoa-oh\r\nLet's lose our minds and go fuckin' crazy\r\nI-I-I-I-I-I keep on hopin' we'll eat cake by the ocean\r\nOoh, ah-ah\r\nI-I-I-I-I-I keep on hopin' we'll eat cake by the ocean (uh)\r\nOoh, ah-ah\r\nI-I-I-I-I-I keep on hopin' we'll eat cake by the ocean (uh)\r\nHey, you're fuckin' delicious\r\nTalk to me, girl\r\nTalk to me, baby (talk to me, baby)\r\nI'm goin' blind from this sweet-sweet cravin', whoa-oh\r\nLet's lose our minds and go fuckin' crazy\r\nI-I-I-I-I-I keep on hopin' we'll eat cake by the ocean (hey) (uh)\r\nWalk for me, baby (walk for me now)\r\nI'll be Diddy, you'll be Naomi, whoa-oh\r\nLet's lose our minds and go (and go what?), fuckin' crazy (that's right)\r\nI-I-I-I-I-I keep on hopin' (I'm ready), we'll eat cake by the ocean (ah, yeah)\r\nRed velvet, vanilla, chocolate in my life\r\nFunfetti, I'm ready, I need it every night\r\nRed velvet, vanilla, chocolate in my life\r\nI-I-I-I-I-I keep on hopin' we'll eat cake by the ocean (uh)");
            ENHITS.Rows.Add("EN", Properties.Resources.comedy, 0, "Comedy", "Gen Hoshino","Y2MATE", "3:32", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Comedy - Gen Hoshino.wav", "争い合って 壊れかかった\r\nこのお茶目な星で\r\n生まれ落ちた日から よそ者\r\n涙枯れ果てた\r\n帰りゆく場所は夢の中\r\n零れ落ちた 先で出会った\r\nただ秘密を抱え\r\n普通のふりをした あなたと\r\n探し諦めた\r\n私の居場所は作るものだった\r\nあの日交わした\r\n血に勝るもの\r\n心たちの契約を\r\n手を繋ぎ帰ろうか\r\n今日は何食べようか\r\n「こんなことがあった」って\r\n君と話したかったんだ\r\nいつの日も\r\n君となら喜劇よ\r\n踊る軋むベッドで\r\n笑い転げたままで\r\nふざけた生活はつづくさ\r\n劣ってると 言われ育った\r\nこのいかれた星で\r\n普通のふりをして 気づいた\r\n誰が決めつけた\r\n私の光はただ此処にあった\r\nあの日ほどけた\r\n淡い呪いに\r\n心からのさよならを\r\n顔上げて帰ろうか\r\n咲き誇る花々\r\n「こんな綺麗なんだ」って\r\n君と話したかったんだ\r\nどんな日も\r\n君といる奇跡を\r\n命繫ぐキッチンで\r\n伝えきれないままで\r\nふざけた生活はつづく\r\n仕事明けに\r\n歩む共に\r\n朝陽が登るわ ああ\r\nありがとうでは\r\n足りないから\r\n手を繋ぎ\r\nさあうちに帰ろうか\r\n今日は何食べようか\r\n「こんなことがあった」って\r\n君と話したかったんだ\r\nいつの日も\r\n君となら喜劇よ\r\n踊る軋むベッドで\r\n笑い転げたままで\r\n永遠を探そうか\r\nできるだけ暮らそうか\r\nどんなことがあったって\r\n君と話したかったんだ\r\nいつまでも\r\n君となら喜劇よ\r\n分かち合えた日々に\r\n笑い転げた先に\r\nふざけた生活はつづくさ\r\n");
            ENHITS.Rows.Add("EN", Properties.Resources.Hello, 0, "Hello", "Adele","Hoover", "3:48", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Hello - Adele.wav", "Hello, it's me\r\nI was wondering if after all these years you'd like to meet\r\nTo go over everything\r\nThey say that time's supposed to heal ya, but I ain't done much healing\r\nHello, can you hear me?\r\nI'm in California dreaming about who we used to be\r\nWhen we were younger and free\r\nI've forgotten how it felt before the world fell at our feet\r\nThere's such a difference between us\r\nAnd a million miles\r\nHello from the other side\r\nI must've called a thousand times\r\nTo tell you I'm sorry for everything that I've done\r\nBut when I call, you never seem to be home\r\nHello from the outside\r\nAt least I can say that I've tried\r\nTo tell you I'm sorry for breaking your heart\r\nBut it don't matter, it clearly doesn't tear you apart anymore\r\nHello, how are you?\r\nIt's so typical of me to talk about myself, I'm sorry\r\nI hope that you're well\r\nDid you ever make it out of that town where nothing ever happened?\r\nIt's no secret that the both of us\r\nAre running out of time\r\nSo hello from the other side (other side)\r\nI must've called a thousand times (thousand times)\r\nTo tell you I'm sorry for everything that I've done\r\nBut when I call, you never seem to be home\r\nHello from the outside (outside)\r\nAt least I can say that I've tried (I've tried)\r\nTo tell you I'm sorry for breaking your heart\r\nBut it don't matter, it clearly doesn't tear you apart anymore\r\nOoh (lows, lows, lows, lows), anymore\r\n(Highs, highs, highs, highs)\r\nOoh (lows, lows, lows, lows), anymore\r\n(Highs, highs, highs, highs)\r\nOoh (lows, lows, lows, lows), anymore\r\n(Highs, highs, highs, highs)\r\nAnymore (lows, lows, lows, lows)\r\nHello from the other side (other side)\r\nI must've called a thousand times (thousand times)\r\nTo tell you I'm sorry for everything that I've done\r\nBut when I call, you never seem to be home\r\nHello from the outside (outside)\r\nAt least I can say that I've tried (I've tried)\r\nTo tell you I'm sorry for breaking your heart\r\nBut it don't matter, it clearly doesn't tear you apart anymore");
            ENHITS.Rows.Add("EN", Properties.Resources.Hero, 0, "Hero", "Cash Cash","Yummi", "3:20", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Hero - Cash Cash - Christina Perri.wav", "I let my soul fall into you\r\nI never thought I'd fall right through\r\nI fell for every word you said\r\nYou made me feel I needed you\r\nAnd forced my heart to think it's true\r\nBut I found I'm powerless with you\r\nNow I don't need your wings to fly\r\nNo, I don't need a hand to hold in mine this time\r\nYou held me down, but I broke free\r\nI found the love inside of me\r\nNow I don't need a hero to survive\r\n'Cause I already saved my life\r\n'Cause I already saved my life\r\nI fell into your fantasy\r\nBut that's all our love will ever be\r\nI lost hope in saving you and me\r\nYou think I'm lost, falling apart\r\nBut your lies just made a stronger heart\r\nMy life is just about to start\r\nNow I don't need your wings to fly\r\nNo, I don't need a hand to hold in mine this time\r\nYou held me down, but I broke free\r\nI found the love inside of me\r\nNow I don't need a hero to survive\r\n'Cause I already saved my life\r\nAlready saved my life\r\nI already saved my life\r\nAlready saved my life\r\nI already saved my life\r\nNow I don't need your wings to fly\r\nNo, I don't need a hand to hold in mine this time\r\nYou held me down, but I broke free\r\nI found the love inside of me\r\nNow I don't need a hero to survive\r\n'Cause I already saved my life\r\nAlready saved my life\r\nI already saved my life\r\nAlready saved my life\r\nI already saved my life\r\nNow I don't need your wings to fly");
            ENHITS.Rows.Add("EN", Properties.Resources.immortals, 0, "Immortals", "Fall Out Boy","Panter", "3:50", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Immortals - Fall Out Boy.wav", "They say we are what we are, but we don't have to be\r\nI'm bad behavior but I do it in the best way\r\nI'll be the watcher (watcher) of the eternal flame\r\nI'll be the guard dog of all your fever dreams\r\n\r\nOh, I am the sand in the bottom half of the hourglass, glass, glass\r\nOh, I try to picture me without you, but I can't\r\n\r\n'Cause we could be immortals, immortals\r\nJust not for long, for long\r\nAnd live with me forever now, pull the blackout curtains down\r\nJust not for long, for long\r\n\r\nWe could be immor—immortals, immor—immortals\r\nImmor—immortals, immor—immortals, immortals\r\n\r\nSometimes the only payoff for having any faith\r\nIs when it's tested again and again every day\r\nI'm still comparing your past to my future\r\nIt might be your wound, but they're my sutures\r\n\r\nOh, I am the sand in the bottom half of the hourglass, glass, glass\r\nOh, I try to picture me without you, but I can't\r\n\r\n'Cause we could be immortals, immortals\r\nJust not for long, for long\r\nAnd live with me forever now, pull the blackout curtains down\r\nJust not for long, for long\r\n\r\nWe could be immor—immortals, immor—immortals, immortals\r\n\r\nAnd live with me forever now\r\nPull the blackout curtains down\r\n\r\nWe could be immortals, immortals\r\nJust not for long, for long\r\n\r\nWe could be immor—immortals, immor—immortals\r\nImmor—immortals, immor—immortals, immortals\r\n");
            ENHITS.Rows.Add("EN", Properties.Resources.Liar, 0, "Liar", "Camila Cabello","555", "3:53", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Liar - Camila Cabello.wav", "I don't care, if you're here\r\nOr if you're not alone\r\nI don't care, it's been too long\r\nIt's kinda like we didn't happen\r\nThe way that your lips move\r\nThe way you whisper slow\r\nI don't care, it's good, it's gone (uh)\r\nI said, I won't lose control, I don't want it (ooh)\r\nI said, I won't get too close but I can't stop it\r\nOh, no, there you go, making me a liar\r\nGot me begging you for more\r\nOh, no, there I go, startin' up a fire, oh, no, no\r\nOh, no, there you go, you're making me a liar, I kinda like it though\r\nOh, no, there I go, startin' up a fire, oh, no, no (ooh)\r\nYou're watching, I feel it (hey)\r\nI know I shouldn't stare (yeah, yeah)\r\nI picture your hands on me\r\nI think I wanna let it happen\r\nBut what if, you kiss me? (Yeah)\r\nAnd what if, I like it?\r\nAnd no one sees it\r\nI said, I won't lose control, I don't want it (ooh)\r\nI said, I won't get too close but I can't stop it (no)\r\nOh, no, there you go, making me a liar\r\nGot me begging you for more\r\nOh, no, there I go, startin' up a fire, oh, no, no\r\nOh, no, there you go, you're making me a liar, I kinda like it though\r\nOh, no, there I go, startin' up a fire, oh, no, no\r\nOh, no, no, no\r\nHere comes trouble, no, no\r\nStartin' up a fire\r\nI don't believe myself when I say\r\nThat I don't need you, oh\r\nI don't believe myself when I say\r\nSo, don't believe me\r\nOh, no, there you go, you're making me a liar\r\nGot me begging you for more\r\nOh, no, there I go, startin' up a fire, oh, no, no\r\nOh, no, there you go, making me a liar, I kinda like it though\r\nOh, no, there I go, startin' up a fire, oh, no, no\r\nYeah\r\nUh, yeah, yeah\r\nNah, yeah\r\nOh, no, no, no\r\nOh, no, no, no\r\nOh, no, you're making me a liar\r\n'Cause my clothes are on the floor\r\nHuh, huh, huh\r\nUh\r\nOh, no, no, no\r\nAnother fire");
            ENHITS.Rows.Add("EN", Properties.Resources.make_you_mine, 0, "Make you mine", "PUBLIC","qoqo", "3:37", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Make You Mine - PUBLIC.wav", "Well, I will call you darlin' and everything will be okay\r\n'Cause I know that I am yours and you are mine\r\nDoesn't matter anyway\r\nIn the night, we'll take a walk, it's nothing funny\r\nJust to talk\r\nPut your hand in mine\r\nYou know that I want to be with you all the time\r\nYou know that I won't stop until I make you mine\r\nYou know that I won't stop until I make you mine\r\nUntil I make you mine\r\nWell, I have called you darlin' and I'll say it again, again\r\nSo kiss me 'til I'm sorry, babe, that you are gone and I'm a mess\r\nAnd I'll hurt you and you'll hurt me and we'll say things we can't repeat\r\nPut your hand in mine\r\nYou know that I want to be with you all the time\r\nYou know that I won't stop until I make you mine\r\nYou know that I won't stop until I make you mine\r\nUntil I make you mine\r\nYou need to know\r\nWe'll take it slow\r\nI miss you so\r\nWe'll take it slow\r\nIt's hard to feel you slipping (You need to know)\r\nThrough my fingers are so numb (We'll take it slow)\r\nAnd how was I supposed to know (I miss you so)\r\nThat you were not the one?\r\nPut your hand in mine\r\nYou know that I want to be with you all the time\r\nYou know that I won't stop until I make you mine\r\nYou know that I won't stop until I make you mine\r\nUntil I make you mine\r\nPut your hand in mine\r\nYou know that I want to be with you all the time\r\nOh darlin', darlin', baby, you're so very fine\r\nYou know that I won't stop until I make you mine\r\nUntil I make you\r\nLa-la-la-la\r\nLa-la-la-la-la-la\r\nLa-la-la-la-la\r\nLa-la-la-la-la-la\r\nLa-la-la-la-la\r\nLa-la-la-la-la-la\r\nLa-la-la-la-la");

        }
        private void LikedLoad()
        {
            Liked.Columns.Add("theloai", typeof(string));
            Liked.Columns.Add("hinhanh", typeof(object));
            Liked.Columns.Add("Liked", typeof(int));
            Liked.Columns.Add("tenbaihat", typeof(string));
            Liked.Columns.Add("tencasi", typeof(string));
            Liked.Columns.Add("tennhacsi", typeof(string));
            Liked.Columns.Add("thoiluong", typeof(string));
            Liked.Columns.Add("binhluan", typeof(string));
            Liked.Columns.Add("baihat", typeof(string));
            Liked.Columns.Add("loibaihat", typeof(string));
        }
        private void PlayListLoad()
        {
            PlayList.Columns.Add("theloai", typeof(string));
            PlayList.Columns.Add("hinhanh", typeof(object));
            PlayList.Columns.Add("Liked", typeof(int));
            PlayList.Columns.Add("tenbaihat", typeof(string));
            PlayList.Columns.Add("tencasi", typeof(string));
            PlayList.Columns.Add("tennhacsi", typeof(string));
            PlayList.Columns.Add("thoiluong", typeof(string));
            PlayList.Columns.Add("binhluan", typeof(string));
            PlayList.Columns.Add("baihat", typeof(string));
            PlayList.Columns.Add("loibaihat", typeof(string));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            VIRALHITSLoad();
            VNHITSLoad();
            ENHITSLoad();
            LikedLoad();
            PlayListLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox_viralhits_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox_viralhits.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox_viralhits_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_viralhits.BorderStyle = BorderStyle.None;
        }

        private void pictureBox_vn_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox_vn.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox_vn_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_vn.BorderStyle = BorderStyle.None;
        }

        private void pictureBox_eu_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox_eu.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox_eu_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_eu.BorderStyle = BorderStyle.None;
        }

        private void pictureBox_playlists_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox_playlists.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox_playlists_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_playlists.BorderStyle = BorderStyle.None;
        }

        private void pictureBox_liked_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox_liked.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox_liked_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_liked.BorderStyle = BorderStyle.None;
        }


        int viralcheck = 0;
        int vncheck = 0;
        int encheck = 0;
        private void pictureBox_viralhits_Click(object sender, EventArgs e)
        {
            viralcheck = 1;
            vncheck = 0;
            encheck = 0;

            panel_category.Visible = true;
            pictureBox_category.BackgroundImage = Properties.Resources.viralhit_img;

            panel_color.BackColor = Color.PaleVioletRed;
            label4.BackColor = Color.PaleVioletRed;
            label_category.BackColor = Color.PaleVioletRed;
            label_undercate.BackColor = Color.PaleVioletRed;
            label3.BackColor = Color.PaleVioletRed;
            pictureBox11.BackColor = Color.PaleVioletRed;

            label_category.Text = "Viral hits";
            label_undercate.Text = "Popular songs we've collected for you";


            pictureBox1.BackgroundImage = (Image)VIRALHITS.Rows[0]["hinhanh"];
            label_category_1.Text = VIRALHITS.Rows[0]["tenbaihat"].ToString();
            label_category_2.Text = VIRALHITS.Rows[0]["tencasi"].ToString();
            label_category_3.Text = VIRALHITS.Rows[0]["tennhacsi"].ToString();
            label_category_4.Text = VIRALHITS.Rows[0]["thoiluong"].ToString();

            pictureBox2.BackgroundImage = (Image)VIRALHITS.Rows[1]["hinhanh"];
            label_category_5.Text = VIRALHITS.Rows[1]["tenbaihat"].ToString();
            label_category_6.Text = VIRALHITS.Rows[1]["tencasi"].ToString();
            label_category_7.Text = VIRALHITS.Rows[1]["tennhacsi"].ToString();
            label_category_8.Text = VIRALHITS.Rows[1]["thoiluong"].ToString();

            pictureBox3.BackgroundImage = (Image)VIRALHITS.Rows[2]["hinhanh"];
            label_category_9.Text = VIRALHITS.Rows[2]["tenbaihat"].ToString();
            label_category_10.Text = VIRALHITS.Rows[2]["tencasi"].ToString();
            label_category_11.Text = VIRALHITS.Rows[2]["tennhacsi"].ToString();
            label_category_12.Text = VIRALHITS.Rows[2]["thoiluong"].ToString();

            pictureBox4.BackgroundImage = (Image)VIRALHITS.Rows[3]["hinhanh"];
            label_category_13.Text = VIRALHITS.Rows[3]["tenbaihat"].ToString();
            label_category_14.Text = VIRALHITS.Rows[3]["tencasi"].ToString();
            label_category_15.Text = VIRALHITS.Rows[3]["tennhacsi"].ToString();
            label_category_16.Text = VIRALHITS.Rows[3]["thoiluong"].ToString();

            pictureBox5.BackgroundImage = (Image)VIRALHITS.Rows[4]["hinhanh"];
            label_category_17.Text = VIRALHITS.Rows[4]["tenbaihat"].ToString();
            label_category_18.Text = VIRALHITS.Rows[4]["tencasi"].ToString();
            label_category_19.Text = VIRALHITS.Rows[4]["tennhacsi"].ToString();
            label_category_20.Text = VIRALHITS.Rows[4]["thoiluong"].ToString();

            pictureBox6.BackgroundImage = (Image)VIRALHITS.Rows[5]["hinhanh"];
            label_category_21.Text = VIRALHITS.Rows[5]["tenbaihat"].ToString();
            label_category_22.Text = VIRALHITS.Rows[5]["tencasi"].ToString();
            label_category_23.Text = VIRALHITS.Rows[5]["tennhacsi"].ToString();
            label_category_24.Text = VIRALHITS.Rows[5]["thoiluong"].ToString();

            pictureBox7.BackgroundImage = (Image)VIRALHITS.Rows[6]["hinhanh"];
            label_category_25.Text = VIRALHITS.Rows[6]["tenbaihat"].ToString();
            label_category_26.Text = VIRALHITS.Rows[6]["tencasi"].ToString();
            label_category_27.Text = VIRALHITS.Rows[6]["tennhacsi"].ToString();
            label_category_28.Text = VIRALHITS.Rows[6]["thoiluong"].ToString();

            pictureBox8.BackgroundImage = (Image)VIRALHITS.Rows[7]["hinhanh"];
            label_category_29.Text = VIRALHITS.Rows[7]["tenbaihat"].ToString();
            label_category_30.Text = VIRALHITS.Rows[7]["tencasi"].ToString();
            label_category_31.Text = VIRALHITS.Rows[7]["tennhacsi"].ToString();
            label_category_32.Text = VIRALHITS.Rows[7]["thoiluong"].ToString();

            pictureBox9.BackgroundImage = (Image)VIRALHITS.Rows[8]["hinhanh"];
            label_category_33.Text = VIRALHITS.Rows[8]["tenbaihat"].ToString();
            label_category_34.Text = VIRALHITS.Rows[8]["tencasi"].ToString();
            label_category_35.Text = VIRALHITS.Rows[8]["tennhacsi"].ToString();
            label_category_36.Text = VIRALHITS.Rows[8]["thoiluong"].ToString();

            pictureBox10.BackgroundImage = (Image)VIRALHITS.Rows[9]["hinhanh"];
            label_category_37.Text = VIRALHITS.Rows[9]["tenbaihat"].ToString();
            label_category_38.Text = VIRALHITS.Rows[9]["tencasi"].ToString();
            label_category_39.Text = VIRALHITS.Rows[9]["tennhacsi"].ToString();
            label_category_40.Text = VIRALHITS.Rows[9]["thoiluong"].ToString();
        }

        private void pictureBox_vn_Click(object sender, EventArgs e)
        {
            viralcheck = 0;
            vncheck = 1;
            encheck = 0;

            panel_category.Visible = true;
            pictureBox_category.BackgroundImage = Properties.Resources.hothitvn_img;

            panel_color.BackColor = Color.LightSeaGreen;
            label4.BackColor = Color.LightSeaGreen;
            label_category.BackColor = Color.LightSeaGreen;
            label_undercate.BackColor = Color.LightSeaGreen;
            label3.BackColor = Color.LightSeaGreen;
            pictureBox11.BackColor = Color.LightSeaGreen;

            label_category.Text = "Viet Nam hot hits";
            label_undercate.Text = "Popular Vietnamese songs we've collected for you";


            pictureBox1.BackgroundImage = (Image)VNHITS.Rows[0]["hinhanh"];
            label_category_1.Text = VNHITS.Rows[0]["tenbaihat"].ToString();
            label_category_2.Text = VNHITS.Rows[0]["tencasi"].ToString();
            label_category_3.Text = VNHITS.Rows[0]["tennhacsi"].ToString();
            label_category_4.Text = VNHITS.Rows[0]["thoiluong"].ToString();

            pictureBox2.BackgroundImage = (Image)VNHITS.Rows[1]["hinhanh"];
            label_category_5.Text = VNHITS.Rows[1]["tenbaihat"].ToString();
            label_category_6.Text = VNHITS.Rows[1]["tencasi"].ToString();
            label_category_7.Text = VNHITS.Rows[1]["tennhacsi"].ToString();
            label_category_8.Text = VNHITS.Rows[1]["thoiluong"].ToString();

            pictureBox3.BackgroundImage = (Image)VNHITS.Rows[2]["hinhanh"];
            label_category_9.Text = VNHITS.Rows[2]["tenbaihat"].ToString();
            label_category_10.Text = VNHITS.Rows[2]["tencasi"].ToString();
            label_category_11.Text = VNHITS.Rows[2]["tennhacsi"].ToString();
            label_category_12.Text = VNHITS.Rows[2]["thoiluong"].ToString();

            pictureBox4.BackgroundImage = (Image)VNHITS.Rows[3]["hinhanh"];
            label_category_13.Text = VNHITS.Rows[3]["tenbaihat"].ToString();
            label_category_14.Text = VNHITS.Rows[3]["tencasi"].ToString();
            label_category_15.Text = VNHITS.Rows[3]["tennhacsi"].ToString();
            label_category_16.Text = VNHITS.Rows[3]["thoiluong"].ToString();

            pictureBox5.BackgroundImage = (Image)VNHITS.Rows[4]["hinhanh"];
            label_category_17.Text = VNHITS.Rows[4]["tenbaihat"].ToString();
            label_category_18.Text = VNHITS.Rows[4]["tencasi"].ToString();
            label_category_19.Text = VNHITS.Rows[4]["tennhacsi"].ToString();
            label_category_20.Text = VNHITS.Rows[4]["thoiluong"].ToString();

            pictureBox6.BackgroundImage = (Image)VNHITS.Rows[5]["hinhanh"];
            label_category_21.Text = VNHITS.Rows[5]["tenbaihat"].ToString();
            label_category_22.Text = VNHITS.Rows[5]["tencasi"].ToString();
            label_category_23.Text = VNHITS.Rows[5]["tennhacsi"].ToString();
            label_category_24.Text = VNHITS.Rows[5]["thoiluong"].ToString();

            pictureBox7.BackgroundImage = (Image)VNHITS.Rows[6]["hinhanh"];
            label_category_25.Text = VNHITS.Rows[6]["tenbaihat"].ToString();
            label_category_26.Text = VNHITS.Rows[6]["tencasi"].ToString();
            label_category_27.Text = VNHITS.Rows[6]["tennhacsi"].ToString();
            label_category_28.Text = VNHITS.Rows[6]["thoiluong"].ToString();

            pictureBox8.BackgroundImage = (Image)VNHITS.Rows[7]["hinhanh"];
            label_category_29.Text = VNHITS.Rows[7]["tenbaihat"].ToString();
            label_category_30.Text = VNHITS.Rows[7]["tencasi"].ToString();
            label_category_31.Text = VNHITS.Rows[7]["tennhacsi"].ToString();
            label_category_32.Text = VNHITS.Rows[7]["thoiluong"].ToString();

            pictureBox9.BackgroundImage = (Image)VNHITS.Rows[8]["hinhanh"];
            label_category_33.Text = VNHITS.Rows[8]["tenbaihat"].ToString();
            label_category_34.Text = VNHITS.Rows[8]["tencasi"].ToString();
            label_category_35.Text = VNHITS.Rows[8]["tennhacsi"].ToString();
            label_category_36.Text = VNHITS.Rows[8]["thoiluong"].ToString();

            pictureBox10.BackgroundImage = (Image)VNHITS.Rows[9]["hinhanh"];
            label_category_37.Text = VNHITS.Rows[9]["tenbaihat"].ToString();
            label_category_38.Text = VNHITS.Rows[9]["tencasi"].ToString();
            label_category_39.Text = VNHITS.Rows[9]["tennhacsi"].ToString();
            label_category_40.Text = VNHITS.Rows[9]["thoiluong"].ToString();
        }

        private void pictureBox_eu_Click(object sender, EventArgs e)
        {
            viralcheck = 0;
            vncheck = 0;
            encheck = 1;

            panel_category.Visible = true;
            pictureBox_category.BackgroundImage = Properties.Resources.tophitseu_img;

            panel_color.BackColor = Color.DarkSalmon;
            label4.BackColor = Color.DarkSalmon;
            label_category.BackColor = Color.DarkSalmon;
            label_undercate.BackColor = Color.DarkSalmon;
            label3.BackColor = Color.DarkSalmon;
            pictureBox11.BackColor = Color.DarkSalmon;

            label_category.Text = "Europe hot hits";
            label_undercate.Text = "Popular European songs we've collected for you";


            pictureBox1.BackgroundImage = (Image)ENHITS.Rows[0]["hinhanh"];
            label_category_1.Text = ENHITS.Rows[0]["tenbaihat"].ToString();
            label_category_2.Text = ENHITS.Rows[0]["tencasi"].ToString();
            label_category_3.Text = ENHITS.Rows[0]["tennhacsi"].ToString();
            label_category_4.Text = ENHITS.Rows[0]["thoiluong"].ToString();

            pictureBox2.BackgroundImage = (Image)ENHITS.Rows[1]["hinhanh"];
            label_category_5.Text = ENHITS.Rows[1]["tenbaihat"].ToString();
            label_category_6.Text = ENHITS.Rows[1]["tencasi"].ToString();
            label_category_7.Text = ENHITS.Rows[1]["tennhacsi"].ToString();
            label_category_8.Text = ENHITS.Rows[1]["thoiluong"].ToString();

            pictureBox3.BackgroundImage = (Image)ENHITS.Rows[2]["hinhanh"];
            label_category_9.Text = ENHITS.Rows[2]["tenbaihat"].ToString();
            label_category_10.Text = ENHITS.Rows[2]["tencasi"].ToString();
            label_category_11.Text = ENHITS.Rows[2]["tennhacsi"].ToString();
            label_category_12.Text = ENHITS.Rows[2]["thoiluong"].ToString();

            pictureBox4.BackgroundImage = (Image)ENHITS.Rows[3]["hinhanh"];
            label_category_13.Text = ENHITS.Rows[3]["tenbaihat"].ToString();
            label_category_14.Text = ENHITS.Rows[3]["tencasi"].ToString();
            label_category_15.Text = ENHITS.Rows[3]["tennhacsi"].ToString();
            label_category_16.Text = ENHITS.Rows[3]["thoiluong"].ToString();

            pictureBox5.BackgroundImage = (Image)ENHITS.Rows[4]["hinhanh"];
            label_category_17.Text = ENHITS.Rows[4]["tenbaihat"].ToString();
            label_category_18.Text = ENHITS.Rows[4]["tencasi"].ToString();
            label_category_19.Text = ENHITS.Rows[4]["tennhacsi"].ToString();
            label_category_20.Text = ENHITS.Rows[4]["thoiluong"].ToString();

            pictureBox6.BackgroundImage = (Image)ENHITS.Rows[5]["hinhanh"];
            label_category_21.Text = ENHITS.Rows[5]["tenbaihat"].ToString();
            label_category_22.Text = ENHITS.Rows[5]["tencasi"].ToString();
            label_category_23.Text = ENHITS.Rows[5]["tennhacsi"].ToString();
            label_category_24.Text = ENHITS.Rows[5]["thoiluong"].ToString();

            pictureBox7.BackgroundImage = (Image)ENHITS.Rows[6]["hinhanh"];
            label_category_25.Text = ENHITS.Rows[6]["tenbaihat"].ToString();
            label_category_26.Text = ENHITS.Rows[6]["tencasi"].ToString();
            label_category_27.Text = ENHITS.Rows[6]["tennhacsi"].ToString();
            label_category_28.Text = ENHITS.Rows[6]["thoiluong"].ToString();

            pictureBox8.BackgroundImage = (Image)ENHITS.Rows[7]["hinhanh"];
            label_category_29.Text = ENHITS.Rows[7]["tenbaihat"].ToString();
            label_category_30.Text = ENHITS.Rows[7]["tencasi"].ToString();
            label_category_31.Text = ENHITS.Rows[7]["tennhacsi"].ToString();
            label_category_32.Text = ENHITS.Rows[7]["thoiluong"].ToString();

            pictureBox9.BackgroundImage = (Image)ENHITS.Rows[8]["hinhanh"];
            label_category_33.Text = ENHITS.Rows[8]["tenbaihat"].ToString();
            label_category_34.Text = ENHITS.Rows[8]["tencasi"].ToString();
            label_category_35.Text = ENHITS.Rows[8]["tennhacsi"].ToString();
            label_category_36.Text = ENHITS.Rows[8]["thoiluong"].ToString();

            pictureBox10.BackgroundImage = (Image)ENHITS.Rows[9]["hinhanh"];
            label_category_37.Text = ENHITS.Rows[9]["tenbaihat"].ToString();
            label_category_38.Text = ENHITS.Rows[9]["tencasi"].ToString();
            label_category_39.Text = ENHITS.Rows[9]["tennhacsi"].ToString();
            label_category_40.Text = ENHITS.Rows[9]["thoiluong"].ToString();
        }

        //effect
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            panel3.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {

            panel6.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            panel7.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            panel7.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            panel4.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel8_MouseMove(object sender, MouseEventArgs e)
        {
            panel8.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            panel8.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel9_MouseMove(object sender, MouseEventArgs e)
        {
            panel9.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel9_MouseLeave(object sender, EventArgs e)
        {
            panel9.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel10_MouseMove(object sender, MouseEventArgs e)
        {
            panel10.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel10_MouseLeave(object sender, EventArgs e)
        {
            panel10.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel11_MouseMove(object sender, MouseEventArgs e)
        {
            panel11.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel11_MouseLeave(object sender, EventArgs e)
        {
            panel11.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel12_MouseMove(object sender, MouseEventArgs e)
        {
            panel12.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel12_MouseLeave(object sender, EventArgs e)
        {
            panel12.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel13_MouseMove(object sender, MouseEventArgs e)
        {
            panel13.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel13_MouseLeave(object sender, EventArgs e)
        {
            panel13.BorderStyle = BorderStyle.FixedSingle;
        }




        //playbutton
        private void pictureBox_play_Click(object sender, EventArgs e)
        {
            switch (playing)
            {
                case false:
                    player.Play();
                    pictureBox_play.BackgroundImage = pictureBox38.BackgroundImage = Properties.Resources.stop;
                    playing = true;
                    break;
                case true:
                    player.Stop();
                    pictureBox_play.BackgroundImage = pictureBox38.BackgroundImage = Properties.Resources.play3;
                    playing = false;
                    break;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            panel_category.Visible = false;
        }

        //play nhac 
        bool playing = false;
        private void panel3_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox1.BackgroundImage;
            label_songname.Text = label_category_1.Text;
            label_songartist.Text = label_category_2.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;
            if (viralcheck == 1)
                player.SoundLocation = (string)VIRALHITS.Rows[0]["baihat"];
            if (vncheck == 1)
                player.SoundLocation = (string)VNHITS.Rows[0]["baihat"];
            if (encheck == 1)
                player.SoundLocation = (string)ENHITS.Rows[0]["baihat"];
            player.Play();
        }

        private void panel6_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox2.BackgroundImage;
            label_songname.Text = label_category_5.Text;
            label_songartist.Text = label_category_6.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;
            if (viralcheck == 1)
                player.SoundLocation = (string)VIRALHITS.Rows[1]["baihat"];
            if (vncheck == 1)
                player.SoundLocation = (string)VNHITS.Rows[1]["baihat"];
            if (encheck == 1)
                player.SoundLocation = (string)ENHITS.Rows[1]["baihat"];
            player.Play();
        }


        private void panel7_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox3.BackgroundImage;
            label_songname.Text = label_category_9.Text;
            label_songartist.Text = label_category_10.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;
            if (viralcheck == 1)
                player.SoundLocation = (string)VIRALHITS.Rows[2]["baihat"];
            if (vncheck == 1)
                player.SoundLocation = (string)VNHITS.Rows[2]["baihat"];
            if (encheck == 1)
                player.SoundLocation = (string)ENHITS.Rows[2]["baihat"];
            player.Play();
        }

        private void panel4_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox4.BackgroundImage;
            label_songname.Text = label_category_13.Text;
            label_songartist.Text = label_category_14.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;
            if (viralcheck == 1)
                player.SoundLocation = (string)VIRALHITS.Rows[3]["baihat"];
            if (vncheck == 1)
                player.SoundLocation = (string)VNHITS.Rows[3]["baihat"];
            if (encheck == 1)
                player.SoundLocation = (string)ENHITS.Rows[3]["baihat"];
            player.Play();
        }

        private void panel8_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox5.BackgroundImage;
            label_songname.Text = label_category_17.Text;
            label_songartist.Text = label_category_18.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;
            if (viralcheck == 1)
                player.SoundLocation = (string)VIRALHITS.Rows[4]["baihat"];
            if (vncheck == 1)
                player.SoundLocation = (string)VNHITS.Rows[4]["baihat"];
            if (encheck == 1)
                player.SoundLocation = (string)ENHITS.Rows[4]["baihat"];
            player.Play();
        }

        private void panel9_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox6.BackgroundImage;
            label_songname.Text = label_category_21.Text;
            label_songartist.Text = label_category_22.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;
            if (viralcheck == 1)
                player.SoundLocation = (string)VIRALHITS.Rows[5]["baihat"];
            if (vncheck == 1)
                player.SoundLocation = (string)VNHITS.Rows[5]["baihat"];
            if (encheck == 1)
                player.SoundLocation = (string)ENHITS.Rows[5]["baihat"];
            player.Play();
        }

        private void panel10_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox7.BackgroundImage;
            label_songname.Text = label_category_25.Text;
            label_songartist.Text = label_category_26.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;
            if (viralcheck == 1)
                player.SoundLocation = (string)VIRALHITS.Rows[6]["baihat"];
            if (vncheck == 1)
                player.SoundLocation = (string)VNHITS.Rows[6]["baihat"];
            if (encheck == 1)
                player.SoundLocation = (string)ENHITS.Rows[6]["baihat"];
            player.Play();
        }

        private void panel11_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox8.BackgroundImage;
            label_songname.Text = label_category_29.Text;
            label_songartist.Text = label_category_30.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;
            if (viralcheck == 1)
                player.SoundLocation = (string)VIRALHITS.Rows[7]["baihat"];
            if (vncheck == 1)
                player.SoundLocation = (string)VNHITS.Rows[7]["baihat"];
            if (encheck == 1)
                player.SoundLocation = (string)ENHITS.Rows[7]["baihat"];
            player.Play();
        }

        private void panel12_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox9.BackgroundImage;
            label_songname.Text = label_category_33.Text;
            label_songartist.Text = label_category_34.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;
            if (viralcheck == 1)
                player.SoundLocation = (string)VIRALHITS.Rows[8]["baihat"];
            if (vncheck == 1)
                player.SoundLocation = (string)VNHITS.Rows[8]["baihat"];
            if (encheck == 1)
                player.SoundLocation = (string)ENHITS.Rows[8]["baihat"];
            player.Play();
        }

        private void panel13_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox10.BackgroundImage;
            label_songname.Text = label_category_37.Text;
            label_songartist.Text = label_category_38.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;
            if (viralcheck == 1)
                player.SoundLocation = (string)VIRALHITS.Rows[9]["baihat"];
            if (vncheck == 1)
                player.SoundLocation = (string)VNHITS.Rows[9]["baihat"];
            if (encheck == 1)
                player.SoundLocation = (string)ENHITS.Rows[9]["baihat"];
            player.Play();
        }




        private void pictureBox_back_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int dice = random.Next(1, 10);
            switch (dice)
            {
                case 1:
                    panel3_DoubleClick(sender, e);
                    break;
                case 2:
                    panel6_DoubleClick(sender, e);
                    break;
                case 3:
                    panel7_DoubleClick(sender, e);
                    break;
                case 4:
                    panel4_DoubleClick(sender, e);
                    break;
                case 5:
                    panel8_DoubleClick(sender, e);
                    break;
                case 6:
                    panel9_DoubleClick(sender, e);
                    break;
                case 7:
                    panel10_DoubleClick(sender, e);
                    break;
                case 8:
                    panel11_DoubleClick(sender, e);
                    break;
                case 9:
                    panel12_DoubleClick(sender, e);
                    break;
                case 10:
                    panel13_DoubleClick(sender, e);
                    break;
            }
        }

        bool loopcheck = false;
        private void pictureBox_loop_Click(object sender, EventArgs e)
        {
            switch (loopcheck)
            {
                case false:
                    player.PlayLooping();
                    label_loopcheck.Visible = true;
                    loopcheck = true;
                    break;
                case true:
                    player.Play();
                    label_loopcheck.Visible = false;
                    loopcheck = false;
                    break;
            }
        }

        private void pictureBox_for_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int dice = random.Next(1, 10);
            switch (dice)
            {
                case 1:
                    panel3_DoubleClick(sender, e);
                    break;
                case 2:
                    panel6_DoubleClick(sender, e);
                    break;
                case 3:
                    panel7_DoubleClick(sender, e);
                    break;
                case 4:
                    panel4_DoubleClick(sender, e);
                    break;
                case 5:
                    panel8_DoubleClick(sender, e);
                    break;
                case 6:
                    panel9_DoubleClick(sender, e);
                    break;
                case 7:
                    panel10_DoubleClick(sender, e);
                    break;
                case 8:
                    panel11_DoubleClick(sender, e);
                    break;
                case 9:
                    panel12_DoubleClick(sender, e);
                    break;
                case 10:
                    panel13_DoubleClick(sender, e);
                    break;
            }
        }

        private void label_songname_Click(object sender, EventArgs e)
        {
            panel_pricate.Visible = true;
            panel_category.Visible = false;
            panel_likedsong.Visible = false;
            panel_playlist.Visible = false;

            switch (label_songname.Text)
            {
                case "NGTANOISE":
                    pictureBox_1song.BackgroundImage = (Image)VIRALHITS.Rows[0]["hinhanh"];
                    label_1song_1.Text = VIRALHITS.Rows[0]["tenbaihat"].ToString();
                    label_1song_3.Text = VIRALHITS.Rows[0]["tencasi"].ToString();
                    label_1song_4.Text = VIRALHITS.Rows[0]["loibaihat"].ToString();
                    label_1song_5.Text = VIRALHITS.Rows[0]["binhluan"].ToString();
                    label_1song_comp.Text = VIRALHITS.Rows[0]["tennhacsi"].ToString();
                    if (Convert.ToInt32(VIRALHITS.Rows[0]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(VIRALHITS.Rows[0]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "QUERRY":
                    pictureBox_1song.BackgroundImage = (Image)VIRALHITS.Rows[1]["hinhanh"];
                    label_1song_1.Text = VIRALHITS.Rows[1]["tenbaihat"].ToString();
                    label_1song_3.Text = VIRALHITS.Rows[1]["tencasi"].ToString();
                    label_1song_4.Text = VIRALHITS.Rows[1]["loibaihat"].ToString();
                    label_1song_5.Text = VIRALHITS.Rows[1]["binhluan"].ToString();
                    label_1song_comp.Text = VIRALHITS.Rows[1]["tennhacsi"].ToString();
                    if (Convert.ToInt32(VIRALHITS.Rows[1]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(VIRALHITS.Rows[1]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "TAYTO":
                    pictureBox_1song.BackgroundImage = (Image)VIRALHITS.Rows[2]["hinhanh"];
                    label_1song_1.Text = VIRALHITS.Rows[2]["tenbaihat"].ToString();
                    label_1song_3.Text = VIRALHITS.Rows[2]["tencasi"].ToString();
                    label_1song_4.Text = VIRALHITS.Rows[2]["loibaihat"].ToString();
                    label_1song_5.Text = VIRALHITS.Rows[2]["binhluan"].ToString();
                    label_1song_comp.Text = VIRALHITS.Rows[2]["tennhacsi"].ToString();
                    if (Convert.ToInt32(VIRALHITS.Rows[2]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(VIRALHITS.Rows[2]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "THICHTHICH":
                    pictureBox_1song.BackgroundImage = (Image)VIRALHITS.Rows[3]["hinhanh"];
                    label_1song_1.Text = VIRALHITS.Rows[3]["tenbaihat"].ToString();
                    label_1song_3.Text = VIRALHITS.Rows[3]["tencasi"].ToString();
                    label_1song_4.Text = VIRALHITS.Rows[3]["loibaihat"].ToString();
                    label_1song_5.Text = VIRALHITS.Rows[3]["binhluan"].ToString();
                    label_1song_comp.Text = VIRALHITS.Rows[3]["tennhacsi"].ToString();
                    if (Convert.ToInt32(VIRALHITS.Rows[3]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(VIRALHITS.Rows[3]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "tiny love":
                    pictureBox_1song.BackgroundImage = (Image)VIRALHITS.Rows[4]["hinhanh"];
                    label_1song_1.Text = VIRALHITS.Rows[4]["tenbaihat"].ToString();
                    label_1song_3.Text = VIRALHITS.Rows[4]["tencasi"].ToString();
                    label_1song_4.Text = VIRALHITS.Rows[4]["loibaihat"].ToString();
                    label_1song_5.Text = VIRALHITS.Rows[4]["binhluan"].ToString();
                    label_1song_comp.Text = VIRALHITS.Rows[4]["tennhacsi"].ToString();
                    if (Convert.ToInt32(VIRALHITS.Rows[4]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(VIRALHITS.Rows[4]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "My House":
                    pictureBox_1song.BackgroundImage = (Image)VIRALHITS.Rows[5]["hinhanh"];
                    label_1song_1.Text = VIRALHITS.Rows[5]["tenbaihat"].ToString();
                    label_1song_3.Text = VIRALHITS.Rows[5]["tencasi"].ToString();
                    label_1song_4.Text = VIRALHITS.Rows[5]["loibaihat"].ToString();
                    label_1song_5.Text = VIRALHITS.Rows[5]["binhluan"].ToString();
                    label_1song_comp.Text = VIRALHITS.Rows[5]["tennhacsi"].ToString();
                    if (Convert.ToInt32(VIRALHITS.Rows[5]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(VIRALHITS.Rows[5]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "New Genesis":
                    pictureBox_1song.BackgroundImage = (Image)VIRALHITS.Rows[6]["hinhanh"];
                    label_1song_1.Text = VIRALHITS.Rows[6]["tenbaihat"].ToString();
                    label_1song_3.Text = VIRALHITS.Rows[6]["tencasi"].ToString();
                    label_1song_4.Text = VIRALHITS.Rows[6]["loibaihat"].ToString();
                    label_1song_5.Text = VIRALHITS.Rows[6]["binhluan"].ToString();
                    label_1song_comp.Text = VIRALHITS.Rows[6]["tennhacsi"].ToString();
                    if (Convert.ToInt32(VIRALHITS.Rows[6]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(VIRALHITS.Rows[6]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "Sorry":
                    pictureBox_1song.BackgroundImage = (Image)VIRALHITS.Rows[7]["hinhanh"];
                    label_1song_1.Text = VIRALHITS.Rows[7]["tenbaihat"].ToString();
                    label_1song_3.Text = VIRALHITS.Rows[7]["tencasi"].ToString();
                    label_1song_4.Text = VIRALHITS.Rows[7]["loibaihat"].ToString();
                    label_1song_5.Text = VIRALHITS.Rows[7]["binhluan"].ToString();
                    label_1song_comp.Text = VIRALHITS.Rows[7]["tennhacsi"].ToString();
                    if (Convert.ToInt32(VIRALHITS.Rows[7]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(VIRALHITS.Rows[7]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "Sunflower":
                    pictureBox_1song.BackgroundImage = (Image)VIRALHITS.Rows[8]["hinhanh"];
                    label_1song_1.Text = VIRALHITS.Rows[8]["tenbaihat"].ToString();
                    label_1song_3.Text = VIRALHITS.Rows[8]["tencasi"].ToString();
                    label_1song_4.Text = VIRALHITS.Rows[8]["loibaihat"].ToString();
                    label_1song_5.Text = VIRALHITS.Rows[8]["binhluan"].ToString();
                    label_1song_comp.Text = VIRALHITS.Rows[8]["tennhacsi"].ToString();
                    if (Convert.ToInt32(VIRALHITS.Rows[8]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(VIRALHITS.Rows[8]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "There for you":
                    pictureBox_1song.BackgroundImage = (Image)VIRALHITS.Rows[9]["hinhanh"];
                    label_1song_1.Text = VIRALHITS.Rows[9]["tenbaihat"].ToString();
                    label_1song_3.Text = VIRALHITS.Rows[9]["tencasi"].ToString();
                    label_1song_4.Text = VIRALHITS.Rows[9]["loibaihat"].ToString();
                    label_1song_5.Text = VIRALHITS.Rows[9]["binhluan"].ToString();
                    label_1song_comp.Text = VIRALHITS.Rows[9]["tennhacsi"].ToString();
                    if (Convert.ToInt32(VIRALHITS.Rows[9]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(VIRALHITS.Rows[9]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;


                case "25":
                    pictureBox_1song.BackgroundImage = (Image)VNHITS.Rows[0]["hinhanh"];
                    label_1song_1.Text = VNHITS.Rows[0]["tenbaihat"].ToString();
                    label_1song_3.Text = VNHITS.Rows[0]["tencasi"].ToString();
                    label_1song_4.Text = VNHITS.Rows[0]["loibaihat"].ToString();
                    label_1song_5.Text = VNHITS.Rows[0]["binhluan"].ToString();
                    label_1song_comp.Text = VNHITS.Rows[0]["tennhacsi"].ToString();
                    if (Convert.ToInt32(VNHITS.Rows[0]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(VNHITS.Rows[0]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "3107":
                    pictureBox_1song.BackgroundImage = (Image)VNHITS.Rows[1]["hinhanh"];
                    label_1song_1.Text = VNHITS.Rows[1]["tenbaihat"].ToString();
                    label_1song_3.Text = VNHITS.Rows[1]["tencasi"].ToString();
                    label_1song_4.Text = VNHITS.Rows[1]["loibaihat"].ToString();
                    label_1song_5.Text = VNHITS.Rows[1]["binhluan"].ToString();
                    label_1song_comp.Text = VNHITS.Rows[1]["tennhacsi"].ToString();
                    if (Convert.ToInt32(VNHITS.Rows[1]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(VNHITS.Rows[1]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "AI BIET":
                    pictureBox_1song.BackgroundImage = (Image)VNHITS.Rows[2]["hinhanh"];
                    label_1song_1.Text = VNHITS.Rows[2]["tenbaihat"].ToString();
                    label_1song_3.Text = VNHITS.Rows[2]["tencasi"].ToString();
                    label_1song_4.Text = VNHITS.Rows[2]["loibaihat"].ToString();
                    label_1song_5.Text = VNHITS.Rows[2]["binhluan"].ToString();
                    label_1song_comp.Text = VNHITS.Rows[2]["tennhacsi"].ToString();
                    if (Convert.ToInt32(VNHITS.Rows[2]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(VNHITS.Rows[2]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "CHIM SAU":
                    pictureBox_1song.BackgroundImage = (Image)VNHITS.Rows[3]["hinhanh"];
                    label_1song_1.Text = VNHITS.Rows[3]["tenbaihat"].ToString();
                    label_1song_3.Text = VNHITS.Rows[3]["tencasi"].ToString();
                    label_1song_4.Text = VNHITS.Rows[3]["loibaihat"].ToString();
                    label_1song_5.Text = VNHITS.Rows[3]["binhluan"].ToString();
                    label_1song_comp.Text = VNHITS.Rows[3]["tennhacsi"].ToString();
                    if (Convert.ToInt32(VNHITS.Rows[3]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(VNHITS.Rows[3]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "CUA":
                    pictureBox_1song.BackgroundImage = (Image)VNHITS.Rows[4]["hinhanh"];
                    label_1song_1.Text = VNHITS.Rows[4]["tenbaihat"].ToString();
                    label_1song_3.Text = VNHITS.Rows[4]["tencasi"].ToString();
                    label_1song_4.Text = VNHITS.Rows[4]["loibaihat"].ToString();
                    label_1song_5.Text = VNHITS.Rows[4]["binhluan"].ToString();
                    label_1song_comp.Text = VNHITS.Rows[4]["tennhacsi"].ToString();
                    if (Convert.ToInt32(VNHITS.Rows[4]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(VNHITS.Rows[4]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "GIAYPHUT":
                    pictureBox_1song.BackgroundImage = (Image)VNHITS.Rows[5]["hinhanh"];
                    label_1song_1.Text = VNHITS.Rows[5]["tenbaihat"].ToString();
                    label_1song_3.Text = VNHITS.Rows[5]["tencasi"].ToString();
                    label_1song_4.Text = VNHITS.Rows[5]["loibaihat"].ToString();
                    label_1song_5.Text = VNHITS.Rows[5]["binhluan"].ToString();
                    label_1song_comp.Text = VNHITS.Rows[5]["tennhacsi"].ToString();
                    if (Convert.ToInt32(VNHITS.Rows[5]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(VNHITS.Rows[5]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "GU":
                    pictureBox_1song.BackgroundImage = (Image)VNHITS.Rows[6]["hinhanh"];
                    label_1song_1.Text = VNHITS.Rows[6]["tenbaihat"].ToString();
                    label_1song_3.Text = VNHITS.Rows[6]["tencasi"].ToString();
                    label_1song_4.Text = VNHITS.Rows[6]["loibaihat"].ToString();
                    label_1song_5.Text = VNHITS.Rows[6]["binhluan"].ToString();
                    label_1song_comp.Text = VNHITS.Rows[6]["tennhacsi"].ToString();
                    if (Convert.ToInt32(VNHITS.Rows[6]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(VNHITS.Rows[6]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "HOLD MY HAND":
                    pictureBox_1song.BackgroundImage = (Image)VNHITS.Rows[7]["hinhanh"];
                    label_1song_1.Text = VNHITS.Rows[7]["tenbaihat"].ToString();
                    label_1song_3.Text = VNHITS.Rows[7]["tencasi"].ToString();
                    label_1song_4.Text = VNHITS.Rows[7]["loibaihat"].ToString();
                    label_1song_5.Text = VNHITS.Rows[7]["binhluan"].ToString();
                    label_1song_comp.Text = VNHITS.Rows[7]["tennhacsi"].ToString();
                    if (Convert.ToInt32(VNHITS.Rows[7]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(VNHITS.Rows[7]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "ICEMAN":
                    pictureBox_1song.BackgroundImage = (Image)VNHITS.Rows[8]["hinhanh"];
                    label_1song_1.Text = VNHITS.Rows[8]["tenbaihat"].ToString();
                    label_1song_3.Text = VNHITS.Rows[8]["tencasi"].ToString();
                    label_1song_4.Text = VNHITS.Rows[8]["loibaihat"].ToString();
                    label_1song_5.Text = VNHITS.Rows[8]["binhluan"].ToString();
                    label_1song_comp.Text = VNHITS.Rows[8]["tennhacsi"].ToString();
                    if (Convert.ToInt32(VNHITS.Rows[8]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(VNHITS.Rows[8]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "LOCHI":
                    pictureBox_1song.BackgroundImage = (Image)VNHITS.Rows[9]["hinhanh"];
                    label_1song_1.Text = VNHITS.Rows[9]["tenbaihat"].ToString();
                    label_1song_3.Text = VNHITS.Rows[9]["tencasi"].ToString();
                    label_1song_4.Text = VNHITS.Rows[9]["loibaihat"].ToString();
                    label_1song_5.Text = VNHITS.Rows[9]["binhluan"].ToString();
                    label_1song_comp.Text = VNHITS.Rows[9]["tennhacsi"].ToString();
                    if (Convert.ToInt32(VNHITS.Rows[9]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(VNHITS.Rows[9]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "All We Know":
                    pictureBox_1song.BackgroundImage = (Image)ENHITS.Rows[0]["hinhanh"];
                    label_1song_1.Text = ENHITS.Rows[0]["tenbaihat"].ToString();
                    label_1song_3.Text = ENHITS.Rows[0]["tencasi"].ToString();
                    label_1song_4.Text = ENHITS.Rows[0]["loibaihat"].ToString();
                    label_1song_5.Text = ENHITS.Rows[0]["binhluan"].ToString();
                    label_1song_comp.Text = ENHITS.Rows[0]["tennhacsi"].ToString();
                    if (Convert.ToInt32(ENHITS.Rows[0]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(ENHITS.Rows[0]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "Bad Habits":
                    pictureBox_1song.BackgroundImage = (Image)ENHITS.Rows[1]["hinhanh"];
                    label_1song_1.Text = ENHITS.Rows[1]["tenbaihat"].ToString();
                    label_1song_3.Text = ENHITS.Rows[1]["tencasi"].ToString();
                    label_1song_4.Text = ENHITS.Rows[1]["loibaihat"].ToString();
                    label_1song_5.Text = ENHITS.Rows[1]["binhluan"].ToString();
                    label_1song_comp.Text = ENHITS.Rows[1]["tennhacsi"].ToString();
                    if (Convert.ToInt32(ENHITS.Rows[1]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(ENHITS.Rows[1]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "Better Now":
                    pictureBox_1song.BackgroundImage = (Image)ENHITS.Rows[2]["hinhanh"];
                    label_1song_1.Text = ENHITS.Rows[2]["tenbaihat"].ToString();
                    label_1song_3.Text = ENHITS.Rows[2]["tencasi"].ToString();
                    label_1song_4.Text = ENHITS.Rows[2]["loibaihat"].ToString();
                    label_1song_5.Text = ENHITS.Rows[2]["binhluan"].ToString();
                    label_1song_comp.Text = ENHITS.Rows[2]["tennhacsi"].ToString();
                    if (Convert.ToInt32(ENHITS.Rows[2]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(ENHITS.Rows[2]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "Cake By The Ocean":
                    pictureBox_1song.BackgroundImage = (Image)ENHITS.Rows[3]["hinhanh"];
                    label_1song_1.Text = ENHITS.Rows[3]["tenbaihat"].ToString();
                    label_1song_3.Text = ENHITS.Rows[3]["tencasi"].ToString();
                    label_1song_4.Text = ENHITS.Rows[3]["loibaihat"].ToString();
                    label_1song_5.Text = ENHITS.Rows[3]["binhluan"].ToString();
                    label_1song_comp.Text = ENHITS.Rows[3]["tennhacsi"].ToString();
                    if (Convert.ToInt32(ENHITS.Rows[3]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(ENHITS.Rows[3]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "Comedy":
                    pictureBox_1song.BackgroundImage = (Image)ENHITS.Rows[4]["hinhanh"];
                    label_1song_1.Text = ENHITS.Rows[4]["tenbaihat"].ToString();
                    label_1song_3.Text = ENHITS.Rows[4]["tencasi"].ToString();
                    label_1song_4.Text = ENHITS.Rows[4]["loibaihat"].ToString();
                    label_1song_5.Text = ENHITS.Rows[4]["binhluan"].ToString();
                    label_1song_comp.Text = ENHITS.Rows[4]["tennhacsi"].ToString();
                    if (Convert.ToInt32(ENHITS.Rows[4]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(ENHITS.Rows[4]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "Hello":
                    pictureBox_1song.BackgroundImage = (Image)ENHITS.Rows[5]["hinhanh"];
                    label_1song_1.Text = ENHITS.Rows[5]["tenbaihat"].ToString();
                    label_1song_3.Text = ENHITS.Rows[5]["tencasi"].ToString();
                    label_1song_4.Text = ENHITS.Rows[5]["loibaihat"].ToString();
                    label_1song_5.Text = ENHITS.Rows[5]["binhluan"].ToString();
                    label_1song_comp.Text = ENHITS.Rows[5]["tennhacsi"].ToString();
                    if (Convert.ToInt32(ENHITS.Rows[5]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(ENHITS.Rows[5]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "Hero":
                    pictureBox_1song.BackgroundImage = (Image)ENHITS.Rows[6]["hinhanh"];
                    label_1song_1.Text = ENHITS.Rows[6]["tenbaihat"].ToString();
                    label_1song_3.Text = ENHITS.Rows[6]["tencasi"].ToString();
                    label_1song_4.Text = ENHITS.Rows[6]["loibaihat"].ToString();
                    label_1song_5.Text = ENHITS.Rows[6]["binhluan"].ToString();
                    label_1song_comp.Text = ENHITS.Rows[6]["tennhacsi"].ToString();
                    if (Convert.ToInt32(ENHITS.Rows[6]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(ENHITS.Rows[6]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "Immortals":
                    pictureBox_1song.BackgroundImage = (Image)ENHITS.Rows[7]["hinhanh"];
                    label_1song_1.Text = ENHITS.Rows[7]["tenbaihat"].ToString();
                    label_1song_3.Text = ENHITS.Rows[7]["tencasi"].ToString();
                    label_1song_4.Text = ENHITS.Rows[7]["loibaihat"].ToString();
                    label_1song_5.Text = ENHITS.Rows[7]["binhluan"].ToString();
                    label_1song_comp.Text = ENHITS.Rows[7]["tennhacsi"].ToString();
                    if (Convert.ToInt32(ENHITS.Rows[7]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(ENHITS.Rows[7]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "Liar":
                    pictureBox_1song.BackgroundImage = (Image)ENHITS.Rows[8]["hinhanh"];
                    label_1song_1.Text = ENHITS.Rows[8]["tenbaihat"].ToString();
                    label_1song_3.Text = ENHITS.Rows[8]["tencasi"].ToString();
                    label_1song_4.Text = ENHITS.Rows[8]["loibaihat"].ToString();
                    label_1song_5.Text = ENHITS.Rows[8]["binhluan"].ToString();
                    label_1song_comp.Text = ENHITS.Rows[8]["tennhacsi"].ToString();
                    if (Convert.ToInt32(ENHITS.Rows[8]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(ENHITS.Rows[8]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;

                case "Make you mine":
                    pictureBox_1song.BackgroundImage = (Image)ENHITS.Rows[9]["hinhanh"];
                    label_1song_1.Text = ENHITS.Rows[9]["tenbaihat"].ToString();
                    label_1song_3.Text = ENHITS.Rows[9]["tencasi"].ToString();
                    label_1song_4.Text = ENHITS.Rows[9]["loibaihat"].ToString();
                    label_1song_5.Text = ENHITS.Rows[9]["binhluan"].ToString();
                    label_1song_comp.Text = ENHITS.Rows[9]["tennhacsi"].ToString();
                    if (Convert.ToInt32(ENHITS.Rows[9]["Liked"]) == 0)
                        pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                    else
                    {
                        if (Convert.ToInt32(ENHITS.Rows[9]["Liked"]) == 1)
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                    }
                    break;
            }
        }

        private void label_songname_MouseMove(object sender, MouseEventArgs e)
        {
            label_songname.Font = new Font("UTM Avo", 16, FontStyle.Underline | FontStyle.Bold);
        }

        private void label_songname_MouseLeave(object sender, EventArgs e)
        {
            label_songname.Font = new Font("UTM Avo", 16, FontStyle.Bold);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            panel_pricate.Visible = false;
            panel_down.Visible = false;
            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
        }

        int i = -1;
        //bool checklike = false;
        int checklike;
        int a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30;

        private void panel_list_4_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox33.BackgroundImage;
            label_songname.Text = label_list_13.Text;
            label_songartist.Text = label_list_14.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;

            switch (label_songname.Text)
            {
                case "NGTANOISE":
                    player.SoundLocation = (string)VIRALHITS.Rows[0]["baihat"];
                    break;

                case "QUERRY":
                    player.SoundLocation = (string)VIRALHITS.Rows[1]["baihat"];
                    break;

                case "TAYTO":
                    player.SoundLocation = (string)VIRALHITS.Rows[2]["baihat"];
                    break;

                case "THICHTHICH":
                    player.SoundLocation = (string)VIRALHITS.Rows[3]["baihat"];
                    break;

                case "tiny love":
                    player.SoundLocation = (string)VIRALHITS.Rows[4]["baihat"];
                    break;

                case "My House":
                    player.SoundLocation = (string)VIRALHITS.Rows[5]["baihat"];
                    break;

                case "New Genesis":
                    player.SoundLocation = (string)VIRALHITS.Rows[6]["baihat"];
                    break;

                case "Sorry":
                    player.SoundLocation = (string)VIRALHITS.Rows[7]["baihat"];
                    break;

                case "Sunflower":
                    player.SoundLocation = (string)VIRALHITS.Rows[8]["baihat"];
                    break;

                case "There for you":
                    player.SoundLocation = (string)VIRALHITS.Rows[9]["baihat"];
                    break;


                case "25":
                    player.SoundLocation = (string)VNHITS.Rows[0]["baihat"];
                    break;

                case "3107":
                    player.SoundLocation = (string)VNHITS.Rows[1]["baihat"];
                    break;

                case "AI BIET":
                    player.SoundLocation = (string)VNHITS.Rows[2]["baihat"];
                    break;

                case "CHIM SAU":
                    player.SoundLocation = (string)VNHITS.Rows[3]["baihat"];
                    break;

                case "CUA":
                    player.SoundLocation = (string)VNHITS.Rows[4]["baihat"];
                    break;

                case "GIAYPHUT":
                    player.SoundLocation = (string)VNHITS.Rows[5]["baihat"];
                    break;

                case "GU":
                    player.SoundLocation = (string)VNHITS.Rows[6]["baihat"];
                    break;

                case "HOLD MY HAND":
                    player.SoundLocation = (string)VNHITS.Rows[7]["baihat"];
                    break;

                case "ICEMAN":
                    player.SoundLocation = (string)VNHITS.Rows[8]["baihat"];
                    break;

                case "LOCHI":
                    player.SoundLocation = (string)VNHITS.Rows[9]["baihat"];
                    break;

                case "All We Know":
                    player.SoundLocation = (string)ENHITS.Rows[0]["baihat"];
                    break;

                case "Bad Habits":
                    player.SoundLocation = (string)ENHITS.Rows[1]["baihat"];
                    break;

                case "Better Now":
                    player.SoundLocation = (string)ENHITS.Rows[2]["baihat"];
                    break;

                case "Cake By The Ocean":
                    player.SoundLocation = (string)ENHITS.Rows[3]["baihat"];
                    break;

                case "Comedy":
                    player.SoundLocation = (string)ENHITS.Rows[4]["baihat"];
                    break;

                case "Hello":
                    player.SoundLocation = (string)ENHITS.Rows[5]["baihat"];
                    break;

                case "Hero":
                    player.SoundLocation = (string)ENHITS.Rows[6]["baihat"];
                    break;

                case "Immortals":
                    player.SoundLocation = (string)ENHITS.Rows[7]["baihat"];
                    break;

                case "Liar":
                    player.SoundLocation = (string)ENHITS.Rows[8]["baihat"];
                    break;

                case "Make you mine":
                    player.SoundLocation = (string)ENHITS.Rows[9]["baihat"];
                    break;
            }
            player.Play();
        }

        private void panel_list_5_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox32.BackgroundImage;
            label_songname.Text = label_list_17.Text;
            label_songartist.Text = label_list_18.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;

            switch (label_songname.Text)
            {
                case "NGTANOISE":
                    player.SoundLocation = (string)VIRALHITS.Rows[0]["baihat"];
                    break;

                case "QUERRY":
                    player.SoundLocation = (string)VIRALHITS.Rows[1]["baihat"];
                    break;

                case "TAYTO":
                    player.SoundLocation = (string)VIRALHITS.Rows[2]["baihat"];
                    break;

                case "THICHTHICH":
                    player.SoundLocation = (string)VIRALHITS.Rows[3]["baihat"];
                    break;

                case "tiny love":
                    player.SoundLocation = (string)VIRALHITS.Rows[4]["baihat"];
                    break;

                case "My House":
                    player.SoundLocation = (string)VIRALHITS.Rows[5]["baihat"];
                    break;

                case "New Genesis":
                    player.SoundLocation = (string)VIRALHITS.Rows[6]["baihat"];
                    break;

                case "Sorry":
                    player.SoundLocation = (string)VIRALHITS.Rows[7]["baihat"];
                    break;

                case "Sunflower":
                    player.SoundLocation = (string)VIRALHITS.Rows[8]["baihat"];
                    break;

                case "There for you":
                    player.SoundLocation = (string)VIRALHITS.Rows[9]["baihat"];
                    break;


                case "25":
                    player.SoundLocation = (string)VNHITS.Rows[0]["baihat"];
                    break;

                case "3107":
                    player.SoundLocation = (string)VNHITS.Rows[1]["baihat"];
                    break;

                case "AI BIET":
                    player.SoundLocation = (string)VNHITS.Rows[2]["baihat"];
                    break;

                case "CHIM SAU":
                    player.SoundLocation = (string)VNHITS.Rows[3]["baihat"];
                    break;

                case "CUA":
                    player.SoundLocation = (string)VNHITS.Rows[4]["baihat"];
                    break;

                case "GIAYPHUT":
                    player.SoundLocation = (string)VNHITS.Rows[5]["baihat"];
                    break;

                case "GU":
                    player.SoundLocation = (string)VNHITS.Rows[6]["baihat"];
                    break;

                case "HOLD MY HAND":
                    player.SoundLocation = (string)VNHITS.Rows[7]["baihat"];
                    break;

                case "ICEMAN":
                    player.SoundLocation = (string)VNHITS.Rows[8]["baihat"];
                    break;

                case "LOCHI":
                    player.SoundLocation = (string)VNHITS.Rows[9]["baihat"];
                    break;

                case "All We Know":
                    player.SoundLocation = (string)ENHITS.Rows[0]["baihat"];
                    break;

                case "Bad Habits":
                    player.SoundLocation = (string)ENHITS.Rows[1]["baihat"];
                    break;

                case "Better Now":
                    player.SoundLocation = (string)ENHITS.Rows[2]["baihat"];
                    break;

                case "Cake By The Ocean":
                    player.SoundLocation = (string)ENHITS.Rows[3]["baihat"];
                    break;

                case "Comedy":
                    player.SoundLocation = (string)ENHITS.Rows[4]["baihat"];
                    break;

                case "Hello":
                    player.SoundLocation = (string)ENHITS.Rows[5]["baihat"];
                    break;

                case "Hero":
                    player.SoundLocation = (string)ENHITS.Rows[6]["baihat"];
                    break;

                case "Immortals":
                    player.SoundLocation = (string)ENHITS.Rows[7]["baihat"];
                    break;

                case "Liar":
                    player.SoundLocation = (string)ENHITS.Rows[8]["baihat"];
                    break;

                case "Make you mine":
                    player.SoundLocation = (string)ENHITS.Rows[9]["baihat"];
                    break;
            }
            player.Play();
        }

        private void panel_list_6_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox31.BackgroundImage;
            label_songname.Text = label_list_21.Text;
            label_songartist.Text = label_list_22.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;

            switch (label_songname.Text)
            {
                case "NGTANOISE":
                    player.SoundLocation = (string)VIRALHITS.Rows[0]["baihat"];
                    break;

                case "QUERRY":
                    player.SoundLocation = (string)VIRALHITS.Rows[1]["baihat"];
                    break;

                case "TAYTO":
                    player.SoundLocation = (string)VIRALHITS.Rows[2]["baihat"];
                    break;

                case "THICHTHICH":
                    player.SoundLocation = (string)VIRALHITS.Rows[3]["baihat"];
                    break;

                case "tiny love":
                    player.SoundLocation = (string)VIRALHITS.Rows[4]["baihat"];
                    break;

                case "My House":
                    player.SoundLocation = (string)VIRALHITS.Rows[5]["baihat"];
                    break;

                case "New Genesis":
                    player.SoundLocation = (string)VIRALHITS.Rows[6]["baihat"];
                    break;

                case "Sorry":
                    player.SoundLocation = (string)VIRALHITS.Rows[7]["baihat"];
                    break;

                case "Sunflower":
                    player.SoundLocation = (string)VIRALHITS.Rows[8]["baihat"];
                    break;

                case "There for you":
                    player.SoundLocation = (string)VIRALHITS.Rows[9]["baihat"];
                    break;


                case "25":
                    player.SoundLocation = (string)VNHITS.Rows[0]["baihat"];
                    break;

                case "3107":
                    player.SoundLocation = (string)VNHITS.Rows[1]["baihat"];
                    break;

                case "AI BIET":
                    player.SoundLocation = (string)VNHITS.Rows[2]["baihat"];
                    break;

                case "CHIM SAU":
                    player.SoundLocation = (string)VNHITS.Rows[3]["baihat"];
                    break;

                case "CUA":
                    player.SoundLocation = (string)VNHITS.Rows[4]["baihat"];
                    break;

                case "GIAYPHUT":
                    player.SoundLocation = (string)VNHITS.Rows[5]["baihat"];
                    break;

                case "GU":
                    player.SoundLocation = (string)VNHITS.Rows[6]["baihat"];
                    break;

                case "HOLD MY HAND":
                    player.SoundLocation = (string)VNHITS.Rows[7]["baihat"];
                    break;

                case "ICEMAN":
                    player.SoundLocation = (string)VNHITS.Rows[8]["baihat"];
                    break;

                case "LOCHI":
                    player.SoundLocation = (string)VNHITS.Rows[9]["baihat"];
                    break;

                case "All We Know":
                    player.SoundLocation = (string)ENHITS.Rows[0]["baihat"];
                    break;

                case "Bad Habits":
                    player.SoundLocation = (string)ENHITS.Rows[1]["baihat"];
                    break;

                case "Better Now":
                    player.SoundLocation = (string)ENHITS.Rows[2]["baihat"];
                    break;

                case "Cake By The Ocean":
                    player.SoundLocation = (string)ENHITS.Rows[3]["baihat"];
                    break;

                case "Comedy":
                    player.SoundLocation = (string)ENHITS.Rows[4]["baihat"];
                    break;

                case "Hello":
                    player.SoundLocation = (string)ENHITS.Rows[5]["baihat"];
                    break;

                case "Hero":
                    player.SoundLocation = (string)ENHITS.Rows[6]["baihat"];
                    break;

                case "Immortals":
                    player.SoundLocation = (string)ENHITS.Rows[7]["baihat"];
                    break;

                case "Liar":
                    player.SoundLocation = (string)ENHITS.Rows[8]["baihat"];
                    break;

                case "Make you mine":
                    player.SoundLocation = (string)ENHITS.Rows[9]["baihat"];
                    break;
            }
            player.Play();
        }

        private void panel_list_7_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox30.BackgroundImage;
            label_songname.Text = label_list_25.Text;
            label_songartist.Text = label_list_26.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;

            switch (label_songname.Text)
            {
                case "NGTANOISE":
                    player.SoundLocation = (string)VIRALHITS.Rows[0]["baihat"];
                    break;

                case "QUERRY":
                    player.SoundLocation = (string)VIRALHITS.Rows[1]["baihat"];
                    break;

                case "TAYTO":
                    player.SoundLocation = (string)VIRALHITS.Rows[2]["baihat"];
                    break;

                case "THICHTHICH":
                    player.SoundLocation = (string)VIRALHITS.Rows[3]["baihat"];
                    break;

                case "tiny love":
                    player.SoundLocation = (string)VIRALHITS.Rows[4]["baihat"];
                    break;

                case "My House":
                    player.SoundLocation = (string)VIRALHITS.Rows[5]["baihat"];
                    break;

                case "New Genesis":
                    player.SoundLocation = (string)VIRALHITS.Rows[6]["baihat"];
                    break;

                case "Sorry":
                    player.SoundLocation = (string)VIRALHITS.Rows[7]["baihat"];
                    break;

                case "Sunflower":
                    player.SoundLocation = (string)VIRALHITS.Rows[8]["baihat"];
                    break;

                case "There for you":
                    player.SoundLocation = (string)VIRALHITS.Rows[9]["baihat"];
                    break;


                case "25":
                    player.SoundLocation = (string)VNHITS.Rows[0]["baihat"];
                    break;

                case "3107":
                    player.SoundLocation = (string)VNHITS.Rows[1]["baihat"];
                    break;

                case "AI BIET":
                    player.SoundLocation = (string)VNHITS.Rows[2]["baihat"];
                    break;

                case "CHIM SAU":
                    player.SoundLocation = (string)VNHITS.Rows[3]["baihat"];
                    break;

                case "CUA":
                    player.SoundLocation = (string)VNHITS.Rows[4]["baihat"];
                    break;

                case "GIAYPHUT":
                    player.SoundLocation = (string)VNHITS.Rows[5]["baihat"];
                    break;

                case "GU":
                    player.SoundLocation = (string)VNHITS.Rows[6]["baihat"];
                    break;

                case "HOLD MY HAND":
                    player.SoundLocation = (string)VNHITS.Rows[7]["baihat"];
                    break;

                case "ICEMAN":
                    player.SoundLocation = (string)VNHITS.Rows[8]["baihat"];
                    break;

                case "LOCHI":
                    player.SoundLocation = (string)VNHITS.Rows[9]["baihat"];
                    break;

                case "All We Know":
                    player.SoundLocation = (string)ENHITS.Rows[0]["baihat"];
                    break;

                case "Bad Habits":
                    player.SoundLocation = (string)ENHITS.Rows[1]["baihat"];
                    break;

                case "Better Now":
                    player.SoundLocation = (string)ENHITS.Rows[2]["baihat"];
                    break;

                case "Cake By The Ocean":
                    player.SoundLocation = (string)ENHITS.Rows[3]["baihat"];
                    break;

                case "Comedy":
                    player.SoundLocation = (string)ENHITS.Rows[4]["baihat"];
                    break;

                case "Hello":
                    player.SoundLocation = (string)ENHITS.Rows[5]["baihat"];
                    break;

                case "Hero":
                    player.SoundLocation = (string)ENHITS.Rows[6]["baihat"];
                    break;

                case "Immortals":
                    player.SoundLocation = (string)ENHITS.Rows[7]["baihat"];
                    break;

                case "Liar":
                    player.SoundLocation = (string)ENHITS.Rows[8]["baihat"];
                    break;

                case "Make you mine":
                    player.SoundLocation = (string)ENHITS.Rows[9]["baihat"];
                    break;
            }
            player.Play();
        }

        private void panel_list_8_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox29.BackgroundImage;
            label_songname.Text = label_list_29.Text;
            label_songartist.Text = label_list_30.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;

            switch (label_songname.Text)
            {
                case "NGTANOISE":
                    player.SoundLocation = (string)VIRALHITS.Rows[0]["baihat"];
                    break;

                case "QUERRY":
                    player.SoundLocation = (string)VIRALHITS.Rows[1]["baihat"];
                    break;

                case "TAYTO":
                    player.SoundLocation = (string)VIRALHITS.Rows[2]["baihat"];
                    break;

                case "THICHTHICH":
                    player.SoundLocation = (string)VIRALHITS.Rows[3]["baihat"];
                    break;

                case "tiny love":
                    player.SoundLocation = (string)VIRALHITS.Rows[4]["baihat"];
                    break;

                case "My House":
                    player.SoundLocation = (string)VIRALHITS.Rows[5]["baihat"];
                    break;

                case "New Genesis":
                    player.SoundLocation = (string)VIRALHITS.Rows[6]["baihat"];
                    break;

                case "Sorry":
                    player.SoundLocation = (string)VIRALHITS.Rows[7]["baihat"];
                    break;

                case "Sunflower":
                    player.SoundLocation = (string)VIRALHITS.Rows[8]["baihat"];
                    break;

                case "There for you":
                    player.SoundLocation = (string)VIRALHITS.Rows[9]["baihat"];
                    break;


                case "25":
                    player.SoundLocation = (string)VNHITS.Rows[0]["baihat"];
                    break;

                case "3107":
                    player.SoundLocation = (string)VNHITS.Rows[1]["baihat"];
                    break;

                case "AI BIET":
                    player.SoundLocation = (string)VNHITS.Rows[2]["baihat"];
                    break;

                case "CHIM SAU":
                    player.SoundLocation = (string)VNHITS.Rows[3]["baihat"];
                    break;

                case "CUA":
                    player.SoundLocation = (string)VNHITS.Rows[4]["baihat"];
                    break;

                case "GIAYPHUT":
                    player.SoundLocation = (string)VNHITS.Rows[5]["baihat"];
                    break;

                case "GU":
                    player.SoundLocation = (string)VNHITS.Rows[6]["baihat"];
                    break;

                case "HOLD MY HAND":
                    player.SoundLocation = (string)VNHITS.Rows[7]["baihat"];
                    break;

                case "ICEMAN":
                    player.SoundLocation = (string)VNHITS.Rows[8]["baihat"];
                    break;

                case "LOCHI":
                    player.SoundLocation = (string)VNHITS.Rows[9]["baihat"];
                    break;

                case "All We Know":
                    player.SoundLocation = (string)ENHITS.Rows[0]["baihat"];
                    break;

                case "Bad Habits":
                    player.SoundLocation = (string)ENHITS.Rows[1]["baihat"];
                    break;

                case "Better Now":
                    player.SoundLocation = (string)ENHITS.Rows[2]["baihat"];
                    break;

                case "Cake By The Ocean":
                    player.SoundLocation = (string)ENHITS.Rows[3]["baihat"];
                    break;

                case "Comedy":
                    player.SoundLocation = (string)ENHITS.Rows[4]["baihat"];
                    break;

                case "Hello":
                    player.SoundLocation = (string)ENHITS.Rows[5]["baihat"];
                    break;

                case "Hero":
                    player.SoundLocation = (string)ENHITS.Rows[6]["baihat"];
                    break;

                case "Immortals":
                    player.SoundLocation = (string)ENHITS.Rows[7]["baihat"];
                    break;

                case "Liar":
                    player.SoundLocation = (string)ENHITS.Rows[8]["baihat"];
                    break;

                case "Make you mine":
                    player.SoundLocation = (string)ENHITS.Rows[9]["baihat"];
                    break;
            }
            player.Play();
        }

        private void panel_list_9_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox28.BackgroundImage;
            label_songname.Text = label_list_33.Text;
            label_songartist.Text = label_list_34.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;

            switch (label_songname.Text)
            {
                case "NGTANOISE":
                    player.SoundLocation = (string)VIRALHITS.Rows[0]["baihat"];
                    break;

                case "QUERRY":
                    player.SoundLocation = (string)VIRALHITS.Rows[1]["baihat"];
                    break;

                case "TAYTO":
                    player.SoundLocation = (string)VIRALHITS.Rows[2]["baihat"];
                    break;

                case "THICHTHICH":
                    player.SoundLocation = (string)VIRALHITS.Rows[3]["baihat"];
                    break;

                case "tiny love":
                    player.SoundLocation = (string)VIRALHITS.Rows[4]["baihat"];
                    break;

                case "My House":
                    player.SoundLocation = (string)VIRALHITS.Rows[5]["baihat"];
                    break;

                case "New Genesis":
                    player.SoundLocation = (string)VIRALHITS.Rows[6]["baihat"];
                    break;

                case "Sorry":
                    player.SoundLocation = (string)VIRALHITS.Rows[7]["baihat"];
                    break;

                case "Sunflower":
                    player.SoundLocation = (string)VIRALHITS.Rows[8]["baihat"];
                    break;

                case "There for you":
                    player.SoundLocation = (string)VIRALHITS.Rows[9]["baihat"];
                    break;


                case "25":
                    player.SoundLocation = (string)VNHITS.Rows[0]["baihat"];
                    break;

                case "3107":
                    player.SoundLocation = (string)VNHITS.Rows[1]["baihat"];
                    break;

                case "AI BIET":
                    player.SoundLocation = (string)VNHITS.Rows[2]["baihat"];
                    break;

                case "CHIM SAU":
                    player.SoundLocation = (string)VNHITS.Rows[3]["baihat"];
                    break;

                case "CUA":
                    player.SoundLocation = (string)VNHITS.Rows[4]["baihat"];
                    break;

                case "GIAYPHUT":
                    player.SoundLocation = (string)VNHITS.Rows[5]["baihat"];
                    break;

                case "GU":
                    player.SoundLocation = (string)VNHITS.Rows[6]["baihat"];
                    break;

                case "HOLD MY HAND":
                    player.SoundLocation = (string)VNHITS.Rows[7]["baihat"];
                    break;

                case "ICEMAN":
                    player.SoundLocation = (string)VNHITS.Rows[8]["baihat"];
                    break;

                case "LOCHI":
                    player.SoundLocation = (string)VNHITS.Rows[9]["baihat"];
                    break;

                case "All We Know":
                    player.SoundLocation = (string)ENHITS.Rows[0]["baihat"];
                    break;

                case "Bad Habits":
                    player.SoundLocation = (string)ENHITS.Rows[1]["baihat"];
                    break;

                case "Better Now":
                    player.SoundLocation = (string)ENHITS.Rows[2]["baihat"];
                    break;

                case "Cake By The Ocean":
                    player.SoundLocation = (string)ENHITS.Rows[3]["baihat"];
                    break;

                case "Comedy":
                    player.SoundLocation = (string)ENHITS.Rows[4]["baihat"];
                    break;

                case "Hello":
                    player.SoundLocation = (string)ENHITS.Rows[5]["baihat"];
                    break;

                case "Hero":
                    player.SoundLocation = (string)ENHITS.Rows[6]["baihat"];
                    break;

                case "Immortals":
                    player.SoundLocation = (string)ENHITS.Rows[7]["baihat"];
                    break;

                case "Liar":
                    player.SoundLocation = (string)ENHITS.Rows[8]["baihat"];
                    break;

                case "Make you mine":
                    player.SoundLocation = (string)ENHITS.Rows[9]["baihat"];
                    break;
            }
            player.Play();
        }

        private void panel_list_10_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox27.BackgroundImage;
            label_songname.Text = label_list_37.Text;
            label_songartist.Text = label_list_38.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;

            switch (label_songname.Text)
            {
                case "NGTANOISE":
                    player.SoundLocation = (string)VIRALHITS.Rows[0]["baihat"];
                    break;

                case "QUERRY":
                    player.SoundLocation = (string)VIRALHITS.Rows[1]["baihat"];
                    break;

                case "TAYTO":
                    player.SoundLocation = (string)VIRALHITS.Rows[2]["baihat"];
                    break;

                case "THICHTHICH":
                    player.SoundLocation = (string)VIRALHITS.Rows[3]["baihat"];
                    break;

                case "tiny love":
                    player.SoundLocation = (string)VIRALHITS.Rows[4]["baihat"];
                    break;

                case "My House":
                    player.SoundLocation = (string)VIRALHITS.Rows[5]["baihat"];
                    break;

                case "New Genesis":
                    player.SoundLocation = (string)VIRALHITS.Rows[6]["baihat"];
                    break;

                case "Sorry":
                    player.SoundLocation = (string)VIRALHITS.Rows[7]["baihat"];
                    break;

                case "Sunflower":
                    player.SoundLocation = (string)VIRALHITS.Rows[8]["baihat"];
                    break;

                case "There for you":
                    player.SoundLocation = (string)VIRALHITS.Rows[9]["baihat"];
                    break;


                case "25":
                    player.SoundLocation = (string)VNHITS.Rows[0]["baihat"];
                    break;

                case "3107":
                    player.SoundLocation = (string)VNHITS.Rows[1]["baihat"];
                    break;

                case "AI BIET":
                    player.SoundLocation = (string)VNHITS.Rows[2]["baihat"];
                    break;

                case "CHIM SAU":
                    player.SoundLocation = (string)VNHITS.Rows[3]["baihat"];
                    break;

                case "CUA":
                    player.SoundLocation = (string)VNHITS.Rows[4]["baihat"];
                    break;

                case "GIAYPHUT":
                    player.SoundLocation = (string)VNHITS.Rows[5]["baihat"];
                    break;

                case "GU":
                    player.SoundLocation = (string)VNHITS.Rows[6]["baihat"];
                    break;

                case "HOLD MY HAND":
                    player.SoundLocation = (string)VNHITS.Rows[7]["baihat"];
                    break;

                case "ICEMAN":
                    player.SoundLocation = (string)VNHITS.Rows[8]["baihat"];
                    break;

                case "LOCHI":
                    player.SoundLocation = (string)VNHITS.Rows[9]["baihat"];
                    break;

                case "All We Know":
                    player.SoundLocation = (string)ENHITS.Rows[0]["baihat"];
                    break;

                case "Bad Habits":
                    player.SoundLocation = (string)ENHITS.Rows[1]["baihat"];
                    break;

                case "Better Now":
                    player.SoundLocation = (string)ENHITS.Rows[2]["baihat"];
                    break;

                case "Cake By The Ocean":
                    player.SoundLocation = (string)ENHITS.Rows[3]["baihat"];
                    break;

                case "Comedy":
                    player.SoundLocation = (string)ENHITS.Rows[4]["baihat"];
                    break;

                case "Hello":
                    player.SoundLocation = (string)ENHITS.Rows[5]["baihat"];
                    break;

                case "Hero":
                    player.SoundLocation = (string)ENHITS.Rows[6]["baihat"];
                    break;

                case "Immortals":
                    player.SoundLocation = (string)ENHITS.Rows[7]["baihat"];
                    break;

                case "Liar":
                    player.SoundLocation = (string)ENHITS.Rows[8]["baihat"];
                    break;

                case "Make you mine":
                    player.SoundLocation = (string)ENHITS.Rows[9]["baihat"];
                    break;
            }
            player.Play();
        }

        private void panel_list_1_MouseMove(object sender, MouseEventArgs e)
        {
            panel_list_1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel_list_1_MouseLeave(object sender, EventArgs e)
        {
            panel_list_1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel_list_2_MouseLeave(object sender, EventArgs e)
        {
            panel_list_2.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel_list_2_MouseMove(object sender, MouseEventArgs e)
        {
            panel_list_2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel_list_3_MouseMove(object sender, MouseEventArgs e)
        {
            panel_list_3.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel_list_3_MouseLeave(object sender, EventArgs e)
        {
            panel_list_3.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel_list_4_MouseMove(object sender, MouseEventArgs e)
        {
            panel_list_4.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel_list_4_MouseLeave(object sender, EventArgs e)
        {
            panel_list_4.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel_list_5_MouseMove(object sender, MouseEventArgs e)
        {
            panel_list_5.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel_list_5_MouseLeave(object sender, EventArgs e)
        {
            panel_list_5.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel_list_6_MouseMove(object sender, MouseEventArgs e)
        {
            panel_list_6.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel_list_6_MouseLeave(object sender, EventArgs e)
        {
            panel_list_6.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel_list_7_MouseMove(object sender, MouseEventArgs e)
        {
            panel_list_7.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel_list_7_MouseLeave(object sender, EventArgs e)
        {
            panel_list_7.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel_list_8_MouseMove(object sender, MouseEventArgs e)
        {
            panel_list_8.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel_list_8_MouseLeave(object sender, EventArgs e)
        {
            panel_list_8.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel_list_9_MouseMove(object sender, MouseEventArgs e)
        {
            panel_list_9.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel_list_9_MouseLeave(object sender, EventArgs e)
        {
            panel_list_9.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel_list_10_MouseMove(object sender, MouseEventArgs e)
        {
            panel_list_10.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel_list_10_MouseLeave(object sender, EventArgs e)
        {
            panel_list_10.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel_like_1_MouseMove(object sender, MouseEventArgs e)
        {
            panel_like_1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel_like_1_MouseLeave(object sender, EventArgs e)
        {
            panel_like_1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel_like_2_MouseMove(object sender, MouseEventArgs e)
        {
            panel_like_2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel_like_2_MouseLeave(object sender, EventArgs e)
        {
            panel_like_2.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel_like_3_MouseMove(object sender, MouseEventArgs e)
        {
            panel_like_3.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel_like_3_MouseLeave(object sender, EventArgs e)
        {
            panel_like_3.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel_like_4_MouseMove(object sender, MouseEventArgs e)
        {
            panel_like_4.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel_like_4_MouseLeave(object sender, EventArgs e)
        {
            panel_like_4.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel_like_5_MouseMove(object sender, MouseEventArgs e)
        {
            panel_like_5.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel_like_5_MouseLeave(object sender, EventArgs e)
        {
            panel_like_5.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel_like_6_MouseMove(object sender, MouseEventArgs e)
        {
            panel_like_6.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel_like_6_MouseLeave(object sender, EventArgs e)
        {
            panel_like_6.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel_like_7_MouseMove(object sender, MouseEventArgs e)
        {
            panel_like_7.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel_like_7_MouseLeave(object sender, EventArgs e)
        {
            panel_like_7.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel_like_8_MouseMove(object sender, MouseEventArgs e)
        {
            panel_like_8.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel_like_8_MouseLeave(object sender, EventArgs e)
        {
            panel_like_8.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel_like_9_MouseMove(object sender, MouseEventArgs e)
        {
            panel_like_9.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel_like_9_MouseLeave(object sender, EventArgs e)
        {
            panel_like_9.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel_like_10_MouseMove(object sender, MouseEventArgs e)
        {
            panel_like_10.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel_like_10_MouseLeave(object sender, EventArgs e)
        {
            panel_like_10.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            pictureBox_play_Click(sender, e);
        }

        private void pictureBox_search_Click(object sender, EventArgs e)
        {
            switch(comboBox1.Text.ToLower().Replace(" ",""))
            {
                case "ngtanoise":
                    pictureBox_song.BackgroundImage = (Image)VIRALHITS.Rows[0]["hinhanh"];
                    label_songname.Text = VIRALHITS.Rows[0]["tenbaihat"].ToString();
                    label_songartist.Text = VIRALHITS.Rows[0]["tencasi"].ToString();
                    player.SoundLocation = (string)VIRALHITS.Rows[0]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "minhminh":
                    pictureBox_song.BackgroundImage = (Image)VIRALHITS.Rows[0]["hinhanh"];
                    label_songname.Text = VIRALHITS.Rows[0]["tenbaihat"].ToString();
                    label_songartist.Text = VIRALHITS.Rows[0]["tencasi"].ToString();
                    player.SoundLocation = (string)VIRALHITS.Rows[0]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "querry":
                    pictureBox_song.BackgroundImage = (Image)VIRALHITS.Rows[1]["hinhanh"];
                    label_songname.Text = VIRALHITS.Rows[1]["tenbaihat"].ToString();
                    label_songartist.Text = VIRALHITS.Rows[1]["tencasi"].ToString();
                    player.SoundLocation = (string)VIRALHITS.Rows[1]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "congphupong":
                    pictureBox_song.BackgroundImage = (Image)VIRALHITS.Rows[1]["hinhanh"];
                    label_songname.Text = VIRALHITS.Rows[1]["tenbaihat"].ToString();
                    label_songartist.Text = VIRALHITS.Rows[1]["tencasi"].ToString();
                    player.SoundLocation = (string)VIRALHITS.Rows[1]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "tayto":
                    pictureBox_song.BackgroundImage = (Image)VIRALHITS.Rows[2]["hinhanh"];
                    label_songname.Text = VIRALHITS.Rows[2]["tenbaihat"].ToString();
                    label_songartist.Text = VIRALHITS.Rows[2]["tencasi"].ToString();
                    player.SoundLocation = (string)VIRALHITS.Rows[2]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "congphuong":
                    pictureBox_song.BackgroundImage = (Image)VIRALHITS.Rows[2]["hinhanh"];
                    label_songname.Text = VIRALHITS.Rows[2]["tenbaihat"].ToString();
                    label_songartist.Text = VIRALHITS.Rows[2]["tencasi"].ToString();
                    player.SoundLocation = (string)VIRALHITS.Rows[2]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "thichthich":
                    pictureBox_song.BackgroundImage = (Image)VIRALHITS.Rows[3]["hinhanh"];
                    label_songname.Text = VIRALHITS.Rows[3]["tenbaihat"].ToString();
                    label_songartist.Text = VIRALHITS.Rows[3]["tencasi"].ToString();
                    player.SoundLocation = (string)VIRALHITS.Rows[3]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "quyenphuong":
                    pictureBox_song.BackgroundImage = (Image)VIRALHITS.Rows[3]["hinhanh"];
                    label_songname.Text = VIRALHITS.Rows[3]["tenbaihat"].ToString();
                    label_songartist.Text = VIRALHITS.Rows[3]["tencasi"].ToString();
                    player.SoundLocation = (string)VIRALHITS.Rows[3]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "tinylove":
                    pictureBox_song.BackgroundImage = (Image)VIRALHITS.Rows[4]["hinhanh"];
                    label_songname.Text = VIRALHITS.Rows[4]["tenbaihat"].ToString();
                    label_songartist.Text = VIRALHITS.Rows[4]["tencasi"].ToString();
                    player.SoundLocation = (string)VIRALHITS.Rows[4]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "thịnhsuy":
                    pictureBox_song.BackgroundImage = (Image)VIRALHITS.Rows[4]["hinhanh"];
                    label_songname.Text = VIRALHITS.Rows[4]["tenbaihat"].ToString();
                    label_songartist.Text = VIRALHITS.Rows[4]["tencasi"].ToString();
                    player.SoundLocation = (string)VIRALHITS.Rows[4]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "myhouse":
                    pictureBox_song.BackgroundImage = (Image)VIRALHITS.Rows[5]["hinhanh"];
                    label_songname.Text = VIRALHITS.Rows[5]["tenbaihat"].ToString();
                    label_songartist.Text = VIRALHITS.Rows[5]["tencasi"].ToString();
                    player.SoundLocation = (string)VIRALHITS.Rows[5]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "florida":
                    pictureBox_song.BackgroundImage = (Image)VIRALHITS.Rows[5]["hinhanh"];
                    label_songname.Text = VIRALHITS.Rows[5]["tenbaihat"].ToString();
                    label_songartist.Text = VIRALHITS.Rows[5]["tencasi"].ToString();
                    player.SoundLocation = (string)VIRALHITS.Rows[5]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "newgenesis":
                    pictureBox_song.BackgroundImage = (Image)VIRALHITS.Rows[6]["hinhanh"];
                    label_songname.Text = VIRALHITS.Rows[6]["tenbaihat"].ToString();
                    label_songartist.Text = VIRALHITS.Rows[6]["tencasi"].ToString();
                    player.SoundLocation = (string)VIRALHITS.Rows[6]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "tokuda":
                    pictureBox_song.BackgroundImage = (Image)VIRALHITS.Rows[6]["hinhanh"];
                    label_songname.Text = VIRALHITS.Rows[6]["tenbaihat"].ToString();
                    label_songartist.Text = VIRALHITS.Rows[6]["tencasi"].ToString();
                    player.SoundLocation = (string)VIRALHITS.Rows[6]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "sorry":
                    pictureBox_song.BackgroundImage = (Image)VIRALHITS.Rows[7]["hinhanh"];
                    label_songname.Text = VIRALHITS.Rows[7]["tenbaihat"].ToString();
                    label_songartist.Text = VIRALHITS.Rows[7]["tencasi"].ToString();
                    player.SoundLocation = (string)VIRALHITS.Rows[7]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "hashley":
                    pictureBox_song.BackgroundImage = (Image)VIRALHITS.Rows[7]["hinhanh"];
                    label_songname.Text = VIRALHITS.Rows[7]["tenbaihat"].ToString();
                    label_songartist.Text = VIRALHITS.Rows[7]["tencasi"].ToString();
                    player.SoundLocation = (string)VIRALHITS.Rows[7]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "sunflower":
                    pictureBox_song.BackgroundImage = (Image)VIRALHITS.Rows[8]["hinhanh"];
                    label_songname.Text = VIRALHITS.Rows[8]["tenbaihat"].ToString();
                    label_songartist.Text = VIRALHITS.Rows[8]["tencasi"].ToString();
                    player.SoundLocation = (string)VIRALHITS.Rows[8]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "perry":
                    pictureBox_song.BackgroundImage = (Image)VIRALHITS.Rows[8]["hinhanh"];
                    label_songname.Text = VIRALHITS.Rows[8]["tenbaihat"].ToString();
                    label_songartist.Text = VIRALHITS.Rows[8]["tencasi"].ToString();
                    player.SoundLocation = (string)VIRALHITS.Rows[8]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "thereforyou":
                    pictureBox_song.BackgroundImage = (Image)VIRALHITS.Rows[9]["hinhanh"];
                    label_songname.Text = VIRALHITS.Rows[9]["tenbaihat"].ToString();
                    label_songartist.Text = VIRALHITS.Rows[9]["tencasi"].ToString();
                    player.SoundLocation = (string)VIRALHITS.Rows[9]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "hihi":
                    pictureBox_song.BackgroundImage = (Image)VIRALHITS.Rows[9]["hinhanh"];
                    label_songname.Text = VIRALHITS.Rows[9]["tenbaihat"].ToString();
                    label_songartist.Text = VIRALHITS.Rows[9]["tencasi"].ToString();
                    player.SoundLocation = (string)VIRALHITS.Rows[9]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "25":
                    pictureBox_song.BackgroundImage = (Image)VNHITS.Rows[0]["hinhanh"];
                    label_songname.Text = VNHITS.Rows[0]["tenbaihat"].ToString();
                    label_songartist.Text = VNHITS.Rows[0]["tencasi"].ToString();
                    player.SoundLocation = (string)VNHITS.Rows[0]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;


                case "bray":
                    pictureBox_song.BackgroundImage = (Image)VNHITS.Rows[0]["hinhanh"];
                    label_songname.Text = VNHITS.Rows[0]["tenbaihat"].ToString();
                    label_songartist.Text = VNHITS.Rows[0]["tencasi"].ToString();
                    player.SoundLocation = (string)VNHITS.Rows[0]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "3107":
                    pictureBox_song.BackgroundImage = (Image)VNHITS.Rows[1]["hinhanh"];
                    label_songname.Text = VNHITS.Rows[1]["tenbaihat"].ToString();
                    label_songartist.Text = VNHITS.Rows[1]["tencasi"].ToString();
                    player.SoundLocation = (string)VNHITS.Rows[1]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;


                case "w/n":
                    pictureBox_song.BackgroundImage = (Image)VNHITS.Rows[1]["hinhanh"];
                    label_songname.Text = VNHITS.Rows[1]["tenbaihat"].ToString();
                    label_songartist.Text = VNHITS.Rows[1]["tencasi"].ToString();
                    player.SoundLocation = (string)VNHITS.Rows[1]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "aibiet":
                    pictureBox_song.BackgroundImage = (Image)VNHITS.Rows[2]["hinhanh"];
                    label_songname.Text = VNHITS.Rows[2]["tenbaihat"].ToString();
                    label_songartist.Text = VNHITS.Rows[2]["tencasi"].ToString();
                    player.SoundLocation = (string)VNHITS.Rows[2]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "naomi":
                    pictureBox_song.BackgroundImage = (Image)VNHITS.Rows[2]["hinhanh"];
                    label_songname.Text = VNHITS.Rows[2]["tenbaihat"].ToString();
                    label_songartist.Text = VNHITS.Rows[2]["tencasi"].ToString();
                    player.SoundLocation = (string)VNHITS.Rows[2]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "chimsau":
                    pictureBox_song.BackgroundImage = (Image)VNHITS.Rows[3]["hinhanh"];
                    label_songname.Text = VNHITS.Rows[3]["tenbaihat"].ToString();
                    label_songartist.Text = VNHITS.Rows[3]["tencasi"].ToString();
                    player.SoundLocation = (string)VNHITS.Rows[3]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "hoangton":
                    pictureBox_song.BackgroundImage = (Image)VNHITS.Rows[3]["hinhanh"];
                    label_songname.Text = VNHITS.Rows[3]["tenbaihat"].ToString();
                    label_songartist.Text = VNHITS.Rows[3]["tencasi"].ToString();
                    player.SoundLocation = (string)VNHITS.Rows[3]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "cua":
                    pictureBox_song.BackgroundImage = (Image)VNHITS.Rows[4]["hinhanh"];
                    label_songname.Text = VNHITS.Rows[4]["tenbaihat"].ToString();
                    label_songartist.Text = VNHITS.Rows[4]["tencasi"].ToString();
                    player.SoundLocation = (string)VNHITS.Rows[4]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "gernang":
                    pictureBox_song.BackgroundImage = (Image)VNHITS.Rows[4]["hinhanh"];
                    label_songname.Text = VNHITS.Rows[4]["tenbaihat"].ToString();
                    label_songartist.Text = VNHITS.Rows[4]["tencasi"].ToString();
                    player.SoundLocation = (string)VNHITS.Rows[4]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "giayphut":
                    pictureBox_song.BackgroundImage = (Image)VNHITS.Rows[5]["hinhanh"];
                    label_songname.Text = VNHITS.Rows[5]["tenbaihat"].ToString();
                    label_songartist.Text = VNHITS.Rows[5]["tencasi"].ToString();
                    player.SoundLocation = (string)VNHITS.Rows[5]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "caovantung":
                    pictureBox_song.BackgroundImage = (Image)VNHITS.Rows[5]["hinhanh"];
                    label_songname.Text = VNHITS.Rows[5]["tenbaihat"].ToString();
                    label_songartist.Text = VNHITS.Rows[5]["tencasi"].ToString();
                    player.SoundLocation = (string)VNHITS.Rows[5]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "gu":
                    pictureBox_song.BackgroundImage = (Image)VNHITS.Rows[6]["hinhanh"];
                    label_songname.Text = VNHITS.Rows[6]["tenbaihat"].ToString();
                    label_songartist.Text = VNHITS.Rows[6]["tencasi"].ToString();
                    player.SoundLocation = (string)VNHITS.Rows[6]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "seachains":
                    pictureBox_song.BackgroundImage = (Image)VNHITS.Rows[6]["hinhanh"];
                    label_songname.Text = VNHITS.Rows[6]["tenbaihat"].ToString();
                    label_songartist.Text = VNHITS.Rows[6]["tencasi"].ToString();
                    player.SoundLocation = (string)VNHITS.Rows[6]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "holdmyhand":
                    pictureBox_song.BackgroundImage = (Image)VNHITS.Rows[7]["hinhanh"];
                    label_songname.Text = VNHITS.Rows[7]["tenbaihat"].ToString();
                    label_songartist.Text = VNHITS.Rows[7]["tencasi"].ToString();
                    player.SoundLocation = (string)VNHITS.Rows[7]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "tdy":
                    pictureBox_song.BackgroundImage = (Image)VNHITS.Rows[7]["hinhanh"];
                    label_songname.Text = VNHITS.Rows[7]["tenbaihat"].ToString();
                    label_songartist.Text = VNHITS.Rows[7]["tencasi"].ToString();
                    player.SoundLocation = (string)VNHITS.Rows[7]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "iceman":
                    pictureBox_song.BackgroundImage = (Image)VNHITS.Rows[8]["hinhanh"];
                    label_songname.Text = VNHITS.Rows[8]["tenbaihat"].ToString();
                    label_songartist.Text = VNHITS.Rows[8]["tencasi"].ToString();
                    player.SoundLocation = (string)VNHITS.Rows[8]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "binz":
                    pictureBox_song.BackgroundImage = (Image)VNHITS.Rows[8]["hinhanh"];
                    label_songname.Text = VNHITS.Rows[8]["tenbaihat"].ToString();
                    label_songartist.Text = VNHITS.Rows[8]["tencasi"].ToString();
                    player.SoundLocation = (string)VNHITS.Rows[8]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "lochi":
                    pictureBox_song.BackgroundImage = (Image)VNHITS.Rows[9]["hinhanh"];
                    label_songname.Text = VNHITS.Rows[9]["tenbaihat"].ToString();
                    label_songartist.Text = VNHITS.Rows[9]["tencasi"].ToString();
                    player.SoundLocation = (string)VNHITS.Rows[9]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "lowg":
                    pictureBox_song.BackgroundImage = (Image)VNHITS.Rows[9]["hinhanh"];
                    label_songname.Text = VNHITS.Rows[9]["tenbaihat"].ToString();
                    label_songartist.Text = VNHITS.Rows[9]["tencasi"].ToString();
                    player.SoundLocation = (string)VNHITS.Rows[9]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "allweknow":
                    pictureBox_song.BackgroundImage = (Image)ENHITS.Rows[0]["hinhanh"];
                    label_songname.Text = ENHITS.Rows[0]["tenbaihat"].ToString();
                    label_songartist.Text = ENHITS.Rows[0]["tencasi"].ToString();
                    player.SoundLocation = (string)ENHITS.Rows[0]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "desar":
                    pictureBox_song.BackgroundImage = (Image)ENHITS.Rows[0]["hinhanh"];
                    label_songname.Text = ENHITS.Rows[0]["tenbaihat"].ToString();
                    label_songartist.Text = ENHITS.Rows[0]["tencasi"].ToString();
                    player.SoundLocation = (string)ENHITS.Rows[0]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "badhabits":
                    pictureBox_song.BackgroundImage = (Image)ENHITS.Rows[1]["hinhanh"];
                    label_songname.Text = ENHITS.Rows[1]["tenbaihat"].ToString();
                    label_songartist.Text = ENHITS.Rows[1]["tencasi"].ToString();
                    player.SoundLocation = (string)ENHITS.Rows[1]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "taylor":
                    pictureBox_song.BackgroundImage = (Image)ENHITS.Rows[1]["hinhanh"];
                    label_songname.Text = ENHITS.Rows[1]["tenbaihat"].ToString();
                    label_songartist.Text = ENHITS.Rows[1]["tencasi"].ToString();
                    player.SoundLocation = (string)ENHITS.Rows[1]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "betternow":
                    pictureBox_song.BackgroundImage = (Image)ENHITS.Rows[2]["hinhanh"];
                    label_songname.Text = ENHITS.Rows[2]["tenbaihat"].ToString();
                    label_songartist.Text = ENHITS.Rows[2]["tencasi"].ToString();
                    player.SoundLocation = (string)ENHITS.Rows[2]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "qnt":
                    pictureBox_song.BackgroundImage = (Image)ENHITS.Rows[2]["hinhanh"];
                    label_songname.Text = ENHITS.Rows[2]["tenbaihat"].ToString();
                    label_songartist.Text = ENHITS.Rows[2]["tencasi"].ToString();
                    player.SoundLocation = (string)ENHITS.Rows[2]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "cakebytheocean":
                    pictureBox_song.BackgroundImage = (Image)ENHITS.Rows[3]["hinhanh"];
                    label_songname.Text = ENHITS.Rows[3]["tenbaihat"].ToString();
                    label_songartist.Text = ENHITS.Rows[3]["tencasi"].ToString();
                    player.SoundLocation = (string)ENHITS.Rows[3]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "wehit":
                    pictureBox_song.BackgroundImage = (Image)ENHITS.Rows[3]["hinhanh"];
                    label_songname.Text = ENHITS.Rows[3]["tenbaihat"].ToString();
                    label_songartist.Text = ENHITS.Rows[3]["tencasi"].ToString();
                    player.SoundLocation = (string)ENHITS.Rows[3]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "comedy":
                    pictureBox_song.BackgroundImage = (Image)ENHITS.Rows[4]["hinhanh"];
                    label_songname.Text = ENHITS.Rows[4]["tenbaihat"].ToString();
                    label_songartist.Text = ENHITS.Rows[4]["tencasi"].ToString();
                    player.SoundLocation = (string)ENHITS.Rows[4]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "y2mate":
                    pictureBox_song.BackgroundImage = (Image)ENHITS.Rows[4]["hinhanh"];
                    label_songname.Text = ENHITS.Rows[4]["tenbaihat"].ToString();
                    label_songartist.Text = ENHITS.Rows[4]["tencasi"].ToString();
                    player.SoundLocation = (string)ENHITS.Rows[4]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "hello":
                    pictureBox_song.BackgroundImage = (Image)ENHITS.Rows[5]["hinhanh"];
                    label_songname.Text = ENHITS.Rows[5]["tenbaihat"].ToString();
                    label_songartist.Text = ENHITS.Rows[5]["tencasi"].ToString();
                    player.SoundLocation = (string)ENHITS.Rows[5]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "hover":
                    pictureBox_song.BackgroundImage = (Image)ENHITS.Rows[5]["hinhanh"];
                    label_songname.Text = ENHITS.Rows[5]["tenbaihat"].ToString();
                    label_songartist.Text = ENHITS.Rows[5]["tencasi"].ToString();
                    player.SoundLocation = (string)ENHITS.Rows[5]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;


                case "hero":
                    pictureBox_song.BackgroundImage = (Image)ENHITS.Rows[6]["hinhanh"];
                    label_songname.Text = ENHITS.Rows[6]["tenbaihat"].ToString();
                    label_songartist.Text = ENHITS.Rows[6]["tencasi"].ToString();
                    player.SoundLocation = (string)ENHITS.Rows[6]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "yuumi":
                    pictureBox_song.BackgroundImage = (Image)ENHITS.Rows[6]["hinhanh"];
                    label_songname.Text = ENHITS.Rows[6]["tenbaihat"].ToString();
                    label_songartist.Text = ENHITS.Rows[6]["tencasi"].ToString();
                    player.SoundLocation = (string)ENHITS.Rows[6]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;


                case "immortals":
                    pictureBox_song.BackgroundImage = (Image)ENHITS.Rows[7]["hinhanh"];
                    label_songname.Text = ENHITS.Rows[7]["tenbaihat"].ToString();
                    label_songartist.Text = ENHITS.Rows[7]["tencasi"].ToString();
                    player.SoundLocation = (string)ENHITS.Rows[7]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;


                case "panter":
                    pictureBox_song.BackgroundImage = (Image)ENHITS.Rows[7]["hinhanh"];
                    label_songname.Text = ENHITS.Rows[7]["tenbaihat"].ToString();
                    label_songartist.Text = ENHITS.Rows[7]["tencasi"].ToString();
                    player.SoundLocation = (string)ENHITS.Rows[7]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "liar":
                    pictureBox_song.BackgroundImage = (Image)ENHITS.Rows[8]["hinhanh"];
                    label_songname.Text = ENHITS.Rows[8]["tenbaihat"].ToString();
                    label_songartist.Text = ENHITS.Rows[8]["tencasi"].ToString();
                    player.SoundLocation = (string)ENHITS.Rows[8]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "555":
                    pictureBox_song.BackgroundImage = (Image)ENHITS.Rows[8]["hinhanh"];
                    label_songname.Text = ENHITS.Rows[8]["tenbaihat"].ToString();
                    label_songartist.Text = ENHITS.Rows[8]["tencasi"].ToString();
                    player.SoundLocation = (string)ENHITS.Rows[8]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "makeyoumine":
                    pictureBox_song.BackgroundImage = (Image)ENHITS.Rows[9]["hinhanh"];
                    label_songname.Text = ENHITS.Rows[9]["tenbaihat"].ToString();
                    label_songartist.Text = ENHITS.Rows[9]["tencasi"].ToString();
                    player.SoundLocation = (string)ENHITS.Rows[9]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;

                case "qoqo":
                    pictureBox_song.BackgroundImage = (Image)ENHITS.Rows[9]["hinhanh"];
                    label_songname.Text = ENHITS.Rows[9]["tenbaihat"].ToString();
                    label_songartist.Text = ENHITS.Rows[9]["tencasi"].ToString();
                    player.SoundLocation = (string)ENHITS.Rows[9]["baihat"];
                    pictureBox_play.BackgroundImage = Properties.Resources.stop;
                    player.Play();
                    break;
                default:
                    MessageBox.Show("Cant find your song","Notice !",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    break;
            }
            player.Play();
        }

        private void label_songname_TextChanged(object sender, EventArgs e)
        {
            label_his_name.Text += (label_songname.Text + "\r\n");
            label_his_time.Text += (DateTime.Now.ToString() + "\r\n");
        }

        private void pictureBox_history_Click(object sender, EventArgs e)
        {
            panel_history.Visible = true;
            panel_share.Visible = false;
        }

        private void panel_history_Click(object sender, EventArgs e)
        {
            panel_history.Visible = false;
        }

        private void pictureBox_share_Click(object sender, EventArgs e)
        {
            panel_share.Visible = true;
            panel_history.Visible = false;
            label_share_name.Text = label_songname.Text;
            label_share_artist.Text = label_songartist.Text;
            pictureBox_share_share.BackgroundImage = pictureBox_song.BackgroundImage;

            switch (label_songname.Text)
            {
                case "NGTANOISE":
                    textBox3.Text = "https://www.youtube.com/watch?v=fATWCKdQrTI&ab_channel=Vsoul-Topic";
                    break;

                case "QUERRY":
                    textBox3.Text = "https://www.youtube.com/watch?v=7PxxZWrlRTc&ab_channel=QNT";
                    break;

                case "TAYTO":
                    textBox3.Text = "https://www.youtube.com/watch?v=cKBRHaPdjbc&ab_channel=RapitalOfficial";
                    break;

                case "THICHTHICH":
                    textBox3.Text = "https://www.youtube.com/watch?v=OqdA6DKV1Fs&ab_channel=PhuongLyOfficial";
                    break;

                case "tiny love":
                    textBox3.Text = "https://www.youtube.com/watch?v=Z7tiB0xMrZg&ab_channel=ThịnhSuy";
                    break;

                case "My House":
                    textBox3.Text = "https://www.youtube.com/watch?v=uo35R9zQsAI&ab_channel=FloRida";
                    break;

                case "New Genesis":
                    textBox3.Text = "https://www.youtube.com/watch?v=IPaSD4sQOkg&ab_channel=CrunchyrollCollection";
                    break;

                case "Sorry":
                    textBox3.Text = "https://www.youtube.com/watch?v=fRh_vgS2dFE&ab_channel=JustinBieberVEVO";
                    break;

                case "Sunflower":
                    textBox3.Text = "https://www.youtube.com/watch?v=ApXoWvfEYVU&ab_channel=PostMaloneVEVO";
                    break;

                case "There for you":
                    textBox3.Text = "https://www.youtube.com/watch?v=pNNMr5glICM&ab_channel=MartinGarrix";
                    break;


                case "25":
                    textBox3.Text = "https://www.youtube.com/watch?v=FPtITmtjWhQ&ab_channel=ROYRecords";
                    break;

                case "3107":
                    textBox3.Text = "https://www.youtube.com/watch?v=V5GS5ANG96M&ab_channel=W%2Fn";
                    break;

                case "AI BIET":
                    textBox3.Text = "https://www.youtube.com/watch?v=n8poPC4Vu_E&ab_channel=WEAN";
                    break;

                case "CHIM SAU":
                    textBox3.Text = "https://www.youtube.com/watch?v=KFz_v5zDKuw&ab_channel=SonyTranOfficial";
                    break;

                case "CUA":
                    textBox3.Text = "https://www.youtube.com/watch?v=P8qEusQiwsw&ab_channel=HIEUTHUHAI";
                    break;

                case "GIAYPHUT":
                    textBox3.Text = "https://www.youtube.com/watch?v=lwZ6mRpD62o&ab_channel=kidsai";
                    break;

                case "GU":
                    textBox3.Text = "https://www.youtube.com/watch?v=VI47bTJaMe4&ab_channel=CUKAK";
                    break;

                case "HOLD MY HAND":
                    textBox3.Text = "https://www.youtube.com/watch?v=6Cs3Bn121yw&ab_channel=PollOfficial";
                    break;

                case "ICEMAN":
                    textBox3.Text = "https://www.youtube.com/watch?v=A_CXiUlIJdA&ab_channel=Sol7-Topic";
                    break;

                case "LOCHI":
                    textBox3.Text = "https://www.youtube.com/watch?v=o5Pad_ge4KE&ab_channel=FSRio";
                    break;

                case "All We Know":
                    textBox3.Text = "https://www.youtube.com/watch?v=lEi_XBg2Fpk&ab_channel=ChainsmokersVEVO";
                    break;

                case "Bad Habits":
                    textBox3.Text = "https://www.youtube.com/watch?v=orJSJGHjBLI&ab_channel=EdSheeran";
                    break;

                case "Better Now":
                    textBox3.Text = "https://www.youtube.com/watch?v=UYwF-jdcVjY&ab_channel=PostMaloneVEVO";
                    break;

                case "Cake By The Ocean":
                    textBox3.Text = "https://www.youtube.com/watch?v=vWaRiD5ym74&ab_channel=DNCEVEVO";
                    break;

                case "Comedy":
                    textBox3.Text = "https://www.youtube.com/watch?v=G3qQtf7jahE&ab_channel=mysticholy";
                    break;

                case "Hello":
                    textBox3.Text = "https://www.youtube.com/watch?v=YQHsXMglC9A&ab_channel=AdeleVEVO";
                    break;

                case "Hero":
                    textBox3.Text = "https://www.youtube.com/watch?v=78MlJNezFRo&ab_channel=RachelGardner";
                    break;

                case "Immortals":
                    textBox3.Text = "https://www.youtube.com/watch?v=l9PxOanFjxQ&ab_channel=FallOutBoyVEVO";
                    break;

                case "Liar":
                    textBox3.Text = "https://www.youtube.com/watch?v=KsDZix4ZSlU&ab_channel=CamilaCabelloVEVO";
                    break;

                case "Make you mine":
                    textBox3.Text = "https://www.youtube.com/watch?v=nLnp0tpZ0ok&ab_channel=PUBLICVEVO";
                    break;
            }
        }
        private void button_share_close_Click(object sender, EventArgs e)
        {
            panel_share.Visible = false;
            Clipboard.SetText(textBox3.Text);
            MessageBox.Show("Link copied to your clipboard\r\nEnjoy sharing with your friends", "Link copy succesful !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel_list_3_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox34.BackgroundImage;
            label_songname.Text = label_list_9.Text;
            label_songartist.Text = label_list_10.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;

            switch (label_songname.Text)
            {
                case "NGTANOISE":
                    player.SoundLocation = (string)VIRALHITS.Rows[0]["baihat"];
                    break;

                case "QUERRY":
                    player.SoundLocation = (string)VIRALHITS.Rows[1]["baihat"];
                    break;

                case "TAYTO":
                    player.SoundLocation = (string)VIRALHITS.Rows[2]["baihat"];
                    break;

                case "THICHTHICH":
                    player.SoundLocation = (string)VIRALHITS.Rows[3]["baihat"];
                    break;

                case "tiny love":
                    player.SoundLocation = (string)VIRALHITS.Rows[4]["baihat"];
                    break;

                case "My House":
                    player.SoundLocation = (string)VIRALHITS.Rows[5]["baihat"];
                    break;

                case "New Genesis":
                    player.SoundLocation = (string)VIRALHITS.Rows[6]["baihat"];
                    break;

                case "Sorry":
                    player.SoundLocation = (string)VIRALHITS.Rows[7]["baihat"];
                    break;

                case "Sunflower":
                    player.SoundLocation = (string)VIRALHITS.Rows[8]["baihat"];
                    break;

                case "There for you":
                    player.SoundLocation = (string)VIRALHITS.Rows[9]["baihat"];
                    break;


                case "25":
                    player.SoundLocation = (string)VNHITS.Rows[0]["baihat"];
                    break;

                case "3107":
                    player.SoundLocation = (string)VNHITS.Rows[1]["baihat"];
                    break;

                case "AI BIET":
                    player.SoundLocation = (string)VNHITS.Rows[2]["baihat"];
                    break;

                case "CHIM SAU":
                    player.SoundLocation = (string)VNHITS.Rows[3]["baihat"];
                    break;

                case "CUA":
                    player.SoundLocation = (string)VNHITS.Rows[4]["baihat"];
                    break;

                case "GIAYPHUT":
                    player.SoundLocation = (string)VNHITS.Rows[5]["baihat"];
                    break;

                case "GU":
                    player.SoundLocation = (string)VNHITS.Rows[6]["baihat"];
                    break;

                case "HOLD MY HAND":
                    player.SoundLocation = (string)VNHITS.Rows[7]["baihat"];
                    break;

                case "ICEMAN":
                    player.SoundLocation = (string)VNHITS.Rows[8]["baihat"];
                    break;

                case "LOCHI":
                    player.SoundLocation = (string)VNHITS.Rows[9]["baihat"];
                    break;

                case "All We Know":
                    player.SoundLocation = (string)ENHITS.Rows[0]["baihat"];
                    break;

                case "Bad Habits":
                    player.SoundLocation = (string)ENHITS.Rows[1]["baihat"];
                    break;

                case "Better Now":
                    player.SoundLocation = (string)ENHITS.Rows[2]["baihat"];
                    break;

                case "Cake By The Ocean":
                    player.SoundLocation = (string)ENHITS.Rows[3]["baihat"];
                    break;

                case "Comedy":
                    player.SoundLocation = (string)ENHITS.Rows[4]["baihat"];
                    break;

                case "Hello":
                    player.SoundLocation = (string)ENHITS.Rows[5]["baihat"];
                    break;

                case "Hero":
                    player.SoundLocation = (string)ENHITS.Rows[6]["baihat"];
                    break;

                case "Immortals":
                    player.SoundLocation = (string)ENHITS.Rows[7]["baihat"];
                    break;

                case "Liar":
                    player.SoundLocation = (string)ENHITS.Rows[8]["baihat"];
                    break;

                case "Make you mine":
                    player.SoundLocation = (string)ENHITS.Rows[9]["baihat"];
                    break;
            }
            player.Play();
        }

        private void panel_list_2_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox35.BackgroundImage;
            label_songname.Text = label_list_5.Text;
            label_songartist.Text = label_list_6.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;

            switch (label_songname.Text)
            {
                case "NGTANOISE":
                    player.SoundLocation = (string)VIRALHITS.Rows[0]["baihat"];
                    break;

                case "QUERRY":
                    player.SoundLocation = (string)VIRALHITS.Rows[1]["baihat"];
                    break;

                case "TAYTO":
                    player.SoundLocation = (string)VIRALHITS.Rows[2]["baihat"];
                    break;

                case "THICHTHICH":
                    player.SoundLocation = (string)VIRALHITS.Rows[3]["baihat"];
                    break;

                case "tiny love":
                    player.SoundLocation = (string)VIRALHITS.Rows[4]["baihat"];
                    break;

                case "My House":
                    player.SoundLocation = (string)VIRALHITS.Rows[5]["baihat"];
                    break;

                case "New Genesis":
                    player.SoundLocation = (string)VIRALHITS.Rows[6]["baihat"];
                    break;

                case "Sorry":
                    player.SoundLocation = (string)VIRALHITS.Rows[7]["baihat"];
                    break;

                case "Sunflower":
                    player.SoundLocation = (string)VIRALHITS.Rows[8]["baihat"];
                    break;

                case "There for you":
                    player.SoundLocation = (string)VIRALHITS.Rows[9]["baihat"];
                    break;


                case "25":
                    player.SoundLocation = (string)VNHITS.Rows[0]["baihat"];
                    break;

                case "3107":
                    player.SoundLocation = (string)VNHITS.Rows[1]["baihat"];
                    break;

                case "AI BIET":
                    player.SoundLocation = (string)VNHITS.Rows[2]["baihat"];
                    break;

                case "CHIM SAU":
                    player.SoundLocation = (string)VNHITS.Rows[3]["baihat"];
                    break;

                case "CUA":
                    player.SoundLocation = (string)VNHITS.Rows[4]["baihat"];
                    break;

                case "GIAYPHUT":
                    player.SoundLocation = (string)VNHITS.Rows[5]["baihat"];
                    break;

                case "GU":
                    player.SoundLocation = (string)VNHITS.Rows[6]["baihat"];
                    break;

                case "HOLD MY HAND":
                    player.SoundLocation = (string)VNHITS.Rows[7]["baihat"];
                    break;

                case "ICEMAN":
                    player.SoundLocation = (string)VNHITS.Rows[8]["baihat"];
                    break;

                case "LOCHI":
                    player.SoundLocation = (string)VNHITS.Rows[9]["baihat"];
                    break;

                case "All We Know":
                    player.SoundLocation = (string)ENHITS.Rows[0]["baihat"];
                    break;

                case "Bad Habits":
                    player.SoundLocation = (string)ENHITS.Rows[1]["baihat"];
                    break;

                case "Better Now":
                    player.SoundLocation = (string)ENHITS.Rows[2]["baihat"];
                    break;

                case "Cake By The Ocean":
                    player.SoundLocation = (string)ENHITS.Rows[3]["baihat"];
                    break;

                case "Comedy":
                    player.SoundLocation = (string)ENHITS.Rows[4]["baihat"];
                    break;

                case "Hello":
                    player.SoundLocation = (string)ENHITS.Rows[5]["baihat"];
                    break;

                case "Hero":
                    player.SoundLocation = (string)ENHITS.Rows[6]["baihat"];
                    break;

                case "Immortals":
                    player.SoundLocation = (string)ENHITS.Rows[7]["baihat"];
                    break;

                case "Liar":
                    player.SoundLocation = (string)ENHITS.Rows[8]["baihat"];
                    break;

                case "Make you mine":
                    player.SoundLocation = (string)ENHITS.Rows[9]["baihat"];
                    break;
            }
            player.Play();
        }
        private void panel_list_1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox36.BackgroundImage;
            label_songname.Text = label_list_1.Text;
            label_songartist.Text = label_list_2.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;

            switch (label_songname.Text)
            {
                case "NGTANOISE":
                    player.SoundLocation = (string)VIRALHITS.Rows[0]["baihat"];
                    break;

                case "QUERRY":
                    player.SoundLocation = (string)VIRALHITS.Rows[1]["baihat"];
                    break;

                case "TAYTO":
                    player.SoundLocation = (string)VIRALHITS.Rows[2]["baihat"];
                    break;

                case "THICHTHICH":
                    player.SoundLocation = (string)VIRALHITS.Rows[3]["baihat"];
                    break;

                case "tiny love":
                    player.SoundLocation = (string)VIRALHITS.Rows[4]["baihat"];
                    break;

                case "My House":
                    player.SoundLocation = (string)VIRALHITS.Rows[5]["baihat"];
                    break;

                case "New Genesis":
                    player.SoundLocation = (string)VIRALHITS.Rows[6]["baihat"];
                    break;

                case "Sorry":
                    player.SoundLocation = (string)VIRALHITS.Rows[7]["baihat"];
                    break;

                case "Sunflower":
                    player.SoundLocation = (string)VIRALHITS.Rows[8]["baihat"];
                    break;

                case "There for you":
                    player.SoundLocation = (string)VIRALHITS.Rows[9]["baihat"];
                    break;


                case "25":
                    player.SoundLocation = (string)VNHITS.Rows[0]["baihat"];
                    break;

                case "3107":
                    player.SoundLocation = (string)VNHITS.Rows[1]["baihat"];
                    break;

                case "AI BIET":
                    player.SoundLocation = (string)VNHITS.Rows[2]["baihat"];
                    break;

                case "CHIM SAU":
                    player.SoundLocation = (string)VNHITS.Rows[3]["baihat"];
                    break;

                case "CUA":
                    player.SoundLocation = (string)VNHITS.Rows[4]["baihat"];
                    break;

                case "GIAYPHUT":
                    player.SoundLocation = (string)VNHITS.Rows[5]["baihat"];
                    break;

                case "GU":
                    player.SoundLocation = (string)VNHITS.Rows[6]["baihat"];
                    break;

                case "HOLD MY HAND":
                    player.SoundLocation = (string)VNHITS.Rows[7]["baihat"];
                    break;

                case "ICEMAN":
                    player.SoundLocation = (string)VNHITS.Rows[8]["baihat"];
                    break;

                case "LOCHI":
                    player.SoundLocation = (string)VNHITS.Rows[9]["baihat"];
                    break;

                case "All We Know":
                    player.SoundLocation = (string)ENHITS.Rows[0]["baihat"];
                    break;

                case "Bad Habits":
                    player.SoundLocation = (string)ENHITS.Rows[1]["baihat"];
                    break;

                case "Better Now":
                    player.SoundLocation = (string)ENHITS.Rows[2]["baihat"];
                    break;

                case "Cake By The Ocean":
                    player.SoundLocation = (string)ENHITS.Rows[3]["baihat"];
                    break;

                case "Comedy":
                    player.SoundLocation = (string)ENHITS.Rows[4]["baihat"];
                    break;

                case "Hello":
                    player.SoundLocation = (string)ENHITS.Rows[5]["baihat"];
                    break;

                case "Hero":
                    player.SoundLocation = (string)ENHITS.Rows[6]["baihat"];
                    break;

                case "Immortals":
                    player.SoundLocation = (string)ENHITS.Rows[7]["baihat"];
                    break;

                case "Liar":
                    player.SoundLocation = (string)ENHITS.Rows[8]["baihat"];
                    break;

                case "Make you mine":
                    player.SoundLocation = (string)ENHITS.Rows[9]["baihat"];
                    break;
            }
            player.Play();
        }

        int j = -1;
        private void button_addlist_Click(object sender, EventArgs e)
        {
            switch (label_songname.Text)
            {
                case "NGTANOISE":
                    PlayList.Rows.Add("VR", Properties.Resources.ngtanoise, 0, "NGTANOISE", "Vsoul", "3:50", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - NGTANOISE - VSOUL.wav", "Giọt nước mắt rớt trên khuôn nhạc\r\nRớt cứ rớt rơi từng hạt\r\nGiọt nước mắt thấm trên tay người\r\nVẫn còn nhớ ai hay cười\r\nĐã từng bước khắp nơi chân trời\r\nNói mãi không vâng lời\r\nVì đã từng hứa sẽ không đau buồn\r\nBước đi qua từng cuộc chơi\r\nVì đã có nhiều lúc chẵng biết phải nói điều gì\r\nVậy thì là giờ hiện bên mình có ai?\r\nSao không ai nói những lời chân thật \r\nvà nhẹ nhàng và chấp nhận nhiều điều đó sai\r\nAnh cảm thấy bản thân này như là\r\n Batman đi tìm màu buồn màu sầu tối đen\r\nNo no no ta không hợp chẵng có điều gì ấm êm\r\nTại sao như vậy?\r\nTại sao che đậy?\r\nNào có ai nghe đâu, nghe đâu, nghe đâu, nghe đâu\r\nĐừng nên âu sầu\r\nTa đã biết bao nhiêu lần buồn và lần sầu\r\n từ ngày nào đã khiến lòng này khó feel\r\nPoppin’ pills biết bao nhiêu lần và thật\r\n nhiều nhưng mà nhiều lần thật sự là khó quên\r\nTrong một phút giây ngày nào đã trao\r\n nhiều thật nhiều những nụ cười thật ấm êm \r\nVà lời nói nào làm lòng này nóng lên\r\nNgười ta cứ nói đừng quá yêu\r\nNgười ta cứ nói đừng quá tin\r\nNgười ta cứ nói đừng quá yêuuuu\r\nNgười ta cứ nói đừng quá tin");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "QUERRY":
                    PlayList.Rows.Add("VR", Properties.Resources.querry, 0, "QUERRY", "QNT, RPT MCK, Trung Trần", "3:31", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - QUERRY - QNT - Trung Trần - RPT MCK.wav", "QNT:\r\nHàng ngày anh vẫn chọn cách dậy sớm, cùng một ly cafe bên đường\r\nLặng nhìn từng đàn chim đang sải cánh bay đi\r\nLựa chọn outfit ra đón ngày mới, tâm hồn ta như lạc vô chốn thiên đường\r\nVà nụ cười của em đẹp như là hoa đó baby\r\nEm đang dạo bước trên con đường dài\r\nAnh không còn thấy ưu phiền trên vai\r\nEm không còn giống trông như thường ngày\r\nKhông ưa lời nói mật ngọt bên tai\r\nSo, baby I love it !\r\nBaby follow me, follow me….\r\nNgọt ngào vị cherry, đôi môi của em tỏa ra mùi hương thú vị\r\nYou sweet like berry nhưng anh vẫn luôn gọi em là baby Jully\r\nNàng đẹp tựa là Kathy anh vẫn thường hay được xem ở trên tivi\r\nNhư Playboy Carti khi bên cạnh anh thì em chẳng cần phải nghĩ suy\r\nQNT:\r\nAnh không cần biết cho dù ngày hay là canh đêm, anh vẫn sống trọn vẹn đến từng giờ\r\nAnh mong được viết cho bạn bè cho cả anh em, nhưng em khiến anh không thể ngừng mơ, về em\r\nNỗi nhớ cứ kéo đến hàng đêm\r\noutside rollin with my gang\r\nNhưng trong tim anh vẫn hướng về em, em, em\r\nI’m in love, love, love\r\nbaby skz skz skz\r\nYou leaving in my mind !\r\nNgoài trời rớt rơi mưa mưa\r\nNhẹ nhàng phất phơ lưa thưa\r\nBaby gotta feel my vibe !!\r\nNgọt ngào vị cherry, đôi môi của em tỏa ra mùi hương thú vị\r\nYou sweet like berry nhưng anh vẫn luôn gọi em là baby Jully\r\nNàng đẹp tựa là Kathy anh vẫn thường hay được xem ở trên tivi\r\nNhư Playboy Carti khi bên cạnh anh thì em chẳng cần phải nghĩ suy\r\nTrung Trần:\r\nVì sao nhờ ? Cứ tình hình này ôi thôi chết dở\r\nAnh như chú cá mắc cạn trên bờ\r\nNghĩ về em lại tức khẩu thành thơ\r\nVà điều đó giúp anh miệt mài hàng giờ\r\nVà mỗi khi em buồn\r\nAnh thức hết đêm muộn\r\nĐể kể cho em\r\nVà vẽ thêm môi em cười\r\nNhư mùa xuân đến\r\nChiều nay em ghé chơi\r\nVà đó là tất cả những điều anh muốn\r\nYeah đó là tất cả những gì anh muốn\r\nMCK:\r\nCó lẽ anh sẽ cho anh thời gian, tận hưởng niềm vui bên em hàng ngày\r\nMặt trời ngủ quên, ánh chiều muộn màng chiếu xuống dưới những tán cây\r\nNgày mai dậy sớm với những giấc mộng tuyệt vời và lồng ngực em sẽ luôn tràn đầy\r\nHận thù khổ đau với ghen tuông gì tầm này !!\r\nNgọt ngào vị cherry đôi môi của em tại sao lại cong thế nhờ\r\nyeah bọn họ tripping nghĩ đến em, nên là lòng dễ mơ\r\nChỉ cần biết là em ở đây, chẳng còn thêm nghi ngờ\r\nĐể vệt son đó nó sẽ đưa anh, tan vào trong từng ý thơ");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "TAYTO":
                    PlayList.Rows.Add("VR", Properties.Resources.tayto, 0, "TAYTO", "RPT MCK, RPT PHONGKHIN", "3:24", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - Tay To - RPT MCK - RPT PhongKhin.wav", "Anh là tay to khá là hay ho nhưng anh lại hay lo\r\nNên phen này gay to\r\nEm lại trông xinh (em ấy look good)\r\nHơi bị thông minh\r\nMà nhìn em lại chất\r\nNhưng em đi một mình\r\nEm muốn quên đi một cuộc tình (quên)\r\nKhông cho tình yêu chơi đùa mình (no)\r\nNhưng mà quá khứ em chìm sâu (chìm sâu)\r\nEm quay cuồng trong ánh đèn màu (đèn màu)\r\nVà em không biết lối ra đâu\r\nChỉ mong ngày dài trôi qua mau\r\nAnh ra chuyện trò đôi ba câu\r\nVì những thứ làm ta đau (anh nói là)\r\nHey girl khi em bước ra đường bước ra đường (yeah)\r\nĐây không phải nước hoa thường mà là Louis V (LV)\r\nUh baby girl em quá ngọt em rất khác bọt\r\nAnh thấy cả Yết Kiêu đang bơi trong đôi mắt em\r\nOk anh lại trằn trọc suốt đêm qua đặt ra một câu hỏi là tại sao tên em không phải là Mẫn Nhi\r\nVà nếu em có thắc mắc về vấn đề đấy thì em có thể đọc ngược nó lại cho anh\r\nTrên thế giới này có hơn 7 tỷ nụ cười\r\nNhưng mà với anh thì nụ cười của em mới là đẹp nhất\r\nThế nên là làm ơn hãy để anh giúp em giữ cái nụ cười của em trên môi\r\nAnh sẽ tán nàng anh sẽ tán nàng yeah\r\nKhông cần cầu kỳ cho dù nhà anh bán vàng nhà anh bán vàng yeah\r\nAnh đưa em đi vi vu dạo phố quanh Hồ Tây táp vào Circle K\r\nNhớ mua thêm nước vào mình ngồi trà đá em châm cho anh phê thuốc lào\r\nTay anh không to (tay anh không to)\r\nKhông như Long Ngơ (oh no)\r\nTay bận say cỏ (anh đang say em nói đi)\r\nTên anh là Phong cơ (Phong Vân)\r\nVì anh cũng chỉ muốn cảm nhận em từng thời gian\r\nNụ cười thật tươi thật nhiều gout thời trang\r\nBaby no flexin' em biết em là ai\r\nVì một ngày nào đó chứ không phải ngày mai\r\nCộng thêm một suất đi ăn Hồ Tây xong rồi cà phê dưới phố\r\nPhiền em make up đi ngay và luôn anh đang chạy đến đấy đón em\r\nMột bông xanh ngát anh đem tặng em anh mong rằng em sẽ tưới nó oh\r\nYeah có thể là em sẽ cảm thấy cái bài hát này nó quá là sến súa quá là hmm alo alo nhưng mà\r\nNếu em dậy sớm buổi sáng em hãy cứ pha cho mình một cốc trà\r\nYeah và bật bài nhạc này lên anh nghĩ là nó sẽ làm cho em vui");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "THICHTHICH":
                    PlayList.Rows.Add("VR", Properties.Resources.thichthich, 0, "THICHTHICH", "Phương Ly", "3:23", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - THICHTHICH - PHƯƠNG LY.wav", "Em không được xinh đẹp, không hay cười duyên\r\nChẳng biết làm sao cho trông thật ngoan hiền như bao cô ngoài kia\r\nEm đây nhìn cứ ngốc ngốc nghếch nghếch\r\nLắm lúc đứng ngắm mình trong gương, cứ thấy choáng váng\r\nNhưng mà anh ơi\r\nEm rất là vâng lời, không la cà ham chơi\r\nEm hồn nhiên, vô tư và yêu đời\r\nNên anh này, mong anh không cười chê\r\nNếu có thấy chán, em sẽ đến hát đàn anh nghe\r\nDẫu sáng, dẫu tối, em sẽ đến bên cạnh anh thôi\r\nAnh sẽ thấy ngoài kia đấy bao cô gái như em\r\nCũng cần tình yêu, cần được hiểu, cần một chút nuông chiều\r\nI don't wanna let you go, 'cause I know I love you so\r\nVì cuộc đời chẳng có gì ý nghĩa khi mà không có anh\r\nAnh sẽ biết điều cần thiết là nắm lấy tay em\r\nVì lúc này đây, em chỉ muốn gần bên anh mỗi ngày\r\nI don't wanna let you go, 'cause I know I love you so\r\nVà thật lòng em chỉ cần anh biết một điều duy nhất là\r\nEm thích anh\r\nThích, thích, thích, thích, ooh-woah-oh\r\nThích, thích, thích, thích, ooh-woah-oh\r\nThích, thích, thích, thích, ooh-woah-hoo\r\n(Và thật lòng em chỉ cần anh biết một điều duy nhất là)\r\nSau bao ngày mong chờ\r\nMong anh lại bên em ta cùng vui, xin anh đừng hững hờ\r\nXa anh một giây thôi, trong lòng em đã thấy nhớ nhớ\r\nChỉ muốn nhấc máy gọi cho anh, nhưng em chẳng dám\r\nVì biết anh có nhớ đến em?\r\n(Just close your eyes)\r\nAnh sẽ thấy ngoài kia đấy bao cô gái như em\r\nCũng cần tình yêu, cần được hiểu, cần một chút nuông chiều\r\nI don't wanna let you go, 'cause I know I love you so\r\nVì cuộc đời chẳng có gì ý nghĩa khi mà không có anh\r\nAnh sẽ biết điều cần thiết là nắm lấy tay em\r\nVì lúc này đây, em chỉ muốn gần bên anh mỗi ngày\r\nI don't wanna let you go, 'cause I know I love you so\r\nVà thật lòng em chỉ cần anh biết một điều duy nhất là\r\nEm thích anh\r\nCó biết trái tim em đang rung rinh lên chỉ vì anh?\r\nNhưng đâu dám nói, chỉ biết hát khúc ca này tặng anh\r\nLiệu anh có thích em không? (Hoh-oh, hoh-uh-oh-hoh)\r\nAnh sẽ thấy ngoài kia đấy bao cô gái như em\r\nCũng cần tình yêu, cần được hiểu, cần một chút nuông chiều\r\nI don't wanna let you go, 'cause I know I love you so\r\nVì cuộc đời chẳng có gì ý nghĩa khi mà không có anh\r\nAnh sẽ biết điều cần thiết là nắm lấy tay em\r\nVì lúc này đây, em chỉ muốn gần bên anh mỗi ngày\r\nI don't wanna let you go, 'cause I know I love you so\r\nVà thật lòng em chỉ cần anh biết một điều duy nhất là\r\nEm thích anh\r\nThích, thích, thích, thích, ooh-woah-oh\r\nThích, thích, thích, thích, ooh-woah-oh\r\nThích, thích, thích, thích, ooh-woah-hoo\r\n(Và thật lòng em chỉ cần anh biết một điều duy nhất là...)");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "tiny love":
                    PlayList.Rows.Add("VR", Properties.Resources.tiny_love, 0, "tiny love", "Thịnh Suy", "3:27", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - tiny love - Thịnh Suy.wav", "Làm lại từ những thứ đơn giản nhất chuyện trò như lúc mới yêu\r\nTình mình như thứ nước hoa phảng phất nồng nàn như bát bún riêu\r\nNày người yêu dấu nếu trong một chốc buồn sầu đeo bám chúng ta\r\nThì đừng vội trách cớ sao tàn khốc vì niềm đau ấy sẽ qua\r\nSẽ qua thôi những u buồn thế gian\r\nTình yêu sẽ cháy nhưng không tro tàn\r\nYou're my ti ti tiny love\r\nBaby you're my ti ti tiny love\r\nYou're my ti ti tiny love\r\nBaby you're my time time timeless love\r\nMột chiều ta đứng kế bên nhìn ngắm cuộc đời như những bức tranh\r\nDạo từng khu phố lúc xưa chìm đắm mà giờ sao thấy mới toanh\r\nĐồng hồ nhanh quá mới đây mà hết đời người như những giấc mơ\r\nLàm gì cho đáng để sau này vết lời mình như những ý thơ\r\nÝ thơ trong những đau buồn thế gian\r\nTình yêu sẽ cháy nhưng không tro tàn\r\nYou're my ti ti tiny love\r\nBaby you're my ti ti tiny love\r\nYou're my ti ti tiny love\r\nBaby you're my time time timeless love\r\nI wanna love you till the end of time\r\nThings gonna change but not my mind\r\nI needed love just like I need you\r\nI love you my tiny tiny baby blue");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "My House":
                    PlayList.Rows.Add("VR", Properties.Resources.my_house, 0, "My House", "Flo Rida", "3:25", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - My House - Flo Rida.wav", "Open up the champagne, pop!\r\nIt's my house, come on, turn it up\r\nHear a knock on the door and the night begins\r\n'Cause we done this before so you come on in\r\nMake yourself at my home, tell me where you been\r\nPour yourself something cold, baby, cheers to this\r\nSometimes you gotta stay in\r\nAnd you know where I live\r\nYeah, you know what we is\r\nSometimes you gotta stay in, in\r\nWelcome to my house\r\nBaby take control now\r\nWe can't even slow down\r\nWe don't like to go out\r\nWelcome to my house\r\nPlay that music too loud\r\nShow me what you do now\r\nWe don't like to go out\r\nWelcome to my house\r\nWelcome to my house\r\nMorning comes and you know that you wanna stay\r\nClose the blinds, let's pretend that the time has changed\r\nKeep our clothes on the floor, open up champagne\r\nLet's continue tonight, come on, celebrate\r\nSometimes you gotta stay in\r\nAnd you know where I live\r\nYeah, you know what we is\r\nSometimes you gotta stay in, in\r\nWelcome to my house\r\nBaby take control now\r\nWe can't even slow down\r\nWe don't like to go out\r\nWelcome to my house\r\nPlay that music too loud\r\nShow me what you do now\r\nWe don't like to go out\r\nWelcome to my house\r\nWelcome to my house\r\nWelcome to my duck off the crib, the spot, the pad\r\nBut my house is your house if you throwin' it back\r\nExcuse me if my home bringing the sad\r\nSoon as these happy faces, you can run with the cash\r\nHomerun, slam dunk, touchdown, pass\r\nMi casa es tu casa so it ain't no holding back\r\nAnother shot of vodka, you know what's in my glass\r\nIt's my house, just relax\r\nWelcome to my house\r\nBaby take control now\r\nWe can't even slow down\r\nWe don't like to go out\r\nWelcome to my house\r\nPlay that music too loud\r\nShow me what you do now\r\nWe don't like to go out\r\nWelcome to my house\r\nWelcome to my house\r\nWelcome to my house\r\nIt's my house");
                    i++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "New Genesis":
                    PlayList.Rows.Add("VR", Properties.Resources.new_genesis, 0, "New Genesis", "Ado", "3:10", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - New Genesis  - Uta.wav", "新時代はこの未来だ\r\n世界中全部 変えてしまえば 変えてしまえば\r\nジャマモノ やなもの なんて消して\r\nこの世とメタモルフォーゼしようぜ\r\nミュージック キミが起こす マジック\r\n目を閉じれば未来が開いて\r\nいつまでも終わりが来ないようにって\r\nこの歌を歌うよ\r\nDo you wanna play? リアルゲーム ギリギリ\r\n綱渡りみたいな旋律 認めない戻れない忘れたい\r\n夢の中に居させて I wanna be free\r\n見えるよ新時代が 世界の向こうへ\r\nさあ行くよ new world\r\n新時代はこの未来だ\r\n世界中全部 変えてしまえば 変えてしまえば\r\n果てしない音楽がもっと届くように\r\n夢は見ないわ キミが話した「ボクを信じて」\r\nあれこれいらないものは消して\r\nリアルをカラフルに越えようぜ\r\nミュージック 今始まる ライジング\r\n目をつぶりみんなで逃げようよ\r\n今よりイイモノを見せてあげるよ\r\nこの歌を歌えば\r\nDo you wanna play? リアルゲーム ギリギリ\r\n綱渡りみたいな運命 認めない戻れない忘れたい\r\n夢の中に居させて I wanna be free\r\n見えるよ新時代が 世界の向こうへ\r\nさあ行くよ new world\r\n信じたいわ この未来を\r\n世界中全部 変えてしまえば 変えてしまえば\r\n果てしない音楽がもっと届くように\r\n夢を見せるよ 夢を見せるよ 新時代だ\r\nOoh\r\n新時代だ");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Sorry":
                    PlayList.Rows.Add("VR", Properties.Resources.Sorry, 0, "Sorry", "Justin Beiber", "3:30", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Sorry - Justin Bieber.wav", "You gotta go and get angry at all of my honesty\r\nYou know I try but I don't do too well with apologies\r\nI hope I don't run out of time, could someone call a referee?\r\nCause I just need one more shot at forgiveness\r\nI know you know that I made those mistakes maybe once or twice\r\nBy once or twice I mean maybe a couple a hundred times\r\nSo let me, oh let me redeem, oh redeem, oh myself tonight\r\nCause I just need one more shot at second chances\r\nYeah, is it too late now to say sorry?\r\nCause I'm missing more than just your body\r\nIs it too late now to say sorry?\r\nYeah I know that I let you down\r\nIs it too late to say I'm sorry now?\r\nI'm sorry, yeah\r\nSorry, yeah\r\nSorry\r\nYeah I know that I let you down\r\nIs it too late to say I'm sorry now?\r\nI'll take every single piece of the blame if you want me to\r\nBut you know that there is no innocent one in this game for two\r\nI'll go, I'll go and then you go, you go out and spill the truth\r\nCan we both say the words and forget this?\r\nIs it too late now to say sorry?\r\nCause I'm missing more than just your body\r\nIs it too late now to say sorry?\r\nYeah I know that I let you down\r\nIs it too late to say I'm sorry now?\r\nI'm not just trying to get you back on me\r\nCause I'm missing more than just your body\r\nIs it too late now to say sorry?\r\nYeah I know that I let you down\r\nIs it too late to say I'm sorry now?\r\nI'm sorry, yeah\r\nSorry, oh\r\nSorry\r\nYeah I know that I let you down\r\nIs it too late to say I'm sorry now?\r\nI'm sorry, yeah\r\nSorry, oh\r\nSorry\r\nYeah I know that I let you down\r\nIs it too late to say I'm sorry now?");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Sunflower":
                    PlayList.Rows.Add("VR", Properties.Resources.sunflower, 0, "Sunflower", "Post Malone, Swae Lee", "3:48", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Sunflower - Post Malone, Swae Lee.wav", "Eh, eh, eh, eh (Ooh)\r\nUh, uh, uh, uh (Uh)\r\nEh, eh\r\nUh uh, some things you just can't refuse\r\nShe wanna ride me like a cruise and I'm not tryna lose\r\nThen you're left in the dust, unless I stuck by ya\r\nYou're a sunflower, I think your love would be too much\r\nOr you'll be left in the dust, unless I stuck by ya\r\nYou're the sunflower, you're the sunflower\r\nYo no sé lo que tú tienes\r\nCómo hace' lo que quiera' con mi vida, tú te vas y luego vienes\r\nYo no sé qué tiene' tú, pero a la ve' yo pienso que no me convienes\r\nA veces trato de buscar una salida, rápido tú me detienes\r\nAsí de loco tú me quieres\r\nPero soy un loco por ti\r\nTú no sabe' lo que por dentro yo siento por ti\r\nY por má' que no quiero verte, vuelvo a repetir\r\nY sentir cada parte de tu cuerpo cuando estas aquí\r\nNo te puedo mentir\r\nSiempre estoy buscándote, yeah-yey\r\nTrato de alejarme y tú acercándote, yeah-yey\r\nDe lo que nos pasa siempre culpándote, yeah-yey\r\nPero se me olvida cuando te veo desnudándote\r\nY no sé por qué\r\nAnd you'll be left in the dust, unless I stuck by ya\r\nYou're the sunflower, I think your love would be too much\r\nOr you'll be left in the dust, unless I stuck by ya\r\nYou're the sunflower, you're the sunflower\r\nEse día que te conocí\r\nNo sabía que iba a ser así\r\nEl girasol más lindo del jardín\r\nY verte en el amanecer\r\nCon un beso volví a caer\r\nDime a dónde se fue, a dónde se fue\r\nY ahora me quedo con la confusión\r\nCon sentimientos de amor y dolor\r\nTe juro que esa no fue mi intención\r\nLa flor de antes cambió de color\r\nUh-uh-uh-uuh\r\nEn mi vida solo existes tú\r\nBaby, tell what we trynna prove\r\nSi tú sabes que yo soy tu luz (Si tú sabes que yo soy tu luz)\r\nAnd you'll be left in the dust, unless I stuck by ya\r\nYou're the sunflower, es que tu amor es just too much\r\nOr you'll be left in the dust, unless I stuck by ya\r\nYou're the sunflower, you're the sunflower");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "There for you":
                    PlayList.Rows.Add("VR", Properties.Resources.there_for_you, 0, "There for you", "Martin Garrix, Troye Sivan", "3:31", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - There For You - Martin Garrix - Troye Sivan.wav", "I woke up pissed off today\r\nAnd lately everyone feels fake\r\nSomewhere, I lost a piece of me\r\nSmoking cigarettes on balconies\r\nBut I can't do this alone\r\nSometimes I just need a light\r\nIf I call you on the phone\r\nNeed you on the other side\r\nSo when your tears roll down your pillow like a river\r\nI'll be there for you\r\nI'll be there for you\r\nWhen you're screaming, but they only hear you whisper\r\nI'll be loud for you\r\nBut you gotta be there for me too\r\nBut you gotta be there for me too\r\nLast year took a toll on me\r\nBut I made it with you next to me\r\nAround the world and back again\r\nI hope you're waiting at the end\r\nBut I can't do this alone\r\nSometimes I just need a light\r\nIf I call you on the phone\r\nNeed you on the other side\r\nSo when your tears roll down your pillow like a river\r\nI'll be there for you\r\nI'll be there for you\r\nWhen you're screaming, but they only hear you whisper\r\nI'll be loud for you\r\nI'll be loud for you\r\nI got you, I promise\r\nBut let me be honest\r\nLove is a road that goes both ways\r\nWhen your tears roll down your pillow like a river\r\nI'll be there for you\r\nBut you gotta be there for me too\r\nBut you gotta be there for me too\r\nBoy, I'm holdin' onto something\r\nWon't let go of you for nothing\r\nI'm runnin', runnin' just to keep my hands on you\r\nThere was a time that I was so blue\r\nWhat I got to do to show you?\r\nI'm runnin', runnin' just to keep my hands on you\r\nRunnin', runnin' just to keep my hands on you\r\nRunnin', runnin' just to keep my hands on you\r\nSaid, I'm runnin', runnin' just to keep my hands on you\r\nBut you gotta be there for me too\r\nBut you gotta be there for me too");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;


                case "25":
                    PlayList.Rows.Add("VN", Properties.Resources._25, 0, "25", "TÁO", "3:30", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - 25 - TÁO.wav", "Lần đầu tiên anh mong tìm ra cho riêng mình\r\nMột ai quan tâm và nghe lời anh hát\r\nNgồi kề bên đưa anh bờ vai khi anh buồn\r\nLặng im em khâu lành tim từng vỡ nát.\r\n\r\nCó những lúc cô đơn nhưng anh không nói\r\nLê đôi bàn chân bâng khuâng tìm đâu yên vui ngày xưa vẫn đong đầy\r\nNếu kí ức hôm qua tan như mây khói,\r\nxin em đừng đi ngang qua đường chung ta thường đan tay bước qua.\r\n\r\nBóng tối khiến đôi ta về ngược lối\r\nCó những thứ anh chưa từng được nói\r\nNếu biết trước anh không thể dừng lại\r\nThì anh cũng đã chẳng đi.\r\n\r\nMột ngày khác đã đến hôm nay\r\nCăn phòng anh cô đơn chẳng còn chút nắng\r\nSau ô cửa , giam mình trong những tiếng mơ hồ\r\nAnh nghe lời em thoáng qua, nghe thời gian đứng yên nghiêng mình\r\nNhìn mọi thứ trống vắng mông lung\r\nXung quanh tường cao nên anh nhìn sao chẳng thấy\r\nEm ơi mình xa bao lâu rồi đã trôi đi\r\nĐôi mi của em đã khô, con tim của anh tan vỡ\r\n\r\nAnh còn không nhớ nổi ngày cuối cùng trời nắng hay mưa\r\nBên nhau hôm đó mình có nắm tay chưa\r\nNếu chưa cho anh xin của em thêm chỉ một ngày nữa\r\nĐể anh an tâm rời bỏ em, không một chút dây dưa\r\nAnh không biết trước chuyện hôm nay em ơi,xa là không gần\r\nChắc em không đợi, còn chân anh bị bong gân\r\nĐẩy xe về, thành phố trên lưng anh nặng lắm\r\nAnh yêu em được hai năm,giờ anh bệnh thì ai thăm ?\r\nChắc đơn giản phần của anh là sai lầm\r\nDù cho sâu trong thâm tâm anh nghĩ mình lâu hơn trăm năm\r\nNhững thứ anh tặng em, xin em giữ đừng bụi bặm\r\nVì mình cũ kĩ được rồi nhiều vạn dặm xa xăm\r\nAnh đã khóc, cười, khô cả nước mắt\r\nNhưng thực tế, chia tay nhau là bước ngoặc\r\nĐể mình hoàn thành trọn vẹn lí do sống trên đời\r\nDù những thứ mình mong đợi không được bên nhau , em ơi.\r\n\r\nCó những lúc cô đơn nhưng anh không nói\r\nLê đôi bàn chân bâng khuâng tìm đâu yên vui ngày xưa vẫn đong đầy\r\nNếu kí ức hôm qua tan như mây khói,\r\nxin em đừng đi ngang qua đường chung ta thường đan tay bước qua.\r\n\r\nMột ngày khác đã đến hôm nay\r\nCăn phòng anh cô đơn chẳng còn chút nắng\r\nSau ô cửa , giam mình trong những tiếng mơ hồ\r\nAnh nghe lời em thoáng qua, nghe thời gian đứng yên nghiêng mình\r\nNhìn mọi thứ trống vắng mông lung\r\nXung quanh tường cao nên anh nhìn sao chẳng thấy\r\nEm ơi mình xa bao lâu rồi đã trôi đi\r\nĐôi mi của em đã khô, con tim của anh tan vỡ");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "3107":
                    PlayList.Rows.Add("VN", Properties.Resources._3107, 0, "3107", "W/n", "3:20", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - 3107 - W_n.wav", "Đêm dần buông\r\nChỉ có đôi ta đứng đây hơi buồn\r\nNhấm nháp những suy tư\r\nCủa ngày hôm qua vừa đây, đã xa\r\nRiêng mình ta\r\nVẫn mãi lang thang dưới ánh chiều tà\r\nVẫn nỗi nhớ miên man\r\nKý ức bên em bây giờ đang ở một nơi xa\r\nChỉ cần bên nhau như những ngày ấy\r\nAnh sẽ cùng em đi hết tháng ngày\r\nĐể trong cơn mơ anh chẳng tìm thấy\r\nĐể anh bơ vơ mãi phút nơi đây\r\nTình yêu khi xưa đôi ta vụn vỡ\r\nTrong một chiều mưa hai đứa chia tay\r\nChỉ cần cho anh được thêm một chút\r\nCho anh được gần bên em\r\n\r\nXin lỗi vì những cuộc điện thoại\r\nĐã làm phiền em với nửa kia\r\nDưới góc phố lặng thinh\r\nTiếng bước chân chậm chạp\r\nLúc giữa khuya\r\nTất nhiên thì anh cũng như họ\r\nChọn buông bỏ để em thấy yên bình\r\nCòn riêng phần anh\r\nThì lại thầm trách mọi thứ\r\nTrái ngược với duyên tình, em!\r\n\r\nLúc mình buồn nhìn trời và thở hắc\r\nMưa tháng bảy là cơn buồn dào dạt\r\nLẫn về tình yêu mà anh đã lỡ mất\r\nHẳn ai cũng từng nếm phải\r\nCảm giác trống trải\r\nTrong lòng mình em ha\r\nNhư em cũng từng đau khổ vì họ rồi\r\nLại thức trắng bao đêm qua\r\nNếu ta có dịp ngồi lại\r\nThì anh xin phép kể cho em nghe\r\nBình yên của anh thì cũng giống như họ\r\nLà có em ngồi phía sau xe\r\nLà buộc phải cố lượm lặt được hết\r\nNhững thứ trước kia đã xa mình\r\nLà em hồi đó hay là anh bây giờ\r\nCô đơn đứng giữa ngã ba tình\r\nHoàng hôn tháng bảy chưa bao giờ\r\nGiết chết trái tim buồn bã đã cũ mềm\r\nBầu trời đêm nay lại có mưa rơi\r\nQua một ô cửa đã phủ rèm, em\r\nAnh còn chẳng dám khẳng định\r\nMình đã nhớ về em bao nhiêu đêm\r\nNhưng sau tất cả thì chỉ có\r\nAnh và anh tự buộc mình yêu em\r\n\r\nChỉ cần bên nhau như những ngày ấy\r\nAnh sẽ cùng em đi hết tháng ngày\r\nDù chờ ngàn năm anh vẫn ở đấy\r\nDù anh đã cố gắng nghĩ đến em\r\nRồi trong nhân gian bao nhiêu người đến\r\nThanh xuân này anh chỉ muốn bên em\r\nDìu nhau đi qua những con phố dài\r\nChỉ yêu đôi ta chẳng biết đúng sai\r\nVì sao?\r\n\r\nĐêm chờ đông\r\nGió vẫn lao xao khiến ta thêm sầu\r\nGiấu ký ức nơi đây vào gọn trong tim\r\nDù mai đổi thay\r\nRiêng mình ta\r\nVẫn mãi cô đơn dưới ánh trăng vàng\r\nVẫn nỗi nhớ khi xưa\r\nNhững lúc bên em\r\nBây giờ đang ở một nơi xa");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "AI BIET":
                    PlayList.Rows.Add("VN", Properties.Resources.ai_biet, 0, "AI BIET", "WEAN", "3:43", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - AI BIET - WEAN.wav", "Và biết bao nhiêu cho vừa\r\nVà biết bao lâu cho vừa\r\nNào biết đang dư hay thừa\r\nNào biết đâu nào biết đâu\r\nNào biết đâu\r\nSài Gòn ngoài cửa\r\nBầu trời tối sầm\r\nLoay hoay đi kiếm bật lửa\r\nKéo rèm nhìn trời\r\nĐốt một điếu thuốc\r\nHôm nay thành phố lại mưa\r\nMưa rơi kế bên lửa\r\nEm yêu đã dậy hay chưa\r\nĐôi lúc bình yên là vậy\r\nNhững thứ đơn giản\r\nLàm ta say sưa\r\nVà biết bao nhiêu cho vừa\r\nVà biết bao lâu cho vừa\r\nDù biết hút thuốc là xấu\r\nNhưng biết bao lâu cho chừa\r\nEm như là nơi ta có thể\r\nNói hết những thứ còn chưa\r\nRồi sẽ ra sao\r\nNếu những suy nghĩ\r\nMột ngày chẳng còn được đưa em\r\nVà biết bao nhiêu cho vừa\r\nVà biết bao lâu cho vừa\r\nChắc ta sẽ bị hoá đá\r\nNhư trong cổ tích\r\nNgày xửa ngày xưa\r\nThường mơ thấy em\r\nTrong giấc ngủ trưa yeah yeah\r\nThường mơ thấy em\r\nTrong giấc ngủ trưa uh\r\nThôi mở một bài nhạc nghe\r\nNghe bài một bài nhạc nhẹ\r\nGiọng nữ ca sĩ thật khẽ\r\nHoà tan vào ta vào khói\r\nVào trong cơn mưa đầu hè\r\nHạnh phúc đâu cần màu mè\r\nNhìn tóc em tôi đầy me\r\nEm yêu vừa đi đâu về\r\nĐó là lời nhạc của chú Trần Tiến\r\nỞ trong bài Thành Phố Trẻ\r\nCòn tôi thì vẫn một mình\r\nBước tiếp ở giữa con đường\r\nĐầy người và xe\r\nCòn tôi thì vẫn một mình\r\nBước tiếp ở giữa\r\nCon đường đầy người và xe\r\nVà biết bao nhiêu cho vừa\r\nVà biết bao lâu cho vừa\r\nNào biết đang dư hay thừa\r\nNào biết đâu nào biết đâu\r\nNào biết đâu\r\nVà biết bao nhiêu cho vừa\r\nVà biết bao lâu cho vừa\r\nNào biết đang dư hay thừa\r\nNào biết đang dư hay thừa\r\nNào biết đang dư hay thừa\r\nNào biết đang dư hay thừa\r\nChưa biết bao nhiêu cho vừa\r\nHôm nay thành phố vẫn mưa\r\nTa vẫn đi kiếm bật lửa\r\nSong song con đường đi kiếm\r\nMột nửa còn lại và\r\nCó đôi lúc khờ dại\r\nCó đôi lúc dừng bút ngừng hát\r\nChẳng muốn mọi thứ tồn tại\r\nNhững sức ép dồn lại\r\nỞ hai bên tai\r\nĐang vang lên tên ai\r\nAlways in my mind\r\nĐôi lúc thấy trở ngại nhưng rồi\r\nNiềm tin là thứ ở lại cuối cùng\r\nEm như bài hát chill lúc cuối tuần\r\nLà cảm hứng khi trời tối dần\r\nVà dù lúc đó\r\nMặt mũi thối đần\r\nVẫn muốn được hát\r\nEm nghe mấy lần yeah\r\nBài hát này nghe\r\nThật là rối uh uh\r\nĐơn giản chỉ như\r\nSuy nghĩ của tôi thôi\r\nCon beat kia đang trôi trôi\r\nNhững cảm xúc đi lôi thôi\r\nNhớ môi em trên môi tôi\r\nMuốn em trên môi tôi\r\nGiống như Thanh Thảo Quang Dũng\r\nThì em cũng có\r\nVị ngọt trên đôi môi\r\nThat’s right\r\nThat’s right\r\nGiống như Thanh Thảo Quang Dũng\r\nThì em cũng có\r\nVị ngọt trên đôi môi\r\nVà đâu là đúng đâu là sai\r\nCon người luôn mâu thuẫn\r\nCó khi chẳng biết\r\nBên mình là ai\r\nĐiều gì là mãi mãi\r\nĐôi khi điều tích cực\r\nLại nằm ở sâu trong tiếng thở dài\r\nViết văn phải có mở bài\r\nCòn thứ mà bạn vừa nghe\r\nLà mớ hỗn độn\r\nĐược viết trong chiều thứ hai\r\nMột chiều mưa thứ hai\r\nYeah");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "CHIM SAU":
                    PlayList.Rows.Add("VN", Properties.Resources.chim_sau, 0, "CHIM SAU", "Sony tran, Hoang Ton, Blacka", "3:15", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - CHIM SAU - Sony Tran - Hoang Ton - Blacka.wav", "Chìm sâu trong màn đêm\r\nNói chuyện mấy câu\r\nKhông để quá lâu\r\nÔm chặt lấy nhau\r\nI gotta make a move\r\nAnh liền tiến sâu\r\nTâm trạng đến mau\r\nKhông để e thấy đau đâu\r\nVerse 1 (Sony Tran)\r\nOh baby em so đẹp,\r\ntrong bộ váy nhưng càng đẹp hơn khi không mặc gì\r\nCăn phòng này bỗng dưng lại bùng cháy,\r\nnói anh nghe lý do chạy khỏi đây là gì\r\nPre Chorus\r\nEm không cần làm màu đâu, I like it raw\r\nJust take it off cause I take it all\r\nI’ll have a puff if you don’t mind\r\nI’ll put on a show and you got main role\r\nChorus\r\nChìm sâu trong màn đêm\r\nNói chuyện mấy câu\r\nKhông để quá lâu\r\nÔm chặt lấy nhau\r\nI gotta make a move\r\nAnh liền tiến sâu\r\nTâm trạng đến mau\r\nKhông để e thấy đau đâu\r\nVerse 2 (Hoang Ton)\r\nAnh cũng muốn nói tất cả những điều là thần kỳ\r\nNhưng baby em đẹp nhất là khi không mặc gì\r\nEm làm cho anh đã biến thành một gã tình si\r\nEm luôn biết cách tỏa sáng ở những chỗ mình đi\r\nYeah uh yeah\r\nEm cũng chẳng phải nói là tối nay em thích gì\r\nYeah uh yeah\r\nĐã có anh x3 đã…\r\nI know i know I know\r\nAnh biết một chỗ mà mình có thể đi thể đi cả nhau\r\nAnh chỉ muốn ở một mình cùng em cùng em cùng em\r\nThật lâu…\r\nPre chorus\r\nEm không cần làm màu đâu, I like it raw\r\nJust take it off cause I take it all\r\nI’ll have a puff if you don’t mind\r\nI’ll put on a show and you got main role\r\n\r\nChorus\r\nChìm sâu trong màn đêm\r\nNói chuyện mấy câu\r\nKhông để quá lâu\r\nÔm chặt lấy nhau\r\nI gotta make a move\r\nAnh liền tiến sâu\r\nTâm trạng đến mau\r\nKhông để e thấy đau đâu\r\nverse 3 (Blacka)\r\nNhớ không lầm anh viết câu đầu là kế bên nhà\r\nLúc đó em cười vì thế nên là\r\nAnh thấy yên bình\r\nem nấu thêm trà đêm ấy riêng mình, bên dưới hiên nhà , ba má trên lầu , anh nói em là\r\nEm không thể nào biết được thời gian có thể bào mòn cả một phiến đá\r\nVì nếu không thể tiến xa , thì đến lúc mình phải cần tiến hóa\r\nChỉ cần nhớ lúc đó mình đã – ” rất đã”\r\nTa đã có những điều tuyệt nhất có nhớ có quên nên có ra đi anh xin em là đừng đòi anh trả – tất cả\r\nChừa một chút cho người đến sau\r\nVì nếu anh thật sự tồi sau này\r\nHai đứa có thể mến nhau\r\nThương em nhiều nên anh nhắc kĩ\r\nKhi nhạc bật và đèn tắt đi\r\nThì em đẹp nhất khi không mặc gì\r\nChorus 2x\r\nChìm sâu trong màn đêm\r\nNói chuyện mấy câu\r\nKhông để quá lâu\r\nÔm chặt lấy nhau\r\nI gotta make a move\r\nAnh liền tiến sâu\r\nTâm trạng đến mau\r\nKhông để e thấy đau đâu");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "CUA":
                    PlayList.Rows.Add("VN", Properties.Resources.cua, 0, "CUA", "HIEUTHUHAI", "3:47", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - CUA - HIETHUHAI.wav", "Nhìn tụi anh thật cool\r\nLạnh như băng mà không cần cố\r\nTên tuổi lên càng cao\r\nNhư Bray Ở Trong Thành Phố\r\nBài ra bài ra bài\r\nLiên tục lặp lại\r\nNhư một tần số\r\nCòn bạn trai cũ của em\r\nMother****er một thằng ngố\r\nTay phải gạt cần số\r\nCòn tay trái thì cầm vô lăng\r\nNhìn tụi anh như băng khủng bố\r\nCầm tay lái là phải đeo găng\r\nChạy đến khi mà\r\nKhông còn gì mới dừng cơ\r\nLên đây đâu dễ\r\nBắt kịp anh thì không thể\r\nNhư Nguyễn Trọng Tài em Ngừng Mơ\r\nSắc đẹp là điều thứ nhất\r\nĐể làm một nửa của HIEUTHUHAI\r\nSo if you wanna ****\r\nMy DMs let it slide\r\nAnh cua em thì dễ\r\nKhông bao giờ có chuyện ngược lại\r\nNên say bye bye bye\r\nNhiều mảnh vỡ và có Malphite\r\nBắn là bang bang\r\nMake you dance dance\r\nWe the man man\r\nHurrykng KNG\r\nNhững ngày lang thang\r\nSẽ còn sang trang\r\nÂm nhạc vang vang\r\nTích tịch tang tang\r\nNerd GANG GANG\r\nĐi hàng ngang ngang\r\nPop the Champagne\r\nYou gotta stick to the plan\r\nBiến những cú sút trở thành bàn\r\nCó thể gọi tao Johnny Dang\r\nTất cả mọi thứ làm bằng vàng\r\nBaby I’m cool cool\r\nGiơ tay lên nếu cần một ít\r\nTụi anh cua cua\r\nChỉ dừng chân khi qua đường pit\r\nWe say cua cua\r\nHẹn gặp lại ngay ở vạch đích\r\nNên là thích thì cua\r\nMà không thích thì cua\r\nCool cool\r\nGiơ tay lên nếu cần một ít\r\nTụi anh cua cua\r\nChỉ dừng chân khi qua đường pit\r\nWe say cua cua\r\nHẹn gặp lại ngay ở vạch đích\r\nNên là thích thì cua\r\nMà không thích thì cua cua\r\nNerd không coi ***\r\nChỉ coi tiền làm tình\r\nAnh thì đẹp trai\r\nHieuthuhai thì xăm mình\r\nDây chuyền ở trên cổ\r\nKhông phải chân em đâu\r\nDưới Hiên Nhà hút xì gà\r\nNgầu như là Đen Vâu\r\nĐi xe hiệu\r\nEm chân dài rất thích là bo cua\r\nTay cầm Chivas\r\nCòn tay cầm chai Soju\r\nDù Âu hay Hàn thì\r\nAnh được gọi là thần tượng\r\nBận đồ hiệu\r\nEm đi bên anh không cần ngượng\r\nNhạc là kinh doanh\r\nAnh là doanh nhân\r\nThẻ thì trong ngăn\r\nTiền thì trong bank\r\nSố tài khoản trải dài\r\nHơn 15 chữ số\r\nAnh không ngọt ngào\r\nSao cứ gọi anh là bố\r\nThích giàu tích tiền\r\nManbo tính hiền\r\nDing dong dong\r\nChing chang chong\r\nTao Gold Asian Young\r\nBaby I’m cool cool\r\nGiơ tay lên nếu cần một ít\r\nTụi anh cua cua\r\nChỉ dừng chân khi qua đường pit\r\nWe say cua cua\r\nHẹn gặp lại ngay ở vạch đích\r\nNên là thích thì cua\r\nMà không thích thì cua\r\nCool cool\r\nGiơ tay lên nếu cần một ít\r\nTụi anh cua cua\r\nChỉ dừng chân khi qua đường pit\r\nWe say cua cua\r\nHẹn gặp lại ngay ở vạch đích\r\nNên là thích thì cua\r\nMà không thích thì cua cua\r\nNên là thích thì cua\r\nMà không thích thì cua cua cua\r\nNên là thích thì cua\r\nMà không thích thì cua cua\r\nCua cua cua cua cua\r\nThích thì cua\r\nMà không thích thì cua\r\nCua cua cua cua\r\nHẹn gặp lại ngay ở vạch đích\r\nNên là thích thì cua\r\nMà không thích thì cua cua");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "GIAYPHUT":
                    PlayList.Rows.Add("VN", Properties.Resources.giayphut, 0, "GIAYPHUT", "KIDSAI", "3:40", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - GIAYPHUT - KIDSAI.wav", "Chỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nCó lẽ không\r\nAnh chắc chắn trông\r\nChờ đợi baby girl\r\nAnh muốn kế bên em oh baby\r\nAnh muốn có\r\nCó được shawty\r\nEm là\r\nMọi thứ em à\r\nMàu hồng tím\r\nAnh không muốn đau tim đâu em\r\nMàu hồng tím\r\nAnh không muốn tim phải đau em\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nCho bao nhiêu yêu thương xa vời\r\nTrong tim ta đã không có nhau\r\nĐi bên em nói không nên lời\r\nCho anh xin giây phút nhiệm màu\r\nBaby nói cho anh bao điều\r\nKhiến cho con tim anh thêm đau\r\nNếu như giây này không thành\r\nAnh chỉ mong là mình quên nhau\r\nCodeine yeah\r\nTan vào tim\r\nBaby no\r\nAnh lại say\r\nCho thời gian\r\nQuay về đây\r\nCho tình yêu\r\nNhư lúc đầu\r\nCho con tim anh tan vào nicotine\r\nCho đôi ta tan\r\nTrong màn đêm lặng im\r\nCho hai đôi môi\r\nTrai thật lâu nụ hôn\r\nCho anh bên em\r\nThêm một giây được không\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nCho con tim anh tan vào nicotine\r\nCho đôi ta tan\r\nTrong màn đêm lặng im\r\nCho hai đôi môi\r\nTrai thật lâu nụ hôn\r\nCho anh bên em\r\nThêm một giây được không");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "GU":
                    PlayList.Rows.Add("VN", Properties.Resources.gu, 0, "GU", "Freaky, Seachains", "3:23", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - Gu - Freaky - Seachains.wav", "Baby girl, I like you move\r\nCan we talk about your shoes?\r\nYeah! Anh xin thề anh không nói về gu\r\nAi mà nói em không đẹp thì có mắt như mù\r\nBaby girl, I like you move\r\nCan we talk about your shoes?\r\nCuộc đời này mình sống phong lưu\r\nSo I keep mah groove with you my boo\r\nBaby girl, I like you move\r\nCan we talk about your shoes?\r\nYeah! Anh xin thề anh không nói về gu\r\nAi mà nói em không đẹp thì có mắt như mù\r\nBaby girl, I like you move\r\nCan we talk about your shoes?\r\nCuộc đời này mình sống phong lưu\r\nSo I keep mah groove with you my boo\r\nNếu như em là trà sữa, thì anh là đường tinh\r\nNếu như em là trang web, thì anh là đường link\r\nKhiến anh đau đầu, em là phương trình\r\nNếu như em là Âu Cơ, kế bên anh là Trường Chinh\r\nAnh không hề thông minh, nên được gọi là chàng ngơ\r\nGood gril trong bộ váy ngắn, nên anh tạm gọi là nàng thơ\r\nSài Gòn thì rất nóng, còn tim em như đóng băng\r\nNgười yêu cũ em sống lỗi, nên anh bắt buộc phải sống nhăn\r\nEm là buổi sáng, anh là điểm tâm\r\nYêu em không thể thiếu ngày nào, như bị đuổi học vì điểm danh\r\nNgười thì nói anh đa tình, người thì nói anh ga lăng\r\nHọ thấy anh là qua hình, viết một bài là ra trend\r\nBaby girl, I like you move\r\nCan we talk about your shoes?\r\nYeah! Anh xin thề anh không nói về gu\r\nAi mà nói em không đẹp thì có mắt như mù\r\nBaby girl, I like you move\r\nCan we talk about your shoes?\r\nCuộc đời này mình sống phong lưu\r\nSo I keep mah groove with you my boo\r\nAnh là Hip Hop, em là Lofi\r\nQuay clip TikTok, nói mình là mối tình lâu phai\r\nFuckboiz đặt em lên giường, anh đặt nhẫn em lên tay\r\nBad boy bỏ em bên đường, giống như khứa Seachains, eh\r\nGái nhà ai thấy thiệt cool\r\nXuống mần quen thấy hợp gu (oh my god)\r\nMá nó kêu lấy vàng cây, đến nhà em, muốn mần sui\r\nRước làm dâu, xuống miền Tây\r\nBạn trai cũ em đáng ghét, còn em đây thì đáng thương\r\nLý do đây anh thức khuya, vì nick em còn sáng trưng\r\nBa mẹ nói là chúng mình, như là thanh mai trúc mã\r\nChờ tới đủ tuổi được gả, như phải chờ từng tháng lương\r\nBaby girl, I like you move\r\nCan we talk about your shoes?\r\nYeah! Anh xin thề anh không nói về gu\r\nAi mà nói em không đẹp thì có mắt như mù\r\nBaby girl, I like you move\r\nCan we talk about your shoes?\r\nCuộc đời này mình sống phong lưu\r\nSo I keep mah groove with you my boo");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "HOLD MY HAND":
                    PlayList.Rows.Add("VN", Properties.Resources.holdmyhand, 0, "HOLD MY HAND", "POLL, TDY", "3:39", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - HOLD MY HAND - Poll - TDY.wav", "Đôi chân anh cô đơn lang thang 1 mình giữa phố Đông\r\nTìm 1 người hẹn hò mà làm anh ngóng trông...\r\nBaby...anh tương tư em suốt cả đêm dài\r\nTự hỏi mình 1 câu là \"Tại sao luôn anh yêu em hoài?\"\r\nChạm vào ánh mắt và cả bờ môi\r\nYêu em say đắm...chỉ có vậy thôi\r\nYêu em mặc kệ ai đúng sai\r\nI just need a smile\r\nFalling in your eyes\r\n\r\n(Hold my hand...go to the fancy town\r\nHold my hand...touch me and kiss your mouth\r\nHold my hand...Anh vẫn sẽ luôn yêu em\r\nI hope u know u are my memories) x2\r\n\r\nAnh biết rằng từ lâu và em đây chính là loài hoa\r\nLoài hoa cho ngà sức sống và để ghi giấu vào lời ca\r\nI'm feeling them chỉ vỏn vẹn vài ba câu hát\r\nNụ cười thơ ngây vô tình thoáng qua mà lại say đắm cả đời ta\r\n\r\nÁnh mắt dịu dàng, bồi hồi ta nắm tay nhau\r\nVài lời mật ngọt mà làm anh đắm say sao ? (noo...)\r\nYêu em, dù phong ba hay bao nhiêu trắc trở\r\nKhông như sách vở, yêu em luôn cả ngay trong cách thở\r\n\r\nĐôi chân anh cô đơn lang thang 1 mình giữa phố Đông\r\nTìm 1 người hẹn hò mà làm anh ngóng trông...\r\nBaby...anh tương tư em suốt cả đêm dài\r\nTự hỏi mình 1 câu là \"Tại sao luôn anh yêu em hoài?\"\r\nChạm vào ánh mắt và cả bờ môi\r\nYêu em say đắm...chỉ có vậy thôi\r\nYêu em mặc kệ ai đúng sai\r\nI just need a smile\r\nFalling in your eyes\r\n\r\nHold my hand...go to the fancy town\r\nHold my hand...touch me and kiss your mouth\r\nHold my hand...Anh vẫn sẽ luôn yêu em\r\nI hope u know u are my memories\r\n\r\nSau giờ tan ca, làm việc mệt mỏi\r\nEm cần tâm sự và tìm người lắng nghe\r\nVậy thì để anh ở đây luôn bên em mỗi tối\r\nVà dắt tay em về trên con đường vắng xe\r\n\r\nQuan tâm chi em ơi hàng tá công việc\r\nNếu mà cứ lao lực khi nào mình xong xuôi\r\nHãy cứ để bản thân nhận lấy điều tốt đẹp nhất\r\nVì tuổi trẻ đẹp nhất khi ta được rong chơi\r\n\r\nNên là anh sẽ uống cùng em khi phố phường yên giấc\r\nTâm tư anh gánh vác sẽ nhẹ nhàng hơn\r\nAnh chỉ muốn được ôm em thường xuyên nhất\r\nVà nhìn thấy môi em cười dưới ánh hoàng hôn\r\n\r\nI just wanne be with u when the Sunset\r\nCuz baby girl u always in my mind\r\nDont overthink let make life so fresh\r\nVà cùng nhau cố gắng...It will be alright!\r\n\r\nNeed u (lalalaa..)\r\nJust need u (lalalaa..)\r\nTại vì sao anh như người trên mây?\r\nGặp em nơi đâu vẫn xoay vòng\r\nSaxophone trên tay, đôi mình cùng đắm say\r\nFeel my song đêm nay, chỉ cần 1 cái nắm tay\r\n(Em không thoát khỏi anh được đâu)\r\n1 2 3...Now we lets gooo\r\n\r\nĐôi chân anh cô đơn lang thang 1 mình giữa phố Đông\r\nTìm 1 người hẹn hò mà làm anh ngóng trông...\r\nBaby...anh tương tư em suốt cả đêm dài\r\nTự hỏi mình 1 câu là \"Tại sao luôn anh yêu em hoài?\"\r\n\r\nChạm vào ánh mắt và cả bờ môi\r\nYêu em say đắm...chỉ có vậy thôi\r\nYêu em mặc kệ ai đúng sai\r\nI just need a smile\r\nFalling in your eyes\r\n\r\n(Hold my hand...go to the fancy town\r\nHold my hand...touch me and kiss your mouth\r\nHold my hand...Anh vẫn sẽ luôn yêu em\r\nI hope u know u are my memories) x2");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "ICEMAN":
                    PlayList.Rows.Add("VN", Properties.Resources.iceman, 0, "ICEMAN", "SOL7", "3:41", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - iceman - SOL7.wav", "Rolling some tree và mọi thứ dần chậm đi\r\nNgồi đây nhâm nhi nghe giai điệu đó đang thầm thì\r\nPut some ice vào trong ly chấm bi (ice ice)\r\nKhi ở trên mái là một cơn mưa đang ầm ĩ (drop drop)\r\nTrở lại Bồng Sơn hay là Sài Gòn, anh vẫn không lonely\r\nBịt khẩu trang như là Sinobi để tránh thấy covi (coco)\r\nKeep it lowkey, anh đang giải trí cùng với mấy homies\r\nĐặt bàn tay vào trang giấy lấy ra vài cái ô ly\r\nOutside với ai trong team cùng với những đôi mắt lim dim\r\nLuôn luôn có aice ở trong tim\r\nLạnh lùng như vai ở trong phim\r\nSay say trong đêm nay\r\nSome ice ở trên tay\r\nNhún nhảy ở trên stage\r\nBăng giá trong con tim này\r\nGucci jackey đem xuống\r\nRồi khoác nó lên đi\r\nMùi nước hoa mà anh muốn\r\nĐó là mùi của money (dollar)\r\nMoney talk làm ai phải gật đầu\r\nMan not hot 'cause heart cold\r\nNếu em nhất trí bên anh thật lâu\r\nThì chấp nhận anh có tật xấu\r\nGucci jacket đem xuống\r\nRồi khoác nó lên đi\r\nMùi nước hoa mà anh muốn\r\nĐó là mùi của money (dollar)\r\nCái điều em đang cuốn\r\nRồi đốt nó lên đi\r\nMùi nước hoa mà anh muốn\r\nĐó là mùi của money\r\nYea money man\r\nDollar ở đâu thì anh ở đấy (ya ooh)\r\nAnh đưa em về nơi\r\nEm chưa bao giờ thấy (ohhh)\r\nRolling với cả gang đưa anh tờ giấy (Ohhh)\r\nImma smoke some iceee\r\nPut some ice on your neck\r\nBaby imma watch it frozeee\r\nHit me up with icy lemonade\r\nMck cùng dân chơi overdoseeee\r\nTại sao anh lại có thể bằng giá với mức đấy?\r\nI cannot move\r\nStaying in my ground, chưa đến lúc gãy\r\nCan not lose\r\nBởi vì ai cũng có việc mình thôi\r\nBaby don't hate on the law\r\nAnh chỉ muốn được ngồi chill\r\nBut oh my god, fuck the news\r\nGạt điếu em đang cuốn, rồi đốt nó lên đi!\r\nMùi nước hoa mà anh muốn\r\nĐó là mùi của money (dollar)\r\nMoney talk làm ai phải gật đầu\r\nMan not hot 'cause heart cold\r\nMck-overdose icy heart! (yeah yeah)\r\nGạt điếu em đang cuốn, rồi đốt nó lên đi\r\nMùi nước hoa mà anh muốn\r\nĐó là mùi của money (dollar)\r\nGạt điếu em đang cuốn, rồi đốt nó lên đi!\r\nMùi nước hoa mà anh muốn\r\nĐó là mùi của money (dollar)\r\nWhole gang iceout in the club\r\nĐó là mùi của money");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "LOCHI":
                    PlayList.Rows.Add("VN", Properties.Resources.lochi, 0, "LOCHI", "FSRIO", "3:20", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - LO CHI - FSRIO.wav", "Ɲhớ đến em bao đêm dài.\r\nThức trắng đêm ra thêm bài.\r\nƁắt lấу âm thanh nên sài.\r\n\r\nGirl this song is for уa.\r\nƁao nhiêu ngàу qua, con tim rộn ràng bồi hồi đâu уên.\r\nVì anh muốn viết ra khúc ca cho em, thức đêm với anh nào đâu phiền.\r\n\r\nMột người con gái trông thật xinh đang ngồi bàn kế.\r\nƖ like уour smile, môi cười xinh như là nắng đang về.\r\nƁae em đừng mang Fendi, Gucci haу là LV.\r\nƐm vẫn sáng như ngôi một sao, уou are the beautу.\r\n\r\nỪ xin số phone, mình về nhắn tin.\r\nLượn lờ phố đông và đưa nàng đi xem phim.\r\nMình đi đến Hồ Tâу rồi.\r\nMình qua Ϲircle K ngồi.\r\n\r\nRồi ra Ϲoffee thôi đừng lo chi có anh đâу rồi.\r\nLấу đi, em đã lấу trong mơ là từng câu hát mang mùi hương ngát, hai ta đứng kế ông tơ.\r\n(Và)\r\nϹhớ lo! Anh sẽ hát thêm cho em.\r\nϹhỉ cần em muốn dù là giông tố anh sẽ vẫn luôn ở bên.\r\n\r\nĐừng lo nhé vì anh đã nhớ tên em.\r\nƝgân nga dành cho nàng câu hát dù anh đã có thêm fan.\r\nϹho em niềm vui mới nàу.\r\nMong em đừng lo lắng nhé.\r\nƊon’t run awaу! Vì anh sẽ tới bên em.\r\n\r\n*****\r\nAууa lonelу gurl, tối naу trông em có vẻ không vui.\r\nGiữa làn khói mập mờ, có người nói cần chờ, trái tim em vụn rồi nên em cười không nổi.\r\nJust L O V Ɛ, để tình cảm khiến em tự do.\r\nLet уour soul be free, hãу để anh đưa em hoà vào trong làn gió.\r\n\r\nRide around the citу, từ trung tâm tới đích đến chưa biết.\r\nĐể em ngồi phía sau khiến cho уên xe luôn trong tình trạng thừa nhiệt.\r\n2 taу ôm thật chặt nhá, vì mình đang di chuуển trong cái xã hội đảo điên.\r\nƝhà thì chẳng có gì mấу, ơn giời được cái xe với hai mũ bảo hiểm.\r\n\r\nƁabe em chẳng cần phải làm gì, mà các boу vẫn tự mê.\r\nϹhúng mình lang thang hết cả thủ đô chỉ để tìm ra thêm một vẻ đẹp như thế.\r\nTrăng thì đang dần lên cao, lên cao, lên cao lên khỏi tầng cao ốc.\r\n9pm, em và GTM, đang trên xe đi xem, trên đồi có những vì sao khóc.");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "All We Know":
                    PlayList.Rows.Add("EN", Properties.Resources.All_We_Know, 0, "All We Know", "ChainSmokers", "3:30", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - All We Know - The Chainsmokers.wav", "Fighting flames of fire\r\nHang onto burning wires\r\nWe don't care anymore\r\nAre we fading lovers?\r\nWe keep wasting colors\r\nMaybe we should let this go\r\nWe're fallin' apart, still we hold together\r\nWe've passed the end, so we chase forever\r\n'Cause this is all we know\r\nThis feeling's all we know\r\nI'll ride my bike up to the road\r\nDown the streets, right through the city\r\nI'll go everywhere you go\r\nFrom Chicago to the coast\r\nYou tell me, \"Hit this and let's go\r\nBlow the smoke right through the window\"\r\n'Cause this is all we know\r\n'Cause this is all we know\r\n'Cause this is all we know\r\nNever face each other\r\nOne bed, different covers\r\nWe don't care anymore\r\nTwo hearts still beating\r\nOn with different rhythms\r\nMaybe we should let this go\r\nWe're fallin' apart, still we hold together\r\nWe've passed the end, so we chase forever\r\n'Cause this is all we know\r\nThis feeling's all we know\r\nI'll ride my bike up to the road\r\nDown the streets, right through the city\r\nI'll go everywhere you go\r\nFrom Chicago to the coast\r\nYou tell me, \"Hit this and let's go\r\nBlow the smoke right through the window\"\r\n'Cause this is all we know\r\n'Cause this is all we know\r\n'Cause this is all we know");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Bad Habits":
                    PlayList.Rows.Add("EN", Properties.Resources.Bad_Habits, 0, "Bad Habits", "Ed Sheeran", "3:20", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Bad Habits - Ed Sheeran.wav", "One, two, three, four\r\nOoh-ooh, ooh-ooh-ooh\r\nEvery time you come around, you know I can't say no\r\nEvery time the sun goes down, I let you take control\r\nI can feel the paradise before my world implodes\r\nAnd tonight had something wonderful\r\nMy bad habits lead to late nights endin' alone\r\nConversations with a stranger I barely know\r\nSwearin' this will be the last, but it probably won't\r\nI got nothin' left to lose, or use, or do\r\nMy bad habits lead to wide eyes stare into space\r\nAnd I know I'll lose control of the things that I say\r\nYeah, I was lookin' for a way out, now I can't escape\r\nNothin' happens after two, it's true\r\nIt's true, my bad habits lead to you\r\nOoh-ooh, ooh-ooh-ooh\r\nMy bad habits lead to you\r\nOoh-ooh, ooh-ooh-ooh\r\nMy bad habits lead to you\r\nEvery pure intention ends when the good times start\r\nFallin' over everything to reach the first time's spark\r\nIt started under neon lights, and then it all got dark\r\nI only know how to go too far\r\nMy bad habits lead to late nights endin' alone\r\nConversations with a stranger I barely know\r\nSwearin' this will be the last, but it probably won't\r\nI got nothin' left to lose, or use, or do\r\nMy bad habits lead to wide eyes stare into space\r\nAnd I know I'll lose control of the things that I say\r\nYeah, I was lookin' for a way out, now I can't escape\r\nNothin' happens after two, it's true\r\nIt's true, my bad habits lead to you\r\nOoh-ooh, ooh-ooh-ooh\r\nMy bad habits lead to you\r\nOoh-ooh, ooh-ooh-ooh\r\nWe took the long way 'round\r\nAnd burned 'til the fun ran out, now\r\nMy bad habits lead to late nights endin' alone\r\nConversations with a stranger I barely know\r\nSwearin' this will be the last, but it probably won't\r\nI got nothin' left to lose, or use, or do\r\nMy bad habits lead to wide eyes stare into space\r\nAnd I know I'll lose control of the things that I say\r\nYeah, I was lookin' for a way out, now I can't escape\r\nNothin' happens after two, it's true\r\nIt's true, my bad habits lead to you\r\nOoh-ooh, ooh-ooh-ooh\r\nMy bad habits lead to you\r\nOoh-ooh, ooh-ooh-ooh\r\nMy bad habits lead to you");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Better Now":
                    PlayList.Rows.Add("EN", Properties.Resources.Better_Now, 0, "Better Now", "Post Malone", "3:40", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Better Now - Post Malone.wav", "You prolly think that you are better now, better now\r\nYou only say that 'cause I'm not around, not around\r\nYou know I never meant to let you down, let you down\r\nWoulda gave you anything\r\nWoulda gave you everything\r\nYou know I say that I am better now, better now\r\nI only say that 'cause you're not around, not around\r\nYou know I never meant to let you down, let you down\r\nWoulda gave you anything\r\nWoulda gave you everything, oh-oh\r\nI did not believe that it would end, no (end, no)\r\nEverything came second to the Benzo (Benzo)\r\nYou're not even speakin' to my friends, no\r\nYou knew all my uncles and my aunts though\r\n20 candles, blow 'em out and open your eyes\r\nWe were lookin' forward to the rest of our lives\r\nUsed to keep my picture posted by your bedside\r\nNow it's in your dresser with the socks you don't like\r\nAnd I'm rollin', rollin', rollin', rollin'\r\nWith my brothers like it's Jonas, Jonas\r\nDrinkin' Henny and I'm tryna forget\r\nBut I can't get this shit outta my head\r\nYou prolly think that you are better now, better now\r\nYou only say that 'cause I'm not around, not around\r\nYou know I never meant to let you down, let you down\r\nWoulda gave you anything\r\nWoulda gave you everything\r\nYou know I say that I am better now, better now\r\nI only say that 'cause you're not around, not around\r\nYou know I never meant to let you down, let you down\r\nWoulda gave you anything\r\nWoulda gave you everything, oh-oh\r\nI seen you with your other dude\r\nHe seemed like he was pretty cool\r\nI was so broken over you\r\nLife, it goes on, what can you do?\r\nI just wonder what it's gonna take (what it's gonna take?)\r\nAnother foreign or a bigger chain (bigger chain)\r\nBecause no matter how my life has changed\r\nI keep on looking back on better days\r\nYou prolly think that you are better now, better now\r\nYou only say that 'cause I'm not around, not around\r\nYou know I never meant to let you down, let you down\r\nWoulda gave you anything\r\nWoulda gave you everything\r\nYou know I say that I am better now, better now\r\nI only say that 'cause you're not around, not around\r\nYou know I never meant to let you down, let you down\r\nWoulda gave you anything\r\nWoulda gave you everything, oh-oh\r\nI promise, I swear to you, I'll be okay\r\nYou're only the love of my life (the love of my life)\r\nYou prolly think that you are better now, better now\r\nYou only say that 'cause I'm not around, not around\r\nYou know I never meant to let you down, let you down\r\nWoulda gave you anything\r\nWoulda gave you everything\r\nYou know I say that I am better now, better now\r\nI only say that 'cause you're not around, not around\r\nYou know I never meant to let you down, let you down\r\nWoulda gave you anything\r\nWoulda gave you everything, oh-oh");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Cake By The Ocean":
                    PlayList.Rows.Add("EN", Properties.Resources.CBTO, 0, "Cake By The Ocean", "DNCE", "3:30", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Cake By The Ocean - DNCE.wav", "Nah, nah, yeah\r\n(Cake by the ocean)\r\nOh, no\r\nSee you walkin' 'round like it's a funeral\r\nNot so serious, girl, why those feet cold?\r\nWe just gettin' started, don't you tiptoe, tiptoe (ah)\r\nWaste time with a masterpiece, don't waste time with a masterpiece (huh)\r\nYou should be rollin' with me, you should be rollin' with me (ah-ah-ah)\r\nYou're a real-life fantasy, you're a real-life fantasy (huh)\r\nBut you're movin' so carefully, let's start livin' dangerously\r\nTalk to me, baby\r\nI'm goin' blind from this sweet-sweet cravin', whoa-oh\r\nLet's lose our minds and go fuckin' crazy\r\nI-I-I-I-I-I keep on hopin' we'll eat cake by the ocean (uh)\r\nWalk for me, baby\r\nI'll be Diddy, you'll be Naomi, whoa-oh\r\nLet's lose our minds and go fuckin' crazy\r\nI-I-I-I-I-I keep on hopin' we'll eat cake by the ocean (uh)\r\nGoddamn\r\nSee you lickin' frostin' from your own hands\r\nWant another taste, I'm beggin', \"Yes, ma'am\"\r\nI'm tired of all this candy on the dry land, dry land, ooh\r\nWaste time with a masterpiece, don't waste time with a masterpiece (huh)\r\nYou should be rollin' with me, you should be rollin' with me (ah-ah-ah)\r\nYou're a real-life fantasy, you're a real-life fantasy (huh)\r\nBut you're movin' so carefully, let's start livin' dangerously (whoa-oh)\r\nTalk to me, baby\r\nI'm goin' blind from this sweet-sweet cravin', whoa-oh\r\nLet's lose our minds and go fuckin' crazy (ah)\r\nI-I-I-I-I-I keep on hopin' we'll eat cake by the ocean (uh)\r\nWalk for me, baby (walk for me now)\r\nI'll be Diddy, you'll be Naomi, whoa-oh\r\nLet's lose our minds and go fuckin' crazy\r\nI-I-I-I-I-I keep on hopin' we'll eat cake by the ocean\r\nOoh, ah-ah\r\nI-I-I-I-I-I keep on hopin' we'll eat cake by the ocean (uh)\r\nOoh, ah-ah\r\nI-I-I-I-I-I keep on hopin' we'll eat cake by the ocean (uh)\r\nHey, you're fuckin' delicious\r\nTalk to me, girl\r\nTalk to me, baby (talk to me, baby)\r\nI'm goin' blind from this sweet-sweet cravin', whoa-oh\r\nLet's lose our minds and go fuckin' crazy\r\nI-I-I-I-I-I keep on hopin' we'll eat cake by the ocean (hey) (uh)\r\nWalk for me, baby (walk for me now)\r\nI'll be Diddy, you'll be Naomi, whoa-oh\r\nLet's lose our minds and go (and go what?), fuckin' crazy (that's right)\r\nI-I-I-I-I-I keep on hopin' (I'm ready), we'll eat cake by the ocean (ah, yeah)\r\nRed velvet, vanilla, chocolate in my life\r\nFunfetti, I'm ready, I need it every night\r\nRed velvet, vanilla, chocolate in my life\r\nI-I-I-I-I-I keep on hopin' we'll eat cake by the ocean (uh)");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Comedy":
                    PlayList.Rows.Add("EN", Properties.Resources.comedy, 0, "Comedy", "Gen Hoshino", "3:32", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Comedy - Gen Hoshino.wav", "争い合って 壊れかかった\r\nこのお茶目な星で\r\n生まれ落ちた日から よそ者\r\n涙枯れ果てた\r\n帰りゆく場所は夢の中\r\n零れ落ちた 先で出会った\r\nただ秘密を抱え\r\n普通のふりをした あなたと\r\n探し諦めた\r\n私の居場所は作るものだった\r\nあの日交わした\r\n血に勝るもの\r\n心たちの契約を\r\n手を繋ぎ帰ろうか\r\n今日は何食べようか\r\n「こんなことがあった」って\r\n君と話したかったんだ\r\nいつの日も\r\n君となら喜劇よ\r\n踊る軋むベッドで\r\n笑い転げたままで\r\nふざけた生活はつづくさ\r\n劣ってると 言われ育った\r\nこのいかれた星で\r\n普通のふりをして 気づいた\r\n誰が決めつけた\r\n私の光はただ此処にあった\r\nあの日ほどけた\r\n淡い呪いに\r\n心からのさよならを\r\n顔上げて帰ろうか\r\n咲き誇る花々\r\n「こんな綺麗なんだ」って\r\n君と話したかったんだ\r\nどんな日も\r\n君といる奇跡を\r\n命繫ぐキッチンで\r\n伝えきれないままで\r\nふざけた生活はつづく\r\n仕事明けに\r\n歩む共に\r\n朝陽が登るわ ああ\r\nありがとうでは\r\n足りないから\r\n手を繋ぎ\r\nさあうちに帰ろうか\r\n今日は何食べようか\r\n「こんなことがあった」って\r\n君と話したかったんだ\r\nいつの日も\r\n君となら喜劇よ\r\n踊る軋むベッドで\r\n笑い転げたままで\r\n永遠を探そうか\r\nできるだけ暮らそうか\r\nどんなことがあったって\r\n君と話したかったんだ\r\nいつまでも\r\n君となら喜劇よ\r\n分かち合えた日々に\r\n笑い転げた先に\r\nふざけた生活はつづくさ\r\n");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Hello":
                    PlayList.Rows.Add("EN", Properties.Resources.Hello, 0, "Hello", "Adele", "3:48", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Hello - Adele.wav", "Hello, it's me\r\nI was wondering if after all these years you'd like to meet\r\nTo go over everything\r\nThey say that time's supposed to heal ya, but I ain't done much healing\r\nHello, can you hear me?\r\nI'm in California dreaming about who we used to be\r\nWhen we were younger and free\r\nI've forgotten how it felt before the world fell at our feet\r\nThere's such a difference between us\r\nAnd a million miles\r\nHello from the other side\r\nI must've called a thousand times\r\nTo tell you I'm sorry for everything that I've done\r\nBut when I call, you never seem to be home\r\nHello from the outside\r\nAt least I can say that I've tried\r\nTo tell you I'm sorry for breaking your heart\r\nBut it don't matter, it clearly doesn't tear you apart anymore\r\nHello, how are you?\r\nIt's so typical of me to talk about myself, I'm sorry\r\nI hope that you're well\r\nDid you ever make it out of that town where nothing ever happened?\r\nIt's no secret that the both of us\r\nAre running out of time\r\nSo hello from the other side (other side)\r\nI must've called a thousand times (thousand times)\r\nTo tell you I'm sorry for everything that I've done\r\nBut when I call, you never seem to be home\r\nHello from the outside (outside)\r\nAt least I can say that I've tried (I've tried)\r\nTo tell you I'm sorry for breaking your heart\r\nBut it don't matter, it clearly doesn't tear you apart anymore\r\nOoh (lows, lows, lows, lows), anymore\r\n(Highs, highs, highs, highs)\r\nOoh (lows, lows, lows, lows), anymore\r\n(Highs, highs, highs, highs)\r\nOoh (lows, lows, lows, lows), anymore\r\n(Highs, highs, highs, highs)\r\nAnymore (lows, lows, lows, lows)\r\nHello from the other side (other side)\r\nI must've called a thousand times (thousand times)\r\nTo tell you I'm sorry for everything that I've done\r\nBut when I call, you never seem to be home\r\nHello from the outside (outside)\r\nAt least I can say that I've tried (I've tried)\r\nTo tell you I'm sorry for breaking your heart\r\nBut it don't matter, it clearly doesn't tear you apart anymore");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Hero":
                    PlayList.Rows.Add("EN", Properties.Resources.Hero, 0, "Hero", "Cash Cash", "3:20", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Hero - Cash Cash - Christina Perri.wav", "I let my soul fall into you\r\nI never thought I'd fall right through\r\nI fell for every word you said\r\nYou made me feel I needed you\r\nAnd forced my heart to think it's true\r\nBut I found I'm powerless with you\r\nNow I don't need your wings to fly\r\nNo, I don't need a hand to hold in mine this time\r\nYou held me down, but I broke free\r\nI found the love inside of me\r\nNow I don't need a hero to survive\r\n'Cause I already saved my life\r\n'Cause I already saved my life\r\nI fell into your fantasy\r\nBut that's all our love will ever be\r\nI lost hope in saving you and me\r\nYou think I'm lost, falling apart\r\nBut your lies just made a stronger heart\r\nMy life is just about to start\r\nNow I don't need your wings to fly\r\nNo, I don't need a hand to hold in mine this time\r\nYou held me down, but I broke free\r\nI found the love inside of me\r\nNow I don't need a hero to survive\r\n'Cause I already saved my life\r\nAlready saved my life\r\nI already saved my life\r\nAlready saved my life\r\nI already saved my life\r\nNow I don't need your wings to fly\r\nNo, I don't need a hand to hold in mine this time\r\nYou held me down, but I broke free\r\nI found the love inside of me\r\nNow I don't need a hero to survive\r\n'Cause I already saved my life\r\nAlready saved my life\r\nI already saved my life\r\nAlready saved my life\r\nI already saved my life\r\nNow I don't need your wings to fly");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Immortals":
                    PlayList.Rows.Add("EN", Properties.Resources.immortals, 0, "Immortals", "Fall Out Boy", "3:50", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Immortals - Fall Out Boy.wav", "They say we are what we are, but we don't have to be\r\nI'm bad behavior but I do it in the best way\r\nI'll be the watcher (watcher) of the eternal flame\r\nI'll be the guard dog of all your fever dreams\r\n\r\nOh, I am the sand in the bottom half of the hourglass, glass, glass\r\nOh, I try to picture me without you, but I can't\r\n\r\n'Cause we could be immortals, immortals\r\nJust not for long, for long\r\nAnd live with me forever now, pull the blackout curtains down\r\nJust not for long, for long\r\n\r\nWe could be immor—immortals, immor—immortals\r\nImmor—immortals, immor—immortals, immortals\r\n\r\nSometimes the only payoff for having any faith\r\nIs when it's tested again and again every day\r\nI'm still comparing your past to my future\r\nIt might be your wound, but they're my sutures\r\n\r\nOh, I am the sand in the bottom half of the hourglass, glass, glass\r\nOh, I try to picture me without you, but I can't\r\n\r\n'Cause we could be immortals, immortals\r\nJust not for long, for long\r\nAnd live with me forever now, pull the blackout curtains down\r\nJust not for long, for long\r\n\r\nWe could be immor—immortals, immor—immortals, immortals\r\n\r\nAnd live with me forever now\r\nPull the blackout curtains down\r\n\r\nWe could be immortals, immortals\r\nJust not for long, for long\r\n\r\nWe could be immor—immortals, immor—immortals\r\nImmor—immortals, immor—immortals, immortals\r\n");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Liar":
                    PlayList.Rows.Add("EN", Properties.Resources.Liar, 0, "Liar", "Camila Cabello", "3:53", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Liar - Camila Cabello.wav", "I don't care, if you're here\r\nOr if you're not alone\r\nI don't care, it's been too long\r\nIt's kinda like we didn't happen\r\nThe way that your lips move\r\nThe way you whisper slow\r\nI don't care, it's good, it's gone (uh)\r\nI said, I won't lose control, I don't want it (ooh)\r\nI said, I won't get too close but I can't stop it\r\nOh, no, there you go, making me a liar\r\nGot me begging you for more\r\nOh, no, there I go, startin' up a fire, oh, no, no\r\nOh, no, there you go, you're making me a liar, I kinda like it though\r\nOh, no, there I go, startin' up a fire, oh, no, no (ooh)\r\nYou're watching, I feel it (hey)\r\nI know I shouldn't stare (yeah, yeah)\r\nI picture your hands on me\r\nI think I wanna let it happen\r\nBut what if, you kiss me? (Yeah)\r\nAnd what if, I like it?\r\nAnd no one sees it\r\nI said, I won't lose control, I don't want it (ooh)\r\nI said, I won't get too close but I can't stop it (no)\r\nOh, no, there you go, making me a liar\r\nGot me begging you for more\r\nOh, no, there I go, startin' up a fire, oh, no, no\r\nOh, no, there you go, you're making me a liar, I kinda like it though\r\nOh, no, there I go, startin' up a fire, oh, no, no\r\nOh, no, no, no\r\nHere comes trouble, no, no\r\nStartin' up a fire\r\nI don't believe myself when I say\r\nThat I don't need you, oh\r\nI don't believe myself when I say\r\nSo, don't believe me\r\nOh, no, there you go, you're making me a liar\r\nGot me begging you for more\r\nOh, no, there I go, startin' up a fire, oh, no, no\r\nOh, no, there you go, making me a liar, I kinda like it though\r\nOh, no, there I go, startin' up a fire, oh, no, no\r\nYeah\r\nUh, yeah, yeah\r\nNah, yeah\r\nOh, no, no, no\r\nOh, no, no, no\r\nOh, no, you're making me a liar\r\n'Cause my clothes are on the floor\r\nHuh, huh, huh\r\nUh\r\nOh, no, no, no\r\nAnother fire");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Make you mine":
                    PlayList.Rows.Add("EN", Properties.Resources.make_you_mine, 0, "Make you mine", "PUBLIC", "3:37", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Make You Mine - PUBLIC.wav", "Well, I will call you darlin' and everything will be okay\r\n'Cause I know that I am yours and you are mine\r\nDoesn't matter anyway\r\nIn the night, we'll take a walk, it's nothing funny\r\nJust to talk\r\nPut your hand in mine\r\nYou know that I want to be with you all the time\r\nYou know that I won't stop until I make you mine\r\nYou know that I won't stop until I make you mine\r\nUntil I make you mine\r\nWell, I have called you darlin' and I'll say it again, again\r\nSo kiss me 'til I'm sorry, babe, that you are gone and I'm a mess\r\nAnd I'll hurt you and you'll hurt me and we'll say things we can't repeat\r\nPut your hand in mine\r\nYou know that I want to be with you all the time\r\nYou know that I won't stop until I make you mine\r\nYou know that I won't stop until I make you mine\r\nUntil I make you mine\r\nYou need to know\r\nWe'll take it slow\r\nI miss you so\r\nWe'll take it slow\r\nIt's hard to feel you slipping (You need to know)\r\nThrough my fingers are so numb (We'll take it slow)\r\nAnd how was I supposed to know (I miss you so)\r\nThat you were not the one?\r\nPut your hand in mine\r\nYou know that I want to be with you all the time\r\nYou know that I won't stop until I make you mine\r\nYou know that I won't stop until I make you mine\r\nUntil I make you mine\r\nPut your hand in mine\r\nYou know that I want to be with you all the time\r\nOh darlin', darlin', baby, you're so very fine\r\nYou know that I won't stop until I make you mine\r\nUntil I make you\r\nLa-la-la-la\r\nLa-la-la-la-la-la\r\nLa-la-la-la-la\r\nLa-la-la-la-la-la\r\nLa-la-la-la-la\r\nLa-la-la-la-la-la\r\nLa-la-la-la-la");
                    j++;
                    MessageBox.Show("1 song was added into your playlist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void pictureBox14_Click_1(object sender, EventArgs e)
        {
            panel_playlist.Visible = false;
        }
        private void pictureBox_playlists_Click(object sender, EventArgs e)
        {
            panel_playlist.Visible = true;

            viralcheck = 0;
            vncheck = 0;
            encheck = 0;

            label_list_count.Text = (j + 1).ToString();

            switch (j)
            {
                case -1:
                    panel_list_1.Visible = false;
                    panel_list_2.Visible = false;
                    panel_list_3.Visible = false;
                    panel_list_4.Visible = false;
                    panel_list_5.Visible = false;
                    panel_list_6.Visible = false;
                    panel_list_7.Visible = false;
                    panel_list_8.Visible = false;
                    panel_list_9.Visible = false;
                    panel_list_10.Visible = false;
                    break;
                case 0:
                    panel_list_1.Visible = true;
                    panel_list_2.Visible = false;
                    panel_list_3.Visible = false;
                    panel_list_4.Visible = false;
                    panel_list_5.Visible = false;
                    panel_list_6.Visible = false;
                    panel_list_7.Visible = false;
                    panel_list_8.Visible = false;
                    panel_list_9.Visible = false;
                    panel_list_10.Visible = false;

                    pictureBox36.BackgroundImage = (Image)PlayList.Rows[0]["hinhanh"];
                    label_list_1.Text = PlayList.Rows[0]["tenbaihat"].ToString();
                    label_list_2.Text = PlayList.Rows[0]["tencasi"].ToString();
                    label_list_3.Text = PlayList.Rows[0]["tenbaihat"].ToString();
                    label_list_4.Text = PlayList.Rows[0]["thoiluong"].ToString();

                    break;
                case 1:
                    panel_list_1.Visible = true;
                    panel_list_2.Visible = true;
                    panel_list_3.Visible = false;
                    panel_list_4.Visible = false;
                    panel_list_5.Visible = false;
                    panel_list_6.Visible = false;
                    panel_list_7.Visible = false;
                    panel_list_8.Visible = false;
                    panel_list_9.Visible = false;
                    panel_list_10.Visible = false;

                    pictureBox36.BackgroundImage = (Image)PlayList.Rows[0]["hinhanh"];
                    label_list_1.Text = PlayList.Rows[0]["tenbaihat"].ToString();
                    label_list_2.Text = PlayList.Rows[0]["tencasi"].ToString();
                    label_list_3.Text = PlayList.Rows[0]["tenbaihat"].ToString();
                    label_list_4.Text = PlayList.Rows[0]["thoiluong"].ToString();

                    pictureBox35.BackgroundImage = (Image)PlayList.Rows[1]["hinhanh"];
                    label_list_5.Text = PlayList.Rows[1]["tenbaihat"].ToString();
                    label_list_6.Text = PlayList.Rows[1]["tencasi"].ToString();
                    label_list_7.Text = PlayList.Rows[1]["tenbaihat"].ToString();
                    label_list_8.Text = PlayList.Rows[1]["thoiluong"].ToString();

                    break;
                case 2:
                    panel_list_1.Visible = true;
                    panel_list_2.Visible = true;
                    panel_list_3.Visible = true;
                    panel_list_4.Visible = false;
                    panel_list_5.Visible = false;
                    panel_list_6.Visible = false;
                    panel_list_7.Visible = false;
                    panel_list_8.Visible = false;
                    panel_list_9.Visible = false;
                    panel_list_10.Visible = false;

                    pictureBox36.BackgroundImage = (Image)PlayList.Rows[0]["hinhanh"];
                    label_list_1.Text = PlayList.Rows[0]["tenbaihat"].ToString();
                    label_list_2.Text = PlayList.Rows[0]["tencasi"].ToString();
                    label_list_3.Text = PlayList.Rows[0]["tenbaihat"].ToString();
                    label_list_4.Text = PlayList.Rows[0]["thoiluong"].ToString();

                    pictureBox35.BackgroundImage = (Image)PlayList.Rows[1]["hinhanh"];
                    label_list_5.Text = PlayList.Rows[1]["tenbaihat"].ToString();
                    label_list_6.Text = PlayList.Rows[1]["tencasi"].ToString();
                    label_list_7.Text = PlayList.Rows[1]["tenbaihat"].ToString();
                    label_list_8.Text = PlayList.Rows[1]["thoiluong"].ToString();

                    pictureBox34.BackgroundImage = (Image)PlayList.Rows[2]["hinhanh"];
                    label_list_9.Text = PlayList.Rows[2]["tenbaihat"].ToString();
                    label_list_10.Text = PlayList.Rows[2]["tencasi"].ToString();
                    label_list_11.Text = PlayList.Rows[2]["tenbaihat"].ToString();
                    label_list_12.Text = PlayList.Rows[2]["thoiluong"].ToString();

                    break;
                case 3:
                    panel_list_1.Visible = true;
                    panel_list_2.Visible = true;
                    panel_list_3.Visible = true;
                    panel_list_4.Visible = true;
                    panel_list_5.Visible = false;
                    panel_list_6.Visible = false;
                    panel_list_7.Visible = false;
                    panel_list_8.Visible = false;
                    panel_list_9.Visible = false;
                    panel_list_10.Visible = false;

                    pictureBox36.BackgroundImage = (Image)PlayList.Rows[0]["hinhanh"];
                    label_list_1.Text = PlayList.Rows[0]["tenbaihat"].ToString();
                    label_list_2.Text = PlayList.Rows[0]["tencasi"].ToString();
                    label_list_3.Text = PlayList.Rows[0]["tenbaihat"].ToString();
                    label_list_4.Text = PlayList.Rows[0]["thoiluong"].ToString();

                    pictureBox35.BackgroundImage = (Image)PlayList.Rows[1]["hinhanh"];
                    label_list_5.Text = PlayList.Rows[1]["tenbaihat"].ToString();
                    label_list_6.Text = PlayList.Rows[1]["tencasi"].ToString();
                    label_list_7.Text = PlayList.Rows[1]["tenbaihat"].ToString();
                    label_list_8.Text = PlayList.Rows[1]["thoiluong"].ToString();

                    pictureBox34.BackgroundImage = (Image)PlayList.Rows[2]["hinhanh"];
                    label_list_9.Text = PlayList.Rows[2]["tenbaihat"].ToString();
                    label_list_10.Text = PlayList.Rows[2]["tencasi"].ToString();
                    label_list_11.Text = PlayList.Rows[2]["tenbaihat"].ToString();
                    label_list_12.Text = PlayList.Rows[2]["thoiluong"].ToString();

                    pictureBox33.BackgroundImage = (Image)PlayList.Rows[3]["hinhanh"];
                    label_list_13.Text = PlayList.Rows[3]["tenbaihat"].ToString();
                    label_list_14.Text = PlayList.Rows[3]["tencasi"].ToString();
                    label_list_15.Text = PlayList.Rows[3]["tenbaihat"].ToString();
                    label_list_16.Text = PlayList.Rows[3]["thoiluong"].ToString();

                    break;
                case 4:
                    panel_list_1.Visible = true;
                    panel_list_2.Visible = true;
                    panel_list_3.Visible = true;
                    panel_list_4.Visible = true;
                    panel_list_5.Visible = true;
                    panel_list_6.Visible = false;
                    panel_list_7.Visible = false;
                    panel_list_8.Visible = false;
                    panel_list_9.Visible = false;
                    panel_list_10.Visible = false;
                    pictureBox36.BackgroundImage = (Image)PlayList.Rows[0]["hinhanh"];
                    label_list_1.Text = PlayList.Rows[0]["tenbaihat"].ToString();
                    label_list_2.Text = PlayList.Rows[0]["tencasi"].ToString();
                    label_list_3.Text = PlayList.Rows[0]["tenbaihat"].ToString();
                    label_list_4.Text = PlayList.Rows[0]["thoiluong"].ToString();

                    pictureBox35.BackgroundImage = (Image)PlayList.Rows[1]["hinhanh"];
                    label_list_5.Text = PlayList.Rows[1]["tenbaihat"].ToString();
                    label_list_6.Text = PlayList.Rows[1]["tencasi"].ToString();
                    label_list_7.Text = PlayList.Rows[1]["tenbaihat"].ToString();
                    label_list_8.Text = PlayList.Rows[1]["thoiluong"].ToString();

                    pictureBox34.BackgroundImage = (Image)PlayList.Rows[2]["hinhanh"];
                    label_list_9.Text = PlayList.Rows[2]["tenbaihat"].ToString();
                    label_list_10.Text = PlayList.Rows[2]["tencasi"].ToString();
                    label_list_11.Text = PlayList.Rows[2]["tenbaihat"].ToString();
                    label_list_12.Text = PlayList.Rows[2]["thoiluong"].ToString();

                    pictureBox33.BackgroundImage = (Image)PlayList.Rows[3]["hinhanh"];
                    label_list_13.Text = PlayList.Rows[3]["tenbaihat"].ToString();
                    label_list_14.Text = PlayList.Rows[3]["tencasi"].ToString();
                    label_list_15.Text = PlayList.Rows[3]["tenbaihat"].ToString();
                    label_list_16.Text = PlayList.Rows[3]["thoiluong"].ToString();

                    pictureBox32.BackgroundImage = (Image)PlayList.Rows[4]["hinhanh"];
                    label_list_17.Text = PlayList.Rows[4]["tenbaihat"].ToString();
                    label_list_18.Text = PlayList.Rows[4]["tencasi"].ToString();
                    label_list_19.Text = PlayList.Rows[4]["tenbaihat"].ToString();
                    label_list_20.Text = PlayList.Rows[4]["thoiluong"].ToString();

                    break;
                case 5:
                    panel_list_1.Visible = true;
                    panel_list_2.Visible = true;
                    panel_list_3.Visible = true;
                    panel_list_4.Visible = true;
                    panel_list_5.Visible = true;
                    panel_list_6.Visible = true;
                    panel_list_7.Visible = false;
                    panel_list_8.Visible = false;
                    panel_list_9.Visible = false;
                    panel_list_10.Visible = false;

                    pictureBox36.BackgroundImage = (Image)PlayList.Rows[0]["hinhanh"];
                    label_list_1.Text = PlayList.Rows[0]["tenbaihat"].ToString();
                    label_list_2.Text = PlayList.Rows[0]["tencasi"].ToString();
                    label_list_3.Text = PlayList.Rows[0]["tenbaihat"].ToString();
                    label_list_4.Text = PlayList.Rows[0]["thoiluong"].ToString();

                    pictureBox35.BackgroundImage = (Image)PlayList.Rows[1]["hinhanh"];
                    label_list_5.Text = PlayList.Rows[1]["tenbaihat"].ToString();
                    label_list_6.Text = PlayList.Rows[1]["tencasi"].ToString();
                    label_list_7.Text = PlayList.Rows[1]["tenbaihat"].ToString();
                    label_list_8.Text = PlayList.Rows[1]["thoiluong"].ToString();

                    pictureBox34.BackgroundImage = (Image)PlayList.Rows[2]["hinhanh"];
                    label_list_9.Text = PlayList.Rows[2]["tenbaihat"].ToString();
                    label_list_10.Text = PlayList.Rows[2]["tencasi"].ToString();
                    label_list_11.Text = PlayList.Rows[2]["tenbaihat"].ToString();
                    label_list_12.Text = PlayList.Rows[2]["thoiluong"].ToString();

                    pictureBox33.BackgroundImage = (Image)PlayList.Rows[3]["hinhanh"];
                    label_list_13.Text = PlayList.Rows[3]["tenbaihat"].ToString();
                    label_list_14.Text = PlayList.Rows[3]["tencasi"].ToString();
                    label_list_15.Text = PlayList.Rows[3]["tenbaihat"].ToString();
                    label_list_16.Text = PlayList.Rows[3]["thoiluong"].ToString();

                    pictureBox32.BackgroundImage = (Image)PlayList.Rows[4]["hinhanh"];
                    label_list_17.Text = PlayList.Rows[4]["tenbaihat"].ToString();
                    label_list_18.Text = PlayList.Rows[4]["tencasi"].ToString();
                    label_list_19.Text = PlayList.Rows[4]["tenbaihat"].ToString();
                    label_list_20.Text = PlayList.Rows[4]["thoiluong"].ToString();

                    pictureBox31.BackgroundImage = (Image)PlayList.Rows[5]["hinhanh"];
                    label_list_21.Text = PlayList.Rows[5]["tenbaihat"].ToString();
                    label_list_22.Text = PlayList.Rows[5]["tencasi"].ToString();
                    label_list_23.Text = PlayList.Rows[5]["tenbaihat"].ToString();
                    label_list_24.Text = PlayList.Rows[5]["thoiluong"].ToString();

                    break;
                case 6:
                    panel_list_1.Visible = true;
                    panel_list_2.Visible = true;
                    panel_list_3.Visible = true;
                    panel_list_4.Visible = true;
                    panel_list_5.Visible = true;
                    panel_list_6.Visible = true;
                    panel_list_7.Visible = true;
                    panel_list_8.Visible = false;
                    panel_list_9.Visible = false;
                    panel_list_10.Visible = false;

                    pictureBox36.BackgroundImage = (Image)PlayList.Rows[0]["hinhanh"];
                    label_list_1.Text = PlayList.Rows[0]["tenbaihat"].ToString();
                    label_list_2.Text = PlayList.Rows[0]["tencasi"].ToString();
                    label_list_3.Text = PlayList.Rows[0]["tenbaihat"].ToString();
                    label_list_4.Text = PlayList.Rows[0]["thoiluong"].ToString();

                    pictureBox35.BackgroundImage = (Image)PlayList.Rows[1]["hinhanh"];
                    label_list_5.Text = PlayList.Rows[1]["tenbaihat"].ToString();
                    label_list_6.Text = PlayList.Rows[1]["tencasi"].ToString();
                    label_list_7.Text = PlayList.Rows[1]["tenbaihat"].ToString();
                    label_list_8.Text = PlayList.Rows[1]["thoiluong"].ToString();

                    pictureBox34.BackgroundImage = (Image)PlayList.Rows[2]["hinhanh"];
                    label_list_9.Text = PlayList.Rows[2]["tenbaihat"].ToString();
                    label_list_10.Text = PlayList.Rows[2]["tencasi"].ToString();
                    label_list_11.Text = PlayList.Rows[2]["tenbaihat"].ToString();
                    label_list_12.Text = PlayList.Rows[2]["thoiluong"].ToString();

                    pictureBox33.BackgroundImage = (Image)PlayList.Rows[3]["hinhanh"];
                    label_list_13.Text = PlayList.Rows[3]["tenbaihat"].ToString();
                    label_list_14.Text = PlayList.Rows[3]["tencasi"].ToString();
                    label_list_15.Text = PlayList.Rows[3]["tenbaihat"].ToString();
                    label_list_16.Text = PlayList.Rows[3]["thoiluong"].ToString();

                    pictureBox32.BackgroundImage = (Image)PlayList.Rows[4]["hinhanh"];
                    label_list_17.Text = PlayList.Rows[4]["tenbaihat"].ToString();
                    label_list_18.Text = PlayList.Rows[4]["tencasi"].ToString();
                    label_list_19.Text = PlayList.Rows[4]["tenbaihat"].ToString();
                    label_list_20.Text = PlayList.Rows[4]["thoiluong"].ToString();

                    pictureBox31.BackgroundImage = (Image)PlayList.Rows[5]["hinhanh"];
                    label_list_21.Text = PlayList.Rows[5]["tenbaihat"].ToString();
                    label_list_22.Text = PlayList.Rows[5]["tencasi"].ToString();
                    label_list_23.Text = PlayList.Rows[5]["tenbaihat"].ToString();
                    label_list_24.Text = PlayList.Rows[5]["thoiluong"].ToString();

                    pictureBox30.BackgroundImage = (Image)PlayList.Rows[6]["hinhanh"];
                    label_list_25.Text = PlayList.Rows[6]["tenbaihat"].ToString();
                    label_list_26.Text = PlayList.Rows[6]["tencasi"].ToString();
                    label_list_27.Text = PlayList.Rows[6]["tenbaihat"].ToString();
                    label_list_28.Text = PlayList.Rows[6]["thoiluong"].ToString();

                    break;
                case 7:
                    panel_list_1.Visible = true;
                    panel_list_2.Visible = true;
                    panel_list_3.Visible = true;
                    panel_list_4.Visible = true;
                    panel_list_5.Visible = true;
                    panel_list_6.Visible = true;
                    panel_list_7.Visible = true;
                    panel_list_8.Visible = true;
                    panel_list_9.Visible = false;
                    panel_list_10.Visible = false;

                    pictureBox36.BackgroundImage = (Image)PlayList.Rows[0]["hinhanh"];
                    label_list_1.Text = PlayList.Rows[0]["tenbaihat"].ToString();
                    label_list_2.Text = PlayList.Rows[0]["tencasi"].ToString();
                    label_list_3.Text = PlayList.Rows[0]["tenbaihat"].ToString();
                    label_list_4.Text = PlayList.Rows[0]["thoiluong"].ToString();

                    pictureBox35.BackgroundImage = (Image)PlayList.Rows[1]["hinhanh"];
                    label_list_5.Text = PlayList.Rows[1]["tenbaihat"].ToString();
                    label_list_6.Text = PlayList.Rows[1]["tencasi"].ToString();
                    label_list_7.Text = PlayList.Rows[1]["tenbaihat"].ToString();
                    label_list_8.Text = PlayList.Rows[1]["thoiluong"].ToString();

                    pictureBox34.BackgroundImage = (Image)PlayList.Rows[2]["hinhanh"];
                    label_list_9.Text = PlayList.Rows[2]["tenbaihat"].ToString();
                    label_list_10.Text = PlayList.Rows[2]["tencasi"].ToString();
                    label_list_11.Text = PlayList.Rows[2]["tenbaihat"].ToString();
                    label_list_12.Text = PlayList.Rows[2]["thoiluong"].ToString();

                    pictureBox33.BackgroundImage = (Image)PlayList.Rows[3]["hinhanh"];
                    label_list_13.Text = PlayList.Rows[3]["tenbaihat"].ToString();
                    label_list_14.Text = PlayList.Rows[3]["tencasi"].ToString();
                    label_list_15.Text = PlayList.Rows[3]["tenbaihat"].ToString();
                    label_list_16.Text = PlayList.Rows[3]["thoiluong"].ToString();

                    pictureBox32.BackgroundImage = (Image)PlayList.Rows[4]["hinhanh"];
                    label_list_17.Text = PlayList.Rows[4]["tenbaihat"].ToString();
                    label_list_18.Text = PlayList.Rows[4]["tencasi"].ToString();
                    label_list_19.Text = PlayList.Rows[4]["tenbaihat"].ToString();
                    label_list_20.Text = PlayList.Rows[4]["thoiluong"].ToString();

                    pictureBox31.BackgroundImage = (Image)PlayList.Rows[5]["hinhanh"];
                    label_list_21.Text = PlayList.Rows[5]["tenbaihat"].ToString();
                    label_list_22.Text = PlayList.Rows[5]["tencasi"].ToString();
                    label_list_23.Text = PlayList.Rows[5]["tenbaihat"].ToString();
                    label_list_24.Text = PlayList.Rows[5]["thoiluong"].ToString();

                    pictureBox30.BackgroundImage = (Image)PlayList.Rows[6]["hinhanh"];
                    label_list_25.Text = PlayList.Rows[6]["tenbaihat"].ToString();
                    label_list_26.Text = PlayList.Rows[6]["tencasi"].ToString();
                    label_list_27.Text = PlayList.Rows[6]["tenbaihat"].ToString();
                    label_list_28.Text = PlayList.Rows[6]["thoiluong"].ToString();

                    pictureBox29.BackgroundImage = (Image)PlayList.Rows[7]["hinhanh"];
                    label_list_29.Text = PlayList.Rows[7]["tenbaihat"].ToString();
                    label_list_30.Text = PlayList.Rows[7]["tencasi"].ToString();
                    label_list_31.Text = PlayList.Rows[7]["tenbaihat"].ToString();
                    label_list_32.Text = PlayList.Rows[7]["thoiluong"].ToString();

                    break;
                case 8:
                    panel_list_1.Visible = true;
                    panel_list_2.Visible = true;
                    panel_list_3.Visible = true;
                    panel_list_4.Visible = true;
                    panel_list_5.Visible = true;
                    panel_list_6.Visible = true;
                    panel_list_7.Visible = true;
                    panel_list_8.Visible = true;
                    panel_list_9.Visible = true;
                    panel_list_10.Visible = false;

                    pictureBox36.BackgroundImage = (Image)PlayList.Rows[0]["hinhanh"];
                    label_list_1.Text = PlayList.Rows[0]["tenbaihat"].ToString();
                    label_list_2.Text = PlayList.Rows[0]["tencasi"].ToString();
                    label_list_3.Text = PlayList.Rows[0]["tenbaihat"].ToString();
                    label_list_4.Text = PlayList.Rows[0]["thoiluong"].ToString();

                    pictureBox35.BackgroundImage = (Image)PlayList.Rows[1]["hinhanh"];
                    label_list_5.Text = PlayList.Rows[1]["tenbaihat"].ToString();
                    label_list_6.Text = PlayList.Rows[1]["tencasi"].ToString();
                    label_list_7.Text = PlayList.Rows[1]["tenbaihat"].ToString();
                    label_list_8.Text = PlayList.Rows[1]["thoiluong"].ToString();

                    pictureBox34.BackgroundImage = (Image)PlayList.Rows[2]["hinhanh"];
                    label_list_9.Text = PlayList.Rows[2]["tenbaihat"].ToString();
                    label_list_10.Text = PlayList.Rows[2]["tencasi"].ToString();
                    label_list_11.Text = PlayList.Rows[2]["tenbaihat"].ToString();
                    label_list_12.Text = PlayList.Rows[2]["thoiluong"].ToString();

                    pictureBox33.BackgroundImage = (Image)PlayList.Rows[3]["hinhanh"];
                    label_list_13.Text = PlayList.Rows[3]["tenbaihat"].ToString();
                    label_list_14.Text = PlayList.Rows[3]["tencasi"].ToString();
                    label_list_15.Text = PlayList.Rows[3]["tenbaihat"].ToString();
                    label_list_16.Text = PlayList.Rows[3]["thoiluong"].ToString();

                    pictureBox32.BackgroundImage = (Image)PlayList.Rows[4]["hinhanh"];
                    label_list_17.Text = PlayList.Rows[4]["tenbaihat"].ToString();
                    label_list_18.Text = PlayList.Rows[4]["tencasi"].ToString();
                    label_list_19.Text = PlayList.Rows[4]["tenbaihat"].ToString();
                    label_list_20.Text = PlayList.Rows[4]["thoiluong"].ToString();

                    pictureBox31.BackgroundImage = (Image)PlayList.Rows[5]["hinhanh"];
                    label_list_21.Text = PlayList.Rows[5]["tenbaihat"].ToString();
                    label_list_22.Text = PlayList.Rows[5]["tencasi"].ToString();
                    label_list_23.Text = PlayList.Rows[5]["tenbaihat"].ToString();
                    label_list_24.Text = PlayList.Rows[5]["thoiluong"].ToString();

                    pictureBox30.BackgroundImage = (Image)PlayList.Rows[6]["hinhanh"];
                    label_list_25.Text = PlayList.Rows[6]["tenbaihat"].ToString();
                    label_list_26.Text = PlayList.Rows[6]["tencasi"].ToString();
                    label_list_27.Text = PlayList.Rows[6]["tenbaihat"].ToString();
                    label_list_28.Text = PlayList.Rows[6]["thoiluong"].ToString();

                    pictureBox29.BackgroundImage = (Image)PlayList.Rows[7]["hinhanh"];
                    label_list_29.Text = PlayList.Rows[7]["tenbaihat"].ToString();
                    label_list_30.Text = PlayList.Rows[7]["tencasi"].ToString();
                    label_list_31.Text = PlayList.Rows[7]["tenbaihat"].ToString();
                    label_list_32.Text = PlayList.Rows[7]["thoiluong"].ToString();

                    pictureBox28.BackgroundImage = (Image)PlayList.Rows[8]["hinhanh"];
                    label_list_33.Text = PlayList.Rows[8]["tenbaihat"].ToString();
                    label_list_34.Text = PlayList.Rows[8]["tencasi"].ToString();
                    label_list_35.Text = PlayList.Rows[8]["tenbaihat"].ToString();
                    label_list_36.Text = PlayList.Rows[8]["thoiluong"].ToString();
                    break;
                case 9:
                    panel_list_1.Visible = true;
                    panel_list_2.Visible = true;
                    panel_list_3.Visible = true;
                    panel_list_4.Visible = true;
                    panel_list_5.Visible = true;
                    panel_list_6.Visible = true;
                    panel_list_7.Visible = true;
                    panel_list_8.Visible = true;
                    panel_list_9.Visible = true;
                    panel_list_10.Visible = true;

                    pictureBox36.BackgroundImage = (Image)PlayList.Rows[0]["hinhanh"];
                    label_list_1.Text = PlayList.Rows[0]["tenbaihat"].ToString();
                    label_list_2.Text = PlayList.Rows[0]["tencasi"].ToString();
                    label_list_3.Text = PlayList.Rows[0]["tenbaihat"].ToString();
                    label_list_4.Text = PlayList.Rows[0]["thoiluong"].ToString();

                    pictureBox35.BackgroundImage = (Image)PlayList.Rows[1]["hinhanh"];
                    label_list_5.Text = PlayList.Rows[1]["tenbaihat"].ToString();
                    label_list_6.Text = PlayList.Rows[1]["tencasi"].ToString();
                    label_list_7.Text = PlayList.Rows[1]["tenbaihat"].ToString();
                    label_list_8.Text = PlayList.Rows[1]["thoiluong"].ToString();

                    pictureBox34.BackgroundImage = (Image)PlayList.Rows[2]["hinhanh"];
                    label_list_9.Text = PlayList.Rows[2]["tenbaihat"].ToString();
                    label_list_10.Text = PlayList.Rows[2]["tencasi"].ToString();
                    label_list_11.Text = PlayList.Rows[2]["tenbaihat"].ToString();
                    label_list_12.Text = PlayList.Rows[2]["thoiluong"].ToString();

                    pictureBox33.BackgroundImage = (Image)PlayList.Rows[3]["hinhanh"];
                    label_list_13.Text = PlayList.Rows[3]["tenbaihat"].ToString();
                    label_list_14.Text = PlayList.Rows[3]["tencasi"].ToString();
                    label_list_15.Text = PlayList.Rows[3]["tenbaihat"].ToString();
                    label_list_16.Text = PlayList.Rows[3]["thoiluong"].ToString();

                    pictureBox32.BackgroundImage = (Image)PlayList.Rows[4]["hinhanh"];
                    label_list_17.Text = PlayList.Rows[4]["tenbaihat"].ToString();
                    label_list_18.Text = PlayList.Rows[4]["tencasi"].ToString();
                    label_list_19.Text = PlayList.Rows[4]["tenbaihat"].ToString();
                    label_list_20.Text = PlayList.Rows[4]["thoiluong"].ToString();

                    pictureBox31.BackgroundImage = (Image)PlayList.Rows[5]["hinhanh"];
                    label_list_21.Text = PlayList.Rows[5]["tenbaihat"].ToString();
                    label_list_22.Text = PlayList.Rows[5]["tencasi"].ToString();
                    label_list_23.Text = PlayList.Rows[5]["tenbaihat"].ToString();
                    label_list_24.Text = PlayList.Rows[5]["thoiluong"].ToString();

                    pictureBox30.BackgroundImage = (Image)PlayList.Rows[6]["hinhanh"];
                    label_list_25.Text = PlayList.Rows[6]["tenbaihat"].ToString();
                    label_list_26.Text = PlayList.Rows[6]["tencasi"].ToString();
                    label_list_27.Text = PlayList.Rows[6]["tenbaihat"].ToString();
                    label_list_28.Text = PlayList.Rows[6]["thoiluong"].ToString();

                    pictureBox29.BackgroundImage = (Image)PlayList.Rows[7]["hinhanh"];
                    label_list_29.Text = PlayList.Rows[7]["tenbaihat"].ToString();
                    label_list_30.Text = PlayList.Rows[7]["tencasi"].ToString();
                    label_list_31.Text = PlayList.Rows[7]["tenbaihat"].ToString();
                    label_list_32.Text = PlayList.Rows[7]["thoiluong"].ToString();

                    pictureBox28.BackgroundImage = (Image)PlayList.Rows[8]["hinhanh"];
                    label_list_33.Text = PlayList.Rows[8]["tenbaihat"].ToString();
                    label_list_34.Text = PlayList.Rows[8]["tencasi"].ToString();
                    label_list_35.Text = PlayList.Rows[8]["tenbaihat"].ToString();
                    label_list_36.Text = PlayList.Rows[8]["thoiluong"].ToString();

                    pictureBox27.BackgroundImage = (Image)PlayList.Rows[9]["hinhanh"];
                    label_list_37.Text = PlayList.Rows[9]["tenbaihat"].ToString();
                    label_list_38.Text = PlayList.Rows[9]["tencasi"].ToString();
                    label_list_39.Text = PlayList.Rows[9]["tenbaihat"].ToString();
                    label_list_40.Text = PlayList.Rows[9]["thoiluong"].ToString();
                    break;
                default:
                    panel_list_1.Visible = true;
                    panel_list_2.Visible = true;
                    panel_list_3.Visible = true;
                    panel_list_4.Visible = true;
                    panel_list_5.Visible = true;
                    panel_list_6.Visible = true;
                    panel_list_7.Visible = true;
                    panel_list_8.Visible = true;
                    panel_list_9.Visible = true;
                    panel_list_10.Visible = true;

                    pictureBox36.BackgroundImage = (Image)PlayList.Rows[0]["hinhanh"];
                    label_list_1.Text = PlayList.Rows[0]["tenbaihat"].ToString();
                    label_list_2.Text = PlayList.Rows[0]["tencasi"].ToString();
                    label_list_3.Text = PlayList.Rows[0]["tenbaihat"].ToString();
                    label_list_4.Text = PlayList.Rows[0]["thoiluong"].ToString();

                    pictureBox35.BackgroundImage = (Image)PlayList.Rows[1]["hinhanh"];
                    label_list_5.Text = PlayList.Rows[1]["tenbaihat"].ToString();
                    label_list_6.Text = PlayList.Rows[1]["tencasi"].ToString();
                    label_list_7.Text = PlayList.Rows[1]["tenbaihat"].ToString();
                    label_list_8.Text = PlayList.Rows[1]["thoiluong"].ToString();

                    pictureBox34.BackgroundImage = (Image)PlayList.Rows[2]["hinhanh"];
                    label_list_9.Text = PlayList.Rows[2]["tenbaihat"].ToString();
                    label_list_10.Text = PlayList.Rows[2]["tencasi"].ToString();
                    label_list_11.Text = PlayList.Rows[2]["tenbaihat"].ToString();
                    label_list_12.Text = PlayList.Rows[2]["thoiluong"].ToString();

                    pictureBox33.BackgroundImage = (Image)PlayList.Rows[3]["hinhanh"];
                    label_list_13.Text = PlayList.Rows[3]["tenbaihat"].ToString();
                    label_list_14.Text = PlayList.Rows[3]["tencasi"].ToString();
                    label_list_15.Text = PlayList.Rows[3]["tenbaihat"].ToString();
                    label_list_16.Text = PlayList.Rows[3]["thoiluong"].ToString();

                    pictureBox32.BackgroundImage = (Image)PlayList.Rows[4]["hinhanh"];
                    label_list_17.Text = PlayList.Rows[4]["tenbaihat"].ToString();
                    label_list_18.Text = PlayList.Rows[4]["tencasi"].ToString();
                    label_list_19.Text = PlayList.Rows[4]["tenbaihat"].ToString();
                    label_list_20.Text = PlayList.Rows[4]["thoiluong"].ToString();

                    pictureBox31.BackgroundImage = (Image)PlayList.Rows[5]["hinhanh"];
                    label_list_21.Text = PlayList.Rows[5]["tenbaihat"].ToString();
                    label_list_22.Text = PlayList.Rows[5]["tencasi"].ToString();
                    label_list_23.Text = PlayList.Rows[5]["tenbaihat"].ToString();
                    label_list_24.Text = PlayList.Rows[5]["thoiluong"].ToString();

                    pictureBox30.BackgroundImage = (Image)PlayList.Rows[6]["hinhanh"];
                    label_list_25.Text = PlayList.Rows[6]["tenbaihat"].ToString();
                    label_list_26.Text = PlayList.Rows[6]["tencasi"].ToString();
                    label_list_27.Text = PlayList.Rows[6]["tenbaihat"].ToString();
                    label_list_28.Text = PlayList.Rows[6]["thoiluong"].ToString();

                    pictureBox29.BackgroundImage = (Image)PlayList.Rows[7]["hinhanh"];
                    label_list_29.Text = PlayList.Rows[7]["tenbaihat"].ToString();
                    label_list_30.Text = PlayList.Rows[7]["tencasi"].ToString();
                    label_list_31.Text = PlayList.Rows[7]["tenbaihat"].ToString();
                    label_list_32.Text = PlayList.Rows[7]["thoiluong"].ToString();

                    pictureBox28.BackgroundImage = (Image)PlayList.Rows[8]["hinhanh"];
                    label_list_33.Text = PlayList.Rows[8]["tenbaihat"].ToString();
                    label_list_34.Text = PlayList.Rows[8]["tencasi"].ToString();
                    label_list_35.Text = PlayList.Rows[8]["tenbaihat"].ToString();
                    label_list_36.Text = PlayList.Rows[8]["thoiluong"].ToString();

                    pictureBox27.BackgroundImage = (Image)PlayList.Rows[9]["hinhanh"];
                    label_list_37.Text = PlayList.Rows[9]["tenbaihat"].ToString();
                    label_list_38.Text = PlayList.Rows[9]["tencasi"].ToString();
                    label_list_39.Text = PlayList.Rows[9]["tenbaihat"].ToString();
                    label_list_40.Text = PlayList.Rows[9]["thoiluong"].ToString();
                    break;
            }
        }
        private void panel_like_10_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox17.BackgroundImage;
            label_songname.Text = label_like_37.Text;
            label_songartist.Text = label_like_38.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;

            switch (label_songname.Text)
            {
                case "NGTANOISE":
                    player.SoundLocation = (string)VIRALHITS.Rows[0]["baihat"];
                    break;

                case "QUERRY":
                    player.SoundLocation = (string)VIRALHITS.Rows[1]["baihat"];
                    break;

                case "TAYTO":
                    player.SoundLocation = (string)VIRALHITS.Rows[2]["baihat"];
                    break;

                case "THICHTHICH":
                    player.SoundLocation = (string)VIRALHITS.Rows[3]["baihat"];
                    break;

                case "tiny love":
                    player.SoundLocation = (string)VIRALHITS.Rows[4]["baihat"];
                    break;

                case "My House":
                    player.SoundLocation = (string)VIRALHITS.Rows[5]["baihat"];
                    break;

                case "New Genesis":
                    player.SoundLocation = (string)VIRALHITS.Rows[6]["baihat"];
                    break;

                case "Sorry":
                    player.SoundLocation = (string)VIRALHITS.Rows[7]["baihat"];
                    break;

                case "Sunflower":
                    player.SoundLocation = (string)VIRALHITS.Rows[8]["baihat"];
                    break;

                case "There for you":
                    player.SoundLocation = (string)VIRALHITS.Rows[9]["baihat"];
                    break;


                case "25":
                    player.SoundLocation = (string)VNHITS.Rows[0]["baihat"];
                    break;

                case "3107":
                    player.SoundLocation = (string)VNHITS.Rows[1]["baihat"];
                    break;

                case "AI BIET":
                    player.SoundLocation = (string)VNHITS.Rows[2]["baihat"];
                    break;

                case "CHIM SAU":
                    player.SoundLocation = (string)VNHITS.Rows[3]["baihat"];
                    break;

                case "CUA":
                    player.SoundLocation = (string)VNHITS.Rows[4]["baihat"];
                    break;

                case "GIAYPHUT":
                    player.SoundLocation = (string)VNHITS.Rows[5]["baihat"];
                    break;

                case "GU":
                    player.SoundLocation = (string)VNHITS.Rows[6]["baihat"];
                    break;

                case "HOLD MY HAND":
                    player.SoundLocation = (string)VNHITS.Rows[7]["baihat"];
                    break;

                case "ICEMAN":
                    player.SoundLocation = (string)VNHITS.Rows[8]["baihat"];
                    break;

                case "LOCHI":
                    player.SoundLocation = (string)VNHITS.Rows[9]["baihat"];
                    break;

                case "All We Know":
                    player.SoundLocation = (string)ENHITS.Rows[0]["baihat"];
                    break;

                case "Bad Habits":
                    player.SoundLocation = (string)ENHITS.Rows[1]["baihat"];
                    break;

                case "Better Now":
                    player.SoundLocation = (string)ENHITS.Rows[2]["baihat"];
                    break;

                case "Cake By The Ocean":
                    player.SoundLocation = (string)ENHITS.Rows[3]["baihat"];
                    break;

                case "Comedy":
                    player.SoundLocation = (string)ENHITS.Rows[4]["baihat"];
                    break;

                case "Hello":
                    player.SoundLocation = (string)ENHITS.Rows[5]["baihat"];
                    break;

                case "Hero":
                    player.SoundLocation = (string)ENHITS.Rows[6]["baihat"];
                    break;

                case "Immortals":
                    player.SoundLocation = (string)ENHITS.Rows[7]["baihat"];
                    break;

                case "Liar":
                    player.SoundLocation = (string)ENHITS.Rows[8]["baihat"];
                    break;

                case "Make you mine":
                    player.SoundLocation = (string)ENHITS.Rows[9]["baihat"];
                    break;
            }
            player.Play();
        }
        private void panel_like_9_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox18.BackgroundImage;
            label_songname.Text = label_like_33.Text;
            label_songartist.Text = label_like_34.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;

            switch (label_songname.Text)
            {
                case "NGTANOISE":
                    player.SoundLocation = (string)VIRALHITS.Rows[0]["baihat"];
                    break;

                case "QUERRY":
                    player.SoundLocation = (string)VIRALHITS.Rows[1]["baihat"];
                    break;

                case "TAYTO":
                    player.SoundLocation = (string)VIRALHITS.Rows[2]["baihat"];
                    break;

                case "THICHTHICH":
                    player.SoundLocation = (string)VIRALHITS.Rows[3]["baihat"];
                    break;

                case "tiny love":
                    player.SoundLocation = (string)VIRALHITS.Rows[4]["baihat"];
                    break;

                case "My House":
                    player.SoundLocation = (string)VIRALHITS.Rows[5]["baihat"];
                    break;

                case "New Genesis":
                    player.SoundLocation = (string)VIRALHITS.Rows[6]["baihat"];
                    break;

                case "Sorry":
                    player.SoundLocation = (string)VIRALHITS.Rows[7]["baihat"];
                    break;

                case "Sunflower":
                    player.SoundLocation = (string)VIRALHITS.Rows[8]["baihat"];
                    break;

                case "There for you":
                    player.SoundLocation = (string)VIRALHITS.Rows[9]["baihat"];
                    break;


                case "25":
                    player.SoundLocation = (string)VNHITS.Rows[0]["baihat"];
                    break;

                case "3107":
                    player.SoundLocation = (string)VNHITS.Rows[1]["baihat"];
                    break;

                case "AI BIET":
                    player.SoundLocation = (string)VNHITS.Rows[2]["baihat"];
                    break;

                case "CHIM SAU":
                    player.SoundLocation = (string)VNHITS.Rows[3]["baihat"];
                    break;

                case "CUA":
                    player.SoundLocation = (string)VNHITS.Rows[4]["baihat"];
                    break;

                case "GIAYPHUT":
                    player.SoundLocation = (string)VNHITS.Rows[5]["baihat"];
                    break;

                case "GU":
                    player.SoundLocation = (string)VNHITS.Rows[6]["baihat"];
                    break;

                case "HOLD MY HAND":
                    player.SoundLocation = (string)VNHITS.Rows[7]["baihat"];
                    break;

                case "ICEMAN":
                    player.SoundLocation = (string)VNHITS.Rows[8]["baihat"];
                    break;

                case "LOCHI":
                    player.SoundLocation = (string)VNHITS.Rows[9]["baihat"];
                    break;

                case "All We Know":
                    player.SoundLocation = (string)ENHITS.Rows[0]["baihat"];
                    break;

                case "Bad Habits":
                    player.SoundLocation = (string)ENHITS.Rows[1]["baihat"];
                    break;

                case "Better Now":
                    player.SoundLocation = (string)ENHITS.Rows[2]["baihat"];
                    break;

                case "Cake By The Ocean":
                    player.SoundLocation = (string)ENHITS.Rows[3]["baihat"];
                    break;

                case "Comedy":
                    player.SoundLocation = (string)ENHITS.Rows[4]["baihat"];
                    break;

                case "Hello":
                    player.SoundLocation = (string)ENHITS.Rows[5]["baihat"];
                    break;

                case "Hero":
                    player.SoundLocation = (string)ENHITS.Rows[6]["baihat"];
                    break;

                case "Immortals":
                    player.SoundLocation = (string)ENHITS.Rows[7]["baihat"];
                    break;

                case "Liar":
                    player.SoundLocation = (string)ENHITS.Rows[8]["baihat"];
                    break;

                case "Make you mine":
                    player.SoundLocation = (string)ENHITS.Rows[9]["baihat"];
                    break;
            }
            player.Play();
        }
        private void panel_like_8_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox19.BackgroundImage;
            label_songname.Text = label_like_29.Text;
            label_songartist.Text = label_like_30.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;

            switch (label_songname.Text)
            {
                case "NGTANOISE":
                    player.SoundLocation = (string)VIRALHITS.Rows[0]["baihat"];
                    break;

                case "QUERRY":
                    player.SoundLocation = (string)VIRALHITS.Rows[1]["baihat"];
                    break;

                case "TAYTO":
                    player.SoundLocation = (string)VIRALHITS.Rows[2]["baihat"];
                    break;

                case "THICHTHICH":
                    player.SoundLocation = (string)VIRALHITS.Rows[3]["baihat"];
                    break;

                case "tiny love":
                    player.SoundLocation = (string)VIRALHITS.Rows[4]["baihat"];
                    break;

                case "My House":
                    player.SoundLocation = (string)VIRALHITS.Rows[5]["baihat"];
                    break;

                case "New Genesis":
                    player.SoundLocation = (string)VIRALHITS.Rows[6]["baihat"];
                    break;

                case "Sorry":
                    player.SoundLocation = (string)VIRALHITS.Rows[7]["baihat"];
                    break;

                case "Sunflower":
                    player.SoundLocation = (string)VIRALHITS.Rows[8]["baihat"];
                    break;

                case "There for you":
                    player.SoundLocation = (string)VIRALHITS.Rows[9]["baihat"];
                    break;


                case "25":
                    player.SoundLocation = (string)VNHITS.Rows[0]["baihat"];
                    break;

                case "3107":
                    player.SoundLocation = (string)VNHITS.Rows[1]["baihat"];
                    break;

                case "AI BIET":
                    player.SoundLocation = (string)VNHITS.Rows[2]["baihat"];
                    break;

                case "CHIM SAU":
                    player.SoundLocation = (string)VNHITS.Rows[3]["baihat"];
                    break;

                case "CUA":
                    player.SoundLocation = (string)VNHITS.Rows[4]["baihat"];
                    break;

                case "GIAYPHUT":
                    player.SoundLocation = (string)VNHITS.Rows[5]["baihat"];
                    break;

                case "GU":
                    player.SoundLocation = (string)VNHITS.Rows[6]["baihat"];
                    break;

                case "HOLD MY HAND":
                    player.SoundLocation = (string)VNHITS.Rows[7]["baihat"];
                    break;

                case "ICEMAN":
                    player.SoundLocation = (string)VNHITS.Rows[8]["baihat"];
                    break;

                case "LOCHI":
                    player.SoundLocation = (string)VNHITS.Rows[9]["baihat"];
                    break;

                case "All We Know":
                    player.SoundLocation = (string)ENHITS.Rows[0]["baihat"];
                    break;

                case "Bad Habits":
                    player.SoundLocation = (string)ENHITS.Rows[1]["baihat"];
                    break;

                case "Better Now":
                    player.SoundLocation = (string)ENHITS.Rows[2]["baihat"];
                    break;

                case "Cake By The Ocean":
                    player.SoundLocation = (string)ENHITS.Rows[3]["baihat"];
                    break;

                case "Comedy":
                    player.SoundLocation = (string)ENHITS.Rows[4]["baihat"];
                    break;

                case "Hello":
                    player.SoundLocation = (string)ENHITS.Rows[5]["baihat"];
                    break;

                case "Hero":
                    player.SoundLocation = (string)ENHITS.Rows[6]["baihat"];
                    break;

                case "Immortals":
                    player.SoundLocation = (string)ENHITS.Rows[7]["baihat"];
                    break;

                case "Liar":
                    player.SoundLocation = (string)ENHITS.Rows[8]["baihat"];
                    break;

                case "Make you mine":
                    player.SoundLocation = (string)ENHITS.Rows[9]["baihat"];
                    break;
            }
            player.Play();
        }

        private void panel_like_7_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox20.BackgroundImage;
            label_songname.Text = label_like_25.Text;
            label_songartist.Text = label_like_26.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;

            switch (label_songname.Text)
            {
                case "NGTANOISE":
                    player.SoundLocation = (string)VIRALHITS.Rows[0]["baihat"];
                    break;

                case "QUERRY":
                    player.SoundLocation = (string)VIRALHITS.Rows[1]["baihat"];
                    break;

                case "TAYTO":
                    player.SoundLocation = (string)VIRALHITS.Rows[2]["baihat"];
                    break;

                case "THICHTHICH":
                    player.SoundLocation = (string)VIRALHITS.Rows[3]["baihat"];
                    break;

                case "tiny love":
                    player.SoundLocation = (string)VIRALHITS.Rows[4]["baihat"];
                    break;

                case "My House":
                    player.SoundLocation = (string)VIRALHITS.Rows[5]["baihat"];
                    break;

                case "New Genesis":
                    player.SoundLocation = (string)VIRALHITS.Rows[6]["baihat"];
                    break;

                case "Sorry":
                    player.SoundLocation = (string)VIRALHITS.Rows[7]["baihat"];
                    break;

                case "Sunflower":
                    player.SoundLocation = (string)VIRALHITS.Rows[8]["baihat"];
                    break;

                case "There for you":
                    player.SoundLocation = (string)VIRALHITS.Rows[9]["baihat"];
                    break;


                case "25":
                    player.SoundLocation = (string)VNHITS.Rows[0]["baihat"];
                    break;

                case "3107":
                    player.SoundLocation = (string)VNHITS.Rows[1]["baihat"];
                    break;

                case "AI BIET":
                    player.SoundLocation = (string)VNHITS.Rows[2]["baihat"];
                    break;

                case "CHIM SAU":
                    player.SoundLocation = (string)VNHITS.Rows[3]["baihat"];
                    break;

                case "CUA":
                    player.SoundLocation = (string)VNHITS.Rows[4]["baihat"];
                    break;

                case "GIAYPHUT":
                    player.SoundLocation = (string)VNHITS.Rows[5]["baihat"];
                    break;

                case "GU":
                    player.SoundLocation = (string)VNHITS.Rows[6]["baihat"];
                    break;

                case "HOLD MY HAND":
                    player.SoundLocation = (string)VNHITS.Rows[7]["baihat"];
                    break;

                case "ICEMAN":
                    player.SoundLocation = (string)VNHITS.Rows[8]["baihat"];
                    break;

                case "LOCHI":
                    player.SoundLocation = (string)VNHITS.Rows[9]["baihat"];
                    break;

                case "All We Know":
                    player.SoundLocation = (string)ENHITS.Rows[0]["baihat"];
                    break;

                case "Bad Habits":
                    player.SoundLocation = (string)ENHITS.Rows[1]["baihat"];
                    break;

                case "Better Now":
                    player.SoundLocation = (string)ENHITS.Rows[2]["baihat"];
                    break;

                case "Cake By The Ocean":
                    player.SoundLocation = (string)ENHITS.Rows[3]["baihat"];
                    break;

                case "Comedy":
                    player.SoundLocation = (string)ENHITS.Rows[4]["baihat"];
                    break;

                case "Hello":
                    player.SoundLocation = (string)ENHITS.Rows[5]["baihat"];
                    break;

                case "Hero":
                    player.SoundLocation = (string)ENHITS.Rows[6]["baihat"];
                    break;

                case "Immortals":
                    player.SoundLocation = (string)ENHITS.Rows[7]["baihat"];
                    break;

                case "Liar":
                    player.SoundLocation = (string)ENHITS.Rows[8]["baihat"];
                    break;

                case "Make you mine":
                    player.SoundLocation = (string)ENHITS.Rows[9]["baihat"];
                    break;
            }
            player.Play();
        }

        private void panel_like_6_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox21.BackgroundImage;
            label_songname.Text = label_like_21.Text;
            label_songartist.Text = label_like_22.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;

            switch (label_songname.Text)
            {
                case "NGTANOISE":
                    player.SoundLocation = (string)VIRALHITS.Rows[0]["baihat"];
                    break;

                case "QUERRY":
                    player.SoundLocation = (string)VIRALHITS.Rows[1]["baihat"];
                    break;

                case "TAYTO":
                    player.SoundLocation = (string)VIRALHITS.Rows[2]["baihat"];
                    break;

                case "THICHTHICH":
                    player.SoundLocation = (string)VIRALHITS.Rows[3]["baihat"];
                    break;

                case "tiny love":
                    player.SoundLocation = (string)VIRALHITS.Rows[4]["baihat"];
                    break;

                case "My House":
                    player.SoundLocation = (string)VIRALHITS.Rows[5]["baihat"];
                    break;

                case "New Genesis":
                    player.SoundLocation = (string)VIRALHITS.Rows[6]["baihat"];
                    break;

                case "Sorry":
                    player.SoundLocation = (string)VIRALHITS.Rows[7]["baihat"];
                    break;

                case "Sunflower":
                    player.SoundLocation = (string)VIRALHITS.Rows[8]["baihat"];
                    break;

                case "There for you":
                    player.SoundLocation = (string)VIRALHITS.Rows[9]["baihat"];
                    break;


                case "25":
                    player.SoundLocation = (string)VNHITS.Rows[0]["baihat"];
                    break;

                case "3107":
                    player.SoundLocation = (string)VNHITS.Rows[1]["baihat"];
                    break;

                case "AI BIET":
                    player.SoundLocation = (string)VNHITS.Rows[2]["baihat"];
                    break;

                case "CHIM SAU":
                    player.SoundLocation = (string)VNHITS.Rows[3]["baihat"];
                    break;

                case "CUA":
                    player.SoundLocation = (string)VNHITS.Rows[4]["baihat"];
                    break;

                case "GIAYPHUT":
                    player.SoundLocation = (string)VNHITS.Rows[5]["baihat"];
                    break;

                case "GU":
                    player.SoundLocation = (string)VNHITS.Rows[6]["baihat"];
                    break;

                case "HOLD MY HAND":
                    player.SoundLocation = (string)VNHITS.Rows[7]["baihat"];
                    break;

                case "ICEMAN":
                    player.SoundLocation = (string)VNHITS.Rows[8]["baihat"];
                    break;

                case "LOCHI":
                    player.SoundLocation = (string)VNHITS.Rows[9]["baihat"];
                    break;

                case "All We Know":
                    player.SoundLocation = (string)ENHITS.Rows[0]["baihat"];
                    break;

                case "Bad Habits":
                    player.SoundLocation = (string)ENHITS.Rows[1]["baihat"];
                    break;

                case "Better Now":
                    player.SoundLocation = (string)ENHITS.Rows[2]["baihat"];
                    break;

                case "Cake By The Ocean":
                    player.SoundLocation = (string)ENHITS.Rows[3]["baihat"];
                    break;

                case "Comedy":
                    player.SoundLocation = (string)ENHITS.Rows[4]["baihat"];
                    break;

                case "Hello":
                    player.SoundLocation = (string)ENHITS.Rows[5]["baihat"];
                    break;

                case "Hero":
                    player.SoundLocation = (string)ENHITS.Rows[6]["baihat"];
                    break;

                case "Immortals":
                    player.SoundLocation = (string)ENHITS.Rows[7]["baihat"];
                    break;

                case "Liar":
                    player.SoundLocation = (string)ENHITS.Rows[8]["baihat"];
                    break;

                case "Make you mine":
                    player.SoundLocation = (string)ENHITS.Rows[9]["baihat"];
                    break;
            }
            player.Play();
        }

        private void panel_like_5_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox22.BackgroundImage;
            label_songname.Text = label_like_17.Text;
            label_songartist.Text = label_like_18.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;

            switch (label_songname.Text)
            {
                case "NGTANOISE":
                    player.SoundLocation = (string)VIRALHITS.Rows[0]["baihat"];
                    break;

                case "QUERRY":
                    player.SoundLocation = (string)VIRALHITS.Rows[1]["baihat"];
                    break;

                case "TAYTO":
                    player.SoundLocation = (string)VIRALHITS.Rows[2]["baihat"];
                    break;

                case "THICHTHICH":
                    player.SoundLocation = (string)VIRALHITS.Rows[3]["baihat"];
                    break;

                case "tiny love":
                    player.SoundLocation = (string)VIRALHITS.Rows[4]["baihat"];
                    break;

                case "My House":
                    player.SoundLocation = (string)VIRALHITS.Rows[5]["baihat"];
                    break;

                case "New Genesis":
                    player.SoundLocation = (string)VIRALHITS.Rows[6]["baihat"];
                    break;

                case "Sorry":
                    player.SoundLocation = (string)VIRALHITS.Rows[7]["baihat"];
                    break;

                case "Sunflower":
                    player.SoundLocation = (string)VIRALHITS.Rows[8]["baihat"];
                    break;

                case "There for you":
                    player.SoundLocation = (string)VIRALHITS.Rows[9]["baihat"];
                    break;


                case "25":
                    player.SoundLocation = (string)VNHITS.Rows[0]["baihat"];
                    break;

                case "3107":
                    player.SoundLocation = (string)VNHITS.Rows[1]["baihat"];
                    break;

                case "AI BIET":
                    player.SoundLocation = (string)VNHITS.Rows[2]["baihat"];
                    break;

                case "CHIM SAU":
                    player.SoundLocation = (string)VNHITS.Rows[3]["baihat"];
                    break;

                case "CUA":
                    player.SoundLocation = (string)VNHITS.Rows[4]["baihat"];
                    break;

                case "GIAYPHUT":
                    player.SoundLocation = (string)VNHITS.Rows[5]["baihat"];
                    break;

                case "GU":
                    player.SoundLocation = (string)VNHITS.Rows[6]["baihat"];
                    break;

                case "HOLD MY HAND":
                    player.SoundLocation = (string)VNHITS.Rows[7]["baihat"];
                    break;

                case "ICEMAN":
                    player.SoundLocation = (string)VNHITS.Rows[8]["baihat"];
                    break;

                case "LOCHI":
                    player.SoundLocation = (string)VNHITS.Rows[9]["baihat"];
                    break;

                case "All We Know":
                    player.SoundLocation = (string)ENHITS.Rows[0]["baihat"];
                    break;

                case "Bad Habits":
                    player.SoundLocation = (string)ENHITS.Rows[1]["baihat"];
                    break;

                case "Better Now":
                    player.SoundLocation = (string)ENHITS.Rows[2]["baihat"];
                    break;

                case "Cake By The Ocean":
                    player.SoundLocation = (string)ENHITS.Rows[3]["baihat"];
                    break;

                case "Comedy":
                    player.SoundLocation = (string)ENHITS.Rows[4]["baihat"];
                    break;

                case "Hello":
                    player.SoundLocation = (string)ENHITS.Rows[5]["baihat"];
                    break;

                case "Hero":
                    player.SoundLocation = (string)ENHITS.Rows[6]["baihat"];
                    break;

                case "Immortals":
                    player.SoundLocation = (string)ENHITS.Rows[7]["baihat"];
                    break;

                case "Liar":
                    player.SoundLocation = (string)ENHITS.Rows[8]["baihat"];
                    break;

                case "Make you mine":
                    player.SoundLocation = (string)ENHITS.Rows[9]["baihat"];
                    break;
            }
            player.Play();
        }

        private void panel_like_4_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox23.BackgroundImage;
            label_songname.Text = label_like_13.Text;
            label_songartist.Text = label_like_14.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;

            switch (label_songname.Text)
            {
                case "NGTANOISE":
                    player.SoundLocation = (string)VIRALHITS.Rows[0]["baihat"];
                    break;

                case "QUERRY":
                    player.SoundLocation = (string)VIRALHITS.Rows[1]["baihat"];
                    break;

                case "TAYTO":
                    player.SoundLocation = (string)VIRALHITS.Rows[2]["baihat"];
                    break;

                case "THICHTHICH":
                    player.SoundLocation = (string)VIRALHITS.Rows[3]["baihat"];
                    break;

                case "tiny love":
                    player.SoundLocation = (string)VIRALHITS.Rows[4]["baihat"];
                    break;

                case "My House":
                    player.SoundLocation = (string)VIRALHITS.Rows[5]["baihat"];
                    break;

                case "New Genesis":
                    player.SoundLocation = (string)VIRALHITS.Rows[6]["baihat"];
                    break;

                case "Sorry":
                    player.SoundLocation = (string)VIRALHITS.Rows[7]["baihat"];
                    break;

                case "Sunflower":
                    player.SoundLocation = (string)VIRALHITS.Rows[8]["baihat"];
                    break;

                case "There for you":
                    player.SoundLocation = (string)VIRALHITS.Rows[9]["baihat"];
                    break;


                case "25":
                    player.SoundLocation = (string)VNHITS.Rows[0]["baihat"];
                    break;

                case "3107":
                    player.SoundLocation = (string)VNHITS.Rows[1]["baihat"];
                    break;

                case "AI BIET":
                    player.SoundLocation = (string)VNHITS.Rows[2]["baihat"];
                    break;

                case "CHIM SAU":
                    player.SoundLocation = (string)VNHITS.Rows[3]["baihat"];
                    break;

                case "CUA":
                    player.SoundLocation = (string)VNHITS.Rows[4]["baihat"];
                    break;

                case "GIAYPHUT":
                    player.SoundLocation = (string)VNHITS.Rows[5]["baihat"];
                    break;

                case "GU":
                    player.SoundLocation = (string)VNHITS.Rows[6]["baihat"];
                    break;

                case "HOLD MY HAND":
                    player.SoundLocation = (string)VNHITS.Rows[7]["baihat"];
                    break;

                case "ICEMAN":
                    player.SoundLocation = (string)VNHITS.Rows[8]["baihat"];
                    break;

                case "LOCHI":
                    player.SoundLocation = (string)VNHITS.Rows[9]["baihat"];
                    break;

                case "All We Know":
                    player.SoundLocation = (string)ENHITS.Rows[0]["baihat"];
                    break;

                case "Bad Habits":
                    player.SoundLocation = (string)ENHITS.Rows[1]["baihat"];
                    break;

                case "Better Now":
                    player.SoundLocation = (string)ENHITS.Rows[2]["baihat"];
                    break;

                case "Cake By The Ocean":
                    player.SoundLocation = (string)ENHITS.Rows[3]["baihat"];
                    break;

                case "Comedy":
                    player.SoundLocation = (string)ENHITS.Rows[4]["baihat"];
                    break;

                case "Hello":
                    player.SoundLocation = (string)ENHITS.Rows[5]["baihat"];
                    break;

                case "Hero":
                    player.SoundLocation = (string)ENHITS.Rows[6]["baihat"];
                    break;

                case "Immortals":
                    player.SoundLocation = (string)ENHITS.Rows[7]["baihat"];
                    break;

                case "Liar":
                    player.SoundLocation = (string)ENHITS.Rows[8]["baihat"];
                    break;

                case "Make you mine":
                    player.SoundLocation = (string)ENHITS.Rows[9]["baihat"];
                    break;
            }
            player.Play();
        }

        private void panel_like_3_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox24.BackgroundImage;
            label_songname.Text = label_like_9.Text;
            label_songartist.Text = label_like_10.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;

            switch (label_songname.Text)
            {
                case "NGTANOISE":
                    player.SoundLocation = (string)VIRALHITS.Rows[0]["baihat"];
                    break;

                case "QUERRY":
                    player.SoundLocation = (string)VIRALHITS.Rows[1]["baihat"];
                    break;

                case "TAYTO":
                    player.SoundLocation = (string)VIRALHITS.Rows[2]["baihat"];
                    break;

                case "THICHTHICH":
                    player.SoundLocation = (string)VIRALHITS.Rows[3]["baihat"];
                    break;

                case "tiny love":
                    player.SoundLocation = (string)VIRALHITS.Rows[4]["baihat"];
                    break;

                case "My House":
                    player.SoundLocation = (string)VIRALHITS.Rows[5]["baihat"];
                    break;

                case "New Genesis":
                    player.SoundLocation = (string)VIRALHITS.Rows[6]["baihat"];
                    break;

                case "Sorry":
                    player.SoundLocation = (string)VIRALHITS.Rows[7]["baihat"];
                    break;

                case "Sunflower":
                    player.SoundLocation = (string)VIRALHITS.Rows[8]["baihat"];
                    break;

                case "There for you":
                    player.SoundLocation = (string)VIRALHITS.Rows[9]["baihat"];
                    break;


                case "25":
                    player.SoundLocation = (string)VNHITS.Rows[0]["baihat"];
                    break;

                case "3107":
                    player.SoundLocation = (string)VNHITS.Rows[1]["baihat"];
                    break;

                case "AI BIET":
                    player.SoundLocation = (string)VNHITS.Rows[2]["baihat"];
                    break;

                case "CHIM SAU":
                    player.SoundLocation = (string)VNHITS.Rows[3]["baihat"];
                    break;

                case "CUA":
                    player.SoundLocation = (string)VNHITS.Rows[4]["baihat"];
                    break;

                case "GIAYPHUT":
                    player.SoundLocation = (string)VNHITS.Rows[5]["baihat"];
                    break;

                case "GU":
                    player.SoundLocation = (string)VNHITS.Rows[6]["baihat"];
                    break;

                case "HOLD MY HAND":
                    player.SoundLocation = (string)VNHITS.Rows[7]["baihat"];
                    break;

                case "ICEMAN":
                    player.SoundLocation = (string)VNHITS.Rows[8]["baihat"];
                    break;

                case "LOCHI":
                    player.SoundLocation = (string)VNHITS.Rows[9]["baihat"];
                    break;

                case "All We Know":
                    player.SoundLocation = (string)ENHITS.Rows[0]["baihat"];
                    break;

                case "Bad Habits":
                    player.SoundLocation = (string)ENHITS.Rows[1]["baihat"];
                    break;

                case "Better Now":
                    player.SoundLocation = (string)ENHITS.Rows[2]["baihat"];
                    break;

                case "Cake By The Ocean":
                    player.SoundLocation = (string)ENHITS.Rows[3]["baihat"];
                    break;

                case "Comedy":
                    player.SoundLocation = (string)ENHITS.Rows[4]["baihat"];
                    break;

                case "Hello":
                    player.SoundLocation = (string)ENHITS.Rows[5]["baihat"];
                    break;

                case "Hero":
                    player.SoundLocation = (string)ENHITS.Rows[6]["baihat"];
                    break;

                case "Immortals":
                    player.SoundLocation = (string)ENHITS.Rows[7]["baihat"];
                    break;

                case "Liar":
                    player.SoundLocation = (string)ENHITS.Rows[8]["baihat"];
                    break;

                case "Make you mine":
                    player.SoundLocation = (string)ENHITS.Rows[9]["baihat"];
                    break;
            }
            player.Play();
        }

        private void panel_like_2_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox25.BackgroundImage;
            label_songname.Text = label_like_5.Text;
            label_songartist.Text = label_like_6.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;

            switch (label_songname.Text)
            {
                case "NGTANOISE":
                    player.SoundLocation = (string)VIRALHITS.Rows[0]["baihat"];
                    break;

                case "QUERRY":
                    player.SoundLocation = (string)VIRALHITS.Rows[1]["baihat"];
                    break;

                case "TAYTO":
                    player.SoundLocation = (string)VIRALHITS.Rows[2]["baihat"];
                    break;

                case "THICHTHICH":
                    player.SoundLocation = (string)VIRALHITS.Rows[3]["baihat"];
                    break;

                case "tiny love":
                    player.SoundLocation = (string)VIRALHITS.Rows[4]["baihat"];
                    break;

                case "My House":
                    player.SoundLocation = (string)VIRALHITS.Rows[5]["baihat"];
                    break;

                case "New Genesis":
                    player.SoundLocation = (string)VIRALHITS.Rows[6]["baihat"];
                    break;

                case "Sorry":
                    player.SoundLocation = (string)VIRALHITS.Rows[7]["baihat"];
                    break;

                case "Sunflower":
                    player.SoundLocation = (string)VIRALHITS.Rows[8]["baihat"];
                    break;

                case "There for you":
                    player.SoundLocation = (string)VIRALHITS.Rows[9]["baihat"];
                    break;


                case "25":
                    player.SoundLocation = (string)VNHITS.Rows[0]["baihat"];
                    break;

                case "3107":
                    player.SoundLocation = (string)VNHITS.Rows[1]["baihat"];
                    break;

                case "AI BIET":
                    player.SoundLocation = (string)VNHITS.Rows[2]["baihat"];
                    break;

                case "CHIM SAU":
                    player.SoundLocation = (string)VNHITS.Rows[3]["baihat"];
                    break;

                case "CUA":
                    player.SoundLocation = (string)VNHITS.Rows[4]["baihat"];
                    break;

                case "GIAYPHUT":
                    player.SoundLocation = (string)VNHITS.Rows[5]["baihat"];
                    break;

                case "GU":
                    player.SoundLocation = (string)VNHITS.Rows[6]["baihat"];
                    break;

                case "HOLD MY HAND":
                    player.SoundLocation = (string)VNHITS.Rows[7]["baihat"];
                    break;

                case "ICEMAN":
                    player.SoundLocation = (string)VNHITS.Rows[8]["baihat"];
                    break;

                case "LOCHI":
                    player.SoundLocation = (string)VNHITS.Rows[9]["baihat"];
                    break;

                case "All We Know":
                    player.SoundLocation = (string)ENHITS.Rows[0]["baihat"];
                    break;

                case "Bad Habits":
                    player.SoundLocation = (string)ENHITS.Rows[1]["baihat"];
                    break;

                case "Better Now":
                    player.SoundLocation = (string)ENHITS.Rows[2]["baihat"];
                    break;

                case "Cake By The Ocean":
                    player.SoundLocation = (string)ENHITS.Rows[3]["baihat"];
                    break;

                case "Comedy":
                    player.SoundLocation = (string)ENHITS.Rows[4]["baihat"];
                    break;

                case "Hello":
                    player.SoundLocation = (string)ENHITS.Rows[5]["baihat"];
                    break;

                case "Hero":
                    player.SoundLocation = (string)ENHITS.Rows[6]["baihat"];
                    break;

                case "Immortals":
                    player.SoundLocation = (string)ENHITS.Rows[7]["baihat"];
                    break;

                case "Liar":
                    player.SoundLocation = (string)ENHITS.Rows[8]["baihat"];
                    break;

                case "Make you mine":
                    player.SoundLocation = (string)ENHITS.Rows[9]["baihat"];
                    break;
            }
            player.Play();
        }

        private void panel_like_1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_song.BackgroundImage = pictureBox26.BackgroundImage;
            label_songname.Text = label_like_1.Text;
            label_songartist.Text = label_like_2.Text;
            playing = true;
            pictureBox_play.BackgroundImage = Properties.Resources.stop;

            switch (label_songname.Text)
            {
                case "NGTANOISE":
                    player.SoundLocation = (string)VIRALHITS.Rows[0]["baihat"];
                    break;

                case "QUERRY":
                    player.SoundLocation = (string)VIRALHITS.Rows[1]["baihat"];
                    break;

                case "TAYTO":
                    player.SoundLocation = (string)VIRALHITS.Rows[2]["baihat"];
                    break;

                case "THICHTHICH":
                    player.SoundLocation = (string)VIRALHITS.Rows[3]["baihat"];
                    break;

                case "tiny love":
                    player.SoundLocation = (string)VIRALHITS.Rows[4]["baihat"];
                    break;

                case "My House":
                    player.SoundLocation = (string)VIRALHITS.Rows[5]["baihat"];
                    break;

                case "New Genesis":
                    player.SoundLocation = (string)VIRALHITS.Rows[6]["baihat"];
                    break;

                case "Sorry":
                    player.SoundLocation = (string)VIRALHITS.Rows[7]["baihat"];
                    break;

                case "Sunflower":
                    player.SoundLocation = (string)VIRALHITS.Rows[8]["baihat"];
                    break;

                case "There for you":
                    player.SoundLocation = (string)VIRALHITS.Rows[9]["baihat"];
                    break;


                case "25":
                    player.SoundLocation = (string)VNHITS.Rows[0]["baihat"];
                    break;

                case "3107":
                    player.SoundLocation = (string)VNHITS.Rows[1]["baihat"];
                    break;

                case "AI BIET":
                    player.SoundLocation = (string)VNHITS.Rows[2]["baihat"];
                    break;

                case "CHIM SAU":
                    player.SoundLocation = (string)VNHITS.Rows[3]["baihat"];
                    break;

                case "CUA":
                    player.SoundLocation = (string)VNHITS.Rows[4]["baihat"];
                    break;

                case "GIAYPHUT":
                    player.SoundLocation = (string)VNHITS.Rows[5]["baihat"];
                    break;

                case "GU":
                    player.SoundLocation = (string)VNHITS.Rows[6]["baihat"];
                    break;

                case "HOLD MY HAND":
                    player.SoundLocation = (string)VNHITS.Rows[7]["baihat"];
                    break;

                case "ICEMAN":
                    player.SoundLocation = (string)VNHITS.Rows[8]["baihat"];
                    break;

                case "LOCHI":
                    player.SoundLocation = (string)VNHITS.Rows[9]["baihat"];
                    break;

                case "All We Know":
                    player.SoundLocation = (string)ENHITS.Rows[0]["baihat"];
                    break;

                case "Bad Habits":
                    player.SoundLocation = (string)ENHITS.Rows[1]["baihat"];
                    break;

                case "Better Now":
                    player.SoundLocation = (string)ENHITS.Rows[2]["baihat"];
                    break;

                case "Cake By The Ocean":
                    player.SoundLocation = (string)ENHITS.Rows[3]["baihat"];
                    break;

                case "Comedy":
                    player.SoundLocation = (string)ENHITS.Rows[4]["baihat"];
                    break;

                case "Hello":
                    player.SoundLocation = (string)ENHITS.Rows[5]["baihat"];
                    break;

                case "Hero":
                    player.SoundLocation = (string)ENHITS.Rows[6]["baihat"];
                    break;

                case "Immortals":
                    player.SoundLocation = (string)ENHITS.Rows[7]["baihat"];
                    break;

                case "Liar":
                    player.SoundLocation = (string)ENHITS.Rows[8]["baihat"];
                    break;

                case "Make you mine":
                    player.SoundLocation = (string)ENHITS.Rows[9]["baihat"];
                    break;
            }
            player.Play();
        }


        private void pictureBox16_Click(object sender, EventArgs e)
        {
            panel_likedsong.Visible = false;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            
            switch (label_songname.Text)
            {
                case "NGTANOISE":
                    checklike = Convert.ToInt32(VIRALHITS.Rows[0]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            VIRALHITS.Rows[0]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a1);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            VIRALHITS.Rows[0]["Liked"] = 1;
                            Liked.Rows.Add("VR", Properties.Resources.ngtanoise, 0, "NGTANOISE", "Vsoul", "3:50", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - NGTANOISE - VSOUL.wav", "Giọt nước mắt rớt trên khuôn nhạc\r\nRớt cứ rớt rơi từng hạt\r\nGiọt nước mắt thấm trên tay người\r\nVẫn còn nhớ ai hay cười\r\nĐã từng bước khắp nơi chân trời\r\nNói mãi không vâng lời\r\nVì đã từng hứa sẽ không đau buồn\r\nBước đi qua từng cuộc chơi\r\nVì đã có nhiều lúc chẵng biết phải nói điều gì\r\nVậy thì là giờ hiện bên mình có ai?\r\nSao không ai nói những lời chân thật \r\nvà nhẹ nhàng và chấp nhận nhiều điều đó sai\r\nAnh cảm thấy bản thân này như là\r\n Batman đi tìm màu buồn màu sầu tối đen\r\nNo no no ta không hợp chẵng có điều gì ấm êm\r\nTại sao như vậy?\r\nTại sao che đậy?\r\nNào có ai nghe đâu, nghe đâu, nghe đâu, nghe đâu\r\nĐừng nên âu sầu\r\nTa đã biết bao nhiêu lần buồn và lần sầu\r\n từ ngày nào đã khiến lòng này khó feel\r\nPoppin’ pills biết bao nhiêu lần và thật\r\n nhiều nhưng mà nhiều lần thật sự là khó quên\r\nTrong một phút giây ngày nào đã trao\r\n nhiều thật nhiều những nụ cười thật ấm êm \r\nVà lời nói nào làm lòng này nóng lên\r\nNgười ta cứ nói đừng quá yêu\r\nNgười ta cứ nói đừng quá tin\r\nNgười ta cứ nói đừng quá yêuuuu\r\nNgười ta cứ nói đừng quá tin");
                            i++;
                            a1 = i;
                            break;
                    }
                    break;

                case "QUERRY":
                    checklike = Convert.ToInt32(VIRALHITS.Rows[1]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            VIRALHITS.Rows[1]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a2);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            VIRALHITS.Rows[1]["Liked"] = 1;
                            Liked.Rows.Add("VR", Properties.Resources.querry, 0, "QUERRY", "QNT, RPT MCK, Trung Trần", "3:31", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - QUERRY - QNT - Trung Trần - RPT MCK.wav", "QNT:\r\nHàng ngày anh vẫn chọn cách dậy sớm, cùng một ly cafe bên đường\r\nLặng nhìn từng đàn chim đang sải cánh bay đi\r\nLựa chọn outfit ra đón ngày mới, tâm hồn ta như lạc vô chốn thiên đường\r\nVà nụ cười của em đẹp như là hoa đó baby\r\nEm đang dạo bước trên con đường dài\r\nAnh không còn thấy ưu phiền trên vai\r\nEm không còn giống trông như thường ngày\r\nKhông ưa lời nói mật ngọt bên tai\r\nSo, baby I love it !\r\nBaby follow me, follow me….\r\nNgọt ngào vị cherry, đôi môi của em tỏa ra mùi hương thú vị\r\nYou sweet like berry nhưng anh vẫn luôn gọi em là baby Jully\r\nNàng đẹp tựa là Kathy anh vẫn thường hay được xem ở trên tivi\r\nNhư Playboy Carti khi bên cạnh anh thì em chẳng cần phải nghĩ suy\r\nQNT:\r\nAnh không cần biết cho dù ngày hay là canh đêm, anh vẫn sống trọn vẹn đến từng giờ\r\nAnh mong được viết cho bạn bè cho cả anh em, nhưng em khiến anh không thể ngừng mơ, về em\r\nNỗi nhớ cứ kéo đến hàng đêm\r\noutside rollin with my gang\r\nNhưng trong tim anh vẫn hướng về em, em, em\r\nI’m in love, love, love\r\nbaby skz skz skz\r\nYou leaving in my mind !\r\nNgoài trời rớt rơi mưa mưa\r\nNhẹ nhàng phất phơ lưa thưa\r\nBaby gotta feel my vibe !!\r\nNgọt ngào vị cherry, đôi môi của em tỏa ra mùi hương thú vị\r\nYou sweet like berry nhưng anh vẫn luôn gọi em là baby Jully\r\nNàng đẹp tựa là Kathy anh vẫn thường hay được xem ở trên tivi\r\nNhư Playboy Carti khi bên cạnh anh thì em chẳng cần phải nghĩ suy\r\nTrung Trần:\r\nVì sao nhờ ? Cứ tình hình này ôi thôi chết dở\r\nAnh như chú cá mắc cạn trên bờ\r\nNghĩ về em lại tức khẩu thành thơ\r\nVà điều đó giúp anh miệt mài hàng giờ\r\nVà mỗi khi em buồn\r\nAnh thức hết đêm muộn\r\nĐể kể cho em\r\nVà vẽ thêm môi em cười\r\nNhư mùa xuân đến\r\nChiều nay em ghé chơi\r\nVà đó là tất cả những điều anh muốn\r\nYeah đó là tất cả những gì anh muốn\r\nMCK:\r\nCó lẽ anh sẽ cho anh thời gian, tận hưởng niềm vui bên em hàng ngày\r\nMặt trời ngủ quên, ánh chiều muộn màng chiếu xuống dưới những tán cây\r\nNgày mai dậy sớm với những giấc mộng tuyệt vời và lồng ngực em sẽ luôn tràn đầy\r\nHận thù khổ đau với ghen tuông gì tầm này !!\r\nNgọt ngào vị cherry đôi môi của em tại sao lại cong thế nhờ\r\nyeah bọn họ tripping nghĩ đến em, nên là lòng dễ mơ\r\nChỉ cần biết là em ở đây, chẳng còn thêm nghi ngờ\r\nĐể vệt son đó nó sẽ đưa anh, tan vào trong từng ý thơ");
                            i++;
                            a2 = i;
                            break;
                    }
                    break;

                case "TAYTO":
                    checklike = Convert.ToInt32(VIRALHITS.Rows[2]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            VIRALHITS.Rows[2]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a3);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            VIRALHITS.Rows[2]["Liked"] = 1;
                            Liked.Rows.Add("VR", Properties.Resources.tayto, 0, "TAYTO", "RPT MCK, RPT PHONGKHIN", "3:24", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - Tay To - RPT MCK - RPT PhongKhin.wav", "Anh là tay to khá là hay ho nhưng anh lại hay lo\r\nNên phen này gay to\r\nEm lại trông xinh (em ấy look good)\r\nHơi bị thông minh\r\nMà nhìn em lại chất\r\nNhưng em đi một mình\r\nEm muốn quên đi một cuộc tình (quên)\r\nKhông cho tình yêu chơi đùa mình (no)\r\nNhưng mà quá khứ em chìm sâu (chìm sâu)\r\nEm quay cuồng trong ánh đèn màu (đèn màu)\r\nVà em không biết lối ra đâu\r\nChỉ mong ngày dài trôi qua mau\r\nAnh ra chuyện trò đôi ba câu\r\nVì những thứ làm ta đau (anh nói là)\r\nHey girl khi em bước ra đường bước ra đường (yeah)\r\nĐây không phải nước hoa thường mà là Louis V (LV)\r\nUh baby girl em quá ngọt em rất khác bọt\r\nAnh thấy cả Yết Kiêu đang bơi trong đôi mắt em\r\nOk anh lại trằn trọc suốt đêm qua đặt ra một câu hỏi là tại sao tên em không phải là Mẫn Nhi\r\nVà nếu em có thắc mắc về vấn đề đấy thì em có thể đọc ngược nó lại cho anh\r\nTrên thế giới này có hơn 7 tỷ nụ cười\r\nNhưng mà với anh thì nụ cười của em mới là đẹp nhất\r\nThế nên là làm ơn hãy để anh giúp em giữ cái nụ cười của em trên môi\r\nAnh sẽ tán nàng anh sẽ tán nàng yeah\r\nKhông cần cầu kỳ cho dù nhà anh bán vàng nhà anh bán vàng yeah\r\nAnh đưa em đi vi vu dạo phố quanh Hồ Tây táp vào Circle K\r\nNhớ mua thêm nước vào mình ngồi trà đá em châm cho anh phê thuốc lào\r\nTay anh không to (tay anh không to)\r\nKhông như Long Ngơ (oh no)\r\nTay bận say cỏ (anh đang say em nói đi)\r\nTên anh là Phong cơ (Phong Vân)\r\nVì anh cũng chỉ muốn cảm nhận em từng thời gian\r\nNụ cười thật tươi thật nhiều gout thời trang\r\nBaby no flexin' em biết em là ai\r\nVì một ngày nào đó chứ không phải ngày mai\r\nCộng thêm một suất đi ăn Hồ Tây xong rồi cà phê dưới phố\r\nPhiền em make up đi ngay và luôn anh đang chạy đến đấy đón em\r\nMột bông xanh ngát anh đem tặng em anh mong rằng em sẽ tưới nó oh\r\nYeah có thể là em sẽ cảm thấy cái bài hát này nó quá là sến súa quá là hmm alo alo nhưng mà\r\nNếu em dậy sớm buổi sáng em hãy cứ pha cho mình một cốc trà\r\nYeah và bật bài nhạc này lên anh nghĩ là nó sẽ làm cho em vui");
                            i++;
                            a3 = i;
                            break;
                    }
                    break;

                case "THICHTHICH":
                    checklike = Convert.ToInt32(VIRALHITS.Rows[3]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            VIRALHITS.Rows[3]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a4);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            VIRALHITS.Rows[3]["Liked"] = 1;
                            Liked.Rows.Add("VR", Properties.Resources.thichthich, 0, "THICHTHICH", "Phương Ly", "3:23", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - THICHTHICH - PHƯƠNG LY.wav", "Em không được xinh đẹp, không hay cười duyên\r\nChẳng biết làm sao cho trông thật ngoan hiền như bao cô ngoài kia\r\nEm đây nhìn cứ ngốc ngốc nghếch nghếch\r\nLắm lúc đứng ngắm mình trong gương, cứ thấy choáng váng\r\nNhưng mà anh ơi\r\nEm rất là vâng lời, không la cà ham chơi\r\nEm hồn nhiên, vô tư và yêu đời\r\nNên anh này, mong anh không cười chê\r\nNếu có thấy chán, em sẽ đến hát đàn anh nghe\r\nDẫu sáng, dẫu tối, em sẽ đến bên cạnh anh thôi\r\nAnh sẽ thấy ngoài kia đấy bao cô gái như em\r\nCũng cần tình yêu, cần được hiểu, cần một chút nuông chiều\r\nI don't wanna let you go, 'cause I know I love you so\r\nVì cuộc đời chẳng có gì ý nghĩa khi mà không có anh\r\nAnh sẽ biết điều cần thiết là nắm lấy tay em\r\nVì lúc này đây, em chỉ muốn gần bên anh mỗi ngày\r\nI don't wanna let you go, 'cause I know I love you so\r\nVà thật lòng em chỉ cần anh biết một điều duy nhất là\r\nEm thích anh\r\nThích, thích, thích, thích, ooh-woah-oh\r\nThích, thích, thích, thích, ooh-woah-oh\r\nThích, thích, thích, thích, ooh-woah-hoo\r\n(Và thật lòng em chỉ cần anh biết một điều duy nhất là)\r\nSau bao ngày mong chờ\r\nMong anh lại bên em ta cùng vui, xin anh đừng hững hờ\r\nXa anh một giây thôi, trong lòng em đã thấy nhớ nhớ\r\nChỉ muốn nhấc máy gọi cho anh, nhưng em chẳng dám\r\nVì biết anh có nhớ đến em?\r\n(Just close your eyes)\r\nAnh sẽ thấy ngoài kia đấy bao cô gái như em\r\nCũng cần tình yêu, cần được hiểu, cần một chút nuông chiều\r\nI don't wanna let you go, 'cause I know I love you so\r\nVì cuộc đời chẳng có gì ý nghĩa khi mà không có anh\r\nAnh sẽ biết điều cần thiết là nắm lấy tay em\r\nVì lúc này đây, em chỉ muốn gần bên anh mỗi ngày\r\nI don't wanna let you go, 'cause I know I love you so\r\nVà thật lòng em chỉ cần anh biết một điều duy nhất là\r\nEm thích anh\r\nCó biết trái tim em đang rung rinh lên chỉ vì anh?\r\nNhưng đâu dám nói, chỉ biết hát khúc ca này tặng anh\r\nLiệu anh có thích em không? (Hoh-oh, hoh-uh-oh-hoh)\r\nAnh sẽ thấy ngoài kia đấy bao cô gái như em\r\nCũng cần tình yêu, cần được hiểu, cần một chút nuông chiều\r\nI don't wanna let you go, 'cause I know I love you so\r\nVì cuộc đời chẳng có gì ý nghĩa khi mà không có anh\r\nAnh sẽ biết điều cần thiết là nắm lấy tay em\r\nVì lúc này đây, em chỉ muốn gần bên anh mỗi ngày\r\nI don't wanna let you go, 'cause I know I love you so\r\nVà thật lòng em chỉ cần anh biết một điều duy nhất là\r\nEm thích anh\r\nThích, thích, thích, thích, ooh-woah-oh\r\nThích, thích, thích, thích, ooh-woah-oh\r\nThích, thích, thích, thích, ooh-woah-hoo\r\n(Và thật lòng em chỉ cần anh biết một điều duy nhất là...)");
                            i++;
                            a4 = i;
                            break;
                    }
                    break;

                case "tiny love":
                    checklike = Convert.ToInt32(VIRALHITS.Rows[4]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            VIRALHITS.Rows[4]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a5);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            VIRALHITS.Rows[4]["Liked"] = 1;
                            Liked.Rows.Add("VR", Properties.Resources.tiny_love, 0, "tiny love", "Thịnh Suy", "3:27", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - tiny love - Thịnh Suy.wav", "Làm lại từ những thứ đơn giản nhất chuyện trò như lúc mới yêu\r\nTình mình như thứ nước hoa phảng phất nồng nàn như bát bún riêu\r\nNày người yêu dấu nếu trong một chốc buồn sầu đeo bám chúng ta\r\nThì đừng vội trách cớ sao tàn khốc vì niềm đau ấy sẽ qua\r\nSẽ qua thôi những u buồn thế gian\r\nTình yêu sẽ cháy nhưng không tro tàn\r\nYou're my ti ti tiny love\r\nBaby you're my ti ti tiny love\r\nYou're my ti ti tiny love\r\nBaby you're my time time timeless love\r\nMột chiều ta đứng kế bên nhìn ngắm cuộc đời như những bức tranh\r\nDạo từng khu phố lúc xưa chìm đắm mà giờ sao thấy mới toanh\r\nĐồng hồ nhanh quá mới đây mà hết đời người như những giấc mơ\r\nLàm gì cho đáng để sau này vết lời mình như những ý thơ\r\nÝ thơ trong những đau buồn thế gian\r\nTình yêu sẽ cháy nhưng không tro tàn\r\nYou're my ti ti tiny love\r\nBaby you're my ti ti tiny love\r\nYou're my ti ti tiny love\r\nBaby you're my time time timeless love\r\nI wanna love you till the end of time\r\nThings gonna change but not my mind\r\nI needed love just like I need you\r\nI love you my tiny tiny baby blue");
                            i++;
                            a5 = i;
                            break;
                    }
                    break;

                case "My House":
                    checklike = Convert.ToInt32(VIRALHITS.Rows[5]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            VIRALHITS.Rows[5]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a6);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            VIRALHITS.Rows[5]["Liked"] = 1;
                            Liked.Rows.Add("VR", Properties.Resources.my_house, 0, "My House", "Flo Rida", "3:25", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - My House - Flo Rida.wav", "Open up the champagne, pop!\r\nIt's my house, come on, turn it up\r\nHear a knock on the door and the night begins\r\n'Cause we done this before so you come on in\r\nMake yourself at my home, tell me where you been\r\nPour yourself something cold, baby, cheers to this\r\nSometimes you gotta stay in\r\nAnd you know where I live\r\nYeah, you know what we is\r\nSometimes you gotta stay in, in\r\nWelcome to my house\r\nBaby take control now\r\nWe can't even slow down\r\nWe don't like to go out\r\nWelcome to my house\r\nPlay that music too loud\r\nShow me what you do now\r\nWe don't like to go out\r\nWelcome to my house\r\nWelcome to my house\r\nMorning comes and you know that you wanna stay\r\nClose the blinds, let's pretend that the time has changed\r\nKeep our clothes on the floor, open up champagne\r\nLet's continue tonight, come on, celebrate\r\nSometimes you gotta stay in\r\nAnd you know where I live\r\nYeah, you know what we is\r\nSometimes you gotta stay in, in\r\nWelcome to my house\r\nBaby take control now\r\nWe can't even slow down\r\nWe don't like to go out\r\nWelcome to my house\r\nPlay that music too loud\r\nShow me what you do now\r\nWe don't like to go out\r\nWelcome to my house\r\nWelcome to my house\r\nWelcome to my duck off the crib, the spot, the pad\r\nBut my house is your house if you throwin' it back\r\nExcuse me if my home bringing the sad\r\nSoon as these happy faces, you can run with the cash\r\nHomerun, slam dunk, touchdown, pass\r\nMi casa es tu casa so it ain't no holding back\r\nAnother shot of vodka, you know what's in my glass\r\nIt's my house, just relax\r\nWelcome to my house\r\nBaby take control now\r\nWe can't even slow down\r\nWe don't like to go out\r\nWelcome to my house\r\nPlay that music too loud\r\nShow me what you do now\r\nWe don't like to go out\r\nWelcome to my house\r\nWelcome to my house\r\nWelcome to my house\r\nIt's my house");
                            i++;
                            a6 = i;
                            break;
                    }
                    break;

                case "New Genesis":
                    checklike = Convert.ToInt32(VIRALHITS.Rows[6]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            VIRALHITS.Rows[6]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a7);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            VIRALHITS.Rows[6]["Liked"] = 1;
                            Liked.Rows.Add("VR", Properties.Resources.new_genesis, 0, "New Genesis", "Ado", "3:10", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - New Genesis  - Uta.wav", "新時代はこの未来だ\r\n世界中全部 変えてしまえば 変えてしまえば\r\nジャマモノ やなもの なんて消して\r\nこの世とメタモルフォーゼしようぜ\r\nミュージック キミが起こす マジック\r\n目を閉じれば未来が開いて\r\nいつまでも終わりが来ないようにって\r\nこの歌を歌うよ\r\nDo you wanna play? リアルゲーム ギリギリ\r\n綱渡りみたいな旋律 認めない戻れない忘れたい\r\n夢の中に居させて I wanna be free\r\n見えるよ新時代が 世界の向こうへ\r\nさあ行くよ new world\r\n新時代はこの未来だ\r\n世界中全部 変えてしまえば 変えてしまえば\r\n果てしない音楽がもっと届くように\r\n夢は見ないわ キミが話した「ボクを信じて」\r\nあれこれいらないものは消して\r\nリアルをカラフルに越えようぜ\r\nミュージック 今始まる ライジング\r\n目をつぶりみんなで逃げようよ\r\n今よりイイモノを見せてあげるよ\r\nこの歌を歌えば\r\nDo you wanna play? リアルゲーム ギリギリ\r\n綱渡りみたいな運命 認めない戻れない忘れたい\r\n夢の中に居させて I wanna be free\r\n見えるよ新時代が 世界の向こうへ\r\nさあ行くよ new world\r\n信じたいわ この未来を\r\n世界中全部 変えてしまえば 変えてしまえば\r\n果てしない音楽がもっと届くように\r\n夢を見せるよ 夢を見せるよ 新時代だ\r\nOoh\r\n新時代だ");
                            i++;
                            a7 = i;
                            break;
                    }
                    break;

                case "Sorry":
                    checklike = Convert.ToInt32(VIRALHITS.Rows[7]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            VIRALHITS.Rows[7]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a8);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            VIRALHITS.Rows[7]["Liked"] = 1;
                            Liked.Rows.Add("VR", Properties.Resources.Sorry, 0, "Sorry", "Justin Beiber", "3:30", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Sorry - Justin Bieber.wav", "You gotta go and get angry at all of my honesty\r\nYou know I try but I don't do too well with apologies\r\nI hope I don't run out of time, could someone call a referee?\r\nCause I just need one more shot at forgiveness\r\nI know you know that I made those mistakes maybe once or twice\r\nBy once or twice I mean maybe a couple a hundred times\r\nSo let me, oh let me redeem, oh redeem, oh myself tonight\r\nCause I just need one more shot at second chances\r\nYeah, is it too late now to say sorry?\r\nCause I'm missing more than just your body\r\nIs it too late now to say sorry?\r\nYeah I know that I let you down\r\nIs it too late to say I'm sorry now?\r\nI'm sorry, yeah\r\nSorry, yeah\r\nSorry\r\nYeah I know that I let you down\r\nIs it too late to say I'm sorry now?\r\nI'll take every single piece of the blame if you want me to\r\nBut you know that there is no innocent one in this game for two\r\nI'll go, I'll go and then you go, you go out and spill the truth\r\nCan we both say the words and forget this?\r\nIs it too late now to say sorry?\r\nCause I'm missing more than just your body\r\nIs it too late now to say sorry?\r\nYeah I know that I let you down\r\nIs it too late to say I'm sorry now?\r\nI'm not just trying to get you back on me\r\nCause I'm missing more than just your body\r\nIs it too late now to say sorry?\r\nYeah I know that I let you down\r\nIs it too late to say I'm sorry now?\r\nI'm sorry, yeah\r\nSorry, oh\r\nSorry\r\nYeah I know that I let you down\r\nIs it too late to say I'm sorry now?\r\nI'm sorry, yeah\r\nSorry, oh\r\nSorry\r\nYeah I know that I let you down\r\nIs it too late to say I'm sorry now?");
                            i++;
                            a8 = i;
                            break;
                    }
                    break;

                case "Sunflower":
                    checklike = Convert.ToInt32(VIRALHITS.Rows[8]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            VIRALHITS.Rows[8]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a9);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            VIRALHITS.Rows[8]["Liked"] = 1;
                            Liked.Rows.Add("VR", Properties.Resources.sunflower, 0, "Sunflower", "Post Malone, Swae Lee", "3:48", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Sunflower - Post Malone, Swae Lee.wav", "Eh, eh, eh, eh (Ooh)\r\nUh, uh, uh, uh (Uh)\r\nEh, eh\r\nUh uh, some things you just can't refuse\r\nShe wanna ride me like a cruise and I'm not tryna lose\r\nThen you're left in the dust, unless I stuck by ya\r\nYou're a sunflower, I think your love would be too much\r\nOr you'll be left in the dust, unless I stuck by ya\r\nYou're the sunflower, you're the sunflower\r\nYo no sé lo que tú tienes\r\nCómo hace' lo que quiera' con mi vida, tú te vas y luego vienes\r\nYo no sé qué tiene' tú, pero a la ve' yo pienso que no me convienes\r\nA veces trato de buscar una salida, rápido tú me detienes\r\nAsí de loco tú me quieres\r\nPero soy un loco por ti\r\nTú no sabe' lo que por dentro yo siento por ti\r\nY por má' que no quiero verte, vuelvo a repetir\r\nY sentir cada parte de tu cuerpo cuando estas aquí\r\nNo te puedo mentir\r\nSiempre estoy buscándote, yeah-yey\r\nTrato de alejarme y tú acercándote, yeah-yey\r\nDe lo que nos pasa siempre culpándote, yeah-yey\r\nPero se me olvida cuando te veo desnudándote\r\nY no sé por qué\r\nAnd you'll be left in the dust, unless I stuck by ya\r\nYou're the sunflower, I think your love would be too much\r\nOr you'll be left in the dust, unless I stuck by ya\r\nYou're the sunflower, you're the sunflower\r\nEse día que te conocí\r\nNo sabía que iba a ser así\r\nEl girasol más lindo del jardín\r\nY verte en el amanecer\r\nCon un beso volví a caer\r\nDime a dónde se fue, a dónde se fue\r\nY ahora me quedo con la confusión\r\nCon sentimientos de amor y dolor\r\nTe juro que esa no fue mi intención\r\nLa flor de antes cambió de color\r\nUh-uh-uh-uuh\r\nEn mi vida solo existes tú\r\nBaby, tell what we trynna prove\r\nSi tú sabes que yo soy tu luz (Si tú sabes que yo soy tu luz)\r\nAnd you'll be left in the dust, unless I stuck by ya\r\nYou're the sunflower, es que tu amor es just too much\r\nOr you'll be left in the dust, unless I stuck by ya\r\nYou're the sunflower, you're the sunflower");
                            i++;
                            a9 = i;
                            break;
                    }
                    break;

                case "There for you":
                    checklike = Convert.ToInt32(VIRALHITS.Rows[9]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            VIRALHITS.Rows[9]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a10);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            VIRALHITS.Rows[9]["Liked"] = 1;
                            Liked.Rows.Add("VR", Properties.Resources.there_for_you, 0, "There for you", "Martin Garrix, Troye Sivan", "3:31", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - There For You - Martin Garrix - Troye Sivan.wav", "I woke up pissed off today\r\nAnd lately everyone feels fake\r\nSomewhere, I lost a piece of me\r\nSmoking cigarettes on balconies\r\nBut I can't do this alone\r\nSometimes I just need a light\r\nIf I call you on the phone\r\nNeed you on the other side\r\nSo when your tears roll down your pillow like a river\r\nI'll be there for you\r\nI'll be there for you\r\nWhen you're screaming, but they only hear you whisper\r\nI'll be loud for you\r\nBut you gotta be there for me too\r\nBut you gotta be there for me too\r\nLast year took a toll on me\r\nBut I made it with you next to me\r\nAround the world and back again\r\nI hope you're waiting at the end\r\nBut I can't do this alone\r\nSometimes I just need a light\r\nIf I call you on the phone\r\nNeed you on the other side\r\nSo when your tears roll down your pillow like a river\r\nI'll be there for you\r\nI'll be there for you\r\nWhen you're screaming, but they only hear you whisper\r\nI'll be loud for you\r\nI'll be loud for you\r\nI got you, I promise\r\nBut let me be honest\r\nLove is a road that goes both ways\r\nWhen your tears roll down your pillow like a river\r\nI'll be there for you\r\nBut you gotta be there for me too\r\nBut you gotta be there for me too\r\nBoy, I'm holdin' onto something\r\nWon't let go of you for nothing\r\nI'm runnin', runnin' just to keep my hands on you\r\nThere was a time that I was so blue\r\nWhat I got to do to show you?\r\nI'm runnin', runnin' just to keep my hands on you\r\nRunnin', runnin' just to keep my hands on you\r\nRunnin', runnin' just to keep my hands on you\r\nSaid, I'm runnin', runnin' just to keep my hands on you\r\nBut you gotta be there for me too\r\nBut you gotta be there for me too");
                            i++;
                            a10 = i;
                            break;
                    }
                    break;


                case "25":
                    checklike = Convert.ToInt32(VNHITS.Rows[0]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            VNHITS.Rows[0]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a11);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            VNHITS.Rows[0]["Liked"] = 1;
                            Liked.Rows.Add("VN", Properties.Resources._25, 0, "25", "TÁO", "3:30", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - 25 - TÁO.wav", "Lần đầu tiên anh mong tìm ra cho riêng mình\r\nMột ai quan tâm và nghe lời anh hát\r\nNgồi kề bên đưa anh bờ vai khi anh buồn\r\nLặng im em khâu lành tim từng vỡ nát.\r\n\r\nCó những lúc cô đơn nhưng anh không nói\r\nLê đôi bàn chân bâng khuâng tìm đâu yên vui ngày xưa vẫn đong đầy\r\nNếu kí ức hôm qua tan như mây khói,\r\nxin em đừng đi ngang qua đường chung ta thường đan tay bước qua.\r\n\r\nBóng tối khiến đôi ta về ngược lối\r\nCó những thứ anh chưa từng được nói\r\nNếu biết trước anh không thể dừng lại\r\nThì anh cũng đã chẳng đi.\r\n\r\nMột ngày khác đã đến hôm nay\r\nCăn phòng anh cô đơn chẳng còn chút nắng\r\nSau ô cửa , giam mình trong những tiếng mơ hồ\r\nAnh nghe lời em thoáng qua, nghe thời gian đứng yên nghiêng mình\r\nNhìn mọi thứ trống vắng mông lung\r\nXung quanh tường cao nên anh nhìn sao chẳng thấy\r\nEm ơi mình xa bao lâu rồi đã trôi đi\r\nĐôi mi của em đã khô, con tim của anh tan vỡ\r\n\r\nAnh còn không nhớ nổi ngày cuối cùng trời nắng hay mưa\r\nBên nhau hôm đó mình có nắm tay chưa\r\nNếu chưa cho anh xin của em thêm chỉ một ngày nữa\r\nĐể anh an tâm rời bỏ em, không một chút dây dưa\r\nAnh không biết trước chuyện hôm nay em ơi,xa là không gần\r\nChắc em không đợi, còn chân anh bị bong gân\r\nĐẩy xe về, thành phố trên lưng anh nặng lắm\r\nAnh yêu em được hai năm,giờ anh bệnh thì ai thăm ?\r\nChắc đơn giản phần của anh là sai lầm\r\nDù cho sâu trong thâm tâm anh nghĩ mình lâu hơn trăm năm\r\nNhững thứ anh tặng em, xin em giữ đừng bụi bặm\r\nVì mình cũ kĩ được rồi nhiều vạn dặm xa xăm\r\nAnh đã khóc, cười, khô cả nước mắt\r\nNhưng thực tế, chia tay nhau là bước ngoặc\r\nĐể mình hoàn thành trọn vẹn lí do sống trên đời\r\nDù những thứ mình mong đợi không được bên nhau , em ơi.\r\n\r\nCó những lúc cô đơn nhưng anh không nói\r\nLê đôi bàn chân bâng khuâng tìm đâu yên vui ngày xưa vẫn đong đầy\r\nNếu kí ức hôm qua tan như mây khói,\r\nxin em đừng đi ngang qua đường chung ta thường đan tay bước qua.\r\n\r\nMột ngày khác đã đến hôm nay\r\nCăn phòng anh cô đơn chẳng còn chút nắng\r\nSau ô cửa , giam mình trong những tiếng mơ hồ\r\nAnh nghe lời em thoáng qua, nghe thời gian đứng yên nghiêng mình\r\nNhìn mọi thứ trống vắng mông lung\r\nXung quanh tường cao nên anh nhìn sao chẳng thấy\r\nEm ơi mình xa bao lâu rồi đã trôi đi\r\nĐôi mi của em đã khô, con tim của anh tan vỡ");
                            i++;
                            a11 = i;
                            break;
                    }
                    break;

                case "3107":
                    checklike = Convert.ToInt32(VNHITS.Rows[1]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            VNHITS.Rows[1]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a12);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            VNHITS.Rows[1]["Liked"] = 1;
                            Liked.Rows.Add("VN", Properties.Resources._3107, 0, "3107", "W/n", "3:20", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - 3107 - W_n.wav", "Đêm dần buông\r\nChỉ có đôi ta đứng đây hơi buồn\r\nNhấm nháp những suy tư\r\nCủa ngày hôm qua vừa đây, đã xa\r\nRiêng mình ta\r\nVẫn mãi lang thang dưới ánh chiều tà\r\nVẫn nỗi nhớ miên man\r\nKý ức bên em bây giờ đang ở một nơi xa\r\nChỉ cần bên nhau như những ngày ấy\r\nAnh sẽ cùng em đi hết tháng ngày\r\nĐể trong cơn mơ anh chẳng tìm thấy\r\nĐể anh bơ vơ mãi phút nơi đây\r\nTình yêu khi xưa đôi ta vụn vỡ\r\nTrong một chiều mưa hai đứa chia tay\r\nChỉ cần cho anh được thêm một chút\r\nCho anh được gần bên em\r\n\r\nXin lỗi vì những cuộc điện thoại\r\nĐã làm phiền em với nửa kia\r\nDưới góc phố lặng thinh\r\nTiếng bước chân chậm chạp\r\nLúc giữa khuya\r\nTất nhiên thì anh cũng như họ\r\nChọn buông bỏ để em thấy yên bình\r\nCòn riêng phần anh\r\nThì lại thầm trách mọi thứ\r\nTrái ngược với duyên tình, em!\r\n\r\nLúc mình buồn nhìn trời và thở hắc\r\nMưa tháng bảy là cơn buồn dào dạt\r\nLẫn về tình yêu mà anh đã lỡ mất\r\nHẳn ai cũng từng nếm phải\r\nCảm giác trống trải\r\nTrong lòng mình em ha\r\nNhư em cũng từng đau khổ vì họ rồi\r\nLại thức trắng bao đêm qua\r\nNếu ta có dịp ngồi lại\r\nThì anh xin phép kể cho em nghe\r\nBình yên của anh thì cũng giống như họ\r\nLà có em ngồi phía sau xe\r\nLà buộc phải cố lượm lặt được hết\r\nNhững thứ trước kia đã xa mình\r\nLà em hồi đó hay là anh bây giờ\r\nCô đơn đứng giữa ngã ba tình\r\nHoàng hôn tháng bảy chưa bao giờ\r\nGiết chết trái tim buồn bã đã cũ mềm\r\nBầu trời đêm nay lại có mưa rơi\r\nQua một ô cửa đã phủ rèm, em\r\nAnh còn chẳng dám khẳng định\r\nMình đã nhớ về em bao nhiêu đêm\r\nNhưng sau tất cả thì chỉ có\r\nAnh và anh tự buộc mình yêu em\r\n\r\nChỉ cần bên nhau như những ngày ấy\r\nAnh sẽ cùng em đi hết tháng ngày\r\nDù chờ ngàn năm anh vẫn ở đấy\r\nDù anh đã cố gắng nghĩ đến em\r\nRồi trong nhân gian bao nhiêu người đến\r\nThanh xuân này anh chỉ muốn bên em\r\nDìu nhau đi qua những con phố dài\r\nChỉ yêu đôi ta chẳng biết đúng sai\r\nVì sao?\r\n\r\nĐêm chờ đông\r\nGió vẫn lao xao khiến ta thêm sầu\r\nGiấu ký ức nơi đây vào gọn trong tim\r\nDù mai đổi thay\r\nRiêng mình ta\r\nVẫn mãi cô đơn dưới ánh trăng vàng\r\nVẫn nỗi nhớ khi xưa\r\nNhững lúc bên em\r\nBây giờ đang ở một nơi xa");
                            i++;
                            a12 = i;
                            break;
                    }
                    break;

                case "AI BIET":
                    checklike = Convert.ToInt32(VNHITS.Rows[2]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            VNHITS.Rows[2]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a13);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            VNHITS.Rows[2]["Liked"] = 1;
                            Liked.Rows.Add("VN", Properties.Resources.ai_biet, 0, "AI BIET", "WEAN", "3:43", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - AI BIET - WEAN.wav", "Và biết bao nhiêu cho vừa\r\nVà biết bao lâu cho vừa\r\nNào biết đang dư hay thừa\r\nNào biết đâu nào biết đâu\r\nNào biết đâu\r\nSài Gòn ngoài cửa\r\nBầu trời tối sầm\r\nLoay hoay đi kiếm bật lửa\r\nKéo rèm nhìn trời\r\nĐốt một điếu thuốc\r\nHôm nay thành phố lại mưa\r\nMưa rơi kế bên lửa\r\nEm yêu đã dậy hay chưa\r\nĐôi lúc bình yên là vậy\r\nNhững thứ đơn giản\r\nLàm ta say sưa\r\nVà biết bao nhiêu cho vừa\r\nVà biết bao lâu cho vừa\r\nDù biết hút thuốc là xấu\r\nNhưng biết bao lâu cho chừa\r\nEm như là nơi ta có thể\r\nNói hết những thứ còn chưa\r\nRồi sẽ ra sao\r\nNếu những suy nghĩ\r\nMột ngày chẳng còn được đưa em\r\nVà biết bao nhiêu cho vừa\r\nVà biết bao lâu cho vừa\r\nChắc ta sẽ bị hoá đá\r\nNhư trong cổ tích\r\nNgày xửa ngày xưa\r\nThường mơ thấy em\r\nTrong giấc ngủ trưa yeah yeah\r\nThường mơ thấy em\r\nTrong giấc ngủ trưa uh\r\nThôi mở một bài nhạc nghe\r\nNghe bài một bài nhạc nhẹ\r\nGiọng nữ ca sĩ thật khẽ\r\nHoà tan vào ta vào khói\r\nVào trong cơn mưa đầu hè\r\nHạnh phúc đâu cần màu mè\r\nNhìn tóc em tôi đầy me\r\nEm yêu vừa đi đâu về\r\nĐó là lời nhạc của chú Trần Tiến\r\nỞ trong bài Thành Phố Trẻ\r\nCòn tôi thì vẫn một mình\r\nBước tiếp ở giữa con đường\r\nĐầy người và xe\r\nCòn tôi thì vẫn một mình\r\nBước tiếp ở giữa\r\nCon đường đầy người và xe\r\nVà biết bao nhiêu cho vừa\r\nVà biết bao lâu cho vừa\r\nNào biết đang dư hay thừa\r\nNào biết đâu nào biết đâu\r\nNào biết đâu\r\nVà biết bao nhiêu cho vừa\r\nVà biết bao lâu cho vừa\r\nNào biết đang dư hay thừa\r\nNào biết đang dư hay thừa\r\nNào biết đang dư hay thừa\r\nNào biết đang dư hay thừa\r\nChưa biết bao nhiêu cho vừa\r\nHôm nay thành phố vẫn mưa\r\nTa vẫn đi kiếm bật lửa\r\nSong song con đường đi kiếm\r\nMột nửa còn lại và\r\nCó đôi lúc khờ dại\r\nCó đôi lúc dừng bút ngừng hát\r\nChẳng muốn mọi thứ tồn tại\r\nNhững sức ép dồn lại\r\nỞ hai bên tai\r\nĐang vang lên tên ai\r\nAlways in my mind\r\nĐôi lúc thấy trở ngại nhưng rồi\r\nNiềm tin là thứ ở lại cuối cùng\r\nEm như bài hát chill lúc cuối tuần\r\nLà cảm hứng khi trời tối dần\r\nVà dù lúc đó\r\nMặt mũi thối đần\r\nVẫn muốn được hát\r\nEm nghe mấy lần yeah\r\nBài hát này nghe\r\nThật là rối uh uh\r\nĐơn giản chỉ như\r\nSuy nghĩ của tôi thôi\r\nCon beat kia đang trôi trôi\r\nNhững cảm xúc đi lôi thôi\r\nNhớ môi em trên môi tôi\r\nMuốn em trên môi tôi\r\nGiống như Thanh Thảo Quang Dũng\r\nThì em cũng có\r\nVị ngọt trên đôi môi\r\nThat’s right\r\nThat’s right\r\nGiống như Thanh Thảo Quang Dũng\r\nThì em cũng có\r\nVị ngọt trên đôi môi\r\nVà đâu là đúng đâu là sai\r\nCon người luôn mâu thuẫn\r\nCó khi chẳng biết\r\nBên mình là ai\r\nĐiều gì là mãi mãi\r\nĐôi khi điều tích cực\r\nLại nằm ở sâu trong tiếng thở dài\r\nViết văn phải có mở bài\r\nCòn thứ mà bạn vừa nghe\r\nLà mớ hỗn độn\r\nĐược viết trong chiều thứ hai\r\nMột chiều mưa thứ hai\r\nYeah");
                            i++;
                            a13 = i;
                            break;
                    }
                    break;

                case "CHIM SAU":
                    checklike = Convert.ToInt32(VNHITS.Rows[3]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            VNHITS.Rows[3]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a14);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            VNHITS.Rows[3]["Liked"] = 1;
                            Liked.Rows.Add("VN", Properties.Resources.chim_sau, 0, "CHIM SAU", "Sony tran, Hoang Ton, Blacka", "3:15", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - CHIM SAU - Sony Tran - Hoang Ton - Blacka.wav", "Chìm sâu trong màn đêm\r\nNói chuyện mấy câu\r\nKhông để quá lâu\r\nÔm chặt lấy nhau\r\nI gotta make a move\r\nAnh liền tiến sâu\r\nTâm trạng đến mau\r\nKhông để e thấy đau đâu\r\nVerse 1 (Sony Tran)\r\nOh baby em so đẹp,\r\ntrong bộ váy nhưng càng đẹp hơn khi không mặc gì\r\nCăn phòng này bỗng dưng lại bùng cháy,\r\nnói anh nghe lý do chạy khỏi đây là gì\r\nPre Chorus\r\nEm không cần làm màu đâu, I like it raw\r\nJust take it off cause I take it all\r\nI’ll have a puff if you don’t mind\r\nI’ll put on a show and you got main role\r\nChorus\r\nChìm sâu trong màn đêm\r\nNói chuyện mấy câu\r\nKhông để quá lâu\r\nÔm chặt lấy nhau\r\nI gotta make a move\r\nAnh liền tiến sâu\r\nTâm trạng đến mau\r\nKhông để e thấy đau đâu\r\nVerse 2 (Hoang Ton)\r\nAnh cũng muốn nói tất cả những điều là thần kỳ\r\nNhưng baby em đẹp nhất là khi không mặc gì\r\nEm làm cho anh đã biến thành một gã tình si\r\nEm luôn biết cách tỏa sáng ở những chỗ mình đi\r\nYeah uh yeah\r\nEm cũng chẳng phải nói là tối nay em thích gì\r\nYeah uh yeah\r\nĐã có anh x3 đã…\r\nI know i know I know\r\nAnh biết một chỗ mà mình có thể đi thể đi cả nhau\r\nAnh chỉ muốn ở một mình cùng em cùng em cùng em\r\nThật lâu…\r\nPre chorus\r\nEm không cần làm màu đâu, I like it raw\r\nJust take it off cause I take it all\r\nI’ll have a puff if you don’t mind\r\nI’ll put on a show and you got main role\r\n\r\nChorus\r\nChìm sâu trong màn đêm\r\nNói chuyện mấy câu\r\nKhông để quá lâu\r\nÔm chặt lấy nhau\r\nI gotta make a move\r\nAnh liền tiến sâu\r\nTâm trạng đến mau\r\nKhông để e thấy đau đâu\r\nverse 3 (Blacka)\r\nNhớ không lầm anh viết câu đầu là kế bên nhà\r\nLúc đó em cười vì thế nên là\r\nAnh thấy yên bình\r\nem nấu thêm trà đêm ấy riêng mình, bên dưới hiên nhà , ba má trên lầu , anh nói em là\r\nEm không thể nào biết được thời gian có thể bào mòn cả một phiến đá\r\nVì nếu không thể tiến xa , thì đến lúc mình phải cần tiến hóa\r\nChỉ cần nhớ lúc đó mình đã – ” rất đã”\r\nTa đã có những điều tuyệt nhất có nhớ có quên nên có ra đi anh xin em là đừng đòi anh trả – tất cả\r\nChừa một chút cho người đến sau\r\nVì nếu anh thật sự tồi sau này\r\nHai đứa có thể mến nhau\r\nThương em nhiều nên anh nhắc kĩ\r\nKhi nhạc bật và đèn tắt đi\r\nThì em đẹp nhất khi không mặc gì\r\nChorus 2x\r\nChìm sâu trong màn đêm\r\nNói chuyện mấy câu\r\nKhông để quá lâu\r\nÔm chặt lấy nhau\r\nI gotta make a move\r\nAnh liền tiến sâu\r\nTâm trạng đến mau\r\nKhông để e thấy đau đâu");
                            i++;
                            a14 = i;
                            break;
                    }
                    break;

                case "CUA":
                    checklike = Convert.ToInt32(VNHITS.Rows[4]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            VNHITS.Rows[4]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a15);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            VNHITS.Rows[4]["Liked"] = 1;
                            Liked.Rows.Add("VN", Properties.Resources.cua, 0, "CUA", "HIEUTHUHAI", "3:47", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - CUA - HIETHUHAI.wav", "Nhìn tụi anh thật cool\r\nLạnh như băng mà không cần cố\r\nTên tuổi lên càng cao\r\nNhư Bray Ở Trong Thành Phố\r\nBài ra bài ra bài\r\nLiên tục lặp lại\r\nNhư một tần số\r\nCòn bạn trai cũ của em\r\nMother****er một thằng ngố\r\nTay phải gạt cần số\r\nCòn tay trái thì cầm vô lăng\r\nNhìn tụi anh như băng khủng bố\r\nCầm tay lái là phải đeo găng\r\nChạy đến khi mà\r\nKhông còn gì mới dừng cơ\r\nLên đây đâu dễ\r\nBắt kịp anh thì không thể\r\nNhư Nguyễn Trọng Tài em Ngừng Mơ\r\nSắc đẹp là điều thứ nhất\r\nĐể làm một nửa của HIEUTHUHAI\r\nSo if you wanna ****\r\nMy DMs let it slide\r\nAnh cua em thì dễ\r\nKhông bao giờ có chuyện ngược lại\r\nNên say bye bye bye\r\nNhiều mảnh vỡ và có Malphite\r\nBắn là bang bang\r\nMake you dance dance\r\nWe the man man\r\nHurrykng KNG\r\nNhững ngày lang thang\r\nSẽ còn sang trang\r\nÂm nhạc vang vang\r\nTích tịch tang tang\r\nNerd GANG GANG\r\nĐi hàng ngang ngang\r\nPop the Champagne\r\nYou gotta stick to the plan\r\nBiến những cú sút trở thành bàn\r\nCó thể gọi tao Johnny Dang\r\nTất cả mọi thứ làm bằng vàng\r\nBaby I’m cool cool\r\nGiơ tay lên nếu cần một ít\r\nTụi anh cua cua\r\nChỉ dừng chân khi qua đường pit\r\nWe say cua cua\r\nHẹn gặp lại ngay ở vạch đích\r\nNên là thích thì cua\r\nMà không thích thì cua\r\nCool cool\r\nGiơ tay lên nếu cần một ít\r\nTụi anh cua cua\r\nChỉ dừng chân khi qua đường pit\r\nWe say cua cua\r\nHẹn gặp lại ngay ở vạch đích\r\nNên là thích thì cua\r\nMà không thích thì cua cua\r\nNerd không coi ***\r\nChỉ coi tiền làm tình\r\nAnh thì đẹp trai\r\nHieuthuhai thì xăm mình\r\nDây chuyền ở trên cổ\r\nKhông phải chân em đâu\r\nDưới Hiên Nhà hút xì gà\r\nNgầu như là Đen Vâu\r\nĐi xe hiệu\r\nEm chân dài rất thích là bo cua\r\nTay cầm Chivas\r\nCòn tay cầm chai Soju\r\nDù Âu hay Hàn thì\r\nAnh được gọi là thần tượng\r\nBận đồ hiệu\r\nEm đi bên anh không cần ngượng\r\nNhạc là kinh doanh\r\nAnh là doanh nhân\r\nThẻ thì trong ngăn\r\nTiền thì trong bank\r\nSố tài khoản trải dài\r\nHơn 15 chữ số\r\nAnh không ngọt ngào\r\nSao cứ gọi anh là bố\r\nThích giàu tích tiền\r\nManbo tính hiền\r\nDing dong dong\r\nChing chang chong\r\nTao Gold Asian Young\r\nBaby I’m cool cool\r\nGiơ tay lên nếu cần một ít\r\nTụi anh cua cua\r\nChỉ dừng chân khi qua đường pit\r\nWe say cua cua\r\nHẹn gặp lại ngay ở vạch đích\r\nNên là thích thì cua\r\nMà không thích thì cua\r\nCool cool\r\nGiơ tay lên nếu cần một ít\r\nTụi anh cua cua\r\nChỉ dừng chân khi qua đường pit\r\nWe say cua cua\r\nHẹn gặp lại ngay ở vạch đích\r\nNên là thích thì cua\r\nMà không thích thì cua cua\r\nNên là thích thì cua\r\nMà không thích thì cua cua cua\r\nNên là thích thì cua\r\nMà không thích thì cua cua\r\nCua cua cua cua cua\r\nThích thì cua\r\nMà không thích thì cua\r\nCua cua cua cua\r\nHẹn gặp lại ngay ở vạch đích\r\nNên là thích thì cua\r\nMà không thích thì cua cua");
                            i++;
                            a15 = i;
                            break;
                    }
                    break;

                case "GIAYPHUT":
                    checklike = Convert.ToInt32(VNHITS.Rows[5]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            VNHITS.Rows[5]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a16);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            VNHITS.Rows[5]["Liked"] = 1;
                            Liked.Rows.Add("VN", Properties.Resources.giayphut, 0, "GIAYPHUT", "KIDSAI", "3:40", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - GIAYPHUT - KIDSAI.wav", "Chỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nCó lẽ không\r\nAnh chắc chắn trông\r\nChờ đợi baby girl\r\nAnh muốn kế bên em oh baby\r\nAnh muốn có\r\nCó được shawty\r\nEm là\r\nMọi thứ em à\r\nMàu hồng tím\r\nAnh không muốn đau tim đâu em\r\nMàu hồng tím\r\nAnh không muốn tim phải đau em\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nCho bao nhiêu yêu thương xa vời\r\nTrong tim ta đã không có nhau\r\nĐi bên em nói không nên lời\r\nCho anh xin giây phút nhiệm màu\r\nBaby nói cho anh bao điều\r\nKhiến cho con tim anh thêm đau\r\nNếu như giây này không thành\r\nAnh chỉ mong là mình quên nhau\r\nCodeine yeah\r\nTan vào tim\r\nBaby no\r\nAnh lại say\r\nCho thời gian\r\nQuay về đây\r\nCho tình yêu\r\nNhư lúc đầu\r\nCho con tim anh tan vào nicotine\r\nCho đôi ta tan\r\nTrong màn đêm lặng im\r\nCho hai đôi môi\r\nTrai thật lâu nụ hôn\r\nCho anh bên em\r\nThêm một giây được không\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nChỉ sợ giây phút này không thành\r\nAnh không muốn đắm say\r\nCho con tim anh tan vào nicotine\r\nCho đôi ta tan\r\nTrong màn đêm lặng im\r\nCho hai đôi môi\r\nTrai thật lâu nụ hôn\r\nCho anh bên em\r\nThêm một giây được không");
                            i++;
                            a16 = i;
                            break;
                    }
                    break;

                case "GU":
                    checklike = Convert.ToInt32(VNHITS.Rows[6]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            VNHITS.Rows[6]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a17);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            VNHITS.Rows[6]["Liked"] = 1;
                            Liked.Rows.Add("VN", Properties.Resources.gu, 0, "GU", "Freaky, Seachains", "3:23", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - Gu - Freaky - Seachains.wav", "Baby girl, I like you move\r\nCan we talk about your shoes?\r\nYeah! Anh xin thề anh không nói về gu\r\nAi mà nói em không đẹp thì có mắt như mù\r\nBaby girl, I like you move\r\nCan we talk about your shoes?\r\nCuộc đời này mình sống phong lưu\r\nSo I keep mah groove with you my boo\r\nBaby girl, I like you move\r\nCan we talk about your shoes?\r\nYeah! Anh xin thề anh không nói về gu\r\nAi mà nói em không đẹp thì có mắt như mù\r\nBaby girl, I like you move\r\nCan we talk about your shoes?\r\nCuộc đời này mình sống phong lưu\r\nSo I keep mah groove with you my boo\r\nNếu như em là trà sữa, thì anh là đường tinh\r\nNếu như em là trang web, thì anh là đường link\r\nKhiến anh đau đầu, em là phương trình\r\nNếu như em là Âu Cơ, kế bên anh là Trường Chinh\r\nAnh không hề thông minh, nên được gọi là chàng ngơ\r\nGood gril trong bộ váy ngắn, nên anh tạm gọi là nàng thơ\r\nSài Gòn thì rất nóng, còn tim em như đóng băng\r\nNgười yêu cũ em sống lỗi, nên anh bắt buộc phải sống nhăn\r\nEm là buổi sáng, anh là điểm tâm\r\nYêu em không thể thiếu ngày nào, như bị đuổi học vì điểm danh\r\nNgười thì nói anh đa tình, người thì nói anh ga lăng\r\nHọ thấy anh là qua hình, viết một bài là ra trend\r\nBaby girl, I like you move\r\nCan we talk about your shoes?\r\nYeah! Anh xin thề anh không nói về gu\r\nAi mà nói em không đẹp thì có mắt như mù\r\nBaby girl, I like you move\r\nCan we talk about your shoes?\r\nCuộc đời này mình sống phong lưu\r\nSo I keep mah groove with you my boo\r\nAnh là Hip Hop, em là Lofi\r\nQuay clip TikTok, nói mình là mối tình lâu phai\r\nFuckboiz đặt em lên giường, anh đặt nhẫn em lên tay\r\nBad boy bỏ em bên đường, giống như khứa Seachains, eh\r\nGái nhà ai thấy thiệt cool\r\nXuống mần quen thấy hợp gu (oh my god)\r\nMá nó kêu lấy vàng cây, đến nhà em, muốn mần sui\r\nRước làm dâu, xuống miền Tây\r\nBạn trai cũ em đáng ghét, còn em đây thì đáng thương\r\nLý do đây anh thức khuya, vì nick em còn sáng trưng\r\nBa mẹ nói là chúng mình, như là thanh mai trúc mã\r\nChờ tới đủ tuổi được gả, như phải chờ từng tháng lương\r\nBaby girl, I like you move\r\nCan we talk about your shoes?\r\nYeah! Anh xin thề anh không nói về gu\r\nAi mà nói em không đẹp thì có mắt như mù\r\nBaby girl, I like you move\r\nCan we talk about your shoes?\r\nCuộc đời này mình sống phong lưu\r\nSo I keep mah groove with you my boo");
                            i++;
                            a17 = i;
                            break;
                    }
                    break;

                case "HOLD MY HAND":
                    checklike = Convert.ToInt32(VNHITS.Rows[7]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            VNHITS.Rows[7]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a18);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            VNHITS.Rows[7]["Liked"] = 1;
                            Liked.Rows.Add("VN", Properties.Resources.holdmyhand, 0, "HOLD MY HAND", "POLL, TDY", "3:39", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - HOLD MY HAND - Poll - TDY.wav", "Đôi chân anh cô đơn lang thang 1 mình giữa phố Đông\r\nTìm 1 người hẹn hò mà làm anh ngóng trông...\r\nBaby...anh tương tư em suốt cả đêm dài\r\nTự hỏi mình 1 câu là \"Tại sao luôn anh yêu em hoài?\"\r\nChạm vào ánh mắt và cả bờ môi\r\nYêu em say đắm...chỉ có vậy thôi\r\nYêu em mặc kệ ai đúng sai\r\nI just need a smile\r\nFalling in your eyes\r\n\r\n(Hold my hand...go to the fancy town\r\nHold my hand...touch me and kiss your mouth\r\nHold my hand...Anh vẫn sẽ luôn yêu em\r\nI hope u know u are my memories) x2\r\n\r\nAnh biết rằng từ lâu và em đây chính là loài hoa\r\nLoài hoa cho ngà sức sống và để ghi giấu vào lời ca\r\nI'm feeling them chỉ vỏn vẹn vài ba câu hát\r\nNụ cười thơ ngây vô tình thoáng qua mà lại say đắm cả đời ta\r\n\r\nÁnh mắt dịu dàng, bồi hồi ta nắm tay nhau\r\nVài lời mật ngọt mà làm anh đắm say sao ? (noo...)\r\nYêu em, dù phong ba hay bao nhiêu trắc trở\r\nKhông như sách vở, yêu em luôn cả ngay trong cách thở\r\n\r\nĐôi chân anh cô đơn lang thang 1 mình giữa phố Đông\r\nTìm 1 người hẹn hò mà làm anh ngóng trông...\r\nBaby...anh tương tư em suốt cả đêm dài\r\nTự hỏi mình 1 câu là \"Tại sao luôn anh yêu em hoài?\"\r\nChạm vào ánh mắt và cả bờ môi\r\nYêu em say đắm...chỉ có vậy thôi\r\nYêu em mặc kệ ai đúng sai\r\nI just need a smile\r\nFalling in your eyes\r\n\r\nHold my hand...go to the fancy town\r\nHold my hand...touch me and kiss your mouth\r\nHold my hand...Anh vẫn sẽ luôn yêu em\r\nI hope u know u are my memories\r\n\r\nSau giờ tan ca, làm việc mệt mỏi\r\nEm cần tâm sự và tìm người lắng nghe\r\nVậy thì để anh ở đây luôn bên em mỗi tối\r\nVà dắt tay em về trên con đường vắng xe\r\n\r\nQuan tâm chi em ơi hàng tá công việc\r\nNếu mà cứ lao lực khi nào mình xong xuôi\r\nHãy cứ để bản thân nhận lấy điều tốt đẹp nhất\r\nVì tuổi trẻ đẹp nhất khi ta được rong chơi\r\n\r\nNên là anh sẽ uống cùng em khi phố phường yên giấc\r\nTâm tư anh gánh vác sẽ nhẹ nhàng hơn\r\nAnh chỉ muốn được ôm em thường xuyên nhất\r\nVà nhìn thấy môi em cười dưới ánh hoàng hôn\r\n\r\nI just wanne be with u when the Sunset\r\nCuz baby girl u always in my mind\r\nDont overthink let make life so fresh\r\nVà cùng nhau cố gắng...It will be alright!\r\n\r\nNeed u (lalalaa..)\r\nJust need u (lalalaa..)\r\nTại vì sao anh như người trên mây?\r\nGặp em nơi đâu vẫn xoay vòng\r\nSaxophone trên tay, đôi mình cùng đắm say\r\nFeel my song đêm nay, chỉ cần 1 cái nắm tay\r\n(Em không thoát khỏi anh được đâu)\r\n1 2 3...Now we lets gooo\r\n\r\nĐôi chân anh cô đơn lang thang 1 mình giữa phố Đông\r\nTìm 1 người hẹn hò mà làm anh ngóng trông...\r\nBaby...anh tương tư em suốt cả đêm dài\r\nTự hỏi mình 1 câu là \"Tại sao luôn anh yêu em hoài?\"\r\n\r\nChạm vào ánh mắt và cả bờ môi\r\nYêu em say đắm...chỉ có vậy thôi\r\nYêu em mặc kệ ai đúng sai\r\nI just need a smile\r\nFalling in your eyes\r\n\r\n(Hold my hand...go to the fancy town\r\nHold my hand...touch me and kiss your mouth\r\nHold my hand...Anh vẫn sẽ luôn yêu em\r\nI hope u know u are my memories) x2");
                            i++;
                            a18 = i;
                            break;
                    }
                    break;

                case "ICEMAN":
                    checklike = Convert.ToInt32(VNHITS.Rows[8]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            VNHITS.Rows[8]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a19);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            VNHITS.Rows[8]["Liked"] = 1;
                            Liked.Rows.Add("VN", Properties.Resources.iceman, 0, "ICEMAN", "SOL7", "3:41", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - iceman - SOL7.wav", "Rolling some tree và mọi thứ dần chậm đi\r\nNgồi đây nhâm nhi nghe giai điệu đó đang thầm thì\r\nPut some ice vào trong ly chấm bi (ice ice)\r\nKhi ở trên mái là một cơn mưa đang ầm ĩ (drop drop)\r\nTrở lại Bồng Sơn hay là Sài Gòn, anh vẫn không lonely\r\nBịt khẩu trang như là Sinobi để tránh thấy covi (coco)\r\nKeep it lowkey, anh đang giải trí cùng với mấy homies\r\nĐặt bàn tay vào trang giấy lấy ra vài cái ô ly\r\nOutside với ai trong team cùng với những đôi mắt lim dim\r\nLuôn luôn có aice ở trong tim\r\nLạnh lùng như vai ở trong phim\r\nSay say trong đêm nay\r\nSome ice ở trên tay\r\nNhún nhảy ở trên stage\r\nBăng giá trong con tim này\r\nGucci jackey đem xuống\r\nRồi khoác nó lên đi\r\nMùi nước hoa mà anh muốn\r\nĐó là mùi của money (dollar)\r\nMoney talk làm ai phải gật đầu\r\nMan not hot 'cause heart cold\r\nNếu em nhất trí bên anh thật lâu\r\nThì chấp nhận anh có tật xấu\r\nGucci jacket đem xuống\r\nRồi khoác nó lên đi\r\nMùi nước hoa mà anh muốn\r\nĐó là mùi của money (dollar)\r\nCái điều em đang cuốn\r\nRồi đốt nó lên đi\r\nMùi nước hoa mà anh muốn\r\nĐó là mùi của money\r\nYea money man\r\nDollar ở đâu thì anh ở đấy (ya ooh)\r\nAnh đưa em về nơi\r\nEm chưa bao giờ thấy (ohhh)\r\nRolling với cả gang đưa anh tờ giấy (Ohhh)\r\nImma smoke some iceee\r\nPut some ice on your neck\r\nBaby imma watch it frozeee\r\nHit me up with icy lemonade\r\nMck cùng dân chơi overdoseeee\r\nTại sao anh lại có thể bằng giá với mức đấy?\r\nI cannot move\r\nStaying in my ground, chưa đến lúc gãy\r\nCan not lose\r\nBởi vì ai cũng có việc mình thôi\r\nBaby don't hate on the law\r\nAnh chỉ muốn được ngồi chill\r\nBut oh my god, fuck the news\r\nGạt điếu em đang cuốn, rồi đốt nó lên đi!\r\nMùi nước hoa mà anh muốn\r\nĐó là mùi của money (dollar)\r\nMoney talk làm ai phải gật đầu\r\nMan not hot 'cause heart cold\r\nMck-overdose icy heart! (yeah yeah)\r\nGạt điếu em đang cuốn, rồi đốt nó lên đi\r\nMùi nước hoa mà anh muốn\r\nĐó là mùi của money (dollar)\r\nGạt điếu em đang cuốn, rồi đốt nó lên đi!\r\nMùi nước hoa mà anh muốn\r\nĐó là mùi của money (dollar)\r\nWhole gang iceout in the club\r\nĐó là mùi của money");
                            i++;
                            a19 = i;
                            break;
                    }
                    break;

                case "LOCHI":
                    checklike = Convert.ToInt32(VNHITS.Rows[9]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            VNHITS.Rows[9]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a20);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            VNHITS.Rows[9]["Liked"] = 1;
                            Liked.Rows.Add("VN", Properties.Resources.lochi, 0, "LOCHI", "FSRIO", "3:20", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\VN\\VN - LO CHI - FSRIO.wav", "Ɲhớ đến em bao đêm dài.\r\nThức trắng đêm ra thêm bài.\r\nƁắt lấу âm thanh nên sài.\r\n\r\nGirl this song is for уa.\r\nƁao nhiêu ngàу qua, con tim rộn ràng bồi hồi đâu уên.\r\nVì anh muốn viết ra khúc ca cho em, thức đêm với anh nào đâu phiền.\r\n\r\nMột người con gái trông thật xinh đang ngồi bàn kế.\r\nƖ like уour smile, môi cười xinh như là nắng đang về.\r\nƁae em đừng mang Fendi, Gucci haу là LV.\r\nƐm vẫn sáng như ngôi một sao, уou are the beautу.\r\n\r\nỪ xin số phone, mình về nhắn tin.\r\nLượn lờ phố đông và đưa nàng đi xem phim.\r\nMình đi đến Hồ Tâу rồi.\r\nMình qua Ϲircle K ngồi.\r\n\r\nRồi ra Ϲoffee thôi đừng lo chi có anh đâу rồi.\r\nLấу đi, em đã lấу trong mơ là từng câu hát mang mùi hương ngát, hai ta đứng kế ông tơ.\r\n(Và)\r\nϹhớ lo! Anh sẽ hát thêm cho em.\r\nϹhỉ cần em muốn dù là giông tố anh sẽ vẫn luôn ở bên.\r\n\r\nĐừng lo nhé vì anh đã nhớ tên em.\r\nƝgân nga dành cho nàng câu hát dù anh đã có thêm fan.\r\nϹho em niềm vui mới nàу.\r\nMong em đừng lo lắng nhé.\r\nƊon’t run awaу! Vì anh sẽ tới bên em.\r\n\r\n*****\r\nAууa lonelу gurl, tối naу trông em có vẻ không vui.\r\nGiữa làn khói mập mờ, có người nói cần chờ, trái tim em vụn rồi nên em cười không nổi.\r\nJust L O V Ɛ, để tình cảm khiến em tự do.\r\nLet уour soul be free, hãу để anh đưa em hoà vào trong làn gió.\r\n\r\nRide around the citу, từ trung tâm tới đích đến chưa biết.\r\nĐể em ngồi phía sau khiến cho уên xe luôn trong tình trạng thừa nhiệt.\r\n2 taу ôm thật chặt nhá, vì mình đang di chuуển trong cái xã hội đảo điên.\r\nƝhà thì chẳng có gì mấу, ơn giời được cái xe với hai mũ bảo hiểm.\r\n\r\nƁabe em chẳng cần phải làm gì, mà các boу vẫn tự mê.\r\nϹhúng mình lang thang hết cả thủ đô chỉ để tìm ra thêm một vẻ đẹp như thế.\r\nTrăng thì đang dần lên cao, lên cao, lên cao lên khỏi tầng cao ốc.\r\n9pm, em và GTM, đang trên xe đi xem, trên đồi có những vì sao khóc.");
                            i++;
                            a20 = i;
                            break;
                    }
                    break;

                case "All We Know":
                    checklike = Convert.ToInt32(ENHITS.Rows[0]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            ENHITS.Rows[0]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a21);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            ENHITS.Rows[0]["Liked"] = 1;
                            Liked.Rows.Add("EN", Properties.Resources.All_We_Know, 0, "All We Know", "ChainSmokers", "3:30", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - All We Know - The Chainsmokers.wav", "Fighting flames of fire\r\nHang onto burning wires\r\nWe don't care anymore\r\nAre we fading lovers?\r\nWe keep wasting colors\r\nMaybe we should let this go\r\nWe're fallin' apart, still we hold together\r\nWe've passed the end, so we chase forever\r\n'Cause this is all we know\r\nThis feeling's all we know\r\nI'll ride my bike up to the road\r\nDown the streets, right through the city\r\nI'll go everywhere you go\r\nFrom Chicago to the coast\r\nYou tell me, \"Hit this and let's go\r\nBlow the smoke right through the window\"\r\n'Cause this is all we know\r\n'Cause this is all we know\r\n'Cause this is all we know\r\nNever face each other\r\nOne bed, different covers\r\nWe don't care anymore\r\nTwo hearts still beating\r\nOn with different rhythms\r\nMaybe we should let this go\r\nWe're fallin' apart, still we hold together\r\nWe've passed the end, so we chase forever\r\n'Cause this is all we know\r\nThis feeling's all we know\r\nI'll ride my bike up to the road\r\nDown the streets, right through the city\r\nI'll go everywhere you go\r\nFrom Chicago to the coast\r\nYou tell me, \"Hit this and let's go\r\nBlow the smoke right through the window\"\r\n'Cause this is all we know\r\n'Cause this is all we know\r\n'Cause this is all we know");
                            i++;
                            a21 = i;
                            break;
                    }
                    break;

                case "Bad Habits":
                    checklike = Convert.ToInt32(ENHITS.Rows[1]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            ENHITS.Rows[1]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a22);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            ENHITS.Rows[1]["Liked"] = 1;
                            Liked.Rows.Add("EN", Properties.Resources.Bad_Habits, 0, "Bad Habits", "Ed Sheeran", "3:20", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Bad Habits - Ed Sheeran.wav", "One, two, three, four\r\nOoh-ooh, ooh-ooh-ooh\r\nEvery time you come around, you know I can't say no\r\nEvery time the sun goes down, I let you take control\r\nI can feel the paradise before my world implodes\r\nAnd tonight had something wonderful\r\nMy bad habits lead to late nights endin' alone\r\nConversations with a stranger I barely know\r\nSwearin' this will be the last, but it probably won't\r\nI got nothin' left to lose, or use, or do\r\nMy bad habits lead to wide eyes stare into space\r\nAnd I know I'll lose control of the things that I say\r\nYeah, I was lookin' for a way out, now I can't escape\r\nNothin' happens after two, it's true\r\nIt's true, my bad habits lead to you\r\nOoh-ooh, ooh-ooh-ooh\r\nMy bad habits lead to you\r\nOoh-ooh, ooh-ooh-ooh\r\nMy bad habits lead to you\r\nEvery pure intention ends when the good times start\r\nFallin' over everything to reach the first time's spark\r\nIt started under neon lights, and then it all got dark\r\nI only know how to go too far\r\nMy bad habits lead to late nights endin' alone\r\nConversations with a stranger I barely know\r\nSwearin' this will be the last, but it probably won't\r\nI got nothin' left to lose, or use, or do\r\nMy bad habits lead to wide eyes stare into space\r\nAnd I know I'll lose control of the things that I say\r\nYeah, I was lookin' for a way out, now I can't escape\r\nNothin' happens after two, it's true\r\nIt's true, my bad habits lead to you\r\nOoh-ooh, ooh-ooh-ooh\r\nMy bad habits lead to you\r\nOoh-ooh, ooh-ooh-ooh\r\nWe took the long way 'round\r\nAnd burned 'til the fun ran out, now\r\nMy bad habits lead to late nights endin' alone\r\nConversations with a stranger I barely know\r\nSwearin' this will be the last, but it probably won't\r\nI got nothin' left to lose, or use, or do\r\nMy bad habits lead to wide eyes stare into space\r\nAnd I know I'll lose control of the things that I say\r\nYeah, I was lookin' for a way out, now I can't escape\r\nNothin' happens after two, it's true\r\nIt's true, my bad habits lead to you\r\nOoh-ooh, ooh-ooh-ooh\r\nMy bad habits lead to you\r\nOoh-ooh, ooh-ooh-ooh\r\nMy bad habits lead to you");
                            i++;
                            a22 = i;
                            break;
                    }
                    break;

                case "Better Now":
                    checklike = Convert.ToInt32(ENHITS.Rows[2]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            ENHITS.Rows[2]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a23);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            ENHITS.Rows[2]["Liked"] = 1;
                            Liked.Rows.Add("EN", Properties.Resources.Better_Now, 0, "Better Now", "Post Malone", "3:40", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Better Now - Post Malone.wav", "You prolly think that you are better now, better now\r\nYou only say that 'cause I'm not around, not around\r\nYou know I never meant to let you down, let you down\r\nWoulda gave you anything\r\nWoulda gave you everything\r\nYou know I say that I am better now, better now\r\nI only say that 'cause you're not around, not around\r\nYou know I never meant to let you down, let you down\r\nWoulda gave you anything\r\nWoulda gave you everything, oh-oh\r\nI did not believe that it would end, no (end, no)\r\nEverything came second to the Benzo (Benzo)\r\nYou're not even speakin' to my friends, no\r\nYou knew all my uncles and my aunts though\r\n20 candles, blow 'em out and open your eyes\r\nWe were lookin' forward to the rest of our lives\r\nUsed to keep my picture posted by your bedside\r\nNow it's in your dresser with the socks you don't like\r\nAnd I'm rollin', rollin', rollin', rollin'\r\nWith my brothers like it's Jonas, Jonas\r\nDrinkin' Henny and I'm tryna forget\r\nBut I can't get this shit outta my head\r\nYou prolly think that you are better now, better now\r\nYou only say that 'cause I'm not around, not around\r\nYou know I never meant to let you down, let you down\r\nWoulda gave you anything\r\nWoulda gave you everything\r\nYou know I say that I am better now, better now\r\nI only say that 'cause you're not around, not around\r\nYou know I never meant to let you down, let you down\r\nWoulda gave you anything\r\nWoulda gave you everything, oh-oh\r\nI seen you with your other dude\r\nHe seemed like he was pretty cool\r\nI was so broken over you\r\nLife, it goes on, what can you do?\r\nI just wonder what it's gonna take (what it's gonna take?)\r\nAnother foreign or a bigger chain (bigger chain)\r\nBecause no matter how my life has changed\r\nI keep on looking back on better days\r\nYou prolly think that you are better now, better now\r\nYou only say that 'cause I'm not around, not around\r\nYou know I never meant to let you down, let you down\r\nWoulda gave you anything\r\nWoulda gave you everything\r\nYou know I say that I am better now, better now\r\nI only say that 'cause you're not around, not around\r\nYou know I never meant to let you down, let you down\r\nWoulda gave you anything\r\nWoulda gave you everything, oh-oh\r\nI promise, I swear to you, I'll be okay\r\nYou're only the love of my life (the love of my life)\r\nYou prolly think that you are better now, better now\r\nYou only say that 'cause I'm not around, not around\r\nYou know I never meant to let you down, let you down\r\nWoulda gave you anything\r\nWoulda gave you everything\r\nYou know I say that I am better now, better now\r\nI only say that 'cause you're not around, not around\r\nYou know I never meant to let you down, let you down\r\nWoulda gave you anything\r\nWoulda gave you everything, oh-oh");
                            i++;
                            a23 = i;
                            break;
                    }
                    break;

                case "Cake By The Ocean":
                    checklike = Convert.ToInt32(ENHITS.Rows[3]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            ENHITS.Rows[3]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a24);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            ENHITS.Rows[3]["Liked"] = 1;
                            Liked.Rows.Add("EN", Properties.Resources.CBTO, 0, "Cake By The Ocean", "DNCE", "3:30", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Cake By The Ocean - DNCE.wav", "Nah, nah, yeah\r\n(Cake by the ocean)\r\nOh, no\r\nSee you walkin' 'round like it's a funeral\r\nNot so serious, girl, why those feet cold?\r\nWe just gettin' started, don't you tiptoe, tiptoe (ah)\r\nWaste time with a masterpiece, don't waste time with a masterpiece (huh)\r\nYou should be rollin' with me, you should be rollin' with me (ah-ah-ah)\r\nYou're a real-life fantasy, you're a real-life fantasy (huh)\r\nBut you're movin' so carefully, let's start livin' dangerously\r\nTalk to me, baby\r\nI'm goin' blind from this sweet-sweet cravin', whoa-oh\r\nLet's lose our minds and go fuckin' crazy\r\nI-I-I-I-I-I keep on hopin' we'll eat cake by the ocean (uh)\r\nWalk for me, baby\r\nI'll be Diddy, you'll be Naomi, whoa-oh\r\nLet's lose our minds and go fuckin' crazy\r\nI-I-I-I-I-I keep on hopin' we'll eat cake by the ocean (uh)\r\nGoddamn\r\nSee you lickin' frostin' from your own hands\r\nWant another taste, I'm beggin', \"Yes, ma'am\"\r\nI'm tired of all this candy on the dry land, dry land, ooh\r\nWaste time with a masterpiece, don't waste time with a masterpiece (huh)\r\nYou should be rollin' with me, you should be rollin' with me (ah-ah-ah)\r\nYou're a real-life fantasy, you're a real-life fantasy (huh)\r\nBut you're movin' so carefully, let's start livin' dangerously (whoa-oh)\r\nTalk to me, baby\r\nI'm goin' blind from this sweet-sweet cravin', whoa-oh\r\nLet's lose our minds and go fuckin' crazy (ah)\r\nI-I-I-I-I-I keep on hopin' we'll eat cake by the ocean (uh)\r\nWalk for me, baby (walk for me now)\r\nI'll be Diddy, you'll be Naomi, whoa-oh\r\nLet's lose our minds and go fuckin' crazy\r\nI-I-I-I-I-I keep on hopin' we'll eat cake by the ocean\r\nOoh, ah-ah\r\nI-I-I-I-I-I keep on hopin' we'll eat cake by the ocean (uh)\r\nOoh, ah-ah\r\nI-I-I-I-I-I keep on hopin' we'll eat cake by the ocean (uh)\r\nHey, you're fuckin' delicious\r\nTalk to me, girl\r\nTalk to me, baby (talk to me, baby)\r\nI'm goin' blind from this sweet-sweet cravin', whoa-oh\r\nLet's lose our minds and go fuckin' crazy\r\nI-I-I-I-I-I keep on hopin' we'll eat cake by the ocean (hey) (uh)\r\nWalk for me, baby (walk for me now)\r\nI'll be Diddy, you'll be Naomi, whoa-oh\r\nLet's lose our minds and go (and go what?), fuckin' crazy (that's right)\r\nI-I-I-I-I-I keep on hopin' (I'm ready), we'll eat cake by the ocean (ah, yeah)\r\nRed velvet, vanilla, chocolate in my life\r\nFunfetti, I'm ready, I need it every night\r\nRed velvet, vanilla, chocolate in my life\r\nI-I-I-I-I-I keep on hopin' we'll eat cake by the ocean (uh)");
                            i++;
                            a24 = i;
                            break;
                    }
                    break;

                case "Comedy":
                    checklike = Convert.ToInt32(ENHITS.Rows[4]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            ENHITS.Rows[4]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a25);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            ENHITS.Rows[4]["Liked"] = 1;
                            Liked.Rows.Add("EN", Properties.Resources.comedy, 0, "Comedy", "Gen Hoshino", "3:32", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Comedy - Gen Hoshino.wav", "争い合って 壊れかかった\r\nこのお茶目な星で\r\n生まれ落ちた日から よそ者\r\n涙枯れ果てた\r\n帰りゆく場所は夢の中\r\n零れ落ちた 先で出会った\r\nただ秘密を抱え\r\n普通のふりをした あなたと\r\n探し諦めた\r\n私の居場所は作るものだった\r\nあの日交わした\r\n血に勝るもの\r\n心たちの契約を\r\n手を繋ぎ帰ろうか\r\n今日は何食べようか\r\n「こんなことがあった」って\r\n君と話したかったんだ\r\nいつの日も\r\n君となら喜劇よ\r\n踊る軋むベッドで\r\n笑い転げたままで\r\nふざけた生活はつづくさ\r\n劣ってると 言われ育った\r\nこのいかれた星で\r\n普通のふりをして 気づいた\r\n誰が決めつけた\r\n私の光はただ此処にあった\r\nあの日ほどけた\r\n淡い呪いに\r\n心からのさよならを\r\n顔上げて帰ろうか\r\n咲き誇る花々\r\n「こんな綺麗なんだ」って\r\n君と話したかったんだ\r\nどんな日も\r\n君といる奇跡を\r\n命繫ぐキッチンで\r\n伝えきれないままで\r\nふざけた生活はつづく\r\n仕事明けに\r\n歩む共に\r\n朝陽が登るわ ああ\r\nありがとうでは\r\n足りないから\r\n手を繋ぎ\r\nさあうちに帰ろうか\r\n今日は何食べようか\r\n「こんなことがあった」って\r\n君と話したかったんだ\r\nいつの日も\r\n君となら喜劇よ\r\n踊る軋むベッドで\r\n笑い転げたままで\r\n永遠を探そうか\r\nできるだけ暮らそうか\r\nどんなことがあったって\r\n君と話したかったんだ\r\nいつまでも\r\n君となら喜劇よ\r\n分かち合えた日々に\r\n笑い転げた先に\r\nふざけた生活はつづくさ\r\n");
                            i++;
                            a25 = i;
                            break;
                    }
                    break;

                case "Hello":
                    checklike = Convert.ToInt32(ENHITS.Rows[5]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            ENHITS.Rows[5]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a26);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            ENHITS.Rows[5]["Liked"] = 1;
                            Liked.Rows.Add("EN", Properties.Resources.Hello, 0, "Hello", "Adele", "3:48", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Hello - Adele.wav", "Hello, it's me\r\nI was wondering if after all these years you'd like to meet\r\nTo go over everything\r\nThey say that time's supposed to heal ya, but I ain't done much healing\r\nHello, can you hear me?\r\nI'm in California dreaming about who we used to be\r\nWhen we were younger and free\r\nI've forgotten how it felt before the world fell at our feet\r\nThere's such a difference between us\r\nAnd a million miles\r\nHello from the other side\r\nI must've called a thousand times\r\nTo tell you I'm sorry for everything that I've done\r\nBut when I call, you never seem to be home\r\nHello from the outside\r\nAt least I can say that I've tried\r\nTo tell you I'm sorry for breaking your heart\r\nBut it don't matter, it clearly doesn't tear you apart anymore\r\nHello, how are you?\r\nIt's so typical of me to talk about myself, I'm sorry\r\nI hope that you're well\r\nDid you ever make it out of that town where nothing ever happened?\r\nIt's no secret that the both of us\r\nAre running out of time\r\nSo hello from the other side (other side)\r\nI must've called a thousand times (thousand times)\r\nTo tell you I'm sorry for everything that I've done\r\nBut when I call, you never seem to be home\r\nHello from the outside (outside)\r\nAt least I can say that I've tried (I've tried)\r\nTo tell you I'm sorry for breaking your heart\r\nBut it don't matter, it clearly doesn't tear you apart anymore\r\nOoh (lows, lows, lows, lows), anymore\r\n(Highs, highs, highs, highs)\r\nOoh (lows, lows, lows, lows), anymore\r\n(Highs, highs, highs, highs)\r\nOoh (lows, lows, lows, lows), anymore\r\n(Highs, highs, highs, highs)\r\nAnymore (lows, lows, lows, lows)\r\nHello from the other side (other side)\r\nI must've called a thousand times (thousand times)\r\nTo tell you I'm sorry for everything that I've done\r\nBut when I call, you never seem to be home\r\nHello from the outside (outside)\r\nAt least I can say that I've tried (I've tried)\r\nTo tell you I'm sorry for breaking your heart\r\nBut it don't matter, it clearly doesn't tear you apart anymore");
                            i++;
                            a26 = i;
                            break;
                    }
                    break;

                case "Hero":
                    checklike = Convert.ToInt32(ENHITS.Rows[6]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            ENHITS.Rows[6]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a27);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            ENHITS.Rows[6]["Liked"] = 1;
                            Liked.Rows.Add("EN", Properties.Resources.Hero, 0, "Hero", "Cash Cash", "3:20", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Hero - Cash Cash - Christina Perri.wav", "I let my soul fall into you\r\nI never thought I'd fall right through\r\nI fell for every word you said\r\nYou made me feel I needed you\r\nAnd forced my heart to think it's true\r\nBut I found I'm powerless with you\r\nNow I don't need your wings to fly\r\nNo, I don't need a hand to hold in mine this time\r\nYou held me down, but I broke free\r\nI found the love inside of me\r\nNow I don't need a hero to survive\r\n'Cause I already saved my life\r\n'Cause I already saved my life\r\nI fell into your fantasy\r\nBut that's all our love will ever be\r\nI lost hope in saving you and me\r\nYou think I'm lost, falling apart\r\nBut your lies just made a stronger heart\r\nMy life is just about to start\r\nNow I don't need your wings to fly\r\nNo, I don't need a hand to hold in mine this time\r\nYou held me down, but I broke free\r\nI found the love inside of me\r\nNow I don't need a hero to survive\r\n'Cause I already saved my life\r\nAlready saved my life\r\nI already saved my life\r\nAlready saved my life\r\nI already saved my life\r\nNow I don't need your wings to fly\r\nNo, I don't need a hand to hold in mine this time\r\nYou held me down, but I broke free\r\nI found the love inside of me\r\nNow I don't need a hero to survive\r\n'Cause I already saved my life\r\nAlready saved my life\r\nI already saved my life\r\nAlready saved my life\r\nI already saved my life\r\nNow I don't need your wings to fly");
                            i++;
                            a27 = i;
                            break;
                    }
                    break;

                case "Immortals":
                    checklike = Convert.ToInt32(ENHITS.Rows[7]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            ENHITS.Rows[7]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a28);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            ENHITS.Rows[7]["Liked"] = 1;
                            Liked.Rows.Add("EN", Properties.Resources.immortals, 0, "Immortals", "Fall Out Boy", "3:50", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Immortals - Fall Out Boy.wav", "They say we are what we are, but we don't have to be\r\nI'm bad behavior but I do it in the best way\r\nI'll be the watcher (watcher) of the eternal flame\r\nI'll be the guard dog of all your fever dreams\r\n\r\nOh, I am the sand in the bottom half of the hourglass, glass, glass\r\nOh, I try to picture me without you, but I can't\r\n\r\n'Cause we could be immortals, immortals\r\nJust not for long, for long\r\nAnd live with me forever now, pull the blackout curtains down\r\nJust not for long, for long\r\n\r\nWe could be immor—immortals, immor—immortals\r\nImmor—immortals, immor—immortals, immortals\r\n\r\nSometimes the only payoff for having any faith\r\nIs when it's tested again and again every day\r\nI'm still comparing your past to my future\r\nIt might be your wound, but they're my sutures\r\n\r\nOh, I am the sand in the bottom half of the hourglass, glass, glass\r\nOh, I try to picture me without you, but I can't\r\n\r\n'Cause we could be immortals, immortals\r\nJust not for long, for long\r\nAnd live with me forever now, pull the blackout curtains down\r\nJust not for long, for long\r\n\r\nWe could be immor—immortals, immor—immortals, immortals\r\n\r\nAnd live with me forever now\r\nPull the blackout curtains down\r\n\r\nWe could be immortals, immortals\r\nJust not for long, for long\r\n\r\nWe could be immor—immortals, immor—immortals\r\nImmor—immortals, immor—immortals, immortals\r\n");
                            i++;
                            a28 = i;
                            break;
                    }
                    break;

                case "Liar":
                    checklike = Convert.ToInt32(ENHITS.Rows[8]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            ENHITS.Rows[8]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a29);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            ENHITS.Rows[8]["Liked"] = 1;
                            Liked.Rows.Add("EN", Properties.Resources.Liar, 0, "Liar", "Camila Cabello", "3:53", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Liar - Camila Cabello.wav", "I don't care, if you're here\r\nOr if you're not alone\r\nI don't care, it's been too long\r\nIt's kinda like we didn't happen\r\nThe way that your lips move\r\nThe way you whisper slow\r\nI don't care, it's good, it's gone (uh)\r\nI said, I won't lose control, I don't want it (ooh)\r\nI said, I won't get too close but I can't stop it\r\nOh, no, there you go, making me a liar\r\nGot me begging you for more\r\nOh, no, there I go, startin' up a fire, oh, no, no\r\nOh, no, there you go, you're making me a liar, I kinda like it though\r\nOh, no, there I go, startin' up a fire, oh, no, no (ooh)\r\nYou're watching, I feel it (hey)\r\nI know I shouldn't stare (yeah, yeah)\r\nI picture your hands on me\r\nI think I wanna let it happen\r\nBut what if, you kiss me? (Yeah)\r\nAnd what if, I like it?\r\nAnd no one sees it\r\nI said, I won't lose control, I don't want it (ooh)\r\nI said, I won't get too close but I can't stop it (no)\r\nOh, no, there you go, making me a liar\r\nGot me begging you for more\r\nOh, no, there I go, startin' up a fire, oh, no, no\r\nOh, no, there you go, you're making me a liar, I kinda like it though\r\nOh, no, there I go, startin' up a fire, oh, no, no\r\nOh, no, no, no\r\nHere comes trouble, no, no\r\nStartin' up a fire\r\nI don't believe myself when I say\r\nThat I don't need you, oh\r\nI don't believe myself when I say\r\nSo, don't believe me\r\nOh, no, there you go, you're making me a liar\r\nGot me begging you for more\r\nOh, no, there I go, startin' up a fire, oh, no, no\r\nOh, no, there you go, making me a liar, I kinda like it though\r\nOh, no, there I go, startin' up a fire, oh, no, no\r\nYeah\r\nUh, yeah, yeah\r\nNah, yeah\r\nOh, no, no, no\r\nOh, no, no, no\r\nOh, no, you're making me a liar\r\n'Cause my clothes are on the floor\r\nHuh, huh, huh\r\nUh\r\nOh, no, no, no\r\nAnother fire");
                            i++;
                            a29 = i;
                            break;
                    }
                    break;

                case "Make you mine":
                    checklike = Convert.ToInt32(ENHITS.Rows[9]["Liked"]);
                    switch (checklike)
                    {
                        case 1:
                            pictureBox_like.BackgroundImage = Properties.Resources.unheart;
                            //checklike = false;
                            ENHITS.Rows[9]["Liked"] = 0;
                            Liked.Rows.RemoveAt(a30);
                            i--;
                            break;
                        case 0:
                            pictureBox_like.BackgroundImage = Properties.Resources.heartt;
                            //checklike = true;
                            ENHITS.Rows[9]["Liked"] = 1;
                            Liked.Rows.Add("EN", Properties.Resources.make_you_mine, 0, "Make you mine", "PUBLIC", "3:37", " ", "F:\\Codes\\VS\\thuchanh3\\DATA\\EN\\EN - Make You Mine - PUBLIC.wav", "Well, I will call you darlin' and everything will be okay\r\n'Cause I know that I am yours and you are mine\r\nDoesn't matter anyway\r\nIn the night, we'll take a walk, it's nothing funny\r\nJust to talk\r\nPut your hand in mine\r\nYou know that I want to be with you all the time\r\nYou know that I won't stop until I make you mine\r\nYou know that I won't stop until I make you mine\r\nUntil I make you mine\r\nWell, I have called you darlin' and I'll say it again, again\r\nSo kiss me 'til I'm sorry, babe, that you are gone and I'm a mess\r\nAnd I'll hurt you and you'll hurt me and we'll say things we can't repeat\r\nPut your hand in mine\r\nYou know that I want to be with you all the time\r\nYou know that I won't stop until I make you mine\r\nYou know that I won't stop until I make you mine\r\nUntil I make you mine\r\nYou need to know\r\nWe'll take it slow\r\nI miss you so\r\nWe'll take it slow\r\nIt's hard to feel you slipping (You need to know)\r\nThrough my fingers are so numb (We'll take it slow)\r\nAnd how was I supposed to know (I miss you so)\r\nThat you were not the one?\r\nPut your hand in mine\r\nYou know that I want to be with you all the time\r\nYou know that I won't stop until I make you mine\r\nYou know that I won't stop until I make you mine\r\nUntil I make you mine\r\nPut your hand in mine\r\nYou know that I want to be with you all the time\r\nOh darlin', darlin', baby, you're so very fine\r\nYou know that I won't stop until I make you mine\r\nUntil I make you\r\nLa-la-la-la\r\nLa-la-la-la-la-la\r\nLa-la-la-la-la\r\nLa-la-la-la-la-la\r\nLa-la-la-la-la\r\nLa-la-la-la-la-la\r\nLa-la-la-la-la");
                            i++;
                            a30 = i;
                            break;
                    }
                    break;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            switch (label_songname.Text)
            {
                case "NGTANOISE":
                    VIRALHITS.Rows[0]["binhluan"] += ("User\r\n"+textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = VIRALHITS.Rows[0]["binhluan"].ToString();
                    break;

                case "QUERRY":
                    VIRALHITS.Rows[1]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = VIRALHITS.Rows[1]["binhluan"].ToString();
                    break;

                case "TAYTO":
                    VIRALHITS.Rows[2]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = VIRALHITS.Rows[2]["binhluan"].ToString();
                    break;

                case "THICHTHICH":
                    VIRALHITS.Rows[3]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = VIRALHITS.Rows[3]["binhluan"].ToString();
                    break;

                case "tiny love":
                    VIRALHITS.Rows[4]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = VIRALHITS.Rows[4]["binhluan"].ToString();
                    break;

                case "My House":
                    VIRALHITS.Rows[5]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = VIRALHITS.Rows[5]["binhluan"].ToString();
                    break;

                case "New Genesis":
                    VIRALHITS.Rows[6]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = VIRALHITS.Rows[6]["binhluan"].ToString();
                    break;

                case "Sorry":
                    VIRALHITS.Rows[7]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = VIRALHITS.Rows[7]["binhluan"].ToString();
                    break;

                case "Sunflower":
                    VIRALHITS.Rows[8]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = VIRALHITS.Rows[8]["binhluan"].ToString();
                    break;

                case "There for you":
                    VIRALHITS.Rows[9]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = VIRALHITS.Rows[9]["binhluan"].ToString();
                    break;


                case "25":
                    VNHITS.Rows[0]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = VNHITS.Rows[0]["binhluan"].ToString();
                    break;

                case "3107":
                    VNHITS.Rows[1]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = VNHITS.Rows[1]["binhluan"].ToString();
                    break;

                case "AI BIET":
                    VNHITS.Rows[2]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = VNHITS.Rows[2]["binhluan"].ToString();
                    break;

                case "CHIM SAU":
                    VNHITS.Rows[3]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = VNHITS.Rows[3]["binhluan"].ToString();
                    break;

                case "CUA":
                    VNHITS.Rows[4]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = VNHITS.Rows[4]["binhluan"].ToString();
                    break;

                case "GIAYPHUT":
                    VNHITS.Rows[5]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = VNHITS.Rows[5]["binhluan"].ToString();
                    break;

                case "GU":
                    VNHITS.Rows[6]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = VNHITS.Rows[6]["binhluan"].ToString();
                    break;

                case "HOLD MY HAND":
                    VNHITS.Rows[7]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = VNHITS.Rows[7]["binhluan"].ToString();
                    break;

                case "ICEMAN":
                    VNHITS.Rows[8]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = VNHITS.Rows[8]["binhluan"].ToString();
                    break;

                case "LOCHI":
                    VNHITS.Rows[9]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = VNHITS.Rows[9]["binhluan"].ToString();
                    break;

                case "All We Know":
                    ENHITS.Rows[0]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = ENHITS.Rows[0]["binhluan"].ToString();
                    break;

                case "Bad Habits":
                    ENHITS.Rows[1]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = ENHITS.Rows[1]["binhluan"].ToString();
                    break;

                case "Better Now":
                    ENHITS.Rows[2]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = ENHITS.Rows[2]["binhluan"].ToString();
                    break;

                case "Cake By The Ocean":
                    ENHITS.Rows[3]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = ENHITS.Rows[3]["binhluan"].ToString();
                    break;

                case "Comedy":
                    ENHITS.Rows[4]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = ENHITS.Rows[4]["binhluan"].ToString();
                    break;

                case "Hello":
                    ENHITS.Rows[5]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = ENHITS.Rows[5]["binhluan"].ToString();
                    break;

                case "Hero":
                    ENHITS.Rows[6]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = ENHITS.Rows[6]["binhluan"].ToString();
                    break;

                case "Immortals":
                    ENHITS.Rows[7]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = ENHITS.Rows[7]["binhluan"].ToString();
                    break;

                case "Liar":
                    ENHITS.Rows[8]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = ENHITS.Rows[8]["binhluan"].ToString();
                    break;

                case "Make you mine":
                    ENHITS.Rows[9]["binhluan"] += ("User\r\n" + textBox_cmt.Text + "\r\n----------------------------------------------------------------\r\n");
                    label_1song_5.Text = ENHITS.Rows[9]["binhluan"].ToString();
                    break;
            }
        }
        string FileSave;//biến chứa đường dẫn lưu files
        WebClient Wc = new WebClient();//Khai báo biến webclient để thực hiện tải về


        private void Save_File()//chọn đường dẫn lưu file
        {
            SaveFileDialog saveDial = new SaveFileDialog();//Hộp thoại tạo file lưu trữ
            //saveDial.Title = "Download Music";//tên hộp thoại
            saveDial.Filter = ".mp3|*.mp3";//Định dạnh file lưu
            saveDial.Filter = ".mp4|*.mp4";//Định dạnh file lưu
            if (saveDial.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)//Nếu không ấn hủy thì sẽ lấy đường dẫn lưu file
                FileSave = saveDial.FileName;//Lấy đường dẫn để lưu file
            textBox2.Text = FileSave;//Xuất đường dẫn ra textbox
        }

        private void button2_Click_1(object sender, EventArgs e)//Sự kiện ấn nút chọn đường dẫn lưu file
        {
            Save_File();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Wc_DownloadProgressChange);//Hiển thị phần trăm tải về bằng progressBar
            Uri FileUrl = new Uri(textBox1.Text.Trim());//Uri để tạo đầu vào cho Wc tải về, Trim để xóa kí tự rỗng ở 2 đầu
            if (textBox2.Text == "" || textBox2.Text == null)//Nếu chưa chọn đường dẫn để lưu thì phải chọn xong mới tải
                Save_File();
            else//Nếu đã chọn đường dẫn lưu file thì bắt đầu tải
                Wc.DownloadFileAsync(FileUrl, textBox2.Text);//Bắt đầu tải về Cú pháp: TênBiếnWebclient.DownloadFileAsync(Uri chứa đường dẫn tải về, Địa điểm lưu file)

        }
        void Wc_DownloadProgressChange(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;//Gán phần trăm tải về vào ProgressBar
            label_percent.Text = progressBar1.Value.ToString() + "%";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            panel_down.Visible = true;

            switch (label_songname.Text)
            {
                case "NGTANOISE":
                    textBox1.Text = "https://www.youtube.com/watch?v=fATWCKdQrTI&ab_channel=Vsoul-Topic";
                    break;

                case "QUERRY":
                    textBox1.Text = "https://www.youtube.com/watch?v=7PxxZWrlRTc&ab_channel=QNT";
                    break;

                case "TAYTO":
                    textBox1.Text = "https://www.youtube.com/watch?v=cKBRHaPdjbc&ab_channel=RapitalOfficial";
                    break;

                case "THICHTHICH":
                    textBox1.Text = "https://www.youtube.com/watch?v=OqdA6DKV1Fs&ab_channel=PhuongLyOfficial";
                    break;

                case "tiny love":
                    textBox1.Text = "https://www.youtube.com/watch?v=Z7tiB0xMrZg&ab_channel=ThịnhSuy";
                    break;

                case "My House":
                    textBox1.Text = "https://www.youtube.com/watch?v=uo35R9zQsAI&ab_channel=FloRida";
                    break;

                case "New Genesis":
                    textBox1.Text = "https://www.youtube.com/watch?v=IPaSD4sQOkg&ab_channel=CrunchyrollCollection";
                    break;

                case "Sorry":
                    textBox1.Text = "https://www.youtube.com/watch?v=fRh_vgS2dFE&ab_channel=JustinBieberVEVO";
                    break;

                case "Sunflower":
                    textBox1.Text = "https://www.youtube.com/watch?v=ApXoWvfEYVU&ab_channel=PostMaloneVEVO";
                    break;

                case "There for you":
                    textBox1.Text = "https://www.youtube.com/watch?v=pNNMr5glICM&ab_channel=MartinGarrix";
                    break;


                case "25":
                    textBox1.Text = "https://www.youtube.com/watch?v=FPtITmtjWhQ&ab_channel=ROYRecords";
                    break;

                case "3107":
                    textBox1.Text = "https://www.youtube.com/watch?v=V5GS5ANG96M&ab_channel=W%2Fn";
                    break;

                case "AI BIET":
                    textBox1.Text = "https://www.youtube.com/watch?v=n8poPC4Vu_E&ab_channel=WEAN";
                    break;

                case "CHIM SAU":
                    textBox1.Text = "https://www.youtube.com/watch?v=KFz_v5zDKuw&ab_channel=SonyTranOfficial";
                    break;

                case "CUA":
                    textBox1.Text = "https://www.youtube.com/watch?v=P8qEusQiwsw&ab_channel=HIEUTHUHAI";
                    break;

                case "GIAYPHUT":
                    textBox1.Text = "https://www.youtube.com/watch?v=lwZ6mRpD62o&ab_channel=kidsai";
                    break;

                case "GU":
                    textBox1.Text = "https://www.youtube.com/watch?v=VI47bTJaMe4&ab_channel=CUKAK";
                    break;

                case "HOLD MY HAND":
                    textBox1.Text = "https://www.youtube.com/watch?v=6Cs3Bn121yw&ab_channel=PollOfficial";
                    break;

                case "ICEMAN":
                    textBox1.Text = "https://www.youtube.com/watch?v=A_CXiUlIJdA&ab_channel=Sol7-Topic";
                    break;

                case "LOCHI":
                    textBox1.Text = "https://www.youtube.com/watch?v=o5Pad_ge4KE&ab_channel=FSRio";
                    break;

                case "All We Know":
                    textBox1.Text = "https://www.youtube.com/watch?v=lEi_XBg2Fpk&ab_channel=ChainsmokersVEVO";
                    break;

                case "Bad Habits":
                    textBox1.Text = "https://www.youtube.com/watch?v=orJSJGHjBLI&ab_channel=EdSheeran";
                    break;

                case "Better Now":
                    textBox1.Text = "https://www.youtube.com/watch?v=UYwF-jdcVjY&ab_channel=PostMaloneVEVO";
                    break;

                case "Cake By The Ocean":
                    textBox1.Text = "https://www.youtube.com/watch?v=vWaRiD5ym74&ab_channel=DNCEVEVO";
                    break;

                case "Comedy":
                    textBox1.Text = "https://www.youtube.com/watch?v=G3qQtf7jahE&ab_channel=mysticholy";
                    break;

                case "Hello":
                    textBox1.Text = "https://www.youtube.com/watch?v=YQHsXMglC9A&ab_channel=AdeleVEVO";
                    break;

                case "Hero":
                    textBox1.Text = "https://www.youtube.com/watch?v=78MlJNezFRo&ab_channel=RachelGardner";
                    break;

                case "Immortals":
                    textBox1.Text = "https://www.youtube.com/watch?v=l9PxOanFjxQ&ab_channel=FallOutBoyVEVO";
                    break;

                case "Liar":
                    textBox1.Text = "https://www.youtube.com/watch?v=KsDZix4ZSlU&ab_channel=CamilaCabelloVEVO";
                    break;

                case "Make you mine":
                    textBox1.Text = "https://www.youtube.com/watch?v=nLnp0tpZ0ok&ab_channel=PUBLICVEVO";
                    break;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            panel_down.Visible = false;
        }

        private void pictureBox_liked_Click(object sender, EventArgs e)
        {
            viralcheck = 0;
            vncheck = 0;
            encheck = 0;

            panel_likedsong.Visible = true;
            label_like_count.Text = (i+1).ToString();

            switch (i)
            {
                case -1:
                    panel_like_1.Visible = false;
                    panel_like_2.Visible = false;
                    panel_like_3.Visible = false;
                    panel_like_4.Visible = false;
                    panel_like_5.Visible = false;
                    panel_like_6.Visible = false;
                    panel_like_7.Visible = false;
                    panel_like_8.Visible = false;
                    panel_like_9.Visible = false;
                    panel_like_10.Visible = false;
                    break;
                case 0:
                    panel_like_1.Visible = true;
                    panel_like_2.Visible = false;
                    panel_like_3.Visible = false;
                    panel_like_4.Visible = false;
                    panel_like_5.Visible = false;
                    panel_like_6.Visible = false;
                    panel_like_7.Visible = false;
                    panel_like_8.Visible = false;
                    panel_like_9.Visible = false;
                    panel_like_10.Visible = false;

                    pictureBox26.BackgroundImage = (Image)Liked.Rows[0]["hinhanh"];
                    label_like_1.Text = Liked.Rows[0]["tenbaihat"].ToString();
                    label_like_2.Text = Liked.Rows[0]["tencasi"].ToString();
                    label_like_3.Text = Liked.Rows[0]["tenbaihat"].ToString();
                    label_like_4.Text = Liked.Rows[0]["thoiluong"].ToString();

                    break;
                case 1:
                    panel_like_1.Visible = true;
                    panel_like_2.Visible = true;
                    panel_like_3.Visible = false;
                    panel_like_4.Visible = false;
                    panel_like_5.Visible = false;
                    panel_like_6.Visible = false;
                    panel_like_7.Visible = false;
                    panel_like_8.Visible = false;
                    panel_like_9.Visible = false;
                    panel_like_10.Visible = false;

                    pictureBox26.BackgroundImage = (Image)Liked.Rows[0]["hinhanh"];
                    label_like_1.Text = Liked.Rows[0]["tenbaihat"].ToString();
                    label_like_2.Text = Liked.Rows[0]["tencasi"].ToString();
                    label_like_3.Text = Liked.Rows[0]["tenbaihat"].ToString();
                    label_like_4.Text = Liked.Rows[0]["thoiluong"].ToString();

                    pictureBox25.BackgroundImage = (Image)Liked.Rows[1]["hinhanh"];
                    label_like_5.Text = Liked.Rows[1]["tenbaihat"].ToString();
                    label_like_6.Text = Liked.Rows[1]["tencasi"].ToString();
                    label_like_7.Text = Liked.Rows[1]["tenbaihat"].ToString();
                    label_like_8.Text = Liked.Rows[1]["thoiluong"].ToString();

                    break;
                case 2:
                    panel_like_1.Visible = true;
                    panel_like_2.Visible = true;
                    panel_like_3.Visible = true;
                    panel_like_4.Visible = false;
                    panel_like_5.Visible = false;
                    panel_like_6.Visible = false;
                    panel_like_7.Visible = false;
                    panel_like_8.Visible = false;
                    panel_like_9.Visible = false;
                    panel_like_10.Visible = false;

                    pictureBox26.BackgroundImage = (Image)Liked.Rows[0]["hinhanh"];
                    label_like_1.Text = Liked.Rows[0]["tenbaihat"].ToString();
                    label_like_2.Text = Liked.Rows[0]["tencasi"].ToString();
                    label_like_3.Text = Liked.Rows[0]["tenbaihat"].ToString();
                    label_like_4.Text = Liked.Rows[0]["thoiluong"].ToString();

                    pictureBox25.BackgroundImage = (Image)Liked.Rows[1]["hinhanh"];
                    label_like_5.Text = Liked.Rows[1]["tenbaihat"].ToString();
                    label_like_6.Text = Liked.Rows[1]["tencasi"].ToString();
                    label_like_7.Text = Liked.Rows[1]["tenbaihat"].ToString();
                    label_like_8.Text = Liked.Rows[1]["thoiluong"].ToString();

                    pictureBox24.BackgroundImage = (Image)Liked.Rows[2]["hinhanh"];
                    label_like_9.Text = Liked.Rows[2]["tenbaihat"].ToString();
                    label_like_10.Text = Liked.Rows[2]["tencasi"].ToString();
                    label_like_11.Text = Liked.Rows[2]["tenbaihat"].ToString();
                    label_like_12.Text = Liked.Rows[2]["thoiluong"].ToString();

                    break;
                case 3:
                    panel_like_1.Visible = true;
                    panel_like_2.Visible = true;
                    panel_like_3.Visible = true;
                    panel_like_4.Visible = true;
                    panel_like_5.Visible = false;
                    panel_like_6.Visible = false;
                    panel_like_7.Visible = false;
                    panel_like_8.Visible = false;
                    panel_like_9.Visible = false;
                    panel_like_10.Visible = false;

                    pictureBox26.BackgroundImage = (Image)Liked.Rows[0]["hinhanh"];
                    label_like_1.Text = Liked.Rows[0]["tenbaihat"].ToString();
                    label_like_2.Text = Liked.Rows[0]["tencasi"].ToString();
                    label_like_3.Text = Liked.Rows[0]["tenbaihat"].ToString();
                    label_like_4.Text = Liked.Rows[0]["thoiluong"].ToString();

                    pictureBox25.BackgroundImage = (Image)Liked.Rows[1]["hinhanh"];
                    label_like_5.Text = Liked.Rows[1]["tenbaihat"].ToString();
                    label_like_6.Text = Liked.Rows[1]["tencasi"].ToString();
                    label_like_7.Text = Liked.Rows[1]["tenbaihat"].ToString();
                    label_like_8.Text = Liked.Rows[1]["thoiluong"].ToString();

                    pictureBox24.BackgroundImage = (Image)Liked.Rows[2]["hinhanh"];
                    label_like_9.Text = Liked.Rows[2]["tenbaihat"].ToString();
                    label_like_10.Text = Liked.Rows[2]["tencasi"].ToString();
                    label_like_11.Text = Liked.Rows[2]["tenbaihat"].ToString();
                    label_like_12.Text = Liked.Rows[2]["thoiluong"].ToString();

                    pictureBox23.BackgroundImage = (Image)Liked.Rows[3]["hinhanh"];
                    label_like_13.Text = Liked.Rows[3]["tenbaihat"].ToString();
                    label_like_14.Text = Liked.Rows[3]["tencasi"].ToString();
                    label_like_15.Text = Liked.Rows[3]["tenbaihat"].ToString();
                    label_like_16.Text = Liked.Rows[3]["thoiluong"].ToString();

                    break;
                case 4:
                    panel_like_1.Visible = true;
                    panel_like_2.Visible = true;
                    panel_like_3.Visible = true;
                    panel_like_4.Visible = true;
                    panel_like_5.Visible = true;
                    panel_like_6.Visible = false;
                    panel_like_7.Visible = false;
                    panel_like_8.Visible = false;
                    panel_like_9.Visible = false;
                    panel_like_10.Visible = false;
                    pictureBox26.BackgroundImage = (Image)Liked.Rows[0]["hinhanh"];
                    label_like_1.Text = Liked.Rows[0]["tenbaihat"].ToString();
                    label_like_2.Text = Liked.Rows[0]["tencasi"].ToString();
                    label_like_3.Text = Liked.Rows[0]["tenbaihat"].ToString();
                    label_like_4.Text = Liked.Rows[0]["thoiluong"].ToString();

                    pictureBox25.BackgroundImage = (Image)Liked.Rows[1]["hinhanh"];
                    label_like_5.Text = Liked.Rows[1]["tenbaihat"].ToString();
                    label_like_6.Text = Liked.Rows[1]["tencasi"].ToString();
                    label_like_7.Text = Liked.Rows[1]["tenbaihat"].ToString();
                    label_like_8.Text = Liked.Rows[1]["thoiluong"].ToString();

                    pictureBox24.BackgroundImage = (Image)Liked.Rows[2]["hinhanh"];
                    label_like_9.Text = Liked.Rows[2]["tenbaihat"].ToString();
                    label_like_10.Text = Liked.Rows[2]["tencasi"].ToString();
                    label_like_11.Text = Liked.Rows[2]["tenbaihat"].ToString();
                    label_like_12.Text = Liked.Rows[2]["thoiluong"].ToString();

                    pictureBox23.BackgroundImage = (Image)Liked.Rows[3]["hinhanh"];
                    label_like_13.Text = Liked.Rows[3]["tenbaihat"].ToString();
                    label_like_14.Text = Liked.Rows[3]["tencasi"].ToString();
                    label_like_15.Text = Liked.Rows[3]["tenbaihat"].ToString();
                    label_like_16.Text = Liked.Rows[3]["thoiluong"].ToString();

                    pictureBox22.BackgroundImage = (Image)Liked.Rows[4]["hinhanh"];
                    label_like_17.Text = Liked.Rows[4]["tenbaihat"].ToString();
                    label_like_18.Text = Liked.Rows[4]["tencasi"].ToString();
                    label_like_19.Text = Liked.Rows[4]["tenbaihat"].ToString();
                    label_like_20.Text = Liked.Rows[4]["thoiluong"].ToString();

                    break;
                case 5:
                    panel_like_1.Visible = true;
                    panel_like_2.Visible = true;
                    panel_like_3.Visible = true;
                    panel_like_4.Visible = true;
                    panel_like_5.Visible = true;
                    panel_like_6.Visible = true;
                    panel_like_7.Visible = false;
                    panel_like_8.Visible = false;
                    panel_like_9.Visible = false;
                    panel_like_10.Visible = false;

                    pictureBox26.BackgroundImage = (Image)Liked.Rows[0]["hinhanh"];
                    label_like_1.Text = Liked.Rows[0]["tenbaihat"].ToString();
                    label_like_2.Text = Liked.Rows[0]["tencasi"].ToString();
                    label_like_3.Text = Liked.Rows[0]["tenbaihat"].ToString();
                    label_like_4.Text = Liked.Rows[0]["thoiluong"].ToString();

                    pictureBox25.BackgroundImage = (Image)Liked.Rows[1]["hinhanh"];
                    label_like_5.Text = Liked.Rows[1]["tenbaihat"].ToString();
                    label_like_6.Text = Liked.Rows[1]["tencasi"].ToString();
                    label_like_7.Text = Liked.Rows[1]["tenbaihat"].ToString();
                    label_like_8.Text = Liked.Rows[1]["thoiluong"].ToString();

                    pictureBox24.BackgroundImage = (Image)Liked.Rows[2]["hinhanh"];
                    label_like_9.Text = Liked.Rows[2]["tenbaihat"].ToString();
                    label_like_10.Text = Liked.Rows[2]["tencasi"].ToString();
                    label_like_11.Text = Liked.Rows[2]["tenbaihat"].ToString();
                    label_like_12.Text = Liked.Rows[2]["thoiluong"].ToString();

                    pictureBox23.BackgroundImage = (Image)Liked.Rows[3]["hinhanh"];
                    label_like_13.Text = Liked.Rows[3]["tenbaihat"].ToString();
                    label_like_14.Text = Liked.Rows[3]["tencasi"].ToString();
                    label_like_15.Text = Liked.Rows[3]["tenbaihat"].ToString();
                    label_like_16.Text = Liked.Rows[3]["thoiluong"].ToString();

                    pictureBox22.BackgroundImage = (Image)Liked.Rows[4]["hinhanh"];
                    label_like_17.Text = Liked.Rows[4]["tenbaihat"].ToString();
                    label_like_18.Text = Liked.Rows[4]["tencasi"].ToString();
                    label_like_19.Text = Liked.Rows[4]["tenbaihat"].ToString();
                    label_like_20.Text = Liked.Rows[4]["thoiluong"].ToString();

                    pictureBox21.BackgroundImage = (Image)Liked.Rows[5]["hinhanh"];
                    label_like_21.Text = Liked.Rows[5]["tenbaihat"].ToString();
                    label_like_22.Text = Liked.Rows[5]["tencasi"].ToString();
                    label_like_23.Text = Liked.Rows[5]["tenbaihat"].ToString();
                    label_like_24.Text = Liked.Rows[5]["thoiluong"].ToString();

                    break;
                case 6:
                    panel_like_1.Visible = true;
                    panel_like_2.Visible = true;
                    panel_like_3.Visible = true;
                    panel_like_4.Visible = true;
                    panel_like_5.Visible = true;
                    panel_like_6.Visible = true;
                    panel_like_7.Visible = true;
                    panel_like_8.Visible = false;
                    panel_like_9.Visible = false;
                    panel_like_10.Visible = false;

                    pictureBox26.BackgroundImage = (Image)Liked.Rows[0]["hinhanh"];
                    label_like_1.Text = Liked.Rows[0]["tenbaihat"].ToString();
                    label_like_2.Text = Liked.Rows[0]["tencasi"].ToString();
                    label_like_3.Text = Liked.Rows[0]["tenbaihat"].ToString();
                    label_like_4.Text = Liked.Rows[0]["thoiluong"].ToString();

                    pictureBox25.BackgroundImage = (Image)Liked.Rows[1]["hinhanh"];
                    label_like_5.Text = Liked.Rows[1]["tenbaihat"].ToString();
                    label_like_6.Text = Liked.Rows[1]["tencasi"].ToString();
                    label_like_7.Text = Liked.Rows[1]["tenbaihat"].ToString();
                    label_like_8.Text = Liked.Rows[1]["thoiluong"].ToString();

                    pictureBox24.BackgroundImage = (Image)Liked.Rows[2]["hinhanh"];
                    label_like_9.Text = Liked.Rows[2]["tenbaihat"].ToString();
                    label_like_10.Text = Liked.Rows[2]["tencasi"].ToString();
                    label_like_11.Text = Liked.Rows[2]["tenbaihat"].ToString();
                    label_like_12.Text = Liked.Rows[2]["thoiluong"].ToString();

                    pictureBox23.BackgroundImage = (Image)Liked.Rows[3]["hinhanh"];
                    label_like_13.Text = Liked.Rows[3]["tenbaihat"].ToString();
                    label_like_14.Text = Liked.Rows[3]["tencasi"].ToString();
                    label_like_15.Text = Liked.Rows[3]["tenbaihat"].ToString();
                    label_like_16.Text = Liked.Rows[3]["thoiluong"].ToString();

                    pictureBox22.BackgroundImage = (Image)Liked.Rows[4]["hinhanh"];
                    label_like_17.Text = Liked.Rows[4]["tenbaihat"].ToString();
                    label_like_18.Text = Liked.Rows[4]["tencasi"].ToString();
                    label_like_19.Text = Liked.Rows[4]["tenbaihat"].ToString();
                    label_like_20.Text = Liked.Rows[4]["thoiluong"].ToString();

                    pictureBox21.BackgroundImage = (Image)Liked.Rows[5]["hinhanh"];
                    label_like_21.Text = Liked.Rows[5]["tenbaihat"].ToString();
                    label_like_22.Text = Liked.Rows[5]["tencasi"].ToString();
                    label_like_23.Text = Liked.Rows[5]["tenbaihat"].ToString();
                    label_like_24.Text = Liked.Rows[5]["thoiluong"].ToString();

                    pictureBox20.BackgroundImage = (Image)Liked.Rows[6]["hinhanh"];
                    label_like_25.Text = Liked.Rows[6]["tenbaihat"].ToString();
                    label_like_26.Text = Liked.Rows[6]["tencasi"].ToString();
                    label_like_27.Text = Liked.Rows[6]["tenbaihat"].ToString();
                    label_like_28.Text = Liked.Rows[6]["thoiluong"].ToString();

                    break;
                case 7:
                    panel_like_1.Visible = true;
                    panel_like_2.Visible = true;
                    panel_like_3.Visible = true;
                    panel_like_4.Visible = true;
                    panel_like_5.Visible = true;
                    panel_like_6.Visible = true;
                    panel_like_7.Visible = true;
                    panel_like_8.Visible = true;
                    panel_like_9.Visible = false;
                    panel_like_10.Visible = false;

                    pictureBox26.BackgroundImage = (Image)Liked.Rows[0]["hinhanh"];
                    label_like_1.Text = Liked.Rows[0]["tenbaihat"].ToString();
                    label_like_2.Text = Liked.Rows[0]["tencasi"].ToString();
                    label_like_3.Text = Liked.Rows[0]["tenbaihat"].ToString();
                    label_like_4.Text = Liked.Rows[0]["thoiluong"].ToString();

                    pictureBox25.BackgroundImage = (Image)Liked.Rows[1]["hinhanh"];
                    label_like_5.Text = Liked.Rows[1]["tenbaihat"].ToString();
                    label_like_6.Text = Liked.Rows[1]["tencasi"].ToString();
                    label_like_7.Text = Liked.Rows[1]["tenbaihat"].ToString();
                    label_like_8.Text = Liked.Rows[1]["thoiluong"].ToString();

                    pictureBox24.BackgroundImage = (Image)Liked.Rows[2]["hinhanh"];
                    label_like_9.Text = Liked.Rows[2]["tenbaihat"].ToString();
                    label_like_10.Text = Liked.Rows[2]["tencasi"].ToString();
                    label_like_11.Text = Liked.Rows[2]["tenbaihat"].ToString();
                    label_like_12.Text = Liked.Rows[2]["thoiluong"].ToString();

                    pictureBox23.BackgroundImage = (Image)Liked.Rows[3]["hinhanh"];
                    label_like_13.Text = Liked.Rows[3]["tenbaihat"].ToString();
                    label_like_14.Text = Liked.Rows[3]["tencasi"].ToString();
                    label_like_15.Text = Liked.Rows[3]["tenbaihat"].ToString();
                    label_like_16.Text = Liked.Rows[3]["thoiluong"].ToString();

                    pictureBox22.BackgroundImage = (Image)Liked.Rows[4]["hinhanh"];
                    label_like_17.Text = Liked.Rows[4]["tenbaihat"].ToString();
                    label_like_18.Text = Liked.Rows[4]["tencasi"].ToString();
                    label_like_19.Text = Liked.Rows[4]["tenbaihat"].ToString();
                    label_like_20.Text = Liked.Rows[4]["thoiluong"].ToString();

                    pictureBox21.BackgroundImage = (Image)Liked.Rows[5]["hinhanh"];
                    label_like_21.Text = Liked.Rows[5]["tenbaihat"].ToString();
                    label_like_22.Text = Liked.Rows[5]["tencasi"].ToString();
                    label_like_23.Text = Liked.Rows[5]["tenbaihat"].ToString();
                    label_like_24.Text = Liked.Rows[5]["thoiluong"].ToString();

                    pictureBox20.BackgroundImage = (Image)Liked.Rows[6]["hinhanh"];
                    label_like_25.Text = Liked.Rows[6]["tenbaihat"].ToString();
                    label_like_26.Text = Liked.Rows[6]["tencasi"].ToString();
                    label_like_27.Text = Liked.Rows[6]["tenbaihat"].ToString();
                    label_like_28.Text = Liked.Rows[6]["thoiluong"].ToString();

                    pictureBox19.BackgroundImage = (Image)Liked.Rows[7]["hinhanh"];
                    label_like_29.Text = Liked.Rows[7]["tenbaihat"].ToString();
                    label_like_30.Text = Liked.Rows[7]["tencasi"].ToString();
                    label_like_31.Text = Liked.Rows[7]["tenbaihat"].ToString();
                    label_like_32.Text = Liked.Rows[7]["thoiluong"].ToString();

                    break;
                case 8:
                    panel_like_1.Visible = true;
                    panel_like_2.Visible = true;
                    panel_like_3.Visible = true;
                    panel_like_4.Visible = true;
                    panel_like_5.Visible = true;
                    panel_like_6.Visible = true;
                    panel_like_7.Visible = true;
                    panel_like_8.Visible = true;
                    panel_like_9.Visible = true;
                    panel_like_10.Visible = false;

                    pictureBox26.BackgroundImage = (Image)Liked.Rows[0]["hinhanh"];
                    label_like_1.Text = Liked.Rows[0]["tenbaihat"].ToString();
                    label_like_2.Text = Liked.Rows[0]["tencasi"].ToString();
                    label_like_3.Text = Liked.Rows[0]["tenbaihat"].ToString();
                    label_like_4.Text = Liked.Rows[0]["thoiluong"].ToString();

                    pictureBox25.BackgroundImage = (Image)Liked.Rows[1]["hinhanh"];
                    label_like_5.Text = Liked.Rows[1]["tenbaihat"].ToString();
                    label_like_6.Text = Liked.Rows[1]["tencasi"].ToString();
                    label_like_7.Text = Liked.Rows[1]["tenbaihat"].ToString();
                    label_like_8.Text = Liked.Rows[1]["thoiluong"].ToString();

                    pictureBox24.BackgroundImage = (Image)Liked.Rows[2]["hinhanh"];
                    label_like_9.Text = Liked.Rows[2]["tenbaihat"].ToString();
                    label_like_10.Text = Liked.Rows[2]["tencasi"].ToString();
                    label_like_11.Text = Liked.Rows[2]["tenbaihat"].ToString();
                    label_like_12.Text = Liked.Rows[2]["thoiluong"].ToString();

                    pictureBox23.BackgroundImage = (Image)Liked.Rows[3]["hinhanh"];
                    label_like_13.Text = Liked.Rows[3]["tenbaihat"].ToString();
                    label_like_14.Text = Liked.Rows[3]["tencasi"].ToString();
                    label_like_15.Text = Liked.Rows[3]["tenbaihat"].ToString();
                    label_like_16.Text = Liked.Rows[3]["thoiluong"].ToString();

                    pictureBox22.BackgroundImage = (Image)Liked.Rows[4]["hinhanh"];
                    label_like_17.Text = Liked.Rows[4]["tenbaihat"].ToString();
                    label_like_18.Text = Liked.Rows[4]["tencasi"].ToString();
                    label_like_19.Text = Liked.Rows[4]["tenbaihat"].ToString();
                    label_like_20.Text = Liked.Rows[4]["thoiluong"].ToString();

                    pictureBox21.BackgroundImage = (Image)Liked.Rows[5]["hinhanh"];
                    label_like_21.Text = Liked.Rows[5]["tenbaihat"].ToString();
                    label_like_22.Text = Liked.Rows[5]["tencasi"].ToString();
                    label_like_23.Text = Liked.Rows[5]["tenbaihat"].ToString();
                    label_like_24.Text = Liked.Rows[5]["thoiluong"].ToString();

                    pictureBox20.BackgroundImage = (Image)Liked.Rows[6]["hinhanh"];
                    label_like_25.Text = Liked.Rows[6]["tenbaihat"].ToString();
                    label_like_26.Text = Liked.Rows[6]["tencasi"].ToString();
                    label_like_27.Text = Liked.Rows[6]["tenbaihat"].ToString();
                    label_like_28.Text = Liked.Rows[6]["thoiluong"].ToString();

                    pictureBox19.BackgroundImage = (Image)Liked.Rows[7]["hinhanh"];
                    label_like_29.Text = Liked.Rows[7]["tenbaihat"].ToString();
                    label_like_30.Text = Liked.Rows[7]["tencasi"].ToString();
                    label_like_31.Text = Liked.Rows[7]["tenbaihat"].ToString();
                    label_like_32.Text = Liked.Rows[7]["thoiluong"].ToString();

                    pictureBox18.BackgroundImage = (Image)Liked.Rows[8]["hinhanh"];
                    label_like_33.Text = Liked.Rows[8]["tenbaihat"].ToString();
                    label_like_34.Text = Liked.Rows[8]["tencasi"].ToString();
                    label_like_35.Text = Liked.Rows[8]["tenbaihat"].ToString();
                    label_like_36.Text = Liked.Rows[8]["thoiluong"].ToString();
                    break;
                case 9:
                    panel_like_1.Visible = true;
                    panel_like_2.Visible = true;
                    panel_like_3.Visible = true;
                    panel_like_4.Visible = true;
                    panel_like_5.Visible = true;
                    panel_like_6.Visible = true;
                    panel_like_7.Visible = true;
                    panel_like_8.Visible = true;
                    panel_like_9.Visible = true;
                    panel_like_10.Visible = true;

                    pictureBox26.BackgroundImage = (Image)Liked.Rows[0]["hinhanh"];
                    label_like_1.Text = Liked.Rows[0]["tenbaihat"].ToString();
                    label_like_2.Text = Liked.Rows[0]["tencasi"].ToString();
                    label_like_3.Text = Liked.Rows[0]["tenbaihat"].ToString();
                    label_like_4.Text = Liked.Rows[0]["thoiluong"].ToString();

                    pictureBox25.BackgroundImage = (Image)Liked.Rows[1]["hinhanh"];
                    label_like_5.Text = Liked.Rows[1]["tenbaihat"].ToString();
                    label_like_6.Text = Liked.Rows[1]["tencasi"].ToString();
                    label_like_7.Text = Liked.Rows[1]["tenbaihat"].ToString();
                    label_like_8.Text = Liked.Rows[1]["thoiluong"].ToString();

                    pictureBox24.BackgroundImage = (Image)Liked.Rows[2]["hinhanh"];
                    label_like_9.Text = Liked.Rows[2]["tenbaihat"].ToString();
                    label_like_10.Text = Liked.Rows[2]["tencasi"].ToString();
                    label_like_11.Text = Liked.Rows[2]["tenbaihat"].ToString();
                    label_like_12.Text = Liked.Rows[2]["thoiluong"].ToString();

                    pictureBox23.BackgroundImage = (Image)Liked.Rows[3]["hinhanh"];
                    label_like_13.Text = Liked.Rows[3]["tenbaihat"].ToString();
                    label_like_14.Text = Liked.Rows[3]["tencasi"].ToString();
                    label_like_15.Text = Liked.Rows[3]["tenbaihat"].ToString();
                    label_like_16.Text = Liked.Rows[3]["thoiluong"].ToString();

                    pictureBox22.BackgroundImage = (Image)Liked.Rows[4]["hinhanh"];
                    label_like_17.Text = Liked.Rows[4]["tenbaihat"].ToString();
                    label_like_18.Text = Liked.Rows[4]["tencasi"].ToString();
                    label_like_19.Text = Liked.Rows[4]["tenbaihat"].ToString();
                    label_like_20.Text = Liked.Rows[4]["thoiluong"].ToString();

                    pictureBox21.BackgroundImage = (Image)Liked.Rows[5]["hinhanh"];
                    label_like_21.Text = Liked.Rows[5]["tenbaihat"].ToString();
                    label_like_22.Text = Liked.Rows[5]["tencasi"].ToString();
                    label_like_23.Text = Liked.Rows[5]["tenbaihat"].ToString();
                    label_like_24.Text = Liked.Rows[5]["thoiluong"].ToString();

                    pictureBox20.BackgroundImage = (Image)Liked.Rows[6]["hinhanh"];
                    label_like_25.Text = Liked.Rows[6]["tenbaihat"].ToString();
                    label_like_26.Text = Liked.Rows[6]["tencasi"].ToString();
                    label_like_27.Text = Liked.Rows[6]["tenbaihat"].ToString();
                    label_like_28.Text = Liked.Rows[6]["thoiluong"].ToString();

                    pictureBox19.BackgroundImage = (Image)Liked.Rows[7]["hinhanh"];
                    label_like_29.Text = Liked.Rows[7]["tenbaihat"].ToString();
                    label_like_30.Text = Liked.Rows[7]["tencasi"].ToString();
                    label_like_31.Text = Liked.Rows[7]["tenbaihat"].ToString();
                    label_like_32.Text = Liked.Rows[7]["thoiluong"].ToString();

                    pictureBox18.BackgroundImage = (Image)Liked.Rows[8]["hinhanh"];
                    label_like_33.Text = Liked.Rows[8]["tenbaihat"].ToString();
                    label_like_34.Text = Liked.Rows[8]["tencasi"].ToString();
                    label_like_35.Text = Liked.Rows[8]["tenbaihat"].ToString();
                    label_like_36.Text = Liked.Rows[8]["thoiluong"].ToString();

                    pictureBox17.BackgroundImage = (Image)Liked.Rows[9]["hinhanh"];
                    label_like_37.Text = Liked.Rows[9]["tenbaihat"].ToString();
                    label_like_38.Text = Liked.Rows[9]["tencasi"].ToString();
                    label_like_39.Text = Liked.Rows[9]["tenbaihat"].ToString();
                    label_like_40.Text = Liked.Rows[9]["thoiluong"].ToString();
                    break;
                default:
                    panel_like_1.Visible = true;
                    panel_like_2.Visible = true;
                    panel_like_3.Visible = true;
                    panel_like_4.Visible = true;
                    panel_like_5.Visible = true;
                    panel_like_6.Visible = true;
                    panel_like_7.Visible = true;
                    panel_like_8.Visible = true;
                    panel_like_9.Visible = true;
                    panel_like_10.Visible = true;

                    pictureBox26.BackgroundImage = (Image)Liked.Rows[0]["hinhanh"];
                    label_like_1.Text = Liked.Rows[0]["tenbaihat"].ToString();
                    label_like_2.Text = Liked.Rows[0]["tencasi"].ToString();
                    label_like_3.Text = Liked.Rows[0]["tenbaihat"].ToString();
                    label_like_4.Text = Liked.Rows[0]["thoiluong"].ToString();

                    pictureBox25.BackgroundImage = (Image)Liked.Rows[1]["hinhanh"];
                    label_like_5.Text = Liked.Rows[1]["tenbaihat"].ToString();
                    label_like_6.Text = Liked.Rows[1]["tencasi"].ToString();
                    label_like_7.Text = Liked.Rows[1]["tenbaihat"].ToString();
                    label_like_8.Text = Liked.Rows[1]["thoiluong"].ToString();

                    pictureBox24.BackgroundImage = (Image)Liked.Rows[2]["hinhanh"];
                    label_like_9.Text = Liked.Rows[2]["tenbaihat"].ToString();
                    label_like_10.Text = Liked.Rows[2]["tencasi"].ToString();
                    label_like_11.Text = Liked.Rows[2]["tenbaihat"].ToString();
                    label_like_12.Text = Liked.Rows[2]["thoiluong"].ToString();

                    pictureBox23.BackgroundImage = (Image)Liked.Rows[3]["hinhanh"];
                    label_like_13.Text = Liked.Rows[3]["tenbaihat"].ToString();
                    label_like_14.Text = Liked.Rows[3]["tencasi"].ToString();
                    label_like_15.Text = Liked.Rows[3]["tenbaihat"].ToString();
                    label_like_16.Text = Liked.Rows[3]["thoiluong"].ToString();

                    pictureBox22.BackgroundImage = (Image)Liked.Rows[4]["hinhanh"];
                    label_like_17.Text = Liked.Rows[4]["tenbaihat"].ToString();
                    label_like_18.Text = Liked.Rows[4]["tencasi"].ToString();
                    label_like_19.Text = Liked.Rows[4]["tenbaihat"].ToString();
                    label_like_20.Text = Liked.Rows[4]["thoiluong"].ToString();

                    pictureBox21.BackgroundImage = (Image)Liked.Rows[5]["hinhanh"];
                    label_like_21.Text = Liked.Rows[5]["tenbaihat"].ToString();
                    label_like_22.Text = Liked.Rows[5]["tencasi"].ToString();
                    label_like_23.Text = Liked.Rows[5]["tenbaihat"].ToString();
                    label_like_24.Text = Liked.Rows[5]["thoiluong"].ToString();

                    pictureBox20.BackgroundImage = (Image)Liked.Rows[6]["hinhanh"];
                    label_like_25.Text = Liked.Rows[6]["tenbaihat"].ToString();
                    label_like_26.Text = Liked.Rows[6]["tencasi"].ToString();
                    label_like_27.Text = Liked.Rows[6]["tenbaihat"].ToString();
                    label_like_28.Text = Liked.Rows[6]["thoiluong"].ToString();

                    pictureBox19.BackgroundImage = (Image)Liked.Rows[7]["hinhanh"];
                    label_like_29.Text = Liked.Rows[7]["tenbaihat"].ToString();
                    label_like_30.Text = Liked.Rows[7]["tencasi"].ToString();
                    label_like_31.Text = Liked.Rows[7]["tenbaihat"].ToString();
                    label_like_32.Text = Liked.Rows[7]["thoiluong"].ToString();

                    pictureBox18.BackgroundImage = (Image)Liked.Rows[8]["hinhanh"];
                    label_like_33.Text = Liked.Rows[8]["tenbaihat"].ToString();
                    label_like_34.Text = Liked.Rows[8]["tencasi"].ToString();
                    label_like_35.Text = Liked.Rows[8]["tenbaihat"].ToString();
                    label_like_36.Text = Liked.Rows[8]["thoiluong"].ToString();

                    pictureBox17.BackgroundImage = (Image)Liked.Rows[9]["hinhanh"];
                    label_like_37.Text = Liked.Rows[9]["tenbaihat"].ToString();
                    label_like_38.Text = Liked.Rows[9]["tencasi"].ToString();
                    label_like_39.Text = Liked.Rows[9]["tenbaihat"].ToString();
                    label_like_40.Text = Liked.Rows[9]["thoiluong"].ToString();
                    break;
            }   
        }
    }
}