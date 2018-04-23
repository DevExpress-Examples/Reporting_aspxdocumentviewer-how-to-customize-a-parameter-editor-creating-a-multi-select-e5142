Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports System.Collections.Generic
Imports System.Linq

Namespace E5142
	Partial Public Class ProductsReport
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub ProductsReport_DataSourceDemanded(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.DataSourceDemanded
			Dim categories() As String = Convert.ToString(Me.Parameters("Categories").Value).Split("|"c)
			Dim selectedCategories As New List(Of Integer)()
			For Each category As String In categories
				Dim categoryID As Integer
				If Int32.TryParse(category, categoryID) Then
					selectedCategories.Add(categoryID)
				End If
			Next category

			Dim db As New NWindEntities()
			Me.DataSource = _
				From product In db.Products _
				Where product.CategoryID.HasValue AndAlso selectedCategories.Contains(product.CategoryID.Value) _
				Select product
		End Sub

	End Class
End Namespace
