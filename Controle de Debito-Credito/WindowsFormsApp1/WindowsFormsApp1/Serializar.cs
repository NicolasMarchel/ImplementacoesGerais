using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public class Serializar<T>
    {
        ArrayList Registro = new ArrayList();
        string texto;

        public Serializar(ArrayList x, string t)
        {
            Registro.AddRange(x);
            texto = t;
        }
        public Serializar(T[] x, string t)
        {
            Registro.AddRange(x);
            texto = t;
        }
        public Serializar(string t)
        {
            texto = t;
        }
        public void SalvarXML()
        {
            FileStream arquivo = new FileStream(@"C:\windows\temp\Cadastro" + texto+".xml", FileMode.Create);

            T[] Vetor_serializar = (T[])Registro.ToArray(typeof(T));

            XmlSerializer serializaçao = new XmlSerializer(typeof(T[]));

            serializaçao.Serialize(arquivo, Vetor_serializar);

            arquivo.Close();

        }
        public ArrayList RetornarArquivoXML()
        {

            FileStream arquivo = new FileStream(@"C:\windows\temp\Cadastro" + texto+".xml", FileMode.Open);

            XmlSerializer Desserealizaçao = new XmlSerializer(typeof(T[]));
            T[] x = (T[])Desserealizaçao.Deserialize(arquivo);

            Registro.Clear();

            Registro.AddRange(x);
            arquivo.Close();
            return Registro;
        }
    }
}

