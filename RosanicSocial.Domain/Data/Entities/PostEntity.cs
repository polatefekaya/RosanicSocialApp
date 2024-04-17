using System;
using System.Collections.Generic;

namespace RosanicSocial.Domain.Data.Entities {
    public class PostEntity {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int LikesId { get; set; }
        public int MediaType {  get; set; }
        public string? Body { get; set; }
        public string? MediaUrl { get; set; }
    }
}
