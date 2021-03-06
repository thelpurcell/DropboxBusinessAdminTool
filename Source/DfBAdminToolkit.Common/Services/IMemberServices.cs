﻿using System.Collections.Generic;
using System;

namespace DfBAdminToolkit.Common.Services
{
    public interface IMemberServices {

        #region Endpoint urls

        string AddMemberUrl { get; set; }

        string RemoveMemberUrl { get; set; }

        string SuspendMemberUrl { get; set; }

        string UnSuspendMemberUrl { get; set; }

        string RecoverMemberUrl { get; set; }

        string ListMembersUrl { get; set; }

        string ListMembersContinuationUrl { get; set; }

        string SearchFilesUrl { get; set; }

        string ListFolderUrl { get; set; }

        string FileDumpUrl { get; set; }

        string GetDevicesUrl { get; set; }

        string DumpDevicesUrl { get; set; }

        string GetGroupsUrl { get; set; }

        string ExportGroupsUrl { get; set; }

        string ListSharedFoldersUrl { get; set; }

        string ListSharedFoldersContinuationUrl { get; set; }

        string RemoveSharedFolderMemberUrl { get; set; }

        string ExportGroupPermsUrl { get; set; }

        string ExportGroupPermsContinuationUrl { get; set; }

        string CreateGroupUrl { get; set; }

        string AddMemberGroupUrl { get; set; }

        string DeleteMemberGroupUrl { get; set; }

        string GetUsageUrl { get; set; }

        string GetInfoUrl { get; set; }

        string GetActivityUrl { get; set; }

        string GetDevicesReportUrl { get; set; }

        string GetStorageUrl { get; set; }

        string SetProfileUrl { get; set; }

        string GetEventsUrl { get; set; }

        string ActivateTeamFolderUrl { get; set; }

        string ArchiveTeamFolderUrl { get; set; }

        string SyncSettingTeamFolderUrl { get; set; }

        string CreateTeamFolderUrl { get; set; }

        string ListTeamFolderUrl { get; set; }

        string UpdateMembersTeamFolderUrl { get; set; }

        string ListPaperDocsUrl { get; set; }

        string GetPaperMetadataUrl { get; set; }

        string ArchivePaperDocUrl { get; set; }

        string PermDeletePaperDocUrl { get; set; }

        string DownloadPaperDocUrl { get; set; }

        string PaperDocFolderInfoUrl { get; set; }

        string GetCurrentAccountUrl{ get; set; }

        string UserAgentVersion { get; set; }

        #endregion Endpoint urls

        IServiceResponse AddMember(IMemberData data, string authToken);

        IServiceResponse RemoveMember(IMemberData data, string authToken);

        IServiceResponse SuspendMember(IMemberData data, string authToken);

        IServiceResponse UnSuspendMember(IMemberData data, string authToken);

        IServiceResponse RecoverMember(IMemberData data, string authToken);

        IDataResponse ListMembers(IMemberData data, string authToken);

        IDataResponse SearchFiles(IMemberData data, string authToken);

        IDataResponse ListFolders(IMemberData data, string authToken);

        IDataResponse GetUsage(IMemberData data, string authToken);

        IDataResponse GetInfo(string authToken);

        IDataResponse GetActivity(string authToken);

        IDataResponse GetDevicesReport(string authToken);

        IDataResponse GetStorage(string authToken);

        IServiceResponse SetProfile(IMemberData data, string authToken);

        IDataResponse GetGroups(IMemberData data, string authToken);

        IDataResponse ListSharedFolders(IMemberData data, string authToken);

        IServiceResponse RemoveSharedFolderMember(string ownerId, string sharedFolderId, string email, string authToken);

        IDataResponse ExportGroups(IMemberData data, List<string> groupIds, string authToken);

        IDataResponse ExportGroupPerms(IMemberData data, string shareId, string authToken);

        IServiceResponse CreateGroup(string groupName, string groupType, string authToken);

        IServiceResponse AddMemberGroup(IMemberData data, string authToken);

        IServiceResponse DeleteMemberGroup(IMemberData data, string email, string authToken);

        IDataResponse DumpFile(IMemberData data, string outputFolder, string authToken);

        IDataResponse FindDevices(IMemberData data, string authToken);

        IDataResponse DumpDevices(IMemberData data, string authToken, bool remoteWipe);

        IDataResponse ListTeamFolders(string authToken);

        IServiceResponse CreateTeamFolder(string teamFolderName, string authToken);

        IServiceResponse SetTeamFolderStatus(string teamFolderId, bool activeSetting, string authToken);

        IServiceResponse SetFolderSyncSetting(string teamFolderId, string syncSetting, string authToken);

        IDataResponse GetEvents(IMemberData data, string authToken, DateTime startTime, DateTime finishTime);

        IDataResponse ListPaperDocs(IMemberData data, string authToken);

        IDataResponse GetPaperMetadata(string docId, string authToken, string memberId);

        IDataResponse ArchivePaperDoc(string memberId, string authToken, string docId);

        IDataResponse PermDeletePaperDoc(string memberId, string authToken, string docId);

        IDataResponse DownloadPaperDoc(string memberId, string docId, string outputFolder, string fileName, string authToken);

        IDataResponse GetPaperDocFolderInfo(string docId, string authToken, string memberId);

        IDataResponse GetCurrentAccount(string authToken);
    }
}