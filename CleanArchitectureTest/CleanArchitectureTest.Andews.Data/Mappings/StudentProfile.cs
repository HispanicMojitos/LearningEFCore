namespace CleanArchitectureTest.Core.Mappings
{
    using AutoMapper;

    using CleanArchitectureTest.Core.Models;

    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            this.CreateMap<StudentUpdate, Student>();
        }
    }
}
