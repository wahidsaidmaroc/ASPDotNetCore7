using Models.Service;
using System.Net.Http.Headers;

namespace BLL.NosService;

public class NosService
{
    public List<ServiceListVM> ToList()
    {
        var List = new List<ServiceListVM>();
        for (int i = 0; i < 10; i++)
        {
            ServiceListVM m = new ServiceListVM { Id = i, Description = " This blog post shows a few different types of content that’s supported and styled with Bootstrap. Basic typography, lists, tables,*\r\n        images, code, and more are all supported as expected.", Titre = $"Titre {i}" };
            List.Add(m);
        }
        return List;
    }

    public ServiceDetailVM ToDetail() {
        var obj = new ServiceDetailVM
        {
            DateCreation = DateTime.Now,
            Titre = "Typography",
            Description = "Bootstrap sets basic global display, typography, and link styles. When more control is needed, check out the textual utility classes.\r\n\r\nUse a native font stack that selects the best font-family for each OS and device.\r\nFor a more inclusive and accessible type scale, we use the browser’s default root font-size (typically 16px) so visitors can customize their browser defaults as needed.\r\nUse the $font-family-base, $font-size-base, and $line-height-base attributes as our typographic base applied to the <body>.\r\nSet the global link color via $link-color.\r\nUse $body-bg to set a background-color on the <body> (#fff by default).\r\nThese styles can be found within _reboot.scss, and the global variables are defined in _variables.scss. Make sure to set $font-size-base in rem."
        };
        return obj;
    }

}
