using PropertyChanged;

namespace Tasker.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Task
    {
        public string TaskName { get; set; }
        public bool Completed { get; set; }
        public int CategoryId { get; set; }
        public string TaskColor { get; set; }
    }
}
