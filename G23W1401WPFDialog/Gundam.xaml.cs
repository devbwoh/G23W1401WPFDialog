using System.Windows;

namespace G23W1401WPFDialog {
    public partial class Gundam : Window {
        public Gundam() {
            InitializeComponent();
            Name2.Focus();
        }

        //-----------------------------------
        // prop 탭 두 번
        //public int MyProperty { get; set; }
        //-----------------------------------

        //-----------------------------------
        // propfull 탭 두 번
        //private int myVar;

        //public int MyProperty {
        //    get { return myVar; }
        //    set { myVar = value; }
        //}
        //-----------------------------------

        // 현재 예제에서는 Control에 있는 Text 값 사용하므로,
        // Backing property는 사용하지 않음
        //private string _MSName;

        public string MSName {
            get { return Name2.Text; }
        }

        public string MSModel {
            get { return Model.Text; }
        }

        public string MSParty => Party.Text;

        private void OnOK(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(Name2.Text)) {
                MessageBox.Show(
                    "이름을 입력하십시오.", 
                    "입력 부족",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                return;
            }
            if (string.IsNullOrEmpty(Model.Text)) {
                MessageBox.Show(
                    "모델을 입력하십시오.",
                    "입력 부족",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                return;
            }
            if (string.IsNullOrEmpty(Party.Text)) {
                MessageBox.Show(
                    "소속을 입력하십시오.",
                    "입력 부족",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                return;
            }

            DialogResult = true;
        }

        private void OnCancel(object sender, RoutedEventArgs e) {
            DialogResult = false;
        }
    }
}
