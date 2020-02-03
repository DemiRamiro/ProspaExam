namespace Prospa.MapperProfiles
{
    using AutoMapper;
    using Prospa.Data.Entities;
    using Prospa.ViewModels;

    public class BusinessProfile : Profile
    {
        public BusinessProfile()
        {
            this.CreateMap<BusinessViewModel, Business>();
        }
    }
}