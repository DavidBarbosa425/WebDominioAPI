namespace WebDominioAPI.Core
{
    public class DbConfig
    {
        public static string conexao = "UID=EXTERNO;PWD=EXTERNO;SERVER=srvdominio;DBN=contabil;HOST=172.16.3.53:2638";
        public static string conexaoConfirp = "TrustServerCertificate=True;Min Pool Size=5;Max Pool Size=1000;Password=conexao;Persist Security Info=True;User ID=conexao;Initial Catalog=ConfirpDigitalIncorporacao; Data Source=172.16.3.10; Pooling=false;Connection Timeout = 50000";
    }
}
