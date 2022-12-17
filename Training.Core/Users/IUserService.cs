namespace Training.Core.Users;

public interface IUserService
{
    void CreateUser(UserDto user);

    IEnumerable<UserDto> GetUsers(string rol);
}