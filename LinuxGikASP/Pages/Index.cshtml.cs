using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrismSharp.Core;


namespace LinuxGikASP.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string CodeStyle(string inCode)
        {
            string h2 = "<h2>", endh2 = "</h2>";

            return h2 + inCode + endh2;
        }
        public void OnGet()
        {

        }
    }
}
