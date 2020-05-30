using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace serialização
{
    public class Serializar<T>
    {
        ArrayList Registro = new ArrayList();
        public Serializar(T[] x)
        {
            Registro.AddRange(x);
        }
        public void Salvar_xml()
        {
            FileStream Stream = new FileStream(@"D:\Pasta\Cadastro.xml", FileMode.Create);
        
            T[] Vetor_serializar = (T[])Registro.ToArray(typeof(T));

            XmlSerializer serializaçao = new XmlSerializer(typeof(T[]));

            serializaçao.Serialize(Stream, Vetor_serializar);
            Stream.Close();      

        }
        public ArrayList RetornarArquivoXML()
        {

            FileStream arquivo = new FileStream(@"D:\Pasta\Cadastro.xml", FileMode.Open);

            XmlSerializer Desserealizaçao = new XmlSerializer(typeof(T[]));
            T[] x = (T[])Desserealizaçao.Deserialize(arquivo);

            Registro.Clear();

            Registro.AddRange(x);

            return Registro;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
           
        }

    }
}
