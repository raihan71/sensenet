﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net.Analysis;

namespace SenseNet.Search.Tests.Implementations
{
    public class TestIndexFieldHandler_string : IFieldIndexHandler
    {
        public bool Compile(IQueryCompilerValue value)
        {
            value.Set(value.StringValue.ToLowerInvariant());
            return true;
        }
        public bool TryParseAndSet(IQueryFieldValue value)
        {
            throw new NotImplementedException();
        }

        public void ConvertToTermValue(IQueryFieldValue value)
        {
            throw new NotImplementedException();
        }

        public string GetDefaultAnalyzerName()
        {
            return typeof(KeywordAnalyzer).FullName;
        }

        public IEnumerable<string> GetParsableValues(ISnField field)
        {
            throw new NotImplementedException();
        }

        public int SortingType { get; }
        public IndexFieldType IndexFieldType { get; } = IndexFieldType.String;
        public IPerFieldIndexingInfo OwnerIndexingInfo { get; set; }
        public string GetSortFieldName(string fieldName)
        {
            return fieldName;
        }

        public IEnumerable<IIndexFieldInfo> GetIndexFieldInfos(ISnField field, out string textExtract)
        {
            throw new NotImplementedException();
        }
    }
    public class TestIndexFieldHandler_long : IFieldIndexHandler
    {
        public bool Compile(IQueryCompilerValue value)
        {
            throw new NotImplementedException();

            value.Set(long.Parse(value.StringValue));
            return true;
        }
        public bool TryParseAndSet(IQueryFieldValue value)
        {
            throw new NotImplementedException();
        }

        public void ConvertToTermValue(IQueryFieldValue value)
        {
            throw new NotImplementedException();
        }

        public string GetDefaultAnalyzerName()
        {
            return typeof(KeywordAnalyzer).FullName;
        }

        public IEnumerable<string> GetParsableValues(ISnField field)
        {
            throw new NotImplementedException();
        }

        public int SortingType { get; }
        public IndexFieldType IndexFieldType { get; } = IndexFieldType.String;
        public IPerFieldIndexingInfo OwnerIndexingInfo { get; set; }
        public string GetSortFieldName(string fieldName)
        {
            return fieldName;
        }

        public IEnumerable<IIndexFieldInfo> GetIndexFieldInfos(ISnField field, out string textExtract)
        {
            throw new NotImplementedException();
        }
    }
    public class TestIndexFieldHandler_double : IFieldIndexHandler
    {
        public bool Compile(IQueryCompilerValue value)
        {
            throw new NotImplementedException();

            value.Set(double.Parse(value.StringValue));
            return true;
        }

        public bool TryParseAndSet(IQueryFieldValue value)
        {
            throw new NotImplementedException();
        }
        public void ConvertToTermValue(IQueryFieldValue value)
        {
            throw new NotImplementedException();
        }

        public string GetDefaultAnalyzerName()
        {
            return typeof(KeywordAnalyzer).FullName;
        }

        public IEnumerable<string> GetParsableValues(ISnField field)
        {
            throw new NotImplementedException();
        }

        public int SortingType { get; }
        public IndexFieldType IndexFieldType { get; } = IndexFieldType.String;
        public IPerFieldIndexingInfo OwnerIndexingInfo { get; set; }
        public string GetSortFieldName(string fieldName)
        {
            return fieldName;
        }

        public IEnumerable<IIndexFieldInfo> GetIndexFieldInfos(ISnField field, out string textExtract)
        {
            throw new NotImplementedException();
        }
    }
}