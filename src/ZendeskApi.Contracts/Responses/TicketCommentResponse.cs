﻿using Newtonsoft.Json;
using ZendeskApi.Contracts.Models;

namespace ZendeskApi.Contracts.Responses
{
    public class TicketCommentResponse
    {
        [JsonProperty("comment")]
        public TicketComment Item { get; set; }
    }
}
