using AutoMapper;
using LearnSharp4.Automapper.Entities;
using LearnSharp4.Automapper.ViewModels;

namespace LearnSharp4.Automapper
{
    internal class Program
    {
        private static void Main()
        {
            var mapperConfiguration = new MapperConfiguration(config =>
            {
                config.CreateMap<PersonViewModel, Person>()
                          .ForMember(x => x.Address, src => src.MapFrom(y => new Address()
                          {
                              HomeNumber = y.HomeNumber.ToString(),
                              Street = y.Street,
                              Town = y.Town
                          }))
                          .ForMember(x => x.Id, src => src.Ignore());

                config.CreateMap<Person, PersonViewModel>()
                          .ForMember(x => x.HomeNumber, src => src.MapFrom(y => y.Address.HomeNumber))
                          .ForMember(x => x.Street, src => src.MapFrom(y => y.Address.Street))
                          .ForMember(x => x.Town, src => src.MapFrom(y => y.Address.Town));
            });

            mapperConfiguration.AssertConfigurationIsValid();
            var mapper = new Mapper(mapperConfiguration);

            var vm = new PersonViewModel()
            {
                Name = "name",
                LastName = "lastName",
                HomeNumber = 123,
                Street = "Vyatskaya",
                Town = "Vyatka"
            };

            var person = mapper.Map<Person>(vm);

            vm = mapper.Map<PersonViewModel>(person);
        }
    }
}
