using System.ComponentModel.DataAnnotations;
using LeaveManagementProject.Data;

namespace LeaveManagementProject.Models
{
    public class LeaveTypeVM: BaseEntity
    {
        public string Name { get; set; }
        [Display(Name="No of days")]
        public int DefaultDays { get;set;}
    }
}
