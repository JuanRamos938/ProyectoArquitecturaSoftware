using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization;

namespace ECOAPP.Core.Common.Exceptions
{
    /// <summary>
    /// Core exception
    /// </summary>
    [Serializable()]
    public class TdPolimerosException : Exception
    {
        public HttpStatusCode Code { get; }

        public Dictionary<string, List<string>> Errors { get; } = new Dictionary<string, List<string>>();



        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="code"></param>
        public TdPolimerosException(HttpStatusCode code): base()
        {
            Code = code;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public TdPolimerosException()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message"></param>
        public TdPolimerosException(string message) : base(message)
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        public TdPolimerosException(string message, Exception inner): base(message, inner)
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        public TdPolimerosException(HttpStatusCode code, string message) : base(message)
        {
            Code = code;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="validator"></param>
        public TdPolimerosException(Dictionary<string, List<string>> errors) : base()
        {
            Errors = errors;
        }

        protected TdPolimerosException(SerializationInfo info, StreamingContext context) : base(info, context) {
            Code = (HttpStatusCode) info.GetInt16("code");
        }
    
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("code", Code);
            base.GetObjectData(info, context);
        }
    
    }
}
