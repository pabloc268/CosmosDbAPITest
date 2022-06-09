using System;
namespace CosmosAPI.Models
{
    public class ToDo
    {
        public string Id { get; set; }

        public string Description { get; set; }

        public string Date { get; set; }

        public bool Completed { get; set; }
    }
}
