﻿

using System.ComponentModel.DataAnnotations;

namespace EmployeesHrApi.Models;

public record EmployeesResponseModel
{
    public List<EmployeesSummaryResponseModel> Employees { get; set; } = new();
    public string ShowingDepartment { get; set; } = string.Empty;
}

public record EmployeesSummaryResponseModel
{
    public string Id { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
}

// GET /employees/{id}
public record EmployeeDetailsResponseModel 
{
    public string Id { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public string PhoneExtension { get; set; } = string.Empty;
}

public record EmployeeSalaryInformationResponse
{
   
    public decimal Salary { get; init; }
}

public record EmployeeSalaryInformationRequest
{
    [Required]
    public decimal? Salary { get; init; }
}