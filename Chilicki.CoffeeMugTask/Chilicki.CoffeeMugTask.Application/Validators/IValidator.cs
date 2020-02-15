using Chilicki.CoffeeMugTask.Application.Dtos;

namespace Chilicki.CoffeeMugTask.Application.Validators
{
    public interface IValidator<TDto> where TDto : IDto
    {
        void Validate(TDto dto);
    }
}