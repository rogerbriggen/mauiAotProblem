using AutoMapper;


namespace mauiAotProblem
{
    public class DtoProfile : Profile
    {
        public DtoProfile()
        {
            CreateMap <MyDto, MyOtherDto>();
        }
    }
}
