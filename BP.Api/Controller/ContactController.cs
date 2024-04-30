using System;
using BP.Api.Models;
using BP.Api.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BP.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private readonly IContactService contactService;


        public ContactController(IConfiguration Configuration,IContactService ContactService)
        {
            configuration = Configuration;
            contactService = ContactService;
        }

        [HttpGet]
        public String Get()
        {
            return configuration["ReadMe"].ToString();
        }

        [HttpGet("{id}")]
        public ContactDVO GetContactById(int id)
        {
            return contactService.GetContactById(id);
        }
    }
}
