using System.Windows;

namespace G23W1401WPFDialog;

public partial class MainWindow : Window {
    public GundamViewModel vm = new GundamViewModel();

    public MainWindow() {
        InitializeComponent();

        this.DataContext = vm;
    }

    private void OnAdd(object sender, RoutedEventArgs e) {
        Gundam g = new Gundam();
        if (g.ShowDialog() != true)
            return;

        vm.Add(new GundamModel(g.MSName, g.MSModel, g.MSParty));
    }
}