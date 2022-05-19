namespace Authorization.Dtos
{
    public class UserDto
    {
        public string UserName { get; set; }
        public string Token { get; set; }
        public int success { get; set; } = 0;
    }
}
