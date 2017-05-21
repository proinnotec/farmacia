using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace SistemaFarmacia.Servicios.Utilerias
{
    public class Serializar
    {
        public string XmlSerialize<T>(T entity) where T : class
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;

            XmlSerializer xsSubmit = new XmlSerializer(typeof(T));
            StringWriter sw = new StringWriter();
            using (XmlWriter writer = XmlWriter.Create(sw, settings))
            {
                var xmlns = new XmlSerializerNamespaces();
                xmlns.Add(string.Empty, string.Empty);
                xsSubmit.Serialize(writer, entity, xmlns);
                return sw.ToString();
            }
        }
    }
}
