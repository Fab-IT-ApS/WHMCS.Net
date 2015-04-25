﻿
namespace Whmcs.Tests.TestableData
{
    public class GetTestData
    {
        public readonly string Products = "{\"result\":\"success\",\"totalresults\":1,\"products\":{\"product\":[{\"pid\":\"98\",\"gid\":\"25\",\"type\":\"other\",\"name\":\"TestProduct#1\",\"description\":\"This is a Product#1\\r\\nDescription\\r\\nPage\",\"module\":\"\",\"paytype\":\"recurring\",\"pricing\":{\"DKK\":{\"prefix\":\"\",\"suffix\":\" kr\",\"msetupfee\":\"0.00\",\"qsetupfee\":\"0.00\",\"ssetupfee\":\"0.00\",\"asetupfee\":\"0.00\",\"bsetupfee\":\"0.00\",\"tsetupfee\":\"0.00\",\"monthly\":\"-1.00\",\"quarterly\":\"-1.00\",\"semiannually\":\"-1.00\",\"annually\":\"-1.00\",\"biennially\":\"-1.00\",\"triennially\":\"-1.00\"},\"EUR\":{\"prefix\":\"\\u20ac\",\"suffix\":\"EUR\",\"msetupfee\":\"0.00\",\"qsetupfee\":\"0.00\",\"ssetupfee\":\"0.00\",\"asetupfee\":\"0.00\",\"bsetupfee\":\"0.00\",\"tsetupfee\":\"0.00\",\"monthly\":\"-1.00\",\"quarterly\":\"-1.00\",\"semiannually\":\"-1.00\",\"annually\":\"-1.00\",\"biennially\":\"-1.00\",\"triennially\":\"-1.00\"},\"USD\":{\"prefix\":\"$\",\"suffix\":\"USD\",\"msetupfee\":\"0.00\",\"qsetupfee\":\"0.00\",\"ssetupfee\":\"0.00\",\"asetupfee\":\"0.00\",\"bsetupfee\":\"0.00\",\"tsetupfee\":\"0.00\",\"monthly\":\"-1.00\",\"quarterly\":\"-1.00\",\"semiannually\":\"-1.00\",\"annually\":\"-1.00\",\"biennially\":\"-1.00\",\"triennially\":\"-1.00\"}},\"customfields\":{\"customfield\":[]},\"configoptions\":{\"configoption\":[{\"id\":\"11\",\"name\":\"Performance Dedicated server\",\"type\":\"3\",\"options\":{\"option\":[{\"id\":\"23\",\"name\":\"Opgrader standard diske til 600GB SSD\",\"recurring\":0,\"pricing\":{\"DKK\":{\"msetupfee\":\"450.00\",\"qsetupfee\":\"0.00\",\"ssetupfee\":\"0.00\",\"asetupfee\":\"0.00\",\"bsetupfee\":\"0.00\",\"tsetupfee\":\"0.00\",\"monthly\":\"400.00\",\"quarterly\":\"1000.00\",\"semiannually\":\"0.00\",\"annually\":\"0.00\",\"biennially\":\"0.00\",\"triennially\":\"0.00\"},\"EUR\":{\"msetupfee\":\"60.30\",\"qsetupfee\":\"0.00\",\"ssetupfee\":\"0.00\",\"asetupfee\":\"0.00\",\"bsetupfee\":\"0.00\",\"tsetupfee\":\"0.00\",\"monthly\":\"53.60\",\"quarterly\":\"134.01\",\"semiannually\":\"0.00\",\"annually\":\"0.00\",\"biennially\":\"0.00\",\"triennially\":\"0.00\"},\"USD\":{\"msetupfee\":\"64.79\",\"qsetupfee\":\"0.00\",\"ssetupfee\":\"0.00\",\"asetupfee\":\"0.00\",\"bsetupfee\":\"0.00\",\"tsetupfee\":\"0.00\",\"monthly\":\"57.59\",\"quarterly\":\"143.97\",\"semiannually\":\"0.00\",\"annually\":\"0.00\",\"biennially\":\"0.00\",\"triennially\":\"0.00\"}}}]}}]}}]}}";
        public readonly string Clients = "{\"result\":\"success\",\"totalresults\":\"1\",\"startnumber\":0,\"numreturned\":1,\"clients\":{\"client\":[{\"id\":\"88\",\"firstname\":\"John\",\"lastname\":\"Doe\",\"companyname\":\"CompanyName\",\"email\":\"Name@Company.tls\",\"datecreated\":\"2015-04-22\",\"groupid\":\"1\",\"status\":\"Active\"}]}}";
        public readonly string ClientDetails = "{\"result\":\"success\",\"userid\":\"88\",\"id\":\"88\",\"firstname\":\"John\",\"lastname\":\"Doe\",\"fullname\":\"John Doe\",\"companyname\":\"CompanyName\",\"email\":\"Name@Company.tls\",\"address1\":\"JohnDoeAddress1\",\"address2\":\"JohnDoeAddress2\",\"city\":\"JohnDoeCity\",\"fullstate\":\"JohnDoeStateOrRegion\",\"state\":\"JohnDoeStateOrRegion\",\"postcode\":\"9999\",\"countrycode\":\"DK\",\"country\":\"DK\",\"statecode\":\"JohnDoeStateOrRegion\",\"countryname\":\"Denmark\",\"phonecc\":45,\"phonenumber\":\"11 22 33 44\",\"phonenumberformatted\":\"+45.11223344\",\"billingcid\":\"0\",\"notes\":\"This here, is Admin Notes for John Doe @ CompanyName\",\"password\":\"5696965d6d07ba73c544f14a5a3fc8d8:VDP!c\",\"twofaenabled\":false,\"currency\":\"1\",\"defaultgateway\":\"\",\"cctype\":\"\",\"cclastfour\":\"\",\"securityqid\":\"1\",\"securityqans\":\"JohnsSpecialCatLikeCreature\",\"groupid\":\"1\",\"status\":\"Active\",\"credit\":\"0.00\",\"taxexempt\":\"\",\"latefeeoveride\":\"\",\"overideduenotices\":\"\",\"separateinvoices\":\"\",\"disableautocc\":\"\",\"emailoptout\":\"0\",\"overrideautoclose\":\"0\",\"language\":\"\",\"lastlogin\":\"No Login Logged\",\"customfields1\":\"\",\"customfields\":[{\"id\":\"1\",\"value\":\"\"},{\"id\":\"29\",\"value\":\"IDunno?\"},{\"id\":\"32\",\"value\":\"Whmcs.EasyApi test\"},{\"id\":\"33\",\"value\":\"SomeRquiredField!\"},{\"id\":\"34\",\"value\":\"b\"}],\"customfields2\":\"IDunno?\",\"customfields3\":\"Whmcs.EasyApi test\",\"customfields4\":\"SomeRquiredField!\",\"customfields5\":\"b\",\"currency_code\":\"DKK\"}";
    }
}
