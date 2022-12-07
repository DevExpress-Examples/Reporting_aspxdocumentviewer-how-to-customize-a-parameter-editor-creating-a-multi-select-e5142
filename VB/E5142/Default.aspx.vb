Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Namespace E5142
	Partial Public Class [Default]
		Inherits System.Web.UI.Page
		Private db As New NWindEntities()

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub documentViewer_CustomizeParameterEditors(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Web.CustomizeParameterEditorsEventArgs)
			If e.Parameter.Name = "Categories" Then
				Dim customParameterEditor As New ASPxTokenBox() With {.ID = "tbCategories"}
				e.Editor = customParameterEditor
				AddHandler customParameterEditor.Init, AddressOf customParameterEditor_Init
			End If
		End Sub

		Private Sub customParameterEditor_Init(ByVal sender As Object, ByVal e As EventArgs)
			Dim customParameterEditor As ASPxTokenBox = TryCast(sender, ASPxTokenBox)
			customParameterEditor.AllowCustomTokens = False
			customParameterEditor.ShowDropDownOnFocus = ShowDropDownOnFocusMode.Always

			customParameterEditor.ValueField = "CategoryID"
			customParameterEditor.TextField = "CategoryName"
			customParameterEditor.ValueSeparator = "|"c

			customParameterEditor.DataSource = _
				From category In db.Categories _
				Select category
			customParameterEditor.DataBindItems()
		End Sub
	End Class
End Namespace