﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenseNet.Search
{
    public partial class SnQuery
    {
        private static IPermissionFilterFactory PermissionFilterFactory = new DefaultPermissionFilterFactory();
        private static IQueryEngineSelector QueryEngineSelector = new DefaultQueryEngineSelector();
        private static IQueryParserFactory QueryParserFactory = new DefaultQueryParserFactory();

        private static IQueryResult<int> Query(string queryText, QuerySettings settings, int userId)
        {
            var query = QueryParserFactory.Create().Parse(queryText, settings);
            var permissionFilter = PermissionFilterFactory.Create(userId);
            var engine = QueryEngineSelector.Select(query, settings);
            return engine.ExecuteQuery(query, permissionFilter);
        }
        private static IQueryResult<string> QueryAndProject(string queryText, QuerySettings settings, int userId)
        {
            var query = QueryParserFactory.Create().Parse(queryText, settings);
            var permissionFilter = PermissionFilterFactory.Create(userId);
            var engine = QueryEngineSelector.Select(query, settings);
            return engine.ExecuteQueryAndProject(query, permissionFilter);
        }
    }
}
