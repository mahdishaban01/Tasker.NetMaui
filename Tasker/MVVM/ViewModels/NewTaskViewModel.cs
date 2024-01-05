using System.Collections.ObjectModel;
using Tasker.MVVM.Models;
using Task = Tasker.MVVM.Models.Task;

namespace Tasker.MVVM.ViewModels
{
    public class NewTaskViewModel
    {
        public string Task { get; set; }
        public ObservableCollection<Task> Tasks { get; set; }
        public ObservableCollection<Category> Categories { get; set; }
    }
}
