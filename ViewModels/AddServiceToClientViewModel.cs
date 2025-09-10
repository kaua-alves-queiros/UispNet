namespace UispNet.ViewModels;

public class AddServiceToClientViewModel
{
    public bool? Prepaid { get; set; }
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
    public DateTime? ActiveFrom { get; set; }
    public DateTime? ActiveTo { get; set; }
    public DateTime? ContractEndDate { get; set; }
    public int? DiscountType { get; set; }
    public decimal? DiscountValue { get; set; }
    public string? DiscountInvoiceLabel { get; set; }
    public DateTime? DiscountFrom { get; set; }
    public DateTime? DiscountTo { get; set; }
    public int? Tax1Id { get; set; }
    public int? Tax2Id { get; set; }
    public int? Tax3Id { get; set; }
    public DateTime? InvoicingStart { get; set; }
    public int? InvoicingPeriodType { get; set; }
    public int? InvoicingPeriodStartDay { get; set; }
    public int? NextInvoicingDayAdjustment { get; set; }
    public bool? InvoicingProratedSeparately { get; set; }
    public bool? InvoicingSeparately { get; set; }
    public bool? SendEmailsAutomatically { get; set; }
    public bool? UseCreditAutomatically { get; set; }
    public int? FccBlockId { get; set; }
    public List<object>? Attributes { get; set; }
    public object? AddressData { get; set; }
    public decimal? SetupFeePrice { get; set; }
    public decimal? EarlyTerminationFeePrice { get; set; }
    public int? ServicePlanGroupId { get; set; }
}