using AutoMapper;
using LeaveManagementProject.Data;
using LeaveManagementProject.Models;

namespace LeaveManagementProject.Configuration
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();

        }
    }
}
