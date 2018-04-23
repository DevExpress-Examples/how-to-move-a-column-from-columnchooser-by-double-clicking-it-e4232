using System.Windows;
using DevExpress.Xpf.Grid;
using System.Collections.ObjectModel;
using System;

namespace DXGridSample {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }


    public class ColumnChooserDoubleClickHelper {
        public static bool GetIsEnabled(DependencyObject obj) {
            return (bool)obj.GetValue(IsEnabledProperty);
        }
        public static void SetIsEnabled(DependencyObject obj, bool value) {
            obj.SetValue(IsEnabledProperty, value);
        }
        public static readonly DependencyProperty IsEnabledProperty =
            DependencyProperty.RegisterAttached("IsEnabled", typeof(bool), typeof(ColumnChooserDoubleClickHelper), new PropertyMetadata(OnIsEnabledChanged));

        private static void OnIsEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            GridColumnHeader header = (GridColumnHeader)d;
            if ((bool)e.NewValue)
                header.PreviewMouseDoubleClick += ColumnChooserDoubleClickHelper_PreviewMouseDoubleClick;
            else
                header.PreviewMouseDoubleClick -= ColumnChooserDoubleClickHelper_PreviewMouseDoubleClick;
        }
        private static void ColumnChooserDoubleClickHelper_PreviewMouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e) {
            ((GridColumn)((GridColumnHeader)sender).DataContext).Visible = true;
        }
    }
}