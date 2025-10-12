using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryAPI.Data;
using InventoryAPI.DTOs;
using InventoryAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace InventoryAPI.Services
{
    public class InvoiceService
    {
        private readonly ApplicationDbContext _context;

        public InvoiceService(ApplicationDbContext context)
        {
            _context = context;
        }

        // --- Get All Invoices with Employee and Details ---
        public async Task<List<InvoiceDto>> GetAllInvoicesAsync()
        {
            var invoices = await _context.Invoices
                .Include(i => i.Employee)
                .Include(i => i.InvoiceDetails)
                    .ThenInclude(d => d.Product)
                .Select(i => new InvoiceDto
                {
                    InvoiceID = i.InvoiceID,
                    CustomerName = i.CustomerName,
                    CustomerPhone = i.CustomerPhone,
                    EmployeeName = i.Employee.EmployeeName,
                    EmployeeID = i.Employee.EmployeeID,
                    OrderDate = i.OrderDate,
                    TotalAmount = i.TotalAmount,
                    Details = i.InvoiceDetails.Select(d => new InvoiceDetailDto
                    {
                        ProductName = d.Product.ProductName,
                        Quantity = d.Quantity,
                        UnitPrice = d.UnitPrice
                    }).ToList()
                })
                .ToListAsync();

            return invoices;
        }

        // --- Get Invoice By ID ---
        public async Task<InvoiceDto?> GetInvoiceByIdAsync(int id)
        {
            var invoice = await _context.Invoices
                .Include(i => i.Employee)
                .Include(i => i.InvoiceDetails)
                    .ThenInclude(d => d.Product)
                .Where(i => i.InvoiceID == id)
                .Select(i => new InvoiceDto
                {
                    InvoiceID = i.InvoiceID,
                    CustomerName = i.CustomerName,
                    CustomerPhone = i.CustomerPhone,
                    EmployeeID = i.Employee.EmployeeID,
                    EmployeeName = i.Employee.EmployeeName,
                    OrderDate = i.OrderDate,
                    TotalAmount = i.TotalAmount,
                    Details = i.InvoiceDetails.Select(d => new InvoiceDetailDto
                    {
                        ProductName = d.Product.ProductName,
                        Quantity = d.Quantity,
                        UnitPrice = d.UnitPrice
                    }).ToList()
                })
                .FirstOrDefaultAsync();

            return invoice;
        }
        public async Task<InvoiceDto> CreateInvoiceAsync(CreateInvoiceDto dto)
        {
            if (dto.Details == null || !dto.Details.Any())
                throw new ArgumentException("Invoice must have at least one detail.");

            var invoice = new Invoice
            {
                CustomerName = dto.CustomerName,
                CustomerPhone = dto.CustomerPhone,
                EmployeeID = dto.EmployeeID,
                OrderDate = DateTime.Now,
                TotalAmount = dto.Details.Sum(d => d.Quantity * d.UnitPrice),
                InvoiceDetails = dto.Details.Select(d => new InvoiceDetail
                {
                    ProductID = d.ProductID,
                    Quantity = d.Quantity,
                    UnitPrice = d.UnitPrice
                }).ToList()
            };

            _context.Invoices.Add(invoice);
            await _context.SaveChangesAsync();

            // Reload with Employee and Product for proper DTO mapping
            var savedInvoice = await _context.Invoices
                .Include(i => i.Employee)
                .Include(i => i.InvoiceDetails)
                    .ThenInclude(d => d.Product)
                .FirstOrDefaultAsync(i => i.InvoiceID == invoice.InvoiceID);

            if (savedInvoice == null)
                throw new Exception("Failed to load saved invoice.");

            // Map to DTO
            var result = new InvoiceDto
            {
                InvoiceID = savedInvoice.InvoiceID,
                CustomerName = savedInvoice.CustomerName,
                CustomerPhone = savedInvoice.CustomerPhone,
                EmployeeID = savedInvoice.EmployeeID,
                EmployeeName = savedInvoice.Employee.EmployeeName,
                OrderDate = savedInvoice.OrderDate,
                TotalAmount = savedInvoice.TotalAmount,
                Details = savedInvoice.InvoiceDetails.Select(d => new InvoiceDetailDto
                {
                    ProductName = d.Product.ProductName,
                    Quantity = d.Quantity,
                    UnitPrice = d.UnitPrice
                }).ToList()
            };

            return result;
        }


    }
}
