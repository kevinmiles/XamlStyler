using System.Text;
using System.Xml;

namespace XamlStyler.Core.DocumentProcessors
{
    internal class XmlDeclarationDocumentProcessor : IDocumentProcessor
    {
        public void Process(XmlReader xmlReader, StringBuilder output, ElementProcessContext elementProcessContext)
        {
            output.Append("<?xml ");
            output.Append(xmlReader.Value.Trim());
            output.Append(" ?>");
        }
    }
}