

using Omega.DLX;
using static Omega.BoardValidator.dlxBoardValidator;
using static Omega.Exceptions.Exceptions;

namespace SudokuTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {


        }
        // all the easy boards are 9x9 boards
        // meduim are 16x16
        // hard are 25x25
        // insane and hell are above
        [Test]
        public void easy1()
        {
            string easy1 = "003000002080050000700800049000000100006003000900500078009060014000400200100000500";
            IsValid(easy1);
            int lng = (int)Math.Sqrt(easy1.Length);
            DLXSudokuBoard dlx = new DLXSudokuBoard(easy1, lng);
            dlx.FinalSolve();
            string solved = "693741852482659731715832649257984163846173925931526478579268314368415297124397586";
            Assert.Pass(dlx.SolvedBoard ,Is.EqualTo(solved));

        }
        [Test]
        public void easy2()
        {
            string easy1 = "200050106030000080010902000004001500080009000950000060049037000703010005001000600";
            IsValid(easy1);
            int lng = (int)Math.Sqrt(easy1.Length);
            DLXSudokuBoard dlx = new DLXSudokuBoard(easy1, lng);
            dlx.FinalSolve();
            string solved = "298354176435176982617982354374861529186529743952743861549637218763218495821495637";
            Assert.Pass(dlx.SolvedBoard, Is.EqualTo(solved));

        }
        [Test]
        public void easy3()
        {
            string easy1 = "000050200070094038000070000005600410900080020600409003000000000530000001190500060";
            IsValid(easy1);
            int lng = (int)Math.Sqrt(easy1.Length);
            DLXSudokuBoard dlx = new DLXSudokuBoard(easy1, lng);
            dlx.FinalSolve();
            string solved = "419853276276194538853276194385627419941385627627419853762941385538762941194538762";
            Assert.Pass(dlx.SolvedBoard, Is.EqualTo(solved));

        }
        [Test]
        public void easy4()
        {
            string easy1 = "030097068068300970901000000500000000820000097100200054300901600000543000000006400";
            IsValid(easy1);
            int lng = (int)Math.Sqrt(easy1.Length);
            DLXSudokuBoard dlx = new DLXSudokuBoard(easy1, lng);
            dlx.FinalSolve();
            string solved = "419853276276194538853276194385627419941385627627419853762941385538762941194538762";
            Assert.Pass(dlx.SolvedBoard, Is.EqualTo(solved));

        }
        [Test]
        public void easy5()
        {
            string easy1 = "050060000190400670700098500000730901800000007000000002004000008000020700060001000";
            IsValid(easy1);
            int lng = (int)Math.Sqrt(easy1.Length);
            DLXSudokuBoard dlx = new DLXSudokuBoard(easy1, lng);
            dlx.FinalSolve();
            string solved = "452367819198452673736198524245736981819245367673819452524673198981524736367981245";
            Assert.Pass(dlx.SolvedBoard, Is.EqualTo(solved));

        }
        [Test]
        public void meduim1()
        {
            string s = "0804095020:<06;06000000@9570:00?:000100;000000000000000<00600004?002;1>0@008907=907=0200;100430@008@0=0502000>60060000080907000204305000:020;000000;8040000000000?0000008@40=0070957:0200;00@008;1>030@45000<200000:000130007=957=00?0<000000@000000900=?0000000";
            IsValid(s);
            int lng = (int)Math.Sqrt(s.Length);
            DLXSudokuBoard dlx = new DLXSudokuBoard(s, lng);
            dlx.FinalSolve();
            string solved = "38@4=9572?:<>6;16;1>438@957=:<2?:<2?1>6;438@57=957=92?:<1>6;38@4?:<2;1>6@438957=957=<2?:;1>6438@438@7=95<2?:1>6;>6;1@438=957?:<2@43857=9:<2?;1>61>6;8@437=952?:<2?:<6;1>8@43=957=957:<2?6;1>@438;1>638@457=9<2?:<2?:>6;138@47=957=95?:<2>6;18@438@43957=?:<26;1>";
            Assert.Pass(dlx.SolvedBoard, Is.EqualTo(solved));
        }
        [Test]
        public void meduim2()
        {
            string s = "0000@300010>05003000000=0600400270=00000:0009?@00050<04000090=079:0200?@008=06000?0300=0004000000000;000<00:000>0560200<00>00178=@0080000400000001780:000000@30=00;40?003>001700?<09>0007851004000000009>=100050@20?=10>0567040010000670000;00?@0000:00090003000";
            IsValid(s);
            int lng = (int)Math.Sqrt(s.Length);
            DLXSudokuBoard dlx = new DLXSudokuBoard(s, lng);
            dlx.FinalSolve();
            string solved = "24:<@39?=17>856;39?@17>=56;84:<27>=16;85:<249?@3;856<24:?@39>=179:<23>?@178=56;4>?@378=16;45:<298=17;456<29:?@3>456;29:<@3>?=178=@3>8517;4:6<29?51784:6;29?<@3>=:6;49?<23>=@1785?<29>=@378516;4:<;4:?@29>=137856@29?=13>8567;4:<13>=56784:<;29?@6785:<;49?@23>=1";
            Assert.Pass(dlx.SolvedBoard, Is.EqualTo(solved));
        }
        [Test]
        public void meduim3()
        {
            string s = "0:<09?00208=00074000;:0>00@9680008=0300000<>?00000@0260030000:<>0?0@00680340000<000<@001=20003403057>;:090002080200070050;:0001000000704000:@9?0090000000704<0000>0000900=0050040300<0;009?00000:000010900000000000400000@0080268=06400300000@0010000800057300>0";
            IsValid(s);
            int lng = (int)Math.Sqrt(s.Length);
            DLXSudokuBoard dlx = new DLXSudokuBoard(s, lng);
            dlx.FinalSolve();
            string solved = ";:<>9?1@268=34574573;:<>?1@968=268=23457;:<>?1@9?1@9268=3457;:<>9?1@=2687345>;:<>;:<@9?1=26873453457>;:<9?1@268=268=7345>;:<9?1@=2685734<>;:@9?1@9?18=265734<>;:<>;:1@9?8=2657347345<>;:@9?1=268:<>;?1@968=245735734:<>;1@9?8=268=264573:<>;1@9?1@9?68=24573:<>;";
            Assert.Pass(dlx.SolvedBoard, Is.EqualTo(solved));
        }
        [Test]
        public void meduim4()
        {
            string s = "0:09;00050600000?000000@;008010<000004?0390000008;>05100=4003000007=0000000205100<007000009@;020080000060=0?009000008;>200000=400000600000=00:3900@:000>0001?7=0=4009003000000501005?70000008;00:30@>00006<04?0000403900>2801000506<4?009@0308;0;0081600007=00:3";
            IsValid(s);
            int lng = (int)Math.Sqrt(s.Length);
            DLXSudokuBoard dlx = new DLXSudokuBoard(s, lng);
            dlx.FinalSolve();
            string solved = "@:39;>28516<=4?7?7=4:39@;>28516<<516=4?739@:>28;8;>2516<=4?739@:4?7=@:398;>2<5166<517=4?:39@;>2828;><5167=4?:39@9@:38;>2<5167=4?>28;6<51?7=4@:3939@:28;>6<51?7=4=4?79@:328;>6<5116<5?7=4@:398;>2:39@>28;16<54?7=7=4?39@:>28;16<5516<4?7=9@:328;>;>2816<54?7=9@:3";
            Assert.Pass(dlx.SolvedBoard, Is.EqualTo(solved));
        }
        [Test]
        public void meduim5()
        {
            string s = "00;00=407050000@000000000200009:0053?@00:8090><0021?0080=00005000000:2000090><7000?000004>075006800=0000050@00000><0@6030000;000;9=400<003000:810<00200@00:00=00500200000000006010000;00>0763@0590000070000008;0<00500@0000;04090@210?:00=400000000;090007600210";
            IsValid(s);
            int lng = (int)Math.Sqrt(s.Length);
            DLXSudokuBoard dlx = new DLXSudokuBoard(s, lng);
            dlx.FinalSolve();
            string solved = ":8;9<=4>765321?@=4><3765@21?8;9:7653?@21:8;94><=@21?9:8;=4><6537653@:21?8;9=><7421?:=8;94><753@68;9=74><653@1?:24><7@65321?:;9=8;9=46><753@2?:81><76253@1?:89=4;53@281?:;9=4<76>1?:84;9=><763@259=4>5<763@21:8;?<76513@2?:8;=4>93@21;?:89=4>765<?:8;>9=4<765@213";
            Assert.Pass(dlx.SolvedBoard, Is.EqualTo(solved));
        }
        [Test]

        public void hard1()
        {
            string s = "I0@1E670=F0>;H0C000A0:00007D0F0G0;0<00C82504:01EI0BG00H8<9A0?4020EI001D=0678<0005?4:03@1E0007D00;HBG00002I301000=F00BG>090C00?4:2I0@0E6D=F078G00H0C5<9000E070=F000080509AC02I04000F0000H09A05<I?0:21060@0000809A054020?00@100007D<00C00002I0006300000008G0D00B0>0H000C5093400IE00@00;00<0A000:0I0400106000D=90C5?0:0030067000=00H80004:0I3@1E60=FB0D<>;08C0?90010600=F0G;08<>?9005000400F0G>;H8000504A0000307000008<0AC0?00I00000E6000>0FAC00002I3@E0000>0FBG0<0;002I3@1067D0B0>=9;H005?00000670=FBG>0009;4A050030022I001060000G0;F0H8<9?4000067D=FBG0;009A00C50400120F0G>008<90000001000@700E0H000A00?0:I0@020E600G>0F0000002030100D=000000<9AH8";
            IsValid(s);
            int lng = (int)Math.Sqrt(s.Length);
            DLXSudokuBoard dlx = new DLXSudokuBoard(s, lng);
            dlx.FinalSolve();
            string solved = "I3@1E67D=FG>;HBC8<9A4:25?67D=FBG>;H<9AC825?4:@1EI3BG>;H8<9AC?4:25EI3@1D=F678<9AC5?4:23@1EIF67D=>;HBG5?4:2I3@1E7D=F6HBG>;9AC8<?4:2I3@1E6D=FB78G>;HAC5<93@1E67D=FB>;H8G5<9AC:2I?47D=FBG>;H89AC5<I?4:21E63@G>;H8<9AC54:2I?63@1E=FB7D<9AC5?4:2I@1E63B7D=F;H8G>D=FBG>;H8<AC5?934:2IE67@1>;H8<9AC5?:2I347@1E6FBGD=9AC5?4:2I31E67@GD=FBH8<>;4:2I3@1E67=FBGD<>;H8C5?9A@1E67D=FBG;H8<>?9AC52I34:=FBG>;H8<9C5?4A@:2I367D1E;H8<9AC5?42I3@:D1E67BG>=FAC5?4:2I3@E67D1>=FBG8<9;H:2I3@1E67DFBG>=9;H8<5?4AC1E67D=FBG>H8<9;4AC5?I3@:22I3@1E67D=BG>;FAH8<9?4:C5E67D=FBG>;8<9AH:C5?43@12IFBG>;H8<9A5?4:C12I3@7D=E6H8<9AC5?4:I3@12=E67DG>;FBC5?4:2I3@167D=E;FBG><9AH8";
            Assert.Pass(dlx.SolvedBoard, Is.EqualTo(solved));
        }
        [Test]
        public void hard2()
        {
            string s = "724B0E0000D390;10000=0<?000=000@704F0H0000960C0001000I5:<000000B@0GH0>390;0;03960580C0A0:<700B@G00>F000E06;D090C0080=:004B002@00400E>FG0D30080CI500:00000=:40002>00HE0D3961C050580CI=0<0A000000F00E0096060039CI501000000720BFG000>F0HE0600001C00000:<20B@7:<000200000>0GH0;039000I000810A00<?0@024000GH;D096060D300I5000?A=0@00400GHEE0FG03960D000CI0?A0000000B07040HE>060D00080CI?00:<000?A0040000>00060D00800I000000A=0<00@700E0FG60030000;081CI00:<?A4B072E>FGH0E>0GD390000810:<0A=@720B000720GH0>060D0I001C00A=:1005800A0004B@70H00F960D300060081CI0=00004B000E00GGH0>00D30600581=:<0A0@00404B07>0GH0396;000081:00A000:<0@720BG00>F09000I080C";
            IsValid(s);
            int lng = (int)Math.Sqrt(s.Length);
            DLXSudokuBoard dlx = new DLXSudokuBoard(s, lng);
            dlx.FinalSolve();
            string solved = "724B@E>FGHD396;1CI58=:<?A?A=:<B@724FGHE>D396;CI58181CI5:<?A=724B@FGHE>396;D;D396I581C?A=:<724B@GHE>FFGHE>6;D391CI58A=:<?4B@72@724BHE>FG;D39681CI5A=:<?<?A=:4B@72>FGHE;D3961CI58581CI=:<?A@724B>FGHED396;6;D39CI581<?A=:@724BFGHE>>FGHE96;D381CI5?A=:<24B@7:<?A=24B@7E>FGH6;D3981CI5I581CA=:<?B@724E>FGH;D39696;D31CI58:<?A=B@724>FGHEE>FGH396;D581CI<?A=:724B@B@724GHE>F6;D39581CI?A=:<=:<?A724B@HE>FG96;D3581CICI581?A=:<4B@72HE>FG6;D39396;D81CI5=:<?A4B@72E>FGHHE>FGD396;I581C:<?A=@724B4B@72FGHE>96;D3I581C<?A=:1CI58<?A=:24B@7GHE>F96;D3D396;581CIA=:<?24B@7HE>FGGHE>F;D396CI581=:<?AB@72424B@7>FGHE396;DCI581:<?A=A=:<?@724BGHE>F396;DI581C";
            Assert.Pass(dlx.SolvedBoard, Is.EqualTo(solved));
        }
        [Test]
        public void hard3()
        {
            string s = "<F0HB0G0;7C01:0I>0D?9A0@4307002100C>000I049A0HB<0600C00=D?0>40A0@F000080300?I0=D0A0@0600<F;78G32005CE@00AH00F07000;0C2000D00>0>=D0A0@490B3F6080:01?5C0@4900B0F0080:00021?50EI00F0H00G:0780005C0=0EI00049070000?002=D00>4000@0300000010DEI>00A<@00H0300:;004900F3060BG000821?00E@0=00H03;0070000I00=DE00<04007000500001DE00090<003;0HB0010I0@0=D0<F49000;6:508G>00000F0900300H0G:07?0C012100>@00DE0F09000;0H5080000E@4009A<3070BG05C8000009A006;70B3:0C0G0?I0000=DE003;75C80000>210E040F600<0000CI02000@4=DA0F00;70B3A006070B3;002G00I000000E0B0;08C0G:50>=00E040D0H00F00500>01?0009D0<0000080000?I>=090E00600<3;700C0G0000040000<F;780005C000=100";
            IsValid(s);
            int lng = (int)Math.Sqrt(s.Length);
            DLXSudokuBoard dlx = new DLXSudokuBoard(s, lng);
            dlx.FinalSolve();
            string solved = "<F6HB8G3;7C21:5I>=D?9AE@43;78G21:5C>=D?I@49AEHB<F6:5C21=D?I>49AE@F6HB<8G3;7?I>=D9AE@46HB<F;78G321:5CE@49AHB<F678G3;5C21:=D?I>I>=DEA<@49HB3F678G:;1?5C2@49A<B3F6H8G:;7C21?5DEI>=F6HB3G:;7821?5C>=DEIA<@49;78G:1?5C2=DEI>49A<@B3F6H5C21?DEI>=9A<@46HB3FG:;7849A<F3;6HBG:57821?ICE@>=D6HB3;:578G1?IC2=DE@><F49A78G:5?IC21DE@>=9A<F43;6HBC21?IE@>=DA<F49HB3;6:578G>=DE@<F49AB3;6H8G:57?IC2121?I>@4=DE<F69AB3;7H5C8G:=DE@4F69A<3;7HBG:5C8I>21?9A<F6;7HB3:5C8G1?I>2@4=DEHB3;75C8G:?I>21DE@4=F69A<8G:5CI>21?E@4=DA<F69;7HB3A<F6H78B3;5C2G:?I>=149DE@B3;78C2G:5I>=1?E@49D6HA<FG:5C2>=1?I@49DE<F6HA78B3;1?I>=49DE@F6HA<3;78BC2G:5DE@496HA<F;78B3:5C2G>=1?I";
            Assert.Pass(dlx.SolvedBoard, Is.EqualTo(solved));
        }
        [Test]
        public void hard4()
        {
            string s = "3:0A00800C5090076@?004E0B0000B<0:2A000C000000?00000?0761BH00<3:2A0I000D05F90D00070@?G1000E<0000;C08000C000F9D=06@?G1B04002000F0005G70@?01B00A<0:0I0C>80000>=500DG7000E1B043:00<<300A0>000=000D0000?B00E10H401A<302>000C5F00000G766@0G701004A<300>0I;C9005F5F0D=?006@4E00H2000:8I000>00;C0=009?0760400BH<000A00300;C>0I0=0F00G70010H4E1004E00030C>8I;=500D6@0G076000000002A<300>0I;09D=52003:0;0>09005F00G00E1B04E1B04020<0;000I0=0F900@00070@0H0E1B:0A<00C>000F9D000000000060400B02003>00;C008I090=50@00060001BA03:2;C>8I00D000@?G7BH4012000::0A<08I0C009D006@0G74E10H4E0BH002A<0;C>80D=500000??000@0000100200I;C08=50900=0F90@0G0000E0302A000800";
            IsValid(s);
            int lng = (int)Math.Sqrt(s.Length);
            DLXSudokuBoard dlx = new DLXSudokuBoard(s, lng);
            dlx.FinalSolve();
            string solved = "3:2A<>8I;C5F9D=76@?GH4E1BH4E1B<3:2A8I;C>F9D=5?G76@@?G761BH4E<3:2A8I;C>D=5F99D=5F76@?G1BH4E<3:2A;C>8II;C>85F9D=76@?G1BH4E:2A<3F9D=5G76@?E1BH4A<3:2I;C>88I;C>=5F9DG76@?E1BH43:2A<<3:2AC>8I;=5F9DG76@?BH4E1BH4E1A<3:2>8I;C5F9D=@?G766@?G7E1BH4A<3:2>8I;C9D=5F5F9D=?G76@4E1BH2A<3:8I;C>>8I;CD=5F9?G76@4E1BH<3:2AA<3:2;C>8ID=5F9?G76@1BH4E1BH4E2A<3:C>8I;=5F9D6@?G776@?G4E1BH2A<3:C>8I;F9D=52A<3:I;C>89D=5F@?G76E1BH4E1BH4:2A<3;C>8ID=5F976@?GG76@?H4E1B:2A<3;C>8I5F9D==5F9D@?G76H4E1B:2A<3>8I;CC>8I;9D=5F@?G76H4E1BA<3:2;C>8IF9D=56@?G7BH4E12A<3::2A<38I;C>F9D=56@?G74E1BH4E1BH3:2A<I;C>89D=5FG76@??G76@BH4E13:2A<I;C>8=5F9DD=5F96@?G7BH4E13:2A<C>8I;";
            Assert.Pass(dlx.SolvedBoard, Is.EqualTo(solved));
        }
        [Test]
        public void hard5()
        {
            string s = "0E487:009200I300000=<;0?0090:50>00G=1B00;60A<87FE003000=1BC00;0?070008:5@9200D=1<00?080FE450920000006?A0;80FE400092>I0G0010C0E48705I000003G00000100?0<90:0I>B30H10C00F00<;00E4000H>B1000=0000<@E4075I92:CD=060F?A07@E40I00:50B30H00000000000I02:B0GH>10000D=00000A00@94070000I00GH>A00FE00487030:5C0H00600=000009030:00C000?0006000<;2:5I0B000>6?0=1EA<;0@9000G0>B060D01FEA<;94870002:0:5000CD00B?A=004<0F092870H0BC00A010040;02800930:50=1000000000200@0:0I3CDH>000FE40087030:000000C0A=108709230:0IC00>BA=06000<007090:GH5I0D0>B00160A08;F05I00H00>00A006080FE00:000>000=A000048;0E00002G000006?A000;FE2:7@905I3G000000FE402:0@90H003000CDA<100";
            IsValid(s);
            int lng = (int)Math.Sqrt(s.Length);
            DLXSudokuBoard dlx = new DLXSudokuBoard(s, lng);
            dlx.FinalSolve();
            string solved = "FE487:5@92H>I3G1BCD=<;6?A@92:5H>I3G=1BCD;6?A<87FE4I3GH>=1BCD<;6?A7FE48:5@92BCD=1<;6?A87FE45@92:H>I3G6?A<;87FE4:5@92>I3GH=1BCDE487@5I92:>B3GH6CD=1;F?A<92:5I>B3GH16CD=F?A<;7@E483GH>B16CD=;F?A<@E4875I92:CD=16;F?A<7@E48I92:5>B3GH?A<;F7@E485I92:B3GH>16CD=D=16?FEA<;@948732:5IBCGH>A<;FE@9487I32:5CGH>B6?D=1487@9I32:5BCGH>?D=16FEA<;2:5I3BCGH>6?D=1EA<;F@9487GH>BC6?D=1FEA<;9487@I32:5:5I3GCDH>B?A=164<;FE9287@H>BCD?A=16E4<;F287@93G:5I=16?AE4<;F9287@G:5I3CDH>B<;FE49287@3G:5IDH>BC?A=1687@923G:5ICDH>BA=16?E4<;F7@92:GH5I3D=>BC<16?A48;FE5I3GHD=>BCA<16?8;FE42:7@9>BCD=A<16?48;FE:7@92GH5I316?A<48;FE2:7@9H5I3GD=>BC;FE482:7@9GH5I3=>BCDA<16?";
            Assert.Pass(dlx.SolvedBoard, Is.EqualTo(solved));
        }
        [Test]
        public void Insane1()
        {
            string s = "45D3=0M@000?;QN060E00G8100<>P00000C00BK0T0A45030@0I9?0060;0NR2001E<0PH0070>P0LC0000045D30A00M@SI0000N00010R02G800RL7<00H00KOT030A00D?00S09000F0J0Q006J2G80ER<0P0L70C0B00A0000=S090M@0SI000J0QN06081E00H07<>P00B0OT5D0=A0R2G000H07<>00:000TD3=0409?M00000QN000;QNF0R2G81E0<>P00OT0:BK0A40000000?MM0SI0?0J000020800RP000<00C0BKO40D0=004000=?M0009J;00000ER0G80L7<>000KO00C:B0OT0A4000M0SI000F600Q002G80000PHLL700P0T000K0A0503=I9000006J;QN0000000R20800H0700000B000000A0000M@0600QNF60;Q00E02001L7<00HK000:B00A000M0S090?M0SI0060;Q00008100P007<OT000K000D000045D00?M@SI6J0Q00800R200007<00:0KOTTC00KO0=A40D?M0S000006J;1E000000<>P0H000>0000:BK000003S000000F600002G80E3=045DI00M@0F600Q0001E00000070TC000OOT0:000000000?0@0I0Q0F6000ER000L70>00H07<>0000:B3=A0500000?000F6J0ER208010R208000L0<O0C0B005030A0I0?0@F60000F00;0N00R0G00L0<00000TC:030A40?0@S00000@S00060;0E000010>00L700TC0000000300T0:B000=00I90M00J00NF6000ER00HL70>0PHL700KO00:D3=A00M@S090;0000J0002G80100000000L0K0T0:BA4500=00I000N00J;Q0F600Q010R0GP007<>:B0OTC0D3=A49?00S009?M@SQ0F6000E02G800>00LB000C03=040DD00A05S0000@0F600Q20010R<>0000O0C0BK500000@0I0?00N06J;02081E0<>00L0O00:BB0000005D3=0S000M@00;00F20000R>PH0000>P0000BKO0C0D0=040M@SI0J;Q0F081ER0G000E007<>PH0BKOTC:=04003M@0I0?00F0J000F0J;0000R200HL700:0KOT40D3=AI00M00009?M0;0NF6J01E00G00<>P000K0TC030A45";
            IsValid(s);
            int lng = (int)Math.Sqrt(s.Length);
            DLXSudokuBoard dlx = new DLXSudokuBoard(s, lng);
            dlx.FinalSolve();
            string solved = "45D3=AM@SI9?;QNF6JER2G81L7<>PHBKOTC::BKOTCA45D3=@SI9?MF6J;QNR2G81E<>PHL77<>PHLC:BKOT45D3=A9?M@SI6J;QNFG81ER22G81ERL7<>PH:BKOTC3=A45D?M@SI9;QNF6J;QNF6J2G81ER<>PHL7TC:BKOA45D3=SI9?M@@SI9?MJ;QNF6G81ER2HL7<>PC:BKOT5D3=A4R2G81EHL7<>PC:BKOTD3=A459?M@SIJ;QNF6J;QNF6R2G81E7<>PHLOTC:BK=A45D3@SI9?MM@SI9?6J;QNF2G81ERPHL7<>TC:BKO45D3=AA45D3=?M@SI9J;QNF61ER2G8HL7<>P:BKOTCC:BKOT=A45D3M@SI9?NF6J;QER2G817<>PHLL7<>PHTC:BKOA45D3=I9?M@SF6J;QN2G81ERER2G81PHL7<>TC:BKO5D3=A4I9?M@S6J;QNF6J;QNFER2G81L7<>PHKOTC:B3=A45DM@SI9??M@SI9F6J;QNR2G81E>PHL7<OTC:BKA45D3==A45D39?M@SI6J;QNF81ER2GPHL7<>C:BKOTTC:BKO3=A45D?M@SI9QNF6J;1ER2G8L7<>PHHL7<>POTC:BK=A45D3SI9?M@NF6J;QR2G81E3=A45DI9?M@SF6J;QNG81ER2>PHL7<TC:BKOOTC:BKD3=A459?M@SI;QNF6J81ER2GHL7<>PPHL7<>KOTC:B3=A45D@SI9?MQNF6J;ER2G811ER2G8>PHL7<OTC:BK45D3=ASI9?M@F6J;QNF6J;QN1ER2G8HL7<>PBKOTC:D3=A45?M@SI99?M@SINF6J;QER2G81<>PHL7KOTC:B=A45D3KOTC:B5D3=A4I9?M@SJ;QNF6G81ER2PHL7<>>PHL7<BKOTC:D3=A45M@SI9?;QNF6J1ER2G881ER2G<>PHL7KOTC:BA45D3=@SI9?MNF6J;QNF6J;Q81ER2GPHL7<>:BKOTC5D3=A49?M@SII9?M@SQNF6J;1ER2G87<>PHLBKOTC:3=A45DD3=A45SI9?M@NF6J;Q2G81ER<>PHL7OTC:BK5D3=A4@SI9?MQNF6J;R2G81E7<>PHLKOTC:BBKOTC:45D3=ASI9?M@6J;QNF2G81ER>PHL7<<>PHL7:BKOTC5D3=A4?M@SI9J;QNF681ER2GG81ER27<>PHLBKOTC:=A45D3M@SI9?QNF6J;QNF6J;G81ER2>PHL7<C:BKOT45D3=AI9?M@SSI9?M@;QNF6J81ER2GL7<>PH:BKOTCD3=A45";
            Assert.Pass(dlx.SolvedBoard, Is.EqualTo(solved));
        }
        [Test]
        public void Insane2()
        {
            string easy1 = "Q000K00P0B500E>000OMH080?0120R903NTF0S00G0E000060=8000R0J10700003NA0K@QC0600D008;0MH0020R?0000I30C0400:P0050M0=8;0007R?JF9I3N0@Q000K5S:00B0>0<L00J100R9I300FCA00@0050:PGL0E0D<08;O0HT00I0NA4000CS:0GB0006E>D0H=00O1000?JJ080002700F09I0000QSA000600005>D0LHE01070?000T00A00@Q056:P0000>0<080O00=C0I0NT4K00000PG006LH000<J=8;O000R0F1SA4K@QPGB06:00D<0HMJ000001200?03NT000:PG000D00HE=0;00J00020R0903N04K00SAH00D0000O0000200?00090000000@Q0GB000A000T00000:40G050000>D0L00;OMJ0R00020000QSG056E00D000=000;O092000F3NT00I0PGB00D00H0000OM010900R0AI0NT0000S000>000H0O000020R009C0I0NT0000Q00006EP1800M07R?090000TC0S040@Q0000000<0H0>0200?F300CAI0K0Q0000P0000>D<LH;0MJ082;00J1R?F9I00NTC04:P0@0000B5000LH=0D00R009N00A43K0000P000B5080<L00OM010;43N0CA00000K0B50E>08D<0H0;OMJ0000000P000S000000G00000812;0MJ070?F000C000>GB000<0000D0OMJ009000?F03NTC000S00K000000O0012070?F000400TC0K@QS:00600000TC040S:P0@B5600D00<L000O0002?0003000000P00E>0B00000;00OM00000F9I00A400D050E00H080<O00127I0R?F9KN0004Q0000@0<L000M000000000I34KN0CAG@Q0:050E>DB00MJ12?09I3RNTC000PG00S00B06E0L0=0;00R?0900CA0KN@0S0P0>0056E;0LH080J1070000:0G00>D05L0000O7R0J12N?F0I0CA400T<06E>0H=0;O00J02700N0F0I0TCA40S0P0B0OLH=8;00200M?F9000K0TCA0000:PG0E0D<50MJ000F9I30?0004000BQS000000>D008;00N?0003C000@TQ0:0G0D000E>00H=00002000@0C04KS:PGB000E>0<;0L008RMJ0270903N0";
            IsValid(easy1);
            int lng = (int)Math.Sqrt(easy1.Length);
            DLXSudokuBoard dlx = new DLXSudokuBoard(easy1, lng);
            dlx.FinalSolve();
            string solved = "QCA4K@:PGB5S6E>D<LOMH=8;?J127R9I3NTF5S:PGBE>D<L6H=8;OMR?J127TF9I3NA4K@QCL6E>D<=8;OMHJ127R?NTF9I3QCA4K@:PGB5SMH=8;O127R?JF9I3NT@QCA4K5S:PGBE>D<L6?J127R9I3NTFCA4K@QB5S:PGL6E>D<=8;OMHTF9I3NA4K@QCS:PGB5<L6E>DMH=8;O127R?JJ=8;OM27R?F19I3NTCQSA4K@6:PGB5>D<LHEF127R?I3NTC9A4K@QS56:PGBHE>D<L8;OMJ=C9I3NT4K@QSA:PGB56LHE>D<J=8;OM27R?F1SA4K@QPGB56:E>D<LHMJ=8;OF127R?I3NTC96:PGB5>D<LHE=8;OMJ?F127RC9I3NT4K@QSAHE>D<L8;OMJ=127R?FTC9I3NSA4K@QPGB56:AI3NTCK@QS:4PGB56EH=>D<L18;OMJ7R?F92:4K@QSGB56EP>D<LH=J18;OM927R?F3NTCAIEPGB56D<LH=>8;OMJ1F927R?AI3NTCK@QS:4=>D<LH;OMJ1827R?F9CAI3NT:4K@QSGB56EP18;OMJ7R?F92I3NTCAS:4K@QEPGB56D<LH=>927R?F3NTCAI4K@QS:6EPGB5=>D<LH;OMJ182;OMJ1R?F9I73NTCA4:PK@QS>GB56E<LH=8DI7R?F9NTCA43K@QS:PE>GB568D<LH=OMJ12;43NTCA@QS:PKGB56E>=8D<LH2;OMJ1R?F9I7PK@QS:B56E>GD<LH=812;OMJI7R?F9NTCA43>GB56E<LH=8D;OMJ129I7R?F43NTCA@QS:PK8D<LH=OMJ12;7R?F9IA43NTCPK@QS:B56E>GKNTCA4QS:PG@B56E>D8;<LH=7OMJ12?F9I3RG@QS:P56E>DB<LH=8;27OMJ13R?F9ITCA4KNDB56E>LH=8;<OMJ127I3R?F9KNTCA4QS:PG@;<LH=8MJ127OR?F9I34KNTCAG@QS:P56E>DB7OMJ12?F9I3RNTCA4KPG@QS:DB56E>LH=8;<3R?F9ITCA4KN@QS:PG>DB56E;<LH=8MJ127OBQS:PG6E>D<5LH=8;O7RMJ12N?F9I3CA4K@T<56E>DH=8;OLMJ127R3N?F9I@TCA4KS:PGBQOLH=8;J127RM?F9I3NK@TCA4BQS:PG6E>D<5RMJ127F9I3N?TCA4K@GBQS:P<56E>DH=8;OLN?F9I3CA4K@TQS:PGBD<56E>OLH=8;J127RM@TCA4KS:PGBQ56E>D<;OLH=8RMJ127F9I3N?";
            Assert.Pass(dlx.SolvedBoard, Is.EqualTo(solved));

        }
        [Test]
        public void Insane3()
        {
            string easy1 = "R00KG1F09?L0NM07Q00A00I0;000000S:06@L0000?0=NM47I0005H0B30O>:J60D00EK00R47Q=N00H08000000000D0:J0KG00<0T009?000000800O>CBJ6@000R<EKG1200LT00Q00M4CB3;00S:J00D010<E000000000M40000000P@DS:0600010<00LTF24000N0008PA500;0000020000000A080050I030O>0J00<S:00G000AQ0N00HI80B0>C03;0<0006@01000KF09007050I8P;0>C030@<S00T00G109?L702Q=NM0000;0>C006@0S0R0E0G7000?00040Q05HI00B0S006@K00R0E000020A0=N0400P00000000000KG00200L00M00Q00B0H08000CD000000000:06@<G10T000000005=004A80B3H0;000000K00RT900702005=NM0H0000000S;00060<EQ000L0004A0=PB0HI0S;000D00<E0J0G1R000=N00A08P0000DS;O>E000@010T00G00?L003HI8PBO>C0S000E:00000000?0002900040000O0CDJ6@0E:000001Q00?L70405=00I80B30I00B0>CDS0000006@0G1RT007Q=90N04A5H:0000S0000KJ0F2G1R09?L700A000M000B3;K06@<0100F0G7Q000L0NM000PB3;08O0000:2G0RT0?00Q=000H0040I0PB30DS:0>J60000=9?00QM4000N03;I00:00000@0E0J6G00T000NM4A50PB0;ID0:0>00J00000TF2G00000Q0060<E0R0F00000N000000000000O0000DS:090R0F207Q0N00H0M0008PB3;0000>C60<EKG0?L0000A5H0000O00BJ>CD000EK00@000F29IM4050P0000800J>C0G0@0EKTF291R0L700008P00;0DS:0>E0G60<0100007Q0N?LM4A5HIJ0C00:@0EK060291RTN?07Q=A00I000000;0>0030O0S0J00KG0@000R0000Q=0ML00A0HI800D0:J0EKG0@29?00F0L00=05H004AP0300>1@<E0GT00900=NML708400H03;O>P0000:J0?R0F207Q=00LH080A5>0B000S:000D00EK01M07Q00A50084;0>P006CDS00E001@<0T029?0405H0B30O00:J0C0S1000000090000700NM";
            IsValid(easy1);
            int lng = (int)Math.Sqrt(easy1.Length);
            DLXSudokuBoard dlx = new DLXSudokuBoard(easy1, lng);
            dlx.FinalSolve();
            string solved = "R<EKG1F29?LTNM47Q=PA5HI8;O>CB3DS:J6@LTF29?Q=NM47I8PA5HCB3;O>:J6@DS<EKG1R47Q=NM5HI8PAO>CB3;@DS:J6KG1R<ETF29?LPA5HI83;O>CBJ6@DS:R<EKG129?LTF7Q=NM4CB3;O>S:J6@DG1R<EKLTF29?=NM47QA5HI8P@DS:J6EKG1R<9?LTF247Q=NMHI8PA5B3;O>C7F29?L=NM4AQ8PB5HID3;O>CJ6@<S:EKG1RTAQ=NM4HI8PB5>CD3;O<S:J6@G1RTEKF29?L7B5HI8P;O>CD36@<S:JTEKG1R9?L7F2Q=NM4AD3;O>C:J6@<S1RTEKG7F29?LNM4AQ=5HI8PB<S:J6@KG1RTE?L7F29AQ=NM4I8PB5H3;O>CDTEKG1R29?L7FM4AQ=NB5HI8PO>CD3;S:J6@<E:J6@<G1RTFKL7Q29?5=NM4A8PB3HI;O>CDSFKG1RT9?L7Q24A5=NM3HI8PB>CDS;O:J6@<EQ29?L7NM4A5=PB3HI8S;O>CD6@<E:JKG1RTF5=NM4AI8PB3HCDS;O>E:J6@<1RTFKG29?L7Q3HI8PBO>CDS;@<E:J6FKG1RT?L7Q29=NM4A5S;O>CDJ6@<E:RTFKG1Q29?L7M4A5=NHI8PB3;I8PB3>CDS:O<EKJ6@2G1RTFL7Q=9?NM4A5H:O>CDS6@<EKJTF2G1R=9?L7Q4A5HNMI8PB3;KJ6@<E1RTF2G7Q=9?LHNM4A5PB3;I8O>CDS:2G1RTF?L7Q=9A5HNM4;I8PB3CDS:O>J6@<EK=9?L7QM4A5HNB3;I8P:O>CDS@<EKJ6G1RTF2HNM4A58PB3;IDS:O>CKJ6@<ERTF2G19?L7Q=G6@<EKRTF291Q=N?L7IM4A5HB3;O8P>CDS:J91RTF2L7Q=N?5HIM4AO8PB3;DS:J>C6@<EKGN?L7Q=4A5HIM3;O8PBJ>CDS:<EKG6@1RTF29IM4A5HPB3;O8S:J>CDG6@<EKTF291R?L7Q=NO8PB3;CDS:J>EKG6@<91RTF27Q=N?LM4A5HIJ>CDS:@<EKG6F291RTN?L7Q=A5HIM48PB3;O>PB3;ODS:J6CKG1@<E?RTF29Q=NML74A5HI86CDS:J<EKG1@29?RTFML7Q=N5HI84APB3;O>1@<EKGTF29?R=NML7Q84A5HI3;O>PBCDS:J6?RTF297Q=NMLHI84A5>PB3;OS:J6CD@<EKG1ML7Q=NA5HI84;O>PB36CDS:JEKG1@<RTF29?84A5HIB3;O>P:J6CDS1@<EKGF29?RTL7Q=NM";
            Assert.Pass(dlx.SolvedBoard, Is.EqualTo(solved));

        }
        [Test]
        public void HELL()
        {
            //49x49 hellish board :)
            string s = "00Y0030_0?V0409U0X000R00A\\0000]F00056H00NJO0W8>Q004200?V`@T90P0\\00RB:A0=0K0^]J50010N00W8>QD00Y<;00UP000T0000\\I0RE^00=a0H1S0J060OC080Q0[0<00ZL00_G00I0R0:00000E0]F000H1SNW80QDO0Z7[0<;0L42_0?VUPX`@09^00=0KE1SN0560DO0W00000;3Z7[VL420G?0PX`@00IM0B00\\5600S0J8>Q0OCWZ00Y<;320G00009UPX0@T00RB:A00]F0a0EO0W000D0;3Z0000L420G?X`0T0U000M0B:A^]F=aK000010N00W0S0J0>Q0OC080[00000_G?V04000R00T9M0B0A\\0]H000E^0080Q0O03Z7[2004X_00V`0T9UP00M00:A\\]H=a000001SN05020;3Z000VL400U0R0@T00:00IMF^0H0aKE0W0S0050000QD040_000L0T9U00`IMFB:A\\=aKE0]00000000C08000O[2<0000P0`000U:A0I0FB0]0=aKE000J56W0C00>QD02<03Z740_G0VLMFB0A\\0aKE00H=06W1SN00>Q00C0702<;000X000000R00T90]H0aK0^0NJ5001OC080Q0<;0Z000L0X_G0VP0`@00UM0B0A000000\\0MK000010608S0J0000OCY<02_00Z7X0G0V040B0T90P00aKE0]NJ06W00CY0>QD0000702_0X0G0V0RB0T9UPF000\\0MW80N05600000<>02003Z0G?V040`000@09UF000\\00H1a00^0Y<00D0C3Z002_;40`0?0L@000P0BM0=0A0I01aKE000800J5020030000000000P00@00U:A0I0F=001aKE^W0SN006Y<>Q0OC00G?VL0T0U0R00M0000\\Ia00^]H1008S0J500>QD0C2_00000RB@00U00000F0:0010000SN0560800<0QD0200007[000?VL4`00VL0X9UP00:TF=aA\\0MKE^0010W0>0J56<00D00Y0G300000:T00P00IMF0a0H0SKE^]0J06W8000;QDOC_03Z70000?V000=00\\I0F0^]H000W8>0056QDO00<;2_G3Z0[0@0VL400:09U0R1SK0^]HJ0000>N000QD0C0Z00000X`0?004B:09U0R=a000M000N056W0000<;020G0000?V0400@RB:T9UP=aA0IM01S0000H<;QD0C0Z702_G0X`@00L400000000000\\IM1S00000000056W_000700V00X`@?RB0T9UP0\\0MF00H000E^]0>NJ560<00DO000K0IMF0^]00S008>QJ00WDOCY<030G?00[2@0VL0X`:09U0R00000]H15000>QJ<;30O0YZ002_000@00L4X:0900000K\\I0F0>Q056W00CY<;30_0?Z7020L4X`0TB0A00P000\\000=SN00]H00300CY<0[20G0Z0@0VL0X9U0RB:A=aK\\IM00N00]01>QJ0600G?Z000_04X0@000:A0000\\0MF=0K0S0E^0H00J56W8;3DO00<@T0L4X`0PR00A9000\\0MFE^0H00080QJ000000O0Y<G?Z700_009UP0BIM00aK000N0000006000Q<;30O00G?00[00@TV040`A0U0RB0M0000EISNJ0]0100W80QD03000Y0?07[2_G00L4X000EI0F00]000NJ0>QD0000O000;30G007000T900X0@00U0R0:NJ0]00S0000Q05;00OCY<7[000?000904000\\00R0:00IM0000D000800Y<;00OG0V702_L4X`@000A\\0PR0K00M0=0NJ^]H1030000<;[0_0?070T9L0X`UP0B:00a00IM00000000S005008>?00[00G0000T9L000UPR0I00=aK00N0^0H1Q05008>0ZO0Y00T90400@P0B000U0KE0M0=^]H1SN000D00W03ZO0Y00000[200D0008>Q00;007C0V0[0_G0X00T9U000000:E0MF00KJ5]H0SN07CY<;0200?V0[09000`@P0000\\00E^000005]H0S00O608000L02_G?0`0000400I0R0:M00aK0^N05]H00DO6W0>0Z7000;3900X`@0RB:A\\IPKE0MF0a0H100J5QDO6W0007CY003V0020G0\\IP00:AF=000000J0]H006W80QDO0Z0CY<0V00000?0040`0TE^MF0aK01SNJ0]QDO0W00C0<0007?00[0_09U000@T\\IP0000J0]H1SN0800D003Z7CY<;000G0VL00U0X`0\\I0R0:A0^M0=00";
            IsValid(s);
            int lng = (int)Math.Sqrt(s.Length);
            DLXSudokuBoard dlx = new DLXSudokuBoard(s, lng);
            dlx.FinalSolve();
            string solved = "7[Y<;3Z_G?VL429UPX`@TRB:A\\IME^]F=aK56H1SNJOCW8>QDL42_G?V`@T9UPX\\IMRB:AF=aKE^]J56H1SNOCW8>QD7[Y<;3ZUPX`@T9B:A\\IMRE^]F=aKH1SNJ56DOCW8>Q7[Y<;3ZL42_G?VIMRB:A\\=aKE^]FJ56H1SNW8>QDOCZ7[Y<;3L42_G?VUPX`@T9^]F=aKE1SNJ56HDOCW8>QY<;3Z7[VL42_G?UPX`@T9IMRB:A\\56H1SNJ8>QDOCWZ7[Y<;32_G?VL49UPX`@TIMRB:A\\^]F=aKEOCW8>QD<;3Z7[YVL42_G?X`@T9UP\\IMRB:A^]F=aKE56H1SNJ6W1SNJ5>QDOCY87[2<;3Z_G?VL4XUPR`@T9MFB:A\\I]H=aKE^CY8>QDO;3Z7[2<L4X_G?V`@T9UPRIMFB:A\\]H=aKE^6W1SNJ5[2<;3Z7G?VL4X_UPR`@T9B:A\\IMF^]H=aKE6W1SNJ5CY8>QDO4X_G?VL@T9UPR`IMFB:A\\=aKE^]H56W1SNJCY8>QDO[2<;3Z7PR`@T9U:A\\IMFB^]H=aKE1SNJ56WOCY8>QD[2<;3Z74X_G?VLMFB:A\\IaKE^]H=56W1SNJ8>QDOCY7[2<;3Z4X_G?VLPR`@T9U]H=aKE^SNJ56W1OCY8>QD<;3Z7[2L4X_G?VPR`@T9UMFB:A\\IF=:A\\IMKE^]H1a6W8SNJ5>QDOCY<[2_;3Z7X`G?VL4RB@T9UPH1aKE^]NJ56W8SCY<>QDO;3Z7[2_4X`G?VLRB@T9UPF=:A\\IMW8SNJ56QDOCY<>[2_;3Z7G?VL4X`PRB@T9UF=:A\\IMH1aKE^]Y<>QDOC3Z7[2_;4X`G?VL@T9UPRBMF=:A\\IH1aKE^]W8SNJ562_;3Z7[?VL4X`GPRB@T9U:A\\IMF=]H1aKE^W8SNJ56Y<>QDOCX`G?VL4T9UPRB@MF=:A\\IaKE^]H16W8SNJ5Y<>QDOC2_;3Z7[RB@T9UPA\\IMF=:]H1aKE^SNJ56W8CY<>QDO2_;3Z7[X`G?VL4`@?VL4X9UPRB:TF=aA\\IMKE^]H1SW8>NJ56<;QDOCY_G3Z7[2B:T9UPR\\IMF=aAH1SKE^]NJ56W8>Y<;QDOC_G3Z7[2`@?VL4X=aA\\IMFE^]H1SKW8>NJ56QDOCY<;2_G3Z7[`@?VL4XB:T9UPR1SKE^]HJ56W8>NY<;QDOC3Z7[2_GX`@?VL4B:T9UPR=aA\\IMF8>NJ56WDOCY<;Q2_G3Z7[?VL4X`@RB:T9UP=aA\\IMF1SKE^]H<;QDOCYZ7[2_G3X`@?VL4T9UPRB:F=aA\\IM1SKE^]H8>NJ56W_G3Z7[2VL4X`@?RB:T9UPA\\IMF=aH1SKE^]8>NJ56W<;QDOCYaK\\IMF=^]H1SNE8>QJ56WDOCY<;3_G?Z7[2@TVL4X`:A9UPRBSNE^]H156W8>QJ<;3DOCYZ7[2_G?`@TVL4X:A9UPRBaK\\IMF=>QJ56W8OCY<;3D_G?Z7[2VL4X`@TB:A9UPRaK\\IMF=SNE^]H1;3DOCY<7[2_G?Z`@TVL4X9UPRB:A=aK\\IMFSNE^]H1>QJ56W8G?Z7[2_L4X`@TVB:A9UPR\\IMF=aK1SNE^]H>QJ56W8;3DOCY<@TVL4X`UPRB:A9=aK\\IMFE^]H1SN8>QJ56W;3DOCY<G?Z7[2_:A9UPRBIMF=aK\\1SNE^]HJ56W8>Q<;3DOCYG?Z7[2_@TVL4X`A\\UPRB:MF=aKEISNJ^]H156W8>QD;3ZOCY<?V7[2_GT9L4X`@KEIMF=a]H1SNJ^>QD56W8OCY<;3ZG?V7[2_T9L4X`@A\\UPRB:NJ^]H1S6W8>QD5;3ZOCY<7[2_G?V@T9L4X`A\\UPRB:KEIMF=aQD56W8>CY<;3ZOG?V7[2_L4X`@T9:A\\UPRBKEIMF=aNJ^]H1S3ZOCY<;[2_G?V7@T9L4X`UPRB:A\\aKEIMF=NJ^]H1SQD56W8>?V7[2_G4X`@T9L:A\\UPRBIMF=aKESNJ^]H1QD56W8>3ZOCY<;T9L4X`@PRB:A\\UaKEIMF=^]H1SNJ>QD56W83ZOCY<;?V7[2_GDO6W8>QY<;3Z7C?VL[2_G4X`@T9UA\\IPRB:E^MF=aKJ5]H1SNZ7CY<;32_G?VL[T9U4X`@PRB:A\\IKE^MF=aJ5]H1SNDO6W8>QVL[2_G?X`@T9U4A\\IPRB:MF=aKE^NJ5]H1SDO6W8>QZ7CY<;39U4X`@TRB:A\\IPKE^MF=a]H1SNJ5QDO6W8>Z7CY<;3VL[2_G?\\IPRB:AF=aKE^MNJ5]H1S6W8>QDO3Z7CY<;VL[2_G?9U4X`@TE^MF=aKH1SNJ5]QDO6W8>CY<;3Z7?VL[2_G9U4X`@T\\IPRB:AJ5]H1SNW8>QDO63Z7CY<;[2_G?VLT9U4X`@\\IPRB:AE^MF=aK";
            Assert.Pass(dlx.SolvedBoard, Is.EqualTo(solved));
        }


        
        [Test]
        public void exceptionTest1()
        {
            // size is not valid
            string s = "00000";
            Assert.Throws<SizeNotSupportedException>(() => IsValid(s));
        }

        [Test]
        public void exceptionTest2()
        {
            //F cant be in a 9x9 board
            string s = "f00000000000000000000000000000000000000000000000000000000000000000000000000000000";
            Assert.Throws<CharNotSupportedException>(() => IsValid(s));
        }

        [Test]
        public void exceptionTest3()
        {
            // 2 numbers cant be in the same row
            string s = "110000000000000000000000000000000000000000000000000000000000000000000000000000000";
            Assert.Throws<RowNotSupportedException>(() => IsValid(s));
        }

        [Test]
        public void exceptionTest4()
        {
            // 2 numbers cant be in the same col
            string s = "100000000100000000000000000000000000000000000000000000000000000000000000000000000";
            Assert.Throws<ColNotSupportedException>(() => IsValid(s));
        }

        [Test]
        public void exceptionTest5()
        {
            // two numbers cant be in the same box
            string s = "100000000010000000000000000000000000000000000000000000000000000000000000000000000";
            Assert.Throws<BoxNotSupportedException>(() => IsValid(s));
        }

        [Test]
        public void noSolution()
        {
            string easy1 = "100000000000100000000000005000000100000000000000000000000000000000000010000000000";
            IsValid(easy1);
            int lng = (int)Math.Sqrt(easy1.Length);
            DLXSudokuBoard dlx = new DLXSudokuBoard(easy1, lng);
            dlx.FinalSolve();
            string solved = "cant solve";
            Assert.Pass(dlx.SolvedBoard, Is.EqualTo(solved));
        }
    }
}