using Dto;

namespace Service
{
    public interface IClientService
    {
        Task<ClientCreateDto> Create(int userId);
    }
}