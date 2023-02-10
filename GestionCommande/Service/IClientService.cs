using Dto;

namespace Service
{
    public interface IClientService
    {
        Task<int> Create(ClientCreateDto obj);
    }
}