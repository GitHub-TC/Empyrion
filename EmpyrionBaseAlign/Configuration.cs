﻿using EmpyrionNetAPIDefinitions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EmpyrionBaseAlign
{
    public class Configuration
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public PermissionType FreePermissionLevel { get; set; } = PermissionType.Moderator;
        public string[] ForbiddenPlayfields { get; set; } = new string[] { "" };
    }

}
