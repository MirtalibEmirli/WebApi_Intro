namespace Web_Intro.DTO;

public record struct  UpdateUserDto
{
    public string Name { get; set; }
    public string LastName { get; set; }
}
