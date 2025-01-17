using EOD_ClientEmail.DTOs;
using System.Reflection;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DataService.Models;




namespace EOD_ClientEmail.Service
{
    public class EODClientEmailservice : IEODClientEmailservice

    {

        private readonly NeoNexusBrsContext _dbContext;
        private readonly IErrorLogService _errorLogService;


        public EODClientEmailservice(NeoNexusBrsContext dbContext, IErrorLogService errorLogService)
        {
            _dbContext = dbContext;
            _errorLogService = errorLogService;
        }

        public async Task GetOrderHistory()
        {
            try

            {
                var orderHistories = new List<EODSummaryModel>();
                var aiforderHistories = new List<EODSummaryModel>();
                var mforderHistories = new List<EODSummaryModel>();
                var listedOrderHistories = new List<EODSummaryModel>();


                DateTime todayDate = DateTime.Today;

                var orders = await (from bsh in _dbContext.Omsholdingbuysellorderhistories
                                    where bsh.Ordertype != "LISTED EQ"
                                    join osd in _dbContext.Omsstatusdetails on bsh.Id equals osd.Orderhistoryid
                                    join cxoMapping in _dbContext.WsClientrmcsomappings on bsh.Clientcode equals Convert.ToString(cxoMapping.Clientid) into cxoJoin
                                    from cxo in cxoJoin.DefaultIfEmpty()
                                    join cred in _dbContext.Credentialssmtpmailers on bsh.Entityid equals cred.EntityId into credJoin

                                    from credential in credJoin.DefaultIfEmpty()

                                    join fixedIncome in _dbContext.Omsfixedincomedetails on bsh.Id equals fixedIncome.Orderhistoryid into fixedIncomeJoin

                                    from fi in fixedIncomeJoin.DefaultIfEmpty()

                                    join unlistedEq in _dbContext.Omsunlistedeqdetails on bsh.Id equals unlistedEq.Orderhistoryid into unlistedEqJoin

                                    from ue in unlistedEqJoin.DefaultIfEmpty()

                                    join listedEq in _dbContext.Omslistedeqdetails on bsh.Id equals listedEq.Orderhistoryid into listedEqJoin

                                    from le in listedEqJoin.DefaultIfEmpty()

                                    where bsh.Makertimetamp.HasValue && bsh.Makertimetamp.Value.Date == todayDate.Date
                                     && bsh.Isactive == true && bsh.Isdeleted == false

                                    orderby bsh.Id ascending

                                    select new

                                    {

                                        bsh.Id,

                                        BankerId = cxo.BankerEmpId,

                                        BankerName = cxo.BankerName,

                                        BankerEmailId = cxo.BankerEmail,

                                        CxoName = cxo.Csoname,

                                        CxoEmailId = cxo.Csoemail,

                                        Makertimetamp = bsh.Makertimetamp,

                                        Tradedate = bsh.Tradedate,

                                        Ordertype = bsh.Ordertype,

                                        Ac_Type = bsh.Accounttype,

                                        AccountCode = bsh.Clientcode,

                                        Clientname = bsh.Clientname,

                                        Buyselltype = bsh.Buyselltype,

                                        Securityname = bsh.Securityname,

                                        Isincode = bsh.Isincode,

                                        Amount = bsh.Ordertype == "FIXED INCOME" ? fi.Totalconsideration :

                                                 bsh.Ordertype == "UNLISTED EQ" ? ue.Totalconsideration : (decimal?)null,
                                        Quantitybooked = bsh.Ordertype == "FIXED INCOME" ? fi.Quantitybooked :

                                                        bsh.Ordertype == "UNLISTED EQ" ? ue.Quantitybooked : (decimal?)null,

                                        Status = string.IsNullOrEmpty(osd.Finalstatus) ? "PENDING" : osd.Finalstatus,

                                        FromAddress = credential.FormAddress,

                                        ClientPan = bsh.Pan,

                                        ReferenceNumber = bsh.Referencenumber,

                                    }).Distinct().ToListAsync();

                if (orders.Any())

                {

                    var groupedOrders = orders.GroupBy(o => new { o.BankerEmailId, o.CxoEmailId })

                                              .Select(group => new

                                              {

                                                  BankerEmail = group.Key.BankerEmailId,

                                                  CxoEmail = group.Key.CxoEmailId,

                                                  Orders = group.DistinctBy(x => x.ReferenceNumber).ToList()

                                              });

                    foreach (var group in groupedOrders)

                    {

                        orderHistories = group.Orders.Select(order => new EODSummaryModel

                        {

                            InvId = order.Id,

                            OrderDate = order.Makertimetamp,

                            TransactionDate = order.Tradedate,

                            Category = order.Ordertype,

                            ClientName = order.Clientname,

                            TransactionType = order.Buyselltype,

                            AC_Type = order.Ac_Type,

                            AccountCode = order.AccountCode,

                            SchemeOrScrip = order.Securityname,

                            ISIN = order.Isincode,

                            Amount = order.Amount ?? 0,

                            Units = Math.Round(order.Quantitybooked ?? 0, 2),

                            RMName = order.BankerName,

                            RMEmailId = order.BankerEmailId,

                            CSOName = order.CxoName,

                            CSOEmailId = order.CxoEmailId,

                            Status = order.Status,

                            ToAddress = order.BankerEmailId,

                            FromAddress = order.FromAddress,

                            ReferenceNumber = order.ReferenceNumber

                        }).ToList();

                    }
                }


                var aiforders = await (from bsh in _dbContext.Omsaiholdinghistories
                                       join osd in _dbContext.Omsaifstatusdetails on bsh.Id equals osd.Orderhistoryid
                                       join cxoMapping in _dbContext.WsClientrmcsomappings on bsh.Clientcode equals Convert.ToString(cxoMapping.Clientid) into cxoJoin
                                       from cxo in cxoJoin.DefaultIfEmpty()
                                       join cred in _dbContext.Credentialssmtpmailers on bsh.Entityid equals cred.EntityId into credJoin

                                       from credential in credJoin.DefaultIfEmpty()

                                       join fixedIncome in _dbContext.Omsaiffundetails on bsh.Id equals fixedIncome.Orderhistoryid into fixedIncomeJoin

                                       from fi in fixedIncomeJoin.DefaultIfEmpty()


                                       where bsh.Tradedate.HasValue && bsh.Tradedate.Value.Date == todayDate.Date && bsh.Isactive == true
                                       orderby bsh.Id ascending

                                       select new

                                       {

                                           bsh.Id,

                                           BankerId = cxo.BankerEmpId,

                                           BankerName = cxo.BankerName,

                                           BankerEmailId = cxo.BankerEmail,

                                           CxoName = cxo.Csoname,

                                           CxoEmailId = cxo.Csoemail,

                                           Makertimetamp = osd.Makertimestamp,

                                           Tradedate = bsh.Tradedate,

                                           Ordertype = bsh.Ordertype,

                                           Ac_Type = bsh.Acounttype,

                                           AccountCode = bsh.Clientcode,

                                           Clientname = bsh.Clientname,

                                           Buyselltype = bsh.Trxtype,

                                           Securityname = bsh.Schmename,

                                           Isincode = bsh.Isincode,

                                           Amount = bsh.Trxtype == "SUBSCRIPTION" ? bsh.Commitmentamount : bsh.Amount,

                                           Quantitybooked = bsh.Units,

                                           Status = string.IsNullOrEmpty(osd.Finalstatus) ? "PENDING" : osd.Finalstatus,

                                           FromAddress = credential.FormAddress,

                                           ReferenceNumber = bsh.Refenecenumber

                                       }).Distinct().ToListAsync();

                if (aiforders.Any())
                {
                    var aifgroupedOrders = aiforders.GroupBy(o => new { o.BankerEmailId, o.CxoEmailId }).Select(group => new

                    {
                        BankerEmail = group.Key.BankerEmailId,

                        CxoEmail = group.Key.CxoEmailId,

                        aiforders = group.DistinctBy(x => x.ReferenceNumber).ToList()
                    });

                    foreach (var group in aifgroupedOrders)

                    {
                        aiforderHistories = group.aiforders.Select(order => new EODSummaryModel

                        {
                            InvId = order.Id,

                            OrderDate = order.Makertimetamp,

                            TransactionDate = order.Tradedate,

                            Category = order.Ordertype,

                            ClientName = order.Clientname,

                            TransactionType = order.Buyselltype,

                            AC_Type = order.Ac_Type,

                            AccountCode = order.AccountCode,

                            SchemeOrScrip = order.Securityname,

                            ISIN = order.Isincode,

                            Amount = order.Amount ?? 0,

                            Units = Math.Round(order.Quantitybooked ?? 0, 2),

                            RMName = order.BankerName,

                            RMEmailId = order.BankerEmailId,

                            CSOName = order.CxoName,

                            CSOEmailId = order.CxoEmailId,

                            Status = order.Status,

                            ToAddress = order.BankerEmailId,

                            FromAddress = order.FromAddress,

                            ReferenceNumber = order.ReferenceNumber

                        }).ToList();

                    }
                }


                var mforders = await (from bsh in _dbContext.Omsmfholdingdatahistories
                                      join wsData in _dbContext.WsClientmasterdata on bsh.ClientCode equals wsData.Clientcode
                                      join wsEntity in _dbContext.WsEntitynamemappingdata on wsData.Refcode4 equals wsEntity.Wsentityname
                                      join osd in _dbContext.Omsmfstatusdetails on bsh.Id equals osd.Orderhistoryid
                                      join cxoMapping in _dbContext.WsClientrmcsomappings on bsh.ClientCode equals Convert.ToString(cxoMapping.Clientid) into cxoJoin
                                      from cxo in cxoJoin.DefaultIfEmpty()
                                      join cred in _dbContext.Credentialssmtpmailers on
                                          (wsData.Refcode1 == "NDPMS" ? 3 : wsEntity.Entityid) equals cred.EntityId into credJoin
                                      from credential in credJoin.DefaultIfEmpty()
                                      join omsmf in _dbContext.Omsmutualfundetails on bsh.Id equals omsmf.Orderhistoryid into omsmfjoin
                                      from fi in omsmfjoin.DefaultIfEmpty()
                                      where bsh.TradeDate.HasValue && bsh.TradeDate.Value.Date == todayDate.Date
                                            && bsh.IsActive == true
                                      orderby bsh.Id ascending
                                      select new
                                      {
                                          bsh.Id,
                                          BankerId = cxo.BankerEmpId,
                                          BankerName = cxo.BankerName,
                                          BankerEmailId = cxo.BankerEmail,
                                          CxoName = cxo.Csoname,
                                          CxoEmailId = cxo.Csoemail,
                                          Makertimetamp = osd.Makertimestamp,
                                          Tradedate = bsh.TradeDate,
                                          Ordertype = bsh.OrderType,
                                          Ac_Type = bsh.AccountType,
                                          AccountCode = bsh.ClientCode,
                                          Clientname = bsh.ClientName,
                                          Buyselltype = bsh.TransactionTypeName,
                                          Securityname = bsh.SchemeName,
                                          Isincode = bsh.IsinCode,
                                          Amount = bsh.Amount,
                                          Quantitybooked = bsh.Units,
                                          Status = string.IsNullOrEmpty(osd.Finalstatus) ? "PENDING" : osd.Finalstatus,
                                          FromAddress = credential.FormAddress,
                                          ReferenceNumber = bsh.ReferenceNumber,
                                      }).Distinct().ToListAsync();

                if (mforders.Any())
                {
                    var mfgroupedOrders = mforders.GroupBy(o => new { o.BankerEmailId, o.CxoEmailId })
                                              .Select(group => new
                                              {
                                                  BankerEmail = group.Key.BankerEmailId,
                                                  CxoEmail = group.Key.CxoEmailId,
                                                  mforders = group.DistinctBy(x => x.ReferenceNumber).ToList()
                                              });

                    foreach (var group in mfgroupedOrders)
                    {
                        mforderHistories = group.mforders.Select(order => new EODSummaryModel
                        {
                            InvId = order.Id,
                            OrderDate = order.Makertimetamp,
                            TransactionDate = order.Tradedate,
                            Category = order.Ordertype,
                            ClientName = order.Clientname,
                            TransactionType = order.Buyselltype,
                            AC_Type = order.Ac_Type,
                            AccountCode = order.AccountCode,
                            SchemeOrScrip = order.Securityname,
                            ISIN = order.Isincode,
                            Amount = order.Amount ?? 0,
                            Units = Math.Round(order.Quantitybooked ?? 0, 2),
                            RMName = order.BankerName,
                            RMEmailId = order.BankerEmailId,
                            CSOName = order.CxoName,
                            CSOEmailId = order.CxoEmailId,
                            Status = order.Status,
                            ToAddress = order.BankerEmailId,
                            FromAddress = order.FromAddress,
                            ReferenceNumber = order.ReferenceNumber

                        }).ToList();

                    }
                }


                var todayDatestring = DateTime.Now.Date.ToString("M/d/yyyy hh:mm:ss tt");

                var listedOrders = await (
                                    from a in _dbContext.WsClientmasterdata
                                    join b in _dbContext.WsTradedetails
                                    on a.Refcode6 equals b.AccountCode

                                    join c in _dbContext.WsClientrmcsomappings
                                    on a.Clientcode equals Convert.ToString(c.Clientid) into clientMapping
                                    from c in clientMapping.DefaultIfEmpty()

                                    join entity in _dbContext.WsEntitynamemappingdata on a.Refcode4 equals entity.Wsentityname into entityGroup
                                    from entity in entityGroup.DefaultIfEmpty()

                                    join cred in _dbContext.Credentialssmtpmailers on entity.Entityid equals cred.EntityId into credJoin
                                    from credential in credJoin.DefaultIfEmpty()

                                    where a.Isactive == true && b.Isactive == true && c.IsActive == true
                                      && (b.Exchange == "11111100" || b.Exchange == "11111200")
                                    && b.TrxDate == todayDatestring
                                    select new
                                    {
                                        OrderDate = todayDate,
                                        TransactionDate = b.TrxDate,
                                        ClientPan = a.Pannumber,
                                        Product = "LISTED EQ",
                                        ClientName = a.Clientname,
                                        ClientEmail = a.Email,
                                        TransactionType = b.BuySell,
                                        AccountType = a.Refcode1,
                                        AccountCode = a.Clientcode,
                                        SchemeName = b.ExcSymbol,
                                        Isin = b.IsinCode,
                                        Amount = b.TradeAmt,
                                        Quantity = b.Quantity,
                                        Status = "EXECUTED",
                                        BankerName = c.BankerName,
                                        BankerEmail = c.BankerEmail,
                                        CsoName = c.Csoname,
                                        CsoEmail = c.Csoemail,
                                        FromAddress = credential.FormAddress,

                                    }).Distinct().ToListAsync();

                if (listedOrders.Any())
                {
                    var groupedOrders = listedOrders.GroupBy(o => o.ClientPan)
                                              .Select(group => new
                                              {
                                                  ClientPan = group.Key,
                                                  Orders = group.ToList()
                                              });

                    foreach (var group in groupedOrders)
                    {
                        listedOrderHistories = group.Orders.Select(order => new EODSummaryModel
                        {

                            InvId = 0,

                            OrderDate = order.OrderDate,

                            TransactionDate = DateTime.Parse(order.TransactionDate),

                            Category = order.Product,

                            ClientName = order.ClientName,

                            TransactionType = order.TransactionType,

                            AC_Type = order.AccountType,

                            AccountCode = order.AccountCode,

                            SchemeOrScrip = order.SchemeName,

                            ISIN = order.Isin,

                            Amount = order.Amount ?? 0,

                            Units = Math.Round(order.Quantity ?? 0, 2),

                            RMName = order.BankerName,

                            RMEmailId = order.BankerEmail,

                            CSOName = order.CsoName,

                            CSOEmailId = order.CsoEmail,

                            Status = order.Status,

                            ToAddress = "",

                            FromAddress = order.FromAddress,

                            ReferenceNumber = ""

                        }).ToList();
                    }


                }


                var allOrderHistories = new List<EODSummaryModel>();

                allOrderHistories = orderHistories.Union(aiforderHistories).Union(mforderHistories).Union(listedOrderHistories).ToList();


                string htmlBody = GenerateHtmlTable(allOrderHistories);

            }
            catch (Exception ex)
            {
                _errorLogService.LogException(ex);
                throw;
            }
        }

        private string GenerateHtmlTable(List<EODSummaryModel> orderHistories)
        {
            try
            {
                var html = new StringBuilder();

                html.Append("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional //EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\" xmlns:v=\"urn:schemas-microsoft-com:vml\" xmlns:o=\"urn:schemas-microsoft-com:office:office\">\r\n\t<head>\r\n\t\t<meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\" />\r\n\t\t<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n\t\t<meta name=\"x-apple-disable-message-reformatting\" />\r\n\t\t<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\r\n\t\t<title>Neo Wealth Partners</title>\r\n\t\t<style type=\"text/css\">\r\n\t\t\ttable {\r\n\t\t\twidth: 100%;\r\n\t\t\tborder-collapse: collapse;\r\n\t\t\ttext-align: center; margin: 0 auto; padding-top: 0px; padding-bottom: 10px; padding-left: 0; padding-right: 0; -webkit-text-size-adjust: 100%; background-color: #fff; color: #000000;\r\n\t\t\t}\r\n\t\t\tth {\r\n\t\t\tbackground-color: #3c0256;\r\n\t\t\tcolor: white;\r\n\t\t\tborder: 1px solid black;\r\n\t\t\tpadding: 8px;\r\n\t\t\t}\r\n\t\t\ttd {\r\n\t\t\tcolor: #000000;\r\n\t\t\tborder: 1px solid black;\r\n\t\t\tpadding: 8px;\r\n\t\t\t}\r\n\t\t\ttbody tr:nth-child(even) {\r\n\t\t\tbackground-color: white;\r\n\t\t\t}\r\n\t\t\tp{\r\n\t\t\tfont-size:13px;\r\n\t\t\t}\r\n\t\t</style>\r\n\t</head>" +
                    "<body style=\"font-size: 10px;\">" +
                    "<p>Dear " + (orderHistories.Any() ? orderHistories[0]?.RMName?.ToUpper().ToString() ?? "" : "") + " ,</p>" +
                    "<p>Following is the summary of transactions executed / status updates for your client today.</p>" +

                    "<p>In case of any discrepancy or query, kindly reach out to your CXO - " + (orderHistories.Any() ? orderHistories[0]?.CSOName?.ToString().ToUpper() ?? "" : "") + ".</p>");
                html.Append("<table><thead><tr>");
                html.Append("<th>ORDER DATE</th>");
                html.Append("<th>TRANSACTION DATE</th>");
                html.Append("<th>PRODUCT</th>");
                html.Append("<th>REFERENCE NUMBER</th>");
                html.Append("<th>CLIENT NAME</th>");
                html.Append("<th>TRANSACTION TYPE</th>");
                html.Append("<th>A/C TYPE</th>");
                html.Append("<th>ACCOUNT CODE</th>");
                html.Append("<th>SCHEME/SCRIP</th>");
                html.Append("<th>ISIN</th>");
                html.Append("<th>AMOUNT</th>");
                html.Append("<th>UNITS</th>");
                html.Append("<th>STATUS</th>");
                html.Append("</tr></thead><tbody>");

                foreach (var order in orderHistories)
                {
                    string unitsText = order.Units != 0 ? order.Units.ToString() : " - ";
                    html.Append("<tr>");
                    html.Append($"<td  style=\"text-align: left;\">{order.OrderDate?.ToString("dd-MMM-yyyy")}</td>");
                    html.Append($"<td  style=\"text-align: left;\">{order.TransactionDate?.ToString("dd-MMM-yyyy")}</td>");
                    html.Append($"<td  style=\"text-align: left;\">{order.Category?.ToUpper()}</td>");
                    html.Append($"<td  style=\"text-align: left;\">{order.ReferenceNumber?.ToUpper()}</td>");
                    html.Append($"<td  style=\"text-align: left;\">{order.ClientName?.ToUpper()}</td>");
                    html.Append($"<td  style=\"text-align: left;\">{order.TransactionType?.ToUpper()}</td>");
                    html.Append($"<td  style=\"text-align: left;\">{order.AC_Type?.ToUpper()}</td>");
                    html.Append($"<td  style=\"text-align: left;\">{order.AccountCode?.ToUpper()}</td>");
                    html.Append($"<td  style=\"text-align: left;\">{order.SchemeOrScrip?.ToUpper()}</td>");
                    html.Append($"<td  style=\"text-align: left;\">{order.ISIN?.ToUpper()}</td>");
                    html.Append($"<td  style=\"text-align: right;\">{order.Amount?.ToString("#,##0.00")}</td>");
                    html.Append($"<td style=\"text-align: right;\">{unitsText}</td>");
                    html.Append($"<td style=\"text-align: left;\">{order.Status?.ToUpper()}</td>");
                    html.Append("</tr>");
                }

                html.Append("</tbody></table>");
                html.Append("<p>Thanks & Regards,</p>" +
                    "<p>This is a system generated mail, please do not reply as it will not reach a Mailbox.</p>");
                html.Append("</body>\r\n</html>");

                NotificationMessage message = new NotificationMessage
                {
                    Invid = orderHistories.Any() ? orderHistories[0]?.InvId ?? 0 : 0,
                    FromAddress = orderHistories.Any() ? orderHistories[0]?.FromAddress ?? "" : "",
                    ToAddress = "kinjal.vora@neo-group.in",
                    //ToAddress = "aniket1996007@gmail.com",
                    Ccaddress = "Rupak.Shukla@genietechno.com;pankaj.jadhav@genietechno.com",
                    //Ccaddress = "pankaj.jadhav@genietechno.com;ravi.suthar@genietechno.com;aniket1996007@gmail.com",
                    Emailbody = html.ToString(),
                    Ismailsent = false,
                    Isactive = true,
                    Timestamp = DateTime.Now,
                    Subject = "Transaction Update for the day - " + DateTime.Now.ToString("dd-MMM-yyyy"),

                };

                var isSent = InsertDataIntoNotificationMessages(message);
                return html.ToString();
            }
            catch (Exception ex)
            {
                 _errorLogService.LogException(ex);
                throw;
            }
        }



        public async Task GetOrderHistoryForClient(bool ismailtocxo)
        {
            try

            {
                var orderHistories = new List<EODSummaryModel>();
                var aiforderHistories = new List<EODSummaryModel>();
                var mforderHistories = new List<EODSummaryModel>();
                var listedOrderHistories = new List<EODSummaryModel>();


                DateTime todayDate = DateTime.Today;

                var orders = await (
                                    from bsh in _dbContext.Omsholdingbuysellorderhistories
                                    where bsh.Ordertype != "LISTED EQ"
                                    join osd in _dbContext.Omsstatusdetails on bsh.Id equals osd.Orderhistoryid
                                    join cxoMapping in _dbContext.WsClientrmcsomappings on bsh.Clientcode equals Convert.ToString(cxoMapping.Clientid) into cxoJoin
                                    from cxo in cxoJoin.DefaultIfEmpty()
                                    join cred in _dbContext.Credentialssmtpmailers on bsh.Entityid equals cred.EntityId into credJoin

                                    from credential in credJoin.DefaultIfEmpty()

                                    join fixedIncome in _dbContext.Omsfixedincomedetails on bsh.Id equals fixedIncome.Orderhistoryid into fixedIncomeJoin

                                    from fi in fixedIncomeJoin.DefaultIfEmpty()

                                    join unlistedEq in _dbContext.Omsunlistedeqdetails on bsh.Id equals unlistedEq.Orderhistoryid into unlistedEqJoin

                                    from ue in unlistedEqJoin.DefaultIfEmpty()

                                    join listedEq in _dbContext.Omslistedeqdetails on bsh.Id equals listedEq.Orderhistoryid into listedEqJoin

                                    from le in listedEqJoin.DefaultIfEmpty()

                                    where bsh.Makertimetamp.HasValue && bsh.Makertimetamp.Value.Date == todayDate.Date
                                                        && bsh.Isactive == true && bsh.Isdeleted == false

                                    orderby bsh.Id ascending

                                    select new
                                    {
                                        bsh.Id,

                                        bsh.Email,

                                        bsh.Pan,

                                        BankerId = cxo.BankerEmpId,

                                        BankerName = cxo.BankerName,

                                        BankerEmailId = cxo.BankerEmail,

                                        CxoName = cxo.Csoname,

                                        CxoEmailId = cxo.Csoemail,

                                        Makertimetamp = bsh.Makertimetamp,

                                        Tradedate = bsh.Tradedate,

                                        Ordertype = bsh.Ordertype,

                                        Ac_Type = bsh.Accounttype,

                                        AccountCode = bsh.Clientcode,

                                        Clientname = bsh.Clientname,

                                        Buyselltype = bsh.Buyselltype,

                                        Securityname = bsh.Securityname,

                                        Isincode = bsh.Isincode,

                                        Amount = bsh.Ordertype == "FIXED INCOME" ? fi.Totalconsideration :

                                                 bsh.Ordertype == "UNLISTED EQ" ? ue.Totalconsideration : (decimal?)null,

                                        Quantitybooked = bsh.Ordertype == "FIXED INCOME" ? fi.Quantitybooked :

                                                        bsh.Ordertype == "UNLISTED EQ" ? ue.Quantitybooked : (decimal?)null,

                                         Status = string.IsNullOrEmpty(osd.Finalstatus) ? "PENDING" : osd.Finalstatus,

                                        FromAddress = credential.FormAddress,

                                        ClientPan = bsh.Pan,

                                        ReferenceNumber = bsh.Referencenumber,

                                    }).Distinct().ToListAsync();

                if (orders.Any())
                {
                    orderHistories = orders.Select(order => new EODSummaryModel
                    {
                        InvId = order.Id,
                        OrderDate = order.Makertimetamp,
                        TransactionDate = order.Tradedate,
                        Category = order.Ordertype,
                        ClientName = order.Clientname,
                        TransactionType = order.Buyselltype,
                        AC_Type = order.Ac_Type,
                        AccountCode = order.AccountCode,
                        SchemeOrScrip = order.Securityname,
                        ISIN = order.Isincode,
                        Amount = order.Amount ?? 0,
                        Units = Math.Round(order.Quantitybooked ?? 0, 2),
                        RMName = order.BankerName,
                        RMEmailId = order.BankerEmailId,
                        CSOName = order.CxoName,
                        CSOEmailId = order.CxoEmailId,
                        Status = order.Status,
                        ToAddress = order.BankerEmailId,
                        FromAddress = order.FromAddress,
                        ClientEmail = order.Email,
                        ReferenceNumber = order.ReferenceNumber,
                        ClientPan= order.ClientPan
                    }).DistinctBy(x => x.ReferenceNumber).ToList();
                }


                var aiforders = await (from bsh in _dbContext.Omsaiholdinghistories
                                       join osd in _dbContext.Omsaifstatusdetails on bsh.Id equals osd.Orderhistoryid
                                       join cxoMapping in _dbContext.WsClientrmcsomappings on bsh.Clientcode equals Convert.ToString(cxoMapping.Clientid) into cxoJoin
                                       from cxo in cxoJoin.DefaultIfEmpty()
                                       join cred in _dbContext.Credentialssmtpmailers on bsh.Entityid equals cred.EntityId into credJoin

                                       from credential in credJoin.DefaultIfEmpty()

                                       join fixedIncome in _dbContext.Omsaiffundetails on bsh.Id equals fixedIncome.Orderhistoryid into fixedIncomeJoin

                                       from fi in fixedIncomeJoin.DefaultIfEmpty()

                                       where bsh.Tradedate.HasValue && bsh.Tradedate.Value.Date == todayDate.Date && bsh.Isactive == true
                                       orderby bsh.Id ascending

                                       select new

                                       {

                                           bsh.Id,

                                           bsh.Email,

                                           BankerId = cxo.BankerEmpId,

                                           BankerName = cxo.BankerName,

                                           BankerEmailId = cxo.BankerEmail,

                                           CxoName = cxo.Csoname,

                                           CxoEmailId = cxo.Csoemail,

                                           Makertimetamp = osd.Makertimestamp,

                                           Tradedate = bsh.Tradedate,

                                           Ordertype = bsh.Ordertype,

                                           Ac_Type = bsh.Acounttype,

                                           AccountCode = bsh.Clientcode,

                                           Clientname = bsh.Clientname,

                                           Buyselltype = bsh.Trxtype,

                                           Securityname = bsh.Schmename,

                                           Isincode = bsh.Isincode,

                                           Amount = bsh.Trxtype == "SUBSCRIPTION" ? bsh.Commitmentamount : bsh.Amount,

                                           Quantitybooked = bsh.Units,

                                           Status = string.IsNullOrEmpty(osd.Finalstatus) ? "PENDING" : osd.Finalstatus,

                                           FromAddress = credential.FormAddress,

                                           ClientPan = bsh.Pan,

                                           ReferenceNumber = bsh.Refenecenumber

                                       }).Distinct().ToListAsync();

                if (aiforders.Any())
                {
                    aiforderHistories = aiforders.Select(order => new EODSummaryModel
                    {
                        InvId = order.Id,
                        OrderDate = order.Makertimetamp,
                        TransactionDate = order.Tradedate,
                        Category = order.Ordertype,
                        ClientName = order.Clientname,
                        TransactionType = order.Buyselltype,
                        AC_Type = order.Ac_Type,
                        AccountCode = order.AccountCode,
                        SchemeOrScrip = order.Securityname,
                        ISIN = order.Isincode,
                        Amount = order.Amount ?? 0,
                        Units = Math.Round(order.Quantitybooked ?? 0, 2),
                        RMName = order.BankerName,
                        RMEmailId = order.BankerEmailId,
                        CSOName = order.CxoName,
                        CSOEmailId = order.CxoEmailId,
                        Status = order.Status,
                        ToAddress = order.BankerEmailId,
                        FromAddress = order.FromAddress,
                        ClientEmail = order.Email,
                        ReferenceNumber = order.ReferenceNumber,
                        ClientPan = order.ClientPan
                    }).DistinctBy(x => x.ReferenceNumber).ToList();
                }



                var mforders = await (from bsh in _dbContext.Omsmfholdingdatahistories
                                      join wsData in _dbContext.WsClientmasterdata on bsh.ClientCode equals wsData.Clientcode
                                      join wsEntity in _dbContext.WsEntitynamemappingdata on wsData.Refcode4 equals wsEntity.Wsentityname
                                      join osd in _dbContext.Omsmfstatusdetails on bsh.Id equals osd.Orderhistoryid
                                      join cxoMapping in _dbContext.WsClientrmcsomappings on bsh.ClientCode equals Convert.ToString(cxoMapping.Clientid) into cxoJoin
                                      from cxo in cxoJoin.DefaultIfEmpty()
                                      join cred in _dbContext.Credentialssmtpmailers on
                                          (wsData.Refcode1 == "NDPMS" ? 3 : wsEntity.Entityid) equals cred.EntityId into credJoin
                                      from credential in credJoin.DefaultIfEmpty()
                                      join omsmf in _dbContext.Omsmutualfundetails on bsh.Id equals omsmf.Orderhistoryid into omsmfjoin
                                      from fi in omsmfjoin.DefaultIfEmpty()
                                      where bsh.TradeDate.HasValue && bsh.TradeDate.Value.Date == todayDate.Date
                                            && bsh.IsActive == true
                                      orderby bsh.Id ascending
                                      select new
                                      {
                                          bsh.Id,
                                          bsh.Email,
                                          BankerId = cxo.BankerEmpId,
                                          BankerName = cxo.BankerName,
                                          BankerEmailId = cxo.BankerEmail,
                                          CxoName = cxo.Csoname,
                                          CxoEmailId = cxo.Csoemail,
                                          Makertimetamp = osd.Makertimestamp,
                                          Tradedate = bsh.TradeDate,
                                          Ordertype = bsh.OrderType,
                                          Ac_Type = bsh.AccountType,
                                          AccountCode = bsh.ClientCode,
                                          Clientname = bsh.ClientName,
                                          Buyselltype = bsh.TransactionTypeName,
                                          Securityname = bsh.SchemeName,
                                          Isincode = bsh.IsinCode,
                                          Amount = bsh.Amount,
                                          Quantitybooked = bsh.Units,
                                          Status = string.IsNullOrEmpty(osd.Finalstatus) ? "PENDING" : osd.Finalstatus,
                                          FromAddress = credential.FormAddress,
                                          ClientPan = bsh.Pan,
                                          ReferenceNumber = bsh.ReferenceNumber

                                      }).Distinct().ToListAsync();

                if (mforders.Any())
                {
                    mforderHistories = mforders.Select(order => new EODSummaryModel
                    {
                        InvId = order.Id,
                        OrderDate = order.Makertimetamp,
                        TransactionDate = order.Tradedate,
                        Category = order.Ordertype,
                        ClientName = order.Clientname,
                        TransactionType = order.Buyselltype,
                        AC_Type = order.Ac_Type,
                        AccountCode = order.AccountCode,
                        SchemeOrScrip = order.Securityname,
                        ISIN = order.Isincode,
                        Amount = order.Amount ?? 0,
                        Units = Math.Round(order.Quantitybooked ?? 0, 2),
                        RMName = order.BankerName,
                        RMEmailId = order.BankerEmailId,
                        CSOName = order.CxoName,
                        CSOEmailId = order.CxoEmailId,
                        Status = order.Status,
                        ToAddress = order.BankerEmailId,
                        FromAddress = order.FromAddress,
                        ClientEmail = order.Email,
                        ReferenceNumber = order.ReferenceNumber,
                        ClientPan = order.ClientPan,
                    }).DistinctBy(x => x.ReferenceNumber).ToList();
                }


                var todayDatestring = DateTime.Now.Date.ToString("M/d/yyyy hh:mm:ss tt");

                var listedOrders =  (
                                    from a in _dbContext.WsClientmasterdata
                                    join b in _dbContext.WsTradedetails
                                    on a.Refcode6 equals b.AccountCode

                                    join c in _dbContext.WsClientrmcsomappings
                                    on a.Clientcode equals Convert.ToString(c.Clientid) into clientMapping
                                    from c in clientMapping.DefaultIfEmpty()

                                    join entity in _dbContext.WsEntitynamemappingdata on a.Refcode4 equals entity.Wsentityname into entityGroup
                                    from entity in entityGroup.DefaultIfEmpty()

                                    join cred in _dbContext.Credentialssmtpmailers on entity.Entityid equals cred.EntityId into credJoin
                                    from credential in credJoin.DefaultIfEmpty()

                                    where a.Isactive == true && b.Isactive == true 
                                      && (b.Exchange == "11111100" || b.Exchange == "11111200")
                                    && (b.TrxDate) == todayDatestring
                                    select new
                                    {
                                        OrderDate = todayDate,
                                        TransactionDate = b.TrxDate,
                                        ClientPan = a.Pannumber,
                                        Product = "LISTED EQ",
                                        ClientName = a.Clientname,
                                        ClientEmail = a.Email,
                                        TransactionType = b.BuySell,
                                        AccountType = a.Refcode1,
                                        AccountCode = a.Clientcode,
                                        SchemeName = b.ExcSymbol,
                                        Isin = b.IsinCode,
                                        Amount = b.TradeAmt,
                                        Quantity = b.Quantity,
                                        Status = "EXECUTED",
                                        BankerName = c.BankerName,
                                        BankerEmail = c.BankerEmail,
                                        CsoName = c.Csoname,
                                        CsoEmail = c.Csoemail,
                                        FromAddress = credential.FormAddress,

                                    }).Distinct().ToList();

                if (listedOrders.Any())
                {
                    listedOrderHistories = listedOrders.Select(order => new EODSummaryModel
                    {
                        InvId = 0,
                        OrderDate = order.OrderDate,
                        TransactionDate = DateTime.Parse(order.TransactionDate),
                        Category = order.Product,
                        ClientName = order.ClientName,
                        TransactionType = order.TransactionType,
                        AC_Type = order.AccountType,
                        AccountCode = order.AccountCode,
                        SchemeOrScrip = order.SchemeName,
                        ISIN = order.Isin,
                        Amount = order.Amount ?? 0,
                        Units = Math.Round(order.Quantity ?? 0, 2),
                        RMName = order.BankerName,
                        RMEmailId = order.BankerEmail,
                        CSOName = order.CsoName,
                        CSOEmailId = order.CsoEmail,
                        Status = order.Status,
                        ToAddress = "", // This field is intentionally left blank
                        FromAddress = order.FromAddress,
                        ReferenceNumber = "", // This field is intentionally left blank
                        ClientPan = order.ClientPan
                    }).ToList();
                }
                 var allOrderHistories = new List<EODSummaryModel>();

                allOrderHistories = orderHistories.Union(aiforderHistories).Union(mforderHistories).Union(listedOrderHistories).ToList();

                if (ismailtocxo) 
                {
                    GenerateHtmlTable(allOrderHistories);
                }
                else
                {
                    GenerateHtmlTableForClient(allOrderHistories);
                }
               

            }
            catch (Exception ex)
            {
               _errorLogService.LogException(ex);
                throw;
            }
        }

        private string GenerateHtmlTableForClient(List<EODSummaryModel> orderHistories)
        {
            try
            {
                // Group orders by ClientPan
                var groupedByPan = orderHistories.GroupBy(x => x.ClientPan).ToList();
                List<string> sentEmails = new List<string>();

                foreach (var clientGroup in groupedByPan)
                {
                    // Extract email and validate
                    var clientEmail = clientGroup.FirstOrDefault()?.ClientEmail;
                    if (string.IsNullOrEmpty(clientEmail))
                    {
                        continue; // Skip if email is null or empty
                    }
                    
                    var clientDetails = clientGroup.FirstOrDefault(); // Get representative client details
                    var clientName = clientDetails?.ClientName?.ToUpper() ?? "Client"; // Default if null
                    var csoName = clientDetails?.CSOName?.ToUpper() ?? "CSO";

                    // Build email content
                    var html = new StringBuilder();
                    html.Append("<!DOCTYPE html><html><head><meta charset=\"UTF-8\">");
                    html.Append("<style>table {width: 100%; border-collapse: collapse; text-align: left;} th, td {border: 1px solid black; padding: 8px;} th {background-color: #3c0256; color: white;} tbody tr:nth-child(even) {background-color: #f2f2f2;} p {font-size: 13px;}</style>");
                    html.Append("</head><body style=\"font-size: 10px;\">");
                    html.Append($"<p>Dear {clientName},</p>");
                    html.Append("<p>Following is the summary of transactions executed/status updates for your client today:</p>");
                    html.Append($"<p>In case of any discrepancy or query, kindly reach out to your CXO - {csoName}.</p>");

                    // Build table
                    html.Append("<table><thead><tr>");
                    html.Append("<th>ORDER DATE</th><th>TRANSACTION DATE</th><th>PRODUCT</th><th>TRANSACTION TYPE</th>");
                    html.Append("<th>A/C TYPE</th><th>ACCOUNT CODE</th><th>SCHEME/SCRIP</th><th>ISIN</th>");
                    html.Append("<th>AMOUNT</th><th>UNITS</th><th>STATUS</th></tr></thead><tbody>");

                    foreach (var order in clientGroup)
                    {
                        var unitsText = order.Units != 0 ? order.Units.ToString() : " - ";
                        html.Append("<tr>");
                        html.Append($"<td>{order.OrderDate?.ToString("dd-MMM-yyyy")}</td>");
                        html.Append($"<td>{order.TransactionDate?.ToString("dd-MMM-yyyy")}</td>");
                        html.Append($"<td>{order.Category?.ToUpper()}</td>");
                        html.Append($"<td>{order.TransactionType?.ToUpper()}</td>");
                        html.Append($"<td>{order.AC_Type?.ToUpper()}</td>");
                        html.Append($"<td>{order.AccountCode?.ToUpper()}</td>");
                        html.Append($"<td>{order.SchemeOrScrip?.ToUpper()}</td>");
                        html.Append($"<td>{order.ISIN?.ToUpper()}</td>");
                        html.Append($"<td style=\"text-align: right;\">{order.Amount?.ToString("#,##0.00")}</td>");
                        html.Append($"<td style=\"text-align: right;\">{unitsText}</td>");
                        html.Append($"<td>{order.Status?.ToUpper()}</td>");
                        html.Append("</tr>");
                    }

                    html.Append("</tbody></table>");
                    html.Append("<p>Thanks & Regards,</p>");
                    html.Append("<p>This is a system-generated mail, please do not reply as it will not reach a mailbox.</p>");
                    html.Append("</body></html>");

                    // Prepare and send email
                    NotificationMessage message = new NotificationMessage
                    {
                        Invid = clientDetails?.InvId ?? 0,
                        FromAddress = clientDetails?.FromAddress ?? "",
                        ToAddress = "kinjal.vora@neo-group.in",
                        Ccaddress = "Rupak.Shukla@genietechno.com;pankaj.jadhav@genietechno.com",
                        Emailbody = html.ToString(),
                        Ismailsent = false,
                        Isactive = true,
                        Timestamp = DateTime.Now,
                        Subject = "Transaction Update for the day - " + DateTime.Now.ToString("dd-MMM-yyyy")
                    };

                    var isSent = InsertDataIntoNotificationMessages(message);
                    if (isSent)
                    {
                        sentEmails.Add(clientEmail);
                    }
                }

                return "Emails sent to the following clients: " + string.Join(", ", sentEmails);
            }
            catch (Exception ex)
            {
                _errorLogService.LogException(ex);
                throw;
            }
        }



        private bool InsertDataIntoNotificationMessages(NotificationMessage notificationMessage)
        {
            try
            {
                _dbContext.NotificationMessages.Add(new NotificationMessage
                {
                    Invid = notificationMessage.Invid,
                    FromAddress = notificationMessage.FromAddress,
                    ToAddress = notificationMessage.ToAddress,
                    Ccaddress = notificationMessage.Ccaddress,
                    Emailbody = notificationMessage.Emailbody,
                    Ismailsent = notificationMessage.Ismailsent,
                    Subject = notificationMessage.Subject,
                    Isactive = true,
                });

                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _errorLogService.LogException(ex);
                return false;
            }
        }

    }



}


















