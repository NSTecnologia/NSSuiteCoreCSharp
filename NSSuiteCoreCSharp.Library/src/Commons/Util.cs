using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace NSSuiteCoreCSharp.Library.src.Commons
{
    public static class Util
    {
        //private static int GerarDigitoVerificador(string chave)
        //{
        //    int soma = 0;
        //    int restoDivisao = -1;
        //    int digitoVerificador = -1;
        //    int pesoMultiplicacao = 2;

        //    for (int i = chave.Length - 1; i != -1; i--)
        //    {
        //        int ch = Convert.ToInt32(chave[i].ToString());
        //        soma += ch * pesoMultiplicacao;

        //        if (pesoMultiplicacao < 9)
        //            pesoMultiplicacao += 1;
        //        else
        //            pesoMultiplicacao = 2;
        //    }
        //    restoDivisao = soma % 11;
        //    if (restoDivisao == 0 || restoDivisao == 1)
        //        digitoVerificador = 0;
        //    else
        //        digitoVerificador = 11 - restoDivisao;

        //    return digitoVerificador;
        //}
        //public static string GerarChaveDocumento(Projetos projeto, string cUF, string dhEmi,
        //    string serie, string nDF, string tpEmis, string cDF, string cnpjEmitente,
        //    string tpEvento = "", string nSeqEvento = "")
        //{
        //    for (int i = serie.Length; i < 3; i++)
        //        serie = "0" + serie;
        //    for (int i = nDF.Length; i < 9; i++)
        //        serie = "0" + serie;
        //    string[] auxAAMM = dhEmi.Split('T');
        //    DateTime dateTime = DateTime.Parse(auxAAMM[0]);
        //    string aamm = dateTime.ToString("yyMM");
        //    string chave43 = cUF + aamm + cnpjEmitente + ((int)projeto).ToString() + serie + nDF + tpEmis + cDF;
        //    string chave = tpEvento + chave43 + GerarDigitoVerificador(chave43) + nSeqEvento;
        //    return chave;
        //}
       
        public static string GerarPDFTemporario(string pdf)
        {
            byte[] bytes = Convert.FromBase64String(pdf);
            string file = Path.GetTempFileName() + ".pdf";
            File.WriteAllBytes(file, bytes);
            System.Diagnostics.Process.Start(@"cmd.exe ", @"/c "+ file);
            return file;
        }


        public static string LerElementoDeXMLString(string xml, string elemento)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            XmlNodeList xmlNodeList = root.GetElementsByTagName(elemento);
            if (xmlNodeList.Count > 1)
                throw new ArgumentOutOfRangeException();

            return root.GetElementsByTagName(elemento).Item(0).InnerText;
        }        
        public static string GerarXMLDocumento<T>(T ObjectXML)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlSerializer xmlSerializer = new XmlSerializer(ObjectXML.GetType());
            using (MemoryStream xmlStream = new MemoryStream())
            {
                xmlSerializer.Serialize(xmlStream, ObjectXML);
                xmlStream.Position = 0;
                xmlDoc.Load(xmlStream);
                StringWriter sw = new StringWriter();
                XmlTextWriter xw = new XmlTextWriter(sw);
                xmlDoc.WriteTo(xw);
                return sw.ToString();
            }
        }
        public static string CriarDiretorio(string caminho)
        {
            try
            {
                if (!Directory.Exists(caminho)) Directory.CreateDirectory(caminho);
                if (!caminho.EndsWith(@"\")) caminho += @"\";
                return caminho;
            }
            catch (IOException ex)
            {
                GravarLinhaLog("[CRIAR_DIRETORIO]" + caminho);
                GravarLinhaLog(ex.Message);
                throw new Exception("Erro: " + ex.Message);
            }
        }
        public static async Task SalvarXML(string xml, string caminho, string nome)
        {
            await Task.Run(() =>
            {
                if (!string.IsNullOrEmpty(xml))
                {
                    Util.GravarLinhaLog("[SALVANDO_XML_INICIO]");
                    string localParaSalvar = $"{caminho + nome}.xml";
                    string ConteudoSalvar = xml.Replace(@"\""", "");
                    File.WriteAllText(localParaSalvar, ConteudoSalvar);
                    Util.GravarLinhaLog("[SALVANDO_XML_FIM]");
                }
                else
                {
                    Util.GravarLinhaLog("[ERRO AO SALVAR XML] : XML sem conteudo");
                }
            });
        }

        public static async Task SalvarPDF(string pdf, string caminho, string nome, bool exibirPDFNaTela)
        {
            await Task.Run(() => {
                if (!string.IsNullOrEmpty(pdf))
                {
                    Util.GravarLinhaLog("[SALVANDO_PDF_INICIO]");
                    string localParaSalvar = $"{caminho + nome}.pdf";
                    byte[] bytes = Convert.FromBase64String(pdf);
                    if (File.Exists(localParaSalvar))
                        File.Delete(localParaSalvar);
                    using (BinaryWriter writer = new BinaryWriter(new FileStream(localParaSalvar, FileMode.CreateNew)))
                        writer.Write(bytes, 0, bytes.Length);

                    if (exibirPDFNaTela)                   
                        System.Diagnostics.Process.Start(@"cmd.exe ", @"/c " + localParaSalvar);
                    
                    Util.GravarLinhaLog("[SALVANDO_PDF_FIM]");
                }
                else
                {
                    Util.GravarLinhaLog("[ERRO AO SALVAR PDF] : PDF sem conteudo");
                }
            }); 
        }
        public static void GravarLinhaLog(string conteudo)
        {
            string caminho = @".\log\";

            if (!Directory.Exists(caminho))
                Directory.CreateDirectory(caminho);
            string data = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff");
            string nomeArq = DateTime.Now.ToString("MM-dd-yyyy");

            using (StreamWriter outputFile = new StreamWriter($"{caminho + nomeArq}.log", true))
                outputFile.WriteLine(data + " - " + conteudo);
        }
    }
}