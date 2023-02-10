using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ClientService : IClientService
    {
        //public async Task<Client> Get(int id)
        //{
        //    return await _basketRepo.GetAsync(id);
        //}

        public async Task<ClientCreateDto> Create(int userId)
        {
            //var basket = new Basket(userId);
            //_basketRepo.Add(basket);
            //await UnitOfWork.SaveChangeAsync();
            return null;
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
