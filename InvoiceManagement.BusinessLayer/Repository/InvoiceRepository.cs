using InvoiceManagement.BusinessLayer.ViewModels;
using InvoiceManagement.DataLayer;
using InvoiceManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.BusinessLayer.Services.Repository
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly InvoiceDbContext _dbContext;
        public InvoiceRepository(InvoiceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Invoice> CreateInvoice(Invoice Invoice)
        {
            try
            {
                var result = await _dbContext.Invoices.AddAsync(Invoice);
                await _dbContext.SaveChangesAsync();
                return Invoice;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<bool> DeleteInvoiceById(int id)
        {
            try
            {
                _dbContext.Remove(_dbContext.Invoices.Single(a => a.InvoiceId == id));
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public List<Invoice> GetAllInvoices()
        {
            try
            {
                var result = _dbContext.Invoices.
                OrderByDescending(x => x.InvoiceId).Take(10).ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<Invoice> GetInvoiceById(int id)
        {
            try
            {
                return await _dbContext.Invoices.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<Invoice> UpdateInvoice(InvoiceViewModel model)
        {
            var feature = await _dbContext.Invoices.FindAsync(model.InvoiceId);
            try
            {
                _dbContext.Invoices.Update(feature);
                await _dbContext.SaveChangesAsync();
                return feature;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}