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

  Public Shared Function GetComment(commentID As Int32) As CommentInfo

   Return CType(CBO.FillObject(DataProvider.Instance().GetComment(commentID), GetType(CommentInfo)), CommentInfo)

  End Function

  Public Shared Function AddComment(ByRef objComment As CommentInfo) As Integer

   objComment.CommentID = CType(DataProvider.Instance().AddComment(objComment.AddedDate, objComment.Approved, objComment.Author, objComment.Comment, objComment.ContentItemId, objComment.Email, objComment.Title, objComment.UserID, objComment.Website), Integer)
   Return objComment.CommentID

  End Function

  Public Shared Sub UpdateComment(objComment As CommentInfo)

   DataProvider.Instance().UpdateComment(objComment.AddedDate, objComment.Approved, objComment.Author, objComment.Comment, objComment.CommentID, objComment.ContentItemId, objComment.Email, objComment.Title, objComment.UserID, objComment.Website)

  End Sub

  Public Shared Sub DeleteComment(commentID As Int32)

   DataProvider.Instance().DeleteComment(commentID)

  End Sub

 End Class
End Namespace

