using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SliderView
{
    internal class ColorViewModel : INotifyPropertyChanged
    {
        public Color_ color;
        public ObservableCollection<Color_> Colors { get; set; }
        public ColorViewModel()
        {
            color = new Color_ { alpha = 0,blue = 0, red = 0, green = 0, name = ""};
            Colors = new ObservableCollection<Color_>
            {
            };
        }
        public double? colorAlpha
        {
            get { return color.alpha; }
            set
            {
                color.alpha = value;
                OnPropertyChanged("colorAlpha");
            }
        }
        public double? colorRed
        {
            get { return color.red; }
            set
            {
                color.red = value;
                OnPropertyChanged("colorRed");
            }
        }
        public double? colorGreen
        {
            get { return color.green; }
            set
            {
                color.green = value;
                OnPropertyChanged("colorGreen");
            }
        }
        public double? colorBlue
        {
            get { return color.blue; }
            set
            {
                color.blue = value;
                OnPropertyChanged("colorBlue");
            }
        }
        public string? Name
        {
            get { return color.name; }
            set
            {
                color.name = value;
                OnPropertyChanged("Name");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                this.PropertyChanged(this, e);
            }
        }
    }
}
