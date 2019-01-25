﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using Umbraco.Core.Models.Editors;
using Umbraco.Web.Models.ContentEditing;

namespace Umbraco.Web.Models
{
    [DataContract(Name = "contentTypeImportModel")]
    public class ContentTypeImportModel : INotificationModel, IHaveUploadedFiles
    {
        [DataMember(Name = "alias")]
        public string Alias { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "notifications")]
        public List<Notification> Notifications { get; } = new List<Notification>();

        [DataMember(Name = "tempFileName")]
        public string TempFileName { get; set; }

        public List<ContentPropertyFile> UploadedFiles => new List<ContentPropertyFile>();
    }
}