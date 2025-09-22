using Microsoft.AspNetCore.Mvc;
using Backend.DTO;

namespace Backend.Controllers;

[Route("contact")]
[ApiController]
public class ContactController : ControllerBase
{
    private List<string> namen = new List<string>()
    {
        "Vitali","Tasi","Coralie","Yumi"
    };

    //GET
    [HttpGet]
    public async Task<List<string>> getData()
    {
        return namen;
    }
    //POST

    //PUT

    //DELETE
}