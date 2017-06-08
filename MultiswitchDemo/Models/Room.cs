using System.ComponentModel.DataAnnotations;

namespace MultiswitchDemo.Models
{
    public class Room
    {
        [Display(Name = "Room Number")]
        public int RoomNumber { get; set; }

        [Display(Name = "Room Name")]
        public string RoomName { get; set; }

        [Display(Name = "Is reserved?")]
        public bool IsReserved { get; set; }
    }
}