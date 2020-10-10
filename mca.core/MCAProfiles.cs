using AutoMapper;
using mca.core.ViewModels;
using mca.entity.Entities;

namespace mca.core
{
    public class MCAProfiles : Profile
    {
        public MCAProfiles()
        {
            CreateMap<CreateContactDTO, Contact>();
            CreateMap<Contact, GetContactDTO>();
            CreateMap<UpdateContactDTO, Contact>();
        }
    }
}
