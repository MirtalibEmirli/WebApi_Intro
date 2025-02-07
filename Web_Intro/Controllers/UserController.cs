using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Intro.DTO;
using Web_Intro.Entities;

namespace Web_Intro.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    List<User> userList = new()
      {
          new User  {Id="a22b3c01-03b2-42d0-bb7b-474566c77cbd",FirstName="adil",LastName="aliyev",Email="adil@gmail.com",Age=20},
          new User  {Id="ebf3c6d4-0bf3-4beb-9135-4eaa639e32d1",FirstName="Taleh",LastName="Haciyev",Email="taleh@gmail.com",Age=25},
          new User  {Id="4bdcec44-0a33-43c1-80ae-5bf67bfbc45f",FirstName="ali",LastName="adilov",Email="ali@gmail.com",Age=20}
      };

    [HttpGet]
    [Route("userlist")]
    public List<User> GetList()
    {
        return userList;
    }


    [HttpGet]
    [Route("getbyid")]
    public User GetById(string guid)
    {
        return userList.FirstOrDefault(u => u.Id == guid);
    }


    [HttpPost]
    public List<User>  Add([FromBody] User user)
    {
        userList.Add(user);
        return userList;
    }


    [HttpPut("{id}")]
    public List<User> Update(string id,UpdateUserDto updateUserDto)
    {
        var currentUser = userList.FirstOrDefault(u => u.Id == id);
        currentUser.FirstName = updateUserDto.Name;
        currentUser.LastName = updateUserDto.LastName;
       
        return userList;
    }
    [HttpDelete]
    public List<User> Delete(string id)
    {
        var currentUser = userList.FirstOrDefault(u => u.Id == id);
        userList.Remove(currentUser);
        return userList;
    }


}