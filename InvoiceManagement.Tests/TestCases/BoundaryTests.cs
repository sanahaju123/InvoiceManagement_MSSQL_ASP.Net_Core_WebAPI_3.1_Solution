
using InvoiceManagement.BusinessLayer.Interfaces;
using InvoiceManagement.BusinessLayer.Services.Repository;
using InvoiceManagement.BusinessLayer.Services;
using InvoiceManagement.BusinessLayer.ViewModels;
using InvoiceManagement.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace InvoiceManagement.Tests.TestCases
{
    public class BoundaryTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IInvoiceService _insuranceService;
        public readonly Mock<IInvoiceRepository> insuranceservice = new Mock<IInvoiceRepository>();

        private readonly Invoice _Invoice;
        private readonly InvoiceViewModel _InvoiceViewModel;

        private static string type = "Boundary";

        public BoundaryTests(ITestOutputHelper output)
        {
            _insuranceService = new InvoiceService(insuranceservice.Object);

            _output = output;

            _Invoice = new Invoice
            {
                InvoiceId = 1,
                CustomerId = 11,
                EndDate = DateTime.Now,
                StartDate = DateTime.Now,
                IsActive = true,
                InvoiceNumber = "HI123",
                InvoiceType = "Home Insurance",
                Amount = 12000
            };

            _InvoiceViewModel = new InvoiceViewModel
            {
                InvoiceId = 1,
                CustomerId = 11,
                EndDate = DateTime.Now,
                StartDate = DateTime.Now,
                IsActive = true,
                InvoiceNumber = "HI123",
                InvoiceType = "Home Insurance",
                Amount = 12000
            };
        }


        [Fact]
        public async Task<bool> Testfor_InvoiceNumber_NotEmpty()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                insuranceservice.Setup(repo => repo.CreateInvoice(_Invoice)).ReturnsAsync(_Invoice);
                var result = await  _insuranceService.CreateInvoice(_Invoice);
                var actualLength = _Invoice.InvoiceNumber.ToString().Length;
                if (result.InvoiceNumber.ToString().Length == actualLength)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }
       
        [Fact]
        public async Task<bool> Testfor_Amount_NotEmpty()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                insuranceservice.Setup(repo => repo.CreateInvoice(_Invoice)).ReturnsAsync(_Invoice);
                var result = await  _insuranceService.CreateInvoice(_Invoice);
                var actualLength = _Invoice.Amount.ToString().Length;
                if (result.Amount.ToString().Length == actualLength)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_CustomerId_NotEmpty()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                insuranceservice.Setup(repo => repo.CreateInvoice(_Invoice)).ReturnsAsync(_Invoice);
                var result = await _insuranceService.CreateInvoice(_Invoice);
                var actualLength = _Invoice.CustomerId.ToString().Length;
                if (result.CustomerId.ToString().Length == actualLength)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_InvoiceId_NotEmpty()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                insuranceservice.Setup(repo => repo.CreateInvoice(_Invoice)).ReturnsAsync(_Invoice);
                var result = await  _insuranceService.CreateInvoice(_Invoice);
                var actualLength = _Invoice.InvoiceId.ToString().Length;
                if (result.InvoiceId.ToString().Length == actualLength)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_InvoiceType_NotEmpty()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                insuranceservice.Setup(repo => repo.CreateInvoice(_Invoice)).ReturnsAsync(_Invoice);
                var result = await _insuranceService.CreateInvoice(_Invoice);
                var actualLength = _Invoice.InvoiceType.ToString().Length;
                if (result.InvoiceType.ToString().Length == actualLength)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_StartDate_NotEmpty()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                insuranceservice.Setup(repo => repo.CreateInvoice(_Invoice)).ReturnsAsync(_Invoice);
                var result = await _insuranceService.CreateInvoice(_Invoice);
                var actualLength = _Invoice.StartDate.ToString().Length;
                if (result.StartDate.ToString().Length == actualLength)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

    }
}