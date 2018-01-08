using FilterSorting.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace FilterSorting.Controllers
{
    public class RpItemsServiceController : ApiController
    {
        IEnumerable<ItemsWithDetailModel> GetItemsWithDetail()
        {
            // create some data 
            var data = new List<ItemsWithDetailModel>()
            {
                new ItemsWithDetailModel(){
                    Id = 1,
                    AccountName = "Test1",
                    AccountNumber = "1234",
                    Assigned1 = "Gene Smith",
                    Assigned2 = "Peter Deutch",
                    CloseDate = new DateTime(2012, 10, 2),
                    OpenDate = DateTime.Now,
                    Rep = "Rep1",
                    IssueSummary = "Summary1",
                    Status = "Status1",
                    FaName = "Ashwini Perkins"
                },
                new ItemsWithDetailModel(){
                    Id = 2,
                    AccountName = "Test2",
                    AccountNumber = "4321",
                    Assigned1 = "Lien Smith",
                    Assigned2 = "Anthony Deutch",
                    CloseDate = new DateTime(2011, 11, 12),
                    OpenDate = DateTime.Now,
                    Rep = "Rep2",
                    IssueSummary = "Latest Summary",
                    Status = "Status2",
                    FaName = "Lisa Carlson"
                },
                new ItemsWithDetailModel(){
                    Id = 3,
                    AccountName = "Test3",
                    AccountNumber = "3412",
                    Assigned1 = "Jenny Boroda",
                    Assigned2 = "Lien Smith",
                    CloseDate = new DateTime(2013, 4, 24),
                    OpenDate = DateTime.Now,
                    Rep = "Rep3",
                    IssueSummary = "This is a summary",
                    Status = "Status3",
                    FaName = "Ashwini Perkins"
                },
                new ItemsWithDetailModel()
                {
                    Id = 4,
                    AccountName = "Test4",
                    AccountNumber = "54346789",
                    Assigned1 = "Peter Smith",
                    Assigned2 = "Gene Deutch",
                    CloseDate = new DateTime(2010, 11, 22),
                    OpenDate = DateTime.Now,
                    Rep = "Rep5",
                    IssueSummary = "Where is the summary?",
                    Status = "Status4",
                    FaName = "Noname Perkins"
                },
                  new ItemsWithDetailModel(){
                    Id = 1,
                    AccountName = "Test5",
                    AccountNumber = "1234",
                    Assigned1 = "Gene Smith",
                    Assigned2 = "Peter Deutch",
                    CloseDate = new DateTime(2012, 10, 2),
                    OpenDate = DateTime.Now,
                    Rep = "Rep1",
                    IssueSummary = "Summary1",
                    Status = "Status1",
                    FaName = "Ashwini Perkins"
                },
                    new ItemsWithDetailModel(){
                    Id = 1,
                    AccountName = "Test6",
                    AccountNumber = "1234",
                    Assigned1 = "Gene Smith",
                    Assigned2 = "Peter Deutch",
                    CloseDate = new DateTime(2012, 10, 2),
                    OpenDate = DateTime.Now,
                    Rep = "Rep1",
                    IssueSummary = "Summary1",
                    Status = "Status1",
                    FaName = "Ashwini Perkins"
                },
                      new ItemsWithDetailModel(){
                    Id = 1,
                    AccountName = "Test7",
                    AccountNumber = "1234",
                    Assigned1 = "Gene Smith",
                    Assigned2 = "Peter Deutch",
                    CloseDate = new DateTime(2012, 10, 2),
                    OpenDate = DateTime.Now,
                    Rep = "Rep1",
                    IssueSummary = "Summary1",
                    Status = "Status1",
                    FaName = "Ashwini Perkins"
                },
                    new ItemsWithDetailModel(){
                    Id = 1,
                    AccountName = "Test8",
                    AccountNumber = "1234",
                    Assigned1 = "Gene Smith",
                    Assigned2 = "Peter Deutch",
                    CloseDate = new DateTime(2012, 10, 2),
                    OpenDate = DateTime.Now,
                    Rep = "Rep1",
                    IssueSummary = "Summary1",
                    Status = "Status1",
                    FaName = "Ashwini Perkins"
                },
                    new ItemsWithDetailModel(){
                    Id = 1,
                    AccountName = "Test9",
                    AccountNumber = "1234",
                    Assigned1 = "Gene Smith",
                    Assigned2 = "Peter Deutch",
                    CloseDate = new DateTime(2012, 10, 2),
                    OpenDate = DateTime.Now,
                    Rep = "Rep1",
                    IssueSummary = "Summary1",
                    Status = "Status1",
                    FaName = "Ashwini Perkins"
                },
            };
            return data;
        }

        public DataSourceResult GetRpItems([System.Web.Http.ModelBinding.ModelBinder(typeof(WebApiDataSourceRequestModelBinder))]DataSourceRequest request)
        {
            var q = GetItemsWithDetail();
            return q.ToDataSourceResult(request);
        }

    }
}
