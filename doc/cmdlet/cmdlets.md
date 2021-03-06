# Cmdlets

Here lists all cmdlets provided from ImageStore.

# Database
Operates on [database](../concept/database.md) connection or shrinks database.

|Command|Alias|Description|
|---|---|---|
|[Open-ImageStoreDatabase](Database/OpenDatabase.md)|OpenDatabase|Sets connection string and opens connection to the target database.|
|[Compress-ImageStoreDatabase](Database/CompressDatabase.md)|ShrinkDatabase, CompressDatabase, Shrink-ImageStoreDatabase|Runs ShrinkDatabase command in connected database to shrink the size of the data and log files.|
|[Close-ImageStoreDatabase](Database/CloseDatabase.md)|CloseDatabase|Closes the connection to the database.|

# Folder
Manages [folders](../concept/folder.md).

|Command|Alias|Description|
|---|---|---|
|[Add-ImageStoreFolder](Folder/AddFolder.md)|AddFolder|Creates and adds a folder record to database.|
|[Clear-ImageStoreEmptyFolders](Folder/ClearEmptyFolders.md)|ClearEmptyFolder|Clears empty directories from file system within the folder specified.|
|[Find-ImageStoreFolder](Folder/FindFolder.md)|FindFolder|Finds the record related to the folder by name.|
|[Get-ImageStoreFolder](Folder/GetFolder.md)|GetFolder|Gets the record related to the folder by id.|
|[Remove-ImageStoreFolder](Folder/RemoveFolder.md)|RemoveFolder|Removes the folder record specified from database.|
|[Search-ImageStoreFolder](Folder/SearchFolder.md)|SearchFolder|Searches all folders records matched with the conditions provided.|
|[Sync-ImageStoreFolder](Folder/SyncFolder.md)|SyncFolder|Syncs the database to make records consistent with file system.|
|[Update-ImageStoreFolder](Folder/UpdateFolder.md)|UpdateFolder|Updates the folder record by the entity provided.|

# Extension
Manages [extensions](../concept/Extension.md).

|Command|Alias|Description|
|---|---|---|
|[Add-ImageStoreExtension](Extension/AddExtension.md)|AddExtension|Creates and adds an extension to database.|
|[Find-ImageStoreExtension](Extension/FindExtension.md)|FindExtension|Finds the record related to the extension by name.|
|[Get-ImageStoreExtension](Extension/GetExtension.md)|GetExtension|Gets the record by id.|
|[Remove-ImageStoreExtension](Extension/RemoveExtension.md)|RemoveExtension|Removes the extension record specified from database.|
|[Search-ImageStoreExtension](Extension/SearchExtension.md)|SearchExtension|Searches all extensions records matched with the conditions provided.|
|[Update-ImageStoreExtension](Extension/UpdateExtension.md)|UpdateExtension|Updates the extension record by the entity provided.|

# Ignored Directory
Manages the directories excluded from folders.

|Command|Alias|Description|
|---|---|---|
|[Add-ImageStoreIgnoredDirectory](IgnoredDirectory/AddIgnoredDirectory.md)|AddIgnoredDirectory|Creates and adds an ignored directory record to database.|
|[Find-ImageStoreIgnoredDirectory](IgnoredDirectory/FindIgnoredDirectory.md)|FindIgnoredDirectory|Finds the record related to the ignored directory by all properties.|
|[Get-ImageStoreIgnoredDirectory](IgnoredDirectory/GetIgnoredDirectory.md)|GetIgnoredDirectory|Gets the record of ignored directory by id.|
|[Remove-ImageStoreIgnoredDirectory](IgnoredDirectory/RemoveIgnoredDirectory.md)|RemoveIgnoredDirectory|Removes the ignored directory record specified from database.|
|[Search-ImageStoreIgnoredDirectory](IgnoredDirectory/SearchIgnoredDirectory.md)|SearchIgnoredDirectory|Searches all ignored directory records matched with the conditions provided.|
|[Update-ImageStoreIgnoredDirectory](IgnoredDirectory/UpdateIgnoredDirectory.md)|UpdateIgnoredDirectory|Updates the ignored directory record by the entity provided.|

# File
Manages [files](../concept/File.md) and computes hashing results.

|Command|Alias|Description|
|---|---|---|
|[Add-ImageStoreFile](File/AddFile.md)|AddFile|Creates and adds a file record to database.|
|[Find-ImageStoreFile](File/FindFile.md)|FindFolder|Finds the record related to the file by folder, path and file name.|
|[Get-ImageStoreFile](File/GetFile.md)|GetFile|Gets the record related to the file by id.|
|[Measure-ImageStoreFile](File/MeasureFile.md)|MeasureFile|Computes hashing result of the file specified.|
|[Measure-ImageStoreFiles](File/MeasureFiles.md)|MeasureFiles|Computes hashing result of the files within the folder specified.|
|[Move-ImageStoreFile](File/MoveFile.md)|MoveFile|Moves the file record specified and the pointed file to the target folder and directory.|
|[Remove-ImageStoreDirectory](File/RemoveDirectory.md)|RemoveDirectory|Removes the directory specified, including all files and sub directories, from database and file system.|
|[Remove-ImageStoreFile](File/RemoveFile.md)|RemoveFile|Removes the file record specified and the pointed file.|
|[Rename-ImageStoreFile](File/RenameFile.md)|RenameFile|Renames the file record specified and the pointed file.|
|[Resolve-ImageStoreFile](File/ResolveFile.md)|ResolveFile|Gets the full path of the file specified.|
|[Search-ImageStoreFile](File/SearchFile.md)|SearchFile|Searches all files records matched with the conditions provided.|
|[Update-ImageStoreFile](file/UpdateFile.md)|UpdateFile|Updates the file record by the entity provided.|

# Same File
Generates, manages and deals with [same files](../concept/SameFile.md) records based on file hashing result using Sha1 algorithm.

|Command|Alias|Description|
|---|---|---|
|[Clear-ImageStoreSameFileObsoletedGroups](SameFile/ClearSameFileObsoletedGroups.md)|ClearSameFileObsoletedGroups|Clears same file groups which have only one record left.|
|[Compare-ImageStoreSameFiles](SameFile/CompareSameFiles.md)|CompareSameFiles|Compares file hashing result and generates same file groups.|
|[Get-ImageStoreSameFile](SameFile/GetSameFile.md)|GetSameFile|Gets the record of same file by id.|
|[Hide-ImageStoreSameFile](SameFile/HideSameFile.md)|HideSameFile|Marks the record of same file as ignored.|
|[Remove-ImageStoreSameFile](SameFile/RemoveSameFile.md)|RemoveSameFile|Removes the same file record specified.|
|[Remove-ImageStoreSameFileGroup](SameFile/RemoveSameFileGroup.md)|RemoveSameFileGroup|Removes same file records by file hashing result specified.|
|[Search-ImageStoreSameFile](SameFile/SearchSameFile.md)|SearchSameFile|Searches all same file records matched with the conditions provided.|
|[Select-ImageStoreSameFile](SameFile/SelectSameFile.md)|SelectSameFile|Deals with found same files and selects records for further operating, like removal.|
|[Show-ImageStoreSameFile](SameFile/ShowSameFile.md)|ShowSameFile|Marks the record of same file as effective, not ignored.|
|[Update-ImageStoreSameFile](SameFile/UpdateSameFile.md)|UpdateSameFile|Updates the same file record by the entity provided.|

# Similar File
Generates, manages and deals with [similar files](../concept/SimilarFile.md) records based on image hashing result using priHash algorithm.

|Command|Alias|Description|
|---|---|---|
|[Clear-ImageStoreThumbprintCache](SimilarFile/ClearThumbprintCache.md)|ClearThumbprintCache|Deletes all thumbprint cache data used by [Resolve-ImageStoreSimilarFiles](SimilarFile/ResolveSimilarFiles.md).|
|[Clear-ImageStoreThumbprintCacheFolder](SimilarFile/ClearThumbprintCacheFolder.md)|ClearThumbprintCacheFolder|Disables thumbprint cache function by clearing the path setting of the cache folder.|
|[Compare-ImageStoreSimilarFiles](SimilarFile/CompareSimilarFiles.md)|CompareSimilarFiles|Compares image hashing result and generates similar file relation records.|
|[Get-ImageStoreSimilarFile](SimilarFile/GetSimilarFile.md)|GetSimilarFile|Gets the record of similar file relation by id.|
|[Hide-ImageStoreSimilarFile](SimilarFile/HideSimilarFile.md)|HideSimilarFile|Marks the record of similar file relation as ignored.|
|[Remove-ImageStoreSimilarFile](SimilarFile/RemoveSimilarFile.md)|RemoveSimilarFile|Removes the record of similar file relation specified.|
|[Reset-ImageStoreSimilarFiles](SimilarFile/ResetSimilarFiles.md)|ResetSimilarFiles|Removes all records of similar file relations and reset all file records to the state before comparing similar files.|
|[Resolve-ImageStoreSimilarFiles](SimilarFile/ResolveSimilarFiles.md)|ResolveSimilarFiles|Deals with found similar files and selects files for further operating, like removal.|
|[Search-ImageStoreSimilarFile](SimilarFile/SearchSimilarFile.md)|SearchSimilarFile|Searches all records of similar file relations matched with the condition provided.|
|[Set-ImageStoreThumbprintCacheFolder](SimilarFile/SetThumbprintCacheFolder.md)|SetThumbprintCacheFolder|Enables thumbprint cache function by setting the path setting of the cache folder.|
|[Show-ImageStoreSimilarFile](SimilarFile/ShowSimilarFile.md)|ShowSimilarFile|Marks the record of similar file relation as effective, not ignored.|
|[Update-ImageStoreSimilarFile](SimilarFile/UpdateSimilarFile.md)|UpdateSimilarFile|Updates the record of similar file relation by the entity provided.|