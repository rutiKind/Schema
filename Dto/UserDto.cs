
namespace Dto
{
    public class UserDto
    {
        public int id { get; set; }
        private userTypedto userType { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
