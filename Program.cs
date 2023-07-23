// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using ReositoryPattern.Models;
using ReositoryPattern.Repositories;
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");

using (var unitOfWork = new UnitOfWork(new ReositoryPattern.Persistence.SchoolContext()))
{
    var tanents = unitOfWork.TenantRepository.GetAll();
    //var tanents = unitOfWork.TenantRepository.GetTenantsByStatus("active");


    var filter = "{'PropertyName': 'id', 'Operator': '=', 'value': '1'}";
    var filterModel = JsonConvert.DeserializeObject<FilterModel>(filter);


    var parameterExp = Expression.Parameter(typeof(Tenant), "x");
    var propertyExp = Expression.Property(parameterExp, filterModel.PropertyName);
    var valueExp = Expression.Constant(filterModel.Value);
    var conditionExp = Expression.Equal(propertyExp, valueExp);

    var lambdaExp = Expression.Lambda<Func<Tenant, bool>>(conditionExp, parameterExp);

    //var filteredData = tanents.Where(lambdaExp);
}