﻿using System.Collections.Generic;
using Datory;

namespace SSCMS.Cli.Updater.Tables.GovInteract
{
    public partial class TableGovInteractPermissions
    {
        public const string OldTableName = "wcm_GovInteractPermissions";

        public static ConvertInfo Converter => new ConvertInfo
        {
            NewTableName = NewTableName,
            NewColumns = NewColumns,
            ConvertKeyDict = ConvertKeyDict,
            ConvertValueDict = ConvertValueDict
        };

        private static readonly string NewTableName = "ss_govinteract_permissions";

        private static readonly List<TableColumn> NewColumns = new List<TableColumn>
        {
            new TableColumn
            {
                AttributeName = "Id",
                DataType = DataType.Integer,
                IsPrimaryKey = true,
                IsIdentity = true
            },
            new TableColumn
            {
                AttributeName = "UserName",
                DataType = DataType.VarChar,
                DataLength = 50
            },
            new TableColumn
            {
                AttributeName = "ChannelId",
                DataType = DataType.Integer
            },
            new TableColumn
            {
                AttributeName = "Permissions",
                DataType = DataType.Text
            }
        };

        private static readonly Dictionary<string, string> ConvertKeyDict =
            new Dictionary<string, string>
            {
                {"ChannelId", nameof(NodeId)}
            };

        private static readonly Dictionary<string, string> ConvertValueDict = null;
    }
}
