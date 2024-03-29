using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using ePlatform.Api.Core.QueryBuilder;
using Newtonsoft.Json;

namespace ePlatform.Api.Core.Extensions
{
    public static class RegexExtention
    {
        public static bool checkDateFormat(string date)
        {
            string rx = @"^(0[1-9]|[12][0-9]|3[01])[.](0[1-9]|[1][012])[.]([0-9]{4})$";
            var match = Regex.Match(date, rx);

            return match.Success;
        }
        public static bool checkAllDateFormat(PagingModel model)
        {
            var parsedModel = JsonConvert.DeserializeObject<List<QueryFilter>>(model.QueryFilter);

            string rx = @"^*(date|Date)\z";
            foreach (var item in parsedModel)
            {
                var match = Regex.Match(item.Category, rx);
                if (match.Success)
                {
                    if (!checkDateFormat(item.Value.ToString()))
                        throw new Exception(item.Category + " Date Format should be dd.mm.YYYY");
                }
            }
            return true;
        }
    }
}