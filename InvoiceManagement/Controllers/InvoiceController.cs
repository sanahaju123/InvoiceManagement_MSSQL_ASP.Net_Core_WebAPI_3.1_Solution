using InvoiceManagement.BusinessLayer.Interfaces;
using InvoiceManagement.BusinessLayer.ViewModels;
using InvoiceManagement.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InvoiceManagement.Controllers
{
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _InvoiceService;
        public InvoiceController(IInvoiceService InvoiceService)
        {
            _InvoiceService = InvoiceService;
        }

        [HttpPost]
        [Route("create-Invoice")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateInvoice([FromBody] Invoice model)
        {
            var InvoiceExists = await _InvoiceService.GetInvoiceById(model.InvoiceId);
            if (InvoiceExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Invoice already exists!" });
            var result = await _InvoiceService.CreateInvoice(model);
            if (result == null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Invoice creation failed! Please check details and try again." });

            return Ok(new Response { Status = "Success", Message = "Invoice created successfully!" });

        }


        [HttpPut]
        [Route("update-Invoice")]
        public async Task<IActionResult> UpdateInvoice([FromBody] InvoiceViewModel model)
        {
            var Invoice = await _InvoiceService.UpdateInvoice(model);
            if (Invoice == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response
                { Status = "Error", Message = $"Invoice With Id = {model.InvoiceId} cannot be found" });
            }
            else
            {
                var result = await _InvoiceService.UpdateInvoice(model);
                return Ok(new Response { Status = "Success", Message = "Invoice updated successfully!" });
            }
        }

        [HttpDelete]
        [Route("delete-Invoice")]
        public async Task<IActionResult> DeleteInvoice(int id)
        {
            var Invoice = await _InvoiceService.GetInvoiceById(id);
            if (Invoice == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response
                { Status = "Error", Message = $"Invoice With Id = {id} cannot be found" });
            }
            else
            {
                var result = await _InvoiceService.DeleteInvoiceById(id);
                return Ok(new Response { Status = "Success", Message = "Invoice deleted successfully!" });
            }
        }


        [HttpGet]
        [Route("get-Invoice-by-id")]
        public async Task<IActionResult> GetInvoiceById(int id)
        {
            var Invoice = await _InvoiceService.GetInvoiceById(id);
            if (Invoice == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response
                { Status = "Error", Message = $"Invoice With Id = {id} cannot be found" });
            }
            else
            {
                return Ok(Invoice);
            }
        }

        [HttpGet]
        [Route("get-all-Invoices")]
        public async Task<IEnumerable<Invoice>> GetAllInvoices()
        {
            return _InvoiceService.GetAllInvoices();
        }
    }
}