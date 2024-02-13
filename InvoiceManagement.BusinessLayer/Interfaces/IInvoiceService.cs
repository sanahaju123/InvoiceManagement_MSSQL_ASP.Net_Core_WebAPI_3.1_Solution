using InvoiceManagement.BusinessLayer.ViewModels;
using InvoiceManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.BusinessLayer.Interfaces
{
    public interface IInvoiceService
    {
        List<Invoice> GetAllInvoices();
        Task<Invoice> CreateInvoice(Invoice Invoice);
        Task<Invoice> GetInvoiceById(int id);
        Task<bool> DeleteInvoiceById(int id);
        Task<Invoice> UpdateInvoice(InvoiceViewModel model);
    }
}
