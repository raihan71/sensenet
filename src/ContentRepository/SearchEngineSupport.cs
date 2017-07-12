﻿using System.Linq;
using SenseNet.ContentRepository.Fields;
using SenseNet.ContentRepository.Schema;
using SenseNet.ContentRepository.Storage;
using SenseNet.ContentRepository.Storage.Search;
using SenseNet.Search;

namespace SenseNet.ContentRepository
{
    internal class SearchEngineSupport : ISearchEngineSupport
    {
        public bool RestoreIndexOnstartup()
        {
            return RepositoryInstance.RestoreIndexOnStartup();
        }

        public int[] GetNotIndexedNodeTypeIds()
        {
            return new AllContentTypes()
                .Where(c => !c.IndexingEnabled)
                .Select(c => Storage.Schema.NodeType.GetByName(c.Name).Id)
                .ToArray();
        }

        public IPerFieldIndexingInfo GetPerFieldIndexingInfo(string fieldName)
        {
            var ensureStart = ContentTypeManager.Current;
            return ContentTypeManager.GetPerFieldIndexingInfo(fieldName);
        }

        public bool IsContentTypeIndexed(string contentTypeName)
        {
            var ct = ContentType.GetByName(contentTypeName);
            if (ct == null)
                return true;
            return ct.IndexingEnabled;
        }

        public bool TextExtractingWillBePotentiallySlow(IIndexableField field)
        {
            return TextExtractor.TextExtractingWillBePotentiallySlow((BinaryData) ((BinaryField) field).GetData());
        }
    }
}