using Grand.Infrastructure.Plugins;
using Payments.CashOnDelivery;

[assembly: PluginInfo(
    FriendlyName = "Cash On Delivery (COD)",
    Group = "Payment methods",
    SystemName = CashOnDeliveryPaymentDefaults.ProviderSystemName,
    Author = "iCuboid team",
    Version = "2.1.1"
)]