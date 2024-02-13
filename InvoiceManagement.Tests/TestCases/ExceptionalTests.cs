

using InvoiceManagement.BusinessLayer.Interfaces;
using InvoiceManagement.BusinessLayer.Services.Repository;
using InvoiceManagement.BusinessLayer.Services;
using InvoiceManagement.BusinessLayer.ViewModels;
using InvoiceManagement.Entities;
using Moq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace InvoiceManagement.Tests.TestCases
{
    public class ExceptionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IInvoiceService _insuranceService;
        public readonly Mock<IInvoiceRepository> insuranceservice = new Mock<IInvoiceRepository>();

        private readonly Invoice _Invoice;
        private readonly InvoiceViewModel _InvoiceViewModel;

        private static string type = "Exception";

        public ExceptionalTests(ITestOutputHelper output)
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
        public async Task<bool> Testfor_Validate_IfInvalidInvoiceIdIsPassed()
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
                if (result != null || result.InvoiceId !=0)
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
        public async Task<bool> Testfor_Validate_IfInvalidCustomerIdIsPassed()
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
                if (result != null || result.CustomerId != 0)
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
        public async Task<bool> Testfor_Validate_IfInvalidInvoiceNumberIsPassed()
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
                if (result != null || result.InvoiceNumber != null)
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
        public async Task<bool> Testfor_Validate_IfInvalidInvoiceTypeIsPassed()
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
        public async Task<bool> Testfor_Validate_IfInvalidStartDateIsPassed()
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
