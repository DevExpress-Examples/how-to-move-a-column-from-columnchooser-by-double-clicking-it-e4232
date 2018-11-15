<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/ColumnChooserDoubleClick/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/ColumnChooserDoubleClick/MainWindow.xaml.vb))
* [ViewModel.cs](./CS/ViewModel.cs)
<!-- default file list end -->
# How to move a column from ColumnChooser by double-clicking it


<p>By default, ColumnChooser allows you to show and hide columns using CheckBoxes. This example demonstrates how to change a column's visibility by double-clicking it.</p>
<p>To accomplish this task, define a style for the ExtendedColumnChooserGridColumnHeader element, subscribe to its PreviewMouseDoubleClick event and change the GridColumn.Visible property value in this event handler.</p>

<br/>


