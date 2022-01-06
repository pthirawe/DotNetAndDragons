using DotNetAndDragons.Equipment;
using DotNetAndDragons.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAndDragons
{
    public class Event
    {
        public enum EventType { Get, Use, Combat, Discover }
        public EventType Type;
        public string TriggerPhrase;
        public Result EventResult;

        public Event(string triggerPhrase, EventType type, Result eventResult)
        {
            TriggerPhrase = triggerPhrase;
            Type = type;
            EventResult = eventResult;
        }
    }

    public class Result
    {
        public enum ResultType { NewExit, GetItem, GetEquipment, Encounter, MessageOnly }
        public ResultType Type { get; }

        public string ResultExit { get; }
        public IItem ResultItem { get; }
        public IEquipment ResultEquipment { get; }
        public string ResultMessage { get; }

        public Result(string resultExit, string resultMessage)
        {
            Type = ResultType.NewExit;
            ResultExit = resultExit;
            ResultMessage = resultMessage;
        }
        public Result(IItem resultItem, string resultMessage)
        {
            Type = ResultType.GetItem;
            ResultItem = resultItem;
            ResultMessage = resultMessage;
        }
        public Result(IEquipment resultEquipment, string resultMessage)
        {
            Type = ResultType.GetEquipment;
            ResultEquipment = resultEquipment;
            ResultMessage = resultMessage;
        }
        public Result(string resultMessage)
        {
            Type = ResultType.MessageOnly;
            ResultMessage = resultMessage;
        }
    }

}
