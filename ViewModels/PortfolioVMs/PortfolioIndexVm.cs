using EternaTask.Models;

namespace EternaTask.ViewModels.PortfolioVMs
{
    public class PortfolioIndexVm
    {
        public List<Client>? _clients { get; set; }
        public List<Portfolio>? _portfolios { get; set; }
        public List<Category>? _categories { get; set; }
    }
}
