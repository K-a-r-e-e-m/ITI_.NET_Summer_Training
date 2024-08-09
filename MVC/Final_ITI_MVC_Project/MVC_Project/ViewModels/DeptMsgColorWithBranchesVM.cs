namespace MVC_Project.ViewModels
{
    public class DeptMsgColorWithBranchesVM
    {
        public string Department { get; set; }
        public string Manager { get; set; }
        public string Message { get; set; }
        public string Color { get; set; }
        public int TraineesNumber { get; set; }
        public List<string> Branches { get; set; } = new List<string>();
    }
}
