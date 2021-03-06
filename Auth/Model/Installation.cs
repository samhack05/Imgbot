// <auto-generated/>

using System;
using System.Collections.Generic;

namespace Auth.Model
{
    public class Installations
    {
        public int total_count { get; set; }
        public List<Installation> installations { get; set; }
    }
    public class Installation
    {
        public int id { get; set; }
        public Account account { get; set; }
        public string repository_selection { get; set; }
        public string access_tokens_url { get; set; }
        public string repositories_url { get; set; }
        public string html_url { get; set; }
        public int app_id { get; set; }
        public int target_id { get; set; }
        public string target_type { get; set; }
        //public Permissions permissions { get; set; }
        //public List<object> events { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        //public object single_file_name { get; set; }
    }
}
