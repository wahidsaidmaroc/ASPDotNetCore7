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

}
