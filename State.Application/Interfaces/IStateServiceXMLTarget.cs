using System.Xml;

namespace State.Application.Interfaces
{
    public interface IStateServiceXMLTarget
    {
        XmlDocument? GetAllStatesAsXML();
    }
}