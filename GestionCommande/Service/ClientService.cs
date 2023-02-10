using DAL.Models;
using Dto;
using Infrastructure.SeedWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ClientService : BaseService, IClientService
    {
        private readonly IRepository<TClient> _clientRepo;

        public ClientService(
            IRepository<TClient> clientRepo,
            IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _clientRepo = clientRepo;
        }



        //public async Task<Client> Get(int id)
        //{
        //    return await _basketRepo.GetAsync(id);
        //}

        public async Task<int> Create(ClientCreateDto obj)
        {
            var m = new TClient()
            {
                Adresse = obj.Adresse,
                Id = obj.Id,
                Client = obj.Nom
            };
            //var basket = new Basket(userId);
            _clientRepo.Add(m);
            await UnitOfWork.SaveChangeAsync();
            return m.Id;
        }

        public async Task<int> GetList(ClientCreateDto obj)
        {
            var m = new TClient()
            {
                Adresse = obj.Adresse,
                Id = obj.Id,
                Client = obj.Nom
            };
            //var basket = new Basket(userId);
            _clientRepo.Add(m);
            await UnitOfWork.SaveChangeAsync();
            return m.Id;
        }

        //public async Task AddItem(int basketId, int productId)
        //{
        //    var basket = await _basketRepo.GetAsync(basketId);
        //    var productItem = basket.Products.FirstOrDefault(_ => _.Product.Id == productId);
        //    if (productItem == null)
        //    {
        //        var product = await _productRepo.GetAsync(productId);
        //        productItem = new BasketProductItem(product);
        //        basket.Products.Add(productItem);
        //    }
        //    else
        //    {
        //        productItem.Quantity += 1;
        //    }

        //    await UnitOfWork.SaveChangeAsync();
        //}

        //public async Task RemoveItem(int basketId, int itemId)
        //{
        //    var basket = await _basketRepo.GetAsync(basketId);
        //    var productItem = basket.Products.FirstOrDefault(_ => _.Id == itemId);
        //    if (productItem != null)
        //    {
        //        basket.Products.Remove(productItem);
        //        await UnitOfWork.SaveChangeAsync();
        //    }
        //}

        //public async Task MarkAsResolved(int basketId)
        //{
        //    var basket = await _basketRepo.GetAsync(basketId);
        //    basket.IsCheckedOut = true;
        //    await UnitOfWork.SaveChangeAsync();
        //}
    }
}
