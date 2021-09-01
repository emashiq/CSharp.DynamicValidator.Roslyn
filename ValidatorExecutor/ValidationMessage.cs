using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorExecutor
{
    public enum MessageType
    {
        Information,
        Error,
        Success
    }
    public class ValidationMessage
    {
        public string Message { get; set; }
        public MessageType MessageType { get; set; }
    }

    public class ValitorResultGenerator
    {

        public ValidationMessage Error(string message)
        {
            return new ValidationMessage() { Message = message, MessageType = MessageType.Error };
        }

        public ValidationMessage Success(string message)
        {
            return new ValidationMessage() { Message = message, MessageType = MessageType.Success };
        }

        public ValidationMessage Information(string message)
        {
            return new ValidationMessage() { Message = message, MessageType = MessageType.Information };
        }
    }
}
