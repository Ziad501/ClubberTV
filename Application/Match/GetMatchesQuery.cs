using Application.Dtos;
using MediatR;

namespace Application.Match
{
    public class GetMatchesQuery : IRequest<List<MatchDto>>
    {
        public string? Status { get; set; }
    }
}
