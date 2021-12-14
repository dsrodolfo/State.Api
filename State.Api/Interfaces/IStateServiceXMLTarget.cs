using System.Xml;

namespace State.Api.Interfaces
{
    public interface IStateServiceXMLTarget
    {
        XmlDocument GetAllStatesAsXML();
    }
}