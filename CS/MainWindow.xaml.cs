using System.Windows;
using DevExpress.Xpf.Grid;
using DevExpress.Mvvm.UI.Interactivity;
using DevExpress.Mvvm.DataAnnotations;
using System.Collections.ObjectModel;

namespace DXGridSample {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }
    public class Behavior : Behavior<ExtendedColumnChooserGridColumnHeader> {
        protected override void OnAttached() {
            base.OnAttached();
            AssociatedObject.PreviewMouseDoubleClick += AssociatedObject_PreviewMouseDoubleClick;
        }
        protected override void OnDetaching() {
            AssociatedObject.PreviewMouseDoubleClick -= AssociatedObject_PreviewMouseDoubleClick;
            base.OnDetaching();
        }
        private void AssociatedObject_PreviewMouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e) {
            GridColumn clickedColumn = (GridColumn)AssociatedObject.DataContext;
            if (((TableView)clickedColumn.View).VisibleColumns.Count == 1 && clickedColumn.Visible)
                return;
            clickedColumn.Visible = !clickedColumn.Visible;
        }
    }
}