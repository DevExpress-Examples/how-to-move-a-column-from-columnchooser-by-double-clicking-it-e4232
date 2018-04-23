Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports System.Windows.Input
Imports System.Collections.ObjectModel
Imports DevExpress.Xpf.Grid

Namespace ColumnChooserDoubleClick
	Partial Public Class MainWindow
		Inherits Window

		Public records As ObservableCollection(Of Record)

		Public Sub New()
			InitializeComponent()
			FillData()
		End Sub

		Public Sub FillData()
			records = New ObservableCollection(Of Record)()
			records.Add(New Record("a", "a", "a", "a", "a"))
			records.Add(New Record("b", "b", "b", "b", "b"))
			records.Add(New Record("c", "c", "c", "c", "c"))

			gridControl1.ItemsSource = records
			ColumnChooserInit()
		End Sub

		Private Sub ColumnChooserInit()
			gridControl1.Columns(1).Visible = False
			gridControl1.Columns(2).Visible = False
			gridControl1.View.ShowColumnChooser()
		End Sub
		Private Sub GridColumnHeader_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
			Dim header As GridColumnHeader = TryCast(sender, GridColumnHeader)
			Dim gc As GridColumn = CType(header.DataContext, GridColumn)
			Dim lst As List(Of ColumnBase) = gridControl1.View.ColumnChooserColumns.ToList()
			For i As Integer = 0 To lst.Count - 1
				If gc.ActualColumnChooserHeaderCaption = lst(i).ActualColumnChooserHeaderCaption Then
					lst(i).Visible = True
					Exit For
				End If
			Next i
		End Sub
	End Class
End Namespace
