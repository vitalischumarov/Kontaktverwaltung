using Microsoft.AspNetCore.Mvc;
using Backend.Models;
using Backend.Data;

namespace Backend.Controllers;

[Route("contact")]
[ApiController]
public class ContactController : ControllerBase
{
    private DbContactContext context = new DbContactContext();
    private List<string> namen = new List<string>()
    {
        "Vitali","Tasi","Coralie","Yumi"
    };

    //GET
    [HttpGet]
    public async Task<List<Contact>> getData()
    {
        var contacts = context.Contacts.ToList();
        return contacts;
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
}