Imports System
Imports DotNetNuke

Namespace Data

 Partial Public MustInherit Class DataProvider

#Region " BlogPermission Methods "
  Public MustOverride Function GetBlogPermissionsByBlog(blogID As Int32, StartRowIndex As Integer, MaximumRows As Integer, OrderBy As String) As IDataReader
#End Region

#Region " Blog Methods "
  Public MustOverride Function GetBlogsByModule(moduleID As Int32, StartRowIndex As Integer, MaximumRows As Integer, OrderBy As String) As IDataReader
  Public MustOverride Function GetBlogsByCreatedByUser(userID As Int32, StartRowIndex As Integer, MaximumRows As Integer, OrderBy As String) As IDataReader
#End Region

#Region " Comment Methods "
  Public MustOverride Function GetCommentsByContentItem(contentItemId As Int32, IncludeNonApproved As Boolean) As IDataReader
#End Region

#Region " Entry Methods "
  Public MustOverride Function GetEntriesByBlog(blogID As Int32, StartRowIndex As Integer, MaximumRows As Integer, OrderBy As String) As IDataReader
#End Region

 End Class

End Namespace

