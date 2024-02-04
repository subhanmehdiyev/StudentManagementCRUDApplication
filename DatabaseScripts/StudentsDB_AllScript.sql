USE [master]
GO
/****** Object:  Database [StudentsDB]    Script Date: 04.02.2024 14:34:22 ******/
CREATE DATABASE [StudentsDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StudentsDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\StudentsDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StudentsDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\StudentsDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [StudentsDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StudentsDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StudentsDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StudentsDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StudentsDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StudentsDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StudentsDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [StudentsDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StudentsDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StudentsDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StudentsDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StudentsDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StudentsDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StudentsDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StudentsDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StudentsDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StudentsDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StudentsDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StudentsDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StudentsDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StudentsDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StudentsDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StudentsDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StudentsDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StudentsDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StudentsDB] SET  MULTI_USER 
GO
ALTER DATABASE [StudentsDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StudentsDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StudentsDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StudentsDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StudentsDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StudentsDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [StudentsDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [StudentsDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [StudentsDB]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 04.02.2024 14:34:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Student_ID] [int] NOT NULL,
	[Student_ImageInByteArray] [image] NULL,
	[Student_Name] [varchar](80) NOT NULL,
	[Student_Surname] [varchar](80) NOT NULL,
	[Student_Birthdate] [date] NULL,
	[Student_Nationality] [varchar](80) NULL,
	[Student_Gender] [varchar](30) NULL,
	[Student_Address] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Student_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Students] ([Student_ID], [Student_ImageInByteArray], [Student_Name], [Student_Surname], [Student_Birthdate], [Student_Nationality], [Student_Gender], [Student_Address]) VALUES (101111, 0xFFD8FFE000104A46494600010101000000000000FFDB0043000A0708151512181516151818181A1818191A181A1A181C181A1C1C181A191A1C191A1C212E251C1E2B2318182638262B2F313535351A253D403B343F2E343531FFDB0043010C0C0C100F101A12121A342424213434343434343434343434343434313434343431343434343434343434343434343434343434343134343434343434343434FFC000110800E100E003012200021101031101FFC4001C0000020203010100000000000000000000000103060204050708FFC4003E1000010302030604030604060203000000010002110321041231054151617181062291B132A1C1134252D1E1F007146272238292A2B2F115332443C2FFC4001801010101010100000000000000000000000001030204FFC400231101010101000104020203000000000000000102112103123141516132A1132271FFDA000C03010002110311003F00F574249A01349340210840D0842010F701A95A7B5769330F4DD51E600F527801BCAF2ADB9E34AF5333B30A74CFC2DB1711B89EBD92D1EA78ADB1429897D460FF00309F495A387F16E11EECADA82662F03DF5ECBC3EB6D1717110E3C6728336E22536E2848CCCC82C24837EAE163D2CA795F0FA21955AED0AC9787D77566530EA3509D0013E61BFC8640361A19B48EBA8CF1463DAE39712F6B86AC3963B0208EDC6511EF885E65E1BFE25930CC5B2F606A322678B982F1D2FD57A361314CAAC0FA6F6BDA74734823F4544C842100926920124D240249A4A810842012284150649A485434210A06849340D6B63F18DA4CCCE227702627F45393175E55E3DF11E7A869B5D690D00130ED443B80924C6F808391E33F103F1355AC69917B6EB9816D2F07B752B8020905E7480D9BCC6F6B753ACCFCC2E7D4AB05C5A65CE240235CBA5BAE9DD7570744308801F522D310CFED1CB7B8EFD37A4460FA6FF00B8CAA5A46A0960F93403D89EAA27308F89AF69FC4E19C46F96BBE86565B4B0EE6BBFC47B9C489CAD05C6FA4DEC399D57383DDB83BA13F4002A3A9471191B9330730C439B240BCC6575C5EF94F62343AF5EABD87CAF90458871D3FA5E208D0483DEEB4C3E0C8107420DC1D6C77F62B2A3520100083720DE0E92D3BB87EE4456CBF10C2D19DAE331706ED3CE7DAD2BB9E1CF12BF08EF2BE587426E01D723DBAC711BB348D4CD67219207A6EF429367411AF3F42141F44F87B6ED3C5D20F6119B4737783D38597557CEBB0F6AD4C33F3D37B43B7799B71696969371A1F6D4AF6EF0B788998DA39DA32BDB6A8CFC279722A8EE24842012421502109201084204914D22A0CD0842A1A124D40D2A9A1405C6F16ED2186C23EAEF000178BBAC3E682B5E39F18FD8B0D3A4E8A8490FB0F20EFBFD579054ACE7BCB8925C4CE63722F24CEF3FAADDC463C39C5CF25D98C96900DF8874CCAD37BC1B324DBEF0DC3791255442E7DE7D3DA7E4A4A58A73493FBE9D142F9162B670783CFF00972E252D9092DBC889F55EF7799D2499B9B4F3DC174766E118E395ED2C2059C26E6446A6279A9B0FB09CE74B558B01B0EA38863DB0045C70BCC72E4B3BB9F4D27A7AFB71F1FB11ED9759CDCA0B5C378D44F3FDF0536076239ED0E0CB4C3871CC09904F2CBEBAF0BFB760791ACCC72DB5D6C2175303B31AC6444E9E8098F75CDD3B998A1BBC3E1AE39984B5C036459C2781E446FF00CD57319B09EC97019849D3789171C0DF4E5CD7B4BF08D22216B55D9AC76EEBC0DE7EAB996C75732BC12B360F023E7CF91561F09F88EB615F9D994B0C31C08178048EF2667995D6F1AF875AC39DA222D22341304FAEBC95636480C9CE3E2735801B8D6E4CF0911CF5B4ADB3AF7461ACFB6BE88D9F8A156932A3747B43BD45C2D8541FE1D6D1735CFC2BCC40CF4DAE378DF9788D0FAABF2A84842150249A4804212500914D228334210A8139490A01CE8E8A85FC55C41FB0A6C12067CCE3D1A408F52AF85A382F36FE291CADA4C6982E7196924C06826DC35F9041E5EF610D25CCF2CF9751E877FA2CA830996B5A64DFB75E278738DEB3C5D473A7E2206B0DB344981CB8DF8A9704E7B585CD61739E72B5EED0377E59E3C74EE97E124F2E63E66FAAB56CAC19F23635027F7E8B875B02E6D4630FC4E73411CC913E9217A56C8C04998597ABAF1246FE8E7CDB5BBB2B6706816560A7404447E6961F0B014EC6ACE4E35B7A918DE49852D3A5BC94398175C73D600AC5E564428DE10553C6559BF645A60C8368998540D99851903DF66978689D49CF2F200F84650E1D55EFC660B6939C07DD37EE179DE05E2B16B0B8C863A27410DB37EB3FD4575E9FDB3F57E9BF4AA3E9BD95A61EC25E351A4003A1103D38C2F73C0E2DB569B2A30CB5ED0E07AAF15C453CEE3060B72B483FD2CB47312D9E83BFA07F0E717FE13E8492299616924E8F68240E40C8EB2B564B82134950909A4804934940245348AA324D24D00842100BCBBF8A6F2EC561D83731EEB73222FCF2C2F515E5FF00C41A67F9E6B88B36888EA7ED23B0742951E71B4226E4C6A222C24C120EB3AEBEEAFBE1BD98F386696536E62DF2BCE52ECD02E1A5B3FEE10A8188A59AB106CDCC0663610204C9E8AF75FC4F86A549B4D9558486C7DFCBBEC40175CEFB7923BC593B6A3C3786CB713F685D99AC1198DF33CC870693AB5B6BF1246E2AF980C343459794D6F15BF50F69B40B16B63968BA783F18E2488606BFFB1CC73BB343899E50B8B9B7CB5CEA4F0F52A752028F3F9952F01E2D19C31E0B4BB7105A41E86FA47A2B3D2C458BF71BF65C5BF4D24FB7446232824E8B56AED9A4D139C1E3045BF254AF12789BECCB9ADB08235893754960C456CCF60316B59A083B9B244F3856799D716F2F1EDF4B6CD270B3C7A859D3C5B1F394CC2F1EC36CCC4B44B984CF0796C7230C74FCD74A9E371549BE46D2074CCEA955DECD007C95B3F69EEFD2F1E23C2FDAD17B46B07D978BE1AA64AA09B16DBE703E9E8ADD8FF18ED0A0E02AD2A10E12D391E5AE1C5AE6BE0EA154B69E285671AB91AC2E75C3672E93226E1778CD97F559EF52CFDC583C375CBDCF7100BB238C9FC59858F68F52AF7E03AF96B39910D2C6098B486C86CF200DD79A78731791B538C121DBC3B290D8EFEEAF5E08AF9B10CCBBCBDCE3C66D1DB20FF5F58ED9BD3D24CA4AA9210844242125142453589551221084509A49A0154BC7BB2F3D215DB39E9D8C6F638C131BE267B2B6AD5DA65BF62FCDA6474FFA4A23E70C333CCFFB4139185CE69904905AC0D245E0B9E27902AF584A40B286463580B1AE2580365C4033E5813EAAA4E1352A32092EA751ADE794E76772EA6E1DC2F4C1823FCB51C96229B00EB907E4B3F52F23BF4E76B8F576961E8921E5CE33C6DD2E409E4B8FB4B6CE0AA7FF005FA8691E8755B0FF000954CF9B3B1C5C0870A824006FE5DE355AF86F09B58E05EF7174D836207AB567DCFDD69FED6F247131A72333D17B8337B24E512625AD3669923D56787DBF8F14DD92ABF246A5B4CC01CDCD95DFDB3B09987C23F230E67963049265EE7800C6937DCBD2F676CAA54F0E290630B435AC232833020CF19566BB3F3FF4F679F3FD3C4F66D00F1F6CF97B9CE7005C6620024DFA9E90BA984F123699CCD6080633169749E10200F55D9D91B198CAF89C23C02D6BF3B01162C7825A39886B81E6D5263FC2B4C35C0532184825AC710D078C09CBD94B65BE564D73C351BE346BE41022D27ECDCC03B82E8EE16E36A33134F3B49CC08B4891D08B11CD4583F0CE1A480C7C18CCD0F9040D01B93AF4566D9BE1DA34C873199390263B8985C6ACBFC5D4967F257FC5F841FF008C7B9C2EC731CD26E67306DB990E23BAA8EDFF000EBF0D42938992E00D4FE97B868390D3B735E95E29A21FFCBE1E3FF662184C7E0A60D57CF2F281FE60B93E2F702C787CFF00471169103AAD33AB99238B99AB6BCEB66B0169E2D39A3888D3D437E6BD3FF8718322A82E06452738DE7CCF736DD848EEA8F86D9AFA6F0E2D827312C31B8C32637DF4FCD7AA78070A5B49F51DABDC1A0EECAC681239125C56DD6322D6842154242124024829201229A450669A49A8A10842014588A799A47252A151F3EE370AFF00E7035B6767700E3A078AAECB3CB31685EA1B0B1CCA945B00B1D4C063E99F8E9B9A002D70D7A1DE082ABDE26C09A78BA840FBE6A0DC5D9B23C06F470713DF85BB6FA14EAE57B9AD3E51E712D7C44887B48205D65BB3EDDE27E1BF5F0AD246BDB77543306C67980BF1372B82EC2C1863F10045A2B3DD7DF67CDB4DEB95B503C34873B12E0771AAF13CBCA42C6FB5E899D5FAFEDD9AEE6E271B4B0CD20B68BFF98AB1700B4453693F88B9C1D1C1BCD5E2933CA7B2A551AB87C051631A58C2E873C920173CDCDF86E5B87C402D7D74BDB4DDC575EE91266D6BF8B30E68D4A78D634B853F2560D04B8D371F8801A963AFD1CE5D5D998E6D6635ED19D86C1EDF334F71A743A2D1C3F8B70E6AE4755666D32E61AF0EBC9547C53826B3166A61C65639AD73C32CDCD24175B49002BD9F64CDB7C3D20D200E6C9DF2C7CD69E236E50612D3518E708F233FC4A97FE8A61CE1D48039AAB6CED8ADA8D0E7063BFBC66EFE69565C3D234D81A0003FA4003D14967E1759B3EDA385A551F5CE26B372434B28D22417318E20BDEFCA48CCE2D68804C06EB72B8BE27A9E72444E590EB488D72F3D2159FEDAC794AAF635E1D532E5CDC4100EA46EDDAC83CBB29EEED73272572765615AFAF4A983E776427798F883637000C9DFA05EBF85C3369D36B1821AD000EDF5544F056C9FFE63EA916A6C89E2F7C1B72027D79AF405E8CBCF7F00A1092E9C848A6B128049052402450914124A6B14D034D629A81A1085456FC69B3C3E90AA273D3E1A96BAC45BB7ECAAE6C5AF9A931A4C10D8371BADF457ADAF4B3D17B794FA5FDC05E61807E469689D6D11CB7F53F3E4B2F5235F4EAD9FCD31A387E5FBF75A0CC531F50CDC37809FD156313B409900DE35BF99DCB94F6D147B3C64792E2E1322C6D68077F12B0E57A3DD2399E21AEE75525CCCEC6B8B5B98122091611AEA16A7FE4DCC6801B906E68881D06E562DAB4D84001A0CDCC1CC66E249062E33180AB58FD9EECC3CA6223B9D02EF3CBE2B8B75F3191A352A00F60005869DC498B69AE8AE1E15A20D37B6B1CCE73F79974801A47EECB8382C2BDB4DAD700010019E92D2795FE6B6AB62B26470BC5FADF524684CEA3FEDABDF0B99679AEA51DA870D54D2746524E47CEEFC248D2235563C3ED56BC0B836B8ED2BCD31D8EFB46B4BA2C4988B59A09E7A4F5CA7B6EE1316E6300CC0C8B199D2C0B48DD0A5CD909B9AF95BB19B421C088B98B6EE33FBDCB41F443C9737E202601D5B30446FB4F75C7AF8ACE0F2832246E39A4EE11BFF0063B5B3DE5E1F91C24E502DBC8CC7ADE49FD15CE7CB9D6BC3D0BC3C07D8021B9413EB10D04F61F25D250E1181B4D8D168680A55E98F30421081148A0AC4A0108490091424504A84934026926804D24204F163D1790EDFA6FA151F480805C4077F412488E795CD1D8AF5E72A6F8E76497B3EDDBAB18411139AFE53D8FBAE753B173795407D5B448CC3474580BFC3BE644CDB41C956EAE21EF7E56CFC472CEB737F61F35D5DA6EC8EC83CCE30001A102381BC890ADDB2BC2AC0C350819DC4BA324C037B13700EEBDC5ECB89393AEEDED91CBD8FB031351A09700388693D3470FD8562A5E1B7889AC2C77D31F572D76635F4DE587CB04C9240813B80DFFA0D54188C4BEA303C3DD23EEDE60981238F2594BDF98F4CD7278756BF85D8F12FACF37D258D1E807D557B6D78529B58487B891A093952A1B49F0E99B5C49E2E206EE0E6DFAF0581DA2E7116272B9C1C0DC6E304FF00A8F4015B6FD25D767954713807D319A65A0C6FB4C9EDC3BF35D163258C6CC381B4DA416E6209DD001E56579C660D8EC239EF65B202401F8A01234300C18B1107A2F3EA2465735BE6CA1D637224C6A376BF25AF3B275E6EF2DE3AD84C3E501D721C4013201CCD39A20EE1BFA71565F0C61C3AB88B89698BF944361C771B4E9C7B9E132BE601A78B5C7965321AD1FE636E20057FF06E0A067B7011C018027A347A1E699CF95D6BC2DB0842168CC245091281148A09490092108049082833421254640A6B144A832941294A44A0095057A61CD2D2241104294951BDCA8F39ADB03ECF18E9CD94B4E4305DA411C743303842BDB28B594F7021B68E9A927B5F905A3B56BD2680F73DA0030092209360D078930216C57AC4E58B0049773CA0C0EF6D792E784AAC9D85F6AF738F95B0337F4C1CD95BC493A9FD56D3F65B07C110C2D917800DF7C49904F1DDBED647536E5CB6816DD7394813F33DD73B1F45C69B9AD3073DCEF201CD20DEF060F459DCB49AAE0D6C2B017F97E10C64EBA00D31CF59B45C03CB4713B07379D8DCAF68F30D43984439A46FCA40E3A9830BB6CA595CE73E1A22735F2BBC80DBA3C93ED65D2C0372B1A609319A0FE2983CE3CD3DD5CE4D69150C11FB068395CDA8CF332F9672C1D38E93CC9D579FED1D8AD662E002D6B46688394B730B4EF24C7583C97A562AA435AD1A0F9120889F454FDB98A67DA1B8CCE6300378B38C1B49FBFF00EDE623ABF0E279AD1F0E6C8FB4ACD6BBCB018620C8025F3C3736DFDBA95EA782C3318C6B5820002C1523C32CA8CFF15F2204061B18D2F370607E615E30D886BC02D3DB7AE73A97C3AD66C6C2482B12B47064AC4A1240248490084210082848A8324241273F809DE5743294D62EE09FB7150348AC5CFF0097A2537EA10475AB40982570B6CE21E295470378817F2831131A6ABB788612DE7B971B69B3361DF6BC13DC09FA2A95C5761DAFAF45AEBB58D7B9A0E92035A0F5879F55B0FDA229B8B5FF000CBA0C08123E23C7429D47E5AB4CFE20E6CDB780E1FF00050ED3A1981E2BCDBD5CE9BE33359E3B786C6B439B2730209B19BCC836FBBBA7905CCDA78D34EA66D44663372E2266C391023D345512D7B1DE57B991711F08221C2DA5C813F458E26BE201CCEC8FE0483235D6E389D38E8BA9EA66A5F4B5165FE725EC60702D70CC03B3086880D2336F5B636806325CF01EE0041BC36017403C49F98E0A8D8AC45771249811A004131C86EB68A2C3E1AA92D249044C19BF4E5AEBA9809EF9F94FF1EBF0B6ED5DB920C34C66203AC4B81988F783D2CB95B3367BEA54FB4A997401B00D834DBBF29B2581D9DC5C5D31BE780BFA0569C2D1CA165ADFBBE1B67D3F6FCB670CD810B730B4A2CA2A14E574A8314CC2A214DEC12C739C35CAE71279E571F636E616C603145ECCC789EB6F753BA0095850644EEDFDCFEC2F462D61B92260512B1C3BA64703BD665AB470C651282C2B170840E50B1944A069144A45066ED0A4E6F9BF77FD519A45B5589719954660F98F41F34FA7EBF3587DEEC3A265C06F506353E23A891EC82080248DC12AA7437FFB13F4523B49E10A8459EDC4CAD034C02E6936BC6FD42E891E8B5B10DF3023788EE89555DA5877369077DEA6477C8E0481C240F9AC4BC3DB6BC8041DD71FAAEEE3B0E0DB73C44F076E27A80AAD4CB98F75333624B7FB49D3B19ED0B0F5B3F6DBD1BF483118591A76FDF651B28C0885D178958358BCBC7B2573DF48CDADCECA21859372BA8E6859E1F0A1CECC409D3B70F64E1D6780C342EC51A72A3A34602E861E959779CB3D6995162DFA6D51536299CE81CD6B98CAD46FA92E8D436E56C30103F7AEF5AF429EBD6E78F25B06DCD7A24E4616F6F5851F89DFB0A48E5751D00093D7E8164F174419AFFAACE4A8C195949409A41EA939838AC5B671130A51788282273485812A67BAF1EDECA3A8DE0835B0EF20961376FC3CDBBBD34F4E2A62E96C6F8B75850E25E410459C0F94EE70DED3CCFCECB2A7880E198684C779D396AA89A91075FC2DDFC964E1651B1F71BA471D6C1481C78FB7BA0C2A7C23A8E13AC6EEAA5DD6BFB2C2A9B776FB8591E96D540DA6CB0AA25BD20F4EBCD64C10277724CB6DC6420D4C4795BE6E5BB81FCBD970B6A60FFC43522D00833AF111F3B70563752CCD883D656B3A86E927CBE59E46ED3CEFAFE4964B39496CBD8E01C2A85F41771B46DA696513B0EBC773CAF6675D71E950BAE850A10B619875B54A924C974C68D15BAC6254D8A77D8692770E6B4CE59DD711BCC752A36924E513FD4780E00EE3FBDE8A8F8077B8FC2374F3E016C536646893BE493BC9D56F9CF186B5D66C1161A0091722471EDA7C904FA6E5D2161E6E789FA46A9BB5FAFEA9D2072F5BAC5FAE8A0517BF6E28CD6D7D62E823E975965D419F920C0BBCE2781BF15238C7B0D2EA2730022E75593EA49B7DDB77FDFBA04D30EBEEF7DEA4636449DF75835B0D83A9313EFF0025200634B20D5AF4ED06E38FDE1D23EAB4012CA9712DA80DE2C5C38F0247FC574B388BF949DC63DD455E8B5C3BC8D011CC6E26EA8D4188F3305C187EBC881AF1B85BD9808E9B81F9C05C979CB55B31F1380131F1341B0238B4AE97DB5F29FA19472CAA3E411A5DBFF2F7521207E9D56B39E7FDC386EBA9DA4831A9DF7474CF8F2EA9B1F3A7145AFA7E5B93893BD036CF3E8B55A356EF073B759E63DFFD4B64FBFAA82B9CB95DF848BF2363F43D9063904DB7FF00DAC5F48F05B0698D2DC4731CBD9655DD00982481A0D4F2EAB2D67BE5A635CF0D4FB352318869E3C54C5C23F7759C8D2D641B093CC02E71D2F3B9148392AA1AE869931781CAD7FC96D9CF18EB5D418719A5E6C5DA7F4B78753A9EDC16D9898D7E6B1647A5F821AE9BFE5EEBA72C813361EBF449EE9B7637439E2275F4FCD44DD67E5BF84DBAA09DC77FE88AAEB05806DB9EEE0983022C4EFD1006E358958899D401D50DD35EDFA279AFBFD1060F37049B0BE8A2A4F21A0FEB73727D4A7897795DC632F73E51EEA173C668DCC1BBF11DDCCFE6A8DC603304E827A13FA7BA9F75D6AE19840927CC6E4F3E1DB4ECA69BC012541AAED4F65AF4741FBDC50855CB59DF1B3A33DDCB6B0FF13BFCC9A106787D07F71F72B6CFC23F7BC210A2C44751D90FF8876F67210AAA4DFE9F451633E17743EC8428154F85BFDDFF00E4A9717A1EDEC5084223FDFF00B8291BF0B7AA10B2CFCB6D7C33A5A8E87D8AC0FF00EC77F6B7DCA10B5621DA7F9826353FBE2921061BFB7D51435F4421512B7F3FAA19AA685042FD7B8F753F0EA842A46BD6F84FF733FE4B5705A3BFBFEA10841BACF847F6A96868842847FFD9, N'David', N'Bomwal', CAST(N'1979-07-14' AS Date), N'Slovakian', N'Male', N'Germany, Berlin')
GO
USE [master]
GO
ALTER DATABASE [StudentsDB] SET  READ_WRITE 
GO
