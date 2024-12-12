using PeppolCrawlerApp;
using System.Text;

System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

List<EdinetCodeClass> edinetCodeList = new List<EdinetCodeClass>();

//csv読み込み
string filePath = @".\Data\sample.csv";
try
{
    using (StreamReader reader = new StreamReader(filePath, Encoding.GetEncoding("Shift_JIS")))
    {
        string line;
        if ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine("１行目をスキップ");
        }

        if ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine("２行目をスキップ");
        }

        while ((line = reader.ReadLine()) != null)
        {
            // カンマで分割して各要素を配列に格納
            string[] values = line.Split(',');

            EdinetCodeClass edinetCode = new EdinetCodeClass
            {
                EdinetCode = values[0].Replace("\"", ""),
                SubmitterType = values[1].Replace("\"", ""),
                ListingStatus = values[2].Replace("\"", ""),
                IsConsolidated = values[3].Replace("\"", "") == "有",
                Capital = Decimal.Parse(values[4].Replace("\"", "")),
                FiscalYearEnd = new DateTime(2023, 3, 31),
                SubmitterName = values[6].Replace("\"", ""),
                SubmitterNameEnglish = values[7].Replace("\"", ""),
                SubmitterNameYomi = values[8].Replace("\"", ""),
                Address = values[9].Replace("\"", ""),
                SubmitterIndustry = values[10].Replace("\"", ""),
                SecuritiesCode = values[11].Replace("\"", ""),
                CorporateNumber = values[12].Replace("\"", "")
            };

            edinetCodeList.Add(edinetCode);
        }
    }
}
catch (FileNotFoundException)
{
    Console.WriteLine("指定されたCSVファイルが見つかりません。");
}
catch (Exception ex)
{
    Console.WriteLine("エラーが発生しました: " + ex.Message);
}