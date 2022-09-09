using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;


namespace MVCDemo.Models
{
    public class Friend
    {
        [Required]
        public int FriendId { get; set; }

        [Required]
        public string FriendName { get; set; }
        public string Place { get; set; }

    }
}
