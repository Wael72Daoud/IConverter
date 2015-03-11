using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IConverter.Converters
{
    class Currency_Data
    {

        Currency currency = new Currency();
                
        public string Symbol = null;
        public string Country_Flag { set; get; }
        
        public const string Symbol__AED_Emirati_Dirham              = "AED";
        public const string Symbol__Afghan_Afghani                  = "AFN";
        public const string Symbol__Albanian_Lek                    = "ALL";
        public const string Symbol__Algerian_Dinar                  = "DZD";
        public const string Symbol__Angolan_Kwanza                  = "AOA";
        public const string Symbol__Argentine_Peso                  = "ARS";
        public const string Symbol__Armenian_Dram                   = "AMD";
        public const string Symbol__Aruban_or_Dutch_Guilder         = "AWG";
        public const string Symbol__AUD_Australian_Dollar           = "AUD";
        public const string Symbol__Azerbaijani_New_Manat           = "AZN";
        public const string Symbol__Bahamian_Dollar                 = "BSD";
        public const string Symbol__Bahraini_Dinar                  = "BHD";
        public const string Symbol__Bangladeshi_Taka                = "BDT";
        public const string Symbol__Barbadian_or_Bajan_Dollar       = "BBD";
        public const string Symbol__Basotho_Loti                    = "LSL";
        public const string Symbol__Belarusian_Ruble                = "BYR";
        public const string Symbol__Belizean_Dollar                 = "BZD";
        public const string Symbol__Bermudian_Dollar                = "BMD";
        public const string Symbol__Bhutanese_Ngultrum              = "BTN";
        public const string Symbol__Bolivian_Boliviano              = "BOB";
        public const string Symbol__Bosnian_Convertible_Marka       = "BAM";
        public const string Symbol__Botswana_Pula                   = "BWP";
        public const string Symbol__Brazilian_Real                  = "BRL";
        public const string Symbol__Bruneian_Dollar                 = "BND";
        public const string Symbol__Bulgarian_Lev                   = "BGN";
        public const string Symbol__Burmese_Kyat                    = "MMK";
        public const string Symbol__Burundian_Franc                 = "BIF";
        public const string Symbol__CAD_Canadian_Dollar             = "CAD";
        public const string Symbol__Cambodian_Riel                  = "KHR";
        public const string Symbol__Cape_Verdean_Escudo             = "CVE";
        public const string Symbol__Caymanian_Dollar                = "KYD";
        public const string Symbol__Central_African_CFA_Franc_BEAC  = "XAF";
        public const string Symbol__CFA_Franc                       = "XOF";
        public const string Symbol__CFP_Franc                       = "XPF";
        public const string Symbol__CHF_Swiss_Franc                 = "CHF";
        public const string Symbol__Chilean_Peso                    = "CLP";
        public const string Symbol__CNY_Chinese_Yuan_Renminbi       = "CNY";
        public const string Symbol__Colombian_Peso                  = "COP";
        public const string Symbol__Comoran_Franc                   = "KMF";
        public const string Symbol__Congolese_Franc                 = "CDF";
        public const string Symbol__Costa_Rican_Colon               = "CRC";
        public const string Symbol__Croatian_Kuna                   = "HRK";
        public const string Symbol__Cuban_Convertible_Peso          = "CUC";
        public const string Symbol__Cuban_Peso                      = "CUP";
        public const string Symbol__Czech_Koruna                    = "CZK";
        public const string Symbol__Danish_Krone                    = "DKK";
        public const string Symbol__Djiboutian_Franc                = "DJF";
        public const string Symbol__Dominican_Peso                  = "DOP";
        public const string Symbol__Dutch_Guilder                   = "ANG";
        public const string Symbol__East_Caribbean_Dollar           = "XCD";
        public const string Symbol__Egyptian_Pound                  = "EGP";
        public const string Symbol__Eritrean_Nakfa                  = "ERN";
        public const string Symbol__Ethiopian_Birr                  = "ETB";
        public const string Symbol__EUR_Euro                        = "EUR";
        public const string Symbol__Falkland_Island_Pound           = "FKP";
        public const string Symbol__Fijian_Dollar                   = "FJD";
        public const string Symbol__Gambian_Dalasi                  = "GMD";
        public const string Symbol__GBP_British_Pound               = "GBP";
        public const string Symbol__Georgian_Lari                   = "GEL";
        public const string Symbol__Ghanaian_Cedi                   = "GHS";
        public const string Symbol__Gibraltar_Pound                 = "GIP";
        public const string Symbol__Gold_Ounce                      = "XAU";
        public const string Symbol__Guatemalan_Quetzal              = "GTQ";
        public const string Symbol__Guernsey_Pound                  = "GGP";
        public const string Symbol__Guinean_Franc                   = "GNF";
        public const string Symbol__Guyanese_Dollar                 = "GYD";
        public const string Symbol__Haitian_Gourde                  = "HTG";
        public const string Symbol__Honduran_Lempira                = "HNL";
        public const string Symbol__Hong_Kong_Dollar                = "HKD";
        public const string Symbol__Hungarian_Forint                = "HUF";
        public const string Symbol__Icelandic_Krona                 = "ISK";
        public const string Symbol__IMF_Special_Drawing_Rights      = "XDR";
        public const string Symbol__Indonesian_Rupiah               = "IDR";
        public const string Symbol__INR_Indian_Rupee                = "INR";
        public const string Symbol__Iranian_Rial                    = "IRR";
        public const string Symbol__Iraqi_Dinar                     = "IQD";
        public const string Symbol__Isle_of_Man_Pound               = "IMP";
        public const string Symbol__Israeli_Shekel                  = "ILS";
        public const string Symbol__Jamaican_Dollar                 = "JMD";
        public const string Symbol__Jersey_Pound                    = "JEP";
        public const string Symbol__Jordanian_Dinar                 = "JOD";
        public const string Symbol__JPY_Japanese_Yen                = "JPY";
        public const string Symbol__Kazakhstani_Tenge               = "KZT";
        public const string Symbol__Kenyan_Shilling                 = "KES";
        public const string Symbol__Kuwaiti_Dinar                   = "KWD";
        public const string Symbol__Kyrgyzstani_Som                 = "KGS";
        public const string Symbol__Lao_or_Laotian_Kip              = "LAK";
        public const string Symbol__Latvian_Lat                     = "LVL";
        public const string Symbol__Lebanese_Pound                  = "LBP";
        public const string Symbol__Liberian_Dollar                 = "LRD";
        public const string Symbol__Libyan_Dinar                    = "LYD";
        public const string Symbol__Lithuanian_Litas                = "LTL";
        public const string Symbol__Macau_Pataca                    = "MOP";
        public const string Symbol__Macedonian_Denar                = "MKD";
        public const string Symbol__Malagasy_Ariary                 = "MGA";
        public const string Symbol__Malawian_Kwacha                 = "MWK";
        public const string Symbol__Maldivian_Rufiyaa               = "MVR";
        public const string Symbol__Mauritanian_Ouguiya             = "MRO";
        public const string Symbol__Mauritian_Rupee                 = "MUR";
        public const string Symbol__Moldovan_Leu                    = "MDL";
        public const string Symbol__Mongolian_Tughrik               = "MNT";
        public const string Symbol__Moroccan_Dirham                 = "MAD";
        public const string Symbol__Mozambican_Metical              = "MZN";
        public const string Symbol__MXN_Mexican_Peso                = "MXN";
        public const string Symbol__MYR_Malaysian_Ringgit           = "MYR";
        public const string Symbol__Namibian_Dollar                 = "NAD";
        public const string Symbol__Nepalese_Rupee                  = "NPR";
        public const string Symbol__Ni_Vanuatu_Vatu                 = "VUV";
        public const string Symbol__Nicaraguan_Cordoba              = "NIO";
        public const string Symbol__Nigerian_Naira                  = "NGN";
        public const string Symbol__North_Korean_Won                = "KPW";
        public const string Symbol__Norwegian_Krone                 = "NOK";
        public const string Symbol__NZD_New_Zealand_Dollar          = "NZD";
        public const string Symbol__Omani_Rial                      = "OMR";
        public const string Symbol__Pakistani_Rupee                 = "PKR";
        public const string Symbol__Palladium_Ounce                 = "XPD";
        public const string Symbol__Panamanian_Balboa               = "PAB";
        public const string Symbol__Papua_New_Guinean_Kina          = "PGK";
        public const string Symbol__Paraguayan_Guarani              = "PYG";
        public const string Symbol__Peruvian_Nuevo_Sol              = "PEN";
        public const string Symbol__PHP_Philippine_Peso             = "PHP";
        public const string Symbol__Platinum_Ounce                  = "XPT";
        public const string Symbol__Polish_Zloty                    = "PLN";
        public const string Symbol__Qatari_Riyal                    = "QAR";
        public const string Symbol__Romanian_New_Leu                = "RON";
        public const string Symbol__Russian_Ruble                   = "RUB";
        public const string Symbol__Rwandan_Franc                   = "RWF";
        public const string Symbol__Saint_Helenian_Pound            = "SHP";
        public const string Symbol__Salvadoran_Colon                = "SVC";
        public const string Symbol__Samoan_Tala                     = "WST";
        public const string Symbol__Sao_Tomean_Dobra                = "STD";
        public const string Symbol__SAR_Saudi_Arabian_Riyal         = "SAR";
        public const string Symbol__Seborgan_Luigino                = "SPL";
        public const string Symbol__SEK_Swedish_Krona               = "SEK";
        public const string Symbol__Serbian_Dinar                   = "RSD";
        public const string Symbol__Seychellois_Rupee               = "SCR";
        public const string Symbol__Sierra_Leonean_Leone            = "SLL";
        public const string Symbol__Silver_Ounce                    = "XAG";
        public const string Symbol__Singapore_Dollar                = "SGD";
        public const string Symbol__Solomon_Islander_Dollar         = "SBD";
        public const string Symbol__Somali_Shilling                 = "SOS";
        public const string Symbol__South_Korean_Won                = "KRW";
        public const string Symbol__Sri_Lankan_Rupee                = "LKR";
        public const string Symbol__Sudanese_Pound                  = "SDG";
        public const string Symbol__Surinamese_Dollar               = "SRD";
        public const string Symbol__Swazi_Lilangeni                 = "SZL";
        public const string Symbol__Syrian_Pound                    = "SYP";
        public const string Symbol__Taiwan_New_Dollar               = "TWD";
        public const string Symbol__Tajikistani_Somoni              = "TJS";
        public const string Symbol__Tanzanian_Shilling              = "TZS";
        public const string Symbol__THB_Thai_Baht                   = "THB";
        public const string Symbol__Tongan_Paanga                   = "TOP";
        public const string Symbol__Trinidadian_Dollar              = "TTD";
        public const string Symbol__TRY_Turkish_Lira                = "TRY";
        public const string Symbol__Tunisian_Dinar                  = "TND";
        public const string Symbol__Turkmenistani_Manat             = "TMT";
        public const string Symbol__Tuvaluan_Dollar                 = "TVD";
        public const string Symbol__Ugandan_Shilling                = "UGX";
        public const string Symbol__Ukrainian_Hryvna                = "UAH";
        public const string Symbol__Uruguayan_Peso                  = "UYU";
        public const string Symbol__USD_US_Dollar                   = "USD";
        public const string Symbol__Uzbekistani_Som                 = "UZS";        
        public const string Symbol__Venezuelan_Bolivar              = "VEF";
        public const string Symbol__Vietnamese_Dong                 = "VND";
        public const string Symbol__Yemeni_Rial                     = "YER";
        public const string Symbol__Zambian_Kwacha                  = "ZMK";
        public const string Symbol__Zambian_Kwacha_B                = "ZMW";
        public const string Symbol__ZAR_South_African_Rand          = "ZAR";
        public const string Symbol__Zimbabwean_Dollar               = "ZWD";
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   

    }
}
