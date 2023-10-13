using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace webapi.Applications.GenreOperations.Commands.UpdateGenre
{
    public class UpdateGenreCommandValidator : AbstractValidator<UpdateGenreCommand>
    {
        public UpdateGenreCommandValidator()
        {
            RuleFor(command => command.GenreId).GreaterThan(0);
            RuleFor(command => command.Model.Name)
                .MinimumLength(4)
                .When(x => x.Model.Name.Trim() != string.Empty);
        }
    }
}
