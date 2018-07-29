Number.prototype.formatMoney = function (decimalPlaces, decimalSymbol, thousandsSeparator, currencySymbol) {
    var num = this;
    decimalPlaces = isNaN(decimalPlaces = Math.abs(decimalPlaces)) ? 2 : decimalPlaces;
    decimalSymbol = decimalSymbol == undefined ? '.' : decimalSymbol;
    thousandsSeparator = thousandsSeparator == undefined ? ',' : thousandsSeparator;
    currencySymbol = currencySymbol == undefined ? '£' : currencySymbol;
    var s = num < 0 ? '-' : '';
    var i = parseInt(num = Math.abs(+num || 0).toFixed(c)) + '';
    var j = (j = i.length) > 3 ? j % 3 : 0;
    return currencySymbol + s + (j ? i.substr(0, j) + t : '') + i.substr(j).replace(/(\d{3})(?=\d)/g, '$1' + t) + (c ? d + Math.abs(num - i).toFixed(c).slice(2) : '');
};
/* 
// Usage
(1234.5678).formatMoney(); // No decimal places
(1234.5678).formatMoney(2); // Standard UK format
(1234.5678).formatMoney(2, ',', '.', '$'); // US format with . and , opposite of UK format
*/