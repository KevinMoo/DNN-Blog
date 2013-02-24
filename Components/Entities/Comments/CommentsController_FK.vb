Imports System
Imports System.Data
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Imports DotNetNuke
Imports DotNetNuke.Common
Imports DotNetNuke.Common.Utilities
Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.Entities.Portals
Imports DotNetNuke.Services.Tokens

Imports DotNetNuke.Modules.Blog.Data

Namespace Entities.Comments

 Partial Public Class CommentsController

  Public Shared Function GetCommentsByContentItem(contentItemId As Int32 , IncludeNonApproved As Boolean) As List(Of CommentInfo)

   Return DotNetNuke.Common.Utilities.CBO.FillCollection(Of CommentInfo)(DataProvider.Instance().GetCommentsByContentItem(contentItemId, IncludeNonApproved))

  End Function

 End Class
End Namespace

