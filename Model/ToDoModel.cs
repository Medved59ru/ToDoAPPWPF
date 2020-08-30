using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAPPWPF.Model
{
    class ToDoModel : INotifyPropertyChanged
    {
        private string _text;
        private bool _isDone;
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public bool IsDone
        {
            get { return _isDone; }
            set 
            { if (_isDone == value) // если значение не поменялось выходим
                {
                    return;
                }
            else
                {  //если поменялось перезаписываем 
                    _isDone = value;
                    OnPropertyChanged("IsDone"); //уведомляем подписчиков, что произошли изменения
                }
            }
        }

        public string Text
        {
            get { return _text; }
            set 
            {
                if (_text == value)
                {
                    return;
                }
                else
                {
                    _text = value;
                    OnPropertyChanged("Text");

                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged( string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));  //проверка на не null и вызов метода обработчика событий
           
        }
    }
}
