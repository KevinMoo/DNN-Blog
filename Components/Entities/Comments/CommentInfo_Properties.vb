Imports System
Imports System.Runtime.Serialization

Namespace Entities.Comments
  Partial Public Class CommentInfo
#Region " Private Members "
#End Region
	
#Region " Constructors "
  Public Sub New()
  End Sub
#End Region

#Region " Public Properties "
  <DataMember()>
  Public Property CommentID As Int32 = -1
  <DataMember()>
  Public Property ContentItemId As Int32 = -1
  <DataMember()>
  Public Property UserID As Int32 = -1
  <DataMember()>
  Public Property Comment As String = ""
  <DataMember()>
  Public Property AddedDate As Date = Date.MinValue
  <DataMember()>
  Public Property Title As String = ""
  <DataMember()>
  Public Property Approved As Boolean = False
  <DataMember()>
  Public Property Author As String = ""
  <DataMember()>
  Public Property Website As String = ""
  <DataMember()>
  Public Property Email As String = ""
  <DataMember()>
  Public Property Username As String = ""
  <DataMember()>
  Public Property DisplayName As String = ""
#End Region

 End Class
End Namespace


