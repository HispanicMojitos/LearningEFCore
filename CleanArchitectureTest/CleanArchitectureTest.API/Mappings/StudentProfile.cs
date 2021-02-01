namespace CleanArchitectureTest.API.Mappings
{
    using AutoMapper;

    using CleanArchitectureTest.API.ViewModels;
    using CleanArchitectureTest.Core.Models;

    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            this.CreateMap<Student, StudentViewModel>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.LastName}|{src.FirstName}"))
                .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => src.BirthDate.ToString("dd/MMMM/yyyy")));

            this.CreateMap<Student, StudentViewModelListItem>();

            this.CreateMap<StudentViewModelCreate, Student>();
        }
    }
}
