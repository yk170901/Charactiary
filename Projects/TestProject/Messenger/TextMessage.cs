using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestProject.Messenger;

//public class TestClass
//{
//    public string MyProperty { get; set; }
//}

internal class TextMessage : ValueChangedMessage<string>
{
    public TextMessage(string value) : base(value)
    {

    }



}
