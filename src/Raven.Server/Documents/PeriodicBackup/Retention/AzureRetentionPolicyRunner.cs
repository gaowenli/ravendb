using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Raven.Client.Documents.Operations.Backups;
using Raven.Server.Documents.PeriodicBackup.Azure;

namespace Raven.Server.Documents.PeriodicBackup.Retention
{
    public class AzureRetentionPolicyRunner : RetentionPolicyRunnerBase
    {
        private readonly RavenAzureClient _client;

        protected override string Name => "Azure";

        public AzureRetentionPolicyRunner(RetentionPolicy retentionPolicy, string databaseName, Action<string> onProgress, RavenAzureClient client)
            : base(retentionPolicy, databaseName, onProgress)
        {
            _client = client;
        }

        protected override Task<List<string>> GetFolders()
        {
            throw new NotSupportedException();
        }

        protected override string GetFolderName(string folderPath)
        {
            throw new NotSupportedException();
        }

        protected override Task<List<string>> GetFiles(string folder)
        {
            throw new NotSupportedException();
        }

        protected override Task DeleteFolders(List<FolderDetails> folderDetails)
        {
            throw new NotSupportedException();
        }
    }
}
