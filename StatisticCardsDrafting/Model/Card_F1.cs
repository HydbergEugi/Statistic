using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StatisticCardsDrafting
{
    public class Card_F1 : INotifyPropertyChanged
    {
        //реализация интерфейса
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        //-----объявление полей и свойств-----

        //вид документа
        public List<int> documentTypes;

        //номер документа
        public long documentNumber;

        //за кем числится преступление
        public string listedCrimeObject;

        //наименования военной прокуратуры, за которой числится преступление
        public string listedProsecutorOffice;

        //порядковый номер преступления в уголовном деле
        public int crimeNumber;

        //номер регистрации заявления
        public int stateRegNumber;

        //дата регистрации
        public DateTime registrationDate;

        //дата направления карточки прокурору
        public DateTime dateTransCard;




    }
}
