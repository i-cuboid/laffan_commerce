using Grand.Domain.Catalog;
using Grand.Domain.Directory;

namespace Grand.Business.Core.Interfaces.Catalog.Prices
{
    public interface IPriceFormatter
    {
        /// <summary>
        /// Formats price
        /// </summary>
        /// <param name="price">Price</param>
        /// <returns>Price</returns>
        string FormatPrice(double price);

        /// <summary>
        /// Formats price
        /// </summary>
        /// <param name="price">Price</param>
        /// <param name="targetCurrency">Target currency</param>
        /// <returns>Price</returns>
        string FormatPrice(double price, Currency targetCurrency);
        
        /// <summary>
        /// Resource name of rental product (rental period)
        /// </summary>
        /// <param name="product">Product</param>
        /// <returns>Rental product price with period</returns>
        string ResourceReservationProductPeriod(Product product);


        /// <summary>
        /// Formats a tax rate
        /// </summary>
        /// <param name="taxRate">Tax rate</param>
        /// <returns>Formatted tax rate</returns>
        string FormatTaxRate(double taxRate);
    }
}
