

#if ROCKLIB
namespace RockLib.Messaging
#else
namespace Rock.Messaging
#endif
{
    public class MessagingSectionHandler : XmlSerializerSectionHandler<XmlSerializingRockMessagingConfiguration>
    {
    }
}