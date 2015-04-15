using System.Xml;

namespace Lib.JSON.Converters
{
    internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration
    {
        private readonly XmlDeclaration _declaration;

        public XmlDeclarationWrapper(XmlDeclaration declaration) : base(declaration)
        {
            this._declaration = declaration;
        }

        public string Version
        {
            get
            {
                return this._declaration.Version;
            }
        }

        public string Encoding
        {
            get
            {
                return this._declaration.Encoding;
            }
            set
            {
                this._declaration.Encoding = value;
            }
        }

        public string Standalone
        {
            get
            {
                return this._declaration.Standalone;
            }
            set
            {
                this._declaration.Standalone = value;
            }
        }
    }
}