// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes;

var benefitsDataViewModel = new EmployeeBenefitsDataViewModel();
var deductionsDataViewModel = new EmployeeDeductionsDataViewModel();
var financialDataViewModel = new EmployeeFinancialDataViewModel();
var generalDataViewModel = new EmployeeGeneralDataViewModel();
var employeeDataMediator = new EmployeeDataMediator(benefitsDataViewModel, deductionsDataViewModel, financialDataViewModel, generalDataViewModel);
benefitsDataViewModel.DoLogic();
deductionsDataViewModel.DoLogic();
financialDataViewModel.DoLogic();
generalDataViewModel.DoLogic();