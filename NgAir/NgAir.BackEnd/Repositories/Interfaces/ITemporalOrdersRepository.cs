﻿using NgAir.Shared.DTOs;
using NgAir.Shared.Entities;
using NgAir.Shared.Responses;

namespace NgAir.BackEnd.Repositories.Interfaces
{
    public interface ITemporalOrdersRepository
    {
        Task<ActionResponse<TemporalOrderDTO>> AddFullAsync(string email, TemporalOrderDTO temporalOrderDTO);

        Task<ActionResponse<TemporalOrder>> GetAsync(int id);

        Task<ActionResponse<IEnumerable<TemporalOrder>>> GetAsync(string email);

        Task<ActionResponse<int>> GetCountAsync(string email);

        Task<ActionResponse<TemporalOrder>> PutFullAsync(TemporalOrderDTO temporalOrderDTO);

    }
}
