using System;
namespace DotNetCoreWebAPI.Models
{
    public class Member:Person
    {
      
        public DateTime StratDate {get;set;}
        public DateTime EndDate{get;set;}
    }
    
}