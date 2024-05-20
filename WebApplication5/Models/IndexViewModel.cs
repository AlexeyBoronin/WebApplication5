namespace WebApplication5.Models
{
    public class IndexViewModel
    {
        public IEnumerable<User> Users { get; }
        public PageViewModel PageViewModel { get; }
        public IndexViewModel(IEnumerable<User> users, PageViewModel viewModel)
        {
            Users = users;
            PageViewModel = viewModel;
        }
    }
}
