using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MapaPolski.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            /*
            < img class="Bialystok" src="~/image/miasto.png" />

            <img class="DojlidyGorne" src="~/image/dojlidy_górneq.png" />
            */
        }
    }
}