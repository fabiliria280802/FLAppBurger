using System.ComponentModel;

namespace FLAppBurger.ViewModels;

public class FLDateViewModel : INotifyPropertyChanged
{
    DateTime _dateTime;
    Timer _timer;
    public event PropertyChangingEventHandler PropertyChanged;
    public DateTime DateTime
    {
        get => _dateTime; 
        set
        {
            if(_dateTime != value)
            {
                _dateTime = value;
                OnPropertyChanged();
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DateTime)));
            }
            else 
            {
                
            }
        }
    }
    public FLDateViewModel()
    {
        this.DateTime = DateTime.Now;
        _timer = new Timer(new TimerCallback((s) => this.DateTime = DateTime.Now),null,TimeSpan.Zero,TimeSpan.FromSeconds(1));
        //
    }
    
    -FLDateViewModel() => _timer.Dispose();
    public void OnPropertyChanged([CallerMemberName] string name "");
}