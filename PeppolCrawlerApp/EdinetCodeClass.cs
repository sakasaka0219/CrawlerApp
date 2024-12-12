using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeppolCrawlerApp
{
    public class EdinetCodeClass
    {
        public string EdinetCode { get; set; } // EDINETコード
        public string SubmitterType { get; set; } // 提出者種別
        public string ListingStatus { get; set; } // 上場区分
        public bool IsConsolidated { get; set; } // 連結の有無
        public decimal Capital { get; set; } // 資本金
        public DateTime FiscalYearEnd { get; set; } // 決算日
        public string SubmitterName { get; set; } // 提出者名
        public string SubmitterNameEnglish { get; set; } // 提出者名（英字）
        public string SubmitterNameYomi { get; set; } // 提出者名（ヨミ）
        public string Address { get; set; } // 所在地
        public string SubmitterIndustry { get; set; } // 提出者業種
        public string SecuritiesCode { get; set; } // 証券コード
        public string CorporateNumber { get; set; } // 提出者法人番号


    }
}
