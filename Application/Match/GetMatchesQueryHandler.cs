using Application.Dtos;
using Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Match
{
    public class GetMatchesQueryHandler(AppDbContext context) : IRequestHandler<GetMatchesQuery, List<MatchDto>>
    {
        public async Task<List<MatchDto>> Handle(GetMatchesQuery request, CancellationToken cancellationToken)
        {
            var query = context.Matches.AsNoTracking().AsQueryable(); 
            if (!string.IsNullOrEmpty(request.Status))
            {
                query = query.Where(m => m.Status == request.Status);
            }
            return await query.Select(p=> new MatchDto
            {
                Id = p.Id,
                Title = p.Title,
                Competition = p.Competition,
                Date = p.Date,
                Status = p.Status
            }).ToListAsync(cancellationToken);
        }
    }
}
