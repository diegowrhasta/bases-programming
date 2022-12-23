using AutoMapper;
using DummyLibrary.Classes.Payloads;
using DummyLibrary.Interfaces;
using DummyLibrary.Lightweights;

namespace DummyLibrary.Classes;

public class EmployeeDataMediator : IMediator
{
    private readonly EmployeeBenefitsDataViewModel _benefitsDataViewModel;
    private readonly EmployeeDeductionsDataViewModel _deductionsDataViewModel;
    private readonly EmployeeFinancialDataViewModel _financialDataViewModel;
    private readonly EmployeeGeneralDataViewModel _generalDataViewModel;
    private readonly Mapper _mapper = new(DummyMapperConfiguration.Config);

    public EmployeeDataMediator(
        EmployeeBenefitsDataViewModel benefitsDataViewModel,
        EmployeeDeductionsDataViewModel deductionsDataViewModel,
        EmployeeFinancialDataViewModel financialDataViewModel,
        EmployeeGeneralDataViewModel generalDataViewModel)
    {
        _benefitsDataViewModel = benefitsDataViewModel;
        _benefitsDataViewModel.SetMediator(this);
        _deductionsDataViewModel = deductionsDataViewModel;
        _deductionsDataViewModel.SetMediator(this);
        _financialDataViewModel = financialDataViewModel;
        _financialDataViewModel.SetMediator(this);
        _generalDataViewModel = generalDataViewModel;
        _generalDataViewModel.SetMediator(this);
    }

    public void Send(MediatorEvent @event)
    {
        switch (@event)
        {
            case MediatorEvent.BenefitsRequest:
                var benefitsPayload = new BenefitsPayload
                {
                    FinancialGood = _financialDataViewModel.Good,
                    GeneralViews = _generalDataViewModel.Views,
                };
                _mapper.Map(benefitsPayload, _benefitsDataViewModel.PayLoad);
                break;
            case MediatorEvent.DeductionsRequest:
                var deductionsPayload = new DeductionsPayload
                {
                    GeneralGood = _generalDataViewModel.Good,
                };
                _mapper.Map(deductionsPayload, _deductionsDataViewModel.Payload);
                break;
            case MediatorEvent.FinancialRequest:
                var financialPayload = new FinancialPayload
                {
                    BenefitTotal = _benefitsDataViewModel.Total,
                    GeneralTitle = _generalDataViewModel.Title,
                };
                _mapper.Map(financialPayload, _financialDataViewModel.Payload);
                break;
            case MediatorEvent.GeneralRequest:
                var generalPayLoad = new GeneralPayload
                {
                    FinancialGood = _financialDataViewModel.Good,
                    BenefitsGood = _benefitsDataViewModel.Good,
                    DeductionsGood = _deductionsDataViewModel.Good,
                };
                _mapper.Map(generalPayLoad, _generalDataViewModel.Payload);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(@event), @event, null);
        }
    }
}