﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Microsoft.IT.GRM.ServiceClient.Models
{
    public partial class ViewUserFilterRequest
    {
        private string _requestStatus;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string RequestStatus
        {
            get { return this._requestStatus; }
            set { this._requestStatus = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        private string _userAlias;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string UserAlias
        {
            get { return this._userAlias; }
            set { this._userAlias = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ViewUserFilterRequest class.
        /// </summary>
        public ViewUserFilterRequest()
        {
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type ViewUserFilterRequest
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.RequestStatus != null)
            {
                outputObject["RequestStatus"] = this.RequestStatus;
            }
            if (this.Type != null)
            {
                outputObject["Type"] = this.Type;
            }
            if (this.UserAlias != null)
            {
                outputObject["UserAlias"] = this.UserAlias;
            }
            return outputObject;
        }
    }
}
