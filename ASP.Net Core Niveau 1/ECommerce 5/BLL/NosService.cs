using DAL.Entity;
using DAL.Migrations;
using DAL.Repos;
using Models.Service;
using System.Collections.Generic;

namespace BLL;

public class NosService
{
    public List<ServiceListVM> ToList()
    {
        ServiceRepos serviceRepos = new ServiceRepos(); 

        List<ServiceListVM> listM = new List<ServiceListVM>();

        foreach (var item in serviceRepos.All())
        {
            ServiceListVM obj =  new ServiceListVM { Id = item.Id, Description = item.Description, Titre = item.Titre };

            listM.Add(obj);
        }


        return listM;
    }

    public ServiceDetailVM ToDetail(int id)
    {
        ServiceRepos serviceRepos = new ServiceRepos();
        var source = serviceRepos.Read(id);
        var obj = new ServiceDetailVM
        {
            DateCreation = DateTime.Now,
            Titre = source.Titre,
            Description = source.Description        };
        return obj;
    }

    public void AjouterService(AdminServiceCreateMV obj)
    {
        ServiceRepos serviceRepos = new ServiceRepos();
        Service service = new Service();
        service.Titre = obj.Titre;
        service.Description = obj.Description;

        serviceRepos.Create(service);
    }



    public List<Models.Service.AdminListService> ToListAdmin()
    {
        ServiceRepos serviceRepos = new ServiceRepos();

        List<Models.Service.AdminListService> listM = new List<Models.Service.AdminListService>();

        foreach (var item in serviceRepos.All())
        {
            var obj = new Models.Service.AdminListService { Id = item.Id, Titre = item.Titre };

            listM.Add(obj);
        }


        return listM;
    }

}
