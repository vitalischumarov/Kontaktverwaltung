using Microsoft.AspNetCore.Mvc;
using Backend.Models;
using Backend.Data;

namespace Backend.Controllers;

[Route("contact")]
[ApiController]
public class ContactController : ControllerBase
{
    private DbContactContext context = new DbContactContext();

    //GET
    [HttpGet]
    public async Task<List<Contact>> getData()
    {
        var contacts = context.Contacts.ToList();
        return contacts;
    }

    [HttpGet("{id}")]
    public async Task<Contact> getData(int id)
    {
        return context.Contacts.Find(id);
    }
    //POST
    [HttpPost]
    public IActionResult PostData([FromBody] Contact contact)
    {
        context.Contacts.Add(contact);
        context.SaveChanges();
        return Ok("Data created");
    }
    
    //PUT

    //DELETE
    [HttpDelete]
    public IActionResult DeleteData([FromBody] Contact contact)
    {
        context.Contacts.Remove(contact);
        context.SaveChanges();
        return Ok("Data deleted");
    }
    
}