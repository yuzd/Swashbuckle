using System;
using System.Xml.XPath;
using Newtonsoft.Json.Serialization;

namespace Swashbuckle.Swagger
{
    public interface IModelFilter
    {
        XPathNavigator XmlNavigator { get; }
        void Apply(Schema model, ModelFilterContext context);
    }

    public class ModelFilterContext
    {
        public ModelFilterContext(
            Type systemType,
            JsonObjectContract jsonObjectContract,
            SchemaRegistry schemaRegistry)
        {
            SystemType = systemType;
            JsonObjectContract = jsonObjectContract;
            SchemaRegistry = schemaRegistry;
        }

        public Type SystemType { get; private set; }

        public JsonObjectContract JsonObjectContract { get; private set; }

        public SchemaRegistry SchemaRegistry { get; private set; }
    }
}
