Imports System.Windows
Imports DevExpress.Xpf.Grid
Imports DevExpress.Mvvm.UI.Interactivity
Imports DevExpress.Mvvm.DataAnnotations
Imports System.Collections.ObjectModel

Namespace DXGridSample
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    <POCOViewModel> _
    Public Class MainViewModel
        Public Overridable Property Items() As ObservableCollection(Of Item)
        Public Sub New()
            Items = New ObservableCollection(Of Item)()
            For i As Integer = 0 To 99
                Items.Add(New Item With { _
                    .Id = i, _
                    .Name = "Name" & i _
                })
            Next i
        End Sub
    End Class
    Public Class Item
        Public Property Id() As Integer
        Public Property Name() As String
    End Class

    Public Class Behavior
        Inherits Behavior(Of ExtendedColumnChooserGridColumnHeader)

        Protected Overrides Sub OnAttached()
            MyBase.OnAttached()
            AddHandler AssociatedObject.PreviewMouseDoubleClick, AddressOf AssociatedObject_PreviewMouseDoubleClick
        End Sub
        Protected Overrides Sub OnDetaching()
            RemoveHandler AssociatedObject.PreviewMouseDoubleClick, AddressOf AssociatedObject_PreviewMouseDoubleClick
            MyBase.OnDetaching()
        End Sub
        Private Sub AssociatedObject_PreviewMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs)
            Dim clickedColumn As GridColumn = CType(AssociatedObject.DataContext, GridColumn)
            If CType(clickedColumn.View, TableView).VisibleColumns.Count = 1 AndAlso clickedColumn.Visible Then
                Return
            End If
            clickedColumn.Visible = Not clickedColumn.Visible
        End Sub
    End Class
End Namespace