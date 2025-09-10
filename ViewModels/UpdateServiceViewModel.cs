namespace UispNet.ViewModels;

public class UpdateServiceViewModel
{
    public int? ServicePlanPeriodId { get; set; }
    public string? Name { get; set; }
    public string? FullAddress { get; set; }
    public string? Street1 { get; set; }
    public string? Street2 { get; set; }
    public string? City { get; set; }
    public int? CountryId { get; set; }
    public int? StateId { get; set; }
    public string? ZipCode { get; set; }
    public string? Note { get; set; }
    public double? AddressGpsLat { get; set; }
    public double? AddressGpsLon { get; set; }
    public decimal? Price { get; set; }
    public string? InvoiceLabel { get; set; }
    public int? ContractId { get; set; }
    public int? ContractLengthType { get; set; }
    public int? MinimumContractLengthMonths { get; set; }
    public DateTime? ActiveTo { get; set; }
    public DateTime? ContractEndDate { get; set; }
    public int? DiscountType { get; set; }
    public decimal? DiscountValue { get; set; }
    public string? DiscountInvoiceLabel { get; set; }
    public DateTime? DiscountFrom { get; set; }
    public DateTime? DiscountTo { get; set; }
    public int? InvoicingPeriodType { get; set; }
    public int? NextInvoicingDayAdjustment { get; set; }
    public bool? InvoicingSeparately { get; set; }
    public bool? SendEmailsAutomatically { get; set; }
    public bool? UseCreditAutomatically { get; set; }
    public int? FccBlockId { get; set; }
    public List<object>? Attributes { get; set; }
    public object? AddressData { get; set; }
    public decimal? SetupFeePrice { get; set; }
    public decimal? EarlyTerminationFeePrice { get; set; }
    public int? ServicePlanGroupId { get; set; }

    public static UpdateServiceViewModel FromViewModel(ServiceViewModel service)
    {
        return new UpdateServiceViewModel
        {
            ServicePlanPeriodId = service.ServicePlanPeriodId,
            Name = service.Name,
            FullAddress = service.FullAddress,
            Street1 = service.Street1,
            Street2 = service.Street2,
            City = service.City,
            CountryId = service.CountryId,
            StateId = service.StateId,
            ZipCode = service.ZipCode,
            Note = service.Note,
            AddressGpsLat = service.AddressGpsLat,
            AddressGpsLon = service.AddressGpsLon,
            Price = service.Price,
            InvoiceLabel = service.InvoiceLabel,
            ContractId = service.ContractId,
            ContractLengthType = service.ContractLengthType,
            MinimumContractLengthMonths = service.MinimumContractLengthMonths,
            ActiveTo = service.ActiveTo,
            ContractEndDate = service.ContractEndDate,
            DiscountType = service.DiscountType,
            DiscountValue = service.DiscountValue,
            DiscountInvoiceLabel = service.DiscountInvoiceLabel,
            DiscountFrom = service.DiscountFrom,
            DiscountTo = service.DiscountTo,
            InvoicingPeriodType = service.InvoicingPeriodType,
            NextInvoicingDayAdjustment = service.NextInvoicingDayAdjustment,
            InvoicingSeparately = service.InvoicingSeparately,
            SendEmailsAutomatically = service.SendEmailsAutomatically,
            UseCreditAutomatically = service.UseCreditAutomatically,
            FccBlockId = service.FccBlockId,
            Attributes = service.Attributes,
            AddressData = service.AddressData,
            SetupFeePrice = service.SetupFeePrice,
            EarlyTerminationFeePrice = service.EarlyTerminationFeePrice,
            ServicePlanGroupId = service.ServicePlanGroupId
        };
    }

    public static UpdateServiceViewModel FromAddService(AddServiceToClientViewModel service)
    {
        return new UpdateServiceViewModel
        {
            ServicePlanPeriodId = service.ServicePlanPeriodId,
            Name = service.Name,
            FullAddress = service.FullAddress,
            Street1 = service.Street1,
            Street2 = service.Street2,
            City = service.City,
            CountryId = service.CountryId,
            StateId = service.StateId,
            ZipCode = service.ZipCode,
            Note = service.Note,
            AddressGpsLat = service.AddressGpsLat,
            AddressGpsLon = service.AddressGpsLon,
            Price = service.Price,
            InvoiceLabel = service.InvoiceLabel,
            ContractId = service.ContractId,
            ContractLengthType = service.ContractLengthType,
            MinimumContractLengthMonths = service.MinimumContractLengthMonths,
            ActiveTo = service.ActiveTo,
            ContractEndDate = service.ContractEndDate,
            DiscountType = service.DiscountType,
            DiscountValue = service.DiscountValue,
            DiscountInvoiceLabel = service.DiscountInvoiceLabel,
            DiscountFrom = service.DiscountFrom,
            DiscountTo = service.DiscountTo,
            InvoicingPeriodType = service.InvoicingPeriodType,
            NextInvoicingDayAdjustment = service.NextInvoicingDayAdjustment,
            InvoicingSeparately = service.InvoicingSeparately,
            SendEmailsAutomatically = service.SendEmailsAutomatically,
            UseCreditAutomatically = service.UseCreditAutomatically,
            FccBlockId = service.FccBlockId,
            Attributes = service.Attributes,
            AddressData = service.AddressData,
            SetupFeePrice = service.SetupFeePrice,
            EarlyTerminationFeePrice = service.EarlyTerminationFeePrice,
            ServicePlanGroupId = service.ServicePlanGroupId
        };
    }
}