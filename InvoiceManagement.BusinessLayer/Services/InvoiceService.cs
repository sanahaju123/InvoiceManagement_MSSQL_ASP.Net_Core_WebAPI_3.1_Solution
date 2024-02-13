using InvoiceManagement.BusinessLayer.Interfaces;
using InvoiceManagement.BusinessLayer.Services.Repository;
using InvoiceManagement.BusinessLayer.ViewModels;
using InvoiceManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.BusinessLayer.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _InvoiceRepository;

        public InvoiceService(IInvoiceRepository InvoiceRepository)
        {
            _InvoiceRepository = InvoiceRepository;
        }

        public async Task<Invoice> CreateInvoice(Invoice Invoice)
        {
            return await _InvoiceRepository.CreateInvoice(Invoice);
        }

        public async Task<bool> DeleteInvoiceById(int id)
        {
            return await _InvoiceRepository.DeleteInvoiceById(id);
        }

        public List<Invoice> GetAllInvoices()
        {
            return _InvoiceRepository.GetAllInvoices();
        }

        public async Task<Invoice> GetInvoiceById(int id)
        {
            return await _InvoiceRepository.GetInvoiceById(id);
        }

        public async Task<Invoice> UpdateInvoice(InvoiceViewModel model)
        {
            return await _InvoiceRepository.UpdateInvoice(model);
        }
    }
}