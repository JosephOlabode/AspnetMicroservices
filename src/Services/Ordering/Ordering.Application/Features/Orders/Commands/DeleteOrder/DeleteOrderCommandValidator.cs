using System;
using FluentValidation;

namespace Ordering.Application.Features.Orders.Commands.DeleteOrder
{
    public class DeleteOrderCommandValidator: AbstractValidator<DeleteOrderCommand>
    {
        public DeleteOrderCommandValidator()
        {
            RuleFor(p => p.Id).NotEmpty().WithMessage("{Id} is required.");
        }
    }
}
