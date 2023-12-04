using System.ComponentModel;

namespace G23W1401WPFDialog;
public class GundamViewModel : INotifyPropertyChanged {
    public event PropertyChangedEventHandler? PropertyChanged;

	private string _GundamList = "";

	public string GundamList {
		get { return _GundamList; }
	}

	public void Add(GundamModel model) {
		_GundamList = $"{model.Party}의 {model.Model} "
            + $"{model.Name}{(HasJongsung(model.Name) ? "이" : "가")} "
            + "추가되었습니다.\n"
            + _GundamList;

        OnPropertyChanged(nameof(GundamList));
	}

    // propName에 "GundamList"가 넘어감
    protected void OnPropertyChanged(string propName = "") {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }

    protected bool HasJongsung(string str) {
        if (str.Length < 1)
            return true;
        char last = str[str.Length - 1];
        return (last - 44032) % 28 != 0 ? true : false;
    }
}
