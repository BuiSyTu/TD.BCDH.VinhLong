using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TD.BCDH.VinhLong.APIResults;
using TD.BCDH.VinhLong.ViewModels;

namespace TD.BCDH.VinhLong.APIResults
{
    [DataContract]
    [KnownType(typeof(List<BieuDo>))]
    [KnownType(typeof(ChartOutput))]
    [Serializable]
    public class APIResult
    {
        [DataMember]
        public object data { get; set; }
        [DataMember]
        public int total { get; set; }
        [DataMember]
        public Error error { get; set; }
    }
}
