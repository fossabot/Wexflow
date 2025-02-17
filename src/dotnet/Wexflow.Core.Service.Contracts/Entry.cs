﻿using System.Runtime.Serialization;

namespace Wexflow.Core.Service.Contracts
{
    public enum Status
    {
        Pending,
        Running,
        Done,
        Failed,
        Warning,
        Disabled,
        Stopped
    }

    [DataContract]
    public class Entry
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int WorkflowId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public LaunchType LaunchType { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public Status Status { get; set; }
        [DataMember]
        //public double StatusDate { get; set; }
        public string StatusDate { get; set; }
    }
}
