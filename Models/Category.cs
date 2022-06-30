using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models;
public class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [DisplayName("Display Order")] //this displays the custom name in error
    [Range(1, 100, ErrorMessage = "Display Order must be between 1 and 100 only!!")]
    //the range notifies user that the value should be under the 100 
    public int DisplayOrder { get; set; }
    public DateTime CreatedDateTime { get; set; } = DateTime.Now;
}